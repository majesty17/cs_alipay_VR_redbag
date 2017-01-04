using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Reflection;
using System.Drawing.Drawing2D;

using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.UI;

namespace 支付宝VR红包
{
    public partial class Form1 : Form
    {
        [DllImport("Kernel32.dll", EntryPoint = "RtlMoveMemory", SetLastError = true)]
        private static extern void CopyMemory(IntPtr Dest, IntPtr src, int Length);                 // Marshal.Copy 居然没有从一个内存地址直接复制到另外一个内存的重载函数        

        private Bitmap Bmp=null,b;
        private IntPtr ImageCopyPointer, ImagePointer;
        private int DataLength;


        //
        Image<Bgr, Byte> inner = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|Png files (*.png)|*.png|All valid files (*.bmp/*.jpg/*.png)|*.bmp;*.jpg;*.png";
            openFileDialog.FilterIndex = 4;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                openFileToShow(openFileDialog.FileName);

                numericUpDown1_ValueChanged(sender, e);
            }

        }
        private void openFileToShow(string filename) {
            if (Bmp != null)
            {
                Bmp.Dispose();
                Marshal.FreeHGlobal(ImageCopyPointer);
            }
            try
            {
                Bmp = (Bitmap)Bitmap.FromFile(filename);
                BitmapData BmpData = new BitmapData();
                Bmp.LockBits(new Rectangle(0, 0, Bmp.Width, Bmp.Height), ImageLockMode.ReadWrite, Bmp.PixelFormat, BmpData);    // 用原始格式LockBits,得到图像在内存中真正地址，这个地址在图像的大小，色深等未发生变化时，每次Lock返回的Scan0值都是相同的。
                ImagePointer = BmpData.Scan0;                            //  记录图像在内存中的真正地址
                DataLength = BmpData.Stride * BmpData.Height;           //  记录整幅图像占用的内存大小
                ImageCopyPointer = Marshal.AllocHGlobal(DataLength);    //  直接用内存数据来做备份，AllocHGlobal在内部调用的是LocalAlloc函数
                CopyMemory(ImageCopyPointer, ImagePointer, DataLength); //  这里当然也可以用Bitmap的Clone方式来处理，但是我总认为直接处理内存数据比用对象的方式速度快。
                Bmp.UnlockBits(BmpData);
                //pictureBox1.Image = Bmp;
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        //调整高斯模糊半径
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (Bmp == null)
                return;
            b = new Bitmap(420, 420);
            Graphics g = Graphics.FromImage(b);
            // 插值算法的质量
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(Bmp, new Rectangle(0, 0, 420, 420),
                new Rectangle(330, 1071, 420, 420),
                GraphicsUnit.Pixel);

            for (int i = 0; i < 27; i++)
            {
                //对于一个8px高度的黑线，上下各取出4px的内容来填充
                g.DrawImage(Bmp, new Rectangle(0, 11 + 15 * i, 420, 4),
                new Rectangle(330 + 0, 1071 + 11 + 15 * i - 3, 420, 4),
                GraphicsUnit.Pixel);
                g.DrawImage(Bmp, new Rectangle(0, 11 + 15 * i + 4, 420, 4),
                new Rectangle(330 + 0, 1071 + 11 + 15 * i + 8, 420, 4),
                GraphicsUnit.Pixel);
            }
            Rectangle ret = new Rectangle(0, 0, 420, 420);
            double rad = Convert.ToDouble(numericUpDown1.Text);
            b.GaussianBlur(ref ret, (float)rad, checkBox1.Checked);
            pictureBox1.Image = b;
            g.Dispose();
            if (rad > 255) {
                numericUpDown1.Value = 255;
            }
        }
        //开关边界
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
        }



        //松开拖动
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string filename = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            if (filename.EndsWith(".jpg") || filename.EndsWith(".png"))
            {
                //openFileToShow(filename);
                //numericUpDown1_ValueChanged(sender, e);
                inPainting(filename);
            }
            else {
                MessageBox.Show("只允许使用图片文件！");
            }  
        }




        //拖拽进入
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }
        //打开图片
        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            Openfile.Filter = "All valid files (*.bmp/*.jpg/*.png)|*.bmp;*.jpg;*.png";
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                inPainting(Openfile.FileName);   
            } 
        }
        //取出inner图片
        private void inPainting(string filename) {

            //1，裁剪
            Image<Bgr, Byte> ori_pic = new Image<Bgr, byte>(filename);
            ori_pic.ROI = new Rectangle(Util.INNER_PIC_POS_X, Util.INNER_PIC_POS_Y, Util.INNER_PIC_WIDTH, Util.INNER_PIC_HEIGHT);
            inner = ori_pic.Copy();

            inPainting();

            
        }

       //处理图片，show
        private void inPainting() {
            if (inner == null)
                return;

            /*
            //灰度化inner
            Image<Gray, Byte> inner_gray = inner.Convert<Gray, Byte>();

            //二值化
            int thre = Convert.ToInt32(numericUpDown_binthre.Value);
            int blocksize = Convert.ToInt32(numericUpDown_blocksize.Value);
            thre = thre % 256;
            //Image<Bgr, Byte> mask = inner_gray.ThresholdBinary(new Bgr(thre, thre, thre), new Bgr(255, 255, 255));
            Image<Gray, Byte> mask = inner_gray.ThresholdAdaptive(new Gray(255), ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_GAUSSIAN_C, THRESH.CV_THRESH_BINARY_INV, blocksize, new Gray(thre));
            
            
            //需要加一个mask预处理机制
            */

            Image<Gray, Byte> mask = makeMask(inner.Size).Convert<Gray,Byte>();
            //3，inpaint
            double rad = Convert.ToDouble(numericUpDown_inpaintrad.Value);
            Image<Bgr, Byte> output = inner.InPaint(mask, rad);

            pictureBox1.Image = output.ToBitmap();
        }



        //二值化阈值
        private void numericUpDown_binthre_ValueChanged_1(object sender, EventArgs e)
        {
            inPainting();
        }
        // inpaint半径
        private void numericUpDown_inpaintrad_ValueChanged_1(object sender, EventArgs e)
        {
            inPainting();
        }
        //块大小
        private void numericUpDown_blocksize_ValueChanged(object sender, EventArgs e)
        {
            inPainting();
        }
        private void numericUpDown_mask_x_ValueChanged(object sender, EventArgs e)
        {
            inPainting();
        }

        private void numericUpDown_mask_y_ValueChanged(object sender, EventArgs e)
        {
            inPainting();
        }

        //生成mask并显示
        private void button_makemask_Click(object sender, EventArgs e)
        {

            Image<Bgr, Byte> mask_pic = new Image<Bgr, byte>(420, 420);

            for (int i = -10; i < 10; i++) {
                for(int j=-10;j<10;j++){
                    drawPatern(mask_pic, new Point(i*83+j*12, i*26+j*95));
                }
                
            }

            pictureBox1.Image = mask_pic.ToBitmap();
        }

        //返回一个合适的mask
        private Image<Bgr, Byte> makeMask(Size size) {
            Image<Bgr, Byte> mask = new Image<Bgr, byte>(size);
            int mask_x = Convert.ToInt32(numericUpDown_mask_x.Value);
            int mask_y = Convert.ToInt32(numericUpDown_mask_y.Value);
            for (int i = -10; i < 10; i++)
            {
                for (int j = -10; j < 10; j++)
                {
                    drawPatern(mask, new Point(mask_x + i * 83 + j * 12, mask_y + i * 26 + j * 95));
                }

            }
            return mask;
        }
        private void drawPatern(Image<Bgr, Byte> mask_pic, Point poi)
        {
            int c_x = poi.X;
            int c_y = poi.Y;

            
            Bgr pen = new Bgr(Color.White);
            //1，大点和小点

            mask_pic.Draw(new CircleF(new PointF(c_x, c_y), 14), pen, 0);
            mask_pic.Draw(new CircleF(new PointF(c_x - 33, c_y - 42), 10), pen, 0);   //左上
            mask_pic.Draw(new CircleF(new PointF(c_x + 21, c_y - 55), 10), pen, 0);   //右上
            mask_pic.Draw(new CircleF(new PointF(c_x - 51, c_y + 12), 10), pen, 0);   //左
            mask_pic.Draw(new CircleF(new PointF(c_x + 50, c_y - 15), 10), pen, 0);   //右
            mask_pic.Draw(new CircleF(new PointF(c_x - 22, c_y + 53), 10), pen, 0);   //左下
            mask_pic.Draw(new CircleF(new PointF(c_x + 32, c_y + 39), 10), pen, 0);   //右下
            //2，辐射线

            
            mask_pic.Draw(new LineSegment2DF(new PointF(c_x - 33, c_y - 42), new PointF(c_x, c_y)), pen, 4);
            mask_pic.Draw(new LineSegment2DF(new PointF(c_x + 21, c_y - 55), new PointF(c_x, c_y)), pen, 4);
            mask_pic.Draw(new LineSegment2DF(new PointF(c_x - 51, c_y + 12), new PointF(c_x, c_y)), pen, 4);
            mask_pic.Draw(new LineSegment2DF(new PointF(c_x + 51, c_y - 14), new PointF(c_x, c_y)), pen, 4);
            mask_pic.Draw(new LineSegment2DF(new PointF(c_x - 22, c_y + 53), new PointF(c_x, c_y)), pen, 4);
            mask_pic.Draw(new LineSegment2DF(new PointF(c_x + 32, c_y + 39), new PointF(c_x, c_y)), pen, 4);
            //3，连接线
            mask_pic.Draw(new LineSegment2DF(new PointF(c_x - 33, c_y - 42), new PointF(c_x - 51, c_y + 12)), pen, 4);
            mask_pic.Draw(new LineSegment2DF(new PointF(c_x + 21, c_y - 55), new PointF(c_x + 51, c_y - 14)), pen, 4);
            mask_pic.Draw(new LineSegment2DF(new PointF(c_x - 22, c_y + 53), new PointF(c_x + 32, c_y + 39)), pen, 4);
             
        }




        

    }
}

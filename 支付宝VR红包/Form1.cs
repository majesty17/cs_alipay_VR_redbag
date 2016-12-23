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


namespace 支付宝VR红包
{
    public partial class Form1 : Form
    {
        [DllImport("Kernel32.dll", EntryPoint = "RtlMoveMemory", SetLastError = true)]
        private static extern void CopyMemory(IntPtr Dest, IntPtr src, int Length);                 // Marshal.Copy 居然没有从一个内存地址直接复制到另外一个内存的重载函数        

        private Bitmap Bmp=null,b;
        private IntPtr ImageCopyPointer, ImagePointer;
        private int DataLength;



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
                if (Bmp != null)
                {
                    Bmp.Dispose();
                    Marshal.FreeHGlobal(ImageCopyPointer);
                }
                try
                {
                    Bmp = (Bitmap)Bitmap.FromFile(openFileDialog.FileName);
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

                numericUpDown1_ValueChanged(sender, e);
            }

        }

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
            b.GaussianBlur(ref ret, (float)rad, false);
            pictureBox1.Image = b;
            g.Dispose();
            if (rad > 255) {
                numericUpDown1.Value = 255;
            }
        }
    }
}

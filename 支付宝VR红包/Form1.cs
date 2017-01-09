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

        //
        Image<Bgr, Byte> inner = null;

        public Form1()
        {
            InitializeComponent();
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
        private void button_open_Click(object sender, EventArgs e)
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
            //直接show原图
            if (checkBox_ori.Checked == true)
            {
                pictureBox1.Image = inner.ToBitmap();
                return;
            }

            

            
            //1,灰度化
            Image<Gray, Byte> inner_gray = inner.Convert<Gray, Byte>();

            //2,二值化
            int thre = Convert.ToInt32(numericUpDown_binthre.Value);
            int blocksize = Convert.ToInt32(numericUpDown_blocksize.Value);
            thre = thre % 256;
            ADAPTIVE_THRESHOLD_TYPE thre_type = ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_GAUSSIAN_C;
            //Image<Bgr, Byte> mask = inner_gray.ThresholdBinary(new Bgr(thre, thre, thre), new Bgr(255, 255, 255));
            if (radioButton_mean.Checked == true) {
                thre_type = ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_MEAN_C;
            }
            Image<Gray, Byte> mask = inner_gray.ThresholdAdaptive(new Gray(255),
                thre_type, 
                THRESH.CV_THRESH_BINARY_INV, blocksize, new Gray(thre));
            
            
            //需要加一个mask预处理机制
           
            //3，inpaint
            if (checkBox_onlymask.Checked == true)
            {
                pictureBox1.Image = mask.ToBitmap();
            }
            else {
                double rad = Convert.ToDouble(numericUpDown_inpaintrad.Value);
                Image<Bgr, Byte> output = inner.InPaint(mask, rad);

                pictureBox1.Image = output.ToBitmap();
            }
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
        //是否仅显示mask
        private void checkBox_onlymask_CheckedChanged(object sender, EventArgs e)
        {
            inPainting();
        }
        //自适应阈值化算法
        private void radioButton_gauss_CheckedChanged(object sender, EventArgs e)
        {
            inPainting();
        }
        //只显示原图
        private void checkBox_ori_CheckedChanged(object sender, EventArgs e)
        {
            inPainting();
        }






    }
}

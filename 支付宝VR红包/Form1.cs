using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 支付宝VR红包
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                
                string filename=openFileDialog1.FileName;
                System.Drawing.Image initImage = System.Drawing.Image.FromFile(filename);

                //新建一个bmp图片
                System.Drawing.Image bitmap = new System.Drawing.Bitmap(420, 420);
                //新建一个画板
                Graphics g = System.Drawing.Graphics.FromImage(bitmap);
                //设置高质量插值法
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                //设置高质量,低速度呈现平滑程度
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //清空画布并以透明背景色填充
                g.Clear(Color.Transparent);
                //在指定位置并且按指定大小绘制原图片的指定部分
                g.DrawImage(initImage, new Rectangle(0, 0, 420, 420),
                    new Rectangle(330, 1071, 420, 420),
                    GraphicsUnit.Pixel);



                for (int i = 0; i < 27; i++) {
                    //g.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 11 + 15 * i, 420, 8));
                    g.DrawImage(bitmap, new Rectangle(0, 11 + 15 * i, 420, 4),
                    new Rectangle(0, 11 + 15 * i - 3, 420, 4),
                    GraphicsUnit.Pixel);
                    g.DrawImage(bitmap, new Rectangle(0, 11 + 15 * i+4, 420, 4),
                    new Rectangle(0, 11 + 15 * i +8, 420, 4),
                    GraphicsUnit.Pixel);
                }

                try
                {
                    //以jpg格式保存缩略图
                    bitmap.Save(@"C:\1.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    pictureBox1.Image = Image.FromFile(@"C:\1.jpg");
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    initImage.Dispose();
                    bitmap.Dispose();
                    g.Dispose();
                }

            }
        }
    }
}

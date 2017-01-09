namespace 支付宝VR红包
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_mean = new System.Windows.Forms.RadioButton();
            this.radioButton_gauss = new System.Windows.Forms.RadioButton();
            this.checkBox_onlymask = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_blocksize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_binthre = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_inpaintrad = new System.Windows.Forms.NumericUpDown();
            this.button_open = new System.Windows.Forms.Button();
            this.checkBox_ori = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_blocksize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_binthre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inpaintrad)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(287, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 536);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_ori);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.checkBox_onlymask);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown_blocksize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown_binthre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown_inpaintrad);
            this.groupBox1.Controls.Add(this.button_open);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 331);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inpaint参数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "自适应阈值算法";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_mean);
            this.panel1.Controls.Add(this.radioButton_gauss);
            this.panel1.Location = new System.Drawing.Point(15, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 39);
            this.panel1.TabIndex = 19;
            // 
            // radioButton_mean
            // 
            this.radioButton_mean.AutoSize = true;
            this.radioButton_mean.Location = new System.Drawing.Point(154, 11);
            this.radioButton_mean.Name = "radioButton_mean";
            this.radioButton_mean.Size = new System.Drawing.Size(47, 16);
            this.radioButton_mean.TabIndex = 1;
            this.radioButton_mean.Text = "MEAN";
            this.radioButton_mean.UseVisualStyleBackColor = true;
            this.radioButton_mean.CheckedChanged += new System.EventHandler(this.radioButton_gauss_CheckedChanged);
            // 
            // radioButton_gauss
            // 
            this.radioButton_gauss.AutoSize = true;
            this.radioButton_gauss.Checked = true;
            this.radioButton_gauss.Location = new System.Drawing.Point(41, 11);
            this.radioButton_gauss.Name = "radioButton_gauss";
            this.radioButton_gauss.Size = new System.Drawing.Size(71, 16);
            this.radioButton_gauss.TabIndex = 0;
            this.radioButton_gauss.TabStop = true;
            this.radioButton_gauss.Text = "GAUSSIAN";
            this.radioButton_gauss.UseVisualStyleBackColor = true;
            this.radioButton_gauss.CheckedChanged += new System.EventHandler(this.radioButton_gauss_CheckedChanged);
            // 
            // checkBox_onlymask
            // 
            this.checkBox_onlymask.AutoSize = true;
            this.checkBox_onlymask.Location = new System.Drawing.Point(15, 234);
            this.checkBox_onlymask.Name = "checkBox_onlymask";
            this.checkBox_onlymask.Size = new System.Drawing.Size(84, 16);
            this.checkBox_onlymask.TabIndex = 18;
            this.checkBox_onlymask.Text = "仅显示mask";
            this.checkBox_onlymask.UseVisualStyleBackColor = true;
            this.checkBox_onlymask.CheckedChanged += new System.EventHandler(this.checkBox_onlymask_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "block(2和200之间的奇数)";
            // 
            // numericUpDown_blocksize
            // 
            this.numericUpDown_blocksize.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_blocksize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_blocksize.Location = new System.Drawing.Point(179, 106);
            this.numericUpDown_blocksize.Maximum = new decimal(new int[] {
            199,
            0,
            0,
            0});
            this.numericUpDown_blocksize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_blocksize.Name = "numericUpDown_blocksize";
            this.numericUpDown_blocksize.ReadOnly = true;
            this.numericUpDown_blocksize.Size = new System.Drawing.Size(75, 23);
            this.numericUpDown_blocksize.TabIndex = 16;
            this.numericUpDown_blocksize.Value = new decimal(new int[] {
            181,
            0,
            0,
            0});
            this.numericUpDown_blocksize.ValueChanged += new System.EventHandler(this.numericUpDown_blocksize_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "二值化阈值(0~255)";
            // 
            // numericUpDown_binthre
            // 
            this.numericUpDown_binthre.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_binthre.Location = new System.Drawing.Point(179, 71);
            this.numericUpDown_binthre.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_binthre.Name = "numericUpDown_binthre";
            this.numericUpDown_binthre.ReadOnly = true;
            this.numericUpDown_binthre.Size = new System.Drawing.Size(75, 23);
            this.numericUpDown_binthre.TabIndex = 14;
            this.numericUpDown_binthre.ValueChanged += new System.EventHandler(this.numericUpDown_binthre_ValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "InPaint半径";
            // 
            // numericUpDown_inpaintrad
            // 
            this.numericUpDown_inpaintrad.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_inpaintrad.Location = new System.Drawing.Point(179, 144);
            this.numericUpDown_inpaintrad.Name = "numericUpDown_inpaintrad";
            this.numericUpDown_inpaintrad.ReadOnly = true;
            this.numericUpDown_inpaintrad.Size = new System.Drawing.Size(75, 23);
            this.numericUpDown_inpaintrad.TabIndex = 12;
            this.numericUpDown_inpaintrad.Value = new decimal(new int[] {
            40,
            0,
            0,
            65536});
            this.numericUpDown_inpaintrad.ValueChanged += new System.EventHandler(this.numericUpDown_inpaintrad_ValueChanged_1);
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(15, 31);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 23);
            this.button_open.TabIndex = 11;
            this.button_open.Text = "打开";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // checkBox_ori
            // 
            this.checkBox_ori.AutoSize = true;
            this.checkBox_ori.Location = new System.Drawing.Point(15, 256);
            this.checkBox_ori.Name = "checkBox_ori";
            this.checkBox_ori.Size = new System.Drawing.Size(72, 16);
            this.checkBox_ori.TabIndex = 21;
            this.checkBox_ori.Text = "显示原图";
            this.checkBox_ori.UseVisualStyleBackColor = true;
            this.checkBox_ori.CheckedChanged += new System.EventHandler(this.checkBox_ori_CheckedChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 536);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_blocksize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_binthre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inpaintrad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_binthre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_inpaintrad;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_blocksize;
        private System.Windows.Forms.CheckBox checkBox_onlymask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_mean;
        private System.Windows.Forms.RadioButton radioButton_gauss;
        private System.Windows.Forms.CheckBox checkBox_ori;
    }
}


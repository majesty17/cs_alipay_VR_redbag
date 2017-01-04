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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_blocksize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_binthre = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_inpaintrad = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button_makemask = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_mask_x = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_mask_y = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_blocksize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_binthre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inpaintrad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mask_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mask_y)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "打开";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "高斯模糊半径";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown1.Location = new System.Drawing.Point(95, 60);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(75, 23);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            65536});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(176, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "边界扩展";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown_mask_y);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown_mask_x);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown_blocksize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown_binthre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown_inpaintrad);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 255);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inpaint参数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "block大小";
            // 
            // numericUpDown_blocksize
            // 
            this.numericUpDown_blocksize.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_blocksize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_blocksize.Location = new System.Drawing.Point(122, 106);
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
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "二值化阈值";
            // 
            // numericUpDown_binthre
            // 
            this.numericUpDown_binthre.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_binthre.Location = new System.Drawing.Point(122, 71);
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
            this.label2.Location = new System.Drawing.Point(13, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "InPaint半径";
            // 
            // numericUpDown_inpaintrad
            // 
            this.numericUpDown_inpaintrad.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_inpaintrad.Location = new System.Drawing.Point(122, 215);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "新打开";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button_makemask
            // 
            this.button_makemask.Location = new System.Drawing.Point(14, 440);
            this.button_makemask.Name = "button_makemask";
            this.button_makemask.Size = new System.Drawing.Size(75, 23);
            this.button_makemask.TabIndex = 12;
            this.button_makemask.Text = "生成mask";
            this.button_makemask.UseVisualStyleBackColor = true;
            this.button_makemask.Click += new System.EventHandler(this.button_makemask_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "mask偏移x";
            // 
            // numericUpDown_mask_x
            // 
            this.numericUpDown_mask_x.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_mask_x.Location = new System.Drawing.Point(122, 141);
            this.numericUpDown_mask_x.Name = "numericUpDown_mask_x";
            this.numericUpDown_mask_x.ReadOnly = true;
            this.numericUpDown_mask_x.Size = new System.Drawing.Size(75, 23);
            this.numericUpDown_mask_x.TabIndex = 18;
            this.numericUpDown_mask_x.Value = new decimal(new int[] {
            40,
            0,
            0,
            65536});
            this.numericUpDown_mask_x.ValueChanged += new System.EventHandler(this.numericUpDown_mask_x_ValueChanged);
            // 
            // numericUpDown_mask_y
            // 
            this.numericUpDown_mask_y.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_mask_y.Location = new System.Drawing.Point(122, 171);
            this.numericUpDown_mask_y.Name = "numericUpDown_mask_y";
            this.numericUpDown_mask_y.ReadOnly = true;
            this.numericUpDown_mask_y.Size = new System.Drawing.Size(75, 23);
            this.numericUpDown_mask_y.TabIndex = 20;
            this.numericUpDown_mask_y.Value = new decimal(new int[] {
            40,
            0,
            0,
            65536});
            this.numericUpDown_mask_y.ValueChanged += new System.EventHandler(this.numericUpDown_mask_y_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "mask偏移y";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 536);
            this.Controls.Add(this.button_makemask);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_blocksize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_binthre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inpaintrad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mask_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mask_y)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_binthre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_inpaintrad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_blocksize;
        private System.Windows.Forms.Button button_makemask;
        private System.Windows.Forms.NumericUpDown numericUpDown_mask_y;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_mask_x;
        private System.Windows.Forms.Label label6;
    }
}


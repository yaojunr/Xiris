namespace XirisSDKtest1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gobalShutter = new System.Windows.Forms.RadioButton();
            this.rollShutter = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pixelDepth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.triggerMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.aoiBottom = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.aoiTop = new System.Windows.Forms.NumericUpDown();
            this.aoiSet = new System.Windows.Forms.Button();
            this.aoiReset = new System.Windows.Forms.Button();
            this.aoiLeft = new System.Windows.Forms.NumericUpDown();
            this.aoiRight = new System.Windows.Forms.NumericUpDown();
            this.frameRate = new System.Windows.Forms.NumericUpDown();
            this.cameraReady = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoiBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoiTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoiLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoiRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameRate)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1040, 593);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(8, 8);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "快门模式";
            // 
            // gobalShutter
            // 
            this.gobalShutter.AutoSize = true;
            this.gobalShutter.Location = new System.Drawing.Point(8, 68);
            this.gobalShutter.Name = "gobalShutter";
            this.gobalShutter.Size = new System.Drawing.Size(47, 16);
            this.gobalShutter.TabIndex = 3;
            this.gobalShutter.TabStop = true;
            this.gobalShutter.Text = "全局";
            this.gobalShutter.UseVisualStyleBackColor = true;
            this.gobalShutter.CheckedChanged += new System.EventHandler(this.gobalShutter_CheckedChanged);
            // 
            // rollShutter
            // 
            this.rollShutter.AutoSize = true;
            this.rollShutter.Location = new System.Drawing.Point(8, 90);
            this.rollShutter.Name = "rollShutter";
            this.rollShutter.Size = new System.Drawing.Size(47, 16);
            this.rollShutter.TabIndex = 4;
            this.rollShutter.TabStop = true;
            this.rollShutter.Text = "卷帘";
            this.rollShutter.UseVisualStyleBackColor = true;
            this.rollShutter.CheckedChanged += new System.EventHandler(this.rollShutter_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "帧频率（1-55FPS）";
            // 
            // pixelDepth
            // 
            this.pixelDepth.FormattingEnabled = true;
            this.pixelDepth.Items.AddRange(new object[] {
            "8 bits",
            "12 bits"});
            this.pixelDepth.Location = new System.Drawing.Point(8, 208);
            this.pixelDepth.Name = "pixelDepth";
            this.pixelDepth.Size = new System.Drawing.Size(121, 20);
            this.pixelDepth.TabIndex = 8;
            this.pixelDepth.SelectedIndexChanged += new System.EventHandler(this.pixelDepth_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "像素位深";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "触发模式";
            // 
            // triggerMode
            // 
            this.triggerMode.FormattingEnabled = true;
            this.triggerMode.Items.AddRange(new object[] {
            "自由运行",
            "固定曝光",
            "脉冲曝光"});
            this.triggerMode.Location = new System.Drawing.Point(8, 282);
            this.triggerMode.Name = "triggerMode";
            this.triggerMode.Size = new System.Drawing.Size(121, 20);
            this.triggerMode.TabIndex = 10;
            this.triggerMode.SelectedIndexChanged += new System.EventHandler(this.triggerMode_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "AOI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "高";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "右";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "低";
            // 
            // aoiBottom
            // 
            this.aoiBottom.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.aoiBottom.Location = new System.Drawing.Point(52, 461);
            this.aoiBottom.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.aoiBottom.Name = "aoiBottom";
            this.aoiBottom.Size = new System.Drawing.Size(48, 21);
            this.aoiBottom.TabIndex = 17;
            this.aoiBottom.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "左";
            // 
            // aoiTop
            // 
            this.aoiTop.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.aoiTop.Location = new System.Drawing.Point(52, 363);
            this.aoiTop.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.aoiTop.Name = "aoiTop";
            this.aoiTop.Size = new System.Drawing.Size(48, 21);
            this.aoiTop.TabIndex = 22;
            // 
            // aoiSet
            // 
            this.aoiSet.Location = new System.Drawing.Point(8, 504);
            this.aoiSet.Name = "aoiSet";
            this.aoiSet.Size = new System.Drawing.Size(54, 23);
            this.aoiSet.TabIndex = 23;
            this.aoiSet.Text = "Set";
            this.aoiSet.UseVisualStyleBackColor = true;
            this.aoiSet.Click += new System.EventHandler(this.aoiSet_Click);
            // 
            // aoiReset
            // 
            this.aoiReset.Location = new System.Drawing.Point(75, 504);
            this.aoiReset.Name = "aoiReset";
            this.aoiReset.Size = new System.Drawing.Size(54, 23);
            this.aoiReset.TabIndex = 24;
            this.aoiReset.Text = "Reset";
            this.aoiReset.UseVisualStyleBackColor = true;
            this.aoiReset.Click += new System.EventHandler(this.aoiReset_Click);
            // 
            // aoiLeft
            // 
            this.aoiLeft.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.aoiLeft.Location = new System.Drawing.Point(11, 413);
            this.aoiLeft.Maximum = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            this.aoiLeft.Name = "aoiLeft";
            this.aoiLeft.Size = new System.Drawing.Size(48, 21);
            this.aoiLeft.TabIndex = 25;
            // 
            // aoiRight
            // 
            this.aoiRight.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.aoiRight.Location = new System.Drawing.Point(101, 413);
            this.aoiRight.Maximum = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            this.aoiRight.Name = "aoiRight";
            this.aoiRight.Size = new System.Drawing.Size(48, 21);
            this.aoiRight.TabIndex = 26;
            this.aoiRight.Value = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            // 
            // frameRate
            // 
            this.frameRate.Location = new System.Drawing.Point(14, 149);
            this.frameRate.Maximum = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.frameRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frameRate.Name = "frameRate";
            this.frameRate.Size = new System.Drawing.Size(51, 21);
            this.frameRate.TabIndex = 27;
            this.frameRate.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.frameRate.ValueChanged += new System.EventHandler(this.frameRate_ValueChanged);
            // 
            // cameraReady
            // 
            this.cameraReady.AutoSize = true;
            this.cameraReady.Location = new System.Drawing.Point(116, 13);
            this.cameraReady.Name = "cameraReady";
            this.cameraReady.Size = new System.Drawing.Size(0, 12);
            this.cameraReady.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 592);
            this.Controls.Add(this.cameraReady);
            this.Controls.Add(this.frameRate);
            this.Controls.Add(this.aoiRight);
            this.Controls.Add(this.aoiLeft);
            this.Controls.Add(this.aoiReset);
            this.Controls.Add(this.aoiSet);
            this.Controls.Add(this.aoiTop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.aoiBottom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.triggerMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pixelDepth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rollShutter);
            this.Controls.Add(this.gobalShutter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoiBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoiTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoiLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoiRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton gobalShutter;
        private System.Windows.Forms.RadioButton rollShutter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pixelDepth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox triggerMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown aoiBottom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown aoiTop;
        private System.Windows.Forms.Button aoiSet;
        private System.Windows.Forms.Button aoiReset;
        private System.Windows.Forms.NumericUpDown aoiLeft;
        private System.Windows.Forms.NumericUpDown aoiRight;
        private System.Windows.Forms.NumericUpDown frameRate;
        private System.Windows.Forms.Label cameraReady;
    }
}


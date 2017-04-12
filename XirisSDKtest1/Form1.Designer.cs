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
            this.shutterModeText = new System.Windows.Forms.Label();
            this.gobalShutter = new System.Windows.Forms.RadioButton();
            this.rollShutter = new System.Windows.Forms.RadioButton();
            this.frameRateText = new System.Windows.Forms.Label();
            this.pixelDepth = new System.Windows.Forms.ComboBox();
            this.pixelDepthText = new System.Windows.Forms.Label();
            this.triggerModeText = new System.Windows.Forms.Label();
            this.triggerMode = new System.Windows.Forms.ComboBox();
            this.AOIText = new System.Windows.Forms.Label();
            this.aoiTopText = new System.Windows.Forms.Label();
            this.aoiRightText = new System.Windows.Forms.Label();
            this.aoiBottomText = new System.Windows.Forms.Label();
            this.aoiBottom = new System.Windows.Forms.NumericUpDown();
            this.aoiLeftText = new System.Windows.Forms.Label();
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
            // shutterModeText
            // 
            this.shutterModeText.AutoSize = true;
            this.shutterModeText.Location = new System.Drawing.Point(12, 50);
            this.shutterModeText.Name = "shutterModeText";
            this.shutterModeText.Size = new System.Drawing.Size(53, 12);
            this.shutterModeText.TabIndex = 2;
            this.shutterModeText.Text = "快门模式";
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
            // frameRateText
            // 
            this.frameRateText.AutoSize = true;
            this.frameRateText.Location = new System.Drawing.Point(9, 125);
            this.frameRateText.Name = "frameRateText";
            this.frameRateText.Size = new System.Drawing.Size(107, 12);
            this.frameRateText.TabIndex = 7;
            this.frameRateText.Text = "帧频率（1-55FPS）";
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
            // pixelDepthText
            // 
            this.pixelDepthText.AutoSize = true;
            this.pixelDepthText.Location = new System.Drawing.Point(9, 193);
            this.pixelDepthText.Name = "pixelDepthText";
            this.pixelDepthText.Size = new System.Drawing.Size(53, 12);
            this.pixelDepthText.TabIndex = 9;
            this.pixelDepthText.Text = "像素位深";
            // 
            // triggerModeText
            // 
            this.triggerModeText.AutoSize = true;
            this.triggerModeText.Location = new System.Drawing.Point(9, 267);
            this.triggerModeText.Name = "triggerModeText";
            this.triggerModeText.Size = new System.Drawing.Size(53, 12);
            this.triggerModeText.TabIndex = 11;
            this.triggerModeText.Text = "触发模式";
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
            // AOIText
            // 
            this.AOIText.AutoSize = true;
            this.AOIText.Location = new System.Drawing.Point(11, 343);
            this.AOIText.Name = "AOIText";
            this.AOIText.Size = new System.Drawing.Size(23, 12);
            this.AOIText.TabIndex = 12;
            this.AOIText.Text = "AOI";
            // 
            // aoiTopText
            // 
            this.aoiTopText.AutoSize = true;
            this.aoiTopText.Location = new System.Drawing.Point(65, 343);
            this.aoiTopText.Name = "aoiTopText";
            this.aoiTopText.Size = new System.Drawing.Size(17, 12);
            this.aoiTopText.TabIndex = 14;
            this.aoiTopText.Text = "高";
            // 
            // aoiRightText
            // 
            this.aoiRightText.AutoSize = true;
            this.aoiRightText.Location = new System.Drawing.Point(116, 389);
            this.aoiRightText.Name = "aoiRightText";
            this.aoiRightText.Size = new System.Drawing.Size(17, 12);
            this.aoiRightText.TabIndex = 16;
            this.aoiRightText.Text = "右";
            // 
            // aoiBottomText
            // 
            this.aoiBottomText.AutoSize = true;
            this.aoiBottomText.Location = new System.Drawing.Point(65, 441);
            this.aoiBottomText.Name = "aoiBottomText";
            this.aoiBottomText.Size = new System.Drawing.Size(17, 12);
            this.aoiBottomText.TabIndex = 18;
            this.aoiBottomText.Text = "低";
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
            // aoiLeftText
            // 
            this.aoiLeftText.AutoSize = true;
            this.aoiLeftText.Location = new System.Drawing.Point(17, 389);
            this.aoiLeftText.Name = "aoiLeftText";
            this.aoiLeftText.Size = new System.Drawing.Size(17, 12);
            this.aoiLeftText.TabIndex = 20;
            this.aoiLeftText.Text = "左";
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
            this.cameraReady.Font = new System.Drawing.Font("SimSun", 12F);
            this.cameraReady.ForeColor = System.Drawing.Color.Red;
            this.cameraReady.Location = new System.Drawing.Point(16, 557);
            this.cameraReady.Name = "cameraReady";
            this.cameraReady.Size = new System.Drawing.Size(136, 16);
            this.cameraReady.TabIndex = 28;
            this.cameraReady.Text = "camera not ready";
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
            this.Controls.Add(this.aoiLeftText);
            this.Controls.Add(this.aoiBottomText);
            this.Controls.Add(this.aoiBottom);
            this.Controls.Add(this.aoiRightText);
            this.Controls.Add(this.aoiTopText);
            this.Controls.Add(this.AOIText);
            this.Controls.Add(this.triggerModeText);
            this.Controls.Add(this.triggerMode);
            this.Controls.Add(this.pixelDepthText);
            this.Controls.Add(this.pixelDepth);
            this.Controls.Add(this.frameRateText);
            this.Controls.Add(this.rollShutter);
            this.Controls.Add(this.gobalShutter);
            this.Controls.Add(this.shutterModeText);
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
        private System.Windows.Forms.Label shutterModeText;
        private System.Windows.Forms.RadioButton gobalShutter;
        private System.Windows.Forms.RadioButton rollShutter;
        private System.Windows.Forms.Label frameRateText;
        private System.Windows.Forms.ComboBox pixelDepth;
        private System.Windows.Forms.Label pixelDepthText;
        private System.Windows.Forms.Label triggerModeText;
        private System.Windows.Forms.ComboBox triggerMode;
        private System.Windows.Forms.Label AOIText;
        private System.Windows.Forms.Label aoiTopText;
        private System.Windows.Forms.Label aoiRightText;
        private System.Windows.Forms.Label aoiBottomText;
        private System.Windows.Forms.NumericUpDown aoiBottom;
        private System.Windows.Forms.Label aoiLeftText;
        private System.Windows.Forms.NumericUpDown aoiTop;
        private System.Windows.Forms.Button aoiSet;
        private System.Windows.Forms.Button aoiReset;
        private System.Windows.Forms.NumericUpDown aoiLeft;
        private System.Windows.Forms.NumericUpDown aoiRight;
        private System.Windows.Forms.NumericUpDown frameRate;
        private System.Windows.Forms.Label cameraReady;
    }
}


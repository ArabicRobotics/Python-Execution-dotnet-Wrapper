namespace NAO.NET
{
    partial class frmPicture
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
            this.imgCamera = new System.Windows.Forms.PictureBox();
            this.cameraStatusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.btnGetImage = new System.Windows.Forms.Button();
            this.lstCamera = new System.Windows.Forms.ComboBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).BeginInit();
            this.cameraStatusBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgCamera
            // 
            this.imgCamera.Location = new System.Drawing.Point(12, 185);
            this.imgCamera.Name = "imgCamera";
            this.imgCamera.Size = new System.Drawing.Size(369, 301);
            this.imgCamera.TabIndex = 0;
            this.imgCamera.TabStop = false;
            // 
            // cameraStatusBar
            // 
            this.cameraStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.cameraStatusBar.Location = new System.Drawing.Point(0, 551);
            this.cameraStatusBar.Name = "cameraStatusBar";
            this.cameraStatusBar.Size = new System.Drawing.Size(792, 22);
            this.cameraStatusBar.TabIndex = 1;
            this.cameraStatusBar.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // btnGetImage
            // 
            this.btnGetImage.Location = new System.Drawing.Point(196, 113);
            this.btnGetImage.Name = "btnGetImage";
            this.btnGetImage.Size = new System.Drawing.Size(145, 45);
            this.btnGetImage.TabIndex = 2;
            this.btnGetImage.Text = "Get Image";
            this.btnGetImage.UseVisualStyleBackColor = true;
            this.btnGetImage.Click += new System.EventHandler(this.btnGetImage_Click);
            // 
            // lstCamera
            // 
            this.lstCamera.AllowDrop = true;
            this.lstCamera.FormattingEnabled = true;
            this.lstCamera.Items.AddRange(new object[] {
            "Top",
            "Buttom"});
            this.lstCamera.Location = new System.Drawing.Point(196, 31);
            this.lstCamera.Name = "lstCamera";
            this.lstCamera.Size = new System.Drawing.Size(145, 21);
            this.lstCamera.TabIndex = 3;
            this.lstCamera.SelectedIndexChanged += new System.EventHandler(this.lstCamera_SelectedIndexChanged);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(196, 69);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(145, 20);
            this.txtFileName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Camera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "File Name EX:   Image.PNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstCamera);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGetImage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 167);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera Setting.";
            // 
            // frmPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cameraStatusBar);
            this.Controls.Add(this.imgCamera);
            this.Name = "frmPicture";
            this.Text = "frmPicture";
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).EndInit();
            this.cameraStatusBar.ResumeLayout(false);
            this.cameraStatusBar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCamera;
        private System.Windows.Forms.StatusStrip cameraStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button btnGetImage;
        private System.Windows.Forms.ComboBox lstCamera;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
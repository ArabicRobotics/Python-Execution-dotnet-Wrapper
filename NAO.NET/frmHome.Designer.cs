namespace NAO.NET
{
    partial class frmHome
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
            this.btnMovement = new System.Windows.Forms.Button();
            this.btnCamera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMovement
            // 
            this.btnMovement.Location = new System.Drawing.Point(13, 13);
            this.btnMovement.Name = "btnMovement";
            this.btnMovement.Size = new System.Drawing.Size(91, 23);
            this.btnMovement.TabIndex = 0;
            this.btnMovement.Text = "Movement";
            this.btnMovement.UseVisualStyleBackColor = true;
            this.btnMovement.Click += new System.EventHandler(this.btnMovement_Click);
            // 
            // btnCamera
            // 
            this.btnCamera.Location = new System.Drawing.Point(110, 13);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(95, 23);
            this.btnCamera.TabIndex = 1;
            this.btnCamera.Text = "Camera";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 486);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.btnMovement);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMovement;
        private System.Windows.Forms.Button btnCamera;
    }
}
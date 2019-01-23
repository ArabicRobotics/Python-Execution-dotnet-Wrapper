namespace NAO.NET
{
    partial class frmMove
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
            this.tabController = new System.Windows.Forms.TabControl();
            this.tabHead = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCurrentY = new System.Windows.Forms.TextBox();
            this.txtCurrentX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetCurrentValues = new System.Windows.Forms.Button();
            this.txtHeadAngleY = new System.Windows.Forms.TextBox();
            this.txtHeadAngleX = new System.Windows.Forms.TextBox();
            this.lblMoveHeadResult = new System.Windows.Forms.Label();
            this.progMoveHead = new System.Windows.Forms.ProgressBar();
            this.btnMoveHead = new System.Windows.Forms.Button();
            this.lblHeadY = new System.Windows.Forms.Label();
            this.lblHeadX = new System.Windows.Forms.Label();
            this.tabHands = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRightHandValue = new System.Windows.Forms.TextBox();
            this.txtLeftHandValue = new System.Windows.Forms.TextBox();
            this.btnRefreshHandsValues = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRightHandAngle = new System.Windows.Forms.TextBox();
            this.txtLeftHandAngle = new System.Windows.Forms.TextBox();
            this.chkRightHandMove = new System.Windows.Forms.CheckBox();
            this.chkLeftHandMove = new System.Windows.Forms.CheckBox();
            this.lblMoveHandsResult = new System.Windows.Forms.Label();
            this.progMoveHands = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.movementStatusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tabController.SuspendLayout();
            this.tabHead.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabHands.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.movementStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabHead);
            this.tabController.Controls.Add(this.tabHands);
            this.tabController.Location = new System.Drawing.Point(24, 12);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(768, 520);
            this.tabController.TabIndex = 1;
            // 
            // tabHead
            // 
            this.tabHead.Controls.Add(this.groupBox1);
            this.tabHead.Location = new System.Drawing.Point(4, 22);
            this.tabHead.Name = "tabHead";
            this.tabHead.Padding = new System.Windows.Forms.Padding(3);
            this.tabHead.Size = new System.Drawing.Size(760, 494);
            this.tabHead.TabIndex = 0;
            this.tabHead.Text = "Head";
            this.tabHead.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCurrentY);
            this.groupBox1.Controls.Add(this.txtCurrentX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGetCurrentValues);
            this.groupBox1.Controls.Add(this.txtHeadAngleY);
            this.groupBox1.Controls.Add(this.txtHeadAngleX);
            this.groupBox1.Controls.Add(this.lblMoveHeadResult);
            this.groupBox1.Controls.Add(this.progMoveHead);
            this.groupBox1.Controls.Add(this.btnMoveHead);
            this.groupBox1.Controls.Add(this.lblHeadY);
            this.groupBox1.Controls.Add(this.lblHeadX);
            this.groupBox1.Location = new System.Drawing.Point(248, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 189);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position";
            // 
            // txtCurrentY
            // 
            this.txtCurrentY.Location = new System.Drawing.Point(300, 55);
            this.txtCurrentY.Name = "txtCurrentY";
            this.txtCurrentY.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentY.TabIndex = 12;
            // 
            // txtCurrentX
            // 
            this.txtCurrentX.Location = new System.Drawing.Point(300, 20);
            this.txtCurrentX.Name = "txtCurrentX";
            this.txtCurrentX.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentX.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "current Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "current X";
            // 
            // btnGetCurrentValues
            // 
            this.btnGetCurrentValues.Location = new System.Drawing.Point(269, 98);
            this.btnGetCurrentValues.Name = "btnGetCurrentValues";
            this.btnGetCurrentValues.Size = new System.Drawing.Size(147, 23);
            this.btnGetCurrentValues.TabIndex = 3;
            this.btnGetCurrentValues.Text = "Refresh Current Position";
            this.btnGetCurrentValues.UseVisualStyleBackColor = true;
            this.btnGetCurrentValues.Click += new System.EventHandler(this.btnGetCurrentValues_Click);
            // 
            // txtHeadAngleY
            // 
            this.txtHeadAngleY.Location = new System.Drawing.Point(94, 55);
            this.txtHeadAngleY.Name = "txtHeadAngleY";
            this.txtHeadAngleY.Size = new System.Drawing.Size(100, 20);
            this.txtHeadAngleY.TabIndex = 8;
            // 
            // txtHeadAngleX
            // 
            this.txtHeadAngleX.Location = new System.Drawing.Point(94, 24);
            this.txtHeadAngleX.Name = "txtHeadAngleX";
            this.txtHeadAngleX.Size = new System.Drawing.Size(100, 20);
            this.txtHeadAngleX.TabIndex = 7;
            // 
            // lblMoveHeadResult
            // 
            this.lblMoveHeadResult.AutoSize = true;
            this.lblMoveHeadResult.Location = new System.Drawing.Point(170, 150);
            this.lblMoveHeadResult.Name = "lblMoveHeadResult";
            this.lblMoveHeadResult.Size = new System.Drawing.Size(24, 13);
            this.lblMoveHeadResult.TabIndex = 6;
            this.lblMoveHeadResult.Text = "Idel";
            // 
            // progMoveHead
            // 
            this.progMoveHead.Location = new System.Drawing.Point(6, 150);
            this.progMoveHead.Name = "progMoveHead";
            this.progMoveHead.Size = new System.Drawing.Size(158, 23);
            this.progMoveHead.TabIndex = 5;
            // 
            // btnMoveHead
            // 
            this.btnMoveHead.Location = new System.Drawing.Point(6, 108);
            this.btnMoveHead.Name = "btnMoveHead";
            this.btnMoveHead.Size = new System.Drawing.Size(115, 23);
            this.btnMoveHead.TabIndex = 4;
            this.btnMoveHead.Text = "Move";
            this.btnMoveHead.UseVisualStyleBackColor = true;
            this.btnMoveHead.Click += new System.EventHandler(this.btnMoveHead_Click);
            // 
            // lblHeadY
            // 
            this.lblHeadY.AutoSize = true;
            this.lblHeadY.Location = new System.Drawing.Point(33, 63);
            this.lblHeadY.Name = "lblHeadY";
            this.lblHeadY.Size = new System.Drawing.Size(14, 13);
            this.lblHeadY.TabIndex = 3;
            this.lblHeadY.Text = "Y";
            // 
            // lblHeadX
            // 
            this.lblHeadX.AutoSize = true;
            this.lblHeadX.Location = new System.Drawing.Point(33, 24);
            this.lblHeadX.Name = "lblHeadX";
            this.lblHeadX.Size = new System.Drawing.Size(14, 13);
            this.lblHeadX.TabIndex = 2;
            this.lblHeadX.Text = "X";
            // 
            // tabHands
            // 
            this.tabHands.Controls.Add(this.groupBox2);
            this.tabHands.Location = new System.Drawing.Point(4, 22);
            this.tabHands.Name = "tabHands";
            this.tabHands.Padding = new System.Windows.Forms.Padding(3);
            this.tabHands.Size = new System.Drawing.Size(760, 494);
            this.tabHands.TabIndex = 1;
            this.tabHands.Text = "Hands";
            this.tabHands.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtRightHandValue);
            this.groupBox2.Controls.Add(this.txtLeftHandValue);
            this.groupBox2.Controls.Add(this.btnRefreshHandsValues);
            this.groupBox2.Controls.Add(this.btnApply);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtRightHandAngle);
            this.groupBox2.Controls.Add(this.txtLeftHandAngle);
            this.groupBox2.Controls.Add(this.chkRightHandMove);
            this.groupBox2.Controls.Add(this.chkLeftHandMove);
            this.groupBox2.Controls.Add(this.lblMoveHandsResult);
            this.groupBox2.Controls.Add(this.progMoveHands);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(54, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 270);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hands Open and Close";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Current Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Current Value";
            // 
            // txtRightHandValue
            // 
            this.txtRightHandValue.Location = new System.Drawing.Point(401, 106);
            this.txtRightHandValue.Name = "txtRightHandValue";
            this.txtRightHandValue.Size = new System.Drawing.Size(100, 20);
            this.txtRightHandValue.TabIndex = 9;
            // 
            // txtLeftHandValue
            // 
            this.txtLeftHandValue.Location = new System.Drawing.Point(402, 47);
            this.txtLeftHandValue.Name = "txtLeftHandValue";
            this.txtLeftHandValue.Size = new System.Drawing.Size(100, 20);
            this.txtLeftHandValue.TabIndex = 9;
            // 
            // btnRefreshHandsValues
            // 
            this.btnRefreshHandsValues.Location = new System.Drawing.Point(394, 177);
            this.btnRefreshHandsValues.Name = "btnRefreshHandsValues";
            this.btnRefreshHandsValues.Size = new System.Drawing.Size(117, 34);
            this.btnRefreshHandsValues.TabIndex = 8;
            this.btnRefreshHandsValues.Text = "Refresh";
            this.btnRefreshHandsValues.UseVisualStyleBackColor = true;
            this.btnRefreshHandsValues.Click += new System.EventHandler(this.btnRefreshHandsValues_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(27, 177);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(128, 34);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Angle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Angle";
            // 
            // txtRightHandAngle
            // 
            this.txtRightHandAngle.Location = new System.Drawing.Point(184, 111);
            this.txtRightHandAngle.Name = "txtRightHandAngle";
            this.txtRightHandAngle.Size = new System.Drawing.Size(100, 20);
            this.txtRightHandAngle.TabIndex = 4;
            // 
            // txtLeftHandAngle
            // 
            this.txtLeftHandAngle.Location = new System.Drawing.Point(184, 42);
            this.txtLeftHandAngle.Name = "txtLeftHandAngle";
            this.txtLeftHandAngle.Size = new System.Drawing.Size(100, 20);
            this.txtLeftHandAngle.TabIndex = 4;
            // 
            // chkRightHandMove
            // 
            this.chkRightHandMove.AutoSize = true;
            this.chkRightHandMove.Location = new System.Drawing.Point(26, 113);
            this.chkRightHandMove.Name = "chkRightHandMove";
            this.chkRightHandMove.Size = new System.Drawing.Size(80, 17);
            this.chkRightHandMove.TabIndex = 3;
            this.chkRightHandMove.Text = "Right Hand";
            this.chkRightHandMove.UseVisualStyleBackColor = true;
            // 
            // chkLeftHandMove
            // 
            this.chkLeftHandMove.AutoSize = true;
            this.chkLeftHandMove.Location = new System.Drawing.Point(27, 47);
            this.chkLeftHandMove.Name = "chkLeftHandMove";
            this.chkLeftHandMove.Size = new System.Drawing.Size(73, 17);
            this.chkLeftHandMove.TabIndex = 2;
            this.chkLeftHandMove.Text = "Left Hand";
            this.chkLeftHandMove.UseVisualStyleBackColor = true;
            // 
            // lblMoveHandsResult
            // 
            this.lblMoveHandsResult.AutoSize = true;
            this.lblMoveHandsResult.Location = new System.Drawing.Point(181, 241);
            this.lblMoveHandsResult.Name = "lblMoveHandsResult";
            this.lblMoveHandsResult.Size = new System.Drawing.Size(24, 13);
            this.lblMoveHandsResult.TabIndex = 1;
            this.lblMoveHandsResult.Text = "Idel";
            // 
            // progMoveHands
            // 
            this.progMoveHands.Location = new System.Drawing.Point(26, 241);
            this.progMoveHands.Name = "progMoveHands";
            this.progMoveHands.Size = new System.Drawing.Size(129, 23);
            this.progMoveHands.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 67);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(6, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 67);
            this.panel2.TabIndex = 13;
            // 
            // movementStatusBar
            // 
            this.movementStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.movementStatusBar.Location = new System.Drawing.Point(0, 551);
            this.movementStatusBar.Name = "movementStatusBar";
            this.movementStatusBar.Size = new System.Drawing.Size(792, 22);
            this.movementStatusBar.TabIndex = 2;
            this.movementStatusBar.Text = "Ready";
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
            // frmMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.movementStatusBar);
            this.Controls.Add(this.tabController);
            this.Name = "frmMove";
            this.Text = "frmMove";
            this.tabController.ResumeLayout(false);
            this.tabHead.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabHands.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.movementStatusBar.ResumeLayout(false);
            this.movementStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage tabHead;
        private System.Windows.Forms.TabPage tabHands;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHeadY;
        private System.Windows.Forms.Label lblHeadX;
        private System.Windows.Forms.Label lblMoveHeadResult;
        private System.Windows.Forms.ProgressBar progMoveHead;
        private System.Windows.Forms.Button btnMoveHead;
        private System.Windows.Forms.TextBox txtHeadAngleY;
        private System.Windows.Forms.TextBox txtHeadAngleX;
        private System.Windows.Forms.StatusStrip movementStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button btnGetCurrentValues;
        private System.Windows.Forms.TextBox txtCurrentY;
        private System.Windows.Forms.TextBox txtCurrentX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRightHandValue;
        private System.Windows.Forms.TextBox txtLeftHandValue;
        private System.Windows.Forms.Button btnRefreshHandsValues;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRightHandAngle;
        private System.Windows.Forms.TextBox txtLeftHandAngle;
        private System.Windows.Forms.CheckBox chkRightHandMove;
        private System.Windows.Forms.CheckBox chkLeftHandMove;
        private System.Windows.Forms.Label lblMoveHandsResult;
        private System.Windows.Forms.ProgressBar progMoveHands;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
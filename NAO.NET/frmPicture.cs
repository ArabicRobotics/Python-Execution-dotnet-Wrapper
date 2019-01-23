using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dllPython.NETConnection.NAO;
using System.Threading;
namespace NAO.NET
{
    public partial class frmPicture : Form
    {
        public frmPicture()
        {
            InitializeComponent();
            init();
        }
        bool isRunning;
        public void init()
        {
            toolStripProgressBar1.Value = 0;
            cameraStatusBar.Items[0].Text = "Ready.";
            lstCamera.SelectedIndex = 0;
            isRunning = false;
        
        }
        private void btnGetImage_Click(object sender, EventArgs e)
        {
            #region PreCal Validation
            if (isRunning)
            {
                MessageBox.Show("still  Working...");
                return;
            }
            if (txtFileName.Text =="")
	        {
                txtFileName.Text = "Image1.PNG";
	        }
            string strFileName = txtFileName.Text;
            int intCamID = lstCamera.SelectedIndex;
	        #endregion 	
            #region InitilizeVariables:
            int callResult = -1;
            cameraStatusBar.Items[0].Text = "Starting...";
            toolStripProgressBar1.Value = 0;
            #endregion
            try
            {                
                // Initialize the thread that will handle the background process
                Thread backgroundThread = new Thread(
                    new ThreadStart(() =>
                    {
                        isRunning = true;
                        cameraStatusBar.BeginInvoke(new Action(() => toolStripProgressBar1.Value = 30));
                        cameraStatusBar.BeginInvoke(new Action(() => cameraStatusBar.Items[0].Text = "Taking PictureFrom Robot..."));
                        callResult = clsNAOCam.GetImage(intCamID, strFileName);
                        if (callResult == 0)
                        {
                            cameraStatusBar.BeginInvoke(new Action(() => toolStripProgressBar1.Value = 50));
                            cameraStatusBar.BeginInvoke(new Action(() => cameraStatusBar.Items[0].Text = "Success Take Picture."));
                            cameraStatusBar.BeginInvoke(new Action(() => toolStripProgressBar1.Value = 75));
                            cameraStatusBar.BeginInvoke(new Action(() => cameraStatusBar.Items[0].Text = "Getting Image from file..."));

                            #region Getting and Display FileFromDisk
                            imgCamera.Image = System.Drawing.Image.FromFile(clsDefinitions.LocalImagesDir+strFileName);
                            cameraStatusBar.BeginInvoke(new Action(() => toolStripProgressBar1.Value = 100));
                            cameraStatusBar.BeginInvoke(new Action(() => cameraStatusBar.Items[0].Text = "Loaded Image Successfully"));
                            isRunning = false;
                            #endregion
                        }
                        else
                        {
                            cameraStatusBar.BeginInvoke(new Action(() => toolStripProgressBar1.Value = 0));
                            cameraStatusBar.BeginInvoke(new Action(() => cameraStatusBar.Items[0].Text = "Failed to Take PictureFrom Robot..."));
                            Thread.Sleep(1000);
                            isRunning = false;
                            //cameraStatusBar.BeginInvoke(new Action(() => cameraStatusBar.Items[0].Text = "Ready."));
                        }

                    }
                    ));
                backgroundThread.Start();
                isRunning = false;
            }
	        catch (Exception)
	        {
		
		        throw;
	        }
        }

        private void lstCamera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

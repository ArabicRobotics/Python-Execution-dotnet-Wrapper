using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using dllPython;
using dllPython.NETConnection.NAO;
using dllPython.NETConnection.Config;
namespace NAO.NET
{
    public partial class frmMove : Form
    {
        public bool isProcessRunning;
        public void init ()
        {
            isProcessRunning = false;
            lblMoveHeadResult.Text = "Idel";
            movementStatusBar.Items[0].Text = "Ready.";
        }
        public frmMove()
        {
            InitializeComponent();
            init();
        }
        
        private void btnMoveHead_Click(object sender, EventArgs e)
        {   double x;
            double y;
            try
            {
                x = double.Parse(txtHeadAngleX.Text);
                y = double.Parse(txtHeadAngleY.Text);
                if (!(x<1.6&& y<1.6 && x>-1.6 && y >-1.6))
                {
                    MessageBox.Show("X , y Have to be Between -1.6 and 1.6");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (isProcessRunning)
            {
                MessageBox.Show("A process is already running.");
                return;
            }


            try
            {
                // Initialize the thread that will handle the background process
                Thread backgroundThread = new Thread(
                    new ThreadStart(() =>
                    {
                        int callResult = -1;

                        // Set the flag that indicates if a process is currently running
                        isProcessRunning = true;
                        ///Call Method: head move
                        ///
                       progMoveHead.BeginInvoke(new Action(() => progMoveHead.Value = 50));                        
                       movementStatusBar.BeginInvoke(new Action(() => movementStatusBar.Items[0].Text = "In Progress ..."));
                       lblMoveHeadResult.BeginInvoke(new Action(()=> lblMoveHeadResult.Text = "calling Move To X: "+txtHeadAngleX.Text+" Y: "+txtHeadAngleY.Text));
                       
                        callResult =  clsHead.MoveTo(x,y);
                        if (callResult == 0)
                        {
                         lblMoveHeadResult.BeginInvoke(new Action(()=>   lblMoveHeadResult.Text = "Success Turn Head."));
                         movementStatusBar.BeginInvoke(new Action(() => movementStatusBar.Items[0].Text = "Successful call ..."));
                        }
                        else
                        {
                           lblMoveHeadResult.BeginInvoke(new Action(()=> lblMoveHeadResult.Text = "failed To  turn  Head."));
                        }
                        // Iterate from 0 - 99
                        // On each iteration, pause the thread for .05 seconds, then update the progress bar

                            progMoveHead.BeginInvoke(new Action(() => progMoveHead.Value =100));

                            try
                            {
                                txtCurrentX.BeginInvoke(new Action(()=> txtCurrentX.Text = clsXMLValues.GetNAOValue("HeadYaw")));
                                txtCurrentY.BeginInvoke(new Action(()=> txtCurrentY.Text = clsXMLValues.GetNAOValue("HeadPitch")));
                            }
                            catch (Exception ex)
                            {
                                lblMoveHeadResult.BeginInvoke(new Action(()=>lblMoveHeadResult.Text = ex.Message));
                            }
                            #region Ending Thread
                            // Show a dialog box that confirms the process has completed
                            //MessageBox.Show("Thread completed!");

                            // Reset the progress bar's value if it is still valid to do so
                            if (progMoveHead.InvokeRequired)
                                progMoveHead.BeginInvoke(new Action(() => progMoveHead.Value = 0));
                                movementStatusBar.BeginInvoke(new Action(() => movementStatusBar.Items[0].Text = "Ready."));
                            // Reset the flag that indicates if a process is currently running
                            isProcessRunning = false;                             
                            #endregion

                    }
                ));
                backgroundThread.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetCurrentValues_Click(object sender, EventArgs e)
        {
            try
            {
                txtCurrentX.Text = clsXMLValues.GetNAOValue("HeadYaw");
                txtCurrentY.Text = clsXMLValues.GetNAOValue("HeadPitch");
            }
            catch (Exception ex)
            {
                lblMoveHeadResult.Text =  ex.Message ;
            }
        }



 

       
    }
}

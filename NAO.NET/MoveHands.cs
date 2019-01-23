using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dllPython.NETConnection.NAO;
using System.Windows.Forms;
using System.Threading;
using dllPython.NETConnection.Config;

namespace NAO.NET
{
   partial class frmMove
    {
       private void btnApply_Click(object sender, EventArgs e)
       {
           bool MoveRightHand;
           double MoveRightHandValue;
           bool MoveLeftHand;
           double MoveLeftHandValue;
           if (ValidateMoveHandsFormValues(out MoveRightHand, out MoveRightHandValue, out MoveLeftHand, out MoveLeftHandValue))
           {
               if (MoveRightHand)
               {
                   /// MoveRight Hand
                   /// 
                   ////////////

                   #region Thread Call MoveRight Hands 
                   try
                   {
                       // Initialize the thread that will handle the background process
                       Thread RightbackgroundThread = new Thread(
                           new ThreadStart(() =>
                           {
                               int callResult = -1;
                               // Set the flag that indicates if a process is currently running
                               isProcessRunning = true;
                               ///Call Method: Hands move
                               ///
                               progMoveHands.BeginInvoke(new Action(() => progMoveHands.Value = 30));
                               movementStatusBar.BeginInvoke(new Action(() => movementStatusBar.Items[0].Text = "In Progress ..."));
                               lblMoveHandsResult.BeginInvoke(new Action(() => lblMoveHandsResult.Text = "calling Move Hands To Angle: " + txtRightHandAngle.Text));
                               ////////////REAL CALL 

                               callResult =  clsHand.MoveHand("RHand", MoveRightHandValue);
                               /////////////////End Real CALL 
                               if (callResult == 0)
                               {
                                   lblMoveHandsResult.BeginInvoke(new Action(() => lblMoveHandsResult.Text = "Success Open/Close Right Hand."));
                                   movementStatusBar.BeginInvoke(new Action(() => movementStatusBar.Items[0].Text = "Successful call ..."));

                               }
                               else
                               {
                                   lblMoveHandsResult.BeginInvoke(new Action(() => lblMoveHandsResult.Text = "Failed To Open/Close Right hand."));
                               }
                               // Iterate from 0 - 99
                               // On each iteration,
                               //pause the thread for .05 seconds, then update the progress bar

                               progMoveHands.BeginInvoke(new Action(() => progMoveHands.Value = 100));
                              
                               #region Getting Hands Values from Robot
                               try
                               {

                                   txtLeftHandValue.BeginInvoke(new Action(() => txtLeftHandValue.Text = clsXMLValues.GetNAOValue("LHand")));

                                   txtRightHandValue.BeginInvoke(new Action(() => txtRightHandValue.Text = clsXMLValues.GetNAOValue("RHand")));

                               }

                               catch (Exception ex)
                               {

                                   lblMoveHandsResult.BeginInvoke(new Action(() => lblMoveHandsResult.Text = ex.Message));

                               }
                               #endregion
                               
                               #region Ending Thread
                               // Show a dialog box that confirms the process has completed
                               //MessageBox.Show("Thread completed!");

                               // Reset the progress bar's value if it is still valid to do so
                               if (progMoveHands.InvokeRequired)
                                   progMoveHands.BeginInvoke(new Action(() => progMoveHands.Value = 0));
                               lblMoveHandsResult.BeginInvoke(new Action(() => lblMoveHandsResult.Text = "Ready."));
                               movementStatusBar.BeginInvoke(new Action(() => movementStatusBar.Items[0].Text = "Ready."));
                               // Reset the flag that indicates if a process is currently running
                               isProcessRunning = false;
                               #endregion

                           }
                       ));
                       RightbackgroundThread.Start();
                   }
                   catch (Exception ex)
                   {

                       MessageBox.Show(ex.Message);
                   }


                   #endregion Thread                 
               }
               if (MoveLeftHand)
               {
                   /// Move Left Hand
                   /// 

                   #region Thread Call MoveLeft Hands
                   try
                   {
                       // Initialize the thread that will handle the background process
                       Thread LeftbackgroundThread = new Thread(
                           new ThreadStart(() =>
                           {
                               int callResult = -1;
                               // Set the flag that indicates if a process is currently running
                               isProcessRunning = true;
                               ///Call Method: Hand move
                               ///
                               progMoveHands.BeginInvoke(new Action(() => progMoveHands.Value = 30));
                               movementStatusBar.BeginInvoke(new Action(() => movementStatusBar.Items[0].Text = "In Progress ..."));
                               lblMoveHandsResult.BeginInvoke(new Action(() => lblMoveHandsResult.Text = "calling Move Hands To Angle: " + txtRightHandAngle.Text));
                               ////////////REAL CALL 

                               callResult =  clsHand.MoveHand("LHand", MoveLeftHandValue);
                               /////////////////End Real CALL 
                               if (callResult == 0)
                               {
                                   lblMoveHandsResult.BeginInvoke(new Action(() => lblMoveHandsResult.Text = "Success Open/Close Right Hand."));
                                   movementStatusBar.BeginInvoke(new Action(() => movementStatusBar.Items[0].Text = "Successful call ..."));

                               }
                               else
                               {
                                   lblMoveHandsResult.BeginInvoke(new Action(() => lblMoveHandsResult.Text = "Failed To Open/Close Right hand."));
                               }
                               // Iterate from 0 - 99
                               // On each iteration, pause the thread for .05 seconds, then update the progress bar

                               progMoveHands.BeginInvoke(new Action(() => progMoveHands.Value = 100));
                               #region Ending Thread
                               // Show a dialog box that confirms the process has completed
                               //MessageBox.Show("Thread completed!");
                               #region Getting Hands Values from Robot
                              try

                               {

                                   txtLeftHandValue.BeginInvoke(new Action(() => txtLeftHandValue.Text = clsXMLValues.GetNAOValue("LHand")));

                                   txtRightHandValue.BeginInvoke(new Action(() => txtRightHandValue.Text = clsXMLValues.GetNAOValue("RHand")));

                               }

                             catch (Exception ex)

                               {

                               lblMoveHandsResult.BeginInvoke(new Action(() => lblMoveHandsResult.Text = ex.Message));

                               }
                               #endregion



                               // Reset the progress bar's value if it is still valid to do so
                               if (progMoveHands.InvokeRequired)
                                   progMoveHands.BeginInvoke(new Action(() => progMoveHands.Value = 0));
                               lblMoveHandsResult.BeginInvoke(new Action(() => lblMoveHandsResult.Text = "Ready."));
                               movementStatusBar.BeginInvoke(new Action(() => movementStatusBar.Items[0].Text = "Ready."));
                               // Reset the flag that indicates if a process is currently running
                               isProcessRunning = false;
                               #endregion

                           }
                       ));
                       LeftbackgroundThread.Start();
                   }
                   catch (Exception ex)
                   {

                       MessageBox.Show(ex.Message);
                   }


                   #endregion Thread                    
               }
               GetCurrentHandsPosition();
           }
       }


       bool ValidateMoveHandsFormValues(out bool MoveRightHand, out double MoveRightHandValue, out bool MoveLeftHand, out double MoveLeftHandValue)
       {
           bool MoveLeft = validateRightHandMove(out MoveRightHand, out MoveRightHandValue);
           bool MoveRight = validateLeftHandMove(out MoveLeftHand, out MoveLeftHandValue);

           if (MoveLeft == true || MoveRight == true)
           {
               return true;
           }
           else
           {
               return false;
           }



       }

       bool validateRightHandMove(out bool HandMove, out double HandMovevalue)
       {
           HandMove = false;
           if (chkRightHandMove.Checked)
           {
               if (txtRightHandAngle.Text == "")
               {
                   MessageBox.Show("please fill Value in Right hand text box");
                   HandMovevalue = 0;
                   return false;
               }
               try
               {
                   double.Parse(txtRightHandAngle.Text);
                   HandMove = true;
                   HandMovevalue = double.Parse(txtRightHandAngle.Text);
                   return true;
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
                   HandMovevalue = 0;
                   return false;
               }
           }
           else
           {
               HandMovevalue = 0;
               HandMove = false;
               return true;
           }

       }

       void GetCurrentHandsPosition()
       {

           #region Getting Hands Values from Robot
           try
           {

                txtLeftHandValue.Text = clsXMLValues.GetNAOValue("LHand");

               txtRightHandValue.Text = clsXMLValues.GetNAOValue("RHand");

           }

           catch (Exception ex)
           {

            lblMoveHandsResult.Text = ex.Message;

           }
           #endregion
       
       }
       bool validateLeftHandMove(out bool HandMove, out double HandMovevalue)
       {
           HandMove = false;
           if (chkLeftHandMove.Checked)
           {
               if (txtLeftHandAngle.Text == "")
               {
                   MessageBox.Show("please fill Value in left hand text box");
                   HandMovevalue = 0;
                   return false;
               }
               try
               {
                   double.Parse(txtLeftHandAngle.Text);
                   HandMove = true;
                   HandMovevalue = double.Parse(txtLeftHandAngle.Text);
                   return true;
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
                   HandMovevalue = 0;
                   return false;
               }
           }
           else
           {
               HandMovevalue = 0;
               HandMove = false;
               return true;
           }

       }

       private void btnRefreshHandsValues_Click(object sender, EventArgs e)
       {

           GetCurrentHandsPosition();
       }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dllPython.NETConnection.NAO
{
    public class clsHand
    {
        static public int MoveHand(string Hand,double Angle)
        {
            try
            {
                return clsConnection.ExFile("v1\\clsHands.py", clsDefinitions.RobotIP + " " + Hand + " " + Angle.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }

        }
    }
}

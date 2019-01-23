import time
import sys
from naoqi import ALProxy
import clsStatics
import clsFile
def HandMove(robotIP,PORT,Hand,Angle):
    motionProxy = ALProxy("ALMotion", robotIP, PORT)
    # log
    clsFile.clsFile.logInFile("Values Inside Method:")
    clsFile.clsFile.logInFile("RobotIP = "+str(robotIP))
    clsFile.clsFile.logInFile("Port = "+str(PORT))
    clsFile.clsFile.logInFile("Hand = "+Hand)
    clsFile.clsFile.logInFile("angle = "+str(Angle))
    clsFile.clsFile.logInFile("End Log Values Inside Method.")
    #End Log

    motionProxy.setStiffnesses(Hand, 1.0)

    # Example showing how to set angles, using a fraction of max speed
    names  = [Hand]
    angles  = [Angle]
    fractionMaxSpeed  = 0.2
    motionProxy.setAngles(names, angles, fractionMaxSpeed)

    time.sleep(3.0)
    motionProxy.setStiffnesses(Hand, 0.0)

if __name__ == "__main__":
   robotIP = clsStatics.clsStatics.RobotIP
   PORT = clsStatics.clsStatics.RobotPort
   Hand = "RHand"
   Angle = 1
   if len(sys.argv) > 1: 
        robotIP = sys.argv[1]
        clsFile.clsFile.logInFile(str(robotIP))
        Hand =  sys.argv[2]
        clsFile.clsFile.logInFile(str(Hand))
        Angle= float(sys.argv[3])
        clsFile.clsFile.logInFile(str(Angle))

HandMove(robotIP,PORT,Hand,Angle)
import clsWriteXML
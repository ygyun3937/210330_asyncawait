using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sync_Ansync
{
    public partial class Form1 : Form
    {
        CRobot _cRobot;
        CDoor _cDoor1,_cDoor2;
        int _iRobot_Rotate = 0;
        int _iSpeed = 100;  //mm/sec
        bool _bObjectExist = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _cRobot = new CRobot("Robot");
            _cDoor1 = new CDoor("DoorLeft");
            _cDoor2 = new CDoor("DoorRight");

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btnInit":
                    InitDraw();
                    break;
                case "btnSimulation":
                    break;
                case "btnSimulationAsync":
                    break;
                case "btnD1Open":
                    break;
                case "btnD1Close":
                    break;
                case "btnD2Open":
                    break;
                case "btnD2Close":
                    break;
                case "btnRobotExtend":
                    break;
                case "btnRobotRetract":
                    break;
                case "btnRobotRotate":
                    break;


                default:
                    break;
            }
            Log(enLogLevel.Info_L1, $"BtnTest : {btn.Text}");

        }

        private void InitDraw()
        {
            _cRobot = null;
            _cDoor1 = null;
            _cDoor2 = null;
            _iRobot_Rotate = 0;
            _bObjectExist = false;

            _cRobot = new CRobot("Robot");
            _cDoor1 = new CDoor("DoorLeft");
            _cDoor2 = new CDoor("DoorRight");

            fDoor1Draw(0);
            fDoor2Draw(0);
        }

        private void fRobotDraw(int iRotate,int iRobot_Arm_Move,bool isObject)
        {
            pRobot.Refresh();

            Graphics g = pRobot.CreateGraphics();
            g.FillEllipse(_cRobot.fBrushInfo(), _cRobot._rtCirCle_Robot);

            _cRobot.fMove(iRobot_Arm_Move);

            Point center = new Point(100, 100);
            //g.Transform =

            g.DrawRectangle(_cDoor1.fPenInfo(), _cDoor1._rtDoorSide);
        }
       
        private Matrix GetMatrix(Point centerPoint,float rotateAngle)
        {
            M
        }



        private void fDoor1Draw(int Move)
        {
            pDoor1.Refresh();

            _cDoor1.fMove(Move);


            Graphics g = pDoor1.CreateGraphics();
            g.FillRectangle(_cDoor1.fBrushInfo(), _cDoor1._rtDoor);
            g.DrawRectangle(_cDoor1.fPenInfo(), _cDoor1._rtDoorSide);
        }

        private void fDoor2Draw(int Move)
        {
            pDoor2.Refresh();

            _cDoor2.fMove(Move);


            Graphics g = pDoor2.CreateGraphics();
            g.FillRectangle(_cDoor2.fBrushInfo(), _cDoor2._rtDoor);
            g.DrawRectangle(_cDoor2.fPenInfo(), _cDoor2._rtDoorSide);
        }

        #region Log Viewer 

        // Log Level을 지정 할 Enum (44강 Tree View 참조)
        enum enLogLevel
        {
            Info_L1,
            Info_L2,
            Info_L3,
            Warning,
            Error,
        }

        private void Log(enLogLevel eLevel, string LogDesc)
        {
            this.Invoke(new Action(delegate ()
            {
                DateTime dTime = DateTime.Now;
                string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
                lboxLog.Items.Insert(0, LogInfo);
            }));
        }

        private void Log(DateTime dTime, enLogLevel eLevel, string LogDesc)
        {
            this.Invoke(new Action(delegate ()
            {
                string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
                lboxLog.Items.Insert(0, LogInfo);
            }));
        }

        #endregion



    }
}

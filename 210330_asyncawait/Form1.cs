using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
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
                    start_move();
                    break;
                case "btnSimulationAsync":
                    Start_Move_Async();
                    break;
                case "btnD1Open":
                    Door1Open();
                    break;
                case "btnD1Close":
                    Door1Close();
                    break;
                case "btnD2Open":
                    Door2Open();
                    break;
                case "btnD2Close":
                    Door2Close();
                    break;
                case "btnRobotExtend":
                    RobotArmExtend();
                    break;
                case "btnRobotRetract":
                    RobotArmRetract();
                    break;
                case "btnRobotRotate":
                    RobotRotate();
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

            fRobotDraw(_iRobot_Rotate, 0, false);
            fDoor1Draw(0);
            fDoor2Draw(0);
        }

        private void fRobotDraw(int iRotate,int iRobot_Arm_Move,bool isObject)
        {
            this.Invoke(new Action(delegate ()
            {
                pRobot.Refresh();

                Graphics g = pRobot.CreateGraphics();
                g.FillEllipse(_cRobot.fBrushInfo(), _cRobot._rtCirCle_Robot);

                _cRobot.fMove(iRobot_Arm_Move);

                Point center = new Point(100, 100);
                g.Transform = GetMatrix(center, iRotate);

                g.DrawRectangle(_cRobot.fPenInfo(), _cRobot._rtSquare_Arm);

                if (isObject)
                {
                    g.FillRectangle(_cRobot.fBrushInfo(), _cRobot._rtSquare_Object);
                }
            }));         

        }
       
        private Matrix GetMatrix(Point centerPoint,float rotateAngle)
        {
            Matrix matrix = new Matrix();

            matrix.RotateAt(rotateAngle, centerPoint);

            return matrix;
        }



        private void fDoor1Draw(int Move)
        {
            this.Invoke(new Action(delegate ()
            {
                pDoor1.Refresh();

                _cDoor1.fMove(Move);


                Graphics g = pDoor1.CreateGraphics();
                g.FillRectangle(_cDoor1.fBrushInfo(), _cDoor1._rtDoor);
                g.DrawRectangle(_cDoor1.fPenInfo(), _cDoor1._rtDoorSide);
            }));
          
        }

        private void fDoor2Draw(int Move)
        {
            this.Invoke(new Action(delegate ()
            {
                pDoor2.Refresh();

                _cDoor2.fMove(Move);


                Graphics g = pDoor2.CreateGraphics();
                g.FillRectangle(_cDoor2.fBrushInfo(), _cDoor2._rtDoor);
                g.DrawRectangle(_cDoor2.fPenInfo(), _cDoor2._rtDoorSide);
            }));
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


        #region Task
        private void start_move()
        {
            Task.Run(() =>
            {
                Log(enLogLevel.Info_L2, "Move Sequence Start");

                Door1Open();
                RobotArmExtend();
                Thread.Sleep(500);
                _bObjectExist = true;  // 팔을 뻗고 물건을 가지고 나오고
                RobotArmRetract();
                Door1Close();
                RobotRotate();
                Door2Open();
                RobotArmExtend();
                Thread.Sleep(500);
                _bObjectExist = false;  // 팔을 뻗고 물건을 놔두고 나옴
                RobotArmRetract();
                Door2Close();
                RobotRotate();

                Log(enLogLevel.Info_L2, "Move Sequence Complete");

            });
        }
        /// <summary>
        /// 비동기 제어 : 함수 호출 시 Task를 생성 해서 비동기로 진행 하나 필요에 따라 await를 가지고 함수의 종료를 대기
        /// </summary>
        private async void Start_Move_Async()
        {
            Log(enLogLevel.Info_L2, "Move Async Sequence Start");

            // 동시 동작 하는 부분의 경우 긴 시간 기준으로 대기 하도록 함
            Task vTask;

            vTask = Task.Run(() => RobotArmExtend());
            await Task.Run(() => Door1Open());

            Thread.Sleep(500);
            _bObjectExist = true;  // 팔을 뻗고 물건을 가지고 나오고
            await Task.Run(() => RobotArmRetract());

            vTask = Task.Run(() => Door1Close());
            await Task.Run(() => Call_RobotRotate());

            vTask = Task.Run(() => RobotArmExtend());
            await Task.Run(() => Call_Door2Open());

            Thread.Sleep(500);
            _bObjectExist = false;  // 팔을 뻗고 물건을 가지고 나오고
            await Task.Run(() => RobotArmRetract());

            vTask = Task.Run(() => Door2Close());
            await Task.Run(() => Call_RobotRotate());

            Log(enLogLevel.Info_L2, "Move Async Sequence Complete");


            /*
            //Call_RobotArmExtend();
            //await Call_Door1Open();
            Thread.Sleep(500);
            _bObjectExist = true;  // 팔을 뻗고 물건을 가지고 나오고
            await Call_RobotArmRetract();
            Call_Door1Close();
            await Call_RobotRotate();
            Call_RobotArmExtend();
            await Call_Door2Open();
            Thread.Sleep(500);
            _bObjectExist = false;  // 팔을 뻗고 물건을 놔두고 나옴
            await Call_RobotArmRetract();
            Call_Door2Close();
            await Call_RobotRotate();
            */
        }
#endregion

        #region 단위동작
        private int Door1Open()
        {
            Log(enLogLevel.Info_L1, "Door1 Open Start");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(_iSpeed);
                //_iDoor1Move = -5;
                fDoor1Draw(-5);
            }

            Log(enLogLevel.Info_L1, "Door1 Open Complete");

            return 0;
        }

        private int Door1Close()
        {
            Log(enLogLevel.Info_L1, "Door1 Close Start");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(_iSpeed);
                //_iDoor1Move = 5;
                fDoor1Draw(5);
            }

            Log(enLogLevel.Info_L1, "Door1 Close Complete");

            return 0;
        }

        /*
        // 1번 문 Open
        private async Task<int> Door1OpenAsync()
        {
            var vTask = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(_iSpeed);
                    //_iDoor1Move = -5;
                    fDoor1Draw(-5);
                }
            });
            await vTask;
            return 0;
        }
       
        // 1번 문 Close
        private async Task<int> Door1CloseAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(_iSpeed);
                //_iDoor1Move = 5;
                fDoor2Draw(5);
            }
            return 0;
        }
        */

        // 2번 문 Open
        private int Door2Open()
        {
            Log(enLogLevel.Info_L1, "Door2 Open Start");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(_iSpeed);
                fDoor2Draw(-5);
            }

            Log(enLogLevel.Info_L1, "Door2 Open Complete");

            return 0;
        }


        // 2번 문 Close
        private int Door2Close()
        {
            Log(enLogLevel.Info_L1, "Door2 Close Start");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(_iSpeed);
                fDoor2Draw(5);
            }

            Log(enLogLevel.Info_L1, "Door2 Close Complete");

            return 0;
        }


        // Robot Arm Extend (Robot의 팔을 뻗는다)
        private int RobotArmExtend()
        {
            Log(enLogLevel.Info_L1, "Robot Arm Extend Start");

            // Robot Arm Extend
            for (int i = 0; i < 8; i++)
            {
                Thread.Sleep(_iSpeed);
                fRobotDraw(_iRobot_Rotate, -5, _bObjectExist);
            }

            Log(enLogLevel.Info_L1, "Robot Arm Extend Complete");

            return 0;
        }


        // Robot Arm Retract (Robot의 팔을 접는다)
        private int RobotArmRetract()
        {
            Log(enLogLevel.Info_L1, "Robot Arm Retract Start");

            // Robot Arm Retract
            for (int i = 0; i < 8; i++)
            {
                Thread.Sleep(_iSpeed);
                fRobotDraw(_iRobot_Rotate, 5, _bObjectExist);
            }

            Log(enLogLevel.Info_L1, "Robot Arm Retract Complete");

            return 0;
        }



        // Robot Rotate (Robot을 회전 시킴)
        private int RobotRotate()
        {
            Log(enLogLevel.Info_L1, "Robot Rotate Start");

            for (int i = 0; i < 12; i++)
            {
                Thread.Sleep(_iSpeed);
                _iRobot_Rotate = _iRobot_Rotate + 15;

                fRobotDraw(_iRobot_Rotate, 0, _bObjectExist);
            }

            // 회전을 완료 한 뒤 회전각이 360을 넘어 가면 360 만큼 빼줌
            if (_iRobot_Rotate > 360) _iRobot_Rotate -= 360;

            Log(enLogLevel.Info_L1, "Robot Rotate Complete");

            return 0;
        }

        #endregion
        #region 비동기 호출 Call 함수 (필요 없지만 참고용으로 사용)

        private Task<int> Call_Door1Open()
        {
            var vTask = Task.Run(() => Door1Open());

            return vTask;
        }


        private Task<int> Call_Door1Close()
        {
            var vTask = Task.Run(() => Door1Close());

            return vTask;
        }

        private Task<int> Call_Door2Open()
        {
            var vTask = Task.Run(() => Door2Open());

            return vTask;
        }


        private Task<int> Call_Door2Close()
        {
            var vTask = Task.Run(() => Door2Close());

            return vTask;
        }

        private Task<int> Call_RobotArmExtend()
        {
            var vTask = Task.Run(() => RobotArmExtend());

            return vTask;
        }


        private Task<int> Call_RobotArmRetract()
        {
            var vTask = Task.Run(() => RobotArmRetract());

            return vTask;
        }

        private Task<int> Call_RobotRotate()
        {
            var vTask = Task.Run(() => RobotRotate());

            return vTask;
        }
        #endregion

    }
}

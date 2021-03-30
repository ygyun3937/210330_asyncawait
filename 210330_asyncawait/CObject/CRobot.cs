using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sync_Ansync
{
    class CRobot :CBase
    {
        public Rectangle _rtCirCle_Robot; // Robot 몸통
        public Rectangle _rtSquare_Arm; // Robot 팔
        public Rectangle _rtSquare_Object; //Robot이 가지고 움직 일 물건

        public CRobot(string sName)
        {
            strName = sName;    
            _Pen = new Pen(Color.WhiteSmoke, 3);
            _Brush = new SolidBrush(Color.WhiteSmoke);

            _rtCirCle_Robot = new Rectangle(50, 50, 100, 100);
            _rtSquare_Arm = new Rectangle(40, 90, 80, 20);
            _rtSquare_Object = new Rectangle(20, 80, 20, 40);
        }


        public Pen fPenInfo()
        {
            return _Pen;
        }
        public SolidBrush fBrushInfo()
        {
            return _Brush;
        }
        #region Robot 몸통은 회전, 팔을 회전 이동 필요


        /// <summary>
        /// 외부에서 그림의 위치를 이동시키는 함수를 호출
        /// </summary>
        /// <param name="iMove"></param>
        public void fMove(int iMove)
        {
            fSquare1Move(iMove);
        }


        /// <summary>
        /// 몸통1의 위치를 가져와서 X 위치값을 이동 시키고 다시 바퀴1에 위치 정보를 넣어줌
        /// </summary>
        /// <param name="iMove"></param>
        protected void fSquare1Move(int iMove)
        {
            // Robot Arm을 움직임
            Point oPoint = _rtSquare_Arm.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSquare_Arm.Location = oPoint;

            // Robot Object도 Arm과 함께 움직임 (필요 시 화면에 표시 할지 말지만 정함)
            oPoint = _rtSquare_Object.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSquare_Object.Location = oPoint;
        }


        #endregion 

    }
}

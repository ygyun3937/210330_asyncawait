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
        public Rectangle _rtSqure_Arm; // Robot 팔
        public Rectangle _rtSqure_Object; //Robot이 가지고 움직 일 물건

        public CRobot(string sName)
        {
            strName = sName;    
            _Pen = new Pen(Color.WhiteSmoke, 3);
            _Brush = new SolidBrush(Color.WhiteSmoke);

            _rtCirCle_Robot = new Rectangle(50, 50, 100, 100);
            _rtSqure_Arm = new Rectangle(40, 90, 80, 20);
            _rtSqure_Object = new Rectangle(20, 80, 20, 40);
        }


        public Pen fPenInfo()
        {
            return _Pen;
        }


    }
}

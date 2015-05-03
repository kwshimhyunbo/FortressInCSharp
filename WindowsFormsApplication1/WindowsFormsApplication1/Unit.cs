using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    class Unit
    {
        public PictureBox img;
        private int HP;
        private bool turn;
        private double angle;

        public double getAngle()
        {
            return angle;
        }

        public void setAngle(int angle)
        {
            this.angle += angle;
        }

        public int getHP()
        {
            return HP;
        }
        public void setHP(int hp)
        {
            this.HP = hp;
        }

        public bool getNowTurn()
        {
            return turn;
        }

        public void setNowTurn(bool myTurn)
        {
            this.turn = myTurn;
        }

        public void init()
        {
            HP = 1500;
            turn = false;
            img = null;
            angle = 45;
        }



    }
}

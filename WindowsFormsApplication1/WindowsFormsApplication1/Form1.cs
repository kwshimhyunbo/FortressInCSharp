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
    
    public partial class leftbomb : Form
    {
        Random generateRandom;
        Unit user , leftUser, rightUser;
        int value;
        int power_value;
        int wind;

        public leftbomb()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameStart();
     
        }

        public void changeTurnSetting()
        {

            DateTime dtmcurrent = DateTime.Now;
            generateRandom = new Random(dtmcurrent.Millisecond);

            windlabel.Text = generateRandom.Next(-10, 10).ToString();
            value = 0;
            power_value = 0;
            
            if(leftUser.getNowTurn())
            {
                leftUser.setNowTurn(false);
                rightUser.setNowTurn(true);
            }
            else
            {
                rightUser.setNowTurn(false);
                leftUser.setNowTurn(true);
            }
            this.Refresh();
        }
        public void gameStart()
        {
            leftUser = new Unit();
            rightUser = new Unit();

            leftUser.init();
            rightUser.init();

            leftUser.setNowTurn(true);
            rightUser.setNowTurn(false);   

            DateTime dtmcurrent = DateTime.Now;
            generateRandom = new Random(dtmcurrent.Millisecond);
            windlabel.Text = generateRandom.Next(-10, 10).ToString();
           
            leftUser.img = player1;
            rightUser.img = player2;
        }
        private void Drawsetting()
        {
            Graphics _graphics = this.CreateGraphics();
            SolidBrush _brush = new SolidBrush(Color.Yellow);
            _graphics.FillRectangle(_brush, 204, 468, 187, 30);
            _graphics.FillRectangle(_brush, 220, 504, 550, 30);
            _graphics.FillRectangle(_brush, 579, 468, 187, 30);

        }
        public void move(int a)
        {
            value +=a;
            Graphics _graphics = this.CreateGraphics();
            SolidBrush _brush = new SolidBrush(Color.Yellow);
            _graphics.FillRectangle(_brush, 204, 468, value, 30);
        }
        public void power(int a)
        {
            power_value += a;
            
            Graphics _graphics = this.CreateGraphics();
            SolidBrush _brush = new SolidBrush(Color.Red);
            _graphics.FillRectangle(_brush, 220, 504, power_value, 30);
            powerlabel.Text = power_value.ToString();
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    timer1.Interval = 20;
                    timer1.Start();
                    changeTurnSetting();
                    break;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          
            int position;
            int labelposition;
            int bombposition;
            PictureBox bomb;
            Label label;

            if(leftUser.getNowTurn())
                user= leftUser;
            else
                user = rightUser;

            switch (e.KeyCode)
            {
                case Keys.Up:
                    if(user.getAngle()<89)
                    {
                        user.setAngle(1);
                    }
                    angleValue.Text = user.getAngle().ToString();
                    break;

                case Keys.Down:
             
                    if (user.getAngle() >1)
                        user.setAngle(-1);
                    angleValue.Text = user.getAngle().ToString();
                    break;

                case Keys.Space:
                    if (power_value < 540)
                        power(5);
                    break;

                //오른쪽으로 이동
                case Keys.Right:
                    if (leftUser.getNowTurn())
                    {
                        bomb = leftbom;
                        label = hp1label;
                        user.img.Image = Properties.Resources.tank2_right;
                    }
                    else
                    {
                        bomb = rightbom;
                        label = hp2label;
                        user.img.Image = Properties.Resources.tank_right;
                    }
                    if(value<180)
                    {
                        move(5);
                        label.Text = "HP:" + user.getHP().ToString();
                        labelposition = label.Location.X + 1;
                        position = user.img.Location.X + 1;
                        bombposition = bomb.Location.X +1;

                        bomb.Location = new Point(bombposition, 296);
                        label.Location = new Point(labelposition,365);
                        user.img.Location = new System.Drawing.Point(position, 325);
                    }
                    break;
                case Keys.None:
                  break;
                //왼쪽으로 이동
                case Keys.Left:
                  if (leftUser.getNowTurn())
                  {
                      bomb = leftbom;
                      label = hp1label;
                      user.img.Image = Properties.Resources.tank2_left;
                  }

                  else
                  {
                      bomb = rightbom;
                      label = hp2label;
                      user.img.Image = Properties.Resources.tank_left;
                  }
                  if (value < 180)
                  {
                      move(5);
                      label.Text = "HP:" + user.getHP().ToString();
                      labelposition = label.Location.X - 1;
                      position = user.img.Location.X - 1;
                      bombposition = bomb.Location.X - 1;
                      bomb.Location = new Point(bombposition, 296);
                      label.Location = new Point(labelposition, 365);
                      user.img.Location = new System.Drawing.Point(position, 325);
                  }

                   break;
            }
        }

    }


}

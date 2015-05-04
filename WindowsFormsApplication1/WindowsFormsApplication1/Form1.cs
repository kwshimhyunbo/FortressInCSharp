using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
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
            angleValue.Text = leftUser.getAngle().ToString();
            windlabel.Text = generateRandom.Next(-10, 10).ToString();
            value = 0;
            power_value = 0;
            
            if(leftUser.getNowTurn()) // left 유저가 턴이였다면
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
            leftUser.isleft = false;
            leftUser.isright = true;
            rightUser.isright = false;
            rightUser.isleft = true;

            DateTime dtmcurrent = DateTime.Now;
            generateRandom = new Random(dtmcurrent.Millisecond);
            windlabel.Text = generateRandom.Next(-10, 10).ToString();
            angleValue.Text = leftUser.getAngle().ToString();
           
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

                case Keys.Left:
                    if(rightUser.getNowTurn())
                    {
                        rightUser.img.Image = Properties.Resources.wait;
                    }
                    break;

                case Keys.Space:
                    timer1.Interval = 20;
                    missileSetting();
                    x = user.img.Location.X;
                    y = user.img.Location.Y;
                BOMB.Location = new Point(x, y-30);
                    timer1.Start();
                   
                    
                    break;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          
            int position;
            int labelposition;
           
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
                    user.isright = true;
                      user.isleft = false;
                    if (leftUser.getNowTurn())
                    {
                        label = hp1label;
                        user.img.Image = Properties.Resources.tank2_right;
                    }
                    else
                    {
                      
                        label = hp2label;
                        user.img.Image = Properties.Resources.move2;
                    }
                    if(value<180)
                    {
                        move(5);
                        label.Text = "HP:" + user.getHP().ToString();
                        labelposition = label.Location.X + 1;
                        position = user.img.Location.X + 1;
            
                        label.Location = new Point(labelposition,365);
                        user.img.Location = new System.Drawing.Point(position, 320);
                    }
                    break;
                case Keys.None:
                  break;
                //왼쪽으로 이동
                case Keys.Left:
                     user.isleft = true;
                      user.isright = false;
                  if (leftUser.getNowTurn())
                  {
                      label = hp1label;
                      user.img.Image = Properties.Resources.tank2_left;
                  }

                  else
                  {
                      label = hp2label;
                      user.img.Image = Properties.Resources.move ;
                  }
                  if (value < 180)
                  {
                      move(5);
                      label.Text = "HP:" + user.getHP().ToString();
                      labelposition = label.Location.X - 1;
                      position = user.img.Location.X - 1;
     
                      label.Location = new Point(labelposition, 365);
                      user.img.Location = new System.Drawing.Point(position, 320);
                  }

                   break;
            }
        }
        int g = 1;
        double vx, vy;
        int x, y;
        
        int v;
        private void missileLocate()
        {
            Unit player;
            int x,y;
              if(leftUser.getNowTurn())
              {
                  player = rightUser;
              }
              else
              {
                  player = leftUser;
              }
                x = player.img.Location.X;
                y = player.img.Location.Y;
                BOMB.Location = new Point(x, y);
          
        }
        private void missileSetting()
        {
        
            user.bomb = BOMB;
            v = Int32.Parse(powerlabel.Text)/10;
            vx = v * Math.Cos(user.getAngle() * Math.PI / 180);
            vy =- v * Math.Sin(user.getAngle() * Math.PI / 180);
            
            
            BOMB.Visible = true;
            
        }
        public void userHit()
        {
            user.bomb.Visible = false;
            missileLocate();
            changeTurnSetting();
            timer1.Stop();
        }
        private void isgameover()
        {
            if (leftUser.getHP() < 0)
            {
                MessageBox.Show("2player가 이겼습니다.");
                this.Close();
            }
              
            if (rightUser.getHP() < 0)
            {
                MessageBox.Show("1player가 이겼습니다.");
                this.Close();
            }
                

          
        }
        int w = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            w++;
            vy = vy + g;
            x = user.bomb.Location.X;
            y = user.bomb.Location.Y;
            if(user.isleft)
            {
                x -= Convert.ToInt32(vx);
                x = x + Int32.Parse(windlabel .Text)* w/70;
            }
            else
            {
                x += Convert.ToInt32(vx);
                x = x + Int32.Parse(windlabel.Text) * w/70;

            }
          
            y += Convert.ToInt32(vy);
            user.bomb.Location = new Point(x, y);

            DateTime dtmcurrent = DateTime.Now;
            generateRandom = new Random(dtmcurrent.Millisecond);

            int damage = generateRandom.Next(750, 850);
            int hp;
            if(leftUser.getNowTurn())
            {
                if (BOMB.Location.X <= rightUser.img.Location.X + 20 && BOMB.Location.X >= rightUser.img.Location.X - 20)
                {
                    if (BOMB.Location.Y <= rightUser.img.Location.Y + 20 && BOMB.Location.Y >= rightUser.img.Location.Y - 20)
                    {
                        
                        fire.Visible = true;
                        fire.Location = new Point(BOMB.Location.X - 60, BOMB.Location.Y);
                        hp = rightUser.getHP();
                        rightUser.setHP(hp - damage);
                        userHit();
                        Thread.Sleep(1000);
                        fire.Visible = false;
                       hp2label.Text = "HP:" + rightUser.getHP().ToString();
                       angleValue.Text = rightUser.getAngle().ToString();
                       isgameover();
                       
                    }
                }
            }
            if(rightUser.getNowTurn())
            {
                if (BOMB.Location.X <= leftUser.img.Location.X + 20 && BOMB.Location.X >= leftUser.img.Location.X - 20)
                {
                    if (BOMB.Location.Y <= leftUser.img.Location.Y + 20 && BOMB.Location.Y >= leftUser.img.Location.Y - 20)
                    {
                       
                        fire.Visible = true;
                        fire.Location = new Point(BOMB.Location.X - 60, BOMB.Location.Y+10);
                        hp = leftUser.getHP();
                        leftUser.setHP(hp - damage);
                        userHit();
                        Thread.Sleep(1000);
                        fire.Visible = false;
                        hp1label.Text = "HP:" + leftUser.getHP().ToString();
                        angleValue.Text = leftUser.getAngle().ToString();
                        isgameover();
                    }
                }
            }
           
          

            if(user.bomb.Location.X>800 || user.bomb.Location.X<0 || user.bomb.Location.Y>400)
            {
                user.bomb.Visible = false;
                missileLocate();
                changeTurnSetting();
                timer1.Stop();
            }
  
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            x = user.bomb.Location.X;
            y = user.bomb.Location.Y;
            if (user.isleft)
            {
                x -= Convert.ToInt32(vx);

            }
            else
            {
                x += Convert.ToInt32(vx);

            }
        }

    }


}

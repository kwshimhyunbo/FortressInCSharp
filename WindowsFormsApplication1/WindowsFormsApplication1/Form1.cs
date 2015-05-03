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
            this.Refresh();
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
            DateTime dtmcurrent = DateTime.Now;
            generateRandom = new Random(dtmcurrent.Millisecond);

            windlabel.Text = generateRandom.Next(-10, 10).ToString();
            leftUser = new Unit();
            rightUser = new Unit();
            leftUser.init();
            rightUser.init();
            leftUser.img = player1;
            rightUser.img = player2;

            
            leftUser.setNowTurn(true);
            rightUser.setNowTurn(false);            
           
        }
       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        
        }



        private void setting()
        {
            // Graphics 객체를생성한다.
            Graphics _graphics = this.CreateGraphics();
            // 메인폼의Graphics 객체를통해바탕화면을희색으로Clear한다.

            // 노란색SolidBrush 객체를생성한다.
            SolidBrush _brush = new SolidBrush(Color.Yellow);
            // 노란색으로채워진사각형을그린다.
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
       public void makemissile()
        {
          
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
                    {
                        user.setAngle(-1);
                    }
                    
                    
                    angleValue.Text = user.getAngle().ToString();
                    break;

                case Keys.Space:
                    if (power_value < 540)
                    {

                        power(10);

                    }
                    
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelWind_Click(object sender, EventArgs e)
        {

        }


        int g = 2; //중력가속도 값

        int vx = 10; // x축의 초기 속도

        int vy = +10;
        int x, y = 1000;

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (rightUser.getNowTurn()==true)
            {
                leftbom.Visible = true;
                
                    x = leftbom.Location.X;

                    x = x + Convert.ToInt32(Math.Cos(Math.PI * leftUser.getAngle() / 180.0)) * Int32.Parse(powerlabel.Text) / 10;
                    vy = vy * Convert.ToInt32(Math.Sin(Math.PI * leftUser.getAngle() / 180.0)) -g;
                    y = leftbom.Location.Y;
                    y = y - vy;
                    leftbom.Location = new Point(x, y);
                    if (y > 400)
                    {
                        leftbom.Visible = false;
                        
                        vx = 10;
                        vy = +20;
                        y = 1000;
                        timer1.Stop();
                        leftbom.Location = new Point(leftUser.img.Location.X + 10, leftUser.img.Location.Y - 10);
                    }
            }

            else
            {
                rightbom.Visible = true;
                
                    x = rightbom.Location.X;
                    x = x - Int32.Parse(powerlabel.Text)/10;
                    vy = vy  - g;
                    y = rightbom.Location.Y;
                    y = y -vy;
                    rightbom.Location = new Point(x, y);
                    if (y > 400)
                    {
                        rightbom.Visible = false;
                        
                        vx = 10;
                        vy = +20;
                        y = 1000;
                        
                        timer1.Stop();
                        rightbom.Location = new Point(rightUser.img.Location.X + 10, rightUser.img.Location.Y - 10);
                        
                    }
            }

        
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
       
        }

        


        


       /* private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //게임 시작
                case Keys.Space:
                    if (!isGameRunning)
                        GameStart();
                    break;

                //오른쪽으로 이동
                case Keys.Right:
                    if (isGameRunning)
                        this.Player.ImageLocation = "c:/img/right.gif";
                    PlayerMove(8);
                    break;
                case Keys.None:
                    if (isGameRunning)
                        this.Player.ImageLocation = "c:/img/don.bmp";
                    break;
                //왼쪽으로 이동
                case Keys.Left:
                    if (isGameRunning)
                        this.Player.ImageLocation = "c:/img/left.gif";
                    PlayerMove(-8);
                    break;
            }
        }*/


    }


    public class Unit
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

       public int  getHP()
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
            turn = false ;
            img = null;
            angle = 45;
        }



    }
}

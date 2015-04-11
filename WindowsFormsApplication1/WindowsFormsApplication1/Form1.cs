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

    public partial class Form1 : Form
    {
        Unit leftUser, rightUser;
        int value;
        int power_value;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameStart();
           
        }

        public void changeTurnSetting()
        {
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
            leftUser.img = player1;
            rightUser.img = player2;

            
            rightUser.setNowTurn(true);
            
           
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


        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    changeTurnSetting();
                    break;
            }
        }
       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          
            int position;
            Unit user;
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
                         user.img.Image = user.img.Image = Properties.Resources.tank2_right;
                     else
                         user.img.Image = user.img.Image = Properties.Resources.tank_right;
                    if(value<180)
                    {
                     move(5);
                    position = user.img.Location.X + 1;
                     user.img.Location = new System.Drawing.Point(position, 325);
                    }
                    break;
                case Keys.None:
                  break;
                //왼쪽으로 이동
                case Keys.Left:
                  if (leftUser.getNowTurn())
                      user.img.Image = user.img.Image = Properties.Resources.tank2_left;
                  else
                      user.img.Image = user.img.Image = Properties.Resources.tank_left;
                  if (value < 180)
                  {
                      move(5);
                     
                      position = user.img.Location.X - 1;
                      user.img.Location = new System.Drawing.Point(position, 325);

                  }

                  
                   break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
        private int angle;

        public int getAngle()
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
            angle = 0;
        }



    }
}

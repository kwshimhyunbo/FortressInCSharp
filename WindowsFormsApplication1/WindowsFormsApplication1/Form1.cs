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
        }

        public void gameStart()
        {
            angle.Parent = pictureBox1;
            wind.Parent = pictureBox1;
            player2.Parent = pictureBox1;
            player1.Parent = pictureBox1;

            leftUser = new Unit();
            rightUser = new Unit();
            leftUser.img = player1;
            rightUser.img = player2;


            rightUser.setNowTurn(true);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int position;
            Unit user;
            if(leftUser.getNowTurn())
            {
                user= leftUser;
            }

              else
                user = rightUser;
            switch (e.KeyCode)
            {
                //게임 시작
                case Keys.Space:
                    changeTurnSetting();
                     break;

                //오른쪽으로 이동
                case Keys.Right:
                    if(leftUser.getNowTurn())
                        user.img.Image = user.img.Image = Properties.Resources.tank2_right;
                    else
                        user.img.Image = user.img.Image = Properties.Resources.tank_right;

                    position = user.img.Location.X + 1;
                     user.img.Location = new System.Drawing.Point(position, 325);  
                    break;
                case Keys.None:
                  break;
                //왼쪽으로 이동
                case Keys.Left:
                  if (leftUser.getNowTurn())
                      user.img.Image = user.img.Image = Properties.Resources.tank2_left;
                  else
                      user.img.Image = user.img.Image = Properties.Resources.tank_left;
                  position = user.img.Location.X - 1;
                  user.img.Location = new System.Drawing.Point(position, 325);
                   break;
            }
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
        }



    }
}

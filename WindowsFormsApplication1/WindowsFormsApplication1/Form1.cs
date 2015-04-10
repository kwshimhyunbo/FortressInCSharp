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

        public Form1()
        {
           
            InitializeComponent();
        }

       

   

        private void Form1_Load(object sender, EventArgs e)
        {
            angle.Parent = pictureBox1;
            wind.Parent = pictureBox1;
            player2.Parent = pictureBox1;
            player1.Parent = pictureBox1;
        }


        public void gameStart()
        {
          
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
            switch (e.KeyCode)
            {
                //게임 시작
                case Keys.Space:
                    this.Close();
                     break;

                //오른쪽으로 이동
                case Keys.Right:
                     position = this.player1.Location.X + 1;
                     this.player1.Location = new System.Drawing.Point(position, 325);  
                    break;
                case Keys.None:
                  break;
                //왼쪽으로 이동
                case Keys.Left:
                  position = this.player1.Location.X - 1;
                  this.player1.Location = new System.Drawing.Point(position, 325);
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
        private int x;
        private int y;
        private int HP;

        public void init()
        {
            x = 0;
            y = 0;
            HP = 1500;
        }



    }
}

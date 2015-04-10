using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        PictureBox Player;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Player = new PictureBox();
            this.Player.Image = Properties.Resources.tank;
            this.Player.Location = new System.Drawing.Point(100, 100);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(30, 30);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
          
            this.Player.Parent = pictureBox1;
            
            this.Controls.Add(Player);

        }

       


    }
}

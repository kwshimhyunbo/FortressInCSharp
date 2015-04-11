using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Graphics _graphics = this.CreateGraphics();
            SolidBrush _brush = new SolidBrush(Color.Yellow);
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void DrawRectangleRectangle(PaintEventArgs e)
        {

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create rectangle.
            Rectangle rect = new Rectangle(0, 0, 200, 200);

            // Draw rectangle to screen.
            e.Graphics.DrawRectangle(blackPen, rect);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            // Graphics 객체를생성한다.
            Graphics _graphics = this.CreateGraphics();
            // 메인폼의Graphics 객체를통해바탕화면을희색으로Clear한다.
         
            // 노란색SolidBrush 객체를생성한다.
            SolidBrush _brush = new SolidBrush(Color.Yellow);
            // 노란색으로채워진사각형을그린다.
            _graphics.FillRectangle(_brush, 10, 180, 100, 165);
        }

        public void DrawRectangleRectangle(object sender, EventArgs e,PaintEventArgs s)
        {

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create rectangle.
            Rectangle rect = new Rectangle(0, 0, 200, 200);

            // Draw rectangle to screen.
            s.Graphics.DrawRectangle(blackPen, rect);
        }


        private void label2_Click(object sender, EventArgs e,PaintEventArgs s)
        {

                
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        }
    }
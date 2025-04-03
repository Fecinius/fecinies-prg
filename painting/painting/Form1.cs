using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace painting
{
    public partial class Form1 : Form
    {
        Graphics g;
        bool mouseMoving;
        Pen cursorPen;
        int mouseX;
        int mouseY;
        int penswitcher;
        int penSize;
        
        public Form1()
        {
           
            InitializeComponent();
            g = panelDraw.CreateGraphics();
            penSize = 8;
            cursorPen = new Pen(Color.Black, penSize);
            penswitcher = 0;
            if (penswitcher == 0)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                cursorPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                cursorPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            }
            else if (penswitcher == 1) 
            {
                int radius = penSize;
                float dotSizes = penSize / 8;


            }
 
        }

        private void pictureBoxBlack_Click(object sender, EventArgs e)
        {
            PictureBox color = (PictureBox)sender;
            cursorPen.Color = color.BackColor;
           
        }

        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            mouseMoving = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void panelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            mouseMoving = false;
            mouseX = -1;
            mouseY = -1;
        }

        private void panelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseMoving && mouseX != -1 && mouseY != -1) 
            { 
                if(penswitcher == 0)
                {
                    g.DrawLine(cursorPen, new Point(mouseX, mouseY), e.Location);
                    mouseX = e.X;
                    mouseY = e.Y;
                }
                else if (penswitcher == 1)
                {
                    
                    Random rng = new Random();
                    g.DrawLine()
                }
               
            }
        }
    }
}

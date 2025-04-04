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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

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
            penSize = 6;
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
                if (penswitcher == 0)
                {
                    cursorPen.Width = penSize;
                    g.DrawLine(cursorPen, new Point(mouseX, mouseY), e.Location);
                    mouseX = e.X;
                    mouseY = e.Y;
                }
                else if (penswitcher == 1)
                {

                    Random rng = new Random();
                    int radius = penSize;
                    cursorPen.Width = 2;

                    for (int i = 0; i < rng.Next(radius/2,radius*2); i++)
                    {
                        int sprayX = mouseX + rng.Next(-radius, radius + 1);
                        int sprayY = mouseY + rng.Next(-radius, radius + 1);
                        g.DrawLine(cursorPen, new Point(sprayX, sprayY), new Point(sprayX + 1, sprayY + 1)); 
                    }                   
                    mouseX = e.X;
                    mouseY = e.Y;
                }

            }
        }

        private void buttonClasicPen_Click(object sender, EventArgs e)
        {
            penswitcher = 0;
        }

        private void buttonSpray_Click(object sender, EventArgs e)
        {
            penswitcher = 1;
            if (penSize<8)
            {
                textBoxPenSize.Text = "8";
            }
        }

        private void textBoxPenSize_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPenSize.Text.Length == 0) return; // Prevents error on empty text

            if (int.TryParse(textBoxPenSize.Text, out int penSize) && penSize > 0 && penSize.ToString().Length<3 )
            {
                this.penSize = penSize;
            }
            else
            {
                //textBoxPenSize.Text = textBoxPenSize.Text.Remove(textBoxPenSize.Text.Length - 1);
                textBoxPenSize.Text = textBoxPenSize.Text.Substring(0, textBoxPenSize.Text.Length - 1);
                textBoxPenSize.SelectionStart = textBoxPenSize.Text.Length;
            }
        }
    }
}

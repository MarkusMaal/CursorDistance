using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursorDistance
{
    public partial class Form1 : Form
    {
        double seconds = 0.00;
        ulong[] lastmousepos = { 0, 0 };
        ulong distance = 0;
        int onedistance = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.BackColor = SystemColors.ActiveCaption;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            lastmousepos = newposition();
        }

        ulong[] newposition()
        {
            ulong x = Convert.ToUInt64(Cursor.Position.X);
            ulong y = Convert.ToUInt64(Cursor.Position.Y);
            ulong[] newlocation = { x, y };
            return newlocation;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            seconds += (1.00 / 29.00);
            ulong[] newlocate = newposition();
            if (((newlocate[0] - lastmousepos[0]) ^ 2) != 0.00)
            {
                ulong a = 0;
                if (newlocate[0] >= lastmousepos[0])
                {
                    a = newlocate[0] - lastmousepos[0];
                }
                else if (newlocate[0] < lastmousepos[0])
                {
                    a = lastmousepos[0] - newlocate[0];
                }
                ulong b = 0;
                if (newlocate[1] >= lastmousepos[1])
                {
                    b = newlocate[1] - lastmousepos[1];
                }
                else if (newlocate[1] < lastmousepos[1])
                {
                    b = lastmousepos[1] - newlocate[1];
                }
                ulong length = Convert.ToUInt64(Math.Sqrt(a^2 + b^2));
                distance += length;
                onedistance += Convert.ToInt32(length);
                pixelCount.Text = "Pixels travelled: " + distance;
            }
            lastmousepos = newlocate;
            secondCount.Text = "Time: " + Math.Round(seconds, 0).ToString() + " seconds";
            speedAverage.Text = "Average speed: " + Convert.ToString(Math.Round(Convert.ToDouble(distance) / seconds, 2)) + " px/s";
            label1.Location = new Point(Cursor.Position.X - (label1.Width / 2), Cursor.Position.Y - (label1.Height / 2));
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            currentSpeed.Text = "Current speed: " + Convert.ToString(onedistance * 20) + " px/s";
            onedistance = 0;
        }

        private void Label1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label1.Text = "L";
                label1.BackColor = Color.Red;
            }
            else if (e.Button == MouseButtons.Middle)
            {
                label1.Text = "M";
                label1.ForeColor = Color.Black;
                label1.BackColor = Color.Lime;
            }
            else if (e.Button == MouseButtons.Right)
            {
                label1.Text = "R";
                label1.BackColor = Color.Blue;
            }
            else if (e.Button == MouseButtons.None)
            {
                label1.ForeColor = Color.White;
                label1.Text = "";
                label1.BackColor = Color.DimGray;
            }
            if (e.Clicks >= 2)
            {
                label1.Text = e.Clicks.ToString() + label1.Text;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label1.Text = "L";
                label1.BackColor = Color.Red;
            }
            else if (e.Button == MouseButtons.Middle)
            {
                label1.Text = "M";
                label1.ForeColor = Color.Black;
                label1.BackColor = Color.Lime;
            }
            else if (e.Button == MouseButtons.Right)
            {
                label1.Text = "R";
                label1.BackColor = Color.Blue;
            }
            else if (e.Button == MouseButtons.None)
            {
                label1.ForeColor = Color.White;
                label1.Text = "";
                label1.BackColor = Color.DimGray;
            }
            if (e.Clicks >= 2)
            {
                label1.Text = e.Clicks.ToString() + label1.Text;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.White;
            label1.Text = "";
            label1.BackColor = Color.DimGray;
        }

        private void TextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label1.Text = "L";
                label1.BackColor = Color.Red;
            }
            else if (e.Button == MouseButtons.Middle)
            {
                label1.Text = "M";
                label1.ForeColor = Color.Black;
                label1.BackColor = Color.Lime;
            }
            else if (e.Button == MouseButtons.Right)
            {
                label1.Text = "R";
                label1.BackColor = Color.Blue;
            }
            else if (e.Button == MouseButtons.None)
            {
                label1.ForeColor = Color.White;
                label1.Text = "";
                label1.BackColor = Color.DimGray;
            }
            if (e.Clicks >= 2)
            {
                label1.Text = e.Clicks.ToString() + label1.Text;
            }
        }

        private void TextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.White;
            label1.Text = "";
            label1.BackColor = Color.DimGray;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.BrowserBack)
            {
                label1.ForeColor = Color.Black;
                label1.Text = "BB";
                label1.BackColor = Color.DeepSkyBlue;
                lastmousepos = newposition();
                seconds = 0.00;
                distance = 0;
                onedistance = 0;
            }
            else if (e.KeyCode == Keys.BrowserForward)
            {
                label1.ForeColor = Color.Black;
                label1.Text = "BF";
                label1.BackColor = Color.DeepPink;
            }
            else if (e.KeyCode == Keys.XButton1)
            {
                label1.Text = "X1";
                label1.ForeColor = Color.Black;
                label1.BackColor = Color.Aqua;
            }
            else if (e.KeyCode == Keys.XButton2)
            {
                label1.Text = "X2";
                label1.ForeColor = Color.Black;
                label1.BackColor = Color.LightGray;
            }
            else
            {
                label1.ForeColor = Color.Black;
                label1.Text = "Kbd";
                label1.BackColor = Color.Yellow;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            label1.ForeColor = Color.White;
            label1.Text = "";
            label1.BackColor = Color.DimGray;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.BrowserBack)
            {
                label1.ForeColor = Color.Black;
                label1.Text = "BB";
                label1.BackColor = Color.DeepSkyBlue;
                lastmousepos = newposition();
                seconds = 0.00;
                distance = 0;
                onedistance = 0;
            }
            else if (e.KeyCode == Keys.BrowserForward)
            {
                label1.ForeColor = Color.Black;
                label1.Text = "BF";
                label1.BackColor = Color.DeepPink;
            }
            else if (e.KeyCode == Keys.XButton1)
            {
                label1.Text = "X1";
                label1.ForeColor = Color.Black;
                label1.BackColor = Color.Aqua;
            }
            else if (e.KeyCode == Keys.XButton2)
            {
                label1.Text = "X2";
                label1.ForeColor = Color.Black;
                label1.BackColor = Color.LightGray;
            }
            else
            {
                label1.ForeColor = Color.Black;
                label1.Text = "Kbd";
                label1.BackColor = Color.Yellow;
            }
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            label1.ForeColor = Color.White;
            label1.Text = "";
            label1.BackColor = Color.DimGray;
        }
    }
}

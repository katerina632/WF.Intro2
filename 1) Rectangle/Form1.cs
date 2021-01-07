using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1__Rectangle
{
    public partial class Form1 : Form
    {
        readonly int distance = 10;        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Coords: {e.X} : {e.Y}";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {   
            if (e.Button == MouseButtons.Left)
            {
                label1.Visible = false;

                if (Control.ModifierKeys == Keys.Control)
                {
                    this.Close();
                }


                if (e.X >= 0 && e.X < distance || e.X > this.ClientSize.Width - distance && e.X <= this.ClientSize.Width
                    || e.Y >= 0 && e.Y < distance || e.Y > this.ClientSize.Height - distance && e.Y <= this.ClientSize.Height)
                {
                    MessageBox.Show("The current point is outside the rectangle");
                }
                else if (e.X == distance || e.X == this.ClientSize.Width - distance || 
                    e.Y == distance || e.Y == this.ClientSize.Height - distance)
                {
                    MessageBox.Show("The current point is on the bound of the rectangle");
                }
                else
                {
                    MessageBox.Show("The current point is inside the rectangle");
                }
            }

            if (e.Button == MouseButtons.Right)
            {
               label1.Visible = true;
               label1.Text= $"Client size width:  {this.ClientSize.Width}\n" +
                    $"Client size height: {this.ClientSize.Height}";
            }           
        }
       
    }
}

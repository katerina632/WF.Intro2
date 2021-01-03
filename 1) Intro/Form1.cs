using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1__Intro
{
    public partial class Form1 : Form
    {
        int countAttempts = 0;        

        public Form1()
        {

            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {                       

            //foreach (TextBox tb in this.Controls.OfType<TextBox>())
            //{
            //    if (string.IsNullOrEmpty(tb.Text))
            //    {
            //        MessageBox.Show("Please fill in all empty fields!", "Error!", MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);                 
            //        return;                    
            //    }
            //}
            
                int minNumber = 1;
                int maxNumber = 100;

                Random rand = new Random();
                int number = rand.Next(minNumber, maxNumber);
                bool isGuessed = false;

                do
                {
                    countAttempts++;
                    DialogResult res = MessageBox.Show($"Did I guess the number? ", $"Number {number}", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        MessageBox.Show($"The number is guessed in {countAttempts} attempts", "Great!");
                        isGuessed = true;
                        countAttempts = 0;
                    }
                    else
                    {
                        DialogResult res2 = MessageBox.Show("Is the number bigger? ", $"My number - {number}", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                        if (res2 == DialogResult.Yes)
                        {
                            minNumber = number + 1;
                            number = rand.Next(minNumber, maxNumber);
                        }
                        else if (res2 == DialogResult.Cancel)
                        {
                            this.Close();
                        }
                        else
                        {
                            maxNumber = number - 1;
                            number = rand.Next(minNumber, maxNumber);
                        }

                    }
                } while (!isGuessed);          
        }
    }
}

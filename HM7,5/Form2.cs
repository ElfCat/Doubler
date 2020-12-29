using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM7_5
{
    public partial class Form2 : Form 
    {
        public int userNumber;
        public int num;
        public int counter = 0;


        public Form2()
        {
            InitializeComponent();
            tBoxGuess.Text = "Guess a number in 10 turns";
        }

        public int userAnswer
        {
            get { return int.Parse(tboxAnswer.Text); }
        }

        private void Check(int num, int userNumber)
        {
            if (counter < 10)
            {
                if (num == userNumber)
                {
                    tBoxGuess.Text = "You guessed right!!! Good job friend 😀!";
                    btnDisable();
                }
                else if (userNumber > num)
                {
                    counter++;
                    tBoxGuess.Text = "Your number biger then given\nTurns left " + counter;
                }
                else if (userNumber < num)
                {
                    counter++;
                    tBoxGuess.Text = "Your number smaller then given\nTurns left " + counter;
                }
            }
            else
            {
                tBoxGuess.Text = "Your loose(\nYour turns bigger then given. Number was " + num;
                btnDisable();
            }
        }
        private void btnDisable()
        {
            tboxAnswer.Enabled = false;
            btnEnter.Enabled = false;
            btnGen.Enabled = false;
        }

        private void tboxAnswer_TextChanged(object sender, EventArgs e)
        {
            userNumber = Convert.ToInt32(tboxAnswer.Text);
        }

        private void btnGen_Click(object sender, EventArgs e)
        {

            //int num = 10;
            Random rand = new Random();
            num = rand.Next(0, 100);
            if (btnGen.Enabled)
            {
                tboxAnswer.Enabled = true;
                btnEnter.Enabled = true;
            }
            else
            {
                tboxAnswer.Enabled = false;
                btnEnter.Enabled = false;
            }
            btnGen.Enabled = false;
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Check(num, userNumber);
        }

    }
}

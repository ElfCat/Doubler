using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM7_5
{
    public partial class Doubler : Form
    {
        public int counter = 0;
        public int userNumber, userCount;

        public Doubler()
        {
            InitializeComponent();
            btnPlus.Text = "+1";
            btnDouble.Text = "x2";
            btnReset.Text = "Reset";
            lblNumber.Text = "0";
            lblCount.Text = "0";
            this.Text = "Doubler";

            btnDisable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!btnBack.Enabled)
            {
                btnBack.Enabled = true;
            }
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            counter++;
            lblCount.Text = (counter).ToString();
            Check(int.Parse(lblNumber.Text), counter);
            remove.Push(lblNumber.Text);

        }

        private void Check(int num, int c)
        {
            if (num == userNumber && c == userCount)
            {
                lblGetNum.Text = "You did it!!! Good job friend 😀!";
                btnDisable();

            }
            else if (c > userCount)
            {
                lblGetNum.Text = "You failed 😥\nYour moves biger then given";
                btnDisable();
            }
            else if (userNumber < num)
            {
                lblGetNum.Text = "You failed 😥\nYour number biger then given";
                btnDisable();
            }
        }

        public Stack remove = new Stack();
        

        private void btnDisable()
        {
            btnPlus.Enabled = false;
            btnDouble.Enabled = false;
            btnReset.Enabled = false;
            btnBack.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!btnBack.Enabled)
            {
                btnBack.Enabled = true;
            }
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            counter++;
            lblCount.Text = (counter).ToString();
            Check(int.Parse(lblNumber.Text), counter);
            remove.Push(lblNumber.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            lblNumber.Text = "0";
            lblCount.Text = "0";
            counter = 0;
            btnBack.Enabled = false;
            remove.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCount_Click(object sender, EventArgs e)
        {
           
        }

        private void Doubler_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            var rand = new Random();
            userNumber = rand.Next(1, 100);

            lblNumber.Text = "0";
            lblCount.Text = "0";
            counter = 0;

            btnPlus.Enabled = true;
            btnDouble.Enabled = true;
            btnReset.Enabled = true;
            btnBack.Enabled = true;

            userCount = GetStep(userNumber);
            lblGetNum.Text = "Get number - " + userNumber + " with minimum moves - " + userCount;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            remove.Pop();
            if (remove.Count == 0)
            {
                lblNumber.Text = "0";
                lblCount.Text = "0";
                counter = 0;
                btnBack.Enabled = false;
            }
            else
            {
                lblNumber.Text = (string)remove.Peek();
                counter = counter - 1;
                lblCount.Text = counter.ToString();
            }
        }

        private static int GetStep(int userNumber)
        {
            int tempNum = userNumber;
            int step = 0;
            while(tempNum != 0)
            {
                if (tempNum % 2 == 0)
                {
                    tempNum = tempNum / 2;
                    step++;
                } else
                {
                    tempNum = tempNum - 1;
                    step++;
                }
            }

            return step;
        }
    }
}

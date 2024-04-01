using System;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private enum Operations
        {
            Plus,
            Minus,
            Multi,
            Division
        }

        private Operations Operation { get; set; }
        public double Value { get; set; }
        public double Result { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        public void Num(double num)
        {
            if (TextNumbers.Text == "0")
            {
                TextNumbers.Text = num.ToString();
            }
            else
            {
                TextNumbers.Text += num.ToString();
            }
        }

        private void TextNumbers_Click(object sender, EventArgs e)
        {
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Num(0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Num(9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Num(8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Num(7);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Num(6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Num(5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Num(4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Num(3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Num(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Num(1);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            TextNumbers.Text = "0";
            Operation = new Operations();
            Value = 0;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            Operation = Operations.Division;
            Value = double.Parse(TextNumbers.Text);
            TextNumbers.Text = "";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            Operation = Operations.Multi;
            Value = double.Parse(TextNumbers.Text);
            TextNumbers.Text = "";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Operation = Operations.Plus;
            Value = double.Parse(TextNumbers.Text);
            TextNumbers.Text = "";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Operation = Operations.Minus;
            Value = double.Parse(TextNumbers.Text);
            TextNumbers.Text = "";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Operation)
                {
                    case Operations.Plus:
                        Result = Value + double.Parse(TextNumbers.Text);
                        TextNumbers.Text = Result.ToString();
                        break;
                    case Operations.Minus:
                        Result = Value - double.Parse(TextNumbers.Text);
                        TextNumbers.Text = Result.ToString();
                        break;
                    case Operations.Multi:
                        Result = Value * double.Parse(TextNumbers.Text);
                        TextNumbers.Text = Result.ToString();
                        break;
                    case Operations.Division:
                        Result = Value / double.Parse(TextNumbers.Text);
                        TextNumbers.Text = Result.ToString();
                        break;
                }
            }
            catch (FormatException)
            {
                TextNumbers.Text = "Error";
            }
        }
    }
}
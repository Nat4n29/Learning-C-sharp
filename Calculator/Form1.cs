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

        public double ValuePercent { get; set; }
        public bool showingResult { get; set; }

        private Operations Operation { get; set; }
        public double Value { get; set; }
        public double Result { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        public void Num(double num)
        {
            if (TextNumbers.Text == "0" || TextNumbers.Text == "-" || TextNumbers.Text == "+" || TextNumbers.Text == "x" || TextNumbers.Text == "/")
            {
                TextNumbers.Text = num.ToString();
            }
            else
            {
                TextNumbers.Text += num.ToString();
            }
        }

        private void TextNumbers_Click(object sender, EventArgs e) { }

        private void button0_Click(object sender, EventArgs e)
        {
            if (showingResult)
            {
                TextNumbers.Text = "";
                showingResult = false;
            }
            Num(0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (showingResult)
            {
                TextNumbers.Text = "";
                showingResult = false;
            }
            Num(9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (showingResult)
            {
                TextNumbers.Text = "";
                showingResult = false;
            }
            Num(8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (showingResult)
            {
                TextNumbers.Text = "";
                showingResult = false;
            }
            Num(7);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (showingResult)
            {
                TextNumbers.Text = "";
                showingResult = false;
            }
            Num(6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (showingResult)
            {
                TextNumbers.Text = "";
                showingResult = false;
            }
            Num(5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (showingResult)
            {
                TextNumbers.Text = "";
                showingResult = false;
            }
            Num(4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (showingResult)
            {
                TextNumbers.Text = "";
                showingResult = false;
            }
            Num(3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (showingResult)
            {
                TextNumbers.Text = "";
                showingResult = false;
            }
            Num(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (showingResult)
            {
                TextNumbers.Text = "";
                showingResult = false;
            }
            Num(1);
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (TextNumbers.Text != "0")
            {
                TextNumbers.Text += ".";
            }
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextNumbers.Text != "0")
                {
                    double valueP = double.Parse(TextNumbers.Text);
                    ValuePercent = (double)valueP / 100;
                    TextNumbers.Text = ValuePercent.ToString();
                }
            }
            catch (FormatException)
            {
                TextNumbers.Text = "Error";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            TextNumbers.Text = "0";
            TextM.Text = "";
            Operation = new Operations();
            Value = 0;
        }

        private void buttonLClear_Click(object sender, EventArgs e)
        {
            if (TextNumbers.Text != "+" && TextNumbers.Text != "-" && TextNumbers.Text != "x" && TextNumbers.Text != "/" && TextNumbers.Text != ".")
            {
                if (TextNumbers.Text.Length > 0)
                {
                    TextNumbers.Text = TextNumbers.Text.Remove(TextNumbers.Text.Length - 1);
                    if (TextNumbers.Text.Length == 0)
                    {
                        TextNumbers.Text = "0";
                    }
                }
                else
                {
                    TextNumbers.Text = "0";
                }
            }
        }

        //Operators

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            Operation = Operations.Division;
            Value = double.Parse(TextNumbers.Text);
            TextNumbers.Text = "/";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            Operation = Operations.Multi;
            Value = double.Parse(TextNumbers.Text);
            TextNumbers.Text = "x";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Operation = Operations.Plus;
            Value = double.Parse(TextNumbers.Text);
            TextNumbers.Text = "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Operation = Operations.Minus;
            Value = double.Parse(TextNumbers.Text);
            TextNumbers.Text = "-";
        }

        //Memorie

        private void TextM_Click(object sender, EventArgs e) { }

        private void buttonMminus_Click(object sender, EventArgs e)
        {
            TextM.Text = "";
        }

        private void buttonMplus_Click(object sender, EventArgs e)
        {
            if (TextNumbers.Text != "+" && TextNumbers.Text != "-" && TextNumbers.Text != "x" && TextNumbers.Text != "/" && TextNumbers.Text != ".")
            {
                TextM.Text = TextNumbers.Text;
                TextNumbers.Text = "";
            }
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            if (TextNumbers.Text == "0" || TextNumbers.Text == "-" || TextNumbers.Text == "+" || TextNumbers.Text == "x" || TextNumbers.Text == "/")
            {
                TextNumbers.Text = TextM.Text;
            }
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
                        Operation = new Operations();
                        break;
                    case Operations.Minus:
                        Result = Value - double.Parse(TextNumbers.Text);
                        TextNumbers.Text = Result.ToString();
                        Operation = new Operations();
                        break;
                    case Operations.Multi:
                        Result = Value * double.Parse(TextNumbers.Text);
                        TextNumbers.Text = Result.ToString();
                        Operation = new Operations();
                        break;
                    case Operations.Division:
                        Result = Value / double.Parse(TextNumbers.Text);
                        TextNumbers.Text = Result.ToString();
                        Operation = new Operations();
                        break;
                }

                showingResult = true;
            }
            catch (FormatException)
            {
                TextNumbers.Text = "Error";
            }
        }
    }
}

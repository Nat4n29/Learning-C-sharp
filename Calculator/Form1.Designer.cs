namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button0 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonEquals = new Button();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonMulti = new Button();
            buttonDivision = new Button();
            buttonClear = new Button();
            TextNumbers = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(17, 233);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 11;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(73, 233);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 12;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(129, 233);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 13;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button0
            // 
            button0.Location = new Point(73, 289);
            button0.Name = "button0";
            button0.Size = new Size(50, 50);
            button0.TabIndex = 15;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // button4
            // 
            button4.Location = new Point(17, 177);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 7;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(73, 177);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 8;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(129, 177);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 9;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(17, 121);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 3;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(73, 121);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 4;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(129, 121);
            button9.Name = "button9";
            button9.Size = new Size(50, 50);
            button9.TabIndex = 5;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.BackColor = SystemColors.Highlight;
            buttonEquals.ForeColor = SystemColors.ControlLightLight;
            buttonEquals.Location = new Point(185, 289);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(50, 50);
            buttonEquals.TabIndex = 16;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = false;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(185, 233);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(50, 50);
            buttonPlus.TabIndex = 14;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(185, 177);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(50, 50);
            buttonMinus.TabIndex = 10;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonMulti
            // 
            buttonMulti.Location = new Point(185, 121);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(50, 50);
            buttonMulti.TabIndex = 6;
            buttonMulti.Text = "x";
            buttonMulti.UseVisualStyleBackColor = true;
            buttonMulti.Click += buttonMulti_Click;
            // 
            // buttonDivision
            // 
            buttonDivision.Location = new Point(185, 65);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(50, 50);
            buttonDivision.TabIndex = 2;
            buttonDivision.Text = "/";
            buttonDivision.UseVisualStyleBackColor = true;
            buttonDivision.Click += buttonDivision_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(129, 65);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(50, 50);
            buttonClear.TabIndex = 1;
            buttonClear.Text = "CE";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // TextNumbers
            // 
            TextNumbers.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TextNumbers.Location = new Point(17, 16);
            TextNumbers.Name = "TextNumbers";
            TextNumbers.Size = new Size(218, 32);
            TextNumbers.TabIndex = 0;
            TextNumbers.Text = "0";
            TextNumbers.TextAlign = ContentAlignment.TopRight;
            TextNumbers.Click += TextNumbers_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 349);
            Controls.Add(TextNumbers);
            Controls.Add(buttonClear);
            Controls.Add(buttonDivision);
            Controls.Add(buttonMulti);
            Controls.Add(button9);
            Controls.Add(buttonMinus);
            Controls.Add(button6);
            Controls.Add(buttonEquals);
            Controls.Add(buttonPlus);
            Controls.Add(button3);
            Controls.Add(button0);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Calculator Test";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button0;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonEquals;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMulti;
        private Button buttonDivision;
        private Button buttonClear;
        private Label TextNumbers;
    }
}
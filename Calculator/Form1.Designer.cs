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
            buttonPoint = new Button();
            buttonPercent = new Button();
            buttonM = new Button();
            buttonMminus = new Button();
            buttonMplus = new Button();
            TextM = new Label();
            buttonLClear = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(17, 233);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 16;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(73, 233);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 17;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(129, 233);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 18;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button0
            // 
            button0.Location = new Point(73, 289);
            button0.Name = "button0";
            button0.Size = new Size(50, 50);
            button0.TabIndex = 20;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // button4
            // 
            button4.Location = new Point(17, 177);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 11;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(73, 177);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 12;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(129, 177);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 13;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(17, 121);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(73, 121);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(129, 121);
            button9.Name = "button9";
            button9.Size = new Size(50, 50);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.BackColor = SystemColors.Highlight;
            buttonEquals.ForeColor = SystemColors.ControlLightLight;
            buttonEquals.Location = new Point(185, 233);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(50, 106);
            buttonEquals.TabIndex = 22;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = false;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.BackColor = SystemColors.ButtonFace;
            buttonPlus.Location = new Point(185, 202);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(50, 25);
            buttonPlus.TabIndex = 15;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = SystemColors.ButtonFace;
            buttonMinus.Location = new Point(185, 177);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(50, 25);
            buttonMinus.TabIndex = 14;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonMulti
            // 
            buttonMulti.BackColor = SystemColors.ButtonFace;
            buttonMulti.Location = new Point(185, 146);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(50, 25);
            buttonMulti.TabIndex = 10;
            buttonMulti.Text = "x";
            buttonMulti.UseVisualStyleBackColor = false;
            buttonMulti.Click += buttonMulti_Click;
            // 
            // buttonDivision
            // 
            buttonDivision.BackColor = SystemColors.ButtonFace;
            buttonDivision.Location = new Point(185, 121);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(50, 25);
            buttonDivision.TabIndex = 9;
            buttonDivision.Text = "/";
            buttonDivision.UseVisualStyleBackColor = false;
            buttonDivision.Click += buttonDivision_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Firebrick;
            buttonClear.ForeColor = SystemColors.ControlLightLight;
            buttonClear.Location = new Point(17, 65);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(50, 50);
            buttonClear.TabIndex = 1;
            buttonClear.Text = "CE";
            buttonClear.UseVisualStyleBackColor = false;
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
            TextNumbers.TextAlign = ContentAlignment.MiddleRight;
            TextNumbers.Click += TextNumbers_Click;
            // 
            // buttonPoint
            // 
            buttonPoint.Location = new Point(129, 289);
            buttonPoint.Name = "buttonPoint";
            buttonPoint.Size = new Size(50, 50);
            buttonPoint.TabIndex = 21;
            buttonPoint.Text = ".";
            buttonPoint.UseVisualStyleBackColor = true;
            buttonPoint.Click += buttonPoint_Click;
            // 
            // buttonPercent
            // 
            buttonPercent.Location = new Point(17, 289);
            buttonPercent.Name = "buttonPercent";
            buttonPercent.Size = new Size(50, 50);
            buttonPercent.TabIndex = 19;
            buttonPercent.Text = "%";
            buttonPercent.UseVisualStyleBackColor = true;
            buttonPercent.Click += buttonPercent_Click;
            // 
            // buttonM
            // 
            buttonM.Location = new Point(73, 65);
            buttonM.Name = "buttonM";
            buttonM.Size = new Size(50, 50);
            buttonM.TabIndex = 2;
            buttonM.Text = "M";
            buttonM.UseVisualStyleBackColor = true;
            buttonM.Click += buttonM_Click;
            // 
            // buttonMminus
            // 
            buttonMminus.Location = new Point(129, 90);
            buttonMminus.Name = "buttonMminus";
            buttonMminus.Size = new Size(50, 25);
            buttonMminus.TabIndex = 4;
            buttonMminus.Text = "M -";
            buttonMminus.UseVisualStyleBackColor = true;
            buttonMminus.Click += buttonMminus_Click;
            // 
            // buttonMplus
            // 
            buttonMplus.Location = new Point(129, 65);
            buttonMplus.Name = "buttonMplus";
            buttonMplus.Size = new Size(50, 25);
            buttonMplus.TabIndex = 3;
            buttonMplus.Text = "M +";
            buttonMplus.UseVisualStyleBackColor = true;
            buttonMplus.Click += buttonMplus_Click;
            // 
            // TextM
            // 
            TextM.AutoSize = true;
            TextM.Location = new Point(17, 9);
            TextM.Name = "TextM";
            TextM.Size = new Size(0, 15);
            TextM.TabIndex = 23;
            TextM.Click += TextM_Click;
            // 
            // buttonLClear
            // 
            buttonLClear.BackColor = Color.FromArgb(255, 192, 192);
            buttonLClear.Location = new Point(185, 65);
            buttonLClear.Name = "buttonLClear";
            buttonLClear.Size = new Size(50, 50);
            buttonLClear.TabIndex = 5;
            buttonLClear.Text = "<--";
            buttonLClear.UseVisualStyleBackColor = false;
            buttonLClear.Click += buttonLClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 349);
            Controls.Add(buttonLClear);
            Controls.Add(TextM);
            Controls.Add(TextNumbers);
            Controls.Add(buttonClear);
            Controls.Add(buttonMplus);
            Controls.Add(buttonMminus);
            Controls.Add(buttonM);
            Controls.Add(buttonDivision);
            Controls.Add(buttonMulti);
            Controls.Add(button9);
            Controls.Add(buttonMinus);
            Controls.Add(button6);
            Controls.Add(buttonEquals);
            Controls.Add(buttonPlus);
            Controls.Add(button3);
            Controls.Add(buttonPercent);
            Controls.Add(buttonPoint);
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
            PerformLayout();
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
        private Button buttonPoint;
        private Button buttonPercent;
        private Button buttonM;
        private Button buttonMminus;
        private Button buttonMplus;
        private Label TextM;
        private Button buttonLClear;
    }
}
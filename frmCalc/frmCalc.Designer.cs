using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace frmCalc
{
    partial class frmCalc
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
            buttonM = new Button();
            buttonC = new Button();
            buttonDiv = new Button();
            buttonMulti = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMinus = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnPlus = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            button17 = new Button();
            button18 = new Button();
            button16 = new Button();
            txtDisplay = new TextBox();
            SuspendLayout();
            // 
            // buttonM
            // 
            buttonM.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonM.Location = new Point(12, 111);
            buttonM.Name = "buttonM";
            buttonM.Size = new Size(59, 55);
            buttonM.TabIndex = 0;
            buttonM.Text = "<";
            buttonM.UseVisualStyleBackColor = true;
            buttonM.Click += backspaceClick;
            // 
            // buttonC
            // 
            buttonC.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonC.Location = new Point(91, 111);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(59, 55);
            buttonC.TabIndex = 2;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += ClickClear;
            // 
            // buttonDiv
            // 
            buttonDiv.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDiv.Location = new Point(168, 111);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(59, 55);
            buttonDiv.TabIndex = 3;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += operClick;
            // 
            // buttonMulti
            // 
            buttonMulti.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMulti.Location = new Point(246, 111);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(59, 55);
            buttonMulti.TabIndex = 4;
            buttonMulti.Text = "*";
            buttonMulti.UseVisualStyleBackColor = true;
            buttonMulti.Click += operClick;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(12, 182);
            btn1.Name = "btn1";
            btn1.Size = new Size(59, 55);
            btn1.TabIndex = 5;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += BtnActionNumber;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(91, 182);
            btn2.Name = "btn2";
            btn2.Size = new Size(59, 55);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += BtnActionNumber;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(168, 182);
            btn3.Name = "btn3";
            btn3.Size = new Size(59, 55);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += BtnActionNumber;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinus.Location = new Point(246, 182);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(59, 55);
            btnMinus.TabIndex = 8;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += operClick;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(12, 256);
            btn4.Name = "btn4";
            btn4.Size = new Size(59, 55);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += BtnActionNumber;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(91, 256);
            btn5.Name = "btn5";
            btn5.Size = new Size(59, 55);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += BtnActionNumber;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.Location = new Point(168, 256);
            btn6.Name = "btn6";
            btn6.Size = new Size(59, 55);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += BtnActionNumber;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlus.Location = new Point(246, 256);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(59, 55);
            btnPlus.TabIndex = 12;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += operClick;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(15, 332);
            btn7.Name = "btn7";
            btn7.Size = new Size(59, 55);
            btn7.TabIndex = 13;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += BtnActionNumber;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.Location = new Point(91, 332);
            btn8.Name = "btn8";
            btn8.Size = new Size(59, 55);
            btn8.TabIndex = 14;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += BtnActionNumber;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.Location = new Point(168, 332);
            btn9.Name = "btn9";
            btn9.Size = new Size(59, 55);
            btn9.TabIndex = 15;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += BtnActionNumber;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button17.Location = new Point(15, 405);
            button17.Name = "button17";
            button17.Size = new Size(135, 55);
            button17.TabIndex = 17;
            button17.Text = "0";
            button17.UseVisualStyleBackColor = true;
            button17.Click += BtnActionNumber;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button18.Location = new Point(168, 404);
            button18.Name = "button18";
            button18.Size = new Size(59, 55);
            button18.TabIndex = 18;
            button18.Text = ",";
            button18.UseVisualStyleBackColor = true;
            button18.Click += BtnActionNumber;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button16.Location = new Point(246, 332);
            button16.Name = "button16";
            button16.Size = new Size(63, 127);
            button16.TabIndex = 19;
            button16.Text = "=";
            button16.UseVisualStyleBackColor = true;
            button16.Click += actions;
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(290, 71);
            txtDisplay.TabIndex = 20;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.Click += BtnActionNumber;
            // 
            // frmCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(318, 475);
            Controls.Add(txtDisplay);
            Controls.Add(button16);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnPlus);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMinus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(buttonMulti);
            Controls.Add(buttonDiv);
            Controls.Add(buttonC);
            Controls.Add(buttonM);
            Name = "frmCalc";
            Text = "Calculator";
            Click += operClick;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button buttonM;
        private Button buttonC;
        private Button buttonDiv;
        private Button buttonMulti;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnMinus;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnPlus;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button button17;
        private Button button18;
        private Button button16;
        private TextBox txtDisplay;
    }
}
namespace SimpleCalculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Zero = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.DivisionSign = new System.Windows.Forms.Button();
            this.MultiplicationSign = new System.Windows.Forms.Button();
            this.SubtractionSign = new System.Windows.Forms.Button();
            this.AdditionSign = new System.Windows.Forms.Button();
            this.EqualSign = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Exponent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Zero
            // 
            this.Zero.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Zero.Location = new System.Drawing.Point(12, 183);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(56, 41);
            this.Zero.TabIndex = 11;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.One.Location = new System.Drawing.Point(12, 136);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(56, 41);
            this.One.TabIndex = 8;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Two.Location = new System.Drawing.Point(74, 136);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(56, 41);
            this.Two.TabIndex = 9;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Three.Location = new System.Drawing.Point(136, 136);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(56, 41);
            this.Three.TabIndex = 10;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Four
            // 
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Four.Location = new System.Drawing.Point(12, 89);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(56, 41);
            this.Four.TabIndex = 5;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Five.Location = new System.Drawing.Point(74, 89);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(56, 41);
            this.Five.TabIndex = 6;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Six.Location = new System.Drawing.Point(136, 89);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(56, 41);
            this.Six.TabIndex = 7;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Seven
            // 
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Seven.Location = new System.Drawing.Point(12, 42);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(56, 41);
            this.Seven.TabIndex = 1;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Eight
            // 
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Eight.Location = new System.Drawing.Point(74, 42);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(56, 41);
            this.Eight.TabIndex = 3;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Nine
            // 
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Nine.Location = new System.Drawing.Point(136, 42);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(56, 41);
            this.Nine.TabIndex = 4;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Dot
            // 
            this.Dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Dot.Location = new System.Drawing.Point(74, 183);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(56, 41);
            this.Dot.TabIndex = 16;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // DivisionSign
            // 
            this.DivisionSign.BackColor = System.Drawing.Color.SandyBrown;
            this.DivisionSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DivisionSign.Location = new System.Drawing.Point(198, 89);
            this.DivisionSign.Name = "DivisionSign";
            this.DivisionSign.Size = new System.Drawing.Size(56, 41);
            this.DivisionSign.TabIndex = 20;
            this.DivisionSign.Text = "/";
            this.DivisionSign.UseVisualStyleBackColor = false;
            this.DivisionSign.Click += new System.EventHandler(this.DivisionSign_Click);
            // 
            // MultiplicationSign
            // 
            this.MultiplicationSign.BackColor = System.Drawing.Color.SandyBrown;
            this.MultiplicationSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MultiplicationSign.Location = new System.Drawing.Point(198, 136);
            this.MultiplicationSign.Name = "MultiplicationSign";
            this.MultiplicationSign.Size = new System.Drawing.Size(56, 41);
            this.MultiplicationSign.TabIndex = 12;
            this.MultiplicationSign.Text = "*";
            this.MultiplicationSign.UseVisualStyleBackColor = false;
            this.MultiplicationSign.Click += new System.EventHandler(this.MultiplicationSign_Click);
            // 
            // SubtractionSign
            // 
            this.SubtractionSign.BackColor = System.Drawing.Color.SandyBrown;
            this.SubtractionSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SubtractionSign.Location = new System.Drawing.Point(198, 183);
            this.SubtractionSign.Name = "SubtractionSign";
            this.SubtractionSign.Size = new System.Drawing.Size(56, 41);
            this.SubtractionSign.TabIndex = 13;
            this.SubtractionSign.Text = "-";
            this.SubtractionSign.UseVisualStyleBackColor = false;
            this.SubtractionSign.Click += new System.EventHandler(this.SubtractionSign_Click);
            // 
            // AdditionSign
            // 
            this.AdditionSign.BackColor = System.Drawing.Color.SandyBrown;
            this.AdditionSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AdditionSign.Location = new System.Drawing.Point(198, 230);
            this.AdditionSign.Name = "AdditionSign";
            this.AdditionSign.Size = new System.Drawing.Size(56, 41);
            this.AdditionSign.TabIndex = 14;
            this.AdditionSign.Text = "+";
            this.AdditionSign.UseVisualStyleBackColor = false;
            this.AdditionSign.Click += new System.EventHandler(this.AdditionSign_Click);
            // 
            // EqualSign
            // 
            this.EqualSign.BackColor = System.Drawing.Color.SandyBrown;
            this.EqualSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EqualSign.Location = new System.Drawing.Point(12, 230);
            this.EqualSign.Name = "EqualSign";
            this.EqualSign.Size = new System.Drawing.Size(180, 41);
            this.EqualSign.TabIndex = 15;
            this.EqualSign.Text = "=";
            this.EqualSign.UseVisualStyleBackColor = false;
            this.EqualSign.Click += new System.EventHandler(this.EqualSign_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Clear.Location = new System.Drawing.Point(136, 183);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(56, 41);
            this.Clear.TabIndex = 21;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exponent
            // 
            this.Exponent.BackColor = System.Drawing.Color.SandyBrown;
            this.Exponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Exponent.Location = new System.Drawing.Point(198, 42);
            this.Exponent.Name = "Exponent";
            this.Exponent.Size = new System.Drawing.Size(56, 41);
            this.Exponent.TabIndex = 22;
            this.Exponent.Text = "^";
            this.Exponent.UseVisualStyleBackColor = false;
            this.Exponent.Click += new System.EventHandler(this.Exponent_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 288);
            this.Controls.Add(this.Exponent);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.DivisionSign);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.EqualSign);
            this.Controls.Add(this.AdditionSign);
            this.Controls.Add(this.SubtractionSign);
            this.Controls.Add(this.MultiplicationSign);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Seven);
            this.Name = "Calculator";
            this.Text = "Scientific Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button DivisionSign;
        private System.Windows.Forms.Button MultiplicationSign;
        private System.Windows.Forms.Button SubtractionSign;
        private System.Windows.Forms.Button AdditionSign;
        private System.Windows.Forms.Button EqualSign;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exponent;
    }
}


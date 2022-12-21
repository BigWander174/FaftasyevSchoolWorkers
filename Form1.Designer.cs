namespace FaftasyevSchoolWorkers
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.firstMonthLabel = new System.Windows.Forms.Label();
            this.secondMonthLabel = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.thirdMonthLabel = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.fourthMonthLabel = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.LCoefLabel = new System.Windows.Forms.Label();
            this.lTextBox = new System.Windows.Forms.TextBox();
            this.jTextBox = new System.Windows.Forms.TextBox();
            this.JCoefLabel = new System.Windows.Forms.Label();
            this.hTextBox = new System.Windows.Forms.TextBox();
            this.HCoefLabel = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(28, 32);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // firstMonthLabel
            // 
            this.firstMonthLabel.AutoSize = true;
            this.firstMonthLabel.Location = new System.Drawing.Point(28, 9);
            this.firstMonthLabel.Name = "firstMonthLabel";
            this.firstMonthLabel.Size = new System.Drawing.Size(112, 20);
            this.firstMonthLabel.TabIndex = 1;
            this.firstMonthLabel.Text = "Первый месяц";
            // 
            // secondMonthLabel
            // 
            this.secondMonthLabel.AutoSize = true;
            this.secondMonthLabel.Location = new System.Drawing.Point(210, 9);
            this.secondMonthLabel.Name = "secondMonthLabel";
            this.secondMonthLabel.Size = new System.Drawing.Size(107, 20);
            this.secondMonthLabel.TabIndex = 3;
            this.secondMonthLabel.Text = "Второй месяц";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(210, 32);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // thirdMonthLabel
            // 
            this.thirdMonthLabel.AutoSize = true;
            this.thirdMonthLabel.Location = new System.Drawing.Point(404, 9);
            this.thirdMonthLabel.Name = "thirdMonthLabel";
            this.thirdMonthLabel.Size = new System.Drawing.Size(105, 20);
            this.thirdMonthLabel.TabIndex = 5;
            this.thirdMonthLabel.Text = "Третий месяц";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(404, 32);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown3.TabIndex = 4;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // fourthMonthLabel
            // 
            this.fourthMonthLabel.AutoSize = true;
            this.fourthMonthLabel.Location = new System.Drawing.Point(606, 9);
            this.fourthMonthLabel.Name = "fourthMonthLabel";
            this.fourthMonthLabel.Size = new System.Drawing.Size(131, 20);
            this.fourthMonthLabel.TabIndex = 7;
            this.fourthMonthLabel.Text = "Четвертый месяц";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(606, 32);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown4.TabIndex = 6;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // LCoefLabel
            // 
            this.LCoefLabel.AutoSize = true;
            this.LCoefLabel.Location = new System.Drawing.Point(28, 110);
            this.LCoefLabel.Name = "LCoefLabel";
            this.LCoefLabel.Size = new System.Drawing.Size(26, 20);
            this.LCoefLabel.TabIndex = 8;
            this.LCoefLabel.Text = "L=";
            // 
            // lTextBox
            // 
            this.lTextBox.Location = new System.Drawing.Point(60, 106);
            this.lTextBox.Name = "lTextBox";
            this.lTextBox.Size = new System.Drawing.Size(125, 27);
            this.lTextBox.TabIndex = 9;
            this.lTextBox.Text = "0";
            this.lTextBox.Validated += new System.EventHandler(this.hTextBox_Validated);
            // 
            // jTextBox
            // 
            this.jTextBox.Location = new System.Drawing.Point(60, 139);
            this.jTextBox.Name = "jTextBox";
            this.jTextBox.Size = new System.Drawing.Size(125, 27);
            this.jTextBox.TabIndex = 11;
            this.jTextBox.Text = "0";
            this.jTextBox.Validated += new System.EventHandler(this.hTextBox_Validated);
            // 
            // JCoefLabel
            // 
            this.JCoefLabel.AutoSize = true;
            this.JCoefLabel.Location = new System.Drawing.Point(30, 142);
            this.JCoefLabel.Name = "JCoefLabel";
            this.JCoefLabel.Size = new System.Drawing.Size(24, 20);
            this.JCoefLabel.TabIndex = 10;
            this.JCoefLabel.Text = "J=";
            // 
            // hTextBox
            // 
            this.hTextBox.Location = new System.Drawing.Point(60, 172);
            this.hTextBox.Name = "hTextBox";
            this.hTextBox.Size = new System.Drawing.Size(125, 27);
            this.hTextBox.TabIndex = 13;
            this.hTextBox.Text = "0";
            this.hTextBox.Validated += new System.EventHandler(this.hTextBox_Validated);
            // 
            // HCoefLabel
            // 
            this.HCoefLabel.AutoSize = true;
            this.HCoefLabel.Location = new System.Drawing.Point(28, 175);
            this.HCoefLabel.Name = "HCoefLabel";
            this.HCoefLabel.Size = new System.Drawing.Size(30, 20);
            this.HCoefLabel.TabIndex = 12;
            this.HCoefLabel.Text = "H=";
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(296, 258);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(125, 27);
            this.answerTextBox.TabIndex = 14;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(30, 258);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(260, 20);
            this.answerLabel.TabIndex = 15;
            this.answerLabel.Text = "Оптимальное количество студентов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 298);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.hTextBox);
            this.Controls.Add(this.HCoefLabel);
            this.Controls.Add(this.jTextBox);
            this.Controls.Add(this.JCoefLabel);
            this.Controls.Add(this.lTextBox);
            this.Controls.Add(this.LCoefLabel);
            this.Controls.Add(this.fourthMonthLabel);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.thirdMonthLabel);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.secondMonthLabel);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.firstMonthLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label firstMonthLabel;
        private System.Windows.Forms.Label secondMonthLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label thirdMonthLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label fourthMonthLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label LCoefLabel;
        private System.Windows.Forms.TextBox lTextBox;
        private System.Windows.Forms.TextBox jTextBox;
        private System.Windows.Forms.Label JCoefLabel;
        private System.Windows.Forms.TextBox hTextBox;
        private System.Windows.Forms.Label HCoefLabel;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label answerLabel;
    }
}

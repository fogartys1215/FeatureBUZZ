namespace FizzBuzz
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Number = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultViewTextBox = new System.Windows.Forms.RichTextBox();
            this.NumberValidationLabel = new System.Windows.Forms.Label();
            this.NumOfFIZZLabel = new System.Windows.Forms.Label();
            this.NumOfBUZZLabel = new System.Windows.Forms.Label();
            this.NumOfFIZZ = new System.Windows.Forms.Label();
            this.NumOfBUZZ = new System.Windows.Forms.Label();
            this.LastCalcLabel = new System.Windows.Forms.Label();
            this.LastCalc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(12, 12);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(100, 20);
            this.Number.TabIndex = 0;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(118, 9);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResultViewTextBox
            // 
            this.ResultViewTextBox.Location = new System.Drawing.Point(12, 54);
            this.ResultViewTextBox.Name = "ResultViewTextBox";
            this.ResultViewTextBox.ReadOnly = true;
            this.ResultViewTextBox.Size = new System.Drawing.Size(113, 240);
            this.ResultViewTextBox.TabIndex = 2;
            this.ResultViewTextBox.Text = "";
            // 
            // NumberValidationLabel
            // 
            this.NumberValidationLabel.AutoSize = true;
            this.NumberValidationLabel.ForeColor = System.Drawing.Color.Red;
            this.NumberValidationLabel.Location = new System.Drawing.Point(9, 35);
            this.NumberValidationLabel.Name = "NumberValidationLabel";
            this.NumberValidationLabel.Size = new System.Drawing.Size(206, 13);
            this.NumberValidationLabel.TabIndex = 3;
            this.NumberValidationLabel.Text = "Please enter a valid, non-negative integer!";
            this.NumberValidationLabel.Visible = false;
            // 
            // NumOfFIZZLabel
            // 
            this.NumOfFIZZLabel.AutoSize = true;
            this.NumOfFIZZLabel.Location = new System.Drawing.Point(128, 80);
            this.NumOfFIZZLabel.Name = "NumOfFIZZLabel";
            this.NumOfFIZZLabel.Size = new System.Drawing.Size(90, 13);
            this.NumOfFIZZLabel.TabIndex = 4;
            this.NumOfFIZZLabel.Text = "Number of FIZZs:";
            // 
            // NumOfBUZZLabel
            // 
            this.NumOfBUZZLabel.AutoSize = true;
            this.NumOfBUZZLabel.Location = new System.Drawing.Point(128, 106);
            this.NumOfBUZZLabel.Name = "NumOfBUZZLabel";
            this.NumOfBUZZLabel.Size = new System.Drawing.Size(96, 13);
            this.NumOfBUZZLabel.TabIndex = 5;
            this.NumOfBUZZLabel.Text = "Number of BUZZs:";
            // 
            // NumOfFIZZ
            // 
            this.NumOfFIZZ.AutoSize = true;
            this.NumOfFIZZ.Location = new System.Drawing.Point(128, 93);
            this.NumOfFIZZ.Name = "NumOfFIZZ";
            this.NumOfFIZZ.Size = new System.Drawing.Size(10, 13);
            this.NumOfFIZZ.TabIndex = 6;
            this.NumOfFIZZ.Text = " ";
            // 
            // NumOfBUZZ
            // 
            this.NumOfBUZZ.AutoSize = true;
            this.NumOfBUZZ.Location = new System.Drawing.Point(128, 119);
            this.NumOfBUZZ.Name = "NumOfBUZZ";
            this.NumOfBUZZ.Size = new System.Drawing.Size(10, 13);
            this.NumOfBUZZ.TabIndex = 7;
            this.NumOfBUZZ.Text = " ";
            // 
            // LastCalcLabel
            // 
            this.LastCalcLabel.AutoSize = true;
            this.LastCalcLabel.Location = new System.Drawing.Point(128, 54);
            this.LastCalcLabel.Name = "LastCalcLabel";
            this.LastCalcLabel.Size = new System.Drawing.Size(83, 13);
            this.LastCalcLabel.TabIndex = 8;
            this.LastCalcLabel.Text = "Last Calculated:";
            // 
            // LastCalc
            // 
            this.LastCalc.AutoSize = true;
            this.LastCalc.Location = new System.Drawing.Point(128, 67);
            this.LastCalc.Name = "LastCalc";
            this.LastCalc.Size = new System.Drawing.Size(10, 13);
            this.LastCalc.TabIndex = 9;
            this.LastCalc.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 306);
            this.Controls.Add(this.LastCalc);
            this.Controls.Add(this.LastCalcLabel);
            this.Controls.Add(this.NumOfBUZZ);
            this.Controls.Add(this.NumOfFIZZ);
            this.Controls.Add(this.NumOfBUZZLabel);
            this.Controls.Add(this.NumOfFIZZLabel);
            this.Controls.Add(this.NumberValidationLabel);
            this.Controls.Add(this.ResultViewTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.Number);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FizzBuzz Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.RichTextBox ResultViewTextBox;
        private System.Windows.Forms.Label NumberValidationLabel;
        private System.Windows.Forms.Label NumOfFIZZLabel;
        private System.Windows.Forms.Label NumOfBUZZLabel;
        private System.Windows.Forms.Label NumOfFIZZ;
        private System.Windows.Forms.Label NumOfBUZZ;
        private System.Windows.Forms.Label LastCalcLabel;
        private System.Windows.Forms.Label LastCalc;
    }
}


namespace Main
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.plusLabel = new System.Windows.Forms.Label();
            this.equalLabel = new System.Windows.Forms.Label();
            this.numberTextBox1 = new System.Windows.Forms.TextBox();
            this.numberTextBox2 = new System.Windows.Forms.TextBox();
            this.numberTextBox3 = new System.Windows.Forms.TextBox();
            this.numberTextBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(351, 205);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(90, 50);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "執行運算";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // plusLabel
            // 
            this.plusLabel.AutoSize = true;
            this.plusLabel.Location = new System.Drawing.Point(210, 98);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(11, 12);
            this.plusLabel.TabIndex = 1;
            this.plusLabel.Text = "+";
            // 
            // equalLabel
            // 
            this.equalLabel.AutoSize = true;
            this.equalLabel.Location = new System.Drawing.Point(67, 133);
            this.equalLabel.Name = "equalLabel";
            this.equalLabel.Size = new System.Drawing.Size(11, 12);
            this.equalLabel.TabIndex = 3;
            this.equalLabel.Text = "=";
            // 
            // numberTextBox1
            // 
            this.numberTextBox1.Location = new System.Drawing.Point(89, 88);
            this.numberTextBox1.Name = "numberTextBox1";
            this.numberTextBox1.Size = new System.Drawing.Size(100, 22);
            this.numberTextBox1.TabIndex = 4;
            // 
            // numberTextBox2
            // 
            this.numberTextBox2.Location = new System.Drawing.Point(241, 88);
            this.numberTextBox2.Name = "numberTextBox2";
            this.numberTextBox2.Size = new System.Drawing.Size(100, 22);
            this.numberTextBox2.TabIndex = 5;
            // 
            // numberTextBox3
            // 
            this.numberTextBox3.Location = new System.Drawing.Point(89, 130);
            this.numberTextBox3.Name = "numberTextBox3";
            this.numberTextBox3.Size = new System.Drawing.Size(100, 22);
            this.numberTextBox3.TabIndex = 6;
            // 
            // numberTextBox4
            // 
            this.numberTextBox4.Location = new System.Drawing.Point(89, 183);
            this.numberTextBox4.Name = "numberTextBox4";
            this.numberTextBox4.Size = new System.Drawing.Size(100, 22);
            this.numberTextBox4.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 330);
            this.Controls.Add(this.numberTextBox4);
            this.Controls.Add(this.numberTextBox3);
            this.Controls.Add(this.numberTextBox2);
            this.Controls.Add(this.numberTextBox1);
            this.Controls.Add(this.equalLabel);
            this.Controls.Add(this.plusLabel);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label plusLabel;
        private System.Windows.Forms.Label equalLabel;
        private System.Windows.Forms.TextBox numberTextBox1;
        private System.Windows.Forms.TextBox numberTextBox2;
        private System.Windows.Forms.TextBox numberTextBox3;
        private System.Windows.Forms.TextBox numberTextBox4;
    }
}


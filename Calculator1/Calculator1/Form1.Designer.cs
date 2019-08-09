namespace WindowsFormsApplication2
{
    partial class Calculator1
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
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblEquals = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtPlus = new System.Windows.Forms.Button();
            this.txtMultiply = new System.Windows.Forms.Button();
            this.txtDivide = new System.Windows.Forms.Button();
            this.txtSubtract = new System.Windows.Forms.Button();
            this.txtEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(12, 11);
            this.txtSum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(261, 22);
            this.txtSum.TabIndex = 7;
            this.txtSum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSum_KeyDown);
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Location = new System.Drawing.Point(12, 40);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(16, 17);
            this.lblEquals.TabIndex = 9;
            this.lblEquals.Text = "=";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(34, 37);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(239, 22);
            this.txtAnswer.TabIndex = 8;
            // 
            // txtPlus
            // 
            this.txtPlus.Location = new System.Drawing.Point(198, 64);
            this.txtPlus.Name = "txtPlus";
            this.txtPlus.Size = new System.Drawing.Size(75, 23);
            this.txtPlus.TabIndex = 10;
            this.txtPlus.Text = "+";
            this.txtPlus.UseVisualStyleBackColor = true;
            this.txtPlus.Click += new System.EventHandler(this.TxtPlus_Click);
            // 
            // txtMultiply
            // 
            this.txtMultiply.Location = new System.Drawing.Point(198, 93);
            this.txtMultiply.Name = "txtMultiply";
            this.txtMultiply.Size = new System.Drawing.Size(75, 23);
            this.txtMultiply.TabIndex = 11;
            this.txtMultiply.Text = "X";
            this.txtMultiply.UseVisualStyleBackColor = true;
            // 
            // txtDivide
            // 
            this.txtDivide.Location = new System.Drawing.Point(198, 122);
            this.txtDivide.Name = "txtDivide";
            this.txtDivide.Size = new System.Drawing.Size(75, 23);
            this.txtDivide.TabIndex = 12;
            this.txtDivide.Text = "÷";
            this.txtDivide.UseVisualStyleBackColor = true;
            // 
            // txtSubtract
            // 
            this.txtSubtract.Location = new System.Drawing.Point(198, 151);
            this.txtSubtract.Name = "txtSubtract";
            this.txtSubtract.Size = new System.Drawing.Size(75, 23);
            this.txtSubtract.TabIndex = 13;
            this.txtSubtract.Text = "-";
            this.txtSubtract.UseVisualStyleBackColor = true;
            // 
            // txtEqual
            // 
            this.txtEqual.Location = new System.Drawing.Point(198, 180);
            this.txtEqual.Name = "txtEqual";
            this.txtEqual.Size = new System.Drawing.Size(75, 23);
            this.txtEqual.TabIndex = 14;
            this.txtEqual.Text = "=";
            this.txtEqual.UseVisualStyleBackColor = true;
            // 
            // Calculator1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 214);
            this.Controls.Add(this.txtEqual);
            this.Controls.Add(this.txtSubtract);
            this.Controls.Add(this.txtDivide);
            this.Controls.Add(this.txtMultiply);
            this.Controls.Add(this.txtPlus);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.txtSum);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Calculator1";
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Button txtPlus;
        private System.Windows.Forms.Button txtMultiply;
        private System.Windows.Forms.Button txtDivide;
        private System.Windows.Forms.Button txtSubtract;
        private System.Windows.Forms.Button txtEqual;
    }
}


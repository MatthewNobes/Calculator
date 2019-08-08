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
            // Calculator1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 71);
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
    }
}


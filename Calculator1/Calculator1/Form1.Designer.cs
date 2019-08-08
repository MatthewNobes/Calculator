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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.grbCalculator = new System.Windows.Forms.GroupBox();
            this.lblEquals = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.grbCalculator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(8, 21);
            this.txtSum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(261, 22);
            this.txtSum.TabIndex = 7;
            this.txtSum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSum_KeyDown);
            // 
            // grbCalculator
            // 
            this.grbCalculator.Controls.Add(this.lblEquals);
            this.grbCalculator.Controls.Add(this.txtAnswer);
            this.grbCalculator.Controls.Add(this.txtSum);
            this.grbCalculator.Controls.Add(this.label2);
            this.grbCalculator.Location = new System.Drawing.Point(11, 10);
            this.grbCalculator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbCalculator.Name = "grbCalculator";
            this.grbCalculator.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbCalculator.Size = new System.Drawing.Size(441, 54);
            this.grbCalculator.TabIndex = 9;
            this.grbCalculator.TabStop = false;
            this.grbCalculator.Text = "Calculator";
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Location = new System.Drawing.Point(275, 24);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(16, 17);
            this.lblEquals.TabIndex = 9;
            this.lblEquals.Text = "=";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(297, 21);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(138, 22);
            this.txtAnswer.TabIndex = 8;
            this.txtAnswer.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            // 
            // Calculator1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 76);
            this.Controls.Add(this.grbCalculator);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Calculator1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator1_KeyPress);
            this.grbCalculator.ResumeLayout(false);
            this.grbCalculator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.GroupBox grbCalculator;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblEquals;
    }
}


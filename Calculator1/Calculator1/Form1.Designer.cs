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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbMul = new System.Windows.Forms.RadioButton();
            this.rdbSub = new System.Windows.Forms.RadioButton();
            this.rdbDiv = new System.Windows.Forms.RadioButton();
            this.rdbPlus = new System.Windows.Forms.RadioButton();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(76, 20);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(176, 22);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.Text = "0";
            this.txtNum1.TextChanged += new System.EventHandler(this.TxtNum1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Num1";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(76, 46);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(176, 22);
            this.txtNum2.TabIndex = 2;
            this.txtNum2.Text = "0";
            this.txtNum2.TextChanged += new System.EventHandler(this.TxtNum2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Num2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMul);
            this.groupBox1.Controls.Add(this.rdbSub);
            this.groupBox1.Controls.Add(this.rdbDiv);
            this.groupBox1.Controls.Add(this.rdbPlus);
            this.groupBox1.Location = new System.Drawing.Point(277, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(178, 120);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operators";
            // 
            // rdbMul
            // 
            this.rdbMul.AutoSize = true;
            this.rdbMul.Location = new System.Drawing.Point(20, 93);
            this.rdbMul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbMul.Name = "rdbMul";
            this.rdbMul.Size = new System.Drawing.Size(76, 21);
            this.rdbMul.TabIndex = 3;
            this.rdbMul.TabStop = true;
            this.rdbMul.Text = "Multiply";
            this.rdbMul.UseVisualStyleBackColor = true;
            this.rdbMul.CheckedChanged += new System.EventHandler(this.RdbMul_CheckedChanged);
            // 
            // rdbSub
            // 
            this.rdbSub.AutoSize = true;
            this.rdbSub.Location = new System.Drawing.Point(20, 69);
            this.rdbSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbSub.Name = "rdbSub";
            this.rdbSub.Size = new System.Drawing.Size(82, 21);
            this.rdbSub.TabIndex = 2;
            this.rdbSub.TabStop = true;
            this.rdbSub.Text = "Subtract";
            this.rdbSub.UseVisualStyleBackColor = true;
            this.rdbSub.CheckedChanged += new System.EventHandler(this.RdbSub_CheckedChanged);
            // 
            // rdbDiv
            // 
            this.rdbDiv.AutoSize = true;
            this.rdbDiv.Location = new System.Drawing.Point(20, 45);
            this.rdbDiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbDiv.Name = "rdbDiv";
            this.rdbDiv.Size = new System.Drawing.Size(68, 21);
            this.rdbDiv.TabIndex = 1;
            this.rdbDiv.TabStop = true;
            this.rdbDiv.Text = "Divide";
            this.rdbDiv.UseVisualStyleBackColor = true;
            this.rdbDiv.CheckedChanged += new System.EventHandler(this.RdbDiv_CheckedChanged);
            // 
            // rdbPlus
            // 
            this.rdbPlus.AutoSize = true;
            this.rdbPlus.Location = new System.Drawing.Point(20, 21);
            this.rdbPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbPlus.Name = "rdbPlus";
            this.rdbPlus.Size = new System.Drawing.Size(56, 21);
            this.rdbPlus.TabIndex = 0;
            this.rdbPlus.TabStop = true;
            this.rdbPlus.Text = "Plus";
            this.rdbPlus.UseVisualStyleBackColor = true;
            this.rdbPlus.CheckedChanged += new System.EventHandler(this.RdbPlus_CheckedChanged);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(76, 71);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(176, 22);
            this.txtAnswer.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Answer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNum1);
            this.groupBox2.Controls.Add(this.txtAnswer);
            this.groupBox2.Controls.Add(this.txtNum2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(11, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(260, 120);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // Calculator1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 141);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Calculator1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbMul;
        private System.Windows.Forms.RadioButton rdbSub;
        private System.Windows.Forms.RadioButton rdbDiv;
        private System.Windows.Forms.RadioButton rdbPlus;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


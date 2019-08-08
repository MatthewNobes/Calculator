using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    public partial class Calculator1 : Form
    {
        public Calculator1()
        {
            InitializeComponent();

        }

        private void btnGo_Click(object sender, EventArgs e)
        {

        }

        private void txtPlus_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtNum1_TextChanged(object sender, EventArgs e)
        {


        }

        private void TxtNum2_TextChanged(object sender, EventArgs e)
        {
        }

        private void RdbPlus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RdbDiv_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RdbSub_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RdbMul_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Calculator1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {

        }

        public static int runCalc(int num1, int num2, string sign)
        {
            int Answer;
            switch (sign)
            {
                case "*":
                    Answer = num1 * num2;
                    break;
                case "/":
                    Answer = num1 / num2;
                    break;
                case "-":
                    Answer = num1 - num2;
                    break;
                default:
                    Answer = num1 + num2;
                    break;
            }
            return Answer;
        }

        private void Calculator1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                MessageBox.Show("1 key works");
            }
        }

        private void TxtSum_KeyDown(object sender, KeyEventArgs e)
        {
            int dig = 0;
            switch (e.KeyCode)
            {
                case Keys.D1:
                    dig = 1;
                    break;
                case Keys.D2:
                    dig = 2;
                    break;
                case Keys.D3:
                    dig = 3;
                    break;
                case Keys.D4:
                    dig = 4;
                    break;
                case Keys.D5:
                    dig = 5;
                    break;
                case Keys.D6:
                    dig = 6;
                    break;
                case Keys.D7:
                    dig = 7;
                    break;
                case Keys.D8:
                    dig = 8;
                    break;
                case Keys.D9:
                    dig = 9;
                    break;
                case Keys.D0:
                    dig = 0;
                    break;
                default:
                    break;
            }
            
            txtSum.Text += Convert.ToString(dig);
        }
    }
}

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
            string oper = "+";
            List<String> sumList = new List<String>();

            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                switch (e.KeyCode)
                {
                    case Keys.D1:
                        dig = 1;
                        break               case Keys.D2:
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
            else
            {
                if (e.KeyCode == Keys.Multiply)
                {
                    oper = "*";
                    txtSum.Text += Convert.ToString(oper);
                }
                else if (e.KeyCode == Keys.Subtract)
                {
                    oper = "-";
                    txtSum.Text += Convert.ToString(oper);
                }
                else if (e.KeyCode == Keys.Add)
                {
                    oper = "+";
                    txtSum.Text += Convert.ToString(oper);
                }
                else if (e.KeyCode == Keys.Divide)
                {
                    oper = "/";
                    txtSum.Text += Convert.ToString(oper);
                }


            }
        }
    }
}

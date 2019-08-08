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
            //Performs presence check for first number textbox.
            if (txtNum1.Text == "")
            {
                txtAnswer.Text = txtAnswer.Text;
            }
            else
            {
                //Performs presence check for secound number textbox.
                if (txtNum2.Text == "")
                {
                    txtAnswer.Text = txtAnswer.Text;
                }
                else
                {
                   
                    string oper = "+";
                    if (rdbDiv.Checked)
                    {
                        oper = "/";
                    }
                    if (rdbMul.Checked)
                    {
                        oper = "*";
                    }
                    if (rdbSub.Checked)
                    {
                        oper = "-";
                    }
                    int dig1 = Convert.ToInt32(txtNum1.Text);
                    int dig2 = Convert.ToInt32(txtNum2.Text);
                    int answer = runCalc(dig1, dig2, oper);

                    txtAnswer.Text = (Convert.ToString(answer));
                }

            }
            
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

        private void TxtNum2_TextChanged(object sender, EventArgs e)
        {
            //Performs presence check for first number textbox.
            if (txtNum1.Text == "")
            {
                txtAnswer.Text = txtAnswer.Text;
            }
            else
            {
                //Performs presence check for secound number textbox.
                if (txtNum2.Text == "")
                {
                    txtAnswer.Text = txtAnswer.Text;
                }
                else
                {
                    string oper = "+";
                    if (rdbDiv.Checked)
                    {
                        oper = "/";
                    }
                    if (rdbMul.Checked)
                    {
                        oper = "*";
                    }
                    if (rdbSub.Checked)
                    {
                        oper = "-";
                    }
                    int dig1 = Convert.ToInt32(txtNum1.Text);
                    int dig2 = Convert.ToInt32(txtNum2.Text);
                    int answer = runCalc(dig1, dig2, oper);

                    txtAnswer.Text = (Convert.ToString(answer));
                }
            }
        }

        private void RdbPlus_CheckedChanged(object sender, EventArgs e)
        {
                //Performs presence check for first number textbox.
                if (txtNum1.Text == "")
                {
                    txtAnswer.Text = txtAnswer.Text;
                }
                else
                {
                    //Performs presence check for secound number textbox.
                    if (txtNum2.Text == "")
                    {
                        txtAnswer.Text = txtAnswer.Text;
                    }
                    else
                    {
                        string oper = "+";
                        if (rdbDiv.Checked)
                        {
                            oper = "/";
                        }
                        if (rdbMul.Checked)
                        {
                            oper = "*";
                        }
                        if (rdbSub.Checked)
                        {
                            oper = "-";
                        }
                        int dig1 = Convert.ToInt32(txtNum1.Text);
                        int dig2 = Convert.ToInt32(txtNum2.Text);
                        int answer = runCalc(dig1, dig2, oper);

                        txtAnswer.Text = (Convert.ToString(answer));
                    }

                }
            }

        private void RdbDiv_CheckedChanged(object sender, EventArgs e)
        {
            //Performs presence check for first number textbox.
            if (txtNum1.Text == "")
            {
                txtAnswer.Text = txtAnswer.Text;
            }
            else
            {
                //Performs presence check for secound number textbox.
                if (txtNum2.Text == "")
                {
                    txtAnswer.Text = txtAnswer.Text;
                }
                else
                {
                    string oper = "+";
                    if (rdbDiv.Checked)
                    {
                        oper = "/";
                    }
                    if (rdbMul.Checked)
                    {
                        oper = "*";
                    }
                    if (rdbSub.Checked)
                    {
                        oper = "-";
                    }
                    int dig1 = Convert.ToInt32(txtNum1.Text);
                    int dig2 = Convert.ToInt32(txtNum2.Text);
                    int answer = runCalc(dig1, dig2, oper);

                    txtAnswer.Text = (Convert.ToString(answer));
                }

            }
        }

        private void RdbSub_CheckedChanged(object sender, EventArgs e)
        {
            //Performs presence check for first number textbox.
            if (txtNum1.Text == "")
            {
                txtAnswer.Text = txtAnswer.Text;
            }
            else
            {
                //Performs presence check for secound number textbox.
                if (txtNum2.Text == "")
                {
                    txtAnswer.Text = txtAnswer.Text;
                }
                else
                {
                    string oper = "+";
                    if (rdbDiv.Checked)
                    {
                        oper = "/";
                    }
                    if (rdbMul.Checked)
                    {
                        oper = "*";
                    }
                    if (rdbSub.Checked)
                    {
                        oper = "-";
                    }
                    int dig1 = Convert.ToInt32(txtNum1.Text);
                    int dig2 = Convert.ToInt32(txtNum2.Text);
                    int answer = runCalc(dig1, dig2, oper);

                    txtAnswer.Text = (Convert.ToString(answer));
                }

            }
        }

        private void RdbMul_CheckedChanged(object sender, EventArgs e)
        {
            //Performs presence check for first number textbox.
            if (txtNum1.Text == "")
            {
                txtAnswer.Text = txtAnswer.Text;
            }
            else
            {
                //Performs presence check for secound number textbox.
                if (txtNum2.Text == "")
                {
                    txtAnswer.Text = txtAnswer.Text;
                }
                else
                {
                    string oper = "+";
                    if (rdbDiv.Checked)
                    {
                        oper = "/";
                    }
                    if (rdbMul.Checked)
                    {
                        oper = "*";
                    }
                    if (rdbSub.Checked)
                    {
                        oper = "-";
                    }
                    int dig1 = Convert.ToInt32(txtNum1.Text);
                    int dig2 = Convert.ToInt32(txtNum2.Text);
                    int answer = runCalc(dig1, dig2, oper);

                    txtAnswer.Text = (Convert.ToString(answer));
                }

            }
        }
    }
}

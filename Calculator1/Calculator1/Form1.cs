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
            if (rdbPlus.Checked)
            {
                int Dig1 = (Convert.ToInt32(txtNum1.Text));
                int Dig2 = (Convert.ToInt32(txtNum2.Text));
                int Answer = Dig1 + Dig2;
                txtAnswer.Text = (Convert.ToString(Answer));
            }
            if (rdbDiv.Checked)
            {
                int Dig1 = (Convert.ToInt32(txtNum1.Text));
                int Dig2 = (Convert.ToInt32(txtNum2.Text));
                int Answer = Dig1 / Dig2;
                txtAnswer.Text = (Convert.ToString(Answer));
            }
            if (rdbMul.Checked)
            {
                int Dig1 = (Convert.ToInt32(txtNum1.Text));
                int Dig2 = (Convert.ToInt32(txtNum2.Text));
                int Answer = Dig1 * Dig2;
                txtAnswer.Text = (Convert.ToString(Answer));
            }
            if (rdbSub.Checked)
            {
                int Dig1 = (Convert.ToInt32(txtNum1.Text));
                int Dig2 = (Convert.ToInt32(txtNum2.Text));
                int Answer = Dig1 - Dig2;
                txtAnswer.Text = (Convert.ToString(Answer));
            }
        }

        private void txtPlus_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

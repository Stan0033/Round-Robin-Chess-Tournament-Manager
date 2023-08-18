using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_Tournament_Calculator
{
    public partial class enterresult : Form
    {
        public string PGN;
        public string reason;
        public string result = string.Empty;
        public enterresult()
        {
            InitializeComponent();
            DialogResult = DialogResult.Yes;
        }

        private void enterresult_Load(object sender, EventArgs e)
        {
            by_draw.Location = by_win.Location;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = "0";
            DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result = "1/2";
            DialogResult = DialogResult.OK;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result = "-";
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = "1";
            DialogResult = DialogResult.OK;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            by_draw.Visible = true;
            by_win.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            by_draw.Visible = false;
            by_win.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            by_draw.Visible = false;
            by_win.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PGN = richTextBox1.Text;
            if (button_draw.Checked)
            {
                reason = by_draw.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked)?.Text;
            }
            else
            {
                reason = by_win.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked)?.Text;
            }

            DialogResult = DialogResult.OK;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

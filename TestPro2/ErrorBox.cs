using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPro2
{
    public partial class ErrorBox : Form
    {
        public int index = -1;
        List<Evaporators> evapors;
        public ErrorBox(List<Evaporators> evaporators, int pos)
        {
            InitializeComponent();
            evapors = evaporators;
            pos++;
            error_dgv.DataSource = evaporators;
            if (pos < 7)
            {
                heder.Text = "The SIP file contained incomplete data for position 1 in crucible " +
                    pos + ".\nPlease choose the appropriate process.";
            }
            else
            {
                heder.Text = "The SIP file contained incomplete data for position " +
                    (pos - 5) + ".\nPlease choose the appropriate process.";
            }
        }

        private void error_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                index = e.RowIndex;
                string text;
                if (!string.IsNullOrEmpty(evapors[index].Scan))
                {
                    text = evapors[index].Matter + " was chosen, with a rate of " + evapors[index].Rate +
                    ", from the " + evapors[index].Src +
                    " source, \n placed in position " + evapors[index].Pos +
                    ", using a " + evapors[index].Scan + " scan.";
                }
                else
                {
                    text = evapors[index].Matter + " was chosen, with a rate of " + evapors[index].Rate +
                    ", from the " + evapors[index].Src + " source, \n placed in position " + evapors[index].Pos + ".";
                }
                var validate = MessageBox.Show(text, "data error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (validate == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}

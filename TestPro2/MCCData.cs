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
    public partial class MCCData : Form
    {
        public MCCData(List<MCC> mCCs)
        {
            InitializeComponent();
            this.Text = "Limits - " + mCCs[0].Name;
            mcc_dgv.DataSource = mCCs;
        }
    }
}

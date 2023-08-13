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
    public partial class GSMTable : Form
    {
        public GSMTable(JsonTable jt)
        {
            InitializeComponent();
            
            List<JsonTable> list = new List<JsonTable>();
            list.Add(jt);
            dgv_gsm.DataSource = null;
            dgv_gsm.DataSource = list;
        }
    }
}

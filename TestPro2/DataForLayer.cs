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
    public partial class DataForLayer : Form
    {
        public DataForLayer(JsonTable jt)
        {
            InitializeComponent();
            this.Text = "Data for " + jt.Sequence;
            List<JsonTable> list = new List<JsonTable>();
            list.Add(jt);
            dgv_layer.DataSource = null;
            dgv_layer.DataSource = list;
        }

    }
}

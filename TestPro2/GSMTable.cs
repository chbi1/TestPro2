namespace TestPro2
{
    public partial class GSMTable : Form
    {
        public GSMTable(JsonTable jt)
        {
            InitializeComponent();
            this.Text = "GSM datd for " + jt.Name;
            List<JsonTable> list = new List<JsonTable>();
            list.Add(jt);
            dgv_gsm.DataSource = null;
            dgv_gsm.DataSource = list;
        }
    }
}

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

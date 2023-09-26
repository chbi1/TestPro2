namespace TestPro2
{
    public partial class DataForLayer : Form
    {
        public DataForLayer(List<LayerData> jt, string title)
        {
            InitializeComponent();
            this.Text = "Data for step " + title;
            dgv_layer.DataSource = null;
            dgv_layer.DataSource = jt;
        }

    }
}

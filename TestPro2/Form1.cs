using Newtonsoft.Json;
using System;
using System.Reflection;

namespace TestPro2
{
    public partial class Form1 : Form
    {
        Rootobject rootobject;
        List<JsonTable> jts;
        string jsonData = string.Empty;
        string filePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
            rootobject = new Rootobject();
            jts = new List<JsonTable>();
        }


        private void open_btn_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\Users\\user\\Desktop";
                openFileDialog.Filter = "json REC files (*.REC)|*.REC";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    jsonData = File.ReadAllText(filePath);
                }
            }
            MessageBox.Show("File Content at path: " + filePath);
        }

        private void process_btn_Click(object sender, EventArgs e)
        {
            jts.Clear();

            jsonData = jsonData.Replace(" ", "");
            jsonData = jsonData.Replace("-", "");

            rootobject = JsonConvert.DeserializeObject<Rootobject>(jsonData);
            JsonTable jsontable = new JsonTable();
            jsontable.Sequence = "Pretreatment";
            jts.Add(jsontable);
            foreach (ProcessSequence sequence in rootobject.ProcessSequence)
            {
                jsontable = new JsonTable();
                switch (sequence.ModuleType)
                {
                    case "B":
                        jsontable = GetBake(sequence);
                        break;

                    case "C":
                        jsontable = GetClean(sequence);
                        break;

                    case "L":
                        jsontable= GetLayer(sequence);
                        break;

                    case "V":
                        jsontable = GetVacume(sequence);
                        break;
                }
                //jsontable.Sequence = sequence.SequenceNumber.ToString() + "  " + s;
                jts.Add(jsontable);
            }

            dgv.DataSource = null;
            dgv.DataSource = jts;

            //rootobject.Identification.ProcessID = "1234";
            string output = JsonConvert.SerializeObject(rootobject, Formatting.Indented);
            rtb.Text = output;
        }
        public JsonTable GetBake(ProcessSequence ps)
        {
            JsonTable jsontable = new JsonTable();
            foreach (Bake bake in rootobject.Bake)
            {
                if (ps.ModuleNumber == bake.Identification.ModuleNumber)
                {
                    jsontable.ModuleName = bake.Identification.ModuleName;
                    break;
                }
            }
            jsontable.Sequence = "Bake" +" "+ ps.SequenceNumber.ToString();
            return jsontable;
        }
        public JsonTable GetLayer(ProcessSequence ps)
        {
            JsonTable jsontable = new JsonTable();
            foreach (Layer layer in rootobject.Layer)
            {
                if (ps.ModuleNumber == layer.Identification.ModuleNumber)
                {
                    jsontable.ModuleName = layer.Identification.ModuleName;
                    break;
                }
            }
            jsontable.Sequence = "Leyer" +" "+ ps.SequenceNumber.ToString();
            return jsontable;
        }
        public JsonTable GetVacume(ProcessSequence ps)
        {
            JsonTable jsontable = new JsonTable();
            foreach (Vacuum1 vacuum in rootobject.Vacuum)
            {
                if (ps.ModuleNumber == vacuum.Identification.ModuleNumber)
                {
                    jsontable.ModuleName = vacuum.Identification.ModuleName;
                    break;
                }
            }
            jsontable.Sequence = "Vacuum" +" "+ ps.SequenceNumber.ToString();
            return jsontable;
        }
        public JsonTable GetClean(ProcessSequence ps)
        {
            JsonTable jsontable = new JsonTable();
            foreach (Clean clean in rootobject.Clean)
            {
                if (ps.ModuleNumber == clean.Identification.ModuleNumber)
                {
                    jsontable.ModuleName = clean.Identification.ModuleName;
                    break;
                }
            }
            jsontable.Sequence = "Clean" + " " + ps.SequenceNumber.ToString();
            return jsontable;
        }
    }
}
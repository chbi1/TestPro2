using Newtonsoft.Json;
using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace TestPro2
{
    public partial class Form1 : Form
    {
        Rootobject rootobject;

        public List<JsonTable> jts;
        Queue<char> id;

        string jsonData = string.Empty;
        string filePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
            rootobject = new Rootobject();

            jts = new List<JsonTable>();
            id = new Queue<char>();
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
            //string pattern = @"(?<![0-9.])-(?![0-9])";
            //string replacement = "__";
            //jsonData = Regex.Replace(jsonData, pattern, replacement);

            ///string spacePattern = @"\S \S";
            //string spaceReplacement = "_";
            //jsonData = Regex.Replace(jsonData, spacePattern, spaceReplacement);

            rtb.Text = jsonData;
            jsonData = jsonData.Replace(" ", "");
            string pattern = @"(?<![0-9.])-(?![0-9])";
            string replacement = "";


            jsonData = Regex.Replace(jsonData, pattern, replacement);
            rootobject = JsonConvert.DeserializeObject<Rootobject>(jsonData);
            show_file_name.Text = rootobject.Identification.ProcessID.ToString();

        }

        private void process_btn_Click(object sender, EventArgs e)
        {
            rtb.Text = string.Empty;
            if (jsonData == string.Empty) { return; }
            jts.Clear();


            JsonTable jsontable = new JsonTable();
            jsontable.Sequence = "Pretreatment";
            foreach (Bake bake in rootobject.Bake)
            {
                if (rootobject.Pretreatment.References.BakeModule
                    == bake.Identification.ModuleNumber)
                {
                    jsontable.ModuleName = bake.Identification.ModuleName;
                    break;
                }
            }
            jts.Add(jsontable);
            foreach (ProcessSequence sequence in rootobject.ProcessSequence)
            {

                jsontable = new JsonTable();
                switch (sequence.ModuleType)
                {
                    case "B":

                        jsontable = GetBake(sequence);
                        id.Enqueue('B');

                        break;

                    case "C":
                        jsontable = GetClean(sequence);

                        id.Enqueue('C');

                        break;

                    case "L":
                        jsontable = GetLayer(sequence);

                        id.Enqueue('L');

                        break;

                    case "V":
                        jsontable = GetVacuum(sequence);

                        id.Enqueue('V');

                        break;
                }
                //jsontable.Sequence = sequence.SequenceNumber.ToString() + "  " + s;
                jts.Add(jsontable);
            }

            dgv.DataSource = null;
            dgv.DataSource = jts;

            int i = 1;
            dgv.Rows[0].Cells[0].Style.BackColor = Color.Gainsboro;
            while (id.Count > 0)
            {
                switch (id.Dequeue())
                {
                    case 'B':
                        dgv.Rows[i].Cells[0].Style.BackColor = Color.MistyRose;
                        break;
                    case 'C':
                        dgv.Rows[i].Cells[0].Style.BackColor = Color.LightGreen;
                        break;
                    case 'L':
                        dgv.Rows[i].Cells[0].Style.BackColor = Color.AliceBlue;
                        break;
                    case 'V':
                        dgv.Rows[i].Cells[0].Style.BackColor = Color.LightYellow;
                        break;
                }
                i++;
            }


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
            jsontable.Sequence = "Bake" + " - " + ps.SequenceNumber.ToString();
            return jsontable;
        }
        public JsonTable GetLayer(ProcessSequence ps)
        {
            JsonTable jsontable = new JsonTable();
            float[] tempRateMod = new float[3] { 0, 0, 0 };
            float tempGSMMod = 0;
            float tempSrcMod = 0;
            int i;
            string special;
            jsontable.Sequence = "Layer" + " - " + ps.SequenceNumber.ToString();
            foreach (Layer layer in rootobject.Layer)
            {
                if (ps.ModuleNumber == layer.Identification.ModuleNumber)
                {
                    tempRateMod[0] = layer.References.RateModule1;
                    tempRateMod[1] = layer.References.RateModule2;
                    tempRateMod[2] = layer.References.RateModule3;
                    tempGSMMod = layer.References.GSMModule;
                    jsontable.ModuleName = layer.Identification.ModuleName;
                    float thickness = layer.Parameter.General.Thickness * 10;
                    jsontable.Thickness = thickness.ToString() + "\u212B";
                    jsontable.Rotation = layer.Parameter.General.Rotation.Setpoint.ToString();
                    break;
                }
            }
            for (i = 2; i > -1; i--)
            {
                if (tempRateMod[i] != 0) break;
            }
            foreach (Rate rate in rootobject.Rate)
            {
                if (tempRateMod[i] == rate.Identification.ModuleNumber)
                {
                    float tRate = rate.Parameter.General.Rate * 10;
                    jsontable.Rate = tRate.ToString();
                    tempSrcMod = rate.References.SourceModule;
                    break;
                }

            }
            foreach (Source source in rootobject.Source)
            {
                if (tempSrcMod == source.Identification.ModuleNumber)
                {
                    if (source.Parameter.SourceNumber == 1)
                        jsontable.TSource = source.References.EECModule;
                    else
                        jsontable.TSource = source.Parameter.SourceNumber.ToString();
                    break;
                }
            }
            if (tempGSMMod != 0)
            {
                jsontable.IsGSM = true;
                foreach (GSM1 gsm in rootobject.GSM)
                {
                    if (tempGSMMod == gsm.Identification.ModuleNumber)
                    {
                        jsontable.StartIntensity = gsm.Parameter.General.Intensity.Start.ToString();            //Main & GSM
                        jsontable.IntensityMax = gsm.Parameter.General.Intensity.Maximum.ToString();            //GSM
                        jsontable.IntensityMin = gsm.Parameter.General.Intensity.Minimum.ToString();            //GSM
                        jsontable.Threshold = gsm.Parameter.General.Threshold.ToString();                       //GSM
                        jsontable.Wavelength = gsm.SignalSettings.Lambda.ToString();                            //Main & GSM
                        jsontable.AlgDalay = gsm.SignalSettings.AlgorithmDelay.ToString();                      //GSM
                        jsontable.AlgTime = gsm.SignalSettings.AlgorithmTime.ToString();                        //GSM
                        jsontable.SubCycles = gsm.SignalSettings.NumberofCycles.ToString();                     //GSM
                        jsontable.Name = gsm.Identification.ModuleName;                                         //GSM


                        // ------------------- special words --------------------
                        special = gsm.Parameter.General.Transmission;
                        special = special.Split('_').Last();
                        jsontable.Beam = special;                                                               //GSM
                        special = gsm.Parameter.General.Glass.Changer;
                        special = special.Split('_').Last();
                        jsontable.Monitor = special;                                                            //Main & GSM 
                        special = gsm.SignalSettings.StopCriterion;
                        special = special.Split('_').First();

                        jsontable.StopMode = special;                                                           //GSM

                        if (jsontable.StopMode == "QUARTZ")
                        {
                            jsontable.Cycles = "Layer";
                        }
                        else
                        {
                            jsontable.Cycles = jsontable.StopMode + " " + gsm.SignalSettings.NumberofCycles.ToString();    //Main
                        }
                        break;
                    }
                }
            }
            return jsontable;
        }
        public JsonTable GetVacuum(ProcessSequence ps)
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
            jsontable.Sequence = "Vacuum" + " - " + ps.SequenceNumber.ToString();
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
            jsontable.Sequence = "Clean" + " - " + ps.SequenceNumber.ToString();
            return jsontable;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;
                if (columnIndex > 5 && jts[rowIndex].IsGSM)
                    new GSMTable(jts[rowIndex]).ShowDialog();

            }
        }
    }
}
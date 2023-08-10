using Newtonsoft.Json;
using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace TestPro2
{
    public partial class Form1 : Form
    {
        Rootobject rootobject;
        STableGSM sTableGSM;
        List<JsonTable> jts;
        string jsonData = string.Empty;
        string filePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
            rootobject = new Rootobject();
            sTableGSM = new STableGSM();
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
            //string pattern = @"(?<![0-9.])-(?![0-9])";
            //string replacement = "__";
            //jsonData = Regex.Replace(jsonData, pattern, replacement);

            ///string spacePattern = @"\S \S";
            //string spaceReplacement = "_";
            //jsonData = Regex.Replace(jsonData, spacePattern, spaceReplacement);

            MessageBox.Show("File Content at path: " + filePath);
            rtb.Text = jsonData;
        }

        private void process_btn_Click(object sender, EventArgs e)
        {
            rtb.Text = string.Empty;
            if (jsonData == string.Empty) { return; }
            jts.Clear();

            jsonData = jsonData.Replace(" ", "");
            string pattern = @"(?<![0-9.])-(?![0-9])";
            string replacement = "";


            jsonData = Regex.Replace(jsonData, pattern, replacement);

            rootobject = JsonConvert.DeserializeObject<Rootobject>(jsonData);
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
                        break;

                    case "C":
                        jsontable = GetClean(sequence);
                        break;

                    case "L":
                        jsontable = GetLayer(sequence);
                        break;

                    case "V":
                        jsontable = GetVacuum(sequence);
                        break;
                }
                //jsontable.Sequence = sequence.SequenceNumber.ToString() + "  " + s;
                jts.Add(jsontable);
            }

            dgv.DataSource = null;
            dgv.DataSource = jts;

            dgv_gsm.DataSource = null;
            dgv_gsm.DataSource = jts;

            show_file_name.Text = rootobject.Identification.ProcessID.ToString();
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
            foreach (GSM1 gsm in rootobject.GSM)
            {
                if (tempGSMMod == gsm.Identification.ModuleNumber)
                {
                    jsontable.StartIntensity = gsm.Parameter.General.Intensity.Start.ToString();
                    jsontable.IntensityMax = gsm.Parameter.General.Intensity.Minimum.ToString();
                    jsontable.IntensityMin = gsm.Parameter.General.Intensity.Minimum.ToString();
                    jsontable.Threshold = gsm.Parameter.General.Threshold.ToString();
                    jsontable.Wavelength = gsm.SignalSettings.Lambda.ToString();
                    jsontable.AlgDalay = gsm.SignalSettings.AlgorithmDelay.ToString();
                    jsontable.AlgTime = gsm.SignalSettings.AlgorithmTime.ToString();
                    jsontable.SubCycles = gsm.SignalSettings.NumberofCycles.ToString();
                    jsontable.Name = gsm.Identification.ModuleName;

                    // ------------------- special words --------------------
                    special = gsm.Parameter.General.Transmission;
                    special = special.Split('_').Last();
                    jsontable.Beam = special;
                    special = gsm.Parameter.General.Glass.Changer;
                    special = special.Split('_').Last();
                    jsontable.Monitor = special;
                    if (gsm.SignalSettings.StopCriterion == "QUARTZ_STOP")
                    {
                        jsontable.Cycles = "Layer";
                    }
                    else
                    {
                        special = gsm.SignalSettings.StopCriterion;
                        special = special.Split('_').First();
                        jsontable.Cycles = special + " " + gsm.SignalSettings.NumberofCycles.ToString();
                    }


                    break;
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
    }
}
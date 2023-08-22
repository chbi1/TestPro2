using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;
using static System.Windows.Forms.Design.AxImporter;

namespace TestPro2
{
    public partial class TestPro : Form
    {
        Rootobject rootobject;
        public List<JsonTable> jts;
        Queue<char> id;
        string jsonData = string.Empty;
        string filePath = string.Empty;
        string initialDirectory = string.Empty;
        public TestPro()
        {
            InitializeComponent();
            rootobject = new Rootobject();
            jts = new List<JsonTable>();
            id = new Queue<char>();
            initialDirectory = "c:\\Users\\user\\Desktop";
        }
        private void machine_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (machine.Text)
            {
                case "E":
                    initialDirectory = "\\\\tigger\\ophir\\Optics\\mfg\\coatings\\Machines\\E\\in\\PCB32\\rec";
                    break;
                case "X":
                    initialDirectory = "\\\\tigger\\ophir\\Optics\\mfg\\coatings\\Machines\\X\\IN\\REC";
                    break;
                case "N":
                    initialDirectory = "\\\\tigger\\ophir\\Optics\\mfg\\coatings\\Machines\\N\\IN\\rec";
                    break;
                case "P":
                    initialDirectory = "\\\\tigger\\ophir\\Optics\\mfg\\coatings\\Machines\\P\\IN\\rec";
                    break;
                case "W":
                    initialDirectory = "\\\\tigger\\ophir\\Optics\\mfg\\coatings\\Machines\\X\\IN\\REC";
                    break;

            }
        }
        private void open_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = initialDirectory;
                openFileDialog.Filter = "json REC files (*.REC)|*.REC";
                openFileDialog.RestoreDirectory = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    //Read the contents of the file into a stream
                    jsonData = File.ReadAllText(filePath);

                    dgv.DataSource = null;
                    //machine.Text = string.Empty;
                }
            }
            //string pattern = @"(?<![0-9.])-(?![0-9])";
            //string replacement = "__";
            //jsonData = Regex.Replace(jsonData, pattern, replacement);

            ///string spacePattern = @"\S \S";
            //string spaceReplacement = "_";
            //jsonData = Regex.Replace(jsonData, spacePattern, spaceReplacement);

            //rtb.Text = jsonData;
            if (jsonData != string.Empty)
            {
                jsonData = jsonData.Replace(" ", "");
                string pattern = @"(?<![0-9.])-(?![0-9])";
                string replacement = "";

                jsonData = Regex.Replace(jsonData, pattern, replacement);
                rootobject = JsonConvert.DeserializeObject<Rootobject>(jsonData);
                show_file_name.Text = rootobject.Identification.ProcessID.ToString();
            }
        }

        private void process_btn_Click(object sender, EventArgs e)
        {
            //stopwatch.Start();
            //rtb.Text = string.Empty;
            if (jsonData == string.Empty || machine.Text == string.Empty) { return; }
            jts.Clear();

            JsonTable jsontable = new JsonTable();
            jsontable.Sequence = "Pretreatment";
            foreach (Bake bake in rootobject.Bake)
            {
                if (rootobject.Pretreatment.References.BakeModule
                    == bake.Identification.ModuleNumber)
                {
                    jsontable.ModuleName = bake.Identification.ModuleName;

                    jsontable.Rate = "Temp-1: " + bake.Parameter.Setpoint1.ToString();
                    jsontable.Thickness = "Temp-2: " + bake.Parameter.Setpoint2.ToString();
                    jsontable.Cycles = "Time: " + bake.Parameter.BakeoutTime.ToString() + " sec";
                    break;
                }
            }
            jsontable.Rotation = rootobject.Pretreatment.Parameter.General.Rotation.Setpoint.ToString();
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
                        if (jsontable.ErrorFlag)
                            id.Enqueue('E');
                        else
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
            jsontable = new JsonTable();
            jsontable.Sequence = "Posttreatment";
            if (rootobject.Posttreatment.Parameter.VentStop)
                jsontable.TSource = "Vent Stop: Yes";
            else jsontable.TSource = "Vent Stop: No";
            jsontable.Rate = "Temp: " + rootobject.Posttreatment.Parameter.VacuumCool.Temperature.ToString();
            jsontable.Thickness = "H Delay: " + rootobject.Posttreatment.Parameter.VacuumCool.HeatDelay.ToString();
            jsontable.Cycles = "Time: " + rootobject.Posttreatment.Parameter.VacuumCool.Time.ToString() + " sec";

            jts.Add(jsontable);

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
                    case 'E':
                        dgv.Rows[i].DefaultCellStyle.BackColor = Color.PaleVioletRed;
                        dgv.Rows[i].Cells[0].Style.BackColor = Color.AliceBlue;
                        break;
                }
                i++;
            }
            dgv.Rows[i].Cells[0].Style.BackColor = Color.Gainsboro;
        }

        public JsonTable GetBake(ProcessSequence ps)
        {
            JsonTable jsontable = new JsonTable();
            foreach (Bake bake in rootobject.Bake)
            {
                if (ps.ModuleNumber == bake.Identification.ModuleNumber)
                {
                    jsontable.ModuleName = bake.Identification.ModuleName;
                    jsontable.Rate = "Temp-1: " + bake.Parameter.Setpoint1.ToString();
                    jsontable.Thickness = "Temp-2: " + bake.Parameter.Setpoint2.ToString();
                    jsontable.Cycles = "Time: " + bake.Parameter.BakeoutTime.ToString() + " sec";
                    break;
                }
            }
            jsontable.Sequence = "Bake - " + ps.SequenceNumber.ToString();
            return jsontable;
        }
        public JsonTable GetLayer(ProcessSequence ps)
        {
            JsonTable jsontable = new JsonTable();
            float[] tempRateMod = new float[3] { 0, 0, 0 };
            float tempGSMMod = 0;
            float tempLimMod = 0;
            float tempSrcMod = 0;
            string special;
            int rti;
            jsontable.Sequence = "Layer - " + ps.SequenceNumber.ToString();                     //main
            foreach (Layer layer in rootobject.Layer)
            {
                if (ps.ModuleNumber == layer.Identification.ModuleNumber)
                {
                    jsontable.IsLayer = true;
                    tempRateMod[0] = layer.References.RateModule1;
                    tempRateMod[1] = layer.References.RateModule2;
                    tempRateMod[2] = layer.References.RateModule3;
                    tempLimMod = layer.References.LimitCheckModule;
                    tempGSMMod = layer.References.GSMModule;
                    jsontable.ModuleName = layer.Identification.ModuleName;
                    float thickness = layer.Parameter.General.Thickness * 10;
                    jsontable.Thickness = thickness.ToString() + "\u212B";                      //main
                    jsontable.Rotation = layer.Parameter.General.Rotation.Setpoint.ToString();  //main

                    break;
                }
            }
            for (rti = 0; rti < 3; rti++)
            {
                int showRM = rti + 1;
                LayerData dfl = new LayerData();
                if (tempRateMod[rti] == 0) break;
                foreach (Rate rate in rootobject.Rate)
                {
                    if (tempRateMod[rti] == rate.Identification.ModuleNumber)
                    {
                        float tRate = rate.Parameter.General.Rate * 10;
                        jsontable.Rate = tRate.ToString();                              //main
                        dfl.Gain = rate.Parameter.General.ControlGain.ToString();       //layer
                        dfl.HoldTime = rate.Ramping.Hold.Time.ToString();               //layer
                        dfl.PL = rate.Parameter.General.PowerLimit.ToString();          //layer
                        dfl.P3 = rate.Ramping.Ramp3.Power.ToString();                   //layer
                        dfl.T3 = rate.Ramping.Ramp3.Time.ToString();                    //layer
                        dfl.P2 = rate.Ramping.Ramp2.Power.ToString();                   //layer
                        dfl.T2 = rate.Ramping.Ramp2.Time.ToString();                    //layer
                        dfl.P1 = rate.Ramping.Ramp1.Power.ToString();                   //layer
                        dfl.T1 = rate.Ramping.Ramp1.Time.ToString();                    //layer
                        dfl.Delay = rate.Ramping.RiseDelay.ToString();                  //layer
                        tempSrcMod = rate.References.SourceModule;

                        //----------------------------error check-------------------------
                        //if (machine.Text == "E" || machine.Text == "X" || machine.Text == "P")
                        {
                            if (rate.Parameter.General.ToolingFactor != 100)
                            {
                                jsontable.ErrorFlag = true;
                                rtb.Text += "   Error in " + jsontable.Sequence + " rate module " + showRM + " " +
                                    jsontable.ModuleName + " Tooling Factor must be 100\r\n";
                            }
                            if (rate.Ramping.Hold.Time < 1)
                            {
                                jsontable.ErrorFlag = true;
                                rtb.Text += "   Error in " + jsontable.Sequence + " rate module " + showRM + " " +
                                    jsontable.ModuleName + " Hold Time must be more than 1\r\n";
                            }

                        }

                        break;
                    }

                }
                foreach (Source source in rootobject.Source)
                {
                    if (tempSrcMod == source.Identification.ModuleNumber)
                    {
                        if (source.Parameter.SourceNumber == 1)
                            jsontable.TSource = source.References.EECModule;                //main & layer
                        else
                            jsontable.TSource = source.Parameter.SourceNumber.ToString();   //main & layer
                        dfl.Source = jsontable.TSource;
                        dfl.Response = source.Xtal.ResponseTime.ToString();           //layer
                        dfl.Derivative = source.Xtal.DerivativeTime.ToString();       //layer

                        //----------------------------error check-------------------------
                        //if (machine.Text == "E" || machine.Text == "X" || machine.Text == "P")
                        {
                            if (source.Xtal.Density != 2)
                            {
                                jsontable.ErrorFlag = true;
                                rtb.Text += "   Error in " + jsontable.Sequence + " rate module " + showRM + " " +
                                    jsontable.ModuleName + " Density must be 2\r\n";
                            }
                            break;
                        }
                    }
                }
                jsontable.LayersData.Add(dfl);
            }
            if (tempLimMod != 0)
            {
                jsontable.IsMCC = true;
                foreach (LimitCheck check in rootobject.LimitCheck)
                {
                    if (tempLimMod == check.Identification.ModuleNumber)
                    {
                        foreach (CheckPoint checkPoint in check.CheckPoint)
                        {
                            MCC mCC = new MCC();
                            mCC.LowLimit = checkPoint.LowLimit.ToString();
                            mCC.HighLimit = checkPoint.HighLimit.ToString();
                            switch (checkPoint.AlarmCategory)
                            {
                                case 1:
                                    mCC.Alarm = "Information";
                                    break;
                                case 2:
                                    mCC.Alarm = "Warning";
                                    break;
                                case 3:
                                    mCC.Alarm = "Fatal";
                                    break;
                                default:
                                    mCC.Alarm = checkPoint.AlarmCategory.ToString();
                                    break;
                            }
                            mCC.State = checkPoint.Substate.ToString();
                            mCC.Element = checkPoint.ElementType.ToString();
                            mCC.Name = check.Identification.ModuleName.ToString();
                            jsontable.MCCs.Add(mCC);
                        }
                        break;
                    }
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
                            jsontable.Cycles = "Layer";                                                         //Main
                        }
                        else
                        {
                            jsontable.Cycles = jsontable.StopMode + " " + gsm.SignalSettings.NumberofCycles.ToString();    //Main
                        }

                        //----------------------------error check-------------------------
                        //if (machine.Text == "E" || machine.Text == "X" || machine.Text == "P")
                        {
                            if (gsm.Parameter.General.Glass.Changer == "GL_NEW" && gsm.Parameter.General.Intensity.Start != 47)
                            {
                                jsontable.ErrorFlag = true;
                                rtb.Text += "   Error in " + jsontable.Sequence + " " + jsontable.ModuleName + " Start Intensity must be 47% with NEW monitor\r\n";
                            }
                            if (gsm.Parameter.General.Intensity.Maximum != 100)
                            {
                                jsontable.ErrorFlag = true;
                                rtb.Text += "   Error in " + jsontable.Sequence + " " + jsontable.ModuleName + " Intensity Max must be 100%\r\n";
                            }
                            if (gsm.Parameter.General.Intensity.Minimum != 0)
                            {
                                jsontable.ErrorFlag = true;
                                rtb.Text += "   Error in " + jsontable.Sequence + " " + jsontable.ModuleName + " Intensity Min must be 0\r\n";
                            }
                            if (gsm.Parameter.General.HTemp != 150)
                            {
                                jsontable.ErrorFlag = true;
                                rtb.Text += "   Error in " + jsontable.Sequence + " " + jsontable.ModuleName + " HTemp must be 150\r\n";
                            }
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
            jsontable.Sequence = "Vacuum - " + ps.SequenceNumber.ToString();
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
                    jsontable.Thickness = "Gas ST: " + clean.Parameter.GasStabilizationTime.ToString() + " sec";
                    jsontable.Cycles = "Time: " + clean.Parameter.CleanTime.ToString() + " sec";
                    break;
                }
            }
            jsontable.Sequence = "Clean - " + ps.SequenceNumber.ToString();
            return jsontable;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;

                if (e.ColumnIndex < 3 && jts[rowIndex].IsLayer)
                    new DataForLayer(jts[rowIndex].LayersData, jts[rowIndex].Sequence).ShowDialog();
                else if (columnIndex == 5 && jts[rowIndex].IsMCC)
                    new MCCData(jts[rowIndex].MCCs).ShowDialog();
                else if (columnIndex > 5 && jts[rowIndex].IsGSM)
                    new GSMTable(jts[rowIndex]).ShowDialog();
            }
        }

        private void dgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;
                if (jts[rowIndex].IsGSM)
                {
                    if (columnIndex == 9)
                        dgv.Rows[rowIndex].Cells[columnIndex].ToolTipText = "Name: " + jts[rowIndex].Name +
                            "\nIntensity Max:" + jts[rowIndex].IntensityMax + "\nIntensity Min: " + jts[rowIndex].IntensityMin
                            + "\n--double click for GSM table--";
                    else if (columnIndex == 8)
                        dgv.Rows[rowIndex].Cells[columnIndex].ToolTipText = "Name: " + jts[rowIndex].Name +
                            "\nBeam: " + jts[rowIndex].Beam + "\nThreshold: " + jts[rowIndex].Threshold
                            + "\n--double click for GSM table--";
                    else if (columnIndex == 7)
                        dgv.Rows[rowIndex].Cells[columnIndex].ToolTipText = "Name: " + jts[rowIndex].Name +
                            "\nAlgorithm Time: " + jts[rowIndex].AlgTime + "\nAlgorithm Delay: " + jts[rowIndex].AlgDalay
                            + "\n--double click for GSM table--";
                    else if (columnIndex == 6)
                        dgv.Rows[rowIndex].Cells[columnIndex].ToolTipText = "Name: " + jts[rowIndex].Name +
                            "\nCycles: " + jts[rowIndex].SubCycles + "\nStopMode: " + jts[rowIndex].StopMode
                            + "\n--double click for GSM table--";
                }
                if (jts[rowIndex].IsLayer)
                {
                    if (columnIndex == 5)
                    {
                        if (jts[rowIndex].IsMCC)
                            dgv.Rows[rowIndex].Cells[columnIndex].ToolTipText = "--double click for MCC table--";
                        else
                            dgv.Rows[rowIndex].Cells[columnIndex].ToolTipText = "--no MCC data available--";
                    }
                }
            }
        }

    }
}
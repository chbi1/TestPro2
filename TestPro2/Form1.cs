using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Text.Encodings;
using static System.Windows.Forms.Design.AxImporter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Text.Unicode;
using System.Threading.Channels;

namespace TestPro2
{
    public partial class TestPro : Form
    {
        Rootobject rootobject;
        public List<JsonTable> jts;
        Queue<char> id;
        BoxData boxData;
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
            boxData = new BoxData();
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
                openFileDialog.Filter = "json REC files (*.REC)|*.REC|json files (*.json)|*.json";
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

            if (!string.IsNullOrEmpty(jsonData))
            {
                string pattern = @"(?<![0-9.])-(?![0-9])";
                string replacement = "___";
                jsonData = Regex.Replace(jsonData, pattern, replacement);
                jsonData = jsonData.Replace(" ", "__");
                string spacePattern = @"\n_{1,}";
                string spaceReplacement = @"";
                jsonData = Regex.Replace(jsonData, spacePattern, spaceReplacement);

                rootobject = JsonConvert.DeserializeObject<Rootobject>(jsonData)!;
                show_file_name.Text = rootobject.Identification.Process__ID.ToString();
            }

        }

        private void process_btn_Click(object sender, EventArgs e)
        {
            //stopwatch.Start();
            rtb.Text = string.Empty;
            if (jsonData == string.Empty /*|| machine.Text == string.Empty*/)
            {
                MessageBox.Show("No file slected");
                return;
            }
            jts.Clear();

            JsonTable jsontable = new JsonTable();
            jsontable.Sequence = "Pretreatment";
            foreach (Bake bake in rootobject.Bake)
            {
                if (rootobject.Pretreatment.References.Bake__Module
                    == bake.Identification.Module__Number)
                {
                    jsontable.ModuleName = bake.Identification.Module__Name;

                    jsontable.Rate = "Temp-1: " + bake.Parameter.Setpoint__1.ToString();
                    jsontable.Thickness = "Temp-2: " + bake.Parameter.Setpoint__2.ToString();
                    jsontable.Cycles = "Time: " + bake.Parameter.Bakeout__Time.ToString() + " sec";
                    break;
                }
            }
            jsontable.Rotation = rootobject.Pretreatment.Parameter.General.Rotation.Setpoint.ToString();
            jts.Add(jsontable);
            foreach (Process__Sequence sequence in rootobject.Process__Sequence)
            {

                jsontable = new JsonTable();
                switch (sequence.Module__Type)
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
            if (rootobject.Posttreatment.Parameter.Vent__Stop)
                jsontable.TSource = "Vent Stop: Yes";
            else jsontable.TSource = "Vent Stop: No";
            jsontable.Rate = "Temp: " + rootobject.Posttreatment.Parameter.Vacuum__Cool.Temperature.ToString();
            jsontable.Thickness = "H Delay: " + rootobject.Posttreatment.Parameter.Vacuum__Cool.Heat__Delay.ToString();
            jsontable.Cycles = "Time: " + rootobject.Posttreatment.Parameter.Vacuum__Cool.Time.ToString() + " sec";

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

        public JsonTable GetBake(Process__Sequence ps)
        {
            JsonTable jsontable = new JsonTable();
            foreach (Bake bake in rootobject.Bake)
            {
                if (ps.Module__Number == bake.Identification.Module__Number)
                {
                    jsontable.ModuleName = bake.Identification.Module__Name;
                    jsontable.Rate = "Temp-1: " + bake.Parameter.Setpoint__1.ToString();
                    jsontable.Thickness = "Temp-2: " + bake.Parameter.Setpoint__2.ToString();
                    jsontable.Cycles = "Time: " + bake.Parameter.Bakeout__Time.ToString() + " sec";
                    break;
                }
            }
            jsontable.Sequence = "Bake - " + ps.Sequence__Number.ToString();
            return jsontable;
        }
        public JsonTable GetLayer(Process__Sequence ps)
        {
            JsonTable jsontable = new JsonTable();
            float[] tempRateMod = new float[3] { 0, 0, 0 };
            float tempGSMMod = 0;
            float tempLimMod = 0;
            float tempSrcMod = 0;
            string special;
            int rti;
            jsontable.Sequence = "Layer - " + ps.Sequence__Number.ToString();                     //main
            foreach (Layer layer in rootobject.Layer)
            {
                if (ps.Module__Number == layer.Identification.Module__Number)
                {
                    jsontable.IsLayer = true;
                    tempRateMod[0] = layer.References.Rate__Module__1;
                    tempRateMod[1] = layer.References.Rate__Module__2;
                    tempRateMod[2] = layer.References.Rate__Module__3;
                    tempLimMod = layer.References.Limit__Check__Module;
                    tempGSMMod = layer.References.GSM__Module;
                    jsontable.ModuleName = layer.Identification.Module__Name;
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
                    if (tempRateMod[rti] == rate.Identification.Module__Number)
                    {
                        float tRate = rate.Parameter.General.Rate * 10;
                        jsontable.Rate = tRate.ToString();                              //main
                        dfl.Gain = rate.Parameter.General.Control__Gain.ToString();       //layer
                        dfl.HoldTime = rate.Ramping.Hold.Time.ToString();               //layer
                        dfl.PL = rate.Parameter.General.Power__Limit.ToString();          //layer
                        dfl.P3 = rate.Ramping.Ramp__3.Power.ToString();                   //layer
                        dfl.T3 = rate.Ramping.Ramp__3.Time.ToString();                    //layer
                        dfl.P2 = rate.Ramping.Ramp__2.Power.ToString();                   //layer
                        dfl.T2 = rate.Ramping.Ramp__2.Time.ToString();                    //layer
                        dfl.P1 = rate.Ramping.Ramp__1.Power.ToString();                   //layer
                        dfl.T1 = rate.Ramping.Ramp__1.Time.ToString();                    //layer
                        dfl.Delay = rate.Ramping.Rise__Delay.ToString();                  //layer
                        tempSrcMod = rate.References.Source__Module;

                        //----------------------------error check-------------------------
                        //if (machine.Text == "E" || machine.Text == "X" || machine.Text == "P")
                        {
                            if (rate.Parameter.General.Tooling__Factor != 100)
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
                    if (tempSrcMod == source.Identification.Module__Number)
                    {
                        if (source.Parameter.Source__Number == 1)
                            jsontable.TSource = source.References.EEC__Module;                //main & layer
                        else
                            jsontable.TSource = source.Parameter.Source__Number.ToString();   //main & layer
                        dfl.Source = jsontable.TSource;
                        dfl.Response = source.Xtal.Response__Time.ToString();           //layer
                        dfl.Derivative = source.Xtal.Derivative__Time.ToString();       //layer

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
                foreach (Limit__Check check in rootobject.Limit__Check)
                {
                    if (tempLimMod == check.Identification.Module__Number)
                    {
                        foreach (Check__Point checkPoint in check.Check__Point)
                        {
                            MCC mCC = new MCC();
                            mCC.LowLimit = checkPoint.Low__Limit.ToString();
                            mCC.HighLimit = checkPoint.High__Limit.ToString();
                            switch (checkPoint.Alarm__Category)
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
                                    mCC.Alarm = checkPoint.Alarm__Category.ToString();
                                    break;
                            }
                            mCC.State = checkPoint.Substate.ToString();
                            mCC.Element = checkPoint.Element__Type.ToString();
                            mCC.Name = check.Identification.Module__Name.ToString();
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
                    if (tempGSMMod == gsm.Identification.Module__Number)
                    {
                        jsontable.StartIntensity = gsm.Parameter.General.Intensity.Start.ToString();            //Main & GSM
                        jsontable.IntensityMax = gsm.Parameter.General.Intensity.Maximum.ToString();            //GSM
                        jsontable.IntensityMin = gsm.Parameter.General.Intensity.Minimum.ToString();            //GSM
                        jsontable.Threshold = gsm.Parameter.General.Threshold.ToString();                       //GSM
                        jsontable.Wavelength = gsm.Signal__Settings.Lambda.ToString();                            //Main & GSM
                        jsontable.AlgDalay = gsm.Signal__Settings.Algorithm__Delay.ToString();                      //GSM
                        jsontable.AlgTime = gsm.Signal__Settings.Algorithm__Time.ToString();                        //GSM
                        jsontable.SubCycles = gsm.Signal__Settings.Number__of__Cycles.ToString();                     //GSM
                        jsontable.Name = gsm.Identification.Module__Name;                                         //GSM

                        // ------------------- special words --------------------
                        special = gsm.Parameter.General.Transmission;
                        special = special.Split('_').Last();
                        jsontable.Beam = special;                                                               //GSM
                        jsontable.Monitor = gsm.Parameter.General.Glass.Changer;
                        //special = special.Split('_').Last();
                        //jsontable.Monitor = special;                                                            //Main & GSM 
                        special = gsm.Signal__Settings.Stop__Criterion;
                        special = special.Split('_').First();

                        jsontable.StopMode = special;                                                           //GSM

                        if (jsontable.StopMode == "QUARTZ")
                        {
                            jsontable.Cycles = "Layer";                                                         //Main
                        }
                        else
                        {
                            jsontable.Cycles = jsontable.StopMode + " " + gsm.Signal__Settings.Number__of__Cycles.ToString();    //Main
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
        public JsonTable GetVacuum(Process__Sequence ps)
        {
            JsonTable jsontable = new JsonTable();
            foreach (Vacuum1 vacuum in rootobject.Vacuum)
            {
                if (ps.Module__Number == vacuum.Identification.Module__Number)
                {
                    jsontable.ModuleName = vacuum.Identification.Module__Name;
                    break;
                }
            }
            jsontable.Sequence = "Vacuum - " + ps.Sequence__Number.ToString();
            return jsontable;
        }
        public JsonTable GetClean(Process__Sequence ps)
        {
            JsonTable jsontable = new JsonTable();
            foreach (Clean clean in rootobject.Clean)
            {
                if (ps.Module__Number == clean.Identification.Module__Number)
                {
                    jsontable.ModuleName = clean.Identification.Module__Name;
                    jsontable.Thickness = "Gas ST: " + clean.Parameter.Gas__Stabilization__Time.ToString() + " sec";
                    jsontable.Cycles = "Time: " + clean.Parameter.Clean__Time.ToString() + " sec";
                    break;
                }
            }
            jsontable.Sequence = "Clean - " + ps.Sequence__Number.ToString();
            return jsontable;
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;

                if (e.ColumnIndex < 3 && jts[rowIndex].IsLayer)
                    new DataForLayer(jts[rowIndex].LayersData, jts[rowIndex].Sequence).ShowDialog();
                else if (columnIndex == 5)
                {
                    if (jts[rowIndex].IsMCC)
                        new MCCData(jts[rowIndex].MCCs).ShowDialog();
                    else
                        MessageBox.Show("--no MCC data available--");
                }
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

        private void save_btn_Click(object sender, EventArgs e)
        {
            string output = JsonConvert.SerializeObject(rootobject, Formatting.Indented);
            output = output.Replace("___", "-");
            output = output.Replace("__", " ");

            //string floatPattern = @"\.0\,";
            //string floatReplacement = @",";
            //output = Regex.Replace(jsonData, floatPattern, floatReplacement);

            rtb.Text = output;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = initialDirectory;
            saveFileDialog1.Filter = "json REC files (*.REC)|*.REC|json files (*.json)|*.json";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file name from the dialog

                string selectedFileName = saveFileDialog1.FileName;

                // Code to generate or retrieve the 'output' content goes here.
                // ...

                // Write the content directly to the selected file using File.WriteAllText
                File.WriteAllText(selectedFileName, output);
            }

        }

        private void edit_Click(object sender, EventArgs e)
        {
            dgv.ReadOnly = false;
        }

        private void TestPro_Load(object sender, EventArgs e)
        {
            string jsonBox = File.ReadAllText("data.json");
            boxData = JsonConvert.DeserializeObject<BoxData>(jsonBox);
        }
    }
}
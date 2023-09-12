using Newtonsoft.Json;
using System.Text;
using System.Text.RegularExpressions;


namespace TestPro2
{
    public partial class TestPro : Form
    {
        Rootobject? rootobject;
        public List<JsonTable> jts;
        List<Evaporators>? evaporators;
        LayerData[] layerArr;
        Queue<char> id;
        string jsonData = string.Empty;
        string filePath = string.Empty;
        string initialDirectory;
        public TestPro()
        {
            InitializeComponent();
            jts = new List<JsonTable>();
            id = new Queue<char>();
            layerArr = new LayerData[9];

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
                else
                    return;
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
                if (jsonData != null)
                {
                    rootobject = JsonConvert.DeserializeObject<Rootobject>(jsonData)!;
                    show_file_name.Text = rootobject.Identification.ProcessID.ToString();
                    process_btn_Click(sender, e);
                }
            }
        }
        private void process_btn_Click(object sender, EventArgs e)
        {
            rtb.Text = string.Empty;
            if (jsonData == string.Empty)
            {
                MessageBox.Show("No file slected");
                return;
            }
            jts.Clear();
            layerArr = CleenArrData(layerArr);

            JsonTable jsontable = new JsonTable();
            jsontable = GetBake(rootobject.Pretreatment.References.BakeModule);
            jsontable.Sequence = "Pretreatment";
            jsontable.Rotation = rootobject.Pretreatment.Parameter.General.Rotation.Setpoint.ToString();
            jts.Add(jsontable);
            foreach (ProcessSequence sequence in rootobject.ProcessSequence)
            {

                jsontable = new JsonTable();
                switch (sequence.ModuleType)
                {
                    case "B":
                        jsontable = GetBake(sequence.ModuleNumber);
                        jsontable.Sequence = "Bake - " + sequence.SequenceNumber.ToString();
                        id.Enqueue('B');
                        break;

                    case "C":
                        jsontable = GetClean(sequence.ModuleNumber);
                        jsontable.Sequence = "Clean - " + sequence.SequenceNumber.ToString();
                        id.Enqueue('C');
                        break;

                    case "L":
                        jsontable = GetLayer(sequence.ModuleNumber);
                        jsontable.SequenceNum = sequence.SequenceNumber.ToString();
                        jsontable.Sequence = "Layer - " + jsontable.SequenceNum;                            //main
                        if (jsontable.ErrorFlag)
                            id.Enqueue('E');
                        else
                            id.Enqueue('L');
                        break;

                    case "V":
                        jsontable = GetVacuum(sequence.ModuleNumber);
                        jsontable.Sequence = "Vacuum - " + sequence.SequenceNumber.ToString();
                        id.Enqueue('V');
                        break;
                }
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
                        dgv.Rows[i].DefaultCellStyle.BackColor = Color.Coral;
                        dgv.Rows[i].Cells[0].Style.BackColor = Color.AliceBlue;
                        break;
                }
                i++;
            }
            dgv.Rows[i].Cells[0].Style.BackColor = Color.Gainsboro;

            dgv_source.DataSource = null;
            dgv_source.Rows.Clear();
            GetComboBox(dgv_source);
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;

                if (e.ColumnIndex < 3 && jts[rowIndex].IsLayer)
                    new DataForLayer(jts[rowIndex].LayersData, jts[rowIndex].SequenceNum).ShowDialog();
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
                            dgv.Rows[rowIndex].Cells[columnIndex].ToolTipText = "--double click for Limits table--";
                        else
                            dgv.Rows[rowIndex].Cells[columnIndex].ToolTipText = "--no Limits data available--";
                    }
                }
            }
        }

        public JsonTable GetBake(float moduleNumber)
        {
            JsonTable jsontable = new JsonTable();
            Bake bake = rootobject.Bake.ToList().Find(b => b.Identification.ModuleNumber == moduleNumber)!;
            if (bake != null)
            {
                jsontable.ModuleName = bake.Identification.ModuleName;
                jsontable.Rate = "Temp-1: " + bake.Parameter.Setpoint1.ToString();
                jsontable.Thickness = "Temp-2: " + bake.Parameter.Setpoint2.ToString();
                jsontable.Cycles = "Time: " + bake.Parameter.BakeoutTime.ToString() + " sec";
            }
            else
                MessageBox.Show("Error in bake, Module not found");
            return jsontable;
        }
        public JsonTable GetLayer(float moduleNumber)
        {
            JsonTable jsontable = new JsonTable();
            int[] tempRateMod = new int[3] { 0, 0, 0 };
            float tempGSMMod = 0;
            float tempLimMod = 0;
            float tempSrcMod = 0;
            string special;
            int rti;

            Layer layer;
            layer = rootobject.Layer.ToList().Find(l => l.Identification.ModuleNumber == moduleNumber)!;
            if (layer != null)
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
            }
            else
            {
                MessageBox.Show("Error in layer, Module not found");
            }
            Rate? rate = null;
            Source? source = null;
            for (rti = 0; rti < 3; rti++)
            {
                int showRM = rti + 1;
                LayerData data = new LayerData();
                if (tempRateMod[rti] == 0) break;

                rate = rootobject.Rate.ToList().Find(r => r.Identification.ModuleNumber == tempRateMod[rti])!;
                if (rate != null)
                {
                    data = GetRate(tempRateMod[rti]);
                    jsontable.RateModule[rti] = tempRateMod[rti];
                    tempSrcMod = rate.References.SourceModule;

                    //----------------------------error check-------------------------
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
                else
                {
                    MessageBox.Show("Error in rate, Module not found");
                }

                source = rootobject.Source.ToList().Find(s => s.Identification.ModuleNumber == tempSrcMod)!;
                if (source != null)
                {
                    //----------------------------error check-------------------------
                    if (source.Xtal.Density != 2)
                    {
                        jsontable.ErrorFlag = true;
                        rtb.Text += "   Error in " + jsontable.Sequence + " rate module " + showRM + " " +
                            jsontable.ModuleName + " Density must be 2\r\n";
                    }
                }
                else
                {
                    MessageBox.Show("Error in source, Module not found");
                }

                jsontable.LayersData.Add(data);


            }
            if (rate != null && source != null)
            {
                float tRate = rate.Parameter.General.Rate * 10;
                jsontable.Rate = tRate.ToString();                                      //main
                if (source.Parameter.SourceNumber == 1)
                    jsontable.TSource = source.References.EECModule;                    //main
                else
                    jsontable.TSource = source.Parameter.SourceNumber.ToString();       //main
            }
            else
            {
                MessageBox.Show("Error in rate or source, Module not found");
            }



            if (tempLimMod != 0)
            {
                jsontable.IsMCC = true;
                LimitCheck check = rootobject.LimitCheck.ToList().Find(c => c.Identification.ModuleNumber == tempLimMod)!;
                if (check != null)
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
                }
                else
                {
                    MessageBox.Show("Error in Limit Check, Module not found");
                }

            }
            if (tempGSMMod != 0)
            {
                jsontable.IsGSM = true;
                GSM1 gsm = rootobject.GSM.ToList().Find(g => g.Identification.ModuleNumber == tempGSMMod)!;

                if (gsm != null)
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
                else
                {
                    MessageBox.Show("Error in GSM, Module not found");
                }
            }
            return jsontable;
        }
        public JsonTable GetVacuum(float moduleNumber)
        {
            JsonTable jsontable = new JsonTable();
            Vacuum1 vacuum = rootobject.Vacuum.ToList().Find(v => v.Identification.ModuleNumber == moduleNumber)!;
            if (vacuum != null)
                jsontable.ModuleName = vacuum.Identification.ModuleName;
            else
                MessageBox.Show("Error in Vacuum, Module not found");
            return jsontable;
        }
        public JsonTable GetClean(float moduleNumber)
        {
            JsonTable jsontable = new JsonTable();
            Clean clean;
            clean = rootobject.Clean.ToList().Find(c => c.Identification.ModuleNumber == moduleNumber)!;
            if (clean != null)
            {
                jsontable.ModuleName = clean.Identification.ModuleName;
                jsontable.Thickness = "Gas ST: " + clean.Parameter.GasStabilizationTime.ToString() + " sec";
                jsontable.Cycles = "Time: " + clean.Parameter.CleanTime.ToString() + " sec";
            }
            else
            {
                MessageBox.Show("Error in clean, Module not found");
            }
            return jsontable;
        }
        public LayerData GetRate(int module)
        {
            Rate rate = rootobject.Rate.ToList().Find(r => r.Identification.ModuleNumber == module)!;

            int arrPos = -1;
            LayerData layer = new LayerData();
            float tRate = rate.Parameter.General.Rate * 10;
            layer.Rate = tRate;
            layer.ModuleName = rate.Identification.ModuleName;
            layer.RateModule = rate.Identification.ModuleNumber;
            layer.Gain = rate.Parameter.General.ControlGain;       //layer
            layer.HoldTime = rate.Ramping.Hold.Time;               //layer
            layer.PL = rate.Parameter.General.PowerLimit;          //layer
            layer.P3 = rate.Ramping.Ramp3.Power;                   //layer
            layer.T3 = rate.Ramping.Ramp3.Time;                    //layer
            layer.P2 = rate.Ramping.Ramp2.Power;                   //layer
            layer.T2 = rate.Ramping.Ramp2.Time;                    //layer
            layer.P1 = rate.Ramping.Ramp1.Power;                   //layer
            layer.T1 = rate.Ramping.Ramp1.Time;
            layer.Delay = rate.Ramping.RiseDelay.ToString();
            Source source = rootobject.Source.ToList().Find(s => s.Identification.ModuleNumber == rate.References.SourceModule)!;
            if (source != null)
            {
                layer.Pos = source.Parameter.SourceNumber;
                if (layer.Pos == 1)
                {
                    layer.Scan = source.References.EECModule.Split('_').First();
                    layer.Source = source.References.EECModule;
                    char getPos = layer.Source[layer.Source.Length - 1];
                    int.TryParse(getPos.ToString(), out arrPos);
                    arrPos--;
                }
                else
                {
                    arrPos = layer.Pos + 4;
                    layer.Source = source.Parameter.SourceNumber.ToString();
                }


                layer.Response = source.Xtal.ResponseTime;           //layer
                layer.Derivative = source.Xtal.DerivativeTime;       //layer
                List<Evaporators> temp = evaporators.FindAll(e => layer.ModuleName.ToLower().Replace(" ", "").Replace("*", ".").Contains(e.Matter.ToLower().Replace(" ", ""))
                    || e.Matter.ToLower().Replace(" ", "").Contains(layer.ModuleName.ToLower().Replace(" ", "").Replace("*", ".")));
                foreach (Evaporators evp in temp)
                {
                    layer.Src.Add(evp.Src);
                }
                layer.Src = layer.Src.Distinct().ToList();
            }
            if (arrPos > -1)
            {
                if (layerArr[arrPos] != null && layerArr[arrPos].RateModule != layer.RateModule)
                {
                    MessageBox.Show("There is an error where two different rate modules are pointing to the same source.\nnames" + layer.ModuleName + " and " + layerArr[arrPos].ModuleName, "Error");
                }
                layerArr[arrPos] = layer;
            }
            return layer;

        }

        //------------------------------rate tab--------------------------------------

        public DataGridView GetComboBox(DataGridView dataGrid)
        {
            dataGrid.ColumnCount = 5;
            dataGrid.Columns[0].Name = "Pos";
            dataGrid.Columns[1].Name = "Matter";
            dataGrid.Columns[2].Name = "Source";
            dataGrid.Columns[3].Name = "Rate";
            dataGrid.Columns[4].Name = "Scan";
            dataGrid.Columns[0].Width = 50;
            dataGrid.Columns[3].Width = 70;
            dataGrid.RowCount = layerArr.Length;
            for (int i = 0; i < layerArr.Length; i++)
            {
                dataGrid.Rows[i].Cells[1].Value = null;
                dataGrid.Rows[i].Cells[2].Value = null;
                dataGrid.Rows[i].Cells[3].Value = null;
                dataGrid.Rows[i].Cells[4].Value = null;
                int po;
                if (i < 6)
                    po = i + 1;
                else
                    po = i - 4;
                dataGrid.Rows[i].Cells[0].ReadOnly = true;
                dataGrid.Rows[i].Cells[1].ReadOnly = true;
                dataGrid.Rows[i].Cells[2].ReadOnly = true;
                dataGrid.Rows[i].Cells[3].ReadOnly = true;
                dataGrid.Rows[i].Cells[4].ReadOnly = true;

                dataGrid.Rows[i].Cells[0].Value = po;
                if (layerArr[i] != null)
                {
                    // Add cells to the row
                    dataGrid.Rows[i].Cells[1].Value = layerArr[i].ModuleName;

                    // Assuming CreateComboBoxColumn() creates a combo box column
                    if (layerArr[i].Src.Count == 1)
                    {
                        dataGrid.Rows[i].Cells[2].Value = layerArr[i].Src[0];
                    }

                    else
                    {
                        DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
                        dataGrid.Rows[i].Cells[2].ReadOnly = false;

                        comboBoxCell.DataSource = layerArr[i].Src; // Assuming Src is a list or data source
                        dataGrid.Rows[i].Cells[2] = comboBoxCell;
                    }

                    dataGrid.Rows[i].Cells[3].Value = layerArr[i].Rate;
                    dataGrid.Rows[i].Cells[4].Value = layerArr[i].Scan;
                }

            }
            return dataGrid;
        }
        public DataGridView GetParameters(DataGridView param)
        {


            if (dgv_source != null)
            {

                param.ColumnCount = 13;
                param.Columns[0].Name = "";
                param.Columns[1].Name = "Matter";
                param.Columns[2].Name = "T1";
                param.Columns[3].Name = "P1";
                param.Columns[4].Name = "T2";
                param.Columns[5].Name = "P2";
                param.Columns[6].Name = "T3";
                param.Columns[7].Name = "P3";
                param.Columns[8].Name = "PL";
                param.Columns[9].Name = "HoldTime";
                param.Columns[10].Name = "Gain";
                param.Columns[11].Name = "RT";
                param.Columns[12].Name = "DT";


                bool color = false;

                for (int i = 0; i < dgv_source.Rows.Count; i++)
                {
                    int po;
                    if (i < 6)
                        po = i + 1;
                    else
                        po = i - 4;
                    DataGridViewRow recRow = new DataGridViewRow();
                    DataGridViewRow masterRow = new DataGridViewRow();

                    if ((dgv_source.Rows[i].Cells[2].Selected || dgv_source.Rows[i].Cells[2].Value != null) && layerArr[i] != null)
                    {
                        try
                        {
                            Evaporators? ev = evaporators.Find(e => layerArr[i].ModuleName.ToLower().Replace(" ", "").Replace("*", ".").Contains(e.Matter.ToLower().Replace(" ", ""))
                                && e.Pos == layerArr[i].Pos && e.Src == dgv_source.Rows[i].Cells[2].Value.ToString()
                                && e.Rate == layerArr[i].Rate && (layerArr[i].Scan.ToLower().Replace(" ", "").Contains(e.Scan.ToLower().Replace(" ", ""))
                                || e.Scan.ToLower().Replace(" ", "").Contains(layerArr[i].Scan.ToLower().Replace(" ", ""))))!;
                            if (ev != null)
                            {
                                if (color)
                                {
                                    color = false;
                                    recRow.DefaultCellStyle.BackColor = Color.LemonChiffon;
                                    masterRow.DefaultCellStyle.BackColor = Color.LemonChiffon;
                                }
                                else
                                {
                                    color = true;
                                    recRow.DefaultCellStyle.BackColor = Color.Lavender;
                                    masterRow.DefaultCellStyle.BackColor = Color.Lavender;
                                }
                                recRow.Cells.Add(new DataGridViewTextBoxCell { Value = "File " + po });
                                masterRow.Cells.Add(new DataGridViewTextBoxCell { Value = "Param " + po });

                                recRow.Cells.Add(new DataGridViewTextBoxCell { Value = layerArr[i].ModuleName });
                                masterRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.Matter });

                                recRow.Cells.Add(new DataGridViewTextBoxCell { Value = layerArr[i].T1 });
                                masterRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.T1 });
                                if (layerArr[i].T1 != ev.T1)
                                {
                                    recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    masterRow.Cells[masterRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                }

                                recRow.Cells.Add(new DataGridViewTextBoxCell { Value = layerArr[i].P1 });
                                masterRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.P1 });
                                if (layerArr[i].P1 != ev.P1)
                                {
                                    recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    masterRow.Cells[masterRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                }

                                recRow.Cells.Add(new DataGridViewTextBoxCell { Value = layerArr[i].T2 });
                                masterRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.T2 });
                                if (layerArr[i].T2 != ev.T2)
                                {
                                    recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    masterRow.Cells[masterRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                }

                                recRow.Cells.Add(new DataGridViewTextBoxCell { Value = layerArr[i].P2 });
                                masterRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.P2 });
                                if (layerArr[i].P2 != ev.P2)
                                {
                                    recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    masterRow.Cells[masterRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                }

                                recRow.Cells.Add(new DataGridViewTextBoxCell { Value = layerArr[i].T3 });
                                masterRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.T3 });
                                if (layerArr[i].T3 != ev.T3)
                                {
                                    recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    masterRow.Cells[masterRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                }

                                recRow.Cells.Add(new DataGridViewTextBoxCell { Value = layerArr[i].P3 });
                                masterRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.P3 });
                                if (layerArr[i].P3 != ev.P3)
                                {
                                    recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    masterRow.Cells[masterRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                }

                                recRow.Cells.Add(new DataGridViewTextBoxCell { Value = layerArr[i].PL });
                                masterRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.PL });
                                if (layerArr[i].PL != ev.PL)
                                {
                                    recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    masterRow.Cells[masterRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                }

                                recRow.Cells.Add(new DataGridViewTextBoxCell { Value = layerArr[i].HoldTime });
                                masterRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.HoldTime });
                                if (layerArr[i].HoldTime != ev.HoldTime)
                                {
                                    recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    masterRow.Cells[masterRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                }

                                recRow.Cells.Add(new DataGridViewTextBoxCell { Value = layerArr[i].Gain });
                                masterRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.Gain });
                                if (layerArr[i].Gain != ev.Gain)
                                {
                                    recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    masterRow.Cells[masterRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                }

                                recRow.Cells.Add(new DataGridViewTextBoxCell { Value = layerArr[i].Response });
                                masterRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.RT });
                                if (layerArr[i].Response != ev.RT)
                                {
                                    recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    masterRow.Cells[masterRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                }

                                recRow.Cells.Add(new DataGridViewTextBoxCell { Value = layerArr[i].Derivative });
                                masterRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.DT });
                                if (layerArr[i].Derivative != ev.DT)
                                {
                                    recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    masterRow.Cells[masterRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                }

                                param.Rows.Add(masterRow);
                                param.Rows.Add(recRow);
                            }
                            else
                            {
                                recRow.Cells.Add(new DataGridViewTextBoxCell { Value = "no data " + po });
                                recRow.Cells.Add(new DataGridViewTextBoxCell { Value = dgv_source.Rows[i].Cells[1].Value });
                                param.Rows.Add(recRow);
                                MessageBox.Show("no data find for "+ dgv_source.Rows[i].Cells[1].Value + " try changing source");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error while creating layer grid");
                        }
                    }
                    
                }

            }
            return param;
        }
        private void chack_btn_Click(object sender, EventArgs e)
        {
            dgv_param.DataSource = null;
            dgv_param.Rows.Clear();
            GetParameters(dgv_param);


            //dgv_param.DataSource = evapArr;
        }
        private void machine_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            jsonData = File.ReadAllText(Properties.Settings.Default.jsonDir + "Machine" + machine_box.Text + ".json", Encoding.UTF8);
            evaporators = JsonConvert.DeserializeObject<List<Evaporators>>(jsonData)!;
        }
        private LayerData[] CleenArrData(LayerData[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = null;
            }
            return array;
        }
    }
}
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;


namespace TestPro2
{
    public partial class TestPro : Form
    {
        // json deserialization main object
        Rootobject? rootobject;

        // main table and holds details for all the pop up tables
        private List<JsonTable> jsonMasterTable;

        // all machine calibrations for all evaporators
        List<Evaporators>? evaporators;

        // saves data of the boats and curcibles
        List<LayerData> sourceTable;

        // saves data for table colors
        Queue<char> id;

        string jsonData = string.Empty;
        string filePath = string.Empty;
        string initialDirectory;
        public TestPro()
        {
            InitializeComponent();
            jsonMasterTable = new List<JsonTable>();
            id = new Queue<char>();
            sourceTable = new List<LayerData>();
            initialDirectory = "c:\\Users\\user\\Desktop";
        }
        //------------------------------head----------------------------
        private void machine_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (machine.Text)
            {
                case "E":
                    initialDirectory = Properties.Settings.Default.dbMachineE;
                    break;
                case "X":
                    initialDirectory = Properties.Settings.Default.dbMachineX;
                    break;
                case "N":
                    initialDirectory = Properties.Settings.Default.dbMachineN;
                    break;
                case "P":
                    initialDirectory = Properties.Settings.Default.dbMachineP;
                    break;

            }
            try
            {
                jsonData = File.ReadAllText(Properties.Settings.Default.jsonDir + "Machine" + machine.Text + ".json", Encoding.UTF8);
                evaporators = JsonConvert.DeserializeObject<List<Evaporators>>(jsonData)!;
            }
            catch { MessageBox.Show("Parameters file not found, Srouce teble functionality won't work"); }
        }
        private void admin_btn_Click(object sender, EventArgs e)
        {
            new DbControl().ShowDialog();
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
                }
                else
                    return;
            }

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
            if (jsonData == string.Empty || rootobject == null)
            {
                MessageBox.Show("No file slected");
                return;
            }
            jsonMasterTable.Clear();
            sourceTable.Clear();


            JsonTable jsontable;
            jsontable = GetBake(rootobject.Pretreatment.References.BakeModule);
            jsontable.Sequence = "Pretreatment";
            jsontable.Rotation = rootobject.Pretreatment.Parameter.General.Rotation.Setpoint.ToString();
            jsonMasterTable.Add(jsontable);
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
                jsonMasterTable.Add(jsontable);
            }
            jsontable = new JsonTable();
            jsontable.Sequence = "Posttreatment";
            if (rootobject.Posttreatment.Parameter.VentStop)
                jsontable.TSource = "Vent Stop: Yes";
            else jsontable.TSource = "Vent Stop: No";
            jsontable.Rate = "Temp: " + rootobject.Posttreatment.Parameter.VacuumCool.Temperature.ToString();
            jsontable.Thickness = "H Delay: " + rootobject.Posttreatment.Parameter.VacuumCool.HeatDelay.ToString();
            jsontable.Cycles = "Time: " + rootobject.Posttreatment.Parameter.VacuumCool.Time.ToString() + " sec";

            jsonMasterTable.Add(jsontable);

            dgv.DataSource = null;
            dgv.DataSource = jsonMasterTable;

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
            GetDgSource(dgv_source);
        }

        //--------------------------rec processer------------------------
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;

                if (e.ColumnIndex < 3 && jsonMasterTable[rowIndex].IsLayer)
                    new DataForLayer(jsonMasterTable[rowIndex].LayersData, jsonMasterTable[rowIndex].SequenceNum).ShowDialog();
                else if (columnIndex == 5 && jsonMasterTable[rowIndex].IsMCC)
                    new MCCData(jsonMasterTable[rowIndex].MCCs).ShowDialog();
                else if (columnIndex > 5 && jsonMasterTable[rowIndex].IsGSM)
                    new GSMTable(jsonMasterTable[rowIndex]).ShowDialog();
            }
        }
        private void dgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;
                if (jsonMasterTable[rowIndex].IsGSM)
                {
                    if (columnIndex == 9)
                        dgv.Rows[rowIndex].Cells[columnIndex].ToolTipText = "Name: " + jsonMasterTable[rowIndex].Name +
                            "\nIntensity Max:" + jsonMasterTable[rowIndex].IntensityMax + "\nIntensity Min: " + jsonMasterTable[rowIndex].IntensityMin
                            + "\n--double click for GSM table--";
                    else if (columnIndex == 8)
                        dgv.Rows[rowIndex].Cells[columnIndex].ToolTipText = "Name: " + jsonMasterTable[rowIndex].Name +
                            "\nBeam: " + jsonMasterTable[rowIndex].Beam + "\nThreshold: " + jsonMasterTable[rowIndex].Threshold
                            + "\n--double click for GSM table--";
                    else if (columnIndex == 7)
                        dgv.Rows[rowIndex].Cells[columnIndex].ToolTipText = "Name: " + jsonMasterTable[rowIndex].Name +
                            "\nAlgorithm Time: " + jsonMasterTable[rowIndex].AlgTime + "\nAlgorithm Delay: " + jsonMasterTable[rowIndex].AlgDalay
                            + "\n--double click for GSM table--";
                    else if (columnIndex == 6)
                        dgv.Rows[rowIndex].Cells[columnIndex].ToolTipText = "Name: " + jsonMasterTable[rowIndex].Name +
                            "\nCycles: " + jsonMasterTable[rowIndex].SubCycles + "\nStopMode: " + jsonMasterTable[rowIndex].StopMode
                            + "\n--double click for GSM table--";
                }
                if (jsonMasterTable[rowIndex].IsLayer)
                {
                    if (columnIndex == 5)
                    {
                        if (jsonMasterTable[rowIndex].IsMCC)
                            dgv.Rows[rowIndex].Cells[columnIndex].ToolTipText = "--double click for Limits table--";
                        else
                            dgv.Rows[rowIndex].Cells[columnIndex].ToolTipText = "--no Limits data available--";
                    }
                    if (columnIndex < 3)
                    {
                        if (jsonMasterTable[rowIndex].LayersData.Count == 1)
                            dgv.Rows[rowIndex].Cells[columnIndex].ToolTipText = jsonMasterTable[rowIndex].LayersData.Count.ToString() + " rate module is used";
                        else
                            dgv.Rows[rowIndex].Cells[columnIndex].ToolTipText = jsonMasterTable[rowIndex].LayersData.Count.ToString() + " rate modules are used";
                    }
                }
            }
        }

        public JsonTable GetBake(float moduleNumber)
        {
            JsonTable jsontable = new JsonTable();
            Bake bake = rootobject!.Bake.ToList().Find(b => b.Identification.ModuleNumber == moduleNumber)!;
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
            layer = rootobject!.Layer.ToList().Find(l => l.Identification.ModuleNumber == moduleNumber)!;
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
                if (tempRateMod[rti] == 0) break;


                rate = rootobject.Rate.ToList().Find(r => r.Identification.ModuleNumber == tempRateMod[rti])!;
                if (rate != null)
                {
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
                    source = rootobject.Source.ToList().Find(s => s.Identification.ModuleNumber == tempSrcMod)!;
                    if (source != null)
                    {
                        int arrPos = -1;
                        if (source.Parameter.SourceNumber == 1)
                        {
                            char getPos = source.References.EECModule[source.References.EECModule.Length - 1];
                            int.TryParse(getPos.ToString(), out arrPos);
                        }
                        else
                        {
                            arrPos = source.Parameter.SourceNumber + 5;
                        }
                        if (arrPos > -1)
                        {
                            LayerData? data = sourceTable.Find(st => st.PosInMachine == arrPos && st.RateModule == tempRateMod[rti]);
                            if (data != null)
                            {
                                jsontable.LayersData.Add(data);
                            }
                            else
                            {
                                data = GetRate(tempRateMod[rti]);
                                data.PosInMachine = arrPos;
                                sourceTable.Add(data);
                                jsontable.LayersData.Add(data);
                            }
                        }
                        else
                        {
                            LayerData data = GetRate(tempRateMod[rti]);
                            jsontable.LayersData.Add(data);
                            MessageBox.Show("couldn't locate the Crucible of " + data.ModuleName + ".");
                        }

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
                }
                else
                {
                    MessageBox.Show("Error in rate, Module not found");
                }

            }
            if (rate != null)
            {
                float tRate = rate.Parameter.General.Rate * 10;
                jsontable.Rate = tRate.ToString();                                      //main
            }
            if (source != null)
            {
                if (source.Parameter.SourceNumber == 1)
                    jsontable.TSource = source.References.EECModule;                    //main
                else
                    jsontable.TSource = source.Parameter.SourceNumber.ToString();
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
                    special = special.Split('_')[special.Split('_').Count() - 1];
                    jsontable.Beam = special;                                                               //GSM
                    special = gsm.Parameter.General.Glass.Changer;
                    special = special.Split('_')[special.Split('_').Count() - 1];
                    jsontable.Monitor = special;                                                            //Main & GSM 
                    special = gsm.SignalSettings.StopCriterion;
                    special = special.Split('_')[0];

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
            Vacuum1 vacuum = rootobject!.Vacuum.ToList().Find(v => v.Identification.ModuleNumber == moduleNumber)!;
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
            clean = rootobject!.Clean.ToList().Find(c => c.Identification.ModuleNumber == moduleNumber)!;
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
            LayerData layer = new LayerData();
            Rate rate = rootobject!.Rate.ToList().Find(r => r.Identification.ModuleNumber == module)!;
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
                    layer.Scan = source.References.EECModule.Split('_')[0];
                    layer.Source = source.References.EECModule;
                }
                else
                {
                    layer.Source = source.Parameter.SourceNumber.ToString();
                }


                layer.Response = source.Xtal.ResponseTime;
                layer.Derivative = source.Xtal.DerivativeTime;
                if (evaporators != null)
                {
                    if (layer.Pos == 1)
                    {
                        layer.Src = evaporators.FindAll(evp => (layer.ModuleName.ToLower().Replace(" ", "").Replace("*", ".").Contains(evp.Matter!.ToLower().Replace(" ", ""))
                        || evp.Matter.ToLower().Replace(" ", "").Contains(layer.ModuleName.ToLower().Replace(" ", "").Replace("*", ".")))
                        && evp.Pos == layer.Pos && evp.Rate == layer.Rate).Select(evp => evp.Src!).Distinct().ToList();
                    }
                    else
                    {
                        layer.Src = evaporators.FindAll(evp => (layer.ModuleName.ToLower().Replace(" ", "").Replace("*", ".").Contains(evp.Matter!.ToLower().Replace(" ", ""))
                        || evp.Matter.ToLower().Replace(" ", "").Contains(layer.ModuleName.ToLower().Replace(" ", "").Replace("*", ".")))
                        && evp.Rate == layer.Rate && evp.Pos != 1).Select(evp => evp.Src!).Distinct().ToList();
                    }
                }
                else
                    layer.Src.Add("error no param file");
            }
            return layer;

        }

        //------------------------------rate tab--------------------------------------

        private void chack_btn_Click(object sender, EventArgs e)
        {
            if (evaporators == null || evaporators.Count == 0)
            { return; }
            dgv_param.DataSource = null;
            dgv_param.Rows.Clear();
            GetParameters(dgv_param);


        }
        private void machine_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            jsonData = File.ReadAllText(Properties.Settings.Default.jsonDir + "Machine" + machine_box.Text + ".json", Encoding.UTF8);
            evaporators = JsonConvert.DeserializeObject<List<Evaporators>>(jsonData)!;
        }
        public void GetDgSource(DataGridView dataGrid)
        {
            dataGrid.ColumnCount = 5;
            dataGrid.Columns[0].Name = "Pos";
            dataGrid.Columns[1].Name = "Matter";
            dataGrid.Columns[2].Name = "Source";
            dataGrid.Columns[3].Name = "Rate";
            dataGrid.Columns[4].Name = "Scan";
            dataGrid.Columns[0].Width = 50;
            dataGrid.Columns[3].Width = 70;
            if (sourceTable.Count > 0)
            {
                sourceTable = sourceTable.OrderBy(st => st.PosInMachine).ThenBy(st => st.ModuleName).ToList();
                dataGrid.Columns[0].Width = 90;
                int po = 0;
                string pos;
                for (int i = 1; i < 10; i++)
                {
                    List<LayerData> currentPos = sourceTable.FindAll(p => p.PosInMachine == i);
                    if (currentPos.Count > 0)
                    {
                        foreach (LayerData layer in currentPos)
                        {
                            if (layer.PosInMachine > 6)
                            {
                                pos = "boat " + (layer.PosInMachine - 5).ToString();
                            }
                            else
                            {
                                pos = "curcible " + layer.PosInMachine.ToString();
                            }

                            DataGridViewRow row = new DataGridViewRow();
                            row.ReadOnly = true;
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = pos });
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = layer.ModuleName });

                            if (layer.Src.Count == 1)
                            {
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = layer.Src[0] });
                            }
                            else if (layer.Src.Count == 0)
                            {
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = null });
                            }
                            else
                            {
                                DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
                                row.Cells[row.Cells.Count - 1].ReadOnly = false;
                                comboBoxCell.DataSource = layer.Src; // Assuming Src is a list or data source
                                row.Cells.Add(comboBoxCell);
                            }

                            row.Cells.Add(new DataGridViewTextBoxCell { Value = layer.Rate });
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = layer.Scan });

                            if (po == layer.PosInMachine)
                            {
                                row.DefaultCellStyle.BackColor = Color.LightSalmon;
                                dataGrid.Rows[dataGrid.Rows.Count - 2].DefaultCellStyle.BackColor = Color.LightSalmon;
                            }
                            dataGrid.Rows.Add(row);
                            po = layer.PosInMachine;
                        }
                    }
                    else
                    {
                        if (i > 6)
                        {
                            pos = "boat " + (i - 5).ToString();
                        }
                        else
                        {
                            pos = "curcible " + i.ToString();
                        }

                        DataGridViewRow row = new DataGridViewRow();
                        row.ReadOnly = true;
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = pos });
                        //row.Cells.Add(new DataGridViewTextBoxCell { Value = string.Empty });
                        //row.Cells.Add(new DataGridViewTextBoxCell { Value = string.Empty });
                        //row.Cells.Add(new DataGridViewTextBoxCell { Value = string.Empty });
                        //row.Cells.Add(new DataGridViewTextBoxCell { Value = string.Empty });

                        dataGrid.Rows.Add(row);
                    }

                }

            }
        }
        public void GetParameters(DataGridView param)
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
                    DataGridViewRow recRow = new DataGridViewRow();
                    DataGridViewRow paramRow = new DataGridViewRow();

                    if (dgv_source.Rows[i].Cells[2].Value != null)
                    {
                        try
                        {
                            LayerData? data = null;
                            Evaporators? ev = null;

                            data = sourceTable.Find(d => d.ModuleName == dgv_source.Rows[i].Cells[1].Value.ToString());
                            if (data != null)
                            {
                                ev = evaporators!.Find(e => data.ModuleName.ToLower().Replace(" ", "").Replace("*", ".").Contains(e.Matter!.ToLower().Replace(" ", ""))
                                && e.Pos == data.Pos && e.Src == dgv_source.Rows[i].Cells[2].Value.ToString()
                                && e.Rate == data.Rate && (data.Scan.ToLower().Replace(" ", "").Contains(e.Scan.ToLower().Replace(" ", ""))
                                || e.Scan.ToLower().Replace(" ", "").Contains(data.Scan.ToLower().Replace(" ", ""))))!;

                                if (ev == null && data.Pos != 1)
                                {
                                    ev = evaporators.Find(e => data.ModuleName.ToLower().Replace(" ", "").Replace("*", ".").Contains(e.Matter!.ToLower().Replace(" ", ""))
                                    && e.Src == dgv_source.Rows[i].Cells[2].Value.ToString() && e.Rate == data.Rate
                                    && (data.Scan.ToLower().Replace(" ", "").Contains(e.Scan.ToLower().Replace(" ", ""))
                                    || e.Scan.ToLower().Replace(" ", "").Contains(data.Scan.ToLower().Replace(" ", ""))))!;
                                    if (ev != null)
                                    {
                                        var result = MessageBox.Show("couldn't find " + data.ModuleName + "'s parameters for boat number " + data.Pos
                                            + ".\n Would you like to use the same parameters like boat number " + ev.Pos + "?",
                                            "Missing data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                        if (result == DialogResult.No)
                                        {
                                            ev = null;
                                        }
                                    }
                                }
                                if (ev != null)
                                {
                                    if (color)
                                    {
                                        color = false;
                                        recRow.DefaultCellStyle.BackColor = Color.LemonChiffon;
                                        paramRow.DefaultCellStyle.BackColor = Color.LemonChiffon;
                                    }
                                    else
                                    {
                                        color = true;
                                        recRow.DefaultCellStyle.BackColor = Color.Lavender;
                                        paramRow.DefaultCellStyle.BackColor = Color.Lavender;
                                    }

                                    recRow.Cells.Add(new DataGridViewTextBoxCell { Value = "machine " + dgv_source.Rows[i].Cells[0].Value });
                                    paramRow.Cells.Add(new DataGridViewTextBoxCell { Value = "file " + dgv_source.Rows[i].Cells[0].Value });

                                    recRow.Cells.Add(new DataGridViewTextBoxCell { Value = data.ModuleName });
                                    paramRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.Matter });

                                    recRow.Cells.Add(new DataGridViewTextBoxCell { Value = data.T1 });
                                    paramRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.T1 });
                                    if (data.T1 != ev.T1)
                                    {
                                        recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                        paramRow.Cells[paramRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    }

                                    recRow.Cells.Add(new DataGridViewTextBoxCell { Value = data.P1 });
                                    paramRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.P1 });
                                    if (data.P1 != ev.P1)
                                    {
                                        recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                        paramRow.Cells[paramRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    }

                                    recRow.Cells.Add(new DataGridViewTextBoxCell { Value = data.T2 });
                                    paramRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.T2 });
                                    if (data.T2 != ev.T2)
                                    {
                                        recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                        paramRow.Cells[paramRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    }

                                    recRow.Cells.Add(new DataGridViewTextBoxCell { Value = data.P2 });
                                    paramRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.P2 });
                                    if (data.P2 != ev.P2)
                                    {
                                        recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                        paramRow.Cells[paramRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    }

                                    recRow.Cells.Add(new DataGridViewTextBoxCell { Value = data.T3 });
                                    paramRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.T3 });
                                    if (data.T3 != ev.T3)
                                    {
                                        recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                        paramRow.Cells[paramRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    }

                                    recRow.Cells.Add(new DataGridViewTextBoxCell { Value = data.P3 });
                                    paramRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.P3 });
                                    if (data.P3 != ev.P3)
                                    {
                                        recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                        paramRow.Cells[paramRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    }

                                    recRow.Cells.Add(new DataGridViewTextBoxCell { Value = data.PL });
                                    paramRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.PL });
                                    if (data.PL != ev.PL)
                                    {
                                        recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                        paramRow.Cells[paramRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    }

                                    recRow.Cells.Add(new DataGridViewTextBoxCell { Value = data.HoldTime });
                                    paramRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.HoldTime });
                                    if (data.HoldTime != ev.HoldTime)
                                    {
                                        recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                        paramRow.Cells[paramRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    }

                                    recRow.Cells.Add(new DataGridViewTextBoxCell { Value = data.Gain });
                                    paramRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.Gain });
                                    if (data.Gain != ev.Gain)
                                    {
                                        recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                        paramRow.Cells[paramRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    }

                                    recRow.Cells.Add(new DataGridViewTextBoxCell { Value = data.Response });
                                    paramRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.RT });
                                    if (data.Response != ev.RT)
                                    {
                                        recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                        paramRow.Cells[paramRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    }

                                    recRow.Cells.Add(new DataGridViewTextBoxCell { Value = data.Derivative });
                                    paramRow.Cells.Add(new DataGridViewTextBoxCell { Value = ev.DT });
                                    if (data.Derivative != ev.DT)
                                    {
                                        recRow.Cells[recRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                        paramRow.Cells[paramRow.Cells.Count - 1].Style.BackColor = Color.Coral;
                                    }

                                    param.Rows.Add(paramRow);
                                    param.Rows.Add(recRow);
                                }
                                else
                                {
                                    recRow.Cells.Add(new DataGridViewTextBoxCell { Value = "no data " + dgv_source.Rows[i].Cells[0].Value });
                                    recRow.Cells.Add(new DataGridViewTextBoxCell { Value = dgv_source.Rows[i].Cells[1].Value });
                                    param.Rows.Add(recRow);
                                    MessageBox.Show("no data find for " + dgv_source.Rows[i].Cells[1].Value + " try changing source");
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error while creating layer grid");
                        }
                    }

                }

            }
        }

    }
}
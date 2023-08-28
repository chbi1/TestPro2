namespace TestPro2
{
    partial class GSMTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GSMTable));
            dgv_gsm = new DataGridView();
            intensityMaxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            intensityMinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            thresholdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startIntensityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            beamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Monitor = new DataGridViewTextBoxColumn();
            algDalayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            algTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stopModeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subCyclesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Wavelength = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            jsonTableBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgv_gsm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jsonTableBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgv_gsm
            // 
            dgv_gsm.AllowUserToAddRows = false;
            dgv_gsm.AllowUserToDeleteRows = false;
            dgv_gsm.AllowUserToResizeColumns = false;
            dgv_gsm.AllowUserToResizeRows = false;
            dgv_gsm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_gsm.AutoGenerateColumns = false;
            dgv_gsm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_gsm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_gsm.Columns.AddRange(new DataGridViewColumn[] { intensityMaxDataGridViewTextBoxColumn, intensityMinDataGridViewTextBoxColumn, thresholdDataGridViewTextBoxColumn, startIntensityDataGridViewTextBoxColumn, beamDataGridViewTextBoxColumn, Monitor, algDalayDataGridViewTextBoxColumn, algTimeDataGridViewTextBoxColumn, stopModeDataGridViewTextBoxColumn, subCyclesDataGridViewTextBoxColumn, Wavelength, nameDataGridViewTextBoxColumn });
            dgv_gsm.DataSource = jsonTableBindingSource;
            dgv_gsm.Location = new Point(12, 12);
            dgv_gsm.Name = "dgv_gsm";
            dgv_gsm.ReadOnly = true;
            dgv_gsm.RowHeadersVisible = false;
            dgv_gsm.RowHeadersWidth = 62;
            dgv_gsm.RowTemplate.Height = 33;
            dgv_gsm.Size = new Size(1400, 151);
            dgv_gsm.TabIndex = 0;
            // 
            // intensityMaxDataGridViewTextBoxColumn
            // 
            intensityMaxDataGridViewTextBoxColumn.DataPropertyName = "IntensityMax";
            intensityMaxDataGridViewTextBoxColumn.FillWeight = 104.364326F;
            intensityMaxDataGridViewTextBoxColumn.HeaderText = "Intensity Max";
            intensityMaxDataGridViewTextBoxColumn.MinimumWidth = 8;
            intensityMaxDataGridViewTextBoxColumn.Name = "intensityMaxDataGridViewTextBoxColumn";
            intensityMaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // intensityMinDataGridViewTextBoxColumn
            // 
            intensityMinDataGridViewTextBoxColumn.DataPropertyName = "IntensityMin";
            intensityMinDataGridViewTextBoxColumn.FillWeight = 103.220108F;
            intensityMinDataGridViewTextBoxColumn.HeaderText = "Intensity Min";
            intensityMinDataGridViewTextBoxColumn.MinimumWidth = 8;
            intensityMinDataGridViewTextBoxColumn.Name = "intensityMinDataGridViewTextBoxColumn";
            intensityMinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thresholdDataGridViewTextBoxColumn
            // 
            thresholdDataGridViewTextBoxColumn.DataPropertyName = "Threshold";
            thresholdDataGridViewTextBoxColumn.FillWeight = 102.184441F;
            thresholdDataGridViewTextBoxColumn.HeaderText = "Threshold";
            thresholdDataGridViewTextBoxColumn.MinimumWidth = 8;
            thresholdDataGridViewTextBoxColumn.Name = "thresholdDataGridViewTextBoxColumn";
            thresholdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startIntensityDataGridViewTextBoxColumn
            // 
            startIntensityDataGridViewTextBoxColumn.DataPropertyName = "StartIntensity";
            startIntensityDataGridViewTextBoxColumn.FillWeight = 101.247025F;
            startIntensityDataGridViewTextBoxColumn.HeaderText = "Start Intensity";
            startIntensityDataGridViewTextBoxColumn.MinimumWidth = 8;
            startIntensityDataGridViewTextBoxColumn.Name = "startIntensityDataGridViewTextBoxColumn";
            startIntensityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // beamDataGridViewTextBoxColumn
            // 
            beamDataGridViewTextBoxColumn.DataPropertyName = "Beam";
            beamDataGridViewTextBoxColumn.FillWeight = 100.398567F;
            beamDataGridViewTextBoxColumn.HeaderText = "Beam";
            beamDataGridViewTextBoxColumn.MinimumWidth = 8;
            beamDataGridViewTextBoxColumn.Name = "beamDataGridViewTextBoxColumn";
            beamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Monitor
            // 
            Monitor.DataPropertyName = "Monitor";
            Monitor.HeaderText = "Glass";
            Monitor.MinimumWidth = 8;
            Monitor.Name = "Monitor";
            Monitor.ReadOnly = true;
            // 
            // algDalayDataGridViewTextBoxColumn
            // 
            algDalayDataGridViewTextBoxColumn.DataPropertyName = "AlgDalay";
            algDalayDataGridViewTextBoxColumn.FillWeight = 99.63059F;
            algDalayDataGridViewTextBoxColumn.HeaderText = "Alg Dalay";
            algDalayDataGridViewTextBoxColumn.MinimumWidth = 8;
            algDalayDataGridViewTextBoxColumn.Name = "algDalayDataGridViewTextBoxColumn";
            algDalayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // algTimeDataGridViewTextBoxColumn
            // 
            algTimeDataGridViewTextBoxColumn.DataPropertyName = "AlgTime";
            algTimeDataGridViewTextBoxColumn.FillWeight = 98.9354858F;
            algTimeDataGridViewTextBoxColumn.HeaderText = "Alg Time";
            algTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            algTimeDataGridViewTextBoxColumn.Name = "algTimeDataGridViewTextBoxColumn";
            algTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stopModeDataGridViewTextBoxColumn
            // 
            stopModeDataGridViewTextBoxColumn.DataPropertyName = "StopMode";
            stopModeDataGridViewTextBoxColumn.FillWeight = 97.7368851F;
            stopModeDataGridViewTextBoxColumn.HeaderText = "Stop Mode";
            stopModeDataGridViewTextBoxColumn.MinimumWidth = 8;
            stopModeDataGridViewTextBoxColumn.Name = "stopModeDataGridViewTextBoxColumn";
            stopModeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subCyclesDataGridViewTextBoxColumn
            // 
            subCyclesDataGridViewTextBoxColumn.DataPropertyName = "SubCycles";
            subCyclesDataGridViewTextBoxColumn.FillWeight = 96.75489F;
            subCyclesDataGridViewTextBoxColumn.HeaderText = "Cycles";
            subCyclesDataGridViewTextBoxColumn.MinimumWidth = 8;
            subCyclesDataGridViewTextBoxColumn.Name = "subCyclesDataGridViewTextBoxColumn";
            subCyclesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Wavelength
            // 
            Wavelength.DataPropertyName = "Wavelength";
            Wavelength.HeaderText = "Wavelength";
            Wavelength.MinimumWidth = 8;
            Wavelength.Name = "Wavelength";
            Wavelength.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.FillWeight = 97.22145F;
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jsonTableBindingSource
            // 
            jsonTableBindingSource.DataSource = typeof(JsonTable);
            // 
            // GSMTable
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1424, 175);
            Controls.Add(dgv_gsm);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GSMTable";
            Text = "GSM Data";
            ((System.ComponentModel.ISupportInitialize)dgv_gsm).EndInit();
            ((System.ComponentModel.ISupportInitialize)jsonTableBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_gsm;
        private BindingSource jsonTableBindingSource;
        private DataGridViewTextBoxColumn intensityMaxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn intensityMinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thresholdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startIntensityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Monitor;
        private DataGridViewTextBoxColumn algDalayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn algTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stopModeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subCyclesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Wavelength;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPro2
{
    public partial class DataForLayer : Form
    {
        public DataForLayer(JsonTable jt)
        {
            InitializeComponent();
            
            List<JsonTable> list = new List<JsonTable>();
            list.Add(jt);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private DataGridView dataGridView1;
        private BindingSource jsonTableBindingSource;
        private IContainer components;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jsonTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sequenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moduleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rotationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thicknessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cyclesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wavelengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startIntensityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intensityMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intensityMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thresholdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.algDalayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.algTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCyclesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.derivativeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.derivative2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holdTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jsonTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sequenceDataGridViewTextBoxColumn,
            this.moduleNameDataGridViewTextBoxColumn,
            this.tSourceDataGridViewTextBoxColumn,
            this.rotationDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.thicknessDataGridViewTextBoxColumn,
            this.cyclesDataGridViewTextBoxColumn,
            this.wavelengthDataGridViewTextBoxColumn,
            this.monitorDataGridViewTextBoxColumn,
            this.startIntensityDataGridViewTextBoxColumn,
            this.intensityMaxDataGridViewTextBoxColumn,
            this.intensityMinDataGridViewTextBoxColumn,
            this.thresholdDataGridViewTextBoxColumn,
            this.beamDataGridViewTextBoxColumn,
            this.algDalayDataGridViewTextBoxColumn,
            this.algTimeDataGridViewTextBoxColumn,
            this.stopModeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.subCyclesDataGridViewTextBoxColumn,
            this.derivativeDataGridViewTextBoxColumn,
            this.derivative2DataGridViewTextBoxColumn,
            this.responseDataGridViewTextBoxColumn,
            this.gainDataGridViewTextBoxColumn,
            this.holdTimeDataGridViewTextBoxColumn,
            this.pLDataGridViewTextBoxColumn,
            this.p3DataGridViewTextBoxColumn,
            this.t3DataGridViewTextBoxColumn,
            this.p2DataGridViewTextBoxColumn,
            this.t2DataGridViewTextBoxColumn,
            this.p1DataGridViewTextBoxColumn,
            this.t1DataGridViewTextBoxColumn,
            this.delayDataGridViewTextBoxColumn,
            this.sourceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jsonTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1506, 113);
            this.dataGridView1.TabIndex = 0;
            // 
            // jsonTableBindingSource
            // 
            this.jsonTableBindingSource.DataSource = typeof(TestPro2.JsonTable);
            // 
            // sequenceDataGridViewTextBoxColumn
            // 
            this.sequenceDataGridViewTextBoxColumn.DataPropertyName = "Sequence";
            this.sequenceDataGridViewTextBoxColumn.HeaderText = "Sequence";
            this.sequenceDataGridViewTextBoxColumn.MinimumWidth = 4;
            this.sequenceDataGridViewTextBoxColumn.Name = "sequenceDataGridViewTextBoxColumn";
            this.sequenceDataGridViewTextBoxColumn.Visible = false;
            this.sequenceDataGridViewTextBoxColumn.Width = 50;
            // 
            // moduleNameDataGridViewTextBoxColumn
            // 
            this.moduleNameDataGridViewTextBoxColumn.DataPropertyName = "ModuleName";
            this.moduleNameDataGridViewTextBoxColumn.HeaderText = "ModuleName";
            this.moduleNameDataGridViewTextBoxColumn.MinimumWidth = 4;
            this.moduleNameDataGridViewTextBoxColumn.Name = "moduleNameDataGridViewTextBoxColumn";
            this.moduleNameDataGridViewTextBoxColumn.Visible = false;
            this.moduleNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // tSourceDataGridViewTextBoxColumn
            // 
            this.tSourceDataGridViewTextBoxColumn.DataPropertyName = "TSource";
            this.tSourceDataGridViewTextBoxColumn.HeaderText = "TSource";
            this.tSourceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tSourceDataGridViewTextBoxColumn.Name = "tSourceDataGridViewTextBoxColumn";
            this.tSourceDataGridViewTextBoxColumn.Visible = false;
            this.tSourceDataGridViewTextBoxColumn.Width = 125;
            // 
            // rotationDataGridViewTextBoxColumn
            // 
            this.rotationDataGridViewTextBoxColumn.DataPropertyName = "Rotation";
            this.rotationDataGridViewTextBoxColumn.HeaderText = "Rotation";
            this.rotationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rotationDataGridViewTextBoxColumn.Name = "rotationDataGridViewTextBoxColumn";
            this.rotationDataGridViewTextBoxColumn.Visible = false;
            this.rotationDataGridViewTextBoxColumn.Width = 125;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.Visible = false;
            this.rateDataGridViewTextBoxColumn.Width = 125;
            // 
            // thicknessDataGridViewTextBoxColumn
            // 
            this.thicknessDataGridViewTextBoxColumn.DataPropertyName = "Thickness";
            this.thicknessDataGridViewTextBoxColumn.HeaderText = "Thickness";
            this.thicknessDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thicknessDataGridViewTextBoxColumn.Name = "thicknessDataGridViewTextBoxColumn";
            this.thicknessDataGridViewTextBoxColumn.Visible = false;
            this.thicknessDataGridViewTextBoxColumn.Width = 125;
            // 
            // cyclesDataGridViewTextBoxColumn
            // 
            this.cyclesDataGridViewTextBoxColumn.DataPropertyName = "Cycles";
            this.cyclesDataGridViewTextBoxColumn.HeaderText = "Cycles";
            this.cyclesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cyclesDataGridViewTextBoxColumn.Name = "cyclesDataGridViewTextBoxColumn";
            this.cyclesDataGridViewTextBoxColumn.Visible = false;
            this.cyclesDataGridViewTextBoxColumn.Width = 125;
            // 
            // wavelengthDataGridViewTextBoxColumn
            // 
            this.wavelengthDataGridViewTextBoxColumn.DataPropertyName = "Wavelength";
            this.wavelengthDataGridViewTextBoxColumn.HeaderText = "Wavelength";
            this.wavelengthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wavelengthDataGridViewTextBoxColumn.Name = "wavelengthDataGridViewTextBoxColumn";
            this.wavelengthDataGridViewTextBoxColumn.Visible = false;
            this.wavelengthDataGridViewTextBoxColumn.Width = 125;
            // 
            // monitorDataGridViewTextBoxColumn
            // 
            this.monitorDataGridViewTextBoxColumn.DataPropertyName = "Monitor";
            this.monitorDataGridViewTextBoxColumn.HeaderText = "Monitor";
            this.monitorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monitorDataGridViewTextBoxColumn.Name = "monitorDataGridViewTextBoxColumn";
            this.monitorDataGridViewTextBoxColumn.Visible = false;
            this.monitorDataGridViewTextBoxColumn.Width = 125;
            // 
            // startIntensityDataGridViewTextBoxColumn
            // 
            this.startIntensityDataGridViewTextBoxColumn.DataPropertyName = "StartIntensity";
            this.startIntensityDataGridViewTextBoxColumn.HeaderText = "StartIntensity";
            this.startIntensityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startIntensityDataGridViewTextBoxColumn.Name = "startIntensityDataGridViewTextBoxColumn";
            this.startIntensityDataGridViewTextBoxColumn.Visible = false;
            this.startIntensityDataGridViewTextBoxColumn.Width = 125;
            // 
            // intensityMaxDataGridViewTextBoxColumn
            // 
            this.intensityMaxDataGridViewTextBoxColumn.DataPropertyName = "IntensityMax";
            this.intensityMaxDataGridViewTextBoxColumn.HeaderText = "IntensityMax";
            this.intensityMaxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.intensityMaxDataGridViewTextBoxColumn.Name = "intensityMaxDataGridViewTextBoxColumn";
            this.intensityMaxDataGridViewTextBoxColumn.Visible = false;
            this.intensityMaxDataGridViewTextBoxColumn.Width = 125;
            // 
            // intensityMinDataGridViewTextBoxColumn
            // 
            this.intensityMinDataGridViewTextBoxColumn.DataPropertyName = "IntensityMin";
            this.intensityMinDataGridViewTextBoxColumn.HeaderText = "IntensityMin";
            this.intensityMinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.intensityMinDataGridViewTextBoxColumn.Name = "intensityMinDataGridViewTextBoxColumn";
            this.intensityMinDataGridViewTextBoxColumn.Visible = false;
            this.intensityMinDataGridViewTextBoxColumn.Width = 125;
            // 
            // thresholdDataGridViewTextBoxColumn
            // 
            this.thresholdDataGridViewTextBoxColumn.DataPropertyName = "Threshold";
            this.thresholdDataGridViewTextBoxColumn.HeaderText = "Threshold";
            this.thresholdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thresholdDataGridViewTextBoxColumn.Name = "thresholdDataGridViewTextBoxColumn";
            this.thresholdDataGridViewTextBoxColumn.Visible = false;
            this.thresholdDataGridViewTextBoxColumn.Width = 125;
            // 
            // beamDataGridViewTextBoxColumn
            // 
            this.beamDataGridViewTextBoxColumn.DataPropertyName = "Beam";
            this.beamDataGridViewTextBoxColumn.HeaderText = "Beam";
            this.beamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.beamDataGridViewTextBoxColumn.Name = "beamDataGridViewTextBoxColumn";
            this.beamDataGridViewTextBoxColumn.Visible = false;
            this.beamDataGridViewTextBoxColumn.Width = 125;
            // 
            // algDalayDataGridViewTextBoxColumn
            // 
            this.algDalayDataGridViewTextBoxColumn.DataPropertyName = "AlgDalay";
            this.algDalayDataGridViewTextBoxColumn.HeaderText = "AlgDalay";
            this.algDalayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.algDalayDataGridViewTextBoxColumn.Name = "algDalayDataGridViewTextBoxColumn";
            this.algDalayDataGridViewTextBoxColumn.Visible = false;
            this.algDalayDataGridViewTextBoxColumn.Width = 125;
            // 
            // algTimeDataGridViewTextBoxColumn
            // 
            this.algTimeDataGridViewTextBoxColumn.DataPropertyName = "AlgTime";
            this.algTimeDataGridViewTextBoxColumn.HeaderText = "AlgTime";
            this.algTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.algTimeDataGridViewTextBoxColumn.Name = "algTimeDataGridViewTextBoxColumn";
            this.algTimeDataGridViewTextBoxColumn.Visible = false;
            this.algTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // stopModeDataGridViewTextBoxColumn
            // 
            this.stopModeDataGridViewTextBoxColumn.DataPropertyName = "StopMode";
            this.stopModeDataGridViewTextBoxColumn.HeaderText = "StopMode";
            this.stopModeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stopModeDataGridViewTextBoxColumn.Name = "stopModeDataGridViewTextBoxColumn";
            this.stopModeDataGridViewTextBoxColumn.Visible = false;
            this.stopModeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // subCyclesDataGridViewTextBoxColumn
            // 
            this.subCyclesDataGridViewTextBoxColumn.DataPropertyName = "SubCycles";
            this.subCyclesDataGridViewTextBoxColumn.HeaderText = "SubCycles";
            this.subCyclesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subCyclesDataGridViewTextBoxColumn.Name = "subCyclesDataGridViewTextBoxColumn";
            this.subCyclesDataGridViewTextBoxColumn.Visible = false;
            this.subCyclesDataGridViewTextBoxColumn.Width = 125;
            // 
            // derivativeDataGridViewTextBoxColumn
            // 
            this.derivativeDataGridViewTextBoxColumn.DataPropertyName = "Derivative";
            this.derivativeDataGridViewTextBoxColumn.HeaderText = "Derivative";
            this.derivativeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.derivativeDataGridViewTextBoxColumn.Name = "derivativeDataGridViewTextBoxColumn";
            this.derivativeDataGridViewTextBoxColumn.Width = 125;
            // 
            // derivative2DataGridViewTextBoxColumn
            // 
            this.derivative2DataGridViewTextBoxColumn.DataPropertyName = "Derivative2";
            this.derivative2DataGridViewTextBoxColumn.HeaderText = "Derivative2";
            this.derivative2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.derivative2DataGridViewTextBoxColumn.Name = "derivative2DataGridViewTextBoxColumn";
            this.derivative2DataGridViewTextBoxColumn.Width = 125;
            // 
            // responseDataGridViewTextBoxColumn
            // 
            this.responseDataGridViewTextBoxColumn.DataPropertyName = "Response";
            this.responseDataGridViewTextBoxColumn.HeaderText = "Response";
            this.responseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.responseDataGridViewTextBoxColumn.Name = "responseDataGridViewTextBoxColumn";
            this.responseDataGridViewTextBoxColumn.Width = 125;
            // 
            // gainDataGridViewTextBoxColumn
            // 
            this.gainDataGridViewTextBoxColumn.DataPropertyName = "Gain";
            this.gainDataGridViewTextBoxColumn.HeaderText = "Gain";
            this.gainDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gainDataGridViewTextBoxColumn.Name = "gainDataGridViewTextBoxColumn";
            this.gainDataGridViewTextBoxColumn.Width = 125;
            // 
            // holdTimeDataGridViewTextBoxColumn
            // 
            this.holdTimeDataGridViewTextBoxColumn.DataPropertyName = "HoldTime";
            this.holdTimeDataGridViewTextBoxColumn.HeaderText = "HoldTime";
            this.holdTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.holdTimeDataGridViewTextBoxColumn.Name = "holdTimeDataGridViewTextBoxColumn";
            this.holdTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // pLDataGridViewTextBoxColumn
            // 
            this.pLDataGridViewTextBoxColumn.DataPropertyName = "PL";
            this.pLDataGridViewTextBoxColumn.HeaderText = "PL";
            this.pLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pLDataGridViewTextBoxColumn.Name = "pLDataGridViewTextBoxColumn";
            this.pLDataGridViewTextBoxColumn.Width = 125;
            // 
            // p3DataGridViewTextBoxColumn
            // 
            this.p3DataGridViewTextBoxColumn.DataPropertyName = "P3";
            this.p3DataGridViewTextBoxColumn.HeaderText = "P3";
            this.p3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.p3DataGridViewTextBoxColumn.Name = "p3DataGridViewTextBoxColumn";
            this.p3DataGridViewTextBoxColumn.Width = 80;
            // 
            // t3DataGridViewTextBoxColumn
            // 
            this.t3DataGridViewTextBoxColumn.DataPropertyName = "T3";
            this.t3DataGridViewTextBoxColumn.HeaderText = "T3";
            this.t3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.t3DataGridViewTextBoxColumn.Name = "t3DataGridViewTextBoxColumn";
            this.t3DataGridViewTextBoxColumn.Width = 80;
            // 
            // p2DataGridViewTextBoxColumn
            // 
            this.p2DataGridViewTextBoxColumn.DataPropertyName = "P2";
            this.p2DataGridViewTextBoxColumn.HeaderText = "P2";
            this.p2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.p2DataGridViewTextBoxColumn.Name = "p2DataGridViewTextBoxColumn";
            this.p2DataGridViewTextBoxColumn.Width = 80;
            // 
            // t2DataGridViewTextBoxColumn
            // 
            this.t2DataGridViewTextBoxColumn.DataPropertyName = "T2";
            this.t2DataGridViewTextBoxColumn.HeaderText = "T2";
            this.t2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.t2DataGridViewTextBoxColumn.Name = "t2DataGridViewTextBoxColumn";
            this.t2DataGridViewTextBoxColumn.Width = 80;
            // 
            // p1DataGridViewTextBoxColumn
            // 
            this.p1DataGridViewTextBoxColumn.DataPropertyName = "P1";
            this.p1DataGridViewTextBoxColumn.HeaderText = "P1";
            this.p1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.p1DataGridViewTextBoxColumn.Name = "p1DataGridViewTextBoxColumn";
            this.p1DataGridViewTextBoxColumn.Width = 80;
            // 
            // t1DataGridViewTextBoxColumn
            // 
            this.t1DataGridViewTextBoxColumn.DataPropertyName = "T1";
            this.t1DataGridViewTextBoxColumn.HeaderText = "T1";
            this.t1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.t1DataGridViewTextBoxColumn.Name = "t1DataGridViewTextBoxColumn";
            this.t1DataGridViewTextBoxColumn.Width = 80;
            // 
            // delayDataGridViewTextBoxColumn
            // 
            this.delayDataGridViewTextBoxColumn.DataPropertyName = "Delay";
            this.delayDataGridViewTextBoxColumn.HeaderText = "Delay";
            this.delayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.delayDataGridViewTextBoxColumn.Name = "delayDataGridViewTextBoxColumn";
            this.delayDataGridViewTextBoxColumn.Width = 80;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            this.sourceDataGridViewTextBoxColumn.Width = 125;
            // 
            // DataForLayer
            // 
            this.ClientSize = new System.Drawing.Size(1529, 137);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataForLayer";
            this.Text = "Data For Layer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jsonTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private DataGridViewTextBoxColumn sequenceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moduleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tSourceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rotationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thicknessDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cyclesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wavelengthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn monitorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startIntensityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn intensityMaxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn intensityMinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thresholdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn algDalayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn algTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stopModeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subCyclesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn derivativeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn derivative2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn responseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gainDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn holdTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pLDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn p3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn t3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn p2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn t2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn p1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn t1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn delayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
    }
}

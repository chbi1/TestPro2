namespace TestPro2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            open_btn = new Button();
            rtb = new RichTextBox();
            dgv = new DataGridView();
            sequenceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            moduleNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            rotationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            thicknessDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cyclesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wavelengthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            monitorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startIntensityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            jsonTableBindingSource = new BindingSource(components);
            process_btn = new Button();
            show_file_name = new TextBox();
            label1 = new Label();
            dgv_gsm = new DataGridView();
            intensityMaxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            intensityMinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            thresholdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startIntensityDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            beamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            monitorDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            algDalayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            algTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stopModeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subCyclesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wavelengthDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            jsonTableBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jsonTableBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_gsm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jsonTableBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // open_btn
            // 
            open_btn.Location = new Point(12, 12);
            open_btn.Name = "open_btn";
            open_btn.Size = new Size(112, 34);
            open_btn.TabIndex = 0;
            open_btn.Text = "&Open";
            open_btn.UseVisualStyleBackColor = true;
            open_btn.Click += open_btn_Click;
            // 
            // rtb
            // 
            rtb.Location = new Point(12, 753);
            rtb.Name = "rtb";
            rtb.Size = new Size(1693, 139);
            rtb.TabIndex = 1;
            rtb.Text = "";
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AutoGenerateColumns = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { sequenceDataGridViewTextBoxColumn, moduleNameDataGridViewTextBoxColumn, dataGridViewTextBoxColumn2, rotationDataGridViewTextBoxColumn, rateDataGridViewTextBoxColumn, thicknessDataGridViewTextBoxColumn, cyclesDataGridViewTextBoxColumn, wavelengthDataGridViewTextBoxColumn, monitorDataGridViewTextBoxColumn, startIntensityDataGridViewTextBoxColumn });
            dgv.DataSource = jsonTableBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle2;
            dgv.Location = new Point(12, 62);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RightToLeft = RightToLeft.Yes;
            dgv.RowHeadersWidth = 62;
            dgv.RowTemplate.Height = 33;
            dgv.Size = new Size(1693, 493);
            dgv.TabIndex = 2;
            // 
            // sequenceDataGridViewTextBoxColumn
            // 
            sequenceDataGridViewTextBoxColumn.DataPropertyName = "Sequence";
            sequenceDataGridViewTextBoxColumn.HeaderText = "Sequence";
            sequenceDataGridViewTextBoxColumn.MinimumWidth = 8;
            sequenceDataGridViewTextBoxColumn.Name = "sequenceDataGridViewTextBoxColumn";
            sequenceDataGridViewTextBoxColumn.ReadOnly = true;
            sequenceDataGridViewTextBoxColumn.Width = 150;
            // 
            // moduleNameDataGridViewTextBoxColumn
            // 
            moduleNameDataGridViewTextBoxColumn.DataPropertyName = "ModuleName";
            moduleNameDataGridViewTextBoxColumn.HeaderText = "ModuleName";
            moduleNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            moduleNameDataGridViewTextBoxColumn.Name = "moduleNameDataGridViewTextBoxColumn";
            moduleNameDataGridViewTextBoxColumn.ReadOnly = true;
            moduleNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "TSource";
            dataGridViewTextBoxColumn2.HeaderText = "TSource";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // rotationDataGridViewTextBoxColumn
            // 
            rotationDataGridViewTextBoxColumn.DataPropertyName = "Rotation";
            rotationDataGridViewTextBoxColumn.HeaderText = "Rotation";
            rotationDataGridViewTextBoxColumn.MinimumWidth = 8;
            rotationDataGridViewTextBoxColumn.Name = "rotationDataGridViewTextBoxColumn";
            rotationDataGridViewTextBoxColumn.ReadOnly = true;
            rotationDataGridViewTextBoxColumn.Width = 150;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            rateDataGridViewTextBoxColumn.MinimumWidth = 8;
            rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            rateDataGridViewTextBoxColumn.ReadOnly = true;
            rateDataGridViewTextBoxColumn.Width = 150;
            // 
            // thicknessDataGridViewTextBoxColumn
            // 
            thicknessDataGridViewTextBoxColumn.DataPropertyName = "Thickness";
            thicknessDataGridViewTextBoxColumn.HeaderText = "Thickness";
            thicknessDataGridViewTextBoxColumn.MinimumWidth = 8;
            thicknessDataGridViewTextBoxColumn.Name = "thicknessDataGridViewTextBoxColumn";
            thicknessDataGridViewTextBoxColumn.ReadOnly = true;
            thicknessDataGridViewTextBoxColumn.Width = 150;
            // 
            // cyclesDataGridViewTextBoxColumn
            // 
            cyclesDataGridViewTextBoxColumn.DataPropertyName = "Cycles";
            cyclesDataGridViewTextBoxColumn.HeaderText = "Cycles";
            cyclesDataGridViewTextBoxColumn.MinimumWidth = 8;
            cyclesDataGridViewTextBoxColumn.Name = "cyclesDataGridViewTextBoxColumn";
            cyclesDataGridViewTextBoxColumn.ReadOnly = true;
            cyclesDataGridViewTextBoxColumn.Width = 150;
            // 
            // wavelengthDataGridViewTextBoxColumn
            // 
            wavelengthDataGridViewTextBoxColumn.DataPropertyName = "Wavelength";
            wavelengthDataGridViewTextBoxColumn.HeaderText = "Wavelength";
            wavelengthDataGridViewTextBoxColumn.MinimumWidth = 8;
            wavelengthDataGridViewTextBoxColumn.Name = "wavelengthDataGridViewTextBoxColumn";
            wavelengthDataGridViewTextBoxColumn.ReadOnly = true;
            wavelengthDataGridViewTextBoxColumn.Width = 150;
            // 
            // monitorDataGridViewTextBoxColumn
            // 
            monitorDataGridViewTextBoxColumn.DataPropertyName = "Monitor";
            monitorDataGridViewTextBoxColumn.HeaderText = "Monitor";
            monitorDataGridViewTextBoxColumn.MinimumWidth = 8;
            monitorDataGridViewTextBoxColumn.Name = "monitorDataGridViewTextBoxColumn";
            monitorDataGridViewTextBoxColumn.ReadOnly = true;
            monitorDataGridViewTextBoxColumn.Width = 150;
            // 
            // startIntensityDataGridViewTextBoxColumn
            // 
            startIntensityDataGridViewTextBoxColumn.DataPropertyName = "StartIntensity";
            startIntensityDataGridViewTextBoxColumn.HeaderText = "StartIntensity";
            startIntensityDataGridViewTextBoxColumn.MinimumWidth = 8;
            startIntensityDataGridViewTextBoxColumn.Name = "startIntensityDataGridViewTextBoxColumn";
            startIntensityDataGridViewTextBoxColumn.ReadOnly = true;
            startIntensityDataGridViewTextBoxColumn.Width = 150;
            // 
            // jsonTableBindingSource
            // 
            jsonTableBindingSource.DataSource = typeof(JsonTable);
            // 
            // process_btn
            // 
            process_btn.Location = new Point(153, 12);
            process_btn.Name = "process_btn";
            process_btn.Size = new Size(112, 34);
            process_btn.TabIndex = 3;
            process_btn.Text = "&Process";
            process_btn.UseVisualStyleBackColor = true;
            process_btn.Click += process_btn_Click;
            // 
            // show_file_name
            // 
            show_file_name.Location = new Point(1524, 17);
            show_file_name.Name = "show_file_name";
            show_file_name.ReadOnly = true;
            show_file_name.Size = new Size(181, 31);
            show_file_name.TabIndex = 4;
            show_file_name.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1428, 17);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 5;
            label1.Text = "File Name";
            // 
            // dgv_gsm
            // 
            dgv_gsm.AutoGenerateColumns = false;
            dgv_gsm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_gsm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_gsm.Columns.AddRange(new DataGridViewColumn[] { intensityMaxDataGridViewTextBoxColumn, intensityMinDataGridViewTextBoxColumn, thresholdDataGridViewTextBoxColumn, startIntensityDataGridViewTextBoxColumn1, beamDataGridViewTextBoxColumn, monitorDataGridViewTextBoxColumn1, algDalayDataGridViewTextBoxColumn, algTimeDataGridViewTextBoxColumn, stopModeDataGridViewTextBoxColumn, subCyclesDataGridViewTextBoxColumn, wavelengthDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn });
            dgv_gsm.DataSource = jsonTableBindingSource1;
            dgv_gsm.Location = new Point(12, 561);
            dgv_gsm.Name = "dgv_gsm";
            dgv_gsm.RowHeadersWidth = 62;
            dgv_gsm.RowTemplate.Height = 33;
            dgv_gsm.Size = new Size(1693, 186);
            dgv_gsm.TabIndex = 6;
            // 
            // intensityMaxDataGridViewTextBoxColumn
            // 
            intensityMaxDataGridViewTextBoxColumn.DataPropertyName = "IntensityMax";
            intensityMaxDataGridViewTextBoxColumn.HeaderText = "IntensityMax";
            intensityMaxDataGridViewTextBoxColumn.MinimumWidth = 8;
            intensityMaxDataGridViewTextBoxColumn.Name = "intensityMaxDataGridViewTextBoxColumn";
            // 
            // intensityMinDataGridViewTextBoxColumn
            // 
            intensityMinDataGridViewTextBoxColumn.DataPropertyName = "IntensityMin";
            intensityMinDataGridViewTextBoxColumn.HeaderText = "IntensityMin";
            intensityMinDataGridViewTextBoxColumn.MinimumWidth = 8;
            intensityMinDataGridViewTextBoxColumn.Name = "intensityMinDataGridViewTextBoxColumn";
            // 
            // thresholdDataGridViewTextBoxColumn
            // 
            thresholdDataGridViewTextBoxColumn.DataPropertyName = "Threshold";
            thresholdDataGridViewTextBoxColumn.HeaderText = "Threshold";
            thresholdDataGridViewTextBoxColumn.MinimumWidth = 8;
            thresholdDataGridViewTextBoxColumn.Name = "thresholdDataGridViewTextBoxColumn";
            // 
            // startIntensityDataGridViewTextBoxColumn1
            // 
            startIntensityDataGridViewTextBoxColumn1.DataPropertyName = "StartIntensity";
            startIntensityDataGridViewTextBoxColumn1.HeaderText = "StartIntensity";
            startIntensityDataGridViewTextBoxColumn1.MinimumWidth = 8;
            startIntensityDataGridViewTextBoxColumn1.Name = "startIntensityDataGridViewTextBoxColumn1";
            // 
            // beamDataGridViewTextBoxColumn
            // 
            beamDataGridViewTextBoxColumn.DataPropertyName = "Beam";
            beamDataGridViewTextBoxColumn.HeaderText = "Beam";
            beamDataGridViewTextBoxColumn.MinimumWidth = 8;
            beamDataGridViewTextBoxColumn.Name = "beamDataGridViewTextBoxColumn";
            // 
            // monitorDataGridViewTextBoxColumn1
            // 
            monitorDataGridViewTextBoxColumn1.DataPropertyName = "Monitor";
            monitorDataGridViewTextBoxColumn1.HeaderText = "Monitor";
            monitorDataGridViewTextBoxColumn1.MinimumWidth = 8;
            monitorDataGridViewTextBoxColumn1.Name = "monitorDataGridViewTextBoxColumn1";
            // 
            // algDalayDataGridViewTextBoxColumn
            // 
            algDalayDataGridViewTextBoxColumn.DataPropertyName = "AlgDalay";
            algDalayDataGridViewTextBoxColumn.HeaderText = "AlgDalay";
            algDalayDataGridViewTextBoxColumn.MinimumWidth = 8;
            algDalayDataGridViewTextBoxColumn.Name = "algDalayDataGridViewTextBoxColumn";
            // 
            // algTimeDataGridViewTextBoxColumn
            // 
            algTimeDataGridViewTextBoxColumn.DataPropertyName = "AlgTime";
            algTimeDataGridViewTextBoxColumn.HeaderText = "AlgTime";
            algTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            algTimeDataGridViewTextBoxColumn.Name = "algTimeDataGridViewTextBoxColumn";
            // 
            // stopModeDataGridViewTextBoxColumn
            // 
            stopModeDataGridViewTextBoxColumn.DataPropertyName = "StopMode";
            stopModeDataGridViewTextBoxColumn.HeaderText = "StopMode";
            stopModeDataGridViewTextBoxColumn.MinimumWidth = 8;
            stopModeDataGridViewTextBoxColumn.Name = "stopModeDataGridViewTextBoxColumn";
            // 
            // subCyclesDataGridViewTextBoxColumn
            // 
            subCyclesDataGridViewTextBoxColumn.DataPropertyName = "SubCycles";
            subCyclesDataGridViewTextBoxColumn.HeaderText = "SubCycles";
            subCyclesDataGridViewTextBoxColumn.MinimumWidth = 8;
            subCyclesDataGridViewTextBoxColumn.Name = "subCyclesDataGridViewTextBoxColumn";
            // 
            // wavelengthDataGridViewTextBoxColumn1
            // 
            wavelengthDataGridViewTextBoxColumn1.DataPropertyName = "Wavelength";
            wavelengthDataGridViewTextBoxColumn1.HeaderText = "Wavelength";
            wavelengthDataGridViewTextBoxColumn1.MinimumWidth = 8;
            wavelengthDataGridViewTextBoxColumn1.Name = "wavelengthDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // jsonTableBindingSource1
            // 
            jsonTableBindingSource1.DataSource = typeof(JsonTable);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1717, 904);
            Controls.Add(dgv_gsm);
            Controls.Add(label1);
            Controls.Add(show_file_name);
            Controls.Add(process_btn);
            Controls.Add(dgv);
            Controls.Add(rtb);
            Controls.Add(open_btn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)jsonTableBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_gsm).EndInit();
            ((System.ComponentModel.ISupportInitialize)jsonTableBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button open_btn;
        private DataGridViewTextBoxColumn sequenceNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moduleTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moduleNumberDataGridViewTextBoxColumn;
        private RichTextBox rtb;
        private DataGridView dgv;
        private Button process_btn;
        private DataGridViewTextBoxColumn tSourceDataGridViewTextBoxColumn;
        private TextBox show_file_name;
        private Label label1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn sequenceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moduleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn rotationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thicknessDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cyclesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wavelengthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn monitorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startIntensityDataGridViewTextBoxColumn;
        private BindingSource jsonTableBindingSource;
        private DataGridView dgv_gsm;
        private BindingSource jsonTableBindingSource1;
        private DataGridViewTextBoxColumn intensityMaxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn intensityMinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thresholdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startIntensityDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn beamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn monitorDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn algDalayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn algTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stopModeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subCyclesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wavelengthDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}
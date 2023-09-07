﻿namespace TestPro2
{
    partial class TestPro
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestPro));
            jsonTableBindingSource = new BindingSource(components);
            open_btn = new Button();
            rtb = new RichTextBox();
            process_btn = new Button();
            show_file_name = new TextBox();
            label1 = new Label();
            machine = new ComboBox();
            label2 = new Label();
            tabs = new TabControl();
            REC_tab = new TabPage();
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
            src_tab = new TabPage();
            sours_sip = new DataGridView();
            open_sip_btn = new Button();
            layerDataBindingSource = new BindingSource(components);
            machine_box = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)jsonTableBindingSource).BeginInit();
            tabs.SuspendLayout();
            REC_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            src_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sours_sip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layerDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // jsonTableBindingSource
            // 
            jsonTableBindingSource.DataSource = typeof(JsonTable);
            // 
            // open_btn
            // 
            open_btn.Location = new Point(367, 23);
            open_btn.Name = "open_btn";
            open_btn.Size = new Size(112, 34);
            open_btn.TabIndex = 0;
            open_btn.Text = "&Open";
            open_btn.UseVisualStyleBackColor = true;
            open_btn.Click += open_btn_Click;
            // 
            // rtb
            // 
            rtb.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rtb.Location = new Point(9, 561);
            rtb.Margin = new Padding(10, 3, 3, 3);
            rtb.Name = "rtb";
            rtb.ReadOnly = true;
            rtb.Size = new Size(1571, 194);
            rtb.TabIndex = 1;
            rtb.Text = "";
            // 
            // process_btn
            // 
            process_btn.Location = new Point(1028, 15);
            process_btn.Name = "process_btn";
            process_btn.Size = new Size(112, 34);
            process_btn.TabIndex = 3;
            process_btn.Text = "&Refresh";
            process_btn.UseVisualStyleBackColor = true;
            process_btn.Click += process_btn_Click;
            // 
            // show_file_name
            // 
            show_file_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            show_file_name.Location = new Point(1341, 20);
            show_file_name.Name = "show_file_name";
            show_file_name.ReadOnly = true;
            show_file_name.Size = new Size(181, 31);
            show_file_name.TabIndex = 4;
            show_file_name.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(1234, 23);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 5;
            label1.Text = "File Name";
            // 
            // machine
            // 
            machine.FormattingEnabled = true;
            machine.Items.AddRange(new object[] { "E", "N", "X", "P" });
            machine.Location = new Point(147, 20);
            machine.Name = "machine";
            machine.Size = new Size(66, 33);
            machine.TabIndex = 6;
            machine.SelectedIndexChanged += machine_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 23);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 7;
            label2.Text = "Select machine";
            // 
            // tabs
            // 
            tabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabs.Controls.Add(REC_tab);
            tabs.Controls.Add(src_tab);
            tabs.Location = new Point(1, 65);
            tabs.Margin = new Padding(5);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(1596, 801);
            tabs.TabIndex = 8;
            // 
            // REC_tab
            // 
            REC_tab.Controls.Add(dgv);
            REC_tab.Controls.Add(rtb);
            REC_tab.Location = new Point(4, 34);
            REC_tab.Margin = new Padding(7);
            REC_tab.Name = "REC_tab";
            REC_tab.Padding = new Padding(7);
            REC_tab.Size = new Size(1588, 763);
            REC_tab.TabIndex = 0;
            REC_tab.Text = "REC processor";
            REC_tab.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.AutoGenerateColumns = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { sequenceDataGridViewTextBoxColumn, moduleNameDataGridViewTextBoxColumn, dataGridViewTextBoxColumn2, rotationDataGridViewTextBoxColumn, rateDataGridViewTextBoxColumn, thicknessDataGridViewTextBoxColumn, cyclesDataGridViewTextBoxColumn, wavelengthDataGridViewTextBoxColumn, monitorDataGridViewTextBoxColumn, startIntensityDataGridViewTextBoxColumn });
            dgv.DataSource = jsonTableBindingSource;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle5;
            dgv.Location = new Point(8, 10);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RightToLeft = RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 62;
            dgv.RowTemplate.Height = 33;
            dgv.Size = new Size(1571, 545);
            dgv.TabIndex = 3;
            dgv.CellDoubleClick += dgv_CellClick;
            dgv.CellMouseEnter += dgv_CellMouseEnter;
            // 
            // sequenceDataGridViewTextBoxColumn
            // 
            sequenceDataGridViewTextBoxColumn.DataPropertyName = "Sequence";
            sequenceDataGridViewTextBoxColumn.HeaderText = "Sequence";
            sequenceDataGridViewTextBoxColumn.MinimumWidth = 8;
            sequenceDataGridViewTextBoxColumn.Name = "sequenceDataGridViewTextBoxColumn";
            sequenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moduleNameDataGridViewTextBoxColumn
            // 
            moduleNameDataGridViewTextBoxColumn.DataPropertyName = "ModuleName";
            moduleNameDataGridViewTextBoxColumn.HeaderText = "Module Name";
            moduleNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            moduleNameDataGridViewTextBoxColumn.Name = "moduleNameDataGridViewTextBoxColumn";
            moduleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "TSource";
            dataGridViewTextBoxColumn2.HeaderText = "Source";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // rotationDataGridViewTextBoxColumn
            // 
            rotationDataGridViewTextBoxColumn.DataPropertyName = "Rotation";
            rotationDataGridViewTextBoxColumn.HeaderText = "Rotation";
            rotationDataGridViewTextBoxColumn.MinimumWidth = 8;
            rotationDataGridViewTextBoxColumn.Name = "rotationDataGridViewTextBoxColumn";
            rotationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            rateDataGridViewTextBoxColumn.MinimumWidth = 8;
            rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            rateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thicknessDataGridViewTextBoxColumn
            // 
            thicknessDataGridViewTextBoxColumn.DataPropertyName = "Thickness";
            thicknessDataGridViewTextBoxColumn.HeaderText = "Thickness";
            thicknessDataGridViewTextBoxColumn.MinimumWidth = 8;
            thicknessDataGridViewTextBoxColumn.Name = "thicknessDataGridViewTextBoxColumn";
            thicknessDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cyclesDataGridViewTextBoxColumn
            // 
            cyclesDataGridViewTextBoxColumn.DataPropertyName = "Cycles";
            cyclesDataGridViewTextBoxColumn.HeaderText = "Cycles";
            cyclesDataGridViewTextBoxColumn.MinimumWidth = 8;
            cyclesDataGridViewTextBoxColumn.Name = "cyclesDataGridViewTextBoxColumn";
            cyclesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wavelengthDataGridViewTextBoxColumn
            // 
            wavelengthDataGridViewTextBoxColumn.DataPropertyName = "Wavelength";
            wavelengthDataGridViewTextBoxColumn.HeaderText = "Wavelength";
            wavelengthDataGridViewTextBoxColumn.MinimumWidth = 8;
            wavelengthDataGridViewTextBoxColumn.Name = "wavelengthDataGridViewTextBoxColumn";
            wavelengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monitorDataGridViewTextBoxColumn
            // 
            monitorDataGridViewTextBoxColumn.DataPropertyName = "Monitor";
            monitorDataGridViewTextBoxColumn.HeaderText = "Monitor";
            monitorDataGridViewTextBoxColumn.MinimumWidth = 8;
            monitorDataGridViewTextBoxColumn.Name = "monitorDataGridViewTextBoxColumn";
            monitorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startIntensityDataGridViewTextBoxColumn
            // 
            startIntensityDataGridViewTextBoxColumn.DataPropertyName = "StartIntensity";
            startIntensityDataGridViewTextBoxColumn.HeaderText = "Start Intensity";
            startIntensityDataGridViewTextBoxColumn.MinimumWidth = 8;
            startIntensityDataGridViewTextBoxColumn.Name = "startIntensityDataGridViewTextBoxColumn";
            startIntensityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // src_tab
            // 
            src_tab.Controls.Add(sours_sip);
            src_tab.Controls.Add(open_sip_btn);
            src_tab.Location = new Point(4, 34);
            src_tab.Name = "src_tab";
            src_tab.Padding = new Padding(3);
            src_tab.Size = new Size(1588, 763);
            src_tab.TabIndex = 1;
            src_tab.Text = "Source processor";
            src_tab.UseVisualStyleBackColor = true;
            // 
            // sours_sip
            // 
            sours_sip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sours_sip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sours_sip.Location = new Point(420, 6);
            sours_sip.Name = "sours_sip";
            sours_sip.RowHeadersWidth = 62;
            sours_sip.RowTemplate.Height = 33;
            sours_sip.Size = new Size(1162, 350);
            sours_sip.TabIndex = 9;
            // 
            // open_sip_btn
            // 
            open_sip_btn.Location = new Point(55, 54);
            open_sip_btn.Name = "open_sip_btn";
            open_sip_btn.Size = new Size(112, 34);
            open_sip_btn.TabIndex = 0;
            open_sip_btn.Text = "&Open";
            open_sip_btn.UseVisualStyleBackColor = true;
            open_sip_btn.Click += open_sip_btn_Click;
            // 
            // layerDataBindingSource
            // 
            layerDataBindingSource.DataSource = typeof(LayerData);
            // 
            // machine_box
            // 
            machine_box.FormattingEnabled = true;
            machine_box.Items.AddRange(new object[] { "E", "N", "X", "P" });
            machine_box.Location = new Point(506, 22);
            machine_box.Name = "machine_box";
            machine_box.Size = new Size(94, 33);
            machine_box.TabIndex = 1;
            machine_box.SelectedIndexChanged += machine_box_SelectedIndexChanged;
            // 
            // TestPro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 867);
            Controls.Add(tabs);
            Controls.Add(show_file_name);
            Controls.Add(machine_box);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(machine);
            Controls.Add(process_btn);
            Controls.Add(open_btn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TestPro";
            Text = "Test Pro";
            ((System.ComponentModel.ISupportInitialize)jsonTableBindingSource).EndInit();
            tabs.ResumeLayout(false);
            REC_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            src_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sours_sip).EndInit();
            ((System.ComponentModel.ISupportInitialize)layerDataBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn sequenceNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moduleTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moduleNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tSourceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private BindingSource jsonTableBindingSource;
        private Button open_btn;
        private RichTextBox rtb;
        private Button process_btn;
        private TextBox show_file_name;
        private Label label1;
        private ComboBox machine;
        private Label label2;
        private TabControl tabs;
        private TabPage REC_tab;
        private DataGridView dgv;
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
        private TabPage src_tab;
        private Button open_sip_btn;
        private Label label3;
        private ComboBox machine_box;
        private DataGridView sours_sip;
        private BindingSource layerDataBindingSource;
        private DataGridViewTextBoxColumn moduleNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn posDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
    }
}
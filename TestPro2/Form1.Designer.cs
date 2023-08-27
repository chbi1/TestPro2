namespace TestPro2
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestPro));
            jsonTableBindingSource = new BindingSource(components);
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
            process_btn = new Button();
            show_file_name = new TextBox();
            label1 = new Label();
            machine = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)jsonTableBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // jsonTableBindingSource
            // 
            jsonTableBindingSource.DataSource = typeof(JsonTable);
            // 
            // open_btn
            // 
            open_btn.Location = new Point(17, 13);
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
            rtb.Location = new Point(12, 655);
            rtb.Margin = new Padding(10, 3, 3, 3);
            rtb.Name = "rtb";
            rtb.ReadOnly = true;
            rtb.Size = new Size(1483, 194);
            rtb.TabIndex = 1;
            rtb.Text = "";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 62;
            dgv.RowTemplate.Height = 33;
            dgv.Size = new Size(1483, 587);
            dgv.TabIndex = 2;
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
            // process_btn
            // 
            process_btn.Location = new Point(381, 15);
            process_btn.Name = "process_btn";
            process_btn.Size = new Size(112, 34);
            process_btn.TabIndex = 3;
            process_btn.Text = "&Process";
            process_btn.UseVisualStyleBackColor = true;
            process_btn.Click += process_btn_Click;
            // 
            // show_file_name
            // 
            show_file_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            show_file_name.Location = new Point(1314, 15);
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
            label1.Location = new Point(1218, 18);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 5;
            label1.Text = "File Name";
            // 
            // machine
            // 
            machine.FormattingEnabled = true;
            machine.Items.AddRange(new object[] { "E", "N", "X", "P", "W" });
            machine.Location = new Point(283, 15);
            machine.Name = "machine";
            machine.Size = new Size(66, 33);
            machine.TabIndex = 6;
            machine.SelectedIndexChanged += machine_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 18);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 7;
            label2.Text = "Select machine";
            // 
            // TestPro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1507, 858);
            Controls.Add(label2);
            Controls.Add(machine);
            Controls.Add(label1);
            Controls.Add(show_file_name);
            Controls.Add(process_btn);
            Controls.Add(dgv);
            Controls.Add(rtb);
            Controls.Add(open_btn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TestPro";
            Text = "Test Pro";
            ((System.ComponentModel.ISupportInitialize)jsonTableBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
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
        private DataGridView dgv;
        private Button process_btn;
        private TextBox show_file_name;
        private Label label1;
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
        private ComboBox machine;
        private Label label2;
    }
}
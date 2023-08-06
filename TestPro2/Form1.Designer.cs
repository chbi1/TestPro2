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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            open_btn = new Button();
            rtb = new RichTextBox();
            dgv = new DataGridView();
            process_btn = new Button();
            show_file_name = new TextBox();
            label1 = new Label();
            jsonTableBindingSource = new BindingSource(components);
            sequenceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            moduleNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            thicknessDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startIntensityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jsonTableBindingSource).BeginInit();
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
            rtb.Location = new Point(12, 62);
            rtb.Name = "rtb";
            rtb.Size = new Size(598, 692);
            rtb.TabIndex = 1;
            rtb.Text = "";
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AutoGenerateColumns = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { sequenceDataGridViewTextBoxColumn, moduleNameDataGridViewTextBoxColumn, dataGridViewTextBoxColumn2, thicknessDataGridViewTextBoxColumn, rateDataGridViewTextBoxColumn, startIntensityDataGridViewTextBoxColumn });
            dgv.DataSource = jsonTableBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle1;
            dgv.Location = new Point(627, 62);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RightToLeft = RightToLeft.Yes;
            dgv.RowHeadersWidth = 62;
            dgv.RowTemplate.Height = 33;
            dgv.Size = new Size(1078, 692);
            dgv.TabIndex = 2;
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
            // jsonTableBindingSource
            // 
            jsonTableBindingSource.DataSource = typeof(JsonTable);
            // 
            // sequenceDataGridViewTextBoxColumn
            // 
            sequenceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sequenceDataGridViewTextBoxColumn.DataPropertyName = "Sequence";
            sequenceDataGridViewTextBoxColumn.HeaderText = "Sequence";
            sequenceDataGridViewTextBoxColumn.MinimumWidth = 8;
            sequenceDataGridViewTextBoxColumn.Name = "sequenceDataGridViewTextBoxColumn";
            sequenceDataGridViewTextBoxColumn.ReadOnly = true;
            sequenceDataGridViewTextBoxColumn.Width = 124;
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
            dataGridViewTextBoxColumn2.HeaderText = "Source";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
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
            // rateDataGridViewTextBoxColumn
            // 
            rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            rateDataGridViewTextBoxColumn.MinimumWidth = 8;
            rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            rateDataGridViewTextBoxColumn.ReadOnly = true;
            rateDataGridViewTextBoxColumn.Width = 150;
            // 
            // startIntensityDataGridViewTextBoxColumn
            // 
            startIntensityDataGridViewTextBoxColumn.DataPropertyName = "StartIntensity";
            startIntensityDataGridViewTextBoxColumn.HeaderText = "Start Intensity";
            startIntensityDataGridViewTextBoxColumn.MinimumWidth = 8;
            startIntensityDataGridViewTextBoxColumn.Name = "startIntensityDataGridViewTextBoxColumn";
            startIntensityDataGridViewTextBoxColumn.ReadOnly = true;
            startIntensityDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1717, 766);
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
        private BindingSource jsonTableBindingSource;
        private DataGridViewTextBoxColumn sequenceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moduleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn thicknessDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startIntensityDataGridViewTextBoxColumn;
    }
}
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
            open_btn = new Button();
            rtb = new RichTextBox();
            dgv = new DataGridView();
            process_btn = new Button();
            jsonTableBindingSource = new BindingSource(components);
            sequenceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            moduleNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            dgv.AutoGenerateColumns = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { sequenceDataGridViewTextBoxColumn, moduleNameDataGridViewTextBoxColumn });
            dgv.DataSource = jsonTableBindingSource;
            dgv.Location = new Point(627, 62);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 62;
            dgv.RowTemplate.Height = 33;
            dgv.Size = new Size(1078, 592);
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
            // jsonTableBindingSource
            // 
            jsonTableBindingSource.DataSource = typeof(JsonTable);
            // 
            // sequenceDataGridViewTextBoxColumn
            // 
            sequenceDataGridViewTextBoxColumn.DataPropertyName = "Sequence";
            sequenceDataGridViewTextBoxColumn.HeaderText = "Sequence";
            sequenceDataGridViewTextBoxColumn.MinimumWidth = 8;
            sequenceDataGridViewTextBoxColumn.Name = "sequenceDataGridViewTextBoxColumn";
            sequenceDataGridViewTextBoxColumn.Width = 150;
            // 
            // moduleNameDataGridViewTextBoxColumn
            // 
            moduleNameDataGridViewTextBoxColumn.DataPropertyName = "ModuleName";
            moduleNameDataGridViewTextBoxColumn.HeaderText = "ModuleName";
            moduleNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            moduleNameDataGridViewTextBoxColumn.Name = "moduleNameDataGridViewTextBoxColumn";
            moduleNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1717, 766);
            Controls.Add(process_btn);
            Controls.Add(dgv);
            Controls.Add(rtb);
            Controls.Add(open_btn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)jsonTableBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button open_btn;
        private DataGridViewTextBoxColumn sequenceNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moduleTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moduleNumberDataGridViewTextBoxColumn;
        private RichTextBox rtb;
        private DataGridView dgv;
        private Button process_btn;
        private DataGridViewTextBoxColumn sequenceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moduleNameDataGridViewTextBoxColumn;
        private BindingSource jsonTableBindingSource;
    }
}
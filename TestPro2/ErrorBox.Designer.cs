namespace TestPro2
{
    partial class ErrorBox
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
            error_dgv = new DataGridView();
            matterDataGridViewTextBoxColumn = new DataGridViewButtonColumn();
            posDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            srcDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            scanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            evaporatorsBindingSource = new BindingSource(components);
            heder = new Label();
            ((System.ComponentModel.ISupportInitialize)error_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)evaporatorsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // error_dgv
            // 
            error_dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            error_dgv.AutoGenerateColumns = false;
            error_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            error_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            error_dgv.Columns.AddRange(new DataGridViewColumn[] { matterDataGridViewTextBoxColumn, posDataGridViewTextBoxColumn, srcDataGridViewTextBoxColumn, scanDataGridViewTextBoxColumn, rateDataGridViewTextBoxColumn });
            error_dgv.DataSource = evaporatorsBindingSource;
            error_dgv.Location = new Point(12, 147);
            error_dgv.Name = "error_dgv";
            error_dgv.RowHeadersWidth = 62;
            error_dgv.RowTemplate.Height = 33;
            error_dgv.Size = new Size(1269, 291);
            error_dgv.TabIndex = 0;
            error_dgv.CellContentClick += error_dgv_CellContentClick;
            // 
            // matterDataGridViewTextBoxColumn
            // 
            matterDataGridViewTextBoxColumn.DataPropertyName = "Matter";
            matterDataGridViewTextBoxColumn.HeaderText = "Matter";
            matterDataGridViewTextBoxColumn.MinimumWidth = 8;
            matterDataGridViewTextBoxColumn.Name = "matterDataGridViewTextBoxColumn";
            matterDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            matterDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // posDataGridViewTextBoxColumn
            // 
            posDataGridViewTextBoxColumn.DataPropertyName = "Pos";
            posDataGridViewTextBoxColumn.HeaderText = "Pos";
            posDataGridViewTextBoxColumn.MinimumWidth = 8;
            posDataGridViewTextBoxColumn.Name = "posDataGridViewTextBoxColumn";
            // 
            // srcDataGridViewTextBoxColumn
            // 
            srcDataGridViewTextBoxColumn.DataPropertyName = "Src";
            srcDataGridViewTextBoxColumn.HeaderText = "Src";
            srcDataGridViewTextBoxColumn.MinimumWidth = 8;
            srcDataGridViewTextBoxColumn.Name = "srcDataGridViewTextBoxColumn";
            // 
            // scanDataGridViewTextBoxColumn
            // 
            scanDataGridViewTextBoxColumn.DataPropertyName = "Scan";
            scanDataGridViewTextBoxColumn.HeaderText = "Scan";
            scanDataGridViewTextBoxColumn.MinimumWidth = 8;
            scanDataGridViewTextBoxColumn.Name = "scanDataGridViewTextBoxColumn";
            // 
            // rateDataGridViewTextBoxColumn
            // 
            rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            rateDataGridViewTextBoxColumn.MinimumWidth = 8;
            rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            // 
            // evaporatorsBindingSource
            // 
            evaporatorsBindingSource.DataSource = typeof(Evaporators);
            // 
            // heder
            // 
            heder.AutoSize = true;
            heder.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            heder.Location = new Point(151, 23);
            heder.MinimumSize = new Size(1000, 0);
            heder.Name = "heder";
            heder.Size = new Size(1000, 96);
            heder.TabIndex = 1;
            heder.Text = "The SIP file contained incomplete data.\r\nPlease choose the appropriate process.";
            heder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ErrorBox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 450);
            Controls.Add(heder);
            Controls.Add(error_dgv);
            Name = "ErrorBox";
            Text = "ErrorBox";
            ((System.ComponentModel.ISupportInitialize)error_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)evaporatorsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView error_dgv;
        private DataGridViewButtonColumn matterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn posDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn srcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn scanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private BindingSource evaporatorsBindingSource;
        private Label heder;
    }
}
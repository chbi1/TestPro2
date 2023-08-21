namespace TestPro2
{
    partial class MCCData
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
            mcc_dgv = new DataGridView();
            elementDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lowLimitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            highLimitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            alarmDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mCCBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)mcc_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mCCBindingSource).BeginInit();
            SuspendLayout();
            // 
            // mcc_dgv
            // 
            mcc_dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mcc_dgv.AutoGenerateColumns = false;
            mcc_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mcc_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mcc_dgv.Columns.AddRange(new DataGridViewColumn[] { elementDataGridViewTextBoxColumn, lowLimitDataGridViewTextBoxColumn, highLimitDataGridViewTextBoxColumn, alarmDataGridViewTextBoxColumn, stateDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            mcc_dgv.DataSource = mCCBindingSource;
            mcc_dgv.Location = new Point(12, 12);
            mcc_dgv.Name = "mcc_dgv";
            mcc_dgv.RowHeadersVisible = false;
            mcc_dgv.RowHeadersWidth = 62;
            mcc_dgv.RowTemplate.Height = 33;
            mcc_dgv.Size = new Size(991, 200);
            mcc_dgv.TabIndex = 0;
            // 
            // elementDataGridViewTextBoxColumn
            // 
            elementDataGridViewTextBoxColumn.DataPropertyName = "Element";
            elementDataGridViewTextBoxColumn.HeaderText = "Element";
            elementDataGridViewTextBoxColumn.MinimumWidth = 170;
            elementDataGridViewTextBoxColumn.Name = "elementDataGridViewTextBoxColumn";
            // 
            // lowLimitDataGridViewTextBoxColumn
            // 
            lowLimitDataGridViewTextBoxColumn.DataPropertyName = "LowLimit";
            lowLimitDataGridViewTextBoxColumn.HeaderText = "LowLimit";
            lowLimitDataGridViewTextBoxColumn.MinimumWidth = 8;
            lowLimitDataGridViewTextBoxColumn.Name = "lowLimitDataGridViewTextBoxColumn";
            // 
            // highLimitDataGridViewTextBoxColumn
            // 
            highLimitDataGridViewTextBoxColumn.DataPropertyName = "HighLimit";
            highLimitDataGridViewTextBoxColumn.HeaderText = "HighLimit";
            highLimitDataGridViewTextBoxColumn.MinimumWidth = 8;
            highLimitDataGridViewTextBoxColumn.Name = "highLimitDataGridViewTextBoxColumn";
            // 
            // alarmDataGridViewTextBoxColumn
            // 
            alarmDataGridViewTextBoxColumn.DataPropertyName = "Alarm";
            alarmDataGridViewTextBoxColumn.HeaderText = "Alarm";
            alarmDataGridViewTextBoxColumn.MinimumWidth = 8;
            alarmDataGridViewTextBoxColumn.Name = "alarmDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            stateDataGridViewTextBoxColumn.HeaderText = "State";
            stateDataGridViewTextBoxColumn.MinimumWidth = 200;
            stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // mCCBindingSource
            // 
            mCCBindingSource.DataSource = typeof(MCC);
            // 
            // MCCData
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 224);
            Controls.Add(mcc_dgv);
            Name = "MCCData";
            Text = "MCCData";
            ((System.ComponentModel.ISupportInitialize)mcc_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)mCCBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView mcc_dgv;
        private BindingSource mCCBindingSource;
        private DataGridViewTextBoxColumn elementDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lowLimitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn highLimitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alarmDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}
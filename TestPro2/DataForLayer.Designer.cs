namespace TestPro2
{
    partial class DataForLayer
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
            jsonTableBindingSource = new BindingSource(components);
            dgv_layer = new DataGridView();
            derivativeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            derivative2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            responseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gainDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            holdTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pLDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            p3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            t3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            p2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            t2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            p1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            t1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            delayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sourceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)jsonTableBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_layer).BeginInit();
            SuspendLayout();
            // 
            // jsonTableBindingSource
            // 
            jsonTableBindingSource.DataSource = typeof(JsonTable);
            // 
            // dgv_layer
            // 
            dgv_layer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_layer.AutoGenerateColumns = false;
            dgv_layer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_layer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_layer.Columns.AddRange(new DataGridViewColumn[] { derivativeDataGridViewTextBoxColumn, derivative2DataGridViewTextBoxColumn, responseDataGridViewTextBoxColumn, gainDataGridViewTextBoxColumn, holdTimeDataGridViewTextBoxColumn, pLDataGridViewTextBoxColumn, p3DataGridViewTextBoxColumn, t3DataGridViewTextBoxColumn, p2DataGridViewTextBoxColumn, t2DataGridViewTextBoxColumn, p1DataGridViewTextBoxColumn, t1DataGridViewTextBoxColumn, delayDataGridViewTextBoxColumn, sourceDataGridViewTextBoxColumn });
            dgv_layer.DataSource = jsonTableBindingSource;
            dgv_layer.Location = new Point(12, 12);
            dgv_layer.Name = "dgv_layer";
            dgv_layer.RowHeadersWidth = 62;
            dgv_layer.RowTemplate.Height = 33;
            dgv_layer.Size = new Size(1728, 151);
            dgv_layer.TabIndex = 0;
            // 
            // derivativeDataGridViewTextBoxColumn
            // 
            derivativeDataGridViewTextBoxColumn.DataPropertyName = "Derivative";
            derivativeDataGridViewTextBoxColumn.HeaderText = "Derivative";
            derivativeDataGridViewTextBoxColumn.MinimumWidth = 8;
            derivativeDataGridViewTextBoxColumn.Name = "derivativeDataGridViewTextBoxColumn";
            // 
            // derivative2DataGridViewTextBoxColumn
            // 
            derivative2DataGridViewTextBoxColumn.DataPropertyName = "Derivative2";
            derivative2DataGridViewTextBoxColumn.HeaderText = "Derivative2";
            derivative2DataGridViewTextBoxColumn.MinimumWidth = 8;
            derivative2DataGridViewTextBoxColumn.Name = "derivative2DataGridViewTextBoxColumn";
            // 
            // responseDataGridViewTextBoxColumn
            // 
            responseDataGridViewTextBoxColumn.DataPropertyName = "Response";
            responseDataGridViewTextBoxColumn.HeaderText = "Response";
            responseDataGridViewTextBoxColumn.MinimumWidth = 8;
            responseDataGridViewTextBoxColumn.Name = "responseDataGridViewTextBoxColumn";
            // 
            // gainDataGridViewTextBoxColumn
            // 
            gainDataGridViewTextBoxColumn.DataPropertyName = "Gain";
            gainDataGridViewTextBoxColumn.HeaderText = "Gain";
            gainDataGridViewTextBoxColumn.MinimumWidth = 8;
            gainDataGridViewTextBoxColumn.Name = "gainDataGridViewTextBoxColumn";
            // 
            // holdTimeDataGridViewTextBoxColumn
            // 
            holdTimeDataGridViewTextBoxColumn.DataPropertyName = "HoldTime";
            holdTimeDataGridViewTextBoxColumn.HeaderText = "HoldTime";
            holdTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            holdTimeDataGridViewTextBoxColumn.Name = "holdTimeDataGridViewTextBoxColumn";
            // 
            // pLDataGridViewTextBoxColumn
            // 
            pLDataGridViewTextBoxColumn.DataPropertyName = "PL";
            pLDataGridViewTextBoxColumn.HeaderText = "PL";
            pLDataGridViewTextBoxColumn.MinimumWidth = 8;
            pLDataGridViewTextBoxColumn.Name = "pLDataGridViewTextBoxColumn";
            // 
            // p3DataGridViewTextBoxColumn
            // 
            p3DataGridViewTextBoxColumn.DataPropertyName = "P3";
            p3DataGridViewTextBoxColumn.HeaderText = "P3";
            p3DataGridViewTextBoxColumn.MinimumWidth = 8;
            p3DataGridViewTextBoxColumn.Name = "p3DataGridViewTextBoxColumn";
            // 
            // t3DataGridViewTextBoxColumn
            // 
            t3DataGridViewTextBoxColumn.DataPropertyName = "T3";
            t3DataGridViewTextBoxColumn.HeaderText = "T3";
            t3DataGridViewTextBoxColumn.MinimumWidth = 8;
            t3DataGridViewTextBoxColumn.Name = "t3DataGridViewTextBoxColumn";
            // 
            // p2DataGridViewTextBoxColumn
            // 
            p2DataGridViewTextBoxColumn.DataPropertyName = "P2";
            p2DataGridViewTextBoxColumn.HeaderText = "P2";
            p2DataGridViewTextBoxColumn.MinimumWidth = 8;
            p2DataGridViewTextBoxColumn.Name = "p2DataGridViewTextBoxColumn";
            // 
            // t2DataGridViewTextBoxColumn
            // 
            t2DataGridViewTextBoxColumn.DataPropertyName = "T2";
            t2DataGridViewTextBoxColumn.HeaderText = "T2";
            t2DataGridViewTextBoxColumn.MinimumWidth = 8;
            t2DataGridViewTextBoxColumn.Name = "t2DataGridViewTextBoxColumn";
            // 
            // p1DataGridViewTextBoxColumn
            // 
            p1DataGridViewTextBoxColumn.DataPropertyName = "P1";
            p1DataGridViewTextBoxColumn.HeaderText = "P1";
            p1DataGridViewTextBoxColumn.MinimumWidth = 8;
            p1DataGridViewTextBoxColumn.Name = "p1DataGridViewTextBoxColumn";
            // 
            // t1DataGridViewTextBoxColumn
            // 
            t1DataGridViewTextBoxColumn.DataPropertyName = "T1";
            t1DataGridViewTextBoxColumn.HeaderText = "T1";
            t1DataGridViewTextBoxColumn.MinimumWidth = 8;
            t1DataGridViewTextBoxColumn.Name = "t1DataGridViewTextBoxColumn";
            // 
            // delayDataGridViewTextBoxColumn
            // 
            delayDataGridViewTextBoxColumn.DataPropertyName = "Delay";
            delayDataGridViewTextBoxColumn.HeaderText = "Delay";
            delayDataGridViewTextBoxColumn.MinimumWidth = 8;
            delayDataGridViewTextBoxColumn.Name = "delayDataGridViewTextBoxColumn";
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            sourceDataGridViewTextBoxColumn.HeaderText = "Source";
            sourceDataGridViewTextBoxColumn.MinimumWidth = 8;
            sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            // 
            // DataForLayer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1752, 175);
            Controls.Add(dgv_layer);
            Name = "DataForLayer";
            Text = "Data for layer";
            ((System.ComponentModel.ISupportInitialize)jsonTableBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_layer).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource jsonTableBindingSource;
        private DataGridView dgv_layer;
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
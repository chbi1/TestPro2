namespace TestPro2
{
    partial class DbControl
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
            enter_btn = new Button();
            label1 = new Label();
            code_box = new TextBox();
            Machine_x = new Button();
            Machine_p = new Button();
            Machine_n = new Button();
            Machine_e = new Button();
            label2 = new Label();
            param_db = new Button();
            SuspendLayout();
            // 
            // enter_btn
            // 
            enter_btn.Location = new Point(389, 62);
            enter_btn.Name = "enter_btn";
            enter_btn.Size = new Size(112, 34);
            enter_btn.TabIndex = 0;
            enter_btn.Text = "&Enter";
            enter_btn.UseVisualStyleBackColor = true;
            enter_btn.Click += enter_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 67);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 1;
            label1.Text = "Enter code";
            // 
            // code_box
            // 
            code_box.Location = new Point(186, 64);
            code_box.Name = "code_box";
            code_box.Size = new Size(179, 31);
            code_box.TabIndex = 2;
            // 
            // Machine_x
            // 
            Machine_x.Enabled = false;
            Machine_x.Location = new Point(438, 267);
            Machine_x.Name = "Machine_x";
            Machine_x.Size = new Size(112, 34);
            Machine_x.TabIndex = 3;
            Machine_x.Text = "Machine X";
            Machine_x.UseVisualStyleBackColor = true;
            Machine_x.Visible = false;
            Machine_x.Click += Machine_x_Click;
            // 
            // Machine_p
            // 
            Machine_p.Enabled = false;
            Machine_p.Location = new Point(296, 267);
            Machine_p.Name = "Machine_p";
            Machine_p.Size = new Size(112, 34);
            Machine_p.TabIndex = 4;
            Machine_p.Text = "Machine P";
            Machine_p.UseVisualStyleBackColor = true;
            Machine_p.Visible = false;
            Machine_p.Click += Machine_p_Click;
            // 
            // Machine_n
            // 
            Machine_n.Enabled = false;
            Machine_n.Location = new Point(154, 267);
            Machine_n.Name = "Machine_n";
            Machine_n.Size = new Size(112, 34);
            Machine_n.TabIndex = 5;
            Machine_n.Text = "Machine N";
            Machine_n.UseVisualStyleBackColor = true;
            Machine_n.Visible = false;
            Machine_n.Click += Machine_n_Click;
            // 
            // Machine_e
            // 
            Machine_e.Enabled = false;
            Machine_e.Location = new Point(12, 267);
            Machine_e.Name = "Machine_e";
            Machine_e.Size = new Size(112, 34);
            Machine_e.TabIndex = 6;
            Machine_e.Text = "Machine E";
            Machine_e.UseVisualStyleBackColor = true;
            Machine_e.Visible = false;
            Machine_e.Click += Machine_e_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 225);
            label2.Name = "label2";
            label2.Size = new Size(246, 25);
            label2.TabIndex = 7;
            label2.Text = "change database for REC files";
            label2.Visible = false;
            // 
            // param_db
            // 
            param_db.Enabled = false;
            param_db.Location = new Point(214, 131);
            param_db.Name = "param_db";
            param_db.Size = new Size(151, 76);
            param_db.TabIndex = 8;
            param_db.Text = "Parameter DataBase";
            param_db.UseVisualStyleBackColor = true;
            param_db.Visible = false;
            param_db.Click += param_db_Click;
            // 
            // DbControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 313);
            Controls.Add(param_db);
            Controls.Add(label2);
            Controls.Add(Machine_e);
            Controls.Add(Machine_n);
            Controls.Add(Machine_p);
            Controls.Add(Machine_x);
            Controls.Add(code_box);
            Controls.Add(label1);
            Controls.Add(enter_btn);
            Name = "DbControl";
            Text = "DbControl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button enter_btn;
        private Label label1;
        private TextBox code_box;
        private Button Machine_x;
        private Button Machine_p;
        private Button Machine_n;
        private Button Machine_e;
        private Label label2;
        private Button param_db;
    }
}
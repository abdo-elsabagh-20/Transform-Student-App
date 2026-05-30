namespace Bus_System
{
    partial class Students
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
            studentgrid = new DataGridView();
            Deletebutton = new Button();
            Updatebutton = new Button();
            addbutton = new Button();
            panel2 = new Panel();
            textphone = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            textname = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            textid = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            textaddress = new TextBox();
            label4 = new Label();
            searchbutton = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)studentgrid).BeginInit();
            SuspendLayout();
            // 
            // studentgrid
            // 
            studentgrid.BackgroundColor = SystemColors.Control;
            studentgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentgrid.Location = new Point(122, 302);
            studentgrid.Name = "studentgrid";
            studentgrid.RowHeadersWidth = 51;
            studentgrid.Size = new Size(557, 374);
            studentgrid.TabIndex = 44;
            studentgrid.CellContentClick += studentgrid_CellContentClick;
            // 
            // Deletebutton
            // 
            Deletebutton.BackColor = Color.FromArgb(44, 62, 80);
            Deletebutton.FlatAppearance.BorderSize = 0;
            Deletebutton.FlatStyle = FlatStyle.Flat;
            Deletebutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Deletebutton.ForeColor = Color.White;
            Deletebutton.Location = new Point(417, 215);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(94, 39);
            Deletebutton.TabIndex = 43;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = false;
            Deletebutton.Click += Deletebutton_Click_1;
            // 
            // Updatebutton
            // 
            Updatebutton.BackColor = Color.FromArgb(44, 62, 80);
            Updatebutton.FlatAppearance.BorderSize = 0;
            Updatebutton.FlatStyle = FlatStyle.Flat;
            Updatebutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Updatebutton.ForeColor = Color.White;
            Updatebutton.Location = new Point(286, 215);
            Updatebutton.Name = "Updatebutton";
            Updatebutton.Size = new Size(94, 39);
            Updatebutton.TabIndex = 42;
            Updatebutton.Text = "Update";
            Updatebutton.UseVisualStyleBackColor = false;
            Updatebutton.Click += Updatebutton_Click;
            // 
            // addbutton
            // 
            addbutton.BackColor = Color.FromArgb(44, 62, 80);
            addbutton.FlatAppearance.BorderSize = 0;
            addbutton.FlatStyle = FlatStyle.Flat;
            addbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addbutton.ForeColor = Color.White;
            addbutton.Location = new Point(150, 215);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(94, 39);
            addbutton.TabIndex = 41;
            addbutton.Text = "Add";
            addbutton.UseVisualStyleBackColor = false;
            addbutton.Click += addbutton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Location = new Point(555, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 2);
            panel2.TabIndex = 40;
            // 
            // textphone
            // 
            textphone.BackColor = Color.FromArgb(44, 62, 80);
            textphone.BorderStyle = BorderStyle.None;
            textphone.Font = new Font("Segoe UI", 10.2F);
            textphone.ForeColor = SystemColors.ActiveCaptionText;
            textphone.Location = new Point(555, 65);
            textphone.Name = "textphone";
            textphone.Size = new Size(158, 23);
            textphone.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(441, 67);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 38;
            label1.Text = "Phone";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(193, 163);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 2);
            panel1.TabIndex = 37;
            // 
            // textname
            // 
            textname.BackColor = Color.FromArgb(44, 62, 80);
            textname.BorderStyle = BorderStyle.None;
            textname.Font = new Font("Segoe UI", 10.2F);
            textname.ForeColor = SystemColors.ActiveCaptionText;
            textname.Location = new Point(193, 138);
            textname.Name = "textname";
            textname.Size = new Size(158, 23);
            textname.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(97, 142);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 35;
            label2.Text = "Name";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Location = new Point(193, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(158, 2);
            panel3.TabIndex = 47;
            // 
            // textid
            // 
            textid.BackColor = Color.FromArgb(44, 62, 80);
            textid.BorderStyle = BorderStyle.None;
            textid.Font = new Font("Segoe UI", 10.2F);
            textid.ForeColor = SystemColors.ActiveCaptionText;
            textid.Location = new Point(193, 62);
            textid.Name = "textid";
            textid.Size = new Size(158, 23);
            textid.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(97, 64);
            label3.Name = "label3";
            label3.Size = new Size(33, 28);
            label3.TabIndex = 45;
            label3.Text = "ID";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Location = new Point(555, 167);
            panel4.Name = "panel4";
            panel4.Size = new Size(158, 2);
            panel4.TabIndex = 50;
            // 
            // textaddress
            // 
            textaddress.BackColor = Color.FromArgb(44, 62, 80);
            textaddress.BorderStyle = BorderStyle.None;
            textaddress.Font = new Font("Segoe UI", 10.2F);
            textaddress.ForeColor = SystemColors.ActiveCaptionText;
            textaddress.Location = new Point(555, 142);
            textaddress.Name = "textaddress";
            textaddress.Size = new Size(158, 23);
            textaddress.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(441, 144);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 48;
            label4.Text = "Address";
            // 
            // searchbutton
            // 
            searchbutton.BackColor = Color.FromArgb(44, 62, 80);
            searchbutton.FlatAppearance.BorderSize = 0;
            searchbutton.FlatStyle = FlatStyle.Flat;
            searchbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            searchbutton.ForeColor = Color.White;
            searchbutton.Location = new Point(545, 215);
            searchbutton.Name = "searchbutton";
            searchbutton.Size = new Size(94, 39);
            searchbutton.TabIndex = 51;
            searchbutton.Text = "Search";
            searchbutton.UseVisualStyleBackColor = false;
            searchbutton.Click += searchbutton_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(761, 2);
            label7.Name = "label7";
            label7.Size = new Size(35, 38);
            label7.TabIndex = 54;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(1, 1);
            label6.Name = "label6";
            label6.Size = new Size(39, 41);
            label6.TabIndex = 53;
            label6.Text = "<";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(342, 9);
            label5.Name = "label5";
            label5.Size = new Size(142, 41);
            label5.TabIndex = 52;
            label5.Text = "Students";
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(800, 688);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(searchbutton);
            Controls.Add(panel4);
            Controls.Add(textaddress);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(textid);
            Controls.Add(label3);
            Controls.Add(studentgrid);
            Controls.Add(Deletebutton);
            Controls.Add(Updatebutton);
            Controls.Add(addbutton);
            Controls.Add(panel2);
            Controls.Add(textphone);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(textname);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Students";
            Text = "Student";
            Load += Student_Load;
            ((System.ComponentModel.ISupportInitialize)studentgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView studentgrid;
        private Button Deletebutton;
        private Button Updatebutton;
        private Button addbutton;
        private Panel panel2;
        private TextBox textphone;
        private Label label1;
        private Panel panel1;
        private TextBox textname;
        private Label label2;
        private Panel panel3;
        private TextBox textid;
        private Label label3;
        private Panel panel4;
        private TextBox textaddress;
        private Label label4;
        private Button searchbutton;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}
namespace Bus_System
{
    partial class Drivers
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
            panel1 = new Panel();
            drivname = new TextBox();
            label2 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            drivPhone = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            driverGrid = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            drivid = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)driverGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(397, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 2);
            panel1.TabIndex = 27;
            // 
            // drivname
            // 
            drivname.BackColor = Color.FromArgb(44, 62, 80);
            drivname.BorderStyle = BorderStyle.None;
            drivname.Font = new Font("Segoe UI", 10.8F);
            drivname.ForeColor = SystemColors.ActiveCaptionText;
            drivname.Location = new Point(397, 144);
            drivname.Name = "drivname";
            drivname.Size = new Size(158, 24);
            drivname.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(292, 150);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 25;
            label2.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(374, 6);
            label4.Name = "label4";
            label4.Size = new Size(118, 41);
            label4.TabIndex = 24;
            label4.Text = "Drivers";
            label4.Click += label4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Location = new Point(539, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 2);
            panel2.TabIndex = 30;
            // 
            // drivPhone
            // 
            drivPhone.BackColor = Color.FromArgb(44, 62, 80);
            drivPhone.BorderStyle = BorderStyle.None;
            drivPhone.Font = new Font("Segoe UI", 10.8F);
            drivPhone.ForeColor = SystemColors.ActiveCaptionText;
            drivPhone.Location = new Point(539, 86);
            drivPhone.Name = "drivPhone";
            drivPhone.Size = new Size(158, 24);
            drivPhone.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(436, 91);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 28;
            label1.Text = "Phone";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(44, 62, 80);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(501, 204);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 39);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(44, 62, 80);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(353, 204);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 39);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(44, 62, 80);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(202, 204);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 39);
            btnAdd.TabIndex = 31;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // driverGrid
            // 
            driverGrid.BackgroundColor = SystemColors.Control;
            driverGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            driverGrid.Location = new Point(176, 290);
            driverGrid.Name = "driverGrid";
            driverGrid.RowHeadersWidth = 51;
            driverGrid.Size = new Size(445, 374);
            driverGrid.TabIndex = 34;
            driverGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(0, -1);
            label6.Name = "label6";
            label6.Size = new Size(39, 41);
            label6.TabIndex = 35;
            label6.Text = "<";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(759, -1);
            label7.Name = "label7";
            label7.Size = new Size(35, 38);
            label7.TabIndex = 36;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Location = new Point(193, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(158, 2);
            panel3.TabIndex = 39;
            // 
            // drivid
            // 
            drivid.BackColor = Color.FromArgb(44, 62, 80);
            drivid.BorderStyle = BorderStyle.None;
            drivid.Font = new Font("Segoe UI", 10.8F);
            drivid.ForeColor = SystemColors.ActiveCaptionText;
            drivid.Location = new Point(193, 75);
            drivid.Name = "drivid";
            drivid.Size = new Size(158, 24);
            drivid.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(99, 86);
            label3.Name = "label3";
            label3.Size = new Size(33, 28);
            label3.TabIndex = 37;
            label3.Text = "ID";
            // 
            // Drivers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(793, 703);
            Controls.Add(panel3);
            Controls.Add(drivid);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(driverGrid);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(panel2);
            Controls.Add(drivPhone);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(drivname);
            Controls.Add(label2);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Drivers";
            Text = "Drivers";
            Load += Drivers_Load;
            ((System.ComponentModel.ISupportInitialize)driverGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox drivname;
        private Label label2;
        private Label label4;
        private Panel panel2;
        private TextBox drivPhone;
        private Label label1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView driverGrid;
        private Label label6;
        private Label label7;
        private Panel panel3;
        private TextBox drivid;
        private Label label3;
    }
}
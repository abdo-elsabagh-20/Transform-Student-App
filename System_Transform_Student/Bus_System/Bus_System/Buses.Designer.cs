namespace Bus_System
{
    partial class Buses
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
            label4 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            txtCapacity = new TextBox();
            panel1 = new Panel();
            txtRoute = new TextBox();
            label2 = new Label();
            cmbDriver = new ComboBox();
            cmbArea = new ComboBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvBuses = new DataGridView();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            busid = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBuses).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(328, 8);
            label4.Name = "label4";
            label4.Size = new Size(97, 41);
            label4.TabIndex = 16;
            label4.Text = "Buses";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(21, 141);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 15;
            label1.Text = "Capacity";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Location = new Point(132, 171);
            panel3.Name = "panel3";
            panel3.Size = new Size(158, 2);
            panel3.TabIndex = 20;
            // 
            // txtCapacity
            // 
            txtCapacity.BackColor = Color.FromArgb(44, 62, 80);
            txtCapacity.BorderStyle = BorderStyle.None;
            txtCapacity.Font = new Font("Segoe UI", 10.8F);
            txtCapacity.ForeColor = SystemColors.ActiveCaptionText;
            txtCapacity.Location = new Point(132, 145);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(158, 24);
            txtCapacity.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(482, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 2);
            panel1.TabIndex = 23;
            // 
            // txtRoute
            // 
            txtRoute.BackColor = Color.FromArgb(44, 62, 80);
            txtRoute.BorderStyle = BorderStyle.None;
            txtRoute.Font = new Font("Segoe UI", 10.8F);
            txtRoute.ForeColor = SystemColors.ActiveCaptionText;
            txtRoute.Location = new Point(482, 146);
            txtRoute.Name = "txtRoute";
            txtRoute.Size = new Size(158, 24);
            txtRoute.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(386, 149);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 21;
            label2.Text = "Route";
            // 
            // cmbDriver
            // 
            cmbDriver.ForeColor = SystemColors.ActiveCaptionText;
            cmbDriver.FormattingEnabled = true;
            cmbDriver.Location = new Point(132, 217);
            cmbDriver.Name = "cmbDriver";
            cmbDriver.Size = new Size(158, 28);
            cmbDriver.TabIndex = 24;
            // 
            // cmbArea
            // 
            cmbArea.ForeColor = SystemColors.ActiveCaptionText;
            cmbArea.FormattingEnabled = true;
            cmbArea.Location = new Point(482, 217);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(158, 28);
            cmbArea.TabIndex = 25;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(44, 62, 80);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(464, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 38);
            btnDelete.TabIndex = 28;
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
            btnUpdate.Location = new Point(314, 275);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 38);
            btnUpdate.TabIndex = 27;
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
            btnAdd.Location = new Point(155, 275);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 38);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvBuses
            // 
            dgvBuses.BackgroundColor = SystemColors.Control;
            dgvBuses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuses.Location = new Point(45, 353);
            dgvBuses.Name = "dgvBuses";
            dgvBuses.RowHeadersWidth = 51;
            dgvBuses.Size = new Size(696, 386);
            dgvBuses.TabIndex = 29;
            dgvBuses.CellContentClick += dgvBuses_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(386, 220);
            label3.Name = "label3";
            label3.Size = new Size(56, 28);
            label3.TabIndex = 30;
            label3.Text = "Area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(21, 217);
            label5.Name = "label5";
            label5.Size = new Size(71, 28);
            label5.TabIndex = 31;
            label5.Text = "Driver";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(2, 1);
            label6.Name = "label6";
            label6.Size = new Size(39, 41);
            label6.TabIndex = 32;
            label6.Text = "<";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(761, 1);
            label7.Name = "label7";
            label7.Size = new Size(35, 38);
            label7.TabIndex = 33;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Location = new Point(132, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 2);
            panel2.TabIndex = 36;
            // 
            // busid
            // 
            busid.BackColor = Color.FromArgb(44, 62, 80);
            busid.BorderStyle = BorderStyle.None;
            busid.Font = new Font("Segoe UI", 10.8F);
            busid.ForeColor = SystemColors.ActiveCaptionText;
            busid.Location = new Point(132, 83);
            busid.Name = "busid";
            busid.Size = new Size(165, 24);
            busid.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(28, 90);
            label8.Name = "label8";
            label8.Size = new Size(33, 28);
            label8.TabIndex = 34;
            label8.Text = "ID";
            // 
            // Buses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(800, 751);
            Controls.Add(panel2);
            Controls.Add(busid);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(dgvBuses);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbArea);
            Controls.Add(cmbDriver);
            Controls.Add(panel1);
            Controls.Add(txtRoute);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(txtCapacity);
            Controls.Add(label4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Buses";
            Text = "Buses";
            Load += Buses_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBuses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private Panel panel3;
        private TextBox txtCapacity;
        private Panel panel1;
        private TextBox txtRoute;
        private Label label2;
        private ComboBox cmbDriver;
        private ComboBox cmbArea;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvBuses;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel2;
        private TextBox busid;
        private Label label8;
    }
}
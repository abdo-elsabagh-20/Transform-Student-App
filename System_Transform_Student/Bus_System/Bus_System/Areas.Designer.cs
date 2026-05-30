namespace Bus_System
{
    partial class Areas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            areaname = new TextBox();
            label2 = new Label();
            label4 = new Label();
            dgvArea = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            areaid = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvArea).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(581, 166);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 2);
            panel1.TabIndex = 27;
            // 
            // areaname
            // 
            areaname.BackColor = Color.FromArgb(44, 62, 80);
            areaname.BorderStyle = BorderStyle.None;
            areaname.Font = new Font("Segoe UI", 10.8F);
            areaname.ForeColor = SystemColors.ActiveCaptionText;
            areaname.Location = new Point(581, 140);
            areaname.Name = "areaname";
            areaname.Size = new Size(158, 24);
            areaname.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(430, 145);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 25;
            label2.Text = "Area Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(398, 22);
            label4.Name = "label4";
            label4.Size = new Size(90, 38);
            label4.TabIndex = 24;
            label4.Text = "Areas";
            // 
            // dgvArea
            // 
            dgvArea.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvArea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvArea.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvArea.DefaultCellStyle = dataGridViewCellStyle2;
            dgvArea.Location = new Point(280, 325);
            dgvArea.Name = "dgvArea";
            dgvArea.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dgvArea.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvArea.Size = new Size(321, 359);
            dgvArea.TabIndex = 33;
            dgvArea.CellContentClick += dgvArea_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(44, 62, 80);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(534, 232);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 38);
            btnDelete.TabIndex = 32;
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
            btnUpdate.Location = new Point(373, 232);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 38);
            btnUpdate.TabIndex = 31;
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
            btnAdd.Location = new Point(206, 232);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 38);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(0, 3);
            label6.Name = "label6";
            label6.Size = new Size(37, 38);
            label6.TabIndex = 34;
            label6.Text = "<";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(808, 0);
            label7.Name = "label7";
            label7.Size = new Size(38, 41);
            label7.TabIndex = 35;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Location = new Point(206, 166);
            panel3.Name = "panel3";
            panel3.Size = new Size(158, 2);
            panel3.TabIndex = 41;
            // 
            // areaid
            // 
            areaid.BackColor = Color.FromArgb(44, 62, 80);
            areaid.BorderStyle = BorderStyle.None;
            areaid.Font = new Font("Segoe UI", 10.8F);
            areaid.ForeColor = SystemColors.ActiveCaptionText;
            areaid.Location = new Point(206, 140);
            areaid.Name = "areaid";
            areaid.Size = new Size(158, 24);
            areaid.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(120, 143);
            label3.Name = "label3";
            label3.Size = new Size(33, 28);
            label3.TabIndex = 39;
            label3.Text = "ID";
            // 
            // Areas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(846, 756);
            Controls.Add(panel3);
            Controls.Add(areaid);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dgvArea);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            Controls.Add(areaname);
            Controls.Add(label2);
            Controls.Add(label4);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Areas";
            Text = "Areas";
            Load += Areas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox areaname;
        private Label label2;
        private Label label4;
        private DataGridView dgvArea;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label6;
        private Label label7;
        private Panel panel3;
        private TextBox areaid;
        private Label label3;
    }
}
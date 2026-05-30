namespace Bus_System
{
    partial class Trips
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
            panel2 = new Panel();
            tripid = new TextBox();
            label2 = new Label();
            label1 = new Label();
            busid = new ComboBox();
            label3 = new Label();
            tripDGV = new DataGridView();
            date = new DateTimePicker();
            time = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            deletetrip = new Button();
            updatetrip = new Button();
            addtrip = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)tripDGV).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Location = new Point(116, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 2);
            panel2.TabIndex = 11;
            // 
            // tripid
            // 
            tripid.BackColor = Color.FromArgb(44, 62, 80);
            tripid.BorderStyle = BorderStyle.None;
            tripid.Font = new Font("Segoe UI", 10.8F);
            tripid.ForeColor = SystemColors.ActiveCaptionText;
            tripid.Location = new Point(116, 114);
            tripid.Name = "tripid";
            tripid.Size = new Size(158, 24);
            tripid.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(44, 62, 80);
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(38, 116);
            label2.Name = "label2";
            label2.Size = new Size(33, 25);
            label2.TabIndex = 10;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(44, 62, 80);
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(348, 22);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 12;
            label1.Text = "Book Trip";
            // 
            // busid
            // 
            busid.FormattingEnabled = true;
            busid.Location = new Point(508, 121);
            busid.Name = "busid";
            busid.Size = new Size(151, 28);
            busid.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(44, 62, 80);
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(377, 124);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 14;
            label3.Text = "Bus ID";
            // 
            // tripDGV
            // 
            tripDGV.BackgroundColor = SystemColors.Control;
            tripDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tripDGV.Location = new Point(140, 310);
            tripDGV.Name = "tripDGV";
            tripDGV.RowHeadersWidth = 51;
            tripDGV.Size = new Size(581, 317);
            tripDGV.TabIndex = 15;
            tripDGV.CellContentClick += tripDGV_CellContentClick;
            // 
            // date
            // 
            date.Location = new Point(116, 180);
            date.Name = "date";
            date.Size = new Size(241, 27);
            date.TabIndex = 16;
            // 
            // time
            // 
            time.Location = new Point(508, 182);
            time.Name = "time";
            time.Size = new Size(250, 27);
            time.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(44, 62, 80);
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(38, 182);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 18;
            label4.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(44, 62, 80);
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(393, 184);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 19;
            label5.Text = "Time";
            // 
            // deletetrip
            // 
            deletetrip.BackColor = Color.FromArgb(44, 62, 80);
            deletetrip.FlatAppearance.BorderSize = 0;
            deletetrip.FlatStyle = FlatStyle.Flat;
            deletetrip.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            deletetrip.ForeColor = Color.White;
            deletetrip.Location = new Point(510, 250);
            deletetrip.Name = "deletetrip";
            deletetrip.Size = new Size(109, 42);
            deletetrip.TabIndex = 22;
            deletetrip.Text = "Delete";
            deletetrip.UseVisualStyleBackColor = false;
            deletetrip.Click += deletetrip_Click;
            // 
            // updatetrip
            // 
            updatetrip.BackColor = Color.FromArgb(44, 62, 80);
            updatetrip.FlatAppearance.BorderSize = 0;
            updatetrip.FlatStyle = FlatStyle.Flat;
            updatetrip.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            updatetrip.ForeColor = Color.White;
            updatetrip.Location = new Point(362, 250);
            updatetrip.Name = "updatetrip";
            updatetrip.Size = new Size(109, 42);
            updatetrip.TabIndex = 21;
            updatetrip.Text = "Update";
            updatetrip.UseVisualStyleBackColor = false;
            updatetrip.Click += updatetrip_Click;
            // 
            // addtrip
            // 
            addtrip.BackColor = Color.FromArgb(44, 62, 80);
            addtrip.FlatAppearance.BorderSize = 0;
            addtrip.FlatStyle = FlatStyle.Flat;
            addtrip.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addtrip.ForeColor = Color.White;
            addtrip.Location = new Point(211, 250);
            addtrip.Name = "addtrip";
            addtrip.Size = new Size(109, 42);
            addtrip.TabIndex = 20;
            addtrip.Text = "Add";
            addtrip.UseVisualStyleBackColor = false;
            addtrip.Click += addtrip_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(3, 2);
            label6.Name = "label6";
            label6.Size = new Size(39, 41);
            label6.TabIndex = 54;
            label6.Text = "<";
            label6.Click += label6_Click;
            // 
            // Trips
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(798, 653);
            Controls.Add(label6);
            Controls.Add(deletetrip);
            Controls.Add(updatetrip);
            Controls.Add(addtrip);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(time);
            Controls.Add(date);
            Controls.Add(tripDGV);
            Controls.Add(label3);
            Controls.Add(busid);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(tripid);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Trips";
            Text = "Trips";
            Load += Trips_Load;
            ((System.ComponentModel.ISupportInitialize)tripDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private TextBox tripid;
        private Label label2;
        private Label label1;
        private ComboBox busid;
        private Label label3;
        private DataGridView tripDGV;
        private DateTimePicker date;
        private DateTimePicker time;
        private Label label4;
        private Label label5;
        private Button deletetrip;
        private Button updatetrip;
        private Button addtrip;
        private Label label6;
    }
}
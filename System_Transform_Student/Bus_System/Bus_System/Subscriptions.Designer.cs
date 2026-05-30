namespace Bus_System
{
    partial class Subscriptions
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
            subsDGV = new DataGridView();
            stuid = new ComboBox();
            status = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            date = new DateTimePicker();
            label3 = new Label();
            delete = new Button();
            update = new Button();
            add = new Button();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            subid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)subsDGV).BeginInit();
            SuspendLayout();
            // 
            // subsDGV
            // 
            subsDGV.BackgroundColor = SystemColors.Control;
            subsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            subsDGV.Location = new Point(113, 303);
            subsDGV.Name = "subsDGV";
            subsDGV.RowHeadersWidth = 51;
            subsDGV.Size = new Size(589, 300);
            subsDGV.TabIndex = 0;
            subsDGV.CellContentClick += subsDGV_CellContentClick;
            // 
            // stuid
            // 
            stuid.FormattingEnabled = true;
            stuid.Location = new Point(181, 150);
            stuid.Name = "stuid";
            stuid.Size = new Size(165, 28);
            stuid.TabIndex = 1;
            // 
            // status
            // 
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "Paid", "Not Paid" });
            status.Location = new Point(507, 91);
            status.Name = "status";
            status.Size = new Size(151, 28);
            status.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 150);
            label1.Name = "label1";
            label1.Size = new Size(113, 28);
            label1.TabIndex = 3;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(411, 94);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 4;
            label2.Text = "Status";
            // 
            // date
            // 
            date.Location = new Point(507, 152);
            date.Name = "date";
            date.Size = new Size(244, 27);
            date.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(411, 152);
            label3.Name = "label3";
            label3.Size = new Size(57, 28);
            label3.TabIndex = 6;
            label3.Text = "Date";
            // 
            // delete
            // 
            delete.BackColor = Color.FromArgb(44, 62, 80);
            delete.FlatAppearance.BorderSize = 0;
            delete.FlatStyle = FlatStyle.Flat;
            delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            delete.ForeColor = Color.White;
            delete.Location = new Point(490, 232);
            delete.Name = "delete";
            delete.Size = new Size(109, 42);
            delete.TabIndex = 13;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(44, 62, 80);
            update.FlatAppearance.BorderSize = 0;
            update.FlatStyle = FlatStyle.Flat;
            update.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            update.ForeColor = Color.White;
            update.Location = new Point(342, 232);
            update.Name = "update";
            update.Size = new Size(109, 42);
            update.TabIndex = 12;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // add
            // 
            add.BackColor = Color.FromArgb(44, 62, 80);
            add.FlatAppearance.BorderSize = 0;
            add.FlatStyle = FlatStyle.Flat;
            add.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            add.ForeColor = Color.White;
            add.Location = new Point(191, 232);
            add.Name = "add";
            add.Size = new Size(109, 42);
            add.TabIndex = 11;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(329, 6);
            label4.Name = "label4";
            label4.Size = new Size(209, 41);
            label4.TabIndex = 14;
            label4.Text = "Subscriptions";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(3, 2);
            label6.Name = "label6";
            label6.Size = new Size(39, 41);
            label6.TabIndex = 22;
            label6.Text = "<";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(771, -1);
            label7.Name = "label7";
            label7.Size = new Size(35, 38);
            label7.TabIndex = 23;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(12, 94);
            label5.Name = "label5";
            label5.Size = new Size(74, 28);
            label5.TabIndex = 24;
            label5.Text = "Sub ID";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Location = new Point(181, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 2);
            panel2.TabIndex = 38;
            // 
            // subid
            // 
            subid.BackColor = Color.FromArgb(44, 62, 80);
            subid.BorderStyle = BorderStyle.None;
            subid.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subid.ForeColor = SystemColors.ActiveCaptionText;
            subid.Location = new Point(181, 89);
            subid.Name = "subid";
            subid.Size = new Size(165, 24);
            subid.TabIndex = 37;
            // 
            // Subscriptions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(805, 673);
            Controls.Add(panel2);
            Controls.Add(subid);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(add);
            Controls.Add(label3);
            Controls.Add(date);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(status);
            Controls.Add(stuid);
            Controls.Add(subsDGV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Subscriptions";
            Text = "Subscriptions";
            Load += Subscriptions_Load;
            ((System.ComponentModel.ISupportInitialize)subsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView subsDGV;
        private ComboBox stuid;
        private ComboBox status;
        private Label label1;
        private Label label2;
        private DateTimePicker date;
        private Label label3;
        private Button delete;
        private Button update;
        private Button add;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label5;
        private Panel panel2;
        private TextBox subid;
    }
}
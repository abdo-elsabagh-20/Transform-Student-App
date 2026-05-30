namespace Bus_System
{
    partial class Sign_up
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
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            emailtext = new TextBox();
            label4 = new Label();
            phonetext = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            passtext = new TextBox();
            label5 = new Label();
            createbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(267, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 41);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Location = new Point(350, 221);
            panel3.Name = "panel3";
            panel3.Size = new Size(161, 2);
            panel3.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Location = new Point(353, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 2);
            panel2.TabIndex = 14;
            // 
            // emailtext
            // 
            emailtext.BackColor = Color.FromArgb(44, 62, 80);
            emailtext.BorderStyle = BorderStyle.None;
            emailtext.Font = new Font("Segoe UI", 10.8F);
            emailtext.ForeColor = SystemColors.ActiveCaptionText;
            emailtext.Location = new Point(350, 196);
            emailtext.Name = "emailtext";
            emailtext.Size = new Size(161, 24);
            emailtext.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(180, 203);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 13;
            label4.Text = "Email";
            // 
            // phonetext
            // 
            phonetext.BackColor = Color.FromArgb(44, 62, 80);
            phonetext.BorderStyle = BorderStyle.None;
            phonetext.Font = new Font("Segoe UI", 10.8F);
            phonetext.ForeColor = SystemColors.ActiveCaptionText;
            phonetext.Location = new Point(353, 132);
            phonetext.Name = "phonetext";
            phonetext.Size = new Size(158, 24);
            phonetext.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(180, 140);
            label2.Name = "label2";
            label2.Size = new Size(132, 19);
            label2.TabIndex = 12;
            label2.Text = "Phone Number";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Location = new Point(353, 280);
            panel4.Name = "panel4";
            panel4.Size = new Size(158, 2);
            panel4.TabIndex = 20;
            // 
            // passtext
            // 
            passtext.BackColor = Color.FromArgb(44, 62, 80);
            passtext.BorderStyle = BorderStyle.None;
            passtext.Font = new Font("Segoe UI", 10.8F);
            passtext.ForeColor = SystemColors.ActiveCaptionText;
            passtext.Location = new Point(353, 255);
            passtext.Name = "passtext";
            passtext.PasswordChar = '*';
            passtext.Size = new Size(158, 24);
            passtext.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(180, 263);
            label5.Name = "label5";
            label5.Size = new Size(87, 19);
            label5.TabIndex = 18;
            label5.Text = "Password";
            // 
            // createbtn
            // 
            createbtn.BackColor = Color.FromArgb(44, 62, 80);
            createbtn.FlatAppearance.BorderSize = 0;
            createbtn.FlatStyle = FlatStyle.Flat;
            createbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createbtn.ForeColor = Color.White;
            createbtn.Location = new Point(213, 349);
            createbtn.Name = "createbtn";
            createbtn.Size = new Size(268, 39);
            createbtn.TabIndex = 22;
            createbtn.Text = "Create Account";
            createbtn.UseVisualStyleBackColor = false;
            createbtn.Click += createbtn_Click;
            // 
            // Sign_up
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(631, 484);
            Controls.Add(createbtn);
            Controls.Add(panel4);
            Controls.Add(passtext);
            Controls.Add(label5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(emailtext);
            Controls.Add(label4);
            Controls.Add(phonetext);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sign_up";
            Text = "Sign_up";
            Load += Sign_up_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private TextBox emailtext;
        private Label label4;
        private TextBox phonetext;
        private Label label2;
        private Panel panel4;
        private TextBox passtext;
        private Label label5;
        private Button createbtn;
    }
}
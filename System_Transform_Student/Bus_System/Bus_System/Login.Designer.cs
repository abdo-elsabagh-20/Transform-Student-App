namespace Bus_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            phonetext = new TextBox();
            passwordtext = new TextBox();
            linkLabel1 = new LinkLabel();
            loginbutton = new Button();
            resetbutton = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(44, 62, 80);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(369, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(44, 62, 80);
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(202, 249);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 2;
            label2.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(44, 62, 80);
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(204, 311);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // phonetext
            // 
            phonetext.BackColor = Color.FromArgb(44, 62, 80);
            phonetext.BorderStyle = BorderStyle.None;
            phonetext.Font = new Font("Segoe UI", 10.8F);
            phonetext.ForeColor = SystemColors.ActiveCaptionText;
            phonetext.Location = new Point(392, 241);
            phonetext.Name = "phonetext";
            phonetext.Size = new Size(158, 24);
            phonetext.TabIndex = 1;
            phonetext.TextChanged += phonetext_TextChanged;
            // 
            // passwordtext
            // 
            passwordtext.BackColor = Color.FromArgb(44, 62, 80);
            passwordtext.BorderStyle = BorderStyle.None;
            passwordtext.Font = new Font("Segoe UI", 10.8F);
            passwordtext.ForeColor = SystemColors.ActiveCaptionText;
            passwordtext.Location = new Point(389, 305);
            passwordtext.Name = "passwordtext";
            passwordtext.PasswordChar = '*';
            passwordtext.Size = new Size(161, 24);
            passwordtext.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = SystemColors.Control;
            linkLabel1.Location = new Point(438, 464);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(144, 23);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create Account ?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // loginbutton
            // 
            loginbutton.BackColor = Color.FromArgb(44, 62, 80);
            loginbutton.FlatAppearance.BorderSize = 0;
            loginbutton.FlatStyle = FlatStyle.Flat;
            loginbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            loginbutton.ForeColor = Color.White;
            loginbutton.Location = new Point(300, 400);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(94, 36);
            loginbutton.TabIndex = 6;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // resetbutton
            // 
            resetbutton.BackColor = Color.FromArgb(44, 62, 80);
            resetbutton.FlatAppearance.BorderSize = 0;
            resetbutton.FlatStyle = FlatStyle.Flat;
            resetbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            resetbutton.ForeColor = Color.White;
            resetbutton.Location = new Point(420, 401);
            resetbutton.Name = "resetbutton";
            resetbutton.Size = new Size(94, 35);
            resetbutton.TabIndex = 7;
            resetbutton.Text = "Reset";
            resetbutton.UseVisualStyleBackColor = false;
            resetbutton.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Location = new Point(392, 267);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 2);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Location = new Point(389, 331);
            panel3.Name = "panel3";
            panel3.Size = new Size(161, 2);
            panel3.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(331, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(736, 0);
            label7.Name = "label7";
            label7.Size = new Size(35, 38);
            label7.TabIndex = 23;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(44, 62, 80);
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(266, 467);
            label3.Name = "label3";
            label3.Size = new Size(166, 18);
            label3.TabIndex = 24;
            label3.Text = "Don‘t Have Account !";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(772, 554);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(resetbutton);
            Controls.Add(loginbutton);
            Controls.Add(linkLabel1);
            Controls.Add(passwordtext);
            Controls.Add(label4);
            Controls.Add(phonetext);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label1;
        private Label label2;
        private TextBox phonetext;
        private TextBox passwordtext;
        private LinkLabel linkLabel1;
        private Button loginbutton;
        private Button resetbutton;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label3;
    }
}
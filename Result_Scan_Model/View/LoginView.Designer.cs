namespace Result_Scan_Model.View
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            tableLayoutPanel1 = new TableLayoutPanel();
            panelLogin = new Panel();
            btnExit = new Button();
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            hiddenPass = new PictureBox();
            txtNIK = new TextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtPassword = new TextBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hiddenPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(panelLogin, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(1405, 843);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(241, 248, 233);
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(btnExit);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(label1);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(284, 129);
            panelLogin.Name = "panelLogin";
            panelLogin.Padding = new Padding(6);
            panelLogin.Size = new Size(837, 584);
            panelLogin.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.AutoSize = true;
            btnExit.BackColor = Color.FromArgb(231, 76, 60);
            btnExit.Font = new Font("PUDHinban M", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btnExit.Location = new Point(502, 440);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 75);
            btnExit.TabIndex = 12;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.AutoSize = true;
            btnLogin.BackColor = Color.FromArgb(39, 174, 96);
            btnLogin.Font = new Font("PUDHinban M", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btnLogin.Location = new Point(193, 440);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 75);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(59, 59, 59);
            label2.Location = new Point(6, 74);
            label2.Name = "label2";
            label2.Size = new Size(823, 53);
            label2.TabIndex = 2;
            label2.Text = "Laundry System Business Unit";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(59, 59, 59);
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(823, 68);
            label1.TabIndex = 1;
            label1.Text = "SCAN PART MOTOR WASH";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hiddenPass
            // 
            hiddenPass.Anchor = AnchorStyles.None;
            hiddenPass.BackColor = Color.FromArgb(241, 248, 233);
            hiddenPass.Cursor = Cursors.Hand;
            hiddenPass.Image = Properties.Resources.show;
            hiddenPass.InitialImage = (Image)resources.GetObject("hiddenPass.InitialImage");
            hiddenPass.Location = new Point(886, 443);
            hiddenPass.Margin = new Padding(3, 4, 3, 4);
            hiddenPass.Name = "hiddenPass";
            hiddenPass.Size = new Size(40, 41);
            hiddenPass.TabIndex = 18;
            hiddenPass.TabStop = false;
            hiddenPass.Click += hiddenPass_Click;
            // 
            // txtNIK
            // 
            txtNIK.Anchor = AnchorStyles.None;
            txtNIK.BackColor = Color.FromArgb(241, 248, 233);
            txtNIK.BorderStyle = BorderStyle.None;
            txtNIK.Font = new Font("Arial", 15.75F);
            txtNIK.Location = new Point(530, 350);
            txtNIK.Margin = new Padding(3, 4, 3, 4);
            txtNIK.Name = "txtNIK";
            txtNIK.PlaceholderText = "NIK";
            txtNIK.Size = new Size(397, 31);
            txtNIK.TabIndex = 13;
            txtNIK.KeyDown += txtNIK_KeyDown;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Location = new Point(530, 494);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(397, 4);
            panel2.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(530, 392);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 4);
            panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.FromArgb(241, 248, 233);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(477, 344);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.FromArgb(241, 248, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Arial", 15.75F);
            txtPassword.Location = new Point(530, 451);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(397, 31);
            txtPassword.TabIndex = 14;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.FromArgb(241, 248, 233);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(477, 448);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1405, 843);
            Controls.Add(hiddenPass);
            Controls.Add(txtNIK);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(pictureBox2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hiddenPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelLogin;
        private Label label1;
        private Label label2;
        private Button btnExit;
        private Button btnLogin;
        private PictureBox hiddenPass;
        private TextBox txtNIK;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtPassword;
        private PictureBox pictureBox2;
    }
}
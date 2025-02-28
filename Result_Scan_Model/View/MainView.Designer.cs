
namespace Result_Scan_Model
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            panel1 = new Panel();
            Maximizeimg = new PictureBox();
            Minimizeimg = new PictureBox();
            Closeimg = new PictureBox();
            lblFormTitle = new Label();
            buttonScan = new Button();
            buttonRecord = new Button();
            buttonSetting = new Button();
            labelTitle = new Label();
            panel2 = new Panel();
            panelView = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button2 = new Button();
            btnAbout = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            lblUser = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Maximizeimg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minimizeimg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Closeimg).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Maximizeimg);
            panel1.Controls.Add(Minimizeimg);
            panel1.Controls.Add(Closeimg);
            panel1.Controls.Add(lblFormTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 53);
            panel1.TabIndex = 0;
            // 
            // Maximizeimg
            // 
            Maximizeimg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Maximizeimg.BorderStyle = BorderStyle.Fixed3D;
            Maximizeimg.Image = (Image)resources.GetObject("Maximizeimg.Image");
            Maximizeimg.Location = new Point(1513, 5);
            Maximizeimg.Name = "Maximizeimg";
            Maximizeimg.Size = new Size(38, 38);
            Maximizeimg.SizeMode = PictureBoxSizeMode.CenterImage;
            Maximizeimg.TabIndex = 2;
            Maximizeimg.TabStop = false;
            Maximizeimg.Click += Maximizeimg_Click;
            // 
            // Minimizeimg
            // 
            Minimizeimg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Minimizeimg.BorderStyle = BorderStyle.Fixed3D;
            Minimizeimg.Image = (Image)resources.GetObject("Minimizeimg.Image");
            Minimizeimg.Location = new Point(1469, 5);
            Minimizeimg.Name = "Minimizeimg";
            Minimizeimg.Size = new Size(38, 38);
            Minimizeimg.SizeMode = PictureBoxSizeMode.CenterImage;
            Minimizeimg.TabIndex = 3;
            Minimizeimg.TabStop = false;
            Minimizeimg.Click += Minimizeimg_Click;
            // 
            // Closeimg
            // 
            Closeimg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Closeimg.BorderStyle = BorderStyle.Fixed3D;
            Closeimg.Image = (Image)resources.GetObject("Closeimg.Image");
            Closeimg.Location = new Point(1557, 5);
            Closeimg.Name = "Closeimg";
            Closeimg.Size = new Size(38, 38);
            Closeimg.SizeMode = PictureBoxSizeMode.CenterImage;
            Closeimg.TabIndex = 4;
            Closeimg.TabStop = false;
            Closeimg.Click += pictureBox2_Click_1;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.Image = Properties.Resources.icons8_clothes_in_laundry_48;
            lblFormTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblFormTitle.Location = new Point(-1, -1);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(174, 53);
            lblFormTitle.TabIndex = 1;
            lblFormTitle.Text = "LSBU";
            lblFormTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonScan
            // 
            buttonScan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonScan.BackColor = Color.MediumSeaGreen;
            buttonScan.FlatAppearance.BorderColor = Color.White;
            buttonScan.FlatAppearance.MouseDownBackColor = Color.Red;
            buttonScan.FlatAppearance.MouseOverBackColor = Color.Red;
            buttonScan.Font = new Font("Arial", 16F, FontStyle.Bold);
            buttonScan.ForeColor = Color.FromArgb(241, 248, 233);
            buttonScan.Image = Properties.Resources.icons8_barcode_50;
            buttonScan.ImageAlign = ContentAlignment.TopCenter;
            buttonScan.Location = new Point(0, 3);
            buttonScan.Margin = new Padding(0, 3, 0, 3);
            buttonScan.Name = "buttonScan";
            buttonScan.RightToLeft = RightToLeft.No;
            buttonScan.Size = new Size(200, 99);
            buttonScan.TabIndex = 2;
            buttonScan.Text = "Scan";
            buttonScan.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonScan.UseMnemonic = false;
            buttonScan.UseVisualStyleBackColor = false;
            buttonScan.Click += buttonScan_Click;
            // 
            // buttonRecord
            // 
            buttonRecord.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonRecord.BackColor = Color.MediumSeaGreen;
            buttonRecord.Font = new Font("Arial", 16F, FontStyle.Bold);
            buttonRecord.ForeColor = Color.FromArgb(241, 248, 233);
            buttonRecord.Image = Properties.Resources.icons8_rescan_document_50;
            buttonRecord.ImageAlign = ContentAlignment.TopCenter;
            buttonRecord.Location = new Point(0, 108);
            buttonRecord.Margin = new Padding(0, 3, 0, 3);
            buttonRecord.Name = "buttonRecord";
            buttonRecord.Size = new Size(200, 99);
            buttonRecord.TabIndex = 3;
            buttonRecord.Text = "Scan Record";
            buttonRecord.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonRecord.UseVisualStyleBackColor = false;
            buttonRecord.Click += buttonRecord_Click;
            // 
            // buttonSetting
            // 
            buttonSetting.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSetting.BackColor = Color.MediumSeaGreen;
            buttonSetting.Font = new Font("Arial", 18F, FontStyle.Bold);
            buttonSetting.ForeColor = Color.FromArgb(241, 248, 233);
            buttonSetting.Image = Properties.Resources.icons8_setting_50__1_;
            buttonSetting.ImageAlign = ContentAlignment.TopCenter;
            buttonSetting.Location = new Point(0, 213);
            buttonSetting.Margin = new Padding(0, 3, 0, 3);
            buttonSetting.Name = "buttonSetting";
            buttonSetting.Size = new Size(200, 99);
            buttonSetting.TabIndex = 4;
            buttonSetting.Text = "Setting";
            buttonSetting.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonSetting.UseVisualStyleBackColor = false;
            buttonSetting.Click += buttonSetting_Click;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.FromArgb(241, 248, 233);
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(1394, 41);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Title Page";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelTitle);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1394, 41);
            panel2.TabIndex = 3;
            // 
            // panelView
            // 
            panelView.Dock = DockStyle.Fill;
            panelView.Location = new Point(3, 50);
            panelView.Name = "panelView";
            panelView.Size = new Size(1394, 709);
            panelView.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(157, 193, 131);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button2, 0, 5);
            tableLayoutPanel1.Controls.Add(buttonSetting, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonRecord, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonScan, 0, 0);
            tableLayoutPanel1.Controls.Add(btnAbout, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(200, 762);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 77, 77);
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Arial", 16F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.icons8_logout_50;
            button2.Location = new Point(3, 595);
            button2.Name = "button2";
            button2.Size = new Size(194, 114);
            button2.TabIndex = 0;
            button2.Text = "LOGOUT";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.DodgerBlue;
            btnAbout.Dock = DockStyle.Fill;
            btnAbout.Font = new Font("Arial", 16F, FontStyle.Bold);
            btnAbout.ForeColor = Color.White;
            btnAbout.Image = Properties.Resources.icons8_about_50;
            btnAbout.Location = new Point(3, 490);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(194, 99);
            btnAbout.TabIndex = 5;
            btnAbout.Text = "ABOUT";
            btnAbout.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAbout.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(241, 248, 233);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panelView, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1400, 762);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(157, 193, 131);
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.625F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.875F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(lblUser, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 53);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1600, 85);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Arial", 30F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(241, 248, 233);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(724, 85);
            label2.TabIndex = 0;
            label2.Text = "SCAN PART MOTOR WASH";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Fill;
            lblUser.Font = new Font("Arial", 15F, FontStyle.Bold);
            lblUser.ForeColor = Color.FromArgb(241, 248, 233);
            lblUser.ImageAlign = ContentAlignment.TopCenter;
            lblUser.Location = new Point(1285, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(312, 85);
            lblUser.TabIndex = 1;
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 138);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 762);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(200, 138);
            panel4.Name = "panel4";
            panel4.Size = new Size(1400, 762);
            panel4.TabIndex = 9;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Maximizeimg).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minimizeimg).EndInit();
            ((System.ComponentModel.ISupportInitialize)Closeimg).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblFormTitle;
        private PictureBox Maximizeimg;
        private PictureBox Minimizeimg;
        private PictureBox Closeimg;
        private Button buttonScan;
        private Button buttonRecord;
        private Button buttonSetting;
        private Label labelTitle;
        private Panel panel2;
        private Panel panelView;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Label lblUser;
        private Button button2;
        private Button btnAbout;
    }
}

namespace Result_Scan_Model.View
{
    partial class SettingView
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
            lblSetting = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnOn = new RadioButton();
            btnOff = new RadioButton();
            btnPreview = new RadioButton();
            btnCancel = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnConnect = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblActivated = new Label();
            checkBox = new CheckBox();
            lblPrintMode = new Label();
            lblCameraIp = new Label();
            lblCameraPort = new Label();
            lblLocation = new Label();
            lblProduct = new Label();
            JPBox = new ComboBox();
            locationBox = new ComboBox();
            label7 = new Label();
            textBoxPort = new TextBox();
            textBoxIP = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblSetting
            // 
            lblSetting.BackColor = Color.White;
            lblSetting.Dock = DockStyle.Top;
            lblSetting.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSetting.Location = new Point(0, 0);
            lblSetting.Name = "lblSetting";
            lblSetting.Size = new Size(752, 44);
            lblSetting.TabIndex = 4;
            lblSetting.Text = "Setting";
            lblSetting.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnOn);
            flowLayoutPanel1.Controls.Add(btnOff);
            flowLayoutPanel1.Controls.Add(btnPreview);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(223, 55);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 0, 0, 0);
            flowLayoutPanel1.Size = new Size(361, 46);
            flowLayoutPanel1.TabIndex = 15;
            flowLayoutPanel1.WrapContents = false;
            // 
            // btnOn
            // 
            btnOn.AutoSize = true;
            btnOn.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOn.Location = new Point(13, 4);
            btnOn.Margin = new Padding(3, 4, 3, 4);
            btnOn.Name = "btnOn";
            btnOn.Size = new Size(83, 43);
            btnOn.TabIndex = 14;
            btnOn.TabStop = true;
            btnOn.Text = "On";
            btnOn.UseVisualStyleBackColor = true;
            btnOn.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // btnOff
            // 
            btnOff.AutoSize = true;
            btnOff.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOff.Location = new Point(102, 4);
            btnOff.Margin = new Padding(3, 4, 3, 4);
            btnOff.Name = "btnOff";
            btnOff.Size = new Size(83, 43);
            btnOff.TabIndex = 13;
            btnOff.TabStop = true;
            btnOff.Text = "Off";
            btnOff.UseVisualStyleBackColor = true;
            btnOff.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // btnPreview
            // 
            btnPreview.AutoSize = true;
            btnPreview.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPreview.Location = new Point(191, 4);
            btnPreview.Margin = new Padding(3, 4, 3, 4);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(155, 43);
            btnPreview.TabIndex = 12;
            btnPreview.TabStop = true;
            btnPreview.Text = "Preview";
            btnPreview.TextAlign = ContentAlignment.MiddleRight;
            btnPreview.UseVisualStyleBackColor = true;
            btnPreview.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.Red;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = Properties.Resources.icons8_disconnected_48;
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(333, 113);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(213, 61);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btnCancel, 1, 0);
            tableLayoutPanel4.Controls.Add(btnConnect, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(4, 421);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(587, 288);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // btnConnect
            // 
            btnConnect.Anchor = AnchorStyles.None;
            btnConnect.BackColor = Color.FromArgb(27, 60, 115);
            btnConnect.Cursor = Cursors.Hand;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnConnect.ForeColor = Color.White;
            btnConnect.Image = Properties.Resources.icons8_connected_48;
            btnConnect.Location = new Point(40, 113);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(213, 61);
            btnConnect.TabIndex = 27;
            btnConnect.Text = "Connect";
            btnConnect.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(78, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 58.7078667F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 41.2921333F));
            tableLayoutPanel3.Size = new Size(595, 713);
            tableLayoutPanel3.TabIndex = 29;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Controls.Add(lblActivated, 0, 0);
            tableLayoutPanel1.Controls.Add(checkBox, 1, 0);
            tableLayoutPanel1.Controls.Add(lblPrintMode, 0, 1);
            tableLayoutPanel1.Controls.Add(lblCameraIp, 0, 2);
            tableLayoutPanel1.Controls.Add(lblCameraPort, 0, 3);
            tableLayoutPanel1.Controls.Add(lblLocation, 0, 6);
            tableLayoutPanel1.Controls.Add(lblProduct, 0, 7);
            tableLayoutPanel1.Controls.Add(JPBox, 1, 7);
            tableLayoutPanel1.Controls.Add(locationBox, 1, 6);
            tableLayoutPanel1.Controls.Add(label7, 1, 4);
            tableLayoutPanel1.Controls.Add(textBoxPort, 1, 3);
            tableLayoutPanel1.Controls.Add(textBoxIP, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(587, 410);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblActivated
            // 
            lblActivated.AutoSize = true;
            lblActivated.Dock = DockStyle.Left;
            lblActivated.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActivated.ImageAlign = ContentAlignment.MiddleLeft;
            lblActivated.Location = new Point(3, 0);
            lblActivated.Name = "lblActivated";
            lblActivated.Size = new Size(213, 52);
            lblActivated.TabIndex = 1;
            lblActivated.Text = "Actived Setting";
            lblActivated.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Cursor = Cursors.Hand;
            checkBox.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox.Location = new Point(223, 4);
            checkBox.Margin = new Padding(3, 4, 3, 4);
            checkBox.Name = "checkBox";
            checkBox.Padding = new Padding(10, 0, 0, 0);
            checkBox.Size = new Size(177, 43);
            checkBox.TabIndex = 14;
            checkBox.Text = "checklist";
            checkBox.TextImageRelation = TextImageRelation.ImageBeforeText;
            checkBox.UseVisualStyleBackColor = true;
            checkBox.CheckedChanged += checkBox_CheckedChanged;
            // 
            // lblPrintMode
            // 
            lblPrintMode.AutoSize = true;
            lblPrintMode.Dock = DockStyle.Left;
            lblPrintMode.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrintMode.Location = new Point(3, 52);
            lblPrintMode.Name = "lblPrintMode";
            lblPrintMode.Size = new Size(155, 52);
            lblPrintMode.TabIndex = 15;
            lblPrintMode.Text = "Print Mode";
            lblPrintMode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCameraIp
            // 
            lblCameraIp.AutoSize = true;
            lblCameraIp.Dock = DockStyle.Left;
            lblCameraIp.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            lblCameraIp.Location = new Point(3, 104);
            lblCameraIp.Name = "lblCameraIp";
            lblCameraIp.Size = new Size(150, 52);
            lblCameraIp.TabIndex = 16;
            lblCameraIp.Text = "Camera IP";
            lblCameraIp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCameraPort
            // 
            lblCameraPort.AutoSize = true;
            lblCameraPort.Dock = DockStyle.Left;
            lblCameraPort.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            lblCameraPort.Location = new Point(3, 156);
            lblCameraPort.Name = "lblCameraPort";
            lblCameraPort.Size = new Size(179, 52);
            lblCameraPort.TabIndex = 17;
            lblCameraPort.Text = "Camera Port";
            lblCameraPort.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Dock = DockStyle.Left;
            lblLocation.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            lblLocation.Location = new Point(3, 260);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(129, 52);
            lblLocation.TabIndex = 21;
            lblLocation.Text = "Location";
            lblLocation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Dock = DockStyle.Left;
            lblProduct.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            lblProduct.Location = new Point(3, 312);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(187, 52);
            lblProduct.TabIndex = 22;
            lblProduct.Text = "Jenis Produk";
            lblProduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // JPBox
            // 
            JPBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            JPBox.DropDownStyle = ComboBoxStyle.DropDownList;
            JPBox.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JPBox.FormattingEnabled = true;
            JPBox.Location = new Point(223, 316);
            JPBox.Margin = new Padding(3, 4, 3, 4);
            JPBox.Name = "JPBox";
            JPBox.Size = new Size(361, 41);
            JPBox.TabIndex = 25;
            // 
            // locationBox
            // 
            locationBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            locationBox.DropDownStyle = ComboBoxStyle.DropDownList;
            locationBox.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            locationBox.FormattingEnabled = true;
            locationBox.Location = new Point(223, 264);
            locationBox.Margin = new Padding(3, 4, 3, 4);
            locationBox.Name = "locationBox";
            locationBox.Size = new Size(361, 41);
            locationBox.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(223, 208);
            label7.Name = "label7";
            label7.Size = new Size(337, 26);
            label7.TabIndex = 20;
            label7.Text = "*Click button Connect after change IP/Port";
            // 
            // textBoxPort
            // 
            textBoxPort.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPort.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPort.Location = new Point(223, 160);
            textBoxPort.Margin = new Padding(3, 4, 3, 4);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(361, 37);
            textBoxPort.TabIndex = 19;
            // 
            // textBoxIP
            // 
            textBoxIP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxIP.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxIP.Location = new Point(223, 108);
            textBoxIP.Margin = new Padding(3, 4, 3, 4);
            textBoxIP.Name = "textBoxIP";
            textBoxIP.Size = new Size(361, 37);
            textBoxIP.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AccessibleRole = AccessibleRole.TitleBar;
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 47);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel2.Size = new Size(752, 763);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // SettingView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(752, 810);
            Controls.Add(lblSetting);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingView";
            Text = "Setting";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblSetting;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton btnOn;
        private RadioButton btnOff;
        private RadioButton btnPreview;
        private Button btnCancel;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnConnect;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblActivated;
        private CheckBox checkBox;
        private Label lblPrintMode;
        private Label lblCameraIp;
        private Label lblCameraPort;
        private Label lblLocation;
        private Label lblProduct;
        private ComboBox JPBox;
        private ComboBox locationBox;
        private Label label7;
        private TextBox textBoxPort;
        private TextBox textBoxIP;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
﻿using System.Diagnostics;

namespace Result_Scan_Model.View
{
    partial class ScanView
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
            if (disposing)
            {
                _presenter.StopListening();
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanView));
            cbModelNumber = new ComboBox();
            labelScan = new Label();
            labelStatus = new Label();
            labelInspector = new Label();
            label3 = new Label();
            lblPartNumber = new Label();
            txtPartNumber = new TextBox();
            txtInspector = new TextBox();
            txtStatus = new TextBox();
            labelOK = new Label();
            tableLayoutView = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutDateTime = new TableLayoutPanel();
            lblTime = new Label();
            lblDate = new Label();
            tableLayoutBtn = new TableLayoutPanel();
            btnClear = new Button();
            btnManual = new Button();
            tableLayoutInput = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            txtScanPartCode = new TextBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblPartNumberId = new Label();
            txtPartNumberId = new TextBox();
            labelLastScan = new Label();
            txtLastScan = new TextBox();
            tableLayoutOK_NG = new TableLayoutPanel();
            labelNG = new Label();
            pictureBox4 = new PictureBox();
            tableLayoutView.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutDateTime.SuspendLayout();
            tableLayoutBtn.SuspendLayout();
            tableLayoutInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutOK_NG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // cbModelNumber
            // 
            cbModelNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbModelNumber.BackColor = SystemColors.ActiveBorder;
            cbModelNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cbModelNumber.FlatStyle = FlatStyle.Popup;
            cbModelNumber.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbModelNumber.FormattingEnabled = true;
            cbModelNumber.Location = new Point(291, 99);
            cbModelNumber.Name = "cbModelNumber";
            cbModelNumber.Size = new Size(500, 43);
            cbModelNumber.TabIndex = 2;
            // 
            // labelScan
            // 
            labelScan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelScan.AutoSize = true;
            labelScan.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelScan.Location = new Point(53, 0);
            labelScan.Name = "labelScan";
            labelScan.Size = new Size(232, 48);
            labelScan.TabIndex = 3;
            labelScan.Text = "Scan Part Code";
            labelScan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelStatus
            // 
            labelStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStatus.Location = new Point(53, 288);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(232, 50);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "Status";
            labelStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelInspector
            // 
            labelInspector.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelInspector.AutoSize = true;
            labelInspector.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInspector.Location = new Point(53, 240);
            labelInspector.Name = "labelInspector";
            labelInspector.Size = new Size(232, 48);
            labelInspector.TabIndex = 5;
            labelInspector.Text = "Inspector";
            labelInspector.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 96);
            label3.Name = "label3";
            label3.Size = new Size(232, 48);
            label3.TabIndex = 6;
            label3.Text = "Model Number";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPartNumber
            // 
            lblPartNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPartNumber.AutoSize = true;
            lblPartNumber.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPartNumber.Location = new Point(53, 192);
            lblPartNumber.Name = "lblPartNumber";
            lblPartNumber.Size = new Size(232, 48);
            lblPartNumber.TabIndex = 7;
            lblPartNumber.Text = "Part Number";
            lblPartNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPartNumber
            // 
            txtPartNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPartNumber.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPartNumber.Location = new Point(291, 195);
            txtPartNumber.Name = "txtPartNumber";
            txtPartNumber.ReadOnly = true;
            txtPartNumber.Size = new Size(500, 42);
            txtPartNumber.TabIndex = 9;
            // 
            // txtInspector
            // 
            txtInspector.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtInspector.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInspector.Location = new Point(291, 243);
            txtInspector.Name = "txtInspector";
            txtInspector.ReadOnly = true;
            txtInspector.Size = new Size(500, 42);
            txtInspector.TabIndex = 10;
            // 
            // txtStatus
            // 
            txtStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatus.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStatus.Location = new Point(291, 291);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(500, 42);
            txtStatus.TabIndex = 11;
            // 
            // labelOK
            // 
            labelOK.Anchor = AnchorStyles.None;
            labelOK.BackColor = SystemColors.ButtonShadow;
            labelOK.BorderStyle = BorderStyle.FixedSingle;
            labelOK.Cursor = Cursors.No;
            labelOK.FlatStyle = FlatStyle.Popup;
            labelOK.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOK.Image = (Image)resources.GetObject("labelOK.Image");
            labelOK.Location = new Point(158, 64);
            labelOK.Name = "labelOK";
            labelOK.Size = new Size(275, 290);
            labelOK.TabIndex = 15;
            labelOK.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutView
            // 
            tableLayoutView.BackColor = Color.FromArgb(241, 248, 233);
            tableLayoutView.ColumnCount = 3;
            tableLayoutView.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutView.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutView.Controls.Add(tableLayoutPanel5, 1, 1);
            tableLayoutView.Controls.Add(tableLayoutOK_NG, 1, 2);
            tableLayoutView.Dock = DockStyle.Fill;
            tableLayoutView.Location = new Point(0, 0);
            tableLayoutView.Name = "tableLayoutView";
            tableLayoutView.RowCount = 3;
            tableLayoutView.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutView.RowStyles.Add(new RowStyle(SizeType.Absolute, 350F));
            tableLayoutView.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutView.Size = new Size(1228, 794);
            tableLayoutView.TabIndex = 17;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.68189F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.3181038F));
            tableLayoutPanel5.Controls.Add(tableLayoutDateTime, 1, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutInput, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(23, 23);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(1182, 344);
            tableLayoutPanel5.TabIndex = 18;
            // 
            // tableLayoutDateTime
            // 
            tableLayoutDateTime.ColumnCount = 1;
            tableLayoutDateTime.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutDateTime.Controls.Add(lblTime, 0, 1);
            tableLayoutDateTime.Controls.Add(lblDate, 0, 0);
            tableLayoutDateTime.Controls.Add(tableLayoutBtn, 0, 2);
            tableLayoutDateTime.Dock = DockStyle.Fill;
            tableLayoutDateTime.Location = new Point(803, 3);
            tableLayoutDateTime.Name = "tableLayoutDateTime";
            tableLayoutDateTime.RowCount = 3;
            tableLayoutDateTime.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutDateTime.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutDateTime.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutDateTime.Size = new Size(376, 338);
            tableLayoutDateTime.TabIndex = 17;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(3, 77);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(370, 46);
            lblTime.TabIndex = 14;
            lblTime.Text = "Time";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(3, 10);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(370, 46);
            lblDate.TabIndex = 13;
            lblDate.Text = "Date";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutBtn
            // 
            tableLayoutBtn.ColumnCount = 1;
            tableLayoutBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutBtn.Controls.Add(btnClear, 0, 1);
            tableLayoutBtn.Controls.Add(btnManual, 0, 0);
            tableLayoutBtn.Dock = DockStyle.Fill;
            tableLayoutBtn.Location = new Point(3, 137);
            tableLayoutBtn.Name = "tableLayoutBtn";
            tableLayoutBtn.RowCount = 2;
            tableLayoutBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutBtn.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutBtn.Size = new Size(370, 198);
            tableLayoutBtn.TabIndex = 15;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gold;
            btnClear.Dock = DockStyle.Fill;
            btnClear.Font = new Font("Segoe UI", 24F);
            btnClear.Image = Properties.Resources.icons8_clear_50;
            btnClear.ImageAlign = ContentAlignment.MiddleRight;
            btnClear.Location = new Point(3, 102);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(364, 93);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Visible = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnManual
            // 
            btnManual.BackColor = Color.LimeGreen;
            btnManual.Dock = DockStyle.Fill;
            btnManual.Font = new Font("Segoe UI", 24F);
            btnManual.Image = Properties.Resources.icons8_input_48;
            btnManual.ImageAlign = ContentAlignment.MiddleRight;
            btnManual.Location = new Point(3, 3);
            btnManual.Name = "btnManual";
            btnManual.Size = new Size(364, 93);
            btnManual.TabIndex = 12;
            btnManual.Text = "Input Manual";
            btnManual.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManual.UseVisualStyleBackColor = false;
            btnManual.Click += btnManual_Click_1;
            // 
            // tableLayoutInput
            // 
            tableLayoutInput.ColumnCount = 3;
            tableLayoutInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tableLayoutInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
            tableLayoutInput.Controls.Add(pictureBox4, 0, 1);
            tableLayoutInput.Controls.Add(pictureBox1, 0, 0);
            tableLayoutInput.Controls.Add(txtScanPartCode, 2, 0);
            tableLayoutInput.Controls.Add(labelScan, 1, 0);
            tableLayoutInput.Controls.Add(pictureBox5, 0, 6);
            tableLayoutInput.Controls.Add(pictureBox6, 0, 5);
            tableLayoutInput.Controls.Add(pictureBox9, 0, 4);
            tableLayoutInput.Controls.Add(pictureBox2, 0, 3);
            tableLayoutInput.Controls.Add(pictureBox3, 0, 2);
            tableLayoutInput.Controls.Add(labelStatus, 1, 6);
            tableLayoutInput.Controls.Add(labelInspector, 1, 5);
            tableLayoutInput.Controls.Add(lblPartNumber, 1, 4);
            tableLayoutInput.Controls.Add(lblPartNumberId, 1, 3);
            tableLayoutInput.Controls.Add(label3, 1, 2);
            tableLayoutInput.Controls.Add(txtStatus, 2, 6);
            tableLayoutInput.Controls.Add(txtInspector, 2, 5);
            tableLayoutInput.Controls.Add(txtPartNumber, 2, 4);
            tableLayoutInput.Controls.Add(txtPartNumberId, 2, 3);
            tableLayoutInput.Controls.Add(cbModelNumber, 2, 2);
            tableLayoutInput.Controls.Add(labelLastScan, 1, 1);
            tableLayoutInput.Controls.Add(txtLastScan, 2, 1);
            tableLayoutInput.Dock = DockStyle.Fill;
            tableLayoutInput.Location = new Point(3, 3);
            tableLayoutInput.Name = "tableLayoutInput";
            tableLayoutInput.RowCount = 7;
            tableLayoutInput.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853F));
            tableLayoutInput.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285306F));
            tableLayoutInput.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285306F));
            tableLayoutInput.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285306F));
            tableLayoutInput.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285306F));
            tableLayoutInput.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285306F));
            tableLayoutInput.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2881651F));
            tableLayoutInput.Size = new Size(794, 338);
            tableLayoutInput.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // txtScanPartCode
            // 
            txtScanPartCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtScanPartCode.CharacterCasing = CharacterCasing.Upper;
            txtScanPartCode.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtScanPartCode.Location = new Point(291, 3);
            txtScanPartCode.Name = "txtScanPartCode";
            txtScanPartCode.PlaceholderText = "Input Scan";
            txtScanPartCode.ReadOnly = true;
            txtScanPartCode.Size = new Size(500, 42);
            txtScanPartCode.TabIndex = 1;
            txtScanPartCode.KeyDown += txtScanPartCode_KeyDown;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 292);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 42);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 244);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(44, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(3, 196);
            pictureBox9.Margin = new Padding(3, 4, 3, 4);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(44, 40);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 22;
            pictureBox9.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 148);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 100);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // lblPartNumberId
            // 
            lblPartNumberId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPartNumberId.AutoSize = true;
            lblPartNumberId.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPartNumberId.Location = new Point(53, 144);
            lblPartNumberId.Name = "lblPartNumberId";
            lblPartNumberId.Size = new Size(232, 48);
            lblPartNumberId.TabIndex = 12;
            lblPartNumberId.Text = "Part Number Id";
            lblPartNumberId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPartNumberId
            // 
            txtPartNumberId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPartNumberId.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPartNumberId.Location = new Point(291, 147);
            txtPartNumberId.Name = "txtPartNumberId";
            txtPartNumberId.ReadOnly = true;
            txtPartNumberId.Size = new Size(500, 42);
            txtPartNumberId.TabIndex = 13;
            // 
            // labelLastScan
            // 
            labelLastScan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelLastScan.AutoSize = true;
            labelLastScan.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLastScan.Location = new Point(53, 48);
            labelLastScan.Name = "labelLastScan";
            labelLastScan.Size = new Size(232, 48);
            labelLastScan.TabIndex = 25;
            labelLastScan.Text = "Last Scan";
            labelLastScan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLastScan
            // 
            txtLastScan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLastScan.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastScan.Location = new Point(291, 51);
            txtLastScan.Name = "txtLastScan";
            txtLastScan.ReadOnly = true;
            txtLastScan.Size = new Size(500, 42);
            txtLastScan.TabIndex = 26;
            // 
            // tableLayoutOK_NG
            // 
            tableLayoutOK_NG.BackColor = Color.MediumSeaGreen;
            tableLayoutOK_NG.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial;
            tableLayoutOK_NG.ColumnCount = 2;
            tableLayoutOK_NG.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutOK_NG.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutOK_NG.Controls.Add(labelNG, 1, 0);
            tableLayoutOK_NG.Controls.Add(labelOK, 0, 0);
            tableLayoutOK_NG.Dock = DockStyle.Fill;
            tableLayoutOK_NG.Location = new Point(23, 373);
            tableLayoutOK_NG.Name = "tableLayoutOK_NG";
            tableLayoutOK_NG.RowCount = 1;
            tableLayoutOK_NG.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutOK_NG.Size = new Size(1182, 418);
            tableLayoutOK_NG.TabIndex = 19;
            // 
            // labelNG
            // 
            labelNG.Anchor = AnchorStyles.None;
            labelNG.BackColor = SystemColors.ButtonShadow;
            labelNG.BorderStyle = BorderStyle.FixedSingle;
            labelNG.Cursor = Cursors.No;
            labelNG.FlatStyle = FlatStyle.Popup;
            labelNG.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNG.Image = (Image)resources.GetObject("labelNG.Image");
            labelNG.Location = new Point(748, 64);
            labelNG.Name = "labelNG";
            labelNG.Size = new Size(275, 290);
            labelNG.TabIndex = 16;
            labelNG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 52);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // ScanView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(tableLayoutView);
            Name = "ScanView";
            Size = new Size(1228, 794);
            tableLayoutView.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutDateTime.ResumeLayout(false);
            tableLayoutDateTime.PerformLayout();
            tableLayoutBtn.ResumeLayout(false);
            tableLayoutInput.ResumeLayout(false);
            tableLayoutInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutOK_NG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cbModelNumber;
        private Label labelScan;
        private Label labelStatus;
        private Label labelInspector;
        private Label label3;
        private Label lblPartNumber;
        private TextBox txtPartNumber;
        private TextBox txtInspector;
        private TextBox txtStatus;
        private Label labelOK;
        private TableLayoutPanel tableLayoutView;
        private TableLayoutPanel tableLayoutInput;
        private TextBox txtScanPartCode;
        private TextBox txtPartNumberId;
        private Label lblPartNumberId;
        private TableLayoutPanel tableLayoutDateTime;
        private Label lblTime;
        private Label lblDate;
        private TableLayoutPanel tableLayoutBtn;
        private Button btnClear;
        private Button btnManual;
        private Label labelNG;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutOK_NG;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox9;
        private Label labelLastScan;
        private TextBox txtLastScan;
        private PictureBox pictureBox4;
    }
}
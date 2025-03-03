namespace Result_Scan_Model.View
{
    partial class ResultView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultView));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnSearch = new Button();
            btnClear2 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBox7 = new PictureBox();
            textBoxSearch = new TextBox();
            lblSearch = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox8 = new PictureBox();
            dtFromDate = new DateTimePicker();
            label13 = new Label();
            cbResult = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(241, 248, 233);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.647356F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.3526459F));
            tableLayoutPanel1.Size = new Size(1228, 794);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.74141F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2585926F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(btnSearch, 1, 1);
            tableLayoutPanel2.Controls.Add(btnClear2, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1222, 150);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(52, 199, 89);
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.Font = new Font("Microsoft Sans Serif", 18F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = Properties.Resources.icons8_search_64;
            btnSearch.ImageAlign = ContentAlignment.MiddleRight;
            btnSearch.Location = new Point(953, 78);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(266, 69);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "search";
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear2
            // 
            btnClear2.BackColor = Color.FromArgb(85, 85, 85);
            btnClear2.Dock = DockStyle.Fill;
            btnClear2.Font = new Font("Microsoft Sans Serif", 18F);
            btnClear2.ForeColor = Color.White;
            btnClear2.Image = Properties.Resources.icons8_clear_50;
            btnClear2.ImageAlign = ContentAlignment.MiddleRight;
            btnClear2.Location = new Point(953, 3);
            btnClear2.Name = "btnClear2";
            btnClear2.Size = new Size(266, 69);
            btnClear2.TabIndex = 21;
            btnClear2.Text = "clear search";
            btnClear2.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear2.UseVisualStyleBackColor = false;
            btnClear2.Click += btnClear2_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel3.Controls.Add(pictureBox7, 0, 0);
            tableLayoutPanel3.Controls.Add(textBoxSearch, 2, 0);
            tableLayoutPanel3.Controls.Add(lblSearch, 1, 0);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(944, 69);
            tableLayoutPanel3.TabIndex = 23;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(3, 4);
            pictureBox7.Margin = new Padding(3, 4, 0, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(57, 61);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.CharacterCasing = CharacterCasing.Upper;
            textBoxSearch.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(284, 13);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search...";
            textBoxSearch.Size = new Size(657, 42);
            textBoxSearch.TabIndex = 20;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblSearch.Location = new Point(63, 3);
            lblSearch.Margin = new Padding(3);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(215, 63);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search";
            lblSearch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 6;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel4.Controls.Add(pictureBox1, 3, 0);
            tableLayoutPanel4.Controls.Add(pictureBox8, 0, 0);
            tableLayoutPanel4.Controls.Add(dtFromDate, 2, 0);
            tableLayoutPanel4.Controls.Add(label13, 1, 0);
            tableLayoutPanel4.Controls.Add(cbResult, 5, 0);
            tableLayoutPanel4.Controls.Add(label1, 4, 0);
            tableLayoutPanel4.Location = new Point(3, 78);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(944, 69);
            tableLayoutPanel4.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(474, 4);
            pictureBox1.Margin = new Padding(3, 4, 0, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(3, 0);
            pictureBox8.Margin = new Padding(3, 0, 0, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(57, 65);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 17;
            pictureBox8.TabStop = false;
            // 
            // dtFromDate
            // 
            dtFromDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtFromDate.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFromDate.CustomFormat = "dd MMMM yyyy";
            dtFromDate.Font = new Font("Segoe UI", 18F);
            dtFromDate.Format = DateTimePickerFormat.Custom;
            dtFromDate.Location = new Point(161, 11);
            dtFromDate.Margin = new Padding(3, 0, 3, 0);
            dtFromDate.Name = "dtFromDate";
            dtFromDate.Size = new Size(307, 47);
            dtFromDate.TabIndex = 14;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 18F, FontStyle.Bold);
            label13.Location = new Point(63, 3);
            label13.Margin = new Padding(3);
            label13.Name = "label13";
            label13.Size = new Size(92, 63);
            label13.TabIndex = 19;
            label13.Text = "Date";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbResult
            // 
            cbResult.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbResult.DropDownStyle = ComboBoxStyle.DropDownList;
            cbResult.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbResult.FormattingEnabled = true;
            cbResult.Location = new Point(657, 13);
            cbResult.Name = "cbResult";
            cbResult.Size = new Size(284, 43);
            cbResult.TabIndex = 20;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold);
            label1.Location = new Point(534, 3);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(117, 63);
            label1.TabIndex = 21;
            label1.Text = "Result";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1222, 632);
            dataGridView1.TabIndex = 1;
            // 
            // ResultView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ResultView";
            Size = new Size(1228, 794);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private DateTimePicker dtFromDate;
        private TextBox textBoxSearch;
        private Label label13;
        private Label lblSearch;
        private Button btnSearch;
        private Button btnClear2;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private ComboBox cbResult;
        private Label label1;
        private PictureBox pictureBox1;
    }
}

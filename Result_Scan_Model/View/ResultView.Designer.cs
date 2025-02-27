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
            dtFromDate = new DateTimePicker();
            lblModelCode = new Label();
            textBoxSearch = new TextBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            label13 = new Label();
            btnClear2 = new Button();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
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
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(btnSearch, 3, 1);
            tableLayoutPanel2.Controls.Add(dtFromDate, 2, 1);
            tableLayoutPanel2.Controls.Add(lblModelCode, 1, 0);
            tableLayoutPanel2.Controls.Add(textBoxSearch, 2, 0);
            tableLayoutPanel2.Controls.Add(pictureBox8, 0, 1);
            tableLayoutPanel2.Controls.Add(pictureBox7, 0, 0);
            tableLayoutPanel2.Controls.Add(label13, 1, 1);
            tableLayoutPanel2.Controls.Add(btnClear2, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
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
            btnSearch.Location = new Point(876, 78);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(343, 69);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "search";
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtFromDate
            // 
            dtFromDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtFromDate.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFromDate.Font = new Font("Segoe UI", 18F);
            dtFromDate.Format = DateTimePickerFormat.Custom;
            dtFromDate.Location = new Point(295, 89);
            dtFromDate.Margin = new Padding(3, 0, 3, 0);
            dtFromDate.Name = "dtFromDate";
            dtFromDate.Size = new Size(575, 47);
            dtFromDate.TabIndex = 14;
            // 
            // lblModelCode
            // 
            lblModelCode.AutoSize = true;
            lblModelCode.Dock = DockStyle.Fill;
            lblModelCode.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblModelCode.Location = new Point(63, 3);
            lblModelCode.Margin = new Padding(3);
            lblModelCode.Name = "lblModelCode";
            lblModelCode.Size = new Size(226, 69);
            lblModelCode.TabIndex = 1;
            lblModelCode.Text = "Model Code";
            lblModelCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.CharacterCasing = CharacterCasing.Upper;
            textBoxSearch.Font = new Font("Arial", 18F);
            textBoxSearch.Location = new Point(295, 16);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search Model Code";
            textBoxSearch.Size = new Size(575, 42);
            textBoxSearch.TabIndex = 20;
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(3, 75);
            pictureBox8.Margin = new Padding(3, 0, 0, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(57, 71);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 17;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(3, 4);
            pictureBox7.Margin = new Padding(3, 4, 0, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(57, 67);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Arial", 18F, FontStyle.Bold);
            label13.Location = new Point(63, 78);
            label13.Margin = new Padding(3);
            label13.Name = "label13";
            label13.Size = new Size(226, 69);
            label13.TabIndex = 19;
            label13.Text = "Date";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClear2
            // 
            btnClear2.BackColor = Color.FromArgb(85, 85, 85);
            btnClear2.Dock = DockStyle.Fill;
            btnClear2.Font = new Font("Microsoft Sans Serif", 18F);
            btnClear2.ForeColor = Color.White;
            btnClear2.Image = Properties.Resources.icons8_clear_50;
            btnClear2.ImageAlign = ContentAlignment.MiddleRight;
            btnClear2.Location = new Point(876, 3);
            btnClear2.Name = "btnClear2";
            btnClear2.Size = new Size(343, 69);
            btnClear2.TabIndex = 21;
            btnClear2.Text = "clear search";
            btnClear2.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear2.UseVisualStyleBackColor = false;
            btnClear2.Click += btnClear2_Click;
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
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
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
        private Label lblModelCode;
        private Button btnSearch;
        private Button btnClear2;
        private DataGridView dataGridView1;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Result_Scan_Model.Model;
using Result_Scan_Model.Presenter;

namespace Result_Scan_Model.View
{
    public partial class ResultView : UserControl, IResultView
    {
        private readonly ResultPresenter _presenter;
        private BindingSource _bindingSource = new BindingSource();

        public ResultView()
        {
            InitializeComponent();
            _presenter = new ResultPresenter(this);
            SetupDataGridView();
            _presenter.LoadResults(DateTime.Now.Date,"");  // Memanggil Presenter untuk mengambil data
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.EnableHeadersVisualStyles = false; // Supaya warna header bisa diubah
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Enabled = false;
            dataGridView1.CurrentCell = null;


            // Ubah warna header menjadi biru
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Padding = new(3, 6, 3, 6);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Konfigurasi agar tabel menyesuaikan ukuran DataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Font = new Font("Arial", 12, FontStyle.Regular);
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "No.",
                DataPropertyName = "No",
                Width = 70,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None, // Pastikan ukuran tetap
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Scan",
                DataPropertyName = "ScanResult",
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Part Motor Washes",
                DataPropertyName = "PartMotorWash",
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Model Code",
                DataPropertyName = "ModelCodeId",
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Model Number",
                DataPropertyName = "ModelNumber",
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Location",
                DataPropertyName = "Location",
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Inspector",
                DataPropertyName = "InspectorId",
            });

            var resultColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Result",
                DataPropertyName = "Result",
            };

            dataGridView1.Columns.Add(resultColumn);

            // Event untuk mewarnai seluruh baris berdasarkan kolom "Result"
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;

            dataGridView1.DataSource = _bindingSource;
        }

        // Event untuk mengubah warna seluruh baris berdasarkan nilai di kolom "Result"
        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Result")
            {
                if (e.Value != null)
                {
                    string resultValue = e.Value.ToString();
                    Color rowColor = resultValue == "OK" ? Color.LightGreen : resultValue == "NG" ? Color.LightCoral : Color.White;

                    // Terapkan warna ke seluruh sel dalam satu baris
                    foreach (DataGridViewCell cell in dataGridView1.Rows[e.RowIndex].Cells)
                    {
                        cell.Style.BackColor = rowColor;
                        cell.Style.SelectionBackColor = rowColor;
                        cell.Style.SelectionForeColor = Color.Black;
                    }
                }
            }
        }


        public void DisplayResults(List<ResultScanModel> results)
        {
            var formattedResults = results.Select((r, index) => new
            {
                No = index + 1,
                ScanResult = r.ScanResult,
                ModelNumber = r.ModelCode?.ModelNumber ?? "N/A",
                PartMotorWash = r.PartMotorWash?.PartNumber ?? "N/A",
                Location = r.Location?.LocationName ?? "N/A",
                InspectorId = r.InspectorId,
                Result = r.Result,
                ModelCodeId = r.ModelCodeId,
            }).ToList();

            _bindingSource.DataSource = formattedResults;
            dataGridView1.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime date = dtFromDate.Value;
            string modelCodeId = textBoxSearch.Text;

            _presenter.LoadResults(date, modelCodeId);
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            dtFromDate.Value = DateTime.Now.Date;
            textBoxSearch.Clear();
            _presenter.LoadResults(DateTime.Now.Date, "");
        }
    }
}

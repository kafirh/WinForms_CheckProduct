using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Result_Scan_Model.Presenter;
using Result_Scan_Model.Repository;
using Result_Scan_Model.Model;
using Result_Scan_Model.Service;

namespace Result_Scan_Model.View
{
    public partial class ScanView : UserControl, IScanView
    {
        private readonly ScanPresenter _presenter;
        private System.Windows.Forms.Timer timer;
        private bool buttonClickedOnce;

        public ScanView()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _presenter = new ScanPresenter(this);


            // Timer untuk update waktu setiap detik
            timer = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };
            timer.Tick += Timer_Tick;

            this.Load += ScanView_Load;
            cbModelNumber.SelectedIndexChanged += CbModelNumber_SelectedIndexChanged; // Menambahkan event handler
        }

        private void ScanView_Load(object sender, EventArgs e)
        {
            txtInspector.Text = SessionManager.CurrentUser?.Name ?? "";
            timer.Start();
            _presenter.UpdateCurrentTime();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _presenter.UpdateCurrentTime();
        }

        public void UpdateDateTime(string date, string time)
        {
            lblDate.Text = date;
            lblTime.Text = time;
        }

        private void CbModelNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Pastikan ada pilihan yang dipilih
            if (cbModelNumber.SelectedValue != null)
            {
                // Ambil ModelCodeId yang dipilih
                string selectedModelCodeId = cbModelNumber.SelectedValue.ToString();

                // Kirim ke presenter untuk memuat data part numbers berdasarkan ModelCodeId yang dipilih
                _presenter.DisplayData(selectedModelCodeId);
                if (txtScanPartCode.Text != "")
                {
                    string inputScan = txtScanPartCode.Text.ToString();
                    string partNumberId = txtPartNumberId.Text.ToString();

                    _presenter.DisplayOKNG(inputScan, partNumberId);
                }

            }
        }

        public void SetModelCodeList(List<ModelCodeModel> modelCodes)
        {
            cbModelNumber.DataSource = modelCodes;
            cbModelNumber.DisplayMember = "ModelNumber";
            cbModelNumber.ValueMember = "ModelCodeId";

            cbModelNumber.SelectedIndex = -1;
        }
        public void SetDisplay(PartMotorWashModel model)
        {
            // Pastikan SetDisplay hanya dipanggil jika ModelNumber telah dipilih
            if (cbModelNumber.SelectedIndex != -1)
            {
                // Update tampilan berdasarkan data dari partMotorWashModel
                txtPartNumberId.Text = model.PartNumberId;
                txtPartNumber.Text = model.PartNumber;
            }
        }
        private void SetLabelOK(bool isActive)
        {
            labelOK.BackColor = isActive ? Color.Green : SystemColors.Control;
            labelOK.ForeColor = isActive ? Color.White : SystemColors.ControlText;
        }

        private void SetLabelNG(bool isActive)
        {
            labelNG.BackColor = isActive ? Color.Red : SystemColors.Control;
            labelNG.ForeColor = isActive ? Color.White : SystemColors.ControlText;
        }

        public void SetOKNG(bool ok)
        {
            if (txtScanPartCode != null)
            {
                SetLabelOK(ok);
                SetLabelNG(!ok);
            }
        }


        public void LoadData()
        {
            _presenter.LoadData();
        }

        private void btnManual_Click_1(object sender, EventArgs e)
        {
            buttonClickedOnce = !buttonClickedOnce; // Toggle state

            btnManual.BackColor = buttonClickedOnce ? Color.FromArgb(0, 133, 181) : Color.LimeGreen;
            btnClear.Visible = buttonClickedOnce;
            btnManual.Text = buttonClickedOnce ? "Auto Print" : "Input Manual";
            txtScanPartCode.ReadOnly = !buttonClickedOnce;
            txtStatus.BackColor = SystemColors.Control;

            if (buttonClickedOnce)
            {
                txtScanPartCode.Focus();
            }
        }

        private void txtScanPartCode_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtScanPartCode.Text) && !string.IsNullOrWhiteSpace(txtPartNumberId.Text))
            {
                string inputScan = txtScanPartCode.Text.ToString();
                string partNumberId = txtPartNumberId.Text.ToString();

                _presenter.DisplayOKNG(inputScan, partNumberId);
            }
        }
    }
}

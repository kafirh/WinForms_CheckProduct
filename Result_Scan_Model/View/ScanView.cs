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
        private bool IsUpdateUi = false;

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

        private async void ScanView_Load(object sender, EventArgs e)
        {
            txtInspector.Text = SessionManager.CurrentUser?.Name ?? "";
            timer.Start();
            _presenter.UpdateCurrentTime();
            await _presenter.StartListeningAsync();
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
            if (cbModelNumber.DataSource == null || cbModelNumber.SelectedIndex == -1)
                return; // Jangan lanjut jika data belum siap

            string selectedModelCodeId = cbModelNumber.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(selectedModelCodeId))
            {
                _presenter.DisplayData(selectedModelCodeId);

                if (!string.IsNullOrWhiteSpace(txtScanPartCode.Text) && !string.IsNullOrWhiteSpace(txtPartNumberId.Text))
                {
                    ResultScanModel model = new ResultScanModel
                    {
                        ScanResult = txtScanPartCode.Text,
                        ModelCodeId = selectedModelCodeId,
                        PartMotorWashId = txtPartNumberId.Text,
                        DateTime = DateTime.Now
                    };

                    _presenter.DisplayOKNG(model);
                    txtScanPartCode.Text = "";
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
            if (model == null || cbModelNumber.SelectedIndex == -1) return; // Hindari error null reference

            txtPartNumberId.Text = model.PartNumberId ?? "";
            txtPartNumber.Text = model.PartNumber ?? "";
        }
        private async void SetLabelOK(bool isActive)
        {
            labelOK.BackColor = isActive ? Color.Green : SystemColors.Control;
            labelOK.ForeColor = isActive ? Color.White : SystemColors.ControlText;

            if (isActive)
            {
                await Task.Delay(3000); // Tunggu 10 detik
                labelOK.BackColor = SystemColors.Control;
                labelOK.ForeColor = SystemColors.ControlText;
            }
        }

        private async void SetLabelNG(bool isActive)
        {
            labelNG.BackColor = isActive ? Color.Red : SystemColors.Control;
            labelNG.ForeColor = isActive ? Color.White : SystemColors.ControlText;

            if (isActive)
            {
                await Task.Delay(3000); // Tunggu 10 detik
                labelNG.BackColor = SystemColors.Control;
                labelNG.ForeColor = SystemColors.ControlText;
            }
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
        private void updateAuto(bool update)
        {
            //MessageBox.Show("masuk method");
            if (update)
            {
                if (!string.IsNullOrWhiteSpace(txtScanPartCode.Text) && !string.IsNullOrWhiteSpace(txtPartNumberId.Text))
                {
                    ResultScanModel model = new ResultScanModel();
                    model.ScanResult = txtScanPartCode.Text;
                    model.ModelCodeId = cbModelNumber.SelectedValue.ToString() ?? "";
                    model.PartMotorWashId = txtPartNumberId.Text;
                    model.DateTime = DateTime.Now;

                    _presenter.DisplayOKNG(model);
                    txtScanPartCode.Text = "";
                    IsUpdateUi = false;
                }
            }
        }
        public async void RefreshScan()
        {
            // Implementasi untuk refresh koneksi TCP atau lainnya
            await _presenter.StartListeningAsync();
        }


        private void txtScanPartCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Cek jika tombol Enter ditekan
            {
                e.SuppressKeyPress = true;
                if (!string.IsNullOrWhiteSpace(txtScanPartCode.Text) && !string.IsNullOrWhiteSpace(txtPartNumberId.Text))
                {
                    ResultScanModel model = new ResultScanModel();
                    model.ScanResult = txtScanPartCode.Text;
                    model.ModelCodeId = cbModelNumber.SelectedValue.ToString() ?? "";
                    model.PartMotorWashId = txtPartNumberId.Text;
                    model.DateTime = DateTime.Now;

                    _presenter.DisplayOKNG(model);
                    txtScanPartCode.Text = "";
                }
            }
        }
        public void UpdateUI1(string data1)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() => txtScanPartCode.Text = data1));
            }
            else
            {
                txtScanPartCode.Text = data1;
            }
            IsUpdateUi = true;
            updateAuto(IsUpdateUi);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScanPartCode.Text = "";
            txtPartNumber.Text = "";
            txtPartNumberId.Text = "";

            cbModelNumber.SelectedIndex = -1;
        }
    }
}

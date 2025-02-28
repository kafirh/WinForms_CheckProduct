using Result_Scan_Model.Data;
using Result_Scan_Model.Model;
using Result_Scan_Model.Repository;
using Result_Scan_Model.Service;
using Result_Scan_Model.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Result_Scan_Model.Presenter
{
    public class ScanPresenter
    {
        private readonly IScanView _view;
        private readonly ModelCodeRepository _modelCodeRepository;
        private readonly PartMotorWashRepository _partMotorWashRepository;
        private readonly ScanPartRepository _scanPartRepository;
        private readonly ResultScanRepository _resultScanRepository;
        private readonly DatabaseContext _dbContext;
        private readonly TCPConnection _tcpConnection;

        public ScanPresenter(IScanView view)
        {
            _dbContext = new DatabaseContext();
            _view = view;
            _modelCodeRepository = new ModelCodeRepository(_dbContext);
            _partMotorWashRepository = new PartMotorWashRepository(_dbContext);
            _scanPartRepository = new ScanPartRepository(_dbContext);
            _resultScanRepository = _resultScanRepository = ResultScanRepository.Instance;
            _tcpConnection = new TCPConnection(UpdateUI1);

            // Inisialisasi tampilan pertama kali
            UpdateCurrentTime();
            LoadData();
        }
        //TCP Connection
        public async Task StartListeningAsync()
        {
            await _tcpConnection.ConnectToServerAsync();
        }
        private void UpdateUI1(string data1)
        {
            _view.UpdateUI1(data1);
        }
        public void StopListening()
        {
            _tcpConnection?.CloseConnection();
        }
        //Load Data View
        public void LoadData()
        {
            // Ambil data langsung dari repository tanpa model
            List<ModelCodeModel> modelCodes = _modelCodeRepository.GetAllModelCodes();
            _view.SetModelCodeList(modelCodes);
        }
        public void DisplayOKNG(ResultScanModel model)
        {
            bool Judgement;
            model.InspectorId = SessionManager.CurrentUser?.NIK ?? "";
            model.ProductId = Properties.Settings.Default.ProductID;
            model.LocationId = Properties.Settings.Default.LocationID;

            if (model.ScanResult == model.PartMotorWashId)
            {
                Judgement = true;
                model.Result = "OK";
            }
            else
            {
                Judgement = false;
                model.Result = "NG";
            }
            _resultScanRepository.Add(model);
            _view.SetOKNG(Judgement);
        }
        public void DisplayData(string modelCodeId)
        {
            // Ambil data ScanPart berdasarkan ModelCodeId
            ScanPartModel scanPart = _scanPartRepository.GetScanPart(modelCodeId);

            if (scanPart != null)
            {
                // Ambil data PartMotorWash berdasarkan MotorWashNumberId
                PartMotorWashModel partMotorWash = _partMotorWashRepository.GetPartMotorWash(scanPart.MotorWashNumberId);

                // Kirimkan data ke view untuk ditampilkan
                _view.SetDisplay(partMotorWash);
            }
        }
        public void UpdateCurrentTime()
        {
            string date = DateTime.Now.ToString("dd MMMM yyyy");
            string time = DateTime.Now.ToString("HH:mm:ss");
            _view.UpdateDateTime(date, time);
        }
    }
}

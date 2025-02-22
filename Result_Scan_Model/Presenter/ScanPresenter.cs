using Result_Scan_Model.Data;
using Result_Scan_Model.Model;
using Result_Scan_Model.Repository;
using Result_Scan_Model.View;
using System;
using System.Collections.Generic;

namespace Result_Scan_Model.Presenter
{
    public class ScanPresenter
    {
        private readonly IScanView _view;
        private readonly ModelCodeRepository _modelCodeRepository;
        private readonly PartMotorWashRepository _partMotorWashRepository;
        private readonly ScanPartRepository _scanPartRepository;
        private readonly DatabaseContext _dbContext;

        public ScanPresenter(IScanView view)
        {
            _dbContext = new DatabaseContext();
            _view = view;
            _modelCodeRepository = new ModelCodeRepository(_dbContext);
            _partMotorWashRepository = new PartMotorWashRepository(_dbContext);
            _scanPartRepository = new ScanPartRepository(_dbContext);

            // Inisialisasi tampilan pertama kali
            UpdateCurrentTime();
            LoadData();
        }

        public void LoadData()
        {
            // Ambil data langsung dari repository tanpa model
            List<ModelCodeModel> modelCodes = _modelCodeRepository.GetAllModelCodes();
            _view.SetModelCodeList(modelCodes);
        }
        public void DisplayOKNG(string scanInput,string partNumberId)
        {
            bool Judgement;
            if(scanInput == partNumberId)
            {
                Judgement = true;
            }
            else
            {
                Judgement = false;
            }
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

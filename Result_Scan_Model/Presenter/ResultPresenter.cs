using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using Result_Scan_Model.Data;
using Result_Scan_Model.Model;
using Result_Scan_Model.Repository;
using Result_Scan_Model.View;

namespace Result_Scan_Model.Presenter
{
    public class ResultPresenter
    {
        private readonly IResultView _resultView;
        private readonly DatabaseContext _dbContext;
        private readonly ResultScanRepository _resultScanRepository;

        public ResultPresenter(IResultView resultView)
        {
            _dbContext = new DatabaseContext();
            _resultView = resultView;
            _resultScanRepository = ResultScanRepository.Instance;
            // Pastikan event tidak duplikat
            _resultScanRepository.DataUpdated -= OnDataUpdated;
            _resultScanRepository.DataUpdated += OnDataUpdated;
        }
        private void OnDataUpdated()
        {
            LoadResults(DateTime.Now.Date, "");
        }

        public async void LoadResults(DateTime date, string modelCodeId)
        {
            int locationId = Properties.Settings.Default.LocationID;

            List<ResultScanModel> results = await Task.Run(() =>
                _resultScanRepository.GetAllResultScan(date, modelCodeId, locationId));

            _resultView.DisplayResults(results);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Result_Scan_Model.Data;
using Result_Scan_Model.Model;
using Result_Scan_Model.Repository;
using Result_Scan_Model.View;

namespace Result_Scan_Model.Presenter
{
    public class SettingPresenter
    {
        private readonly ISettingView _settingView;
        private readonly LocationRepository _locationRepository;
        private readonly ProductTypeRepository _productTypeRepository;
        private readonly DatabaseContext _dbContext;
        public SettingPresenter(ISettingView View)
        {
            _settingView = View;
            _dbContext = new DatabaseContext();
            _locationRepository = new LocationRepository(_dbContext);
            _productTypeRepository = new ProductTypeRepository(_dbContext);

            LoadDataSetting();
        }

        public List<string> GetAllPrinters()
        {
            List<string> printerList = PrinterSettings.InstalledPrinters.Cast<string>().ToList();

            // Ambil printer default dari setting
            string defaultPrinter = Properties.Settings.Default.PrinterType;

            // Jika printer default tidak kosong dan belum ada di list, tambahkan ke paling atas
            if (!string.IsNullOrEmpty(defaultPrinter) && !printerList.Contains(defaultPrinter))
            {
                printerList.Insert(0, defaultPrinter);
            }

            return printerList;
        }

        private void LoadDataSetting()
        {
            List<LocationModel> locations = _locationRepository.GetAllLocation();
            List<ProductTypeModel> productTypeModels = _productTypeRepository.GetAllProduct();
            List<string> printers = GetAllPrinters();
            _settingView.SetLocation(locations);
            _settingView.SetProductType(productTypeModels);
            _settingView.SetPrinter(printers);
            _settingView.SetMode(Properties.Settings.Default.Mode);
            _settingView.portaddress = Properties.Settings.Default.Port.ToString();
            _settingView.ipaddress = Properties.Settings.Default.ServerIP;
            _settingView.IsCheckBoxChecked = Properties.Settings.Default.CheckBoxChecked;
        }

        public void SaveSetting()
        {
            int productId = _settingView.GetProductType();
            int locationId = _settingView.GetLocation();
            Properties.Settings.Default.CheckBoxChecked = _settingView.IsCheckBoxChecked;
            Properties.Settings.Default.Mode = _settingView.mode;
            Properties.Settings.Default.ProductID = productId;
            Properties.Settings.Default.LocationID = locationId;
            Properties.Settings.Default.PrinterType = _settingView.GetPrinter();
            Properties.Settings.Default.ServerIP = _settingView.ipaddress;
            Properties.Settings.Default.Port = int.Parse(_settingView.portaddress);
            Properties.Settings.Default.ProductType = _productTypeRepository.GetProduct(productId).ProductName;
            Properties.Settings.Default.Location = _locationRepository.GetLocation(locationId).LocationName;
            Properties.Settings.Default.Save();
        }
    }
}

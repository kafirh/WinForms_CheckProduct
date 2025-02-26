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

        private void LoadDataSetting()
        {
            List<LocationModel> locations = _locationRepository.GetAllLocation();
            List<ProductTypeModel> productTypeModels = _productTypeRepository.GetAllProduct();
            _settingView.SetLocation(locations);
            _settingView.SetProductType(productTypeModels);
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
            Properties.Settings.Default.ServerIP = _settingView.ipaddress;
            Properties.Settings.Default.Port = int.Parse(_settingView.portaddress);
            Properties.Settings.Default.ProductType = _productTypeRepository.GetProduct(productId).ProductName;
            Properties.Settings.Default.Location = _locationRepository.GetLocation(locationId).LocationName;
            Properties.Settings.Default.Save();
        }
    }
}

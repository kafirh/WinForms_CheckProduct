using System;
using System.Collections.Generic;
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

        public void LoadDataSetting()
        {
            List<LocationModel> locations = _locationRepository.GetAllLocation();
            List<ProductTypeModel> productTypeModels = _productTypeRepository.GetAllProduct();
            _settingView.SetLocation(locations);
            _settingView.SetProductType(productTypeModels);
        }
    }
}

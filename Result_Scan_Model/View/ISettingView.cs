using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Result_Scan_Model.Model;

namespace Result_Scan_Model.View
{
    public interface ISettingView
    {
        public string ipaddress {  get; set; }
        public string portaddress { get; set; }
        public string mode { get; set; }
        public bool IsCheckBoxChecked { get; set; }
        public void SetLocation(List<LocationModel> locations);
        public int GetLocation();
        public void SetProductType(List<ProductTypeModel> products);
        public int GetProductType();
        public void SetMode(string mode);
    }
}

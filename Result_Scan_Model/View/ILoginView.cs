using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result_Scan_Model.View
{
    public interface ILoginView
    {
        string NIK { get; set; }
        string Password { get; set; }
        void ShowErrorMessage(string message);
        void ShowMain();
    }
}

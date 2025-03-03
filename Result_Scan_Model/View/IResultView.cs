using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Result_Scan_Model.Model;

namespace Result_Scan_Model.View
{
    public interface IResultView
    {
        public string GetcbResult();
        public void DisplayResults(List<ResultScanModel> results);
    }
}

using System;
using Result_Scan_Model.Model;

namespace Result_Scan_Model.View
{
    public interface IScanView
    {
        void UpdateDateTime(string date, string time);
        void SetModelCodeList(List<ModelCodeModel> modelCodes);
        void LoadData();
        void SetDisplay(PartMotorWashModel model);
        void SetOKNG(bool ok);
    }
}

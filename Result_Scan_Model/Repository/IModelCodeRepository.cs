using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Result_Scan_Model.Model;

namespace Result_Scan_Model.Repository
{
    internal interface IModelCodeRepository
    {
        List<ModelCodeModel> GetAllModelCodes();
        ModelCodeModel GetModelCode(string modelCodeId);
    }
}

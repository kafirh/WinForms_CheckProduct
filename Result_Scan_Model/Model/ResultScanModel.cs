using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result_Scan_Model.Model
{
    public class ResultScanModel
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string InspectorId { get; set; }
        public int LocationId { get; set; }
        public int ProductId { get; set; }
        public string ModelCodeId {  get; set; }
        public string PartMotorWashId {  get; set; }
        public string ScanResult { get; set; }
        public string Result {  get; set; }

        public LocationModel? Location { get; set; }
        public ProductTypeModel? ProductType { get; set; }
        public ModelCodeModel? ModelCode { get; set; } 
        public PartMotorWashModel? PartMotorWash { get; set; }

    }
}

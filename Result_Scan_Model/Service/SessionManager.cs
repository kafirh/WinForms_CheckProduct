using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Result_Scan_Model.Model;

namespace Result_Scan_Model.Service
{
    public static class SessionManager
    {
        public static InspectorModel CurrentUser { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Automotive_sales_management_app
{
    public class AUTO
    {
        public int ID { get; set; }
        public string MODEL { get; set; }
        public int PRIX { get; set; }
        public DateTime ANNE { get; set; }
        public int KILO { get; set; }
        public string ACCIDENT { get; set; }
        public int IDSALESMEN { get; set; }

        public string FullInfo
        {
            get
            {
                return $"Model :{MODEL} - Prix :{PRIX} Annee : {ANNE} Kilo :{KILO} Info:{ACCIDENT}";
            }
        }
    }
}

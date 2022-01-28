using System;
using System.Collections.Generic;
using System.Text;

namespace Automotive_sales_management_app
{
    public class ACCESSORY
    {
        public int ID { get; set; }
        public string NOM { get; set; }
        public int IDSALESMEN { get; set; }

        public string FullInfo
        {
            get
            {
                return $"Nom : {NOM}";
            }
        }
    }
}

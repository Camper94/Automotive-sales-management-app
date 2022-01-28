using System;
using System.Collections.Generic;
using System.Text;

namespace Automotive_sales_management_app
{
    public class PARTS
    {
        public int ID { get; set; }
        public string NOM { get; set; }
        public string MODELAUTO { get; set; }
        public int IDSALESMEN { get; set; }

        public string FullInfo
        {
            get
            {
                return $"Model :{MODELAUTO} - Nom :{NOM}";
            }
        }
    }
}

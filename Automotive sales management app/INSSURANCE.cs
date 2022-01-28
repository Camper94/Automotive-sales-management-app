using System;
using System.Collections.Generic;
using System.Text;

namespace Automotive_sales_management_app
{
    public class INSSURANCE
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public int IDSALESMEN { get; set; }

        public string FullInfo
        {
            get
            {
                return $"Name : {NAME}";
            }
        }
    }
}

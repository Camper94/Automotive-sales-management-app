using System;
using System.Collections.Generic;
using System.Text;

namespace Automotive_sales_management_app
{
    class CLIENT
    {
        public int ID { get; set; }
        public string NOM { get; set; }
        public string PRENOM { get; set; }
        public int CTBANK { get; set; }
        public string ADRESS { get; set; }
        public string PASSWORD { get; set; }
        public int IDSALESMEN { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{ID} { NOM } { PRENOM } { CTBANK } { ADRESS } { PASSWORD } { IDSALESMEN } ";
            }
        }
    }
}

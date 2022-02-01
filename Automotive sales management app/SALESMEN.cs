using System;
using System.Collections.Generic;
using System.Text;

namespace Automotive_sales_management_app
{
    public class SALESMEN
    {
        public int ID { get; set; }
        public string NOM { get; set; }
        public string PRENOM { get; set; }
        public int NSOCIAL { get; set; }
        public int COMISSION { get; set; }
        public int VRCOMMI { get; set; }
        public string PASSWORD { get; set; }
        public int IDOWNER { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{ID} { NOM } { PRENOM }";
            }
        }
    }
}

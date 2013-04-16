using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CriterionManufacturingSolutions.Products.KiosksSolution
{
    public class KiosksLookup 
    {
        private string bayID;
        private string kiosksMacId;
        private string functionName;

        public string BayID
        {
            get { return bayID; }
            set { bayID = value; }
        }

        public string KiosksMacId
        {
            get { return kiosksMacId; }
            set { kiosksMacId = value; }
        }

        public string FunctionName
        {
            get { return functionName; }
            set { functionName = value; }
        }
    }
}

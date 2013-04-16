using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace CriterionManufacturingSolutions.Products.KiosksSolution
{
    [DataContract]
    public class KiosksConfiguration
    {
        private string kiosksMacID;
        private string bayID;
        private string functionName;

        [DataMember]
        public string KiosksMACId
        {
            get { return kiosksMacID; }
            set { kiosksMacID = value; }
        }

        [DataMember]
        public string BayID
        {
            get { return bayID; }
            set { bayID = value; }
        }

        [DataMember]
        public string FunctionName
        {
            get { return functionName; }
            set { functionName = value; }
        }
    }

    [DataContract]
    public class MonthlyRate
    {
        private int duration;
        private decimal rate;

        [DataMember]
        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        [DataMember]
        public decimal Rate
        {
            get { return rate; }
            set { rate = value; }
        }
    }

    [DataContract]
    public class CreditCardDetails
    {
        private string creditCardNumber;
        private string validTillDate;

        [DataMember]
        public string CreditCardNumber
        {
            get { return creditCardNumber; }
            set { creditCardNumber = value; }
        }

        [DataMember]
        public string ValidTillDate
        {
            get { return validTillDate; }
            set { validTillDate = value; }
        }
    }

    [DataContract]
    public class TransactionResult
    {
        private string result;
        private string transactionID;

        [DataMember]
        public string Result
        {
            get { return result; }
            set { result = value; }
        }

        [DataMember]
        public string TransactionID
        {
            get { return transactionID; }
            set { transactionID = value; }
        }
    }
}

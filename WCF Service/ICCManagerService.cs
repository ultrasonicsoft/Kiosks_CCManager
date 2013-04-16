using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace CriterionManufacturingSolutions.Products.KiosksSolution
{
    [ServiceContract(CallbackContract = typeof(IKiosksCallback))]
    public interface ICCManagerService
    {
        [OperationContract]
        KiosksConfiguration GetConfiguration(string kiosksMacID);

        [OperationContract]
        List<MonthlyRate> GetMonthlyRates();

        //[OperationContract(IsOneWay = true)]
        [OperationContract]
        bool IsBayReadyForStore(string BayID);

        //[OperationContract(IsOneWay = true)]
        [OperationContract]
        bool IsBayReadyForRetrieval(string BayID);

        [OperationContract]
        bool IsValidCreditCard(CreditCardDetails creditCardInfo);

        [OperationContract]
        TransactionResult DoTransaction(CreditCardDetails creditCardInfo, string bayID, string kiosksMACId);
    }

    public interface IKiosksCallback
    {
        [OperationContract]
        bool IsBayReadyForStoreCallback(bool bayStatus);

        [OperationContract]
        bool IsBayReadyForRetrievalCallback(bool bayStatus);
    }
}

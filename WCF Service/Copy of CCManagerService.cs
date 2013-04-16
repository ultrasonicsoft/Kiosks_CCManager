//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.ServiceModel;
//using System.Threading;

//[ServiceContract(CallbackContract=typeof(IKiosksCallback))]
//public interface ICCManagerService
//{
//    [OperationContract(IsOneWay=true)]
//    void RegisterForTempDrops();
//}

//public interface IKiosksCallback
//{
//    //[OperationContract(IsOneWay = true)]
//    //void TempUpdate(double temp);

//    [OperationContract]
//    bool TempUpdate(double temp);
//}

//[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Reentrant)]
//public class Temperature : ICCManagerService
//{
//    public void RegisterForTempDrops()
//    {
//        OperationContext ctxt = OperationContext.Current;
//        IKiosksCallback callBack = ctxt.GetCallbackChannel<IKiosksCallback>();
//        Thread.Sleep(3000); //simulate update happens somewhere; for example monitoring a database field
//        callBack.TempUpdate(10);
//    }
    
//}


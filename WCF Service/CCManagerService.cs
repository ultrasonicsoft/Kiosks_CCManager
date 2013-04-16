using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CriterionManufacturingSolutions.Products.KiosksSolution
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class CCManagerService : ICCManagerService
    {
        BusinessLogic m_businessLogic = new BusinessLogic();

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <param name="kiosksMacID">The kiosks mac ID.</param>
        /// <returns></returns>
        public KiosksConfiguration GetConfiguration(string kiosksMacID)
        {
            KiosksConfiguration configuration = new KiosksConfiguration();
            try
            {
                configuration.KiosksMACId = kiosksMacID;
                configuration.BayID = Properties.Settings.Default[kiosksMacID].ToString() ?? string.Empty;
                configuration.FunctionName = Properties.Settings.Default[configuration.BayID].ToString() ?? string.Empty; ;
            }
            catch (Exception ex)
            {
                //log exception
            }
            return configuration;
        }


        /// <summary>
        /// Gets the monthly rate.
        /// </summary>
        /// <returns></returns>
        public List<MonthlyRate> GetMonthlyRates()
        {
            List<MonthlyRate> monthlyRates = new List<MonthlyRate>();
            monthlyRates.Add(new MonthlyRate() { Rate = (decimal)2.5, Duration = 1 });
            return monthlyRates;
        }


        /// <summary>
        /// Determines whether [is bay ready] [the specified bay ID].
        /// </summary>
        /// <param name="BayID">The bay ID.</param>
        /// <returns>
        ///   <c>true</c> if [is bay ready] [the specified bay ID]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsBayReadyForStore(string BayID)
        {
            bool bayStatus = false;

            try
            {
                //OperationContext ctxt = OperationContext.Current;
                //IKiosksCallback callBack = ctxt.GetCallbackChannel<IKiosksCallback>();

                Task.Factory.StartNew( ()=> bayStatus = m_businessLogic.IsBayReadyForStore(BayID));

                //Thread.Sleep(3000);
                //callBack.IsBayReadyForStoreCallback(bayStatus);
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
            return bayStatus;
        }

        /// <summary>
        /// Determines whether [is bay ready for retrieval] [the specified bay ID].
        /// </summary>
        /// <param name="BayID">The bay ID.</param>
        public bool IsBayReadyForRetrieval(string BayID)
        {
            bool bayStatus = false;
            try
            {
                //OperationContext ctxt = OperationContext.Current;
                //IKiosksCallback callBack = ctxt.GetCallbackChannel<IKiosksCallback>();

                Task.Factory.StartNew(() => bayStatus = m_businessLogic.IsBayReadyForStore(BayID));

                //Thread.Sleep(3000);
                //callBack.IsBayReadyForRetrievalCallback(bayStatus);
            }
            catch (Exception ex)
            {
                //TODO: log exception                
            }
            return bayStatus;
        }

        /// <summary>
        /// Determines whether [is valid credit card] [the specified credit card].
        /// </summary>
        /// <param name="creditCard">The credit card.</param>
        /// <returns>
        ///   <c>true</c> if [is valid credit card] [the specified credit card]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsValidCreditCard(CreditCardDetails creditCardInfo)
        {
            bool isValidCreditCard = false;
            try
            {
                Task.Factory.StartNew(() => isValidCreditCard = m_businessLogic.IsValidCreditCard(creditCardInfo));
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
            return isValidCreditCard;
        }


        /// <summary>
        /// Does the transaction.
        /// </summary>
        /// <param name="creditCardInfo">The credit card info.</param>
        /// <returns></returns>
        public TransactionResult DoTransaction(CreditCardDetails creditCardInfo, string bayID, string kiosksMACId)
        {
            TransactionResult result = null;
            try
            {
                Task.Factory.StartNew(() => result = m_businessLogic.DoParkingTransaction(creditCardInfo, bayID, kiosksMACId));
            }
            catch (Exception ex)
            {
                //TODO: log exception                                
            }
            return result;
        }
    }
}
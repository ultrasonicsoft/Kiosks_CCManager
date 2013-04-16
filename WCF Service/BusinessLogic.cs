using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CriterionManufacturingSolutions.Products.KiosksSolution
{
    internal class BusinessLogic
    {
        /// <summary>
        /// Determines whether [is bay ready for store] [the specified bay ID].
        /// </summary>
        /// <param name="BayID">The bay ID.</param>
        /// <returns>
        ///   <c>true</c> if [is bay ready for store] [the specified bay ID]; otherwise, <c>false</c>.
        /// </returns>
        internal bool IsBayReadyForStore(string bayID)
        {
            bool isReady = false;
            try
            {
                //TODO: do some logic here
                isReady = true;
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
            return isReady;
        }

        /// <summary>
        /// Determines whether [is bay ready for store] [the specified bay ID].
        /// </summary>
        /// <param name="BayID">The bay ID.</param>
        /// <returns>
        ///   <c>true</c> if [is bay ready for store] [the specified bay ID]; otherwise, <c>false</c>.
        /// </returns>
        internal bool IsBayReadyForRetrieval(string bayID)
        {
            bool isReady = false;
            try
            {
                //TODO: do some logic here
                isReady = true;
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
            return isReady;
        }

        /// <summary>
        /// Determines whether [is valid credit card] [the specified credit card].
        /// </summary>
        /// <param name="creditCard">The credit card.</param>
        /// <returns>
        ///   <c>true</c> if [is valid credit card] [the specified credit card]; otherwise, <c>false</c>.
        /// </returns>
        internal bool IsValidCreditCard(CreditCardDetails creditCard)
        {
            bool isValid = false;
            try
            {
                //TODO: do some logic here
                isValid = true;
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
            return isValid;
        }

        /// <summary>
        /// Does the parking transaction.
        /// </summary>
        /// <param name="creditCardInfo">The credit card info.</param>
        /// <returns></returns>
        internal TransactionResult DoParkingTransaction(CreditCardDetails creditCardInfo, string bayID, string kiosksMACId)
        {
            TransactionResult result = null;
            try
            {
                //TODO: add transaction logic
                result = new TransactionResult();
                result.Result = "Successful";
                result.TransactionID = "T001";

                StoreTransactionResult(result);
            }
            catch (Exception ex)
            {
                //TODO: log exception                                
            }
            return result;
        }

        /// <summary>
        /// Stores the transaction result.
        /// </summary>
        /// <param name="result">The result.</param>
        private void StoreTransactionResult(TransactionResult result)
        {
            try
            {
                //TODO: add logic to store transaction result
            }
            catch (Exception ex)
            {
                //TODO: log exception                                
            }
        }
    }
}

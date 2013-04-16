using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace CriterionManufacturingSolutions.Products.KiosksSolution
{
    public class CCManager
    {
        internal static ServiceHost myServiceHost = null;

        public CommunicationState CurrentCommunciationState
        {
            get { return myServiceHost.State; }
        }

        public bool StartService()
        {
            bool isServiceStarted = false;
            try
            {
                myServiceHost = new ServiceHost(typeof(CCManagerService));
                myServiceHost.Open();
                
                isServiceStarted = true;
            }
            catch (Exception ex)
            {
                //Log exception
            }
            return isServiceStarted;
        }

        public bool StopService()
        {
            bool isServiceStopped = false;
            try
            {
                myServiceHost.Close();
                isServiceStopped = true;
            }
            catch (Exception ex)
            {
                //Log exception
            }
            return isServiceStopped;
        }
    }
}

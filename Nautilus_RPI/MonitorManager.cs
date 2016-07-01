using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nautilus_RPI
{
    class MonitorManager
    {

        //Public function that checks fr an internet connection by loading google on an object and returning a true value
        public static bool internetAccess()
        {
            try
            {
                using (var client = new System.Net.WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        //Function that return the geolocation of the nautilus device
        public static bool  gps()
        {
            //TODO
            return false;
        }

        //Function that returns the value for the database functionality
        public static bool checkDB()
        {
            bool valor = DBManager.testConn();
            return valor;
        }

    }
}

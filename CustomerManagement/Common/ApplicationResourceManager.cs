using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Common
{
    public static class ApplicationResourceManager
    {
        private static ResourceManager resMgr = new ResourceManager("CustomerManagement.Properties.Resources", Assembly.GetExecutingAssembly());

        public static string GetRessourcesValue(string messageId)
        {
            return resMgr.GetString(messageId);
        }
    }
}

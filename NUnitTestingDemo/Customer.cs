using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
   public class Customer
    {
        public bool AddCustomer(EMailClass obj)
        {
            //EMailClass obj = new EMailClass();
            obj.sendMail();
     // Some code of ADO.Net will go here
            return true;
        }
    }
}

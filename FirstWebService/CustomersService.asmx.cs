using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace FirstWebService
{
    /// <summary>
    /// Summary description for CustomersService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CustomersService : System.Web.Services.WebService
    {
        

        [WebMethod]
        public CustomerData GetCustomerById(int id)
        {
            using(AccountsEntities1 context = new AccountsEntities1())
            {
                Customer cust = context.Customers.Where(i => i.Id == id).SingleOrDefault();
                CustomerData cust2 = new CustomerData
                {
                    Id = cust.Id,
                    AccountNumber = cust.AccountNumber,
                    Balance = cust.Balance,
                    CellPhone = cust.CellPhone,
                    Fname = cust.Fname,
                    Lname = cust.Lname
                };
                return cust2;         
            }
        }
    }
}

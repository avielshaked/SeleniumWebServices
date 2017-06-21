using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;

namespace FirstWebService
{
    public class Main
    {
        [Test]
        public void Run()
        {
            NBA g = new NBA();
            g.HelloWorld();
        }

        [Test]
        public void Call()
        {
            CustomersService cs = new CustomersService();
            cs.GetCustomerById(123456789);
        }
    }
}
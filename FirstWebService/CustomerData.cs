using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWebService
{
    public class CustomerData
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public long CellPhone { get; set; }
        public decimal Balance { get; set; }
        public int AccountNumber { get; set; }

        public static implicit operator CustomerData(Customer v)
        {
            throw new NotImplementedException();
        }
    }
}
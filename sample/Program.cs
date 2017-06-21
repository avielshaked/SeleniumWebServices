using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sample.ServiceReference;

namespace sample
{
    class Program
    {
        static void Main(string[] args)
        {
            NBASoapClient nba = new NBASoapClient();
            
            var a= nba.GetPlayerData("PF");

            var b =  doctor.GetDoctorData("avi", 45);
            
        }
    }
}

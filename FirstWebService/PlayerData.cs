using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWebService
{
    public class PlayerData
    {
        public int playerid { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public int teamid { get; set; }

        public static implicit operator PlayerData(Player v)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;


namespace FirstWebService
{
    /// <summary>
    /// Summary description for NBA
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NBA : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<PlayerData> GetPlayerData(string pos)
        {                  
            using (NBAPlayersEntities1 context = new NBAPlayersEntities1())
            {
                List<Player> PlayerInfo = context.Players.Where(p => p.Position == pos).ToList();
                List<PlayerData> LPd = new List<PlayerData>();
                foreach (var item in PlayerInfo)
                {
                    PlayerData pd = new PlayerData
                    {
                        playerid = item.PlayerID,
                        name = item.Name,
                        position = item.Position,
                        teamid = item.TeamID
                    };
                    LPd.Add(pd);
                }
                return LPd.ToList();
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat= ResponseFormat.Json)]
        public string GetPlayerDatajson(int teamid)
        {
            using (NBAPlayersEntities1 context = new NBAPlayersEntities1())
            {
                var PlayerInfo = context.Players.Where(p => p.TeamID == teamid).ToArray();
                PlayerData[] playersarr = new PlayerData[PlayerInfo.Count()];
                for(int i =0; i < playersarr.Count(); i++)
                {
                    playersarr[i] = new PlayerData { name = PlayerInfo[i].Name, playerid = PlayerInfo[i].PlayerID,position=PlayerInfo[i].Position,
                    teamid=PlayerInfo[i].TeamID};
                    
                };          
                return new JavaScriptSerializer().Serialize(playersarr);               
            }
        }
    }
}

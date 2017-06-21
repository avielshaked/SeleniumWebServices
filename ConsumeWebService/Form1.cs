using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumeWebService.localhost;


namespace ConsumeWebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NBA nba = new NBA();
            PlayerData[] players = nba.GetPlayerData("PF");
            foreach(PlayerData player in players)
            {
                listBox1.Items.Add(player.name + "----------->" + string.Format("${0}", player.playerid));
            }
            
        }
    }
}

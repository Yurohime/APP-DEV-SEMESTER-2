using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

internal class Preset
{
    public Team Team1()
    {
        String[] Playername = { "Eiji Kawashima", "Shuichi Gonda", "Daniel Schmidt", "Miki Yamane" , "Shogo Taniguchi", "Kou Itakura", "Yuto Nagatomo", "Wataru Endo", "Gaku Shibasaki", "Kaoru Mitoma", "Takumi Minamino", "Ritsu Doan", "Junya Ito", "Takuma Asano", "Shuto Machino"};
        String[] Playernumber = { "01", "12","22", "02", "03", "04", "05", "06", "07", "09", "10", "08", "14", "18", "20" };
        String[] Pos = { "GK", "GK", "GK", "DF", "DF", "DF", "DF", "MF", "MF", "MF", "MF", "FW", "FW", "FW", "FW" };
        Team team = new Team();
        team.Name = "Japan Squad";
        team.Country = "Japan";
        team.City = "Tokyo";
        team.PlayerList = new List<Player>();
        for (int i = 0; i < Playername.Count(); i++)
        {
            Player player = new Player();
            player.Name = Playername[i];
            player.Number = Playernumber[i];
            player.Pos = Pos[i];
            team.PlayerList.Add(player);
            team.PlayerList.OrderBy(o => o.Number).ToList();
        }
        return team;
    }
    public Team Team2()
    {
        String[] Playername = { "Stefan Ortega", "Ederson", "Scott Carson", "Kyle Walker", "Rúben Dias", "John Stones", "Nathan Aké", "Kalvin Phillips", "Ilkay Gündogan", "Rodri", "Kevin De Bruyne", "Erling Haaland", "Julián Álvarez", "Riyad Mahrez" };
        String[] Playernumber = { "18", "31", "33", "02", "03", "05", "06", "04", "08", "14", "17", "09", "19", "26"};
        String[] Pos = { "GK", "GK", "GK", "DF", "DF", "DF", "DF", "MF", "MF", "MF", "MF", "FW", "FW", "FW" };
        Team team = new Team();
        team.Name = "Manchester City Squad";
        team.Country = "United Kingdom";
        team.City = "Manchester";
        team.PlayerList = new List<Player>();
        for (int i = 0; i < Playername.Count(); i++)
        {
            Player player = new Player();
            player.Name = Playername[i];
            player.Number = Playernumber[i];
            player.Pos = Pos[i];
            team.PlayerList.Add(player);
            team.PlayerList.OrderBy(o => o.Number).ToList();
        }
        return team;
    }
    public Team Team3()
    {
        String[] Playername = { "Alisson", "Adrián", "Caoimhin Kelleher", "Joe Gomez", "Virgil van Dijk", "Ibrahima Konaté", "Konstantinos Tsimikas", "Fabinho", "Thiago", "James Milner", "Naby Keita", "Mohamed Salah", "Cody Gakpo", "Diogo Jota", "Luis Díaz" };
        String[] Playernumber = { "01", "13", "62", "02", "04", "05", "21", "03", "06", "07", "08", "11", "18", "20", "23" };
        String[] Pos = { "GK", "GK", "GK", "DF", "DF", "DF", "DF", "MF", "MF", "MF", "MF", "FW", "FW", "FW", "FW" };
        Team team = new Team();
        team.Name = "Liverpool Squad";
        team.Country = "United Kingdom";
        team.City = "Liverpool";
        team.PlayerList = new List<Player>();
        for (int i = 0; i < Playername.Count(); i++)
        {
            Player player = new Player();
            player.Name = Playername[i];
            player.Number = Playernumber[i];
            player.Pos = Pos[i];
            team.PlayerList.Add(player);
            team.PlayerList.OrderBy(o => o.Number).ToList();
        }
        return team;
    }

}


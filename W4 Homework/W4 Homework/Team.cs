using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Team
{
    protected string name;
    protected string country;
    protected string city;
    protected List<Player> playerList;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Country
    {
        get { return country; }
        set { country = value; }
    }
    public string City
    {
        get { return city; }
        set { city = value; }
    }
    public List<Player> PlayerList
    {
        get { return playerList; }
        set { playerList = value; }
    }
}


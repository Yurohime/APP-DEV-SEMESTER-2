using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Movie
{
    protected string name;
    protected string seatm;
    protected string seatn;
    protected string seate;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string SeatMorning
    {
        get { return seatm; }
        set { seatm = value; }
    }
    public string SeatNoon
    {
        get { return seatn; }
        set { seatn = value; }
    }
    public string SeatEvening
    {
        get { return seate; }
        set { seate = value; }
    }
}
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W8
{
    public partial class FormDetail : Form
    {
        string mysqlconnection = "server=localhost;uid=root;database=premier_league";
        MySqlConnection myconnection;
        MySqlCommand mycommand;
        MySqlDataAdapter myadapter;
        string mysqlquary;
        DataTable dtcbox = new DataTable();
        string teamid = "";
        int index = 0;

        int goal = 0;
        int goalpen = 0;
        int goalown = 0;
        int penmiss = 0;
        int yellow = 0;
        int red = 0;
        public FormDetail(string teamid, int index)
        {
            InitializeComponent();
            this.teamid = teamid;
            this.index = index;
        }

        private void FormDetail_Load(object sender, EventArgs e)
        {
            DataTable dtplayerdata = new DataTable();
            mysqlquary = $"SELECT p.player_id, t.team_name ,p.player_name as 'Name',p.playing_pos, p.team_number as 'Number' , n.nation FROM player p,team t, nationality n where p.team_id = t.team_id and p.nationality_id = n.nationality_id and t.team_id = '{teamid}';";
            myconnection = new MySqlConnection(mysqlconnection);
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myadapter = new MySqlDataAdapter(mycommand);
            myadapter.Fill(dtplayerdata);

            string playerid = dtplayerdata.Rows[index][0].ToString();

            DataTable dtdetailmatch = new DataTable();
            mysqlquary = $"SELECT d.`type` FROM dmatch d, player p where d.player_id = p.player_id and p.player_id='{playerid}';";
            myconnection = new MySqlConnection(mysqlconnection);
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myadapter = new MySqlDataAdapter(mycommand);
            myadapter.Fill(dtdetailmatch);

            labelplayername.Text = "player:" + dtplayerdata.Rows[index][2].ToString();
            labelplayerteam.Text = "Team: " + dtplayerdata.Rows[index][1].ToString();
            labelplayernumber.Text = "Number: "+ dtplayerdata.Rows[index][4].ToString();
            labelplayernation.Text = "Nationality: "+ dtplayerdata.Rows[index][5].ToString();
            if (dtplayerdata.Rows[index][3].ToString() == "F")
            {
                labelplayerpos.Text = "Position: Forward";
            }
            if (dtplayerdata.Rows[index][3].ToString() == "D")
            {
                labelplayerpos.Text = "Position: Defense";
            }
            if (dtplayerdata.Rows[index][3].ToString() == "M")
            {
                labelplayerpos.Text = "Position: Midfield";
            }
            if (dtplayerdata.Rows[index][3].ToString() == "G")
            {
                labelplayerpos.Text = "Position: GoalKeeper";
            }

            for(int i = 0; i < dtdetailmatch.Rows.Count; i++)
            {
                if (dtdetailmatch.Rows[i][0].ToString() == "GO")
                {
                    goal++;
                }
                else if (dtdetailmatch.Rows[i][0].ToString() == "GP")
                {
                    goalpen++;
                }
                else if (dtdetailmatch.Rows[i][0].ToString() == "GW")
                {
                    goalown++;
                }
                else if (dtdetailmatch.Rows[i][0].ToString() == "PM")
                {
                    penmiss++;
                }
                else if (dtdetailmatch.Rows[i][0].ToString() == "CY")
                {
                    yellow++;
                }
                else if (dtdetailmatch.Rows[i][0].ToString() == "CR")
                {
                    red++;
                }
            }
            labelcareergoal.Text = ": " + goal.ToString();
            labelcareerpenaltygoal.Text = ": " + goalpen.ToString();
            labelcareergoalown.Text = ": " + goalown.ToString();
            labelcareerpenaltymiss.Text = ": " + penmiss.ToString();
            labelcareeryellowcard.Text = ": " + yellow.ToString();
            labelcareerredcard.Text = ": " + red.ToString();
        }
    }
}

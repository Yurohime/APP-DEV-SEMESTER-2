using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W8
{
    public partial class FormMatchDetail : Form
    {
        string matchid = "";
        string mysqlconnection = "server=localhost;uid=root;database=premier_league";
        MySqlConnection myconnection;
        MySqlCommand mycommand;
        MySqlDataAdapter myadapter;
        string mysqlquary;
        string data;
        DataTable dtmatch = new DataTable();
        DataTable dtmatchdata = new DataTable();
        public FormMatchDetail(string matchid, string data)
        {
            InitializeComponent();
            this.matchid = matchid;
            this.data = data;
        }

        private void FormMatchDetail_Load(object sender, EventArgs e)
        {
            mysqlquary = $"SELECT t.team_name as 'Team', p.player_name as 'Player Name',if (d.`type`='GO','Goal',if(d.`type`='GW','Goal (Own)',if(d.`type`='GP','Penalty Goal',if(d.`type`='PM','Penalty Miss',if(d.`type`='CY','Yellow Card','Red Card'))))) as 'Type', d.`minute` as 'Minute' FROM player p, team t, `match` m, dmatch d where p.player_id = d.player_id and t.team_id = d.team_id and  m.match_id = d.match_id and m.match_id = '{matchid}';";
            myconnection = new MySqlConnection(mysqlconnection);
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myadapter = new MySqlDataAdapter(mycommand);
            myadapter.Fill(dtmatch);
            dgv_detail.DataSource = dtmatch;
            dgv_detail.RowHeadersVisible = false;

            mysqlquary = $"SELECT date_format(m.match_date,'%D %M %Y'), m.goal_home, m.goal_away, r.referee_name FROM `match` m , referee r where r.referee_id = m.referee_id and m.match_id = '{matchid}';";
            myconnection = new MySqlConnection(mysqlconnection);
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myadapter = new MySqlDataAdapter(mycommand);
            myadapter.Fill(dtmatchdata);

            string[] datapieces = data.Split('-');
            labelhome.Text = $"Home: {datapieces[0]} Score: {dtmatchdata.Rows[0][1].ToString()}";
            labelaway.Text = $"Away: {datapieces[1]} Score: {dtmatchdata.Rows[0][2].ToString()}";
            labeldate.Text = $"Date: {dtmatchdata.Rows[0][0].ToString()}";
            labelref.Text = $"Referee: {dtmatchdata.Rows[0][3].ToString()}";

        }
    }
}

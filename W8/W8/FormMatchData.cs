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
    public partial class FormMatchData : Form
    {
        string mysqlconnection = "server=localhost;uid=root;database=premier_league";
        MySqlConnection myconnection;
        MySqlCommand mycommand;
        MySqlDataAdapter myadapter;
        string mysqlquary;
        DataTable dtcbox = new DataTable();
        DataTable dtmatchcombine = new DataTable();
        DataTable dtcboxmatch = new DataTable();
        string teamid = "";
        string matchid = "";
        string teamhome = "";
        string teamaway = "";
        int index = 0;
        public FormMatchData()
        {
            InitializeComponent();
        }
        public Form1 FormRef { get; set; }

        private void FormMatchData_Load(object sender, EventArgs e)
        {
            mysqlquary = "SELECT team_id as 'ID',team_name as 'Team' FROM team t;";
            myconnection = new MySqlConnection(mysqlconnection);
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myadapter = new MySqlDataAdapter(mycommand);
            myadapter.Fill(dtcbox);
            cbox_team.DataSource = dtcbox;
            cbox_team.ValueMember = "ID";
            cbox_team.DisplayMember = "Team";

            DataTable dtmatchid = new DataTable();
            mysqlquary = $"SELECT m.team_home, m.team_away FROM `match` m;";
            myconnection = new MySqlConnection(mysqlconnection);
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myadapter = new MySqlDataAdapter(mycommand);
            myadapter.Fill(dtmatchid);

            DataTable dtmatchhome = new DataTable();
            mysqlquary = $"SELECT m.match_id , t.team_name FROM `match` m , team t where m.team_home = t.team_id;";
            myconnection = new MySqlConnection(mysqlconnection);
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myadapter = new MySqlDataAdapter(mycommand);
            myadapter.Fill(dtmatchhome);

            DataTable dtmatchaway = new DataTable();
            mysqlquary = $"SELECT m.match_id , t.team_name FROM `match` m , team t where m.team_away = t.team_id;";
            myconnection = new MySqlConnection(mysqlconnection);
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myadapter = new MySqlDataAdapter(mycommand);
            myadapter.Fill(dtmatchaway);

            dtmatchcombine.Columns.Add("Match ID");
            dtmatchcombine.Columns.Add("Home Team");
            dtmatchcombine.Columns.Add("Away Team");
            dtmatchcombine.Columns.Add("VS");
            dtmatchcombine.Columns.Add("Home id");
            dtmatchcombine.Columns.Add("Away id");
            for (int i = 0; i < dtmatchhome.Rows.Count; i++)
            {
                string vs = dtmatchhome.Rows[i][1].ToString() + " VS " + dtmatchaway.Rows[i][1].ToString();
                dtmatchcombine.Rows.Add(dtmatchhome.Rows[i][0].ToString(), dtmatchhome.Rows[i][1].ToString(), dtmatchaway.Rows[i][1].ToString(), vs, dtmatchid.Rows[i][0].ToString(), dtmatchid.Rows[i][1].ToString());
            }
            dtcboxmatch.Columns.Add("matches");
            dtcboxmatch.Columns.Add("home id");
            dtcboxmatch.Columns.Add("away id");
            dtcboxmatch.Columns.Add("matchid");
            dtcboxmatch.Columns.Add("matchidnamed");
        }

        public void Committeam(object sender, EventArgs e)
        {
            cbox_match.Items.Clear();
            dtcboxmatch.Rows.Clear();

            string teamname = this.cbox_team.GetItemText(this.cbox_team.SelectedItem);
            for (int i = 0; i < dtmatchcombine.Rows.Count; i++)
            {
                string teamnames = dtmatchcombine.Rows[i][1].ToString() + "-" + dtmatchcombine.Rows[i][2].ToString();
                if (dtmatchcombine.Rows[i][1].ToString() == teamname)
                {
                    dtcboxmatch.Rows.Add(dtmatchcombine.Rows[i][3].ToString(), dtmatchcombine.Rows[i][4].ToString(), dtmatchcombine.Rows[i][5].ToString(), dtmatchcombine.Rows[i][0].ToString(),teamnames);
                    cbox_match.Items.Add(dtmatchcombine.Rows[i][3].ToString());
                }
                else if (dtmatchcombine.Rows[i][2].ToString() == teamname)
                {
                    dtcboxmatch.Rows.Add(dtmatchcombine.Rows[i][3].ToString(), dtmatchcombine.Rows[i][4].ToString(), dtmatchcombine.Rows[i][5].ToString(), dtmatchcombine.Rows[i][0].ToString(),teamnames);
                    cbox_match.Items.Add(dtmatchcombine.Rows[i][3].ToString());
                }
            }
        }

        private void commitmatch(object sender, EventArgs e)
        {
            
            teamhome = dtcboxmatch.Rows[cbox_match.SelectedIndex][1].ToString();
            teamaway = dtcboxmatch.Rows[cbox_match.SelectedIndex][2].ToString();
            matchid = dtcboxmatch.Rows[cbox_match.SelectedIndex][3].ToString();

            DataTable dtplayerhome = new DataTable();
            mysqlquary = $"SELECT p.player_name as 'Name' FROM player p,team t where p.team_id = t.team_id and t.team_id = '{teamhome}';";
            myconnection = new MySqlConnection(mysqlconnection);
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myadapter = new MySqlDataAdapter(mycommand);
            dgv_home.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
            dgv_home.RowHeadersVisible = false;
            myadapter.Fill(dtplayerhome);
            dgv_home.DataSource = dtplayerhome;

            DataTable dtplayeraway = new DataTable();
            mysqlquary = $"SELECT p.player_name as 'Name' FROM player p,team t where p.team_id = t.team_id and t.team_id = '{teamaway}';";
            myconnection = new MySqlConnection(mysqlconnection);
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myadapter = new MySqlDataAdapter(mycommand);
            dgv_away.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
            dgv_away.RowHeadersVisible = false;
            myadapter.Fill(dtplayeraway);
            dgv_away.DataSource = dtplayeraway;

            matchdetail();
        }

        private void matchdetail()
        {
            if (panel_detail.Controls.Count == 1)
            {
                panel_detail.Controls.Clear();
            }
            FormMatchDetail newform = new FormMatchDetail(matchid, dtcboxmatch.Rows[cbox_match.SelectedIndex][4].ToString());
            newform.TopLevel = false;
            newform.FormBorderStyle = FormBorderStyle.None;
            newform.Dock = DockStyle.Fill;
            panel_detail.Controls.Add(newform);
            newform.Show();
        }
        private void playerdetail(string teamid, int index)
        {
            if (panel_detail.Controls.Count == 1)
            {
                panel_detail.Controls.Clear();
            }
            FormDetail newform = new FormDetail(teamid,index);
            newform.TopLevel = false;
            newform.FormBorderStyle = FormBorderStyle.None;
            newform.Dock = DockStyle.Fill;
            panel_detail.Controls.Add(newform);
            newform.Show();
        }

        private void btn_matchview_Click(object sender, EventArgs e)
        {
            matchdetail();
        }

        private void mouseclickhome(object sender, DataGridViewCellMouseEventArgs e)
        {
            playerdetail(teamhome, dgv_home.CurrentCell.RowIndex);
        }

        private void mouseclickaway(object sender, DataGridViewCellMouseEventArgs e)
        {
            playerdetail(teamaway, dgv_away.CurrentCell.RowIndex);
        }
    }
}

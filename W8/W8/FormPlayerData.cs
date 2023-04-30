using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace W8
{
    public partial class FormPlayerData : Form
    {
        string mysqlconnection = "server=localhost;uid=root;database=premier_league";
        MySqlConnection myconnection;
        MySqlCommand mycommand;
        MySqlDataAdapter myadapter;
        string mysqlquary;
        DataTable dtcbox = new DataTable();
        string teamid = "";
        string playerid = "";


        public FormPlayerData()
        {
            InitializeComponent();
        }
        public Form1 FormRef { get; set; }

        private void FormPlayerData_Load(object sender, EventArgs e)
        {
            mysqlquary = "SELECT team_id as 'ID',team_name as 'Team' FROM team t;";
            myconnection = new MySqlConnection(mysqlconnection);
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myadapter = new MySqlDataAdapter(mycommand);
            myadapter.Fill(dtcbox);
            cbox_team.DataSource = dtcbox;
            cbox_team.ValueMember = "ID";
            cbox_team.DisplayMember = "Team";
        }

        private void Committed(object sender, EventArgs e)
        {
            teamid = dtcbox.Rows[cbox_team.SelectedIndex][0].ToString();

            DataTable dtplayer = new DataTable();
            mysqlquary = $"SELECT p.player_name as 'Name', p.team_number as 'Number' FROM player p,team t where p.team_id = t.team_id and t.team_id = '{teamid}';";
            myconnection = new MySqlConnection(mysqlconnection);
            mycommand = new MySqlCommand(mysqlquary, myconnection);
            myadapter = new MySqlDataAdapter(mycommand);
            dgv_select.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
            myadapter.Fill(dtplayer);
            dgv_select.DataSource = dtplayer;
        }

        private void mouseclick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (panel_detail.Controls.Count == 1)
            {
                panel_detail.Controls.Clear();
            }
            FormDetail newform = new FormDetail(teamid,dgv_select.CurrentCell.RowIndex);
            newform.TopLevel = false;
            newform.FormBorderStyle = FormBorderStyle.None;
            newform.Dock = DockStyle.Fill;
            panel_detail.Controls.Add(newform);
            newform.Show();
        }
    }
}

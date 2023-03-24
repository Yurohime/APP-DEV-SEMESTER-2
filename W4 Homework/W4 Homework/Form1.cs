using System.Diagnostics.Metrics;
using System.Numerics;
using System.Windows.Forms.VisualStyles;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace W4_Homework
{
    public partial class Form1 : Form
    {
        List<Team> teamlist = new List<Team>();
        public string selected_player = "";
        public Form1()
        {
            InitializeComponent();
            Preset preset = new Preset();
            teamlist.Add(preset.Team1());
            teamlist.Add(preset.Team2());
            teamlist.Add(preset.Team3());
            Comboboxupdate();
        }

        private void button_add_team_Click(object sender, EventArgs e)
        {
            bool added = false;
            foreach (Team teamism in teamlist)
            {
                if (teamism.Name == tbox_team_name.Text)
                {
                    MessageBox.Show("Team already added");
                    added = true;
                }
            }
            if (added == false)
            {
                cbox_team.Items.Clear();
                Team team = new Team();
                team.Country = tbox_team_country.Text;
                team.Name = tbox_team_name.Text;
                team.City = tbox_team_city.Text;
                team.PlayerList = new List<Player>();
                teamlist.Add(team);
                Comboboxupdate();
                tbox_team_country.Text = "";
                tbox_team_name.Text = "";
                tbox_team_city.Text = "";
            }
        }
        // Independent Metode
        private void Comboboxupdate()
        {
            cbox_country.Items.Clear();
            foreach(Team team in teamlist)
            {
                if (!cbox_country.Items.Contains(team.Country))
                {
                    cbox_country.Items.Add(team.Country);
                }
            }
        }
        private void Comboboxupdateteam()
        {
            cbox_team.Items.Clear();
            foreach (Team team in teamlist)
            {
                if (team.Country == cbox_country.SelectedItem.ToString())
                {
                    cbox_team.Items.Add(team.Name);
                }
            }
        }
        public void RosterUpdate()
        {
            lbox_player.Items.Clear();
            foreach (Team team in teamlist)
            {
                if (team.Name == cbox_team.SelectedItem.ToString())
                {
                    foreach(Player player in team.PlayerList)
                    {
                        lbox_player.Items.Add($"[{player.Number}]{player.Name},{player.Pos}");
                    }
                }
            }
            lbox_player.Sorted = true;
        }
        // Noin
        private void Country_Selected(object sender, EventArgs e)
        {
            lbox_player.Items.Clear();
            Comboboxupdateteam();
        }

        private void Team_Selected(object sender, EventArgs e)
        {
            RosterUpdate();
        }
        private void button_add_player_Click(object sender, EventArgs e)
        {
            if (tbox_player_name.Text == "" || tbox_player_number.Text == "" || cbox_pos.SelectedIndex != -1)
            {
                bool added = false;
                bool numbered = false;
                foreach (Team team in teamlist)
                {
                    for (int i = 0; i < team.PlayerList.Count; i++)
                    {
                        if (team.PlayerList[i].Name == tbox_player_name.Text)
                        {
                            added = true;
                        }
                    }
                    for (int i = 0; i < team.PlayerList.Count; i++)
                    {
                        if (team.PlayerList[i].Number == tbox_player_number.Text)
                        {
                            numbered = true;
                        }
                    }
                    if (added)
                    {
                        MessageBox.Show("Player already added");
                        break;
                    }
                    if (numbered)
                    {
                        MessageBox.Show("Number already added");
                        break;
                    }
                    if (team.Name == cbox_team.SelectedItem.ToString() && added == false)
                    {
                        Player player = new Player();
                        player.Name = tbox_player_name.Text;
                        player.Number = tbox_player_number.Text;
                        player.Pos = this.cbox_pos.GetItemText(this.cbox_pos.SelectedItem);
                        team.PlayerList.Add(player);
                        team.PlayerList.OrderBy(o => o.Number).ToList();
                        RosterUpdate();
                        tbox_player_name.Text = "";
                        tbox_player_number.Text = "";
                        cbox_pos.SelectedIndex = -1;
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }

        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            foreach (Team team in teamlist)
            {
                if (team.Name == cbox_team.SelectedItem.ToString())
                {
                    if (team.PlayerList.Count <= 11)
                    {
                        MessageBox.Show("Too Little Players");
                        break;
                    }
                        for (int i = 0; i < team.PlayerList.Count; i++)
                    {
                        if ($"[{team.PlayerList[i].Number}]{team.PlayerList[i].Name},{team.PlayerList[i].Pos}" == selected_player)
                        {
                            team.PlayerList.RemoveAt(i);
                            i--;
                            RosterUpdate();
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void lbox_value_change(object sender, EventArgs e)
        {
            selected_player = lbox_player.SelectedItem.ToString();
        }
    }
}


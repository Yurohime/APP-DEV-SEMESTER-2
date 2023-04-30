using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel_select.Controls.Count==1)
            {
                panel_select.Controls.Clear();
            }
            FormPlayerData newform = new FormPlayerData();
            newform.TopLevel = false;
            newform.FormBorderStyle = FormBorderStyle.None;
            newform.Dock = DockStyle.Fill;
            panel_select.Controls.Add(newform);
            newform.FormRef = this;
            newform.Show();
        }

        private void matchDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel_select.Controls.Count == 1)
            {
                panel_select.Controls.Clear();
            }
            FormMatchData newform = new FormMatchData();
            newform.TopLevel = false;
            newform.Dock = DockStyle.Fill;
            newform.FormBorderStyle = FormBorderStyle.None;
            panel_select.Controls.Add(newform);
            newform.FormRef = this;
            newform.Show();
        }
    }
}

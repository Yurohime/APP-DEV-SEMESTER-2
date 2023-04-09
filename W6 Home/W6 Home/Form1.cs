using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W6_Home
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbox_attempt.Text) > 3)
            {
                FormGame game = new FormGame(Convert.ToInt32(tbox_attempt.Text));
                game.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W7_Home_II
{
    public partial class FormDebug : Form
    {
        public FormDebug(DataTable dtmovie)
        {
            InitializeComponent();
            viewer_movie.DataSource = dtmovie;
        }

        private void viewer_movie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

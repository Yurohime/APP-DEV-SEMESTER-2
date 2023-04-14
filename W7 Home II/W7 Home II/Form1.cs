using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.InteropServices.ComTypes;

namespace W7_Home_II
{
    public partial class Form1 : Form
    {
        
        public List<string> dataline;
        public DataTable dtmovie = new DataTable();
        List<Movie> movielist;
        public Form1()
        {
            InitializeComponent();
            moviecomposer();
            randomizer();
        }
        public void updateseat(int movieindex, string movietime, string newdata)
        {
            for (int i = 1; i < dataline.Count; i++)
            {
                if (i == movieindex)
                {
                    if (movietime == "9:00")
                    {
                        movielist[i].SeatMorning = newdata;
                    }
                    else if (movietime == "12:30")
                    {
                        movielist[i].SeatNoon = newdata;
                    }
                    else if (movietime == "18:00")
                    {
                        movielist[i].SeatEvening = newdata;
                    }
                }
            }
        }
        public void randomizer()
        {
            Random random = new Random();
            movielist = new List<Movie>();
            for (int i = 1; i < dataline.Count; i++)
            {
                string seatdata = "";
                Movie movie = new Movie();
                string[] dataprocess = dataline[i].Split(' ');
                string name = dataprocess[0].Replace('_', ' ');
                movie.Name = name;
                movie.SeatMorning=  getseatwat(random);
                movie.SeatNoon=  getseatwat(random);
                movie.SeatEvening=  getseatwat(random);
                dtmovie.Rows[i-1][2] = movie.SeatMorning;
                dtmovie.Rows[i-1][3] = movie.SeatNoon;
                dtmovie.Rows[i-1][4] = movie.SeatEvening;
                //MessageBox.Show(movie.SeatMorning);
                //MessageBox.Show(movie.SeatNoon);
                //MessageBox.Show(movie.SeatEvening);

                movielist.Add(movie);
            }
        }
        public string getseatwat(Random random)
        {
            string seatdata = "";
            for (int ip = 0; ip < 100; ip++)
            {
                int yes = random.Next(0, 100);
                if (yes < 69)
                {
                    seatdata = seatdata + (random.Next(0, 2));
                }
                else
                {
                    seatdata = seatdata + 0;
                }
            }
            return seatdata;
        }
        public void moviecomposer()
        {
            dtmovie.Columns.Add("movie");
            dtmovie.Columns.Add("movie_image");
            dtmovie.Columns.Add("Seat Morning");
            dtmovie.Columns.Add("Seat Noon");
            dtmovie.Columns.Add("Seat Evening");

            string username = Environment.UserName;
            string data = File.ReadAllText($@"C:\Users\{username}\source\repos\W7 Home II\W7 Home II\Movie\Movie List.txt");
            string[] dataprocessed = data.Split('-');//starts from 1
            dataline = new List<string>(dataprocessed);
            for (int i = 1; i < dataline.Count; i++)
            {
                string[] dataprocess = dataline[i].Split(' ');
                string name = dataprocess[0].Replace('_', ' ');
                string image = dataprocess[1];
                dtmovie.Rows.Add(name,image,"","","");
            }
        }
        private void movieSeatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FromMovieList movieList = new FromMovieList(dtmovie, movielist);
            movieList.TopLevel = false;
            movieList.Dock = DockStyle.Fill;
            panel_main.Controls.Add(movieList);
            movieList.FormRef = this;
            movieList.Show();
        }

        //Other Menu
        private void moviegridviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDebug debug = new FormDebug(dtmovie);
            debug.TopLevel = false;
            debug.Dock = DockStyle.Fill;
            panel_main.Controls.Add(debug);
            debug.Show();
        }
        public void updatemanual(string time, string data,int index)
        {
            FormSeat movieList = new FormSeat(time,data,index, dtmovie, movielist);
            movieList.FormRef = this;
            movieList.TopLevel = false;
            movieList.Dock = DockStyle.Fill;
            panel_main.Controls.Add(movieList);
            movieList.Show();
        }
        public void UpdateSeat(int index, string time, string data)
        {
            if (time == "9:00")
            {
                dtmovie.Rows[index][2] = data;
            }
            else if (time == "12:30")
            {
                dtmovie.Rows[index][3] = data;
            }
            else
            {
                dtmovie.Rows[index][4] = data;
            }
        }
    }
}

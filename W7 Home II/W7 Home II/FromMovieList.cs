using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Threading;

namespace W7_Home_II
{
    public partial class FromMovieList : Form
    {
        DataTable dtmovie;
        List<Movie> movieList;
        int movieindexselected = 0;
        public FromMovieList(DataTable dtmovie, List<Movie> movieList)
        {
            InitializeComponent();
            this.dtmovie = dtmovie;

            GenerateImage();
            this.movieList = movieList;
        }
        public Form1 FormRef { get; set; }
        public void GenerateTool()
        {
            MenuStrip mstrip = new MenuStrip();
            this.Controls.Add(mstrip);
        }
        public void GenerateImage()
        {
            int initialrow = 45;
            int line = 0;
            string username = Environment.UserName;
            for(int row = 0; row < dtmovie.Rows.Count; row++)
            {
                PictureBox pbox = new PictureBox();
                pbox.Size = new Size(181, 255);
                pbox.Location= new Point(line * 205 + 25, initialrow);
                pbox.BorderStyle = BorderStyle.FixedSingle;
                pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                pbox.Name = dtmovie.Rows[row][0].ToString()+""+ dtmovie.Rows[row][1].ToString();
                pbox.Image = System.Drawing.Image.FromFile($@"C:\Users\{username}\source\repos\W7 HOME\W7 HOME\Movie\{dtmovie.Rows[row][1].ToString()}");
                pbox.Tag = "movieimage"+row;
                pbox.Click += Clickimage;
                this.Controls.Add(pbox);
                line++;

            }
        }
        public async void Clickimage(object sender, EventArgs e)
        {
            //45
            int selectedindex = 0;
            string title = "";
            PictureBox pbox = sender as PictureBox;
            string data = pbox.Name.ToString();
            for (int row = 0; row < dtmovie.Rows.Count; row++)
            {
                if (row.ToString() == pbox.Tag.ToString().Substring(pbox.Tag.ToString().Length - 1, 1))
                {
                    title = dtmovie.Rows[row][0].ToString();
                    selectedindex = row;
                    movieindexselected = row;
                    break;
                }
            }
            //Buttons
            Button btn1 = new Button();
            Button btn2 = new Button();
            Button btn3 = new Button();
            btn1.Click += pictureClick;
            btn2.Click += pictureClick;
            btn3.Click += pictureClick;
            btn1.Tag = data;
            btn2.Tag = data;
            btn3.Tag = data;
            Button btntitle = new Button();
            PictureBox mainbutton = sender as PictureBox;
            int x = mainbutton.Location.X;
            int y = mainbutton.Location.Y;
            if (mainbutton.Location.Y > 0)
            {
                #region anim
                await Task.Delay(41);
                mainbutton.Location = new Point(x, y - 75);
                btn1.Location = new Point(x + 45, y + 220);
                btn1.Size = new Size(100, 30);
                btn1.Text = "9:00";
                this.Controls.Add(btn1);
                await Task.Delay(41);
                mainbutton.Location = new Point(x, y - 110);
                btn2.Location = new Point(x + 45, y + 180);
                btn2.Size = new Size(100, 30);
                btn2.Text = "12:30";
                this.Controls.Add(btn2);
                await Task.Delay(41);
                mainbutton.Location = new Point(x, y - 140);
                btn3.Location = new Point(x + 45, y + 140);
                btn3.Size = new Size(100, 30);
                btn3.Text = "18:00";
                this.Controls.Add(btn3);
                await Task.Delay(41);
                mainbutton.Location = new Point(x, y - 170);
                btntitle.Location = new Point(x + 15, y + 100);
                btntitle.Size = new Size(160, 30);
                btntitle.Text = title;
                btntitle.Font = new Font("Arial", 12, FontStyle.Bold);
                this.Controls.Add(btntitle);
                await Task.Delay(41);
                mainbutton.Location = new Point(x, y - 190);
                await Task.Delay(41);
                mainbutton.Location = new Point(x, y - 200);
                await Task.Delay(41);
                mainbutton.Location = new Point(x, y - 202);
                await Task.Delay(41);
                mainbutton.Location = new Point(x, y - 205);
                #endregion
            }
            else
            {
                #region anim
                await Task.Delay(41);
                mainbutton.Location = new Point(x, y + 75);
                await Task.Delay(41);
                mainbutton.Location = new Point(x, y + 110);
                await Task.Delay(41);
                mainbutton.Location = new Point(x, y + 140);
                await Task.Delay(41);
                this.Controls.Remove(btn3);
                mainbutton.Location = new Point(x, y + 170);
                await Task.Delay(41);
                this.Controls.Remove(btn2);
                mainbutton.Location = new Point(x, y + 190);
                await Task.Delay(41);
                this.Controls.Remove(btn1);
                mainbutton.Location = new Point(x, y + 200);
                await Task.Delay(41);
                mainbutton.Location = new Point(x, y + 202);
                await Task.Delay(41);
                mainbutton.Location = new Point(x, y + 205);
                #endregion
            }
        }
        public void valuechange(object sender, EventArgs e)
        {

        }
        private void pictureClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string time = btn.Text;
            string movieindex = btn.Tag.ToString();
            FormRef.updatemanual(time,movieindex, movieindexselected);
            this.Close();
        }
    }
}

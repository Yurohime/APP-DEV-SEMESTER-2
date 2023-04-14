using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace W7_Home_II
{
    public partial class FormSeat : Form
    {
        DataTable dtmovie;
        List<Movie> movieList;
        Random random = new Random();
        string time;
        string[] data;
        int index;
        string seatdata;
        public FormSeat(string time, string data, int index, DataTable dtmovie, List<Movie> movieList)
        {
            InitializeComponent();
            this.time = time;
            this.data = data.Split(' ');
            this.index = index;
            this.dtmovie = dtmovie;
            this.movieList = movieList;

            CreateObject();
            CreateSeat();
            GetSeat();
            UpdateSeats();
        }
        public Form1 FormRef { get; set; }
        public void CreateObject()
        {
            string username = Environment.UserName;
            PictureBox pbox = new PictureBox();
            pbox.Size = new Size(136, 198);
            pbox.Location = new Point(25, 51);
            pbox.Image = System.Drawing.Image.FromFile($@"C:\Users\{username}\source\repos\W7 HOME\W7 HOME\Movie\{dtmovie.Rows[index][1].ToString()}");
            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pbox);

            Label lbl = new Label();
            lbl.Location = new Point(23, 18);
            lbl.Text = $"{data[0]} [{time}]";
            lbl.AutoSize = true;
            lbl.Font = new Font("Arial", 14, FontStyle.Bold);
            this.Controls.Add(lbl);

            Button btn_add = new Button();
            btn_add.Location = new Point(174, 346 -27);
            btn_add.Text = "Add";
            btn_add.Tag = "object";
            btn_add.Click += Add;
            this.Controls.Add(btn_add);

            //Button btn_remove = new Button();
            //btn_remove.Location = new Point(174, 346 - 27);
            //btn_remove.Text = "Remove";
            //btn_remove.Tag = "object";
            //this.Controls.Add(btn_remove);

            Button btn_reset = new Button();
            btn_reset.Location = new Point(174, 346 - 54);
            btn_reset.Text = "Reset";
            btn_reset.Tag = "object";
            btn_reset.Click += Reset;
            this.Controls.Add(btn_reset);

            Button btn_clear = new Button();
            btn_clear.Location = new Point(174, 346 - 81);
            btn_clear.Text = "Clear";
            btn_clear.Tag = "object";
            btn_clear.Click += Clear;
            this.Controls.Add(btn_clear);

            Button btn_back = new Button();
            btn_back.Location = new Point(12, 346);
            btn_back.Text = "Back";
            btn_back.Click += Back;
            btn_back.Tag = "object";
            this.Controls.Add(btn_back);
        }
        public void CreateSeat()
        {
            int x = 276;
            int y = 18;
            int xoff = 0;
            int yoff = 0;
            for(int i = 0; i < 100; i++)
            {
                Button btn = new Button();
                btn.Location=new Point(x+(xoff), y+(yoff));
                btn.Size = new Size(33,33);
                btn.Tag = i;
                btn.Click += SeatSet;
                this.Controls.Add(btn);
                xoff += 33;
                if (xoff == 66 || xoff == 274)
                {
                    xoff += 10;
                }
                if (xoff == 350)
                {
                    yoff += 33;
                    xoff = 0;
                }
                if (yoff == 132)
                {
                    yoff += 10;
                }
            }
        }
        public void GetSeat()
        {
            if (time == "9:00")
            {
                seatdata = dtmovie.Rows[index][2].ToString();
            }
            else if (time == "12:30")
            {
                seatdata = dtmovie.Rows[index][3].ToString();
            }
            else
            {
                seatdata = dtmovie.Rows[index][4].ToString();
            }
        }
        public void UpdateSeats()
        {
            for(int i = 0; i < 100; i++)
            {
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    if (button.Tag.ToString() == i.ToString())
                    {
                        if (seatdata[i] == '0')
                        {
                            button.BackColor = Color.LightGray;
                        }
                        else
                        {
                            button.BackColor = Color.LightGreen;
                        }
                        break;
                    }
                }
            }
        }
        public void SeatSet(object sender, EventArgs e)
        {
            Button button = sender as Button;
            //if (button.BackColor == Color.LightGreen)
            //{
            //    button.BackColor = Color.Red;
            //}
            //else if (button.BackColor == Color.Red)
            //{
            //    button.BackColor = Color.LightGreen;
            //}
            if (button.BackColor == Color.LightGray)
            {
                button.BackColor = Color.Yellow;
            }
            else if (button.BackColor == Color.Yellow)
            {
                button.BackColor = Color.LightGray;
            }
        }
        public void Add(object sender, EventArgs e)
        {
            int counter = 0;
            int counter2 = 0;
            foreach (Button button in this.Controls.OfType<Button>())
            {
                if (button.BackColor == Color.Yellow)
                {
                    counter++;
                }
            }
            for (int i = 0; i < 100; i++)
            {
                string newseatdata = "";
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    if (button.Tag.ToString() == i.ToString())
                    {
                        if (button.BackColor == Color.Yellow)
                        {
                            button.BackColor = Color.LightGreen;
                            
                            for(int i2 = 0; i2 < 100; i2++)
                            {
                                if (i2 == i)
                                {
                                    newseatdata = newseatdata+"1";
                                    counter2++;
                                }
                                else
                                {
                                    newseatdata = newseatdata + seatdata[i2];
                                }
                            }
                            seatdata = newseatdata;
                            if (counter2 == 3)
                            {
                                break;
                            }
                        }
                    }
                }
                if (counter2 == counter)
                {
                    break;
                }
            }
            FormRef.UpdateSeat(index, time, seatdata);
            UpdateSeats();
        }
        public void Remove(object sender, EventArgs e)
        {

        }
        public void Reset(object sender, EventArgs e)
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
            this.seatdata = seatdata;
            FormRef.UpdateSeat(index, time, seatdata);
            UpdateSeats();
        }
        public void Clear(object sender, EventArgs e)
        {
            seatdata = "";
            for(int i = 0; i < 100; i++)
            {
                seatdata = seatdata + "0";
            }
            FormRef.UpdateSeat(index, time, seatdata);
            UpdateSeats();
        }
        
        public void Back(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

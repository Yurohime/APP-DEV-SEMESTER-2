using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace W5_Home
{
    public partial class Form1 : Form
    {
        Thread thread;
        public Form1()
        {
            InitializeComponent();
            Fancytime();
        }

        private void Enter_the_shop(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Fancytime();
                this.Close();
                thread = new Thread(startmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private async void Realtime_tick(object sender, EventArgs e)
        {

            label_enter.Visible = false;
            await Task.Delay(500);
            label_enter.Visible = true;
            await Task.Delay(500);
        }
        private async void Fancytime()
        {
            panel_gif.Location = new Point(34, 39);
            await Task.Delay(500);
            panel_gif.Location = new Point(55, 38);
            await Task.Delay(100);
            panel_gif.Location = new Point(68, 39);
            await Task.Delay(100);
            panel_gif.Location = new Point(74, 39);
            await Task.Delay(100);
            panel_gif.Location = new Point(87, 39);
            await Task.Delay(100);
            panel_gif.Location = new Point(102, 39);
            await Task.Delay(100);
            panel_gif.Location = new Point(123, 39);
            await Task.Delay(100);
            panel_gif.Location = new Point(137, 39);
            await Task.Delay(100);
            panel_gif.Location = new Point(154, 48);
            await Task.Delay(100);
            panel_gif.Location = new Point(170, 48);
            await Task.Delay(100);
            panel_gif.Location = new Point(185, 48);
            await Task.Delay(100);
            panel_gif.Location = new Point(198, 48);
            await Task.Delay(100);
            panel_gif.Location = new Point(216, 48);
            await Task.Delay(100);
            panel_gif.Location = new Point(237, 48);
            await Task.Delay(100);
            panel_gif.Location = new Point(250, 48);
            await Task.Delay(100);
            panel_gif.Location = new Point(265, 48);
            await Task.Delay(100);
            panel_gif.Location = new Point(288, 48);
            await Task.Delay(100);
            panel_gif.Location = new Point(301, 48);
            await Task.Delay(100);
            panel_gif.Location = new Point(307, 48);
            await Task.Delay(100);
            panel_gif.Location = new Point(321, 48);
            await Task.Delay(100);
            panel_gif.Location = new Point(351, 48);
        }

        private void button_skip_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(startmenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();  
        }
        private void startmenu(object obj)
        {
            Application.Run(new Form_Main());
        }
    }
}

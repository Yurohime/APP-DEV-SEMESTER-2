using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3home
{
    public partial class Second_Window_Form : Form
    {
        public First_Window_Form FormRef { get; set; }
        public Second_Window_Form()
        {
            InitializeComponent();
            Fix();
        }

        private void button_magic_Click(object sender, EventArgs e)
        {
            if ((radioButtonred.Checked || radioButtonblue.Checked || radioButtonyellow.Checked || radioButtonwhite.Checked || radioButtonblack.Checked) && (radioButtonlight.Checked || radioButtondark.Checked || radioButtongray.Checked))
            {
                if (checkBox_agree.Checked && checkBox_term.Checked)
                {
                    if (radioButtonred.Checked)
                    {
                        this.FormRef.BackColor = Color.Red;
                    }
                    else if (radioButtonblue.Checked)
                    {
                        this.FormRef.BackColor = Color.Blue;
                    }
                    else if(radioButtonyellow.Checked)
                    {
                        this.FormRef.BackColor = Color.Yellow;
                    }
                    else if(radioButtonwhite.Checked)
                    {
                        this.FormRef.BackColor = Color.White;
                    }
                    else if(radioButtonblack.Checked)
                    {
                        this.FormRef.BackColor = Color.Black;
                    }
                    if (radioButtonlight.Checked)
                    {
                        this.FormRef.ForeColor = Color.White;
                    }
                    else if (radioButtondark.Checked)
                    {
                        this.FormRef.ForeColor = Color.Black;
                    }
                    else if (radioButtongray.Checked)
                    {
                        this.FormRef.ForeColor = Color.Gray;
                    }
                }
                else
                {
                    MessageBox.Show("You need to agree to the terms");
                }
            }
            else
            {
                MessageBox.Show("You need to pick both a Background Color and a Text Color");
            }
        }
        public void Changename(string name, string artist)
        {
            label_second.Text = $"Hi, my name is {name} and my favorite artist is {artist}";
        }
        public async void Fix()
        {
            await Task.Delay(100);
            radioButtonred.Checked = false;
        }
    }
}

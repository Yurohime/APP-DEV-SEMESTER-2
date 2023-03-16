using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3home.Properties;


namespace W3home
{
    public partial class First_Window_Form : Form
    {
        Second_Window_Form second = new Second_Window_Form();
        
        public bool second_window = false;
        public string color = "";
        public string text = "";
        public First_Window_Form()
        {
            InitializeComponent();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            Second_Window_Form second = new Second_Window_Form();
            second.FormRef = this;
            SetFormClass(second);
            second.Show();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Second_Window_Form>().Any() && checkBox_term.Checked)
            {
                second.Changename(textBox_name.Text, textBox_artist.Text);
            }
            else if (checkBox_term.Checked)
            {
                MessageBox.Show("You havent fulfilled");
            }
        }
        public void Changebackground(string color, string text)
        {
        }
        private async void Realtimetick(object sender, EventArgs e)
        {
        }
        public void SetFormClass(Second_Window_Form thisss)
        {
            second = thisss;
        }
    }
}

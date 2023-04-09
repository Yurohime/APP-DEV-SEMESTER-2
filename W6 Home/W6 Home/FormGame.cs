using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace W6_Home
{
    public partial class FormGame : Form
    {
        public int attempt, line;
        public string keypressed;
        public string answer, guess;
        string[] anotherhugelist;
        List<string> Solved = new List<string>();
        public FormGame(int attempt)
        {
            InitializeComponent();
            this.attempt = attempt;
            line = 0;
            guess = "";
            Createanswer();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            string tagid = "";
            for (int i = 0; i < attempt; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tagid = i.ToString() + "_" + j.ToString();
                    Button button = new Button();
                    button.Size = new Size(50, 50);
                    button.Location = new Point((j * 50)+50, (i * 50)+70);
                    button.Tag = tagid;
                    button.Click += ButtonClick;
                    this.Controls.Add(button);
                }
            }
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            Button lol = sender as Button;
            MessageBox.Show(answer);
        }
        private void Createanswer()
        {
            string ahugenumber = File.ReadAllText("Listofwords.txt");
            anotherhugelist = ahugenumber.Split(',');
            while (true)
            {
                Random random = new Random();
                int answernumber = random.Next(0, anotherhugelist.Length - 1);
                answer = anotherhugelist[answernumber].ToUpper();
                if (answer.Length == 5)
                {
                    break;
                }
            }
        }
        private void Updategrid(int x)
        {
            for (int i = 0; i < 5; i++)
            {
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    string tag = button.Tag.ToString();
                    if (tag == line.ToString() + "_" + i.ToString() && x > i)
                    {
                        button.Text = guess[i].ToString();
                    }
                    else if (tag == line.ToString() + "_" + i.ToString())
                    {
                        button.Text = "";
                    }
                }
            }
        }
        private void Checkgreen()
        {
            for (int i = 0; i < 5; i++)
            {
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    string tag = button.Tag.ToString();
                    if (tag == line.ToString() + "_"+i.ToString())
                    {
                        if (button.Text == answer[i].ToString().ToUpper())
                        {
                            button.BackColor = Color.LightGreen;
                            Solved[i] = " ";
                        }
                    }
                }
            }
        }
        private void Checkyellow()
        {
            foreach (string keyremaining in Solved)
            {
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    string tag = button.Tag.ToString();
                    if (tag == line.ToString() + "_0" && button.Text == keyremaining && button.BackColor != Color.LightGreen && button.BackColor != Color.Yellow)
                    {
                        button.BackColor = Color.Yellow; break;
                    }
                    if (tag == line.ToString() + "_1" && button.Text == keyremaining && button.BackColor != Color.LightGreen && button.BackColor != Color.Yellow)
                    {
                        button.BackColor = Color.Yellow; break;
                    }
                    if (tag == line.ToString() + "_2" && button.Text == keyremaining && button.BackColor != Color.LightGreen && button.BackColor != Color.Yellow)
                    {
                        button.BackColor = Color.Yellow; break;
                    }
                    if (tag == line.ToString() + "_3" && button.Text == keyremaining && button.BackColor != Color.LightGreen && button.BackColor != Color.Yellow)
                    {
                        button.BackColor = Color.Yellow; break;
                    }
                    if (tag == line.ToString() + "_4" && button.Text == keyremaining && button.BackColor != Color.LightGreen && button.BackColor != Color.Yellow)
                    {
                        button.BackColor = Color.Yellow; break;
                    }

                }
            }
            line++;
            guess = "";
        }
        private void Checkwin()
        {
            int counter = 0;
            line = line - 1;
            foreach (Button button in this.Controls.OfType<Button>())
            {
                string tag = button.Tag.ToString();
                if (tag == line.ToString() + "_0" && button.BackColor == Color.LightGreen)
                {
                    counter++;
                }
                if (tag == line.ToString() + "_1" && button.BackColor == Color.LightGreen)
                {
                    counter++;
                }
                if (tag == line.ToString() + "_2" && button.BackColor == Color.LightGreen)
                {
                    counter++;
                }
                if (tag == line.ToString() + "_3" && button.BackColor == Color.LightGreen)
                {
                    counter++;
                }
                if (tag == line.ToString() + "_4" && button.BackColor == Color.LightGreen)
                {
                    counter++;
                }
            }
            line = line + 1;
            if (counter == 5)
            {
                MessageBox.Show("You Won");
            }
            
            else if (line == attempt && counter < 5)
            {
                MessageBox.Show("You Lost, the word was "+ answer);
            }
        }
        private void Commitlinechange()
        {
            ResetSolve();
            Checkgreen();
            Checkyellow();
            Updategrid(0);
            Checkwin();
        }
        private void ResetSolve()
        {
            Solved.Clear();
            for (int i = 0; i < 5; i++)
            {
                Solved.Add(answer[i].ToString().ToUpper());
            }
        }
        private void UpdateWord(string key)
        {
            if (key == "back" && guess.Length > 0)
            {
                guess = guess.Substring(0, guess.Length - 1);
            }
            else if (key == "enter" && guess.Length == 5)
            {
                bool isnotaword = true;
                foreach (string item in anotherhugelist)
                {
                    if (item.ToUpper() == guess)
                    {
                        Commitlinechange();
                        isnotaword = false;
                        break;
                    }
                }
                if (isnotaword)
                {
                    MessageBox.Show("not a word");
                }
                
            }
            else if (key == "enter")
            {
                MessageBox.Show("are you sure, you still have space");
            }
            else if (guess.Length < 5 && guess.Length > -1)
            {
                if (key != "back")
                {
                    guess = guess + key.ToUpper();
                }
                
            }
            Updategrid(guess.Length);
        }
        #region Keybind
        private void btn_back_Click(object sender, EventArgs e)
        {
            UpdateWord("back");
        }

        private void btn_w_Click(object sender, EventArgs e)
        {
            UpdateWord("w");
        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            UpdateWord("e");
        }

        private void btn_r_Click(object sender, EventArgs e)
        {
            UpdateWord("r");
        }

        private void btn_t_Click(object sender, EventArgs e)
        {
            UpdateWord("t");
        }

        private void btn_y_Click(object sender, EventArgs e)
        {
            UpdateWord("y");
        }

        private void btn_u_Click(object sender, EventArgs e)
        {
            UpdateWord("u");
        }

        private void btn_i_Click(object sender, EventArgs e)
        {
            UpdateWord("i");
        }

        private void btn_o_Click(object sender, EventArgs e)
        {
            UpdateWord("o");
        }

        private void btn_p_Click(object sender, EventArgs e)
        {
            UpdateWord("p");
        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            UpdateWord("a");
        }

        private void btn_s_Click(object sender, EventArgs e)
        {
            UpdateWord("s");
        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            UpdateWord("d");
        }

        private void btn_f_Click(object sender, EventArgs e)
        {
            UpdateWord("f");
        }

        private void btn_g_Click(object sender, EventArgs e)
        {
            UpdateWord("g");
        }

        private void btn_h_Click(object sender, EventArgs e)
        {
            UpdateWord("h");
        }

        private void btn_j_Click(object sender, EventArgs e)
        {
            UpdateWord("j");
        }

        private void btn_k_Click(object sender, EventArgs e)
        {
            UpdateWord("k");
        }

        private void btn_l_Click(object sender, EventArgs e)
        {
            UpdateWord("l");
        }

        private void btn_z_Click(object sender, EventArgs e)
        {
            UpdateWord("z");
        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            UpdateWord("x");
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            UpdateWord("c");
        }

        private void btn_v_Click(object sender, EventArgs e)
        {
            UpdateWord("v");
        }

        private void btn_b_Click(object sender, EventArgs e)
        {
            UpdateWord("b");
        }

        private void btn_n_Click(object sender, EventArgs e)
        {
            UpdateWord("n");
        }

        private void btn_m_Click(object sender, EventArgs e)
        {
            UpdateWord("m");
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            UpdateWord("enter");
        }

        private void btn_q_Click(object sender, EventArgs e)
        {
            UpdateWord("q");
        }
        #endregion
    }
}

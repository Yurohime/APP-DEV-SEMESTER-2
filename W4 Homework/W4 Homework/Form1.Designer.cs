namespace W4_Homework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button_add_team = new System.Windows.Forms.Button();
            this.button_add_player = new System.Windows.Forms.Button();
            this.cbox_country = new System.Windows.Forms.ComboBox();
            this.cbox_team = new System.Windows.Forms.ComboBox();
            this.lbox_player = new System.Windows.Forms.ListBox();
            this.button_remove = new System.Windows.Forms.Button();
            this.tbox_team_name = new System.Windows.Forms.TextBox();
            this.tbox_team_country = new System.Windows.Forms.TextBox();
            this.tbox_team_city = new System.Windows.Forms.TextBox();
            this.tbox_player_name = new System.Windows.Forms.TextBox();
            this.tbox_player_number = new System.Windows.Forms.TextBox();
            this.cbox_pos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soccer Team List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adding Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adding Player";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Choose Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Choose Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Team Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Team Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Team City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(507, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Player Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(507, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Player Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(508, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Player Position";
            // 
            // button_add_team
            // 
            this.button_add_team.Location = new System.Drawing.Point(355, 142);
            this.button_add_team.Name = "button_add_team";
            this.button_add_team.Size = new System.Drawing.Size(75, 23);
            this.button_add_team.TabIndex = 11;
            this.button_add_team.Text = "Add";
            this.button_add_team.UseVisualStyleBackColor = true;
            this.button_add_team.Click += new System.EventHandler(this.button_add_team_Click);
            // 
            // button_add_player
            // 
            this.button_add_player.Location = new System.Drawing.Point(599, 141);
            this.button_add_player.Name = "button_add_player";
            this.button_add_player.Size = new System.Drawing.Size(75, 23);
            this.button_add_player.TabIndex = 12;
            this.button_add_player.Text = "Add";
            this.button_add_player.UseVisualStyleBackColor = true;
            this.button_add_player.Click += new System.EventHandler(this.button_add_player_Click);
            // 
            // cbox_country
            // 
            this.cbox_country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_country.FormattingEnabled = true;
            this.cbox_country.Location = new System.Drawing.Point(118, 41);
            this.cbox_country.Name = "cbox_country";
            this.cbox_country.Size = new System.Drawing.Size(121, 23);
            this.cbox_country.TabIndex = 13;
            this.cbox_country.SelectionChangeCommitted += new System.EventHandler(this.Country_Selected);
            // 
            // cbox_team
            // 
            this.cbox_team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_team.FormattingEnabled = true;
            this.cbox_team.Location = new System.Drawing.Point(118, 76);
            this.cbox_team.Name = "cbox_team";
            this.cbox_team.Size = new System.Drawing.Size(121, 23);
            this.cbox_team.TabIndex = 14;
            this.cbox_team.SelectionChangeCommitted += new System.EventHandler(this.Team_Selected);
            // 
            // lbox_player
            // 
            this.lbox_player.FormattingEnabled = true;
            this.lbox_player.ItemHeight = 15;
            this.lbox_player.Location = new System.Drawing.Point(19, 117);
            this.lbox_player.Name = "lbox_player";
            this.lbox_player.Size = new System.Drawing.Size(220, 184);
            this.lbox_player.TabIndex = 15;
            this.lbox_player.SelectedValueChanged += new System.EventHandler(this.lbox_value_change);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(251, 278);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 16;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // tbox_team_name
            // 
            this.tbox_team_name.Location = new System.Drawing.Point(355, 38);
            this.tbox_team_name.Name = "tbox_team_name";
            this.tbox_team_name.Size = new System.Drawing.Size(119, 23);
            this.tbox_team_name.TabIndex = 17;
            // 
            // tbox_team_country
            // 
            this.tbox_team_country.Location = new System.Drawing.Point(355, 72);
            this.tbox_team_country.Name = "tbox_team_country";
            this.tbox_team_country.Size = new System.Drawing.Size(119, 23);
            this.tbox_team_country.TabIndex = 18;
            // 
            // tbox_team_city
            // 
            this.tbox_team_city.Location = new System.Drawing.Point(355, 105);
            this.tbox_team_city.Name = "tbox_team_city";
            this.tbox_team_city.Size = new System.Drawing.Size(119, 23);
            this.tbox_team_city.TabIndex = 19;
            // 
            // tbox_player_name
            // 
            this.tbox_player_name.Location = new System.Drawing.Point(599, 38);
            this.tbox_player_name.Name = "tbox_player_name";
            this.tbox_player_name.Size = new System.Drawing.Size(121, 23);
            this.tbox_player_name.TabIndex = 20;
            // 
            // tbox_player_number
            // 
            this.tbox_player_number.Location = new System.Drawing.Point(599, 71);
            this.tbox_player_number.Name = "tbox_player_number";
            this.tbox_player_number.Size = new System.Drawing.Size(121, 23);
            this.tbox_player_number.TabIndex = 21;
            // 
            // cbox_pos
            // 
            this.cbox_pos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_pos.FormattingEnabled = true;
            this.cbox_pos.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.cbox_pos.Location = new System.Drawing.Point(599, 107);
            this.cbox_pos.Name = "cbox_pos";
            this.cbox_pos.Size = new System.Drawing.Size(121, 23);
            this.cbox_pos.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 321);
            this.Controls.Add(this.cbox_pos);
            this.Controls.Add(this.tbox_player_number);
            this.Controls.Add(this.tbox_player_name);
            this.Controls.Add(this.tbox_team_city);
            this.Controls.Add(this.tbox_team_country);
            this.Controls.Add(this.tbox_team_name);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.lbox_player);
            this.Controls.Add(this.cbox_team);
            this.Controls.Add(this.cbox_country);
            this.Controls.Add(this.button_add_player);
            this.Controls.Add(this.button_add_team);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button_add_team;
        private Button button_add_player;
        private ComboBox cbox_country;
        private ComboBox cbox_team;
        private ListBox lbox_player;
        private Button button_remove;
        private TextBox tbox_team_name;
        private TextBox tbox_team_country;
        private TextBox tbox_team_city;
        private TextBox tbox_player_name;
        private TextBox tbox_player_number;
        private ComboBox cbox_pos;
    }
}
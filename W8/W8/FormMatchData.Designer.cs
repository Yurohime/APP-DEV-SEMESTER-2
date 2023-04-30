namespace W8
{
    partial class FormMatchData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_home = new System.Windows.Forms.DataGridView();
            this.cbox_team = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_detail = new System.Windows.Forms.Panel();
            this.cbox_match = new System.Windows.Forms.ComboBox();
            this.dgv_away = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelhometeamname = new System.Windows.Forms.Label();
            this.labelawayteamname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_matchview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_away)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_home
            // 
            this.dgv_home.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_home.Location = new System.Drawing.Point(12, 105);
            this.dgv_home.Name = "dgv_home";
            this.dgv_home.RowTemplate.Height = 21;
            this.dgv_home.Size = new System.Drawing.Size(121, 251);
            this.dgv_home.TabIndex = 2;
            this.dgv_home.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mouseclickhome);
            // 
            // cbox_team
            // 
            this.cbox_team.FormattingEnabled = true;
            this.cbox_team.Location = new System.Drawing.Point(12, 12);
            this.cbox_team.Name = "cbox_team";
            this.cbox_team.Size = new System.Drawing.Size(121, 20);
            this.cbox_team.TabIndex = 3;
            this.cbox_team.SelectionChangeCommitted += new System.EventHandler(this.Committeam);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Match Detail Stats";
            // 
            // panel_detail
            // 
            this.panel_detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_detail.Location = new System.Drawing.Point(313, 49);
            this.panel_detail.Name = "panel_detail";
            this.panel_detail.Size = new System.Drawing.Size(269, 307);
            this.panel_detail.TabIndex = 5;
            // 
            // cbox_match
            // 
            this.cbox_match.FormattingEnabled = true;
            this.cbox_match.Location = new System.Drawing.Point(12, 38);
            this.cbox_match.Name = "cbox_match";
            this.cbox_match.Size = new System.Drawing.Size(237, 20);
            this.cbox_match.TabIndex = 6;
            this.cbox_match.SelectionChangeCommitted += new System.EventHandler(this.commitmatch);
            // 
            // dgv_away
            // 
            this.dgv_away.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_away.Location = new System.Drawing.Point(165, 105);
            this.dgv_away.Name = "dgv_away";
            this.dgv_away.RowTemplate.Height = 21;
            this.dgv_away.Size = new System.Drawing.Size(121, 251);
            this.dgv_away.TabIndex = 7;
            this.dgv_away.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mouseclickaway);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Home Team Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Away Team Player";
            // 
            // labelhometeamname
            // 
            this.labelhometeamname.AutoSize = true;
            this.labelhometeamname.Location = new System.Drawing.Point(10, 80);
            this.labelhometeamname.Name = "labelhometeamname";
            this.labelhometeamname.Size = new System.Drawing.Size(69, 12);
            this.labelhometeamname.TabIndex = 10;
            this.labelhometeamname.Text = "(home team)";
            // 
            // labelawayteamname
            // 
            this.labelawayteamname.AutoSize = true;
            this.labelawayteamname.Location = new System.Drawing.Point(163, 80);
            this.labelawayteamname.Name = "labelawayteamname";
            this.labelawayteamname.Size = new System.Drawing.Size(68, 12);
            this.labelawayteamname.TabIndex = 11;
            this.labelawayteamname.Text = "(away team)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "(VS)";
            // 
            // btn_matchview
            // 
            this.btn_matchview.Location = new System.Drawing.Point(490, 20);
            this.btn_matchview.Name = "btn_matchview";
            this.btn_matchview.Size = new System.Drawing.Size(92, 23);
            this.btn_matchview.TabIndex = 13;
            this.btn_matchview.Text = "Match Details";
            this.btn_matchview.UseVisualStyleBackColor = true;
            this.btn_matchview.Click += new System.EventHandler(this.btn_matchview_Click);
            // 
            // FormMatchData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 368);
            this.Controls.Add(this.btn_matchview);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelawayteamname);
            this.Controls.Add(this.labelhometeamname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_away);
            this.Controls.Add(this.cbox_match);
            this.Controls.Add(this.panel_detail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_team);
            this.Controls.Add(this.dgv_home);
            this.Name = "FormMatchData";
            this.Text = "FormMatchData";
            this.Load += new System.EventHandler(this.FormMatchData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_away)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_home;
        private System.Windows.Forms.ComboBox cbox_team;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_detail;
        private System.Windows.Forms.ComboBox cbox_match;
        private System.Windows.Forms.DataGridView dgv_away;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelhometeamname;
        private System.Windows.Forms.Label labelawayteamname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_matchview;
    }
}
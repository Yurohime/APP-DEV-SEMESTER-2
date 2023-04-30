namespace W8
{
    partial class FormPlayerData
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
            this.cbox_team = new System.Windows.Forms.ComboBox();
            this.dgv_select = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_detail = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_select)).BeginInit();
            this.SuspendLayout();
            // 
            // cbox_team
            // 
            this.cbox_team.FormattingEnabled = true;
            this.cbox_team.Location = new System.Drawing.Point(12, 12);
            this.cbox_team.Name = "cbox_team";
            this.cbox_team.Size = new System.Drawing.Size(121, 20);
            this.cbox_team.TabIndex = 0;
            this.cbox_team.SelectionChangeCommitted += new System.EventHandler(this.Committed);
            // 
            // dgv_select
            // 
            this.dgv_select.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_select.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_select.Location = new System.Drawing.Point(12, 49);
            this.dgv_select.Name = "dgv_select";
            this.dgv_select.RowTemplate.Height = 21;
            this.dgv_select.Size = new System.Drawing.Size(238, 307);
            this.dgv_select.TabIndex = 1;
            this.dgv_select.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mouseclick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player Stats Picker";
            // 
            // panel_detail
            // 
            this.panel_detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_detail.Location = new System.Drawing.Point(313, 49);
            this.panel_detail.Name = "panel_detail";
            this.panel_detail.Size = new System.Drawing.Size(269, 307);
            this.panel_detail.TabIndex = 3;
            // 
            // FormPlayerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 368);
            this.Controls.Add(this.panel_detail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_select);
            this.Controls.Add(this.cbox_team);
            this.Name = "FormPlayerData";
            this.Text = "FormPlayerData";
            this.Load += new System.EventHandler(this.FormPlayerData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_select)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_team;
        private System.Windows.Forms.DataGridView dgv_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_detail;
    }
}
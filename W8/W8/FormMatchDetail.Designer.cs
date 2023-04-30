namespace W8
{
    partial class FormMatchDetail
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_detail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelplayerteam = new System.Windows.Forms.Label();
            this.labelaway = new System.Windows.Forms.Label();
            this.labelhome = new System.Windows.Forms.Label();
            this.labeldate = new System.Windows.Forms.Label();
            this.labelref = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Match Stats";
            // 
            // dgv_detail
            // 
            this.dgv_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detail.Location = new System.Drawing.Point(8, 138);
            this.dgv_detail.Name = "dgv_detail";
            this.dgv_detail.RowTemplate.Height = 21;
            this.dgv_detail.Size = new System.Drawing.Size(245, 130);
            this.dgv_detail.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(8, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Match Details";
            // 
            // labelplayerteam
            // 
            this.labelplayerteam.AutoSize = true;
            this.labelplayerteam.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelplayerteam.Location = new System.Drawing.Point(12, 37);
            this.labelplayerteam.Name = "labelplayerteam";
            this.labelplayerteam.Size = new System.Drawing.Size(0, 16);
            this.labelplayerteam.TabIndex = 15;
            // 
            // labelaway
            // 
            this.labelaway.AutoSize = true;
            this.labelaway.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelaway.Location = new System.Drawing.Point(8, 54);
            this.labelaway.Name = "labelaway";
            this.labelaway.Size = new System.Drawing.Size(88, 16);
            this.labelaway.TabIndex = 16;
            this.labelaway.Text = "Away Team:";
            // 
            // labelhome
            // 
            this.labelhome.AutoSize = true;
            this.labelhome.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelhome.Location = new System.Drawing.Point(8, 34);
            this.labelhome.Name = "labelhome";
            this.labelhome.Size = new System.Drawing.Size(90, 16);
            this.labelhome.TabIndex = 17;
            this.labelhome.Text = "Home Team:";
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labeldate.Location = new System.Drawing.Point(8, 72);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(42, 16);
            this.labeldate.TabIndex = 18;
            this.labeldate.Text = "Date:";
            // 
            // labelref
            // 
            this.labelref.AutoSize = true;
            this.labelref.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelref.Location = new System.Drawing.Point(8, 91);
            this.labelref.Name = "labelref";
            this.labelref.Size = new System.Drawing.Size(63, 16);
            this.labelref.TabIndex = 19;
            this.labelref.Text = "Referee:";
            // 
            // FormMatchDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 268);
            this.Controls.Add(this.labelref);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.labelhome);
            this.Controls.Add(this.labelaway);
            this.Controls.Add(this.labelplayerteam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_detail);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMatchDetail";
            this.Text = "FormMatchDetail";
            this.Load += new System.EventHandler(this.FormMatchDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_detail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelplayerteam;
        private System.Windows.Forms.Label labelaway;
        private System.Windows.Forms.Label labelhome;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Label labelref;
    }
}
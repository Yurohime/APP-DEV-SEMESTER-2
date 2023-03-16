namespace W3home
{
    partial class First_Window_Form
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
            this.components = new System.ComponentModel.Container();
            this.button_next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_artist = new System.Windows.Forms.TextBox();
            this.checkBox_term = new System.Windows.Forms.CheckBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.Realtime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(14, 121);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(130, 36);
            this.button_next.TabIndex = 0;
            this.button_next.Text = "Open Next Form";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(84, 12);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 19);
            this.textBox_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "My Favorite Artist";
            // 
            // textBox_artist
            // 
            this.textBox_artist.Location = new System.Drawing.Point(14, 85);
            this.textBox_artist.Name = "textBox_artist";
            this.textBox_artist.Size = new System.Drawing.Size(182, 19);
            this.textBox_artist.TabIndex = 4;
            // 
            // checkBox_term
            // 
            this.checkBox_term.AutoSize = true;
            this.checkBox_term.Location = new System.Drawing.Point(14, 187);
            this.checkBox_term.Name = "checkBox_term";
            this.checkBox_term.Size = new System.Drawing.Size(193, 16);
            this.checkBox_term.TabIndex = 5;
            this.checkBox_term.Text = "I agree with the above statement";
            this.checkBox_term.UseVisualStyleBackColor = true;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(14, 218);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(130, 36);
            this.button_submit.TabIndex = 6;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // Realtime
            // 
            this.Realtime.Enabled = true;
            this.Realtime.Tick += new System.EventHandler(this.Realtimetick);
            // 
            // First_Window_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(250, 273);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.checkBox_term);
            this.Controls.Add(this.textBox_artist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_next);
            this.Name = "First_Window_Form";
            this.Text = "Main Window Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_artist;
        private System.Windows.Forms.CheckBox checkBox_term;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Timer Realtime;
    }
}


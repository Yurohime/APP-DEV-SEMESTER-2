namespace W5_Home
{
    partial class Form1
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
            this.label_title = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_enter = new System.Windows.Forms.Label();
            this.Realtime = new System.Windows.Forms.Timer(this.components);
            this.panel_gif = new System.Windows.Forms.Panel();
            this.button_skip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_title.Location = new System.Drawing.Point(29, 48);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(313, 27);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Welcome to the Bob Salon";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(114, 122);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(126, 12);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Please enter your name";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(130, 137);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 19);
            this.textBox_name.TabIndex = 2;
            this.textBox_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_the_shop);
            // 
            // label_enter
            // 
            this.label_enter.AutoSize = true;
            this.label_enter.Location = new System.Drawing.Point(144, 159);
            this.label_enter.Name = "label_enter";
            this.label_enter.Size = new System.Drawing.Size(71, 12);
            this.label_enter.TabIndex = 3;
            this.label_enter.Text = "(press enter)";
            // 
            // Realtime
            // 
            this.Realtime.Interval = 1000;
            this.Realtime.Tick += new System.EventHandler(this.Realtime_tick);
            // 
            // panel_gif
            // 
            this.panel_gif.Location = new System.Drawing.Point(34, 48);
            this.panel_gif.Name = "panel_gif";
            this.panel_gif.Size = new System.Drawing.Size(308, 45);
            this.panel_gif.TabIndex = 4;
            // 
            // button_skip
            // 
            this.button_skip.Location = new System.Drawing.Point(321, 2);
            this.button_skip.Name = "button_skip";
            this.button_skip.Size = new System.Drawing.Size(47, 28);
            this.button_skip.TabIndex = 5;
            this.button_skip.Text = "Skip";
            this.button_skip.UseVisualStyleBackColor = true;
            this.button_skip.Click += new System.EventHandler(this.button_skip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 221);
            this.Controls.Add(this.button_skip);
            this.Controls.Add(this.panel_gif);
            this.Controls.Add(this.label_enter);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_enter;
        private System.Windows.Forms.Timer Realtime;
        private System.Windows.Forms.Panel panel_gif;
        private System.Windows.Forms.Button button_skip;
    }
}


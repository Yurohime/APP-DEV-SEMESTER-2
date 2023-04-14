namespace W7_Home_II
{
    partial class FormDebug
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
            this.viewer_movie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewer_movie)).BeginInit();
            this.SuspendLayout();
            // 
            // viewer_movie
            // 
            this.viewer_movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewer_movie.Location = new System.Drawing.Point(29, 12);
            this.viewer_movie.Name = "viewer_movie";
            this.viewer_movie.RowTemplate.Height = 21;
            this.viewer_movie.Size = new System.Drawing.Size(568, 325);
            this.viewer_movie.TabIndex = 0;
            this.viewer_movie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewer_movie_CellContentClick);
            // 
            // FormDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 367);
            this.Controls.Add(this.viewer_movie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDebug";
            this.Text = "FormDebug";
            ((System.ComponentModel.ISupportInitialize)(this.viewer_movie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewer_movie;
    }
}
namespace W5_Home
{
    partial class Form_Main
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
            this.viewer_main = new System.Windows.Forms.DataGridView();
            this.viewer_category = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_filter_all = new System.Windows.Forms.Button();
            this.button_filter_select = new System.Windows.Forms.Button();
            this.cbox_filter = new System.Windows.Forms.ComboBox();
            this.tbox_pro_name = new System.Windows.Forms.TextBox();
            this.tbox_pro_cost = new System.Windows.Forms.TextBox();
            this.tbox_pro_stock = new System.Windows.Forms.TextBox();
            this.cbox_pro_category = new System.Windows.Forms.ComboBox();
            this.tbox_cat_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_pro_edit = new System.Windows.Forms.Button();
            this.button_pro_add = new System.Windows.Forms.Button();
            this.button_add_remove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_cat_add = new System.Windows.Forms.Button();
            this.button_cat_remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewer_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewer_category)).BeginInit();
            this.SuspendLayout();
            // 
            // viewer_main
            // 
            this.viewer_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewer_main.Location = new System.Drawing.Point(28, 62);
            this.viewer_main.Name = "viewer_main";
            this.viewer_main.RowTemplate.Height = 21;
            this.viewer_main.Size = new System.Drawing.Size(538, 223);
            this.viewer_main.TabIndex = 0;
            this.viewer_main.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.viewer_main_click);
            // 
            // viewer_category
            // 
            this.viewer_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewer_category.Location = new System.Drawing.Point(599, 64);
            this.viewer_category.Name = "viewer_category";
            this.viewer_category.RowTemplate.Height = 21;
            this.viewer_category.Size = new System.Drawing.Size(240, 150);
            this.viewer_category.TabIndex = 1;
            this.viewer_category.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Category_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(595, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category";
            // 
            // button_filter_all
            // 
            this.button_filter_all.Location = new System.Drawing.Point(168, 29);
            this.button_filter_all.Name = "button_filter_all";
            this.button_filter_all.Size = new System.Drawing.Size(75, 23);
            this.button_filter_all.TabIndex = 4;
            this.button_filter_all.Text = "All";
            this.button_filter_all.UseVisualStyleBackColor = true;
            this.button_filter_all.Click += new System.EventHandler(this.button_filter_all_Click);
            // 
            // button_filter_select
            // 
            this.button_filter_select.Location = new System.Drawing.Point(249, 29);
            this.button_filter_select.Name = "button_filter_select";
            this.button_filter_select.Size = new System.Drawing.Size(75, 23);
            this.button_filter_select.TabIndex = 5;
            this.button_filter_select.Text = "Filter";
            this.button_filter_select.UseVisualStyleBackColor = true;
            this.button_filter_select.Click += new System.EventHandler(this.button_filter_select_Click);
            // 
            // cbox_filter
            // 
            this.cbox_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_filter.Enabled = false;
            this.cbox_filter.FormattingEnabled = true;
            this.cbox_filter.Location = new System.Drawing.Point(330, 29);
            this.cbox_filter.Name = "cbox_filter";
            this.cbox_filter.Size = new System.Drawing.Size(121, 20);
            this.cbox_filter.TabIndex = 6;
            this.cbox_filter.SelectionChangeCommitted += new System.EventHandler(this.Selected_filter);
            // 
            // tbox_pro_name
            // 
            this.tbox_pro_name.Location = new System.Drawing.Point(100, 292);
            this.tbox_pro_name.Name = "tbox_pro_name";
            this.tbox_pro_name.Size = new System.Drawing.Size(466, 19);
            this.tbox_pro_name.TabIndex = 7;
            // 
            // tbox_pro_cost
            // 
            this.tbox_pro_cost.Location = new System.Drawing.Point(100, 342);
            this.tbox_pro_cost.Name = "tbox_pro_cost";
            this.tbox_pro_cost.Size = new System.Drawing.Size(100, 19);
            this.tbox_pro_cost.TabIndex = 9;
            this.tbox_pro_cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_cost_press);
            // 
            // tbox_pro_stock
            // 
            this.tbox_pro_stock.Location = new System.Drawing.Point(100, 366);
            this.tbox_pro_stock.Name = "tbox_pro_stock";
            this.tbox_pro_stock.Size = new System.Drawing.Size(100, 19);
            this.tbox_pro_stock.TabIndex = 10;
            this.tbox_pro_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_stock_press);
            // 
            // cbox_pro_category
            // 
            this.cbox_pro_category.FormattingEnabled = true;
            this.cbox_pro_category.Location = new System.Drawing.Point(100, 316);
            this.cbox_pro_category.Name = "cbox_pro_category";
            this.cbox_pro_category.Size = new System.Drawing.Size(100, 20);
            this.cbox_pro_category.TabIndex = 11;
            // 
            // tbox_cat_name
            // 
            this.tbox_cat_name.Location = new System.Drawing.Point(664, 233);
            this.tbox_cat_name.Name = "tbox_cat_name";
            this.tbox_cat_name.Size = new System.Drawing.Size(175, 19);
            this.tbox_cat_name.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(595, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Name:";
            // 
            // button_pro_edit
            // 
            this.button_pro_edit.Location = new System.Drawing.Point(275, 345);
            this.button_pro_edit.Name = "button_pro_edit";
            this.button_pro_edit.Size = new System.Drawing.Size(61, 42);
            this.button_pro_edit.TabIndex = 17;
            this.button_pro_edit.Text = "Edit Product";
            this.button_pro_edit.UseVisualStyleBackColor = true;
            this.button_pro_edit.Click += new System.EventHandler(this.button_pro_edit_Click);
            // 
            // button_pro_add
            // 
            this.button_pro_add.Location = new System.Drawing.Point(214, 345);
            this.button_pro_add.Name = "button_pro_add";
            this.button_pro_add.Size = new System.Drawing.Size(55, 42);
            this.button_pro_add.TabIndex = 16;
            this.button_pro_add.Text = "Add product";
            this.button_pro_add.UseVisualStyleBackColor = true;
            this.button_pro_add.Click += new System.EventHandler(this.button_pro_add_Click);
            // 
            // button_add_remove
            // 
            this.button_add_remove.Location = new System.Drawing.Point(342, 345);
            this.button_add_remove.Name = "button_add_remove";
            this.button_add_remove.Size = new System.Drawing.Size(56, 42);
            this.button_add_remove.TabIndex = 18;
            this.button_add_remove.Text = "Remove item";
            this.button_add_remove.UseVisualStyleBackColor = true;
            this.button_add_remove.Click += new System.EventHandler(this.button_add_remove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(23, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(23, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(23, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(24, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Stock:";
            // 
            // button_cat_add
            // 
            this.button_cat_add.Location = new System.Drawing.Point(705, 258);
            this.button_cat_add.Name = "button_cat_add";
            this.button_cat_add.Size = new System.Drawing.Size(65, 42);
            this.button_cat_add.TabIndex = 23;
            this.button_cat_add.Text = "Add Category";
            this.button_cat_add.UseVisualStyleBackColor = true;
            this.button_cat_add.Click += new System.EventHandler(this.button_cat_add_Click);
            // 
            // button_cat_remove
            // 
            this.button_cat_remove.Location = new System.Drawing.Point(776, 258);
            this.button_cat_remove.Name = "button_cat_remove";
            this.button_cat_remove.Size = new System.Drawing.Size(63, 42);
            this.button_cat_remove.TabIndex = 24;
            this.button_cat_remove.Text = "Remove Category";
            this.button_cat_remove.UseVisualStyleBackColor = true;
            this.button_cat_remove.Click += new System.EventHandler(this.button_cat_remove_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 408);
            this.Controls.Add(this.button_cat_remove);
            this.Controls.Add(this.button_cat_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_add_remove);
            this.Controls.Add(this.button_pro_edit);
            this.Controls.Add(this.button_pro_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox_cat_name);
            this.Controls.Add(this.cbox_pro_category);
            this.Controls.Add(this.tbox_pro_stock);
            this.Controls.Add(this.tbox_pro_cost);
            this.Controls.Add(this.tbox_pro_name);
            this.Controls.Add(this.cbox_filter);
            this.Controls.Add(this.button_filter_select);
            this.Controls.Add(this.button_filter_all);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewer_category);
            this.Controls.Add(this.viewer_main);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewer_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewer_category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewer_main;
        private System.Windows.Forms.DataGridView viewer_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_filter_all;
        private System.Windows.Forms.Button button_filter_select;
        private System.Windows.Forms.ComboBox cbox_filter;
        private System.Windows.Forms.TextBox tbox_pro_name;
        private System.Windows.Forms.TextBox tbox_pro_cost;
        private System.Windows.Forms.TextBox tbox_pro_stock;
        private System.Windows.Forms.ComboBox cbox_pro_category;
        private System.Windows.Forms.TextBox tbox_cat_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_pro_edit;
        private System.Windows.Forms.Button button_pro_add;
        private System.Windows.Forms.Button button_add_remove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_cat_add;
        private System.Windows.Forms.Button button_cat_remove;
    }
}
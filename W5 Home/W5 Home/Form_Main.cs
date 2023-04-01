using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W5_Home
{
    public partial class Form_Main : Form
    {
        List<Items> itemlist = new List<Items>();
        DataTable dtProductSaved = new DataTable();
        DataTable dtProductFiltered = new DataTable();
        DataTable dtCategory = new DataTable();
        public string selected_filter = "";
        public int selected_filter_state = 1;
        public Form_Main()
        {
            InitializeComponent();
            //Hidden
            dtProductSaved.Columns.Add("ID Product");
            dtProductSaved.Columns.Add("Product Name");
            dtProductSaved.Columns.Add("Cost");
            dtProductSaved.Columns.Add("Stock");
            dtProductSaved.Columns.Add("ID Category");

            //Shown
            dtProductFiltered.Columns.Add("ID Product");
            dtProductFiltered.Columns.Add("Product Name");
            dtProductFiltered.Columns.Add("Cost");
            dtProductFiltered.Columns.Add("Stock");
            dtProductFiltered.Columns.Add("ID Category");

            //Category
            dtCategory.Columns.Add("Category ID");
            dtCategory.Columns.Add("Category Name");
            viewer_category.DataSource = dtCategory;
            viewer_main.DataSource = dtProductFiltered;

            Preset();
            PresetCatagory();
            Display(1);
            DisplayCategory();
        }
        //filter button
        private void button_filter_all_Click(object sender, EventArgs e)
        {
            selected_filter_state = 1;
            cbox_filter.SelectedIndex = -1;
            cbox_filter.Enabled = false;
            Display(1);
        }

        private void button_filter_select_Click(object sender, EventArgs e)
        {
            selected_filter_state = 2;
            cbox_filter.Enabled = true;
        }
        //filter button 

        //Other
        private void Preset()
        {
            string[] product_name_list_preset = { "Apple's Shirt", "Apple's T-Shirt" ,"Bee's Style", "The Bomb", "A Literal Gun","Good Shirt","Sword","Chainmail"};
            string[] product_cost_preset = { "100000","20000","45000","75000","250000", "750000", "125000", "75000" };
            string[] product_stock_preset = { "20","300","34","678","34", "20", "140", "15" };
            string[] product_category_preset = { "C1","C3","C1","C2","C4", "C1", "C4", "C5" };
            List<string> ID = new List<string>();
            for (int i = 0; i < product_name_list_preset.Length; i++)
            {
                string data = IDgetter(product_name_list_preset[i]);
                ID.Add(data);
                dtProductSaved.Rows.Add(ID[i], product_name_list_preset[i], product_cost_preset[i], product_stock_preset[i], product_category_preset[i]);
            }
            
        }
        private void PresetCatagory()
        {
            string[] category_name = {"Shirt","Better Shirt","A Design","Weapon","Armor","Misc" };
            string[] category_ID = {"C1","C2","C3","C4","C5","C6" };
            for (int i = 0; i < category_name.Length; i++)
            {
                dtCategory.Rows.Add(category_ID[i], category_name[i]);
            }
        }
        //Tools
        private void Display(int val)
        {
            dtProductFiltered.Clear();
            switch (val)
            {
                case 1://No Filters
                    for (int i = 0; i < dtProductSaved.Rows.Count; i++)
                    {
                        dtProductFiltered.Rows.Add(dtProductSaved.Rows[i][0].ToString(), dtProductSaved.Rows[i][1].ToString(), dtProductSaved.Rows[i][2].ToString(), dtProductSaved.Rows[i][3].ToString(), dtProductSaved.Rows[i][4].ToString());
                    }
                    break;
                case 2://Filtered
                    for (int i = 0; i < dtProductSaved.Rows.Count; i++)
                    {
                        if (selected_filter == dtProductSaved.Rows[i][4].ToString())
                        {
                            dtProductFiltered.Rows.Add(dtProductSaved.Rows[i][0].ToString(), dtProductSaved.Rows[i][1].ToString(), dtProductSaved.Rows[i][2].ToString(), dtProductSaved.Rows[i][3].ToString(), dtProductSaved.Rows[i][4].ToString());
                        }
                    }
                    break;
            }  
        }
        private void DisplayCategory()
        {
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                cbox_filter.Items.Add(dtCategory.Rows[i][1].ToString());
                cbox_pro_category.Items.Add(dtCategory.Rows[i][1].ToString());
            }
        }
        private void ClearText()
        {
            tbox_cat_name.Text = "";
            tbox_pro_cost.Text = "";
            tbox_pro_name.Text = "";
            tbox_pro_stock.Text = "";
            cbox_pro_category.SelectedIndex = -1;
        }
        private string IDgetter(string name)
        {
            int counter = 1;
            string result = "";
            result = name.Substring(0,1).ToUpper();
            
            for (int i = 0; i < dtProductSaved.Rows.Count; i++)
            {
                
                if (dtProductSaved.Rows[i][0].ToString().Substring(0, 1) == result)
                {
                    
                    counter++;
                }
            }

            if (counter.ToString().Length == 1)
            {
                result = result + "00" + counter.ToString();
            }
            else if(counter.ToString().Length == 2)
            {
                result = result + "0" + counter.ToString();
            }
            else if (counter.ToString().Length == 3)
            {
                result = result + counter.ToString();
            }
            return result;
        }
        private string CategoryIDGetter(string val)
        {
            string result = "";
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                if (dtCategory.Rows[i][1].ToString() == val)
                {
                    result = dtCategory.Rows[i][0].ToString();
                    break;
                }
            }
            return result;
        }
        // Object Interaction
        private void Selected_filter(object sender, EventArgs e)
        {
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                if (dtCategory.Rows[i][1].ToString() == cbox_filter.SelectedItem.ToString())
                {
                    selected_filter = dtCategory.Rows[i][0].ToString();
                }
            }
            Display(selected_filter_state);
        }
        private void button_cat_add_Click(object sender, EventArgs e)
        {
            bool newcategory = true;
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                if (dtCategory.Rows[i][1].ToString() == tbox_cat_name.Text)
                {
                    newcategory = false;
                }
            }
            if (newcategory)
            {
                int number = dtCategory.Rows[dtCategory.Rows.Count - 1][0].ToString().Length - 1;
                int newpos = Convert.ToInt32(dtCategory.Rows[dtCategory.Rows.Count - 1][0].ToString().Substring(1, number));
                newpos = newpos + 1;
                dtCategory.Rows.Add( "C" + newpos, tbox_cat_name.Text);
                cbox_filter.Items.Add(tbox_cat_name.Text);
                cbox_pro_category.Items.Add(tbox_cat_name.Text);
            }
            else
            {
                MessageBox.Show("Category already added");
            }
            ClearText();
        }
        private void button_cat_remove_Click(object sender, EventArgs e)
        {
            string category = dtCategory.Rows[viewer_category.CurrentCell.RowIndex][0].ToString();
            string category_named = dtCategory.Rows[viewer_category.CurrentCell.RowIndex][1].ToString();
            for (int i = 0; i < dtProductSaved.Rows.Count; i++)
            {
                if (category == dtProductSaved.Rows[i][4].ToString())
                {
                    dtProductSaved.Rows.RemoveAt(i);
                }
            }
            cbox_filter.SelectedIndex = -1;
            Display(selected_filter_state);
            dtCategory.Rows.RemoveAt(viewer_category.CurrentCell.RowIndex);
            cbox_filter.Items.Add(category_named);
            cbox_pro_category.Items.Add(category_named);
            ClearText();
        }
        private void button_add_remove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {

                if (dtProductSaved.Rows[i][0].ToString() == dtProductFiltered.Rows[viewer_main.CurrentCell.RowIndex][0].ToString())
                {
                    dtProductSaved.Rows.RemoveAt(i);
                    Display(1);
                    ClearText();
                    break;
                }
            }
            cbox_filter.SelectedIndex = -1;
        }
        private void button_pro_add_Click(object sender, EventArgs e)
        {
            string name = tbox_pro_name.Text;
            string ID = IDgetter(tbox_pro_name.Text);
            string cost = tbox_pro_cost.Text;
            string stock = tbox_pro_stock.Text;
            string category = CategoryIDGetter(cbox_pro_category.SelectedItem.ToString());
            dtProductSaved.Rows.Add(ID,name,cost,stock,category);
            Display(selected_filter_state);
            ClearText();
        }
        private void tbox_cost_press(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbox_stock_press(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void button_pro_edit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {

                if (dtProductSaved.Rows[i][0].ToString() == dtProductFiltered.Rows[viewer_main.CurrentCell.RowIndex][0].ToString())
                {
                    dtProductSaved.Rows[i][1] = tbox_pro_name.Text;
                    dtProductSaved.Rows[i][2] = tbox_pro_cost.Text;
                    dtProductSaved.Rows[i][3] = tbox_pro_stock.Text;
                    dtProductSaved.Rows[i][4] = CategoryIDGetter(cbox_pro_category.SelectedItem.ToString());
                    Display(1);
                    ClearText();
                    break;
                }
            }
        }
        private void viewer_main_click(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbox_pro_name.Text = dtProductFiltered.Rows[viewer_main.CurrentCell.RowIndex][1].ToString();
            int counter = 0;
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {

                if (dtCategory.Rows[i][1].ToString() == dtProductFiltered.Rows[viewer_main.CurrentCell.RowIndex][4].ToString())
                {
                    cbox_pro_category.SelectedIndex = counter;
                }
                counter++;
            }
            tbox_pro_stock.Text = dtProductFiltered.Rows[viewer_main.CurrentCell.RowIndex][3].ToString();
            tbox_pro_cost.Text = dtProductFiltered.Rows[viewer_main.CurrentCell.RowIndex][2].ToString();
        }
    }
}
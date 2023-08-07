using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Goods : Form
    {
        // 1-define some classes for showing table of products
        SqlConnection conn = new SqlConnection(@"server=DESKTOP-2IQHR4O\MYTEAM; database=clickteam; integrated security=true");
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        SqlCommandBuilder builder = new SqlCommandBuilder();
        public Goods()
        {
            InitializeComponent();
        }


        // (2)
        //->show Data on DataGridView during the Run
        //-->design columnheader and DefaultCellStyle in datagridview
        private void Goods_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("select * from product", conn);
            adapter.Fill(dt);
            dvg_products.DataSource = dt;

            ///////////////////////////////
            dvg_products.EnableHeadersVisualStyles = false;
            dvg_products.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 18);
            dvg_products.DefaultCellStyle.Font = new Font("Arial",12);
           // dvg_products.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }

        ////////////////////////////// 3-placeholder for textboxes/////////////////////////////////

        //textbox_id placeholder
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txt_id.Text == "ID")
            {
                txt_id.Text = "";
                txt_id.ForeColor = Color.White;
            }
        }
        private void txt_id_Leave(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                txt_id.Text = "ID";
                txt_id.ForeColor = Color.White;
            }
        }

        //textbox_name placeholder
        private void txt_name_Enter_2(object sender, EventArgs e)
        {
            if (txt_name.Text == "Name")
            {
                txt_name.Text = "";
                txt_name.ForeColor = Color.White;
            }
        }
        private void txt_name_Leave_1(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                txt_name.Text = "Name";
                txt_name.ForeColor = Color.DarkGray;
            }
        }

        //textbox_company placeholder
        private void txt_company_Enter(object sender, EventArgs e)
        {
            if (txt_company.Text == "Company")
            {
                txt_company.Text = "";
                txt_company.ForeColor = Color.White;
            }
        }
        private void txt_company_Leave(object sender, EventArgs e)
        {
            if (txt_company.Text == "")
            {
                txt_company.Text = "Company";
                txt_company.ForeColor = Color.DarkGray;
            }
        }

        //textbox_price placeholder
        private void txt_price_Enter(object sender, EventArgs e)
        {
            if (txt_price.Text == "Price")
            {
                txt_price.Text = "";
                txt_price.ForeColor = Color.White;
            }
        }
        private void txt_price_Leave(object sender, EventArgs e)
        {
            if (txt_price.Text == "")
            {
                txt_price.Text = "Price";
                txt_price.ForeColor = Color.DarkGray;
            }
        }

        //textbox_daman placeholder
        private void txt_daman_Enter(object sender, EventArgs e)
        {
            if (txt_daman.Text == "Daman")
            {
                txt_daman.Text = "";
                txt_daman.ForeColor = Color.White;
            }
        }
        private void txt_daman_Leave(object sender, EventArgs e)
        {
            if (txt_daman.Text == "")
            {
                txt_daman.Text = "Daman";
                txt_daman.ForeColor = Color.DarkGray;
            }
        }

        //textbox_search placeholder  and return the table normal after search And AutoComplete txt_search
        private void txt_search_Enter(object sender, EventArgs e)
        {
            if (txt_search.Text == "Search Here")
            {
                txt_search.Text = "";
                txt_search.ForeColor = Color.White;
            }

            AutoCompleteStringCollection txt_completeSearch = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txt_completeSearch.Add(dt.Rows[i][1].ToString());
            }
            txt_search.AutoCompleteCustomSource = txt_completeSearch;
            txt_search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void txt_search_Leave(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                txt_search.Text = "Search Here";
                txt_search.ForeColor = Color.DarkGray;
            }
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text == "" || txt_search.Text == "Search Here")
            {
                SqlDataAdapter ad_changed = new SqlDataAdapter("select *from product", conn);
                DataTable dt_changed = new DataTable();
                ad_changed.Fill(dt_changed);
                dvg_products.DataSource = dt_changed;
            }
        }
        /////////////////////////////placeholder for textboxes///////////////////////



        ///////////////////////////// 4-selection changed on data grid view///////////////////////
        private void dvg_products_SelectionChanged(object sender, EventArgs e)
        {
            if (dvg_products.CurrentRow != null)
            {
                txt_id.ForeColor = Color.White;
                txt_id.Text = dvg_products.CurrentRow.Cells[0].Value.ToString();

                txt_name.ForeColor = Color.White;
                txt_name.Text = dvg_products.CurrentRow.Cells[1].Value.ToString();

                txt_company.ForeColor = Color.White;
                txt_company.Text = dvg_products.CurrentRow.Cells[2].Value.ToString();

                txt_price.ForeColor = Color.White;
                txt_price.Text = dvg_products.CurrentRow.Cells[3].Value.ToString();

                txt_daman.ForeColor = Color.White;
                txt_daman.Text = dvg_products.CurrentRow.Cells[4].Value.ToString();
            }
        }
        /////////////////////////////selection changed on data grid view///////////////////////
        


        ///////////////////////////// 5-click Programming for buttons///////////////////  
        //Button add
        private void btn_add_Click(object sender, EventArgs e)
        {
            //check for empty row
            if (txt_name.Text == "" || txt_id.Text == "" || txt_company.Text == "" || txt_price.Text == "" || txt_daman.Text == "")
            {
                MessageBox.Show("Please Insert Row Correctly !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_name.Text == "Name" || txt_id.Text == "ID" || txt_company.Text == "Company" || txt_price.Text == "Price" || txt_daman.Text == "Daman")
            {
                MessageBox.Show("Please Insert Row Correctly !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //insert row correctly
            else
            {
                DataRow row = dt.NewRow();
                row[0] = txt_id.Text;
                row[1] = txt_name.Text;
                row[2] = txt_company.Text;
                row[3] = txt_price.Text;
                row[4] = txt_daman.Text;
                dt.Rows.Add(row);

                builder = new SqlCommandBuilder(adapter);

                adapter.Update(dt);
                MessageBox.Show("Insertion successed !", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
       
        }

        //Button Update
        private void btn_edit_Click(object sender, EventArgs e)
        {
            //check for empty row
            if (txt_name.Text == "" || txt_id.Text == "" || txt_company.Text == "" || txt_price.Text == "" || txt_daman.Text == "")
            {
                MessageBox.Show("THE Fields Are Empty !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_name.Text == "Name" || txt_id.Text == "ID" || txt_company.Text == "Company" || txt_price.Text == "Price" || txt_daman.Text == "Daman")
            {
                MessageBox.Show("This Default Vlaue !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //UPDATE row correctly
            else
            {
                conn.Open();
                string update = "UPDATE product SET NAME = '" + txt_name.Text + "' , COMPANY='" + txt_company .Text+ "' , PRICE= '" + txt_price.Text + "' , DAMAN='" +  txt_daman.Text + "' WHERE ID='" + txt_id.Text + "' ";
                SqlCommand cmd_update = new SqlCommand(update, conn);
                cmd_update.ExecuteNonQuery();
                MessageBox.Show("Update successed !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

                dvg_products.CurrentRow.Cells[0].Value = txt_id.Text;
                dvg_products.CurrentRow.Cells[1].Value = txt_name.Text;
                dvg_products.CurrentRow.Cells[2].Value = txt_company.Text;
                dvg_products.CurrentRow.Cells[3].Value = txt_price.Text;
                dvg_products.CurrentRow.Cells[4].Value = txt_daman.Text;
            }
        }

        //Button Delete
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //check for empty row
            if (txt_name.Text == "" || txt_id.Text == "" || txt_company.Text == "" || txt_price.Text == "" || txt_daman.Text == "")
            {
                MessageBox.Show("THE Fields Are Empty !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_name.Text == "Name" || txt_id.Text == "ID" || txt_company.Text == "Company" || txt_price.Text == "Price" || txt_daman.Text == "Daman")
            {
                MessageBox.Show("This Default Vlaue !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //delete row correctly
            else
            {
                string delete = "DELETE FROM product WHERE ID='"+txt_id.Text+"'";
                SqlCommand cmd_delete = new SqlCommand(delete, conn);
                conn.Open();
                cmd_delete.ExecuteNonQuery();
                MessageBox.Show("Delete successed !", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                int index = dvg_products.CurrentCell.RowIndex;
                dvg_products.Rows.RemoveAt(index);
            }
        }

        //Button Refersh        
        private void btn_refersh_Click(object sender, EventArgs e)
        {
            txt_name.Text = "Name";
            txt_name.ForeColor = Color.DarkGray;

            txt_company.Text = "Company";
            txt_company.ForeColor = Color.DarkGray;

            txt_price.Text = "Price";
            txt_price.ForeColor = Color.DarkGray;

            txt_daman.Text = "Daman";
            txt_daman.ForeColor = Color.DarkGray;

            txt_search.Text = "Search Here";
            txt_search.ForeColor = Color.DarkGray;
            dvg_products.Refresh();
        }

        //button buy
        private void btn_buy_Click(object sender, EventArgs e)
        {
            //check for empty row
            if (txt_name.Text == "" || txt_id.Text == "" || txt_company.Text == "" || txt_price.Text == "" || txt_daman.Text == "")
            {
                MessageBox.Show("THE Fields Are Empty !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_name.Text == "Name" || txt_id.Text == "ID" || txt_company.Text == "Company" || txt_price.Text == "Price" || txt_daman.Text == "Daman")
            {
                MessageBox.Show("This Default Vlaue !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //UPDATE row correctly
            else
            {
                conn.Open();
                string buy = " INSERT INTO sales VALUES('" +txt_name.Text+ "' , '"+txt_price.Text+"' ,'"+txt_daman.Text+"')";
                SqlCommand cmd_buy = new SqlCommand(buy, conn);
                cmd_buy.ExecuteNonQuery();
                MessageBox.Show("BUY successed !", "BUY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        //button home
        private void btn_home_Click(object sender, EventArgs e)
        {
            List li = new List();
            li.Show();
            this.Close();
        }

        //search button
        private void btn_search_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter ad_search = new SqlDataAdapter("select * from product where NAME ='" +txt_search.Text +"' ",conn);
            DataTable dt_search = new DataTable();
            ad_search.Fill(dt_search);
            dvg_products.DataSource = dt_search;
            conn.Close();
         
        }
        /////////////////////////////click Programming for buttons/////////////////// 

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SalesInvoice : Form
    {
        // 1-define some classes for showing table of sales
        SqlConnection conn3 = new SqlConnection(@"server=DESKTOP-2IQHR4O\MYTEAM; database=clickteam; integrated security=true");
        SqlDataAdapter adapter3;
        DataTable dt3 = new DataTable();
        SqlCommandBuilder builder3 = new SqlCommandBuilder();
        public SalesInvoice()
        {
            InitializeComponent();
        }

        // (2) ->showing data from sales table during the run
        // -->And Find Total price of products which buy
        // --->Autocomplete txt_search
        // ---->design columheader in datagridview
        private void SalesInvoice_Load(object sender, EventArgs e)
        {
            adapter3 = new SqlDataAdapter("select * from sales" ,conn3);
            adapter3.Fill(dt3);
            dvg_sales.DataSource = dt3;

            //////////////////////////////////

            int sum = 0;
            for (int i = 0; i < dvg_sales.Rows.Count; i++)
            {
                sum +=Convert.ToInt32( dvg_sales.Rows[i].Cells[1].Value);
            }
            lab_total.Text = sum+"";

            /////////////////////////////////

            AutoCompleteStringCollection txt_completeSearch = new AutoCompleteStringCollection();
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                txt_completeSearch.Add(dt3.Rows[i][0].ToString());
            }
            txt_search.AutoCompleteCustomSource = txt_completeSearch;
            txt_search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;

            /////////////////////////////////
            dvg_sales.DefaultCellStyle.Font = new Font("Arial", 12);
            dvg_sales.EnableHeadersVisualStyles = false;
            dvg_sales.ColumnHeadersDefaultCellStyle.Font = new Font("Arial",18);
            dvg_sales.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }

        //////////////////3- button click/////////////////////
        //button discount
        private void btn_discount_Click(object sender, EventArgs e)
        {
            //check for empty row
            if (txt_name.Text == "" || txt_price.Text == "" || txt_daman.Text == "")
            {
                MessageBox.Show("THE Fields Are Empty !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (txt_name.Text == "Name" || txt_price.Text == "Price" || txt_daman.Text == "Daman")
            {
                MessageBox.Show("This Default Vlaue !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //int old_price = Convert.ToInt32( txt_price.Text);
            //int cbx = Convert.ToInt32( cbx_discount.SelectedValue);
            //int result1 = old_price * cbx / 100;
            //int res = old_price - result1;
            //txt_price.Text = res +"";
            else
            {
                string discount = "update sales set Price= '" + txt_price.Text + "' Where Name = '" + txt_name.Text + "'";
                SqlCommand cmd_discount = new SqlCommand(discount, conn3);
                conn3.Open();
                cmd_discount.ExecuteNonQuery();
                conn3.Close();
                MessageBox.Show("Discount On This Item successed !", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SqlDataAdapter ad_discount = new SqlDataAdapter("select * from sales ", conn3);
                DataTable dt_discount = new DataTable();
                ad_discount.Fill(dt_discount);
                dvg_sales.DataSource = dt_discount;

                int sum = 0;
                for (int i = 0; i < dvg_sales.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dvg_sales.Rows[i].Cells[1].Value);
                }
                lab_total.Text = sum + "";
            }//else statement
        }

        //button New Bill
        private void btn_bill_Click(object sender, EventArgs e)
        {
            SqlCommand cmd_new = new SqlCommand("delete from sales", conn3);
            conn3.Open();
            cmd_new.ExecuteNonQuery();
            conn3.Close();
            MessageBox.Show("Delete successed !", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dt3.Clear();
            dvg_sales.DataSource = dt3;

            txt_name.ForeColor = Color.DarkGray;
            txt_name.Text = "Name";

            txt_price.ForeColor = Color.DarkGray;
            txt_price.Text = "Price";

            txt_daman.ForeColor = Color.DarkGray;
            txt_daman.Text = "Daman";
            lab_total.Text = "  "+0+"";
        }

        //button home
        private void btn_home_Click(object sender, EventArgs e)
        {
            List li = new List();
            li.Show();
            this.Close();
        }

        //prepare page print to invoice 
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //dvg_sales.RowCount*dvg_sales.RowTemplate.Height*2
            int w = dvg_sales.Width;
            int h = dvg_sales.Height;
            Bitmap bmp = new Bitmap(w, h);
            Rectangle rec = new Rectangle(60,90, w, h);

            dvg_sales.DrawToBitmap(bmp, rec);
            e.Graphics.DrawImage(bmp, rec);
        }

        //button save
        private void btn_pdf_Click(object sender, EventArgs e)
        {
            //TextWriter writer = new StreamWriter("sales.txt");
            //for (int r = 0; r < dvg_sales.Rows.Count; r++)
            //{
            //    writer.WriteLine(dvg_sales.Rows[r].Cells[0].Value.ToString() + "\t"
            //             + "\t" + dvg_sales.Rows[r].Cells[1].Value.ToString() + "\t"
            //             + "\t" + dvg_sales.Rows[r].Cells[2].Value.ToString() + "\t");
            //    writer.WriteLine("___________________________________________________________");
            //}
            //writer.Close();
            //MessageBox.Show("Save successed !", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ((Form)printPreviewDialog1).WindowState=FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        //button search
        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlDataAdapter ad_search = new SqlDataAdapter("select * from sales where Name='" + txt_search.Text + "' ", conn3);
            DataTable dt_search = new DataTable();
            ad_search.Fill(dt_search);
            dvg_sales.DataSource = dt_search;
        }

        //button refersh
        private void btn_refersh_Click(object sender, EventArgs e)
        {
            txt_name.ForeColor = Color.DarkGray;
            txt_name.Text = "Name";

            txt_price.ForeColor = Color.DarkGray;
            txt_price.Text = "Price";

            txt_daman.ForeColor = Color.DarkGray;
            txt_daman.Text = "Daman";

            txt_search.ForeColor = Color.DarkGray;
            txt_search.Text = "Search Here";
        }
        ////////////////// button click/////////////////////



        //////////////////4- PlaceHolder for Textboxes/////////////////////
        //placeholder for txt_name
        private void txt_name_Enter(object sender, EventArgs e)
        {
            if (txt_name.Text == "Name")
            {
                txt_name.Text = "";
                txt_name.ForeColor = Color.White;

            }
        }
        private void txt_name_Leave(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                txt_name.Text = "Name";
                txt_name.ForeColor = Color.DarkGray;

            }
        }

        //placeholder for txt_Price
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

        //placeholder for txt_daman
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

        //placeholder for txt_search
        private void txt_search_Enter(object sender, EventArgs e)
        {
            if (txt_search.Text == "Search Here")
            {
                txt_search.Text = "";
                txt_search.ForeColor = Color.White;

            }
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
                dvg_sales.DataSource = dt3;
            }
        }

        ////////////////// PlaceHolder for Textboxes/////////////////////


        ////////////////// show row from dvg into textboxes/////////////////////
        private void dvg_sales_SelectionChanged(object sender, EventArgs e)
        {
            if (dvg_sales.Rows.Count>1)//check if The table is not empty
            {
                txt_name.ForeColor = Color.White;
                txt_name.Text = dvg_sales.CurrentRow.Cells[0].Value.ToString() + "";

                txt_price.ForeColor = Color.White;
                txt_price.Text = dvg_sales.CurrentRow.Cells[1].Value.ToString();

                txt_daman.ForeColor = Color.White;
                txt_daman.Text = dvg_sales.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                txt_name.Text = "Name";
                txt_name.ForeColor = Color.DarkGray;

                txt_price.Text = "Price";
                txt_price.ForeColor = Color.DarkGray;

                txt_daman.Text = "Daman";
                txt_daman.ForeColor = Color.DarkGray;
            }
        }

        ////////////////// show row from dvg into textboxes/////////////////////
    }
}

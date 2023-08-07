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
using System.IO;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsFormsApplication1
{
    public partial class Supplier : Form
    {
        //1- define some classes for showing data and insertion to table such as buildier 
        SqlConnection conn2 = new SqlConnection(@"server=DESKTOP-2IQHR4O\MYTEAM; database=clickteam; integrated security=true");
        SqlDataAdapter adapter2;
        DataTable dt2 = new DataTable();
        SqlCommandBuilder builder2 = new SqlCommandBuilder();
        public Supplier()
        {
            InitializeComponent();
        }

        //2
        //->show data during the run 
        //-->design DefaultCellStyle in datagridview
        private void Supplier_Load(object sender, EventArgs e)
        {
            adapter2 = new SqlDataAdapter("select * from supplier",conn2);
            adapter2.Fill(dt2);
            dvg_supplier.DataSource = dt2;

            ////////////////////////////
            dvg_supplier.DefaultCellStyle.Font = new System.Drawing.Font("Arial",9);
        }


        //////////////////3- button click event//////////////////
        //button add
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = dt2.NewRow();
                row[0] = txt_id.Text;
                row[1] = txt_client.Text;
                row[2] = txt_total.Text;
                row[3] = txt_pay.Text;
                row[4] = txt_rest.Text;
                row[5] = date.Value;
                dt2.Rows.Add(row);

                builder2 = new SqlCommandBuilder(adapter2);

                adapter2.Update(dt2);
                MessageBox.Show("Insertion successed !", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert Row Correctly !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //button edit
        private void btn_edit_Click(object sender, EventArgs e)
        {
            //check for empty row
            if (txt_client.Text == "" || txt_pay.Text == "" || txt_rest.Text == "" || txt_total.Text == "")
            {
                MessageBox.Show("THE Fields Are Empty !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (txt_client.Text == "Client" || txt_pay.Text == "Payment" || txt_rest.Text == "Rest" || txt_total.Text == "Total")
            {
                MessageBox.Show("This Default Vlaue !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                string upd = "update supplier set Client ='" + txt_client.Text + "',Total = '" + txt_total.Text + "' , Payment = '" + txt_pay.Text + "' , Rest = '" + txt_rest.Text + "' Where ID='" + txt_id.Text + "' ";
                SqlCommand cmd_update = new SqlCommand(upd, conn2);
                conn2.Open();
                cmd_update.ExecuteNonQuery();
                MessageBox.Show("Update successed !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn2.Close();
                dvg_supplier.CurrentRow.Cells[0].Value = txt_id.Text;
                dvg_supplier.CurrentRow.Cells[1].Value = txt_client.Text;
                dvg_supplier.CurrentRow.Cells[2].Value = txt_total.Text;
                dvg_supplier.CurrentRow.Cells[3].Value = txt_pay.Text;
                dvg_supplier.CurrentRow.Cells[4].Value = txt_rest.Text;
                dvg_supplier.CurrentRow.Cells[5].Value = date.Value;
            }
        }

        //button Delete
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //check for empty row
            if (txt_client.Text == "" || txt_pay.Text == "" || txt_rest.Text == "" || txt_total.Text == "")
            {
                MessageBox.Show("THE Fields Are Empty !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (txt_client.Text == "Client" || txt_pay.Text == "Payment" || txt_rest.Text == "Rest" || txt_total.Text == "Total")
            {
                MessageBox.Show("This Default Vlaue !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                string del = "delete from supplier where ID='" + txt_id.Text + "'";
                SqlCommand cmd_del = new SqlCommand(del, conn2);
                conn2.Open();
                cmd_del.ExecuteNonQuery();
                MessageBox.Show("Delete successed !", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn2.Close();
                int index = dvg_supplier.CurrentCell.RowIndex;
                dvg_supplier.Rows.RemoveAt(index);
            }
        }

        //button home
        private void btn_home_Click(object sender, EventArgs e)
        {
            List li = new List();
            li.Show();
            this.Close();
        }

        //button Save
        private void btn_pdf_Click(object sender, EventArgs e)
        {
            //text File
            TextWriter writer = new StreamWriter("supplier.txt");
            for (int r = 0; r < dvg_supplier.Rows.Count; r++)
            {
                writer.WriteLine(dvg_supplier.Rows[r].Cells[0].Value.ToString() + "\t"
                        + "\t" + dvg_supplier.Rows[r].Cells[1].Value.ToString() + "\t"
                        + "\t" + dvg_supplier.Rows[r].Cells[2].Value.ToString() + "\t"
                        + "\t" + dvg_supplier.Rows[r].Cells[3].Value.ToString() + "\t"
                        + "\t" + dvg_supplier.Rows[r].Cells[4].Value.ToString() + "\t"
                        + "\t" + dvg_supplier.Rows[r].Cells[5].Value.ToString() + "\t");
                writer.WriteLine("__________________________________________________________________________________________________________________________________________________________________________________");
            }
            writer.Close();

            //Pdf File
            //Document doc = new Document();
            //PdfWriter.GetInstance(doc,new FileStream("file.pdf",FileMode.Create));
            //doc.Open();
            //for (int r = 0; r < dvg_supplier.Rows.Count; r++)
            //{
            //    Paragraph p1 = new Paragraph(dvg_supplier.Rows[r].Cells[0].Value.ToString() +
            //                                 dvg_supplier.Rows[r].Cells[1].Value.ToString() +
            //                                 dvg_supplier.Rows[r].Cells[2].Value.ToString() +
            //                                 dvg_supplier.Rows[r].Cells[3].Value.ToString() +
            //                                 dvg_supplier.Rows[r].Cells[4].Value.ToString());
            //}
            //doc.Close();
            MessageBox.Show("Save successed !", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //button search
        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlDataAdapter ad_search = new SqlDataAdapter("select * from supplier where Client='"+txt_search.Text+"' ", conn2);
            DataTable dt_search = new DataTable();
            ad_search.Fill(dt_search);
            dvg_supplier.DataSource = dt_search;

            int sum_total= 0;
            int sum_pay = 0;
            int sum_rest = 0;

            for (int i = 0; i < dvg_supplier.Rows.Count; i++)
            {
                sum_total += Convert.ToInt32( dvg_supplier.Rows[i].Cells[2].Value);
                sum_pay += Convert.ToInt32(dvg_supplier.Rows[i].Cells[3].Value);
                sum_rest += Convert.ToInt32(dvg_supplier.Rows[i].Cells[4].Value);
            }
            lab_total.Text = sum_total + "";
            lab_pay.Text = sum_pay + "";
            lab_reset.Text = sum_rest + "";
        }

        //button refersh
        private void btn_refersh_Click(object sender, EventArgs e)
        {
            txt_id.ForeColor = Color.DarkGray;
            txt_id.Text = "ID";

            txt_client.ForeColor = Color.DarkGray;
            txt_client.Text = "Client";

            txt_total.ForeColor = Color.DarkGray;
            txt_total.Text = "Total";

            txt_pay.ForeColor = Color.DarkGray;
            txt_pay.Text = "Paymnt";

            txt_rest.ForeColor = Color.DarkGray;
            txt_rest.Text = "Rest";

            txt_search.ForeColor = Color.DarkGray;
            txt_search.Text = "Search Here";
        }
        ////////////////// button click event//////////////////


        ////////////////// 4- PlaceHolder for textpoxes//////////////////

        // PlaceHolder for txt_id
        private void txt_id_Enter(object sender, EventArgs e)
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
                txt_id.ForeColor = Color.DarkGray;
            }
        }


        // PlaceHolder for txt_client
        private void txt_client_Enter(object sender, EventArgs e)
        {
            if (txt_client.Text == "Client")
            {
                txt_client.Text = "";
                txt_client.ForeColor = Color.White;
            }
        }
        private void txt_client_Leave(object sender, EventArgs e)
        {
            if (txt_client.Text == "")
            {
                txt_client.Text = "Client";
                txt_client.ForeColor = Color.DarkGray;
            }
        }

        // PlaceHolder for txt_Total
        private void txt_total_Enter(object sender, EventArgs e)
        {
            if (txt_total.Text == "Total")
            {
                txt_total.Text = "";
                txt_total.ForeColor = Color.White;
            }
        }
        private void txt_total_Leave(object sender, EventArgs e)
        {
            if (txt_total.Text == "")
            {
                txt_total.Text = "Total";
                txt_total.ForeColor = Color.DarkGray;
            }
        }

        // PlaceHolder for txt_Pay
        private void txt_pay_Enter(object sender, EventArgs e)
        {
            if (txt_pay.Text == "Payment")
            {
                txt_pay.Text = "";
                txt_pay.ForeColor = Color.White;
            }
        }
        private void txt_pay_Leave(object sender, EventArgs e)
        {
            if (txt_pay.Text == "")
            {
                txt_pay.Text = "Pay";
                txt_pay.ForeColor = Color.DarkGray;
            }
        }

        // PlaceHolder for txt_Reset
        private void txt_rest_Enter(object sender, EventArgs e)
        {
            if (txt_rest.Text == "Rest")
            {
                txt_rest.Text = "";
                txt_rest.ForeColor = Color.White;
            }
        }
        private void txt_rest_Leave(object sender, EventArgs e)
        {
            if (txt_rest.Text == "")
            {
                txt_rest.Text = "Rest";
                txt_rest.ForeColor = Color.White;
            }
        }

        // PlaceHolder for txt_reseach And the grd for normal posittion And AutoComplete 
        private void txt_search_TextChanged(object sender, EventArgs e)
        {    
            if (txt_search.Text == "" || txt_search.Text == "Search Here")
            {
                dvg_supplier.DataSource = dt2;
            }
        }
        private void txt_search_Enter(object sender, EventArgs e)
        {
            //AutoCompleteStringCollection txt_completeSearch = new AutoCompleteStringCollection();
            //for (int i = 0; i < dvg_supplier.Rows.Count; i++)
            //{
            //    txt_completeSearch.Add(dvg_supplier.Rows[i].Cells[1].ToString());
            //}
            //txt_search.AutoCompleteCustomSource = txt_completeSearch;
            //txt_search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
        ////////////////// PlaceHolder for textpoxes//////////////////


        ////////////////// 5-show data row from cellselected//////////////////
        private void dvg_supplier_SelectionChanged(object sender, EventArgs e)
        {
            if (dvg_supplier.CurrentRow != null)
            {
                txt_id.ForeColor = Color.White;
                txt_id.Text = dvg_supplier.CurrentRow.Cells[0].Value + "";

                txt_client.ForeColor = Color.White;
                txt_client.Text = dvg_supplier.CurrentRow.Cells[1].Value + "";

                txt_total.ForeColor = Color.White;
                txt_total.Text = dvg_supplier.CurrentRow.Cells[2].Value + "";

                txt_pay.ForeColor = Color.White;
                txt_pay.Text = dvg_supplier.CurrentRow.Cells[3].Value + "";

                txt_rest.ForeColor = Color.White;
                txt_rest.Text = dvg_supplier.CurrentRow.Cells[4].Value + "";

                lab_total.Text = dvg_supplier.CurrentRow.Cells[2].Value + "";
                lab_pay.Text = dvg_supplier.CurrentRow.Cells[3].Value + "";
                lab_reset.Text = dvg_supplier.CurrentRow.Cells[4].Value + "";
            }
        }
        ////////////////// show data row from cellselected//////////////////

    }
}

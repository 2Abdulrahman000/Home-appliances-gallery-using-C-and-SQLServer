using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace WindowsFormsApplication1
{
    public partial class List : Form
    {
        //define variable for sliding in/out panel
        int wd_panel;
        bool hidden;

        //[DllImport("Gdi32", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn(int left,int top, int right, int bottom, int width, int height);
        public List()
        {
            InitializeComponent();
            wd_panel = panel2.Width;
            hidden = false;
            //  Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0,1167,675,20,20));
        }

        //Button 1
        // 1-Move To Goods Form
        private void button1_Click(object sender, EventArgs e)
        {
            Goods goods = new Goods();
            goods.Show();
            this.Close();
        }
        // 2-Mouse Hover to Button Goods
        private void btn_goods_MouseHover(object sender, EventArgs e)
        {
             label2.Text = "Products";
        }
        // 3- MouseLeave from Button Goods
        private void btn_goods_MouseLeave(object sender, EventArgs e)
        {
               label2.Text = "";
        }

        //////////////////////////////////////////////////////////////////////////

        //Button2
        // 1-Move To Sales Form
        private void btn_buy_Click(object sender, EventArgs e)
        {
            SalesInvoice sales = new SalesInvoice();
            sales.Show();
            this.Close();
        }
        // 2-Mouse Hover to Button sales
        private void btn_buy_MouseHover(object sender, EventArgs e)
        {
                  label2.Text = "Sales";
        }
        // 3- MouseLeave from Button Sales
        private void btn_buy_MouseLeave(object sender, EventArgs e)
        {
                   label2.Text = "";
        }

        //////////////////////////////////////////////////////////////////////////

        //Button 3
        // 1-Move To Supplier Form
        private void btn_supplier_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.Show();
            this.Close();
        }
        // 2-Mouse Hover to Button Supplier
        private void btn_supplier_MouseHover(object sender, EventArgs e)
        {
                  label2.Text = "Supplier";
        }
        //3-MouseLeave from Button supplier
        private void btn_supplier_MouseLeave(object sender, EventArgs e)
        {
                 label2.Text = "";
        }

        //////////////////////////////////////////////////////////////////////////

        //Button 4
        ///////// 1-Close
        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure To Exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) timer1.Start();
            else btn_close.Text = "Exit";
        }
        //timer with fade effect to close buton 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= .044;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        ///////////////////////////////////////////////////////////////////////////
        
        //Button 5
        private void btn_slidein_Click(object sender, EventArgs e)
        {
            tmslidein.Start();
        }
        //timer to slide in effect panel
        private void tmslidein_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                panel2.Width += 16;
                if (panel2.Width >= wd_panel)
                {
                    tmslidein.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panel2.Width -= 16;
                if (panel2.Width <= 0)
                {
                    tmslidein.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
            //////////////////////////////////////////////////////////////////////////
        }
        //////////////////////////////////////////////////////////////////////////
        private void List_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class welcomeForm : Form
    {
        //define some variable for diplay letter by letter in label
        int counter = 0;
        string letter;
        int len;
        public welcomeForm()
        {
            InitializeComponent();
        }

        //Avtivate loading and diplay letter by letter in label
        private void welcomeForm_Load(object sender, EventArgs e)
        {
            letter = lb_letter.Text;
            len = letter.Length;
            lb_letter.Text = "";
            timer_loading.Start();
            timer_panel.Start();      
        }



        //////////////////////Animations//////////////////////////////
        ///diplay letter by letter in label
        private void timer_loading_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > len)
            {
                timer_loading.Stop();
                lb_letter.ForeColor = Color.Cyan;
            }
            else lb_letter.Text = letter.Substring(0, counter);
        }

        //loading Animation
        private void timer_panel_Tick(object sender, EventArgs e)
        {
            panel_loading.Width += 14;
            if(panel_loading.Width > this.Width)
            {
                timer_panel.Stop();
                Form1 frm = new Form1();
                this.Hide();
                frm.Show();
            }
        }
        //////////////////////Animations//////////////////////////////
    }
}

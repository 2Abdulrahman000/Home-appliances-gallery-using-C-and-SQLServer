using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //Define sqlconnection to server and databas
        SqlConnection conc = new SqlConnection(@"server=DESKTOP-2IQHR4O\MYTEAM; database=clickteam;integrated security =true");

        //make splash screen//تم الغاءه
        public Form1()
        {
          
           // Thread t = new Thread(new ThreadStart(splash));
           //t.Start();
            InitializeComponent();
          //Thread.Sleep(5100);
          //t.Abort();
        }

        //method to deisgn and display splash screen
        void splash()
        {
            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.AppName = "System Design";
            Application.Run(frm);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //login button to enter to the list form
        private void button1_Click(object sender, EventArgs e)
        {
            //////////////////////make string in sqlcommand
          //  string checkpassword="select * from lgin where username='"+txt_username.Text+"' AND password= '"+txt_password.Text+"' ";
          //  SqlCommand cmd = new SqlCommand(checkpassword,conc);

            /////////////////open the connection///
          //  conc.Open();

            ///////////////////////////excute the command which need sqlreader
          //  SqlDataReader reader = cmd.ExecuteReader();

            //////////////////////read data if was existed
         //   reader.Read();

            //////////////////check info for log in
          /*  if (reader.HasRows)
            {
                MessageBox.Show("Log In Successed" , "Log In" ,MessageBoxButtons.OK,MessageBoxIcon.Information);
                List l = new List();
                l.Show();
                this.Hide();
            }*/
            if (txt_username.Text == "Abdo Elkabany" && txt_password.Text=="1042000")
            {
                MessageBox.Show("Log In Successed", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List l = new List();
                l.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter The Correct Information !!", " Log In" ,MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
            }

            ///////////////////////close reading and connection////
          //  reader.Close();
         //   conc.Close();
        }

        //close button to exit from program
        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure To Exit ?","Exit", MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (result == DialogResult.Yes) timer1.Start();
            else return;
        }

        //placeholder or hint in textbox username 
        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "Enter Your User Name")
            {
                txt_username.Text = "";
                txt_username.ForeColor = Color.White;
            }
        }
        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "Enter Your User Name";
                txt_username.ForeColor = Color.Gray;
            }
            //////////////////////////////////////////////////////////////////////////////////////////
            else if (txt_username.Text == "Abdo Elkabany")
            {
                txt_password.Text = "1042000";
            }

            else if (txt_username.Text == "sharif")
            {
                txt_password.Text = "snow";
            }

            else if (txt_username.Text == "eldesoky")
            {
                txt_password.Text = "eldesoky";
            }
            }



        ////////////////////////Animations////////////////////////////////
        //timer with fade effect during close
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
    }
}

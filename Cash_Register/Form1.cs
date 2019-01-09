using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //  LogUsers user;

        SqlConnection con;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            try { 
            con = new SqlConnection(@"Data Source=JULIO-PC\SQLEXPRESS;Initial Catalog=Project_C#;Integrated Security =True");
            
             string query = "UserName_Password";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
               con.Open();

                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.Add("@username", userNameTxt.Text);
                sda.SelectCommand.Parameters.Add("@password", passwordTxt.Text);

                sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                Main nMain = new Main();
                   
                this.Hide();
                nMain.Show();
            }
            else
            {
                MessageBox.Show("!!!אחד הנתונים שהוקשו שגויים","ERROR!!!");
                    //userNameTxt.Clear();
                    passwordTxt.Clear();
            }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

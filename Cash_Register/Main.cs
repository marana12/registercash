using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Serialization;
using System.Xml;
using Newtonsoft.Json;
using System.Data.OleDb;

namespace Cash_Register
{
    public partial class Main : Form
    {



        int poc;
        public Main()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=JULIO-PC\SQLEXPRESS;Initial Catalog=Project_C#;Integrated Security =True");
      
        SqlDataAdapter adapter;
        SqlCommand scmd;
        DataTable dtbl = new DataTable();
        DataSet ds = new DataSet();
        SqlDataAdapter adp = new SqlDataAdapter();

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Funccion to Update the Tota Price 
        public void  totalp()
        {
            con.Open();
            SqlCommand comand = new SqlCommand("select sum (T_Price) as totalp from ProductsData", con);
            SqlDataReader reg = comand.ExecuteReader();
            if (reg.Read())
                totaltxt.Text = reg["totalp"].ToString();
            if (con != null)
            {
                con.Close();
            }

        }

        //Funccion to show the DB Table
        public void showtbl()
        {
            
            
           

                ds.Tables.Clear();
                

           
            var consulta = "select * from ProductsData";
            adp = new SqlDataAdapter(consulta, con);

            var commandBuilder = new SqlCommandBuilder(adp);
            con.Open();
            adp.Fill(ds);
            tblData.ReadOnly = true;
            tblData.DataSource = null;

            tblData.DataSource = ds.Tables[0];
            if (con != null)
            {
                con.Close();
            }
            totalp();
        }


        //-----------------------ADD----------------------------
        private void addbtn_Click(object sender, EventArgs e)
        {
           //test if the show text are empty
            if ((barcodtxt.Text.Equals(" ")) || (nanetxt.Text.Equals(" ")) || (amountxt.Text.Equals(" ")) || (pricetxt.Text.Equals(" ")))
            {
                MessageBox.Show("אחד מהתגיות ריקות\nלא יתווסף הפריט");
            }

            else
            {
                //put the new data in the DB
                string barcod = barcodtxt.Text;
                string name = nanetxt.Text;
                double quantity = Convert.ToDouble(amountxt.Text);
                double price = Convert.ToDouble(pricetxt.Text);
                try
                {
 

                    //put in the DB
                    string query = "INSERT INTO ProductsData VALUES ('" + barcod + "', N'" + name + "', " + quantity + ", " + price + ", " + (price * quantity) + ")";
                    barcodtxt.Clear();
                    nanetxt.Clear();
                    amountxt.Clear();
                    pricetxt.Clear();

                    //make a conection
                    con.Open();
                    scmd = new SqlCommand(query, con);
                    scmd.ExecuteNonQuery();


                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }
                showtbl();
            }
        }

        //-------------------------UPDATE---------------------------------
    private void updatebtn_Click(object sender, EventArgs e )
        {

            
            string barcod = barcodtxt.Text;
            string name = nanetxt.Text;
            double quantity = Convert.ToDouble(amountxt.Text);
            double price = Convert.ToDouble(pricetxt.Text);
                

            //Update the DB
            String sql = "UPDATE ProductsData  SET barcod = '" + barcod + "',P_Name= N'" + name + "', quantity= " + quantity +
                   ", price =" + price + ", T_Price= " + (price*quantity) + " where id = "+ tblData[5, poc].Value + "";
            scmd = new SqlCommand(sql, con);
            try {
                con.Open();
                adapter = new SqlDataAdapter(scmd);
                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;
                
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    barcodtxt.Clear();
                    nanetxt.Clear();
                    amountxt.Clear();
                    pricetxt.Clear();
                    MessageBox.Show("רשומה עודכנה");
                }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
                showtbl();
                
            }

            
        }

        //-----------------------------DELETE-----------------------------
        private void deletebtn_Click(object sender, EventArgs e)
        {

                     
            //delete from DB
            string sql = "DELETE FROM ProductsData WHERE id = " + tblData[5, poc].Value +"";
            try
            {

                con.Open();
                scmd = new SqlCommand(sql, con);

                scmd.ExecuteNonQuery();
                

               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

    //update the db table in the datagridview         
            showtbl();
            MessageBox.Show("הרשומה נמחקה");
           
        }

        //------------------JSON FILE--------------------------
        private void jsonbtn_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Json | *.Json";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    StreamWriter file = new StreamWriter(sfd.FileName,false);
                    string str = JsonConvert.SerializeObject(ds, Newtonsoft.Json.Formatting.Indented).ToString();
                    
                        file.WriteLine(str.ToString());
                    file.Close();



                    MessageBox.Show("JSON נוצר קובץ חדש מסוג", "JSON Created");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        //-------------XML FILE------------------------
        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    ds.Tables[0].WriteXml(sfd.FileName);
                    MessageBox.Show("XML נוצר קובץ חדש מסוג", "XML Created");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void totaltxt_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void showbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            showtbl();


        }

        private void tblData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.ProductsData' table. You can move, or remove it, as needed.
          //  this.productsDataTableAdapter.Fill(this.appData.ProductsData);

        }
        //Show where are the position in the table
        private void tblData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                 poc = tblData.CurrentRow.Index;
                barcodtxt.Text = tblData[0, poc].Value.ToString();
                nanetxt.Text = tblData[1, poc].Value.ToString();
                amountxt.Text = tblData[2, poc].Value.ToString();
                pricetxt.Text = tblData[3, poc].Value.ToString();
           
            

        }
    }
}

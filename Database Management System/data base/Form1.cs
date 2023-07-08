using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_base
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        SqlDataReader dr;
        Loginform username;

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        #region Method
        public void LoadUser()
        {





            int i = 0;


            guna2DataGridView1.Rows.Clear();
            SqlConnection conn = new SqlConnection(myconnstrng);


            string sql = ("SELECT * FROM [Table7] WHERE No LIKE '%" + guna2TextBox1.Text + "%'");

            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                guna2DataGridView1.Rows.Add(dr[0].ToString());
            }
            if (guna2TextBox1.Text == "" || guna2TextBox1.Text == " ")
            {
                guna2DataGridView1.Rows.Clear();
            }

            dr.Close();
            conn.Close();


        }



        #endregion Method

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            LoadUser();
        }
    }
}

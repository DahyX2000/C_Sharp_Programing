using data_base.infClasses;
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
    public partial class database : Form
    {
        public string No1,No, CName, Taxnum, Entity, TaxOffice, Officenum, Typeentity, MName, IDnum, Phone, Address, Email1, Pass1, Email2, Pass2, Email3, Pass3, Pass4, Pass5, Gmail, GPass, Outlook, OPass, Tax2, Tax3, Tax4,Notes,b,n;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            print Module = new print();
            Module.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public string s;
        private void searchbox_IconRightClick(object sender, EventArgs e)
        {
            searchbox.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            searchbox.Text = "";
        }

        

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            searchbox.Text = "قيمة مضافة";
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            searchbox.Text = "كسب عمل";
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            searchbox.Text = "خصم وتحصيل";
            
        }

        SqlDataReader dr;
        Loginform username;
        public database(Loginform username1)
        {
            InitializeComponent();
            username = username1;
            n = username.z;
            if (username.z == "user" || username.z == "menna")
            {
                pictureBox1.Visible = false;
                printbtn.Visible = false;
                pictureBox2.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                
            }
            else if (username.z == "admin")
            {
                pictureBox1.Visible = true;
                printbtn.Visible = true;
                pictureBox2.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
            }
            
        }
        information db = new information();
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void database_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {            
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {           
        }

        public void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }
        static string myconstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            s = searchbox.Text;
            if (s.Length >= 4)
            {
                LoadUser();
            }
            else
            {
                dataGridView1.Rows.Clear();

            }
            
            
        }


        #region Method
        public void LoadUser()
        {

            
                
            
            
            int i = 0;
            
           
            dataGridView1.Rows.Clear();
            SqlConnection conn = new SqlConnection(myconnstrng);
                
            
            string sql = ("SELECT * FROM [Table6] WHERE CONCAT(No,CName,Taxnum,Officenum,Entity,TaxOffice,Typeentity,MName,IDnum,Phone,Address,Email1,Pass1,Email2,Pass2,Email3,Pass3,Pass4,Pass5,Gmail,GPass,Outlook,OPass,Tax2,Tax3,Tax4,Notes) LIKE '%" + searchbox.Text + "%'");

            SqlCommand cmd = new SqlCommand(sql, conn);
            

            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), dr[13].ToString(), dr[14].ToString(), dr[15].ToString(), dr[16].ToString(), dr[17].ToString(), dr[18].ToString(), dr[19].ToString(), dr[20].ToString(), dr[21].ToString(), dr[22].ToString(), dr[23].ToString(), dr[24].ToString(), dr[25].ToString(), dr[26].ToString(), dr[27].ToString());
            }
            if (searchbox.Text == "" || searchbox.Text == " ")
            {
                dataGridView1.Rows.Clear();
            }

                dr.Close();
            conn.Close();
            

        }

        

        #endregion Method

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            b = "add";
            vuser Module = new vuser(this);
            Module.ShowDialog();
        }

        

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            b = "";
            int rowIndex = e.RowIndex;
            No1 = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            No = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            CName = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            Taxnum = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            Officenum = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            Entity = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            TaxOffice = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            Typeentity = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
            MName = dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();
            IDnum = dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();
            Phone = dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();
            Address = dataGridView1.Rows[rowIndex].Cells[11].Value.ToString();
            Email1 = dataGridView1.Rows[rowIndex].Cells[12].Value.ToString();
            Pass1 = dataGridView1.Rows[rowIndex].Cells[13].Value.ToString();
            Email2 = dataGridView1.Rows[rowIndex].Cells[14].Value.ToString();
            Pass2 = dataGridView1.Rows[rowIndex].Cells[15].Value.ToString();
            Email3 = dataGridView1.Rows[rowIndex].Cells[16].Value.ToString();
            Pass3 = dataGridView1.Rows[rowIndex].Cells[17].Value.ToString();
            Pass4 = dataGridView1.Rows[rowIndex].Cells[18].Value.ToString();
            Pass5 = dataGridView1.Rows[rowIndex].Cells[19].Value.ToString();
            Gmail = dataGridView1.Rows[rowIndex].Cells[20].Value.ToString();
            GPass = dataGridView1.Rows[rowIndex].Cells[21].Value.ToString();
            Outlook = dataGridView1.Rows[rowIndex].Cells[22].Value.ToString();
            OPass = dataGridView1.Rows[rowIndex].Cells[23].Value.ToString();
            Tax2 = dataGridView1.Rows[rowIndex].Cells[24].Value.ToString();
            Tax3 = dataGridView1.Rows[rowIndex].Cells[25].Value.ToString();
            Tax4 = dataGridView1.Rows[rowIndex].Cells[26].Value.ToString();
            Notes = dataGridView1.Rows[rowIndex].Cells[27].Value.ToString();


            vuser Module = new vuser(this);
            Module.ShowDialog();
        }
    }
}

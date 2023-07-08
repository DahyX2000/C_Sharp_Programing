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
using DGVPrinterHelper;

namespace data_base
{
    public partial class print : Form
    {
        public string No1, No, CName, Taxnum, Entity, TaxOffice, Officenum, Typeentity, MName, IDnum, Phone, Address, Email1, Pass1, Email2, Pass2, Email3, Pass3, Pass4, Pass5, Gmail, GPass, Outlook, OPass, Tax2, Tax3, Tax4, Notes, b, n,j,k;

        

        private void print_Load(object sender, EventArgs e)
        {
            
        }

        private void print1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Sample record";
            printer.SubTitle = string.Format("products", printer.SubTitleColor = Color.Black, printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "list of products";
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(dataGridView1);
        }

        

        

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        public string s;

        SqlDataReader dr;

        public print()
        {
            InitializeComponent();
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadUser2();
        }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
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

        private void searchbox_IconRightClick(object sender, EventArgs e)
        {
            searchbox.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            searchbox.Text = "";
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
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
        private void guna2DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            int rowIndex = guna2DataGridView1.CurrentCell.RowIndex;
            guna2DataGridView1.Rows.RemoveAt(rowIndex);

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;


            //guna2DataGridView1.Rows.Add(rowIndex.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value, row.Cells[6].Value, row.Cells[7].Value, row.Cells[8].Value, row.Cells[9].Value, row.Cells[10].Value, row.Cells[11].Value, row.Cells[12].Value, row.Cells[13].Value, row.Cells[14].Value, row.Cells[15].Value, row.Cells[16].Value, row.Cells[17].Value, row.Cells[18].Value, row.Cells[19].Value, row.Cells[20].Value, row.Cells[21].Value, row.Cells[22].Value, row.Cells[23].Value, row.Cells[24].Value, row.Cells[25].Value, row.Cells[26].Value, row.Cells[27].Value);
            guna2DataGridView1.Rows.Add(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[2].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[3].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[4].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[5].Value.ToString(), 
                dataGridView1.Rows[rowIndex].Cells[6].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[7].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[8].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[9].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[10].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[11].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[12].Value.ToString(),
                dataGridView1.Rows[rowIndex].Cells[13].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[14].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[15].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[16].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[17].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[18].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[19].Value.ToString()
                , dataGridView1.Rows[rowIndex].Cells[20].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[21].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[22].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[23].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[24].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[25].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[26].Value.ToString()
                , dataGridView1.Rows[rowIndex].Cells[27].Value.ToString());





        }

        private void add_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                
                    guna2DataGridView1.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value, row.Cells[6].Value, row.Cells[7].Value, row.Cells[8].Value, row.Cells[9].Value, row.Cells[10].Value, row.Cells[11].Value, row.Cells[12].Value, row.Cells[13].Value, row.Cells[14].Value, row.Cells[15].Value, row.Cells[16].Value, row.Cells[17].Value, row.Cells[18].Value, row.Cells[19].Value, row.Cells[20].Value, row.Cells[21].Value, row.Cells[22].Value, row.Cells[23].Value, row.Cells[24].Value, row.Cells[25].Value, row.Cells[26].Value, row.Cells[27].Value);

            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

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

        #region Method
        public void LoadUser2()
        {

            int i = 0;


            guna2DataGridView1.Rows.Clear();
            SqlConnection conn = new SqlConnection(myconnstrng);


            string sql = ("SELECT * FROM [Table7] WHERE CONCAT(No,CName,Taxnum,Officenum,Entity,TaxOffice,Typeentity,MName,IDnum,Phone,Address,Email1,Pass1,Email2,Pass2,Email3,Pass3,Pass4,Pass5,Gmail,GPass,Outlook,OPass,Tax2,Tax3,Tax4,Notes) LIKE '%" + searchbox.Text + "%'");

            SqlCommand cmd = new SqlCommand(sql, conn);


            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                guna2DataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), dr[13].ToString(), dr[14].ToString(), dr[15].ToString(), dr[16].ToString(), dr[17].ToString(), dr[18].ToString(), dr[19].ToString(), dr[20].ToString(), dr[21].ToString(), dr[22].ToString(), dr[23].ToString(), dr[24].ToString(), dr[25].ToString(), dr[26].ToString(), dr[27].ToString());
            }

            dr.Close();
            conn.Close();


        }



        #endregion Method

        #region Method
        public void LoadUser3()
        {

            int i = 0;


            guna2DataGridView1.Rows.Clear();
            SqlConnection conn = new SqlConnection(myconnstrng);


            string sql = ("SELECT * FROM [Table7] WHERE CONCAT(No,CName,Taxnum,Officenum,Entity,TaxOffice,Typeentity,MName,IDnum,Phone,Address,Email1,Pass1,Email2,Pass2,Email3,Pass3,Pass4,Pass5,Gmail,GPass,Outlook,OPass,Tax2,Tax3,Tax4,Notes) LIKE '%" + j + "%'");

            SqlCommand cmd = new SqlCommand(sql, conn);


            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                guna2DataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), dr[13].ToString(), dr[14].ToString(), dr[15].ToString(), dr[16].ToString(), dr[17].ToString(), dr[18].ToString(), dr[19].ToString(), dr[20].ToString(), dr[21].ToString(), dr[22].ToString(), dr[23].ToString(), dr[24].ToString(), dr[25].ToString(), dr[26].ToString(), dr[27].ToString());
            }

            dr.Close();
            conn.Close();


        }



        #endregion Method
    }
}

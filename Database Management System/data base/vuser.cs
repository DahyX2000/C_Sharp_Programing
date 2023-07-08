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

    public partial class vuser : Form
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        
        

        database database1;

        public vuser(database data)
        {
            InitializeComponent();
            

            if (data.n == "user" || data.n == "menna")
            {
                add.Enabled = false;
                delete.Enabled = false;
                update.Enabled = false;
                Gmail.Enabled = false;
                GPass.Enabled = false;
                Outlook.Enabled = false;
                OPass.Enabled = false;
                add.Enabled = false;
                No1.Enabled = false;

                No.ReadOnly = true;
                CName.ReadOnly = true;
                Taxnum.ReadOnly = true;
                Officenum.ReadOnly = true;
                Entity.ReadOnly = true;
                TaxOffice.ReadOnly = true;
                Typeentity.ReadOnly = true;
                Address.ReadOnly = true;
                MName.ReadOnly = true;
                IDnum.ReadOnly = true;
                Phone.ReadOnly = true;
                Email1.ReadOnly = true;
                Pass1.ReadOnly = true;
                Email2.ReadOnly = true;
                Pass2.ReadOnly = true;
                Email3.ReadOnly = true;
                Pass3.ReadOnly = true;
                Pass4.ReadOnly = true;
                No1.ReadOnly = true;
                Pass5.ReadOnly = true;
                

            }
            if (data.b == "add")
            {
                delete.Enabled = false;
                update.Enabled = false;
            }
            else
            {
                add.Enabled = false;
                database1 = data;
                No.Text = data.No;
                CName.Text = data.CName;
                Taxnum.Text = data.Taxnum;
                Officenum.Text = data.Officenum;
                Entity.Text = data.Entity;
                TaxOffice.Text = data.TaxOffice;
                Typeentity.Text = data.Typeentity;
                Address.Text = data.Address;
                MName.Text = data.MName;
                IDnum.Text = data.IDnum;
                Phone.Text = data.Phone;
                Email1.Text = data.Email1;
                Pass1.Text = data.Pass1;
                Email2.Text = data.Email2;
                Pass2.Text = data.Pass2;

                if (data.n == "user")
                {
                    
                }
                else
                {
                    if (data.n == "menna")
                    {
                        No1.Text = data.No1;
                    }
                    else
                    {
                        No1.Text = data.No1;
                        Gmail.Text = data.Gmail;
                        GPass.Text = data.GPass;
                        Outlook.Text = data.Outlook;
                        OPass.Text = data.OPass;
                    }
                    
                    
                }
               
                Email3.Text = data.Email3;
                Pass3.Text = data.Pass3;
                Pass4.Text = data.Pass4;
                Pass5.Text = data.Pass5;

                Notes.Text = data.Notes;
                if (data.Tax2 == "")
                {
                    Tax2.Checked = false;
                }
                else
                {
                    Tax2.Checked = true;
                }

                if (data.Tax3 == "")
                {
                    Tax3.Checked = false;
                }
                else
                {
                    Tax3.Checked = true;
                }

                if (data.Tax4 == "")
                {
                    Tax4.Checked = false;
                }
                else
                {
                    Tax4.Checked = true;
                }

            }
            if (data.n == "menna")
            {
                No1.Enabled = true;
            }
        }

        

        private void add_Click(object sender, EventArgs e)
        {


            SqlConnection conn2 = new SqlConnection(myconnstrng);
            string sql2 = "SELECT COUNT(*) FROM [Table6] WHERE No = @No";

            SqlCommand command = new SqlCommand(sql2, conn2);

            command.Parameters.AddWithValue("@No", No.Text);

            conn2.Open();


            int count = (int)command.ExecuteScalar();


            conn2.Close();


            if (count > 0)
            {

                MessageBox.Show("رقم المسلسل موجود مسبقا");
            }
            else
            {

                SqlConnection conn = new SqlConnection(myconnstrng);
                string sql = "insert into [Table6] (No1,No,CName,Taxnum,Officenum,Entity,TaxOffice,Typeentity,MName,IDnum,Phone,Address,Email1,Pass1,Email2,Pass2,Email3,Pass3,Pass4,Pass5,Gmail,GPass,Outlook,OPass,Tax2,Tax3,Tax4,Notes) values (@No1,@No,@CName,@Taxnum,@Officenum,@Entity,@TaxOffice,@Typeentity,@MName,@IDnum,@Phone,@Address,@Email1,@Pass1,@Email2,@Pass2,@Email3,@Pass3,@Pass4,@Pass5,@Gmail,@GPass,@Outlook,@OPass,@Tax2,@Tax3,@Tax4,@Notes)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@No1", No1.Text);
                cmd.Parameters.AddWithValue("@No", No.Text);
                cmd.Parameters.AddWithValue("@CName", CName.Text);
                cmd.Parameters.AddWithValue("@Taxnum", Taxnum.Text);
                cmd.Parameters.AddWithValue("@Officenum", Officenum.Text);
                cmd.Parameters.AddWithValue("@Entity", Entity.Text);
                cmd.Parameters.AddWithValue("@TaxOffice", TaxOffice.Text);
                cmd.Parameters.AddWithValue("@Typeentity", Typeentity.Text);
                cmd.Parameters.AddWithValue("@MName", MName.Text);
                cmd.Parameters.AddWithValue("@IDnum", IDnum.Text);
                cmd.Parameters.AddWithValue("@Phone", Phone.Text);
                cmd.Parameters.AddWithValue("@Address", Address.Text);
                cmd.Parameters.AddWithValue("@Email1", Email1.Text);
                cmd.Parameters.AddWithValue("@Pass1", Pass1.Text);
                cmd.Parameters.AddWithValue("@Email2", Email2.Text);
                cmd.Parameters.AddWithValue("@Pass2", Pass2.Text);
                cmd.Parameters.AddWithValue("@Email3", Email3.Text);
                cmd.Parameters.AddWithValue("@Pass3", Pass3.Text);
                cmd.Parameters.AddWithValue("@Pass4", Pass4.Text);
                cmd.Parameters.AddWithValue("@Pass5", Pass5.Text);
                cmd.Parameters.AddWithValue("@Gmail", Gmail.Text);
                cmd.Parameters.AddWithValue("@GPass", GPass.Text);
                cmd.Parameters.AddWithValue("@Outlook", Outlook.Text);
                cmd.Parameters.AddWithValue("@OPass", OPass.Text);
                cmd.Parameters.AddWithValue("@Notes", Notes.Text);
                if (Tax2.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Tax2", Tax2.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Tax2", "");
                }

                if (Tax3.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Tax3", Tax3.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Tax3", "");
                }

                if (Tax4.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Tax4", Tax4.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Tax4", "");
                }

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("added");
                No1.Text = "";
                CName.Text = "";
                Taxnum.Text = "";
                Officenum.Text = "";
                Entity.Text = "";
                TaxOffice.Text = "";
                Typeentity.Text = "";
                MName.Text = "";
                IDnum.Text = "";
                Phone.Text = "";
                Address.Text = "";
                Email1.Text = "";
                Pass1.Text = "";
                Email2.Text = "";
                Pass2.Text = "";
                Email3.Text = "";
                Pass3.Text = "";
                Pass4.Text = "";
                Pass5.Text = "";
                Gmail.Text = "";
                GPass.Text = "";
                Outlook.Text = "";
                OPass.Text = "";
                Tax2.Checked = false;
                Tax3.Checked = false;
                Tax4.Checked = false;
                Notes.Text = "";
            }








        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            string sql = "update [Table6] set  No1 = @No1,CName = @CName, Taxnum = @Taxnum,Officenum = @Officenum, Entity = @Entity, TaxOffice = @TaxOffice, Typeentity = @Typeentity, MName = @MName, IDnum = @IDnum, Phone = @Phone, Address = @Address,Email1 = @Email1, Pass1 = @Pass1, Email2 = @Email2, Pass2 = @Pass2, Email3 = @Email3, Pass3 = @Pass3, Pass4 = @Pass4, Pass5 = @Pass5, Gmail = @Gmail, GPass = @GPass, Outlook = @Outlook, OPass = @OPass, Tax2 = @Tax2, Tax3 = @Tax3, Tax4 = @Tax4, Notes = @Notes where No = @No";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@No1", No1.Text);
            cmd.Parameters.AddWithValue("@No", No.Text);
            cmd.Parameters.AddWithValue("@CName", CName.Text);
            cmd.Parameters.AddWithValue("@Taxnum", Taxnum.Text);
            cmd.Parameters.AddWithValue("@Officenum", Officenum.Text);
            cmd.Parameters.AddWithValue("@Entity", Entity.Text);
            cmd.Parameters.AddWithValue("@TaxOffice", TaxOffice.Text);
            cmd.Parameters.AddWithValue("@Typeentity", Typeentity.Text);
            cmd.Parameters.AddWithValue("@MName", MName.Text);
            cmd.Parameters.AddWithValue("@IDnum", IDnum.Text);
            cmd.Parameters.AddWithValue("@Phone", Phone.Text);
            cmd.Parameters.AddWithValue("@Address", Address.Text);
            cmd.Parameters.AddWithValue("@Email1", Email1.Text);
            cmd.Parameters.AddWithValue("@Pass1", Pass1.Text);
            cmd.Parameters.AddWithValue("@Email2", Email2.Text);
            cmd.Parameters.AddWithValue("@Pass2", Pass2.Text);
            cmd.Parameters.AddWithValue("@Email3", Email3.Text);
            cmd.Parameters.AddWithValue("@Pass3", Pass3.Text);
            cmd.Parameters.AddWithValue("@Pass4", Pass4.Text);
            cmd.Parameters.AddWithValue("@Pass5", Pass5.Text);
            cmd.Parameters.AddWithValue("@Gmail", Gmail.Text);
            cmd.Parameters.AddWithValue("@GPass", GPass.Text);
            cmd.Parameters.AddWithValue("@Outlook", Outlook.Text);
            cmd.Parameters.AddWithValue("@OPass", OPass.Text);
            cmd.Parameters.AddWithValue("@Notes", Notes.Text);
            if (Tax2.Checked == true)
            {
                cmd.Parameters.AddWithValue("@Tax2", Tax2.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Tax2", "");
            }

            if (Tax3.Checked == true)
            {
                cmd.Parameters.AddWithValue("@Tax3", Tax3.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Tax3", "");
            }

            if (Tax4.Checked == true)
            {
                cmd.Parameters.AddWithValue("@Tax4", Tax4.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Tax4", "");
            }
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated");
        }








        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);


            if (MessageBox.Show("هل انت تريد مسح البيانات","Open paint", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "delete from [Table6] where No = @No";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@No1", No1.Text);
                cmd.Parameters.AddWithValue("@No", No.Text);
                cmd.Parameters.AddWithValue("@CName", CName.Text);
                cmd.Parameters.AddWithValue("@Taxnum", Taxnum.Text);
                cmd.Parameters.AddWithValue("@Officenum", Officenum.Text);
                cmd.Parameters.AddWithValue("@Entity", Entity.Text);
                cmd.Parameters.AddWithValue("@TaxOffice", TaxOffice.Text);
                cmd.Parameters.AddWithValue("@Typeentity", Typeentity.Text);
                cmd.Parameters.AddWithValue("@MName", MName.Text);
                cmd.Parameters.AddWithValue("@IDnum", IDnum.Text);
                cmd.Parameters.AddWithValue("@Phone", Phone.Text);
                cmd.Parameters.AddWithValue("@Address", Address.Text);
                cmd.Parameters.AddWithValue("@Email1", Email1.Text);
                cmd.Parameters.AddWithValue("@Pass1", Pass1.Text);
                cmd.Parameters.AddWithValue("@Email2", Email2.Text);
                cmd.Parameters.AddWithValue("@Pass2", Pass2.Text);
                cmd.Parameters.AddWithValue("@Email3", Email3.Text);
                cmd.Parameters.AddWithValue("@Pass3", Pass3.Text);
                cmd.Parameters.AddWithValue("@Pass4", Pass4.Text);
                cmd.Parameters.AddWithValue("@Pass5", Pass5.Text);
                cmd.Parameters.AddWithValue("@Gmail", Gmail.Text);
                cmd.Parameters.AddWithValue("@GPass", GPass.Text);
                cmd.Parameters.AddWithValue("@Outlook", Outlook.Text);
                cmd.Parameters.AddWithValue("@OPass", OPass.Text);
                cmd.Parameters.AddWithValue("@Notes", Notes.Text);
                if (Tax2.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Tax2", Tax2.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Tax2", "");
                }

                if (Tax3.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Tax3", Tax3.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Tax3", "");
                }

                if (Tax4.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Tax4", Tax4.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Tax4", "");
                }
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("deleted");
                No1.Text = "";
                CName.Text = "";
                Taxnum.Text = "";
                Officenum.Text = "";
                Entity.Text = "";
                TaxOffice.Text = "";
                Typeentity.Text = "";
                MName.Text = "";
                IDnum.Text = "";
                Phone.Text = "";
                Address.Text = "";
                Email1.Text = "";
                Pass1.Text = "";
                Email2.Text = "";
                Pass2.Text = "";
                Email3.Text = "";
                Pass3.Text = "";
                Pass4.Text = "";
                Pass5.Text = "";
                Gmail.Text = "";
                GPass.Text = "";
                Outlook.Text = "";
                OPass.Text = "";
                Tax2.Checked = false;
                Tax3.Checked = false;
                Tax4.Checked = false;
                Notes.Text = "";
            }
            else
            {

            }

        }

        private void vuser_Load(object sender, EventArgs e)
        {
           
        }

        private void resizeControl(Rectangle r, Control c)
        {
            


        }
        private void vuser_Resize(object sender, EventArgs e)
        {
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}

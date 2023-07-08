using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_base.infClasses
{
    class information
    {
        public string Name1 { get; set; }
        public string Tel1 { get; set; }
        public string Email1 { get; set; }
        public string Pass1 { get; set; }
        public string Address1 { get; set; }
        public string Gender1 { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM [Table3]";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);


            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool Insert (information c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "insert into [table] (Name, Tel, Email, Pass, Address, Gender) values (@Name, @Tel, @Email, @Pass, @Address, @Gender)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Name", c.Name1);
                cmd.Parameters.AddWithValue("@Tel", c.Tel1);
                cmd.Parameters.AddWithValue("@Email", c.Email1);
                cmd.Parameters.AddWithValue("@Pass", c.Pass1);
                cmd.Parameters.AddWithValue("@Address", c.Address1);
                cmd.Parameters.AddWithValue("@Gender", c.Gender1);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows>0)
                {
                    isSuccess = true;

                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool Update (information c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE tbl SET Name = @Name, Tel = @Tel, Email = @Email, Pass = @Pass, Address = @Address, Gender = @Gender";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Tel", c.Tel1);
                cmd.Parameters.AddWithValue("@Email", c.Email1);
                cmd.Parameters.AddWithValue("@Pass", c.Pass1);
                cmd.Parameters.AddWithValue("@Address", c.Address1);
                cmd.Parameters.AddWithValue("@Gender", c.Gender1);
                cmd.Parameters.AddWithValue("@Name", c.Name1);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

            
        }

        public bool Delete (information c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM tbl WEHERE Name=@Name";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", c.Name1);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}

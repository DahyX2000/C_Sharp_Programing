using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_base
{
    public partial class Loginform : Form
    {

        public string z;

        public Loginform()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            string y = textBox2.Text;
            if (x == "user" && y == "123")
            {
                z = textBox1.Text;
                database db = new database(this);
                db.Show();
                this.Hide();
            }
            
            else if ((x == "admin" && y == "HP123789") || (x == "menna" && y == "123***"))
          {
              z = textBox1.Text;
            database db = new database(this);
              db.Show();
this.Hide();
        }
        else
        {
            MessageBox.Show("wrong username or password");


          }


        }
   
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

           
            if (e.KeyChar == (char)Keys.Enter)
            {
           
                string x = textBox1.Text;
                string y = textBox2.Text;
                if (x == "user" && y == "123")
                {
                    z = textBox1.Text;
                    database db = new database(this);
                    db.Show();
                    this.Hide();
                }
                else if ((x == "admin" && y == "HP123789") || (x == "menna" && y == "123***"))
                {
                    z = textBox1.Text;
                    database db = new database(this);
                    db.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("wrong username or password");
                    
                    
                }

               
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                string x = textBox1.Text;
                string y = textBox2.Text;
                if (x == "user" && y == "123***")
                {
                    z = textBox1.Text;
                    database db = new database(this);
                    db.Show();
                    this.Hide();
                }
                else if ((x == "admin" && y == "HP123789") || (x == "menna" && y == "123***")) 
                {
                    z = textBox1.Text;
                    database db = new database(this);
                    db.Show();
                    this.Hide();
                } 
                else
                {
                    MessageBox.Show("wrong username or password");


                }


            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

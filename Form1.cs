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

namespace WindowsLoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-7RDK7V9\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=True");
            string query ="Select * from LoginTable where username = '" + textUsername.Text.Trim() +"' and password = '"+ textPassword.Text.Trim()+"' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count == 1)
            {
                Main objMain = new Main();
                this.Hide();
                objMain.Show();
            }
            else
            {
                MessageBox.Show("Check your usernmae & password");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

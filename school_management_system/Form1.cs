using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-AA6G5JQ\\SQLEXPRESS;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);
           
            con.open();

            string Studentname = tbfirstname.Text;
            string Fathername = tbfathername.Text;
            string Rollno = tbrollno.Text;
            string CNIC = tbcnic.Text;
            string Query = "insert into schools_tbl values(2,'"+Studentname+"','"+Fathername+"','"+Rollno+"','"+CNIC+"')";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data has been saved");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

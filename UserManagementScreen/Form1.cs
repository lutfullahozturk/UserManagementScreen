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

namespace UserManagementScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // In order to access the database, you need to change the connection string below.
        public string constr = "Data Source=.;Initial Catalog=piworks;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();
        

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlConnection sqlcon = new SqlConnection(constr);
            cmd.Connection = sqlcon;
            cmd.CommandText = "INSERT INTO UIManagement(Username,Displayname,Phone,Email,UserRoles,Enabled) " +
                "VALUES('"+textBox1.Text+"','" + textBox2.Text+"','" + textBox3.Text+"','" + textBox4.Text+"','" + comboBox1.SelectedItem+"','"+checkBox2.Checked.GetHashCode()+"')";
            sqlcon.Open();
            int result = cmd.ExecuteNonQuery();
            label7.Text = result.ToString() + " User info added to Database";

            showdata("select * from UIManagement");
        }

        public void showdata(string datafromsql) 
        {
            SqlDataAdapter da = new SqlDataAdapter(datafromsql, constr);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(constr);
            sqlcon.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }
    }
}

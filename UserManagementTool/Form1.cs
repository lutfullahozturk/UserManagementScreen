using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagementTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataColumn column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.AutoIncrement = true;
            column.AutoIncrementSeed = 1;
            column.AutoIncrementStep = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.Rows.Add();

            i = 1;
            dataGridView1.Rows[i].Cells[0].Value = i;
            dataGridView1.Rows[i].Cells[1].Value = textBox1.Text;
            dataGridView1.Rows[i].Cells[2].Value = textBox2.Text;
            dataGridView1.Rows[i].Cells[3].Value = textBox3.Text;
   
            i++;

        }
    }
}

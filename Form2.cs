using System;
using System.Data;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.OleDb;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private OleDbConnection conn;
        private OleDbCommand cmd;
        private OleDbDataAdapter adapter;
        DataTable dt;

        public Form2 ()
        {
            InitializeComponent();
            
        }

        void GetCustomers()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source=dbtk.accdb/passive");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("*Select *FROM Customers",conn);
            conn.Open();        
            adapter.Fill(dt);
            dgwCustomers.DataSource = dt;
            conn.Close();   
            
        }

        private void Form2_Load(object sender, EventArgs e )
        {
             GetCustomers();
        }
            
        private void label2_Click(object sender, EventArgs e)
        {
            // Code for label2 click event
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Code for dataGridView1 cell content click event
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // Code for label8 click event
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Code for textBox4 text changed event
        }

       
    }
}

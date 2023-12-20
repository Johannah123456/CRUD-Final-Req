using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Code for label1 click event
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Code for label3 click event
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Redirect to Form2
            Form2 form2 = new Form2();
            form2.Show();

            // Hide Form1 if needed
            this.Hide();
        }
    }
}

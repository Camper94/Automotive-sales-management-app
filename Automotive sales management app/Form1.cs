using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotive_sales_management_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_Up form = new Sign_Up();
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner owner = new Owner();
            owner.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Client_UI client = new Client_UI();
            client.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Salesmen_UI salesmen = new Salesmen_UI();
            salesmen.Show();
        }
    }
}

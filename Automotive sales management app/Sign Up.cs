using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Automotive_sales_management_app
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool answer;
            DataAccess db = new DataAccess();
            answer = db.AddClient(textBox1.Text, textBox6.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox7.Text, textBox5.Text);
            if (answer == true)  MessageBox.Show("Client Added With Succes!");
            else MessageBox.Show("Connexion Failed");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

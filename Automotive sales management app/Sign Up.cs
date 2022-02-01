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
        bool answer;
        DataAccess db = new DataAccess();
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            answer = db.AddClient(textBox1.Text, textBox6.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox7.Text, textBox5.Text);
            if (answer == true)  MessageBox.Show("Client Added With Succes!");
            else MessageBox.Show("Connexion Failed");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            answer = db.AddAuto(textBox1.Text, textBox6.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox7.Text, textBox5.Text);
            if (answer == true) MessageBox.Show("AUTO Added With Succes!");
            else MessageBox.Show("Connexion Failed");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            answer = db.AddParts(textBox1.Text,textBox2.Text,textBox6.Text,textBox5.Text);
            if (answer == true) MessageBox.Show("PARTS Added With Succes!");
            else MessageBox.Show("Connexion Failed");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            answer = db.AddAccessory(textBox1.Text, textBox6.Text,textBox5.Text);
            if (answer == true) MessageBox.Show("ACCESSORY Added With Succes!");
            else MessageBox.Show("Connexion Failed");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            answer = db.AddInssurance(textBox1.Text, textBox6.Text, textBox5.Text);
            if (answer == true) MessageBox.Show("INSSURANCE Added With Succes!");
            else MessageBox.Show("Connexion Failed");
        }
    }
}

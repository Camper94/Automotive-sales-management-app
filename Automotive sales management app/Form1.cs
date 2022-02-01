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
        public static Form1 instance;
        DataAccess db = new DataAccess();
        public Form1()
        {
            InitializeComponent();
            instance = this;
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
            List<OWNER> owners = new List<OWNER>();
            owners = db.GetOwnerInfo();
            Owner_UI owner = new Owner_UI();
            foreach (var boss in owners)
            {
                if (boss.USERNAME == textBox2.Text && boss.PASS == textBox1.Text)
                {
                    Owner_UI.instance.lb2.Text = boss.USERNAME;
                    owner.Show();
                    break;
                }
                else
                {
                    MessageBox.Show("User doesn't exist !!");
                    break;
                } 
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<CLIENT> users = new List<CLIENT>();
            users = db.GetClientInfo();
            Client_UI client = new Client_UI();
            foreach (var user in users)
            {
                if (user.NOM == textBox2.Text && user.PASSWORD == textBox1.Text)
                {
                    Client_UI.instance.lb1.Text = user.NOM;
                    client.Show();
                    break;
                }
                else
                {
                    MessageBox.Show("User doesn't exist !!");
                    break;
                }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<SALESMEN> employee = new List<SALESMEN>();
            employee = db.GetSalesmenInfo();
            Salesmen_UI salesmen = new Salesmen_UI();
            foreach (var person in employee)
            {
                if (person.NOM == textBox2.Text && person.PASSWORD == textBox1.Text)
                {
                    Salesmen_UI.instance.lb3.Text = person.NOM;
                    salesmen.Show();
                    break;
                }
                else
                {
                    MessageBox.Show("User doesn't exist !!");
                    break;
                }
            }
            
        }
    }
}

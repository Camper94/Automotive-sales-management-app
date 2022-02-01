using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Automotive_sales_management_app
{
    public partial class Salesmen_UI : Form
    {
        public static Salesmen_UI instance;
        public Label lb3;
        DataAccess db = new DataAccess();
        Sign_Up register = new Sign_Up();
        public Salesmen_UI()
        {
            InitializeComponent();
            instance = this;
            lb3 = label3;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string value = comboBox1.Text;
            switch (value)
            {
                case "AUTO":
                    List<AUTO> autos = new List<AUTO>();
                    autos = db.GetAuto();
                    listBox1.DataSource = autos;
                    listBox1.DisplayMember = "FullInfo";
                    break;
                case "PARTS":
                    List<PARTS> parts = new List<PARTS>();
                    parts = db.GetPartsInfo();
                    listBox1.DataSource = parts;
                    listBox1.DisplayMember = "FullInfo";
                    break;
                case "ACCESSORY":
                    List<ACCESSORY> accessory = new List<ACCESSORY>();
                    accessory = db.GetAccessoryInfo();
                    listBox1.DataSource = accessory;
                    listBox1.DisplayMember = "FullInfo";
                    break;
                case "INSSURANCE":
                    List<INSSURANCE> inssurance = new List<INSSURANCE>();
                    inssurance = db.GetInssuranceInfo();
                    listBox1.DataSource = inssurance;
                    listBox1.DisplayMember = "FullInfo";
                    break;
                default:
                    MessageBox.Show("Please Choose your Product ");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = comboBox1.Text;
            switch (value)
            {
                case "":
                    MessageBox.Show("Please Choose your product");
                    break;
                case "AUTO":
                    MessageBox.Show("Fill all the fields");
                    register.Show();
                    break;
                case "PARTS":
                    MessageBox.Show("Fill the fields ID, MODEL, PRENOM and IDSALESMEN");
                    register.Show();
                    break;
                case "ACCESSORY":
                    MessageBox.Show("Fill fields ID, NOM and IDSALESMEN");
                    register.Show();
                    break;
                case "INSSURANCE":
                    MessageBox.Show("Fill fields ID, NOM and IDSALESMEN");
                    register.Show();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool answer;
            answer = db.DeleteProduct(textBox1.Text,comboBox1.Text);
            if (answer) MessageBox.Show("Product Deleted");
            else MessageBox.Show("Connexion Failed !");
        }
    }
}

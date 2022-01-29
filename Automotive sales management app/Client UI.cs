using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Automotive_sales_management_app
{
    public partial class Client_UI : Form
    {
        DataAccess db = new DataAccess();    
        public Client_UI()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<AUTO> autos = new List<AUTO>();
            autos = db.GetAuto();
            listBox1.DataSource = autos;
            listBox1.DisplayMember = "FullInfo";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<PARTS> parts = new List<PARTS>();
            parts = db.GetPartsInfo();
            listBox1.DataSource = parts;
            listBox1.DisplayMember = "FullInfo";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<INSSURANCE> inssurance = new List<INSSURANCE>();
            inssurance = db.GetInssuranceInfo();
            listBox1.DataSource = inssurance;
            listBox1.DisplayMember = "FullInfo";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<ACCESSORY> accessory = new List<ACCESSORY>();
            accessory = db.GetAccessoryInfo();
            listBox1.DataSource = accessory;
            listBox1.DisplayMember = "FullInfo";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PurchaseWindows purchase = new PurchaseWindows();
            purchase.Show();
        }
    }
}

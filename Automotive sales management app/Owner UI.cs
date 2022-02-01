using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Automotive_sales_management_app
{
    public partial class Owner_UI : Form
    {
        public static Owner_UI instance;
        public Label lb2;
        DataAccess db = new DataAccess();
        public Owner_UI()
        {
            InitializeComponent();
            instance = this;
            lb2 = label2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<AUTO> autos = new List<AUTO>();
            autos = db.GetAuto();
            listBox1.DataSource = autos;
            listBox1.DisplayMember = "FullInfo";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<ACCESSORY> accessory = new List<ACCESSORY>();
            accessory = db.GetAccessoryInfo();
            listBox1.DataSource = accessory;
            listBox1.DisplayMember = "FullInfo";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<PARTS> parts = new List<PARTS>();
            parts = db.GetPartsInfo();
            listBox1.DataSource = parts;
            listBox1.DisplayMember = "FullInfo";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<INSSURANCE> inssurance = new List<INSSURANCE>();
            inssurance = db.GetInssuranceInfo();
            listBox1.DataSource = inssurance;
            listBox1.DisplayMember = "FullInfo";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<SALESMEN> salesmen = new List<SALESMEN>();
            salesmen = db.GetSalesmenInfo();
            listBox1.DataSource = salesmen;
            listBox1.DisplayMember = "FullInfo";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<CLIENT> client = new List<CLIENT>();
            client = db.GetClientInfo();
            listBox1.DataSource = client;
            listBox1.DisplayMember = "FullInfo";
        }
    }
}

using DataEntities.Entities.Retail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailStoreWinForms
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            Customer=new Customer();
        }
       public Customer Customer { get; set; }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Customer.FirstName = txfname.Text;
            Customer.LastName = txtlname.Text;
            Customer.CompanyName = txtcomp.Text;
            Customer.LandLine = txtLand.Text;
            Customer.Mobile = txtMob.Text;
            Customer.Email = txtemail.Text;
            this.DialogResult=DialogResult.Yes;
            this.Close();
        }
    }
}

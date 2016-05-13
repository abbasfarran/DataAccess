using System;
using System.Windows.Forms;
using DataEntities.Entities.Retail;

namespace RetailStoreWinForms.GUI.RetailForms
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtlname.Clear();
            txfname.Clear();
            txtMob.Clear();
            txtcomp.Clear();
            txtLand.Clear();
            txtemail.Clear();
        }

        private void CustomerForm_Shown(object sender, EventArgs e)
        {
            txfname.Text = Customer?.FirstName;
            txtlname.Text = Customer?.LastName;
            txtcomp.Text = Customer?.CompanyName;
            txtMob.Text = Customer?.Mobile;
            txtLand.Text = Customer?.LandLine;
            txtemail.Text = Customer?.Email;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}

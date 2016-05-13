using System;
using System.Windows.Forms;
using DataEntities;
using RetailStoreWinForms.GUI.RetailForms;
using RetailStoreWinForms.StaticClasses;

namespace RetailStoreWinForms.GUI
{
    public partial class Form1 : Form
    {
        private CustomersList _customersList;
        public Form1()
        {
            InitializeComponent();
            _customersList=new CustomersList();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           CustomerStaticMethods.Addcustomer();
           CustomerStaticMethods.LoadCustomersForm(ref _customersList, this);
           
        }

        private void existingCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           CustomerStaticMethods.LoadCustomersForm( ref _customersList,this);
          
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            MyContext mct=new MyContext();
            mct.Customers.FindAsync(1);
            CustomerStaticMethods.mct = mct;
            ShippingAddressStaticMethods.mct = mct;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            {
                Application.Exit();
            }
            
            
        }
    }
}

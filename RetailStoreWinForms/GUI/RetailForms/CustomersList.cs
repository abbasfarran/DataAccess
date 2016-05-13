using System;
using System.Windows.Forms;
using DataEntities.Entities.Retail;
using RetailStoreWinForms.StaticClasses;

namespace RetailStoreWinForms.GUI.RetailForms
{
    public partial class CustomersList : Form
    {
        public CustomersList()
        {
            InitializeComponent();
            Customersbgs = new BindingSource();
            ShippingAdressbgs=new BindingSource();
            Customersbgs.DataSourceChanged += Customersbgs_DataSourceChanged;
            ShippingAdressbgs.DataSourceChanged += ShippingAdressbgs_DataSourceChanged; ;
        }

        private void ShippingAdressbgs_DataSourceChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = ShippingAdressbgs;
        }

        public BindingSource ShippingAdressbgs { get; set; }
        public BindingSource Customersbgs { get; set; }

      

        private void Customersbgs_DataSourceChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Customersbgs;
            dataGridView1.CurrentCell=null;
        }

        //customers list
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer customer = (Customer)dataGridView1.CurrentRow?.DataBoundItem;
            if (customer?.ShippingAddresses.Count == 0)
            {
                
                ShippingAdressbgs.DataSource = null;
                return;
            }
            ShippingAdressbgs.DataSource = customer?.ShippingAddresses;
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
        //add customer
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (CustomerStaticMethods.Addcustomer())
            {
                CustomerStaticMethods.BindCustomers(this, dataGridView1);
                if (dataGridView1.RowCount > 0)
                {

                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0];
                }
            }
           
        }

        private void CustomersList_Shown(object sender, EventArgs e)
        {
            CustomerStaticMethods.BindCustomers(this,dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //edit customer
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int rowpos = -1;
            if (dataGridView1.CurrentRow != null)
            {
                rowpos = dataGridView1.CurrentRow.Index;
            }
            Customer customer = (Customer) dataGridView1.CurrentRow?.DataBoundItem;
            if (customer != null)
            {
                CustomerStaticMethods.Editcustomer(customer);
                CustomerStaticMethods.BindCustomers(this, dataGridView1);
                if (dataGridView1.RowCount > 0)
                {

                    dataGridView1.CurrentCell = dataGridView1.Rows[rowpos].Cells[0];
                }
            }
            else
            {
                MessageBox.Show("Please Select a Customer First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
       
    //remove customer
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            int rowpos = -1;
            if (dataGridView1.CurrentRow != null)
            {
                rowpos = dataGridView1.CurrentRow.Index;
            }
            Customer customer = (Customer)dataGridView1.CurrentRow?.DataBoundItem;
            if (customer != null)
            {
                CustomerStaticMethods.Removecustomer(customer);
                CustomerStaticMethods.BindCustomers(this,dataGridView1);
                if (dataGridView1.RowCount > 0)
                {

                    dataGridView1.CurrentCell = dataGridView1.Rows[rowpos].Cells[0];
                }
            }
            else
            {
                MessageBox.Show("Please Select a Customer First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomersList_Load(object sender, EventArgs e)
        {

        }

        //add shipping address
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (ShippingAddressStaticMethods.AddShippingAddress())
            {
                
                if (dataGridView1.RowCount > 0)
                {

                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0];
                }
            }

        }
    }
    }

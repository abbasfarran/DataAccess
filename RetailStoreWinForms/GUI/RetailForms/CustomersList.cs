using System;
using System.Linq;
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
            ShippingAdressbgs = new BindingSource();
            Customersbgs.DataSourceChanged += Customersbgs_DataSourceChanged;
            ShippingAdressbgs.DataSourceChanged += ShippingAdressbgs_DataSourceChanged;
            ;
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
            dataGridView1.CurrentCell = null;
        }

        //customers list
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer customer = (Customer) dataGridView1.CurrentRow?.DataBoundItem;
            ShippingAddressStaticMethods.BindShippingAddresses(customer,ShippingAdressbgs);
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
            CustomerStaticMethods.BindCustomers(this, dataGridView1);
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
            Customer customer = (Customer) dataGridView1.CurrentRow?.DataBoundItem;
            if (customer != null)
            {
                CustomerStaticMethods.Removecustomer(customer);
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

        private void CustomersList_Load(object sender, EventArgs e)
        {

        }

        //add shipping address
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
            Customer customer = (Customer) dataGridView1.CurrentRow?.DataBoundItem;
            if (customer == null)
            {
                MessageBox.Show("Please select a customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
           

            if (ShippingAddressStaticMethods.AddShippingAddress(customer))
                {

                    if (dataGridView1.RowCount > 0)
                    {
                    ShippingAddressStaticMethods.BindShippingAddresses(customer,ShippingAdressbgs);
                        
                    }
                }

            
            
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)dataGridView1.CurrentRow?.DataBoundItem;
            ShippingAddress shippingAddress = (ShippingAddress) dataGridView2.CurrentRow?.DataBoundItem;
            if (shippingAddress == null)
            {
                MessageBox.Show("Please select a Shipping Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
            if (ShippingAddressStaticMethods.EditShippingAddress(shippingAddress))
            {
                if (dataGridView1.RowCount > 0)
                {
                    ShippingAddressStaticMethods.BindShippingAddresses(customer, ShippingAdressbgs);

                }
            }

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            int rowpos = -1;
            if (dataGridView2.CurrentRow != null)
            {
                rowpos = dataGridView2.CurrentRow.Index;
            }
            ShippingAddress shippingAddress = (ShippingAddress)dataGridView2.CurrentRow?.DataBoundItem;
            Customer customer = shippingAddress?.Customer;
            if (shippingAddress != null)
            {
                ShippingAddressStaticMethods.RemoveShippingAddress(shippingAddress);
                ShippingAddressStaticMethods.BindShippingAddresses(customer,ShippingAdressbgs);
                if (dataGridView2.RowCount > 0)
                {

                    dataGridView2.CurrentCell = dataGridView2.Rows[rowpos].Cells[0];
                }
            }
            else
            {
                MessageBox.Show("Please Select a shipping address First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

    
    

using System;
using System.Windows.Forms;
using DataEntities.Entities.Retail;

namespace RetailStoreWinForms
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

        private void CustomersList_Load(object sender, EventArgs e)
        {
        }

        private void CustomersList_Shown(object sender, EventArgs e)
        {
        }

        private void Customersbgs_DataSourceChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Customersbgs;
            dataGridView1.ClearSelection();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer customer = (Customer)dataGridView1.CurrentRow?.DataBoundItem;
            if (customer?.ShippingAddresses.Count==0)
            {
                splitContainer1.Panel2Collapsed = true;
                return;
            }
            ShippingAdressbgs.DataSource = customer.ShippingAddresses;
            splitContainer1.Panel2Collapsed = false;
        }
    }
}
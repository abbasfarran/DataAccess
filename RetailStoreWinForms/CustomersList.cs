using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repositories;
using DataEntities.Entities.Retail;

namespace RetailStoreWinForms
{
    public partial class CustomersList : Form
    {
        public CustomersList()
        {
            InitializeComponent();
        }

        private void CustomersList_Load(object sender, EventArgs e)
        {
            

        }

        private void CustomersList_Shown(object sender, EventArgs e)
        {
            CustomerRepository customerRepository = new CustomerRepository();

            List<Customer> customers = customerRepository.All();
            this.WindowState = FormWindowState.Maximized;
            BindingSource customersbgs = new BindingSource() { DataSource = customers };
            BindingSource shippingAdressbgs = new BindingSource() { DataSource = customersbgs  };
            dataGridView1.DataSource = customersbgs;
           
            
           
        }
    }
}

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
            dataGridView1.DataSource = customerRepository.All();
        }
    }
}

using System;
using System.CodeDom;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            CustomerForm ctf = new CustomerForm();
            var result = ctf.ShowDialog();
            if (result == DialogResult.Yes)
            {
                CustomerRepository customerRepository=new CustomerRepository();
                customerRepository.Add(ctf.Customer);
                customerRepository.Save();
                ctf.Dispose();
            };

        }
    }
}

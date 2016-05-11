using System;
using System.Drawing.Text;
using System.Windows.Forms;
using DataAccess.Repositories;
using DataEntities;

namespace RetailStoreWinForms
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
            
            CustomerForm ctf = new CustomerForm();
            var result = ctf.ShowDialog();
            if (result == DialogResult.Yes)
            {
                CustomerRepository customerRepository=new CustomerRepository();
                customerRepository.Add(ctf.Customer);
                customerRepository.Save();
                ctf.Dispose();
                LoadCustomersForm();
            };

        }

        private void existingCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCustomersForm();
        }

        private void LoadCustomersForm()
        {
            
            if (!_customersList.Visible)
            {
                _customersList = new CustomersList {MdiParent = this};
                _customersList.Show();
                _customersList.WindowState = FormWindowState.Maximized;
            }
            CustomerRepository ctr = new CustomerRepository();
            _customersList.Customersbgs.DataSource = ctr.All();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyContext mct=new MyContext();
            mct.Customers.FindAsync(1);
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

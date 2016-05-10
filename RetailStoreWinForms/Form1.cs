using System;
using System.Windows.Forms;
using DataAccess.Repositories;
using DataEntities;

namespace RetailStoreWinForms
{
    public partial class Form1 : Form
    {
        private new Form ActiveForm { get; set; }
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
                LoadCustomersForm();
            };

        }

        private void existingCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCustomersForm();
        }

        private void LoadCustomersForm()
        {
            ActiveForm?.Close();
            ActiveForm = new CustomersList {MdiParent = this};
            ActiveForm.Show();
            ActiveForm.WindowState = FormWindowState.Maximized;
          
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

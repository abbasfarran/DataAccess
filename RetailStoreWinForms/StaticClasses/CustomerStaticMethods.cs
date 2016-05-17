using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Windows.Forms;
using DataAccess.Repositories;
using DataEntities;
using DataEntities.Entities.Retail;
using RetailStoreWinForms.GUI;
using RetailStoreWinForms.GUI.RetailForms;

namespace RetailStoreWinForms.StaticClasses
{
    public static class CustomerStaticMethods
    {
        public static MyContext mct;
       public static bool Addcustomer()
        {
            CustomerForm ctf = new CustomerForm();
            var result = ctf.ShowDialog();
            if (result == DialogResult.Yes)
            {
                CustomerRepository customerRepository = new CustomerRepository(mct);
                customerRepository.Add(ctf.Customer);
                customerRepository.Save();
                ctf.Dispose();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Removecustomer(Customer customer)
        {
            
                
            var result = MessageBox.Show("Are you sure you to delete the customer:" + customer.FullName + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                CustomerRepository customerRepository = new CustomerRepository(mct);
                customerRepository.Remove(customer);
                customerRepository.Save();
              
            }
        }
        public static void Editcustomer(Customer customer)
        {
            CustomerForm ctf = new CustomerForm();
            ctf.Customer = customer;
            var result = ctf.ShowDialog();
            if (result == DialogResult.Yes)
            {
                CustomerRepository ctr=new CustomerRepository(mct);
                ctr.Update(ctf.Customer);
                ctr.Save();
                ctf.Dispose();
            }
        }
        public static void LoadCustomersForm(ref CustomersList customersList,Form1 frm)
        {
            if (!customersList.Visible)
            {
                customersList = new CustomersList { MdiParent = frm };
                customersList.Show();
                customersList.WindowState = FormWindowState.Maximized;
            }
           
        }

        public static void BindCustomers(CustomersList customersList,DataGridView dgv,ref bool bindingComplete)
        {
            bindingComplete = false;
            CustomerRepository ctr = new CustomerRepository(mct);
            customersList.Customersbgs.DataSource = ctr.All();
            dgv.DataSource = customersList.Customersbgs;
            dgv.CurrentCell = null;
            bindingComplete = true;

        }
    }
}


 


using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataAccess.Repositories;
using DataEntities;
using DataEntities.Entities.Common;
using DataEntities.Entities.Retail;
using RetailStoreWinForms.GUI;
using RetailStoreWinForms.GUI.CommonForms;
using RetailStoreWinForms.GUI.RetailForms;

namespace RetailStoreWinForms.StaticClasses
{
    public static class ShippingAddressStaticMethods
    {
        public static MyContext mct;
        public static bool AddShippingAddress(Customer customer)
        {
            AddressForm satf = new AddressForm();
            GovernorateRepository governorateRepository = new GovernorateRepository(mct);
            satf.Governorates = governorateRepository.Governorates();
            satf.Customer = customer;
            var result =satf.ShowDialog();
            if (result == DialogResult.Yes)
            {
                ShippingAddressRepository shippingAddressRepository = new ShippingAddressRepository(mct);
                shippingAddressRepository.Add(satf.ShippingAddress);
                shippingAddressRepository.Save();
                satf.Dispose();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void RemoveShippingAddress(ShippingAddress shippingAddress)
        {


            var result = MessageBox.Show("Are you sure you to delete the Shipping Address:" + shippingAddress.Street + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                ShippingAddressRepository shippingAddressRepository = new ShippingAddressRepository(mct);
                shippingAddressRepository.Remove(shippingAddress);
                shippingAddressRepository.Save();

            }
        }
        public static bool EditShippingAddress(ShippingAddress shippingAddress)
        {
            AddressForm ctf = new AddressForm();
            ctf.ShippingAddress = shippingAddress;
            GovernorateRepository governorateRepository = new GovernorateRepository(mct);
            ctf.Governorates = governorateRepository.Governorates();
            var result = ctf.ShowDialog();

            if (result == DialogResult.Yes)
            {
                ShippingAddressRepository ctr = new ShippingAddressRepository(mct);
                ctr.Update(ctf.ShippingAddress);
                ctr.Save();
                ctf.Dispose();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void LoadShippingAddressesForm(ref CustomersList customersList, Form1 frm)
        {
            CustomerStaticMethods.LoadCustomersForm(ref customersList,frm);

        }

        public static List<Caza> CazasByGovernorateId(Governorate governorate)
        {
            CazaRepository cazaRepository=new CazaRepository(mct);
            return cazaRepository.CazasByGovernorate(governorate.Id);
        }
        public static void BindShippingAddresses(Customer customer,BindingSource ShippingAdressbgs)
        {
            if (customer?.ShippingAddresses.Count == 0)
            {
                ShippingAdressbgs.DataSource = null;
                return;
            }
            ShippingAdressbgs.DataSource = customer?.ShippingAddresses.ToList();
        }
        //public static void BindShippingAddresses(CustomersList customersList, DataGridView dgv)
        //{
        //    ShippingAddressRepository ctr = new ShippingAddressRepository(mct);
        //    customersList.Customersbgs.DataSource = ctr.All();

        //}
    }

}


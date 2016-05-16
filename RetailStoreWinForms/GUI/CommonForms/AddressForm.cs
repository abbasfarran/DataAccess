using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataEntities.Entities.Common;
using DataEntities.Entities.Retail;
using RetailStoreWinForms.StaticClasses;

namespace RetailStoreWinForms.GUI.CommonForms
{
    public partial class AddressForm : Form
    {
        public ShippingAddress ShippingAddress;
        public List<Governorate> Governorates;
        public List<Caza> Cazas;
        public Customer Customer;
        public AddressForm()
        {
            InitializeComponent();
          
            
        }

      

        private void AddressForm_Shown(object sender, EventArgs e)
        {
            comboBox1.DataSource = Governorates;
            comboBox1.SelectedIndex=-1;
            comboBox2.SelectedIndex = -1;
            comboBox1.SelectedItem = ShippingAddress?.Caza.Governorate;
            comboBox2.SelectedItem = ShippingAddress?.Caza;
            textBox2.Text = ShippingAddress?.Street;
            textBox1.Text = ShippingAddress?.Village;
            if (ShippingAddress != null)
            {
                Customer = ShippingAddress.Customer;
            }
            
        }

        private void AddressForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex>-1)
            {
                Governorate gov = new Governorate();
                gov = (Governorate)comboBox1.SelectedItem;
                comboBox2.DataSource = ShippingAddressStaticMethods.CazasByGovernorateId(gov);
                comboBox2.SelectedIndex = -1;
            }
            else
            {
                comboBox2.DataSource = null;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ShippingAddress == null)
                ShippingAddress=new ShippingAddress();
            Caza caza = (Caza) comboBox2.SelectedItem;
            ShippingAddress.CustomerId = Customer.Id;
            ShippingAddress.CazaId = caza.Id;
            ShippingAddress.Street = textBox2.Text;
            ShippingAddress.Village = textBox1.Text;
            this.DialogResult=DialogResult.Yes;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Abort;
            this.Close();
        }
    }
}

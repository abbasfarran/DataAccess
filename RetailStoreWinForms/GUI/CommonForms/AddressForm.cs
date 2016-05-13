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
        public AddressForm()
        {
            InitializeComponent();
            ShippingAddress = new ShippingAddress();
        }

      

        private void AddressForm_Shown(object sender, EventArgs e)
        {
            comboBox1.DataSource = Governorates;
            comboBox1.SelectedIndex=-1;
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
            }
            
        }
    }
}

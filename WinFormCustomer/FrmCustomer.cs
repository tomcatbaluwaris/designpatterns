﻿using System;
using System.Windows.Forms;
using Factory;
using InterfaceCustomer.Properties;

namespace WinFormCustomer
{
    public partial class FrmCustomer : Form
    {
        // private ICustomer _customer;
        // private ICustomer _lead;
        private ICustomer _customerBase;

        public FrmCustomer()
        {
            InitializeComponent();
            InitializeCustomerComboBox();
        }

        private void InitializeCustomerComboBox()
        {
            //customerBindingSource = new BindingSource();
            //comboBox1.DataSource = new List<object>() { new  { CustomerType = "test1" }, new { CustomerType = "test2" } };
            //comboBox1.DataSource = customerBindingSource;
            //comboBox1.DisplayMember = "CustomerType";            
        }

        private void Validate_Click(object sender, EventArgs e)
        {
            SetCustomer();
            _customerBase.Validate();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {

        }

        private void SetCustomer()
        {
            _customerBase.CustomerName = customerType.Text;
            _customerBase.CustomerName = customerName.Text;
            _customerBase.PhoneNumber = phoneNumber.Text;
            _customerBase.BillAmount = Convert.ToDecimal(billAmount.Text);
            _customerBase.BillDate = Convert.ToDateTime(billDate.Text);
            _customerBase.Address = address.Text;

        }


        private void customerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _customerBase = FactoryCustomer.Create(customerType.Text);
        }
    }
}
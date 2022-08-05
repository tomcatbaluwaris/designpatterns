using MiddleLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Factory;

namespace WinFormCustomer
{
    public partial class FrmCustomer : Form
    {
        private Customer _customer;
        private Lead _lead;
        private CustomerBase _customerBase;

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
            _customer.Validate();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {

        }

        private void customerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _customerBase = FactoryCustomer.Create(comboBox1.Text);
        }
    }
}
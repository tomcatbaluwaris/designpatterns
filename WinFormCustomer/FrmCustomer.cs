using System;
using System.Windows.Forms;
using FactoryCustomer;
using FactoryDal;
using InterfaceCustomer;
using InterfaceDal;

namespace WinFormCustomer
{
    public partial class FrmCustomer : Form
    {
        // private ICustomer _customer;
        // private ICustomer _lead;
        private CustomerBase _customerBase;
        // private IValidation<ICustomer> _validation;

        public FrmCustomer()
        {
            InitializeComponent();
            InitializeCustomerComboBox();
            LoadGrid();
        }
        public void LoadGrid()
        {
            List<CustomerBase> list = new List<CustomerBase>();
            //list.Add(new Cust { Address = "test" });
            dataGridView1.DataSource = list;
        }
        private void InitializeCustomerComboBox()
        {
            //customerBindingSource = new BindingSource();
            //comboBox1.DataSource = new List<object>() { new  { CustomerType = "test1" }, new { CustomerType = "test2" } };
            //comboBox1.DataSource = customerBindingSource;
            //comboBox1.DisplayMember = "CustomerType";            
            dalLayers.Items.Add("ADODal");
            dalLayers.Items.Add("EfDal");

        }

        private void Validate_Click(object sender, EventArgs e)
        {
            SetCustomer();
            _customerBase.Validate();
            // _validation.Validate(_customerBase);
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
            // _customerBase.BillDate = Convert.ToDateTime(billDate.Text);
            _customerBase.BillDate = DateTime.Now;
            _customerBase.Address = address.Text;

        }



        private void customerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _customerBase = FactoryCustomer.Factory<CustomerBase>.Create(customerType.Text);
        }

        // private void button2_Click(object sender, EventArgs e)
        // {
        //     SetCustomer();
        //     var dal = Factory<IDal<ICustomer>>.Create("");
        //     dal.Add(_customerBase);
        //     dal.Save();
        // }
        
        private void button2_Click(object sender, EventArgs e)
        {
            SetCustomer();
            
            // var dal = Factory<IDal<ICustomer>>.Create("");
            IDal<CustomerBase> dal = FactoryDalLayer<IDal<CustomerBase>>.Create("EfDal");
            dal.Add(_customerBase);
            dal.Save();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
    }
}
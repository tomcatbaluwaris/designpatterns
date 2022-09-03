using System;
using System.Windows.Forms;
using EfDal;
using FactoryCustomer;
using FactoryDal;
using InterfaceCustomer;
using InterfaceDal;
using MiddleLayer;

namespace WinFormCustomer
{
    public partial class FrmCustomer : Form
    {
        // private ICustomer _customer;
        // private ICustomer _lead;
        private CustomerBase _customerBase;

        private Customer _customer;
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
            // _customerBase.CustomerName = customerType.Text;
            // _customerBase.CustomerName = customerName.Text;
            // _customerBase.PhoneNumber = phoneNumber.Text;
            // _customerBase.BillAmount = Convert.ToDecimal(billAmount.Text);
            // // _customerBase.BillDate = Convert.ToDateTime(billDate.Text);
            // _customerBase.BillDate = DateTime.Now;
            // _customerBase.Address = address.Text;
            _customer.Id = 1;
            _customer.CustomerName = customerName.Text;
            _customer.PhoneNumber = phoneNumber.Text;
            _customer.BillAmount = Convert.ToDecimal(billAmount.Text);
            // _customerBase.BillDate = Convert.ToDateTime(billDate.Text);
            _customer.BillDate = DateTime.Now;
            _customer.Address = address.Text;

        }



        private void customerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _customer = FactoryCustomer.Factory<Customer>.Create(customerType.Text);
        }

        // private void button2_Click(object sender, EventArgs e)
        // {
        //     SetCustomer();
        //     var dal = Factory<IDal<ICustomer>>.Create("");
        //     dal.Add(_customerBase);
        //     dal.Save();
        // }
        
        private void addDal_Click(object sender, EventArgs e)
        {
            //Unit of Work
            EfUoW efUoW = (EfUoW)FactoryDalLayer<IUoW>.Create("EUoW");
            try
            {
                SetCustomer();
                // var dal = Factory<IRepository<CustomerBase>>.Create("ADODal");
                // dal.SetUnitOfWork(uoW);
                // dal.Add(_customerBase);
                // dal.Save();
                IRepository<Customer> efRepository = FactoryDalLayer<IRepository<Customer>>.Create("EfDal");
                // IRepository<CustomerBase> repository = FactoryDalLayer<IRepository<CustomerBase>>.Create("EfDal");
                
                efRepository.SetUnitOfWork(efUoW);
                efRepository.Add(_customer);
                efRepository.Save();
                // efUoW.Commit();
            }
            catch (Exception exception)
            {
                efUoW.Rollback();
                Console.WriteLine(exception);
                throw;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
    }
}
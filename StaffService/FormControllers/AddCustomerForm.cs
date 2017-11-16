    using StaffService.FormControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StaffService.DataAccess;

namespace StaffService
{
    public partial class AddCustomerForm : MetroFramework.Forms.MetroForm
    {
        public AddCustomerForm()
        {
            InitializeComponent();
            this.StyleManager = CustomerFormStyleManger;
            DBConnection db = new DBConnection();   
            string query = "SELECT busid BusNo FROM Bus";
            busComboBox.DisplayMember = "busid";
            busComboBox.ValueMember = "bus";
            busComboBox.DataSource = db.Select(query);
            busComboBox.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StartUpForm starup = new StartUpForm();
            this.Hide();
            starup.Show();
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            MasterDataForm masterdata = new MasterDataForm();
            masterdata.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StaffService.DataAccess.DBConnection dbcon = new DBConnection();
            dbcon.Inserts("INSERT INTO addcustomer(CustomerName , Contact, StartUpPoint,Destination,BusNumber) Values ('"+ txtBoxName.Text+ "','"+ txtBoxPhone + "','"+ txtBoxStarting + "','"+ txtBoxDestination + "' ,'"+txtBoxBus.Text+"')");
            
        }
    }

    
}

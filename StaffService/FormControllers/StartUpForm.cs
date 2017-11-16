using StaffService.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffService.FormControllers
{
    public partial class StartUpForm : MetroFramework.Forms.MetroForm
    {
        public StartUpForm()
        {
            InitializeComponent();
            this.StyleManager = startupFormStyleManger;
            loadbus_Details();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addcustomer = new AddCustomerForm();
            addcustomer.TopLevel = false;
            addcustomer.AutoScroll = true;
           // addcustomer.panel1.Controls.Add(addcustomer);
            addcustomer.Show();
            this.Close();
            ///AddCustomerForm addcustomer = new AddCustomerForm();
            
            //addcustomer.Show();
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            PaymentForm payment = new PaymentForm();
           // this.Hide();
            payment.Show();

        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            PaymentForm payment = new PaymentForm();
            this.Hide();
            payment.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StaffService.DataAccess.DBConnection dbcon = new DBConnection();
            dbcon.Inserts("INSERT INTO addcustomer(CustomerName , Contact, StartUpPoint,Destination,BusNumber) Values ('" + txtBoxName.Text + "','" + txtBoxPhone.Text + "','" + txtBoxStarting.Text + "','" + txtBoxDestination.Text + "' ,'" + cmboBusNo.SelectedValue.ToString() + "')");
            txtBoxName.Text = null;
            txtBoxPhone.Text = null;
            txtBoxStarting.Text = null;
            txtBoxDestination.Text = null;
            //txtBoxBus.Text = null;
        }

        private void loadbus_Details()
        {
            StaffService.DataAccess.DBConnection dbcon = new DBConnection();

            string query = "SELECT busid ,BusNo FROM Bus";
            cmboBusNo.DisplayMember = "BusNo";
            cmboBusNo.ValueMember = "busid";
            cmboBusNo.DataSource = dbcon.Select(query);

            if (((System.Data.DataTable)cmboBusNo.DataSource).Rows.Count > 0)
            {
                cmboBusNo.SelectedIndex = 0;
            }
        }

        private void btnAddBus_Click_1(object sender, EventArgs e)
        {
            MasterDataForm masterdata = new MasterDataForm();
            masterdata.Show();
        }

        private void metroTextPhone_TextChanged(object sender, EventArgs e)
        {
            StaffService.DataAccess.DBConnection dbcon = new DBConnection();

            string query = "SELECT Customer_Id , CustomerName FROM addcustomer where Contact like '%"+ txtboxPhoneNo.Text + "%'";
            comboBoxName.DisplayMember = "CustomerName";
            comboBoxName.ValueMember = "Customer_Id";
            comboBoxName.DataSource = dbcon.Select(query);
            if (((System.Data.DataTable)comboBoxName.DataSource).Rows.Count > 0)
            {
                comboBoxName.SelectedIndex = 0;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBoxName.Text = null;
            txtBoxPhone.Text = null;
            txtBoxStarting.Text = null;
            txtBoxDestination.Text = null;
            
        }

        private void btnSavePayment_Click(object sender, EventArgs e)
        {

            StaffService.DataAccess.DBConnection dbcon = new DBConnection();
            dbcon.Inserts("INSERT INTO payment(Amount , Date, Customer) Values ('" + metroTextBoxAmount.Text + "','" + monthCalendar.SelectionRange.Start + "' ,'" + comboBoxName.SelectedValue.ToString() + "')");
            StaffService.SMS.SMSGateway sms = new SMS.SMSGateway();

            sms.sendSMS(metroTextBoxAmount.Text, txtboxPhoneNo.Text);
            metroTextBoxAmount.Text = null;
            txtboxPhoneNo.Text = null;
            comboBoxName.DataSource = null;
        }
    }
}

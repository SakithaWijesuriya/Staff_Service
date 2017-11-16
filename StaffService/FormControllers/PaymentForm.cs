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
    public partial class PaymentForm : MetroFramework.Forms.MetroForm
    {
        public PaymentForm()
        {
            InitializeComponent();
            this.StyleManager = paymentStyleManager;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StartUpForm starup = new StartUpForm();
            this.Close();
            starup.Show();
        }
    }
}

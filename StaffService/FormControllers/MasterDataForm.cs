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
    public partial class MasterDataForm : MetroFramework.Forms.MetroForm
    {
        public MasterDataForm()
        {
            InitializeComponent();
            this.StyleManager = masterStyleManager;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StaffService.DataAccess.DBConnection dbcon = new DBConnection();
            dbcon.Inserts("INSERT INTO bus( busNo,Route) Values ('" + txtboxBusNo.Text + "' ,'" + txtboxRoute.Text + "')");
            txtboxBusNo.Text = null;
            txtboxRoute.Text = null;
           
        }
    }
}

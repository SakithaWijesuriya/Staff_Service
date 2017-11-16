namespace StaffService.FormControllers
{
    partial class StartUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startupFormStyleManger = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btnSavePayment = new MetroFramework.Controls.MetroButton();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.metroTextBoxAmount = new MetroFramework.Controls.MetroTextBox();
            this.txtboxPhoneNo = new MetroFramework.Controls.MetroTextBox();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.lblAmount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmboBusNo = new System.Windows.Forms.ComboBox();
            this.txtBoxDestination = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxStarting = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxName = new MetroFramework.Controls.MetroTextBox();
            this.lblBusNo = new MetroFramework.Controls.MetroLabel();
            this.lblDestination = new MetroFramework.Controls.MetroLabel();
            this.lblStarting = new MetroFramework.Controls.MetroLabel();
            this.lblPhone = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.btnAddBus = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.startupFormStyleManger)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // startupFormStyleManger
            // 
            this.startupFormStyleManger.Owner = null;
            this.startupFormStyleManger.Style = MetroFramework.MetroColorStyle.Lime;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 85);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(816, 398);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.comboBoxName);
            this.tabPage1.Controls.Add(this.metroButton1);
            this.tabPage1.Controls.Add(this.metroButton2);
            this.tabPage1.Controls.Add(this.btnSavePayment);
            this.tabPage1.Controls.Add(this.monthCalendar);
            this.tabPage1.Controls.Add(this.metroTextBoxAmount);
            this.tabPage1.Controls.Add(this.txtboxPhoneNo);
            this.tabPage1.Controls.Add(this.lblDate);
            this.tabPage1.Controls.Add(this.lblAmount);
            this.tabPage1.Controls.Add(this.metroLabel1);
            this.tabPage1.Controls.Add(this.metroLabel2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(808, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Make Payment";
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(369, 55);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(175, 21);
            this.comboBoxName.TabIndex = 20;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(509, 326);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(79, 24);
            this.metroButton1.TabIndex = 19;
            this.metroButton1.Text = "Back";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(394, 326);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(79, 24);
            this.metroButton2.TabIndex = 18;
            this.metroButton2.Text = "Cancel";
            this.metroButton2.UseSelectable = true;
            // 
            // btnSavePayment
            // 
            this.btnSavePayment.Location = new System.Drawing.Point(276, 327);
            this.btnSavePayment.Name = "btnSavePayment";
            this.btnSavePayment.Size = new System.Drawing.Size(79, 24);
            this.btnSavePayment.TabIndex = 17;
            this.btnSavePayment.Text = "Save";
            this.btnSavePayment.UseSelectable = true;
            this.btnSavePayment.Click += new System.EventHandler(this.btnSavePayment_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(369, 152);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 16;
            // 
            // metroTextBoxAmount
            // 
            // 
            // 
            // 
            this.metroTextBoxAmount.CustomButton.Image = null;
            this.metroTextBoxAmount.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.metroTextBoxAmount.CustomButton.Name = "";
            this.metroTextBoxAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxAmount.CustomButton.TabIndex = 1;
            this.metroTextBoxAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxAmount.CustomButton.UseSelectable = true;
            this.metroTextBoxAmount.CustomButton.Visible = false;
            this.metroTextBoxAmount.Lines = new string[0];
            this.metroTextBoxAmount.Location = new System.Drawing.Point(369, 99);
            this.metroTextBoxAmount.MaxLength = 32767;
            this.metroTextBoxAmount.Name = "metroTextBoxAmount";
            this.metroTextBoxAmount.PasswordChar = '\0';
            this.metroTextBoxAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxAmount.SelectedText = "";
            this.metroTextBoxAmount.SelectionLength = 0;
            this.metroTextBoxAmount.SelectionStart = 0;
            this.metroTextBoxAmount.ShortcutsEnabled = true;
            this.metroTextBoxAmount.Size = new System.Drawing.Size(179, 23);
            this.metroTextBoxAmount.TabIndex = 15;
            this.metroTextBoxAmount.UseSelectable = true;
            this.metroTextBoxAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtboxPhoneNo
            // 
            // 
            // 
            // 
            this.txtboxPhoneNo.CustomButton.Image = null;
            this.txtboxPhoneNo.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.txtboxPhoneNo.CustomButton.Name = "";
            this.txtboxPhoneNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxPhoneNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxPhoneNo.CustomButton.TabIndex = 1;
            this.txtboxPhoneNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxPhoneNo.CustomButton.UseSelectable = true;
            this.txtboxPhoneNo.CustomButton.Visible = false;
            this.txtboxPhoneNo.Lines = new string[0];
            this.txtboxPhoneNo.Location = new System.Drawing.Point(369, 6);
            this.txtboxPhoneNo.MaxLength = 32767;
            this.txtboxPhoneNo.Name = "txtboxPhoneNo";
            this.txtboxPhoneNo.PasswordChar = '\0';
            this.txtboxPhoneNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxPhoneNo.SelectedText = "";
            this.txtboxPhoneNo.SelectionLength = 0;
            this.txtboxPhoneNo.SelectionStart = 0;
            this.txtboxPhoneNo.ShortcutsEnabled = true;
            this.txtboxPhoneNo.Size = new System.Drawing.Size(179, 23);
            this.txtboxPhoneNo.TabIndex = 14;
            this.txtboxPhoneNo.UseSelectable = true;
            this.txtboxPhoneNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxPhoneNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtboxPhoneNo.TextChanged += new System.EventHandler(this.metroTextPhone_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(213, 144);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 19);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Date";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(213, 99);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(56, 19);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Text = "Amount";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(213, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Contact Number";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(213, 55);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.cmboBusNo);
            this.tabPage2.Controls.Add(this.txtBoxDestination);
            this.tabPage2.Controls.Add(this.txtBoxStarting);
            this.tabPage2.Controls.Add(this.txtBoxPhone);
            this.tabPage2.Controls.Add(this.txtBoxName);
            this.tabPage2.Controls.Add(this.lblBusNo);
            this.tabPage2.Controls.Add(this.lblDestination);
            this.tabPage2.Controls.Add(this.lblStarting);
            this.tabPage2.Controls.Add(this.lblPhone);
            this.tabPage2.Controls.Add(this.lblName);
            this.tabPage2.Controls.Add(this.btnAddBus);
            this.tabPage2.Controls.Add(this.btnBack);
            this.tabPage2.Controls.Add(this.btnCancel);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(808, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Customer";
            // 
            // cmboBusNo
            // 
            this.cmboBusNo.FormattingEnabled = true;
            this.cmboBusNo.Location = new System.Drawing.Point(330, 189);
            this.cmboBusNo.Name = "cmboBusNo";
            this.cmboBusNo.Size = new System.Drawing.Size(155, 21);
            this.cmboBusNo.TabIndex = 52;
            // 
            // txtBoxDestination
            // 
            // 
            // 
            // 
            this.txtBoxDestination.CustomButton.Image = null;
            this.txtBoxDestination.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtBoxDestination.CustomButton.Name = "";
            this.txtBoxDestination.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxDestination.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxDestination.CustomButton.TabIndex = 1;
            this.txtBoxDestination.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxDestination.CustomButton.UseSelectable = true;
            this.txtBoxDestination.CustomButton.Visible = false;
            this.txtBoxDestination.Lines = new string[0];
            this.txtBoxDestination.Location = new System.Drawing.Point(330, 147);
            this.txtBoxDestination.MaxLength = 32767;
            this.txtBoxDestination.Name = "txtBoxDestination";
            this.txtBoxDestination.PasswordChar = '\0';
            this.txtBoxDestination.PromptText = "Destination";
            this.txtBoxDestination.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxDestination.SelectedText = "";
            this.txtBoxDestination.SelectionLength = 0;
            this.txtBoxDestination.SelectionStart = 0;
            this.txtBoxDestination.ShortcutsEnabled = true;
            this.txtBoxDestination.Size = new System.Drawing.Size(155, 23);
            this.txtBoxDestination.TabIndex = 50;
            this.txtBoxDestination.UseSelectable = true;
            this.txtBoxDestination.WaterMark = "Destination";
            this.txtBoxDestination.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxDestination.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBoxStarting
            // 
            // 
            // 
            // 
            this.txtBoxStarting.CustomButton.Image = null;
            this.txtBoxStarting.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtBoxStarting.CustomButton.Name = "";
            this.txtBoxStarting.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxStarting.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxStarting.CustomButton.TabIndex = 1;
            this.txtBoxStarting.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxStarting.CustomButton.UseSelectable = true;
            this.txtBoxStarting.CustomButton.Visible = false;
            this.txtBoxStarting.Lines = new string[0];
            this.txtBoxStarting.Location = new System.Drawing.Point(330, 110);
            this.txtBoxStarting.MaxLength = 32767;
            this.txtBoxStarting.Name = "txtBoxStarting";
            this.txtBoxStarting.PasswordChar = '\0';
            this.txtBoxStarting.PromptText = "Meater Start";
            this.txtBoxStarting.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxStarting.SelectedText = "";
            this.txtBoxStarting.SelectionLength = 0;
            this.txtBoxStarting.SelectionStart = 0;
            this.txtBoxStarting.ShortcutsEnabled = true;
            this.txtBoxStarting.Size = new System.Drawing.Size(155, 23);
            this.txtBoxStarting.TabIndex = 49;
            this.txtBoxStarting.UseSelectable = true;
            this.txtBoxStarting.WaterMark = "Meater Start";
            this.txtBoxStarting.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxStarting.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBoxPhone
            // 
            // 
            // 
            // 
            this.txtBoxPhone.CustomButton.Image = null;
            this.txtBoxPhone.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtBoxPhone.CustomButton.Name = "";
            this.txtBoxPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxPhone.CustomButton.TabIndex = 1;
            this.txtBoxPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxPhone.CustomButton.UseSelectable = true;
            this.txtBoxPhone.CustomButton.Visible = false;
            this.txtBoxPhone.Lines = new string[0];
            this.txtBoxPhone.Location = new System.Drawing.Point(330, 70);
            this.txtBoxPhone.MaxLength = 32767;
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.PasswordChar = '\0';
            this.txtBoxPhone.PromptText = "XXXXXXXXXX";
            this.txtBoxPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxPhone.SelectedText = "";
            this.txtBoxPhone.SelectionLength = 0;
            this.txtBoxPhone.SelectionStart = 0;
            this.txtBoxPhone.ShortcutsEnabled = true;
            this.txtBoxPhone.Size = new System.Drawing.Size(155, 23);
            this.txtBoxPhone.TabIndex = 48;
            this.txtBoxPhone.UseSelectable = true;
            this.txtBoxPhone.WaterMark = "XXXXXXXXXX";
            this.txtBoxPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBoxName
            // 
            // 
            // 
            // 
            this.txtBoxName.CustomButton.Image = null;
            this.txtBoxName.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtBoxName.CustomButton.Name = "";
            this.txtBoxName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxName.CustomButton.TabIndex = 1;
            this.txtBoxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxName.CustomButton.UseSelectable = true;
            this.txtBoxName.CustomButton.Visible = false;
            this.txtBoxName.Lines = new string[0];
            this.txtBoxName.Location = new System.Drawing.Point(330, 33);
            this.txtBoxName.MaxLength = 32767;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.PasswordChar = '\0';
            this.txtBoxName.PromptText = "Name of the Driver";
            this.txtBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxName.SelectedText = "";
            this.txtBoxName.SelectionLength = 0;
            this.txtBoxName.SelectionStart = 0;
            this.txtBoxName.ShortcutsEnabled = true;
            this.txtBoxName.Size = new System.Drawing.Size(155, 23);
            this.txtBoxName.TabIndex = 47;
            this.txtBoxName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxName.UseSelectable = true;
            this.txtBoxName.WaterMark = "Name of the Driver";
            this.txtBoxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblBusNo
            // 
            this.lblBusNo.AutoSize = true;
            this.lblBusNo.Location = new System.Drawing.Point(123, 189);
            this.lblBusNo.Name = "lblBusNo";
            this.lblBusNo.Size = new System.Drawing.Size(82, 19);
            this.lblBusNo.TabIndex = 46;
            this.lblBusNo.Text = "Bus Number";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(123, 147);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(69, 19);
            this.lblDestination.TabIndex = 45;
            this.lblDestination.Text = "Desination";
            // 
            // lblStarting
            // 
            this.lblStarting.AutoSize = true;
            this.lblStarting.Location = new System.Drawing.Point(123, 110);
            this.lblStarting.Name = "lblStarting";
            this.lblStarting.Size = new System.Drawing.Size(54, 19);
            this.lblStarting.TabIndex = 44;
            this.lblStarting.Text = "Starting";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(123, 70);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(107, 19);
            this.lblPhone.TabIndex = 43;
            this.lblPhone.Text = "Contact Number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(123, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 19);
            this.lblName.TabIndex = 42;
            this.lblName.Text = "Name";
            // 
            // btnAddBus
            // 
            this.btnAddBus.Location = new System.Drawing.Point(512, 186);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(75, 23);
            this.btnAddBus.TabIndex = 41;
            this.btnAddBus.Text = "Add Bus";
            this.btnAddBus.UseSelectable = true;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(550, 264);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(442, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(330, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 506);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "StartUpForm";
            this.Text = "Staff Service";
            ((System.ComponentModel.ISupportInitialize)(this.startupFormStyleManger)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager startupFormStyleManger;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroFramework.Controls.MetroButton btnAddBus;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.ComboBox cmboBusNo;
        private MetroFramework.Controls.MetroTextBox txtBoxDestination;
        private MetroFramework.Controls.MetroTextBox txtBoxStarting;
        private MetroFramework.Controls.MetroTextBox txtBoxPhone;
        private MetroFramework.Controls.MetroTextBox txtBoxName;
        private MetroFramework.Controls.MetroLabel lblBusNo;
        private MetroFramework.Controls.MetroLabel lblDestination;
        private MetroFramework.Controls.MetroLabel lblStarting;
        private MetroFramework.Controls.MetroLabel lblPhone;
        private MetroFramework.Controls.MetroLabel lblName;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btnSavePayment;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAmount;
        private MetroFramework.Controls.MetroTextBox txtboxPhoneNo;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroLabel lblAmount;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox comboBoxName;
    }
}
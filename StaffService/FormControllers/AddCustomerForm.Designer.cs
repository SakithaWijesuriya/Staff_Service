namespace StaffService
{
    partial class AddCustomerForm
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
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblPhone = new MetroFramework.Controls.MetroLabel();
            this.lblStarting = new MetroFramework.Controls.MetroLabel();
            this.lblDestination = new MetroFramework.Controls.MetroLabel();
            this.lblBusNo = new MetroFramework.Controls.MetroLabel();
            this.txtBoxName = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxStarting = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxDestination = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxBus = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.CustomerFormStyleManger = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnAddBus = new MetroFramework.Controls.MetroButton();
            this.busComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerFormStyleManger)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(61, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(61, 127);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(107, 19);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Contact Number";
            // 
            // lblStarting
            // 
            this.lblStarting.AutoSize = true;
            this.lblStarting.Location = new System.Drawing.Point(61, 167);
            this.lblStarting.Name = "lblStarting";
            this.lblStarting.Size = new System.Drawing.Size(54, 19);
            this.lblStarting.TabIndex = 2;
            this.lblStarting.Text = "Starting";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(61, 204);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(69, 19);
            this.lblDestination.TabIndex = 3;
            this.lblDestination.Text = "Desination";
            // 
            // lblBusNo
            // 
            this.lblBusNo.AutoSize = true;
            this.lblBusNo.Location = new System.Drawing.Point(61, 246);
            this.lblBusNo.Name = "lblBusNo";
            this.lblBusNo.Size = new System.Drawing.Size(82, 19);
            this.lblBusNo.TabIndex = 4;
            this.lblBusNo.Text = "Bus Number";
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
            this.txtBoxName.Location = new System.Drawing.Point(268, 90);
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
            this.txtBoxName.TabIndex = 5;
            this.txtBoxName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxName.UseSelectable = true;
            this.txtBoxName.WaterMark = "Name of the Driver";
            this.txtBoxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtBoxPhone.Location = new System.Drawing.Point(268, 127);
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
            this.txtBoxPhone.TabIndex = 6;
            this.txtBoxPhone.UseSelectable = true;
            this.txtBoxPhone.WaterMark = "XXXXXXXXXX";
            this.txtBoxPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtBoxStarting.Location = new System.Drawing.Point(268, 167);
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
            this.txtBoxStarting.TabIndex = 7;
            this.txtBoxStarting.UseSelectable = true;
            this.txtBoxStarting.WaterMark = "Meater Start";
            this.txtBoxStarting.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxStarting.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtBoxDestination.Location = new System.Drawing.Point(268, 204);
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
            this.txtBoxDestination.TabIndex = 8;
            this.txtBoxDestination.UseSelectable = true;
            this.txtBoxDestination.WaterMark = "Destination";
            this.txtBoxDestination.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxDestination.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBoxBus
            // 
            // 
            // 
            // 
            this.txtBoxBus.CustomButton.Image = null;
            this.txtBoxBus.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtBoxBus.CustomButton.Name = "";
            this.txtBoxBus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxBus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxBus.CustomButton.TabIndex = 1;
            this.txtBoxBus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxBus.CustomButton.UseSelectable = true;
            this.txtBoxBus.CustomButton.Visible = false;
            this.txtBoxBus.Lines = new string[0];
            this.txtBoxBus.Location = new System.Drawing.Point(268, 242);
            this.txtBoxBus.MaxLength = 32767;
            this.txtBoxBus.Name = "txtBoxBus";
            this.txtBoxBus.PasswordChar = '\0';
            this.txtBoxBus.PromptText = "XX-XXXX";
            this.txtBoxBus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxBus.SelectedText = "";
            this.txtBoxBus.SelectionLength = 0;
            this.txtBoxBus.SelectionStart = 0;
            this.txtBoxBus.ShortcutsEnabled = true;
            this.txtBoxBus.Size = new System.Drawing.Size(155, 23);
            this.txtBoxBus.TabIndex = 9;
            this.txtBoxBus.UseSelectable = true;
            this.txtBoxBus.WaterMark = "XX-XXXX";
            this.txtBoxBus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxBus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(268, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(380, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            // 
            // CustomerFormStyleManger
            // 
            this.CustomerFormStyleManger.Owner = null;
            this.CustomerFormStyleManger.Style = MetroFramework.MetroColorStyle.Lime;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(488, 320);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddBus
            // 
            this.btnAddBus.Location = new System.Drawing.Point(450, 242);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(75, 23);
            this.btnAddBus.TabIndex = 13;
            this.btnAddBus.Text = "Add Bus";
            this.btnAddBus.UseSelectable = true;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // busComboBox
            // 
            this.busComboBox.FormattingEnabled = true;
            this.busComboBox.Location = new System.Drawing.Point(268, 272);
            this.busComboBox.Name = "busComboBox";
            this.busComboBox.Size = new System.Drawing.Size(155, 21);
            this.busComboBox.TabIndex = 14;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 374);
            this.Controls.Add(this.busComboBox);
            this.Controls.Add(this.btnAddBus);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxBus);
            this.Controls.Add(this.txtBoxDestination);
            this.Controls.Add(this.txtBoxStarting);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblBusNo);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblStarting);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Name = "AddCustomerForm";
            this.Text = "Add Cutsomer";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerFormStyleManger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblPhone;
        private MetroFramework.Controls.MetroLabel lblStarting;
        private MetroFramework.Controls.MetroLabel lblDestination;
        private MetroFramework.Controls.MetroLabel lblBusNo;
        private MetroFramework.Controls.MetroTextBox txtBoxName;
        private MetroFramework.Controls.MetroTextBox txtBoxPhone;
        private MetroFramework.Controls.MetroTextBox txtBoxStarting;
        private MetroFramework.Controls.MetroTextBox txtBoxDestination;
        private MetroFramework.Controls.MetroTextBox txtBoxBus;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Components.MetroStyleManager CustomerFormStyleManger;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnAddBus;
        private System.Windows.Forms.ComboBox busComboBox;
    }
}


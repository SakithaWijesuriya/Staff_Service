namespace StaffService.FormControllers
{
    partial class MasterDataForm
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
            this.lblBusNo = new MetroFramework.Controls.MetroLabel();
            this.lblRoute = new MetroFramework.Controls.MetroLabel();
            this.txtboxBusNo = new MetroFramework.Controls.MetroTextBox();
            this.txtboxRoute = new MetroFramework.Controls.MetroTextBox();
            this.masterStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.masterStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusNo
            // 
            this.lblBusNo.AutoSize = true;
            this.lblBusNo.Location = new System.Drawing.Point(23, 117);
            this.lblBusNo.Name = "lblBusNo";
            this.lblBusNo.Size = new System.Drawing.Size(51, 19);
            this.lblBusNo.TabIndex = 0;
            this.lblBusNo.Text = "Bus No";
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Location = new System.Drawing.Point(23, 165);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(43, 19);
            this.lblRoute.TabIndex = 1;
            this.lblRoute.Text = "Route";
            // 
            // txtboxBusNo
            // 
            // 
            // 
            // 
            this.txtboxBusNo.CustomButton.Image = null;
            this.txtboxBusNo.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.txtboxBusNo.CustomButton.Name = "";
            this.txtboxBusNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxBusNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxBusNo.CustomButton.TabIndex = 1;
            this.txtboxBusNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxBusNo.CustomButton.UseSelectable = true;
            this.txtboxBusNo.CustomButton.Visible = false;
            this.txtboxBusNo.Lines = new string[0];
            this.txtboxBusNo.Location = new System.Drawing.Point(148, 117);
            this.txtboxBusNo.MaxLength = 32767;
            this.txtboxBusNo.Name = "txtboxBusNo";
            this.txtboxBusNo.PasswordChar = '\0';
            this.txtboxBusNo.PromptText = "xx-xxxx";
            this.txtboxBusNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxBusNo.SelectedText = "";
            this.txtboxBusNo.SelectionLength = 0;
            this.txtboxBusNo.SelectionStart = 0;
            this.txtboxBusNo.ShortcutsEnabled = true;
            this.txtboxBusNo.Size = new System.Drawing.Size(158, 23);
            this.txtboxBusNo.TabIndex = 2;
            this.txtboxBusNo.UseSelectable = true;
            this.txtboxBusNo.WaterMark = "xx-xxxx";
            this.txtboxBusNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxBusNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtboxRoute
            // 
            // 
            // 
            // 
            this.txtboxRoute.CustomButton.Image = null;
            this.txtboxRoute.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.txtboxRoute.CustomButton.Name = "";
            this.txtboxRoute.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxRoute.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxRoute.CustomButton.TabIndex = 1;
            this.txtboxRoute.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxRoute.CustomButton.UseSelectable = true;
            this.txtboxRoute.CustomButton.Visible = false;
            this.txtboxRoute.Lines = new string[0];
            this.txtboxRoute.Location = new System.Drawing.Point(148, 165);
            this.txtboxRoute.MaxLength = 32767;
            this.txtboxRoute.Name = "txtboxRoute";
            this.txtboxRoute.PasswordChar = '\0';
            this.txtboxRoute.PromptText = "Route";
            this.txtboxRoute.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxRoute.SelectedText = "";
            this.txtboxRoute.SelectionLength = 0;
            this.txtboxRoute.SelectionStart = 0;
            this.txtboxRoute.ShortcutsEnabled = true;
            this.txtboxRoute.Size = new System.Drawing.Size(158, 23);
            this.txtboxRoute.TabIndex = 3;
            this.txtboxRoute.UseSelectable = true;
            this.txtboxRoute.WaterMark = "Route";
            this.txtboxRoute.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxRoute.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // masterStyleManager
            // 
            this.masterStyleManager.Owner = null;
            this.masterStyleManager.Style = MetroFramework.MetroColorStyle.Lime;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(113, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(242, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            // 
            // MasterDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 356);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtboxRoute);
            this.Controls.Add(this.txtboxBusNo);
            this.Controls.Add(this.lblRoute);
            this.Controls.Add(this.lblBusNo);
            this.Name = "MasterDataForm";
            this.Text = "Bus Details";
            ((System.ComponentModel.ISupportInitialize)(this.masterStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblBusNo;
        private MetroFramework.Controls.MetroLabel lblRoute;
        private MetroFramework.Controls.MetroTextBox txtboxBusNo;
        private MetroFramework.Controls.MetroTextBox txtboxRoute;
        private MetroFramework.Components.MetroStyleManager masterStyleManager;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnCancel;
    }
}
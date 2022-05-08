
namespace WinFormCosmosDb
{
    partial class Form1
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxState = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxCountry = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxCity = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxGivenName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxFamilyName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxFirstName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.AddAddressPetParentBtn = new MetroFramework.Controls.MetroButton();
            this.dataGridViewPets = new System.Windows.Forms.DataGridView();
            this.dataGridViewParents = new System.Windows.Forms.DataGridView();
            this.dataGridViewAddresses = new System.Windows.Forms.DataGridView();
            this.metroButtonAddFamilyPage = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddresses)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(24, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(214, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Add Address && Pet and Parent";
            // 
            // metroTextBoxState
            // 
            // 
            // 
            // 
            this.metroTextBoxState.CustomButton.Image = null;
            this.metroTextBoxState.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.metroTextBoxState.CustomButton.Name = "";
            this.metroTextBoxState.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxState.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxState.CustomButton.TabIndex = 1;
            this.metroTextBoxState.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxState.CustomButton.UseSelectable = true;
            this.metroTextBoxState.CustomButton.Visible = false;
            this.metroTextBoxState.Lines = new string[] {
        "State"};
            this.metroTextBoxState.Location = new System.Drawing.Point(25, 146);
            this.metroTextBoxState.MaxLength = 32767;
            this.metroTextBoxState.Name = "metroTextBoxState";
            this.metroTextBoxState.PasswordChar = '\0';
            this.metroTextBoxState.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxState.SelectedText = "";
            this.metroTextBoxState.SelectionLength = 0;
            this.metroTextBoxState.SelectionStart = 0;
            this.metroTextBoxState.ShortcutsEnabled = true;
            this.metroTextBoxState.Size = new System.Drawing.Size(140, 23);
            this.metroTextBoxState.TabIndex = 1;
            this.metroTextBoxState.Text = "State";
            this.metroTextBoxState.UseSelectable = true;
            this.metroTextBoxState.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxState.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxCountry
            // 
            // 
            // 
            // 
            this.metroTextBoxCountry.CustomButton.Image = null;
            this.metroTextBoxCountry.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.metroTextBoxCountry.CustomButton.Name = "";
            this.metroTextBoxCountry.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxCountry.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCountry.CustomButton.TabIndex = 1;
            this.metroTextBoxCountry.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCountry.CustomButton.UseSelectable = true;
            this.metroTextBoxCountry.CustomButton.Visible = false;
            this.metroTextBoxCountry.Lines = new string[] {
        "Country"};
            this.metroTextBoxCountry.Location = new System.Drawing.Point(25, 175);
            this.metroTextBoxCountry.MaxLength = 32767;
            this.metroTextBoxCountry.Name = "metroTextBoxCountry";
            this.metroTextBoxCountry.PasswordChar = '\0';
            this.metroTextBoxCountry.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCountry.SelectedText = "";
            this.metroTextBoxCountry.SelectionLength = 0;
            this.metroTextBoxCountry.SelectionStart = 0;
            this.metroTextBoxCountry.ShortcutsEnabled = true;
            this.metroTextBoxCountry.Size = new System.Drawing.Size(140, 23);
            this.metroTextBoxCountry.TabIndex = 2;
            this.metroTextBoxCountry.Text = "Country";
            this.metroTextBoxCountry.UseSelectable = true;
            this.metroTextBoxCountry.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCountry.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxCity
            // 
            // 
            // 
            // 
            this.metroTextBoxCity.CustomButton.Image = null;
            this.metroTextBoxCity.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.metroTextBoxCity.CustomButton.Name = "";
            this.metroTextBoxCity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCity.CustomButton.TabIndex = 1;
            this.metroTextBoxCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCity.CustomButton.UseSelectable = true;
            this.metroTextBoxCity.CustomButton.Visible = false;
            this.metroTextBoxCity.Lines = new string[] {
        "City"};
            this.metroTextBoxCity.Location = new System.Drawing.Point(25, 204);
            this.metroTextBoxCity.MaxLength = 32767;
            this.metroTextBoxCity.Name = "metroTextBoxCity";
            this.metroTextBoxCity.PasswordChar = '\0';
            this.metroTextBoxCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCity.SelectedText = "";
            this.metroTextBoxCity.SelectionLength = 0;
            this.metroTextBoxCity.SelectionStart = 0;
            this.metroTextBoxCity.ShortcutsEnabled = true;
            this.metroTextBoxCity.Size = new System.Drawing.Size(140, 23);
            this.metroTextBoxCity.TabIndex = 3;
            this.metroTextBoxCity.Text = "City";
            this.metroTextBoxCity.UseSelectable = true;
            this.metroTextBoxCity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxGivenName
            // 
            // 
            // 
            // 
            this.metroTextBoxGivenName.CustomButton.Image = null;
            this.metroTextBoxGivenName.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.metroTextBoxGivenName.CustomButton.Name = "";
            this.metroTextBoxGivenName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxGivenName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxGivenName.CustomButton.TabIndex = 1;
            this.metroTextBoxGivenName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxGivenName.CustomButton.UseSelectable = true;
            this.metroTextBoxGivenName.CustomButton.Visible = false;
            this.metroTextBoxGivenName.Lines = new string[] {
        "Given Name"};
            this.metroTextBoxGivenName.Location = new System.Drawing.Point(24, 387);
            this.metroTextBoxGivenName.MaxLength = 32767;
            this.metroTextBoxGivenName.Name = "metroTextBoxGivenName";
            this.metroTextBoxGivenName.PasswordChar = '\0';
            this.metroTextBoxGivenName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxGivenName.SelectedText = "";
            this.metroTextBoxGivenName.SelectionLength = 0;
            this.metroTextBoxGivenName.SelectionStart = 0;
            this.metroTextBoxGivenName.ShortcutsEnabled = true;
            this.metroTextBoxGivenName.Size = new System.Drawing.Size(140, 23);
            this.metroTextBoxGivenName.TabIndex = 4;
            this.metroTextBoxGivenName.Text = "Given Name";
            this.metroTextBoxGivenName.UseSelectable = true;
            this.metroTextBoxGivenName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxGivenName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxFamilyName
            // 
            // 
            // 
            // 
            this.metroTextBoxFamilyName.CustomButton.Image = null;
            this.metroTextBoxFamilyName.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.metroTextBoxFamilyName.CustomButton.Name = "";
            this.metroTextBoxFamilyName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxFamilyName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFamilyName.CustomButton.TabIndex = 1;
            this.metroTextBoxFamilyName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFamilyName.CustomButton.UseSelectable = true;
            this.metroTextBoxFamilyName.CustomButton.Visible = false;
            this.metroTextBoxFamilyName.Lines = new string[] {
        "Family Name"};
            this.metroTextBoxFamilyName.Location = new System.Drawing.Point(25, 280);
            this.metroTextBoxFamilyName.MaxLength = 32767;
            this.metroTextBoxFamilyName.Name = "metroTextBoxFamilyName";
            this.metroTextBoxFamilyName.PasswordChar = '\0';
            this.metroTextBoxFamilyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFamilyName.SelectedText = "";
            this.metroTextBoxFamilyName.SelectionLength = 0;
            this.metroTextBoxFamilyName.SelectionStart = 0;
            this.metroTextBoxFamilyName.ShortcutsEnabled = true;
            this.metroTextBoxFamilyName.Size = new System.Drawing.Size(139, 23);
            this.metroTextBoxFamilyName.TabIndex = 5;
            this.metroTextBoxFamilyName.Text = "Family Name";
            this.metroTextBoxFamilyName.UseSelectable = true;
            this.metroTextBoxFamilyName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFamilyName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxFirstName
            // 
            // 
            // 
            // 
            this.metroTextBoxFirstName.CustomButton.Image = null;
            this.metroTextBoxFirstName.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.metroTextBoxFirstName.CustomButton.Name = "";
            this.metroTextBoxFirstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFirstName.CustomButton.TabIndex = 1;
            this.metroTextBoxFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFirstName.CustomButton.UseSelectable = true;
            this.metroTextBoxFirstName.CustomButton.Visible = false;
            this.metroTextBoxFirstName.Lines = new string[] {
        "First Name"};
            this.metroTextBoxFirstName.Location = new System.Drawing.Point(24, 309);
            this.metroTextBoxFirstName.MaxLength = 32767;
            this.metroTextBoxFirstName.Name = "metroTextBoxFirstName";
            this.metroTextBoxFirstName.PasswordChar = '\0';
            this.metroTextBoxFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFirstName.SelectedText = "";
            this.metroTextBoxFirstName.SelectionLength = 0;
            this.metroTextBoxFirstName.SelectionStart = 0;
            this.metroTextBoxFirstName.ShortcutsEnabled = true;
            this.metroTextBoxFirstName.Size = new System.Drawing.Size(140, 23);
            this.metroTextBoxFirstName.TabIndex = 6;
            this.metroTextBoxFirstName.Text = "First Name";
            this.metroTextBoxFirstName.UseSelectable = true;
            this.metroTextBoxFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 124);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Address";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 258);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Parent";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 365);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(27, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Pet";
            // 
            // AddAddressPetParentBtn
            // 
            this.AddAddressPetParentBtn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddAddressPetParentBtn.Location = new System.Drawing.Point(25, 473);
            this.AddAddressPetParentBtn.Name = "AddAddressPetParentBtn";
            this.AddAddressPetParentBtn.Size = new System.Drawing.Size(496, 23);
            this.AddAddressPetParentBtn.TabIndex = 10;
            this.AddAddressPetParentBtn.Text = "ADD";
            this.AddAddressPetParentBtn.UseSelectable = true;
            this.AddAddressPetParentBtn.Click += new System.EventHandler(this.AddAddressPetParentBtn_Click);
            // 
            // dataGridViewPets
            // 
            this.dataGridViewPets.AllowUserToAddRows = false;
            this.dataGridViewPets.AllowUserToDeleteRows = false;
            this.dataGridViewPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPets.Location = new System.Drawing.Point(170, 387);
            this.dataGridViewPets.Name = "dataGridViewPets";
            this.dataGridViewPets.ReadOnly = true;
            this.dataGridViewPets.Size = new System.Drawing.Size(351, 80);
            this.dataGridViewPets.TabIndex = 11;
            // 
            // dataGridViewParents
            // 
            this.dataGridViewParents.AllowUserToAddRows = false;
            this.dataGridViewParents.AllowUserToDeleteRows = false;
            this.dataGridViewParents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParents.Location = new System.Drawing.Point(170, 280);
            this.dataGridViewParents.Name = "dataGridViewParents";
            this.dataGridViewParents.ReadOnly = true;
            this.dataGridViewParents.Size = new System.Drawing.Size(351, 85);
            this.dataGridViewParents.TabIndex = 12;
            // 
            // dataGridViewAddresses
            // 
            this.dataGridViewAddresses.AllowUserToAddRows = false;
            this.dataGridViewAddresses.AllowUserToDeleteRows = false;
            this.dataGridViewAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddresses.Location = new System.Drawing.Point(170, 124);
            this.dataGridViewAddresses.Name = "dataGridViewAddresses";
            this.dataGridViewAddresses.ReadOnly = true;
            this.dataGridViewAddresses.Size = new System.Drawing.Size(351, 136);
            this.dataGridViewAddresses.TabIndex = 13;
            // 
            // metroButtonAddFamilyPage
            // 
            this.metroButtonAddFamilyPage.Location = new System.Drawing.Point(391, 76);
            this.metroButtonAddFamilyPage.Name = "metroButtonAddFamilyPage";
            this.metroButtonAddFamilyPage.Size = new System.Drawing.Size(130, 23);
            this.metroButtonAddFamilyPage.TabIndex = 14;
            this.metroButtonAddFamilyPage.Text = "Go Add Family Page";
            this.metroButtonAddFamilyPage.UseSelectable = true;
            this.metroButtonAddFamilyPage.Click += new System.EventHandler(this.metroButtonAddFamilyPage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 505);
            this.Controls.Add(this.metroButtonAddFamilyPage);
            this.Controls.Add(this.dataGridViewAddresses);
            this.Controls.Add(this.dataGridViewParents);
            this.Controls.Add(this.dataGridViewPets);
            this.Controls.Add(this.AddAddressPetParentBtn);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTextBoxFirstName);
            this.Controls.Add(this.metroTextBoxFamilyName);
            this.Controls.Add(this.metroTextBoxGivenName);
            this.Controls.Add(this.metroTextBoxCity);
            this.Controls.Add(this.metroTextBoxCountry);
            this.Controls.Add(this.metroTextBoxState);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Text = "CosmosDB App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddresses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxState;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCountry;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCity;
        private MetroFramework.Controls.MetroTextBox metroTextBoxGivenName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFamilyName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFirstName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton AddAddressPetParentBtn;
        private System.Windows.Forms.DataGridView dataGridViewPets;
        private System.Windows.Forms.DataGridView dataGridViewParents;
        private System.Windows.Forms.DataGridView dataGridViewAddresses;
        private MetroFramework.Controls.MetroButton metroButtonAddFamilyPage;
    }
}



namespace WinFormCosmosDb
{
    partial class Form2
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
            this.metroButtonAddOtherPage = new MetroFramework.Controls.MetroButton();
            this.dataGridViewFamily = new System.Windows.Forms.DataGridView();
            this.metroTextBoxLastName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.AddFamilyBtn = new MetroFramework.Controls.MetroButton();
            this.metroComboBoxParent = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxChild = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxAddress = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFamily)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButtonAddOtherPage
            // 
            this.metroButtonAddOtherPage.Location = new System.Drawing.Point(391, 63);
            this.metroButtonAddOtherPage.Name = "metroButtonAddOtherPage";
            this.metroButtonAddOtherPage.Size = new System.Drawing.Size(130, 23);
            this.metroButtonAddOtherPage.TabIndex = 22;
            this.metroButtonAddOtherPage.Text = "Go Other Add Page";
            this.metroButtonAddOtherPage.UseSelectable = true;
            this.metroButtonAddOtherPage.Click += new System.EventHandler(this.metroButtonAddOtherPage_Click);
            // 
            // dataGridViewFamily
            // 
            this.dataGridViewFamily.AllowUserToAddRows = false;
            this.dataGridViewFamily.AllowUserToDeleteRows = false;
            this.dataGridViewFamily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFamily.Location = new System.Drawing.Point(184, 111);
            this.dataGridViewFamily.Name = "dataGridViewFamily";
            this.dataGridViewFamily.ReadOnly = true;
            this.dataGridViewFamily.Size = new System.Drawing.Size(337, 342);
            this.dataGridViewFamily.TabIndex = 21;
            // 
            // metroTextBoxLastName
            // 
            // 
            // 
            // 
            this.metroTextBoxLastName.CustomButton.Image = null;
            this.metroTextBoxLastName.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.metroTextBoxLastName.CustomButton.Name = "";
            this.metroTextBoxLastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxLastName.CustomButton.TabIndex = 1;
            this.metroTextBoxLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxLastName.CustomButton.UseSelectable = true;
            this.metroTextBoxLastName.CustomButton.Visible = false;
            this.metroTextBoxLastName.Lines = new string[] {
        "Last Name"};
            this.metroTextBoxLastName.Location = new System.Drawing.Point(23, 140);
            this.metroTextBoxLastName.MaxLength = 32767;
            this.metroTextBoxLastName.Name = "metroTextBoxLastName";
            this.metroTextBoxLastName.PasswordChar = '\0';
            this.metroTextBoxLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxLastName.SelectedText = "";
            this.metroTextBoxLastName.SelectionLength = 0;
            this.metroTextBoxLastName.SelectionStart = 0;
            this.metroTextBoxLastName.ShortcutsEnabled = true;
            this.metroTextBoxLastName.Size = new System.Drawing.Size(140, 23);
            this.metroTextBoxLastName.TabIndex = 17;
            this.metroTextBoxLastName.Text = "Last Name";
            this.metroTextBoxLastName.UseSelectable = true;
            this.metroTextBoxLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxId
            // 
            // 
            // 
            // 
            this.metroTextBoxId.CustomButton.Image = null;
            this.metroTextBoxId.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.metroTextBoxId.CustomButton.Name = "";
            this.metroTextBoxId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxId.CustomButton.TabIndex = 1;
            this.metroTextBoxId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxId.CustomButton.UseSelectable = true;
            this.metroTextBoxId.CustomButton.Visible = false;
            this.metroTextBoxId.Lines = new string[] {
        "Id (text)"};
            this.metroTextBoxId.Location = new System.Drawing.Point(23, 111);
            this.metroTextBoxId.MaxLength = 32767;
            this.metroTextBoxId.Name = "metroTextBoxId";
            this.metroTextBoxId.PasswordChar = '\0';
            this.metroTextBoxId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxId.SelectedText = "";
            this.metroTextBoxId.SelectionLength = 0;
            this.metroTextBoxId.SelectionStart = 0;
            this.metroTextBoxId.ShortcutsEnabled = true;
            this.metroTextBoxId.Size = new System.Drawing.Size(140, 23);
            this.metroTextBoxId.TabIndex = 16;
            this.metroTextBoxId.Text = "Id (text)";
            this.metroTextBoxId.UseSelectable = true;
            this.metroTextBoxId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Add Family";
            // 
            // AddFamilyBtn
            // 
            this.AddFamilyBtn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddFamilyBtn.Location = new System.Drawing.Point(23, 471);
            this.AddFamilyBtn.Name = "AddFamilyBtn";
            this.AddFamilyBtn.Size = new System.Drawing.Size(498, 23);
            this.AddFamilyBtn.TabIndex = 23;
            this.AddFamilyBtn.Text = "ADD";
            this.AddFamilyBtn.UseSelectable = true;
            // 
            // metroComboBoxParent
            // 
            this.metroComboBoxParent.FormattingEnabled = true;
            this.metroComboBoxParent.ItemHeight = 23;
            this.metroComboBoxParent.Location = new System.Drawing.Point(23, 200);
            this.metroComboBoxParent.Name = "metroComboBoxParent";
            this.metroComboBoxParent.Size = new System.Drawing.Size(140, 29);
            this.metroComboBoxParent.TabIndex = 24;
            this.metroComboBoxParent.UseSelectable = true;
            // 
            // metroComboBoxChild
            // 
            this.metroComboBoxChild.FormattingEnabled = true;
            this.metroComboBoxChild.ItemHeight = 23;
            this.metroComboBoxChild.Location = new System.Drawing.Point(23, 263);
            this.metroComboBoxChild.Name = "metroComboBoxChild";
            this.metroComboBoxChild.Size = new System.Drawing.Size(140, 29);
            this.metroComboBoxChild.TabIndex = 25;
            this.metroComboBoxChild.UseSelectable = true;
            // 
            // metroComboBoxAddress
            // 
            this.metroComboBoxAddress.FormattingEnabled = true;
            this.metroComboBoxAddress.ItemHeight = 23;
            this.metroComboBoxAddress.Location = new System.Drawing.Point(24, 330);
            this.metroComboBoxAddress.Name = "metroComboBoxAddress";
            this.metroComboBoxAddress.Size = new System.Drawing.Size(140, 29);
            this.metroComboBoxAddress.TabIndex = 26;
            this.metroComboBoxAddress.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 178);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(103, 19);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Select Parents";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 241);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 19);
            this.metroLabel3.TabIndex = 28;
            this.metroLabel3.Text = "Select Children";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 308);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 19);
            this.metroLabel4.TabIndex = 29;
            this.metroLabel4.Text = "Select Address";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 505);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroComboBoxAddress);
            this.Controls.Add(this.metroComboBoxChild);
            this.Controls.Add(this.metroComboBoxParent);
            this.Controls.Add(this.AddFamilyBtn);
            this.Controls.Add(this.metroButtonAddOtherPage);
            this.Controls.Add(this.dataGridViewFamily);
            this.Controls.Add(this.metroTextBoxLastName);
            this.Controls.Add(this.metroTextBoxId);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form2";
            this.Text = "CosmosDB App";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFamily)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonAddOtherPage;
        private System.Windows.Forms.DataGridView dataGridViewFamily;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLastName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxId;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton AddFamilyBtn;
        private MetroFramework.Controls.MetroComboBox metroComboBoxParent;
        private MetroFramework.Controls.MetroComboBox metroComboBoxChild;
        private MetroFramework.Controls.MetroComboBox metroComboBoxAddress;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}
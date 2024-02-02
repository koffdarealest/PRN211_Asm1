
namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            lbMemberID = new Label();
            txtMemberID = new TextBox();
            lbMemberName = new Label();
            txtMemberName = new TextBox();
            lbEmail = new Label();
            txtEmail = new TextBox();
            lbPassword = new Label();
            txtPassword = new TextBox();
            lbCity = new Label();
            txtCity = new TextBox();
            lbCountry = new Label();
            txtCountry = new TextBox();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            dgvMemberList = new DataGridView();
            lbSearch = new Label();
            txtSearchValue = new TextBox();
            lbSearchCountry = new Label();
            cboCountry = new ComboBox();
            lbSearchCity = new Label();
            cboSearchCity = new ComboBox();
            btnSearch = new Button();
            grSearch = new GroupBox();
            radioByName = new RadioButton();
            radioByID = new RadioButton();
            grFilter = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            grSearch.SuspendLayout();
            grFilter.SuspendLayout();
            SuspendLayout();
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(63, 29);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(66, 15);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(167, 26);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(184, 23);
            txtMemberID.TabIndex = 1;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(63, 70);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(87, 15);
            lbMemberName.TabIndex = 2;
            lbMemberName.Text = "Member Name";
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(167, 67);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(184, 23);
            txtMemberName.TabIndex = 3;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(63, 111);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 4;
            lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(167, 108);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(184, 23);
            txtEmail.TabIndex = 5;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(417, 29);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 6;
            lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(483, 26);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(184, 23);
            txtPassword.TabIndex = 7;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(417, 70);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(28, 15);
            lbCity.TabIndex = 8;
            lbCity.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(483, 67);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(184, 23);
            txtCity.TabIndex = 9;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(417, 111);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(50, 15);
            lbCountry.TabIndex = 10;
            lbCountry.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(483, 108);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(184, 23);
            txtCountry.TabIndex = 11;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(159, 158);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(82, 30);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(324, 158);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(84, 30);
            btnNew.TabIndex = 13;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(488, 158);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 30);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(26, 297);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new Size(670, 216);
            dgvMemberList.TabIndex = 15;
            dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(24, 21);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(42, 15);
            lbSearch.TabIndex = 16;
            lbSearch.Text = "Search";
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new Point(72, 18);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(118, 23);
            txtSearchValue.TabIndex = 17;
            // 
            // lbSearchCountry
            // 
            lbSearchCountry.AutoSize = true;
            lbSearchCountry.Location = new Point(27, 23);
            lbSearchCountry.Name = "lbSearchCountry";
            lbSearchCountry.Size = new Size(50, 15);
            lbSearchCountry.TabIndex = 18;
            lbSearchCountry.Text = "Country";
            // 
            // cboCountry
            // 
            cboCountry.Location = new Point(77, 20);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(165, 23);
            cboCountry.TabIndex = 0;
            cboCountry.SelectedIndexChanged += cboCountry_SelectedIndexChanged;
            // 
            // lbSearchCity
            // 
            lbSearchCity.AutoSize = true;
            lbSearchCity.Location = new Point(32, 58);
            lbSearchCity.Name = "lbSearchCity";
            lbSearchCity.Size = new Size(28, 15);
            lbSearchCity.TabIndex = 19;
            lbSearchCity.Text = "City";
            // 
            // cboSearchCity
            // 
            cboSearchCity.Location = new Point(77, 55);
            cboSearchCity.Name = "cboSearchCity";
            cboSearchCity.Size = new Size(165, 23);
            cboSearchCity.TabIndex = 20;
            cboSearchCity.SelectedIndexChanged += cboSearchCity_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(72, 52);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // grSearch
            // 
            grSearch.Controls.Add(radioByName);
            grSearch.Controls.Add(radioByID);
            grSearch.Controls.Add(txtSearchValue);
            grSearch.Controls.Add(btnSearch);
            grSearch.Controls.Add(lbSearch);
            grSearch.Location = new Point(62, 190);
            grSearch.Name = "grSearch";
            grSearch.Size = new Size(289, 89);
            grSearch.TabIndex = 22;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            // 
            // radioByName
            // 
            radioByName.AutoSize = true;
            radioByName.Checked = true;
            radioByName.Location = new Point(210, 52);
            radioByName.Name = "radioByName";
            radioByName.Size = new Size(73, 19);
            radioByName.TabIndex = 23;
            radioByName.TabStop = true;
            radioByName.Text = "By Name";
            radioByName.UseVisualStyleBackColor = true;
            // 
            // radioByID
            // 
            radioByID.AutoSize = true;
            radioByID.Location = new Point(210, 22);
            radioByID.Name = "radioByID";
            radioByID.Size = new Size(52, 19);
            radioByID.TabIndex = 22;
            radioByID.TabStop = true;
            radioByID.Text = "By ID";
            radioByID.UseVisualStyleBackColor = true;
            radioByID.CheckedChanged += radioByID_CheckedChanged;
            // 
            // grFilter
            // 
            grFilter.Controls.Add(cboSearchCity);
            grFilter.Controls.Add(lbSearchCity);
            grFilter.Controls.Add(cboCountry);
            grFilter.Controls.Add(lbSearchCountry);
            grFilter.Location = new Point(406, 194);
            grFilter.Name = "grFilter";
            grFilter.Size = new Size(260, 84);
            grFilter.TabIndex = 23;
            grFilter.TabStop = false;
            grFilter.Text = "Filter";
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 525);
            Controls.Add(grFilter);
            Controls.Add(grSearch);
            Controls.Add(dgvMemberList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtCountry);
            Controls.Add(lbCountry);
            Controls.Add(txtCity);
            Controls.Add(lbCity);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtMemberName);
            Controls.Add(lbMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberID);
            Name = "frmMemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Management";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            grFilter.ResumeLayout(false);
            grFilter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Label lbSearchCountry;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Label lbSearchCity;
        private System.Windows.Forms.ComboBox cboSearchCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.RadioButton io;
        private System.Windows.Forms.RadioButton radioByID;
        private System.Windows.Forms.RadioButton radioByName;
        private System.Windows.Forms.GroupBox grFilter;
    }
}
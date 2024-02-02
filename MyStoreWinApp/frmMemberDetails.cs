using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MyStoreWinApp
{
    public partial class frmMemberDetails : Form
    {
        public bool InsertOrUpdate { get; set; }
        public IMemberRepository memberRepository { get; set; }
        public MemberObject memberInfo { get; set; }

        public frmMemberDetails()
        {
            InitializeComponent();
        }
        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate) // Insert
            {
                btnAdd.Visible = true;
                btnUpdate.Visible = false;

            } else
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
                txtMemberID.Enabled = false;

                txtMemberID.Text = memberInfo.MemberID.ToString() ;
                txtMemberName.Text = memberInfo.MemberName;
                txtEmail.Text = memberInfo.Email;
                txtPassword.Text = memberInfo.Password;
                txtConfirm.Text = memberInfo.Password;
                txtCity.Text = memberInfo.City;
                txtCountry.Text = memberInfo.Country;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MemberObject.IsEmail(txtEmail.Text))
                {
                    throw new Exception("Wrong Email!");
                }
                if (!txtPassword.Text.Equals(txtConfirm.Text))
                {
                    throw new Exception("Confirm does not match with Password!!!");
                }
                int MemberID = memberInfo.MemberID;
                String MemberName = txtMemberName.Text;
                String Email = txtEmail.Text;
                String Password = txtPassword.Text;
                String City = txtCity.Text;
                String Country = txtCountry.Text;

                MemberObject member = new MemberObject(MemberID, MemberName, Email, Password, City, Country);
                
                memberRepository.UpdateMember(member);
                MessageBox.Show("Update successfully!!", "Update member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMemberName.Text = member.MemberName;
                txtEmail.Text = member.Email;
                txtPassword.Text = member.Password;
                txtConfirm.Text = member.Password;
                txtCity.Text = member.City;
                txtCountry.Text = member.Country;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MemberObject.IsEmail(txtEmail.Text))
                {
                    throw new Exception("Wrong Email!");
                }
                if (!txtPassword.Text.Equals(txtConfirm.Text))
                {
                    throw new Exception("Confirm does not match with Password!!!");
                }
                int MemberID = int.Parse(txtMemberID.Text);
                String MemberName = txtMemberName.Text;
                String Email = txtEmail.Text;
                String Password = txtPassword.Text;
                String City = txtCity.Text;
                String Country = txtCountry.Text;
                MemberObject member = new MemberObject(MemberID, MemberName, Email, Password, City, Country);
               
                memberRepository.AddMember(member);
                MessageBox.Show("Add successfully!!", "Add new member", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add new member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}

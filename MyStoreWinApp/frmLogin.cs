using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        MemberObject MemberObject { get; set;}

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text.Trim();
            string Password = txtPassword.Text.Trim();
            MemberObject = memberRepository.Login(Email, Password);
            if (MemberObject != null)
            {               
                if (Email.Equals("admin@fstore.com"))
                {
                    frmMemberManagement frmMemberManagement = new frmMemberManagement();                  
                    frmMemberManagement = new frmMemberManagement
                    {
                        loginMember = MemberObject,
                    };
                    frmMemberManagement.Closed += (s, args) => this.Close();
                    this.Hide();
                    frmMemberManagement.Show();
                } else
                {
                    frmMemberDetails frmMemberDetails = new frmMemberDetails
                    {
                        Text = "Member Details",
                        memberInfo = MemberObject,
                        InsertOrUpdate = false,
                        memberRepository = memberRepository
                    };
                    frmMemberDetails.Closed += (s, args) => this.Close();
                    this.Hide();
                    frmMemberDetails.Show();
                }
            } 
            else
            {
                //if (MessageBox.Show("Login failed!!", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                //{
                //    Close();
                //}
                MessageBox.Show("Invalid Email or Password");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

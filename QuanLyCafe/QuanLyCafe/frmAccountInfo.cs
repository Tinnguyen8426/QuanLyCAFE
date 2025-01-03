using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCafe.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyCafe
{
    public partial class frmAccountInfo : Form
    {
        CafeDBContext db;
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public frmAccountInfo(Account acc)
        {
            db = new CafeDBContext();
            InitializeComponent();
            showAccount(acc);
        }

        private void showAccount(Account acc)
        {
            txtAccount.Text = acc.UserName;
            txtUsername.Text = acc.DisplayName;
            btnUpdate.Tag = acc.DisplayName;
        }

        private bool UpdateAccount(string username, string displayname, string password, string newpassword)
        {
            var account = db.Accounts.FirstOrDefault(x => x.UserName == username && x.Password == password);
            if (account != null)
            {
                account.DisplayName = displayname;
                account.Password = newpassword;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string displayname = btnUpdate.Tag.ToString();
            string username = txtAccount.Text;
            string displaynameUpdate = txtUsername.Text;
            string password = txtPass.Text;
            string newpassword = txtNewPass.Text;
            string reenterpassword = txtNewPassComf.Text;
            if(newpassword == "")
            {
                if (updateDisplayName(username, displaynameUpdate, password))
                {
                    MessageBox.Show("Cập nhật tài khoản thành công", "Thoâng báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                if (UpdateAccount(username, displaynameUpdate, password, newpassword))
                {
                    MessageBox.Show("Cập nhật tài khoản thành công", "Thoâng báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool updateDisplayName(string username,string displaynameUpdate, string password)
        {
            var account = db.Accounts.FirstOrDefault(x => x.UserName == username && x.Password == password);
            if (account != null)
            {
                account.DisplayName = displaynameUpdate;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

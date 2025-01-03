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

namespace QuanLyCafe
{
    public partial class frmLogin : Form
    {
        CafeDBContext db;
        public frmLogin()
        {
            db = new CafeDBContext();
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPasword.Focus();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtAccount.Text;
            string password = txtPasword.Text;
            if (login(username, password))
            {
                Account loginAccount = GetAccountByUsername(username);
                txtPasword.Text = "";
                frmTableManager frm = new frmTableManager(loginAccount);
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                txtPasword.Text = "";
                txtAccount.Focus();
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool login(string username, string password)
        {
            var account = db.Accounts.FirstOrDefault(x => x.UserName == username && x.Password == password);
            if (account != null)
            {
                return true;
            }
            else
            { 
                return false;
            }
        }


        public Account GetAccountByUsername(string username)
        {
            Account accounts = new Account();
            accounts = db.Accounts.Where(x => x.UserName == username).FirstOrDefault();
            return accounts;
        }
    }
}

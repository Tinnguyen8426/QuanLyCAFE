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
            if (login())
            {
                txtPasword.Text = "";
                frmTableManager frm = new frmTableManager();
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

        private bool login()
        {
            var account = db.Accounts.FirstOrDefault(x => x.UserName == txtAccount.Text && x.Password == txtPasword.Text);
            if (account != null)
            {
                return true;
            }
            else
            { 
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTableManager frm = new frmTableManager();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}

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
    public partial class frmAdmin : Form
    {
        CafeDBContext db;
        public frmAdmin()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            db = new CafeDBContext();
            var listAccount = db.Accounts.ToList();
            dgvAccount.DataSource = listAccount;
            var listFood = db.Foods.ToList();
            dgvDrink.DataSource = listFood;
            var listTable = db.Tables.ToList();
            dgvTable.DataSource = listTable;
            var listFoodCategory = db.FoodCategories.ToList();
           dgvCategory.DataSource = listFoodCategory;

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }


    }
}

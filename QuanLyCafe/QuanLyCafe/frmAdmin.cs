using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using QuanLyCafe.Model;
using System.Globalization;

namespace QuanLyCafe
{
    public partial class frmAdmin : Form
    {
        CafeDBContext db;
        public frmAdmin()
        {
            db = new CafeDBContext();
            InitializeComponent();
            LoadDateTimePickerBill();
            FillFoodCategoryCombobox(db.FoodCategories.ToList());
            LoadData();
        }
        void LoadDateTimePickerBill()
        {
            //DateTime today = DateTime.Now;
            //dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            //dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        private void FillFoodCategoryCombobox(List<FoodCategory> listCategories)
        {
            this.cmbDrinkCategory.DataSource = listCategories;
            this.cmbDrinkCategory.DisplayMember = "Name";
            this.cmbDrinkCategory.ValueMember = "idFoodCategory";
        }

        private void LoadData()
        {
            LoadDataAccount();
            LoadDataFood();
            LoadDataTable();
            LoadDataCategory();
        }

        private void LoadDataAccount()
        {
            var listAccount = db.Accounts.ToList();
            dgvAccount.DataSource = listAccount;
            dgvAccount.Columns["UserName"].HeaderText = "Tài khoản";
            dgvAccount.Columns["Password"].HeaderText = "Mật khẩu";
            dgvAccount.Columns["DisplayName"].HeaderText = "Tên hiển thị";
            dgvAccount.Columns["Type"].HeaderText = "Loại tài khoản";
        }
        private void LoadDataFood()
        {
            var listFood = db.Foods.Join(db.FoodCategories, f => f.idFoodCategory, fc => fc.idFoodCategory, (f, fc) => new { f, fc })
                       .Select(x => new { x.f.idFood, FoodName = x.f.name, x.f.Price, CategoryName = x.fc.Name }).ToList();
            dgvDrink.DataSource = listFood;
            dgvDrink.Columns["idFood"].HeaderText = "Mã đồ uống";
            dgvDrink.Columns["FoodName"].HeaderText = "Tên đồ uống";
            dgvDrink.Columns["Price"].HeaderText = "Giá";
            dgvDrink.Columns["CategoryName"].HeaderText = "Tên loại";

        }
        private void LoadDataTable()
        {
            var listTable = db.CFTables.Select(x => new { x.idTable, x.Name, x.Status }).ToList();
            dgvTable.DataSource = listTable;
            dgvTable.Columns["idTable"].HeaderText = "Mã bàn";
            dgvTable.Columns["Name"].HeaderText = "Tên bàn";
            dgvTable.Columns["Status"].HeaderText = "Trạng thái";

        }
        private void LoadDataCategory()
        {
        var listFoodCategory = db.FoodCategories.Select(x => new { x.idFoodCategory, x.Name }).ToList();
            dgvCategory.DataSource = listFoodCategory;
            dgvCategory.Columns["idFoodCategory"].HeaderText = "Mã loại";
            dgvCategory.Columns["Name"].HeaderText = "Tên loại";
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadListBillByDate();
        }

        private void LoadListBillByDate()
        {
            dgvBill.DataSource = db.Bills.Where(x => x.DateCheckIn >= dtpkFromDate.Value && x.DateCheckIn <= dtpkToDate.Value)
                                         .Select(x => new { x.idBill, x.DateCheckIn, x.DateCheckOut, x.Status ,x.totalPrice}).ToList();
            dgvBill.Columns["idBill"].HeaderText = "Mã hóa đơn";
            dgvBill.Columns["DateCheckIn"].HeaderText = "Ngày vào";
            dgvBill.Columns["DateCheckOut"].HeaderText = "Ngày ra";
            dgvBill.Columns["Status"].HeaderText = "Trạng thái";
            dgvBill.Columns["totalPrice"].HeaderText = "Tổng tiền";
            double totalPrice = dgvBill.Rows.Cast<DataGridViewRow>().Sum(x => double.Parse(x.Cells["totalPrice"].Value.ToString()));
            lblTotalPrice.Text = totalPrice.ToString("C", new CultureInfo("vi-VN"));
        }

        private void dgvDrink_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDrink.Rows[e.RowIndex];
                txtDrinkID.Text = selectedRow.Cells[0].Value.ToString();
                txtDrinkName.Text = selectedRow.Cells[1].Value.ToString();
                cmbDrinkCategory.Text = selectedRow.Cells[3].Value.ToString();
                nmDrinkPrice.Value = decimal.Parse(selectedRow.Cells[2].Value.ToString());
            }
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCategory.Rows[e.RowIndex];
                txtCategoryID.Text = selectedRow.Cells[0].Value.ToString();
                txtCategoryName.Text = selectedRow.Cells[1].Value.ToString();
            }
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvTable.Rows[e.RowIndex];
                txtTableID.Text = selectedRow.Cells[0].Value.ToString();
                txtTableName.Text = selectedRow.Cells[1].Value.ToString();
                cmbTableStatus.SelectedIndex = (selectedRow.Cells[2].Value as bool?) == true ? 1 : 0;
            }
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvAccount.Rows[e.RowIndex];
                txtAccountID.Text = selectedRow.Cells[0].Value.ToString();
                txtAccountName.Text = selectedRow.Cells[1].Value.ToString();
                txtAccountPassword.Text = selectedRow.Cells[2].Value.ToString();
                cmbAccountType.SelectedIndex = (selectedRow.Cells[3].Value as int?) == 0 ? 1 : 0;
            }
        }

        private void btnMenuView_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCategoryView_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTableView_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAccountView_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnMenuAdd_Click(object sender, EventArgs e)
        {
            try
            {
                List<Food> ListFood = db.Foods.ToList();
                if (txtDrinkName.Text == "" ||  cmbDrinkCategory.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin thức uống!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ListFood.Any(s => s.name == txtDrinkName.Text))
                {
                    MessageBox.Show("Nước này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var Drink = new Food
                {
                    name = txtDrinkName.Text,
                    FoodCategory = (FoodCategory)cmbDrinkCategory.SelectedItem,
                    Price = double.Parse(nmDrinkPrice.Value.ToString())
                };
                db.Foods.Add(Drink);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Thêm nước thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            try
            {
                List<FoodCategory> ListCategory = db.FoodCategories.ToList();
                if (txtCategoryID.Text == "" || txtCategoryName.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin danh mục!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ListCategory.Any(s => s.Name == txtCategoryName.Text))
                {
                    MessageBox.Show("Danh mục này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var Category = new FoodCategory
                {
                    Name = txtCategoryName.Text
                };
                db.FoodCategories.Add(Category);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Thêm danh mục thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTableAdd_Click(object sender, EventArgs e)
        {
            try
            {
                List<CFTable> ListTable = db.CFTables.ToList();
                if (txtTableName.Text == "" || cmbTableStatus.SelectedIndex == -1)

                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin bàn!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ListTable.Any(s => s.Name == txtTableName.Text))
                {
                    MessageBox.Show("Bàn này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var table = new CFTable
                {
                    Name = txtTableName.Text,
                    Status = (bool)cmbTableStatus.SelectedItem
                };
                db.CFTables.Add(table);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Thêm bàn thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAccountAdd_Click(object sender, EventArgs e)
        {
            try
            {
                List<Account> ListAccount = db.Accounts.ToList();
                if (txtAccountID.Text == "" ||  txtAccountName.Text == "" || txtAccountPassword.Text == "" ||cmbAccountType.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ListAccount.Any(s => s.UserName == txtAccountName.Text))
                {
                    MessageBox.Show("Tài khoản này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var account = new Account
                {
                    UserName = txtAccountName.Text,
                    DisplayName = txtAccountName.Text,
                    Password = txtAccountPassword.Text,
                    Type = (int)cmbAccountType.SelectedItem
                };
                db.Accounts.Add(account);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Thêm tài khoản thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMenuDelete_Click(object sender, EventArgs e)
        {
            if (txtDrinkID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;
            List<Food> ListFood = db.Foods.ToList();
            var food = ListFood.FirstOrDefault(s => s.idFood == int.Parse(txtDrinkID.Text));
            if (food != null && food.idFood == int.Parse(txtDrinkID.Text))
            {
                db.Foods.Remove(food);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Xóa nước thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Nước cần xóa không tồn tại!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            if (txtCategoryID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;
            List<FoodCategory> ListCategory = db.FoodCategories.ToList();
            var category = ListCategory.FirstOrDefault(s => s.idFoodCategory == int.Parse(txtCategoryID.Text));
            if (category != null && category.idFoodCategory == int.Parse(txtCategoryID.Text))
            {
                db.FoodCategories.Remove(category);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Xóa danh mục thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Danh mục cần xóa không tồn tại!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTableDelete_Click(object sender, EventArgs e)
        {
            if (txtTableID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bàn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;
            List<CFTable> ListTable = db.CFTables.ToList();
            var table = ListTable.FirstOrDefault(s => s.idTable == int.Parse(txtTableID.Text));
            if (table != null && table.idTable == int.Parse(txtTableID.Text))
            {
                db.CFTables.Remove(table);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Xóa bàn thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bàn cần xóa không tồn tại!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAccountDelete_Click(object sender, EventArgs e)
        {
            if (txtAccountID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bàn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;
            List<Account> ListAccount = db.Accounts.ToList();
            var account = ListAccount.FirstOrDefault(s => s.UserName == txtAccountID.Text);
            if (account != null && account.UserName == txtTableID.Text)
            {
                db.Accounts.Remove(account);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Xóa tài khoản thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tài khoản cần xóa không tồn tại!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMenuUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                List<Food> ListFood = db.Foods.ToList();
                var student = ListFood.FirstOrDefault(s => s.idFood == int.Parse(txtDrinkID.Text));
                if (student != null && student.idFood == int.Parse(txtDrinkID.Text))
                {
                    student.name = txtDrinkName.Text;
                    student.FoodCategory = (FoodCategory)cmbDrinkCategory.SelectedItem;
                    student.Price = double.Parse(nmDrinkPrice.Value.ToString());
                    db.SaveChanges();
                    LoadData(); 
                    MessageBox.Show("cập nhật nước thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nước này không tồn tại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                List<FoodCategory> ListCategory = db.FoodCategories.ToList();
                var category = ListCategory.FirstOrDefault(s => s.idFoodCategory == int.Parse(txtCategoryID.Text));
                if (category != null && category.idFoodCategory == int.Parse(txtCategoryID.Text))
                {
                    category.Name = txtCategoryName.Text;
                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("cập nhật danh mục thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Danh mục này không tồn tại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTableUpdaue_Click(object sender, EventArgs e)
        {
            try
            {
                List<CFTable> ListTable = db.CFTables.ToList();
                var table = ListTable.FirstOrDefault(s => s.idTable == int.Parse(txtTableID.Text));
                if (table != null && table.idTable == int.Parse(txtTableID.Text))
                {
                    table.Name = txtDrinkName.Text;
                    table.Status = (bool)cmbTableStatus.SelectedItem;
                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("cập nhật bàn thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bàn này không tồn tại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAccountUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                List<Account> ListAccount = db.Accounts.ToList();
                var account = ListAccount.FirstOrDefault(s => s.UserName == txtAccountID.Text);
                if (account != null && account.UserName == txtAccountID.Text)
                {
                    account.DisplayName = txtDrinkName.Text;
                    account.Password = txtAccountPassword.Text;
                    account.Type = (int)cmbAccountType.SelectedItem;
                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("cập nhật tài khoản thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tài khoản này không tồn tại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDrinkSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtDrinkSearch.Text;
            int searchId;
            if (int.TryParse(searchValue, out searchId))
            {
                List<Food> searchResult1 = db.Foods
                .Where(s => s.idFood == searchId
                           || s.name.Contains(searchValue)
                           || s.Price.ToString().Contains(searchValue)
                           )
                .ToList();
                var listFood = searchResult1.Join(db.FoodCategories, f => f.idFoodCategory, fc => fc.idFoodCategory, (f, fc) => new { f, fc })
                                       .Select(x => new { x.f.idFood, FoodName = x.f.name, x.f.Price, CategoryName = x.fc.Name }).ToList();
                dgvDrink.DataSource = listFood;
                dgvDrink.Columns["idFood"].HeaderText = "Mã đồ uống";
                dgvDrink.Columns["FoodName"].HeaderText = "Ten đồ uống";
                dgvDrink.Columns["Price"].HeaderText = "Giá";
                dgvDrink.Columns["CategoryName"].HeaderText = "Tên loại";

                return;
            }
            else
            {
                List<Food> searchResult = db.Foods
                .Where(s => s.idFood == searchId
                           || s.name.Contains(searchValue)
                           || s.Price.ToString().Contains(searchValue)
                            )
                .ToList();
                var listFood = searchResult.Join(db.FoodCategories, f => f.idFoodCategory, fc => fc.idFoodCategory, (f, fc) => new { f, fc })
                                       .Select(x => new { x.f.idFood, FoodName = x.f.name, x.f.Price, CategoryName = x.fc.Name }).ToList();
                dgvDrink.DataSource = listFood;
                dgvDrink.Columns["idFood"].HeaderText = "Mã đồ uống";
                dgvDrink.Columns["FoodName"].HeaderText = "Ten đồ uống";
                dgvDrink.Columns["Price"].HeaderText = "Giá";
                dgvDrink.Columns["CategoryName"].HeaderText = "Tên loại";
            }
        }

        private void txtCategorySearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtCategorySearch.Text;
            int searchId;
            if (int.TryParse(searchValue, out searchId))
            {
                List<FoodCategory> searchResult1 = db.FoodCategories
                .Where(s => s.idFoodCategory == searchId
                           || s.Name.Contains(searchValue)
                           )
                .ToList();
                var listFoodCategory = searchResult1.Select(x => new { x.idFoodCategory, x.Name }).ToList();
                dgvCategory.DataSource = listFoodCategory;
                dgvCategory.Columns["idFoodCategory"].HeaderText = "Mã loại";
                dgvCategory.Columns["Name"].HeaderText = "Tên loại";
                return;
            }
            else
            {
                List<FoodCategory> searchResult = db.FoodCategories
                .Where(s => s.idFoodCategory == searchId
                           || s.Name.Contains(searchValue)
                            )
                .ToList();
                var listFoodCategory = searchResult.Select(x => new { x.idFoodCategory, x.Name }).ToList();
                dgvCategory.DataSource = listFoodCategory;
                dgvCategory.Columns["idFoodCategory"].HeaderText = "Mã loại";
                dgvCategory.Columns["Name"].HeaderText = "Tên loại";
            }
        }

        private void txtTableSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtTableID.Text;
            int searchId;
            if (int.TryParse(searchValue, out searchId))
            {
                List<CFTable> searchResult1 = db.CFTables
                    .Where(s => s.idTable == searchId || s.Name.Contains(searchValue))
                    .ToList();
                dgvTable.DataSource = searchResult1;
                var listTable = searchResult1.Select(x => new { x.idTable, x.Name, x.Status }).ToList();
                dgvTable.DataSource = listTable;
                dgvTable.Columns["idTable"].HeaderText = "Mã bàn";
                dgvTable.Columns["Name"].HeaderText = "Tên bàn";
                dgvTable.Columns["Status"].HeaderText = "Trạng thái";
                return;
            }
            else
            {
                List<CFTable> searchResult = db.CFTables
                    .Where(s => s.Name.Contains(searchValue))
                    .ToList();
                dgvTable.DataSource = searchResult;
                var listTable = searchResult.Select(x => new { x.idTable, x.Name, x.Status }).ToList();
                dgvTable.DataSource = listTable;
                dgvTable.Columns["idTable"].HeaderText = "Mã bàn";
                dgvTable.Columns["Name"].HeaderText = "Tên bàn";
                dgvTable.Columns["Status"].HeaderText = "Trạng thái";
            }
        }

        private void txtAccountSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtAccountID.Text;
            List<Account> searchResult = db.Accounts
            .Where(s => s.UserName == searchValue
                        || s.DisplayName.Contains(searchValue)
                        )
            .ToList();
            dgvAccount.DataSource = searchResult;
            dgvAccount.Columns["UserName"].HeaderText = "Tài khoản";
            dgvAccount.Columns["Password"].HeaderText = "Mật khẩu";
            dgvAccount.Columns["DisplayName"].HeaderText = "Tên hiển thị";
            dgvAccount.Columns["Type"].HeaderText = "Loại tài khoản";
        }
    }
}

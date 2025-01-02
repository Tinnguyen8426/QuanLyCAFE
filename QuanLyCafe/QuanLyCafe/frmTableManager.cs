using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCafe.Model;
using QuanLyCafe.Model.ViewModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLyCafe
{
    public partial class frmTableManager : Form
    {
        CafeDBContext db;
        private List<MenuViewModel> listMenu; // <MenuViewModel>
        public frmTableManager()
        {
            db = new CafeDBContext();
            InitializeComponent();
            loadTable();
            loadCategory();
        }

        private void loadCategory()
        {
            db = new CafeDBContext();
            var listCategory = db.FoodCategories.ToList();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "idFoodCategory";
            cbCategory.SelectedIndex = -1;
        }

        private void loadTable()
        {
            flpTable.Controls.Clear();
            var listTable = db.CFTables.ToList();
            foreach(var item in listTable)
            {
                Button btn = new Button() {
                    Width = 85, 
                    Height = 85,    
                    Text = item.Name.ToString() + Environment.NewLine + (item.Status ? "Có người" : "Trống")
                };
                btn.Click += Btn_Click;
                btn.Tag = item;
                flpTable.Controls.Add(btn);
                btnColor(item.Status, btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as CFTable).idTable;
            lsvBill.Tag = (sender as Button).Tag;
            showBill(tableID);
        }

        private void showBill(int tableID)
        {
            List<MenuViewModel> listBillInfo = GetListMenuByTableID(tableID);
            //if (listBillInfo == null || !listBillInfo.Any())
            //{
            //    MessageBox.Show("Không có dữ liệu hiển thị.");
            //    return;
            //}
            lsvBill.Items.Clear();
            foreach (var item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                lsvBill.Items.Add(lsvItem);
            }
        }

        List<MenuViewModel> GetListMenuByTableID(int idTable)
        {
            var menu = db.BillInfoes
                         .Join(db.Bills, bi => bi.idBill, b => b.idBill, (bi, b) => new { bi, b })
                         .Join(db.Foods, x => x.bi.idFood, f => f.idFood, (x, f) => new { x, f })
                         .Where(x2 => x2.x.b.idTable == idTable && x2.x.b.Status == false)
                         .Select(x3 => new MenuViewModel
                         {
                             Name = x3.f.name,
                             Count = x3.x.bi.count,
                             Price = (float)x3.f.Price,
                             TotalPrice = (float)x3.f.Price * x3.x.bi.count
                         })
                         .ToList();
            float totalPrice = menu.Sum(item => item.TotalPrice);
            lblTotalPrice.Text = totalPrice.ToString("C", new CultureInfo("vi-VN"));
            return menu;
        }


        private int getUncheckBillByTableID(int ID)
        {
            var uncheckedBill = db.Bills.FirstOrDefault(x => x.idTable == ID && x.Status == false);
            if (uncheckedBill != null)
            {
                return uncheckedBill.idBill;    
            }
            return -1;
        }

        private void btnColor(bool status, Button btn)
        {
            if (status)
            {
                btn.BackColor = Color.Red;
            }
            else
            {
                btn.BackColor = Color.White;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccountInfo_Click(object sender, EventArgs e)
        {
            frmAccountInfo frm = new frmAccountInfo();
            
            frm.ShowDialog();
            
        }

        private void toolStripAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            frm.ShowDialog();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedItem == null) return;
            //Lấy giá trị idFoodCategory từ đối tượng FoodCategory được chọn trong combobox cbCategory và gán nó vào biến id.
            id = (cb.SelectedItem as FoodCategory).idFoodCategory;
            List<Food> listFood = GetAllByCategory(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
            cbFood.ValueMember = "idFood";
            cbFood.SelectedIndex = -1;
        }

        private List<Food> GetAllByCategory(int CategoryID)
        {
            db = new CafeDBContext();
            List<Food> listFood = db.Foods.Where(x => x.idFoodCategory == CategoryID).ToList();
            return listFood;
        }

        private void insertBill(int TableID)
        {
            if (!db.CFTables.Any(t => t.idTable == TableID))
            {
                throw new Exception($"TableID {TableID} ko tồn tại trong database.");
            }
            db.Bills.Add(new Bill {
                DateCheckIn = DateTime.Now,
                DateCheckOut = null,
                Status = false,
                idTable = TableID});
            db.SaveChanges();
        }

        private void insertBillInfo(int BillID, int FoodID, int Count)
        {
            var billInfo = db.BillInfoes.FirstOrDefault(bi => bi.idBill == BillID && bi.idFood == FoodID);

            if (billInfo != null)
            {
                //Cập nhật số lượng món ăn
                billInfo.count += Count;
                if (billInfo.count <= 0)
                {
                    db.BillInfoes.Remove(billInfo);
                }
            }
            else
            {
                // Thêm món ăn mới vào hóa đơn
                db.BillInfoes.Add(new BillInfo { idBill = BillID, idFood = FoodID, count = Count });
            }

            db.SaveChanges();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

                CFTable cFTable = lsvBill.Tag as CFTable;
                if (cFTable == null)
                {
                    MessageBox.Show("Vui lòng chọn món trước khi thêm vào bill", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                int billID = getUncheckBillByTableID(cFTable.idTable);
                int foodID = (cbFood.SelectedItem as Food) ?.idFood ?? -1;
                int count = (int)nmCount.Value;
                if (billID == -1)
                {
                    insertBill(cFTable.idTable);
                    insertBillInfo(getMaxBillID(), foodID, count);
                    showBill(cFTable.idTable);
                    UpdateTableStatus();
                    loadTable();
                }
                else
                {
                    insertBillInfo(billID, foodID, count);
                    showBill(cFTable.idTable);
                }
        }

        private int getMaxBillID()
        {
            try
            {
                return db.Bills.Max(x => x.idBill);

            }
            catch
            {
                return 1;
            }
        }

        private void CheckOut(int BillID)
        {
            var bill = db.Bills.FirstOrDefault(b => b.idBill == BillID);
            if (bill != null)
            {
                bill.Status = true;
                bill.DateCheckOut = DateTime.Now;
                db.SaveChanges();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CFTable table = lsvBill.Tag as CFTable;
            int idBill = getUncheckBillByTableID(table.idTable);
            if(idBill != -1)
            {
                if (MessageBox.Show("Bạn có chắc muốn thanh toán hoá đơn cho bàn " + table.Name + "không?", "Thông báo",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    CheckOut(idBill);
                    showBill(table.idTable);
                    UpdateTableStatus();
                    loadTable();
                }
            }
        }
        private void UpdateTableStatus()
        {
            var tables = db.CFTables.ToList();
            foreach (var table in tables)
            {
                var bills = db.Bills.Where(b => b.idTable == table.idTable && b.Status == false).ToList();
                if (table.Status == false && bills.Any())
                {
                    table.Status = true;
                }
                else if (table.Status == true && !bills.Any())
                {
                    table.Status = false;
                }
            }
            db.SaveChanges();
        }
    }
}

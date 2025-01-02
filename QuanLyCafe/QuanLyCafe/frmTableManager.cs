using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCafe.Model;
using QuanLyCafe.Model.ViewModel;

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
        }

        private void GetFoodByCategory(int idCategory)
        {
            db = new CafeDBContext();
            var listFood = db.Foods.Where(x => x.idFoodCategory == idCategory).ToList();
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
            cbFood.ValueMember = "idFood";
        }

        private void loadTable()
        {
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
            lsvBill.Tag = sender as CFTable;
            showBill(tableID);
        }

        private void showBill(int tableID)
        {
            List<MenuViewModel> listBillInfo = GetListMenuByTableID(getUncheckBillByTableID(tableID));
            lsvBill.Items.Clear();
            foreach(var item in listBillInfo)
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
            float totalPrice = 0;
            List<MenuViewModel> listMenu = new List<MenuViewModel>();
            var menu = db.BillInfoes.Join(db.Bills, bi => bi.idBill, b => b.idBill, (bi, b) => new { bi, b })
                                    .Join(db.Foods, x => x.bi.idFood, f => f.idFood, (x, f) => new { x, f })
                                    .Where(x2 => x2.x.b.idTable == idTable && x2.x.b.Status == false).ToList()
                                    .Select(x3 => new MenuViewModel
                                    {
                                         Name = x3.f.name,
                                         Count = x3.x.bi.count,
                                         Price = (float)x3.f.Price,
                                         TotalPrice = (float)x3.f.Price * x3.x.bi.count
                                    }).ToList();
            foreach(var item in menu)
            {
                listMenu.Add(item);
                totalPrice += item.TotalPrice;
            }
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            lblTotalPrice.Text = totalPrice.ToString("C", cultureInfo);
            return listMenu;
        }

        private int getUncheckBillByTableID(int ID)
        {
            //efaultIfEmpty trả về một chuỗi chứa một phần tử với giá trị mặc định (-1) nếu chuỗi nguồn là rỗng.
            return db.Bills.Where(x => x.idTable == ID && x.Status == false)
                           .Select(x => x.idBill).DefaultIfEmpty(-1).FirstOrDefault();
        }

        private List<BillInfo> GetListBillInfo(int idBill)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            listBillInfo = db.BillInfoes.Where(x => x.idBill == idBill).ToList();
            return listBillInfo;
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
        }

        private List<Food> GetAllByCategory(int CategoryID)
        {
            db = new CafeDBContext();
            List<Food> listFood = db.Foods.Where(x => x.idFoodCategory == CategoryID).ToList();
            return listFood;
        }

        private void insertBill(int TableID)
        {
            Bill bill = new Bill();
            bill.DateCheckIn = DateTime.Now;
            bill.DateCheckOut = null;
            bill.Status = false;
            bill.idTable = TableID;
            db.Bills.AddOrUpdate(bill);
            db.SaveChanges();
        }

        private void insertBillInfo(int BillID, int FoodID, int Count)
        {
            BillInfo billInfo = new BillInfo();
            billInfo.idBill = BillID;
            billInfo.idFood = FoodID;
            billInfo.count = Count;
            db.BillInfoes.AddOrUpdate(billInfo);
            db.SaveChanges();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CFTable cFTable = new CFTable();

            int billID = getUncheckBillByTableID(cFTable.idTable);
            int foodID = (cbFood.SelectedItem as Food).idFood;
            int count = (int)nmCount.Value;
            if (billID == -1)
            {
                //insertBill(billID);
                insertBillInfo(getMaxBillID(),foodID,count);
                //showBill(cFTable.idTable);
            }
            else
            {
                insertBillInfo(billID, foodID, count);
                //showBill(cFTable.idTable);
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
    }
}

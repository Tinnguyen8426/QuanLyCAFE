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
    public partial class frmTableManager : Form
    {
        CafeDBContext db;
        public frmTableManager()
        {
            db = new CafeDBContext();
            InitializeComponent();
            loadTable();
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
            int tableID = (sender as CFTable).idTable;
            //showBill(tableID);
        }

        private int showBillByTableID(int ID)
        {
            return db.Bills.Where(x => x.idTable == ID).Count();
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


    }
}

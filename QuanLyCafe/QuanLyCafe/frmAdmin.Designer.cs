namespace QuanLyCafe
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcpAccount = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtAccountPassword = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.btnAccountView = new System.Windows.Forms.Button();
            this.btnAccountUpdate = new System.Windows.Forms.Button();
            this.btnAccountDelete = new System.Windows.Forms.Button();
            this.btnAccountAdd = new System.Windows.Forms.Button();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.tcpTable = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbTableStatus = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.txtTableID = new System.Windows.Forms.TextBox();
            this.btnTableView = new System.Windows.Forms.Button();
            this.btnTableUpdaue = new System.Windows.Forms.Button();
            this.btnTableDelete = new System.Windows.Forms.Button();
            this.btnTableAdd = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.tcpCategory = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.txtCategorySearch = new System.Windows.Forms.TextBox();
            this.btnCategoryView = new System.Windows.Forms.Button();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.tcpFood = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmDrinkPrice = new System.Windows.Forms.NumericUpDown();
            this.cmbDrinkCategory = new System.Windows.Forms.ComboBox();
            this.txtDrinkName = new System.Windows.Forms.TextBox();
            this.txtDrinkID = new System.Windows.Forms.TextBox();
            this.txtDrinkSearch = new System.Windows.Forms.TextBox();
            this.btnMenuView = new System.Windows.Forms.Button();
            this.btnMenuUpdate = new System.Windows.Forms.Button();
            this.btnMenuDelete = new System.Windows.Forms.Button();
            this.btnMenuAdd = new System.Windows.Forms.Button();
            this.dgvDrink = new System.Windows.Forms.DataGridView();
            this.tcpBill = new System.Windows.Forms.TabPage();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tcpAccount.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.tcpTable.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.tcpCategory.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.tcpFood.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDrinkPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrink)).BeginInit();
            this.tcpBill.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.tcAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcpAccount
            // 
            this.tcpAccount.Controls.Add(this.label19);
            this.tcpAccount.Controls.Add(this.groupBox4);
            this.tcpAccount.Controls.Add(this.btnAccountView);
            this.tcpAccount.Controls.Add(this.btnAccountUpdate);
            this.tcpAccount.Controls.Add(this.btnAccountDelete);
            this.tcpAccount.Controls.Add(this.btnAccountAdd);
            this.tcpAccount.Controls.Add(this.dgvAccount);
            this.tcpAccount.Location = new System.Drawing.Point(4, 25);
            this.tcpAccount.Name = "tcpAccount";
            this.tcpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tcpAccount.Size = new System.Drawing.Size(768, 397);
            this.tcpAccount.TabIndex = 4;
            this.tcpAccount.Text = "Tài khoản";
            this.tcpAccount.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(219, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(324, 38);
            this.label19.TabIndex = 33;
            this.label19.Text = "Chỉnh sửa tài khoản";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbAccountType);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.txtAccountPassword);
            this.groupBox4.Controls.Add(this.txtAccountName);
            this.groupBox4.Controls.Add(this.txtAccountID);
            this.groupBox4.Location = new System.Drawing.Point(13, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 242);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin";
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên"});
            this.cmbAccountType.Location = new System.Drawing.Point(106, 157);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(262, 24);
            this.cmbAccountType.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 160);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 16);
            this.label20.TabIndex = 5;
            this.label20.Text = "Loại tài khoản";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(25, 117);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 16);
            this.label24.TabIndex = 5;
            this.label24.Text = "Mật khẩu";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(25, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 16);
            this.label21.TabIndex = 5;
            this.label21.Text = "Tên hiển thị";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 29);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 16);
            this.label22.TabIndex = 5;
            this.label22.Text = "Tên tài khoản";
            // 
            // txtAccountPassword
            // 
            this.txtAccountPassword.Location = new System.Drawing.Point(107, 114);
            this.txtAccountPassword.Name = "txtAccountPassword";
            this.txtAccountPassword.Size = new System.Drawing.Size(261, 22);
            this.txtAccountPassword.TabIndex = 2;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(107, 67);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(261, 22);
            this.txtAccountName.TabIndex = 2;
            // 
            // txtAccountID
            // 
            this.txtAccountID.Location = new System.Drawing.Point(107, 26);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Size = new System.Drawing.Size(261, 22);
            this.txtAccountID.TabIndex = 2;
            // 
            // btnAccountView
            // 
            this.btnAccountView.Location = new System.Drawing.Point(296, 321);
            this.btnAccountView.Name = "btnAccountView";
            this.btnAccountView.Size = new System.Drawing.Size(85, 58);
            this.btnAccountView.TabIndex = 27;
            this.btnAccountView.Text = "Xem";
            this.btnAccountView.UseVisualStyleBackColor = true;
            this.btnAccountView.Click += new System.EventHandler(this.btnAccountView_Click);
            // 
            // btnAccountUpdate
            // 
            this.btnAccountUpdate.Location = new System.Drawing.Point(205, 321);
            this.btnAccountUpdate.Name = "btnAccountUpdate";
            this.btnAccountUpdate.Size = new System.Drawing.Size(85, 58);
            this.btnAccountUpdate.TabIndex = 28;
            this.btnAccountUpdate.Text = "sửa";
            this.btnAccountUpdate.UseVisualStyleBackColor = true;
            this.btnAccountUpdate.Click += new System.EventHandler(this.btnAccountUpdate_Click);
            // 
            // btnAccountDelete
            // 
            this.btnAccountDelete.Location = new System.Drawing.Point(114, 321);
            this.btnAccountDelete.Name = "btnAccountDelete";
            this.btnAccountDelete.Size = new System.Drawing.Size(85, 58);
            this.btnAccountDelete.TabIndex = 29;
            this.btnAccountDelete.Text = "Xoá";
            this.btnAccountDelete.UseVisualStyleBackColor = true;
            this.btnAccountDelete.Click += new System.EventHandler(this.btnAccountDelete_Click);
            // 
            // btnAccountAdd
            // 
            this.btnAccountAdd.Location = new System.Drawing.Point(23, 321);
            this.btnAccountAdd.Name = "btnAccountAdd";
            this.btnAccountAdd.Size = new System.Drawing.Size(85, 58);
            this.btnAccountAdd.TabIndex = 30;
            this.btnAccountAdd.Text = "Thêm";
            this.btnAccountAdd.UseVisualStyleBackColor = true;
            this.btnAccountAdd.Click += new System.EventHandler(this.btnAccountAdd_Click);
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(397, 73);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.Size = new System.Drawing.Size(358, 310);
            this.dgvAccount.TabIndex = 25;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // tcpTable
            // 
            this.tcpTable.Controls.Add(this.label14);
            this.tcpTable.Controls.Add(this.groupBox3);
            this.tcpTable.Controls.Add(this.btnTableView);
            this.tcpTable.Controls.Add(this.btnTableUpdaue);
            this.tcpTable.Controls.Add(this.btnTableDelete);
            this.tcpTable.Controls.Add(this.btnTableAdd);
            this.tcpTable.Controls.Add(this.dgvTable);
            this.tcpTable.Location = new System.Drawing.Point(4, 25);
            this.tcpTable.Name = "tcpTable";
            this.tcpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tcpTable.Size = new System.Drawing.Size(768, 397);
            this.tcpTable.TabIndex = 3;
            this.tcpTable.Text = "Bàn uống";
            this.tcpTable.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(219, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(326, 38);
            this.label14.TabIndex = 23;
            this.label14.Text = "Chỉnh sửa bàn uống";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbTableStatus);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtTableName);
            this.groupBox3.Controls.Add(this.txtTableID);
            this.groupBox3.Location = new System.Drawing.Point(13, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 242);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // cmbTableStatus
            // 
            this.cmbTableStatus.FormattingEnabled = true;
            this.cmbTableStatus.Items.AddRange(new object[] {
            "Trống",
            "Có người"});
            this.cmbTableStatus.Location = new System.Drawing.Point(106, 126);
            this.cmbTableStatus.Name = "cmbTableStatus";
            this.cmbTableStatus.Size = new System.Drawing.Size(262, 24);
            this.cmbTableStatus.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 16);
            this.label17.TabIndex = 5;
            this.label17.Text = "Trạng thái";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 16);
            this.label15.TabIndex = 5;
            this.label15.Text = "Tên mục";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(81, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "ID";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(107, 77);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(261, 22);
            this.txtTableName.TabIndex = 2;
            // 
            // txtTableID
            // 
            this.txtTableID.Location = new System.Drawing.Point(107, 36);
            this.txtTableID.Name = "txtTableID";
            this.txtTableID.Size = new System.Drawing.Size(261, 22);
            this.txtTableID.TabIndex = 2;
            // 
            // btnTableView
            // 
            this.btnTableView.Location = new System.Drawing.Point(296, 321);
            this.btnTableView.Name = "btnTableView";
            this.btnTableView.Size = new System.Drawing.Size(85, 58);
            this.btnTableView.TabIndex = 17;
            this.btnTableView.Text = "Xem";
            this.btnTableView.UseVisualStyleBackColor = true;
            this.btnTableView.Click += new System.EventHandler(this.btnTableView_Click);
            // 
            // btnTableUpdaue
            // 
            this.btnTableUpdaue.Location = new System.Drawing.Point(205, 321);
            this.btnTableUpdaue.Name = "btnTableUpdaue";
            this.btnTableUpdaue.Size = new System.Drawing.Size(85, 58);
            this.btnTableUpdaue.TabIndex = 18;
            this.btnTableUpdaue.Text = "sửa";
            this.btnTableUpdaue.UseVisualStyleBackColor = true;
            this.btnTableUpdaue.Click += new System.EventHandler(this.btnTableUpdaue_Click);
            // 
            // btnTableDelete
            // 
            this.btnTableDelete.Location = new System.Drawing.Point(114, 321);
            this.btnTableDelete.Name = "btnTableDelete";
            this.btnTableDelete.Size = new System.Drawing.Size(85, 58);
            this.btnTableDelete.TabIndex = 19;
            this.btnTableDelete.Text = "Xoá";
            this.btnTableDelete.UseVisualStyleBackColor = true;
            this.btnTableDelete.Click += new System.EventHandler(this.btnTableDelete_Click);
            // 
            // btnTableAdd
            // 
            this.btnTableAdd.Location = new System.Drawing.Point(23, 321);
            this.btnTableAdd.Name = "btnTableAdd";
            this.btnTableAdd.Size = new System.Drawing.Size(85, 58);
            this.btnTableAdd.TabIndex = 20;
            this.btnTableAdd.Text = "Thêm";
            this.btnTableAdd.UseVisualStyleBackColor = true;
            this.btnTableAdd.Click += new System.EventHandler(this.btnTableAdd_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(397, 73);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.RowTemplate.Height = 24;
            this.dgvTable.Size = new System.Drawing.Size(358, 310);
            this.dgvTable.TabIndex = 15;
            this.dgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellClick);
            // 
            // tcpCategory
            // 
            this.tcpCategory.Controls.Add(this.label9);
            this.tcpCategory.Controls.Add(this.label8);
            this.tcpCategory.Controls.Add(this.groupBox2);
            this.tcpCategory.Controls.Add(this.txtCategorySearch);
            this.tcpCategory.Controls.Add(this.btnCategoryView);
            this.tcpCategory.Controls.Add(this.btnCategoryUpdate);
            this.tcpCategory.Controls.Add(this.btnCategoryDelete);
            this.tcpCategory.Controls.Add(this.btnCategoryAdd);
            this.tcpCategory.Controls.Add(this.dgvCategory);
            this.tcpCategory.Location = new System.Drawing.Point(4, 25);
            this.tcpCategory.Name = "tcpCategory";
            this.tcpCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tcpCategory.Size = new System.Drawing.Size(768, 397);
            this.tcpCategory.TabIndex = 2;
            this.tcpCategory.Text = "Danh mục";
            this.tcpCategory.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "ID, Tên mục";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(219, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(334, 38);
            this.label8.TabIndex = 13;
            this.label8.Text = "Chỉnh sửa danh mục";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtCategoryName);
            this.groupBox2.Controls.Add(this.txtCategoryID);
            this.groupBox2.Location = new System.Drawing.Point(13, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 197);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Tên mục";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "ID";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(107, 117);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(261, 22);
            this.txtCategoryName.TabIndex = 2;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(107, 76);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(261, 22);
            this.txtCategoryID.TabIndex = 2;
            // 
            // txtCategorySearch
            // 
            this.txtCategorySearch.Location = new System.Drawing.Point(120, 73);
            this.txtCategorySearch.Name = "txtCategorySearch";
            this.txtCategorySearch.Size = new System.Drawing.Size(261, 22);
            this.txtCategorySearch.TabIndex = 11;
            this.txtCategorySearch.TextChanged += new System.EventHandler(this.txtCategorySearch_TextChanged);
            // 
            // btnCategoryView
            // 
            this.btnCategoryView.Location = new System.Drawing.Point(296, 321);
            this.btnCategoryView.Name = "btnCategoryView";
            this.btnCategoryView.Size = new System.Drawing.Size(85, 58);
            this.btnCategoryView.TabIndex = 7;
            this.btnCategoryView.Text = "Xem";
            this.btnCategoryView.UseVisualStyleBackColor = true;
            this.btnCategoryView.Click += new System.EventHandler(this.btnCategoryView_Click);
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.Location = new System.Drawing.Point(205, 321);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(85, 58);
            this.btnCategoryUpdate.TabIndex = 8;
            this.btnCategoryUpdate.Text = "sửa";
            this.btnCategoryUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Location = new System.Drawing.Point(114, 321);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(85, 58);
            this.btnCategoryDelete.TabIndex = 9;
            this.btnCategoryDelete.Text = "Xoá";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(23, 321);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(85, 58);
            this.btnCategoryAdd.TabIndex = 10;
            this.btnCategoryAdd.Text = "Thêm";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(397, 73);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.RowTemplate.Height = 24;
            this.dgvCategory.Size = new System.Drawing.Size(358, 310);
            this.dgvCategory.TabIndex = 5;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
            // 
            // tcpFood
            // 
            this.tcpFood.Controls.Add(this.label10);
            this.tcpFood.Controls.Add(this.label3);
            this.tcpFood.Controls.Add(this.groupBox1);
            this.tcpFood.Controls.Add(this.txtDrinkSearch);
            this.tcpFood.Controls.Add(this.btnMenuView);
            this.tcpFood.Controls.Add(this.btnMenuUpdate);
            this.tcpFood.Controls.Add(this.btnMenuDelete);
            this.tcpFood.Controls.Add(this.btnMenuAdd);
            this.tcpFood.Controls.Add(this.dgvDrink);
            this.tcpFood.Location = new System.Drawing.Point(4, 25);
            this.tcpFood.Name = "tcpFood";
            this.tcpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tcpFood.Size = new System.Drawing.Size(768, 397);
            this.tcpFood.TabIndex = 1;
            this.tcpFood.Text = "Thức uống";
            this.tcpFood.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "ID, tên món, giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(226, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chỉnh sửa menu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nmDrinkPrice);
            this.groupBox1.Controls.Add(this.cmbDrinkCategory);
            this.groupBox1.Controls.Add(this.txtDrinkName);
            this.groupBox1.Controls.Add(this.txtDrinkID);
            this.groupBox1.Location = new System.Drawing.Point(11, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 197);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Danh mục";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên món";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID";
            // 
            // nmDrinkPrice
            // 
            this.nmDrinkPrice.Location = new System.Drawing.Point(101, 161);
            this.nmDrinkPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmDrinkPrice.Name = "nmDrinkPrice";
            this.nmDrinkPrice.Size = new System.Drawing.Size(260, 22);
            this.nmDrinkPrice.TabIndex = 4;
            // 
            // cmbDrinkCategory
            // 
            this.cmbDrinkCategory.FormattingEnabled = true;
            this.cmbDrinkCategory.Location = new System.Drawing.Point(101, 111);
            this.cmbDrinkCategory.Name = "cmbDrinkCategory";
            this.cmbDrinkCategory.Size = new System.Drawing.Size(260, 24);
            this.cmbDrinkCategory.TabIndex = 3;
            // 
            // txtDrinkName
            // 
            this.txtDrinkName.Location = new System.Drawing.Point(101, 64);
            this.txtDrinkName.Name = "txtDrinkName";
            this.txtDrinkName.Size = new System.Drawing.Size(261, 22);
            this.txtDrinkName.TabIndex = 2;
            // 
            // txtDrinkID
            // 
            this.txtDrinkID.Location = new System.Drawing.Point(101, 23);
            this.txtDrinkID.Name = "txtDrinkID";
            this.txtDrinkID.Size = new System.Drawing.Size(261, 22);
            this.txtDrinkID.TabIndex = 2;
            // 
            // txtDrinkSearch
            // 
            this.txtDrinkSearch.Location = new System.Drawing.Point(112, 71);
            this.txtDrinkSearch.Name = "txtDrinkSearch";
            this.txtDrinkSearch.Size = new System.Drawing.Size(260, 22);
            this.txtDrinkSearch.TabIndex = 2;
            this.txtDrinkSearch.TextChanged += new System.EventHandler(this.txtDrinkSearch_TextChanged);
            // 
            // btnMenuView
            // 
            this.btnMenuView.Location = new System.Drawing.Point(294, 319);
            this.btnMenuView.Name = "btnMenuView";
            this.btnMenuView.Size = new System.Drawing.Size(85, 58);
            this.btnMenuView.TabIndex = 1;
            this.btnMenuView.Text = "Xem";
            this.btnMenuView.UseVisualStyleBackColor = true;
            this.btnMenuView.Click += new System.EventHandler(this.btnMenuView_Click);
            // 
            // btnMenuUpdate
            // 
            this.btnMenuUpdate.Location = new System.Drawing.Point(203, 319);
            this.btnMenuUpdate.Name = "btnMenuUpdate";
            this.btnMenuUpdate.Size = new System.Drawing.Size(85, 58);
            this.btnMenuUpdate.TabIndex = 1;
            this.btnMenuUpdate.Text = "sửa";
            this.btnMenuUpdate.UseVisualStyleBackColor = true;
            this.btnMenuUpdate.Click += new System.EventHandler(this.btnMenuUpdate_Click);
            // 
            // btnMenuDelete
            // 
            this.btnMenuDelete.Location = new System.Drawing.Point(112, 319);
            this.btnMenuDelete.Name = "btnMenuDelete";
            this.btnMenuDelete.Size = new System.Drawing.Size(85, 58);
            this.btnMenuDelete.TabIndex = 1;
            this.btnMenuDelete.Text = "Xoá";
            this.btnMenuDelete.UseVisualStyleBackColor = true;
            this.btnMenuDelete.Click += new System.EventHandler(this.btnMenuDelete_Click);
            // 
            // btnMenuAdd
            // 
            this.btnMenuAdd.Location = new System.Drawing.Point(21, 319);
            this.btnMenuAdd.Name = "btnMenuAdd";
            this.btnMenuAdd.Size = new System.Drawing.Size(85, 58);
            this.btnMenuAdd.TabIndex = 1;
            this.btnMenuAdd.Text = "Thêm";
            this.btnMenuAdd.UseVisualStyleBackColor = true;
            this.btnMenuAdd.Click += new System.EventHandler(this.btnMenuAdd_Click);
            // 
            // dgvDrink
            // 
            this.dgvDrink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrink.Location = new System.Drawing.Point(395, 71);
            this.dgvDrink.Name = "dgvDrink";
            this.dgvDrink.RowHeadersWidth = 51;
            this.dgvDrink.RowTemplate.Height = 24;
            this.dgvDrink.Size = new System.Drawing.Size(358, 310);
            this.dgvDrink.TabIndex = 0;
            this.dgvDrink.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrink_CellClick);
            // 
            // tcpBill
            // 
            this.tcpBill.Controls.Add(this.lblTotalPrice);
            this.tcpBill.Controls.Add(this.label23);
            this.tcpBill.Controls.Add(this.panel2);
            this.tcpBill.Controls.Add(this.panel1);
            this.tcpBill.Location = new System.Drawing.Point(4, 25);
            this.tcpBill.Name = "tcpBill";
            this.tcpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tcpBill.Size = new System.Drawing.Size(768, 397);
            this.tcpBill.TabIndex = 0;
            this.tcpBill.Text = "Doanh thu";
            this.tcpBill.UseVisualStyleBackColor = true;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(571, 361);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(14, 16);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(461, 361);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(103, 16);
            this.label23.TabIndex = 3;
            this.label23.Text = "Tổng doanh thu:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBill);
            this.panel2.Location = new System.Drawing.Point(7, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 310);
            this.panel2.TabIndex = 2;
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(3, 3);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.Size = new System.Drawing.Size(748, 302);
            this.dgvBill.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnList);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpkToDate);
            this.panel1.Controls.Add(this.dtpkFromDate);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 30);
            this.panel1.TabIndex = 1;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(607, 3);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(115, 23);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Thống kê";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "~";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày";
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Location = new System.Drawing.Point(357, 4);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(200, 22);
            this.dtpkToDate.TabIndex = 0;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Location = new System.Drawing.Point(129, 3);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(200, 22);
            this.dtpkFromDate.TabIndex = 0;
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tcpBill);
            this.tcAdmin.Controls.Add(this.tcpFood);
            this.tcAdmin.Controls.Add(this.tcpCategory);
            this.tcAdmin.Controls.Add(this.tcpTable);
            this.tcAdmin.Controls.Add(this.tcpAccount);
            this.tcAdmin.Location = new System.Drawing.Point(12, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(776, 426);
            this.tcAdmin.TabIndex = 0;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcAdmin);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.tcpAccount.ResumeLayout(false);
            this.tcpAccount.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.tcpTable.ResumeLayout(false);
            this.tcpTable.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.tcpCategory.ResumeLayout(false);
            this.tcpCategory.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.tcpFood.ResumeLayout(false);
            this.tcpFood.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDrinkPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrink)).EndInit();
            this.tcpBill.ResumeLayout(false);
            this.tcpBill.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tcAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tcpAccount;
        private System.Windows.Forms.TabPage tcpTable;
        private System.Windows.Forms.TabPage tcpCategory;
        private System.Windows.Forms.TabPage tcpFood;
        private System.Windows.Forms.TabPage tcpBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmDrinkPrice;
        private System.Windows.Forms.ComboBox cmbDrinkCategory;
        private System.Windows.Forms.TextBox txtDrinkName;
        private System.Windows.Forms.TextBox txtDrinkID;
        private System.Windows.Forms.TextBox txtDrinkSearch;
        private System.Windows.Forms.Button btnMenuView;
        private System.Windows.Forms.Button btnMenuUpdate;
        private System.Windows.Forms.Button btnMenuDelete;
        private System.Windows.Forms.Button btnMenuAdd;
        private System.Windows.Forms.DataGridView dgvDrink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.TextBox txtCategorySearch;
        private System.Windows.Forms.Button btnCategoryView;
        private System.Windows.Forms.Button btnCategoryUpdate;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbTableStatus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.TextBox txtTableID;
        private System.Windows.Forms.Button btnTableView;
        private System.Windows.Forms.Button btnTableUpdaue;
        private System.Windows.Forms.Button btnTableDelete;
        private System.Windows.Forms.Button btnTableAdd;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.Button btnAccountView;
        private System.Windows.Forms.Button btnAccountUpdate;
        private System.Windows.Forms.Button btnAccountDelete;
        private System.Windows.Forms.Button btnAccountAdd;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtAccountPassword;
    }
}
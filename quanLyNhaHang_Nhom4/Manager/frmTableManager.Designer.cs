namespace quanLyNhaHang_Nhom4.Manager
{
    partial class frmTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableManager));
            this.pnlListTable = new System.Windows.Forms.Panel();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.pnlTableListName = new System.Windows.Forms.Panel();
            this.lbTableFoodList = new System.Windows.Forms.Label();
            this.pnlHoaDon = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.nmGiamGia = new System.Windows.Forms.NumericUpDown();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.pnlBillName = new System.Windows.Forms.Panel();
            this.lblBill = new System.Windows.Forms.Label();
            this.pnlTableManager = new System.Windows.Forms.Panel();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.nmCountFood = new System.Windows.Forms.NumericUpDown();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.pbFood = new System.Windows.Forms.PictureBox();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOrder = new System.Windows.Forms.Label();
            this.pnlListTable.SuspendLayout();
            this.flpTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.pnlTableListName.SuspendLayout();
            this.pnlHoaDon.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).BeginInit();
            this.pnlBillName.SuspendLayout();
            this.pnlTableManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlListTable
            // 
            this.pnlListTable.Controls.Add(this.flpTable);
            this.pnlListTable.Controls.Add(this.pnlTableListName);
            this.pnlListTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlListTable.Location = new System.Drawing.Point(0, 0);
            this.pnlListTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlListTable.Name = "pnlListTable";
            this.pnlListTable.Size = new System.Drawing.Size(611, 946);
            this.pnlListTable.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.Controls.Add(this.iconPictureBox1);
            this.flpTable.Controls.Add(this.iconPictureBox2);
            this.flpTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTable.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.flpTable.Location = new System.Drawing.Point(0, 100);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(611, 846);
            this.flpTable.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox1.BackgroundImage")));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 203;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(203, 205);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox2.BackgroundImage")));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 205;
            this.iconPictureBox2.Location = new System.Drawing.Point(212, 3);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(208, 205);
            this.iconPictureBox2.TabIndex = 0;
            this.iconPictureBox2.TabStop = false;
            // 
            // pnlTableListName
            // 
            this.pnlTableListName.BackColor = System.Drawing.Color.DimGray;
            this.pnlTableListName.Controls.Add(this.lbTableFoodList);
            this.pnlTableListName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTableListName.Location = new System.Drawing.Point(0, 0);
            this.pnlTableListName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTableListName.Name = "pnlTableListName";
            this.pnlTableListName.Size = new System.Drawing.Size(611, 100);
            this.pnlTableListName.TabIndex = 0;
            // 
            // lbTableFoodList
            // 
            this.lbTableFoodList.AutoSize = true;
            this.lbTableFoodList.BackColor = System.Drawing.Color.DimGray;
            this.lbTableFoodList.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold);
            this.lbTableFoodList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTableFoodList.Location = new System.Drawing.Point(51, 30);
            this.lbTableFoodList.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTableFoodList.Name = "lbTableFoodList";
            this.lbTableFoodList.Size = new System.Drawing.Size(426, 52);
            this.lbTableFoodList.TabIndex = 3;
            this.lbTableFoodList.Text = "DANH SÁCH BÀN ĂN";
            this.lbTableFoodList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHoaDon
            // 
            this.pnlHoaDon.Controls.Add(this.lsvBill);
            this.pnlHoaDon.Controls.Add(this.panel2);
            this.pnlHoaDon.Controls.Add(this.pnlBillName);
            this.pnlHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHoaDon.Location = new System.Drawing.Point(611, 0);
            this.pnlHoaDon.Name = "pnlHoaDon";
            this.pnlHoaDon.Size = new System.Drawing.Size(521, 946);
            this.pnlHoaDon.TabIndex = 1;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Cursor = System.Windows.Forms.Cursors.Default;
            this.lsvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvBill.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.LabelEdit = true;
            this.lsvBill.Location = new System.Drawing.Point(0, 100);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(521, 717);
            this.lsvBill.TabIndex = 3;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 110;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnPayment);
            this.panel2.Controls.Add(this.nmGiamGia);
            this.panel2.Controls.Add(this.txtTotalPrice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 817);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 129);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(235, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giảm giá";
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPayment.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Pencil_icon;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(324, 37);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(191, 54);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "Thanh Toán";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // nmGiamGia
            // 
            this.nmGiamGia.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.nmGiamGia.Location = new System.Drawing.Point(243, 50);
            this.nmGiamGia.Name = "nmGiamGia";
            this.nmGiamGia.Size = new System.Drawing.Size(63, 41);
            this.nmGiamGia.TabIndex = 4;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalPrice.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtTotalPrice.Location = new System.Drawing.Point(6, 39);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(211, 54);
            this.txtTotalPrice.TabIndex = 0;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlBillName
            // 
            this.pnlBillName.BackColor = System.Drawing.Color.DimGray;
            this.pnlBillName.Controls.Add(this.lblBill);
            this.pnlBillName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBillName.Location = new System.Drawing.Point(0, 0);
            this.pnlBillName.Name = "pnlBillName";
            this.pnlBillName.Size = new System.Drawing.Size(521, 100);
            this.pnlBillName.TabIndex = 0;
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblBill.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBill.Location = new System.Drawing.Point(152, 30);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(220, 52);
            this.lblBill.TabIndex = 0;
            this.lblBill.Text = "HÓA ĐƠN";
            this.lblBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTableManager
            // 
            this.pnlTableManager.Controls.Add(this.btnAddFood);
            this.pnlTableManager.Controls.Add(this.nmCountFood);
            this.pnlTableManager.Controls.Add(this.lblNumber);
            this.pnlTableManager.Controls.Add(this.lblFoodPrice);
            this.pnlTableManager.Controls.Add(this.pbFood);
            this.pnlTableManager.Controls.Add(this.cbFood);
            this.pnlTableManager.Controls.Add(this.cbCategory);
            this.pnlTableManager.Controls.Add(this.panel1);
            this.pnlTableManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableManager.Location = new System.Drawing.Point(1132, 0);
            this.pnlTableManager.Name = "pnlTableManager";
            this.pnlTableManager.Size = new System.Drawing.Size(396, 946);
            this.pnlTableManager.TabIndex = 2;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Actions_list_add_icon;
            this.btnAddFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFood.Location = new System.Drawing.Point(89, 817);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(234, 71);
            this.btnAddFood.TabIndex = 12;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // nmCountFood
            // 
            this.nmCountFood.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCountFood.Location = new System.Drawing.Point(221, 746);
            this.nmCountFood.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmCountFood.Name = "nmCountFood";
            this.nmCountFood.Size = new System.Drawing.Size(73, 41);
            this.nmCountFood.TabIndex = 11;
            this.nmCountFood.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(34, 753);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(143, 34);
            this.lblNumber.TabIndex = 10;
            this.lblNumber.Text = "Số lượng:";
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodPrice.Location = new System.Drawing.Point(22, 693);
            this.lblFoodPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(362, 33);
            this.lblFoodPrice.TabIndex = 9;
            this.lblFoodPrice.Text = "0 đ";
            this.lblFoodPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbFood
            // 
            this.pbFood.Location = new System.Drawing.Point(19, 356);
            this.pbFood.Name = "pbFood";
            this.pbFood.Size = new System.Drawing.Size(365, 313);
            this.pbFood.TabIndex = 2;
            this.pbFood.TabStop = false;
            // 
            // cbFood
            // 
            this.cbFood.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(52, 287);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(300, 36);
            this.cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(52, 175);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(300, 36);
            this.cbCategory.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.lblOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblOrder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOrder.Location = new System.Drawing.Point(119, 30);
            this.lblOrder.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(204, 52);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = "GỌI MÓN";
            // 
            // frmTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1528, 946);
            this.Controls.Add(this.pnlTableManager);
            this.Controls.Add(this.pnlHoaDon);
            this.Controls.Add(this.pnlListTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTableManager";
            this.pnlListTable.ResumeLayout(false);
            this.flpTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.pnlTableListName.ResumeLayout(false);
            this.pnlTableListName.PerformLayout();
            this.pnlHoaDon.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).EndInit();
            this.pnlBillName.ResumeLayout(false);
            this.pnlBillName.PerformLayout();
            this.pnlTableManager.ResumeLayout(false);
            this.pnlTableManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlListTable;
        private System.Windows.Forms.Panel pnlHoaDon;
        private System.Windows.Forms.Panel pnlTableManager;
        private System.Windows.Forms.Panel pnlTableListName;
        private System.Windows.Forms.Panel pnlBillName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTableFoodList;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.NumericUpDown nmGiamGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.PictureBox pbFood;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.NumericUpDown nmCountFood;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}
namespace quanLyNhaHang_Nhom4.Admin
{
    partial class frmAdminRevenue
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
            this.pnTotalRevenue = new System.Windows.Forms.Panel();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.dgvViewRevenue = new System.Windows.Forms.DataGridView();
            this.dgv_maHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_giamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ngayVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ngayRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_nvThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTopFoodChart = new System.Windows.Forms.Label();
            this.lblFoodRevenue = new System.Windows.Forms.Label();
            this.dgvFoodRevenue = new System.Windows.Forms.DataGridView();
            this.dgv_tenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_doanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbt_year = new System.Windows.Forms.RadioButton();
            this.rbt_month = new System.Windows.Forms.RadioButton();
            this.rbt_today = new System.Windows.Forms.RadioButton();
            this.lbl_thongKeHoaDon = new System.Windows.Forms.Label();
            this.rbt_seeAll = new System.Windows.Forms.RadioButton();
            this.rbt_seeOnDay = new System.Windows.Forms.RadioButton();
            this.cmb_tu = new System.Windows.Forms.ComboBox();
            this.cmb_den = new System.Windows.Forms.ComboBox();
            this.lbl_tu = new System.Windows.Forms.Label();
            this.lbl_den = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.pnTotalRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodRevenue)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTotalRevenue
            // 
            this.pnTotalRevenue.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTotalRevenue.Controls.Add(this.lblTotalRevenue);
            this.pnTotalRevenue.Location = new System.Drawing.Point(0, 1);
            this.pnTotalRevenue.Name = "pnTotalRevenue";
            this.pnTotalRevenue.Size = new System.Drawing.Size(1058, 100);
            this.pnTotalRevenue.TabIndex = 0;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(27, 17);
            this.lblTotalRevenue.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(111, 23);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "Doanh thu:";
            // 
            // dgvViewRevenue
            // 
            this.dgvViewRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewRevenue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_maHoaDon,
            this.dgv_tongTien,
            this.dgv_giamGia,
            this.dgv_ngayVao,
            this.dgv_ngayRa,
            this.dgv_nvThanhToan});
            this.dgvViewRevenue.Location = new System.Drawing.Point(0, 107);
            this.dgvViewRevenue.Name = "dgvViewRevenue";
            this.dgvViewRevenue.RowHeadersWidth = 51;
            this.dgvViewRevenue.RowTemplate.Height = 24;
            this.dgvViewRevenue.Size = new System.Drawing.Size(1058, 340);
            this.dgvViewRevenue.TabIndex = 1;
            // 
            // dgv_maHoaDon
            // 
            this.dgv_maHoaDon.HeaderText = "Mã Hóa Đơn";
            this.dgv_maHoaDon.MinimumWidth = 6;
            this.dgv_maHoaDon.Name = "dgv_maHoaDon";
            this.dgv_maHoaDon.Width = 150;
            // 
            // dgv_tongTien
            // 
            this.dgv_tongTien.HeaderText = "Tổng Tiền";
            this.dgv_tongTien.MinimumWidth = 6;
            this.dgv_tongTien.Name = "dgv_tongTien";
            this.dgv_tongTien.Width = 175;
            // 
            // dgv_giamGia
            // 
            this.dgv_giamGia.HeaderText = "Giảm Giá";
            this.dgv_giamGia.MinimumWidth = 6;
            this.dgv_giamGia.Name = "dgv_giamGia";
            this.dgv_giamGia.Width = 150;
            // 
            // dgv_ngayVao
            // 
            this.dgv_ngayVao.HeaderText = "Ngày Vào";
            this.dgv_ngayVao.MinimumWidth = 6;
            this.dgv_ngayVao.Name = "dgv_ngayVao";
            this.dgv_ngayVao.Width = 175;
            // 
            // dgv_ngayRa
            // 
            this.dgv_ngayRa.HeaderText = "Ngày Ra";
            this.dgv_ngayRa.MinimumWidth = 6;
            this.dgv_ngayRa.Name = "dgv_ngayRa";
            this.dgv_ngayRa.Width = 175;
            // 
            // dgv_nvThanhToan
            // 
            this.dgv_nvThanhToan.HeaderText = "NV Thanh Toán";
            this.dgv_nvThanhToan.MinimumWidth = 6;
            this.dgv_nvThanhToan.Name = "dgv_nvThanhToan";
            this.dgv_nvThanhToan.Width = 175;
            // 
            // lblTopFoodChart
            // 
            this.lblTopFoodChart.AutoSize = true;
            this.lblTopFoodChart.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTopFoodChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.lblTopFoodChart.Location = new System.Drawing.Point(17, 450);
            this.lblTopFoodChart.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTopFoodChart.Name = "lblTopFoodChart";
            this.lblTopFoodChart.Size = new System.Drawing.Size(498, 40);
            this.lblTopFoodChart.TabIndex = 24;
            this.lblTopFoodChart.Text = "Biểu đồ món ăn bán nhiều nhất";
            // 
            // lblFoodRevenue
            // 
            this.lblFoodRevenue.AutoSize = true;
            this.lblFoodRevenue.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFoodRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.lblFoodRevenue.Location = new System.Drawing.Point(614, 450);
            this.lblFoodRevenue.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFoodRevenue.Name = "lblFoodRevenue";
            this.lblFoodRevenue.Size = new System.Drawing.Size(301, 40);
            this.lblFoodRevenue.TabIndex = 25;
            this.lblFoodRevenue.Text = "Doanh thu món ăn";
            // 
            // dgvFoodRevenue
            // 
            this.dgvFoodRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodRevenue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_tenMon,
            this.dgv_soLuong,
            this.dgv_gia,
            this.dgv_doanhThu});
            this.dgvFoodRevenue.Location = new System.Drawing.Point(508, 513);
            this.dgvFoodRevenue.Name = "dgvFoodRevenue";
            this.dgvFoodRevenue.RowHeadersWidth = 51;
            this.dgvFoodRevenue.RowTemplate.Height = 24;
            this.dgvFoodRevenue.Size = new System.Drawing.Size(556, 363);
            this.dgvFoodRevenue.TabIndex = 26;
            // 
            // dgv_tenMon
            // 
            this.dgv_tenMon.HeaderText = "Tên Món";
            this.dgv_tenMon.MinimumWidth = 6;
            this.dgv_tenMon.Name = "dgv_tenMon";
            this.dgv_tenMon.Width = 125;
            // 
            // dgv_soLuong
            // 
            this.dgv_soLuong.HeaderText = "Số Lượng";
            this.dgv_soLuong.MinimumWidth = 6;
            this.dgv_soLuong.Name = "dgv_soLuong";
            this.dgv_soLuong.Width = 125;
            // 
            // dgv_gia
            // 
            this.dgv_gia.HeaderText = "Giá";
            this.dgv_gia.MinimumWidth = 6;
            this.dgv_gia.Name = "dgv_gia";
            this.dgv_gia.Width = 125;
            // 
            // dgv_doanhThu
            // 
            this.dgv_doanhThu.HeaderText = "Doanh Thu";
            this.dgv_doanhThu.MinimumWidth = 6;
            this.dgv_doanhThu.Name = "dgv_doanhThu";
            this.dgv_doanhThu.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1064, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 878);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(80, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 40);
            this.label1.TabIndex = 28;
            this.label1.Text = "Thống Kê Hóa Đơn";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(33, 132);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 29;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(33, 197);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 20);
            this.radioButton2.TabIndex = 30;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(33, 253);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(103, 20);
            this.radioButton3.TabIndex = 31;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton5);
            this.panel2.Controls.Add(this.radioButton6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 878);
            this.panel2.TabIndex = 32;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(33, 253);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(103, 20);
            this.radioButton4.TabIndex = 31;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(33, 197);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(103, 20);
            this.radioButton5.TabIndex = 30;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(33, 132);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(103, 20);
            this.radioButton6.TabIndex = 29;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(80, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 40);
            this.label2.TabIndex = 28;
            this.label2.Text = "Thống Kê Hóa Đơn";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.btn_print);
            this.panel3.Controls.Add(this.lbl_den);
            this.panel3.Controls.Add(this.lbl_tu);
            this.panel3.Controls.Add(this.cmb_den);
            this.panel3.Controls.Add(this.cmb_tu);
            this.panel3.Controls.Add(this.rbt_seeOnDay);
            this.panel3.Controls.Add(this.rbt_seeAll);
            this.panel3.Controls.Add(this.rbt_year);
            this.panel3.Controls.Add(this.rbt_month);
            this.panel3.Controls.Add(this.rbt_today);
            this.panel3.Controls.Add(this.lbl_thongKeHoaDon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 878);
            this.panel3.TabIndex = 32;
            // 
            // rbt_year
            // 
            this.rbt_year.AutoSize = true;
            this.rbt_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbt_year.ForeColor = System.Drawing.SystemColors.Control;
            this.rbt_year.Location = new System.Drawing.Point(33, 279);
            this.rbt_year.Name = "rbt_year";
            this.rbt_year.Size = new System.Drawing.Size(97, 36);
            this.rbt_year.TabIndex = 31;
            this.rbt_year.TabStop = true;
            this.rbt_year.Text = "Năm";
            this.rbt_year.UseVisualStyleBackColor = true;
            // 
            // rbt_month
            // 
            this.rbt_month.AutoSize = true;
            this.rbt_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbt_month.ForeColor = System.Drawing.SystemColors.Control;
            this.rbt_month.Location = new System.Drawing.Point(33, 211);
            this.rbt_month.Name = "rbt_month";
            this.rbt_month.Size = new System.Drawing.Size(121, 36);
            this.rbt_month.TabIndex = 30;
            this.rbt_month.TabStop = true;
            this.rbt_month.Text = "Tháng";
            this.rbt_month.UseVisualStyleBackColor = true;
            // 
            // rbt_today
            // 
            this.rbt_today.AutoSize = true;
            this.rbt_today.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbt_today.ForeColor = System.Drawing.SystemColors.Control;
            this.rbt_today.Location = new System.Drawing.Point(33, 132);
            this.rbt_today.Name = "rbt_today";
            this.rbt_today.Size = new System.Drawing.Size(158, 36);
            this.rbt_today.TabIndex = 29;
            this.rbt_today.TabStop = true;
            this.rbt_today.Text = "Hôm Nay";
            this.rbt_today.UseVisualStyleBackColor = true;
            // 
            // lbl_thongKeHoaDon
            // 
            this.lbl_thongKeHoaDon.AutoSize = true;
            this.lbl_thongKeHoaDon.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_thongKeHoaDon.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_thongKeHoaDon.Location = new System.Drawing.Point(80, 32);
            this.lbl_thongKeHoaDon.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_thongKeHoaDon.Name = "lbl_thongKeHoaDon";
            this.lbl_thongKeHoaDon.Size = new System.Drawing.Size(308, 40);
            this.lbl_thongKeHoaDon.TabIndex = 28;
            this.lbl_thongKeHoaDon.Text = "Thống Kê Hóa Đơn";
            // 
            // rbt_seeAll
            // 
            this.rbt_seeAll.AutoSize = true;
            this.rbt_seeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbt_seeAll.ForeColor = System.Drawing.SystemColors.Control;
            this.rbt_seeAll.Location = new System.Drawing.Point(33, 347);
            this.rbt_seeAll.Name = "rbt_seeAll";
            this.rbt_seeAll.Size = new System.Drawing.Size(194, 36);
            this.rbt_seeAll.TabIndex = 32;
            this.rbt_seeAll.TabStop = true;
            this.rbt_seeAll.Text = "Xem Tất Cả";
            this.rbt_seeAll.UseVisualStyleBackColor = true;
            // 
            // rbt_seeOnDay
            // 
            this.rbt_seeOnDay.AutoSize = true;
            this.rbt_seeOnDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbt_seeOnDay.ForeColor = System.Drawing.SystemColors.Control;
            this.rbt_seeOnDay.Location = new System.Drawing.Point(33, 421);
            this.rbt_seeOnDay.Name = "rbt_seeOnDay";
            this.rbt_seeOnDay.Size = new System.Drawing.Size(251, 36);
            this.rbt_seeOnDay.TabIndex = 33;
            this.rbt_seeOnDay.TabStop = true;
            this.rbt_seeOnDay.Text = "Xem Theo Ngày";
            this.rbt_seeOnDay.UseVisualStyleBackColor = true;
            // 
            // cmb_tu
            // 
            this.cmb_tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmb_tu.FormattingEnabled = true;
            this.cmb_tu.Location = new System.Drawing.Point(169, 502);
            this.cmb_tu.Name = "cmb_tu";
            this.cmb_tu.Size = new System.Drawing.Size(219, 37);
            this.cmb_tu.TabIndex = 34;
            // 
            // cmb_den
            // 
            this.cmb_den.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmb_den.FormattingEnabled = true;
            this.cmb_den.Location = new System.Drawing.Point(169, 587);
            this.cmb_den.Name = "cmb_den";
            this.cmb_den.Size = new System.Drawing.Size(219, 37);
            this.cmb_den.TabIndex = 35;
            // 
            // lbl_tu
            // 
            this.lbl_tu.AutoSize = true;
            this.lbl_tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_tu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tu.Location = new System.Drawing.Point(58, 510);
            this.lbl_tu.Name = "lbl_tu";
            this.lbl_tu.Size = new System.Drawing.Size(54, 29);
            this.lbl_tu.TabIndex = 36;
            this.lbl_tu.Text = "Từ :";
            // 
            // lbl_den
            // 
            this.lbl_den.AutoSize = true;
            this.lbl_den.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_den.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_den.Location = new System.Drawing.Point(57, 590);
            this.lbl_den.Name = "lbl_den";
            this.lbl_den.Size = new System.Drawing.Size(69, 29);
            this.lbl_den.TabIndex = 37;
            this.lbl_den.Text = "Đến :";
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_print.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.printer__1_;
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.Location = new System.Drawing.Point(146, 715);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(200, 56);
            this.btn_print.TabIndex = 38;
            this.btn_print.Text = "Xuất Phiếu";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // frmAdminRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 878);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvFoodRevenue);
            this.Controls.Add(this.lblFoodRevenue);
            this.Controls.Add(this.lblTopFoodChart);
            this.Controls.Add(this.dgvViewRevenue);
            this.Controls.Add(this.pnTotalRevenue);
            this.Name = "frmAdminRevenue";
            this.Text = "frmAdmỉnevenue";
            this.pnTotalRevenue.ResumeLayout(false);
            this.pnTotalRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodRevenue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTotalRevenue;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.DataGridView dgvViewRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_maHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_tongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_giamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_ngayVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_ngayRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_nvThanhToan;
        private System.Windows.Forms.Label lblTopFoodChart;
        private System.Windows.Forms.Label lblFoodRevenue;
        private System.Windows.Forms.DataGridView dgvFoodRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_tenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_doanhThu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbt_seeOnDay;
        private System.Windows.Forms.RadioButton rbt_seeAll;
        private System.Windows.Forms.RadioButton rbt_year;
        private System.Windows.Forms.RadioButton rbt_month;
        private System.Windows.Forms.RadioButton rbt_today;
        private System.Windows.Forms.Label lbl_thongKeHoaDon;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label lbl_den;
        private System.Windows.Forms.Label lbl_tu;
        private System.Windows.Forms.ComboBox cmb_den;
        private System.Windows.Forms.ComboBox cmb_tu;
    }
}
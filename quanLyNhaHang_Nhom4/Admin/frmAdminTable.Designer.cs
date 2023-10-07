namespace quanLyNhaHang_Nhom4.Manager
{
    partial class frmAdminTable
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolstripTim = new System.Windows.Forms.ToolStripLabel();
            this.dgvBanAn = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lblThongtin = new System.Windows.Forms.Label();
            this.lblMaban = new System.Windows.Forms.Label();
            this.lblTenban = new System.Windows.Forms.Label();
            this.lblTrangthai = new System.Windows.Forms.Label();
            this.txtMaban = new System.Windows.Forms.TextBox();
            this.txtTenban = new System.Windows.Forms.TextBox();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTongdanhmuc = new System.Windows.Forms.Label();
            this.lblTongDM = new System.Windows.Forms.Label();
            this.dgv_maBanAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_tenBanAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_FindNameTable = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAn)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolstripTim});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(189, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Tatice_Cristal_Intense_Loupe_256;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolstripTim
            // 
            this.toolstripTim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolstripTim.Name = "toolstripTim";
            this.toolstripTim.Size = new System.Drawing.Size(145, 24);
            this.toolstripTim.Text = "Tìm kiếm bàn ăn";
            this.toolstripTim.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // dgvBanAn
            // 
            this.dgvBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_maBanAn,
            this.dgv_tenBanAn,
            this.dgv_trangThai});
            this.dgvBanAn.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBanAn.Location = new System.Drawing.Point(0, 122);
            this.dgvBanAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBanAn.Name = "dgvBanAn";
            this.dgvBanAn.RowHeadersWidth = 51;
            this.dgvBanAn.RowTemplate.Height = 24;
            this.dgvBanAn.Size = new System.Drawing.Size(984, 545);
            this.dgvBanAn.TabIndex = 4;
            this.dgvBanAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanAn_CellClick);
            this.dgvBanAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.btn_Show);
            this.panel3.Controls.Add(this.btn_Delete);
            this.panel3.Controls.Add(this.btn_Change);
            this.panel3.Controls.Add(this.btn_Add);
            this.panel3.Location = new System.Drawing.Point(0, 746);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 145);
            this.panel3.TabIndex = 12;
            // 
            // btn_Show
            // 
            this.btn_Show.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.bx_show_icon;
            this.btn_Show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Show.Location = new System.Drawing.Point(756, 37);
            this.btn_Show.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(169, 72);
            this.btn_Show.TabIndex = 4;
            this.btn_Show.Text = "Hiển thị";
            this.btn_Show.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Show.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Close_2_icon;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(554, 37);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(174, 72);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Pencil_icon;
            this.btn_Change.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Change.Location = new System.Drawing.Point(344, 37);
            this.btn_Change.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(174, 72);
            this.btn_Change.TabIndex = 1;
            this.btn_Change.Text = "Sửa";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Actions_list_add_icon;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(133, 37);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(174, 72);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Font = new System.Drawing.Font("Cambria", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtin.ForeColor = System.Drawing.Color.White;
            this.lblThongtin.Location = new System.Drawing.Point(83, 215);
            this.lblThongtin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(207, 30);
            this.lblThongtin.TabIndex = 0;
            this.lblThongtin.Text = "Thông tin bàn ăn";
            this.lblThongtin.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblMaban
            // 
            this.lblMaban.AutoSize = true;
            this.lblMaban.BackColor = System.Drawing.Color.DimGray;
            this.lblMaban.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaban.ForeColor = System.Drawing.Color.White;
            this.lblMaban.Location = new System.Drawing.Point(29, 317);
            this.lblMaban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaban.Name = "lblMaban";
            this.lblMaban.Size = new System.Drawing.Size(65, 20);
            this.lblMaban.TabIndex = 1;
            this.lblMaban.Text = "Mã bàn";
            // 
            // lblTenban
            // 
            this.lblTenban.AutoSize = true;
            this.lblTenban.BackColor = System.Drawing.Color.DimGray;
            this.lblTenban.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenban.ForeColor = System.Drawing.Color.White;
            this.lblTenban.Location = new System.Drawing.Point(29, 443);
            this.lblTenban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenban.Name = "lblTenban";
            this.lblTenban.Size = new System.Drawing.Size(71, 20);
            this.lblTenban.TabIndex = 2;
            this.lblTenban.Text = "Tên bàn";
            // 
            // lblTrangthai
            // 
            this.lblTrangthai.AutoSize = true;
            this.lblTrangthai.BackColor = System.Drawing.Color.DimGray;
            this.lblTrangthai.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangthai.ForeColor = System.Drawing.Color.White;
            this.lblTrangthai.Location = new System.Drawing.Point(29, 584);
            this.lblTrangthai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrangthai.Name = "lblTrangthai";
            this.lblTrangthai.Size = new System.Drawing.Size(89, 20);
            this.lblTrangthai.TabIndex = 3;
            this.lblTrangthai.Text = "Trạng thái";
            // 
            // txtMaban
            // 
            this.txtMaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaban.Location = new System.Drawing.Point(203, 314);
            this.txtMaban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaban.Name = "txtMaban";
            this.txtMaban.ReadOnly = true;
            this.txtMaban.Size = new System.Drawing.Size(193, 23);
            this.txtMaban.TabIndex = 4;
            // 
            // txtTenban
            // 
            this.txtTenban.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenban.Location = new System.Drawing.Point(203, 447);
            this.txtTenban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenban.Name = "txtTenban";
            this.txtTenban.Size = new System.Drawing.Size(193, 23);
            this.txtTenban.TabIndex = 5;
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangthai.Location = new System.Drawing.Point(203, 584);
            this.txtTrangthai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(193, 23);
            this.txtTrangthai.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.txtTrangthai);
            this.panel1.Controls.Add(this.txtTenban);
            this.panel1.Controls.Add(this.txtMaban);
            this.panel1.Controls.Add(this.lblTrangthai);
            this.panel1.Controls.Add(this.lblTenban);
            this.panel1.Controls.Add(this.lblMaban);
            this.panel1.Controls.Add(this.lblThongtin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1041, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 957);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblTongdanhmuc);
            this.panel2.Controls.Add(this.lblTongDM);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 53);
            this.panel2.TabIndex = 13;
            // 
            // lblTongdanhmuc
            // 
            this.lblTongdanhmuc.AutoSize = true;
            this.lblTongdanhmuc.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongdanhmuc.Location = new System.Drawing.Point(237, 13);
            this.lblTongdanhmuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongdanhmuc.Name = "lblTongdanhmuc";
            this.lblTongdanhmuc.Size = new System.Drawing.Size(29, 20);
            this.lblTongdanhmuc.TabIndex = 5;
            this.lblTongdanhmuc.Text = "10";
            // 
            // lblTongDM
            // 
            this.lblTongDM.AutoSize = true;
            this.lblTongDM.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDM.Location = new System.Drawing.Point(19, 13);
            this.lblTongDM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongDM.Name = "lblTongDM";
            this.lblTongDM.Size = new System.Drawing.Size(133, 20);
            this.lblTongDM.TabIndex = 3;
            this.lblTongDM.Text = "Tổng danh mục:";
            // 
            // dgv_maBanAn
            // 
            this.dgv_maBanAn.HeaderText = "Mã bàn ăn";
            this.dgv_maBanAn.MinimumWidth = 6;
            this.dgv_maBanAn.Name = "dgv_maBanAn";
            this.dgv_maBanAn.Width = 200;
            // 
            // dgv_tenBanAn
            // 
            this.dgv_tenBanAn.HeaderText = "Tên bàn ăn";
            this.dgv_tenBanAn.MinimumWidth = 6;
            this.dgv_tenBanAn.Name = "dgv_tenBanAn";
            this.dgv_tenBanAn.Width = 300;
            // 
            // dgv_trangThai
            // 
            this.dgv_trangThai.HeaderText = "Trạng thái";
            this.dgv_trangThai.MinimumWidth = 6;
            this.dgv_trangThai.Name = "dgv_trangThai";
            this.dgv_trangThai.Width = 300;
            // 
            // txt_FindNameTable
            // 
            this.txt_FindNameTable.Location = new System.Drawing.Point(213, 4);
            this.txt_FindNameTable.Name = "txt_FindNameTable";
            this.txt_FindNameTable.Size = new System.Drawing.Size(560, 21);
            this.txt_FindNameTable.TabIndex = 14;
            this.txt_FindNameTable.TextChanged += new System.EventHandler(this.txt_FindNameTable_TextChanged);
            // 
            // frmAdminTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 957);
            this.Controls.Add(this.txt_FindNameTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBanAn);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdminTable";
            this.Text = "frmTable";
            this.Load += new System.EventHandler(this.frmTable_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAn)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolstripTim;
        private System.Windows.Forms.DataGridView dgvBanAn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lblThongtin;
        private System.Windows.Forms.Label lblMaban;
        private System.Windows.Forms.Label lblTenban;
        private System.Windows.Forms.Label lblTrangthai;
        private System.Windows.Forms.TextBox txtMaban;
        private System.Windows.Forms.TextBox txtTenban;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTongdanhmuc;
        private System.Windows.Forms.Label lblTongDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_maBanAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_tenBanAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_trangThai;
        private System.Windows.Forms.TextBox txt_FindNameTable;
    }
}
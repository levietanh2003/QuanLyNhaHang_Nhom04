using quanLyNhaHang_Nhom4.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace quanLyNhaHang_Nhom4.Manager
{
    public partial class frmAdminTable : Form
    {
        QuanLyQuanAnEntities QuanLyQuanAnEntities = new QuanLyQuanAnEntities();
        public frmAdminTable()
        {
            InitializeComponent();
            columnRatio();
        }
        #region Event
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            try
            {
                List<TableFood> TableFood = QuanLyQuanAnEntities.TableFoods.ToList();
                BindGird(TableFood);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        #endregion

        #region Method
        public void columnRatio()
        {
            int totalWidth = dgvBanAn.Width;
            int column1Width = (int)(totalWidth * 0.2);
            int column2Width = (int)(totalWidth * 0.4);
            int column3Width = (int)(totalWidth * 0.4);

            dgvBanAn.Columns[0].Width = column1Width;
            dgvBanAn.Columns[1].Width = column2Width;
            dgvBanAn.Columns[2].Width = column3Width;
        }
        #endregion
        private void BindGird(List<TableFood> tableFoods)
        {
            dgvBanAn.Rows.Clear();
            foreach (var item in tableFoods)
            {
                int index = dgvBanAn.Rows.Add();
                dgvBanAn.Rows[index].Cells[0].Value = item.idTable;
                dgvBanAn.Rows[index].Cells[1].Value = item.nameTable;
                dgvBanAn.Rows[index].Cells[2].Value = item.statusTable;
            }
        }
        private int GetSelectedRow(string nameTable)
        {
            for (int i = 0; i < dgvBanAn.Rows.Count; i++)
            {
                if (dgvBanAn.Rows[i].Cells[1].Value != null && dgvBanAn.Rows[i].Cells[1].Value.ToString() == nameTable)
                {
                    return i;
                }
            }
            return -1;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenban.Text == "")
                {
                    throw new Exception("Vui lòng nhâp đầy đủ thông tin bàn ăn!");
                }
                int selectedRow = GetSelectedRow(txtTenban.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgvBanAn.Rows.Add();
                    QuanLyQuanAnEntities.TableFoods.Add(new TableFood() { nameTable = txtTenban.Text, statusTable = "Trống" });
                    QuanLyQuanAnEntities.SaveChanges();
                    BindGird(QuanLyQuanAnEntities.TableFoods.ToList());
                    MessageBox.Show("Thêm bàn thành công", "Thông báo", MessageBoxButtons.OK);
                    show();
                }
                else
                {
                    MessageBox.Show("Trùng Tên Bàn!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            int maBan = int.Parse(txtMaban.Text);
            TableFood tableFood = QuanLyQuanAnEntities.TableFoods.FirstOrDefault(p => p.idTable == maBan);
            if (tableFood != null)
            {
                int selectedRow = GetSelectedRow(txtTenban.Text);
                if (selectedRow == -1)
                {
                    tableFood.nameTable = txtTenban.Text;
                    QuanLyQuanAnEntities.SaveChanges();
                    BindGird(QuanLyQuanAnEntities.TableFoods.ToList());
                    MessageBox.Show("Cập nhập dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                    show();
                }
                else
                {
                    MessageBox.Show("Trùng Tên Bàn!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã bàn cần sửa", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dgvBanAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                List<TableFood> TableFood = QuanLyQuanAnEntities.TableFoods.ToList();

                if (dgvBanAn.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvBanAn.CurrentRow.Selected = true;
                    txtMaban.Text = dgvBanAn.Rows[e.RowIndex].Cells["dgv_maBanAn"].FormattedValue.ToString();
                    txtTenban.Text = dgvBanAn.Rows[e.RowIndex].Cells["dgv_tenBanAn"].FormattedValue.ToString();
                    txtTrangthai.Text = dgvBanAn.Rows[e.RowIndex].Cells["dgv_trangThai"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtTenban.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy bàn cần xóa");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        TableFood dbDelete = QuanLyQuanAnEntities.TableFoods.FirstOrDefault(p => p.nameTable == txtTenban.Text);
                        QuanLyQuanAnEntities.TableFoods.Remove(dbDelete);
                        QuanLyQuanAnEntities.SaveChanges();
                        BindGird(QuanLyQuanAnEntities.TableFoods.ToList());
                        MessageBox.Show("Xóa bàn ăn thành công!", "Thông Báo", MessageBoxButtons.OK);
                        show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void show()
        {
            txtMaban.Text = "";
            txtTenban.Text = "";
            txtTrangthai.Text = "";
        }
        private void reset()
        {
                try
                {
                    List<TableFood> tableFoods = QuanLyQuanAnEntities.TableFoods.ToList();
                    BindGird(tableFoods);
                    show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            //count  = 0;
            
        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            reset();
        }
        void FindNameTable(string name)
        {
            int n = 0;
            dgvBanAn.Rows.Clear();
            foreach(var item in(from TableFood in QuanLyQuanAnEntities.TableFoods where TableFood.nameTable.Contains(name) select TableFood).ToList())
            {
                n = dgvBanAn.Rows.Add();
                dgvBanAn.Rows[n].Cells[0].Value = item.idTable;
                dgvBanAn.Rows[n].Cells[1].Value = item.nameTable;
                dgvBanAn.Rows[n].Cells[2].Value = item.statusTable;
            }
        }

        private void toolStripSobanan_Click(object sender, EventArgs e)
        {
            //FindNameTable();
        }

        private void txt_FindNameTable_TextChanged(object sender, EventArgs e)
        {
            FindNameTable(txt_FindNameTable.Text);
        }
    }
}

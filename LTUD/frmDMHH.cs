using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LTUD
{

    public partial class frmDMHH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable com2dt = new DataTable();

        Boolean addNewFlag = false;
        string sql, constr;
        int i;
        public frmDMHH()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void grdData_Load(object sender, EventArgs e)
        {
            /*constr = "Data Source = LAPTOP - 915T4IQU\\HUYENVO;" +
                " Initial Catalog = QLBH; Integrated Security = True";*/
            constr = "Data Source=LAPTOP-915T4IQU\\HUYENVO;Initial Catalog=QLBH;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select manhom, mahh,tenhh, dvt, dgvnd, sanxuat  from tblDMHH order by MaHH";
            da=new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdDt.DataSource = dt;
            NapCT();

            sql = "select manhom from tblDMNhom";
            da = new SqlDataAdapter(sql, conn);
            com2dt.Clear();
            da.Fill(com2dt);
            txtMaNhom.DataSource = com2dt;
            txtMaNhom.DisplayMember = "MaNhom";
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdDt.CurrentCell = grdDt[0, 0];
            NapCT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            i = grdDt.RowCount;
            grdDt.CurrentCell = grdDt[0, i-2];
            NapCT();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdDt.CurrentRow.Index;
            if(i < grdDt.RowCount - 2)
            {
                grdDt.CurrentCell = grdDt[0, i + 1];
            }
            else
            {
                grdDt.CurrentCell = grdDt[0, 0];
            }
            
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = grdDt.CurrentRow.Index;
            
            if (i > 0)
            {
                grdDt.CurrentCell = grdDt[0, i - 1];
            }
            else
            {
                grdDt.CurrentCell = grdDt[0, grdDt.RowCount - 2];
            }
            NapCT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "select manhom, mahh,tenhh, dvt, dgvnd, sanxuat  from tblDMHH " + " where " + comTenTruong.Text + " = N'" + comGiaTri.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdDt.DataSource = dt;
            grdDt.Refresh();
            NapCT();
        }

        private void comTenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = " select distinct " + comTenTruong.Text + " from tblDmHH";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGiaTri.DataSource = comdt;
            comGiaTri.DisplayMember = comTenTruong.Text;
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            sql = "select manhom, mahh,tenhh, dvt, dgvnd, sanxuat  from tblDMHH order by MaHH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdDt.DataSource = dt;
            grdDt.Refresh();
            NapCT();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời không?Y/N","Xác nhận" +
                "yêu cầu",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                sql = "delete from tblDMHH where maHH = '" + txtMaHH.Text + "'";
                cmd.Connection = conn;
                // kết nối vs csdl
                cmd.CommandText = sql; 
                // gán nội dung câu lệnh sql
                cmd.ExecuteNonQuery();
                // chạy câu lệnh
                grdDt.Rows.RemoveAt(grdDt.CurrentRow.Index);
                //Xóa dữ liệu ở dòng hiện thời
                NapCT();
            }    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy thực hiện mọi sửa đổi mong muốn trên ô lưới, kết thúc bấm nút Cập nhật", "Thông báo", MessageBoxButtons.OK);
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(addNewFlag == false)
            {
                //cập nhật sửa chữa
                for(i = 0; i < grdDt.Rows.Count - 1; i++)
                {
                    //txtMaNhom.Text = grdDt.Rows[i].Cells["manhom"].Value.ToString();
                    txtMaHH.Text = grdDt.Rows[i].Cells["mahh"].Value.ToString();
                    txtTenHH.Text = grdDt.Rows[i].Cells["tenhh"].Value.ToString();
                    txtDVT.Text = grdDt.Rows[i].Cells["dvt"].Value.ToString();
                    txtDonGia.Text = grdDt.Rows[i].Cells["dgvnd"].Value.ToString();
                    txtNuocsx.Text = grdDt.Rows[i].Cells["sanxuat"].Value.ToString();
                    sql = "update tblDMHH set TenHH = N'" + txtTenHH.Text + "', dvt = N'" + txtDVT.Text + "', dgvnd = " + txtDonGia.Text + ", sanxuat = '" + txtNuocsx.Text + "' where mahh = '" + txtMaHH.Text + "'";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Đã cập nhật thành công", "Thông báo");
            }
            else 
            {
                //cập nhật thêm mới
                addNewFlag = false;
                sql = "insert into tblDMHH (MaNhom, MaHH, TenHH, Dvt, dgvnd, sanxuat) " + 
                    " values ('" + txtMaNhom.Text + "','" + txtMaHH.Text + "',N'" + txtTenHH.Text + "',N'" + txtDVT.Text+ "',N'" + txtDonGia.Text + "',N'"+ txtNuocsx + "')" ;
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                grdDt.Rows[i].Cells["manhom"].Value = txtMaNhom.Text;
                grdDt.Rows[i].Cells["mahh"].Value = txtMaHH.Text;
                grdDt.Rows[i].Cells["tenhh"].Value = txtTenHH.Text;
                grdDt.Rows[i].Cells["dvt"].Value = txtDVT.Text;
                grdDt.Rows[i].Cells["dgvnd"].Value = txtDonGia.Text;
                grdDt.Rows[i].Cells["sanxuat"].Value = txtNuocsx.Text;
                //gán dữ liệu từ chỗ ng dùng nhập vào cho dữ liệu
                grdDt.Refresh();
            }
            btnUpdate.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sql = "select manhom, mahh,tenhh, dvt, dgvnd, sanxuat  from tblDMHH order by MaHH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdDt.DataSource = dt;
            grdDt.Refresh();
            NapCT();

            grdDt.CurrentCell = grdDt[0, grdDt.Rows.Count - 1];
            //di chuyển xuống dòng cuối cùng
            NapCT();
            MessageBox.Show("Hãy nhập nội dung bản ghi mới, kết thúc bấm Cập nhật!");
            txtMaNhom.Focus();
            //chuyển ô chỏ soạn thảo đến ô Mã nhóm
            addNewFlag = true;
            btnUpdate.Enabled = true;
        }

        private void NapCT()
        {
            i = grdDt.CurrentRow.Index;
            //Nhận giá trị chỉ số của bản ghi hiện thời
            txtMaNhom.Text = grdDt.Rows[i].Cells["manhom"].Value.ToString();
            txtMaHH.Text = grdDt.Rows[i].Cells["mahh"].Value.ToString();
            txtTenHH.Text = grdDt.Rows[i].Cells["tenhh"].Value.ToString();
            txtDVT.Text = grdDt.Rows[i].Cells["dvt"].Value.ToString();
            txtDonGia.Text = grdDt.Rows[i].Cells["dgvnd"].Value.ToString();
            txtNuocsx.Text = grdDt.Rows[i].Cells["sanxuat"].Value.ToString();
        }
        
    }
}

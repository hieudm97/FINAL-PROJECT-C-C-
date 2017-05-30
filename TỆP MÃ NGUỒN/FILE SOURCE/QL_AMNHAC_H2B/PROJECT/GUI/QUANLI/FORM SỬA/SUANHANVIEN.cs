using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT.LOGIC_LAYER; 

namespace PROJECT.GUI.QUANLI.FORM_SỬA
{
    public partial class SUANHANVIEN : Form
    {
        //mem
        DataGridView dgv;
        LOGIC lg = new LOGIC(); 
        //func
        public SUANHANVIEN(DataGridView dgv)
        {
            this.dgv = dgv;
            InitializeComponent();
            show_info(); 
        }
        public void show_info()
        {
            DataGridViewRow dgv_row = dgv.SelectedRows[0];
            txt_id.Text = dgv_row.Cells["AID"].Value.ToString();
            txt_ten.Text = dgv_row.Cells["TEN"].Value.ToString();
            txt_tuoi.Text = dgv_row.Cells["TUOI"].Value.ToString();
            txt_diachi.Text = dgv_row.Cells["DIACHI"].Value.ToString();
            txt_tendangnhap.Text = dgv_row.Cells["TENDANGNHAP"].Value.ToString();
            txt_matkhau.Text = dgv_row.Cells["MATKHAU"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lg.sua_nhanvien(txt_id.Text, txt_ten.Text, txt_tuoi.Text, txt_diachi.Text, txt_tendangnhap.Text, txt_matkhau.Text);
            MessageBox.Show("SỦA THÔNG TIN NHÂN VIÊN THÀNH CÔNG!!!");
        }
    }
}

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
    public partial class SUAKHACHHANG : Form
    {
        //MEM
        LOGIC lg = new LOGIC();
        DataGridView dgv; 
        //FUNC
        public SUAKHACHHANG(DataGridView dgv)
        {
            this.dgv = dgv;
            InitializeComponent();
            show_info();
        }
        public void show_info()
        {
            DataGridViewRow dgv_row = dgv.SelectedRows[0];
            txt_id.Text = dgv_row.Cells["MAID"].Value.ToString();
            txt_ten.Text = dgv_row.Cells["TEN"].Value.ToString();
            textBox1.Text = dgv_row.Cells["TUOI"].Value.ToString();
            txt_congty.Text = dgv_row.Cells["CONGTY"].Value.ToString();
            txt_tendangnhap.Text = dgv_row.Cells["TENDANGNHAP"].Value.ToString();
            txt_matkhau.Text = dgv_row.Cells["MATKHAU"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lg.sua_khachang_ql(txt_id.Text,txt_ten.Text, textBox1.Text, txt_congty.Text, txt_tendangnhap.Text, txt_matkhau.Text);
            MessageBox.Show("SỬA THÔNG TIN THÀNH CÔNG THÀNH CÔNG!!!");
        }
    }
}

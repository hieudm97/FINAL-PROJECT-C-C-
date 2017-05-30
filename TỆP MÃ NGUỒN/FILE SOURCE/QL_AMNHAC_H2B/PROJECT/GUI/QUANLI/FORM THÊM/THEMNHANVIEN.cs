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

namespace PROJECT.GUI.QUANLI.FORM_THÊM
{
    public partial class THEMNHANVIEN : Form
    {
        //mem
        LOGIC lg = new LOGIC();
        //func
        public THEMNHANVIEN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lg.add_nhanvien(txt_id.Text,txt_ten.Text,txt_tuoi.Text,txt_diachi.Text,txt_tendangnhap.Text,txt_matkhau.Text);
            MessageBox.Show("THÊM NHÂN VIÊN THÀNH CÔNG!!!");
        }
    }
}

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

namespace PROJECT.GUI.DANGKY_DANGNHAP
{
    public partial class DANGKY : Form
    {
        //member
        LOGIC lg = new LOGIC();
        //func
        public DANGKY()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                try
                {
                    lg.dangky(txt_ten.Text, cbo_tuoi.Text, txt_congty.Text, txt_tendangnhap.Text, txt_matkhau.Text);
                    MessageBox.Show("ĐĂNG KÝ THÀNH CÔNG!!!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("VUI LÒNG ĐỒNG Ý VỚI TẤT CẢ ĐIỀU KHOẢN!!!");
            }
        }
    }
}

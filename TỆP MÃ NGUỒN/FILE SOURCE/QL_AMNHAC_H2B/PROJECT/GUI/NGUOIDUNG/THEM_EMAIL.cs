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
using System.Globalization;

namespace PROJECT.GUI.NGUOIDUNG
{
    public partial class THEM_EMAIL : Form
    {
        //member
        LOGIC lg = new LOGIC();
        int MAID; 
        //func 
        public THEM_EMAIL(int MAID)
        {
            this.MAID = MAID;
            InitializeComponent();
            ini_info();
        }
        public void ini_info()
        {
            //ma id thu
            int maidthu = int.Parse(lg.count_thu_nguoidung(MAID)) + 1 ;
            txt_idthu.Text = maidthu.ToString();
            txt_idthu.Visible = false;
            label2.Visible = false; 
            //ngay 
            txt_ngaytao.Text = DateTime.Now.ToString("ddmmyyyy", CultureInfo.InvariantCulture);
            //nguoidung 
            txt_nguoidung.Text = lg.getTenNguoiDungTuMaID(MAID);
            //nhan vien
            cbo_quantrivien.DataSource = lg.get_nhanvien_ql().ToList();
            cbo_quantrivien.DisplayMember = "TEN";
            cbo_quantrivien.ValueMember = "AID";

            //noi dung
            rich_noidung.Text = "Hãy nhập nội dung vào đây!!!"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*thêm thư*/
            lg.add_thu_nguoidung(int.Parse(lg.count_thu_nguoidung(MAID)) + 1, txt_ngaytao.Text, MAID, cbo_quantrivien.SelectedValue);
            MessageBox.Show("BẠN ĐÃ GỬI EMAIL THÀNH CÔNG!!!"); 
        }
    }
}

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

namespace PROJECT.GUI.QUANLI.FORM_THÊM
{
    public partial class THEMHOPTHU : Form
    {
        //mem
        LOGIC lg = new LOGIC();
        string tendangnhap;
        //fuc
        public THEMHOPTHU(string tendangnhap)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
            initialize_info();
        }
        public void initialize_info()
        {
            //ma thu 
            txt_idthu.Text = lg.get_mathu_ql();
            //nguoi dung
            cbo_tennguoidung.DataSource = lg.get_nguoidung_ql().ToList();
            cbo_tennguoidung.DisplayMember = "TEN";
            cbo_tennguoidung.ValueMember = "MAID";

            //ten quan tri vien
            txt_quantrivien.Text = lg.get_tenquantrivien(tendangnhap);

            //ngay khoi tao
            txt_ngaytao.Text = DateTime.Now.ToString("ddmmyyyy", CultureInfo.InvariantCulture);

        }
        public int get_AIDfromTENDANGNHAP(string tendangnhap)
        {
            int AID = lg.getAIDfromTENDANGNHAP(tendangnhap);
            return AID; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //add thong tin 
            lg.add_thu_ql(txt_idthu.Text, txt_ngaytao.Text, cbo_tennguoidung.SelectedValue, get_AIDfromTENDANGNHAP(tendangnhap), rich_noidung.Text);
            MessageBox.Show("GỬI THƯ THÀNH CÔNG!!!");
        }
    }
}

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
    public partial class THEMVIDEO : Form
    {
        //mem
        LOGIC lg = new LOGIC();
        //func
        public THEMVIDEO()
        {
            InitializeComponent();
            ini_info();
        }
        public void ini_info()
        {
            //maid bai hat 
            txt_maphim.Text = lg.get_soluongphim();
            //nghe si
            cbo_nghesi.DataSource = lg.get_nghesi().ToList();
            cbo_nghesi.DisplayMember = "TEN";
            cbo_nghesi.ValueMember = "NGHESIID";
            //album
            cbo_album.DataSource = lg.get_Album().ToList();
            cbo_album.DisplayMember = "TENALBUM";
            cbo_album.ValueMember = "ALBUMID";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txt_đuongdan.Text = open.FileName;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lg.add_phim_ql(txt_maphim.Text, txt_tenphim.Text, cbo_nghesi.SelectedValue, txt_danhgia.Text, cbo_album.SelectedValue, txt_đuongdan.Text);
            MessageBox.Show("THÊM PHIM THÀNH CÔNG");
        }
    }
}

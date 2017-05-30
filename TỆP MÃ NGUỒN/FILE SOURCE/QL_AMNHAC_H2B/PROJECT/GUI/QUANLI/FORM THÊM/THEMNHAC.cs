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
    public partial class THEMNHAC : Form
    {
        //mem
        LOGIC lg = new LOGIC();
        //func 
        public THEMNHAC()
        {
            InitializeComponent();
            ini_info();
        }
        public void ini_info()
        {
            //maid bai hat 
            txt_id.Text = lg.get_soluongbaihat();
            //nghe si
            cbo_nghesi.DataSource = lg.get_nghesi().ToList();
            cbo_nghesi.DisplayMember = "TEN";
            cbo_nghesi.ValueMember = "NGHESIID";
            //album
            cbo_album.DataSource = lg.get_Album().ToList();
            cbo_album.DisplayMember = "TENALBUM";
            cbo_album.ValueMember = "ALBUMID";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txt_duongdan.Text = open.FileName;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lg.add_baihat_ql(txt_id.Text, txt_tenbaihat.Text, cbo_nghesi.SelectedValue, txt_danhgia.Text, cbo_album.SelectedValue, txt_duongdan.Text);
            MessageBox.Show("THỀM BÀI HÁT THÀNH CÔNG");
            
        }
    }
}

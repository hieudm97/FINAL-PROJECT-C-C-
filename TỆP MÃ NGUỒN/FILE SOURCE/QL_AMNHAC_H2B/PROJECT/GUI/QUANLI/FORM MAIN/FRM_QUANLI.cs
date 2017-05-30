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

namespace PROJECT.GUI
{
    public partial class FRM_QUANLI : Form
    {
        //mem
        LOGIC lg = new LOGIC();
        string tendangnhap;
        //func
        public FRM_QUANLI(string tendangnhap)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
        }

        public void initilize_nhanvien_ql()
        {
            GUI.QUANLI.NHANVIEN nhanvien = new QUANLI.NHANVIEN();
            pn_main.Controls.Add(nhanvien);
            nhanvien.Dock = DockStyle.Fill;
            nhanvien.BringToFront();
        }
        public void change_txt_btn(string them, string xoa, string sua)
        {
            btn_them.Text = them;
            btn_xoa.Text = xoa;
            btn_sua.Text = sua;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            initilize_nhanvien_ql();
            change_txt_btn("THÊM NHÂN VIÊN", "XÓA NHÂN VIÊN", "SỬA NHÂN VIÊN");

        }

        public void initilize_nguoidung_ql()
        {
            GUI.QUANLI.NGUOIDUNG nhanvien = new QUANLI.NGUOIDUNG();
            pn_main.Controls.Add(nhanvien);
            nhanvien.Dock = DockStyle.Fill;
            nhanvien.BringToFront();
        }
        private void pic_nguoidung_Click(object sender, EventArgs e)
        {
            initilize_nguoidung_ql();
            change_txt_btn("THÊM NGƯỜI DÙNG", "XÓA NGƯỜI DÙNG", "SỬA NGƯỜI DÙNG");
        }

        public void initilize_nhacphim_ql()
        {
            GUI.QUANLI.BAIHATVIDEO nhanvien = new QUANLI.BAIHATVIDEO();
            pn_main.Controls.Add(nhanvien);
            nhanvien.Dock = DockStyle.Fill;
            nhanvien.BringToFront();
        }
        private void pic_nhacphim_Click(object sender, EventArgs e)
        {
            initilize_nhacphim_ql();
            change_txt_btn("THÊM NHẠC/PHIM", "XÓA NHẠC/PHIM", "");

        }

        public void initilize_hopthu_ql()
        {
            GUI.QUANLI.HOPTHU nhanvien = new QUANLI.HOPTHU();
            pn_main.Controls.Add(nhanvien);
            nhanvien.Dock = DockStyle.Fill;
            nhanvien.BringToFront();
        }
        private void pic_thu_Click(object sender, EventArgs e)
        {
            initilize_hopthu_ql();
            change_txt_btn("THÊM HỘP THƯ", "XÓA HỘP THƯ", "");
        }

        public int get_manv()
        {
            int manv = 0;
            QUANLI.NHANVIEN uc = this.Controls.Find("NHANVIEN", true).FirstOrDefault() as QUANLI.NHANVIEN;
            DataGridViewRow dr = uc.dataGridView1.SelectedRows[0];
            manv = int.Parse(dr.Cells["AID"].Value.ToString());
            return manv;
        }
        public int get_manguoidung()
        {
            int manv = 0;
            QUANLI.NGUOIDUNG uc = this.Controls.Find("NGUOIDUNG", true).FirstOrDefault() as QUANLI.NGUOIDUNG;
            DataGridViewRow dr = uc.dataGridView1.SelectedRows[0];
            manv = int.Parse(dr.Cells[0].Value.ToString());
            return manv;
        }
        public int get_mahopthu()
        {
            int manv = 0;
            QUANLI.HOPTHU uc = this.Controls.Find("HOPTHU", true).FirstOrDefault() as QUANLI.HOPTHU;
            DataGridViewRow dr = uc.dataGridView1.SelectedRows[0];
            manv = int.Parse(dr.Cells["EMAILID"].Value.ToString());
            return manv;
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (btn_xoa.Text == "XÓA NHÂN VIÊN")
            {
                try
                {
                    
                    lg.delete_nhanvien(get_manv());
                    MessageBox.Show("XÓA NHÂN VIÊN THÀNH CÔNG!!!");
                }
                catch
                {
                    MessageBox.Show("Xin lỗi không thể xóa!!!");
                }
                
            }
            else
            {
                if (btn_xoa.Text == "XÓA NGƯỜI DÙNG")
                {
                    try
                    {
                       
                        lg.delete_nguoidung(get_manguoidung());
                        MessageBox.Show("XÓA NGƯỜI DÙNG THÀNH CÔNG!!!");
                    }
                    catch
                    {
                        MessageBox.Show("Xin lỗi không thể xóa!!!");
                    }
                   
                }
                else
                {
                    if (btn_xoa.Text == "XÓA HỘP THƯ")
                    {
                        try
                        {
                            lg.delete_hopthu(get_mahopthu());
                            MessageBox.Show("XÓA HỘP THƯ THÀNH CÔNG!!!");
                        }
                        catch
                        {
                            MessageBox.Show("Xin lỗi không thể xóa!!!");
                        }
                        
                    }
                    else
                    {
                        if(btn_xoa.Text == "XÓA NHẠC/PHIM")
                        {
                            /*
                             * lây thông tin combobox ben BAIHATVAPHIM uc*/
                            QUANLI.BAIHATVIDEO uc = this.Controls.Find("BAIHATVIDEO", true).FirstOrDefault() as QUANLI.BAIHATVIDEO;
                            DataGridViewRow dgv_row = uc.dataGridView1.SelectedRows[0];
                            int maidorphim = int.Parse(dgv_row.Cells[0].Value.ToString());
                            string tmp = uc.comboBox1.Text;
                            switch (tmp)
                            {
                                case "BÀI HÁT":
                                    try
                                    {
                                        /*xóa bài hát ở đây */
                                        lg.delete_baihat_ql(maidorphim);
                                        MessageBox.Show("Xóa bài hát thành công !!!!"); 
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Xin lỗi không thể xóa!!!!"); 
                                    }
                                    break;
                                case "PHIM":
                                    try
                                    {
                                        lg.delete_phim_ql(maidorphim);
                                        MessageBox.Show("Xóa phim thành công !!!!");
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Xin lỗi không thể xóa!!!!");
                                    }
                                    break;
                            }


                        }
                    }
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "THÊM NHÂN VIÊN")
            {
                QUANLI.FORM_THÊM.THEMNHANVIEN frm_add_nv = new QUANLI.FORM_THÊM.THEMNHANVIEN();
                frm_add_nv.Show();
            }
            else
            {
                if (btn_them.Text == "THÊM NGƯỜI DÙNG")
                {
                    GUI.DANGKY_DANGNHAP.DANGKY frm_dk = new DANGKY_DANGNHAP.DANGKY();
                    frm_dk.Show();
                }
                else
                {
                    if (btn_them.Text == "THÊM HỘP THƯ")
                    {
                        QUANLI.FORM_THÊM.THEMHOPTHU frm_add_nv = new QUANLI.FORM_THÊM.THEMHOPTHU(tendangnhap);
                        frm_add_nv.Show();
                    }
                    else
                    {
                        if (btn_them.Text == "THÊM NHẠC/PHIM")
                        {
                            QUANLI.BAIHATVIDEO uc = this.Controls.Find("BAIHATVIDEO", true).FirstOrDefault() as QUANLI.BAIHATVIDEO;
                            string chuoixoa = uc.comboBox1.Text;
                            switch (chuoixoa)
                            {
                                case "BÀI HÁT":
                                    QUANLI.FORM_THÊM.THEMNHAC frm_addnhac = new QUANLI.FORM_THÊM.THEMNHAC();
                                    frm_addnhac.Show();
                                    break;
                                case "PHIM":
                                    QUANLI.FORM_THÊM.THEMVIDEO frm_addvideo = new QUANLI.FORM_THÊM.THEMVIDEO();
                                    frm_addvideo.Show();
                                    break;
                            }

                        }
                    }
                }
            }
        }
        public DataGridView get_datagrid_nhanvien()
        {
            QUANLI.NHANVIEN uc = this.Controls.Find("NHANVIEN", true).FirstOrDefault() as QUANLI.NHANVIEN;
            DataGridView dgv = uc.dataGridView1;
            return dgv;
        }
        public DataGridView get_datagrid_nguoidung()
        {
            QUANLI.NGUOIDUNG uc = this.Controls.Find("NGUOIDUNG", true).FirstOrDefault() as QUANLI.NGUOIDUNG;
            DataGridView dgv = uc.dataGridView1;
            return dgv;
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "SỬA NHÂN VIÊN")
            {
                QUANLI.FORM_SỬA.SUANHANVIEN frm_suanv = new QUANLI.FORM_SỬA.SUANHANVIEN(get_datagrid_nhanvien());
                frm_suanv.Show();
            }
            else
            {
                if (btn_sua.Text == "SỬA NGƯỜI DÙNG")
                {
                    QUANLI.FORM_SỬA.SUAKHACHHANG frm_suakh = new QUANLI.FORM_SỬA.SUAKHACHHANG(get_datagrid_nguoidung());
                    frm_suakh.Show();
                }

            }
        }

        private void FRM_QUANLI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }
    }
}


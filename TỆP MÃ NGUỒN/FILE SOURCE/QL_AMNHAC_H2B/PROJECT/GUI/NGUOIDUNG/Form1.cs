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

namespace PROJECT
{
    public partial class Form1 : Form
    {
        //mem
        LOGIC lg = new LOGIC();
        string tendangnhap;
        int MAID;
        //func 
        public void initialize_nghesi()
        {

            
            //lay danh sach nghe si 
            List<NGHESI> lst_nghesi = lg.get_nghesi().ToList<NGHESI>();
            //duyet vong lap la hien thi tren list view
            foreach(NGHESI nghesi in lst_nghesi)
            {
                ListViewItem ls_item = new ListViewItem(nghesi.TEN);
                ls_item.ToolTipText = nghesi.TIEUSU;
                listView1.Items.Add(ls_item);
            }
           
        }
        public void get_maidfromtendangnhap_nguoidung(string tendangnhap)
        {
            MAID = lg.getmaidfromtendangnhap_nguoidung(tendangnhap);

        }
        public Form1(string tendangnhap)
        {
            this.tendangnhap = tendangnhap;
            InitializeComponent();
            get_maidfromtendangnhap_nguoidung(tendangnhap);
            initialize_info();
            initialize_nghesi();
        }
        public void initialize_info()
        {
            lbl_tendangnhap.Text = tendangnhap;

            lbl_thu.Text = "Bạn có: " + lg.count_thu_nguoidung(MAID) + " thư";
        }
        public void mouse_hover(PictureBox tmp)
        {
            tmp.BackColor = Color.FromArgb(22, 48, 83);
        }
        public void mouse_leave(PictureBox tmp)
        {
            tmp.BackColor = Color.FromArgb(162, 170, 157);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            mouse_hover(pic_baihat);
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            mouse_hover(pic_phim);
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            mouse_hover(pic_album);
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            mouse_hover(pic_playlist);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            mouse_hover(pic_email);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            mouse_leave(pic_baihat);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            mouse_leave(pic_phim);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            mouse_leave(pic_album);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            mouse_leave(pic_playlist);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            mouse_leave(pic_email);
        }

        private void pic_baihat_Click(object sender, EventArgs e)
        {
            GUI.NGUOIDUNG.BAIHAT album = new GUI.NGUOIDUNG.BAIHAT();
            pn_main.Controls.Add(album);
            album.Dock = DockStyle.Fill;
            album.BringToFront();
        }

        private void pic_phim_Click(object sender, EventArgs e)
        {
            GUI.NGUOIDUNG.PHIM album = new GUI.NGUOIDUNG.PHIM();
            pn_main.Controls.Add(album);
            album.Dock = DockStyle.Fill;
            album.BringToFront();
        }

        private void pic_album_Click(object sender, EventArgs e)
        {
            GUI.NGUOIDUNG.ALBUM album = new GUI.NGUOIDUNG.ALBUM();
            pn_main.Controls.Add(album);
            album.Dock = DockStyle.Fill;
            album.BringToFront();
        }

        private void pic_playlist_Click(object sender, EventArgs e)
        {

            if(lg.check_list_nhac(MAID) == true)
            {
                /* mo USER CONTROL playlist_coroi 
                 */
                GUI.NGUOIDUNG.PLAYLIST_coroi album = new GUI.NGUOIDUNG.PLAYLIST_coroi(MAID);
                pn_main.Controls.Add(album);
                album.Dock = DockStyle.Fill;
                album.BringToFront();
            }
            else
            {
                /*hien thi form chua co playlist*/
                GUI.NGUOIDUNG.playlist_chuaco album = new GUI.NGUOIDUNG.playlist_chuaco(MAID);
                pn_main.Controls.Add(album);
                album.Dock = DockStyle.Fill;
                album.BringToFront();

            }
           
        }

        private void pic_email_Click(object sender, EventArgs e)
        {
            string messageBoxText = "Bạn muốn xem hộp thư(YES) hay tạo một thư mới(NO) ?";
            string caption = "HÃY CHỌN!!!";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            DialogResult result = MessageBox.Show(messageBoxText, caption, button, icon);
            if (result == DialogResult.Yes)
            {
                GUI.NGUOIDUNG.EMAIL album = new GUI.NGUOIDUNG.EMAIL(MAID);
                pn_main.Controls.Add(album);
                album.Dock = DockStyle.Fill;
                album.BringToFront();
            }
            else
            {
                if (result == DialogResult.No)
                {
                    GUI.NGUOIDUNG.THEM_EMAIL _frm_thememail = new GUI.NGUOIDUNG.THEM_EMAIL(MAID);
                    _frm_thememail.Show();
                }
            }
            
        }

        private void pic_timkiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lg.search_nguoidung(textBox1.Text).ToList();
            dataGridView1.BringToFront();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            string path = row.Cells[5].Value.ToString();
            Form1 frm;
            frm = (Form1)this.FindForm();
            frm.axWindowsMediaPlayer1.URL = path;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            ListViewItem item = listView1.SelectedItems[0];
            item.BackColor = Color.FromArgb(31, 42, 51);
            item.ForeColor = Color.White;
            string tennghesi = item.Text;
            this.dataGridView1.DataSource = null;
            dataGridView1.DataSource = lg.getBaiHatFromNgheSi(tennghesi).ToList() ;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;

            dataGridView1.BringToFront();
            item.Selected = false; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        //  private void listView1_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        //{
        //    e.Item.BackColor = Color.FromArgb(31, 42, 51);
        //    e.Item.ForeColor = Color.White;

        //}
    }
}

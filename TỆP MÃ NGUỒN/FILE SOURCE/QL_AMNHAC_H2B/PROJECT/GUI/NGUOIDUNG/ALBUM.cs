using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT.LOGIC_LAYER;

namespace PROJECT.GUI.NGUOIDUNG
{
    public partial class ALBUM : UserControl
    {
        //member
        LOGIC lg = new LOGIC();
        //func
        public ALBUM()
        {
            
            InitializeComponent();
        }
        public void initialize_cbo()
        {
            comboBox1.DataSource = (from album in lg.get_Album()
                                    select new
                                    {
                                        album.TENALBUM
                                    }).ToList();
            comboBox1.DisplayMember = "TENALBUM";
        }
        private void ALBUM_Load(object sender, EventArgs e)
        {
            //load du lieu len combobox
            initialize_cbo();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //load du lieu nhac len datagridview 1
            dataGridView1.DataSource = lg.get_BAIHAT_album(comboBox1.Text).ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            //load du lieu phim len datagridview 2
            dataGridView2.DataSource = lg.get_PHIM_album(comboBox1.Text).ToList();
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].Visible = false;
            dataGridView2.Columns[7].Visible = false;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string path = row.Cells[5].Value.ToString();
            Form1 frm;
            frm = (Form1)this.FindForm();
            frm.axWindowsMediaPlayer1.URL = path;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lay path dan phim
            DataGridViewRow row = dataGridView2.CurrentCell.OwningRow;
            string path = row.Cells["DUONGDANPHIM"].Value.ToString();
            //thuc hien tren Player frm1;
            Form1 frm;
            frm = (Form1)this.FindForm();
            frm.axWindowsMediaPlayer1.URL = path;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT.GUI.NGUOIDUNG
{
    public partial class PLAYLIST_coroi : UserControl
    {
        //mem 
        LOGIC_LAYER.LOGIC lg = new LOGIC_LAYER.LOGIC();
        int maid;
        //func
        public PLAYLIST_coroi(int maid)
        {
            InitializeComponent();
            this.maid = maid;
            show_info();
        }
        public void show_info()
        {
            dataGridView1.DataSource = lg.show_baihat_playlist(maid);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.BringToFront();
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            string path = row.Cells["DUONGDANBAIHAT"].Value.ToString();
            Form1 frm;
            frm = (Form1)this.FindForm();
            frm.axWindowsMediaPlayer1.URL = path;
        }
    }
}

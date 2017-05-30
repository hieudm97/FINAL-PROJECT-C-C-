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
    public partial class PHIM : UserControl
    {
        //member
        LOGIC lg = new LOGIC(); 
        //func
        public PHIM()
        {
            InitializeComponent();
            dataGridView1.DataSource = lg.get_PHIM().ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lay path dan phim
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            string path = row.Cells["DUONGDANPHIM"].Value.ToString();
            //thuc hien tren Player frm1;
            Form1 frm;
            frm = (Form1)this.FindForm();
            frm.axWindowsMediaPlayer1.URL = path;
        }
    }
}

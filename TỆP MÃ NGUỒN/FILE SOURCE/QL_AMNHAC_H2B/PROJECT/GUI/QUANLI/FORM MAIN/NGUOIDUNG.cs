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

namespace PROJECT.GUI.QUANLI
{
    public partial class NGUOIDUNG : UserControl
    {
        //member
        //func 
        LOGIC lg = new LOGIC();
        public NGUOIDUNG()
        {
            InitializeComponent();
            dataGridView1.DataSource = lg.get_nguoidung_ql().ToList();
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int manguoidung = int.Parse(textBox1.Text);
            dataGridView1.DataSource = lg.search_nguoidung_ql(manguoidung).ToList();
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.BringToFront();
        }
    }
}

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
    public partial class NHANVIEN : UserControl
    {
        //member
        LOGIC lg = new LOGIC();

       
        //func
        public NHANVIEN()
        {
            InitializeComponent();
            dataGridView1.DataSource = lg.get_nhanvien_ql().ToList();
            dataGridView1.Columns[6].Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(textBox1.Text);
            dataGridView1.DataSource = lg.search_nv(manv).ToList();
            dataGridView1.BringToFront();
        }
    }
}

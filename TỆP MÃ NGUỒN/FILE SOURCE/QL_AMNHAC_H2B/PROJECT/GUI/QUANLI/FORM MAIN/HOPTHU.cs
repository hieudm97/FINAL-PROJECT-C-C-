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
    public partial class HOPTHU : UserControl
    {
        //member
        LOGIC lg = new LOGIC();
       
        //func 
        public HOPTHU()
        {
            
            InitializeComponent();
           
            dataGridView1.DataSource = lg.get_hopthu_ql().ToList();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int mahopthu = int.Parse(textBox1.Text);
            dataGridView1.DataSource = lg.search_hopthu_ql(mahopthu).ToList();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.BringToFront();
        }
    }
}

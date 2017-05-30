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
    public partial class BAIHATVIDEO : UserControl
    {
        //member
        LOGIC lg = new LOGIC();
        //func 
        public void initialize_gview(string cbo)
        {
            if (cbo == "BÀI HÁT")
            {
                dataGridView1.DataSource = lg.get_BAIHAT().ToList();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[5].Visible = true;
                dataGridView1.Columns[7].Visible = true;
                dataGridView1.Columns[8].Visible = true;
            }
            else
            {
               if(cbo == "PHIM")
                {
                    dataGridView1.DataSource = lg.get_PHIM().ToList();
                    dataGridView1.Columns[0].Visible = true;
                    dataGridView1.Columns[2].Visible = true;
                    dataGridView1.Columns[4].Visible = true;
                    dataGridView1.Columns[5].Visible = true;
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                }
            }
        }
        public BAIHATVIDEO()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            initialize_gview(comboBox1.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string tmp = comboBox1.Text;
            switch (tmp)
            {
                case "PHIM":
                    dataGridView1.DataSource = lg.search_phim_ql(textBox1.Text).ToList();
                    dataGridView1.BringToFront();
                    break;
                case "BÀI HÁT":
                    dataGridView1.DataSource = lg.search_baihat_ql(textBox1.Text).ToList();
                    dataGridView1.BringToFront();
                    break;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

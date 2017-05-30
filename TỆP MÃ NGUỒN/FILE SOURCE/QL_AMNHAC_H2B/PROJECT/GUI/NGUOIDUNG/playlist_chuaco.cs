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
    public partial class playlist_chuaco : UserControl
    {
        //mem
        LOGIC lg = new LOGIC();
        int maid; 
        //func

        public playlist_chuaco(int maid)
        {
            InitializeComponent();
            this.maid = maid;
            show_info();
        }

        public void show_info()
        {
            //phan danh sach 
            textBox2.Text = "";
            //phan danh sach nhac
            dataGridView1.DataSource = lg.get_BAIHAT().ToList();
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[2].Visible = false;
            //dataGridView1.Columns[3].Visible = false;
            //dataGridView1.Columns[5].Visible = false;
            //dataGridView1.Columns[7].Visible = false;
            //dataGridView1.Columns[8].Visible = false;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            string tenlistnhac = textBox2.Text;
            int danhsachid = lg.get_danhsachid();
          
            lg.add_danhsachchoinhac(danhsachid,tenlistnhac,maid);

            /*tao danh sach chi tiet danh sach bai hat*/
            foreach (DataGridViewRow dgv_row in dataGridView1.Rows)
            {
                {
                    if((bool)dgv_row.Cells[0].Value == true)
                    {
                        int idbaihat = int.Parse(dgv_row.Cells["BAIHATID"].Value.ToString());

                        lg.add_chitietdanhsach(danhsachid, idbaihat);
                    }
                }
              
            }
            MessageBox.Show("CHÚC MỪNG!!! BẠN VỪA TẠO DANH SÁCH THÀNH CÔNG <3 ");
            
        }
    }
}

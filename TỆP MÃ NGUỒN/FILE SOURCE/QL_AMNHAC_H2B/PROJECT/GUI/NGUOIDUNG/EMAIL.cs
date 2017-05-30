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
    public partial class EMAIL : UserControl
    {
        //member
        LOGIC lg = new LOGIC();
        int MAID;
        //func
        public void initialize_gridemail(int nguoidungid)
        {
            dataGridView1.DataSource = lg.get_email(nguoidungid).ToList();
            //dataGridView1.Columns[0].Visible = false;   

        }
        public EMAIL(int nguoidungid)
        {
            this.MAID = nguoidungid;
            InitializeComponent();
            initialize_gridemail(MAID);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

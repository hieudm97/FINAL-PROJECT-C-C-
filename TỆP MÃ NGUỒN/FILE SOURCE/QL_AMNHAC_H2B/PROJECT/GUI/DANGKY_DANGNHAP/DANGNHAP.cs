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

namespace PROJECT.GUI.DANGKY_DANGNHAP
{
    public partial class DANGNHAP : Form
    {
        //member
        LOGIC lg = new LOGIC();
        //func
        public DANGNHAP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "QUẢN TRỊ VIÊN")
            {
                
                if(lg.check_quantrivien(textBox1.Text,textBox2.Text) == true)
                {
                    FRM_QUANLI frm_ql = new FRM_QUANLI(textBox1.Text);
                    frm_ql.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("THÔNG TIN BẠN NHẬP KHÔNG ĐÚNG");
                }
            }
            else
            {
                if(comboBox1.Text == "NGƯỜI DÙNG")
                {
                    if (lg.check_nguoidung(textBox1.Text, textBox2.Text) == true)
                    {
                        Form1 frm_ql = new Form1(textBox1.Text);
                        frm_ql.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("THÔNG TIN BẠN NHẬP KHÔNG ĐÚNG");
                    }
                }
                else
                {
                    MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN");
                }
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DANGKY dk = new DANGKY();
            dk.Show(); 
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Nhập tên đăng nhập...")
            {
                textBox1.Text = ""; 
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Nhập tên đăng nhập...";
                textBox1.ForeColor = Color.LightGray; 
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Nhập mật khẩu đăng nhập...")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Nhập mật khẩu đăng nhập...";
                textBox2.ForeColor = Color.LightGray;
            }
        }
    }
}

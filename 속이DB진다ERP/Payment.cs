using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace 속이DB진다ERP
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            MessageBox.Show("결제화면");
        }

        private void panel_header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)//결제 리스트 출력
        {
            Payment_list form = new Payment_list();
            form.Show();

        }

        private void button_enroll_Click(object sender, EventArgs e)//결제 등록 버튼
        {
            //결제 등록 버튼 기능
     
            DBManager.GetInstance().insert("INSERT INTO Payment_list (title, task, memo, permit_1, permit_2, permit_3, comment_, return_, return_memo) VALUES('" + textBox_title.Text + "','" + textBox_work.Text + "','" + textBox_memo.Text + "','" + comboBox_payment_1.Text + "','" + comboBox_payment_2.Text + "','" + comboBox_payment_3.Text + "', '" + textBox_comment.Text + "', 'false','false')");  
        }
    }
}

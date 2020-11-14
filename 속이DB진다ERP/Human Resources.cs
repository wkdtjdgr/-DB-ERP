using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 속이DB진다ERP
{
    public partial class Porsonnel : Form
    {
        public Porsonnel()
        {
            InitializeComponent();
        }

        private void Porsonnel_Load(object sender, EventArgs e)
        {
            Data_Load();
        }

        private bool Data_check()
        {
            bool result = false;
            if (textBox_Name.Text == "")
            {
                MessageBox.Show("이름를 입력해주시기 바랍니다.", "정보 오류");
            }
            else if (textBox_PhoneNumber.Text == "")
            {
                MessageBox.Show("연락처를 입력해주시기 바랍니다.", "정보 오류");
            }
            else if (textBox_Email.Text == "")
            {
                MessageBox.Show("이메일을 입력해주시기 바랍니다.", "정보 오류");
            }
            else if (comboBox_Department.Text == "")
            {
                MessageBox.Show("부서를 선택해주시기 바랍니다.", "정보 오류");
            }
            else if (comboBox_Rank.Text == "")
            {
                MessageBox.Show("직급을 선택해주시기 바랍니다.", "정보 오류");
            }
            else if (textBox_Address.Text == "")
            {
                MessageBox.Show("주소를 입력해주시기 바랍니다.", "정보 오류");
            }
            else if (textBox_Birthday.Text == "")
            {
                MessageBox.Show("생년월일을 입력해주시기 바랍니다.", "정보 오류");
            }
            else if (textBox_Employee_ID.Text == "")
            {
                MessageBox.Show("사원ID를 입력해주시기 바랍니다.", "정보 오류");
            }
            else result = true;
            return result;
        }
            private void button_Registration_Click(object sender, EventArgs e)
        {
            if (Data_check())
            {
                if (!DBManager.GetInstance().data_check("SELECT * FROM HR_management WHERE Employee_ID = '" + textBox_Employee_ID.Text + "'"))
                {
                    DBManager.GetInstance().insert("INSERT INTO HR_management (Employee_ID, Name, Phone_number, Email, Department, Rank, Address, Birthday) VALUES('" + textBox_Employee_ID.Text + "', '" + textBox_Name.Text + "','"+ textBox_PhoneNumber.Text + "','"+textBox_Email.Text+"','"+comboBox_Department.Text+"','"+comboBox_Rank.Text+"','"+textBox_Address.Text+"','"+textBox_Birthday.Text+"')");
                    Data_Load();
                } else
                {
                    MessageBox.Show("등록된 사원 정보가 있습니다.", "정보 오류");
                }
            }
        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            if (Data_check())
            {
                if (DBManager.GetInstance().data_check("SELECT * FROM HR_management WHERE Employee_ID = '" + textBox_Employee_ID.Text + "'"))
                {
                    DBManager.GetInstance().update("UPDATE HR_management SET Name = '" + textBox_Name.Text + "', Phone_number = '" + textBox_PhoneNumber.Text + "', Email = '" + textBox_Email.Text + "', Department = '" + comboBox_Department.Text + "', Rank = '" + comboBox_Rank.Text + "', Address = '"+textBox_Address.Text+"', Birthday = '" + textBox_Birthday.Text + "' WHERE Employee_ID = '"+ textBox_Employee_ID.Text +"'");
                    Data_Load();
                }
                else
                {
                    MessageBox.Show("사원 정보가 올바르지 않습니다.", "정보 오류");
                }
            }
        }

        private void button_Delet_Click(object sender, EventArgs e)
        {
            if (DBManager.GetInstance().data_check("SELECT * FROM HR_management WHERE Employee_ID = '" + textBox_Employee_ID.Text + "'"))
            {
                DBManager.GetInstance().delete("DELETE FROM HR_management WHERE Employee_ID = '" + textBox_Employee_ID.Text + "'");
                Data_Load();
            }
            else
            {
                MessageBox.Show("사원 정보가 없습니다.", "정보 오류");
            }
        }

        private void Data_Load()   //메뉴 정보 불러오기
        {
            dataGridView_HR.DataSource = DBManager.GetInstance().Load_data("SELECT Name as '이름', Phone_number as '연락처', Email as '이메일', Department as '부서', Rank as '직급', Address as '주소', Birthday as '생년월일', Employee_ID as '사원ID' FROM HR_management");
            //menu 테이블에서 정보를 불러온 후 dataGridView에 출력
        }

        private void button_Serch_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_HR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_Name.Text = dataGridView_HR.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox_PhoneNumber.Text = dataGridView_HR.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_Email.Text= dataGridView_HR.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox_Department.Text = dataGridView_HR.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox_Rank.Text = dataGridView_HR.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox_Address.Text = dataGridView_HR.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox_Birthday.Text = dataGridView_HR.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox_Employee_ID.Text = dataGridView_HR.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
    }
}

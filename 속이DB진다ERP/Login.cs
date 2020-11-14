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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginManager.GetInstance().userID = textBoxID.Text;

            if(DBManager.GetInstance().data_check("SELECT ID,Password FROM Login WHERE id = '" + textBoxID.Text + "'and Password='" + textBoxPassWord.Text + "'"))
            {
                LoginManager.GetInstance().userID = textBoxID.Text;
                MainForm form = new MainForm();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" 회원정보가 틀렸습니다. ");
                textBoxID.Text = "";
                textBoxPassWord.Text = "";
            }

            if (checkBoxIDsave.Checked == true)
            {
                Properties.Settings.Default.LoginIDSave = textBoxID.Text;
                Properties.Settings.Default.Checkis = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.LoginIDSave = "";
                Properties.Settings.Default.Checkis = false;
                Properties.Settings.Default.Save();
               
            }

            if (checkBoxPWsave.Checked == true)
            {
                Properties.Settings.Default.LoginPWSave = textBoxPassWord.Text;
                Properties.Settings.Default.Checkis = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.LoginPWSave = "";
                Properties.Settings.Default.Checkis = false;
                Properties.Settings.Default.Save();
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {
            textBoxID.Text = Properties.Settings.Default.LoginIDSave;
            textBoxPassWord.Text = Properties.Settings.Default.LoginPWSave;
            
            if(Properties.Settings.Default.Checkis == true)
            {
                checkBoxIDsave.Checked = true;
            }
            if (Properties.Settings.Default.Checkis == true)
            {
                checkBoxPWsave.Checked = true;
            }

        }
    }
}

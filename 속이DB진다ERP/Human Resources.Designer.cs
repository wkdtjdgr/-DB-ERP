namespace 속이DB진다ERP
{
    partial class Porsonnel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.comboBox_Department = new System.Windows.Forms.ComboBox();
            this.comboBox_Rank = new System.Windows.Forms.ComboBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.textBox_Birthday = new System.Windows.Forms.TextBox();
            this.textBox_Employee_ID = new System.Windows.Forms.TextBox();
            this.button_Registration = new System.Windows.Forms.Button();
            this.button_Modify = new System.Windows.Forms.Button();
            this.button_Delet = new System.Windows.Forms.Button();
            this.button_Serch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView_HR = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 452);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "▶ 부서 관리";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "▷ 부서정보관리";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "▷ 사원정보관리";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "▶ 사원정보";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(185, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "- 사원정보관리";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(188, 66);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(70, 21);
            this.textBox_Name.TabIndex = 1;
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(264, 66);
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(70, 21);
            this.textBox_PhoneNumber.TabIndex = 1;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(340, 66);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(140, 21);
            this.textBox_Email.TabIndex = 1;
            // 
            // comboBox_Department
            // 
            this.comboBox_Department.FormattingEnabled = true;
            this.comboBox_Department.Location = new System.Drawing.Point(486, 66);
            this.comboBox_Department.Name = "comboBox_Department";
            this.comboBox_Department.Size = new System.Drawing.Size(70, 20);
            this.comboBox_Department.TabIndex = 2;
            // 
            // comboBox_Rank
            // 
            this.comboBox_Rank.FormattingEnabled = true;
            this.comboBox_Rank.Location = new System.Drawing.Point(562, 66);
            this.comboBox_Rank.Name = "comboBox_Rank";
            this.comboBox_Rank.Size = new System.Drawing.Size(70, 20);
            this.comboBox_Rank.TabIndex = 2;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(638, 66);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(140, 21);
            this.textBox_Address.TabIndex = 1;
            // 
            // textBox_Birthday
            // 
            this.textBox_Birthday.Location = new System.Drawing.Point(784, 66);
            this.textBox_Birthday.Name = "textBox_Birthday";
            this.textBox_Birthday.Size = new System.Drawing.Size(70, 21);
            this.textBox_Birthday.TabIndex = 1;
            // 
            // textBox_Employee_ID
            // 
            this.textBox_Employee_ID.Location = new System.Drawing.Point(860, 66);
            this.textBox_Employee_ID.Name = "textBox_Employee_ID";
            this.textBox_Employee_ID.Size = new System.Drawing.Size(70, 21);
            this.textBox_Employee_ID.TabIndex = 1;
            // 
            // button_Registration
            // 
            this.button_Registration.Location = new System.Drawing.Point(936, 65);
            this.button_Registration.Name = "button_Registration";
            this.button_Registration.Size = new System.Drawing.Size(50, 23);
            this.button_Registration.TabIndex = 3;
            this.button_Registration.Text = "등록";
            this.button_Registration.UseVisualStyleBackColor = true;
            this.button_Registration.Click += new System.EventHandler(this.button_Registration_Click);
            // 
            // button_Modify
            // 
            this.button_Modify.Location = new System.Drawing.Point(992, 65);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(50, 23);
            this.button_Modify.TabIndex = 3;
            this.button_Modify.Text = "수정";
            this.button_Modify.UseVisualStyleBackColor = true;
            this.button_Modify.Click += new System.EventHandler(this.button_Modify_Click);
            // 
            // button_Delet
            // 
            this.button_Delet.Location = new System.Drawing.Point(1048, 65);
            this.button_Delet.Name = "button_Delet";
            this.button_Delet.Size = new System.Drawing.Size(50, 23);
            this.button_Delet.TabIndex = 3;
            this.button_Delet.Text = "삭제";
            this.button_Delet.UseVisualStyleBackColor = true;
            this.button_Delet.Click += new System.EventHandler(this.button_Delet_Click);
            // 
            // button_Serch
            // 
            this.button_Serch.Location = new System.Drawing.Point(1104, 65);
            this.button_Serch.Name = "button_Serch";
            this.button_Serch.Size = new System.Drawing.Size(50, 23);
            this.button_Serch.TabIndex = 3;
            this.button_Serch.Text = "검색";
            this.button_Serch.UseVisualStyleBackColor = true;
            this.button_Serch.Click += new System.EventHandler(this.button_Serch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(209, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "이름";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(276, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "연락처";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(389, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "이메일";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(504, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "부서";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(580, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "직급";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(690, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "주소";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(790, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "생년월일";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(872, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 15);
            this.label13.TabIndex = 4;
            this.label13.Text = "사원ID";
            // 
            // dataGridView_HR
            // 
            this.dataGridView_HR.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_HR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HR.Location = new System.Drawing.Point(188, 97);
            this.dataGridView_HR.Name = "dataGridView_HR";
            this.dataGridView_HR.RowTemplate.Height = 23;
            this.dataGridView_HR.Size = new System.Drawing.Size(966, 341);
            this.dataGridView_HR.TabIndex = 5;
            this.dataGridView_HR.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_HR_CellClick);
            // 
            // Porsonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1166, 450);
            this.Controls.Add(this.dataGridView_HR);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_Serch);
            this.Controls.Add(this.button_Delet);
            this.Controls.Add(this.button_Modify);
            this.Controls.Add(this.button_Registration);
            this.Controls.Add(this.comboBox_Rank);
            this.Controls.Add(this.comboBox_Department);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Employee_ID);
            this.Controls.Add(this.textBox_Birthday);
            this.Controls.Add(this.textBox_PhoneNumber);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Name = "Porsonnel";
            this.Text = "인사";
            this.Load += new System.EventHandler(this.Porsonnel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.ComboBox comboBox_Department;
        private System.Windows.Forms.ComboBox comboBox_Rank;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBox_Birthday;
        private System.Windows.Forms.TextBox textBox_Employee_ID;
        private System.Windows.Forms.Button button_Registration;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Button button_Delet;
        private System.Windows.Forms.Button button_Serch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView_HR;
    }
}
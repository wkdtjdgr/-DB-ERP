namespace 속이DB진다ERP
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.checkBoxIDsave = new System.Windows.Forms.CheckBox();
            this.checkBoxPWsave = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 40F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(49, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "속이DB진다 ERP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "PASSWORD";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(166, 173);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(177, 21);
            this.textBoxID.TabIndex = 1;
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.Location = new System.Drawing.Point(166, 212);
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.PasswordChar = '*';
            this.textBoxPassWord.Size = new System.Drawing.Size(177, 21);
            this.textBoxPassWord.TabIndex = 2;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(361, 173);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 60);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // checkBoxIDsave
            // 
            this.checkBoxIDsave.AutoSize = true;
            this.checkBoxIDsave.Location = new System.Drawing.Point(166, 261);
            this.checkBoxIDsave.Name = "checkBoxIDsave";
            this.checkBoxIDsave.Size = new System.Drawing.Size(59, 16);
            this.checkBoxIDsave.TabIndex = 4;
            this.checkBoxIDsave.Text = "ID저장";
            this.checkBoxIDsave.UseVisualStyleBackColor = true;
            // 
            // checkBoxPWsave
            // 
            this.checkBoxPWsave.AutoSize = true;
            this.checkBoxPWsave.Location = new System.Drawing.Point(166, 283);
            this.checkBoxPWsave.Name = "checkBoxPWsave";
            this.checkBoxPWsave.Size = new System.Drawing.Size(119, 16);
            this.checkBoxPWsave.TabIndex = 4;
            this.checkBoxPWsave.Text = "PASSWORD 저장";
            this.checkBoxPWsave.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 345);
            this.Controls.Add(this.checkBoxPWsave);
            this.Controls.Add(this.checkBoxIDsave);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassWord);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.CheckBox checkBoxIDsave;
        private System.Windows.Forms.CheckBox checkBoxPWsave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
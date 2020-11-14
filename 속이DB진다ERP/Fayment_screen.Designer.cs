namespace 속이DB진다ERP
{
    partial class Fayment_screen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.button_permit = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.textBox_return_reason = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_return_reason);
            this.groupBox1.Controls.Add(this.button_return);
            this.groupBox1.Controls.Add(this.button_permit);
            this.groupBox1.Controls.Add(this.textBox_info);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 18F);
            this.groupBox1.Location = new System.Drawing.Point(170, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 390);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "결제 하기";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F);
            this.label5.Location = new System.Drawing.Point(23, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "결제 상세 정보";
            // 
            // panel_header
            // 
            this.panel_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_header.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_header.Controls.Add(this.label4);
            this.panel_header.Location = new System.Drawing.Point(2, -2);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(908, 41);
            this.panel_header.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "결제";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 452);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "▷ 나의 결제 리스트";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "▷신규 결제 등록";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "▶ 결제";
            // 
            // textBox_info
            // 
            this.textBox_info.Location = new System.Drawing.Point(26, 65);
            this.textBox_info.Multiline = true;
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.Size = new System.Drawing.Size(655, 183);
            this.textBox_info.TabIndex = 13;
            // 
            // button_permit
            // 
            this.button_permit.Font = new System.Drawing.Font("굴림", 15F);
            this.button_permit.Location = new System.Drawing.Point(26, 264);
            this.button_permit.Name = "button_permit";
            this.button_permit.Size = new System.Drawing.Size(111, 38);
            this.button_permit.TabIndex = 14;
            this.button_permit.Text = "승인";
            this.button_permit.UseVisualStyleBackColor = true;
            // 
            // button_return
            // 
            this.button_return.Font = new System.Drawing.Font("굴림", 15F);
            this.button_return.Location = new System.Drawing.Point(157, 264);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(111, 38);
            this.button_return.TabIndex = 15;
            this.button_return.Text = "반려";
            this.button_return.UseVisualStyleBackColor = true;
            // 
            // textBox_return_reason
            // 
            this.textBox_return_reason.Location = new System.Drawing.Point(274, 264);
            this.textBox_return_reason.Multiline = true;
            this.textBox_return_reason.Name = "textBox_return_reason";
            this.textBox_return_reason.Size = new System.Drawing.Size(407, 118);
            this.textBox_return_reason.TabIndex = 16;
            this.textBox_return_reason.Text = "반려 사유";
            // 
            // Fayment_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel1);
            this.Name = "Fayment_screen";
            this.Text = "Fayment_screen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_return_reason;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button_permit;
        private System.Windows.Forms.TextBox textBox_info;
    }
}
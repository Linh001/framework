namespace lab1
{
    partial class Form1
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
            this.thongbao = new System.Windows.Forms.Label();
            this.tendangnhap = new System.Windows.Forms.TextBox();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dangnhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(326, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Đăng Nhập ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật Khẩu ";
            // 
            // thongbao
            // 
            this.thongbao.AutoSize = true;
            this.thongbao.ForeColor = System.Drawing.Color.Red;
            this.thongbao.Location = new System.Drawing.Point(345, 366);
            this.thongbao.Name = "thongbao";
            this.thongbao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.thongbao.Size = new System.Drawing.Size(0, 16);
            this.thongbao.TabIndex = 1;
            this.thongbao.Click += new System.EventHandler(this.label4_Click);
            // 
            // tendangnhap
            // 
            this.tendangnhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tendangnhap.HideSelection = false;
            this.tendangnhap.Location = new System.Drawing.Point(334, 116);
            this.tendangnhap.Name = "tendangnhap";
            this.tendangnhap.Size = new System.Drawing.Size(297, 22);
            this.tendangnhap.TabIndex = 2;
            this.tendangnhap.TextChanged += new System.EventHandler(this.login);
            // 
            // matkhau
            // 
            this.matkhau.BackColor = System.Drawing.Color.White;
            this.matkhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matkhau.Location = new System.Drawing.Point(334, 162);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(297, 22);
            this.matkhau.TabIndex = 2;
            this.matkhau.UseSystemPasswordChar = true;
            this.matkhau.TextChanged += new System.EventHandler(this.login);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(215, 307);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "hiển thị mật khẩu ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dangnhap
            // 
            this.dangnhap.BackColor = System.Drawing.Color.White;
            this.dangnhap.Enabled = false;
            this.dangnhap.ForeColor = System.Drawing.Color.Black;
            this.dangnhap.Location = new System.Drawing.Point(500, 293);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(131, 47);
            this.dangnhap.TabIndex = 4;
            this.dangnhap.Text = "Đăng Nhập";
            this.dangnhap.UseVisualStyleBackColor = false;
            this.dangnhap.TextChanged += new System.EventHandler(this.login);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dangnhap);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.tendangnhap);
            this.Controls.Add(this.thongbao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Đăng nhập ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label thongbao;
        private System.Windows.Forms.TextBox tendangnhap;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button dangnhap;
    }
}


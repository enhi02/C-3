
namespace ps18264_ASM_C3
{
    partial class DangNhap
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
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.grbLogin = new System.Windows.Forms.GroupBox();
            this.grbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.Location = new System.Drawing.Point(6, 40);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(87, 17);
            this.username.TabIndex = 0;
            this.username.Text = "User Name :";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.Location = new System.Drawing.Point(6, 85);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(77, 17);
            this.password.TabIndex = 1;
            this.password.Text = "Password :";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(100, 35);
            this.txtTaiKhoan.Multiline = true;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(197, 22);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(100, 80);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(197, 22);
            this.txtMatKhau.TabIndex = 3;
            // 
            // btLogin
            // 
            this.btLogin.AutoSize = true;
            this.btLogin.ForeColor = System.Drawing.Color.Black;
            this.btLogin.Location = new System.Drawing.Point(64, 122);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 30);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btCancel
            // 
            this.btCancel.AutoSize = true;
            this.btCancel.ForeColor = System.Drawing.Color.Black;
            this.btCancel.Location = new System.Drawing.Point(185, 122);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(77, 30);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // grbLogin
            // 
            this.grbLogin.Controls.Add(this.btCancel);
            this.grbLogin.Controls.Add(this.btLogin);
            this.grbLogin.Controls.Add(this.txtMatKhau);
            this.grbLogin.Controls.Add(this.txtTaiKhoan);
            this.grbLogin.Controls.Add(this.password);
            this.grbLogin.Controls.Add(this.username);
            this.grbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLogin.ForeColor = System.Drawing.Color.Red;
            this.grbLogin.Location = new System.Drawing.Point(29, 12);
            this.grbLogin.Name = "grbLogin";
            this.grbLogin.Size = new System.Drawing.Size(318, 164);
            this.grbLogin.TabIndex = 0;
            this.grbLogin.TabStop = false;
            this.grbLogin.Text = "Login";
            this.grbLogin.Enter += new System.EventHandler(this.grbLogin_Enter);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(367, 189);
            this.Controls.Add(this.grbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DangNhap";
            this.Text = "Đăng Nhập";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.grbLogin.ResumeLayout(false);
            this.grbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.GroupBox grbLogin;
    }
}


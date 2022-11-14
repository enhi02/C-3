
namespace lab2
{
    partial class bai2
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbtime1 = new System.Windows.Forms.TextBox();
            this.tbtime2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BUTReset = new System.Windows.Forms.Button();
            this.BUTThoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbdanhsach = new System.Windows.Forms.ListBox();
            this.lbchon = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Việt Nam",
            "Nhật Bản",
            "Trung Quốc",
            "Hàn Quốc"});
            this.comboBox1.Location = new System.Drawing.Point(130, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "--Mời Chọn--";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn họ tên:";
            // 
            // btnhap
            // 
            this.btnhap.Location = new System.Drawing.Point(323, 305);
            this.btnhap.Name = "btnhap";
            this.btnhap.Size = new System.Drawing.Size(101, 23);
            this.btnhap.TabIndex = 2;
            this.btnhap.Text = "Nhập";
            this.btnhap.UseVisualStyleBackColor = true;
            this.btnhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time:";
            // 
            // tbtime1
            // 
            this.tbtime1.Location = new System.Drawing.Point(84, 81);
            this.tbtime1.Name = "tbtime1";
            this.tbtime1.Size = new System.Drawing.Size(121, 22);
            this.tbtime1.TabIndex = 5;
            this.tbtime1.TextChanged += new System.EventHandler(this.tbtime1_TextChanged);
            // 
            // tbtime2
            // 
            this.tbtime2.Location = new System.Drawing.Point(309, 83);
            this.tbtime2.Name = "tbtime2";
            this.tbtime2.Size = new System.Drawing.Size(121, 22);
            this.tbtime2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Danh sách các  môn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Danh sách đã chọn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kết quả";
            // 
            // BUTReset
            // 
            this.BUTReset.Location = new System.Drawing.Point(323, 351);
            this.BUTReset.Name = "BUTReset";
            this.BUTReset.Size = new System.Drawing.Size(101, 23);
            this.BUTReset.TabIndex = 14;
            this.BUTReset.Text = "Reset";
            this.BUTReset.UseVisualStyleBackColor = true;
            this.BUTReset.Click += new System.EventHandler(this.BUTReset_Click);
            // 
            // BUTThoat
            // 
            this.BUTThoat.CausesValidation = false;
            this.BUTThoat.Location = new System.Drawing.Point(323, 399);
            this.BUTThoat.Name = "BUTThoat";
            this.BUTThoat.Size = new System.Drawing.Size(101, 23);
            this.BUTThoat.TabIndex = 13;
            this.BUTThoat.Text = "Thoát";
            this.BUTThoat.UseVisualStyleBackColor = true;
            this.BUTThoat.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(208, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 28);
            this.button3.TabIndex = 16;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(208, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 28);
            this.button4.TabIndex = 17;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(208, 238);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 28);
            this.button5.TabIndex = 18;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbdanhsach
            // 
            this.lbdanhsach.FormattingEnabled = true;
            this.lbdanhsach.ItemHeight = 16;
            this.lbdanhsach.Items.AddRange(new object[] {
            "Bóng đá",
            "Bóng bàn",
            "Nhảy dù",
            "Bập bên",
            "Cầu lông",
            "Bắn bi"});
            this.lbdanhsach.Location = new System.Drawing.Point(38, 149);
            this.lbdanhsach.Name = "lbdanhsach";
            this.lbdanhsach.Size = new System.Drawing.Size(134, 116);
            this.lbdanhsach.TabIndex = 19;
            // 
            // lbchon
            // 
            this.lbchon.FormattingEnabled = true;
            this.lbchon.ItemHeight = 16;
            this.lbchon.Location = new System.Drawing.Point(290, 150);
            this.lbchon.Name = "lbchon";
            this.lbchon.Size = new System.Drawing.Size(134, 116);
            this.lbchon.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 305);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 117);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbchon);
            this.Controls.Add(this.lbdanhsach);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BUTReset);
            this.Controls.Add(this.BUTThoat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbtime2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbtime1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "bai2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbtime1;
        private System.Windows.Forms.TextBox tbtime2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BUTReset;
        private System.Windows.Forms.Button BUTThoat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lbdanhsach;
        private System.Windows.Forms.ListBox lbchon;
        private System.Windows.Forms.TextBox textBox1;
    }
}
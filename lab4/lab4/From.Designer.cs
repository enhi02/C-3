
namespace lab4
{
    partial class From
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sort = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.AddUSser = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Groupid = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(187, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Người Dùng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 257);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Sort
            // 
            this.Sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Sort.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sort.ForeColor = System.Drawing.Color.Black;
            this.Sort.Location = new System.Drawing.Point(377, 298);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(91, 43);
            this.Sort.TabIndex = 15;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = false;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Edit.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.Black;
            this.Edit.Location = new System.Drawing.Point(542, 228);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(91, 43);
            this.Edit.TabIndex = 0;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // AddUSser
            // 
            this.AddUSser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddUSser.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUSser.ForeColor = System.Drawing.Color.Black;
            this.AddUSser.Location = new System.Drawing.Point(377, 228);
            this.AddUSser.Name = "AddUSser";
            this.AddUSser.Size = new System.Drawing.Size(91, 43);
            this.AddUSser.TabIndex = 2;
            this.AddUSser.Text = "Add User";
            this.AddUSser.UseVisualStyleBackColor = false;
            this.AddUSser.Click += new System.EventHandler(this.AddUSser_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.xoa.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.ForeColor = System.Drawing.Color.Black;
            this.xoa.Location = new System.Drawing.Point(542, 298);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(91, 43);
            this.xoa.TabIndex = 1;
            this.xoa.Text = "Delect";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Group ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "User Name:";
            // 
            // Groupid
            // 
            this.Groupid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groupid.Location = new System.Drawing.Point(460, 135);
            this.Groupid.Name = "Groupid";
            this.Groupid.Size = new System.Drawing.Size(173, 26);
            this.Groupid.TabIndex = 17;
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(460, 182);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(173, 26);
            this.UserName.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 20;
            // 
            // UserID
            // 
            this.UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.Location = new System.Drawing.Point(460, 87);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(173, 26);
            this.UserID.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "UserID :";
            // 
            // From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 391);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Groupid);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.AddUSser);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.label1);
            this.Name = "From";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button AddUSser;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Groupid;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserID;
        private System.Windows.Forms.Label label5;
    }
}


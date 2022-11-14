
namespace bai4
{
    partial class bai4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bai1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bai2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bai3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Open";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bai1ToolStripMenuItem,
            this.bai2ToolStripMenuItem,
            this.bai3ToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // bai1ToolStripMenuItem
            // 
            this.bai1ToolStripMenuItem.Name = "bai1ToolStripMenuItem";
            this.bai1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bai1ToolStripMenuItem.Text = "bai1";
            this.bai1ToolStripMenuItem.Click += new System.EventHandler(this.bai1ToolStripMenuItem_Click);
            // 
            // bai2ToolStripMenuItem
            // 
            this.bai2ToolStripMenuItem.Name = "bai2ToolStripMenuItem";
            this.bai2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bai2ToolStripMenuItem.Text = "bai2";
            this.bai2ToolStripMenuItem.Click += new System.EventHandler(this.bai2ToolStripMenuItem_Click);
            // 
            // bai3ToolStripMenuItem
            // 
            this.bai3ToolStripMenuItem.Name = "bai3ToolStripMenuItem";
            this.bai3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bai3ToolStripMenuItem.Text = "bai3";
            this.bai3ToolStripMenuItem.Click += new System.EventHandler(this.bai3ToolStripMenuItem_Click);
            // 
            // bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "bai4";
            this.Text = "bai4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bai1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bai2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bai3ToolStripMenuItem;
    }
}
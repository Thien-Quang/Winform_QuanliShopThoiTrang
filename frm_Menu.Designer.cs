namespace QLShopQuanAo
{
    partial class frm_Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quầnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.áoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phụKiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinỨngDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslb_timer = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.thôngTinỨngDụngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1247, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.accountSettingToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.newToolStripMenuItem.Text = "Mới";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.closeToolStripMenuItem.Text = "Đóng";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // accountSettingToolStripMenuItem
            // 
            this.accountSettingToolStripMenuItem.Name = "accountSettingToolStripMenuItem";
            this.accountSettingToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.accountSettingToolStripMenuItem.Text = "Tài Khoản";
            this.accountSettingToolStripMenuItem.Click += new System.EventHandler(this.accountSettingToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.quầnToolStripMenuItem,
            this.áoToolStripMenuItem,
            this.phụKiệnToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // quầnToolStripMenuItem
            // 
            this.quầnToolStripMenuItem.Name = "quầnToolStripMenuItem";
            this.quầnToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.quầnToolStripMenuItem.Text = "Quần ";
            this.quầnToolStripMenuItem.Click += new System.EventHandler(this.quầnToolStripMenuItem_Click);
            // 
            // áoToolStripMenuItem
            // 
            this.áoToolStripMenuItem.Name = "áoToolStripMenuItem";
            this.áoToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.áoToolStripMenuItem.Text = "Áo";
            this.áoToolStripMenuItem.Click += new System.EventHandler(this.áoToolStripMenuItem_Click);
            // 
            // phụKiệnToolStripMenuItem
            // 
            this.phụKiệnToolStripMenuItem.Name = "phụKiệnToolStripMenuItem";
            this.phụKiệnToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.phụKiệnToolStripMenuItem.Text = "Phụ Kiện";
            this.phụKiệnToolStripMenuItem.Click += new System.EventHandler(this.phụKiệnToolStripMenuItem_Click);
            // 
            // thôngTinỨngDụngToolStripMenuItem
            // 
            this.thôngTinỨngDụngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemToolStripMenuItem});
            this.thôngTinỨngDụngToolStripMenuItem.Name = "thôngTinỨngDụngToolStripMenuItem";
            this.thôngTinỨngDụngToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.thôngTinỨngDụngToolStripMenuItem.Text = "Thông tin ứng dụng";
            // 
            // xemToolStripMenuItem
            // 
            this.xemToolStripMenuItem.Name = "xemToolStripMenuItem";
            this.xemToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.xemToolStripMenuItem.Text = "Xem";
            this.xemToolStripMenuItem.Click += new System.EventHandler(this.xemToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslb_timer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 890);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1247, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslb_timer
            // 
            this.tslb_timer.Name = "tslb_timer";
            this.tslb_timer.Size = new System.Drawing.Size(0, 16);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLShopQuanAo.Properties.Resources.pexels_pixabay_206359;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1247, 912);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Menu_FormClosing_1);
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quầnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem áoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem phụKiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinỨngDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tslb_timer;
        private System.Windows.Forms.ToolStripMenuItem xemToolStripMenuItem;
    }
}
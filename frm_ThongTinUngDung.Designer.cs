namespace QLShopQuanAo
{
    partial class frm_ThongTinUngDung
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
            this.lb_Thongtinungdung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Thongtinungdung
            // 
            this.lb_Thongtinungdung.AutoSize = true;
            this.lb_Thongtinungdung.BackColor = System.Drawing.Color.Transparent;
            this.lb_Thongtinungdung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Thongtinungdung.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lb_Thongtinungdung.Location = new System.Drawing.Point(0, 0);
            this.lb_Thongtinungdung.Name = "lb_Thongtinungdung";
            this.lb_Thongtinungdung.Size = new System.Drawing.Size(120, 16);
            this.lb_Thongtinungdung.TabIndex = 0;
            this.lb_Thongtinungdung.Text = "Thông tin ứng dụng";
            // 
            // frm_ThongTinUngDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLShopQuanAo.Properties.Resources.pexels_pixabay_206359;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 697);
            this.Controls.Add(this.lb_Thongtinungdung);
            this.Name = "frm_ThongTinUngDung";
            this.Text = "Thông tin ứng dụng";
            this.Load += new System.EventHandler(this.frm_ThongTinUngDung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Thongtinungdung;
    }
}
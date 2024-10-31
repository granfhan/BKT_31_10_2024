namespace BKT_2_31_10_2024
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.them = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ListSP = new System.Windows.Forms.ListBox();
            this.ListCart = new System.Windows.Forms.ListBox();
            this.TongTien = new System.Windows.Forms.TextBox();
            this.TongSL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ThanhToan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(22, 386);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(182, 23);
            this.them.TabIndex = 2;
            this.them.Text = " Thêm vào giỏ hàng";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(229, 386);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(182, 23);
            this.Xoa.TabIndex = 3;
            this.Xoa.Text = " Xóa khỏi giỏ hàng";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "SP1.jpg");
            this.imageList1.Images.SetKeyName(1, "SP2.jpg");
            this.imageList1.Images.SetKeyName(2, "SP3.jpg");
            this.imageList1.Images.SetKeyName(3, "SP4.jpg");
            this.imageList1.Images.SetKeyName(4, "SP5.jpg");
            this.imageList1.Images.SetKeyName(5, "SP6.jpg");
            // 
            // ListSP
            // 
            this.ListSP.FormattingEnabled = true;
            this.ListSP.ItemHeight = 16;
            this.ListSP.Location = new System.Drawing.Point(22, 26);
            this.ListSP.Name = "ListSP";
            this.ListSP.Size = new System.Drawing.Size(287, 308);
            this.ListSP.TabIndex = 4;
            this.ListSP.SelectedIndexChanged += new System.EventHandler(this.ListSP_SelectedIndexChanged);
            // 
            // ListCart
            // 
            this.ListCart.FormattingEnabled = true;
            this.ListCart.ItemHeight = 16;
            this.ListCart.Location = new System.Drawing.Point(598, 26);
            this.ListCart.Name = "ListCart";
            this.ListCart.Size = new System.Drawing.Size(448, 308);
            this.ListCart.TabIndex = 5;
            this.ListCart.SelectedIndexChanged += new System.EventHandler(this.listCart_SelectedIndexChanged);
            // 
            // TongTien
            // 
            this.TongTien.Location = new System.Drawing.Point(691, 352);
            this.TongTien.Name = "TongTien";
            this.TongTien.Size = new System.Drawing.Size(100, 22);
            this.TongTien.TabIndex = 6;
            this.TongTien.Text = " ";
            // 
            // TongSL
            // 
            this.TongSL.Location = new System.Drawing.Point(937, 352);
            this.TongSL.Name = "TongSL";
            this.TongSL.Size = new System.Drawing.Size(100, 22);
            this.TongSL.TabIndex = 7;
            this.TongSL.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = " Tổng Tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(831, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = " Tổng số lượng";
            // 
            // ThanhToan
            // 
            this.ThanhToan.Location = new System.Drawing.Point(601, 386);
            this.ThanhToan.Name = "ThanhToan";
            this.ThanhToan.Size = new System.Drawing.Size(123, 23);
            this.ThanhToan.TabIndex = 10;
            this.ThanhToan.Text = " Thanh Toán";
            this.ThanhToan.UseVisualStyleBackColor = true;
            this.ThanhToan.Click += new System.EventHandler(this.ThanhToan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 504);
            this.Controls.Add(this.ThanhToan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TongSL);
            this.Controls.Add(this.TongTien);
            this.Controls.Add(this.ListCart);
            this.Controls.Add(this.ListSP);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.them);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox ListSP;
        private System.Windows.Forms.ListBox ListCart;
        private System.Windows.Forms.TextBox TongTien;
        private System.Windows.Forms.TextBox TongSL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ThanhToan;
    }
}


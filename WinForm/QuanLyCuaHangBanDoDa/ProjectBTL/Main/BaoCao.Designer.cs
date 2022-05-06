
namespace ProjectBTL.Main
{
    partial class BaoCao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBCKQKD = new FontAwesome.Sharp.IconButton();
            this.btnTHCHPDN = new FontAwesome.Sharp.IconButton();
            this.btnDGCH = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnBCKQKD
            // 
            this.btnBCKQKD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnBCKQKD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBCKQKD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBCKQKD.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnBCKQKD.IconColor = System.Drawing.Color.White;
            this.btnBCKQKD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBCKQKD.IconSize = 40;
            this.btnBCKQKD.Location = new System.Drawing.Point(94, 90);
            this.btnBCKQKD.Name = "btnBCKQKD";
            this.btnBCKQKD.Size = new System.Drawing.Size(170, 53);
            this.btnBCKQKD.TabIndex = 0;
            this.btnBCKQKD.Text = "Báo cáo kết quả kinh doanh";
            this.btnBCKQKD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBCKQKD.UseVisualStyleBackColor = false;
            this.btnBCKQKD.Click += new System.EventHandler(this.btnBCKQKD_Click);
            // 
            // btnTHCHPDN
            // 
            this.btnTHCHPDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnTHCHPDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHCHPDN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTHCHPDN.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.btnTHCHPDN.IconColor = System.Drawing.Color.White;
            this.btnTHCHPDN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTHCHPDN.IconSize = 40;
            this.btnTHCHPDN.Location = new System.Drawing.Point(94, 176);
            this.btnTHCHPDN.Name = "btnTHCHPDN";
            this.btnTHCHPDN.Size = new System.Drawing.Size(170, 53);
            this.btnTHCHPDN.TabIndex = 1;
            this.btnTHCHPDN.Text = "Tổng hợp chi phí doanh nghiệp";
            this.btnTHCHPDN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTHCHPDN.UseVisualStyleBackColor = false;
            this.btnTHCHPDN.Click += new System.EventHandler(this.btnTHCHPDN_Click);
            // 
            // btnDGCH
            // 
            this.btnDGCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnDGCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDGCH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDGCH.IconChar = FontAwesome.Sharp.IconChar.StickyNote;
            this.btnDGCH.IconColor = System.Drawing.Color.White;
            this.btnDGCH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDGCH.IconSize = 40;
            this.btnDGCH.Location = new System.Drawing.Point(94, 271);
            this.btnDGCH.Name = "btnDGCH";
            this.btnDGCH.Size = new System.Drawing.Size(170, 53);
            this.btnDGCH.TabIndex = 2;
            this.btnDGCH.Text = "Đánh giá cửa hàng";
            this.btnDGCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDGCH.UseVisualStyleBackColor = false;
            this.btnDGCH.Click += new System.EventHandler(this.btnDGCH_Click);
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(192)))), ((int)(((byte)(151)))));
            this.Controls.Add(this.btnDGCH);
            this.Controls.Add(this.btnTHCHPDN);
            this.Controls.Add(this.btnBCKQKD);
            this.Name = "BaoCao";
            this.Size = new System.Drawing.Size(720, 420);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBCKQKD;
        private FontAwesome.Sharp.IconButton btnTHCHPDN;
        private FontAwesome.Sharp.IconButton btnDGCH;
    }
}

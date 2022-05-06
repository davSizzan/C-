
namespace ProjectBTL.Main
{
    partial class Home
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.DoanhThuThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SPBanChay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DoanhThu12Thang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPBanChay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThu12Thang)).BeginInit();
            this.SuspendLayout();
            // 
            // DoanhThuThang
            // 
            this.DoanhThuThang.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            this.DoanhThuThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(233)))), ((int)(((byte)(210)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(233)))), ((int)(((byte)(210)))));
            chartArea1.Name = "ChartArea1";
            this.DoanhThuThang.ChartAreas.Add(chartArea1);
            this.DoanhThuThang.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Name = "Legend1";
            this.DoanhThuThang.Legends.Add(legend1);
            this.DoanhThuThang.Location = new System.Drawing.Point(0, 0);
            this.DoanhThuThang.Name = "DoanhThuThang";
            this.DoanhThuThang.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.DarkBlue;
            series1.Legend = "Legend1";
            series1.MarkerSize = 1;
            series1.Name = "Triệu VND";
            series1.ShadowColor = System.Drawing.Color.Red;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.DoanhThuThang.Series.Add(series1);
            this.DoanhThuThang.Size = new System.Drawing.Size(722, 221);
            this.DoanhThuThang.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            title1.Name = "DoanhThuThang";
            title1.Text = "Doanh thu trong tháng ";
            this.DoanhThuThang.Titles.Add(title1);
            // 
            // SPBanChay
            // 
            this.SPBanChay.BorderlineColor = System.Drawing.Color.Black;
            this.SPBanChay.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.SPBanChay.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.SPBanChay.BorderSkin.BorderWidth = 2;
            this.SPBanChay.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.SPBanChay.ChartAreas.Add(chartArea2);
            this.SPBanChay.Dock = System.Windows.Forms.DockStyle.Left;
            legend2.Name = "Legend1";
            this.SPBanChay.Legends.Add(legend2);
            this.SPBanChay.Location = new System.Drawing.Point(0, 221);
            this.SPBanChay.Name = "SPBanChay";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "SP";
            this.SPBanChay.Series.Add(series2);
            this.SPBanChay.Size = new System.Drawing.Size(262, 199);
            this.SPBanChay.TabIndex = 2;
            this.SPBanChay.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title2.Name = "Title1";
            title2.Text = "Top sản phẩm bán chạy";
            this.SPBanChay.Titles.Add(title2);
            // 
            // DoanhThu12Thang
            // 
            this.DoanhThu12Thang.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.DoanhThu12Thang.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised;
            chartArea3.BorderColor = System.Drawing.Color.DimGray;
            chartArea3.Name = "ChartArea1";
            this.DoanhThu12Thang.ChartAreas.Add(chartArea3);
            this.DoanhThu12Thang.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.DoanhThu12Thang.Legends.Add(legend3);
            this.DoanhThu12Thang.Location = new System.Drawing.Point(262, 221);
            this.DoanhThu12Thang.Name = "DoanhThu12Thang";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Triệu VND";
            this.DoanhThu12Thang.Series.Add(series3);
            this.DoanhThu12Thang.Size = new System.Drawing.Size(460, 199);
            this.DoanhThu12Thang.TabIndex = 3;
            this.DoanhThu12Thang.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title3.Name = "DoanhThu12Thang";
            title3.Text = "Doanh thu 12 tháng gần nhất";
            this.DoanhThu12Thang.Titles.Add(title3);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(233)))), ((int)(((byte)(210)))));
            this.Controls.Add(this.DoanhThu12Thang);
            this.Controls.Add(this.SPBanChay);
            this.Controls.Add(this.DoanhThuThang);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(722, 420);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPBanChay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThu12Thang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart DoanhThuThang;
        private System.Windows.Forms.DataVisualization.Charting.Chart SPBanChay;
        private System.Windows.Forms.DataVisualization.Charting.Chart DoanhThu12Thang;
    }
}

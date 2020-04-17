namespace DipPlusProj
{
    partial class NetWorthPieChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.piechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).BeginInit();
            this.SuspendLayout();
            // 
            // piechart
            // 
            chartArea1.Name = "ChartArea1";
            this.piechart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.piechart.Legends.Add(legend1);
            this.piechart.Location = new System.Drawing.Point(0, 0);
            this.piechart.Name = "piechart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.piechart.Series.Add(series1);
            this.piechart.Size = new System.Drawing.Size(715, 469);
            this.piechart.TabIndex = 0;
            this.piechart.Text = "chart1";
            // 
            // NetWorthPieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 469);
            this.Controls.Add(this.piechart);
            this.Name = "NetWorthPieChart";
            this.Text = "NetWorthPieChart";
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart piechart;
    }
}
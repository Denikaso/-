namespace lab7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.linearSearchChart = new LiveCharts.WinForms.CartesianChart();
            this.barrierLinearSearchChart = new LiveCharts.WinForms.CartesianChart();
            this.bubbleSortChart = new LiveCharts.WinForms.CartesianChart();
            this.selectionSortChart = new LiveCharts.WinForms.CartesianChart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linearSearchChart
            // 
            this.linearSearchChart.Location = new System.Drawing.Point(3, 3);
            this.linearSearchChart.Name = "linearSearchChart";
            this.linearSearchChart.Size = new System.Drawing.Size(487, 357);
            this.linearSearchChart.TabIndex = 9;
            this.linearSearchChart.Text = "cartesianChart1";
            // 
            // barrierLinearSearchChart
            // 
            this.barrierLinearSearchChart.Location = new System.Drawing.Point(496, 3);
            this.barrierLinearSearchChart.Name = "barrierLinearSearchChart";
            this.barrierLinearSearchChart.Size = new System.Drawing.Size(487, 357);
            this.barrierLinearSearchChart.TabIndex = 10;
            this.barrierLinearSearchChart.Text = "cartesianChart2";
            // 
            // bubbleSortChart
            // 
            this.bubbleSortChart.Location = new System.Drawing.Point(3, 366);
            this.bubbleSortChart.Name = "bubbleSortChart";
            this.bubbleSortChart.Size = new System.Drawing.Size(487, 348);
            this.bubbleSortChart.TabIndex = 11;
            this.bubbleSortChart.Text = "cartesianChart3";
            // 
            // selectionSortChart
            // 
            this.selectionSortChart.Location = new System.Drawing.Point(496, 366);
            this.selectionSortChart.Name = "selectionSortChart";
            this.selectionSortChart.Size = new System.Drawing.Size(487, 348);
            this.selectionSortChart.TabIndex = 12;
            this.selectionSortChart.Text = "cartesianChart4";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.selectionSortChart, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bubbleSortChart, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.barrierLinearSearchChart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.linearSearchChart, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 726);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 726);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private LiveCharts.WinForms.CartesianChart linearSearchChart;
        private LiveCharts.WinForms.CartesianChart barrierLinearSearchChart;
        private LiveCharts.WinForms.CartesianChart bubbleSortChart;
        private LiveCharts.WinForms.CartesianChart selectionSortChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}


namespace tpm_plotter
{
    partial class main_form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.start_button = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stop_button = new System.Windows.Forms.Button();
            this.sample_timer = new System.Windows.Forms.Timer(this.components);
            this.settings_button = new System.Windows.Forms.Button();
            this.std_check_box = new System.Windows.Forms.CheckBox();
            this.AverageUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Avg_clear_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.delta2_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.delta1_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ch2_textBox = new System.Windows.Forms.TextBox();
            this.avg_result_label_ch2 = new System.Windows.Forms.Label();
            this.ch1_textBox = new System.Windows.Forms.TextBox();
            this.avg_result_label_ch1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AverageUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont)));
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            chartArea1.AxisX.LabelStyle.Format = "HH:mm:sss";
            chartArea1.AxisX.LabelStyle.Interval = 2D;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            chartArea1.AxisY.LabelStyle.Format = "0.000";
            chartArea1.AxisY.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 93.29787F;
            chartArea1.InnerPlotPosition.Width = 93.34055F;
            chartArea1.InnerPlotPosition.X = 6.659447F;
            chartArea1.InnerPlotPosition.Y = 3.35106F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 35);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.Gray;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.MediumBlue;
            series1.Legend = "Legend1";
            series1.Name = "CH1 (RHCP)";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.DarkRed;
            series2.Legend = "Legend1";
            series2.Name = "CH2 (LHCP)";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            series3.Legend = "Legend1";
            series3.Name = "CH1 std";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series3.YValuesPerPoint = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            series4.Legend = "Legend1";
            series4.Name = "CH2 std";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series4.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(850, 298);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.MouseEnter += new System.EventHandler(this.chart1_MouseEnter);
            this.chart1.MouseLeave += new System.EventHandler(this.chart1_MouseLeave);
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(5, 9);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(38, 20);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 336);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(874, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(49, 9);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(38, 20);
            this.stop_button.TabIndex = 3;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // sample_timer
            // 
            this.sample_timer.Tick += new System.EventHandler(this.sample_timer_Tick);
            // 
            // settings_button
            // 
            this.settings_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_button.Location = new System.Drawing.Point(117, 8);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(61, 23);
            this.settings_button.TabIndex = 4;
            this.settings_button.Text = "Settings";
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // std_check_box
            // 
            this.std_check_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.std_check_box.AutoSize = true;
            this.std_check_box.Location = new System.Drawing.Point(16, 11);
            this.std_check_box.Name = "std_check_box";
            this.std_check_box.Size = new System.Drawing.Size(83, 17);
            this.std_check_box.TabIndex = 12;
            this.std_check_box.Text = "Plot StdDev";
            this.std_check_box.UseVisualStyleBackColor = true;
            this.std_check_box.CheckedChanged += new System.EventHandler(this.std_check_box_CheckedChanged);
            // 
            // AverageUpDown
            // 
            this.AverageUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AverageUpDown.Location = new System.Drawing.Point(131, 11);
            this.AverageUpDown.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.AverageUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AverageUpDown.Name = "AverageUpDown";
            this.AverageUpDown.Size = new System.Drawing.Size(52, 20);
            this.AverageUpDown.TabIndex = 13;
            this.AverageUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AverageUpDown.ValueChanged += new System.EventHandler(this.AverageUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Avg:";
            // 
            // Avg_clear_button
            // 
            this.Avg_clear_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Avg_clear_button.Location = new System.Drawing.Point(189, 9);
            this.Avg_clear_button.Name = "Avg_clear_button";
            this.Avg_clear_button.Size = new System.Drawing.Size(51, 23);
            this.Avg_clear_button.TabIndex = 15;
            this.Avg_clear_button.Text = "Avg Clr";
            this.Avg_clear_button.UseVisualStyleBackColor = true;
            this.Avg_clear_button.Click += new System.EventHandler(this.Avg_clear_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Avg_clear_button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AverageUpDown);
            this.groupBox1.Controls.Add(this.stop_button);
            this.groupBox1.Controls.Add(this.start_button);
            this.groupBox1.Location = new System.Drawing.Point(7, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 34);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.std_check_box);
            this.groupBox2.Controls.Add(this.settings_button);
            this.groupBox2.Location = new System.Drawing.Point(678, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 34);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.delta2_textBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.delta1_textBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.ch2_textBox);
            this.groupBox3.Controls.Add(this.avg_result_label_ch2);
            this.groupBox3.Controls.Add(this.ch1_textBox);
            this.groupBox3.Controls.Add(this.avg_result_label_ch1);
            this.groupBox3.Location = new System.Drawing.Point(261, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(399, 34);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // delta2_textBox
            // 
            this.delta2_textBox.Location = new System.Drawing.Point(335, 11);
            this.delta2_textBox.Name = "delta2_textBox";
            this.delta2_textBox.Size = new System.Drawing.Size(60, 20);
            this.delta2_textBox.TabIndex = 24;
            this.delta2_textBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "delta 2:";
            // 
            // delta1_textBox
            // 
            this.delta1_textBox.Location = new System.Drawing.Point(230, 10);
            this.delta1_textBox.Name = "delta1_textBox";
            this.delta1_textBox.Size = new System.Drawing.Size(60, 20);
            this.delta1_textBox.TabIndex = 22;
            this.delta1_textBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "delta 1:";
            // 
            // ch2_textBox
            // 
            this.ch2_textBox.Location = new System.Drawing.Point(126, 10);
            this.ch2_textBox.Name = "ch2_textBox";
            this.ch2_textBox.Size = new System.Drawing.Size(60, 20);
            this.ch2_textBox.TabIndex = 20;
            this.ch2_textBox.Text = "0";
            // 
            // avg_result_label_ch2
            // 
            this.avg_result_label_ch2.AutoSize = true;
            this.avg_result_label_ch2.Location = new System.Drawing.Point(99, 13);
            this.avg_result_label_ch2.Name = "avg_result_label_ch2";
            this.avg_result_label_ch2.Size = new System.Drawing.Size(31, 13);
            this.avg_result_label_ch2.TabIndex = 1;
            this.avg_result_label_ch2.Text = "CH2:";
            // 
            // ch1_textBox
            // 
            this.ch1_textBox.Location = new System.Drawing.Point(33, 10);
            this.ch1_textBox.Name = "ch1_textBox";
            this.ch1_textBox.Size = new System.Drawing.Size(60, 20);
            this.ch1_textBox.TabIndex = 19;
            this.ch1_textBox.Text = "0";
            // 
            // avg_result_label_ch1
            // 
            this.avg_result_label_ch1.AutoSize = true;
            this.avg_result_label_ch1.Location = new System.Drawing.Point(6, 13);
            this.avg_result_label_ch1.Name = "avg_result_label_ch1";
            this.avg_result_label_ch1.Size = new System.Drawing.Size(31, 13);
            this.avg_result_label_ch1.TabIndex = 0;
            this.avg_result_label_ch1.Text = "CH1:";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 358);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_form";
            this.Text = "Total Power Plotter v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AverageUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Timer sample_timer;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.CheckBox std_check_box;
        private System.Windows.Forms.NumericUpDown AverageUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Avg_clear_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label avg_result_label_ch2;
        private System.Windows.Forms.Label avg_result_label_ch1;
        private System.Windows.Forms.TextBox ch2_textBox;
        private System.Windows.Forms.TextBox ch1_textBox;
        private System.Windows.Forms.TextBox delta2_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox delta1_textBox;
        private System.Windows.Forms.Label label2;
    }
}


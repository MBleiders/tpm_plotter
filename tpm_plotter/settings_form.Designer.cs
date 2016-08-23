namespace tpm_plotter
{
    partial class settings_form
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
            this.ip_textBox = new System.Windows.Forms.TextBox();
            this.port_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.done_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sample_period_box = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.disp_buf_len = new System.Windows.Forms.NumericUpDown();
            this.disp_len_s = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.unit_listBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.sample_period_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disp_buf_len)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ip_textBox
            // 
            this.ip_textBox.Location = new System.Drawing.Point(77, 12);
            this.ip_textBox.Name = "ip_textBox";
            this.ip_textBox.Size = new System.Drawing.Size(89, 20);
            this.ip_textBox.TabIndex = 0;
            this.ip_textBox.Text = "192.168.0.101";
            // 
            // port_textBox
            // 
            this.port_textBox.Location = new System.Drawing.Point(77, 38);
            this.port_textBox.Name = "port_textBox";
            this.port_textBox.Size = new System.Drawing.Size(41, 20);
            this.port_textBox.TabIndex = 1;
            this.port_textBox.Text = "7176";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(153, 8);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(40, 21);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // done_label
            // 
            this.done_label.AutoSize = true;
            this.done_label.Location = new System.Drawing.Point(108, 13);
            this.done_label.Name = "done_label";
            this.done_label.Size = new System.Drawing.Size(43, 13);
            this.done_label.TabIndex = 5;
            this.done_label.Text = "            ";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(9, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 7);
            this.label3.TabIndex = 6;
            this.label3.Text = "MB (c) VIRAC 2016";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "T Sample ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ms";
            // 
            // sample_period_box
            // 
            this.sample_period_box.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sample_period_box.Location = new System.Drawing.Point(77, 64);
            this.sample_period_box.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.sample_period_box.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.sample_period_box.Name = "sample_period_box";
            this.sample_period_box.Size = new System.Drawing.Size(63, 20);
            this.sample_period_box.TabIndex = 10;
            this.sample_period_box.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.sample_period_box.ValueChanged += new System.EventHandler(this.sample_period_box_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Disp buf len";
            // 
            // disp_buf_len
            // 
            this.disp_buf_len.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.disp_buf_len.Location = new System.Drawing.Point(77, 93);
            this.disp_buf_len.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.disp_buf_len.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.disp_buf_len.Name = "disp_buf_len";
            this.disp_buf_len.Size = new System.Drawing.Size(63, 20);
            this.disp_buf_len.TabIndex = 12;
            this.disp_buf_len.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.disp_buf_len.ValueChanged += new System.EventHandler(this.disp_buf_len_ValueChanged);
            // 
            // disp_len_s
            // 
            this.disp_len_s.AutoSize = true;
            this.disp_len_s.Location = new System.Drawing.Point(146, 95);
            this.disp_len_s.Name = "disp_len_s";
            this.disp_len_s.Size = new System.Drawing.Size(45, 13);
            this.disp_len_s.TabIndex = 13;
            this.disp_len_s.Text = "or 100 s";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.done_label);
            this.groupBox1.Controls.Add(this.save_button);
            this.groupBox1.Location = new System.Drawing.Point(12, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 35);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Meas Unit";
            // 
            // unit_listBox
            // 
            this.unit_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.unit_listBox.FormattingEnabled = true;
            this.unit_listBox.Items.AddRange(new object[] {
            "dBm",
            "uW",
            "Raw"});
            this.unit_listBox.Location = new System.Drawing.Point(77, 120);
            this.unit_listBox.Name = "unit_listBox";
            this.unit_listBox.Size = new System.Drawing.Size(63, 43);
            this.unit_listBox.TabIndex = 12;
            // 
            // settings_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 224);
            this.Controls.Add(this.unit_listBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.disp_len_s);
            this.Controls.Add(this.disp_buf_len);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sample_period_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port_textBox);
            this.Controls.Add(this.ip_textBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settings_form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settings_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sample_period_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disp_buf_len)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip_textBox;
        private System.Windows.Forms.TextBox port_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label done_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown sample_period_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown disp_buf_len;
        private System.Windows.Forms.Label disp_len_s;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox unit_listBox;
    }
}
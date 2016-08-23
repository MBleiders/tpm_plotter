using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpm_plotter
{
    public partial class settings_form : Form
    {

        public settings_form()
        {
            InitializeComponent();
        }

        private void update_disp_len_str()
        {
            double disp_len = (double)disp_buf_len.Value * (double)sample_period_box.Value / 1000;
            disp_len_s.Text = "or " + disp_len.ToString() + " s";
        }

        private void settings_form_Load(object sender, EventArgs e)
        {
            //main_form mainForm = new main_form();

            ip_textBox.Text = main_form.ip_address;
            port_textBox.Text = main_form.port;
            sample_period_box.Value = main_form.sample_period;

            if (main_form.plotting_active)
            {
                unit_listBox.Enabled = false;
                disp_buf_len.Enabled = false;
            }
                
            else
            {
                unit_listBox.Enabled = true;
                disp_buf_len.Enabled = true;
            }
                
            disp_buf_len.Value = main_form.x_point_count;

            update_disp_len_str();
        }

        private void save_button_Click(object sender, EventArgs e)
        {

            main_form.ip_address = ip_textBox.Text;
            main_form.port = port_textBox.Text;
            main_form.sample_period = Convert.ToInt32(sample_period_box.Value);
            main_form.set_sample_period();

            if (main_form.plotting_active == false)//only update if not using the buffer
            {
                main_form.x_point_count = Convert.ToInt32(disp_buf_len.Value);

                if (unit_listBox.GetItemText(unit_listBox.SelectedItem) != "")
                main_form.meas_unit = unit_listBox.GetItemText(unit_listBox.SelectedItem);

                main_form.disp_changed = true;
            }

            done_label.Text = "Done!";
            timer1.Start();  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            done_label.Text = "";
        }

        private void sample_period_box_ValueChanged(object sender, EventArgs e)
        {
            update_disp_len_str();
        }

        private void disp_buf_len_ValueChanged(object sender, EventArgs e)
        {
            update_disp_len_str();
        }
    }
}

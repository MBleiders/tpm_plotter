using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Windows.Forms.DataVisualization.Charting;

namespace tpm_plotter
{
    public partial class main_form : Form
    {
        System.Net.Sockets.TcpClient clientSocket = null;

        byte[] read_buffer = new byte[40];

        //double x = 1000;
        //Random rnd = new Random();

        //static int read_flag = 0;
        static string returndata;

        public static string ip_address = "192.168.0.122";
        //public static string ip_address = "10.0.3.136"; //test
        public static string port = "7176";

        public static string meas_unit = "dBm";

        public static int sample_period = 100;

        public static bool plot_std = false;
        public static bool plotting_active = false;
        public static bool disp_changed = false;

        static double yaxis_raw_max = 16777215;
        static double yaxis_raw_min = 0;
        static double zoom_step_raw = 10;

        static double yaxis_dBm_max = 15;
        static double yaxis_dBm_min = -50;
        static double zoom_step_dBm = 0.0001;

        static double yaxis_uW_max = 31623;
        static double yaxis_uW_min = 0.01;
        static double zoom_step_uW = 0.0001;

        //default to dBm
        private double yaxis_max = yaxis_dBm_max;
        private double yaxis_min = yaxis_dBm_min;
        private double min_y_zoom_step = zoom_step_dBm;

        static double x_interval_seconds = 30;
        public static int x_point_count = 1000;
        
        static int average_count_default = 1;
        private double[] ch0_buffer = new double[average_count_default];
        private double[] ch1_buffer = new double[average_count_default];
        private int avg_current_count = 0;

        static string CH1_NAME = "CH1 ";
        static string CH2_NAME = "CH2 ";

        private static main_form _instance;

        private double y_cursor_current_value = yaxis_dBm_min;

        public main_form()
        {      
            InitializeComponent();
            this.MouseWheel += new MouseEventHandler(chart1_MouseWheel);

            _instance = this;
        }

        public static void set_sample_period()//this function can be called from other forms
        {
            if (_instance.sample_timer.Enabled)
            {
                _instance.sample_timer.Stop();
                _instance.sample_timer.Interval = sample_period;
                _instance.sample_timer.Start();
            }
            else
                _instance.sample_timer.Interval = sample_period;
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            clientSocket = new System.Net.Sockets.TcpClient();

            start_button.Enabled = false;
            stop_button.Enabled = true;

            toolStripStatusLabel1.Text = "Connecting to " + ip_address + ":" + port;
            statusStrip1.Refresh();


            var result = clientSocket.BeginConnect(ip_address, Convert.ToInt32(port), null, null);

            var success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(3));

            if (success && clientSocket.Connected)
            {
                // we have connected
                clientSocket.EndConnect(result);

                toolStripStatusLabel1.Text = "Connected!";
                statusStrip1.Refresh();

                sample_timer.Start();

                plotting_active = true;

                //Comment this if stop-start without buffer clear is needed. 
                //If time diff between now and last value gets large, x labels get messy (X time interval is always fixed)
                disp_changed = true;

                //clear buffers only if length changed via settings menu. This allows to stop/start graph without unnecessary buffer clearing
                if (disp_changed)
                {
                    disp_changed = false;
                    chart1.Series[0].Points.Clear();
                    chart1.Series[1].Points.Clear();
                    chart1.Series[2].Points.Clear();
                    chart1.Series[3].Points.Clear();

                    switch (meas_unit)
                    {
                        case "dBm":
                            yaxis_max = yaxis_dBm_max;
                            yaxis_min = yaxis_dBm_min;
                            min_y_zoom_step = zoom_step_dBm;

                            chart1.Series[0].Name = CH1_NAME + "(dBm)";
                            chart1.Series[1].Name = CH2_NAME + "(dBm)";
                            break;
                        case "uW":
                            yaxis_max = yaxis_uW_max;
                            yaxis_min = yaxis_uW_min;
                            min_y_zoom_step = zoom_step_uW;

                            chart1.Series[0].Name = CH1_NAME + "(uW)";
                            chart1.Series[1].Name = CH2_NAME + "(uW)";
                            break;
                        case "Raw":
                            yaxis_max = yaxis_raw_max;
                            yaxis_min = yaxis_raw_min;
                            min_y_zoom_step = zoom_step_raw;

                            chart1.Series[0].Name = CH1_NAME + "(ADC counts)";
                            chart1.Series[1].Name = CH2_NAME + "(ADC counts)";
                            break;
                        default:
                        break;
                    }

                    chart1.ChartAreas[0].AxisY.Maximum = yaxis_max;
                    chart1.ChartAreas[0].AxisY.Minimum = yaxis_min;

                    chart1.ChartAreas[0].AxisY.ScaleView.Zoom(yaxis_min, yaxis_max);

                }
     
            }
            else
            {
                start_button.Enabled = true;
                stop_button.Enabled = false;
                toolStripStatusLabel1.Text = "Could not connect to " + ip_address + ":" + port;
                statusStrip1.Refresh();
            }
            //msg(returndata);
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            start_button.Enabled = true;
            stop_button.Enabled = false;

            plotting_active = false;

            sample_timer.Stop();

            try
            {
                clientSocket.GetStream().Close();
                clientSocket.Close();
            }
            catch (Exception exp)
            {
            }
        } 

        private void Form1_Load(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text = "";
            statusStrip1.Refresh();
            stop_button.Enabled = false;
            plotting_active = false;

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            chart1.ChartAreas[0].AxisY.Maximum = yaxis_max;
            chart1.ChartAreas[0].AxisY.Minimum = yaxis_min;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

            //chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            //chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;

            //chart1.ChartAreas[0].CursorX.Interval = 0;
            chart1.ChartAreas[0].CursorY.Interval = 0;
            //chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            chart1.ChartAreas[0].CursorX.LineColor = Color.Black;
            chart1.ChartAreas[0].CursorX.LineWidth = 1;
            chart1.ChartAreas[0].CursorX.LineDashStyle = ChartDashStyle.Dot;
            chart1.ChartAreas[0].CursorX.Interval = 0;

            chart1.ChartAreas[0].CursorY.LineColor = Color.Black;
            chart1.ChartAreas[0].CursorY.LineWidth = 2;
            chart1.ChartAreas[0].CursorY.LineDashStyle = ChartDashStyle.Dot;
            chart1.ChartAreas[0].CursorY.Interval = 0;


            chart1.Series[0].IsXValueIndexed = false;
            chart1.Series[1].IsXValueIndexed = false;

            chart1.ChartAreas[0].AxisX.LabelStyle.IntervalType = DateTimeIntervalType.Seconds;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = x_interval_seconds;
            chart1.ChartAreas[0].AxisX.MajorGrid.IntervalType = DateTimeIntervalType.Seconds;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = x_interval_seconds;

            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = true;
            chart1.ChartAreas[0].AxisX.MinorGrid.IntervalType = DateTimeIntervalType.Seconds;
            chart1.ChartAreas[0].AxisX.MinorGrid.Interval = x_interval_seconds/2;

            chart1.Series[2].Color = Color.FromArgb(32, 0, 0, 255); //transparent blue
            chart1.Series[3].Color = Color.FromArgb(32, 255, 0, 0); //transparent red

            chart1.Series[2].Enabled = false;
            chart1.Series[3].Enabled = false;

            chart1.Series[0].Name = CH1_NAME + "(dBm)";
            chart1.Series[1].Name = CH2_NAME + "(dBm)";

            sample_timer.Interval = sample_period;

            AverageUpDown.Value = average_count_default;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sample_timer.Stop();

                try
                {
                    clientSocket.GetStream().Close();
                    clientSocket.Close();
                }
                catch (Exception exp)
                {
                    Console.Write(exp.ToString());
                }
        }

        private void end_comunication()
        {
            this.BeginInvoke((Action)(() => toolStripStatusLabel1.Text = "Read failed. Ending activity"));
            this.BeginInvoke((Action)(() => statusStrip1.Refresh()));

            this.BeginInvoke((Action)(() => start_button.Enabled = true));
            this.BeginInvoke((Action)(() => stop_button.Enabled = false));
            this.BeginInvoke((Action)(() => plotting_active = false));

                try
                {
                    clientSocket.GetStream().Close();
                    clientSocket.Close();
                }
                catch (Exception exp)
                {
                    Console.Write(exp.ToString());                          
                }
        }

        private void SocketReadCallback(IAsyncResult ar)//socket read finish callback
        {
            if(clientSocket.Connected)
            {
                NetworkStream myNetworkStream = clientSocket.GetStream();

                int numberOfBytesRead;

                try
                {
                    numberOfBytesRead = myNetworkStream.EndRead(ar);
                }
                catch (Exception exp)
                {
                    Console.Write(exp.ToString());

                    end_comunication();
                    return;
                }

                //this.BeginInvoke((Action)(() => sample_timer.Start()));//if came this far, sapmple timer can be resumed

                //data processing and plotting ahead......................
                    if (numberOfBytesRead > 0)
                    {
                        returndata = Encoding.ASCII.GetString(read_buffer, 0, numberOfBytesRead);
                        //read_flag = 1;

                        this.BeginInvoke((Action)(() => toolStripStatusLabel1.Text = returndata));
                        this.BeginInvoke((Action)(() => statusStrip1.Refresh()));

                        int space_char_count = returndata.Length - returndata.Replace(" ", "").Length;

                        if (space_char_count == 3)//only if string contains 3 spaces
                        {
                            string[] split_data = returndata.Split(' ');

                            double ch0_result;
                            double ch1_result;

                            if (double.TryParse(split_data[0], out ch0_result) == false)
                            {
                                Console.Write("Double.TryParse() on CH0 failed\n");
                                return;
                            }

                            if (double.TryParse(split_data[2], out ch1_result) == false)
                            {
                                Console.Write("Double.TryParse() o CH1 failed\n");
                                return;
                            }

                            double std_result;
                            double[] std_array = new double[2];

                            if (double.TryParse(split_data[1], out std_result) == false)
                            {
                                Console.Write("Double.TryParse() o CH1_STD failed\n");
                                return;
                            }

                            ////CH1
                            double std_result2;
                            double[] std_array2 = new double[2];
                            if (double.TryParse(split_data[3], out std_result2) == false)
                            {
                                Console.Write("Double.TryParse() o CH2_STD failed\n");
                                return;
                            }
                            ////////////////////////////Average part START
                                //buffer last "average_count" values
                                Array.Copy(ch0_buffer, 1, ch0_buffer, 0, ch0_buffer.Length - 1);//shift array to the left
                                Array.Copy(ch1_buffer, 1, ch1_buffer, 0, ch1_buffer.Length - 1);
                                ch0_buffer[ch0_buffer.Length - 1] = ch0_result;//new value in last position
                                ch1_buffer[ch1_buffer.Length - 1] = ch1_result;

                                double avg_sum_ch0 = 0;
                                double avg_sum_ch1 = 0;
                               
                                if (avg_current_count < ch0_buffer.Length)
                                    avg_current_count++;

                                for (int i = (ch0_buffer.Length - 1); i >= (ch0_buffer.Length - avg_current_count); i--)
                                {
                                    avg_sum_ch0 += ch0_buffer[i];
                                    avg_sum_ch1 += ch1_buffer[i];
                                }

                                ch0_result = avg_sum_ch0 / avg_current_count;
                                ch1_result = avg_sum_ch1 / avg_current_count;
                            ////////////////////////////Average part END

                            ////////////////////////////Unit conversion part

                                string double_precision_str = "F0";

                                switch (meas_unit)
                                {
                                    case "dBm":
                                        ch0_result = raw_to_dBm(ch0_result, 1);
                                        ch1_result = raw_to_dBm(ch1_result, 2);

                                        std_result = raw_delta_to_dB(std_result, 1);
                                        std_result2 = raw_delta_to_dB(std_result2, 2);

                                        double_precision_str = "F5";
                                        break;
                                    case "uW":
                                        ch0_result = raw_to_dBm(ch0_result, 1);
                                        ch0_result = dBm_to_uW(ch0_result, 1);                                        
                                        ch1_result = raw_to_dBm(ch1_result, 2);
                                        ch1_result = dBm_to_uW(ch1_result, 2);
                                        
                                        std_result = raw_to_dBm(std_result, 1);
                                        std_result = dBm_to_uW(std_result, 1);
                                        std_result2 = raw_to_dBm(std_result2, 2);
                                        std_result2 = dBm_to_uW(std_result2, 2);

                                        double_precision_str = "F5";
                                        break;
                                    case "Raw":
                                        //its already raw
                                        double_precision_str = "F0";
                                        break;
                                    default:
                                        break;
                                }
                            ///////////////////////////////////////////////
                                double delta_1 = ch0_result - chart1.ChartAreas[0].CursorY.Position;

                                if (!Double.IsNaN(delta_1))
                                    this.BeginInvoke((Action)(() => delta1_textBox.Text = delta_1.ToString(double_precision_str)));
                                else
                                    this.BeginInvoke((Action)(() => delta1_textBox.Text = "- -"));
                                
                                double delta_2 = ch1_result - chart1.ChartAreas[0].CursorY.Position;

                                if (!Double.IsNaN(delta_2))
                                    this.BeginInvoke((Action)(() => delta2_textBox.Text = delta_2.ToString(double_precision_str)));
                                else
                                    this.BeginInvoke((Action)(() => delta2_textBox.Text = "- -"));             
                            ///////////////////////////////////////////////
                                //show avg result
                                this.BeginInvoke((Action)(() => ch1_textBox.Text = ch0_result.ToString(double_precision_str)));
                                this.BeginInvoke((Action)(() => ch2_textBox.Text = ch1_result.ToString(double_precision_str)));
                            ///////////////////////////////////////////////

                            //double ch0_result = Convert.ToDouble(split_data[0]);
                            //double ch1_result = Convert.ToDouble(split_data[2]);
                            System.DateTime x = System.DateTime.Now;

                            DataPoint dp1 = new DataPoint(x.ToOADate(), ch0_result);
                            DataPoint dp2 = new DataPoint(x.ToOADate(), ch1_result);

                            //this is needed to acess controls created in main thread
                            this.BeginInvoke((Action)(() => chart1.Series[0].Points.Add(dp1)));
                            this.BeginInvoke((Action)(() => chart1.Series[1].Points.Add(dp2)));

                            if (chart1.Series[0].Points.Count > x_point_count - 1)
                            {
                                this.BeginInvoke((Action)(() => chart1.Series[0].Points.RemoveAt(0)));
                                this.BeginInvoke((Action)(() => chart1.Series[1].Points.RemoveAt(0)));
                            }

                            ////////////////////////////STD part START <---calculated even if plotting dissabled
                            ////CH0

                            std_array[0] = ch0_result + std_result;
                            std_array[1] = ch0_result - std_result;

                            DataPoint dp3 = new DataPoint(x.ToOADate(), std_array);

                            this.BeginInvoke((Action)(() => chart1.Series[2].Points.Add(dp3)));
                            if (chart1.Series[2].Points.Count > x_point_count - 1)
                            {
                                this.BeginInvoke((Action)(() => chart1.Series[2].Points.RemoveAt(0)));
                            }

                            std_array2[0] = ch1_result + std_result2;
                            std_array2[1] = ch1_result - std_result2;

                            DataPoint dp4 = new DataPoint(x.ToOADate(), std_array2);

                            this.BeginInvoke((Action)(() => chart1.Series[3].Points.Add(dp4)));
                            if (chart1.Series[3].Points.Count > x_point_count - 1)
                            {
                                this.BeginInvoke((Action)(() => chart1.Series[3].Points.RemoveAt(0)));
                            }
                            ////////////////////////////STD part END

                            this.BeginInvoke((Action)(() => chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points[0].XValue));
                            this.BeginInvoke((Action)(() => chart1.ChartAreas[0].AxisX.Maximum = chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].XValue));

                            this.BeginInvoke((Action)(() => chart1.Update()));
                         
                        }
                        else
                            Console.Write("Bad string: " + returndata + "\n");
                    }
            }
        }

        private void sample_timer_Tick(object sender, EventArgs e)
        {
            sample_timer.Stop();//prevents executing again, is last one was not finished

            NetworkStream myNetworkStream = clientSocket.GetStream();

            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("tpm");

                if (clientSocket.Connected)
                {

                    try
                    {
                        myNetworkStream.Write(outStream, 0, outStream.Length);
                        myNetworkStream.Flush();

                        // Begin the asynchronous Read operation.
                        //This greatly reduces lagging when moving window around
                        myNetworkStream.BeginRead(read_buffer, 0, (int)read_buffer.Length, new System.AsyncCallback(SocketReadCallback), null);
                    }
                    catch(Exception exp)
                    {
                        Console.Write(exp.ToString());
                        end_comunication();
                        return;
                    }

                    sample_timer.Start();
                }
                else
                {
                    end_comunication();
                }
        }

        private void settings_button_Click(object sender, EventArgs e)
        {

            settings_form settingsForm = new settings_form();
            // Show the settings form
            settingsForm.ShowDialog();
        }

        private void chart1_MouseEnter(object sender, EventArgs e)
        {
            if (!chart1.Focused)
                chart1.Focus(); 
        }

        private void chart1_MouseLeave(object sender, EventArgs e)
        {
            if (chart1.Focused)
                chart1.Parent.Focus(); 
        }


        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                 double yMin = chart1.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                 double yMax = chart1.ChartAreas[0].AxisY.ScaleView.ViewMaximum;

                 if ((yMin >= yaxis_min) && (yMax <= yaxis_max))
                {
                    if (e.Delta < 0)//zoom out
                    {

                        double posYStart = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) - (yMax - yMin)*1.25;
                        double posYFinish = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) + (yMax - yMin)*1.25;

                        if (posYStart < yaxis_min)
                            posYStart = yaxis_min;

                        if (posYFinish > yaxis_max)
                            posYFinish = yaxis_max;

                            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(posYStart, posYFinish);
                        //else
                            //chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset();
                    }
                    else if ((e.Delta > 0) && ((yMax - yMin) > min_y_zoom_step))//zoom in
                    {

                        double posYStart = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                        double posYFinish = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                        //if ((posYFinish > yaxis_min) && (posYStart < yaxis_max))
                        if ((posYFinish - posYStart) > min_y_zoom_step)
                        chart1.ChartAreas[0].AxisY.ScaleView.Zoom(posYStart, posYFinish);
                    }
                }
            }
            catch { }
        }

        private void std_check_box_CheckedChanged(object sender, EventArgs e)
        {
            if(std_check_box.Checked)
            {
                chart1.Series[2].Enabled = true;
                chart1.Series[3].Enabled = true;
            }
            else
            {
                chart1.Series[2].Enabled = false;
                chart1.Series[3].Enabled = false;
            }
        }

        private void Avg_clear_button_Click(object sender, EventArgs e)
        {
            Array.Clear(ch0_buffer, 0, ch0_buffer.Length);
            Array.Clear(ch1_buffer, 0, ch1_buffer.Length);
            avg_current_count = 0;
        }

        private void AverageUpDown_ValueChanged(object sender, EventArgs e)
        {
            ch0_buffer = new double[(int)AverageUpDown.Value];
            ch1_buffer = new double[(int)AverageUpDown.Value];
            avg_current_count = 0;
        }

        //calibration coeficients
        double dBm_cal_a_ch1 = 0.379087;
        double dBm_cal_b_ch1 = -4674985.474745;
        double dBm_cal_a_ch2 = 0.377687;
        double dBm_cal_b_ch2 = -4712463.100095;

        private double raw_to_dBm(double raw, int channel)
        {

            if(channel == 1)
                return (dBm_cal_a_ch1*raw + dBm_cal_b_ch1)/100000;
            else if(channel == 2)
                return (dBm_cal_a_ch2*raw + dBm_cal_b_ch2)/100000;
            else
            return -1;
        }

        private double raw_delta_to_dB(double raw, int channel)
        {

            if (channel == 1)
                return (dBm_cal_a_ch1 * raw) / 100000;
            else if (channel == 2)
                return (dBm_cal_a_ch2 * raw) / 100000;
            else
                return -1;
        }

        private double dBm_to_uW(double dBm_input, int channel)
        {
            return Math.Pow(10, dBm_input / 10)*1000;
        }

        private void chart1_CursorPositionChanging(object sender, CursorEventArgs e)
        {

        }
    }
}

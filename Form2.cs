using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;


namespace con_trac
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void Form2_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cam.Items.Add(filterInfo.Name);
            cam.SelectedIndex = 0;
        }

        private void start_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cam.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox2.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pictureBox2.Image != null)
            {
                BarcodeReader barcode = new BarcodeReader();
                Result result = barcode.Decode((Bitmap)pictureBox2.Image);
                if (result != null)
                {
                    richTextBoxQR.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Date1 = (MonthQr.SelectedItem.ToString() + " " + DayQr.SelectedItem.ToString() + " " + YearQr.Text);

                StreamWriter InfoQR = new StreamWriter(@"C:\Users\chris\OneDrive\Desktop\PROGRAMS\New folder\" + Date1 + ".txt", true);

                InfoQR.WriteLine("Date: " + Date1);
                InfoQR.WriteLine(richTextBoxQR.Text);

                {
                    InfoQR.Close();
                    MessageBox.Show("File Saved");
                }
            }
            catch
            {
                MessageBox.Show("Please input a date.");
            }

            try
            {

                string Date2 = (MonthQr.SelectedItem.ToString() + " " + DayQr.SelectedItem.ToString() + " " + YearQr.Text);
                StreamReader readInfoQR = new StreamReader(@"C:\Users\chris\OneDrive\Desktop\PROGRAMS\New folder\" + Date2 + ".txt");
                readInfoQR.Close();

            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 MainForm = new Form1();
            MainForm.Show();
            this.Hide();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            richTextBoxQR.Clear();
            MonthQr.ResetText();
            DayQr.ResetText();
            YearQr.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

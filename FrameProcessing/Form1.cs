using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using AForge;
using AForge.Video;
using AForge.Video.FFMPEG;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;

namespace FrameProcessing
{
    public partial class Form1 : Form
    {
        FilterInfoCollection webCams;
        VideoCaptureDevice kamera;
        MJPEGStream stream;
        VideoFileSource videoSource;
        int optChose;

        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.SelectedIndex = 0;

            inputIP.Enabled = false;
            button3.Enabled = false;
            browseVid.Enabled = false;

            webCams = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo camera in webCams)
            {
                comboBox1.Items.Add(camera.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (streamLocCam.Checked == true)
            {
                if (button2.Text == "Start Camera")
                {
                    kamera = new VideoCaptureDevice(webCams[comboBox1.SelectedIndex].MonikerString);
                    kamera.NewFrame += new NewFrameEventHandler(video_NewFrame);
                    kamera.Start();
                    button2.Text = "Stop Camera";
                }
                else
                {
                    kamera.SignalToStop();
                    kamera = null;
                    button2.Text = "Start Camera";
                }
            }
            else
            {
                if (button2.Text == "Start Camera")
                {
                    stream = new MJPEGStream("http://" + inputIP.Text + "/video");
                    stream.NewFrame += new NewFrameEventHandler(video_NewFrame);
                    stream.Start();
                    button2.Text = "Stop Camera";
                }
                else
                {
                    stream.SignalToStop();
                    stream = null;
                    button2.Text = "Start Camera";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Stop Video")
            {
                videoSource.SignalToStop();
                button3.Text = "Start Video";
            }
            else if (button3.Text == "Start Video")
            {
                videoSource.Start();
                button3.Text = "Stop Video";
            }
        }

        // New frame event handler, which is invoked on each new available video frame
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Invoke((MethodInvoker)delegate ()
            {
                optChose = comboBox2.SelectedIndex;
            });

            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            Bitmap bmpPrc = (Bitmap)eventArgs.Frame.Clone();
            switch (optChose) {
                case 0:
                    Grayscale filter0 = new Grayscale(0.2125, 0.7154, 0.0721);
                    Bitmap grayImage = filter0.Apply(bmpPrc);
                    OtsuThreshold filter1 = new OtsuThreshold();
                    pictureBox1.Image = bmp;
                    pictureBox2.Image = filter1.Apply(grayImage);
                    break;
                case 1:
                    Sepia filter2 = new Sepia();
                    pictureBox1.Image = bmp;
                    pictureBox2.Image = filter2.Apply(bmpPrc);
                    break;
                case 2:
                    ChannelFiltering filter3 = new ChannelFiltering();
                    filter3.Red = new IntRange(0, 255);
                    filter3.Green = new IntRange(100, 255);
                    filter3.Blue = new IntRange(100, 255);
                    pictureBox1.Image = bmp;
                    pictureBox2.Image = filter3.Apply(bmpPrc);
                    break;
                case 3:
                    HSLFiltering filter4 = new HSLFiltering();
                    filter4.Hue = new IntRange(340, 20);
                    filter4.UpdateLuminance = false;
                    filter4.UpdateHue = false;
                    pictureBox1.Image = bmp;
                    pictureBox2.Image = filter4.Apply(bmpPrc);
                    break;
            }
        }

        private void browseVid_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "AVI Video (*.avi, *.mp4)|*avi; *mp4"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                // create video source
                videoSource = new VideoFileSource(open.FileName);
                // set NewFrame event handler
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                // start the video source
                videoSource.Start();
                // ...
                button3.Text = "Stop Video";
            }
        }

        private void streamIPCam_CheckedChanged(object sender, EventArgs e)
        {
            CloseVideoSource();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            if (streamIPCam.Checked == true)
            {
                inputIP.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
                browseVid.Enabled = false;
            }
            else if (streamLocCam.Checked == true)
            {
                inputIP.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
                browseVid.Enabled = false;
            }
            else
            {
                inputIP.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = true;
                browseVid.Enabled = true;
            }
        }

        private void streamLocVid_CheckedChanged(object sender, EventArgs e)
        {
            CloseVideoSource();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            if (streamIPCam.Checked == true)
            {
                inputIP.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
                browseVid.Enabled = false;
            }
            else if (streamLocCam.Checked == true)
            {
                inputIP.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
                browseVid.Enabled = false;
            }
            else
            {
                inputIP.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = true;
                browseVid.Enabled = true;
            }
        }

        private void streamLocCam_CheckedChanged(object sender, EventArgs e)
        {
            CloseVideoSource();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            button2.Text = "Start Camera";
            button3.Text = "No Video Selected";
            if (streamIPCam.Checked == true)
            {
                inputIP.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
                browseVid.Enabled = false;
            }
            else if (streamLocCam.Checked == true)
            {
                inputIP.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
                browseVid.Enabled = false;
            }
            else
            {
                inputIP.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = true;
                browseVid.Enabled = true;
            }
        }

        private void CloseVideoSource()
        {
            if (!(kamera == null))
            {
                if (kamera.IsRunning)
                {
                    kamera.SignalToStop();
                    kamera = null;
                }
            }

            if (!(stream == null))
            {
                if (stream.IsRunning)
                {
                    stream.SignalToStop();
                    stream = null;
                }
            }

            if (!(videoSource == null))
            {
                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource = null;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseVideoSource();
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseVideoSource();
            Environment.Exit(0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Accord.Video.FFMPEG;
using AForge.Video;
using AForge.Video.DirectShow;
using static System.Net.Mime.MediaTypeNames;
using static Camera.CameraService;

namespace Camera
{
    public partial class Form1 : Form
    {
        private CameraService cs;

        public Form1()
        {
            InitializeComponent();

            cs = new CameraService();
            cs.AddCombobox(comboBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
        }

        private void Connect_Click(object sender, EventArgs e) => cs.Connect(comboBox1,pictureBox1);
        
        private void StartRecording_Click(object sender, EventArgs e)=> cs.StartRecording();
        
        private void StopRecording_Click(object sender, EventArgs e) => cs.StopRecording();

        private void baslatKamera_Click(object sender, EventArgs e) => cs.Connect(comboBox1, pictureBox1);

        private void durdurKamera_Click(object sender, EventArgs e) =>  cs.Disconnect();

    }
}

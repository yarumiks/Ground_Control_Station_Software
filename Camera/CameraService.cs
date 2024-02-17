using Accord.Video.FFMPEG;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Camera
{
    internal class CameraService
    {
        private VideoCaptureDevice _streamVideo;
        private VideoFileWriter _writer;
        private bool _recording;
        private DateTime? _firstFrameTime;
        private BitmapImage _image;
        private Bitmap _bitmap;
        private FilterInfoCollection _videoDevices;

        public BitmapImage Image { get { return _image; } set { _image = value; } }
        
        public CameraService()
        {
            _videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }

        public void AddCombobox(ComboBox combobox)
        {
           foreach (var device in _videoDevices)
            {
                combobox.Items.Add(device);
            }
        }
        public void Connect(ComboBox comboBox, PictureBox pictureBox)
        {
            _streamVideo = new VideoCaptureDevice(_videoDevices[comboBox.SelectedIndex].MonikerString);
            _streamVideo.NewFrame += (sender, eventArgs) => Vcd_NewFrame(eventArgs, pictureBox);
            _streamVideo.Start();
        }
        private void Vcd_NewFrame(AForge.Video.NewFrameEventArgs eventArgs, PictureBox pictureBox)
        {
            _bitmap = (Bitmap)eventArgs.Frame.Clone();
            try
            {
                if (_recording)
                {
                    if (_firstFrameTime != null)
                    {
                        _writer.WriteVideoFrame(_bitmap, DateTime.Now - _firstFrameTime.Value);
                    }
                    else
                    {
                        _writer.WriteVideoFrame(_bitmap);
                        _firstFrameTime = DateTime.Now;
                    }
                }

                using (var bitmap = _bitmap)
                {
                    var bi = bitmap.ToBitmapImage(); //BitmapHelpers.cs dosyası
                    bi.Freeze();
                    Dispatcher.CurrentDispatcher.Invoke(() => Image = bi); //UI thread yerine 1 tane backgroundworker thread oluşturup sistem kasmadan görevi yapmasını sağlar. 
                }

                pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();

            }
            catch (Exception err)
            {
                MessageBox.Show($"Görüntü gösterilirken bir hata oluştu: {err.Message}");
                _streamVideo.Stop();
            }
        }

        public void Disconnect() => _streamVideo.Stop();

        public void StartRecording()
        {
            var dialog = new SaveFileDialog();
            dialog.FileName = "Video1";
            dialog.DefaultExt = ".avi";
            dialog.AddExtension = true;
            var dialogresult = dialog.ShowDialog();

            if (dialogresult != DialogResult.OK) return;

            _firstFrameTime = null;
            _writer = new VideoFileWriter();
            _writer.Open(dialog.FileName, (int)Math.Round(Image.Width, 0), (int)Math.Round(Image.Height, 0));
            _recording = true;
        }
        public void StopRecording()
        {
            _recording= false;
            _writer.Close();
            _writer.Dispose();

            if (!_recording) MessageBox.Show("Video Başarıyla Kaydedildi");
        }
    }
}

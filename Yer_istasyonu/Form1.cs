using ClosedXML.Excel;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using OpenTK.Graphics.OpenGL;
using STL_Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Yer_istasyonu
{
    public partial class Form1 : Form
    {
        #region Değişkenler 
        //VERİ YAZDIRMA DEĞİŞKENLERİ
        public List<Label> dutyLoadList;
        public List<Label> rocketList;
        private string rocketLn, dutyLoadLn, refereeLn; //arduinodan gelen tek satırlık veri paketlerini karşılayan değişkenler
        double time;
        string[] split;
        private float zoomFactor = 1.0f;
        Color renk1 = Color.White, renk2 = Color.Red;
        public double x = 0.0, y = 0.0, z = 0.0;
        SerialPort serialportInstance = new SerialPort();

        //GPS GENEL DEĞİŞKENLERİ
        private GMapOverlay markersOverlay;
        private GMapOverlay markersOverlay2;
        private ChartDataView[] chartDataViews = new ChartDataView[4]
        {
            new ChartDataView(),
            new ChartDataView(),
            new ChartDataView(),
            new ChartDataView(),
        };

        //EKSEN DEĞİŞKENLERİ
        bool monitorLoaded = false;
        bool moveForm = false;
        int moveOffsetX = 0;
        int moveOffsetY = 0;
        BatuGL.VAO_TRIANGLES modelVAO = null; // 3d model vertex array object
        STL_Tools.Vector3 minPos = new STL_Tools.Vector3();
        STL_Tools.Vector3 maxPos = new STL_Tools.Vector3();
        private const float kScaleFactor = 5.0f;

        //butonların tıklanma durumlarına göre statelerin değişmesi için kullanılacak referans
        //seri iletişim için tıklanan butonlarda kullanılıyor.
        public bool rocketClick, dutyLoadClick, RefereeClick, sendDataState;
        public static readonly List<string> BoundRates = new List<string>
             {
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"
             };

        //SAYAÇLAR
        int rocketCounter = 0;
        byte dLoadCounter = 0;
        int counter = 0;
        #endregion

        public Form1()
        {
            InitializeComponent();
            GetPorts();
            InitializeGPS();
            dutyLoadList = new List<Label>()
            {
                label30, label31, label32,
                label33, label34, label35,
                label36,label37
            };
            rocketList = new List<Label> {
                //label41, 
                //label42, 
                //label43,//label44,
                //label45, label46,
                //label47, label48, label49,
                //label50
                label50, label49, label45, label43, label41, label47
            };
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BatuGL.Configure(glControl1, BatuGL.Ortho_Mode.CENTER);
            FileMenuImportBt_Click(this, EventArgs.Empty);
        }

        #region Bağlantı Ayarları

        private void GetPorts()
        {

            string[] ports = SerialPort.GetPortNames();
            try
            {
                comboBox1.Items.AddRange(ports);
            }
            catch (Exception hata)
            {
                MessageBox.Show($"Portlar Listelenirken Hata Oluştu\nHata: {hata.Message}");
            }

            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;

        }
        private void Refresh_Click(object sender, EventArgs e) => GetPorts();

        private void RocketConnect_Click(object sender, EventArgs e)
        {
            if (!rocketClick && !Rocket.IsOpen)
            {
                try
                {
                    Rocket.PortName = comboBox1.SelectedItem.ToString();
                    Rocket.BaudRate = 9600;
                    Rocket.Parity = Parity.None;
                    Rocket.StopBits = StopBits.One;
                    Rocket.DataBits = 8;
                    Rocket.Handshake = Handshake.None;
                    Rocket.Open();
                    Rocket.DataReceived +=Rocket_DataReceived;


                    roketBaglan.Text= "Bağlantı Kes";
                    roketBaglan.BackColor= Color.ForestGreen;

                }
                catch (Exception err)
                {
                    MessageBox.Show($"Bağlanma Hatası: {err.Message}");
                    throw;
                }
                rocketClick = true;
            }
            else
            {
                try
                {
                    Rocket.DataReceived -=Rocket_DataReceived;
                    Rocket.Close();
                    roketBaglan.Text = "Uydu Bağlan";
                    roketBaglan.BackColor= Color.LimeGreen;
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Sistem kapatılırken bir Hata Oluştu: {err.Message}");
                }
                rocketClick = false;
            }
        }
        private void DutyLoadConnect_Click(object sender, EventArgs e)
        {
            if (!dutyLoadClick && !DutyLoad.IsOpen)
            {
                try
                {
                    DutyLoad.PortName = comboBox1.SelectedItem.ToString();
                    DutyLoad.BaudRate = 9600;
                    DutyLoad.Parity = Parity.None;
                    DutyLoad.StopBits = StopBits.One;
                    DutyLoad.DataBits = 8;
                    DutyLoad.Handshake = Handshake.None;
                    DutyLoad.Open();
                    DutyLoad.DataReceived +=Rocket_DataReceived;

                    gorevYukBaglan.Text= "Bağlantı Kes";
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Bağlanma Hatası: {err.Message}");
                    throw;
                }
                dutyLoadClick = true;
            }
            else
            {
                try
                {
                    DutyLoad.DataReceived -=Rocket_DataReceived;
                    DutyLoad.Close();
                    gorevYukBaglan.Text = "Yük Bağlan";

                }
                catch (Exception err)
                {
                    MessageBox.Show($"Sistem kapatılırken bir Hata Oluştu: {err.Message}");
                }
                dutyLoadClick = false;
            }

        }
        private void RefereeConnect_Click(object sender, EventArgs e)
        {
            if (!RefereeClick && !Referee.IsOpen)
            {
                try
                {
                    Referee.PortName = comboBox1.SelectedItem.ToString();
                    Referee.BaudRate = 9600;
                    Referee.Parity = Parity.None;
                    Referee.StopBits = StopBits.One;
                    Referee.DataBits = 8;
                    Referee.Handshake = Handshake.None;
                    Referee.Open();
                    Referee.DataReceived +=Rocket_DataReceived;

                    hakemBaglan.Text= "\tBağlantı Kes";
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Bağlanma Hatası: {err.Message}");
                    throw;
                }
                RefereeClick = true;
            }
            else
            {
                try
                {
                    Referee.DataReceived -=Rocket_DataReceived;
                    Referee.Close();
                    hakemBaglan.Text = "Hakem";
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Sistem kapatılırken bir Hata Oluştu: {err.Message}");
                }
                RefereeClick = false;
            }

        }

        private void DataTransmission(object sender, EventArgs e)
        {

        }

        private void SendData_Click(object sender, EventArgs e)
        {
            if (Referee.IsOpen)
            {
                if (!sendDataState)
                {
                    sendDataState= true;
                    veriGonderme.Text = "Durdur";
                    veriGonderme.TextAlign = ContentAlignment.MiddleCenter;
                }
                else
                {
                    sendDataState = false;
                    veriGonderme.Text = "Veri Gönder";
                    veriGonderme.TextAlign = ContentAlignment.MiddleRight;
                }
            }
            else
            {
                MessageBox.Show("Hakem Portu Bağlantısını Kontrol Ediniz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }


        #endregion
        #region Veri Yazdırma 
        private void Rocket_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (Rocket.IsOpen)
                {
                    rocketLn = Rocket.ReadLine();
                    this.Invoke(new EventHandler(RocketDisplayData));
                    Rocket.DiscardInBuffer();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Port Sonlandırma Hatası: ${err.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void DutyLoad_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //dutyLoadLn = DutyLoad.ReadLine();
            //this.Invoke(new EventHandler(RocketDisplayData));
        }
        private void Referee_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            refereeLn = Referee.ReadLine();
            this.Invoke(new EventHandler(RocketDisplayData));
        }

        private async void RocketDisplayData(object sender, EventArgs e)
        {
            //Paralel şekilde bir görevin çalışması için Tasklar kullanılır.
            //Task daha otomatik olduğu için kullanılmıştır duruma göre Thread'da kullanılabilir
            //Task otomatik olarak arka planda kendisi bir Thread oluşturarak gelen verilerin çakışmamasını,kasma-donma gibi olayların yaşanmamasını sağlar.
            Task aviyonikTask = Task.Run(() => RocketReceiveData());
            await aviyonikTask;
        }
        private void RocketReceiveData()
        {

            split = rocketLn.Split('*');
            if (split !=null)
            {
                try
                {

                    //DataViewGridUpdate(split);

                    //  --YAZDIRILAN VERİLER--
                    //rocketList değişkenindeki listeyi sıralarken arduinodan gelen paketin sırasına göre sıralanmasına dikkat edilmeli.
                    for (int i = 0; i < rocketList.Count && i < split.Length && i < dataGridView1.Columns.Count; i++)
                    {

                        if (rocketList[i].InvokeRequired) //&& split.lenght == 15
                        {
                            if(split.Length ==15)
                            {
                                rocketList[i].Invoke(new MethodInvoker(delegate { rocketList[i].Text = split[i].ToString(); }));
                            } else
                            {
                                if (richTextBox1.InvokeRequired)
                                {
                                    richTextBox1.Invoke(new MethodInvoker(delegate
                                    {
                                        richTextBox1.Text += rocketLn.ToString() + "\n";
                                        rocketCounter++;
                                        rmdc.Text = Convert.ToString(rocketCounter); //rocket missing data counter
                                        richTextBox1.SelectionStart = richTextBox1.Text.Length;
                                        richTextBox1.ScrollToCaret();
                                    }));
                                }
                                else
                                {
                                    richTextBox1.Text += rocketLn.ToString() + "\n";
                                    rocketCounter++;
                                    rmdc.Text += Convert.ToString(rocketCounter); //rocket missing data counter
                                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                                    richTextBox1.ScrollToCaret();
                                }
                            }
                        }
                        else
                        {
                            rocketList[i].Text = "0";
                        }

                        //  --GRAFİKLER--
                        this.Invoke(new Action(TemperatureGrapth));
                        this.Invoke(new Action(PressureGrapth));

                        //  --GPS--
                        //this.Invoke(new Action(() =>
                        //{     
                        //    if (TryParseCoordinates(refereeLn, out double Latitude, out double Longitude, gpsData1))
                        //    {
                        //        this.Invoke(new Action(() =>
                        //        {
                        //            DisplayGPS(gpsData1, gMapControl1, markersOverlay);
                        //        }));
                        //    }
                        //}));

                        //  --EKSEN-- 

                        if (split.Length >= 3)
                        {
                            Invoke((MethodInvoker)delegate
                            {

                                if (double.TryParse(split[0], NumberStyles.Any, CultureInfo.InvariantCulture, out double parsedX) &&
                                    double.TryParse(split[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double parsedY) &&
                                    double.TryParse(split[2], NumberStyles.Any, CultureInfo.InvariantCulture, out double parsedZ))
                                {
                                    // Tüm dönüştürmeler başarılı oldu, değerleri kullanabilirsiniz.
                                    x = parsedX;
                                    y = parsedY;
                                    z = parsedZ;
                                }
                                Task.Run(() => glControl1.Invalidate());
                            });
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Verileri Okuma Hatası: ${err.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
        #region GPS Metotları
        //iki tane gps olduğu için fonksiyonu genelleştirme adına bir sınıf oluşturuyoruz
        public class GPSData
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }
        GPSData gpsData1 = new GPSData();
        GPSData gpsData2 = new GPSData();

        private void InitializeGPS()
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(41.0082, 28.9784);
            gMapControl1.MinZoom = 5;
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 8;

            markersOverlay = new GMapOverlay("markers");
            gMapControl1.Overlays.Add(markersOverlay);
            //Görev yükü
            gMapControl2.DragButton = MouseButtons.Left;
            gMapControl2.MapProvider = GMapProviders.GoogleMap;
            gMapControl2.Position = new PointLatLng(41.0082, 28.9784);
            gMapControl2.MinZoom = 5;
            gMapControl2.MaxZoom = 20;
            gMapControl2.Zoom = 8;

            markersOverlay2 = new GMapOverlay("markers");
            gMapControl2.Overlays.Add(markersOverlay2);
        }
        //gelen değerleri double türüne dönüştürüyoruz
        private bool TryParseCoordinates(string data, out double latt, out double longt, GPSData gpsData)
        {
            latt = longt = 0.0;
            string[] parts = data.Split('*');
            CultureInfo culture = CultureInfo.InvariantCulture;

            //gelen verileri parse işleminden sonra out keyword ile yeni değerlerini atıyoruz
            if (parts.Length >= 2 && double.TryParse(parts[0], NumberStyles.Any, culture, out latt) &&
                        double.TryParse(parts[1], NumberStyles.Any, culture, out longt))
            {
                //fonksiyon içinde gpsdata değişkeni için son değerleri atıyoruz.
                gpsData.Latitude = latt;
                gpsData.Longitude = longt;
                return true;
            }
            return false;
        }

        private void DisplayGPS(GPSData gpsData, GMapControl gMapControl, GMapOverlay markersOverlay)
        {
            if (gpsData != null && gpsData.Latitude != 0.0 && gpsData.Longitude != 0.0)
            {
                PointLatLng point = new PointLatLng(gpsData.Latitude, gpsData.Longitude);
                var marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);

                //toottip bilgilendirme kutusu özelleştirme kullanılması zorunlu değildir.
                marker.ToolTipText = $"Latitude: {point.Lat},\nLongitude {point.Lng}";
                var tooltip = new GMapToolTip(marker)
                {
                    Fill = new SolidBrush(Color.Black),
                    Foreground = new SolidBrush(Color.White),
                    Offset = new Point(20, -40)
                };
                marker.ToolTip = tooltip;

                markersOverlay.Markers.Clear();
                markersOverlay.Markers.Add(marker);
                gMapControl.Position = point;
                gMapControl.Refresh();
            }
        }

        #endregion
        #region Genel Fonksiyonlar 

        private void SatelliteClear_Click(object sender, EventArgs e) => RocketReceiveData();
        private void ClearMemory_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, 0);
            chart1.ChartAreas[0].AxisX.Minimum = double.NaN;
            chart1.ChartAreas[0].AxisX.Maximum = double.NaN;
            chart1.ChartAreas[0].AxisY.Minimum = double.NaN;
            chart1.ChartAreas[0].AxisY.Maximum = double.NaN;

            chart2.Series[0].Points.Clear();
            chart2.Series[0].Points.AddXY(0, 0);
            chart2.ChartAreas[0].AxisX.Minimum = double.NaN;
            chart2.ChartAreas[0].AxisX.Maximum = double.NaN;
            chart2.ChartAreas[0].AxisY.Minimum = double.NaN;
            chart2.ChartAreas[0].AxisY.Maximum = double.NaN;

            chart3.Series[0].Points.Clear();
            chart3.Series[0].Points.AddXY(0, 0);
            chart3.ChartAreas[0].AxisX.Minimum = double.NaN;
            chart3.ChartAreas[0].AxisX.Maximum = double.NaN;
            chart3.ChartAreas[0].AxisY.Minimum = double.NaN;
            chart3.ChartAreas[0].AxisY.Maximum = double.NaN;

            chart4.Series[0].Points.Clear();
            chart4.Series[0].Points.AddXY(0, 0);
            chart4.ChartAreas[0].AxisX.Minimum = double.NaN;
            chart4.ChartAreas[0].AxisX.Maximum = double.NaN;
            chart4.ChartAreas[0].AxisY.Minimum = double.NaN;
            chart4.ChartAreas[0].AxisY.Maximum = double.NaN;
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            glControl1.SwapBuffers();
            glControl1.Invalidate();
        }
        private void DataViewGridUpdate(string[] data)
        {
            Invoke((MethodInvoker)delegate
            {
                int rowIndex = dataGridView1.Rows.Add();

                for (int i = 0; i < split.Length && i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Rows[rowIndex].Cells[i].Value = split[i].ToString();
                }

                // DataGridView'ı otomatik olarak aşağı kaydırma
                dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
            });
        }
        private void ExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Veri Sayfası");

                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                    }

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            object cellValue = dataGridView1.Rows[i].Cells[j].Value;
                            worksheet.Cell(i + 2, j + 1).Value = cellValue != null ? cellValue.ToString() : string.Empty;
                        }
                    }

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel Dosyası (*.xlsx)|*.xlsx|Tüm Dosyalar (*.*)|*.*";
                    saveFileDialog.Title = "Excel Dosyasına Kaydet";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Veriler Excel dosyasına başarıyla aktarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excel dosyasına veri aktarımı sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Grafikler
        //verilen kordinatların karışmaması için ayrı eventleri oluşturuyoruz.
        private void Chart1_MouseMove(object sender, MouseEventArgs e) 
            => Chart_MouseMove(chartDataViews[0], e, chart1);
        private void Chart2_MouseMove(object sender, MouseEventArgs e) 
            => Chart_MouseMove(chartDataViews[1], e, chart2);
        private void Chart3_MouseMove(object sender, MouseEventArgs e) 
            => Chart_MouseMove(chartDataViews[2], e, chart3);
        private void Chart4_MouseMove(object sender, MouseEventArgs e) 
            => Chart_MouseMove(chartDataViews[3], e, chart4);

        private void tableLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        //mouse hareketi ile X ve Y kordinat değerlerini göstermemize sağlayan ana fonksiyonumuz
        private void Chart_MouseMove(ChartDataView chartData, MouseEventArgs e, Chart chart)
        {
            var pos = e.Location;

                if (chartData == null || chartData.prevPosition.HasValue && pos == chartData.prevPosition.Value)
                    return;

                chartData.tooltip.RemoveAll();
                chartData.prevPosition = pos;

                var results = chart.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint);

                if (results != null)
                {
                    foreach (var result in results)
                    {
                        if (result.ChartElementType == ChartElementType.DataPoint)
                        {
                            var prop = result.Object as DataPoint;
                            if (prop != null)
                            {
                                var pointXPixel = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
                                var pointYPixel = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

                                if (Math.Abs(pos.X - pointXPixel) < 5 && Math.Abs(pos.Y - pointYPixel) < 5)
                                {
                                    chartData.tooltip.Show("X= " + prop.XValue + ", Y= " + prop.YValues[0], chart, pos.X, pos.Y - 15);
                                }
                            }
                        }
                    }
                }
        }


        private void TemperatureGrapth()
        {
            var tempChart = chart1.ChartAreas[0];
            if (rocketLn != null || split.Length >= 3)
            {
                chart1.Series[0].Points.AddXY(time, split[0]);
                if (chart1.Series[0].Points.Count >100) chart1.Series[0].Points.RemoveAt(0);

                time += 0.2; //x ekseni için double türünde zaman değişkeni
                tempChart.AxisX.Minimum =chart1.Series[0].Points[0].XValue;
                tempChart.AxisX.Maximum =time;

                double minY = -50; // Minimum değer
                double maxY = 100;  // Maksimum değer

                tempChart.AxisY.Minimum = minY;
                tempChart.AxisY.Maximum = maxY;
                tempChart.AxisY.IsStartedFromZero = false;

                tempChart.AxisY.Interval = 30; // Aralık değer
                tempChart.AxisY.IntervalOffset = minY % 10; // Aralık ofseti
                tempChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number; // Aralık tipi

                tempChart.AxisX.LabelStyle.Format = "0.00";

                //buradaki koşullar Y ekseninde max ve min değerlerini verdikten sonra
                //eğer o aralık dışında kalan bir değerse aralıkları güncelliyor +10 veya -10 şeklinde
                if (chart1.Series[0].Points.Any())
                {
                    //sabit olması için int olarak Cast ediyoruz
                    double currentMaxY = (int)chart1.Series[0].Points.Max(p => p.YValues[0]);
                    double currentMinY = (int)chart1.Series[0].Points.Min(p => p.YValues[0]);

                    if (currentMaxY > maxY)
                    {
                        tempChart.AxisY.Maximum = currentMaxY + 10;
                    }

                    if (currentMinY < minY)
                    {
                        tempChart.AxisY.Minimum = currentMinY - 10;
                    }
                }
                else
                {
                    Console.WriteLine("Veri ayrıştırılırken bir hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
        private void PressureGrapth()
        {
            var pressurechart = chart2.ChartAreas[0];
            if (rocketLn != null & split.Length >= 3)
            {
                chart2.Series[0].Points.AddXY(time, split[2]);
                if (chart2.Series[0].Points.Count >100) chart2.Series[0].Points.RemoveAt(0);

                time += 0.2;
                pressurechart.AxisX.Minimum =chart2.Series[0].Points[0].XValue;
                pressurechart.AxisX.Maximum =time;

                double minY = -500;
                double maxY = 20000;

                pressurechart.AxisY.Minimum = minY;
                pressurechart.AxisY.Maximum = maxY;
                pressurechart.AxisY.IsStartedFromZero = false;

                pressurechart.AxisY.Interval = 3000;
                pressurechart.AxisY.IntervalOffset = minY % 100;
                pressurechart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

                pressurechart.AxisX.LabelStyle.Format = "0.00";

                if (chart2.Series[0].Points.Count > 0)
                {
                    //sabit olması için int olarak Cast e3diyoruz
                    double currentMaxY = (int)chart2.Series[0].Points.Max(p => p.YValues[0]);
                    double currentMinY = (int)chart2.Series[0].Points.Min(p => p.YValues[0]);

                    if (currentMaxY > maxY) pressurechart.AxisY.Maximum = currentMaxY + 500;

                    if (currentMinY < minY) pressurechart.AxisY.Minimum = currentMinY - 500;
                }
            }
        }
        #endregion
        #region OpenGl2
        private void glControl1_Load(object sender, EventArgs e)
        {
            glControl1.AllowDrop = true;
            monitorLoaded = true;
            glControl1.MakeCurrent();
            GL.ClearColor(Color.Black);

        }


        private void ConfigureBasicLighting(Color modelColor)
        {
            float[] light_1 = new float[] {
            0.2f * modelColor.R / 255.0f,
            0.2f * modelColor.G / 255.0f,
            0.2f * modelColor.B / 255.0f,
            1.0f };
            float[] light_2 = new float[] {
            10.0f * modelColor.R / 255.0f,
            10.0f * modelColor.G / 255.0f,
            10.0f * modelColor.B / 255.0f,
            1.0f };
            float[] specref = new float[] {
                0.2f * modelColor.R / 255.0f,
                0.2f * modelColor.G / 255.0f,
                0.2f * modelColor.B / 255.0f,
                1.0f };
            float[] specular_0 = new float[] { -1.0f, -1.0f, 1.0f, 1.0f };
            float[] specular_1 = new float[] { 1.0f, -1.0f, 1.0f, 1.0f };
            //float[] lightPos_0 = new float[] { 1000f, 1000f, -200.0f, 0.0f };
            float[] lightPos_1 = new float[] { -1000f, -1000f, -200.0f, 0.0f };

            GL.Enable(EnableCap.Lighting);
            /* light 0 */

            GL.Light(LightName.Light0, LightParameter.Ambient, light_1);
            GL.Light(LightName.Light0, LightParameter.Diffuse, light_2);
            GL.Light(LightName.Light0, LightParameter.Specular, specular_0);
            GL.Light(LightName.Light0, LightParameter.Position, lightPos_1);
            GL.Enable(EnableCap.Light0);
            /* light 1 */
            GL.Light(LightName.Light1, LightParameter.Ambient, light_1);
            GL.Light(LightName.Light1, LightParameter.Diffuse, light_2);
            GL.Light(LightName.Light1, LightParameter.Specular, specular_1);
            GL.Light(LightName.Light1, LightParameter.Position, lightPos_1);
            GL.Enable(EnableCap.Light1);
            /*material settings  */
            GL.Enable(EnableCap.ColorMaterial);
            GL.ColorMaterial(MaterialFace.Front, ColorMaterialParameter.AmbientAndDiffuse);
            GL.Material(MaterialFace.Front, MaterialParameter.Specular, specref);
            GL.Material(MaterialFace.Front, MaterialParameter.Shininess, 10);
            GL.Enable(EnableCap.Normalize);
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (!monitorLoaded)
                return;

            BatuGL.Configure(glControl1, BatuGL.Ortho_Mode.CENTER);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);


            GL.PushMatrix();
            BatuGL.Draw_WCS();

            GL.Rotate(-90.0f, 1.0f, 0.0f, 0.0f);
            GL.Rotate(x, 1.0, 0.0, 0.0);
            GL.Rotate(y, 0.0, 0.0, 1.0);
            GL.Rotate(z, 0.0, 1.0, 0.0);

            float scaleValue = 2.0f; // İstediğiniz büyüklük faktörü
            GL.Scale(scaleValue, scaleValue, scaleValue);

            if (modelVAO != null)
            {
                ConfigureBasicLighting(modelVAO.color);
                GL.Translate(-minPos.x, -minPos.y, -minPos.z); //cismin başlangıç konumu için
                GL.Translate(-(maxPos.x - minPos.x) / 2.0f, -(maxPos.y - minPos.y) / 2.0f, -(maxPos.z - minPos.z) / 2.0f); //cismin merkezi için
                if (modelVAO != null) modelVAO.Draw();
            }
            GL.PopMatrix();
            glControl1.SwapBuffers();
        }


        private void ReadSelectedFile(string fileName)
        {
            STLReader stlReader = new STLReader(fileName);
            TriangleMesh[] meshArray = stlReader.ReadFile();
            modelVAO = new BatuGL.VAO_TRIANGLES();
            modelVAO.parameterArray = STLExport.Get_Mesh_Vertices(meshArray);
            modelVAO.normalArray = STLExport.Get_Mesh_Normals(meshArray);
            modelVAO.color = Color.Crimson;
            minPos = stlReader.GetMinMeshPosition(meshArray);
            maxPos = stlReader.GetMaxMeshPosition(meshArray);
            //orb.Reset_Orientation();
            //orb.Reset_Pan();
            //orb.Reset_Scale();
            if (stlReader.Get_Process_Error())
            {
                modelVAO = null;
                /* if there is an error, deinitialize the gl monitor to clear the screen */
                Invoke((MethodInvoker)delegate
                {
                    BatuGL.Configure(glControl1, BatuGL.Ortho_Mode.CENTER);
                    glControl1.SwapBuffers();
                });
            }
            else
            {
                // OpenGL kontrollerini güvenli bir şekilde güncelle
                Invoke((MethodInvoker)delegate
                {
                    glControl1.Invalidate();
                });
            }
        }

        private void FileMenuImportBt_Click(object sender, EventArgs e)
        {
            OpenFileDialog newFileDialog = new OpenFileDialog();
            newFileDialog.Filter = "STL Files|*.stl;*.txt;";
            string stlfineName = "C:/Users/yasar k/Desktop/Yer İstasyonu/Yer_istasyonu/STL_Tools/Toy rocket H010408 file stl free download 3D Model for CNC and 3d printer.stl";
            //if (newFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //ReadSelectedFile(newFileDialog.FileName);
            //}
            if (File.Exists(stlfineName))
            {
                // Dosya varsa işlemlere devam et
                ReadSelectedFile(stlfineName);
            }
            else
            {
                MessageBox.Show("Dosya bulunamadı.");
            }
        }

        #endregion
        #region Komut gönderme
        //private async void button3_Click(object sender, EventArgs e)
        //{
        //    if (connectionState)
        //    {
        //        char sendCharToArduino = 'A';
        //        serialPort1.WriteLine(sendCharToArduino.ToString());
        //    }
        //}

        //private async Task<string> ReadSerialPortAsync()
        //{
        //    string response = string.Empty;
        //    int timeoutMilliseconds = 2000; // Timeout süresi, isteğe bağlı olarak ayarlanabilir

        //    DateTime startTime = DateTime.Now;

        //    while (DateTime.Now.Subtract(startTime).TotalMilliseconds < timeoutMilliseconds)
        //    {
        //        if (serialPort1.BytesToRead > 0)
        //        {
        //            response = serialPort1.ReadExisting();
        //            break;
        //        }

        //        await Task.Delay(100); // 100 milisaniye bekleyerek diğer işlemlere izin ver
        //    }

        //    return response;
        //}
        #endregion
        #region Kamera(düzelt)
        //private CameraService cs;
        //form1() -> new cameraservice(); cs.AddCombobox(comboBox1);
        //connect -> cs.connect(combobox1,picturebox1);
        //startRecording -> cs.startRecording();
        //stop recording ->
        //stopCamera -> cs.Disconnect();
        #endregion

    }
}

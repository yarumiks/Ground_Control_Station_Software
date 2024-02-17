    using System.Drawing;
    using System.Windows.Forms;
    using ScottPlot;
namespace Yer_istasyonu
{

        partial class Form1
        {
            /// <summary>
            ///  Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            ///  Clean up any resources being used.
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
            ///  Required method for Designer support - do not modify
            ///  the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SatelliteClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rollLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.altitudeLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pitchLabel = new System.Windows.Forms.Label();
            this.yawLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rmdc = new System.Windows.Forms.Label();
            this.Rev = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.GYEV = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.hakemBaglan = new FontAwesome.Sharp.IconButton();
            this.gorevYukBaglan = new FontAwesome.Sharp.IconButton();
            this.roketBaglan = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Refresh = new FontAwesome.Sharp.IconButton();
            this.veriGonderme = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExportToExcel = new System.Windows.Forms.Button();
            this.clearMemory = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Rocket = new System.IO.Ports.SerialPort(this.components);
            this.DutyLoad = new System.IO.Ports.SerialPort(this.components);
            this.Referee = new System.IO.Ports.SerialPort(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.gMapControl2 = new GMap.NET.WindowsForms.GMapControl();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.glControl1 = new OpenTK.GLControl();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox5, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1219, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.38885F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.18819F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.42296F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(321, 592);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SatelliteClear);
            this.groupBox3.Controls.Add(this.tableLayoutPanel7);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 215);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "UYDU BİLGİ PANELİ";
            // 
            // SatelliteClear
            // 
            this.SatelliteClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SatelliteClear.ForeColor = System.Drawing.Color.Black;
            this.SatelliteClear.Location = new System.Drawing.Point(3, 189);
            this.SatelliteClear.Margin = new System.Windows.Forms.Padding(1, 20, 1, 1);
            this.SatelliteClear.Name = "SatelliteClear";
            this.SatelliteClear.Size = new System.Drawing.Size(309, 31);
            this.SatelliteClear.TabIndex = 2;
            this.SatelliteClear.Text = "Sıfırla";
            this.SatelliteClear.UseVisualStyleBackColor = true;
            this.SatelliteClear.Click += new System.EventHandler(this.SatelliteClear_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(309, 194);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label45);
            this.panel2.Controls.Add(this.label44);
            this.panel2.Controls.Add(this.label43);
            this.panel2.Controls.Add(this.label41);
            this.panel2.Controls.Add(this.label42);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pressureLabel);
            this.panel2.Controls.Add(this.tempLabel);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.rollLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 188);
            this.panel2.TabIndex = 2;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(80, 129);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(16, 14);
            this.label45.TabIndex = 17;
            this.label45.Text = "0";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(80, 103);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(16, 14);
            this.label44.TabIndex = 16;
            this.label44.Text = "0";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(80, 74);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(16, 14);
            this.label43.TabIndex = 15;
            this.label43.Text = "0";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(80, 45);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(16, 14);
            this.label41.TabIndex = 14;
            this.label41.Text = "0";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(91, 20);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(16, 14);
            this.label42.TabIndex = 13;
            this.label42.Text = "0";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label40);
            this.panel4.Controls.Add(this.label39);
            this.panel4.Controls.Add(this.label38);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Location = new System.Drawing.Point(3, 154);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(297, 98);
            this.panel4.TabIndex = 12;
            // 
            // label40
            // 
            this.label40.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(88, 58);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(16, 14);
            this.label40.TabIndex = 8;
            this.label40.Text = "0";
            // 
            // label39
            // 
            this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(88, 37);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(16, 14);
            this.label39.TabIndex = 7;
            this.label39.Text = "0";
            // 
            // label38
            // 
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(88, 11);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(16, 14);
            this.label38.TabIndex = 6;
            this.label38.Text = "0";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(0, 11);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 14);
            this.label19.TabIndex = 3;
            this.label19.Text = "GPS Enlem:";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(0, 37);
            this.label20.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 14);
            this.label20.TabIndex = 4;
            this.label20.Text = "GPS Boylam:";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(0, 58);
            this.label21.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 14);
            this.label21.TabIndex = 5;
            this.label21.Text = "GPS İrtifa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(-3, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Uydu Statüsü:";
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pressureLabel.Location = new System.Drawing.Point(3, 45);
            this.pressureLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(55, 14);
            this.pressureLabel.TabIndex = 6;
            this.pressureLabel.Text = "Basınç:";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tempLabel.Location = new System.Drawing.Point(3, 74);
            this.tempLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(64, 14);
            this.tempLabel.TabIndex = 7;
            this.tempLabel.Text = "Sıcaklık:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(3, 103);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 14);
            this.label12.TabIndex = 8;
            this.label12.Text = "İniş Hızı:";
            // 
            // rollLabel
            // 
            this.rollLabel.AutoSize = true;
            this.rollLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rollLabel.Location = new System.Drawing.Point(3, 132);
            this.rollLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.rollLabel.Name = "rollLabel";
            this.rollLabel.Size = new System.Drawing.Size(37, 14);
            this.rollLabel.TabIndex = 9;
            this.rollLabel.Text = "Roll:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label50);
            this.panel3.Controls.Add(this.label49);
            this.panel3.Controls.Add(this.label48);
            this.panel3.Controls.Add(this.label47);
            this.panel3.Controls.Add(this.label46);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.altitudeLabel);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.pitchLabel);
            this.panel3.Controls.Add(this.yawLabel);
            this.panel3.Location = new System.Drawing.Point(157, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(149, 188);
            this.panel3.TabIndex = 3;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(86, 137);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(16, 14);
            this.label50.TabIndex = 14;
            this.label50.Text = "0";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(86, 109);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(16, 14);
            this.label49.TabIndex = 13;
            this.label49.Text = "0";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(86, 79);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(16, 14);
            this.label48.TabIndex = 12;
            this.label48.Text = "0";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(86, 50);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(16, 14);
            this.label47.TabIndex = 11;
            this.label47.Text = "0";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(92, 20);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(16, 14);
            this.label46.TabIndex = 10;
            this.label46.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 20);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 14);
            this.label14.TabIndex = 5;
            this.label14.Text = "Panel Sayısı:";
            // 
            // altitudeLabel
            // 
            this.altitudeLabel.AutoSize = true;
            this.altitudeLabel.Location = new System.Drawing.Point(3, 49);
            this.altitudeLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.altitudeLabel.Name = "altitudeLabel";
            this.altitudeLabel.Size = new System.Drawing.Size(77, 14);
            this.altitudeLabel.TabIndex = 6;
            this.altitudeLabel.Text = "Yükseklik:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 79);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 14);
            this.label16.TabIndex = 7;
            this.label16.Text = "Pil Gerilimi:";
            // 
            // pitchLabel
            // 
            this.pitchLabel.AutoSize = true;
            this.pitchLabel.Location = new System.Drawing.Point(3, 108);
            this.pitchLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.pitchLabel.Name = "pitchLabel";
            this.pitchLabel.Size = new System.Drawing.Size(45, 14);
            this.pitchLabel.TabIndex = 8;
            this.pitchLabel.Text = "Pitch:";
            // 
            // yawLabel
            // 
            this.yawLabel.AutoSize = true;
            this.yawLabel.Location = new System.Drawing.Point(3, 137);
            this.yawLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.yawLabel.Name = "yawLabel";
            this.yawLabel.Size = new System.Drawing.Size(42, 14);
            this.yawLabel.TabIndex = 9;
            this.yawLabel.Text = "Yaw:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel8);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(3, 224);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 119);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GÖREV YÜKÜ BİLGİ PANELİ";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(309, 124);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.label33);
            this.panel5.Controls.Add(this.label32);
            this.panel5.Controls.Add(this.label31);
            this.panel5.Controls.Add(this.label30);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(148, 118);
            this.panel5.TabIndex = 2;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(87, 95);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(16, 14);
            this.label33.TabIndex = 11;
            this.label33.Text = "0";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(87, 65);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(16, 14);
            this.label32.TabIndex = 10;
            this.label32.Text = "0";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(87, 35);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(16, 14);
            this.label31.TabIndex = 9;
            this.label31.Text = "0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(87, 9);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(16, 14);
            this.label30.TabIndex = 8;
            this.label30.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 9);
            this.label22.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label22.Name = "label22";
            this.label22.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label22.Size = new System.Drawing.Size(52, 16);
            this.label22.TabIndex = 4;
            this.label22.Text = "Enlem:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 37);
            this.label23.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label23.Name = "label23";
            this.label23.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label23.Size = new System.Drawing.Size(61, 16);
            this.label23.TabIndex = 5;
            this.label23.Text = "Boylam:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 65);
            this.label24.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label24.Name = "label24";
            this.label24.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label24.Size = new System.Drawing.Size(55, 16);
            this.label24.TabIndex = 6;
            this.label24.Text = "Basınç:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 93);
            this.label25.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label25.Name = "label25";
            this.label25.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label25.Size = new System.Drawing.Size(64, 16);
            this.label25.TabIndex = 7;
            this.label25.Text = "Sıcaklık:";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.label37);
            this.panel6.Controls.Add(this.label36);
            this.panel6.Controls.Add(this.label35);
            this.panel6.Controls.Add(this.label34);
            this.panel6.Controls.Add(this.label26);
            this.panel6.Controls.Add(this.label27);
            this.panel6.Controls.Add(this.label28);
            this.panel6.Controls.Add(this.label29);
            this.panel6.Location = new System.Drawing.Point(157, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(149, 118);
            this.panel6.TabIndex = 3;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(89, 95);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(16, 14);
            this.label37.TabIndex = 11;
            this.label37.Text = "0";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(89, 67);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(16, 14);
            this.label36.TabIndex = 10;
            this.label36.Text = "0";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(89, 39);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(16, 14);
            this.label35.TabIndex = 9;
            this.label35.Text = "0";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label34.Location = new System.Drawing.Point(89, 12);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(16, 16);
            this.label34.TabIndex = 8;
            this.label34.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 12);
            this.label26.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label26.Name = "label26";
            this.label26.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label26.Size = new System.Drawing.Size(42, 16);
            this.label26.TabIndex = 4;
            this.label26.Text = "Nem:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 37);
            this.label27.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label27.Name = "label27";
            this.label27.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label27.Size = new System.Drawing.Size(60, 16);
            this.label27.TabIndex = 5;
            this.label27.Text = "İşlemci:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(5, 65);
            this.label28.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label28.Name = "label28";
            this.label28.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label28.Size = new System.Drawing.Size(53, 16);
            this.label28.TabIndex = 6;
            this.label28.Text = "Bellek:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 93);
            this.label29.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label29.Name = "label29";
            this.label29.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label29.Size = new System.Drawing.Size(64, 16);
            this.label29.TabIndex = 7;
            this.label29.Text = "Batarya:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tabControl1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(3, 349);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(315, 240);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "VERİ BİLGİLERİ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(309, 219);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.rmdc);
            this.tabPage2.Controls.Add(this.Rev);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(301, 192);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Roket";
            // 
            // rmdc
            // 
            this.rmdc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rmdc.AutoSize = true;
            this.rmdc.ForeColor = System.Drawing.Color.Red;
            this.rmdc.Location = new System.Drawing.Point(129, 165);
            this.rmdc.Name = "rmdc";
            this.rmdc.Size = new System.Drawing.Size(16, 14);
            this.rmdc.TabIndex = 2;
            this.rmdc.Text = "0";
            // 
            // Rev
            // 
            this.Rev.AutoSize = true;
            this.Rev.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Rev.ForeColor = System.Drawing.Color.DarkOrange;
            this.Rev.Location = new System.Drawing.Point(3, 175);
            this.Rev.Name = "Rev";
            this.Rev.Size = new System.Drawing.Size(120, 14);
            this.Rev.TabIndex = 1;
            this.Rev.Text = "Roket Eksik Veri:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(2, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(297, 150);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.GYEV);
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(301, 194);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Görev Yükü";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(169, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            // 
            // GYEV
            // 
            this.GYEV.AutoSize = true;
            this.GYEV.BackColor = System.Drawing.Color.Black;
            this.GYEV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GYEV.ForeColor = System.Drawing.Color.DarkOrange;
            this.GYEV.Location = new System.Drawing.Point(3, 177);
            this.GYEV.Name = "GYEV";
            this.GYEV.Size = new System.Drawing.Size(160, 14);
            this.GYEV.TabIndex = 1;
            this.GYEV.Text = "Görev Yükü Eksik Veri:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.richTextBox2.BackColor = System.Drawing.Color.Black;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.ForeColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(-1, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(300, 166);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // hakemBaglan
            // 
            this.hakemBaglan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hakemBaglan.BackColor = System.Drawing.Color.LimeGreen;
            this.hakemBaglan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hakemBaglan.ForeColor = System.Drawing.Color.White;
            this.hakemBaglan.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.hakemBaglan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hakemBaglan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.hakemBaglan.IconSize = 29;
            this.hakemBaglan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hakemBaglan.Location = new System.Drawing.Point(330, 167);
            this.hakemBaglan.Name = "hakemBaglan";
            this.hakemBaglan.Size = new System.Drawing.Size(132, 33);
            this.hakemBaglan.TabIndex = 5;
            this.hakemBaglan.Text = "Hakem";
            this.hakemBaglan.UseVisualStyleBackColor = false;
            this.hakemBaglan.Click += new System.EventHandler(this.RefereeConnect_Click);
            // 
            // gorevYukBaglan
            // 
            this.gorevYukBaglan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gorevYukBaglan.BackColor = System.Drawing.Color.LimeGreen;
            this.gorevYukBaglan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gorevYukBaglan.ForeColor = System.Drawing.Color.White;
            this.gorevYukBaglan.IconChar = FontAwesome.Sharp.IconChar.Satellite;
            this.gorevYukBaglan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gorevYukBaglan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.gorevYukBaglan.IconSize = 29;
            this.gorevYukBaglan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gorevYukBaglan.Location = new System.Drawing.Point(330, 118);
            this.gorevYukBaglan.Name = "gorevYukBaglan";
            this.gorevYukBaglan.Size = new System.Drawing.Size(132, 37);
            this.gorevYukBaglan.TabIndex = 4;
            this.gorevYukBaglan.Text = "Yük Bağlan";
            this.gorevYukBaglan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gorevYukBaglan.UseVisualStyleBackColor = false;
            this.gorevYukBaglan.Click += new System.EventHandler(this.DutyLoadConnect_Click);
            // 
            // roketBaglan
            // 
            this.roketBaglan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roketBaglan.BackColor = System.Drawing.Color.LimeGreen;
            this.roketBaglan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roketBaglan.ForeColor = System.Drawing.Color.White;
            this.roketBaglan.IconChar = FontAwesome.Sharp.IconChar.Rocket;
            this.roketBaglan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roketBaglan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roketBaglan.IconSize = 28;
            this.roketBaglan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roketBaglan.Location = new System.Drawing.Point(330, 64);
            this.roketBaglan.Name = "roketBaglan";
            this.roketBaglan.Size = new System.Drawing.Size(132, 37);
            this.roketBaglan.TabIndex = 3;
            this.roketBaglan.Text = "Roket Bağlan";
            this.roketBaglan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roketBaglan.UseVisualStyleBackColor = false;
            this.roketBaglan.Click += new System.EventHandler(this.RocketConnect_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(441, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(778, 223);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Refresh);
            this.groupBox1.Controls.Add(this.veriGonderme);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(503, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 217);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İLETİŞİM AYARLARI PANELİ";
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.ForeColor = System.Drawing.Color.Black;
            this.Refresh.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            this.Refresh.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Refresh.IconSize = 25;
            this.Refresh.Location = new System.Drawing.Point(234, 34);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(41, 28);
            this.Refresh.TabIndex = 19;
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // veriGonderme
            // 
            this.veriGonderme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.veriGonderme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.veriGonderme.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.veriGonderme.IconChar = FontAwesome.Sharp.IconChar.CloudDownload;
            this.veriGonderme.IconColor = System.Drawing.Color.Red;
            this.veriGonderme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.veriGonderme.IconSize = 30;
            this.veriGonderme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.veriGonderme.Location = new System.Drawing.Point(74, 151);
            this.veriGonderme.Margin = new System.Windows.Forms.Padding(0);
            this.veriGonderme.Name = "veriGonderme";
            this.veriGonderme.Size = new System.Drawing.Size(129, 34);
            this.veriGonderme.TabIndex = 18;
            this.veriGonderme.Text = "Veri Gönder";
            this.veriGonderme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.veriGonderme.UseVisualStyleBackColor = false;
            this.veriGonderme.Click += new System.EventHandler(this.SendData_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "COM8",
            "COM5"});
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 22);
            this.comboBox1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "Port";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            ""});
            this.comboBox2.Location = new System.Drawing.Point(91, 97);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(128, 22);
            this.comboBox2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "BandWidth";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ExportToExcel);
            this.groupBox2.Controls.Add(this.clearMemory);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.hakemBaglan);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.gorevYukBaglan);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.roketBaglan);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 217);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UYDU KONTROL PANELİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bağlantı ayarları";
            // 
            // ExportToExcel
            // 
            this.ExportToExcel.ForeColor = System.Drawing.Color.Black;
            this.ExportToExcel.Location = new System.Drawing.Point(178, 169);
            this.ExportToExcel.Name = "ExportToExcel";
            this.ExportToExcel.Size = new System.Drawing.Size(99, 35);
            this.ExportToExcel.TabIndex = 6;
            this.ExportToExcel.Text = "Excel Dosya";
            this.ExportToExcel.UseVisualStyleBackColor = true;
            this.ExportToExcel.Click += new System.EventHandler(this.ExportToExcel_Click);
            // 
            // clearMemory
            // 
            this.clearMemory.ForeColor = System.Drawing.Color.Black;
            this.clearMemory.Location = new System.Drawing.Point(26, 167);
            this.clearMemory.Name = "clearMemory";
            this.clearMemory.Size = new System.Drawing.Size(99, 37);
            this.clearMemory.TabIndex = 4;
            this.clearMemory.Text = "Hafıza Temizle";
            this.clearMemory.UseVisualStyleBackColor = true;
            this.clearMemory.Click += new System.EventHandler(this.ClearMemory_Click);
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(26, 118);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(99, 37);
            this.button8.TabIndex = 4;
            this.button8.Text = "Bilgisayar Sıfırlama";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(178, 119);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 37);
            this.button7.TabIndex = 4;
            this.button7.Text = "Video Yükle";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(178, 64);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 37);
            this.button6.TabIndex = 4;
            this.button6.Text = "Video Seç";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(26, 64);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 37);
            this.button5.TabIndex = 4;
            this.button5.Text = "Yazılım Sıfırlama";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(213, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 14);
            this.label8.TabIndex = 3;
            this.label8.Text = "Video";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Uydu Bilgisayarı";
            // 
            // Rocket
            // 
            this.Rocket.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Rocket_DataReceived);
            // 
            // DutyLoad
            // 
            this.DutyLoad.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DutyLoad_DataReceived);
            // 
            // Referee
            // 
            this.Referee.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Referee_DataReceived);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chart1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chart4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.64124F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.35876F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(441, 592);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.chart1.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.X = 55.68545F;
            legend1.Position.Y = 13.6092F;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.LabelBackColor = System.Drawing.Color.Black;
            series1.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series1.LabelBorderWidth = 2;
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(214, 276);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "title1";
            title1.Text = "Sıcaklık ";
            this.chart1.Titles.Add(title1);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Chart1_MouseMove);
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.chart2.BackColor = System.Drawing.Color.Black;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            chartArea2.AxisX.LineWidth = 2;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            chartArea2.AxisY.LineWidth = 2;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 83.39081F;
            chartArea2.Position.Width = 94F;
            chartArea2.Position.X = 3F;
            chartArea2.Position.Y = 13.6092F;
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.X = 55.87851F;
            legend2.Position.Y = 3F;
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(223, 3);
            this.chart2.Name = "chart2";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series2.LabelBackColor = System.Drawing.Color.White;
            series2.LabelForeColor = System.Drawing.Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(215, 276);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            title2.Text = "Basınç";
            this.chart2.Titles.Add(title2);
            this.chart2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Chart2_MouseMove);
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.Black;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            chartArea3.AxisX.LineWidth = 2;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            chartArea3.AxisY.LineWidth = 2;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea3.BackColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "Legend1";
            legend3.Position.Auto = false;
            legend3.Position.X = 55.68545F;
            legend3.Position.Y = 3F;
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(3, 285);
            this.chart3.Name = "chart3";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Yellow;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(214, 300);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            title3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title3.ForeColor = System.Drawing.Color.White;
            title3.Name = "Title1";
            title3.Text = "Yükseklik";
            this.chart3.Titles.Add(title3);
            this.chart3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Chart3_MouseMove);
            // 
            // chart4
            // 
            this.chart4.BackColor = System.Drawing.Color.Black;
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            chartArea4.AxisX.LineWidth = 2;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            chartArea4.AxisY.LineWidth = 2;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea4.BackColor = System.Drawing.Color.Black;
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Name = "Legend1";
            legend4.Position.Auto = false;
            legend4.Position.X = 55.87851F;
            legend4.Position.Y = 12.99842F;
            this.chart4.Legends.Add(legend4);
            this.chart4.Location = new System.Drawing.Point(223, 285);
            this.chart4.Name = "chart4";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart4.Series.Add(series4);
            this.chart4.Size = new System.Drawing.Size(215, 300);
            this.chart4.TabIndex = 3;
            this.chart4.Text = "chart4";
            title4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title4.ForeColor = System.Drawing.Color.White;
            title4.Name = "Title1";
            title4.Text = "İniş Hızı";
            this.chart4.Titles.Add(title4);
            this.chart4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Chart4_MouseMove);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(441, 223);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.66364F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33637F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(778, 369);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.C2,
            this.C3,
            this.C4,
            this.C5,
            this.C6,
            this.C7,
            this.C8,
            this.C9,
            this.C10,
            this.C11,
            this.C12,
            this.C13,
            this.C14,
            this.C15,
            this.C16,
            this.C17,
            this.C18,
            this.C19,
            this.C20});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 44);
            this.dataGridView1.TabIndex = 15;
            // 
            // C1
            // 
            this.C1.HeaderText = "Paket Numarası";
            this.C1.Name = "C1";
            // 
            // C2
            // 
            this.C2.HeaderText = "Uydu Statüsü";
            this.C2.Name = "C2";
            // 
            // C3
            // 
            this.C3.HeaderText = "Hata Kodu";
            this.C3.Name = "C3";
            // 
            // C4
            // 
            this.C4.HeaderText = "Gönderme Saati";
            this.C4.Name = "C4";
            // 
            // C5
            // 
            this.C5.HeaderText = "Basınç 1";
            this.C5.Name = "C5";
            // 
            // C6
            // 
            this.C6.HeaderText = "Basınç 2";
            this.C6.Name = "C6";
            // 
            // C7
            // 
            this.C7.HeaderText = "Yükseklik 1";
            this.C7.Name = "C7";
            // 
            // C8
            // 
            this.C8.HeaderText = "Yükseklik 2";
            this.C8.Name = "C8";
            // 
            // C9
            // 
            this.C9.HeaderText = "İniş Hızı";
            this.C9.Name = "C9";
            // 
            // C10
            // 
            this.C10.HeaderText = "Pil Gerilimi";
            this.C10.Name = "C10";
            // 
            // C11
            // 
            this.C11.HeaderText = "Latitute 1";
            this.C11.Name = "C11";
            // 
            // C12
            // 
            this.C12.HeaderText = "Longitute 1";
            this.C12.Name = "C12";
            // 
            // C13
            // 
            this.C13.HeaderText = "Altitude 1";
            this.C13.Name = "C13";
            // 
            // C14
            // 
            this.C14.HeaderText = "Latitude 2";
            this.C14.Name = "C14";
            // 
            // C15
            // 
            this.C15.HeaderText = "Longitude 2";
            this.C15.Name = "C15";
            // 
            // C16
            // 
            this.C16.HeaderText = "Altitude 2";
            this.C16.Name = "C16";
            // 
            // C17
            // 
            this.C17.HeaderText = "Pitch";
            this.C17.Name = "C17";
            // 
            // C18
            // 
            this.C18.HeaderText = "Roll";
            this.C18.Name = "C18";
            // 
            // C19
            // 
            this.C19.HeaderText = "Yaw";
            this.C19.Name = "C19";
            // 
            // C20
            // 
            this.C20.HeaderText = "Takım No";
            this.C20.Name = "C20";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel9, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(772, 313);
            this.tableLayoutPanel5.TabIndex = 16;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.groupBox7, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(380, 307);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.gMapControl1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(374, 147);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "AVİYONİK GPS";
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(3, 18);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(368, 126);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.gMapControl2);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(3, 156);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(374, 148);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "YÜK GPS";
            // 
            // gMapControl2
            // 
            this.gMapControl2.Bearing = 0F;
            this.gMapControl2.CanDragMap = true;
            this.gMapControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl2.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl2.GrayScaleMode = false;
            this.gMapControl2.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl2.LevelsKeepInMemory = 5;
            this.gMapControl2.Location = new System.Drawing.Point(3, 18);
            this.gMapControl2.MarkersEnabled = true;
            this.gMapControl2.MaxZoom = 2;
            this.gMapControl2.MinZoom = 2;
            this.gMapControl2.MouseWheelZoomEnabled = true;
            this.gMapControl2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl2.Name = "gMapControl2";
            this.gMapControl2.NegativeMode = false;
            this.gMapControl2.PolygonsEnabled = true;
            this.gMapControl2.RetryLoadTile = 0;
            this.gMapControl2.RoutesEnabled = true;
            this.gMapControl2.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl2.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl2.ShowTileGridLines = false;
            this.gMapControl2.Size = new System.Drawing.Size(368, 127);
            this.gMapControl2.TabIndex = 0;
            this.gMapControl2.Zoom = 0D;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.groupBox8, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.groupBox9, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(389, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(380, 307);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // groupBox8
            // 
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(374, 147);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "KAMERA";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.glControl1);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.ForeColor = System.Drawing.Color.White;
            this.groupBox9.Location = new System.Drawing.Point(3, 156);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(374, 148);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "EKSEN";
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControl1.Location = new System.Drawing.Point(3, 18);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(368, 127);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1540, 592);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Yer İstasyonu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

            }

            #endregion

            private System.CodeDom.CodeTypeReference backgroundWorker2;
            private System.ComponentModel.BackgroundWorker backgroundWorker1;
            private TableLayoutPanel tableLayoutPanel2;
            private GroupBox groupBox3;
            private GroupBox groupBox4;
            private GroupBox groupBox5;
            private TableLayoutPanel tableLayoutPanel4;
            private GroupBox groupBox2;
            private Button clearMemory;
            private Button button8;
            private Button button7;
            private Button button6;
            private Button button5;
            private Label label8;
            private Label label5;
            private GroupBox groupBox1;
            private ComboBox comboBox1;
            private Label label7;
            private ComboBox comboBox2;
            private Label label6;
            private TableLayoutPanel tableLayoutPanel7;
            private Button SatelliteClear;
            private TableLayoutPanel tableLayoutPanel8;
            private Panel panel2;
            private Label label9;
            private Label pressureLabel;
            private Label tempLabel;
            private Label label12;
            private Label rollLabel;
            private Panel panel3;
            private Label label14;
            private Label altitudeLabel;
            private Label label16;
            private Label pitchLabel;
            private Label yawLabel;
            private Panel panel4;
            private Label label19;
            private Label label20;
            private Label label21;
            private Panel panel6;
            private Label label26;
            private Label label27;
            private Label label28;
            private Label label29;
        private Panel panel5;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label37;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label45;
        private Label label44;
        private Label label43;
        private Label label41;
        private Label label42;
        private Label label40;
        private Label label39;
        private Label label38;
        private Label label50;
        private Label label49;
        private Label label48;
        private Label label47;
        private Label label46;
        private FontAwesome.Sharp.IconButton veriGonderme;
        private System.IO.Ports.SerialPort Rocket;
        private System.IO.Ports.SerialPort DutyLoad;
        private System.IO.Ports.SerialPort Referee;
        private FontAwesome.Sharp.IconButton hakemBaglan;
        private FontAwesome.Sharp.IconButton gorevYukBaglan;
        private FontAwesome.Sharp.IconButton roketBaglan;
        private FontAwesome.Sharp.IconButton Refresh;
        private TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private Button ExportToExcel;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn C1;
        private DataGridViewTextBoxColumn C2;
        private DataGridViewTextBoxColumn C3;
        private DataGridViewTextBoxColumn C4;
        private DataGridViewTextBoxColumn C5;
        private DataGridViewTextBoxColumn C6;
        private DataGridViewTextBoxColumn C7;
        private DataGridViewTextBoxColumn C8;
        private DataGridViewTextBoxColumn C9;
        private DataGridViewTextBoxColumn C10;
        private DataGridViewTextBoxColumn C11;
        private DataGridViewTextBoxColumn C12;
        private DataGridViewTextBoxColumn C13;
        private DataGridViewTextBoxColumn C14;
        private DataGridViewTextBoxColumn C15;
        private DataGridViewTextBoxColumn C16;
        private DataGridViewTextBoxColumn C17;
        private DataGridViewTextBoxColumn C18;
        private DataGridViewTextBoxColumn C19;
        private DataGridViewTextBoxColumn C20;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private TableLayoutPanel tableLayoutPanel9;
        private GroupBox groupBox8;
        private GroupBox groupBox9;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private GMap.NET.WindowsForms.GMapControl gMapControl2;
        private OpenTK.GLControl glControl1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Label Rev;
        private RichTextBox richTextBox1;
        private Label GYEV;
        private RichTextBox richTextBox2;
        private Label rmdc;
        private Label label2;
    }
    }


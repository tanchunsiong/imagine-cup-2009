// Motion Detector
//
// Copyright © Andrew Kirillov, 2005
// andrew.kirillov@gmail.com
//

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using VideoSource;
using Tiger.Video.VFW;

namespace motion
{
    /// <summary>
    /// Summary description for MainForm
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        // statistics
        private const int statLength = 15;
        private int statIndex = 0, statReady = 0;
        private int[] statCount = new int[statLength];

        private IMotionDetector detector = new MotionDetector3Optimized();
        private int detectorType = 4;
        private int intervalsToSave = 0;

        private AVIWriter writer = null;
        private bool saveOnMotion = false;

        private System.Windows.Forms.MenuItem fileItem;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem exitFileItem;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Timers.Timer timer;
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.StatusBarPanel fpsPanel;
        private System.Windows.Forms.Panel panel;
        private motion.CameraWindow cameraWindow;
        private System.Windows.Forms.MenuItem motionItem;
        private System.Windows.Forms.MenuItem detector3OptimizedMotionItem;
        private System.Windows.Forms.MenuItem openLocalFileItem;
        private Button btnGFPDetector;
        private Label lblGFPResultL;
        private Timer timer1;
        private IContainer components;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private GroupBox groupBox3;
        private Label lblGFPResult;
        private Label label1;
        private Button btnVisualRainFall;
        private Label lblRainfall;
        private Label label5;
        private Timer tmrRainfall;
        private int count = 0;
        private Label lblAirQuality;
        private Label lblewr;
        private Label label6;
        private Button btnAirQuality;
        private Timer tmrAir;
        private dotnetCHARTING.WinForms.Chart chart1;
        private Timer tmrStream;
        private int raincount = 0;
        private int samplex = 0;
        private int sampley = 0;
        private int airquality = 0;
        DataTable data;
        private int airindex;
        private int steamtick = 0;

        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            dotnetCHARTING.WinForms.Annotation annotation1 = new dotnetCHARTING.WinForms.Annotation();
            dotnetCHARTING.WinForms.Label label2 = new dotnetCHARTING.WinForms.Label();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.fileItem = new System.Windows.Forms.MenuItem();
            this.openLocalFileItem = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.exitFileItem = new System.Windows.Forms.MenuItem();
            this.motionItem = new System.Windows.Forms.MenuItem();
            this.detector3OptimizedMotionItem = new System.Windows.Forms.MenuItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Timers.Timer();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.fpsPanel = new System.Windows.Forms.StatusBarPanel();
            this.panel = new System.Windows.Forms.Panel();
            this.chart1 = new dotnetCHARTING.WinForms.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAirQuality = new System.Windows.Forms.Label();
            this.lblewr = new System.Windows.Forms.Label();
            this.lblRainfall = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGFPResult = new System.Windows.Forms.Label();
            this.lblGFPResultL = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAirQuality = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVisualRainFall = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGFPDetector = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cameraWindow = new motion.CameraWindow();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmrRainfall = new System.Windows.Forms.Timer(this.components);
            this.tmrAir = new System.Windows.Forms.Timer(this.components);
            this.tmrStream = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsPanel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileItem,
            this.motionItem});
            // 
            // fileItem
            // 
            this.fileItem.Index = 0;
            this.fileItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.openLocalFileItem,
            this.menuItem1,
            this.exitFileItem});
            this.fileItem.Text = "&File";
            // 
            // openLocalFileItem
            // 
            this.openLocalFileItem.Index = 0;
            this.openLocalFileItem.Text = "Open &Local Device";
            this.openLocalFileItem.Click += new System.EventHandler(this.openLocalFileItem_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.Text = "-";
            // 
            // exitFileItem
            // 
            this.exitFileItem.Index = 2;
            this.exitFileItem.Text = "E&xit";
            this.exitFileItem.Click += new System.EventHandler(this.exitFileItem_Click);
            // 
            // motionItem
            // 
            this.motionItem.Index = 1;
            this.motionItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.detector3OptimizedMotionItem});
            this.motionItem.Text = "&Motion";
            this.motionItem.Popup += new System.EventHandler(this.motionItem_Popup);
            // 
            // detector3OptimizedMotionItem
            // 
            this.detector3OptimizedMotionItem.Index = 0;
            this.detector3OptimizedMotionItem.Text = "Motion Detection (Bit Comparison)";
            this.detector3OptimizedMotionItem.Click += new System.EventHandler(this.detector3OptimizedMotionItem_Click);
            // 
            // ofd
            // 
            this.ofd.Filter = "AVI files (*.avi)|*.avi";
            this.ofd.Title = "Open movie";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.SynchronizingObject = this;
            this.timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_Elapsed);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 532);
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.fpsPanel});
            this.statusBar.ShowPanels = true;
            this.statusBar.Size = new System.Drawing.Size(970, 22);
            this.statusBar.TabIndex = 1;
            // 
            // fpsPanel
            // 
            this.fpsPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.fpsPanel.Name = "fpsPanel";
            this.fpsPanel.Width = 953;
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.chart1);
            this.panel.Controls.Add(this.groupBox3);
            this.panel.Controls.Add(this.groupBox2);
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.label3);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(970, 532);
            this.panel.TabIndex = 2;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // chart1
            // 
            this.chart1.Background.Color = System.Drawing.Color.White;
            annotation1.Background.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            annotation1.DynamicSize = true;
            annotation1.InteriorLine.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            annotation1.InteriorLine.Visible = true;
            annotation1.Line.Color = System.Drawing.Color.Gray;
            annotation1.Line.Visible = true;
            annotation1.Orientation = dotnetCHARTING.WinForms.Orientation.TopRight;
            annotation1.Padding = 2;
            annotation1.Shadow.Visible = false;
            annotation1.Size = new System.Drawing.Size(529, 164);
            annotation1.Visible = true;
            this.chart1.Box = annotation1;
            this.chart1.ChartArea.Background.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.chart1.ChartArea.CornerTopLeft = dotnetCHARTING.WinForms.BoxCorner.Square;
            this.chart1.ChartArea.DefaultElement.DefaultSubValue.Line.Color = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.chart1.ChartArea.DefaultElement.DefaultSubValue.Line.Visible = true;
            this.chart1.ChartArea.DefaultElement.DefaultSubValue.Visible = true;
            this.chart1.ChartArea.DefaultElement.LegendEntry.DividerLine.Color = System.Drawing.Color.Empty;
            this.chart1.ChartArea.DefaultElement.LegendEntry.DividerLine.Visible = true;
            this.chart1.ChartArea.DefaultElement.Outline.Visible = true;
            this.chart1.ChartArea.DefaultElement.SmartLabel.Color = System.Drawing.Color.Empty;
            this.chart1.ChartArea.DefaultElement.SmartLabel.Line.Visible = true;
            this.chart1.ChartArea.InteriorLine.Color = System.Drawing.Color.LightGray;
            this.chart1.ChartArea.InteriorLine.Visible = true;
            this.chart1.ChartArea.Label.Font = new System.Drawing.Font("Tahoma", 8F);
            this.chart1.ChartArea.LegendBox.Background.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.chart1.ChartArea.LegendBox.CornerBottomRight = dotnetCHARTING.WinForms.BoxCorner.Cut;
            this.chart1.ChartArea.LegendBox.DefaultEntry.DividerLine.Color = System.Drawing.Color.Empty;
            this.chart1.ChartArea.LegendBox.DefaultEntry.DividerLine.Visible = true;
            this.chart1.ChartArea.LegendBox.HeaderEntry.DividerLine.Color = System.Drawing.Color.Gray;
            this.chart1.ChartArea.LegendBox.HeaderEntry.DividerLine.Visible = true;
            this.chart1.ChartArea.LegendBox.HeaderEntry.Name = "Name";
            this.chart1.ChartArea.LegendBox.HeaderEntry.SortOrder = -1;
            this.chart1.ChartArea.LegendBox.HeaderEntry.Value = "Value";
            this.chart1.ChartArea.LegendBox.HeaderEntry.Visible = false;
            this.chart1.ChartArea.LegendBox.InteriorLine.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart1.ChartArea.LegendBox.InteriorLine.Visible = true;
            this.chart1.ChartArea.LegendBox.Line.Color = System.Drawing.Color.Gray;
            this.chart1.ChartArea.LegendBox.Line.Visible = true;
            this.chart1.ChartArea.LegendBox.Padding = 4;
            this.chart1.ChartArea.LegendBox.Position = dotnetCHARTING.WinForms.LegendBoxPosition.Top;
            this.chart1.ChartArea.LegendBox.Visible = true;
            this.chart1.ChartArea.Line.Color = System.Drawing.Color.Gray;
            this.chart1.ChartArea.Line.Visible = true;
            this.chart1.ChartArea.StartDateOfYear = new System.DateTime(((long)(0)));
            this.chart1.ChartArea.TitleBox.Background.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.chart1.ChartArea.TitleBox.InteriorLine.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart1.ChartArea.TitleBox.InteriorLine.Visible = true;
            this.chart1.ChartArea.TitleBox.Label.Color = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(45)))), ((int)(((byte)(38)))));
            this.chart1.ChartArea.TitleBox.Label.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chart1.ChartArea.TitleBox.Line.Color = System.Drawing.Color.Gray;
            this.chart1.ChartArea.TitleBox.Line.Visible = true;
            this.chart1.ChartArea.TitleBox.Visible = true;
            this.chart1.ChartArea.XAxis.DefaultTick.GridLine.Color = System.Drawing.Color.LightGray;
            this.chart1.ChartArea.XAxis.DefaultTick.GridLine.Visible = true;
            this.chart1.ChartArea.XAxis.DefaultTick.Line.Length = 3;
            this.chart1.ChartArea.XAxis.DefaultTick.Line.Visible = true;
            this.chart1.ChartArea.XAxis.MinorTimeIntervalAdvanced.Start = new System.DateTime(((long)(0)));
            this.chart1.ChartArea.XAxis.ScaleBreakLine.Color = System.Drawing.Color.Gray;
            this.chart1.ChartArea.XAxis.ScaleBreakLine.Visible = true;
            this.chart1.ChartArea.XAxis.TickLabelSeparatorLine.Visible = true;
            this.chart1.ChartArea.XAxis.TimeIntervalAdvanced.Start = new System.DateTime(((long)(0)));
            this.chart1.ChartArea.XAxis.ZeroTick.GridLine.Color = System.Drawing.Color.Red;
            this.chart1.ChartArea.XAxis.ZeroTick.GridLine.Visible = true;
            this.chart1.ChartArea.XAxis.ZeroTick.Line.Length = 3;
            this.chart1.ChartArea.XAxis.ZeroTick.Line.Visible = true;
            this.chart1.ChartArea.YAxis.DefaultTick.GridLine.Color = System.Drawing.Color.LightGray;
            this.chart1.ChartArea.YAxis.DefaultTick.GridLine.Visible = true;
            this.chart1.ChartArea.YAxis.DefaultTick.Line.Length = 3;
            this.chart1.ChartArea.YAxis.DefaultTick.Line.Visible = true;
            this.chart1.ChartArea.YAxis.ScaleBreakLine.Color = System.Drawing.Color.Gray;
            this.chart1.ChartArea.YAxis.ScaleBreakLine.Visible = true;
            this.chart1.ChartArea.YAxis.TickLabelSeparatorLine.Visible = true;
            this.chart1.ChartArea.YAxis.TimeIntervalAdvanced.Start = new System.DateTime(((long)(0)));
            this.chart1.ChartArea.YAxis.ZeroTick.GridLine.Color = System.Drawing.Color.Red;
            this.chart1.ChartArea.YAxis.ZeroTick.GridLine.Visible = true;
            this.chart1.ChartArea.YAxis.ZeroTick.Line.Length = 3;
            this.chart1.ChartArea.YAxis.ZeroTick.Line.Visible = true;
            this.chart1.DataGrid = null;
            this.chart1.DefaultElement.DefaultSubValue.Line.Visible = true;
            this.chart1.DefaultElement.DefaultSubValue.Visible = true;
            this.chart1.DefaultElement.LegendEntry.DividerLine.Color = System.Drawing.Color.Empty;
            this.chart1.DefaultElement.LegendEntry.DividerLine.Visible = true;
            this.chart1.DefaultElement.Outline.Visible = true;
            this.chart1.Location = new System.Drawing.Point(385, 184);
            this.chart1.Name = "chart1";
            this.chart1.NoDataLabel.Text = "No Data";
            this.chart1.ObjectChart = label2;
            this.chart1.Size = new System.Drawing.Size(530, 165);
            this.chart1.SmartLabelLine.Visible = true;
            this.chart1.StartDateOfYear = new System.DateTime(((long)(0)));
            this.chart1.TabIndex = 9;
            this.chart1.TempDirectory = "C:\\Users\\v-yishen\\AppData\\Local\\Temp\\";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAirQuality);
            this.groupBox3.Controls.Add(this.lblewr);
            this.groupBox3.Controls.Add(this.lblRainfall);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblGFPResult);
            this.groupBox3.Controls.Add(this.lblGFPResultL);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(385, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 115);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detection Result";
            // 
            // lblAirQuality
            // 
            this.lblAirQuality.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirQuality.Location = new System.Drawing.Point(149, 82);
            this.lblAirQuality.Name = "lblAirQuality";
            this.lblAirQuality.Size = new System.Drawing.Size(373, 18);
            this.lblAirQuality.TabIndex = 9;
            this.lblAirQuality.Text = "Not Started";
            // 
            // lblewr
            // 
            this.lblewr.Location = new System.Drawing.Point(30, 82);
            this.lblewr.Name = "lblewr";
            this.lblewr.Size = new System.Drawing.Size(113, 18);
            this.lblewr.TabIndex = 8;
            this.lblewr.Text = "Air Quality:";
            // 
            // lblRainfall
            // 
            this.lblRainfall.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRainfall.Location = new System.Drawing.Point(149, 55);
            this.lblRainfall.Name = "lblRainfall";
            this.lblRainfall.Size = new System.Drawing.Size(373, 18);
            this.lblRainfall.TabIndex = 7;
            this.lblRainfall.Text = "Not Started";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(30, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rainfall Volume:";
            // 
            // lblGFPResult
            // 
            this.lblGFPResult.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGFPResult.Location = new System.Drawing.Point(149, 28);
            this.lblGFPResult.Name = "lblGFPResult";
            this.lblGFPResult.Size = new System.Drawing.Size(381, 18);
            this.lblGFPResult.TabIndex = 5;
            this.lblGFPResult.Text = "Not Started";
            // 
            // lblGFPResultL
            // 
            this.lblGFPResultL.Location = new System.Drawing.Point(30, 28);
            this.lblGFPResultL.Name = "lblGFPResultL";
            this.lblGFPResultL.Size = new System.Drawing.Size(80, 18);
            this.lblGFPResultL.TabIndex = 4;
            this.lblGFPResultL.Text = "GFP Result:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnAirQuality);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnVisualRainFall);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnGFPDetector);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 215);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monitoring Services";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(660, 50);
            this.label6.TabIndex = 8;
            this.label6.Text = "Using the gray/resolution measurements of a constant far object, the system is ab" +
                "le to co-relate and suggest the type of air pollutant situation within the area." +
                "";
            // 
            // btnAirQuality
            // 
            this.btnAirQuality.Enabled = false;
            this.btnAirQuality.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAirQuality.Location = new System.Drawing.Point(19, 141);
            this.btnAirQuality.Name = "btnAirQuality";
            this.btnAirQuality.Size = new System.Drawing.Size(181, 50);
            this.btnAirQuality.TabIndex = 7;
            this.btnAirQuality.Text = "Air Quality";
            this.btnAirQuality.UseVisualStyleBackColor = true;
            this.btnAirQuality.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Measure rainfall volume visually. Place blue ball in flash and point camera at a " +
                "distance of 30cm away from the foot of the measuring beaker. ";
            // 
            // btnVisualRainFall
            // 
            this.btnVisualRainFall.Enabled = false;
            this.btnVisualRainFall.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualRainFall.Location = new System.Drawing.Point(19, 85);
            this.btnVisualRainFall.Name = "btnVisualRainFall";
            this.btnVisualRainFall.Size = new System.Drawing.Size(181, 50);
            this.btnVisualRainFall.TabIndex = 5;
            this.btnVisualRainFall.Text = "Rain Measurement";
            this.btnVisualRainFall.UseVisualStyleBackColor = true;
            this.btnVisualRainFall.Click += new System.EventHandler(this.btnVisualRainFall_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(660, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // btnGFPDetector
            // 
            this.btnGFPDetector.Enabled = false;
            this.btnGFPDetector.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGFPDetector.Location = new System.Drawing.Point(19, 29);
            this.btnGFPDetector.Name = "btnGFPDetector";
            this.btnGFPDetector.Size = new System.Drawing.Size(181, 50);
            this.btnGFPDetector.TabIndex = 3;
            this.btnGFPDetector.Text = "GFP Detection";
            this.btnGFPDetector.UseVisualStyleBackColor = true;
            this.btnGFPDetector.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cameraWindow);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 286);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Capturing Feed";
            // 
            // cameraWindow
            // 
            this.cameraWindow.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cameraWindow.Camera = null;
            this.cameraWindow.Location = new System.Drawing.Point(19, 19);
            this.cameraWindow.Name = "cameraWindow";
            this.cameraWindow.Size = new System.Drawing.Size(322, 242);
            this.cameraWindow.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(620, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direct Imaging Nature Observation System";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrRainfall
            // 
            this.tmrRainfall.Interval = 2500;
            this.tmrRainfall.Tick += new System.EventHandler(this.tmrRainfall_Tick);
            // 
            // tmrAir
            // 
            this.tmrAir.Interval = 3000;
            this.tmrAir.Tick += new System.EventHandler(this.tmrAir_Tick);
            // 
            // tmrStream
            // 
            this.tmrStream.Interval = 3000;
            this.tmrStream.Tick += new System.EventHandler(this.tmrStream_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(970, 554);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.statusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "SmartFarm - Direct Imaging Nature Observation System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsPanel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new MainForm());
        }

        // On form closing
        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CloseFile();
        }

        // Close the main form
        private void exitFileItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        // Open local capture device
        private void openLocalFileItem_Click(object sender, System.EventArgs e)
        {
            CaptureDeviceForm form = new CaptureDeviceForm();

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                // create video source
                CaptureDevice localSource = new CaptureDevice();
                localSource.VideoSource = form.Device;

                // open it
                OpenVideoSource(localSource);
            }
        }

        // Open video source
        private void OpenVideoSource(IVideoSource source)
        {
            // set busy cursor
            this.Cursor = Cursors.WaitCursor;

            // close previous file
            CloseFile();

            // create camera
            Camera camera = new Camera(source, detector);
            // start camera
            camera.Start();

            // attach camera to camera window
            cameraWindow.Camera = camera;

            // reset statistics
            statIndex = statReady = 0;

            // set event handlers
            camera.NewFrame += new EventHandler(camera_NewFrame);
            camera.Alarm += new EventHandler(camera_Alarm);

            // start timer
            timer.Start();

            btnAirQuality.Enabled = true;
            btnGFPDetector.Enabled = true;
            btnVisualRainFall.Enabled = true;


            this.Cursor = Cursors.Default;
        }

        // Close current file
        private void CloseFile()
        {
            Camera camera = cameraWindow.Camera;

            if (camera != null)
            {
                // detach camera from camera window
                cameraWindow.Camera = null;

                // signal camera to stop
                camera.SignalToStop();
                // wait for the camera
                camera.WaitForStop();

                camera = null;

                if (detector != null)
                    detector.Reset();
            }

            if (writer != null)
            {
                writer.Dispose();
                writer = null;
            }
            intervalsToSave = 0;
        }

        // On timer event - gather statistic
        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Camera camera = cameraWindow.Camera;

            if (camera != null)
            {
                // get number of frames for the last second
                statCount[statIndex] = camera.FramesReceived;

                // increment indexes
                if (++statIndex >= statLength)
                    statIndex = 0;
                if (statReady < statLength)
                    statReady++;

                float fps = 0;

                // calculate average value
                for (int i = 0; i < statReady; i++)
                {
                    fps += statCount[i];
                }
                fps /= statReady;

                statCount[statIndex] = 0;

                fpsPanel.Text = fps.ToString("F2") + " fps";


            }

            // descrease save counter
            if (intervalsToSave > 0)
            {
                if ((--intervalsToSave == 0) && (writer != null))
                {
                    writer.Dispose();
                    writer = null;
                }
            }
        }

        // Remove any motion detectors
        private void noneMotionItem_Click(object sender, System.EventArgs e)
        {
            detector = null;
            detectorType = 0;
            SetMotionDetector();
        }

        // Select detector 3 - optimized
        private void detector3OptimizedMotionItem_Click(object sender, System.EventArgs e)
        {
            detector = new MotionDetector3Optimized();
            detectorType = 4;
            SetMotionDetector();
        }

        // Update motion detector
        private void SetMotionDetector()
        {
            Camera camera = cameraWindow.Camera;

            // set motion detector to camera
            if (camera != null)
            {
                camera.Lock();
                camera.MotionDetector = detector;

                // reset statistics
                statIndex = statReady = 0;
                camera.Unlock();
            }
        }

        // On "Motion" menu item popup
        private void motionItem_Popup(object sender, System.EventArgs e)
        {
            MenuItem[] items = new MenuItem[]
			{
				detector3OptimizedMotionItem,
		    };

            for (int i = 0; i < items.Length; i++)
            {
                items[i].Checked = (i == detectorType);
            }
        }

        // On alarm
        private void camera_Alarm(object sender, System.EventArgs e)
        {
            // save movie for 5 seconds after motion stops
            intervalsToSave = (int)(5 * (1000 / timer.Interval));
        }

        // On new frame
        private void camera_NewFrame(object sender, System.EventArgs e)
        {
            if ((intervalsToSave != 0) && (saveOnMotion == true))
            {
                // lets save the frame
                if (writer == null)
                {
                    // create file name
                    DateTime date = DateTime.Now;
                    String fileName = String.Format("{0}-{1}-{2} {3}-{4}-{5}.avi",
                        date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);

                    try
                    {
                        // create AVI writer
                        writer = new AVIWriter("wmv3");
                        // open AVI file
                        writer.Open(fileName, cameraWindow.Camera.Width, cameraWindow.Camera.Height);
                    }
                    catch (ApplicationException ex)
                    {
                        if (writer != null)
                        {
                            writer.Dispose();
                            writer = null;
                        }
                    }
                }

                // save the frame
                Camera camera = cameraWindow.Camera;

                camera.Lock();
                writer.AddFrame(camera.LastFrame);
                camera.Unlock();
            }
        }


        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblGFPResult.Text != "Not Started")
            {
                lblGFPResult.Text = "Not Started";
                timer1.Stop();
            }
            else
            {
                lblGFPResult.Text = "Started";
                //MessageBox.Show("GFP Monitoring Service started successfully. Polling time is set to 5 seconds by default.");
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Camera camera = cameraWindow.Camera;
            Bitmap bit;
            try
            {
                if (camera != null && camera.LastFrame != null)
                {
                    bit = (Bitmap)cameraWindow.Camera.LastFrame.Clone();
                    int countbit = 0;
                    int r, g, b;

                    for (int i = 0; i < bit.Height; i++)
                    {
                        for (int j = 0; j < bit.Width; j++)
                        {
                            r = int.Parse(bit.GetPixel(j, i).R.ToString());
                            g = int.Parse(bit.GetPixel(j, i).G.ToString());
                            b = int.Parse(bit.GetPixel(j, i).B.ToString());

                            if (g > 140 && r > 20 && r < 120 && b > 20 && b < 120)
                            {
                                countbit++;
                            }
                            if (g > 120 && g < 200 && r > 120 && r < 200 && b < 20)
                            {
                                countbit++;
                            }
                            if (g > 160&& r < 80 && b < 20)
                            {
                                countbit++;
                            }
                        }
                    }

                    lblGFPResult.Text = ((Convert.ToDouble(countbit) / (camera.LastFrame.Width * camera.LastFrame.Height)) * 100).ToString() + @"% Green Fluorescent Detected.";
                    count++;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tmrRainfall_Tick(object sender, EventArgs e)
        {
            raincount++;
            Camera camera = cameraWindow.Camera;
            Bitmap bit;
            try
            {
                if (camera != null && camera.LastFrame != null)
                {
                    bit = (Bitmap)cameraWindow.Camera.LastFrame.Clone();
                    //
                    int countbit = 0;
                    int r = 0;
                    int g = 0;
                    int b = 0;

                    for (int i = 0; i < bit.Height; i++)
                    {
                        for (int j = 0; j < bit.Width; j++)
                        {
                            //r = int.Parse(bit.GetPixel(j, i).R.ToString());
                            g = int.Parse(bit.GetPixel(j, i).G.ToString());
                            b = int.Parse(bit.GetPixel(j, i).B.ToString());
                            r = int.Parse(bit.GetPixel(j, i).R.ToString());
                            if (b > 170 && g < 80)
                            {
                                countbit = i;
                                lblRainfall.Text = (bit.Height - i).ToString() + " (DEBUG: " + raincount.ToString() + " B:" + b.ToString() + " G:" + g.ToString() + ")";
                                break;
                            }
                            if (b>110 && b<140 && g >80 && g <100 && r > 20 && r<80)
                            {
                                countbit = i;
                                lblRainfall.Text = (bit.Height - i).ToString() + " (DEBUG: " + raincount.ToString() + " B:" + b.ToString() + " G:" + g.ToString() + ")";
                                break;
                            }
                        }
                    }

                    //bit.Save(@"C:\Users\v-yishen\Desktop\" + System.Guid.NewGuid().ToString() + ".bmp");
                    countbit = 0;

                }


            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }


        }

        private void btnVisualRainFall_Click(object sender, EventArgs e)
        {
            if (lblRainfall.Text != "Not Started")
            {
                tmrRainfall.Stop();
                lblRainfall.Text = "Not Started";
            }
            else
            {
                lblRainfall.Text = "Started";
                tmrRainfall.Start();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (lblAirQuality.Text != "Not Started")
            {
                tmrAir.Stop();
                lblAirQuality.Text = "Not Started";
            }
            else
            {
                lblAirQuality.Text = "Started";
                tmrAir.Start();
            }
        }

        private void tmrAir_Tick(object sender, EventArgs e)
        {
            Camera camera = cameraWindow.Camera;
            airquality = 0;
            Bitmap bit;
            try
            {
                if (camera != null && camera.LastFrame != null)
                {
                    bit = (Bitmap)cameraWindow.Camera.LastFrame.Clone();
                    //gray color RGB is 
                    int r = 0;
                    int g = 0;
                    int b = 0;

                    for (int i = 0; i < bit.Height; i++)
                    {
                        for (int j = 0; j < bit.Width; j++)
                        {
                            r = int.Parse(bit.GetPixel(j, i).R.ToString());
                            g = int.Parse(bit.GetPixel(j, i).G.ToString());
                            b = int.Parse(bit.GetPixel(j, i).B.ToString());

                            //find the amount of gray pixel, defined as RGB of same value or +/- 5
                            if (r < g + 10 && r > g - 10)
                            {
                                airquality++;
                                //this is gray
                            }
                        }
                    }
                    airindex = (airquality * 100) / 76800;
                    //double airindex = (Convert.ToDouble(airquality.ToString()) / 50000.0) * 100.0;
                    string quality = null;
                    if (airindex > 80)
                        quality = "Serious Haze: Danger Level";
                    else if (airindex > 60)
                        quality = "Moderate Haze: Warning Level";
                    else if (airindex > 40)
                        quality = "Normal Level";
                    else
                        quality = "Good Quality";

                    lblAirQuality.Text = "Status: " + quality + " : " + int.Parse(airindex.ToString());
                    //bit.Save(@"C:\Users\v-yishen\Desktop\" + System.Guid.NewGuid().ToString() + ".bmp");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //chart1.Type = dotnetCHARTING.WinForms.ChartType.Scatter;
            chart1.Title = "Air Quality Monitoring";
            chart1.Series.Name = "Index";
            chart1.Series.Type = dotnetCHARTING.WinForms.SeriesType.Spline;
            chart1.XAxis.Label.Text = "Interval";
            chart1.YAxis.Label.Text = "Amount";
            data = new DataTable("Statistic");
            data.Columns.Add("Index");
            data.Columns.Add("Amount");

            chart1.Series.Data = data;
            chart1.XAxis.Scale = dotnetCHARTING.WinForms.Scale.Range;
            chart1.SeriesCollection.Add();
            tmrStream.Start();
        }

        private void tmrStream_Tick(object sender, EventArgs e)
        {

            if (airquality > 0)
            {
                steamtick++;
                chart1.Series.Type = dotnetCHARTING.WinForms.SeriesType.Spline;
                chart1.SeriesCollection.Clear();

                if (data.Rows.Count == 5)
                {
                    data.Rows[0].Delete();
                }

                DataRow row2 = data.NewRow();
                row2["Index"] = steamtick; ;
                row2["Amount"] = airindex;
                data.Rows.Add(row2);

                chart1.Series.Data = data;
                chart1.XAxis.Scale = dotnetCHARTING.WinForms.Scale.Range;
                chart1.SeriesCollection.Add();
                chart1.Refresh();
            }
        }
    }
}

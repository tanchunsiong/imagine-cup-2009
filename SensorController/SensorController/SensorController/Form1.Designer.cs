namespace SensorController
{
    partial class Form1
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
            this.txtBaroSensorStatus = new System.Windows.Forms.TextBox();
            this.txtGPSSensorStatus = new System.Windows.Forms.TextBox();
            this.txtGyroSensorStatus = new System.Windows.Forms.TextBox();
            this.txtLightSensorStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHumiditySensorStatus = new System.Windows.Forms.TextBox();
            this.btnBaroSensorSwitch = new System.Windows.Forms.Button();
            this.btnGPSSensorSwitch = new System.Windows.Forms.Button();
            this.btnLightSensorSwitch = new System.Windows.Forms.Button();
            this.btnGyroSensorSwitch = new System.Windows.Forms.Button();
            this.btnHumiditySensorSwitch = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTempSensorSwitch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTempSensorStatus = new System.Windows.Forms.TextBox();
            this.lblGFPResultL = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBaroWarning = new System.Windows.Forms.Label();
            this.txtBaroResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblYWarning = new System.Windows.Forms.Label();
            this.lblZWarning = new System.Windows.Forms.Label();
            this.lblXWarning = new System.Windows.Forms.Label();
            this.lblHumidityWarning = new System.Windows.Forms.Label();
            this.lblTempWarning = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGyroZG = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGyroYG = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtGyroXG = new System.Windows.Forms.TextBox();
            this.txtHumidityResult = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTempSensorResult = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tmrSensorResult = new System.Windows.Forms.Timer(this.components);
            this.btnStartAlert = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbStatus = new System.Windows.Forms.ListBox();
            this.windDirection = new CompassCard.CompassCard();
            this.label17 = new System.Windows.Forms.Label();
            this.WindStrength = new VerticalProgressBar.VerticalProgressBar();
            this.tmrGyro = new System.Windows.Forms.Timer(this.components);
            this.tmrLCDAlert = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBaroSensorStatus
            // 
            this.txtBaroSensorStatus.Enabled = false;
            this.txtBaroSensorStatus.Location = new System.Drawing.Point(203, 173);
            this.txtBaroSensorStatus.Name = "txtBaroSensorStatus";
            this.txtBaroSensorStatus.Size = new System.Drawing.Size(100, 24);
            this.txtBaroSensorStatus.TabIndex = 28;
            this.txtBaroSensorStatus.Text = "STOPPED";
            this.txtBaroSensorStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGPSSensorStatus
            // 
            this.txtGPSSensorStatus.Enabled = false;
            this.txtGPSSensorStatus.Location = new System.Drawing.Point(202, 141);
            this.txtGPSSensorStatus.Name = "txtGPSSensorStatus";
            this.txtGPSSensorStatus.Size = new System.Drawing.Size(100, 24);
            this.txtGPSSensorStatus.TabIndex = 27;
            this.txtGPSSensorStatus.Text = "STOPPED";
            this.txtGPSSensorStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGyroSensorStatus
            // 
            this.txtGyroSensorStatus.Enabled = false;
            this.txtGyroSensorStatus.Location = new System.Drawing.Point(202, 80);
            this.txtGyroSensorStatus.Name = "txtGyroSensorStatus";
            this.txtGyroSensorStatus.Size = new System.Drawing.Size(100, 24);
            this.txtGyroSensorStatus.TabIndex = 25;
            this.txtGyroSensorStatus.Text = "STOPPED";
            this.txtGyroSensorStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLightSensorStatus
            // 
            this.txtLightSensorStatus.Enabled = false;
            this.txtLightSensorStatus.Location = new System.Drawing.Point(203, 112);
            this.txtLightSensorStatus.Name = "txtLightSensorStatus";
            this.txtLightSensorStatus.Size = new System.Drawing.Size(100, 24);
            this.txtLightSensorStatus.TabIndex = 26;
            this.txtLightSensorStatus.Text = "STOPPED";
            this.txtLightSensorStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 41);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sensor Master Controller";
            // 
            // txtHumiditySensorStatus
            // 
            this.txtHumiditySensorStatus.Enabled = false;
            this.txtHumiditySensorStatus.Location = new System.Drawing.Point(203, 50);
            this.txtHumiditySensorStatus.Name = "txtHumiditySensorStatus";
            this.txtHumiditySensorStatus.Size = new System.Drawing.Size(100, 24);
            this.txtHumiditySensorStatus.TabIndex = 24;
            this.txtHumiditySensorStatus.Text = "STOPPED";
            this.txtHumiditySensorStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBaroSensorSwitch
            // 
            this.btnBaroSensorSwitch.Location = new System.Drawing.Point(309, 171);
            this.btnBaroSensorSwitch.Name = "btnBaroSensorSwitch";
            this.btnBaroSensorSwitch.Size = new System.Drawing.Size(85, 23);
            this.btnBaroSensorSwitch.TabIndex = 23;
            this.btnBaroSensorSwitch.Text = "START";
            this.btnBaroSensorSwitch.UseVisualStyleBackColor = true;
            this.btnBaroSensorSwitch.Click += new System.EventHandler(this.btnBaroSensorSwitch_Click);
            // 
            // btnGPSSensorSwitch
            // 
            this.btnGPSSensorSwitch.Location = new System.Drawing.Point(309, 142);
            this.btnGPSSensorSwitch.Name = "btnGPSSensorSwitch";
            this.btnGPSSensorSwitch.Size = new System.Drawing.Size(85, 23);
            this.btnGPSSensorSwitch.TabIndex = 22;
            this.btnGPSSensorSwitch.Text = "START";
            this.btnGPSSensorSwitch.UseVisualStyleBackColor = true;
            this.btnGPSSensorSwitch.Click += new System.EventHandler(this.btnGPSSensorSwitch_Click);
            // 
            // btnLightSensorSwitch
            // 
            this.btnLightSensorSwitch.Location = new System.Drawing.Point(309, 114);
            this.btnLightSensorSwitch.Name = "btnLightSensorSwitch";
            this.btnLightSensorSwitch.Size = new System.Drawing.Size(85, 23);
            this.btnLightSensorSwitch.TabIndex = 21;
            this.btnLightSensorSwitch.Text = "START";
            this.btnLightSensorSwitch.UseVisualStyleBackColor = true;
            this.btnLightSensorSwitch.Click += new System.EventHandler(this.btnLightSensorSwitch_Click);
            // 
            // btnGyroSensorSwitch
            // 
            this.btnGyroSensorSwitch.Location = new System.Drawing.Point(309, 85);
            this.btnGyroSensorSwitch.Name = "btnGyroSensorSwitch";
            this.btnGyroSensorSwitch.Size = new System.Drawing.Size(85, 23);
            this.btnGyroSensorSwitch.TabIndex = 20;
            this.btnGyroSensorSwitch.Text = "START";
            this.btnGyroSensorSwitch.UseVisualStyleBackColor = true;
            this.btnGyroSensorSwitch.Click += new System.EventHandler(this.btnGyroSensorSwitch_Click);
            // 
            // btnHumiditySensorSwitch
            // 
            this.btnHumiditySensorSwitch.Location = new System.Drawing.Point(309, 53);
            this.btnHumiditySensorSwitch.Name = "btnHumiditySensorSwitch";
            this.btnHumiditySensorSwitch.Size = new System.Drawing.Size(85, 23);
            this.btnHumiditySensorSwitch.TabIndex = 19;
            this.btnHumiditySensorSwitch.Text = "START";
            this.btnHumiditySensorSwitch.UseVisualStyleBackColor = true;
            this.btnHumiditySensorSwitch.Click += new System.EventHandler(this.btnHumiditySensorSwitch_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 629);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(875, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(141, 17);
            this.lblStatus.Text = "Sensor Controller Started.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBaroSensorStatus);
            this.groupBox3.Controls.Add(this.txtGPSSensorStatus);
            this.groupBox3.Controls.Add(this.txtLightSensorStatus);
            this.groupBox3.Controls.Add(this.txtGyroSensorStatus);
            this.groupBox3.Controls.Add(this.txtHumiditySensorStatus);
            this.groupBox3.Controls.Add(this.btnBaroSensorSwitch);
            this.groupBox3.Controls.Add(this.btnGPSSensorSwitch);
            this.groupBox3.Controls.Add(this.btnLightSensorSwitch);
            this.groupBox3.Controls.Add(this.btnGyroSensorSwitch);
            this.groupBox3.Controls.Add(this.btnHumiditySensorSwitch);
            this.groupBox3.Controls.Add(this.btnTempSensorSwitch);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtTempSensorStatus);
            this.groupBox3.Controls.Add(this.lblGFPResultL);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(19, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 215);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sensor Status";
            // 
            // btnTempSensorSwitch
            // 
            this.btnTempSensorSwitch.Location = new System.Drawing.Point(309, 24);
            this.btnTempSensorSwitch.Name = "btnTempSensorSwitch";
            this.btnTempSensorSwitch.Size = new System.Drawing.Size(85, 23);
            this.btnTempSensorSwitch.TabIndex = 18;
            this.btnTempSensorSwitch.Text = "START";
            this.btnTempSensorSwitch.UseVisualStyleBackColor = true;
            this.btnTempSensorSwitch.Click += new System.EventHandler(this.btnTempSensorSwitch_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(30, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Barometer:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(30, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "GPS:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(30, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Light Intensity Sensor:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gyroscope Sensor:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Humidity Sensor:";
            // 
            // txtTempSensorStatus
            // 
            this.txtTempSensorStatus.Enabled = false;
            this.txtTempSensorStatus.Location = new System.Drawing.Point(202, 22);
            this.txtTempSensorStatus.Name = "txtTempSensorStatus";
            this.txtTempSensorStatus.Size = new System.Drawing.Size(100, 24);
            this.txtTempSensorStatus.TabIndex = 7;
            this.txtTempSensorStatus.Text = "STOPPED";
            this.txtTempSensorStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGFPResultL
            // 
            this.lblGFPResultL.Location = new System.Drawing.Point(30, 28);
            this.lblGFPResultL.Name = "lblGFPResultL";
            this.lblGFPResultL.Size = new System.Drawing.Size(166, 18);
            this.lblGFPResultL.TabIndex = 4;
            this.lblGFPResultL.Text = "Temperature Sensor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBaroWarning);
            this.groupBox1.Controls.Add(this.txtBaroResult);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblYWarning);
            this.groupBox1.Controls.Add(this.lblZWarning);
            this.groupBox1.Controls.Add(this.lblXWarning);
            this.groupBox1.Controls.Add(this.lblHumidityWarning);
            this.groupBox1.Controls.Add(this.lblTempWarning);
            this.groupBox1.Controls.Add(this.txtLat);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtGyroZG);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtGyroYG);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtLong);
            this.groupBox1.Controls.Add(this.txtGyroXG);
            this.groupBox1.Controls.Add(this.txtHumidityResult);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTempSensorResult);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(457, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 339);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensor Result";
            // 
            // lblBaroWarning
            // 
            this.lblBaroWarning.AutoSize = true;
            this.lblBaroWarning.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaroWarning.ForeColor = System.Drawing.Color.Red;
            this.lblBaroWarning.Location = new System.Drawing.Point(308, 81);
            this.lblBaroWarning.Name = "lblBaroWarning";
            this.lblBaroWarning.Size = new System.Drawing.Size(68, 17);
            this.lblBaroWarning.TabIndex = 50;
            this.lblBaroWarning.Text = "[Warning]";
            this.lblBaroWarning.Visible = false;
            // 
            // txtBaroResult
            // 
            this.txtBaroResult.Enabled = false;
            this.txtBaroResult.Location = new System.Drawing.Point(204, 77);
            this.txtBaroResult.Name = "txtBaroResult";
            this.txtBaroResult.Size = new System.Drawing.Size(100, 24);
            this.txtBaroResult.TabIndex = 48;
            this.txtBaroResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(31, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 18);
            this.label7.TabIndex = 46;
            this.label7.Text = "Barometer:";
            // 
            // lblYWarning
            // 
            this.lblYWarning.AutoSize = true;
            this.lblYWarning.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYWarning.ForeColor = System.Drawing.Color.Red;
            this.lblYWarning.Location = new System.Drawing.Point(310, 166);
            this.lblYWarning.Name = "lblYWarning";
            this.lblYWarning.Size = new System.Drawing.Size(68, 17);
            this.lblYWarning.TabIndex = 43;
            this.lblYWarning.Text = "[Warning]";
            this.lblYWarning.Visible = false;
            // 
            // lblZWarning
            // 
            this.lblZWarning.AutoSize = true;
            this.lblZWarning.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZWarning.ForeColor = System.Drawing.Color.Red;
            this.lblZWarning.Location = new System.Drawing.Point(310, 191);
            this.lblZWarning.Name = "lblZWarning";
            this.lblZWarning.Size = new System.Drawing.Size(68, 17);
            this.lblZWarning.TabIndex = 42;
            this.lblZWarning.Text = "[Warning]";
            this.lblZWarning.Visible = false;
            // 
            // lblXWarning
            // 
            this.lblXWarning.AutoSize = true;
            this.lblXWarning.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXWarning.ForeColor = System.Drawing.Color.Red;
            this.lblXWarning.Location = new System.Drawing.Point(308, 142);
            this.lblXWarning.Name = "lblXWarning";
            this.lblXWarning.Size = new System.Drawing.Size(68, 17);
            this.lblXWarning.TabIndex = 40;
            this.lblXWarning.Text = "[Warning]";
            this.lblXWarning.Visible = false;
            // 
            // lblHumidityWarning
            // 
            this.lblHumidityWarning.AutoSize = true;
            this.lblHumidityWarning.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidityWarning.ForeColor = System.Drawing.Color.Red;
            this.lblHumidityWarning.Location = new System.Drawing.Point(309, 57);
            this.lblHumidityWarning.Name = "lblHumidityWarning";
            this.lblHumidityWarning.Size = new System.Drawing.Size(68, 17);
            this.lblHumidityWarning.TabIndex = 39;
            this.lblHumidityWarning.Text = "[Warning]";
            this.lblHumidityWarning.Visible = false;
            // 
            // lblTempWarning
            // 
            this.lblTempWarning.AutoSize = true;
            this.lblTempWarning.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempWarning.ForeColor = System.Drawing.Color.Red;
            this.lblTempWarning.Location = new System.Drawing.Point(308, 28);
            this.lblTempWarning.Name = "lblTempWarning";
            this.lblTempWarning.Size = new System.Drawing.Size(68, 17);
            this.lblTempWarning.TabIndex = 38;
            this.lblTempWarning.Text = "[Warning]";
            this.lblTempWarning.Visible = false;
            // 
            // txtLat
            // 
            this.txtLat.Enabled = false;
            this.txtLat.Location = new System.Drawing.Point(201, 270);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(100, 24);
            this.txtLat.TabIndex = 37;
            this.txtLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(30, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 18);
            this.label15.TabIndex = 33;
            this.label15.Text = "Z-g";
            // 
            // txtGyroZG
            // 
            this.txtGyroZG.Enabled = false;
            this.txtGyroZG.Location = new System.Drawing.Point(204, 191);
            this.txtGyroZG.Name = "txtGyroZG";
            this.txtGyroZG.Size = new System.Drawing.Size(100, 24);
            this.txtGyroZG.TabIndex = 32;
            this.txtGyroZG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(29, 273);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(166, 18);
            this.label18.TabIndex = 36;
            this.label18.Text = "Latitute:";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(31, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 18);
            this.label14.TabIndex = 31;
            this.label14.Text = "Y-g";
            // 
            // txtGyroYG
            // 
            this.txtGyroYG.Enabled = false;
            this.txtGyroYG.Location = new System.Drawing.Point(204, 163);
            this.txtGyroYG.Name = "txtGyroYG";
            this.txtGyroYG.Size = new System.Drawing.Size(100, 24);
            this.txtGyroYG.TabIndex = 30;
            this.txtGyroYG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(29, 247);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 18);
            this.label16.TabIndex = 34;
            this.label16.Text = "Longtitute:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(31, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 18);
            this.label13.TabIndex = 29;
            this.label13.Text = "X-g";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Location Information";
            // 
            // txtLong
            // 
            this.txtLong.Enabled = false;
            this.txtLong.Location = new System.Drawing.Point(201, 241);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(100, 24);
            this.txtLong.TabIndex = 27;
            this.txtLong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGyroXG
            // 
            this.txtGyroXG.Enabled = false;
            this.txtGyroXG.Location = new System.Drawing.Point(203, 135);
            this.txtGyroXG.Name = "txtGyroXG";
            this.txtGyroXG.Size = new System.Drawing.Size(100, 24);
            this.txtGyroXG.TabIndex = 25;
            this.txtGyroXG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHumidityResult
            // 
            this.txtHumidityResult.Enabled = false;
            this.txtHumidityResult.Location = new System.Drawing.Point(203, 50);
            this.txtHumidityResult.Name = "txtHumidityResult";
            this.txtHumidityResult.Size = new System.Drawing.Size(100, 24);
            this.txtHumidityResult.TabIndex = 24;
            this.txtHumidityResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Gyroscope Sensor";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(30, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "Humidity Sensor:";
            // 
            // txtTempSensorResult
            // 
            this.txtTempSensorResult.Enabled = false;
            this.txtTempSensorResult.Location = new System.Drawing.Point(202, 22);
            this.txtTempSensorResult.Name = "txtTempSensorResult";
            this.txtTempSensorResult.Size = new System.Drawing.Size(100, 24);
            this.txtTempSensorResult.TabIndex = 7;
            this.txtTempSensorResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(31, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = "Temperature Sensor:";
            // 
            // tmrSensorResult
            // 
            this.tmrSensorResult.Interval = 5000;
            this.tmrSensorResult.Tick += new System.EventHandler(this.tmrSensorResult_Tick);
            // 
            // btnStartAlert
            // 
            this.btnStartAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartAlert.Location = new System.Drawing.Point(19, 282);
            this.btnStartAlert.Name = "btnStartAlert";
            this.btnStartAlert.Size = new System.Drawing.Size(246, 117);
            this.btnStartAlert.TabIndex = 15;
            this.btnStartAlert.Text = "Start Alert Service";
            this.btnStartAlert.UseVisualStyleBackColor = true;
            this.btnStartAlert.Click += new System.EventHandler(this.btnStartAlert_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbStatus);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 405);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(835, 208);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensor Log:";
            // 
            // lbStatus
            // 
            this.lbStatus.FormattingEnabled = true;
            this.lbStatus.ItemHeight = 15;
            this.lbStatus.Location = new System.Drawing.Point(13, 23);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(803, 169);
            this.lbStatus.TabIndex = 0;
            // 
            // windDirection
            // 
            this.windDirection.Angle = 360F;
            this.windDirection.ArrowColor = System.Drawing.Color.Red;
            this.windDirection.BackColor = System.Drawing.Color.Black;
            this.windDirection.Location = new System.Drawing.Point(281, 302);
            this.windDirection.Name = "windDirection";
            this.windDirection.NumNumbers = 10;
            this.windDirection.Range = 36F;
            this.windDirection.RedZone = 360F;
            this.windDirection.Size = new System.Drawing.Size(103, 97);
            this.windDirection.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(271, 282);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(166, 18);
            this.label17.TabIndex = 29;
            this.label17.Text = "Wind Direction:";
            // 
            // WindStrength
            // 
            this.WindStrength.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            this.WindStrength.Color = System.Drawing.Color.Blue;
            this.WindStrength.Location = new System.Drawing.Point(390, 282);
            this.WindStrength.Maximum = 100;
            this.WindStrength.Minimum = 0;
            this.WindStrength.Name = "WindStrength";
            this.WindStrength.Size = new System.Drawing.Size(23, 120);
            this.WindStrength.Step = 10;
            this.WindStrength.Style = VerticalProgressBar.Styles.Solid;
            this.WindStrength.TabIndex = 31;
            this.WindStrength.Value = 0;
            // 
            // tmrGyro
            // 
            this.tmrGyro.Interval = 150;
            this.tmrGyro.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrLCDAlert
            // 
            this.tmrLCDAlert.Interval = 1000;
            this.tmrLCDAlert.Tick += new System.EventHandler(this.tmrLCDAlert_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 651);
            this.Controls.Add(this.WindStrength);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.windDirection);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStartAlert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "SmartFarm - Sensor Master Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBaroSensorStatus;
        private System.Windows.Forms.TextBox txtGPSSensorStatus;
        private System.Windows.Forms.TextBox txtGyroSensorStatus;
        private System.Windows.Forms.TextBox txtLightSensorStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHumiditySensorStatus;
        private System.Windows.Forms.Button btnBaroSensorSwitch;
        private System.Windows.Forms.Button btnGPSSensorSwitch;
        private System.Windows.Forms.Button btnLightSensorSwitch;
        private System.Windows.Forms.Button btnGyroSensorSwitch;
        private System.Windows.Forms.Button btnHumiditySensorSwitch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTempSensorSwitch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTempSensorStatus;
        private System.Windows.Forms.Label lblGFPResultL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtGyroXG;
        private System.Windows.Forms.TextBox txtHumidityResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTempSensorResult;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer tmrSensorResult;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGyroZG;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGyroYG;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTempWarning;
        private System.Windows.Forms.Label lblHumidityWarning;
        private System.Windows.Forms.Label lblXWarning;
        private System.Windows.Forms.Label lblYWarning;
        private System.Windows.Forms.Label lblZWarning;
        private System.Windows.Forms.Button btnStartAlert;
        private System.Windows.Forms.Label lblBaroWarning;
        private System.Windows.Forms.TextBox txtBaroResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbStatus;
        private CompassCard.CompassCard windDirection;
        private System.Windows.Forms.Label label17;
        private VerticalProgressBar.VerticalProgressBar WindStrength;
        private System.Windows.Forms.Timer tmrGyro;
        private System.Windows.Forms.Timer tmrLCDAlert;
    }
}


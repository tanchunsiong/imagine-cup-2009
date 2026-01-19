using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhidgetsWrapper;
using SMSSenderLibrary;
using GPSReceiverWrapper;

namespace SensorController
{
    public partial class Form1 : Form
    {
        //phidget sensors library object
        Sensor sensor;

        //sms sending library object
        SMSSender smssender;

        //gps receiver object
        GPSReceiver gpsreceiver;
        bool alertsent = false;
        bool startsms = false;
        int strength;
        bool ticker = true;

        public Form1()
        {
            InitializeComponent();
            sensor = new Sensor();
            smssender = new SMSSender();
            gpsreceiver = new GPSReceiver();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrSensorResult.Start();
            tmrGyro.Start();
            lblStatus.Text = "Sensor Controller Started";
            AddToStatus("Info","Sensor Controller Started");
            sensor.WriteToLED("Sensor Controller", "Status: Normal");
        }

        public void AddToStatus(string alerttype, string message)
        {
            lbStatus.Items.Add("("+alerttype+") "+DateTime.Now.ToString()+": "+message);
        }

        private void btnTempSensorSwitch_Click(object sender, EventArgs e)
        {
            if (txtTempSensorStatus.Text == "STOPPED")
            {
                txtTempSensorStatus.Text = "STARTED";
                btnTempSensorSwitch.Text = "STOP";
            }
            else
            {
                txtTempSensorStatus.Text = "STOPPED";
                btnTempSensorSwitch.Text = "START";
            }
        }

        private void btnHumiditySensorSwitch_Click(object sender, EventArgs e)
        {
            if (txtHumiditySensorStatus.Text == "STOPPED")
            {
                txtHumiditySensorStatus.Text = "STARTED";
                btnHumiditySensorSwitch.Text = "STOP";
            }
            else
            {
                txtHumiditySensorStatus.Text = "STOPPED";
                btnHumiditySensorSwitch.Text = "START";
            }
        }

        private void btnGyroSensorSwitch_Click(object sender, EventArgs e)
        {
            if (txtGyroSensorStatus.Text == "STOPPED")
            {
                txtGyroSensorStatus.Text = "STARTED";
                btnGyroSensorSwitch.Text = "STOP";
            }
            else
            {
                txtGyroSensorStatus.Text = "STOPPED";
                btnGyroSensorSwitch.Text = "START";
            }
        }

        private void btnLightSensorSwitch_Click(object sender, EventArgs e)
        {
            if (txtLightSensorStatus.Text == "STOPPED")
            {
                txtLightSensorStatus.Text = "STARTED";
                btnLightSensorSwitch.Text = "STOP";
            }
            else
            {
                txtLightSensorStatus.Text = "STOPPED";
                btnLightSensorSwitch.Text = "START";
            }
        }

        private void btnGPSSensorSwitch_Click(object sender, EventArgs e)
        {
            if (txtGPSSensorStatus.Text == "STOPPED")
            {
                txtGPSSensorStatus.Text = "STARTED";
                btnGPSSensorSwitch.Text = "STOP";
            }
            else
            {
                txtGPSSensorStatus.Text = "STOPPED";
                btnGPSSensorSwitch.Text = "START";
            }
        }

        private void btnBaroSensorSwitch_Click(object sender, EventArgs e)
        {
            if (txtBaroSensorStatus.Text == "STOPPED")
            {
                txtBaroSensorStatus.Text = "STARTED";
                btnBaroSensorSwitch.Text = "STOP";
            }
            else
            {
                txtBaroSensorStatus.Text = "STOPPED";
                btnBaroSensorSwitch.Text = "START";
            }
        }

        private void tmrSensorResult_Tick(object sender, EventArgs e)
        {
            double latitude;
            double longitude;
            if (txtTempSensorStatus.Text == "STARTED")
            {
                txtTempSensorResult.Text = sensor.getTemperature().ToString() + " C";
                if (sensor.getTemperature() > 25)
                {
                    lblTempWarning.Visible = true;
                    AddToStatus("Alert", "Temperature (" + txtTempSensorResult.Text + ") exceed the limit of 25 C");
                    if (alertsent == false)
                    {
                        if (startsms)
                        {
                            smssender.sendSMS("+6594784518", "ALERT: TEMP " + txtTempSensorResult.Text + " C exceeds limit of 27 C in farm sector A");
                            alertsent = true;
                            
                        }
                    }
                    tmrLCDAlert.Start();
                }
                else
                {
                    tmrLCDAlert.Stop();
                    sensor.WriteToLED("Sensor Controller", "Status: Normal");
                    lblTempWarning.Visible = false;
                }
            }

            if (txtHumiditySensorStatus.Text == "STARTED")
                txtHumidityResult.Text = sensor.getHumidity().ToString() + " %";
            
            if (txtBaroSensorStatus.Text == "STARTED")
            {
                txtBaroResult.Text = sensor.getGasPressure().ToString() + " Pa";
            }
            if (txtGPSSensorStatus.Text == "STARTED")
            {
                gpsreceiver.ReadDataFromGPSReceiver(out latitude,out longitude);
                txtLat.Text = latitude.ToString();
                txtLong.Text = longitude.ToString();
            }                  
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnStartAlert_Click(object sender, EventArgs e)
        {
            startsms = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtGyroSensorStatus.Text == "STARTED")
            {
                txtGyroXG.Text = sensor.getxAxisAcceleration().ToString() + " G";
                txtGyroYG.Text = sensor.getyAxisAcceleration().ToString() + " G";
                txtGyroZG.Text = sensor.getzAxisAcceleration().ToString() + " G";

                if (sensor.getzAxisAcceleration() > 0)
                    windDirection.Angle = 0;
                else
                    windDirection.Angle = 180;
                strength = Convert.ToInt16(Math.Abs(Convert.ToDouble(sensor.getzAxisAcceleration() * 100)));
                WindStrength.Value = strength;

                if (sensor.getzAxisAcceleration() < 0.20 && sensor.getzAxisAcceleration() > -0.20)
                {
                    if (sensor.getxAxisAcceleration() > 0)
                    {
                        windDirection.Angle = 270;
                    }
                    else
                    {
                        windDirection.Angle = 90;
                    }

                    strength = Convert.ToInt16(Math.Abs(Convert.ToDouble(sensor.getxAxisAcceleration() * 100)));
                    WindStrength.Value = strength;
                }

            }
        }

        private void tmrLCDAlert_Tick(object sender, EventArgs e)
        {
            if (ticker)
            {
                sensor.WriteToLED("Alert: Temperature", sensor.getTemperature().ToString() + " C limit");
            }
            else
            {
                sensor.WriteToLED(" ", " ");
            }
            ticker = !ticker;
            
        }
    }
}

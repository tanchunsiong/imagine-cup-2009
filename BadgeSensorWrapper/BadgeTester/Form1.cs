using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BadgeSensorWrapper;

namespace BadgeTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BadgeSensorWrapper.LightSensorProvider provider = new BadgeSensorWrapper.LightSensorProvider();
            Interop.Sensors.ISensor[] sensor = provider.Sensors.ToArray();
            Interop.Sensors.ISensorDataReport report;
            sensor[0].GetData(out report);
          
        }
    }
}

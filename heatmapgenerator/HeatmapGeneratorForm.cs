using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.IO;
using heatmapgenerator.PostService;
using System.Collections;
using Westwind.Tools;
using System.Globalization;



namespace heatmapgenerator
{
    public partial class Form2 : Form
    {
        private List<HeatPoint> HeatPoints = new List<HeatPoint>();

        double startLat = 85.05112878;
        double startLon = -180;
        int dateprintfrequency = 1;
        private ArrayList observationArray;
        private ArrayList observationGoodArray;
        DeviceProfile deviceprofile;
        PostService.LocationPostServiceSoapClient post = new PostService.LocationPostServiceSoapClient();
       
        public Form2()
        {
            InitializeComponent();

            observationArray = new ArrayList();
            observationGoodArray = new ArrayList();
            webBrowser1.ObjectForScripting = new ScriptManager(this);
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(Application.StartupPath + "\\heatmap.htm");
           
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
         
           
            
            ReDrawImage();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }



        private void readFromLogFile()
        {
            //Match m;

                        observationArray.Clear();
    
                        LocationStamp locStamp = new LocationStamp();
                        locStamp.LocationData = new LocationData();
                        locStamp.LocationData.Latitude =  19.2820;
                        locStamp.LocationData.Longitude = 73.0926;
                        observationArray.Add(locStamp);

                        locStamp = new LocationStamp();
                        locStamp.LocationData = new LocationData();
                        locStamp.LocationData.Latitude =19.2828;
                        locStamp.LocationData.Longitude = 73.0926;
                        observationArray.Add(locStamp); 
                  
                        locStamp = new LocationStamp();
                        locStamp.LocationData = new LocationData();
                        locStamp.LocationData.Latitude =19.2823;
                        locStamp.LocationData.Longitude = 73.0926;
                        observationArray.Add(locStamp); 
                       
                        locStamp = new LocationStamp();
                        locStamp.LocationData = new LocationData();
                        locStamp.LocationData.Latitude =19.2828;
                        locStamp.LocationData.Longitude =73.0915;
                         observationArray.Add(locStamp); 
   

        }


        private object CallJavascriptFunction(string function, params object[] parms)
        {
            // *** Get the COM DOM object (not the .NET Wrapper)
            object doc = this.webBrowser1.Document.DomDocument;

            // *** Now you can use Reflection on the COM DOM
            object win = wwUtils.GetPropertyCom(doc, "parentWindow");

            // *** Call the JavaScript function and capture the result value
            object result = wwUtils.CallMethodCom(win, function, parms);

            return result;
        }

       public void ReDrawImage() {
           Imaging img = new Imaging();
           if (File.Exists("heatmap.png"))
           {
               File.Delete("heatmap.png");
           }

           readFromLogFile();
          

           Bitmap finalImage = new Bitmap(512, 512);

           int iX, iY;
           
           HeatPoints.Clear();
        int count=0;
         
          
           foreach (Object obj in observationArray.ToArray())
           {
             
               LocationStamp stamp =(LocationStamp) obj;
              
                  
              
                   byte iIntense;
                   iIntense = (byte)80;
                   string[] value = { stamp.LocationData.Latitude.Value.ToString(), stamp.LocationData.Longitude.Value.ToString() };
                   object result = this.CallJavascriptFunction("convertLatLongToXY", value);
                   String strResult = result.ToString();
                   strResult = strResult.Remove(strResult.Length - 1);
                   strResult = strResult.Remove(0, 1);
                   String[] latlongarray = strResult.Split(',');
                   iY = Convert.ToInt32(double.Parse(latlongarray[1].ToString()));
                   iX = Convert.ToInt32(double.Parse(latlongarray[0].ToString()));
                   count += 1;
                 
                        HeatPoints.Add(new HeatPoint(iX, iY, iIntense, 150));
                    
                 
               }
           
          
           finalImage = img.CreateIntensityMask2(finalImage, HeatPoints);
           finalImage = img.Colorise(finalImage, 150);
           finalImage = img.resetWhitePixel(finalImage);
           finalImage.Save("heatmap.png");

           this.CallJavascriptFunction("RemoveImage", false);
           this.CallJavascriptFunction("AddImage", false);
           finalImage.Dispose();
        }

    

      


    }
}
   








using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace heatmapgenerator
{
    struct HeatPoint
    {
        public int X;
        public int Y;
        public byte Intensity;
        public int strength;
        public String recordtime;
        public HeatPoint(int iX, int iY, byte bIntensity)
        {
            X = iX;
            Y = iY;
            Intensity = bIntensity;
            strength = 0;
            recordtime = "";
        }
        public HeatPoint(int iX, int iY, byte bIntensity, int iStrength)
        {
            X = iX;
            Y = iY;
            Intensity = bIntensity;
            strength = iStrength;
            recordtime = "";
        }
        public HeatPoint(int iX, int iY, byte bIntensity, int iStrength, string irecordtime)
        {
            X = iX;
            Y = iY;
            Intensity = bIntensity;
            strength = iStrength;
            recordtime = irecordtime;
        }
    }
}

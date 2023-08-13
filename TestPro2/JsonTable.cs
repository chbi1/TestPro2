using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPro2
{
    public class JsonTable
    {
        public string Sequence { get; set; } = string.Empty;
        public string ModuleName { get; set; } = string.Empty;
        public string TSource { get; set; } = string.Empty;
        public string Rotation { get; set; } = string.Empty;
        public string Rate { get; set; } = string.Empty;
        public string Thickness { get; set; } = string.Empty;
        public string Cycles { get; set; } = string.Empty;              // GSM & Main
        public string Wavelength { get; set; } = string.Empty;          // GSM & Main
        public string Monitor { get; set; } = string.Empty;             // GSM & Main
        public string StartIntensity { get; set; } = string.Empty;      // GSM & Main

        //-------------------GSM Tble--------------------

        public string IntensityMax { get; set; } = string.Empty;
        public string IntensityMin { get; set; } = string.Empty;
        public string Threshold { get; set; } = string.Empty;
        public string Beam { get; set; } = string.Empty;                //Transmission
        //public string Glass { get; set; } = string.Empty;
        public string AlgDalay { get; set; } = string.Empty;
        public string AlgTime { get; set; } = string.Empty;
        public string StopMode { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string SubCycles { get; set; } = string.Empty;


    }

}


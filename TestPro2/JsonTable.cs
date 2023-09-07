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
        public string SequenceNum { get; set; } = string.Empty;
        public string ModuleName { get; set; } = string.Empty;
        public string TSource { get; set; } = string.Empty;
        public string Rotation { get; set; } = string.Empty;
        public string Rate { get; set; } = string.Empty;
        public int RateModule { get; set; }
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
        public bool IsGSM { get; set; } = false;
        public bool IsMCC { get; set; } = false;
        public bool IsLayer { get; set; } = false;
        public bool ErrorFlag { get; set; } = false;

        public List<LayerData> LayersData { get; set; } = new List<LayerData>();
        public List<MCC> MCCs { get; set; } = new List<MCC>();

    }
    public class LayerData
    {
        public string ModuleName { get; set; } = string.Empty;
        public int Pos { get; set; }
        public float Rate { get; set; }
        public int RateModule { get; set; }
        public float Derivative { get; set; }
        public float Response { get; set; }
        public float Gain { get; set; }
        public int HoldTime { get; set; }
        public float PL { get; set; }
        public float P3 { get; set; }
        public int T3 { get; set; }
        public float P2 { get; set; }
        public int T2 { get; set; }
        public float P1 { get; set; }
        public int T1 { get; set; }
        public string Delay { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public string Scan { get; set; } = string.Empty;
        public List<string> Src { get; set; } = new List<string>();
        

    }
    
    public class MCC
    {
        public string Element { get; set; } = string.Empty;
        public string LowLimit { get; set; } = string.Empty;
        public string HighLimit { get; set; } = string.Empty;
        public string Alarm { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
    
}


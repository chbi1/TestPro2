namespace TestPro2
{
    public class Evaporators
    {
        public string? Matter { get; set; }
        public int? Pos { get; set; }
        public string? Src { get; set; }
        public string Scan { get; set; } = string.Empty;
        public int? Rate { get; set; }
        public int T1 { get; set; }
        public float P1 { get; set; }
        public int T2 { get; set; }
        public float P2 { get; set; }
        public int T3 { get; set; }
        public float P3 { get; set; }
        public float PL { get; set; }
        public int HoldTime { get; set; }
        public float Gain { get; set; }
        public float RT { get; set; }
        public float DT { get; set; }
    }
}

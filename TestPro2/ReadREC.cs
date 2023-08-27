public class Rootobject
{
    public Identification Identification { get; set; } = new Identification();

    public Recipe__Property Recipe__Property { get; set; } = new Recipe__Property();
    public Process__Sequence[] Process__Sequence { get; set; } = { };
    public object[] Process__Step__Repetition { get; set; } = { };
    public Pretreatment Pretreatment { get; set; } = new Pretreatment();
    public Posttreatment Posttreatment { get; set; } = new Posttreatment();
    public Heater[] Heater { get; set; } = { };
    public Bake[] Bake { get; set; } = { };
    public Clean[] Clean { get; set; } = { };
    public object[] Deposition { get; set; } = { };
    public Layer[] Layer { get; set; } = { };
    public Rate[] Rate { get; set; } = { };
    public Source[] Source { get; set; } = { };
    public object[] Sputter { get; set; } = { };
    public object[] Power { get; set; } = { };
    public object[] Reactive { get; set; } = { };
    public Vacuum1[] Vacuum { get; set; } = { };
    public RVG[] RVG { get; set; } = { };
    public Limit__Check[] Limit__Check { get; set; } = { };
    public GSM1[] GSM { get; set; } = { };
    public Ion__Source1[] Ion__Source { get; set; } = { };
    public object[] Ios__Parameter__Set { get; set; } = { };
    public QMG[] QMG { get; set; } = { };
    public object[] PEM { get; set; } = { };
    public Sequencer[] Sequencer { get; set; } = { };
    public object[] Sequencer__Parameter { get; set; } = { };
    public Entry__Action[] Entry__Action { get; set; } = { };
    public object[] Supervision { get; set; } = { };
    public User[] User { get; set; } = { };
}

public class Identification
{
    public string Process__ID { get; set; } = string.Empty;
    public string Config__ID { get; set; } = string.Empty;
    public string System__ID { get; set; } = string.Empty;
    public string Recipe__Version { get; set; } = string.Empty;
}

public class Recipe__Property
{
    public string Comment { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Usage { get; set; } = string.Empty;
    public object[] Manufacturing__Adjustments { get; set; } = { };
}

public class Pretreatment
{
    public References References { get; set; } = new References();
    public Parameter Parameter { get; set; } = new Parameter();
}

public class References
{
    public int Bake__Module { get; set; }
    public int Sequencer__Module { get; set; }
    public int QMG__Module { get; set; }
    public int Limit__Module { get; set; }
}

public class Parameter
{
    public Optical__Sputter Optical__Sputter { get; set; } = new Optical__Sputter();
    public General General { get; set; } = new General();
    public Vacuum Vacuum { get; set; } = new Vacuum();
    public Drum__Segment__Flip Drum__Segment__Flip { get; set; } = new Drum__Segment__Flip();
    public Xbow XBow { get; set; } = new Xbow();
}

public class Optical__Sputter
{
    public string WFG__Recipe { get; set; } = string.Empty;
    public string Targetlife__Adjustment__Recipe { get; set; } = string.Empty;
    public OTM OTM { get; set; } = new OTM();
    public GSMBB GSMBB { get; set; } = new GSMBB();
}

public class OTM
{
    public string Recipe { get; set; } = string.Empty;
    public float Dome__Partition { get; set; }
    public float Segments__Definition1 { get; set; }
    public float Segments__Definition2 { get; set; }
    public float Substratum__Thickness { get; set; }
    public string Recipe__Format__ID { get; set; } = string.Empty;
}

public class GSMBB
{
    public bool TGC__Calibration__Check { get; set; }
}

public class General
{
    public float Glow__Current { get; set; }
    public bool Go__to__Wait { get; set; }
    public string Xtal__Run__Criterion { get; set; } = string.Empty;
    public string Xtal__Change__Method { get; set; } = string.Empty;
    public float Runs__Per__Xtal { get; set; }
    public float No__of__Res__Xtals { get; set; }
    public float Global__Frequency__Limit { get; set; }
    public float Max__Run__Counter { get; set; }
    public Rotation Rotation { get; set; } = new Rotation();
    public Flexcalotte FlexCalotte { get; set; } = new Flexcalotte();
}

public class Rotation
{
    public string Direction { get; set; } = string.Empty;
    public float Setpoint { get; set; }
}

public class Flexcalotte
{
    public string Function { get; set; } = string.Empty;
    public float Setpoint { get; set; }
    public float Amplitude { get; set; }
    public float Velocity { get; set; }
}

public class Vacuum
{
    public string PCWater { get; set; } = string.Empty;
    public float Pump__Timeout { get; set; }
    public float Bake__Start__Pressure { get; set; }
    public float Max__Pressure { get; set; }
    public float SCPressure__End { get; set; }
    public string Reload__IonGunWater { get; set; } = string.Empty;
    public Meissner Meissner { get; set; } = new Meissner();
}

public class Meissner
{
    public float Start__Pressure { get; set; }
    public float Delay__Time { get; set; }
    public float Cool__Down__Time { get; set; }
    public float Cool__Done__Temperature { get; set; }
}

public class Drum__Segment__Flip
{
    public bool Flip__All { get; set; }
    public string Flip__Segments { get; set; } = string.Empty;
}

public class Xbow
{
    public string Substrate__thickness { get; set; } = string.Empty;
    public string Substrate__material { get; set; } = string.Empty;
}

public class Posttreatment
{
    public References1 References { get; set; } = new References1();
    public Parameter1 Parameter { get; set; } = new Parameter1();
    public Partial__Vent Partial__Vent { get; set; } = new Partial__Vent();
}

public class References1
{
    public int Partial__Vent__1 { get; set; }
    public int Partial__Vent__2 { get; set; }
    public int Partial__Vent__3 { get; set; }
    public int Sequencer__Module { get; set; }
}

public class Parameter1
{
    public float Final__Vent__Time { get; set; }
    public bool Vent__Stop { get; set; }
    public bool Unload__Before__Vent { get; set; }
    public bool Pacman__enable__flip { get; set; }
    public bool Meissner__No__Change { get; set; }
    public Vacuum__Cool Vacuum__Cool { get; set; } = new Vacuum__Cool();
    public Reload Reload { get; set; } = new Reload();
}

public class Vacuum__Cool
{
    public float Temperature { get; set; }
    public float Heat__Delay { get; set; }
    public float Time { get; set; }
}

public class Reload
{
    public string PCWater { get; set; } = string.Empty;
    public string IonGunWater { get; set; } = string.Empty;
}

public class Partial__Vent
{
    public Partial__Vent__1 Partial__Vent__1 { get; set; } = new Partial__Vent__1();
    public Partial__Vent__2 Partial__Vent__2 { get; set; } = new Partial__Vent__2();
    public Partial__Vent__3 Partial__Vent__3 { get; set; } = new Partial__Vent__3();
}

public class Partial__Vent__1
{
    public string Water__Mode { get; set; } = string.Empty;
    public float Temperature { get; set; }
    public float Time { get; set; }
}

public class Partial__Vent__2
{
    public string Water__Mode { get; set; } = string.Empty;
    public float Temperature { get; set; }
    public float Time { get; set; }
}

public class Partial__Vent__3
{
    public string Water__Mode { get; set; } = string.Empty;
    public float Temperature { get; set; }
    public float Time { get; set; }
}

public class Process__Sequence
{
    public int Sequence__Number { get; set; }
    public string Module__Type { get; set; } = string.Empty;
    public int Module__Number { get; set; }
}

public class Heater
{
    public Identification1 Identification { get; set; } = new Identification1();
    public Parameter2 Parameter { get; set; } = new Parameter2();
}

public class Identification1
{
    public int Module__Number { get; set; }
}

public class Parameter2
{
    public float Approach { get; set; }
    public PID__Control PID__Control { get; set; } = new PID__Control();
    public float[] Zones { get; set; } = new float[0];
}

public class PID__Control
{
    public float Gain { get; set; }
    public float Integration__Time { get; set; }
    public float Derivative__Time { get; set; }
}

public class Bake
{
    public Identification2 Identification { get; set; } = new Identification2();
    public Parameter3 Parameter { get; set; } = new Parameter3();
}

public class Identification2
{
    public int Module__Number { get; set; }
    public string Module__Name { get; set; } = string.Empty;
    public string Module__Definition__State { get; set; } = string.Empty;
}

public class Parameter3
{
    public float Setpoint__1 { get; set; }
    public float Setpoint__2 { get; set; }
    public float Setpoint__3 { get; set; }
    public float Setpoint__4 { get; set; }
    public float Bakeout__Time { get; set; }
    public float Bake__Delay { get; set; }
    public float Ramp__Time { get; set; }
    public float Max__Rise__Time { get; set; }
    public Evacuation Evacuation { get; set; } = new Evacuation();
}

public class Evacuation
{
    public float Pressure { get; set; }
    public float Temperature { get; set; }
}

public class Clean
{
    public Identification3 Identification { get; set; } = new Identification3();
    public References2 References { get; set; } = new References2();
    public Parameter4 Parameter { get; set; } = new Parameter4();
}

public class Identification3
{
    public int Module__Number { get; set; }
    public string Module__Name { get; set; } = string.Empty;
    public string Module__Definition__State { get; set; } = string.Empty;
}

public class References2
{
    public int RVG__Module { get; set; }
    public int QMG__Module { get; set; }
    public int Sequencer__Module { get; set; }
    public int Limit__Check__Module { get; set; }
    public int Ion__Source__Module { get; set; }
}

public class Parameter4
{
    public float Gas__Stabilization__Time { get; set; }
    public float Clean__Time { get; set; }
    public bool DCClean { get; set; }
    public float Evacuation__Pressure { get; set; }
    public float RF__Setpoint { get; set; }
    public float Reflected__Power__Limit { get; set; }
    public bool Depend__On__QMG { get; set; }
    public float Pre__Clean__Time { get; set; }
    public bool Permanent__Step { get; set; }
    public Current Current { get; set; } = new Current();
    public Rotation1 Rotation { get; set; } = new Rotation1();
    public Ion__Source Ion__Source { get; set; } = new Ion__Source();
    public Shutter Shutter { get; set; } = new Shutter();
    public float DistShield__Position { get; set; }
    public Matching Matching { get; set; } = new Matching();
}

public class Current
{
    public float Low__Limit { get; set; }
    public float High__Limit { get; set; }
}

public class Rotation1
{
    public string Direction { get; set; } = string.Empty;
    public float Setpoint { get; set; }
}

public class Ion__Source
{
    public bool MPS__Used { get; set; }
    public float MPS__Parameter__Set { get; set; }
}

public class Shutter
{
    public string Coating__Mode { get; set; } = string.Empty;
    public float Cleaning__Position { get; set; }
    public float Stabilization__Position { get; set; }
}

public class Matching
{
    public float Capacitor__Position__Load { get; set; }
    public float Capacitor__Position__Tune { get; set; }
    public bool Auto__Matching__Mode { get; set; }
}

public class Layer
{
    public Identification4 Identification { get; set; } = new Identification4();
    public References3 References { get; set; } = new References3();
    public Parameter5 Parameter { get; set; } = new Parameter5();
    public Extended Extended { get; set; } = new Extended();
}

public class Identification4
{
    public int Module__Number { get; set; }
    public string Module__Name { get; set; } = string.Empty;
    public string Module__Definition__State { get; set; } = string.Empty;
}

public class References3
{
    public int Rate__Module__1 { get; set; }
    public int Rate__Module__2 { get; set; }
    public int Rate__Module__3 { get; set; }
    public int Rate__Module__4 { get; set; }
    public int Rate__Module__5 { get; set; }
    public int Rate__Module__6 { get; set; }
    public int Rate__Module__7 { get; set; }
    public int Rate__Module__8 { get; set; }
    public int Rate__Module__9 { get; set; }
    public int Rate__Module__10 { get; set; }
    public int Rate__Module__11 { get; set; }
    public int Rate__Module__12 { get; set; }
    public int RVG__Module__1 { get; set; }
    public int RVG__Module__2 { get; set; }
    public int RVG__Module__3 { get; set; }
    public int RVG__Module__4 { get; set; }
    public int Bake__Module { get; set; }
    public int Sequencer__Module { get; set; }
    public int GSM__Module { get; set; }
    public int QMG__Module { get; set; }
    public int Limit__Check__Module { get; set; }
    public int Ion__Source__Module { get; set; }
}

public class Parameter5
{
    public General1 General { get; set; } = new General1();
    public GSM GSM { get; set; } = new GSM();
}

public class General1
{
    public float Evaporation__Time { get; set; }
    public float Retry__Step { get; set; }
    public bool Maintain__Pump__Mode { get; set; }
    public float Thickness { get; set; }
    public float Cup__Temp { get; set; }
    public float Delta__Temp { get; set; }
    public float Min__Gradient__Time { get; set; }
    public string Temperature__Reference__Value { get; set; } = string.Empty;
    public bool GoTo__Wait { get; set; }
    public bool Max__Layer__Timeout { get; set; }
    public float Min__Layer__Time { get; set; }
    public float Max__Layer__Time { get; set; }
    public Rotation2 Rotation { get; set; } = new Rotation2();
    public Source__Temperature__Control Source__Temperature__Control { get; set; } = new Source__Temperature__Control();
    public Flexcalotte1 FlexCalotte { get; set; } = new Flexcalotte1();
    public Feeder Feeder { get; set; } = new Feeder();
    public Material__Consumption Material__Consumption { get; set; } = new Material__Consumption();
}

public class Rotation2
{
    public string Direction { get; set; } = string.Empty;
    public float Setpoint { get; set; }
}

public class Source__Temperature__Control
{
    public float Low__Limit { get; set; }
    public float High__Limit { get; set; }
}

public class Flexcalotte1
{
    public string Function { get; set; } = string.Empty;
    public float Setpoint { get; set; }
    public float Amplitude { get; set; }
    public float Velocity { get; set; }
}

public class Feeder
{
    public float Feed__Time__1 { get; set; }
    public float Feed__Time__2 { get; set; }
}

public class Material__Consumption
{
    public float Rate__1 { get; set; }
    public float Rate__2 { get; set; }
    public float Rate__3 { get; set; }
    public float Rate__4 { get; set; }
    public float Rate__5 { get; set; }
    public float Rate__6 { get; set; }
    public float Rate__7 { get; set; }
    public float Rate__8 { get; set; }
    public float Rate__9 { get; set; }
    public float Rate__10 { get; set; }
    public float Rate__11 { get; set; }
    public float Rate__12 { get; set; }
}

public class GSM
{
    public float Lower__Thickness__Deviation { get; set; }
    public float Upper__Thickness__Deviation { get; set; }
}

public class Extended
{
    public bool Used { get; set; }
    public bool Filament__Permanent { get; set; }
    public float Plasma__Lead__Time { get; set; }
    public object[] Ion__Plating { get; set; } = { };
}

public class Rate
{
    public Identification5 Identification { get; set; } = new Identification5();
    public References4 References { get; set; } = new References4();
    public Parameter6 Parameter { get; set; } = new Parameter6();
    public Ramping Ramping { get; set; } = new Ramping();
    public Coating__Ramp Coating__Ramp { get; set; } = new Coating__Ramp();
    public Deposition__Paramset[] Deposition__ParamSet { get; set; } = { };
    public Monitoring Monitoring { get; set; } = new Monitoring();
}

public class Identification5
{
    public int Module__Number { get; set; }
    public string Module__Name { get; set; } = string.Empty;
    public string Module__Definition__State { get; set; } = string.Empty;
}

public class References4
{
    public int Source__Module { get; set; }
}

public class Parameter6
{
    public General2 General { get; set; } = new General2();
    public Sentinel Sentinel { get; set; } = new Sentinel();
    public PID__Controller PID__Controller { get; set; } = new PID__Controller();
    public Rate__Filter Rate__Filter { get; set; } = new Rate__Filter();
}

public class General2
{
    public float Rate { get; set; }
    public float Ramp__Time { get; set; }
    public float RateStartSetPoint { get; set; }
    public float Control__Gain { get; set; }
    public float Tooling__Factor { get; set; }
    public float Power__Limit { get; set; }
    public float Wait__Power { get; set; }
    public float Source__Cool__Time { get; set; }
    public string Rate__Used { get; set; } = string.Empty;
    public string End__Criterion { get; set; } = string.Empty;
    public bool Shutter__Open { get; set; }
    public string Power__Controller__Type { get; set; } = string.Empty;
    public Rate__Sigma Rate__Sigma { get; set; } = new Rate__Sigma();
}

public class Rate__Sigma
{
    public float Limit { get; set; }
    public float Alarm__Category { get; set; }
    public float Start__Delay { get; set; }
    public float Timeout { get; set; }
    public string On__Limit { get; set; } = string.Empty;
}

public class Sentinel
{
    public bool Sentinel__Used { get; set; }
    public float Rate__New__Value { get; set; }
    public float Start__Thickness { get; set; }
    public float[] Soak__Time { get; set; } = { };
    public float Thickness { get; set; }
    public float Damp { get; set; }
    public PMT PMT { get; set; } = new PMT();
    public float Density { get; set; }
    public float Z__Ratio { get; set; }
    public bool Xtal__Measurement { get; set; }
    public float Setpoint__Thickness { get; set; }
    public float IO__Definition__Reference { get; set; }
    public float Filter__Number { get; set; }
    public Calibration Calibration { get; set; } = new Calibration();
}

public class PMT
{
    public float Range { get; set; }
    public float Calibration { get; set; }
}

public class Calibration
{
    public float Interval { get; set; }
    public float Accuracy { get; set; }
    public bool Automatic { get; set; }
}

public class PID__Controller
{
    public float Proportional { get; set; }
    public float Integral { get; set; }
    public float Derivative { get; set; }
}

public class Rate__Filter
{
    public string Filter__Type { get; set; } = string.Empty;
    public float Filter__Parameter { get; set; }
}

public class Ramping
{
    public float Rise__Delay { get; set; }
    public Ramp__1 Ramp__1 { get; set; } = new Ramp__1();
    public Ramp__2 Ramp__2 { get; set; } = new Ramp__2();
    public Ramp__3 Ramp__3 { get; set; } = new Ramp__3();
    public Hold Hold { get; set; } = new Hold();
}

public class Ramp__1
{
    public float Time { get; set; }
    public float Power { get; set; }
}

public class Ramp__2
{
    public float Time { get; set; }
    public float Power { get; set; }
}

public class Ramp__3
{
    public float Time { get; set; }
    public float Power { get; set; }
}

public class Hold
{
    public float Time { get; set; }
    public float Power { get; set; }
}

public class Coating__Ramp
{
    public string Control__Mode { get; set; } = string.Empty;
    public float Final__Ramp__Value { get; set; }
    public float Ramp__Time { get; set; }
}

public class Monitoring
{
    public string Mode { get; set; } = string.Empty;
    public float Alarm__Category { get; set; }
    public float Shutter__Open__Rate { get; set; }
}

public class Deposition__Paramset
{
    public Identification6 Identification { get; set; } = new Identification6();
    public Parameter7 Parameter { get; set; } = new Parameter7();
}

public class Identification6
{
    public int Module__Number { get; set; }
    public string Module__Name { get; set; } = string.Empty;
    public string Module__Type { get; set; } = string.Empty;
}

public class Parameter7
{
    public float QFactor { get; set; }
    public float SFactor { get; set; }
}

public class Source
{
    public Identification7 Identification { get; set; } = new Identification7();
    public References5 References { get; set; } = new References5();
    public Parameter8 Parameter { get; set; } = new Parameter8();
    public Xtal Xtal { get; set; } = new Xtal();
    public Egun EGun { get; set; } = new Egun();
    public Feed Feed { get; set; } = new Feed();
}

public class Identification7
{
    public int Module__Number { get; set; }
    public string Module__Name { get; set; } = string.Empty;
    public string Module__Definition__State { get; set; } = string.Empty;
}

public class References5
{
    public string EEC__Module { get; set; } = string.Empty;
}

public class Parameter8
{
    public float Source__Number { get; set; }
    public string Shutter__Moving { get; set; } = string.Empty;
    public float Distribution__Shield { get; set; }
    public float _2nd__Shutter__Lead__Delay { get; set; }
}

public class Xtal
{
    public float Response__Time { get; set; }
    public float Density { get; set; }
    public string Thickness__Correction__File { get; set; } = string.Empty;
    public float Shutter__Delay { get; set; }
    public float Xtal__Holder__Number { get; set; }
    public float Xtal__Number { get; set; }
    public float Min__Frequency { get; set; }
    public float Z__Match { get; set; }
    public string Live__Z { get; set; } = string.Empty;
    public float Freq__Corr { get; set; }
    public float Derivative__Time { get; set; }
    public float Q__Factor { get; set; }
    public float S__Factor { get; set; }
    public bool Chopper__Factor__Used { get; set; }
    public float[] Backup { get; set; } = { };
    public Monitoring1 Monitoring { get; set; } = new Monitoring1();
}

public class Monitoring1
{
    public float Xtal__Holder__Nr { get; set; }
    public float Tooling__Factor { get; set; }
    public float Min__Frequency { get; set; }
    public float Xtal__Nr { get; set; }
    public float[] Backup { get; set; } = { };
}

public class Egun
{
    public float Parameter__Code { get; set; }
    public bool Wehnelt__High { get; set; }
    public float Wobble__Code { get; set; }
    public string Material { get; set; } = string.Empty;
    public Focus Focus { get; set; } = new Focus();
}

public class Focus
{
    public float Code { get; set; }
    public bool Control__On { get; set; }
    public bool Sweep__High { get; set; }
}

public class Feed
{
    public float Feeder__Number { get; set; }
    public float Forward__Time { get; set; }
    public float Back__Time { get; set; }
    public bool During__Coating { get; set; }
}

public class Vacuum1
{
    public Identification8 Identification { get; set; } = new Identification8();
    public References6 References { get; set; } = new References6();
    public Parameter9 Parameter { get; set; } = new Parameter9();
}

public class Identification8
{
    public int Module__Number { get; set; }
    public string Module__Name { get; set; } = string.Empty;
    public string Module__Definition__State { get; set; } = string.Empty;
}

public class References6
{
    public int RVG__Module__1 { get; set; }
    public int RVG__Module__2 { get; set; }
    public int RVG__Module__3 { get; set; }
    public int RVG__Module__4 { get; set; }
    public int QMG__Module { get; set; }
    public int Limit__Check__Module { get; set; }
}

public class Parameter9
{
    public float Duration { get; set; }
    public float End__Pressure { get; set; }
    public float Zero__Adjust__Gauge__Dev { get; set; }
    public string Pump__Mode { get; set; } = string.Empty;
    public string Meissner__Command { get; set; } = string.Empty;
    public string Shutt__Off__Valve { get; set; } = string.Empty;
    public string HPA__Mode { get; set; } = string.Empty;
    public string Water__Command { get; set; } = string.Empty;
    public string Pressure__Device { get; set; } = string.Empty;
    public float[] Position__Control { get; set; } = { };
    public Flip Flip { get; set; } = new Flip();
    public Lifter Lifter { get; set; } = new Lifter();
    public Pacman Pacman { get; set; } = new Pacman();
    public float Max__Xtal__Freq__Shift { get; set; }
    public HV__Valve__SC HV__Valve__SC { get; set; } = new HV__Valve__SC();
    public TURBO__PUMP[] TURBO__PUMP { get; set; } = { };
}

public class Flip
{
    public bool Activation { get; set; }
    public float Activation__Time { get; set; }
    public float Dome__Speed { get; set; }
    public string Dome__Rotation { get; set; } = string.Empty;
}

public class Lifter
{
    public bool Enabled { get; set; }
    public float Setpoint { get; set; }
}

public class Pacman
{
    public string Used__Segments { get; set; } = string.Empty;
    public bool Flip__Segment { get; set; }
}

public class HV__Valve__SC
{
    public string Control__Mode { get; set; } = string.Empty;
    public float Setpoint__Position { get; set; }
    public float Setpoint__Pressure { get; set; }
}

public class TURBO__PUMP
{
    public Identification9 Identification { get; set; } = new Identification9();
    public Parameter10 Parameter { get; set; } = new Parameter10();
}

public class Identification9
{
    public float Number { get; set; }
}

public class Parameter10
{
    public float Device__Number { get; set; }
    public float Rotation__Speed { get; set; }
}

public class RVG
{
    public Identification10 Identification { get; set; } = new Identification10();
    public Parameter11 Parameter { get; set; } = new Parameter11();
    public Multiple__Flow Multiple__Flow { get; set; } = new Multiple__Flow();
}

public class Identification10
{
    public int Module__Number { get; set; }
    public string Module__Name { get; set; } = string.Empty;
    public string Module__Definition__State { get; set; } = string.Empty;
}

public class Parameter11
{
    public string Pump__Mode { get; set; } = string.Empty;
    public float Ignition__Gas__Flush { get; set; }
    public float RVG__Number { get; set; }
    public float On__Delay { get; set; }
    public float RVG__Pressure { get; set; }
    public float Response__Time { get; set; }
    public float Gain { get; set; }
    public bool Lead__Delay { get; set; }
    public string Meissner__Command { get; set; } = string.Empty;
    public float[] Shutt__Off__Valves { get; set; } = { };
    public HV__Valve__SC1 HV__Valve__SC { get; set; } = new HV__Valve__SC1();
    public bool Dilution__Purge { get; set; }
}

public class HV__Valve__SC1
{
    public string Control__Mode { get; set; } = string.Empty;
    public float Setpoint__Position { get; set; }
    public float Setpoint__Pressure { get; set; }
}

public class Multiple__Flow
{
    public bool Used { get; set; }
    public float Setpoint { get; set; }
    public RVG__Modules[] RVG__Modules { get; set; } = { };
}

public class RVG__Modules
{
    public float Number { get; set; }
    public float Partial__Setpoint { get; set; }
}

public class Limit__Check
{
    public Identification11 Identification { get; set; } = new Identification11();
    public Check__Point[] Check__Point { get; set; } = { };
}

public class Identification11
{
    public int Module__Number { get; set; }
    public string Module__Name { get; set; } = string.Empty;
    public string Module__Definition__State { get; set; } = string.Empty;
}

public class Check__Point
{
    public float Check__Number { get; set; }
    public string Element__Type { get; set; } = string.Empty;
    public float Device__Number { get; set; }
    public float Low__Limit { get; set; }
    public float High__Limit { get; set; }
    public float Timeout { get; set; }
    public float Start__Delay { get; set; }
    public float Alarm__Category { get; set; }
    public float Event__Trigger { get; set; }
    public string Substate { get; set; } = string.Empty;
    public string Element__Name { get; set; } = string.Empty;
    public bool Delta { get; set; }
    public float Delta__Time { get; set; }
}

public class GSM1
{
    public Identification12 Identification { get; set; } = new Identification12();
    public Signal__Settings Signal__Settings { get; set; } = new Signal__Settings();
    public Parameter12 Parameter { get; set; } = new Parameter12();
}

public class Identification12
{
    public int Module__Number { get; set; }
    public string Module__Name { get; set; } = string.Empty;
    public string Module__Definition__State { get; set; } = string.Empty;
}

public class Signal__Settings
{
    public float Lambda { get; set; }
    public float Number__of__Cycles { get; set; }
    public string Stop__Criterion { get; set; } = string.Empty;
    public float Intensity__Value { get; set; }
    public float Algorithm__Time { get; set; }
    public float Algorithm__Delay { get; set; }
}

public class Parameter12
{
    public General3 General { get; set; } = new General3();
    public GSMBB1 GSMBB { get; set; } = new GSMBB1();
}

public class General3
{
    public string Transmission { get; set; } = string.Empty;
    public string Low__Pass { get; set; } = string.Empty;
    public string Beam__Intensity { get; set; } = string.Empty;
    public float Stray { get; set; }
    public bool Record__Compensation { get; set; }
    public float Threshold { get; set; }
    public float HTemp { get; set; }
    public Glass Glass { get; set; } = new Glass();
    public Intensity Intensity { get; set; } = new Intensity();
}

public class Glass
{
    public string Changer { get; set; } = string.Empty;
    public float Number { get; set; }
}

public class Intensity
{
    public float Start { get; set; }
    public float Minimum { get; set; }
    public float Maximum { get; set; }
}

public class GSMBB1
{
    public string Control__Mode { get; set; } = string.Empty;
    public float Rate { get; set; }
    public float Activation__Thickness { get; set; }
    public float Timeout__Thickness { get; set; }
    public float Coating__Time { get; set; }
    public float Cycles__Correction { get; set; }
    public Stop__Condition Stop__Condition { get; set; } = new Stop__Condition();
    public Wavelength Wavelength { get; set; } = new Wavelength();
}

public class Stop__Condition
{
    public string Mode { get; set; } = string.Empty;
    public float Algorithm { get; set; }
}

public class Wavelength
{
    public float Low__Limit { get; set; }
    public float High__Limit { get; set; }
}

public class Ion__Source1
{
    public Identification13 Identification { get; set; } = new Identification13();
    public References7 References { get; set; } = new References7();
    public Parameter13 Parameter { get; set; } = new Parameter13();
}

public class Identification13
{
    public int Module__Number { get; set; }
    public string Module__Name { get; set; } = string.Empty;
    public string Module__Definition__State { get; set; } = string.Empty;
}

public class References7
{
    public float Parameter__Set__1 { get; set; }
    public float Parameter__Set__2 { get; set; }
    public float Parameter__Set__3 { get; set; }
}

public class Parameter13
{
    public General4 General { get; set; } = new General4();
    public MP[] MPS { get; set; } = { };
    public PDS PDS { get; set; } = new PDS();
    public Beam Beam { get; set; } = new Beam();
    public Shutter1 Shutter { get; set; } = new Shutter1();
    public ICP ICP { get; set; } = new ICP();
    public Ios__General Ios__General { get; set; } = new Ios__General();
    public Solus Solus { get; set; } = new Solus();
    public Gas__General Gas__General { get; set; } = new Gas__General();
    public Gas__Individual[] Gas__Individual { get; set; } = { };
    public Gas__Ios[] Gas__Ios { get; set; } = { };
}

public class General4
{
    public float Ion__Src__Used { get; set; }
    public Ignition Ignition { get; set; } = new Ignition();
    public Coating Coating { get; set; } = new Coating();
    public Mark__II Mark__II { get; set; } = new Mark__II();
}

public class Ignition
{
    public float Voltage { get; set; }
    public float Current { get; set; }
    public float Neutral { get; set; }
}

public class Coating
{
    public float Voltage { get; set; }
    public float Current { get; set; }
    public float Neutral { get; set; }
}

public class Mark__II
{
    public float Anode__Current { get; set; }
    public float Anode__Voltage { get; set; }
    public float Emission__Current { get; set; }
    public float Cathode__Current { get; set; }
    public float Neutralize__Ratio { get; set; }
    public float Neutralize__Current { get; set; }
}

public class PDS
{
    public bool Standby__Step { get; set; }
}

public class Beam
{
    public bool Lead__Delay { get; set; }
    public float On__Delay { get; set; }
    public string Start__Step { get; set; } = string.Empty;
    public float Off__Delay { get; set; }
    public bool Gun__Permanent { get; set; }
}

public class Shutter1
{
    public bool Lead__Delay { get; set; }
    public float Delay { get; set; }
}

public class ICP
{
    public bool MPS__used { get; set; }
    public float RF__Power { get; set; }
    public float CT__Value { get; set; }
    public float CL__Value { get; set; }
    public float Voltage__Bias { get; set; }
    public Current1 Current { get; set; } = new Current1();
    public Frequency__Tuning Frequency__Tuning { get; set; } = new Frequency__Tuning();
    public Matching1 Matching { get; set; } = new Matching1();
}

public class Current1
{
    public float Inner__Coil { get; set; }
    public float Outer__Coil { get; set; }
}

public class Frequency__Tuning
{
    public float Start__Frequency { get; set; }
    public float Start__Delay { get; set; }
    public string Mode { get; set; } = string.Empty;
    public string Change__State { get; set; } = string.Empty;
}

public class Matching1
{
    public bool Auto__Mode { get; set; }
    public float Change__Delay { get; set; }
    public string Change__State { get; set; } = string.Empty;
}

public class Ios__General
{
    public float Beam__Voltage { get; set; }
    public float Beam__Current { get; set; }
    public float Accelerator__Voltage { get; set; }
    public float Accelerator__Current { get; set; }
    public float Discharge__Voltage { get; set; }
    public float Neutralizer__Module__Current { get; set; }
    public float Emission__Current { get; set; }
    public float Emission__Voltage { get; set; }
    public float Cathode__Heater__Current { get; set; }
    public float Cathode__Heater__Start__Current { get; set; }
    public float Discharge__Current { get; set; }
    public float Filament__Heater__Current { get; set; }
    public float Filament__Heater__Start__Current { get; set; }
    public float Filament__Heater__Voltage { get; set; }
}

public class Solus
{
    public float Accelerator__Voltage { get; set; }
    public float Discharge__Voltage { get; set; }
    public float Emission__To__Beam__Curr__Ratio { get; set; }
    public float PBN__Body__Current { get; set; }
    public float Cathode__Current__Target { get; set; }
    public float Discharge__Current__Target { get; set; }
    public float PBN__Filament__Curr__Target { get; set; }
    public float Accelerator__Curr__Target { get; set; }
    public float Beam__Probe__Target { get; set; }
}

public class Gas__General
{
    public bool Permanent { get; set; }
    public bool Lead__Delay { get; set; }
    public float On__Delay { get; set; }
    public Markii__Gas[] MarkII__Gas { get; set; } = { };
    public Markii__HECS MarkII__HECS { get; set; } = new Markii__HECS();
}

public class Markii__HECS
{
    public float Start__Flow { get; set; }
    public float Run__Flow { get; set; }
}

public class Markii__Gas
{
    public float Gas__Number { get; set; }
    public float Start__Flow { get; set; }
    public float Run__Flow { get; set; }
    public bool Master__Channel { get; set; }
}

public class MP
{
    public float Number { get; set; }
    public bool Used { get; set; }
    public float Parameter__Set { get; set; }
    public float Wait__Parameter__Set { get; set; }
}

public class Gas__Individual
{
    public float Gas__Number { get; set; }
    public float RVG__Number { get; set; }
    public float Gas__Setpoint { get; set; }
    public float Response__Time { get; set; }
    public float Gain { get; set; }
    public float Stabilization__Time { get; set; }
}

public class Gas__Ios
{
    public float Gas__Number { get; set; }
    public float Start__Flow { get; set; }
}

public class QMG
{
    public Identification14 Identification { get; set; } = new Identification14();
    public Parameter14 Parameter { get; set; } = new Parameter14();
}

public class Identification14
{
    public int Module__Number { get; set; }
    public string Module__Name { get; set; } = string.Empty;
    public string Module__Definition__State { get; set; } = string.Empty;
}

public class Parameter14
{
    public float Alarm { get; set; }
    public string HPA__Mode { get; set; } = string.Empty;
    public float Source__Setting { get; set; }
    public float Gain__Index { get; set; }
    public float Accuracy { get; set; }
    public Check__Point1[] Check__Point { get; set; } = { };
}

public class Check__Point1
{
    public float Check__Number { get; set; }
    public float Mass__1 { get; set; }
    public float Mass__2 { get; set; }
    public bool Limit__Check__High { get; set; }
    public float Limit { get; set; }
}

public class Sequencer
{
    public Identification15 Identification { get; set; } = new Identification15();
    public References8 References { get; set; } = new References8();
    public object[] Conditions { get; set; } = { };
}

public class Identification15
{
    public int Module__Number { get; set; }
    public string Module__Name { get; set; } = string.Empty;
    public string Module__Definition__State { get; set; } = string.Empty;
}

public class References8
{
    public float[] Entry__Action__Module { get; set; } = { };
    public object[] Supervision { get; set; } = { };
}

public class Entry__Action
{
    public Identification16 Identification { get; set; } = new Identification16();
    public Interface__Description Interface__Description { get; set; } = new Interface__Description();
    public Parameter15 Parameter { get; set; } = new Parameter15();
}

public class Identification16
{
    public int Module__Number { get; set; }
    public string Module__Name { get; set; } = string.Empty;
    public string Module__Definition__State { get; set; } = string.Empty;
}

public class Interface__Description
{
    public string Interface__Type { get; set; } = string.Empty;
    public float Subsystem__Number { get; set; }
    public float Channel__Number { get; set; }
}

public class Parameter15
{
    public float Value { get; set; }
    public float Ramp__Time { get; set; }
    public float Number__of__Bits { get; set; }
}

public class User
{
    public Identification17 Identification { get; set; } = new Identification17();
    public References9 References { get; set; } = new References9();
    public object[] Parameter { get; set; } = { };
}

public class Identification17
{
    public int Module__Number { get; set; }
    public string Module__Name { get; set; } = string.Empty;
    public string Module__Definition__State { get; set; } = string.Empty;
    public string User__Name { get; set; } = string.Empty;
}

public class References9
{
    public int Sequencer__Module__1 { get; set; }
    public int Vacuum__Module { get; set; }
}

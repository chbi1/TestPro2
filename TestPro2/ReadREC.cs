public class Rootobject
{
    public Identification Identification { get; set; }
    public RecipeProperty RecipeProperty { get; set; }
    public ProcessSequence[] ProcessSequence { get; set; }
    public object[] ProcessStepRepetition { get; set; }
    public Pretreatment Pretreatment { get; set; }
    public Posttreatment Posttreatment { get; set; }
    public Heater[] Heater { get; set; }
    public Bake[] Bake { get; set; }
    public Clean[] Clean { get; set; }
    public object[] Deposition { get; set; }
    public Layer[] Layer { get; set; }
    public Rate[] Rate { get; set; }
    public Source[] Source { get; set; }
    public object[] Sputter { get; set; }
    public object[] Power { get; set; }
    public object[] Reactive { get; set; }
    public Vacuum1[] Vacuum { get; set; }
    public RVG[] RVG { get; set; }
    public LimitCheck[] LimitCheck { get; set; }
    public GSM1[] GSM { get; set; }
    public IonSource1[] IonSource { get; set; }
    public object[] IosParameterSet { get; set; }
    public QMG[] QMG { get; set; }
    public object[] PEM { get; set; }
    public Sequencer[] Sequencer { get; set; }
    public object[] SequencerParameter { get; set; }
    public EntryAction[] EntryAction { get; set; }
    public object[] Supervision { get; set; }
    public User[] User { get; set; }
}

public class Identification
{
    public string ProcessID { get; set; }
    public string ConfigID { get; set; }
    public string SystemID { get; set; }
    public string RecipeVersion { get; set; }
}

public class RecipeProperty
{
    public string Comment { get; set; }
    public string Icon { get; set; }
    public string Type { get; set; }
    public string Usage { get; set; }
    public object[] ManufacturingAdjustments { get; set; }
}

public class Pretreatment
{
    public References References { get; set; }
    public Parameter Parameter { get; set; }
}

public class References
{
    public float BakeModule { get; set; }
    public float SequencerModule { get; set; }
    public float QMGModule { get; set; }
    public float LimitModule { get; set; }
}

public class Parameter
{
    public OpticalSputter OpticalSputter { get; set; }
    public General General { get; set; }
    public Vacuum Vacuum { get; set; }
    public DrumSegmentFlip DrumSegmentFlip { get; set; }
    public Xbow XBow { get; set; }
}

public class OpticalSputter
{
    public string WFGRecipe { get; set; }
    public string TargetlifeAdjustmentRecipe { get; set; }
    public OTM OTM { get; set; }
    public GSMBB GSMBB { get; set; }
}

public class OTM
{
    public string Recipe { get; set; }
    public float DomePartition { get; set; }
    public float SegmentsDefinition1 { get; set; }
    public float SegmentsDefinition2 { get; set; }
    public float SubstratumThickness { get; set; }
    public string RecipeFormatID { get; set; }
}

public class GSMBB
{
    public bool TGCCalibrationCheck { get; set; }
}

public class General
{
    public float GlowCurrent { get; set; }
    public bool GotoWait { get; set; }
    public string XtalRunCriterion { get; set; }
    public string XtalChangeMethod { get; set; }
    public float RunsPerXtal { get; set; }
    public float NoofResXtals { get; set; }
    public float GlobalFrequencyLimit { get; set; }
    public float MaxRunCounter { get; set; }
    public Rotation Rotation { get; set; }
    public Flexcalotte FlexCalotte { get; set; }
}

public class Rotation
{
    public string Direction { get; set; }

    public float Setpoint { get; set; }

}

public class Flexcalotte
{
    public string Function { get; set; }
    public float Setpoint { get; set; }
    public float Amplitude { get; set; }
    public float Velocity { get; set; }
}

public class Vacuum
{
    public string PCWater { get; set; }
    public float PumpTimeout { get; set; }
    public float BakeStartPressure { get; set; }
    public float MaxPressure { get; set; }
    public float SCPressureEnd { get; set; }
    public string ReloadIonGunWater { get; set; }
    public Meissner Meissner { get; set; }
}

public class Meissner
{
    public float StartPressure { get; set; }
    public float DelayTime { get; set; }
    public float CoolDownTime { get; set; }
    public float CoolDoneTemperature { get; set; }
}

public class DrumSegmentFlip
{
    public bool FlipAll { get; set; }
    public string FlipSegments { get; set; }
}

public class Xbow
{
    public string Substratethickness { get; set; }
    public string Substratematerial { get; set; }
}

public class Posttreatment
{
    public References1 References { get; set; }
    public Parameter1 Parameter { get; set; }
    public PartialVent PartialVent { get; set; }
}

public class References1
{
    public float PartialVent1 { get; set; }
    public float PartialVent2 { get; set; }
    public float PartialVent3 { get; set; }
    public float SequencerModule { get; set; }
}

public class Parameter1
{
    public float FinalVentTime { get; set; }
    public bool VentStop { get; set; }
    public bool UnloadBeforeVent { get; set; }
    public bool Pacmanenableflip { get; set; }
    public bool MeissnerNoChange { get; set; }
    public VacuumCool VacuumCool { get; set; }
    public Reload Reload { get; set; }
}

public class VacuumCool
{
    public float Temperature { get; set; }
    public float HeatDelay { get; set; }
    public float Time { get; set; }
}

public class Reload
{
    public string PCWater { get; set; }
    public string IonGunWater { get; set; }
}

public class PartialVent
{
    public PartialVent1 PartialVent1 { get; set; }
    public PartialVent2 PartialVent2 { get; set; }
    public PartialVent3 PartialVent3 { get; set; }
}

public class PartialVent1
{
    public string WaterMode { get; set; }
    public float Temperature { get; set; }
    public float Time { get; set; }
}

public class PartialVent2
{
    public string WaterMode { get; set; }
    public float Temperature { get; set; }
    public float Time { get; set; }
}

public class PartialVent3
{
    public string WaterMode { get; set; }
    public float Temperature { get; set; }
    public float Time { get; set; }
}

public class ProcessSequence
{
    public float SequenceNumber { get; set; }
    public string ModuleType { get; set; }
    public float ModuleNumber { get; set; }
}

public class Heater
{
    public Identification1 Identification { get; set; }
    public Parameter2 Parameter { get; set; }
}

public class Identification1
{
    public float ModuleNumber { get; set; }
}

public class Parameter2
{
    public float Approach { get; set; }
    public PIDControl PIDControl { get; set; }
    public float[] Zones { get; set; }
}

public class PIDControl
{
    public float Gain { get; set; }
    public float IntegrationTime { get; set; }
    public float DerivativeTime { get; set; }
}

public class Bake
{
    public Identification2 Identification { get; set; }
    public Parameter3 Parameter { get; set; }
}

public class Identification2
{
    public float ModuleNumber { get; set; }
    public string ModuleName { get; set; }
    public string ModuleDefinitionState { get; set; }
}

public class Parameter3
{
    public float Setpoint1 { get; set; }
    public float Setpoint2 { get; set; }
    public float Setpoint3 { get; set; }
    public float Setpoint4 { get; set; }
    public float BakeoutTime { get; set; }
    public float BakeDelay { get; set; }
    public float RampTime { get; set; }
    public float MaxRiseTime { get; set; }
    public Evacuation Evacuation { get; set; }
}

public class Evacuation
{
    public float Pressure { get; set; }
    public float Temperature { get; set; }
}

public class Clean
{
    public Identification3 Identification { get; set; }
    public References2 References { get; set; }
    public Parameter4 Parameter { get; set; }
}

public class Identification3
{
    public float ModuleNumber { get; set; }
    public string ModuleName { get; set; }
    public string ModuleDefinitionState { get; set; }
}

public class References2
{
    public float RVGModule { get; set; }
    public float QMGModule { get; set; }
    public float SequencerModule { get; set; }
    public float LimitCheckModule { get; set; }
    public float IonSourceModule { get; set; }
}

public class Parameter4
{
    public float GasStabilizationTime { get; set; }
    public float CleanTime { get; set; }
    public bool DCClean { get; set; }
    public float EvacuationPressure { get; set; }
    public float RFSetpoint { get; set; }
    public float ReflectedPowerLimit { get; set; }
    public bool DependOnQMG { get; set; }
    public float PreCleanTime { get; set; }
    public bool PermanentStep { get; set; }
    public Current Current { get; set; }
    public Rotation1 Rotation { get; set; }
    public IonSource IonSource { get; set; }
    public Shutter Shutter { get; set; }
    public float DistShieldPosition { get; set; }
    public Matching Matching { get; set; }
}

public class Current
{
    public float LowLimit { get; set; }
    public float HighLimit { get; set; }
}

public class Rotation1
{
    public string Direction { get; set; }
    public float Setpoint { get; set; }
}

public class IonSource
{
    public bool MPSUsed { get; set; }
    public float MPSParameterSet { get; set; }
}

public class Shutter
{
    public string CoatingMode { get; set; }
    public float CleaningPosition { get; set; }
    public float StabilizationPosition { get; set; }
}

public class Matching
{
    public float CapacitorPositionLoad { get; set; }
    public float CapacitorPositionTune { get; set; }
    public bool AutoMatchingMode { get; set; }
}

public class Layer
{
    public Identification4 Identification { get; set; }
    public References3 References { get; set; }
    public Parameter5 Parameter { get; set; }
    public Extended Extended { get; set; }
}

public class Identification4
{
    public float ModuleNumber { get; set; }
    public string ModuleName { get; set; }
    public string ModuleDefinitionState { get; set; }
}

public class References3
{
    public float RateModule1 { get; set; }
    public float RateModule2 { get; set; }
    public float RateModule3 { get; set; }
    public float RateModule4 { get; set; }
    public float RateModule5 { get; set; }
    public float RateModule6 { get; set; }
    public float RateModule7 { get; set; }
    public float RateModule8 { get; set; }
    public float RateModule9 { get; set; }
    public float RateModule10 { get; set; }
    public float RateModule11 { get; set; }
    public float RateModule12 { get; set; }
    public float RVGModule1 { get; set; }
    public float RVGModule2 { get; set; }
    public float RVGModule3 { get; set; }
    public float RVGModule4 { get; set; }
    public float BakeModule { get; set; }
    public float SequencerModule { get; set; }
    public float GSMModule { get; set; }
    public float QMGModule { get; set; }
    public float LimitCheckModule { get; set; }
    public float IonSourceModule { get; set; }
}

public class Parameter5
{
    public General1 General { get; set; }
    public GSM GSM { get; set; }
}

public class General1
{
    public float EvaporationTime { get; set; }
    public float RetryStep { get; set; }
    public bool MaintainPumpMode { get; set; }
    public float Thickness { get; set; }
    public float CupTemp { get; set; }
    public float DeltaTemp { get; set; }
    public float MinGradientTime { get; set; }
    public string TemperatureReferenceValue { get; set; }
    public bool GoToWait { get; set; }
    public bool MaxLayerTimeout { get; set; }
    public float MinLayerTime { get; set; }
    public float MaxLayerTime { get; set; }
    public Rotation2 Rotation { get; set; }
    public SourceTemperatureControl SourceTemperatureControl { get; set; }
    public Flexcalotte1 FlexCalotte { get; set; }
    public Feeder Feeder { get; set; }
    public MaterialConsumption MaterialConsumption { get; set; }
}

public class Rotation2
{
    public string Direction { get; set; }
    public float Setpoint { get; set; }
}

public class SourceTemperatureControl
{
    public float LowLimit { get; set; }
    public float HighLimit { get; set; }
}

public class Flexcalotte1
{
    public string Function { get; set; }
    public float Setpoint { get; set; }
    public float Amplitude { get; set; }
    public float Velocity { get; set; }
}

public class Feeder
{
    public float FeedTime1 { get; set; }
    public float FeedTime2 { get; set; }
}

public class MaterialConsumption
{
    public float Rate1 { get; set; }
    public float Rate2 { get; set; }
    public float Rate3 { get; set; }
    public float Rate4 { get; set; }
    public float Rate5 { get; set; }
    public float Rate6 { get; set; }
    public float Rate7 { get; set; }
    public float Rate8 { get; set; }
    public float Rate9 { get; set; }
    public float Rate10 { get; set; }
    public float Rate11 { get; set; }
    public float Rate12 { get; set; }
}

public class GSM
{
    public float LowerThicknessDeviation { get; set; }
    public float UpperThicknessDeviation { get; set; }
}

public class Extended
{
    public bool Used { get; set; }
    public bool FilamentPermanent { get; set; }
    public float PlasmaLeadTime { get; set; }
    public object[] IonPlating { get; set; }
}

public class Rate
{
    public Identification5 Identification { get; set; }
    public References4 References { get; set; }
    public Parameter6 Parameter { get; set; }
    public Ramping Ramping { get; set; }
    public CoatingRamp CoatingRamp { get; set; }
    public DepositionParamset[] DepositionParamSet { get; set; }
    public Monitoring Monitoring { get; set; }
}

public class Identification5
{
    public float ModuleNumber { get; set; }
    public string ModuleName { get; set; }
    public string ModuleDefinitionState { get; set; }
}

public class References4
{
    public float SourceModule { get; set; }
}

public class Parameter6
{
    public General2 General { get; set; }
    public Sentinel Sentinel { get; set; }
    public PIDController PIDController { get; set; }
    public RateFilter RateFilter { get; set; }
}

public class General2
{
    public float Rate { get; set; }
    public float RampTime { get; set; }
    public float RateStartSetPoint { get; set; }
    public double ControlGain { get; set; }
    public float ToolingFactor { get; set; }
    public float PowerLimit { get; set; }
    public float WaitPower { get; set; }
    public float SourceCoolTime { get; set; }
    public string RateUsed { get; set; }
    public string EndCriterion { get; set; }
    public bool ShutterOpen { get; set; }
    public string PowerControllerType { get; set; }
    public RateSigma RateSigma { get; set; }
}

public class RateSigma
{
    public float Limit { get; set; }
    public float AlarmCategory { get; set; }
    public float StartDelay { get; set; }
    public float Timeout { get; set; }
    public string OnLimit { get; set; }
}

public class Sentinel
{
    public bool SentinelUsed { get; set; }
    public float RateNewValue { get; set; }
    public float StartThickness { get; set; }
    public float[] SoakTime { get; set; }
    public float Thickness { get; set; }
    public float Damp { get; set; }
    public PMT PMT { get; set; }
    public float Density { get; set; }
    public float ZRatio { get; set; }
    public bool XtalMeasurement { get; set; }
    public float SetpointThickness { get; set; }
    public float IODefinitionReference { get; set; }
    public float FilterNumber { get; set; }
    public Calibration Calibration { get; set; }
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

public class PIDController
{
    public float Proportional { get; set; }
    public float Integral { get; set; }
    public float Derivative { get; set; }
}

public class RateFilter
{
    public string FilterType { get; set; }
    public float FilterParameter { get; set; }
}

public class Ramping
{
    public float RiseDelay { get; set; }
    public Ramp1 Ramp1 { get; set; }
    public Ramp2 Ramp2 { get; set; }
    public Ramp3 Ramp3 { get; set; }
    public Hold Hold { get; set; }
}

public class Ramp1
{
    public float Time { get; set; }
    public double Power { get; set; }
}

public class Ramp2
{
    public float Time { get; set; }
    public float Power { get; set; }
}

public class Ramp3
{
    public float Time { get; set; }
    public float Power { get; set; }
}

public class Hold
{
    public float Time { get; set; }
    public float Power { get; set; }
}

public class CoatingRamp
{
    public string ControlMode { get; set; }
    public float FinalRampValue { get; set; }
    public float RampTime { get; set; }
}

public class Monitoring
{
    public string Mode { get; set; }
    public float AlarmCategory { get; set; }
    public float ShutterOpenRate { get; set; }
}

public class DepositionParamset
{
    public Identification6 Identification { get; set; }
    public Parameter7 Parameter { get; set; }
}

public class Identification6
{
    public float ModuleNumber { get; set; }
    public string ModuleName { get; set; }
    public string ModuleType { get; set; }
}

public class Parameter7
{
    public float QFactor { get; set; }
    public float SFactor { get; set; }
}

public class Source
{
    public Identification7 Identification { get; set; }
    public References5 References { get; set; }
    public Parameter8 Parameter { get; set; }
    public Xtal Xtal { get; set; }
    public Egun EGun { get; set; }
    public Feed Feed { get; set; }
}

public class Identification7
{
    public float ModuleNumber { get; set; }
    public string ModuleName { get; set; }
    public string ModuleDefinitionState { get; set; }
}

public class References5
{
    public string EECModule { get; set; }
}

public class Parameter8
{
    public float SourceNumber { get; set; }
    public string ShutterMoving { get; set; }
    public float DistributionShield { get; set; }
    public float _2ndShutterLeadDelay { get; set; }
}

public class Xtal
{
    public float ResponseTime { get; set; }
    public float Density { get; set; }
    public string ThicknessCorrectionFile { get; set; }
    public float ShutterDelay { get; set; }
    public float XtalHolderNumber { get; set; }
    public float XtalNumber { get; set; }
    public float MinFrequency { get; set; }
    public float ZMatch { get; set; }
    public string LiveZ { get; set; }
    public float FreqCorr { get; set; }
    public float DerivativeTime { get; set; }
    public float QFactor { get; set; }
    public float SFactor { get; set; }
    public bool ChopperFactorUsed { get; set; }
    public float[] Backup { get; set; }
    public Monitoring1 Monitoring { get; set; }
}

public class Monitoring1
{
    public float XtalHolderNr { get; set; }
    public float ToolingFactor { get; set; }
    public float MinFrequency { get; set; }
    public float XtalNr { get; set; }
    public float[] Backup { get; set; }
}

public class Egun
{
    public float ParameterCode { get; set; }
    public bool WehneltHigh { get; set; }
    public float WobbleCode { get; set; }
    public string Material { get; set; }
    public Focus Focus { get; set; }
}

public class Focus
{
    public float Code { get; set; }
    public bool ControlOn { get; set; }
    public bool SweepHigh { get; set; }
}

public class Feed
{
    public float FeederNumber { get; set; }
    public float ForwardTime { get; set; }
    public float BackTime { get; set; }
    public bool DuringCoating { get; set; }
}

public class Vacuum1
{
    public Identification8 Identification { get; set; }
    public References6 References { get; set; }
    public Parameter9 Parameter { get; set; }
}

public class Identification8
{
    public float ModuleNumber { get; set; }
    public string ModuleName { get; set; }
    public string ModuleDefinitionState { get; set; }
}

public class References6
{
    public float RVGModule1 { get; set; }
    public float RVGModule2 { get; set; }
    public float RVGModule3 { get; set; }
    public float RVGModule4 { get; set; }
    public float QMGModule { get; set; }
    public float LimitCheckModule { get; set; }
}

public class Parameter9
{
    public float Duration { get; set; }
    public float EndPressure { get; set; }
    public float ZeroAdjustGaugeDev { get; set; }
    public string PumpMode { get; set; }
    public string MeissnerCommand { get; set; }
    public string ShuttOffValve { get; set; }
    public string HPAMode { get; set; }
    public string WaterCommand { get; set; }
    public string PressureDevice { get; set; }
    public float[] PositionControl { get; set; }
    public Flip Flip { get; set; }
    public Lifter Lifter { get; set; }
    public Pacman Pacman { get; set; }
    public float MaxXtalFreqShift { get; set; }
    public HVValveSC HVValveSC { get; set; }
    public TURBOPUMP[] TURBOPUMP { get; set; }
}

public class Flip
{
    public bool Activation { get; set; }
    public float ActivationTime { get; set; }
    public float DomeSpeed { get; set; }
    public string DomeRotation { get; set; }
}

public class Lifter
{
    public bool Enabled { get; set; }
    public float Setpoint { get; set; }
}

public class Pacman
{
    public string UsedSegments { get; set; }
    public bool FlipSegment { get; set; }
}

public class HVValveSC
{
    public string ControlMode { get; set; }
    public float SetpointPosition { get; set; }
    public float SetpointPressure { get; set; }
}

public class TURBOPUMP
{
    public Identification9 Identification { get; set; }
    public Parameter10 Parameter { get; set; }
}

public class Identification9
{
    public float Number { get; set; }
}

public class Parameter10
{
    public float DeviceNumber { get; set; }
    public float RotationSpeed { get; set; }
}

public class RVG
{
    public Identification10 Identification { get; set; }
    public Parameter11 Parameter { get; set; }
    public MultipleFlow MultipleFlow { get; set; }
}

public class Identification10
{
    public float ModuleNumber { get; set; }
    public string ModuleName { get; set; }
    public string ModuleDefinitionState { get; set; }
}

public class Parameter11
{
    public string PumpMode { get; set; }
    public float IgnitionGasFlush { get; set; }
    public float RVGNumber { get; set; }
    public float OnDelay { get; set; }
    public float RVGPressure { get; set; }
    public float ResponseTime { get; set; }
    public float Gain { get; set; }
    public bool LeadDelay { get; set; }
    public string MeissnerCommand { get; set; }
    public float[] ShuttOffValves { get; set; }
    public HVValveSC1 HVValveSC { get; set; }
    public bool DilutionPurge { get; set; }
}

public class HVValveSC1
{
    public string ControlMode { get; set; }
    public float SetpointPosition { get; set; }
    public float SetpointPressure { get; set; }
}

public class MultipleFlow
{
    public bool Used { get; set; }

    public float Setpoint { get; set; }
    public RVGModule[] RVGModules { get; set; }
}

public class RVGModule
{
    public float Number { get; set; }
    public float PartialSetpoint { get; set; }
}

public class LimitCheck
{
    public Identification11 Identification { get; set; }
    public CheckPoint[] CheckPoint { get; set; }
}

public class Identification11
{
    public float ModuleNumber { get; set; }
    public string ModuleName { get; set; }
    public string ModuleDefinitionState { get; set; }
}

public class CheckPoint
{
    public float CheckNumber { get; set; }
    public string ElementType { get; set; }
    public float DeviceNumber { get; set; }
    public float LowLimit { get; set; }
    public float HighLimit { get; set; }
    public float Timeout { get; set; }
    public float StartDelay { get; set; }
    public float AlarmCategory { get; set; }
    public float EventTrigger { get; set; }
    public string Substate { get; set; }
    public string ElementName { get; set; }
    public bool Delta { get; set; }
    public float DeltaTime { get; set; }
}

public class GSM1
{
    public Identification12 Identification { get; set; }
    public SignalSettings SignalSettings { get; set; }
    public Parameter12 Parameter { get; set; }
}

public class Identification12
{
    public float ModuleNumber { get; set; }
    public string ModuleName { get; set; }
    public string ModuleDefinitionState { get; set; }
}

public class SignalSettings
{
    public float Lambda { get; set; }
    public float NumberofCycles { get; set; }
    public string StopCriterion { get; set; }
    public float IntensityValue { get; set; }
    public float AlgorithmTime { get; set; }
    public float AlgorithmDelay { get; set; }
}

public class Parameter12
{
    public General3 General { get; set; }
    public GSMBB1 GSMBB { get; set; }
}

public class General3
{
    public string Transmission { get; set; }
    public string LowPass { get; set; }
    public string BeamIntensity { get; set; }
    public float Stray { get; set; }
    public bool RecordCompensation { get; set; }
    public float Threshold { get; set; }
    public float HTemp { get; set; }
    public Glass Glass { get; set; }
    public Intensity Intensity { get; set; }
}

public class Glass
{
    public string Changer { get; set; }
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
    public string ControlMode { get; set; }
    public float Rate { get; set; }
    public float ActivationThickness { get; set; }
    public float TimeoutThickness { get; set; }
    public float CoatingTime { get; set; }
    public float CyclesCorrection { get; set; }
    public StopCondition StopCondition { get; set; }
    public Wavelength Wavelength { get; set; }
}

public class StopCondition
{
    public string Mode { get; set; }
    public float Algorithm { get; set; }
}

public class Wavelength
{
    public float LowLimit { get; set; }
    public float HighLimit { get; set; }
}

public class IonSource1
{
    public Identification13 Identification { get; set; }
    public References7 References { get; set; }
    public Parameter13 Parameter { get; set; }
}

public class Identification13
{
    public float ModuleNumber { get; set; }
    public string ModuleName { get; set; }
    public string ModuleDefinitionState { get; set; }
}

public class References7
{
    public float ParameterSet1 { get; set; }
    public float ParameterSet2 { get; set; }
    public float ParameterSet3 { get; set; }
}

public class Parameter13
{
    public General4 General { get; set; }
    public MP[] MPS { get; set; }
    public PDS PDS { get; set; }
    public Beam Beam { get; set; }
    public Shutter1 Shutter { get; set; }
    public ICP ICP { get; set; }
    public IosGeneral IosGeneral { get; set; }
    public Solus Solus { get; set; }
    public GasGeneral GasGeneral { get; set; }
    public GasIndividual[] GasIndividual { get; set; }
    public GasIo[] GasIos { get; set; }
}

public class General4
{
    public float IonSrcUsed { get; set; }
    public Ignition Ignition { get; set; }
    public Coating Coating { get; set; }
    public MarkII MarkII { get; set; }
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

public class MarkII
{
    public float AnodeCurrent { get; set; }
    public float AnodeVoltage { get; set; }
    public float EmissionCurrent { get; set; }
    public float CathodeCurrent { get; set; }
    public float NeutralizeRatio { get; set; }
    public float NeutralizeCurrent { get; set; }
}

public class PDS
{
    public bool StandbyStep { get; set; }
}

public class Beam
{
    public bool LeadDelay { get; set; }
    public float OnDelay { get; set; }
    public string StartStep { get; set; }
    public float OffDelay { get; set; }
    public bool GunPermanent { get; set; }
}

public class Shutter1
{
    public bool LeadDelay { get; set; }
    public float Delay { get; set; }
}

public class ICP
{
    public bool MPSused { get; set; }
    public float RFPower { get; set; }
    public float CTValue { get; set; }
    public float CLValue { get; set; }
    public float VoltageBias { get; set; }
    public Current1 Current { get; set; }
    public FrequencyTuning FrequencyTuning { get; set; }
    public Matching1 Matching { get; set; }
}

public class Current1
{
    public float InnerCoil { get; set; }
    public float OuterCoil { get; set; }
}

public class FrequencyTuning
{
    public float StartFrequency { get; set; }
    public float StartDelay { get; set; }
    public string Mode { get; set; }
    public string ChangeState { get; set; }
}

public class Matching1
{
    public bool AutoMode { get; set; }
    public float ChangeDelay { get; set; }
    public string ChangeState { get; set; }
}

public class IosGeneral
{
    public float BeamVoltage { get; set; }
    public float BeamCurrent { get; set; }
    public float AcceleratorVoltage { get; set; }
    public float AcceleratorCurrent { get; set; }
    public float DischargeVoltage { get; set; }
    public float NeutralizerModuleCurrent { get; set; }
    public float EmissionCurrent { get; set; }
    public float EmissionVoltage { get; set; }
    public float CathodeHeaterCurrent { get; set; }
    public float CathodeHeaterStartCurrent { get; set; }
    public float DischargeCurrent { get; set; }
    public float FilamentHeaterCurrent { get; set; }
    public float FilamentHeaterStartCurrent { get; set; }
    public float FilamentHeaterVoltage { get; set; }
}

public class Solus
{
    public float AcceleratorVoltage { get; set; }
    public float DischargeVoltage { get; set; }
    public float EmissionToBeamCurrRatio { get; set; }
    public float PBNBodyCurrent { get; set; }
    public float CathodeCurrentTarget { get; set; }
    public float DischargeCurrentTarget { get; set; }
    public float PBNFilamentCurrTarget { get; set; }
    public float AcceleratorCurrTarget { get; set; }
    public float BeamProbeTarget { get; set; }
}

public class GasGeneral
{
    public bool Permanent { get; set; }
    public bool LeadDelay { get; set; }
    public float OnDelay { get; set; }
    public MarkiiGas[] MarkIIGas { get; set; }
    public MarkiiHECS MarkIIHECS { get; set; }
}

public class MarkiiHECS
{
    public float StartFlow { get; set; }
    public float RunFlow { get; set; }
}

public class MarkiiGas
{
    public float GasNumber { get; set; }
    public float StartFlow { get; set; }
    public float RunFlow { get; set; }
    public bool MasterChannel { get; set; }
}

public class MP
{
    public float Number { get; set; }
    public bool Used { get; set; }
    public float ParameterSet { get; set; }
    public float WaitParameterSet { get; set; }
}

public class GasIndividual
{
    public float GasNumber { get; set; }
    public float RVGNumber { get; set; }
    public float GasSetpoint { get; set; }
    public float ResponseTime { get; set; }
    public float Gain { get; set; }
    public float StabilizationTime { get; set; }
}

public class GasIo
{
    public float GasNumber { get; set; }
    public float StartFlow { get; set; }
}

public class QMG
{
    public Identification14 Identification { get; set; }
    public Parameter14 Parameter { get; set; }
}

public class Identification14
{
    public float ModuleNumber { get; set; }
    public string ModuleName { get; set; }
    public string ModuleDefinitionState { get; set; }
}

public class Parameter14
{
    public float Alarm { get; set; }
    public string HPAMode { get; set; }
    public float SourceSetting { get; set; }
    public float GainIndex { get; set; }
    public float Accuracy { get; set; }
    public CheckPoint1[] CheckPoint { get; set; }
}

public class CheckPoint1
{
    public float CheckNumber { get; set; }
    public float Mass1 { get; set; }
    public float Mass2 { get; set; }
    public bool LimitCheckHigh { get; set; }
    public float Limit { get; set; }
}

public class Sequencer
{
    public Identification15 Identification { get; set; }
    public References8 References { get; set; }
    public object[] Conditions { get; set; }
}

public class Identification15
{
    public float ModuleNumber { get; set; }
    public string ModuleName { get; set; }
    public string ModuleDefinitionState { get; set; }
}

public class References8
{
    public float[] EntryActionModule { get; set; }
    public object[] Supervision { get; set; }
}

public class EntryAction
{
    public Identification16 Identification { get; set; }
    public InterfaceDescription InterfaceDescription { get; set; }
    public Parameter15 Parameter { get; set; }
}

public class Identification16
{
    public float ModuleNumber { get; set; }
    public string ModuleName { get; set; }
    public string ModuleDefinitionState { get; set; }
}

public class InterfaceDescription
{
    public string InterfaceType { get; set; }
    public float SubsystemNumber { get; set; }
    public float ChannelNumber { get; set; }
}

public class Parameter15
{
    public float Value { get; set; }
    public float RampTime { get; set; }
    public float NumberofBits { get; set; }
}

public class User
{
    public Identification17 Identification { get; set; }
    public References9 References { get; set; }
    public object[] Parameter { get; set; }
}

public class Identification17

{
    public float ModuleNumber { get; set; }
    public string ModuleName { get; set; }
    public string ModuleDefinitionState { get; set; }
    public string UserName { get; set; }
}

public class References9
{
    public float SequencerModule1 { get; set; }
    public float VacuumModule { get; set; }
}

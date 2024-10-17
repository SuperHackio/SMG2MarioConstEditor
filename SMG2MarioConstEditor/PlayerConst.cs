using OrderedPropertyGrid;
using System.ComponentModel;

namespace SMG2PlayerConstEditor
{
    /// <summary>
    /// Various player settings in SMG/2
    /// </summary>
    [TypeConverter(typeof(PropertySorter))]
    public class PlayerConst
    {
        private const string JumpSettings = "Jump Settings";
        private const string HipDropCategoryName = "Ground Pound Settings";
        private const string SlipUpCategoryName = "Slip Up Settings";
        private const string AirWalkCategoryName = "Air Movement Settings";
        private const string LandingCategoryName = "Landing Settings";
        private const string JumpCodeCategoryName = "Bounce Floor Code Settings";
        private const string TrampleRecoilCategoryName = "Trample Bounce Settings";
        private const string UpwardAttackRecoilCategoryName = "Upward Attack Recoil Settings";
        private const string MessageJumpCategoryName = "Message Jump Settings";
        private const string LeadJumpInputCategoryName = "Lead Jump Input Settings";
        private const string WarpPodJumpCategoryName = "Warp Pod Jump Settings";
        private const string MediumDamageCategoryName = "Medium Damage Settings";
        private const string HeavyDamageCategoryName = "Heavy Damage Settings";
        private const string SmallDamageCategoryName = "Small Damage Settings";
        private const string BeingBlownAwayCategoryName = "Being Blown Away Settings";
        private const string FireRunDamageCategoryName = "Fire Run Damage Settings";
        private const string FireDanceDamageCategoryName = "Fire Dance Damage Settings";
        private const string BlackHoleCategoryName = "Black Hole Settings";
        private const string WaterUnderwaterDamageCategoryName = "Water / Underwater Damage Settings";
        private const string FountainJumpCategoryName = "Fountain Jump Settings";
        private const string RunningWalkingCategoryName = "Running / Walking Settings";
        private const string RunningWalkingOnIceCategoryName = "Running / Walking (Ice) Settings";
        private const string RunningWalkingOnSlipCategoryName = "Running / Walking (Slippery) Settings";
        private const string TurnsSlipsBrakesCategoryName = "Turn, Slip, and Brake Settings";
        private const string SlopeCategoryName = "Slope Settings";
        private const string StepCategoryName = "Stair Settings";
        private const string AnimeCategoryName = "Animation Settings";
        private const string SensitivityCategoryName = "Stick Sensitivity Settings";
        private const string CrouchWalkCategoryName = "Crouch Walk Settings";
        private const string WindCategoryName = "Wind Settings";
        private const string TornadoCategoryName = "Tornado Settings";
        private const string WallCategoryName = "Wall Settings";
        private const string ClapCategoryName = "Clap Settings";
        private const string SwimCategoryName = "Swim Settings";
        private const string TurtleCategoryName = "Koopa Shell Swim Settings";
        private const string SwimSinkCategoryName = "Swim Sink Settings";
        private const string SwimSpecialCategoryName = "Special Swim Settings";
        private const string SwimSpinCategoryName = "Spin Attack (Swimming) Settings";
        private const string SwimRingDashCategoryName = "Swimming Dash Ring Settings";
        private const string SwimMovementCategoryName = "Swim Movement Settings";
        private const string SwimBuoyancyDashCategoryName = "Swim Buoyancy Settings";
        private const string SliderCategoryName = "Slider Settings";
        private const string BeeCategoryName = "Bee Powerup Settings";
        private const string HopperCategoryName = "Spring Powerup Settings";
        private const string TeresaCategoryName = "Boo Powerup Settings";
        private const string DrawCategoryName = "Draw Settings";
        private const string RushCategoryName = "Powerup Timer Settings";
        private const string TweaksCategoryName = "Tweak Settings";


        [OrderedCategory(JumpSettings, 0)]
        [DisplayName("Jump Height")]
        [Description("The height of a normal Jump")]
        [Order(0)]
        [DefaultValue(22f)]
        public float JumpHeight1st { get; set; } = 22f;

        [OrderedCategory(JumpSettings, 0)]
        [DisplayName("Double Jump Height")]
        [Description("The height of a Double Jump")]
        [Order(1)]
        [DefaultValue(26f)]
        public float JumpHeight2nd { get; set; } = 26f;

        [OrderedCategory(JumpSettings, 0)]
        [DisplayName("Triple Jump Height")]
        [Description("The height of a Triple Jump")]
        [Order(2)]
        [DefaultValue(36f)]
        public float JumpHeight3rd { get; set; } = 36f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(3)]
        [DefaultValue(24f)]
        public float JumpHeightMiss { get; set; } = 24f;

        [OrderedCategory(JumpSettings, 0)]
        [DisplayName("Side Flip Height")]
        [Description("The height of a side flip")]
        [Order(4)]
        [DefaultValue(32f)]
        public float JumpHeightTurn { get; set; } = 32f;

        [OrderedCategory(JumpSettings, 0)]
        [DisplayName("Long Jump Height")]
        [Description("The height of a long jump")]
        [Order(5)]
        [DefaultValue(15f)]
        public float JumpHeightSquat { get; set; } = 15f;

        [OrderedCategory(JumpSettings, 0)]
        [DisplayName("Backflip height")]
        [Description("the height of a backflip")]
        [Order(6)]
        [DefaultValue(32f)]
        public float JumpHeightBack { get; set; } = 32f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(7)]
        [DefaultValue(22f)]
        public float JumpHeightWall { get; set; } = 22f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(8)]
        [DefaultValue(1f)]
        public float JumpHeightTornado_and_Force { get; set; } = 1f;



        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(9)]
        [DefaultValue(1.8f)]
        public float GravityJumping1st { get; set; } = 1.8f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(10)]
        [DefaultValue(1.8f)]
        public float GravityJumping2nd { get; set; } = 1.8f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(11)]
        [DefaultValue(1.8f)]
        public float GravityJumping3rd { get; set; } = 1.8f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(12)]
        [DefaultValue(1.8f)]
        public float GravityJumpingMiss { get; set; } = 1.8f;
        
        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(13)]
        [DefaultValue(1.8f)]
        public float GravityJumpingTurn { get; set; } = 1.8f;
        
        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(14)]
        [DefaultValue(0.95f)]
        public float GravityJumpingSquat { get; set; } = 0.95f;
        
        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(15)]
        [DefaultValue(1.8f)]
        public float GravityJumpingBack { get; set; } = 1.8f;
        
        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(16)]
        [DefaultValue(2.2f)]
        public float GravityJumpingWall { get; set; } = 2.2f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(17)]
        [DefaultValue(0.4f)]
        public float GravityJumpingTornado { get; set; } = 0.4f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(18)]
        [DefaultValue(0.9f)]
        public float GravityJumpingForce { get; set; } = 0.9f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(19)]
        [DefaultValue(1.8f)]
        public float GravityJumpingSlipUp { get; set; } = 1.8f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(20)]
        [DefaultValue(0.5f)]
        public float GravityJumpingHeli { get; set; } = 0.5f;


        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(21)]
        [DefaultValue(0.1f)]
        public float GravityAirWalk { get; set; } = 0.1f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(22)]
        [DefaultValue(0.5f)]
        public float GravityRatioA { get; set; } = 0.5f;


        [OrderedCategory(JumpSettings, 0)]
        [DisplayName("Jump Speed")]
        [Description("The forward speed given to a jump when moving")]
        [Order(23)]
        [DefaultValue(12.5f)]
        public float JumpFrontSpeed { get; set; } = 12.5f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(24)]
        [DefaultValue(5f)]
        public float JumpTornadoSpeed { get; set; } = 5f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(25)]
        [DefaultValue(30f)]
        public float DropFrontSpeed { get; set; } = 30f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(26)]
        [DefaultValue((short)7)]
        public short JumpConnectTime { get; set; } = 7;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(27)]
        [DefaultValue(0.6f)]
        public float JumpConnectSpeed { get; set; } = 0.6f;

        [OrderedCategory(JumpSettings, 0)]
        [DisplayName("Long Jump Speed")]
        [Description("The forward speed given to a Long Jump")]
        [Order(28)]
        [DefaultValue(16.5f)]
        public float SquatJumpFrontSpeed { get; set; } = 16.5f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(29)]
        [DefaultValue(5f)]
        public float SquatJumpBackSpeed { get; set; } = 5f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(30)]
        [DefaultValue(5f)]
        public float TurnJumpFrontSpeed { get; set; } = 5f;


        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(31)]
        [DefaultValue(35f)]
        public float MaxDropSpeedNormal { get; set; } = 35f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(32)]
        [DefaultValue(20f)]
        public float MaxDropSpeedSpecial1 { get; set; } = 20f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(33)]
        [DefaultValue(5f)]
        public float MaxDropSpeedSpecial2 { get; set; } = 5f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(34)]
        [DefaultValue(6f)]
        public float MaxDropSpeedHelicopter { get; set; } = 6f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(35)]
        [DefaultValue(15f)]
        public float MaxDropSpeedBee { get; set; } = 15f;


        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(36)]
        [DefaultValue((short)30)]
        public short GrReductionDropTimer { get; set; } = 30;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(37)]
        [DefaultValue((short)5)]
        public short DropWaitTime { get; set; } = 5;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(38)]
        [DefaultValue(0.98f)]
        public float JumpFrontReduction { get; set; } = 0.98f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(39)]
        [DefaultValue((short)15)]
        public short JumpFrontReductionBeginTime { get; set; } = 15;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(40)]
        [DefaultValue(0.99f)]
        public float SquatJumpFrontReduction { get; set; } = 0.99f;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(41)]
        [DefaultValue((short)30)]
        public short SquatJumpFrontReductionBTime { get; set; } = 30;

        [OrderedCategory(JumpSettings, 0)]

        [Description("Unknown")]
        [Order(42)]
        [DefaultValue(0.5f)]
        public float MudFloorJumpWeakRatio { get; set; } = 0.5f;



        [OrderedCategory(HipDropCategoryName, 1)]

        [Description("Unknown")]
        [Order(43)]
        [DefaultValue(12f)]
        public float GravityHipDrop { get; set; } = 12f;

        [OrderedCategory(HipDropCategoryName, 1)]

        [Description("Unknown")]
        [Order(44)]
        [DefaultValue(150f)]
        public float LimitSpeedHipDrop { get; set; } = 150f;

        [OrderedCategory(HipDropCategoryName, 1)]

        [Description("Unknown")]
        [Order(45)]
        [DefaultValue(100f)]
        public float HipDropLimitHeight { get; set; } = 100f;

        [OrderedCategory(HipDropCategoryName, 1)]

        [Description("Unknown")]
        [Order(46)]
        [DefaultValue((ushort)2)]
        public ushort HipDropZeroGrTime { get; set; } = 2;

        [OrderedCategory(HipDropCategoryName, 1)]

        [Description("Unknown")]
        [Order(47)]
        [DefaultValue((short)15)]
        public short HipDropLimitTimerAfterTornado { get; set; } = 15;



        [OrderedCategory(SlipUpCategoryName, 2)]

        [Description("Unknown")]
        [Order(48)]
        [DefaultValue((short)8)]
        public short SlipUpSpdCtrlTimer { get; set; } = 8;

        [OrderedCategory(SlipUpCategoryName, 2)]

        [Description("Unknown")]
        [Order(49)]
        [DefaultValue(0.9f)]
        public float SlipUpSpdRatio { get; set; } = 0.9f;

        [OrderedCategory(SlipUpCategoryName, 2)]

        [Description("Unknown")]
        [Order(50)]
        [DefaultValue(16f)]
        public float SlipUpHeight { get; set; } = 16f;

        [OrderedCategory(SlipUpCategoryName, 2)]

        [Description("Unknown")]
        [Order(51)]
        [DefaultValue(8f)]
        public float SlipUpFront { get; set; } = 8f;

        [OrderedCategory(SlipUpCategoryName, 2)]

        [Description("Unknown")]
        [Order(52)]
        [DefaultValue(3f)]
        public float SlipUpFrontWeak { get; set; } = 3f;

        [OrderedCategory(SlipUpCategoryName, 2)]

        [Description("Unknown")]
        [Order(53)]
        [DefaultValue(12f)]
        public float SlipUpHeightHang { get; set; } = 12f;

        [OrderedCategory(SlipUpCategoryName, 2)]

        [Description("Unknown")]
        [Order(54)]
        [DefaultValue(5f)]
        public float SlipUpFrontHang { get; set; } = 5f;

        [OrderedCategory(SlipUpCategoryName, 2)]

        [Description("Unknown")]
        [Order(54)]
        [DefaultValue(150f)]
        public float SlipUpContinueHeight { get; set; } = 150f;



        [OrderedCategory(AirWalkCategoryName, 3)]

        [Description("Unknown")]
        [Order(55)]
        [DefaultValue((ushort)180)]
        public ushort AirWalkTime { get; set; } = 180;

        [OrderedCategory(AirWalkCategoryName, 3)]

        [Description("Unknown")]
        [Order(56)]
        [DefaultValue(3f)]
        public float AirWalkTimerFact1 { get; set; } = 3f;

        [OrderedCategory(AirWalkCategoryName, 3)]

        [Description("Unknown")]
        [Order(57)]
        [DefaultValue((short)300)]
        public short AirWalkTimerFact2 { get; set; } = 300;

        [OrderedCategory(AirWalkCategoryName, 3)]

        [Description("Unknown")]
        [Order(58)]
        [DefaultValue(0.15f)]
        public float AirWalkTimerFact3 { get; set; } = 0.15f;

        [OrderedCategory(AirWalkCategoryName, 3)]
        [DisplayName("XZ Top Speed")]
        [Description("Unknown")]
        [Order(59)]
        [DefaultValue(32f)]
        public float MaxJumpSpeed { get; set; } = 32f;

        [OrderedCategory(AirWalkCategoryName, 3)]

        [Description("Unknown")]
        [Order(60)]
        [DefaultValue(1.3f)]
        public float AirWalkBackBonus { get; set; } = 1.3f;

        [OrderedCategory(AirWalkCategoryName, 3)]

        [Description("Unknown")]
        [Order(61)]
        [DefaultValue(0.1f)]
        public float AirWalkSpeedKiller { get; set; } = 0.1f;

        [OrderedCategory(AirWalkCategoryName, 3)]

        [Description("Unknown")]
        [Order(62)]
        [DefaultValue(10f)]
        public float MaxBackJumpSpeed { get; set; } = 10f;

        [OrderedCategory(AirWalkCategoryName, 3)]

        [Description("Unknown")]
        [Order(63)]
        [DefaultValue(3f)]
        public float AirWalkBonus { get; set; } = 3f;

        [OrderedCategory(AirWalkCategoryName, 3)]

        [Description("Unknown")]
        [Order(64)]
        [DefaultValue((short)60)]
        public short BackJumpLimitFrame { get; set; } = 60;

        [OrderedCategory(AirWalkCategoryName, 3)]

        [Description("Unknown")]
        [Order(65)]
        [DefaultValue(3f)]
        public float BackJumpRatio { get; set; } = 3f;

        [OrderedCategory(AirWalkCategoryName, 3)]

        [Description("Unknown")]
        [Order(66)]
        [DefaultValue((short)15)]
        public short WaitNeutralTimer { get; set; } = 15;



        [OrderedCategory(LandingCategoryName, 4)]

        [Description("Unknown")]
        [Order(67)]
        [DefaultValue(2500f)]
        public float HardLandingHeight { get; set; } = 2500f;

        [OrderedCategory(LandingCategoryName, 4)]

        [Description("Unknown")]
        [Order(68)]
        [DefaultValue((ushort)60)]
        public ushort HardLandStunTimer { get; set; } = 60;



        [OrderedCategory(JumpCodeCategoryName, 5)]

        [Description("Unknown")]
        [Order(69)]
        [DefaultValue(30f)]
        public float CodeJumpPowerWeak { get; set; } = 30f;

        [OrderedCategory(JumpCodeCategoryName, 5)]

        [Description("Unknown")]
        [Order(70)]
        [DefaultValue(60f)]
        public float CodeJumpPowerMiddle { get; set; } = 60f;

        [OrderedCategory(JumpCodeCategoryName, 5)]

        [Description("Unknown")]
        [Order(71)]
        [DefaultValue(100f)]
        public float CodeJumpPowerHigh { get; set; } = 100f;

        [OrderedCategory(JumpCodeCategoryName, 5)]

        [Description("Unknown")]
        [Order(72)]
        [DefaultValue(30f)]
        public float CodeJumpPowerNormal { get; set; } = 30f;



        [OrderedCategory(TrampleRecoilCategoryName, 6)]

        [Description("Unknown")]
        [Order(73)]
        [DefaultValue(19f)]
        public float TrampleNormal { get; set; } = 19f;

        [OrderedCategory(TrampleRecoilCategoryName, 6)]

        [Description("Unknown")]
        [Order(74)]
        [DefaultValue(4f)]
        public float TrampleLong { get; set; } = 4f;

        [OrderedCategory(TrampleRecoilCategoryName, 6)]

        [Description("Unknown")]
        [Order(75)]
        [DefaultValue(28f)]
        public float TrampleNormalTaco { get; set; } = 28f;

        [OrderedCategory(TrampleRecoilCategoryName, 6)]

        [Description("Unknown")]
        [Order(76)]
        [DefaultValue(40f)]
        public float TrampleBegoma { get; set; } = 40f;

        [OrderedCategory(TrampleRecoilCategoryName, 6)]

        [Description("Unknown")]
        [Order(77)]
        [DefaultValue(0.6f)]
        public float TrampleBegomaRotRise { get; set; } = 0.6f;

        [OrderedCategory(TrampleRecoilCategoryName, 6)]

        [Description("Unknown")]
        [Order(78)]
        [DefaultValue(0.25f)]
        public float TrampleBegomaRotFall { get; set; } = 0.25f;

        [OrderedCategory(TrampleRecoilCategoryName, 6)]

        [Description("Unknown")]
        [Order(79)]
        [DefaultValue((ushort)12)]
        public ushort TrampleBegomaOpenTime { get; set; } = 12;



        [OrderedCategory(UpwardAttackRecoilCategoryName, 7)]

        [Description("Unknown")]
        [Order(80)]
        [DefaultValue(10f)]
        public float DropUnderPowerMin { get; set; } = 10f;

        [OrderedCategory(UpwardAttackRecoilCategoryName, 7)]

        [Description("Unknown")]
        [Order(81)]
        [DefaultValue(20f)]
        public float DropUnderPowerMax { get; set; } = 20f;



        [OrderedCategory(MessageJumpCategoryName, 8)]

        [Description("Unknown")]
        [Order(82)]
        [DefaultValue(10f)]
        public float MsgJumpGroundPowerXZ { get; set; } = 10f;

        [OrderedCategory(MessageJumpCategoryName, 8)]

        [Description("Unknown")]
        [Order(83)]
        [DefaultValue(20f)]
        public float MsgJumpGroundPowerY { get; set; } = 20f;

        [OrderedCategory(MessageJumpCategoryName, 8)]

        [Description("Unknown")]
        [Order(84)]
        [DefaultValue(15f)]
        public float MsgJumpAirPower { get; set; } = 15f;

        [OrderedCategory(MessageJumpCategoryName, 8)]

        [Description("Unknown")]
        [Order(85)]
        [DefaultValue(5f)]
        public float BilliardJumpExtra { get; set; } = 5f;



        [OrderedCategory(LeadJumpInputCategoryName, 9)]

        [Description("Unknown")]
        [Order(86)]
        [DefaultValue((short)4)]
        public short FutureJumpReqLimitTime { get; set; } = 4;



        [OrderedCategory(WarpPodJumpCategoryName, 10)]

        [Description("Unknown")]
        [Order(87)]
        [DefaultValue(20f)]
        public float WarpPodJumpX { get; set; } = 20f;

        [OrderedCategory(WarpPodJumpCategoryName, 10)]

        [Description("Unknown")]
        [Order(88)]
        [DefaultValue(30f)]
        public float WarpPodJumpY { get; set; } = 30f;



        [OrderedCategory(MediumDamageCategoryName, 11)]

        [Description("Unknown")]
        [Order(89)]
        [DefaultValue(15f)]
        public float JumpHeightDamage { get; set; } = 15f;

        [OrderedCategory(MediumDamageCategoryName, 11)]

        [Description("Unknown")]
        [Order(90)]
        [DefaultValue(9f)]
        public float JumpDistDamage { get; set; } = 9f;

        [OrderedCategory(MediumDamageCategoryName, 11)]

        [Description("Unknown")]
        [Order(91)]
        [DefaultValue(1f)]
        public float GravityDamage { get; set; } = 1f;



        [OrderedCategory(HeavyDamageCategoryName, 12)]

        [Description("Unknown")]
        [Order(92)]
        [DefaultValue(25f)]
        public float JumpHeightLargeDamage { get; set; } = 25f;

        [OrderedCategory(HeavyDamageCategoryName, 12)]

        [Description("Unknown")]
        [Order(93)]
        [DefaultValue(20f)]
        public float JumpDistLargeDamage { get; set; } = 20f;



        [OrderedCategory(SmallDamageCategoryName, 13)]

        [Description("Unknown")]
        [Order(94)]
        [DefaultValue(15f)]
        public float SlideDistFaint { get; set; } = 15f;

        [OrderedCategory(SmallDamageCategoryName, 13)]

        [Description("Unknown")]
        [Order(95)]
        [DefaultValue((short)15)]
        public short FaintTimer1 { get; set; } = 15;

        [OrderedCategory(SmallDamageCategoryName, 13)]

        [Description("Unknown")]
        [Order(96)]
        [DefaultValue((short)15)]
        public short FaintTimer2 { get; set; } = 15;

        [OrderedCategory(SmallDamageCategoryName, 13)]

        [Description("Unknown")]
        [Order(97)]
        [DefaultValue(0.9f)]
        public float FaintFriction1 { get; set; } = 0.9f;

        [OrderedCategory(SmallDamageCategoryName, 13)]

        [Description("Unknown")]
        [Order(98)]
        [DefaultValue(0.9f)]
        public float FaintFriction2 { get; set; } = 0.9f;



        [OrderedCategory(BeingBlownAwayCategoryName, 14)]

        [Description("Unknown")]
        [Order(99)]
        [DefaultValue(15f)]
        public float SlideDistFlip { get; set; } = 15f;

        [OrderedCategory(BeingBlownAwayCategoryName, 14)]

        [Description("Unknown")]
        [Order(100)]
        [DefaultValue(7.5f)]
        public float SlideDistFlipSpin { get; set; } = 7.5f;

        [OrderedCategory(BeingBlownAwayCategoryName, 14)]

        [Description("Unknown")]
        [Order(101)]
        [DefaultValue((short)15)]
        public short FlipTimer1 { get; set; } = 15;

        [OrderedCategory(BeingBlownAwayCategoryName, 14)]

        [Description("Unknown")]
        [Order(102)]
        [DefaultValue((short)15)]
        public short FlipTimer2 { get; set; } = 15;

        [OrderedCategory(BeingBlownAwayCategoryName, 14)]

        [Description("Unknown")]
        [Order(103)]
        [DefaultValue(0.98f)]
        public float FlipFriction1 { get; set; } = 0.98f;

        [OrderedCategory(BeingBlownAwayCategoryName, 14)]

        [Description("Unknown")]
        [Order(104)]
        [DefaultValue(0.97f)]
        public float FlipFriction2 { get; set; } = 0.97f;

        [OrderedCategory(BeingBlownAwayCategoryName, 14)]

        [Description("Unknown")]
        [Order(105)]
        [DefaultValue(0.6f)]
        public float FlipFriction3 { get; set; } = 0.6f;



        [OrderedCategory(FireRunDamageCategoryName, 15)]

        [Description("Unknown")]
        [Order(106)]
        [DefaultValue((ushort)40)]
        public ushort FireRunTimer1 { get; set; } = 40;

        [OrderedCategory(FireRunDamageCategoryName, 15)]

        [Description("Unknown")]
        [Order(107)]
        [DefaultValue((ushort)30)]
        public ushort FireRunTimer2 { get; set; } = 30;

        [OrderedCategory(FireRunDamageCategoryName, 15)]

        [Description("Unknown")]
        [Order(108)]
        [DefaultValue((ushort)15)]
        public ushort FireRunTimer3 { get; set; } = 15;

        [OrderedCategory(FireRunDamageCategoryName, 15)]

        [Description("Unknown")]
        [Order(109)]
        [DefaultValue(16f)]
        public float FireRunSpeed { get; set; } = 16f;

        [OrderedCategory(FireRunDamageCategoryName, 15)]

        [Description("Unknown")]
        [Order(110)]
        [DefaultValue(0.1f)]
        public float FireRunTurnRatio { get; set; } = 0.1f;

        [OrderedCategory(FireRunDamageCategoryName, 15)]

        [Description("Unknown")]
        [Order(111)]
        [DefaultValue(5f)]
        public float FireRunGravity { get; set; } = 5f;

        [OrderedCategory(FireRunDamageCategoryName, 15)]

        [Description("Unknown")]
        [Order(112)]
        [DefaultValue(50f)]
        public float FireRunFirstJump { get; set; } = 50f;



        [OrderedCategory(FireDanceDamageCategoryName, 16)]

        [Description("Unknown")]
        [Order(113)]
        [DefaultValue(0.2f)]
        public float FireDanceTurnRatio { get; set; } = 0.2f;

        [OrderedCategory(FireDanceDamageCategoryName, 16)]

        [Description("Unknown")]
        [Order(114)]
        [DefaultValue(1f)]
        public float FireDanceGravityRise { get; set; } = 1f;

        [OrderedCategory(FireDanceDamageCategoryName, 16)]

        [Description("Unknown")]
        [Order(115)]
        [DefaultValue(0.75f)]
        public float FireDanceGravityDrop { get; set; } = 0.75f;

        [OrderedCategory(FireDanceDamageCategoryName, 16)]

        [Description("Unknown")]
        [Order(116)]
        [DefaultValue(40f)]
        public float FireDanceFirstJump { get; set; } = 40f;

        [OrderedCategory(FireDanceDamageCategoryName, 16)]

        [Description("Unknown")]
        [Order(117)]
        [DefaultValue(20f)]
        public float FireDanceSecondJump { get; set; } = 20f;

        [OrderedCategory(FireDanceDamageCategoryName, 16)]

        [Description("Unknown")]
        [Order(118)]
        [DefaultValue(10f)]
        public float FireDanceMoveSpeed { get; set; } = 10f;

        [OrderedCategory(FireDanceDamageCategoryName, 16)]

        [Description("Unknown")]
        [Order(119)]
        [DefaultValue(0.5f)]
        public float FireDanceMoveAcc { get; set; } = 0.5f;



        [OrderedCategory(BlackHoleCategoryName, 17)]

        [Description("Unknown")]
        [Order(120)]
        [DefaultValue(0.992f)]
        public float BlackHoleRadiusRatio { get; set; } = 0.992f;

        [OrderedCategory(BlackHoleCategoryName, 17)]

        [Description("Unknown")]
        [Order(121)]
        [DefaultValue(0.002f)]
        public float BlackHoleScaleSpeed { get; set; } = 0.002f;

        [OrderedCategory(BlackHoleCategoryName, 17)]

        [Description("Unknown")]
        [Order(122)]
        [DefaultValue(0.7f)]
        public float BlackHoleScaleLimit { get; set; } = 0.7f;

        [OrderedCategory(BlackHoleCategoryName, 17)]

        [Description("Unknown")]
        [Order(123)]
        [DefaultValue(0.0018f)]
        public float BlackHoleRotateSpeed { get; set; } = 0.0018f;

        [OrderedCategory(BlackHoleCategoryName, 17)]

        [Description("Unknown")]
        [Order(124)]
        [DefaultValue(0.7f)]
        public float BlackHoleRotateLimit { get; set; } = 0.7f;

        [OrderedCategory(BlackHoleCategoryName, 17)]

        [Description("Unknown")]
        [Order(125)]
        [DefaultValue(1f)]
        public float BlackHoleFirstRadius { get; set; } = 1f;

        [OrderedCategory(BlackHoleCategoryName, 17)]

        [Description("Unknown")]
        [Order(126)]
        [DefaultValue((ushort)165)]
        public ushort BlackHoleHideTime { get; set; } = 165;



        [OrderedCategory(WaterUnderwaterDamageCategoryName, 18)]

        [Description("Unknown")]
        [Order(127)]
        [DefaultValue((ushort)60)]
        public ushort WaterInnerFaintTime { get; set; } = 60;

        [OrderedCategory(WaterUnderwaterDamageCategoryName, 18)]

        [Description("Unknown")]
        [Order(128)]
        [DefaultValue(10f)]
        public float SwimFaintSpeed { get; set; } = 10f;

        [OrderedCategory(WaterUnderwaterDamageCategoryName, 18)]

        [Description("Unknown")]
        [Order(129)]
        [DefaultValue((ushort)60)]
        public ushort WaterInnerDamageTime { get; set; } = 60;

        [OrderedCategory(WaterUnderwaterDamageCategoryName, 18)]

        [Description("Unknown")]
        [Order(130)]
        [DefaultValue(10f)]
        public float SwimDamageSpeed { get; set; } = 10f;

        [OrderedCategory(WaterUnderwaterDamageCategoryName, 18)]

        [Description("Unknown")]
        [Order(131)]
        [DefaultValue(5f)]
        public float SwimSurfaceDamageSpeed { get; set; } = 5f;

        [OrderedCategory(WaterUnderwaterDamageCategoryName, 18)]

        [Description("Unknown")]
        [Order(132)]
        [DefaultValue(26f)]
        public float WaterSurfaceDamageJump { get; set; } = 26f;

        [OrderedCategory(WaterUnderwaterDamageCategoryName, 18)]
        [DisplayName("King Fin Swim Damage Timer")]
        [Description("Unknown")]
        [Order(133)]
        [DefaultValue((ushort)90)]
        public ushort SwimDamageTimerEx1 { get; set; } = 90;

        [OrderedCategory(WaterUnderwaterDamageCategoryName, 18)]
        [DisplayName("King Fin Swim Damage Speed")]
        [Description("Unknown")]
        [Order(134)]
        [DefaultValue(35f)]
        public float SwimDamageSpeedEx1 { get; set; } = 35f;



        [OrderedCategory(FountainJumpCategoryName, 19)]

        [Description("Unknown")]
        [Order(135)]
        [DefaultValue(18f)]
        public float JumpHeightFlow { get; set; } = 18f;

        [OrderedCategory(FountainJumpCategoryName, 19)]

        [Description("Unknown")]
        [Order(136)]
        [DefaultValue(2f)]
        public float JumpDistFlow { get; set; } = 2f;

        [OrderedCategory(FountainJumpCategoryName, 19)]

        [Description("Unknown")]
        [Order(137)]
        [DefaultValue(0.3f)]
        public float GravityFlow { get; set; } = 0.3f;



        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(138)]
        [DefaultValue(45f)]
        public float FlatAngle { get; set; } = 45f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(139)]
        [DefaultValue(60f)]
        public float SlipAngle { get; set; } = 60f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(140)]
        [DefaultValue(85f)]
        public float ForceWallAngle { get; set; } = 85f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(141)]
        [DefaultValue(120f)]
        public float DebugMoveSpeed { get; set; } = 120f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(142)]
        [DefaultValue(13f)]
        public float WalkSpeed { get; set; } = 13f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(143)]
        [DefaultValue(0.94f)]
        public float InertiaStandardStop { get; set; } = 0.94f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(144)]
        [DefaultValue(0.9f)]
        public float InertiaStandardMax { get; set; } = 0.9f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(145)]
        [DefaultValue(0.98f)]
        public float InertiaBdash { get; set; } = 0.98f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(146)]
        [DefaultValue(0.992f)]
        public float InertiaBdashAfter { get; set; } = 0.992f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(146)]
        [DefaultValue(0.5f)]
        public float UNKNOWN0 { get; set; } = 0.5f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(147)]
        [DefaultValue(0.85f)]
        public float InertiaStop { get; set; } = 0.85f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(148)]
        [DefaultValue(0.95f)]
        public float InertiaSquat { get; set; } = 0.95f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(149)]
        [DefaultValue(0.91f)]
        public float InertiaTurnSlip { get; set; } = 0.91f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(150)]
        [DefaultValue(0.85f)]
        public float InertiaTurning { get; set; } = 0.85f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(151)]
        [DefaultValue(0.8f)]
        public float InertiaJumpFinish { get; set; } = 0.8f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(152)]
        [DefaultValue(1f)]
        public float InertiaReflectSlip { get; set; } = 1f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(153)]
        [DefaultValue(0.95f)]
        public float InertiaStartSpin { get; set; } = 0.95f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(154)]
        [DefaultValue(0.8f)]
        public float InertiaOverSpeed { get; set; } = 0.8f;


        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(155)]
        [DefaultValue(0.9f)]
        public float TurnAngleSpeed { get; set; } = 0.9f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(156)]
        [DefaultValue(0.15f)]
        public float TurnAngleSpeed2 { get; set; } = 0.15f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(157)]
        [DefaultValue(0.1f)]
        public float TurnAngleSpeed3 { get; set; } = 0.1f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(158)]
        [DefaultValue(0.04f)]
        public float TurnAngleSpeedSlowWalk { get; set; } = 0.04f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(159)]
        [DefaultValue(30f)]
        public float GravityStandard { get; set; } = 30f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(160)]
        [DefaultValue(20f)]
        public float GravityGrounding { get; set; } = 20f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(161)]
        [DefaultValue(2f)]
        public float DashMultiply { get; set; } = 2f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(162)]
        [DefaultValue(0.05f)]
        public float CameraAngleLimit { get; set; } = 0.05f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(163)]
        [DefaultValue((ushort)30)]
        public ushort StartSpinTime { get; set; } = 30;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(164)]
        [DefaultValue((ushort)40)]
        public ushort DashAfterTime { get; set; } = 40;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(165)]
        [DefaultValue((ushort)10000)]
        public ushort AutoBdashTime { get; set; } = 10000;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(166)]
        [DefaultValue((ushort)10)]
        public ushort SlowStartTime { get; set; } = 10;


        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(167)]
        [DefaultValue(1.25f)]
        public float StartSpinAnimeRatio { get; set; } = 1.25f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(168)]
        [DefaultValue(0.5f)]
        public float SlopeAnimeRatio { get; set; } = 0.5f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(169)]
        [DefaultValue(0.75f)]
        public float SlopeSpinAnimeRatio { get; set; } = 0.75f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(170)]
        [DefaultValue(1.5f)]
        public float ItemDashRatio { get; set; } = 1.5f;

        [OrderedCategory(RunningWalkingCategoryName, 20)]

        [Description("Unknown")]
        [Order(171)]
        [DefaultValue((ushort)180)]
        public ushort ItemDashTimer { get; set; } = 180;



        [OrderedCategory(RunningWalkingOnIceCategoryName, 21)]

        [Description("Unknown")]
        [Order(172)]
        [DefaultValue(0.985f)]
        public float InertiaIceStandardStop { get; set; } = 0.985f;

        [OrderedCategory(RunningWalkingOnIceCategoryName, 21)]

        [Description("Unknown")]
        [Order(173)]
        [DefaultValue(0.995f)]
        public float InertiaIceStandardMax { get; set; } = 0.995f;

        [OrderedCategory(RunningWalkingOnIceCategoryName, 21)]

        [Description("Unknown")]
        [Order(174)]
        [DefaultValue(0.98f)]
        public float InertiaIceStartSpin { get; set; } = 0.98f;

        [OrderedCategory(RunningWalkingOnIceCategoryName, 21)]

        [Description("Unknown")]
        [Order(175)]
        [DefaultValue(0.992f)]
        public float InertiaIceStop { get; set; } = 0.992f;

        [OrderedCategory(RunningWalkingOnIceCategoryName, 21)]

        [Description("Unknown")]
        [Order(176)]
        [DefaultValue(0.2f)]
        public float InertiaIceTurn { get; set; } = 0.2f;



        [OrderedCategory(RunningWalkingOnSlipCategoryName, 22)]

        [Description("Unknown")]
        [Order(177)]
        [DefaultValue(0.98f)]
        public float InertiaSlipStandardStop { get; set; } = 0.98f;

        [OrderedCategory(RunningWalkingOnSlipCategoryName, 22)]

        [Description("Unknown")]
        [Order(178)]
        [DefaultValue(0.99f)]
        public float InertiaSlipStandardMax { get; set; } = 0.99f;

        [OrderedCategory(RunningWalkingOnSlipCategoryName, 22)]

        [Description("Unknown")]
        [Order(179)]
        [DefaultValue(0.985f)]
        public float InertiaSlipStartSpin { get; set; } = 0.985f;

        [OrderedCategory(RunningWalkingOnSlipCategoryName, 22)]

        [Description("Unknown")]
        [Order(180)]
        [DefaultValue(0.98f)]
        public float InertiaSlipStop { get; set; } = 0.98f;

        [OrderedCategory(RunningWalkingOnSlipCategoryName, 22)]

        [Description("Unknown")]
        [Order(181)]
        [DefaultValue(0.98f)]
        public float InertiaSlipTurn { get; set; } = 0.98f;



        [OrderedCategory(TurnsSlipsBrakesCategoryName, 23)]

        [Description("Unknown")]
        [Order(182)]
        [DefaultValue(2.6f)]
        public float TurnSlipAngle { get; set; } = 2.6f;

        [OrderedCategory(TurnsSlipsBrakesCategoryName, 23)]

        [Description("Unknown")]
        [Order(183)]
        [DefaultValue((ushort)10)]
        public ushort TurnReadyTime { get; set; } = 10;

        [OrderedCategory(TurnsSlipsBrakesCategoryName, 23)]

        [Description("Unknown")]
        [Order(184)]
        [DefaultValue(0.7f)]
        public float TurnSlipNeutral { get; set; } = 0.7f;

        [OrderedCategory(TurnsSlipsBrakesCategoryName, 23)]

        [Description("Unknown")]
        [Order(185)]
        [DefaultValue(0.25f)]
        public float SlipSpeed { get; set; } = 0.25f;

        [OrderedCategory(TurnsSlipsBrakesCategoryName, 23)]

        [Description("Unknown")]
        [Order(186)]
        [DefaultValue(0.1f)]
        public float FastTurnSpeed { get; set; } = 0.1f;

        [OrderedCategory(TurnsSlipsBrakesCategoryName, 23)]

        [Description("Unknown")]
        [Order(187)]
        [DefaultValue((short)6)]
        public short TurnSlipTime { get; set; } = 6;

        [OrderedCategory(TurnsSlipsBrakesCategoryName, 23)]

        [Description("Unknown")]
        [Order(188)]
        [DefaultValue((short)60)]
        public short TurnSlipTimeB { get; set; } = 60;

        [OrderedCategory(TurnsSlipsBrakesCategoryName, 23)]

        [Description("Unknown")]
        [Order(189)]
        [DefaultValue((short)0)]
        public short TurnJumpInhibitTime { get; set; } = 0;

        [OrderedCategory(TurnsSlipsBrakesCategoryName, 23)]

        [Description("Unknown")]
        [Order(190)]
        [DefaultValue(120f)]
        public float LandTurnHeight { get; set; } = 120f;

        [OrderedCategory(TurnsSlipsBrakesCategoryName, 23)]

        [Description("Unknown")]
        [Order(191)]
        [DefaultValue(0.85f)]
        public float InertiaBrake { get; set; } = 0.85f;

        [OrderedCategory(TurnsSlipsBrakesCategoryName, 23)]

        [Description("Unknown")]
        [Order(192)]
        [DefaultValue((ushort)10)]
        public ushort StandingTurnTime { get; set; } = 10;

        [OrderedCategory(TurnsSlipsBrakesCategoryName, 23)]

        [Description("Unknown")]
        [Order(193)]
        [DefaultValue((ushort)15)]
        public ushort WeakTurnTime { get; set; } = 15;

        [OrderedCategory(TurnsSlipsBrakesCategoryName, 23)]

        [Description("Unknown")]
        [Order(194)]
        [DefaultValue((ushort)15)]
        public ushort BrakeFirstTimer { get; set; } = 15;

        [OrderedCategory(TurnsSlipsBrakesCategoryName, 23)]

        [Description("Unknown")]
        [Order(195)]
        [DefaultValue((ushort)33)]
        public ushort BrakeSecondTimer { get; set; } = 33;



        [OrderedCategory(SlopeCategoryName, 24)]

        [Description("Unknown")]
        [Order(196)]
        [DefaultValue(22f)]
        public float SlopeSpeedMax { get; set; } = 22f;

        [OrderedCategory(SlopeCategoryName, 24)]

        [Description("Unknown")]
        [Order(197)]
        [DefaultValue(0.01f)]
        public float SlopeAccel { get; set; } = 0.01f;

        [OrderedCategory(SlopeCategoryName, 24)]

        [Description("Unknown")]
        [Order(198)]
        [DefaultValue(20f)]
        public float SlopeSpeedMaxBraking { get; set; } = 20f;

        [OrderedCategory(SlopeCategoryName, 24)]

        [Description("Unknown")]
        [Order(199)]
        [DefaultValue(0.95f)]
        public float SlopeFinishInertia { get; set; } = 0.95f;

        [OrderedCategory(SlopeCategoryName, 24)]

        [Description("Unknown")]
        [Order(200)]
        [DefaultValue(0.94f)]
        public float SlopeCancelInertia { get; set; } = 0.94f;

        [OrderedCategory(SlopeCategoryName, 24)]

        [Description("Unknown")]
        [Order(201)]
        [DefaultValue(15f)]
        public float SlopeAnimeFinishSpeed { get; set; } = 15f;

        [OrderedCategory(SlopeCategoryName, 24)]

        [Description("Unknown")]
        [Order(202)]
        [DefaultValue(20f)]
        public float SlopeDashAngleFactor { get; set; } = 20f;

        [OrderedCategory(SlopeCategoryName, 24)]

        [Description("Unknown")]
        [Order(203)]
        [DefaultValue(0.1f)]
        public float SlopeDashSpeedFactor { get; set; } = 0.1f;

        [OrderedCategory(SlopeCategoryName, 24)]

        [Description("Unknown")]
        [Order(204)]
        [DefaultValue(50f)]
        public float SlopeDashAccelFactor { get; set; } = 50f;

        [OrderedCategory(SlopeCategoryName, 24)]

        [Description("Unknown")]
        [Order(205)]
        [DefaultValue((ushort)75)]
        public ushort SlopeDashAccelTime { get; set; } = 75;

        [OrderedCategory(SlopeCategoryName, 24)]

        [Description("Unknown")]
        [Order(206)]
        [DefaultValue(0.95f)]
        public float SlopeSideMoveInertia { get; set; } = 0.95f;

        [OrderedCategory(SlopeCategoryName, 24)]

        [Description("Unknown")]
        [Order(207)]
        [DefaultValue(0.98f)]
        public float SlopeSideStopInertia { get; set; } = 0.98f;

        [OrderedCategory(SlopeCategoryName, 24)]

        [Description("Unknown")]
        [Order(208)]
        [DefaultValue(10f)]
        public float SlopeSideMoveSpeed { get; set; } = 10f;

        [OrderedCategory(SlopeCategoryName, 24)]

        [Description("Unknown")]
        [Order(209)]
        [DefaultValue(0.05f)]
        public float SlopeCurveAssist { get; set; } = 0.05f;

        [OrderedCategory(SlopeCategoryName, 24)]

        [Description("Unknown")]
        [Order(210)]
        [DefaultValue(0.03f)]
        public float SlipMoveTurnAngleRad { get; set; } = 0.03f;



        [OrderedCategory(StepCategoryName, 25)]

        [Description("Unknown")]
        [Order(211)]
        [DefaultValue(50f)]
        public float WalkStepHeight { get; set; } = 50f;



        [OrderedCategory(AnimeCategoryName, 26)]

        [Description("Unknown")]
        [Order(212)]
        [DefaultValue(40f)]
        public float TiltRatio { get; set; } = 40f;

        [OrderedCategory(AnimeCategoryName, 26)]

        [Description("Unknown")]
        [Order(213)]
        [DefaultValue(0.4f)]
        public float LookDownRatio { get; set; } = 0.4f;

        [OrderedCategory(AnimeCategoryName, 26)]
        [DisplayName("% to start Tiptoe animation")]
        [Description("Unknown")]
        [Order(214)]
        [DefaultValue(0.05f)]
        public float SpeedStepLow { get; set; } = 0.05f;

        [OrderedCategory(AnimeCategoryName, 26)]
        [DisplayName("% to start Walk animation")]
        [Description("Unknown")]
        [Order(215)]
        [DefaultValue(0.75f)]
        public float SpeedStepMiddle { get; set; } = 0.75f;

        [OrderedCategory(AnimeCategoryName, 26)]
        [DisplayName("% to start Run animation")]
        [Description("Unknown")]
        [Order(216)]
        [DefaultValue(0.95f)]
        public float SpeedStepHigh { get; set; } = 0.95f;

        [OrderedCategory(AnimeCategoryName, 26)]

        [Description("Unknown")]
        [Order(217)]
        [DefaultValue(6f)]
        public float MaxAnmSpeedA { get; set; } = 6f;

        [OrderedCategory(AnimeCategoryName, 26)]

        [Description("Unknown")]
        [Order(218)]
        [DefaultValue(2.5f)]
        public float MinAnmSpeedA { get; set; } = 2.5f;

        [OrderedCategory(AnimeCategoryName, 26)]

        [Description("Unknown")]
        [Order(219)]
        [DefaultValue(4f)]
        public float MaxAnmSpeedB { get; set; } = 4f;

        [OrderedCategory(AnimeCategoryName, 26)]

        [Description("Unknown")]
        [Order(220)]
        [DefaultValue(2.5f)]
        public float MinAnmSpeedB { get; set; } = 2.5f;

        [OrderedCategory(AnimeCategoryName, 26)]

        [Description("Unknown")]
        [Order(221)]
        [DefaultValue(1.33f)]
        public float MaxAnmSpeedC { get; set; } = 1.33f;

        [OrderedCategory(AnimeCategoryName, 26)]

        [Description("Unknown")]
        [Order(222)]
        [DefaultValue(0.67f)]
        public float MinAnmSpeedC { get; set; } = 0.67f;

        [OrderedCategory(AnimeCategoryName, 26)]

        [Description("Unknown")]
        [Order(223)]
        [DefaultValue(0.2f)]
        public float WeightBlendRatio { get; set; } = 0.2f;

        [OrderedCategory(AnimeCategoryName, 26)]

        [Description("Unknown")]
        [Order(224)]
        [DefaultValue(2f)]
        public float MudFloorSlipRatio { get; set; } = 2f;



        [OrderedCategory(SensitivityCategoryName, 27)]

        [Description("Unknown")]
        [Order(225)]
        [DefaultValue(0.1f)]
        public float StickAngleMargin { get; set; } = 0.1f;

        [OrderedCategory(SensitivityCategoryName, 27)]

        [Description("Unknown")]
        [Order(226)]
        [DefaultValue(0.25f)]
        public float StickMarginX { get; set; } = 0.25f;

        [OrderedCategory(SensitivityCategoryName, 27)]

        [Description("Unknown")]
        [Order(227)]
        [DefaultValue(0.2f)]
        public float StickMarginY { get; set; } = 0.2f;

        [OrderedCategory(SensitivityCategoryName, 27)]

        [Description("Unknown")]
        [Order(228)]
        [DefaultValue(0.5f)]
        public float StickMarginXStart { get; set; } = 0.5f;

        [OrderedCategory(SensitivityCategoryName, 27)]

        [Description("Unknown")]
        [Order(229)]
        [DefaultValue(0.5f)]
        public float StickMarginYStart { get; set; } = 0.5f;

        [OrderedCategory(SensitivityCategoryName, 27)]

        [Description("Unknown")]
        [Order(230)]
        [DefaultValue(0.3f)]
        public float StickHeavyMinRatio { get; set; } = 0.3f;

        [OrderedCategory(SensitivityCategoryName, 27)]

        [Description("Unknown")]
        [Order(231)]
        [DefaultValue(0.7854f)]
        public float StickHeavyMinAngle { get; set; } = 0.7854f;

        [OrderedCategory(SensitivityCategoryName, 27)]

        [Description("Unknown")]
        [Order(232)]
        [DefaultValue(1.5708f)]
        public float StickHeavyMaxAngle { get; set; } = 1.5708f;



        [OrderedCategory(CrouchWalkCategoryName, 28)]

        [Description("Unknown")]
        [Order(233)]
        [DefaultValue(0.05f)]
        public float SpeedSquatWalkLower { get; set; } = 0.05f;

        [OrderedCategory(CrouchWalkCategoryName, 28)]

        [Description("Unknown")]
        [Order(234)]
        [DefaultValue(6f)]
        public float SquatWalkStep { get; set; } = 6f;

        [OrderedCategory(CrouchWalkCategoryName, 28)]

        [Description("Unknown")]
        [Order(235)]
        [DefaultValue(0.2f)]
        public float SquatWalkMaxSpeed { get; set; } = 0.2f;

        [OrderedCategory(CrouchWalkCategoryName, 28)]

        [Description("Unknown")]
        [Order(236)]
        [DefaultValue(0.1f)]
        public float SquatWalkMinSpeed { get; set; } = 0.1f;



        [OrderedCategory(WindCategoryName, 29)]

        [Description("Unknown")]
        [Order(237)]
        [DefaultValue(1f)]
        public float WindSlideLimit { get; set; } = 1f;

        [OrderedCategory(WindCategoryName, 29)]

        [Description("Unknown")]
        [Order(238)]
        [DefaultValue(1.2f)]
        public float WindSlideFriction { get; set; } = 1.2f;

        [OrderedCategory(WindCategoryName, 29)]

        [Description("Unknown")]
        [Order(239)]
        [DefaultValue(0.5f)]
        public float WindForwardFriction { get; set; } = 0.5f;

        [OrderedCategory(WindCategoryName, 29)]

        [Description("Unknown")]
        [Order(240)]
        [DefaultValue(0.8f)]
        public float WindSlideFrictionAgainst { get; set; } = 0.8f;

        [OrderedCategory(WindCategoryName, 29)]

        [Description("Unknown")]
        [Order(241)]
        [DefaultValue(0.1f)]
        public float WindJumpingFriction { get; set; } = 0.1f;



        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(242)]
        [DefaultValue((ushort)45)]
        public ushort TornadoTime { get; set; } = 45;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(243)]
        [DefaultValue((ushort)150)]
        public ushort TornadoTimeAir { get; set; } = 150;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(244)]
        [DefaultValue((ushort)150)]
        public ushort AirWalkTimeTornado { get; set; } = 150;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(244)]
        [DefaultValue((ushort)60)]
        public ushort TornadoRestartTime { get; set; } = 60;


        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(245)]
        [DefaultValue(1.5f)]
        public float SpinDifferMargin { get; set; } = 1.5f;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(246)]
        [DefaultValue(4.5f)]
        public float SpinGoalAngle { get; set; } = 4.5f;


        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(247)]
        [DefaultValue((short)25)]
        public short SpinInputLimitTime { get; set; } = 25;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(248)]
        [DefaultValue((short)120)]
        public short SpinTime { get; set; } = 120;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(249)]
        [DefaultValue(1.8f)]
        public float SpinSpeed { get; set; } = 1.8f;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(250)]
        [DefaultValue(1.1f)]
        public float SpinWalkRatio { get; set; } = 1.1f;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(251)]
        [DefaultValue(1.3f)]
        public float SpinJumpRatio { get; set; } = 1.3f;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(252)]
        [DefaultValue(2f)]
        public float SpinWallReboundSpeed { get; set; } = 2f;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(253)]
        [DefaultValue((ushort)49)]
        public ushort SpinFinishTime { get; set; } = 49;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(254)]
        [DefaultValue(0.2f)]
        public float SpinFinishRate { get; set; } = 0.2f;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(255)]
        [DefaultValue(0.5f)]
        public float TornadoMultiply { get; set; } = 0.5f;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(256)]
        [DefaultValue(0.1f)]
        public float TurnAngleSpeedTornado { get; set; } = 0.1f;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(257)]
        [DefaultValue(0.9f)]
        public float InertiaTornadoAccel { get; set; } = 0.9f;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(258)]
        [DefaultValue(0.96f)]
        public float InertiaTornadoBrake { get; set; } = 0.96f;


        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(259)]
        [DefaultValue((ushort)60)]
        public ushort TornadoChargeTime { get; set; } = 60;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(260)]
        [DefaultValue((ushort)300)]
        public ushort TornadoChargeUpTime { get; set; } = 300;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(261)]
        [DefaultValue((ushort)0)]
        public ushort TornadoZeroGravityTimer { get; set; } = 0;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(262)]
        [DefaultValue(0.0001f)]
        public float TornadoBoostPower { get; set; } = 0.0001f;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(263)]
        [DefaultValue(1.532f)]
        public float TornadoBoostAttn { get; set; } = 1.532f;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(264)]
        [DefaultValue((ushort)28)]
        public ushort TornadoBoostTimer { get; set; } = 28;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(265)]
        [DefaultValue(1.6f)]
        public float TornadoBoostAttnMini { get; set; } = 1.6f;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(266)]
        [DefaultValue((ushort)25)]
        public ushort TornadoBoostTimerMini { get; set; } = 25;


        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(267)]
        [DefaultValue(0.96f)]
        public float TornadoTiltCancel { get; set; } = 0.96f;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(268)]
        [DefaultValue(0.33f)]
        public float TornadoTiltAngle { get; set; } = 0.33f;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(269)]
        [DefaultValue(0.018f)]
        public float TornadoTiltSpeed { get; set; } = 0.018f;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(270)]
        [DefaultValue(0.1f)]
        public float TornadoTiltOffSpeed { get; set; } = 0.1f;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(271)]
        [DefaultValue(0.4f)]
        public float TornadoTiltNear { get; set; } = 0.4f;


        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(272)]
        [DefaultValue((ushort)30)]
        public ushort TornadoReflectTimer { get; set; } = 30;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(273)]
        [DefaultValue(1f)]
        public float TornadoReflectSpeed { get; set; } = 1f;


        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(274)]
        [DefaultValue((ushort)24)]
        public ushort AirWalkTimeSpin { get; set; } = 24;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(275)]
        [DefaultValue(600f)]
        public float SpinCoinPullRadius { get; set; } = 600f;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(276)]
        [DefaultValue(0.75f)]
        public float CoinPullAngleSpeedRatio { get; set; } = 0.75f;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(277)]
        [DefaultValue(0.75f)]
        public float CoinPullDistSpeedRatio { get; set; } = 0.75f;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(278)]
        [DefaultValue((ushort)2)]
        public ushort SpinJumpCount { get; set; } = 2;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(279)]
        [DefaultValue((ushort)45)]
        public ushort SpinIntervalTime { get; set; } = 45;

        [OrderedCategory(TornadoCategoryName, 30)]
        [DisplayName("Spin Jump Height")]
        [Description("The height that you gain with the Spin Jump (Spin while in the air)")]
        [Order(280)]
        [DefaultValue(12f)]
        public float SpinJumpHeight { get; set; } = 12f;

        [OrderedCategory(TornadoCategoryName, 30)]

        [Description("Unknown")]
        [Order(281)]
        [DefaultValue(0.25f)]
        public float SpinJumpGravity { get; set; } = 0.25f;



        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(282)]
        [DefaultValue(100f)]
        public float WallStickGrHeight { get; set; } = 100f;

        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(283)]
        [DefaultValue(50f)]
        public float WallStickFrHeight { get; set; } = 50f;

        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(284)]
        [DefaultValue(325f)]
        public float WallStickStepHeight { get; set; } = 325f;

        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(285)]
        [DefaultValue(4f)]
        public float WallDropSpeedStop { get; set; } = 4f;

        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(286)]
        [DefaultValue(14f)]
        public float WallDropSpeedNormal { get; set; } = 14f;


        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(287)]
        [DefaultValue(13f)]
        public float WallJumpPowerXZ { get; set; } = 13f;

        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(288)]
        [DefaultValue(30f)]
        public float WallJumpPowerY { get; set; } = 30f;


        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(289)]
        [DefaultValue(6f)]
        public float WallBackJumpPowerXZ { get; set; } = 6f;

        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(290)]
        [DefaultValue(10f)]
        public float WallBackJumpPowerY { get; set; } = 10f;


        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(291)]
        [DefaultValue((short)15)]
        public short WallStickTime { get; set; } = 15;

        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(292)]
        [DefaultValue((short)60)]
        public short WallStickTimeIce { get; set; } = 60;

        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(293)]
        [DefaultValue((short)180)]
        public short WallReleaseTime { get; set; } = 180;


        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(294)]
        [DefaultValue(0.003f)]
        public float WallSideMoveRatio { get; set; } = 0.003f;

        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(295)]
        [DefaultValue(10f)]
        public float JumpHeightBlown { get; set; } = 10f;

        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(296)]
        [DefaultValue(1f)]
        public float GravityBlown { get; set; } = 1f;


        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(297)]
        [DefaultValue(225f)]
        public float WallHangGrHeight { get; set; } = 225f;

        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(298)]
        [DefaultValue(150f)]
        public float WallHangMyHeight { get; set; } = 150f;

        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(299)]
        [DefaultValue((short)10)]
        public short HangBlendTime { get; set; } = 10;

        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(300)]
        [DefaultValue(20f)]
        public float WallPushAngleRange { get; set; } = 20f;


        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(301)]
        [DefaultValue(0.5f)]
        public float WallFrontAngleRange { get; set; } = 0.5f;

        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(302)]
        [DefaultValue(0.707f)]
        public float WallBackAngleRange { get; set; } = 0.707f;

        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(303)]
        [DefaultValue(0.1f)]
        public float WallStickCancelAngle { get; set; } = 0.1f;


        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(304)]
        [DefaultValue(0.8f)]
        public float WallBackHangStickPower { get; set; } = 0.8f;

        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(305)]
        [DefaultValue(0.5f)]
        public float WallBackHangWalkSpeed { get; set; } = 0.5f;


        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(306)]
        [DefaultValue(0.996f)]
        public float WallTriJumpMargin { get; set; } = 0.996f;


        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(307)]
        [DefaultValue(5f)]
        public float WallSpinFlipGround { get; set; } = 5f;

        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(308)]
        [DefaultValue(12f)]
        public float WallSpinHopGround { get; set; } = 12f;

        [OrderedCategory(WallCategoryName, 31)]

        [Description("Unknown")]
        [Order(309)]
        [DefaultValue(0.75f)]
        public float WallSpinFlipAirRatio { get; set; } = 0.75f;



        [OrderedCategory(ClapCategoryName, 32)]

        [Description("Unknown")]
        [Order(310)]
        [DefaultValue((ushort)6)]
        public ushort ClapCoinTime { get; set; } = 6;

        [OrderedCategory(ClapCategoryName, 32)]

        [Description("Unknown")]
        [Order(311)]
        [DefaultValue(0.33f)]
        public float ClapCoinPullRate { get; set; } = 0.33f;

        [OrderedCategory(ClapCategoryName, 32)]

        [Description("Unknown")]
        [Order(312)]
        [DefaultValue(10f)]
        public float ClapJumpBonusRising { get; set; } = 10f;

        [OrderedCategory(ClapCategoryName, 32)]

        [Description("Unknown")]
        [Order(313)]
        [DefaultValue(15f)]
        public float ClapJumpBonusFalling { get; set; } = 15f;

        [OrderedCategory(ClapCategoryName, 32)]

        [Description("Unknown")]
        [Order(314)]
        [DefaultValue(10f)]
        public float HopLimit { get; set; } = 10f;



        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(315)]
        [DefaultValue(4f)]
        public float SwimFrontAcc { get; set; } = 4f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(316)]
        [DefaultValue(11.5f)]
        public float SwimFrontMaxSpeed { get; set; } = 11.5f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(317)]
        [DefaultValue(70f)]
        public float SwimFrontSpinSpeed { get; set; } = 70f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(318)]
        [DefaultValue(7.5f)]
        public float SwimFrontNormalSpeed { get; set; } = 7.5f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(319)]
        [DefaultValue(7.5f)]
        public float SwimFrontOnWaterSpeed { get; set; } = 7.5f;

        [OrderedCategory(SwimCategoryName, 33)]

        [DisplayName("Red Shell Swim Speed & Flying Star Speed")]
        [Description("For some reason this value controls both")]
        [Order(320)]
        [DefaultValue(18f)]
        public float SwimFrontJetSpeed { get; set; } = 18f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Green Shell Swim Speed")]
        [Order(321)]
        [DefaultValue(14f)]
        public float SwimFrontJetSpeedSlow { get; set; } = 14f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(321)]
        [DefaultValue(5f)]
        public float UNKNOWN1 { get; set; } = 5f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(321)]
        [DefaultValue(8f)]
        public float UNKNOWN2 { get; set; } = 8f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(321)]
        [DefaultValue(10f)]
        public float UNKNOWN3 { get; set; } = 10f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(321)]
        [DefaultValue(7f)]
        public float UNKNOWN4 { get; set; } = 7f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(321)]
        [DefaultValue(7f)]
        public float UNKNOWN5 { get; set; } = 7f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(321)]
        [DefaultValue(14f)]
        public float UNKNOWN6 { get; set; } = 14f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(321)]
        [DefaultValue(12f)]
        public float UNKNOWN7 { get; set; } = 14f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(322)]
        [DefaultValue(1.5f)]
        public float SwimAccRatio { get; set; } = 1.5f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(323)]
        [DefaultValue(0.1f)]
        public float SwimAccMinRatio { get; set; } = 0.1f;


        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(324)]
        [DefaultValue(0.985f)]
        public float SwimFrontIne { get; set; } = 0.985f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(325)]
        [DefaultValue(0.992f)]
        public float SwimStopIne { get; set; } = 0.992f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(326)]
        [DefaultValue(0.98f)]
        public float SwimStopIneSurface { get; set; } = 0.98f;


        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(327)]
        [DefaultValue(0.04f)]
        public float SwimRotSpeedX { get; set; } = 0.04f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(328)]
        [DefaultValue(0.012f)]
        public float SwimRotSpeedZ { get; set; } = 0.012f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(329)]
        [DefaultValue(2f)]
        public float SwimRotSpeedZStop { get; set; } = 2f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(330)]
        [DefaultValue(0.5f)]
        public float SwimRotXIne { get; set; } = 0.5f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(331)]
        [DefaultValue(0.6f)]
        public float SwimRotZIne { get; set; } = 0.6f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(332)]
        [DefaultValue(0.5f)]
        public float SwimRotXIneT { get; set; } = 0.5f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(333)]
        [DefaultValue(0.6f)]
        public float SwimRotZIneT { get; set; } = 0.6f;


        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(334)]
        [DefaultValue(0.1f)]
        public float SwimUpAcc { get; set; } = 0.1f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(335)]
        [DefaultValue(1f)]
        public float SwimUpMaxSpeed { get; set; } = 1f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(335)]
        [DefaultValue(0.06f)]
        public float UNKNOWN8 { get; set; } = 0.06f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(335)]
        [DefaultValue(0.6f)]
        public float UNKNOWN9 { get; set; } = 0.6f;


        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(336)]
        [DefaultValue(0.04f)]
        public float WeightBlendRatioSwim { get; set; } = 0.04f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(337)]
        [DefaultValue(0.2f)]
        public float WeightBlendRatioSwimB { get; set; } = 0.2f;


        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(338)]
        [DefaultValue(0.1f)]
        public float SwimFreeXback { get; set; } = 0.1f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(339)]
        [DefaultValue(0.04f)]
        public float SwimFreeXback2 { get; set; } = 0.04f;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(340)]
        [DefaultValue(1f)]
        public float SwimSpdYratio { get; set; } = 1f;


        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(341)]
        [DefaultValue(1f)]
        public float SwimRotSpeedRatioSurface { get; set; } = 1f;


        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(342)]
        [DefaultValue((ushort)12)]
        public ushort JumpSinkTimer { get; set; } = 12;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(343)]
        [DefaultValue((ushort)40)]
        public ushort JumpDamageSinkTimer { get; set; } = 40;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(344)]
        [DefaultValue(10f)]
        public float SwimToWalkSpd { get; set; } = 10f;


        [OrderedCategory(SwimCategoryName, 33)]
        [DisplayName("Underwater Health Decrease Rate")]
        [Description("The rate that your health gets depleted after your oxygen runs out underwater")]
        [Order(345)]
        [DefaultValue((ushort)180)]
        public ushort WaterDecInterval { get; set; } = 180;

        [OrderedCategory(SwimCategoryName, 33)]

        [Description("Unknown")]
        [Order(346)]
        [DefaultValue((ushort)0)]
        public ushort WaterDecSpinAcc { get; set; } = 0;

        [OrderedCategory(SwimCategoryName, 33)]
        [DisplayName("Underwater Max Oxygen")]
        [Description("Unknown")]
        [Order(347)]
        [DefaultValue((ushort)3600)]
        public ushort OxygenMax { get; set; } = 3600;



        [OrderedCategory(TurtleCategoryName, 34)]

        [DisplayName("Green Shell Up/Down rotation sharpness")]
        [Description("Unknown")]
        [Order(348)]
        [DefaultValue(0.4f)]
        public float SwimXJetRotRatio { get; set; } = 0.4f;

        [OrderedCategory(TurtleCategoryName, 34)]

        [DisplayName("Red Shell Up/Down rotation sharpness")]
        [Description("Unknown")]
        [Order(349)]
        [DefaultValue(0.35f)]
        public float SwimXJetRotRatioRed { get; set; } = 0.35f;

        [OrderedCategory(TurtleCategoryName, 34)]

        [Description("Unknown")]
        [Order(350)]
        [DefaultValue(0.5f)]
        public float TurboReductionStream { get; set; } = 0.5f;

        [OrderedCategory(TurtleCategoryName, 34)]

        [DisplayName("Wall recoil speed")]
        [Description("Swam into a wall holding a koopa shell? This value controls the rebound.")]
        [Order(351)]
        [DefaultValue(0.1f)]
        public float TurboReductionHitWall { get; set; } = 0.1f;

        [OrderedCategory(TurtleCategoryName, 34)]

        [DisplayName("Floor recoil speed")]
        [Description("Swam into a floor holding a koopa shell? This value controls the rebound.")]
        [Order(352)]
        [DefaultValue(0.995f)]
        public float TurboReductionHitFloor { get; set; } = 0.995f;

        [OrderedCategory(TurtleCategoryName, 34)]

        [Description("Unknown")]
        [Order(353)]
        [DefaultValue((ushort)180)]
        public ushort SwimJetPeriod1 { get; set; } = 180;

        [OrderedCategory(TurtleCategoryName, 34)]

        [Description("Unknown")]
        [Order(354)]
        [DefaultValue((ushort)600)]
        public ushort SwimJetPeriod2 { get; set; } = 600;

        [OrderedCategory(TurtleCategoryName, 34)]

        [Description("Unknown")]
        [Order(355)]
        [DefaultValue(2f)]
        public float SwimJetPeriod1Ratio { get; set; } = 2f;

        [OrderedCategory(TurtleCategoryName, 34)]

        [Description("Unknown")]
        [Order(356)]
        [DefaultValue(0.5f)]
        public float SwimJetPeriod3Ratio { get; set; } = 0.5f;



        [OrderedCategory(SwimSinkCategoryName, 35)]

        [Description("Unknown")]
        [Order(357)]
        [DefaultValue(3.1f)]
        public float ZsinkAngleX { get; set; } = 3.1f;

        [OrderedCategory(SwimSinkCategoryName, 35)]

        [Description("Unknown")]
        [Order(358)]
        [DefaultValue((ushort)15)]
        public ushort ZsinkMoveTimer { get; set; } = 15;

        [OrderedCategory(SwimSinkCategoryName, 35)]

        [Description("Unknown")]
        [Order(359)]
        [DefaultValue((ushort)50)]
        public ushort ZsinkSinkTimer { get; set; } = 50;

        [OrderedCategory(SwimSinkCategoryName, 35)]

        [Description("Unknown")]
        [Order(360)]
        [DefaultValue((ushort)35)]
        public ushort ZsinkStartTimer { get; set; } = 35;

        [OrderedCategory(SwimSinkCategoryName, 35)]

        [Description("Unknown")]
        [Order(361)]
        [DefaultValue(3f)]
        public float ZsinkFrontSpeed { get; set; } = 3f;



        [OrderedCategory(SwimSpecialCategoryName, 36)]

        [Description("Unknown")]
        [Order(362)]
        [DefaultValue((ushort)30)]
        public ushort SwimSpecStartTimerADive { get; set; } = 30;

        [OrderedCategory(SwimSpecialCategoryName, 36)]

        [Description("Unknown")]
        [Order(363)]
        [DefaultValue((ushort)25)]
        public ushort SwimSpecStartTimerAJet { get; set; } = 25;

        [OrderedCategory(SwimSpecialCategoryName, 36)]

        [Description("Unknown")]
        [Order(364)]
        [DefaultValue((ushort)20)]
        public ushort SwimSpecStartTimerASpin { get; set; } = 20;

        [OrderedCategory(SwimSpecialCategoryName, 36)]

        [Description("Unknown")]
        [Order(365)]
        [DefaultValue((ushort)40)]
        public ushort SwimSpecStartTimerBDive { get; set; } = 40;

        [OrderedCategory(SwimSpecialCategoryName, 36)]

        [Description("Unknown")]
        [Order(366)]
        [DefaultValue((ushort)30)]
        public ushort SwimSpecStartTimerBJet { get; set; } = 30;

        [OrderedCategory(SwimSpecialCategoryName, 36)]

        [Description("Unknown")]
        [Order(367)]
        [DefaultValue((ushort)25)]
        public ushort SwimSpecStartTimerBSpin { get; set; } = 25;



        [OrderedCategory(SwimSpinCategoryName, 37)]

        [Description("Unknown")]
        [Order(368)]
        [DefaultValue((ushort)5)]
        public ushort SwimSpinReadyTime { get; set; } = 5;


        [OrderedCategory(SwimSpinCategoryName, 37)]

        [Description("Unknown")]
        [Order(369)]
        [DefaultValue((ushort)33)]
        public ushort SwimSpinTime { get; set; } = 33;

        [OrderedCategory(SwimSpinCategoryName, 37)]

        [Description("Unknown")]
        [Order(370)]
        [DefaultValue((ushort)30)]
        public ushort SwimDashTime { get; set; } = 30;

        [OrderedCategory(SwimSpinCategoryName, 37)]

        [Description("Unknown")]
        [Order(371)]
        [DefaultValue((ushort)24)]
        public ushort SwimSpinFrontTime { get; set; } = 24;

        [OrderedCategory(SwimSpinCategoryName, 37)]

        [Description("Unknown")]
        [Order(372)]
        [DefaultValue((ushort)50)]
        public ushort SwimSpinYspeedTime { get; set; } = 50;


        [OrderedCategory(SwimSpinCategoryName, 37)]

        [Description("Unknown")]
        [Order(373)]
        [DefaultValue((ushort)30)]
        public ushort SwimSpinDownStep { get; set; } = 30;

        [OrderedCategory(SwimSpinCategoryName, 37)]

        [Description("Unknown")]
        [Order(374)]
        [DefaultValue(0f)]
        public float SwimSpinSpeed { get; set; } = 0f;

        [OrderedCategory(SwimSpinCategoryName, 37)]

        [Description("Unknown")]
        [Order(375)]
        [DefaultValue(0.95f)]
        public float SwimSpinAcc1 { get; set; } = 0.95f;

        [OrderedCategory(SwimSpinCategoryName, 37)]

        [Description("Unknown")]
        [Order(375)]
        [DefaultValue(0.96f)]
        public float SwimSpinAcc2 { get; set; } = 0.96f;

        [OrderedCategory(SwimSpinCategoryName, 37)]

        [Description("Unknown")]
        [Order(376)]
        [DefaultValue((ushort)30)]
        public ushort SwimSpinMissOfsTime { get; set; } = 30;

        [OrderedCategory(SwimSpinCategoryName, 37)]

        [Description("Unknown")]
        [Order(376)]
        [DefaultValue((ushort)60)]
        public ushort UNKNOWN10 { get; set; } = 60;

        [OrderedCategory(SwimSpinCategoryName, 37)]

        [DisplayName("Underwater Spin Speed")]
        [Description("Unknown")]
        [Order(377)]
        [DefaultValue(0.7f)]
        public float SwimSpinAccRatio { get; set; } = 0.7f;

        [OrderedCategory(SwimSpinCategoryName, 37)]

        [Description("Unknown")]
        [Order(378)]
        [DefaultValue(0.7f)]
        public float SwimSpinSurfaceAccRatio { get; set; } = 0.7f;


        [OrderedCategory(SwimSpinCategoryName, 37)]

        [Description("Unknown")]
        [Order(379)]
        [DefaultValue(0.1f)]
        public float SwimSpinAccRatioR { get; set; } = 0.1f;

        [OrderedCategory(SwimSpinCategoryName, 37)]

        [Description("Unknown")]
        [Order(380)]
        [DefaultValue(0.1f)]
        public float SwimSpinSurfaceAccRatioR { get; set; } = 0.1f;

        [OrderedCategory(SwimSpinCategoryName, 37)]

        [Description("Unknown")]
        [Order(380)]
        [DefaultValue(1f)]
        public float UNKNOWN11 { get; set; } = 1f;

        [OrderedCategory(SwimSpinCategoryName, 37)]

        [Description("Unknown")]
        [Order(380)]
        [DefaultValue(1f)]
        public float UNKNOWN12 { get; set; } = 1f;



        [OrderedCategory(SwimRingDashCategoryName, 38)]

        [Description("Unknown")]
        [Order(381)]
        [DefaultValue((ushort)15)]
        public ushort SwimRingDashChargeTime { get; set; } = 15;

        [OrderedCategory(SwimRingDashCategoryName, 38)]

        [Description("Unknown")]
        [Order(382)]
        [DefaultValue((ushort)300)]
        public ushort SwimRingDashTime { get; set; } = 300;

        [OrderedCategory(SwimRingDashCategoryName, 38)]

        [Description("Unknown")]
        [Order(383)]
        [DefaultValue((ushort)120)]
        public ushort SwimRingDashFinishTime { get; set; } = 120;

        [OrderedCategory(SwimRingDashCategoryName, 38)]

        [Description("Unknown")]
        [Order(384)]
        [DefaultValue(2.5f)]
        public float SwimRingDashSpeedRatio { get; set; } = 2.5f;



        [OrderedCategory(SwimMovementCategoryName, 39)]

        [Description("Unknown")]
        [Order(385)]
        [DefaultValue(1.8f)]
        public float SwimSurfaceSpeed { get; set; } = 1.8f;

        [OrderedCategory(SwimMovementCategoryName, 39)]

        [Description("Unknown")]
        [Order(386)]
        [DefaultValue(1.6f)]
        public float SwimWaterSpeed { get; set; } = 1.6f;

        [OrderedCategory(SwimMovementCategoryName, 39)]

        [Description("Unknown")]
        [Order(387)]
        [DefaultValue(1f)]
        public float SwimDriftSpeed { get; set; } = 1f;

        [OrderedCategory(SwimMovementCategoryName, 39)]

        [Description("Unknown")]
        [Order(388)]
        [DefaultValue((ushort)35)]
        public ushort SwimConnectIn { get; set; } = 35;

        [OrderedCategory(SwimMovementCategoryName, 39)]

        [Description("Unknown")]
        [Order(389)]
        [DefaultValue((ushort)60)]
        public ushort SwimConnectOut { get; set; } = 60;

        [OrderedCategory(SwimMovementCategoryName, 39)]

        [Description("Unknown")]
        [Order(390)]
        [DefaultValue(5f)]
        public float SwimTiltZup { get; set; } = 5f;

        [OrderedCategory(SwimMovementCategoryName, 39)]

        [Description("Unknown")]
        [Order(391)]
        [DefaultValue(10f)]
        public float SwimTiltZdown { get; set; } = 10f;

        [OrderedCategory(SwimMovementCategoryName, 39)]

        [Description("Unknown")]
        [Order(392)]
        [DefaultValue(1.5f)]
        public float SwimTiltReal { get; set; } = 1.5f;

        [OrderedCategory(SwimMovementCategoryName, 39)]

        [Description("Unknown")]
        [Order(393)]
        [DefaultValue(0.95f)]
        public float SwimTiltSpd { get; set; } = 0.95f;



        [OrderedCategory(SwimBuoyancyDashCategoryName, 40)]

        [Description("Unknown")]
        [Order(394)]
        [DefaultValue(100f)]
        public float SwimUpSurfaceDist { get; set; } = 100f;

        [OrderedCategory(SwimBuoyancyDashCategoryName, 40)]

        [Description("Unknown")]
        [Order(395)]
        [DefaultValue(500f)]
        public float SwimUpStrongDist { get; set; } = 500f;

        [OrderedCategory(SwimBuoyancyDashCategoryName, 40)]

        [Description("Unknown")]
        [Order(396)]
        [DefaultValue(1.5f)]
        public float SwimUpStrongRatio { get; set; } = 1.5f;

        [OrderedCategory(SwimBuoyancyDashCategoryName, 40)]

        [Description("Unknown")]
        [Order(397)]
        [DefaultValue(600f)]
        public float SwimUpWeakDist { get; set; } = 600f;

        [OrderedCategory(SwimBuoyancyDashCategoryName, 40)]

        [Description("Unknown")]
        [Order(398)]
        [DefaultValue(300f)]
        public float SwimUpBottomDist { get; set; } = 300f;

        [OrderedCategory(SwimBuoyancyDashCategoryName, 40)]

        [Description("Unknown")]
        [Order(399)]
        [DefaultValue(0.1f)]
        public float SwimUpWeakRatio { get; set; } = 0.1f;

        [OrderedCategory(SwimBuoyancyDashCategoryName, 40)]

        [Description("Unknown")]
        [Order(400)]
        [DefaultValue(8f)]
        public float SwimReverseSinkRatio { get; set; } = 8f;



        [OrderedCategory(SliderCategoryName, 41)]

        [Description("Unknown")]
        [Order(401)]
        [DefaultValue(0.9f)]
        public float SliderBrakeIne { get; set; } = 0.9f;

        [OrderedCategory(SliderCategoryName, 41)]

        [Description("Unknown")]
        [Order(402)]
        [DefaultValue(0.9f)]
        public float SliderWeightIne { get; set; } = 0.9f;

        [OrderedCategory(SliderCategoryName, 41)]

        [Description("Unknown")]
        [Order(403)]
        [DefaultValue(0.5f)]
        public float SliderSlopePow { get; set; } = 0.5f;

        [OrderedCategory(SliderCategoryName, 41)]

        [Description("Unknown")]
        [Order(404)]
        [DefaultValue(0.9f)]
        public float SliderWeightPow { get; set; } = 0.9f;

        [OrderedCategory(SliderCategoryName, 41)]

        [Description("Unknown")]
        [Order(405)]
        [DefaultValue(32f)]
        public float SliderMaxSpeed { get; set; } = 32f;

        [OrderedCategory(SliderCategoryName, 41)]

        [Description("Unknown")]
        [Order(406)]
        [DefaultValue(0.1f)]
        public float SliderBrakePow { get; set; } = 0.1f;

        [OrderedCategory(SliderCategoryName, 41)]

        [Description("Unknown")]
        [Order(407)]
        [DefaultValue(0.08f)]
        public float SliderFrontTurnRatio { get; set; } = 0.08f;

        [OrderedCategory(SliderCategoryName, 41)]

        [Description("Unknown")]
        [Order(408)]
        [DefaultValue(0.08f)]
        public float SliderHeadRotateRatio { get; set; } = 0.08f;

        [OrderedCategory(SliderCategoryName, 41)]

        [Description("Unknown")]
        [Order(409)]
        [DefaultValue(0.3f)]
        public float SliderTiltRatio { get; set; } = 0.3f;



        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(410)]
        [DefaultValue(0f)]
        public float BeeFlyRandomFactor { get; set; } = 0f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(411)]
        [DefaultValue(5f)]
        public float BeeFlyConstantFactor { get; set; } = 5f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(412)]
        [DefaultValue(0.1f)]
        public float BeeAirWalkAcc { get; set; } = 0.1f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(413)]
        [DefaultValue(8f)]
        public float BeeAirWalkLimit { get; set; } = 8f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(414)]
        [DefaultValue(0.05f)]
        public float BeeAirWalkTurnSpd { get; set; } = 0.05f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(415)]
        [DefaultValue(0.02f)]
        public float BeeSpeedRotateRatio { get; set; } = 0.02f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(416)]
        [DefaultValue(0.1f)]
        public float BeeFreeDropAcc { get; set; } = 0.1f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(417)]
        [DefaultValue(5f)]
        public float BeeFreeDropMaxSpd { get; set; } = 5f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(418)]
        [DefaultValue(0.9f)]
        public float BeePushRiseGravityEraser { get; set; } = 0.9f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(419)]
        [DefaultValue(20f)]
        public float BeeStickJumpPower { get; set; } = 20f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(420)]
        [DefaultValue(0f)]
        public float BeeStickJumpBonus { get; set; } = 0f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(421)]
        [DefaultValue(0.3f)]
        public float BeeStickAngleLimit { get; set; } = 0.3f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(422)]
        [DefaultValue(5.0f)]
        public float BeeUpSpeedMax { get; set; } = 5f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(423)]
        [DefaultValue(1.0f)]
        public float BeeUpAccelRatio { get; set; } = 1f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(424)]
        [DefaultValue(0.02f)]
        public float BeeAccelRatio { get; set; } = 0.02f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(425)]
        [DefaultValue(0.3f)]
        public float BeeUpDownKiller { get; set; } = 0.3f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(426)]
        [DefaultValue((ushort)120)]
        public ushort BeeGravityReviveTime { get; set; } = 120;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(427)]
        [DefaultValue((ushort)60)]
        public ushort BeeGravityPowerTime { get; set; } = 60;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(428)]
        [DefaultValue((ushort)30)]
        public ushort BeeAirWalkInhibitTime { get; set; } = 30;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(429)]
        [DefaultValue((ushort)120)]
        public ushort BeeGravityPowerTimeV { get; set; } = 120;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(430)]
        [DefaultValue((ushort)25)]
        public ushort BeeAirWalkInhibitTimeV { get; set; } = 25;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(431)]
        [DefaultValue((ushort)60)]
        public ushort BeeGravityPowerTimeD { get; set; } = 60;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(432)]
        [DefaultValue((ushort)35)]
        public ushort BeeAirWalkInhibitTimeD { get; set; } = 35;


        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(433)]
        [DefaultValue(1000f)]
        public float BeeWallWalkCancelRadius { get; set; } = 1000f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(434)]
        [DefaultValue(300f)]
        public float BeeWallWalkCancelRadiusShort { get; set; } = 300f;



        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(435)]
        [DefaultValue(0.5f)]
        public float BeePoseDelayAngleAir { get; set; } = 0.5f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(436)]
        [DefaultValue(0.13f)]
        public float BeePoseDelayAngleGround { get; set; } = 0.13f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(437)]
        [DefaultValue(1f)]
        public float BeePoseDelayAccel { get; set; } = 1f;


        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(438)]
        [DefaultValue(0.5f)]
        public float BeePoseLimitAngleAir { get; set; } = 0.5f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(439)]
        [DefaultValue(0.15f)]
        public float BeePoseLimitAngleGround { get; set; } = 0.15f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(440)]
        [DefaultValue(120f)]
        public float BeePoseHeadToFootLength { get; set; } = 120f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(441)]
        [DefaultValue(20f)]
        public float BeePoseDelaySpeedLimit { get; set; } = 20f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(442)]
        [DefaultValue(0.98f)]
        public float BeePoseFrictionStop { get; set; } = 0.98f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(443)]
        [DefaultValue(0.8f)]
        public float BeePoseTransBlendingRatioStop { get; set; } = 0.8f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(444)]
        [DefaultValue(0.95f)]
        public float BeePoseFrictionMove { get; set; } = 0.95f;

        [OrderedCategory(BeeCategoryName, 42)]

        [Description("Unknown")]
        [Order(445)]
        [DefaultValue(0.9f)]
        public float BeePoseTransBlendingRatioMove { get; set; } = 0.9f;



        [OrderedCategory(HopperCategoryName, 43)]

        [Description("Unknown")]
        [Order(446)]
        [DefaultValue(0.08f)]
        public float RabbitTurnRatio { get; set; } = 0.08f;

        [OrderedCategory(HopperCategoryName, 43)]

        [Description("Unknown")]
        [Order(447)]
        [DefaultValue(0.2f)]
        public float RabbitTurnRatio2 { get; set; } = 0.2f;

        [OrderedCategory(HopperCategoryName, 43)]

        [Description("Unknown")]
        [Order(448)]
        [DefaultValue(1f)]
        public float RabbitGravityRise { get; set; } = 1f;

        [OrderedCategory(HopperCategoryName, 43)]

        [Description("Unknown")]
        [Order(449)]
        [DefaultValue(0.75f)]
        public float RabbitGravityDrop { get; set; } = 0.75f;

        [OrderedCategory(HopperCategoryName, 43)]

        [Description("Unknown")]
        [Order(450)]
        [DefaultValue(22f)]
        public float RabbitFirstJump { get; set; } = 22f;

        [OrderedCategory(HopperCategoryName, 43)]

        [Description("Unknown")]
        [Order(451)]
        [DefaultValue(10f)]
        public float RabbitMoveSpeed { get; set; } = 10f;

        [OrderedCategory(HopperCategoryName, 43)]

        [Description("Unknown")]
        [Order(452)]
        [DefaultValue(0.5f)]
        public float RabbitMoveAcc { get; set; } = 0.5f;

        [OrderedCategory(HopperCategoryName, 43)]

        [Description("Unknown")]
        [Order(453)]
        [DefaultValue(0.075f)]
        public float RabbitMoveAcc2 { get; set; } = 0.075f;

        [OrderedCategory(HopperCategoryName, 43)]

        [Description("Unknown")]
        [Order(454)]
        [DefaultValue(0.25f)]
        public float RabbitMoveAcc3 { get; set; } = 0.25f;


        [OrderedCategory(HopperCategoryName, 43)]

        [Description("Unknown")]
        [Order(455)]
        [DefaultValue(60f)]
        public float RabbitFirstJump2 { get; set; } = 60f;

        [OrderedCategory(HopperCategoryName, 43)]

        [Description("Unknown")]
        [Order(456)]
        [DefaultValue(1.2f)]
        public float RabbitGravityRise2 { get; set; } = 1.2f;

        [OrderedCategory(HopperCategoryName, 43)]

        [Description("Unknown")]
        [Order(457)]
        [DefaultValue(1.0f)]
        public float RabbitGravityDrop2 { get; set; } = 1.0f;

        [OrderedCategory(HopperCategoryName, 43)]

        [Description("Unknown")]
        [Order(458)]
        [DefaultValue((ushort)23)]
        public ushort RabbitChargeTime2 { get; set; } = 23;

        [OrderedCategory(HopperCategoryName, 43)]

        [Description("Unknown")]
        [Order(459)]
        [DefaultValue((ushort)10)]
        public ushort HopperLandingTime { get; set; } = 10;



        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(460)]
        [DefaultValue(10.0f)]
        public float TeresaHorizontalSpeedMax { get; set; } = 10.0f;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(461)]
        [DefaultValue(8.0f)]
        public float TeresaAlphaLevelMax { get; set; } = 8.0f;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(462)]
        [DefaultValue(0.5f)]
        public float TeresaAlphaLevelInc { get; set; } = 0.5f;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(463)]
        [DefaultValue(0.2f)]
        public float TeresaAlphaLevelDec { get; set; } = 0.2f;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(464)]
        [DefaultValue((ushort)90)]
        public ushort TeresaWallThroughTime { get; set; } = 90;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(465)]
        [DefaultValue(0.5f)]
        public float TeresaAngleUp { get; set; } = 0.5f;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(466)]
        [DefaultValue(0.7f)]
        public float TeresaAngleDown { get; set; } = 0.7f;


        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(467)]
        [DefaultValue(0f)]
        public float TeresaWallReflectPower { get; set; } = 0f;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(468)]
        [DefaultValue(0.98f)]
        public float TeresaWallReflectReduction { get; set; } = 0.98f;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(469)]
        [DefaultValue((ushort)10)]
        public ushort TeresaWallReflectTime { get; set; } = 10;


        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(470)]
        [DefaultValue(50f)]
        public float TeresaWaitHeight { get; set; } = 50f;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(471)]
        [DefaultValue(50f)]
        public float TeresaDropDownHeight { get; set; } = 50f;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(472)]
        [DefaultValue(90f)]
        public float TeresaBodyRadius { get; set; } = 90f;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(473)]
        [DefaultValue(0.08f)]
        public float TeresaAirWalkTurnSpd { get; set; } = 0.08f;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(474)]
        [DefaultValue(0.8f)]
        public float TeresaDropSpeedMax { get; set; } = 0.8f;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(475)]
        [DefaultValue(0.8f)]
        public float TeresaRiseSpeedMax { get; set; } = 0.8f;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(476)]
        [DefaultValue(8f)]
        public float TeresaDropBase { get; set; } = 8f;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(477)]
        [DefaultValue(0.96f)]
        public float TeresaUpInertia { get; set; } = 0.96f;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(478)]
        [DefaultValue((ushort)2)]
        public ushort TeresaAccelTime { get; set; } = 2;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(479)]
        [DefaultValue((ushort)8)]
        public ushort TeresaTrgOnPushTime1 { get; set; } = 8;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(480)]
        [DefaultValue((ushort)2)]
        public ushort TeresaTrgOnPushTime2 { get; set; } = 2;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(481)]
        [DefaultValue(0.02f)]
        public float TeresaOnePushAccel1 { get; set; } = 0.02f;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(482)]
        [DefaultValue(0.005f)]
        public float TeresaOnePushAccel2 { get; set; } = 0.005f;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(483)]
        [DefaultValue(0.99f)]
        public float TeresaNoPushDownRatio { get; set; } = 0.99f;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(484)]
        [DefaultValue(0.2f)]
        public float TeresaRisingBrake { get; set; } = 0.2f;


        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(485)]
        [DefaultValue(0.9f)]
        public float TeresaWindMovingBrake1 { get; set; } = 0.9f;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(486)]
        [DefaultValue(0.8f)]
        public float TeresaWindMovingBrake2 { get; set; } = 0.8f;

        [OrderedCategory(TeresaCategoryName, 44)]

        [Description("Unknown")]
        [Order(487)]
        [DefaultValue(0.999f)]
        public float TeresaWindMovingBrake3 { get; set; } = 0.999f;



        [OrderedCategory(DrawCategoryName, 45)]

        [Description("Unknown")]
        [Order(488)]
        [DefaultValue(0f)]
        public float SilhouetteZoffset { get; set; } = 0f;

        [OrderedCategory(DrawCategoryName, 45)]

        [Description("Unknown")]
        [Order(489)]
        [DefaultValue(typeof(Color), "192, 255, 255, 0")]
        public Color RibbonColor { get; set; } = Color.FromArgb(192, 255, 255, 0);

        [OrderedCategory(DrawCategoryName, 45)]

        [Description("Unknown")]
        [Order(490)]
        [DefaultValue((byte)40)]
        public byte DamageFogLow { get; set; } = 40;

        [OrderedCategory(DrawCategoryName, 45)]

        [Description("Unknown")]
        [Order(491)]
        [DefaultValue((byte)192)]
        public byte DamageFogHigh { get; set; } = 192;

        [OrderedCategory(DrawCategoryName, 45)]

        [Description("Unknown")]
        [Order(492)]
        [DefaultValue(0.6f)]
        public float StarPieceFogLevel { get; set; } = 0.6f;

        [OrderedCategory(DrawCategoryName, 45)]

        [Description("Unknown")]
        [Order(493)]
        [DefaultValue((byte)25)]
        public byte StarPieceFogTime { get; set; } = 25;


        [OrderedCategory(DrawCategoryName, 45)]

        [Description("Unknown")]
        [Order(494)]
        [DefaultValue((byte)85)]
        public byte SearchLightAlphaLevel { get; set; } = 85;

        [OrderedCategory(DrawCategoryName, 45)]

        [Description("Unknown")]
        [Order(495)]
        [DefaultValue((byte)40)]
        public byte SearchLightBlurAlphaSmall { get; set; } = 40;

        [OrderedCategory(DrawCategoryName, 45)]

        [Description("Unknown")]
        [Order(496)]
        [DefaultValue((byte)20)]
        public byte SearchLightBlurAlphaMedium { get; set; } = 20;

        [OrderedCategory(DrawCategoryName, 45)]

        [Description("Unknown")]
        [Order(497)]
        [DefaultValue((byte)10)]
        public byte SearchLightBlurAlphaLarge { get; set; } = 10;

        [OrderedCategory(DrawCategoryName, 45)]

        [Description("Unknown")]
        [Order(498)]
        [DefaultValue(2f)]
        public float SearchLightBlurScaleSmall { get; set; } = 2f;

        [OrderedCategory(DrawCategoryName, 45)]

        [Description("Unknown")]
        [Order(499)]
        [DefaultValue(3f)]
        public float SearchLightBlurScaleMedium { get; set; } = 3f;

        [OrderedCategory(DrawCategoryName, 45)]

        [Description("Unknown")]
        [Order(500)]
        [DefaultValue(4f)]
        public float SearchLightBlurScaleLarge { get; set; } = 4f;

        [OrderedCategory(DrawCategoryName, 45)]

        [Description("Unknown")]
        [Order(501)]
        [DefaultValue(typeof(Color), "210, 80, 80, 80")]
        public Color SearchLightColor { get; set; } = Color.FromArgb(210, 80, 80, 80);


        [OrderedCategory(DrawCategoryName, 45)]

        [Description("Unknown")]
        [Order(502)]
        [DefaultValue(0f)]
        public float RasterV { get; set; } = 0f;

        [OrderedCategory(DrawCategoryName, 45)]

        [Description("Unknown")]
        [Order(503)]
        [DefaultValue(0)]
        public int RasterSpeed { get; set; } = 0;

        [OrderedCategory(DrawCategoryName, 45)]

        [Description("Unknown")]
        [Order(504)]
        [DefaultValue(0f)]
        public float RasterRange { get; set; } = 0f;



        [OrderedCategory(RushCategoryName, 46)]

        [Description("Unknown")]
        [Order(505)]
        [DefaultValue((ushort)1200)]
        public ushort RacketHoldTime { get; set; } = 1200;

        [OrderedCategory(RushCategoryName, 46)]

        [Description("Unknown")]
        [Order(506)]
        [DefaultValue((ushort)1200)]
        public ushort TornadoHoldTime { get; set; } = 1200;

        [OrderedCategory(RushCategoryName, 46)]
        [DisplayName("Rainbow Star Timer")]
        [Description("How long the Rainbow Star powerup lasts (60 = 1 second)")]
        [Order(507)]
        [DefaultValue((ushort)1200)]
        public ushort MetalHoldTime { get; set; } = 1200;

        [OrderedCategory(RushCategoryName, 46)]
        [DisplayName("Fire Flower Timer")]
        [Description("How long the Fire Flower powerup lasts (60 = 1 second)")]
        [Order(508)]
        [DefaultValue((ushort)1200)]
        public ushort FireModeTime { get; set; } = 1200;

        [OrderedCategory(RushCategoryName, 46)]
        [DisplayName("Ice Flower Timer")]
        [Description("How long the Ice Flower powerup lasts (60 = 1 second)")]
        [Order(509)]
        [DefaultValue((ushort)1200)]
        public ushort IceModeTime { get; set; } = 1200;

        [OrderedCategory(RushCategoryName, 46)]

        [Description("Unknown")]
        [Order(509)]
        [DefaultValue(1)]
        public int UNKNOWN13 { get; set; } = 1;



        [OrderedCategory(TweaksCategoryName, 47)]

        [Description("Unknown")]
        [Order(510)]
        [DefaultValue(0.01f)]
        public float HeadAngleFixMargin { get; set; } = 0.01f;

        [OrderedCategory(TweaksCategoryName, 47)]

        [Description("Unknown")]
        [Order(511)]
        [DefaultValue(0.01f)]
        public float FrontAngleFixMargin { get; set; } = 0.01f;

        [OrderedCategory(TweaksCategoryName, 47)]

        [Description("Unknown")]
        [Order(512)]
        [DefaultValue((ushort)16)]
        public ushort CameraHeadRotationTimer { get; set; } = 16;

        [OrderedCategory(TweaksCategoryName, 47)]

        [Description("Unknown")]
        [Order(513)]
        [DefaultValue(0.1f)]
        public float HeadRotateRatio { get; set; } = 0.1f;

        [OrderedCategory(TweaksCategoryName, 47)]

        [Description("Unknown")]
        [Order(514)]
        [DefaultValue(0.1f)]
        public float VibrationAbsorbAngleF { get; set; } = 0.1f;

        [OrderedCategory(TweaksCategoryName, 47)]

        [Description("Unknown")]
        [Order(515)]
        [DefaultValue(0.01f)]
        public float VibrationAbsorbAngleH { get; set; } = 0.01f;

        [OrderedCategory(TweaksCategoryName, 47)]

        [Description("Unknown")]
        [Order(516)]
        [DefaultValue(0.2f)]
        public float VibrationAbsorbAngleS { get; set; } = 0.2f;

        [OrderedCategory(TweaksCategoryName, 47)]

        [Description("Unknown")]
        [Order(517)]
        [DefaultValue(0.15f)]
        public float SlopeAnimBlendRatio { get; set; } = 0.15f;


        [OrderedCategory(TweaksCategoryName, 47)]

        [Description("Unknown")]
        [Order(518)]
        [DefaultValue(0.5f)]
        public float RotateHeadVecSpeedByGravityL { get; set; } = 0.5f;

        [OrderedCategory(TweaksCategoryName, 47)]

        [Description("Unknown")]
        [Order(519)]
        [DefaultValue(0.1f)]
        public float RotateHeadVecSpeedByGravityM { get; set; } = 0.1f;

        [OrderedCategory(TweaksCategoryName, 47)]

        [Description("Unknown")]
        [Order(520)]
        [DefaultValue(0.01f)]
        public float RotateHeadVecSpeedByGravityS { get; set; } = 0.01f;


        [OrderedCategory(TweaksCategoryName, 47)]

        [Description("Unknown")]
        [Order(521)]
        [DefaultValue(0.7f)]
        public float LookMaxAngleH { get; set; } = 0.7f;

        [OrderedCategory(TweaksCategoryName, 47)]

        [Description("Unknown")]
        [Order(522)]
        [DefaultValue(0.5f)]
        public float LookMaxAngleVP { get; set; } = 0.5f;

        [OrderedCategory(TweaksCategoryName, 47)]

        [Description("Unknown")]
        [Order(523)]
        [DefaultValue(0.1f)]
        public float LookMaxAngleVM { get; set; } = 0.1f;

        [OrderedCategory(TweaksCategoryName, 47)]

        [Description("Unknown")]
        [Order(524)]
        [DefaultValue(8f)]
        public float LookShoulderMoveMax { get; set; } = 8f;


        [OrderedCategory(TweaksCategoryName, 47)]

        [Description("Unknown")]
        [Order(525)]
        [DefaultValue((ushort)4)]
        public ushort RushInBlendTimer { get; set; } = 4;


        public void Read(Stream FS)
        {
            JumpHeight1st = FS.ReadSingle();
            JumpHeight2nd = FS.ReadSingle();
            JumpHeight3rd = FS.ReadSingle();
            JumpHeightMiss = FS.ReadSingle();
            JumpHeightTurn = FS.ReadSingle();
            JumpHeightSquat = FS.ReadSingle();
            JumpHeightBack = FS.ReadSingle();
            JumpHeightWall = FS.ReadSingle();
            JumpHeightTornado_and_Force = FS.ReadSingle();

            GravityJumping1st = FS.ReadSingle();
            GravityJumping2nd = FS.ReadSingle();
            GravityJumping3rd = FS.ReadSingle();
            GravityJumpingMiss = FS.ReadSingle();
            GravityJumpingTurn = FS.ReadSingle();
            GravityJumpingSquat = FS.ReadSingle();
            GravityJumpingBack = FS.ReadSingle();
            GravityJumpingWall = FS.ReadSingle();
            GravityJumpingTornado = FS.ReadSingle();
            GravityJumpingForce = FS.ReadSingle();
            GravityJumpingSlipUp = FS.ReadSingle();
            GravityJumpingHeli = FS.ReadSingle();

            GravityAirWalk = FS.ReadSingle();
            GravityRatioA = FS.ReadSingle();

            JumpFrontSpeed = FS.ReadSingle();
            JumpTornadoSpeed = FS.ReadSingle();
            DropFrontSpeed = FS.ReadSingle();
            JumpConnectTime = FS.ReadShort();
            JumpConnectSpeed = FS.ReadSingle();
            SquatJumpFrontSpeed = FS.ReadSingle();
            SquatJumpBackSpeed = FS.ReadSingle();
            TurnJumpFrontSpeed = FS.ReadSingle();

            MaxDropSpeedNormal = FS.ReadSingle();
            MaxDropSpeedSpecial1 = FS.ReadSingle();
            MaxDropSpeedSpecial2 = FS.ReadSingle();
            MaxDropSpeedHelicopter = FS.ReadSingle();
            MaxDropSpeedBee = FS.ReadSingle();

            GrReductionDropTimer = FS.ReadShort();
            DropWaitTime = FS.ReadShort();
            JumpFrontReduction = FS.ReadSingle();
            JumpFrontReductionBeginTime = FS.ReadShort();

            SquatJumpFrontReduction = FS.ReadSingle();
            SquatJumpFrontReductionBTime = FS.ReadShort();
            MudFloorJumpWeakRatio = FS.ReadSingle();


            GravityHipDrop = FS.ReadSingle();
            LimitSpeedHipDrop = FS.ReadSingle();
            HipDropLimitHeight = FS.ReadSingle();
            HipDropZeroGrTime = FS.ReadUShort();
            HipDropLimitTimerAfterTornado = FS.ReadShort();


            SlipUpSpdCtrlTimer = FS.ReadShort();
            SlipUpSpdRatio = FS.ReadSingle();
            SlipUpHeight = FS.ReadSingle();
            SlipUpFront = FS.ReadSingle();
            SlipUpFrontWeak = FS.ReadSingle();
            SlipUpHeightHang = FS.ReadSingle();
            SlipUpFrontHang = FS.ReadSingle();
            SlipUpContinueHeight = FS.ReadSingle();


            AirWalkTime = FS.ReadUShort();
            AirWalkTimerFact1 = FS.ReadSingle();
            AirWalkTimerFact2 = FS.ReadShort();
            AirWalkTimerFact3 = FS.ReadSingle();
            MaxJumpSpeed = FS.ReadSingle();
            AirWalkBackBonus = FS.ReadSingle();
            AirWalkSpeedKiller = FS.ReadSingle();
            MaxBackJumpSpeed = FS.ReadSingle();
            AirWalkBonus = FS.ReadSingle();
            BackJumpLimitFrame = FS.ReadShort();
            BackJumpRatio = FS.ReadSingle();
            WaitNeutralTimer = FS.ReadShort();


            HardLandingHeight = FS.ReadSingle();
            HardLandStunTimer = FS.ReadUShort();


            CodeJumpPowerWeak = FS.ReadSingle();
            CodeJumpPowerMiddle = FS.ReadSingle();
            CodeJumpPowerHigh = FS.ReadSingle();
            CodeJumpPowerNormal = FS.ReadSingle();


            TrampleNormal = FS.ReadSingle();
            TrampleLong = FS.ReadSingle();
            TrampleNormalTaco = FS.ReadSingle();
            TrampleBegoma = FS.ReadSingle();
            TrampleBegomaRotRise = FS.ReadSingle();
            TrampleBegomaRotFall = FS.ReadSingle();
            TrampleBegomaOpenTime = FS.ReadUShort();


            DropUnderPowerMin = FS.ReadSingle();
            DropUnderPowerMax = FS.ReadSingle();


            MsgJumpGroundPowerXZ = FS.ReadSingle();
            MsgJumpGroundPowerY = FS.ReadSingle();
            MsgJumpAirPower = FS.ReadSingle();
            BilliardJumpExtra = FS.ReadSingle();


            FutureJumpReqLimitTime = FS.ReadShort();


            WarpPodJumpX = FS.ReadSingle();
            WarpPodJumpY = FS.ReadSingle();


            JumpHeightDamage = FS.ReadSingle();
            JumpDistDamage = FS.ReadSingle();
            GravityDamage = FS.ReadSingle();


            JumpHeightLargeDamage = FS.ReadSingle();
            JumpDistLargeDamage = FS.ReadSingle();


            SlideDistFaint = FS.ReadSingle();
            FaintTimer1 = FS.ReadShort();
            FaintTimer2 = FS.ReadShort();
            FaintFriction1 = FS.ReadSingle();
            FaintFriction2 = FS.ReadSingle();


            SlideDistFlip = FS.ReadSingle();
            SlideDistFlipSpin = FS.ReadSingle();
            FlipTimer1 = FS.ReadShort();
            FlipTimer2 = FS.ReadShort();
            FlipFriction1 = FS.ReadSingle();
            FlipFriction2= FS.ReadSingle();
            FlipFriction3 = FS.ReadSingle();


            FireRunTimer1 = FS.ReadUShort();
            FireRunTimer2 = FS.ReadUShort();
            FireRunTimer3 = FS.ReadUShort();
            FireRunSpeed = FS.ReadSingle();
            FireRunTurnRatio = FS.ReadSingle();
            FireRunGravity = FS.ReadSingle();
            FireRunFirstJump = FS.ReadSingle();


            FireDanceTurnRatio = FS.ReadSingle();
            FireDanceGravityRise = FS.ReadSingle();
            FireDanceGravityDrop = FS.ReadSingle();
            FireDanceFirstJump = FS.ReadSingle();
            FireDanceSecondJump = FS.ReadSingle();
            FireDanceMoveSpeed = FS.ReadSingle();
            FireDanceMoveAcc = FS.ReadSingle();

            BlackHoleRadiusRatio = FS.ReadSingle();
            BlackHoleScaleSpeed = FS.ReadSingle();
            BlackHoleScaleLimit = FS.ReadSingle();
            BlackHoleRotateSpeed = FS.ReadSingle();
            BlackHoleRotateLimit = FS.ReadSingle();
            BlackHoleFirstRadius = FS.ReadSingle();
            BlackHoleHideTime = FS.ReadUShort();


            WaterInnerFaintTime = FS.ReadUShort();
            SwimFaintSpeed = FS.ReadSingle();
            WaterInnerDamageTime = FS.ReadUShort();
            SwimDamageSpeed = FS.ReadSingle();
            SwimSurfaceDamageSpeed = FS.ReadSingle();
            WaterSurfaceDamageJump = FS.ReadSingle();

            SwimDamageTimerEx1 = FS.ReadUShort();
            SwimDamageSpeedEx1 = FS.ReadSingle();


            JumpHeightFlow = FS.ReadSingle();
            JumpDistFlow = FS.ReadSingle();
            GravityFlow = FS.ReadSingle();


            FlatAngle = FS.ReadSingle();
            SlipAngle = FS.ReadSingle();
            ForceWallAngle = FS.ReadSingle();
            DebugMoveSpeed = FS.ReadSingle();
            WalkSpeed = FS.ReadSingle();
            InertiaStandardStop = FS.ReadSingle();
            InertiaStandardMax = FS.ReadSingle();
            InertiaBdash = FS.ReadSingle();
            InertiaBdashAfter = FS.ReadSingle();
            //TODO: Figure out why this no longer aligns...
            //Must be new fields
            UNKNOWN0 = FS.ReadSingle();
            InertiaStop = FS.ReadSingle();
            InertiaSquat = FS.ReadSingle();
            InertiaTurnSlip = FS.ReadSingle();
            InertiaTurning = FS.ReadSingle();
            InertiaJumpFinish = FS.ReadSingle();
            InertiaReflectSlip = FS.ReadSingle();
            InertiaStartSpin = FS.ReadSingle();
            InertiaOverSpeed = FS.ReadSingle();

            TurnAngleSpeed = FS.ReadSingle();
            TurnAngleSpeed2 = FS.ReadSingle();
            TurnAngleSpeed3 = FS.ReadSingle();
            TurnAngleSpeedSlowWalk = FS.ReadSingle();
            GravityStandard = FS.ReadSingle();
            GravityGrounding = FS.ReadSingle();
            DashMultiply = FS.ReadSingle();
            CameraAngleLimit = FS.ReadSingle();
            StartSpinTime = FS.ReadUShort();
            DashAfterTime = FS.ReadUShort();
            AutoBdashTime = FS.ReadUShort();
            SlowStartTime = FS.ReadUShort();

            StartSpinAnimeRatio = FS.ReadSingle();
            SlopeAnimeRatio = FS.ReadSingle();
            SlopeSpinAnimeRatio = FS.ReadSingle();
            ItemDashRatio = FS.ReadSingle();
            ItemDashTimer = FS.ReadUShort();


            InertiaIceStandardStop = FS.ReadSingle();
            InertiaIceStandardMax = FS.ReadSingle();
            InertiaIceStartSpin = FS.ReadSingle();
            InertiaIceStop = FS.ReadSingle();
            InertiaIceTurn = FS.ReadSingle();


            InertiaSlipStandardStop = FS.ReadSingle();
            InertiaSlipStandardMax = FS.ReadSingle();
            InertiaSlipStartSpin = FS.ReadSingle();
            InertiaSlipStop = FS.ReadSingle();
            InertiaSlipTurn = FS.ReadSingle();


            TurnSlipAngle = FS.ReadSingle();
            TurnReadyTime = FS.ReadUShort();
            TurnSlipNeutral = FS.ReadSingle();
            SlipSpeed = FS.ReadSingle();
            FastTurnSpeed = FS.ReadSingle();
            TurnSlipTime = FS.ReadShort();
            TurnSlipTimeB = FS.ReadShort();
            TurnJumpInhibitTime = FS.ReadShort();
            LandTurnHeight = FS.ReadSingle();
            InertiaBrake = FS.ReadSingle();
            StandingTurnTime = FS.ReadUShort();
            WeakTurnTime = FS.ReadUShort();
            BrakeFirstTimer = FS.ReadUShort();
            BrakeSecondTimer = FS.ReadUShort();


            SlopeSpeedMax = FS.ReadSingle();
            SlopeAccel = FS.ReadSingle();
            SlopeSpeedMaxBraking = FS.ReadSingle();
            SlopeFinishInertia = FS.ReadSingle();
            SlopeCancelInertia = FS.ReadSingle();
            SlopeAnimeFinishSpeed = FS.ReadSingle();
            SlopeDashAngleFactor = FS.ReadSingle();
            SlopeDashSpeedFactor = FS.ReadSingle();
            SlopeDashAccelFactor = FS.ReadSingle();
            SlopeDashAccelTime = FS.ReadUShort();
            SlopeSideMoveInertia = FS.ReadSingle();
            SlopeSideStopInertia = FS.ReadSingle();
            SlopeSideMoveSpeed = FS.ReadSingle();
            SlopeCurveAssist = FS.ReadSingle();
            SlipMoveTurnAngleRad = FS.ReadSingle();


            WalkStepHeight = FS.ReadSingle();


            TiltRatio = FS.ReadSingle();
            LookDownRatio = FS.ReadSingle();
            SpeedStepLow = FS.ReadSingle();
            SpeedStepMiddle = FS.ReadSingle();
            SpeedStepHigh = FS.ReadSingle();
            MaxAnmSpeedA = FS.ReadSingle();
            MinAnmSpeedA = FS.ReadSingle();
            MaxAnmSpeedB = FS.ReadSingle();
            MinAnmSpeedB = FS.ReadSingle();
            MaxAnmSpeedC = FS.ReadSingle();
            MinAnmSpeedC = FS.ReadSingle();
            WeightBlendRatio = FS.ReadSingle();
            MudFloorSlipRatio = FS.ReadSingle();


            StickAngleMargin = FS.ReadSingle();
            StickMarginX = FS.ReadSingle();
            StickMarginY = FS.ReadSingle();
            StickMarginXStart = FS.ReadSingle();
            StickMarginYStart = FS.ReadSingle();
            StickHeavyMinRatio = FS.ReadSingle();
            StickHeavyMinAngle = FS.ReadSingle();
            StickHeavyMaxAngle = FS.ReadSingle();


            SpeedSquatWalkLower = FS.ReadSingle();
            SquatWalkStep = FS.ReadSingle();
            SquatWalkMaxSpeed = FS.ReadSingle();
            SquatWalkMinSpeed = FS.ReadSingle();


            WindSlideLimit = FS.ReadSingle();
            WindSlideFriction = FS.ReadSingle();
            WindForwardFriction = FS.ReadSingle();
            WindSlideFrictionAgainst = FS.ReadSingle();
            WindJumpingFriction = FS.ReadSingle();


            TornadoTime = FS.ReadUShort();
            TornadoTimeAir = FS.ReadUShort();
            AirWalkTimeTornado = FS.ReadUShort();
            TornadoRestartTime = FS.ReadUShort();

            SpinDifferMargin = FS.ReadSingle();
            SpinGoalAngle = FS.ReadSingle();
            SpinInputLimitTime = FS.ReadShort();
            SpinTime = FS.ReadShort();
            SpinSpeed = FS.ReadSingle();
            SpinWalkRatio = FS.ReadSingle();
            SpinJumpRatio = FS.ReadSingle();
            SpinWallReboundSpeed = FS.ReadSingle();
            SpinFinishTime = FS.ReadUShort();
            SpinFinishRate = FS.ReadSingle();
            TornadoMultiply = FS.ReadSingle();
            TurnAngleSpeedTornado = FS.ReadSingle();
            InertiaTornadoAccel = FS.ReadSingle();
            InertiaTornadoBrake = FS.ReadSingle();
            TornadoChargeTime = FS.ReadUShort();
            TornadoChargeUpTime = FS.ReadUShort();
            TornadoZeroGravityTimer = FS.ReadUShort();
            TornadoBoostPower = FS.ReadSingle();
            TornadoBoostAttn = FS.ReadSingle();
            TornadoBoostTimer = FS.ReadUShort();
            TornadoBoostAttnMini = FS.ReadSingle();
            TornadoBoostTimerMini = FS.ReadUShort();

            TornadoTiltCancel = FS.ReadSingle();
            TornadoTiltAngle = FS.ReadSingle();
            TornadoTiltSpeed = FS.ReadSingle();
            TornadoTiltOffSpeed = FS.ReadSingle();
            TornadoTiltNear = FS.ReadSingle();

            TornadoReflectTimer = FS.ReadUShort();
            TornadoReflectSpeed = FS.ReadSingle();

            AirWalkTimeSpin = FS.ReadUShort();
            SpinCoinPullRadius = FS.ReadSingle();
            CoinPullAngleSpeedRatio = FS.ReadSingle();
            CoinPullDistSpeedRatio = FS.ReadSingle();

            SpinJumpCount = FS.ReadUShort();
            SpinIntervalTime = FS.ReadUShort();
            SpinJumpHeight = FS.ReadSingle();
            SpinJumpGravity = FS.ReadSingle();


            WallStickGrHeight = FS.ReadSingle();
            WallStickFrHeight = FS.ReadSingle();
            WallStickStepHeight = FS.ReadSingle();
            WallDropSpeedStop = FS.ReadSingle();
            WallDropSpeedNormal = FS.ReadSingle();

            WallJumpPowerXZ = FS.ReadSingle();
            WallJumpPowerY = FS.ReadSingle();

            WallBackJumpPowerXZ = FS.ReadSingle();
            WallBackJumpPowerY = FS.ReadSingle();

            WallStickTime = FS.ReadShort();
            WallStickTimeIce = FS.ReadShort();
            WallReleaseTime = FS.ReadShort();

            WallSideMoveRatio = FS.ReadSingle();
            JumpHeightBlown = FS.ReadSingle();
            GravityBlown = FS.ReadSingle();

            WallHangGrHeight = FS.ReadSingle();
            WallHangMyHeight = FS.ReadSingle();
            HangBlendTime = FS.ReadShort();
            WallPushAngleRange = FS.ReadSingle();

            WallFrontAngleRange = FS.ReadSingle();
            WallBackAngleRange = FS.ReadSingle();
            WallStickCancelAngle = FS.ReadSingle();

            WallBackHangStickPower = FS.ReadSingle();
            WallBackHangWalkSpeed = FS.ReadSingle();

            WallTriJumpMargin = FS.ReadSingle();

            WallSpinFlipGround = FS.ReadSingle();
            WallSpinHopGround = FS.ReadSingle();
            WallSpinFlipAirRatio = FS.ReadSingle();


            ClapCoinTime = FS.ReadUShort();
            ClapCoinPullRate = FS.ReadSingle();
            ClapJumpBonusRising = FS.ReadSingle();
            ClapJumpBonusFalling = FS.ReadSingle();
            HopLimit = FS.ReadSingle();


            SwimFrontAcc = FS.ReadSingle();
            SwimFrontMaxSpeed = FS.ReadSingle();
            SwimFrontSpinSpeed = FS.ReadSingle();
            SwimFrontNormalSpeed = FS.ReadSingle();
            SwimFrontOnWaterSpeed = FS.ReadSingle();
            SwimFrontJetSpeed = FS.ReadSingle();
            SwimFrontJetSpeedSlow = FS.ReadSingle();
            //TODO: figure out what goes here?
            UNKNOWN1 = FS.ReadSingle();
            UNKNOWN2 = FS.ReadSingle();
            UNKNOWN3 = FS.ReadSingle();
            UNKNOWN4 = FS.ReadSingle();
            UNKNOWN5 = FS.ReadSingle();
            UNKNOWN6 = FS.ReadSingle();
            UNKNOWN7 = FS.ReadSingle();

            SwimAccRatio = FS.ReadSingle();
            SwimAccMinRatio = FS.ReadSingle();

            SwimFrontIne = FS.ReadSingle();
            SwimStopIne = FS.ReadSingle();
            SwimStopIneSurface = FS.ReadSingle();

            SwimRotSpeedX = FS.ReadSingle();
            SwimRotSpeedZ = FS.ReadSingle();
            SwimRotSpeedZStop = FS.ReadSingle();
            SwimRotXIne = FS.ReadSingle();
            SwimRotZIne = FS.ReadSingle();
            SwimRotXIneT = FS.ReadSingle();
            SwimRotZIneT = FS.ReadSingle();

            SwimUpAcc = FS.ReadSingle();
            SwimUpMaxSpeed = FS.ReadSingle();
            //TODO: figure out what goes here?
            UNKNOWN8 = FS.ReadSingle();
            UNKNOWN9 = FS.ReadSingle();
            WeightBlendRatioSwim = FS.ReadSingle();
            WeightBlendRatioSwimB = FS.ReadSingle();

            SwimFreeXback = FS.ReadSingle();
            SwimFreeXback2 = FS.ReadSingle();
            SwimSpdYratio = FS.ReadSingle();

            SwimRotSpeedRatioSurface = FS.ReadSingle();

            JumpSinkTimer = FS.ReadUShort();
            JumpDamageSinkTimer = FS.ReadUShort();
            SwimToWalkSpd = FS.ReadSingle();

            WaterDecInterval = FS.ReadUShort();
            WaterDecSpinAcc = FS.ReadUShort();
            OxygenMax = FS.ReadUShort();


            SwimXJetRotRatio = FS.ReadSingle();
            SwimXJetRotRatioRed = FS.ReadSingle();
            TurboReductionStream = FS.ReadSingle();
            TurboReductionHitWall = FS.ReadSingle();
            TurboReductionHitFloor = FS.ReadSingle();
            SwimJetPeriod1 = FS.ReadUShort();
            SwimJetPeriod2 = FS.ReadUShort();
            SwimJetPeriod1Ratio = FS.ReadSingle();
            SwimJetPeriod3Ratio = FS.ReadSingle();


            ZsinkAngleX = FS.ReadSingle();
            ZsinkMoveTimer = FS.ReadUShort();
            ZsinkSinkTimer = FS.ReadUShort();
            ZsinkStartTimer = FS.ReadUShort();
            ZsinkFrontSpeed = FS.ReadSingle();


            SwimSpecStartTimerADive = FS.ReadUShort();
            SwimSpecStartTimerAJet = FS.ReadUShort();
            SwimSpecStartTimerASpin = FS.ReadUShort();
            SwimSpecStartTimerBDive = FS.ReadUShort();
            SwimSpecStartTimerBJet = FS.ReadUShort();
            SwimSpecStartTimerBSpin = FS.ReadUShort();

            SwimSpinReadyTime = FS.ReadUShort();

            SwimSpinTime = FS.ReadUShort();
            SwimDashTime = FS.ReadUShort();
            SwimSpinFrontTime = FS.ReadUShort();
            SwimSpinYspeedTime = FS.ReadUShort();

            SwimSpinDownStep = FS.ReadUShort();
            SwimSpinSpeed = FS.ReadSingle();
            SwimSpinAcc1 = FS.ReadSingle();
            SwimSpinAcc2 = FS.ReadSingle();
            SwimSpinMissOfsTime = FS.ReadUShort();
            //TODO: Figure this out
            UNKNOWN10 = FS.ReadUShort();
            SwimSpinAccRatio = FS.ReadSingle();
            SwimSpinSurfaceAccRatio = FS.ReadSingle();

            SwimSpinAccRatioR = FS.ReadSingle();
            SwimSpinSurfaceAccRatioR = FS.ReadSingle();
            //TODO: Figure this out
            //This one will suck because Idk if it's part of
            //The Dash Ring or the Swim Spin...
            UNKNOWN11 = FS.ReadSingle();
            UNKNOWN12 = FS.ReadSingle();

            SwimRingDashChargeTime = FS.ReadUShort();
            SwimRingDashTime = FS.ReadUShort();
            SwimRingDashFinishTime = FS.ReadUShort();
            SwimRingDashSpeedRatio = FS.ReadSingle();


            SwimSurfaceSpeed = FS.ReadSingle();
            SwimWaterSpeed = FS.ReadSingle();
            SwimDriftSpeed = FS.ReadSingle();
            SwimConnectIn = FS.ReadUShort();
            SwimConnectOut = FS.ReadUShort();
            SwimTiltZup = FS.ReadSingle();
            SwimTiltZdown = FS.ReadSingle();
            SwimTiltReal = FS.ReadSingle();
            SwimTiltSpd = FS.ReadSingle();


            SwimUpSurfaceDist = FS.ReadSingle();
            SwimUpStrongDist = FS.ReadSingle();
            SwimUpStrongRatio = FS.ReadSingle();
            SwimUpWeakDist = FS.ReadSingle();
            SwimUpBottomDist = FS.ReadSingle();
            SwimUpWeakRatio = FS.ReadSingle();
            SwimReverseSinkRatio = FS.ReadSingle();


            SliderBrakeIne = FS.ReadSingle();
            SliderWeightIne = FS.ReadSingle();
            SliderSlopePow = FS.ReadSingle();
            SliderWeightPow = FS.ReadSingle();
            SliderMaxSpeed = FS.ReadSingle();
            SliderBrakePow = FS.ReadSingle();
            SliderFrontTurnRatio = FS.ReadSingle();
            SliderHeadRotateRatio = FS.ReadSingle();
            SliderTiltRatio = FS.ReadSingle();


            BeeFlyRandomFactor = FS.ReadSingle();
            BeeFlyConstantFactor = FS.ReadSingle();
            BeeAirWalkAcc = FS.ReadSingle();
            BeeAirWalkLimit = FS.ReadSingle();
            BeeAirWalkTurnSpd = FS.ReadSingle();
            BeeSpeedRotateRatio = FS.ReadSingle();
            BeeFreeDropAcc = FS.ReadSingle();
            BeeFreeDropMaxSpd = FS.ReadSingle();
            BeePushRiseGravityEraser = FS.ReadSingle();
            BeeStickJumpPower = FS.ReadSingle();
            BeeStickJumpBonus = FS.ReadSingle();
            BeeStickAngleLimit = FS.ReadSingle();
            BeeUpSpeedMax = FS.ReadSingle();
            BeeUpAccelRatio = FS.ReadSingle();
            BeeAccelRatio = FS.ReadSingle();
            BeeUpDownKiller = FS.ReadSingle();
            BeeGravityReviveTime = FS.ReadUShort();
            BeeGravityPowerTime = FS.ReadUShort();
            BeeAirWalkInhibitTime = FS.ReadUShort();
            BeeGravityPowerTimeV = FS.ReadUShort();
            BeeAirWalkInhibitTimeV = FS.ReadUShort();
            BeeGravityPowerTimeD = FS.ReadUShort();
            BeeAirWalkInhibitTimeD = FS.ReadUShort();

            BeeWallWalkCancelRadius = FS.ReadSingle();
            BeeWallWalkCancelRadiusShort = FS.ReadSingle();

            BeePoseDelayAngleAir = FS.ReadSingle();
            BeePoseDelayAngleGround = FS.ReadSingle();
            BeePoseDelayAccel = FS.ReadSingle();

            BeePoseLimitAngleAir = FS.ReadSingle();
            BeePoseLimitAngleGround = FS.ReadSingle();
            BeePoseHeadToFootLength = FS.ReadSingle();
            BeePoseDelaySpeedLimit = FS.ReadSingle();
            BeePoseFrictionStop = FS.ReadSingle();
            BeePoseTransBlendingRatioStop = FS.ReadSingle();
            BeePoseFrictionMove = FS.ReadSingle();
            BeePoseTransBlendingRatioMove = FS.ReadSingle();


            RabbitTurnRatio = FS.ReadSingle();
            RabbitTurnRatio2 = FS.ReadSingle();
            RabbitGravityRise = FS.ReadSingle();
            RabbitGravityDrop = FS.ReadSingle();
            RabbitFirstJump = FS.ReadSingle();
            RabbitMoveSpeed = FS.ReadSingle();
            RabbitMoveAcc = FS.ReadSingle();
            RabbitMoveAcc2 = FS.ReadSingle();
            RabbitMoveAcc3 = FS.ReadSingle();

            RabbitFirstJump2 = FS.ReadSingle();
            RabbitGravityRise2 = FS.ReadSingle();
            RabbitGravityDrop2 = FS.ReadSingle();
            RabbitChargeTime2 = FS.ReadUShort();
            HopperLandingTime = FS.ReadUShort();


            TeresaHorizontalSpeedMax = FS.ReadSingle();
            TeresaAlphaLevelMax = FS.ReadSingle();
            TeresaAlphaLevelInc = FS.ReadSingle();
            TeresaAlphaLevelDec = FS.ReadSingle();
            TeresaWallThroughTime = FS.ReadUShort();
            TeresaAngleUp = FS.ReadSingle();
            TeresaAngleDown = FS.ReadSingle();

            TeresaWallReflectPower = FS.ReadSingle();
            TeresaWallReflectReduction = FS.ReadSingle();
            TeresaWallReflectTime = FS.ReadUShort();

            TeresaWaitHeight = FS.ReadSingle();
            TeresaDropDownHeight = FS.ReadSingle();
            TeresaBodyRadius = FS.ReadSingle();
            TeresaAirWalkTurnSpd = FS.ReadSingle();
            TeresaDropSpeedMax = FS.ReadSingle();
            TeresaRiseSpeedMax = FS.ReadSingle();
            TeresaDropBase = FS.ReadSingle();
            TeresaUpInertia = FS.ReadSingle();
            TeresaAccelTime = FS.ReadUShort();
            TeresaTrgOnPushTime1 = FS.ReadUShort();
            TeresaTrgOnPushTime2 = FS.ReadUShort();
            TeresaOnePushAccel1 = FS.ReadSingle();
            TeresaOnePushAccel2 = FS.ReadSingle();
            TeresaNoPushDownRatio = FS.ReadSingle();
            TeresaRisingBrake = FS.ReadSingle();

            TeresaWindMovingBrake1 = FS.ReadSingle();
            TeresaWindMovingBrake2 = FS.ReadSingle();
            TeresaWindMovingBrake3 = FS.ReadSingle();


            SilhouetteZoffset = FS.ReadSingle();
            RibbonColor = FS.ReadColor(0, 3, 2, 1);
            DamageFogLow = StreamEx.ReadByte(FS);
            DamageFogHigh = StreamEx.ReadByte(FS);
            StarPieceFogLevel = FS.ReadSingle();
            StarPieceFogTime = StreamEx.ReadByte(FS);

            SearchLightAlphaLevel = StreamEx.ReadByte(FS);
            SearchLightBlurAlphaSmall = StreamEx.ReadByte(FS);
            SearchLightBlurAlphaMedium = StreamEx.ReadByte(FS);
            SearchLightBlurAlphaLarge = StreamEx.ReadByte(FS);
            SearchLightBlurScaleSmall = FS.ReadSingle();
            SearchLightBlurScaleMedium = FS.ReadSingle();
            SearchLightBlurScaleLarge = FS.ReadSingle();
            SearchLightColor = FS.ReadColor(0, 3, 2, 1);

            RasterV = FS.ReadSingle();
            RasterSpeed = FS.ReadInt();
            RasterRange = FS.ReadSingle();


            RacketHoldTime = FS.ReadUShort();
            TornadoHoldTime = FS.ReadUShort();
            MetalHoldTime = FS.ReadUShort();
            FireModeTime = FS.ReadUShort();
            IceModeTime = FS.ReadUShort();
            //TODO: Figure this out
            UNKNOWN13 = FS.ReadInt();


            HeadAngleFixMargin = FS.ReadSingle();
            FrontAngleFixMargin = FS.ReadSingle();
            CameraHeadRotationTimer = FS.ReadUShort();
            HeadRotateRatio = FS.ReadSingle();
            VibrationAbsorbAngleF = FS.ReadSingle();
            VibrationAbsorbAngleH = FS.ReadSingle();
            VibrationAbsorbAngleS = FS.ReadSingle();
            SlopeAnimBlendRatio = FS.ReadSingle();

            RotateHeadVecSpeedByGravityL = FS.ReadSingle();
            RotateHeadVecSpeedByGravityM = FS.ReadSingle();
            RotateHeadVecSpeedByGravityS = FS.ReadSingle();

            LookMaxAngleH = FS.ReadSingle();
            LookMaxAngleVP = FS.ReadSingle();
            LookMaxAngleVM = FS.ReadSingle();
            LookShoulderMoveMax = FS.ReadSingle();

            RushInBlendTimer = FS.ReadUShort();
        }

        public void Write(Stream FS)
        {
            FS.WriteSingle(JumpHeight1st);
            FS.WriteSingle(JumpHeight2nd);
            FS.WriteSingle(JumpHeight3rd);
            FS.WriteSingle(JumpHeightMiss);
            FS.WriteSingle(JumpHeightTurn);
            FS.WriteSingle(JumpHeightSquat);
            FS.WriteSingle(JumpHeightBack);
            FS.WriteSingle(JumpHeightWall);
            FS.WriteSingle(JumpHeightTornado_and_Force);

            FS.WriteSingle(GravityJumping1st);
            FS.WriteSingle(GravityJumping2nd);
            FS.WriteSingle(GravityJumping3rd);
            FS.WriteSingle(GravityJumpingMiss);
            FS.WriteSingle(GravityJumpingTurn);
            FS.WriteSingle(GravityJumpingSquat);
            FS.WriteSingle(GravityJumpingBack);
            FS.WriteSingle(GravityJumpingWall);
            FS.WriteSingle(GravityJumpingTornado);
            FS.WriteSingle(GravityJumpingForce);
            FS.WriteSingle(GravityJumpingSlipUp);
            FS.WriteSingle(GravityJumpingHeli);

            FS.WriteSingle(GravityAirWalk);
            FS.WriteSingle(GravityRatioA);

            FS.WriteSingle(JumpFrontSpeed);
            FS.WriteSingle(JumpTornadoSpeed);
            FS.WriteSingle(DropFrontSpeed);
            FS.WriteShort(JumpConnectTime);
            FS.WriteSingle(JumpConnectSpeed);
            FS.WriteSingle(SquatJumpFrontSpeed);
            FS.WriteSingle(SquatJumpBackSpeed);
            FS.WriteSingle(TurnJumpFrontSpeed);

            FS.WriteSingle(MaxDropSpeedNormal);
            FS.WriteSingle(MaxDropSpeedSpecial1);
            FS.WriteSingle(MaxDropSpeedSpecial2);
            FS.WriteSingle(MaxDropSpeedHelicopter);
            FS.WriteSingle(MaxDropSpeedBee);

            FS.WriteShort(GrReductionDropTimer);
            FS.WriteShort(DropWaitTime);
            FS.WriteSingle(JumpFrontReduction);
            FS.WriteShort(JumpFrontReductionBeginTime);

            FS.WriteSingle(SquatJumpFrontReduction);
            FS.WriteShort(SquatJumpFrontReductionBTime);
            FS.WriteSingle(MudFloorJumpWeakRatio);


            FS.WriteSingle(GravityHipDrop);
            FS.WriteSingle(LimitSpeedHipDrop);
            FS.WriteSingle(HipDropLimitHeight);
            FS.WriteUShort(HipDropZeroGrTime);
            FS.WriteShort(HipDropLimitTimerAfterTornado);


            FS.WriteShort(SlipUpSpdCtrlTimer);
            FS.WriteSingle(SlipUpSpdRatio);
            FS.WriteSingle(SlipUpHeight);
            FS.WriteSingle(SlipUpFront);
            FS.WriteSingle(SlipUpFrontWeak);
            FS.WriteSingle(SlipUpHeightHang);
            FS.WriteSingle(SlipUpFrontHang);
            FS.WriteSingle(SlipUpContinueHeight);


            FS.WriteUShort(AirWalkTime);
            FS.WriteSingle(AirWalkTimerFact1);
            FS.WriteShort(AirWalkTimerFact2);
            FS.WriteSingle(AirWalkTimerFact3);
            FS.WriteSingle(MaxJumpSpeed);
            FS.WriteSingle(AirWalkBackBonus);
            FS.WriteSingle(AirWalkSpeedKiller);
            FS.WriteSingle(MaxBackJumpSpeed);
            FS.WriteSingle(AirWalkBonus);

            FS.WriteShort(BackJumpLimitFrame);
            FS.WriteSingle(BackJumpRatio);
            FS.WriteShort(WaitNeutralTimer);


            FS.WriteSingle(HardLandingHeight);
            FS.WriteUShort(HardLandStunTimer);


            FS.WriteSingle(CodeJumpPowerWeak);
            FS.WriteSingle(CodeJumpPowerMiddle);
            FS.WriteSingle(CodeJumpPowerHigh);
            FS.WriteSingle(CodeJumpPowerNormal);


            FS.WriteSingle(TrampleNormal);
            FS.WriteSingle(TrampleLong);
            FS.WriteSingle(TrampleNormalTaco);
            FS.WriteSingle(TrampleBegoma);
            FS.WriteSingle(TrampleBegomaRotRise);
            FS.WriteSingle(TrampleBegomaRotFall);
            FS.WriteUShort(TrampleBegomaOpenTime);


            FS.WriteSingle(DropUnderPowerMin);
            FS.WriteSingle(DropUnderPowerMax);


            FS.WriteSingle(MsgJumpGroundPowerXZ);
            FS.WriteSingle(MsgJumpGroundPowerY);
            FS.WriteSingle(MsgJumpAirPower);
            FS.WriteSingle(BilliardJumpExtra);


            FS.WriteShort(FutureJumpReqLimitTime);


            FS.WriteSingle(WarpPodJumpX);
            FS.WriteSingle(WarpPodJumpY);


            FS.WriteSingle(JumpHeightDamage);
            FS.WriteSingle(JumpDistDamage);
            FS.WriteSingle(GravityDamage);


            FS.WriteSingle(JumpHeightLargeDamage);
            FS.WriteSingle(JumpDistLargeDamage);


            FS.WriteSingle(SlideDistFaint);
            FS.WriteShort(FaintTimer1);
            FS.WriteShort(FaintTimer2);
            FS.WriteSingle(FaintFriction1);
            FS.WriteSingle(FaintFriction2);


            FS.WriteSingle(SlideDistFlip);
            FS.WriteSingle(SlideDistFlipSpin);
            FS.WriteShort(FlipTimer1);
            FS.WriteShort(FlipTimer2);
            FS.WriteSingle(FlipFriction1);
            FS.WriteSingle(FlipFriction2);
            FS.WriteSingle(FlipFriction3);


            FS.WriteUShort(FireRunTimer1);
            FS.WriteUShort(FireRunTimer2);
            FS.WriteUShort(FireRunTimer3);
            FS.WriteSingle(FireRunSpeed);
            FS.WriteSingle(FireRunTurnRatio);
            FS.WriteSingle(FireRunGravity);
            FS.WriteSingle(FireRunFirstJump);


            FS.WriteSingle(FireDanceTurnRatio);
            FS.WriteSingle(FireDanceGravityRise);
            FS.WriteSingle(FireDanceGravityDrop);
            FS.WriteSingle(FireDanceFirstJump);
            FS.WriteSingle(FireDanceSecondJump);
            FS.WriteSingle(FireDanceMoveSpeed);
            FS.WriteSingle(FireDanceMoveAcc);


            FS.WriteSingle(BlackHoleRadiusRatio);
            FS.WriteSingle(BlackHoleScaleSpeed);
            FS.WriteSingle(BlackHoleScaleLimit);
            FS.WriteSingle(BlackHoleRotateSpeed);
            FS.WriteSingle(BlackHoleRotateLimit);
            FS.WriteSingle(BlackHoleFirstRadius);
            FS.WriteUShort(BlackHoleHideTime);


            FS.WriteUShort(WaterInnerFaintTime);
            FS.WriteSingle(SwimFaintSpeed);
            FS.WriteUShort(WaterInnerDamageTime);
            FS.WriteSingle(SwimDamageSpeed);
            FS.WriteSingle(SwimSurfaceDamageSpeed);
            FS.WriteSingle(WaterSurfaceDamageJump);


            FS.WriteUShort(SwimDamageTimerEx1);
            FS.WriteSingle(SwimDamageSpeedEx1);


            FS.WriteSingle(JumpHeightFlow);
            FS.WriteSingle(JumpDistFlow);
            FS.WriteSingle(GravityFlow);


            FS.WriteSingle(FlatAngle);
            FS.WriteSingle(SlipAngle);
            FS.WriteSingle(ForceWallAngle);
            FS.WriteSingle(DebugMoveSpeed);
            FS.WriteSingle(WalkSpeed);
            FS.WriteSingle(InertiaStandardStop);
            FS.WriteSingle(InertiaStandardMax);
            FS.WriteSingle(InertiaBdash);
            FS.WriteSingle(InertiaBdashAfter);
            FS.WriteSingle(UNKNOWN0);
            FS.WriteSingle(InertiaStop);
            FS.WriteSingle(InertiaSquat);
            FS.WriteSingle(InertiaTurnSlip);
            FS.WriteSingle(InertiaTurning);
            FS.WriteSingle(InertiaJumpFinish);
            FS.WriteSingle(InertiaReflectSlip);
            FS.WriteSingle(InertiaStartSpin);
            FS.WriteSingle(InertiaOverSpeed);

            FS.WriteSingle(TurnAngleSpeed);
            FS.WriteSingle(TurnAngleSpeed2);
            FS.WriteSingle(TurnAngleSpeed3);
            FS.WriteSingle(TurnAngleSpeedSlowWalk);
            FS.WriteSingle(GravityStandard);
            FS.WriteSingle(GravityGrounding);
            FS.WriteSingle(DashMultiply);
            FS.WriteSingle(CameraAngleLimit);
            FS.WriteUShort(StartSpinTime);
            FS.WriteUShort(DashAfterTime);
            FS.WriteUShort(AutoBdashTime);
            FS.WriteUShort(SlowStartTime);

            FS.WriteSingle(StartSpinAnimeRatio);
            FS.WriteSingle(SlopeAnimeRatio);
            FS.WriteSingle(SlopeSpinAnimeRatio);
            FS.WriteSingle(ItemDashRatio);
            FS.WriteUShort(ItemDashTimer);


            FS.WriteSingle(InertiaIceStandardStop);
            FS.WriteSingle(InertiaIceStandardMax);
            FS.WriteSingle(InertiaIceStartSpin);
            FS.WriteSingle(InertiaIceStop);
            FS.WriteSingle(InertiaIceTurn);


            FS.WriteSingle(InertiaSlipStandardStop);
            FS.WriteSingle(InertiaSlipStandardMax);
            FS.WriteSingle(InertiaSlipStartSpin);
            FS.WriteSingle(InertiaSlipStop);
            FS.WriteSingle(InertiaSlipTurn);


            FS.WriteSingle(TurnSlipAngle);
            FS.WriteUShort(TurnReadyTime);
            FS.WriteSingle(TurnSlipNeutral);
            FS.WriteSingle(SlipSpeed);
            FS.WriteSingle(FastTurnSpeed);
            FS.WriteShort(TurnSlipTime);
            FS.WriteShort(TurnSlipTimeB);
            FS.WriteShort(TurnJumpInhibitTime);
            FS.WriteSingle(LandTurnHeight);
            FS.WriteSingle(InertiaBrake);
            FS.WriteUShort(StandingTurnTime);
            FS.WriteUShort(WeakTurnTime);
            FS.WriteUShort(BrakeFirstTimer);
            FS.WriteUShort(BrakeSecondTimer);


            FS.WriteSingle(SlopeSpeedMax);
            FS.WriteSingle(SlopeAccel);
            FS.WriteSingle(SlopeSpeedMaxBraking);
            FS.WriteSingle(SlopeFinishInertia);
            FS.WriteSingle(SlopeCancelInertia);
            FS.WriteSingle(SlopeAnimeFinishSpeed);
            FS.WriteSingle(SlopeDashAngleFactor);
            FS.WriteSingle(SlopeDashSpeedFactor);
            FS.WriteSingle(SlopeDashAccelFactor);
            FS.WriteUShort(SlopeDashAccelTime);
            FS.WriteSingle(SlopeSideMoveInertia);
            FS.WriteSingle(SlopeSideStopInertia);
            FS.WriteSingle(SlopeSideMoveSpeed);
            FS.WriteSingle(SlopeCurveAssist);
            FS.WriteSingle(SlipMoveTurnAngleRad);


            FS.WriteSingle(WalkStepHeight);


            FS.WriteSingle(TiltRatio);
            FS.WriteSingle(LookDownRatio);

            FS.WriteSingle(SpeedStepLow);
            FS.WriteSingle(SpeedStepMiddle);
            FS.WriteSingle(SpeedStepHigh);

            FS.WriteSingle(MaxAnmSpeedA);
            FS.WriteSingle(MinAnmSpeedA);

            FS.WriteSingle(MaxAnmSpeedB);
            FS.WriteSingle(MinAnmSpeedB);

            FS.WriteSingle(MaxAnmSpeedC);
            FS.WriteSingle(MinAnmSpeedC);

            FS.WriteSingle(WeightBlendRatio);
            FS.WriteSingle(MudFloorSlipRatio);


            FS.WriteSingle(StickAngleMargin);
            FS.WriteSingle(StickMarginX);
            FS.WriteSingle(StickMarginY);
            FS.WriteSingle(StickMarginXStart);
            FS.WriteSingle(StickMarginYStart);
            FS.WriteSingle(StickHeavyMinRatio);
            FS.WriteSingle(StickHeavyMinAngle);
            FS.WriteSingle(StickHeavyMaxAngle);


            FS.WriteSingle(SpeedSquatWalkLower);
            FS.WriteSingle(SquatWalkStep);
            FS.WriteSingle(SquatWalkMaxSpeed);
            FS.WriteSingle(SquatWalkMinSpeed);


            FS.WriteSingle(WindSlideLimit);
            FS.WriteSingle(WindSlideFriction);
            FS.WriteSingle(WindForwardFriction);
            FS.WriteSingle(WindSlideFrictionAgainst);
            FS.WriteSingle(WindJumpingFriction);


            FS.WriteUShort(TornadoTime);
            FS.WriteUShort(TornadoTimeAir);
            FS.WriteUShort(AirWalkTimeTornado);
            FS.WriteUShort(TornadoRestartTime);

            FS.WriteSingle(SpinDifferMargin);
            FS.WriteSingle(SpinGoalAngle);

            FS.WriteShort(SpinInputLimitTime);
            FS.WriteShort(SpinTime);
            FS.WriteSingle(SpinSpeed);
            FS.WriteSingle(SpinWalkRatio);
            FS.WriteSingle(SpinJumpRatio);
            FS.WriteSingle(SpinWallReboundSpeed);
            FS.WriteUShort(SpinFinishTime);
            FS.WriteSingle(SpinFinishRate);
            FS.WriteSingle(TornadoMultiply);
            FS.WriteSingle(TurnAngleSpeedTornado);
            FS.WriteSingle(InertiaTornadoAccel);
            FS.WriteSingle(InertiaTornadoBrake);

            FS.WriteUShort(TornadoChargeTime);
            FS.WriteUShort(TornadoChargeUpTime);
            FS.WriteUShort(TornadoZeroGravityTimer);
            FS.WriteSingle(TornadoBoostPower);
            FS.WriteSingle(TornadoBoostAttn);
            FS.WriteUShort(TornadoBoostTimer);
            FS.WriteSingle(TornadoBoostAttnMini);
            FS.WriteUShort(TornadoBoostTimerMini);


            FS.WriteSingle(TornadoTiltCancel);
            FS.WriteSingle(TornadoTiltAngle);
            FS.WriteSingle(TornadoTiltSpeed);
            FS.WriteSingle(TornadoTiltOffSpeed);
            FS.WriteSingle(TornadoTiltNear);
            FS.WriteUShort(TornadoReflectTimer);
            FS.WriteSingle(TornadoReflectSpeed);

            FS.WriteUShort(AirWalkTimeSpin);
            FS.WriteSingle(SpinCoinPullRadius);
            FS.WriteSingle(CoinPullAngleSpeedRatio);
            FS.WriteSingle(CoinPullDistSpeedRatio);
            FS.WriteUShort(SpinJumpCount);
            FS.WriteUShort(SpinIntervalTime);
            FS.WriteSingle(SpinJumpHeight);
            FS.WriteSingle(SpinJumpGravity);


            FS.WriteSingle(WallStickGrHeight);
            FS.WriteSingle(WallStickFrHeight);
            FS.WriteSingle(WallStickStepHeight);
            FS.WriteSingle(WallDropSpeedStop);
            FS.WriteSingle(WallDropSpeedNormal);

            FS.WriteSingle(WallJumpPowerXZ);
            FS.WriteSingle(WallJumpPowerY);

            FS.WriteSingle(WallBackJumpPowerXZ);
            FS.WriteSingle(WallBackJumpPowerY);

            FS.WriteShort(WallStickTime);
            FS.WriteShort(WallStickTimeIce);
            FS.WriteShort(WallReleaseTime);

            FS.WriteSingle(WallSideMoveRatio);
            FS.WriteSingle(JumpHeightBlown);
            FS.WriteSingle(GravityBlown);

            FS.WriteSingle(WallHangGrHeight);
            FS.WriteSingle(WallHangMyHeight);
            FS.WriteShort(HangBlendTime);
            FS.WriteSingle(WallPushAngleRange);

            FS.WriteSingle(WallFrontAngleRange);
            FS.WriteSingle(WallBackAngleRange);
            FS.WriteSingle(WallStickCancelAngle);

            FS.WriteSingle(WallBackHangStickPower);
            FS.WriteSingle(WallBackHangWalkSpeed);

            FS.WriteSingle(WallTriJumpMargin);

            FS.WriteSingle(WallSpinFlipGround);
            FS.WriteSingle(WallSpinHopGround);
            FS.WriteSingle(WallSpinFlipAirRatio);


            FS.WriteUShort(ClapCoinTime);
            FS.WriteSingle(ClapCoinPullRate);
            FS.WriteSingle(ClapJumpBonusRising);
            FS.WriteSingle(ClapJumpBonusFalling);
            FS.WriteSingle(HopLimit);


            FS.WriteSingle(SwimFrontAcc);
            FS.WriteSingle(SwimFrontMaxSpeed);
            FS.WriteSingle(SwimFrontSpinSpeed);
            FS.WriteSingle(SwimFrontNormalSpeed);
            FS.WriteSingle(SwimFrontOnWaterSpeed);
            FS.WriteSingle(SwimFrontJetSpeed);
            FS.WriteSingle(SwimFrontJetSpeedSlow);
            FS.WriteSingle(UNKNOWN1);
            FS.WriteSingle(UNKNOWN2);
            FS.WriteSingle(UNKNOWN3);
            FS.WriteSingle(UNKNOWN4);
            FS.WriteSingle(UNKNOWN5);
            FS.WriteSingle(UNKNOWN6);
            FS.WriteSingle(UNKNOWN7);
            FS.WriteSingle(SwimAccRatio);
            FS.WriteSingle(SwimAccMinRatio);

            FS.WriteSingle(SwimFrontIne);
            FS.WriteSingle(SwimStopIne);
            FS.WriteSingle(SwimStopIneSurface);

            FS.WriteSingle(SwimRotSpeedX);
            FS.WriteSingle(SwimRotSpeedZ);
            FS.WriteSingle(SwimRotSpeedZStop);
            FS.WriteSingle(SwimRotXIne);
            FS.WriteSingle(SwimRotZIne);
            FS.WriteSingle(SwimRotXIneT);
            FS.WriteSingle(SwimRotZIneT);

            FS.WriteSingle(SwimUpAcc);
            FS.WriteSingle(SwimUpMaxSpeed);
            FS.WriteSingle(UNKNOWN8);
            FS.WriteSingle(UNKNOWN9);

            FS.WriteSingle(WeightBlendRatioSwim);
            FS.WriteSingle(WeightBlendRatioSwimB);

            FS.WriteSingle(SwimFreeXback);
            FS.WriteSingle(SwimFreeXback2);
            FS.WriteSingle(SwimSpdYratio);

            FS.WriteSingle(SwimRotSpeedRatioSurface);

            FS.WriteUShort(JumpSinkTimer);
            FS.WriteUShort(JumpDamageSinkTimer);
            FS.WriteSingle(SwimToWalkSpd);

            FS.WriteUShort(WaterDecInterval);
            FS.WriteUShort(WaterDecSpinAcc);
            FS.WriteUShort(OxygenMax);


            FS.WriteSingle(SwimXJetRotRatio);
            FS.WriteSingle(SwimXJetRotRatioRed);
            FS.WriteSingle(TurboReductionStream);
            FS.WriteSingle(TurboReductionHitWall);
            FS.WriteSingle(TurboReductionHitFloor);
            FS.WriteUShort(SwimJetPeriod1);
            FS.WriteUShort(SwimJetPeriod2);
            FS.WriteSingle(SwimJetPeriod1Ratio);
            FS.WriteSingle(SwimJetPeriod3Ratio);


            FS.WriteSingle(ZsinkAngleX);
            FS.WriteUShort(ZsinkMoveTimer);
            FS.WriteUShort(ZsinkSinkTimer);
            FS.WriteUShort(ZsinkStartTimer);
            FS.WriteSingle(ZsinkFrontSpeed);


            FS.WriteUShort(SwimSpecStartTimerADive);
            FS.WriteUShort(SwimSpecStartTimerAJet);
            FS.WriteUShort(SwimSpecStartTimerASpin);
            FS.WriteUShort(SwimSpecStartTimerBDive);
            FS.WriteUShort(SwimSpecStartTimerBJet);
            FS.WriteUShort(SwimSpecStartTimerBSpin);


            FS.WriteUShort(SwimSpinReadyTime);

            FS.WriteUShort(SwimSpinTime);
            FS.WriteUShort(SwimDashTime);
            FS.WriteUShort(SwimSpinFrontTime);
            FS.WriteUShort(SwimSpinYspeedTime);

            FS.WriteUShort(SwimSpinDownStep);
            FS.WriteSingle(SwimSpinSpeed);
            FS.WriteSingle(SwimSpinAcc1);
            FS.WriteSingle(SwimSpinAcc2);
            FS.WriteUShort(SwimSpinMissOfsTime);
            FS.WriteUShort(UNKNOWN10);
            FS.WriteSingle(SwimSpinAccRatio);
            FS.WriteSingle(SwimSpinSurfaceAccRatio);

            FS.WriteSingle(SwimSpinAccRatioR);
            FS.WriteSingle(SwimSpinSurfaceAccRatioR);
            FS.WriteSingle(UNKNOWN11);
            FS.WriteSingle(UNKNOWN12);


            FS.WriteUShort(SwimRingDashChargeTime);
            FS.WriteUShort(SwimRingDashTime);
            FS.WriteUShort(SwimRingDashFinishTime);
            FS.WriteSingle(SwimRingDashSpeedRatio);


            FS.WriteSingle(SwimSurfaceSpeed);
            FS.WriteSingle(SwimWaterSpeed);
            FS.WriteSingle(SwimDriftSpeed);
            FS.WriteUShort(SwimConnectIn);
            FS.WriteUShort(SwimConnectOut);
            FS.WriteSingle(SwimTiltZup);
            FS.WriteSingle(SwimTiltZdown);
            FS.WriteSingle(SwimTiltReal);
            FS.WriteSingle(SwimTiltSpd);


            FS.WriteSingle(SwimUpSurfaceDist);
            FS.WriteSingle(SwimUpStrongDist);
            FS.WriteSingle(SwimUpStrongRatio);
            FS.WriteSingle(SwimUpWeakDist);
            FS.WriteSingle(SwimUpBottomDist);
            FS.WriteSingle(SwimUpWeakRatio);
            FS.WriteSingle(SwimReverseSinkRatio);


            FS.WriteSingle(SliderBrakeIne);
            FS.WriteSingle(SliderWeightIne);
            FS.WriteSingle(SliderSlopePow);
            FS.WriteSingle(SliderWeightPow);
            FS.WriteSingle(SliderMaxSpeed);
            FS.WriteSingle(SliderBrakePow);
            FS.WriteSingle(SliderFrontTurnRatio);
            FS.WriteSingle(SliderHeadRotateRatio);
            FS.WriteSingle(SliderTiltRatio);


            FS.WriteSingle(BeeFlyRandomFactor);
            FS.WriteSingle(BeeFlyConstantFactor);
            FS.WriteSingle(BeeAirWalkAcc);
            FS.WriteSingle(BeeAirWalkLimit);
            FS.WriteSingle(BeeAirWalkTurnSpd);
            FS.WriteSingle(BeeSpeedRotateRatio);
            FS.WriteSingle(BeeFreeDropAcc);
            FS.WriteSingle(BeeFreeDropMaxSpd);
            FS.WriteSingle(BeePushRiseGravityEraser);
            FS.WriteSingle(BeeStickJumpPower);
            FS.WriteSingle(BeeStickJumpBonus);
            FS.WriteSingle(BeeStickAngleLimit);
            FS.WriteSingle(BeeUpSpeedMax);
            FS.WriteSingle(BeeUpAccelRatio);
            FS.WriteSingle(BeeAccelRatio);
            FS.WriteSingle(BeeUpDownKiller);
            FS.WriteUShort(BeeGravityReviveTime);
            FS.WriteUShort(BeeGravityPowerTime);
            FS.WriteUShort(BeeAirWalkInhibitTime);
            FS.WriteUShort(BeeGravityPowerTimeV);
            FS.WriteUShort(BeeAirWalkInhibitTimeV);
            FS.WriteUShort(BeeGravityPowerTimeD);
            FS.WriteUShort(BeeAirWalkInhibitTimeD);

            FS.WriteSingle(BeeWallWalkCancelRadius);
            FS.WriteSingle(BeeWallWalkCancelRadiusShort);

            FS.WriteSingle(BeePoseDelayAngleAir);
            FS.WriteSingle(BeePoseDelayAngleGround);
            FS.WriteSingle(BeePoseDelayAccel);

            FS.WriteSingle(BeePoseLimitAngleAir);
            FS.WriteSingle(BeePoseLimitAngleGround);
            FS.WriteSingle(BeePoseHeadToFootLength);
            FS.WriteSingle(BeePoseDelaySpeedLimit);
            FS.WriteSingle(BeePoseFrictionStop);
            FS.WriteSingle(BeePoseTransBlendingRatioStop);
            FS.WriteSingle(BeePoseFrictionMove);
            FS.WriteSingle(BeePoseTransBlendingRatioMove);


            FS.WriteSingle(RabbitTurnRatio);
            FS.WriteSingle(RabbitTurnRatio2);
            FS.WriteSingle(RabbitGravityRise);
            FS.WriteSingle(RabbitGravityDrop);
            FS.WriteSingle(RabbitFirstJump);
            FS.WriteSingle(RabbitMoveSpeed);
            FS.WriteSingle(RabbitMoveAcc);
            FS.WriteSingle(RabbitMoveAcc2);
            FS.WriteSingle(RabbitMoveAcc3);

            FS.WriteSingle(RabbitFirstJump2);
            FS.WriteSingle(RabbitGravityRise2);
            FS.WriteSingle(RabbitGravityDrop2);
            FS.WriteUShort(RabbitChargeTime2);
            FS.WriteUShort(HopperLandingTime);


            FS.WriteSingle(TeresaHorizontalSpeedMax);
            FS.WriteSingle(TeresaAlphaLevelMax);
            FS.WriteSingle(TeresaAlphaLevelInc);
            FS.WriteSingle(TeresaAlphaLevelDec);
            FS.WriteUShort(TeresaWallThroughTime);
            FS.WriteSingle(TeresaAngleUp);
            FS.WriteSingle(TeresaAngleDown);

            FS.WriteSingle(TeresaWallReflectPower);
            FS.WriteSingle(TeresaWallReflectReduction);
            FS.WriteUShort(TeresaWallReflectTime);

            FS.WriteSingle(TeresaWaitHeight);
            FS.WriteSingle(TeresaDropDownHeight);
            FS.WriteSingle(TeresaBodyRadius);
            FS.WriteSingle(TeresaAirWalkTurnSpd);
            FS.WriteSingle(TeresaDropSpeedMax);
            FS.WriteSingle(TeresaRiseSpeedMax);
            FS.WriteSingle(TeresaDropBase);
            FS.WriteSingle(TeresaUpInertia);
            FS.WriteUShort(TeresaAccelTime);
            FS.WriteUShort(TeresaTrgOnPushTime1);
            FS.WriteUShort(TeresaTrgOnPushTime2);
            FS.WriteSingle(TeresaOnePushAccel1);
            FS.WriteSingle(TeresaOnePushAccel2);
            FS.WriteSingle(TeresaNoPushDownRatio);
            FS.WriteSingle(TeresaRisingBrake);

            FS.WriteSingle(TeresaWindMovingBrake1);
            FS.WriteSingle(TeresaWindMovingBrake2);
            FS.WriteSingle(TeresaWindMovingBrake3);


            FS.WriteSingle(SilhouetteZoffset);
            FS.WriteColor(RibbonColor, 0, 3, 2, 1);
            FS.WriteByte(DamageFogLow);
            FS.WriteByte(DamageFogHigh);
            FS.WriteSingle(StarPieceFogLevel);
            FS.WriteByte(StarPieceFogTime);
            FS.WriteByte(SearchLightAlphaLevel);

            FS.WriteByte(SearchLightBlurAlphaSmall);
            FS.WriteByte(SearchLightBlurAlphaMedium);
            FS.WriteByte(SearchLightBlurAlphaLarge);

            FS.WriteSingle(SearchLightBlurScaleSmall);
            FS.WriteSingle(SearchLightBlurScaleMedium);
            FS.WriteSingle(SearchLightBlurScaleLarge);

            FS.WriteColor(SearchLightColor, 0, 3, 2, 1);

            FS.WriteSingle(RasterV);
            FS.WriteInt(RasterSpeed);
            FS.WriteSingle(RasterRange);


            FS.WriteUShort(RacketHoldTime);
            FS.WriteUShort(TornadoHoldTime);
            FS.WriteUShort(MetalHoldTime);
            FS.WriteUShort(FireModeTime);
            FS.WriteUShort(IceModeTime);
            FS.WriteInt(UNKNOWN13);


            FS.WriteSingle(HeadAngleFixMargin);
            FS.WriteSingle(FrontAngleFixMargin);
            FS.WriteUShort(CameraHeadRotationTimer);
            FS.WriteSingle(HeadRotateRatio);
            FS.WriteSingle(VibrationAbsorbAngleF);
            FS.WriteSingle(VibrationAbsorbAngleH);
            FS.WriteSingle(VibrationAbsorbAngleS);
            FS.WriteSingle(SlopeAnimBlendRatio);

            FS.WriteSingle(RotateHeadVecSpeedByGravityL);
            FS.WriteSingle(RotateHeadVecSpeedByGravityM);
            FS.WriteSingle(RotateHeadVecSpeedByGravityS);

            FS.WriteSingle(LookMaxAngleH);
            FS.WriteSingle(LookMaxAngleVP);
            FS.WriteSingle(LookMaxAngleVM);

            FS.WriteSingle(LookShoulderMoveMax);
            FS.WriteUShort(RushInBlendTimer);
        }
    }
}

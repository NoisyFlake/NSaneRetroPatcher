using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSaneRetroPatcher {
    internal class Level {
        private Level(string name, string pakName, bool needsPSX) {
            Name = name;
            PakName = pakName;
            NeedsPSX = needsPSX; // Indicates wether one or more PSX tracks is needed to patch all tracks or not
        }

        public string Name { get; }
        public string PakName { get; }
        public bool NeedsPSX { get; }

        public static List<Level> AllLevels() {
            return new List<Level> {
                new Level("Game Select Screen", "C1_StartScreen", false),

                new Level("Wumpa Islands", "L100_Hub", false),
                new Level("N. Sanity Beach", "L101_NSanityBeach", true),
                new Level("Jungle Rollers", "L102_JungleRollers", true),
                new Level("The Great Gate", "L103_TheGreatGate", false),
                new Level("Boulders", "L104_Boulders", false),
                new Level("Upstream", "L105_Upstream", false),
                new Level("Papu Papu", "B101_PapuPapu", false),
                new Level("Rolling Stones", "L106_RollingStones", false),
                new Level("Hog Wild", "L107_HogWild", false),
                new Level("Native Fortress", "L108_NativeFortress", false),
                new Level("Up The Creek", "L109_UpTheCreek", false),
                new Level("Ripper Roo", "B102_RipperRoo", false),
                new Level("The Lost City", "L110_TheLostCity", false),
                new Level("Temple Ruins", "L111_TempleRuins", false),
                new Level("Road to Nowhere", "L112_RoadToNowhere", true),
                new Level("Boulder Dash", "L113_BoulderDash", false),
                new Level("Whole Hog", "L114_WholeHog", false),
                new Level("Sunset Vista", "L115_SunsetVista", false),
                new Level("Koala Kong", "B103_KoalaKong", false),
                new Level("Heavy Machinery", "L116_HeavyMachinery", false),
                new Level("Cortex Power", "L117_CortexPower", false),
                new Level("Generator Room", "L118_GeneratorRoom", false),
                new Level("Toxic Waste", "L119_ToxicWaste", false),
                new Level("Pinstripe Potoroo", "B104_PinstripePotoroo", true),
                new Level("The High Road", "L120_TheHighRoad", true),
                new Level("Slippery Climb", "L121_SlipperyClimb", false),
                new Level("Lights Out", "L122_LightsOut", false),
                new Level("Fumbling in the Dark", "L123_FumblingInTheDark", false),
                new Level("Jaws of Darkness", "L124_JawsOfDarkness", false),
                new Level("Castle Machinery", "L125_CastleMachinery", false),
                new Level("Dr. Nitrus Brio", "B105_DrNitrusBrio", false),
                new Level("The Lab", "L126_TheLab", false),
                new Level("The Great Hall", "L127_TheGreatHall", false),
                new Level("Dr. Neo Cortex", "B106_DrNeoCortex", false),
                new Level("Stormy Ascent", "L128_StormyAscent", false),

                new Level("Warp Room", "L200_Hub", false),
                new Level("Turtle Woods", "L201_TurtleWoods", true),
                new Level("Snow Go", "L202_SnowGo", true),
                new Level("Hang Eight", "L203_HangEight", true),
                new Level("The Pits", "L204_ThePits", true),
                new Level("Crash Dash", "L205_CrashDash", true),
                new Level("Ripper Roo", "B201_RipperRoo", false),
                new Level("Snow Biz", "L206_SnowBiz", true),
                new Level("Air Crash", "L207_AirCrash", true),
                new Level("Bear It", "L208_BearIt", false),
                new Level("Crash Crush", "L209_CrashCrush", true),
                new Level("The Eel Deal", "L210_TheEelDeal", true),
                new Level("Komodo Brothers", "B202_KomodoBrothers", false),
                new Level("Plant Food", "L211_PlantFood", true),
                new Level("Sewer or Later", "L212_SewerOrLater", true),
                new Level("Bear Down", "L213_BearDown", false),
                new Level("Road to Ruin", "L214_RoadToRuin", true),
                new Level("Un-Bearable", "L215_UnBearable", true),
                new Level("Tiny Tiger", "B203_TinyTiger", false),
                new Level("Hangin' Out", "L216_HanginOut", true),
                new Level("Diggin' It", "L217_DigginIt", true),
                new Level("Cold Hard Crash", "L218_ColdHardCrash", true),
                new Level("Ruination", "L219_Ruination", true),
                new Level("Bee-Having", "L220_BeeHaving", true),
                new Level("Dr. N. Gin", "B204_DrNGin", false),
                new Level("Piston It Away", "L221_PistonItAway", false),
                new Level("Rock It", "L222_RockIt", false),
                new Level("Night Fight", "L223_NightFight", true),
                new Level("Pack Attack", "L224_PackAttack", false),
                new Level("Spaced Out", "L225_SpacedOut", true),
                new Level("Dr. N. Cortex", "B205_DrNeoCortex", false),
                new Level("Totally Bear", "L226_TotallyBear", false),
                new Level("Totally Fly", "L227_TotallyFly", true),

                new Level("Time Twister", "L300_Hub", false),
                new Level("Toad Village", "L301_ToadVillage", false),
                new Level("Under Pressure", "L302_UnderPressure", false),
                new Level("Orient Express", "L303_OrientExpress", false),
                new Level("Bone Yard", "L304_BoneYard", false),
                new Level("Makin' Waves", "L305_MakinWaves", false),
                new Level("Tiny Tiger", "B301_TinyTiger", false),
                new Level("Gee Wiz", "L306_GeeWiz", false),
                new Level("Hang 'Em High", "L307_HangemHigh", false),
                new Level("Hog Ride", "L308_HogRide", false),
                new Level("Tomb Time", "L309_TombTime", false),
                new Level("Midnight Run", "L310_MidnightRun", false),
                new Level("Dingodile", "B302_Dingodile", false),
                new Level("Dino Might", "L311_DinoMight", false),
                new Level("Deep Trouble", "L312_DeepTrouble", false),
                new Level("High Time", "L313_HighTime", false),
                new Level("Road Crash", "L314_RoadCrash", false),
                new Level("Double Header", "L315_DoubleHeader", false),
                new Level("N. Tropy", "B303_NTropy", false),
                new Level("Sphynxinator", "L316_Sphynxinator", false),
                new Level("Bye Bye Blimps", "L317_ByeByeBlimps", true),
                new Level("Tell no Tales", "L318_TellNoTales", false),
                new Level("Future Frenzy", "L319_FutureFrenzy", false),
                new Level("Tomb Wader", "L320_TombWader", false),
                new Level("N. Gin", "B304_NGin", false),
                new Level("Gone Tomorrow", "L321_GoneTomorrow", false),
                new Level("Orange Asphalt", "L322_OrangeAsphalt", false),
                new Level("Flaming Passion", "L323_FlamingPassion", false),
                new Level("Mad Bombers", "L324_MadBombers", true),
                new Level("Bug Lite", "L325_BugLite", false),
                new Level("Neo Cortex", "B305_NeoCortex", false),
                new Level("Ski Crazed", "L326_SkiCrazed", false),
                new Level("Area 51", "L328_Area51", false),
                new Level("Rings of Power", "L330_RingsOfPower", false),
                new Level("Hot Coco", "L331_HotCoco", false),
                new Level("Eggipus Rex", "L332_EggipusRex", false),
                new Level("Future Tense", "L333_FutureTense", false)
            };
        }
    }
}

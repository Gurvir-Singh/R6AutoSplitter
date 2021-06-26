using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R6AutoSplitter
{
    public class AspectRatioDefinitions
    {
        public enum AspectRatio
        {
            FiveByFour,
            FourByThree,
            ThreeByTwo,
            SixteenByTen,
            FiveByThree,
            SixteenByNine,
            NineteenByTen,
            TwentyOneByNine
        }
        public static float LoadingIconPositionX(AspectRatio AR)
        {
            switch (AR)
            {
                case AspectRatio.FiveByFour:
                    return 118f / 1920f;
                case AspectRatio.FourByThree:
                    return 118f / 1920f;
                case AspectRatio.ThreeByTwo:
                    return 118f / 1920f;
                case AspectRatio.SixteenByTen:
                    return 118f / 1920f;
                case AspectRatio.FiveByThree:
                    return 118f / 1920f;
                case AspectRatio.SixteenByNine:
                    return 118f / 1920f;
                case AspectRatio.NineteenByTen:
                    return 172f / 1920f;
                case AspectRatio.TwentyOneByNine:
                    return 328f / 1920f;
                default:
                    return 118f / 1920f;
            }
        }
        public static float LoadingIconPositionY(AspectRatio AR)
        {
            switch (AR)
            {
                case AspectRatio.FiveByFour:
                    return 854f / 1080f;
                case AspectRatio.FourByThree:
                    return 875f / 1080f;
                case AspectRatio.ThreeByTwo:
                    return 917f / 1080f;
                case AspectRatio.SixteenByTen:
                    return 942f / 1080f;
                case AspectRatio.FiveByThree:
                    return 917f / 1080f;
                case AspectRatio.SixteenByNine:
                    return 987f / 1080f;
                case AspectRatio.NineteenByTen:
                    return 987f / 1080f;
                case AspectRatio.TwentyOneByNine:
                    return 986f / 1080f;
                default:
                    return 987f / 1080f;
            }
        }
        public static float SkipIconPositionX(AspectRatio AR)
        {
            switch (AR)
            {
                case AspectRatio.FiveByFour:
                    return 1768f / 1920f;
                case AspectRatio.FourByThree:
                    return 1768f / 1920f;
                case AspectRatio.ThreeByTwo:
                    return 1768f / 1920f;
                case AspectRatio.SixteenByTen:
                    return 1768f / 1920f;
                case AspectRatio.FiveByThree:
                    return 1768f / 1920f;
                case AspectRatio.SixteenByNine:
                    return 1768f / 1920f;
                case AspectRatio.NineteenByTen:
                    return 1717f / 1920f;
                case AspectRatio.TwentyOneByNine:
                    return 1567f / 1920f;
                default:
                    return 118f / 1920f;
            }
        }
        public static float SkipIconPositionY(AspectRatio AR)
        {
            switch (AR)
            {
                case AspectRatio.FiveByFour:
                    return 853f / 1080f;
                case AspectRatio.FourByThree:
                    return 874f / 1080f;
                case AspectRatio.ThreeByTwo:
                    return 916f / 1080f;
                case AspectRatio.SixteenByTen:
                    return 940f / 1080f;
                case AspectRatio.FiveByThree:
                    return 957f / 1080f;
                case AspectRatio.SixteenByNine:
                    return 984f / 1080f;
                case AspectRatio.NineteenByTen:
                    return 985f / 1080f;
                case AspectRatio.TwentyOneByNine:
                    return 985f / 1080f;
                default:
                    return 984f / 1080f;
            }
        }
        public static float OperatorIconPositionX(AspectRatio AR)
        {
            switch (AR)
            {
                case AspectRatio.FiveByFour:
                    return 636f / 1920f;
                case AspectRatio.FourByThree:
                    return 657f / 1920f;
                case AspectRatio.ThreeByTwo:
                    return 690f / 1920f;
                case AspectRatio.SixteenByTen:
                    return 710f / 1920f;
                case AspectRatio.FiveByThree:
                    return 718f / 1920f;
                case AspectRatio.SixteenByNine:
                    return 734f / 1920f;
                case AspectRatio.NineteenByTen:
                    return 748f / 1920f;
                case AspectRatio.TwentyOneByNine:
                    return 790f / 1920f;
                default:
                    return 790f / 1920f;
            }
        }
        public static float OperatorIconPositionY(AspectRatio AR)
        {
            switch (AR)
            {
                case AspectRatio.FiveByFour:
                    return 68f / 1080f;
                case AspectRatio.FourByThree:
                    return 68f / 1080f;
                case AspectRatio.ThreeByTwo:
                    return 68f / 1080f;
                case AspectRatio.SixteenByTen:
                    return 68f / 1080f;
                case AspectRatio.FiveByThree:
                    return 68f / 1080f;
                case AspectRatio.SixteenByNine:
                    return 68f / 1080f;
                case AspectRatio.NineteenByTen:
                    return 68f / 1080f;
                case AspectRatio.TwentyOneByNine:
                    return 68f / 1080f;
                default:
                    return 68f / 1080f;
            }
        }
        public static float CameraIconPositionX(AspectRatio AR)
        {
            switch (AR)
            {
                case AspectRatio.FiveByFour:
                    return 908f / 1920f;
                case AspectRatio.FourByThree:
                    return 911f / 1920f;
                case AspectRatio.ThreeByTwo:
                    return 917f / 1920f;
                case AspectRatio.SixteenByTen:
                    return 919f / 1920f;
                case AspectRatio.FiveByThree:
                    return 920f / 1920f;
                case AspectRatio.SixteenByNine:
                    return 924f / 1920f;
                case AspectRatio.NineteenByTen:
                    return 927f / 1920f;
                case AspectRatio.TwentyOneByNine:
                    return 932f / 1920f;
                default:
                    return 924f / 1920f;
            }
        }
        public static float CameraIconPositionY(AspectRatio AR)
        {
            switch (AR)
            {
                case AspectRatio.FiveByFour:
                    return 991f / 1080f;
                case AspectRatio.FourByThree:
                    return 991f / 1080f;
                case AspectRatio.ThreeByTwo:
                    return 991f / 1080f;
                case AspectRatio.SixteenByTen:
                    return 991f / 1080f;
                case AspectRatio.FiveByThree:
                    return 991f / 1080f;
                case AspectRatio.SixteenByNine:
                    return 991f / 1080f;
                case AspectRatio.NineteenByTen:
                    return 991f / 1080f;
                case AspectRatio.TwentyOneByNine:
                    return 991f / 1080f;
                default:
                    return 991f / 1080f;
            }
        }
        public static float KillFeedPositionX(AspectRatio AR)
        {
            switch (AR)
            {
                case AspectRatio.FiveByFour:
                    return 1679f / 1920f;
                case AspectRatio.FourByThree:
                    return 1694f / 1920f;
                case AspectRatio.ThreeByTwo:
                    return 1719f / 1920f;
                case AspectRatio.SixteenByTen:
                    return 1731f / 1920f;
                case AspectRatio.FiveByThree:
                    return 1739f / 1920f;
                case AspectRatio.SixteenByNine:
                    return 1749f / 1920f;
                case AspectRatio.NineteenByTen:
                    return 1700f / 1920f;
                case AspectRatio.TwentyOneByNine:
                    return 1552f / 1920f;
                default:
                    return 1749f / 1920f;
            }
        }
        public static float KillFeedPositionY(AspectRatio AR)
        {
            switch (AR)
            {
                case AspectRatio.FiveByFour:
                    return 305f / 1080f;
                case AspectRatio.FourByThree:
                    return 305f / 1080f;
                case AspectRatio.ThreeByTwo:
                    return 305f / 1080f;
                case AspectRatio.SixteenByTen:
                    return 305f / 1080f;
                case AspectRatio.FiveByThree:
                    return 305f / 1080f;
                case AspectRatio.SixteenByNine:
                    return 305f / 1080f;
                case AspectRatio.NineteenByTen:
                    return 305f / 1080f;
                case AspectRatio.TwentyOneByNine:
                    return 305f / 1080f;
                default:
                    return 305f / 1080f;
            }
        }

    }

    
}

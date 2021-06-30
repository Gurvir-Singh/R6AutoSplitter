#ifndef ASPECTRATIODEFINITIONS_H
#define ASPECTRATIODEFINITIONS_H


class AspectRatioDefinitions
{
public:
    AspectRatioDefinitions();
        enum AspectRatio : int {
            FiveByFour,
            FourByThree,
            ThreeByTwo,
            SixteenByTen,
            FiveByThree,
            SixteenByNine,
            NineteenByTen,
            TwentyOneByNine
        };
        static double LoadingIconPositionX(AspectRatio AR);
        static double LoadingIconPositionY(AspectRatio AR);
        static double SkipIconPositionX(AspectRatio AR);
        static double SkipIconPositionY(AspectRatio AR);
        static double OperatorIconPositionX(AspectRatio AR);
        static double OperatorIconPositionY(AspectRatio AR);
        static double CameraIconPositionX(AspectRatio AR);
        static double CameraIconPositionY(AspectRatio AR);
        static double KillFeedPositionX(AspectRatio AR);
        static double KillFeedPositionY(AspectRatio AR);
};

#endif // ASPECTRATIODEFINITIONS_H

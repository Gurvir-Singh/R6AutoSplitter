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
    static float LoadingIconPositionX(AspectRatio AR);
    static float LoadingIconPositionY(AspectRatio AR);
    static float SkipIconPositionX(AspectRatio AR);
    static float SkipIconPositionY(AspectRatio AR);
    static float OperatorIconPositionX(AspectRatio AR);
    static float OperatorIconPositionY(AspectRatio AR);
    static float CameraIconPositionX(AspectRatio AR);
    static float CameraIconPositionY(AspectRatio AR);
    static float KillFeedPositionX(AspectRatio AR);
    static float KillFeedPositionY(AspectRatio AR);
};

#endif // ASPECTRATIODEFINITIONS_H

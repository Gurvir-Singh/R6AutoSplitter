#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QScreen>
#include "aspectratiodefinitions.h"
#include "windows.h"
#include <QTime>
#include <QtConcurrent/QtConcurrent>
#include <qt_windows.h>
#include <QPixmap>
#include <QImage>
MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    //splitterThread = new SplitterThread(this);
    ui->setupUi(this);
    connect(ui->captureButton, SIGNAL(clicked()), this, SLOT(Start()));
}

MainWindow::~MainWindow()
{
    //splitterThread->Stopped = true;
    delete ui;
}

void MainWindow::Start() {

    Split();
}


void MainWindow::Split() {

    AspectRatioDefinitions::AspectRatio AR = AspectRatioDefinitions::AspectRatio::SixteenByNine;
    bool pauseAfterSplit = false;
    delay(3000);
    QScreen *screen = QGuiApplication::primaryScreen();
    QImage screenShot;
    INPUT ip;
    ip.type = INPUT_KEYBOARD;
    ip.ki.wScan = 0; // hardware scan code for key
    ip.ki.time = 0;
    ip.ki.dwExtraInfo = 0;
    int loadingIconPixelPositionX = (int)(screen->geometry().width() * AspectRatioDefinitions::LoadingIconPositionX(AR));
    int loadingIconPixelPositionY = (int)(screen->geometry().height() * AspectRatioDefinitions::LoadingIconPositionY(AR));
    int skipIconPixelPositionX = (int)(screen->geometry().width() * AspectRatioDefinitions::SkipIconPositionX(AR));
    int skipIconPixelPositionY = (int)(screen->geometry().width() * AspectRatioDefinitions::SkipIconPositionY(AR));
    bool loadOrSkipIconShowing = true;
    do {
        screenShot = screen->grabWindow(0).toImage();
        //int loadIconBrightness = screenShot.pixelColor(loadingIconPixelPositionX, loadingIconPixelPositionY).lightness();
        //int skipIconBrightness = screenShot.pixelColor(skipIconPixelPositionX, skipIconPixelPositionY).lightness();

        int loadIconBrightness = screen->grabWindow(0, loadingIconPixelPositionX, loadingIconPixelPositionY, 1, 1).toImage().pixelColor(0, 0).lightness();
        int skipIconBrightness = screen->grabWindow(0, skipIconPixelPositionX, skipIconPixelPositionY, 1, 1).toImage().pixelColor(0, 0).lightness();

        if (loadIconBrightness < 200 && skipIconBrightness < 200) {
            loadOrSkipIconShowing = false;
        }
    } while (loadOrSkipIconShowing);
    ip.ki.wVk = VK_NUMPAD0;
    ip.ki.dwFlags = 0;
    SendInput(1, &ip, sizeof(INPUT));
    delay(1000);
    bool uiVisible = true;
    int operatorIconPixelPositionX = (int)(screen->geometry().width() * AspectRatioDefinitions::OperatorIconPositionX(AR));
    int operatorIconPixelPositionY = (int)(screen->geometry().height() * AspectRatioDefinitions::OperatorIconPositionY(AR));
    int cameraIconPixelPositionX = (int)(screen->geometry().width() * AspectRatioDefinitions::CameraIconPositionX(AR));
    int cameraIconPixelPositionY = (int)(screen->geometry().height() * AspectRatioDefinitions::CameraIconPositionY(AR));
    int killFeedPixelPositionX = (int)(screen->geometry().width() * AspectRatioDefinitions::KillFeedPositionX(AR));
    int killFeedPixelPositionY = (int)(screen->geometry().height() * AspectRatioDefinitions::KillFeedPositionY(AR));
    do {
        //screenShot = screen->grabWindow(0).toImage();
        //int operatorIconBrightness = screenShot.pixelColor(operatorIconPixelPositionX, operatorIconPixelPositionY).lightness();
        //int cameraIconBrightness = screenShot.pixelColor(cameraIconPixelPositionX, cameraIconPixelPositionY).lightness();
        //int killFeedBrightness = screenShot.pixelColor(killFeedPixelPositionX, killFeedPixelPositionY).lightness();
        //QPixmap debug = screen->grabWindow(0, operatorIconPixelPositionX, operatorIconPixelPositionY, 1, 1);
        //QPixmap debug2 = screen->grabWindow(0, cameraIconPixelPositionX, cameraIconPixelPositionY, 1, 1);
        //QPixmap debug3 = screen->grabWindow(0, killFeedPixelPositionX, killFeedPixelPositionY, 1, 1);
        int operatorIconBrightness = screen->grabWindow(0, operatorIconPixelPositionX, operatorIconPixelPositionY, 1, 1).toImage().pixelColor(0, 0).lightness();
        if (operatorIconBrightness < 240) {
            int cameraIconBrightness = screen->grabWindow(0, cameraIconPixelPositionX, cameraIconPixelPositionY, 1, 1).toImage().pixelColor(0, 0).lightness();
            int killFeedBrightness = screen->grabWindow(0, killFeedPixelPositionX, killFeedPixelPositionY, 1, 1).toImage().pixelColor(0, 0).lightness();
            if (cameraIconBrightness < 240 && killFeedBrightness > 25) {
                uiVisible = false;
            }
        }

    } while (uiVisible);
    ip.ki.wVk = VK_NUMPAD0;
    ip.ki.dwFlags = 0;
    SendInput(1, &ip, sizeof(INPUT));
    if (pauseAfterSplit) {
        ip.ki.wVk = VK_END;
        ip.ki.dwFlags = 0;
        SendInput(1, &ip, sizeof(INPUT));
    }

}

void MainWindow::delay(int ms) {
    QTime dieTime= QTime::currentTime().addMSecs(ms);
    while (QTime::currentTime() < dieTime)
        QCoreApplication::processEvents(QEventLoop::AllEvents, 100);
}

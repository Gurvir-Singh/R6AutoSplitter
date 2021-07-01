#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QScreen>
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

    Split(false, AspectRatioDefinitions::AspectRatio::SixteenByNine);

}


void MainWindow::Split(bool pauseAfterSplit, AspectRatioDefinitions::AspectRatio AR) {
    if (FindWindowA(NULL, "Rainbow Six") == 0) {
        emit R6NotRunning();
        return;
    }
    QScreen *screen = QGuiApplication::primaryScreen();
    WId windowId = 0;
    BYTE SplitBtn = VK_OEM_3;
    BYTE PauseBtn = VK_NUMPAD5;
    int loadingIconPixelPositionX = (int)(screen->geometry().width() * AspectRatioDefinitions::LoadingIconPositionX(AR));
    int loadingIconPixelPositionY = (int)(screen->geometry().height() * AspectRatioDefinitions::LoadingIconPositionY(AR));
    int skipIconPixelPositionX = (int)(screen->geometry().width() * AspectRatioDefinitions::SkipIconPositionX(AR));
    int skipIconPixelPositionY = (int)(screen->geometry().width() * AspectRatioDefinitions::SkipIconPositionY(AR));
    bool loadOrSkipIconShowing = true;
    do {

        int loadIconBrightness = screen->grabWindow(windowId, loadingIconPixelPositionX, loadingIconPixelPositionY, 1, 1).toImage().pixelColor(0, 0).lightness();
        int skipIconBrightness = screen->grabWindow(windowId, skipIconPixelPositionX, skipIconPixelPositionY, 1, 1).toImage().pixelColor(0, 0).lightness();

        if (loadIconBrightness < 200 && skipIconBrightness < 200) {
            loadOrSkipIconShowing = false;
            keybd_event(SplitBtn, 0, 0, 0);
            keybd_event(SplitBtn, 0, KEYEVENTF_KEYUP, 0);
        }
    } while (loadOrSkipIconShowing);


    delay(1000);
    bool uiVisible = true;
    int operatorIconPixelPositionX = (int)(screen->geometry().width() * AspectRatioDefinitions::OperatorIconPositionX(AR));
    int operatorIconPixelPositionY = (int)(screen->geometry().height() * AspectRatioDefinitions::OperatorIconPositionY(AR));
    int cameraIconPixelPositionX = (int)(screen->geometry().width() * AspectRatioDefinitions::CameraIconPositionX(AR));
    int cameraIconPixelPositionY = (int)(screen->geometry().height() * AspectRatioDefinitions::CameraIconPositionY(AR));
    int killFeedPixelPositionX = (int)(screen->geometry().width() * AspectRatioDefinitions::KillFeedPositionX(AR));
    int killFeedPixelPositionY = (int)(screen->geometry().height() * AspectRatioDefinitions::KillFeedPositionY(AR));
    do {
        int operatorIconBrightness = screen->grabWindow(0, operatorIconPixelPositionX, operatorIconPixelPositionY, 1, 1).toImage().pixelColor(0, 0).lightness();
        if (operatorIconBrightness < 240) {
            int cameraIconBrightness = screen->grabWindow(0, cameraIconPixelPositionX, cameraIconPixelPositionY, 1, 1).toImage().pixelColor(0, 0).lightness();
            int killFeedBrightness = screen->grabWindow(0, killFeedPixelPositionX, killFeedPixelPositionY, 1, 1).toImage().pixelColor(0, 0).lightness();
            if (cameraIconBrightness < 240) {
                uiVisible = false;
                keybd_event(SplitBtn, 0, 0, 0);
                keybd_event(SplitBtn, 0, KEYEVENTF_KEYUP, 0);
                if (pauseAfterSplit) {
                    keybd_event(PauseBtn, 0, 0, 0);
                    keybd_event(PauseBtn, 0, KEYEVENTF_KEYUP, 0);

                }
            }
            else {
                delay(5200);
            }
        }

    } while (uiVisible);


}

void MainWindow::Debug() {

    QScreen *screen = QGuiApplication::primaryScreen();
    WId wid = WId(FindWindowA(NULL, "Rainbow Six"));
    ui->captureButton->setText(QString::number((int)FindWindowA(NULL, "Rainbow Six")));
    while (true) {
        ui->label->setPixmap(screen->grabWindow(0).scaled(854, 480, Qt::AspectRatioMode::KeepAspectRatio, Qt::TransformationMode::SmoothTransformation));
        delay(34);
    }

}

void MainWindow::delay(int ms) {
    QTime dieTime= QTime::currentTime().addMSecs(ms);
    while (QTime::currentTime() < dieTime)
        QCoreApplication::processEvents(QEventLoop::AllEvents, 100);
}

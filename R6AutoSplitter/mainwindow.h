#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include "aspectratiodefinitions.h"
QT_BEGIN_NAMESPACE
namespace Ui { class MainWindow; }
QT_END_NAMESPACE

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    MainWindow(QWidget *parent = nullptr);
    ~MainWindow();
    void CaptureScreen();

private:
    Ui::MainWindow *ui;
    void Split(bool pauseAfterSplit, AspectRatioDefinitions::AspectRatio AR);
    void Debug();
    void delay(int ms);
private slots:
    void Start();

signals:
    void finished();
    void R6NotRunning();
};
#endif // MAINWINDOW_H

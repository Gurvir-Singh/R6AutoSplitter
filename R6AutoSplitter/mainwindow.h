#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>

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
    void Split();
    void delay(int ms);
private slots:
    void Start();

signals:
    void finished();
};
#endif // MAINWINDOW_H

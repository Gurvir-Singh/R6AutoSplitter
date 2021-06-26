using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;
using System.IO;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;
namespace R6AutoSplitter
{
    
    public class ScreenScrapper
    {

        

        public static void Split(bool pauseAfterSplit, AspectRatioDefinitions.AspectRatio AR)
        {
            int length = 1;
            //Square bitmap of size "length" squared
            Bitmap bmpScreenshot = new Bitmap(length, length, PixelFormat.Format32bppArgb);
            Graphics gfxScreenshot = Graphics.FromImage(bmpScreenshot);
           
            bool loadOrSkipIconShowing = false;
            //This loop will break once the black fade in starts and the loading icon/skip button has dissapeared signalling the start of the thunt/situation
            int loadingIconPixelPositionX = (int)(Screen.PrimaryScreen.Bounds.Width * AspectRatioDefinitions.LoadingIconPositionX(AR));
            int loadingIconPixelPositionY = (int)(Screen.PrimaryScreen.Bounds.Height * AspectRatioDefinitions.LoadingIconPositionY(AR));
            int skipIconPixelPositionX = (int)(Screen.PrimaryScreen.Bounds.Width * AspectRatioDefinitions.SkipIconPositionX(AR));
            int skipIconPixelPositionY = (int)(Screen.PrimaryScreen.Bounds.Height * AspectRatioDefinitions.SkipIconPositionY(AR));
            do
            {
                //gets a pixel from the r6 loading icon
                loadOrSkipIconShowing = false;
                //This is a pixel from the loading icon
                gfxScreenshot.CopyFromScreen(loadingIconPixelPositionX, loadingIconPixelPositionY, 0, 0, new Size(length, length), CopyPixelOperation.SourceCopy);
                float loadIconBrightness = bmpScreenshot.GetPixel(0, 0).GetBrightness();
                //This is a pixel of the skip button that appears during situation intro cutscenes. When it is visible the loading icon is not
                gfxScreenshot.CopyFromScreen(skipIconPixelPositionX, skipIconPixelPositionY, 0, 0, new Size(length, length), CopyPixelOperation.SourceCopy);
                float skipButtonBrightness = bmpScreenshot.GetPixel(0, 0).GetBrightness();
                if ((skipButtonBrightness > 0.1 || loadIconBrightness > 0.1))
                {
                    loadOrSkipIconShowing = true;
                }

            } while (loadOrSkipIconShowing);


            //Splits on livesplit
            SendKeys.SendWait("{PGUP}");

            //Waites for a second so the fade in can complete so that the pixel we use for checking the end of the thunt is at its max brightness
            Thread.Sleep(1000);

            bool operatorIconVisible = true;
            bool KillFeedVisible = true;
            bool CameraVisible = true;
            //had to check for the killfeed and camera because in protect hostage theres a period after every wave where most of the ui including the operator icon disappears
            //but not the bottom tray and killfeed. So for that period I use the killfeed and camera icon. The killfeed is the better way but for the first couple frames
            //I have to use the camera because the killfeed icons have to slide in from the right. The chances of you going on camera in the 6 frame window the killfeed is not
            //in its final position is fairly low so this was a good enough solution for me.

            int cameraIconPixelPositionX = (int)(Screen.PrimaryScreen.Bounds.Width * AspectRatioDefinitions.CameraIconPositionX(AR));
            int cameraIconPixelPositionY = (int)(Screen.PrimaryScreen.Bounds.Height * AspectRatioDefinitions.CameraIconPositionY(AR));
            int operatorIconPixelPositionX = (int)(Screen.PrimaryScreen.Bounds.Width * AspectRatioDefinitions.OperatorIconPositionX(AR));
            int operatorIconPixelPositionY = (int)(Screen.PrimaryScreen.Bounds.Height * AspectRatioDefinitions.OperatorIconPositionY(AR));
            int killFeedPixelPositionX = (int)(Screen.PrimaryScreen.Bounds.Width * AspectRatioDefinitions.KillFeedPositionX(AR));
            int killFeedPixelPositionY = (int)(Screen.PrimaryScreen.Bounds.Height * AspectRatioDefinitions.KillFeedPositionY(AR));
            do
            {
                CameraVisible = true;
                operatorIconVisible = true;
                KillFeedVisible = true;
                //gets a pixel from the top left corner of the operator icon 
                gfxScreenshot.CopyFromScreen(operatorIconPixelPositionX, operatorIconPixelPositionY, 0, 0, new Size(length, length), CopyPixelOperation.SourceCopy);
                if (bmpScreenshot.GetPixel(0, 0).GetBrightness() < 0.9)
                {
                    operatorIconVisible = false;
                }
                //gets a pixel from the bottom right corner of the killfeed
                gfxScreenshot.CopyFromScreen(killFeedPixelPositionX, killFeedPixelPositionY, 0, 0, new Size(length, length), CopyPixelOperation.SourceCopy);
                if (bmpScreenshot.GetPixel(0, 0).GetBrightness() > 0.1)
                {
                    KillFeedVisible = false;
                }
                //gets a pixel from the camera icon
                gfxScreenshot.CopyFromScreen(cameraIconPixelPositionX, cameraIconPixelPositionY, 0, 0, new Size(length, length), CopyPixelOperation.SourceCopy);
                if (bmpScreenshot.GetPixel(0, 0).GetBrightness() < 0.9)
                {
                    CameraVisible = false;
                }

            } while (operatorIconVisible || KillFeedVisible || CameraVisible);
            //Splits on livesplit
            SendKeys.SendWait("{PGUP}");
            if (pauseAfterSplit)
            {
                //shortest delay inbetween the two signals to live split that allows it to work consistently. 263 is the lowest it can be but the pause is not consistent below 300
                Thread.Sleep(300);
                SendKeys.SendWait("{END}");
            }
        }
        


    }
}

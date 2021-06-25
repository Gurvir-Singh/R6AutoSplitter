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
    public enum SplitType
    {
        Situations,
        AllSituations,
        TerroristHunt,
        AllTerroristHunts,
    }
    public class ScreenScrapper
    {
        public static int Split(SplitType type)
        {
            switch (type)
            {
                case SplitType.Situations:
                    return SplitSituations();
                case SplitType.AllSituations:
                    return SplitAllSituations();
                case SplitType.TerroristHunt:
                    return SplitTerroristHunt();
                case SplitType.AllTerroristHunts:
                    return SplitAllTerroristHunts();
            }
            return 1;
        }
        public static int SplitSituations()
        {
            List<string> linesToLog = new List<string>();
            linesToLog.Add(DateTime.Now.ToString());
            int length = 1;
            //Square bitmap of size "length" squared
            Bitmap bmpScreenshot = new Bitmap(length, length, PixelFormat.Format32bppArgb);
            Graphics gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            System.Drawing.Color CurrentPixelColor;
            //Runs while the pixel's Color is close to white. Cant just compare to white because sometimes its a bit darker
            bool ScreenDark = false;
            bool CinematicShowing = false;
            do
            {
                //gets a pixel from the r6 loading icon
                gfxScreenshot.CopyFromScreen(0, 200, 0, 0, new Size(length, length), CopyPixelOperation.SourceCopy);
                if (bmpScreenshot.GetPixel(0, 0).GetBrightness() < 0.1)
                {
                    ScreenDark = true;
                }
                else
                {
                    ScreenDark = false;
                }
                gfxScreenshot.CopyFromScreen(1749, 982, 0, 0, new Size(length, length), CopyPixelOperation.SourceCopy);
                float nextButtonBrightness = bmpScreenshot.GetPixel(0, 0).GetBrightness();
                gfxScreenshot.CopyFromScreen(124, 986, 0, 0, new Size(length, length), CopyPixelOperation.SourceCopy);
                if (( nextButtonBrightness > 0.1 || bmpScreenshot.GetPixel(0, 0).GetBrightness() > 0.1))
                {
                    
                    CinematicShowing = true;
                }
                else
                {
                    CinematicShowing = false;
                    //linesToLog.Add(bmpScreenshot.GetPixel(1749, 982).GetBrightness().ToString());
                    //linesToLog.Add(bmpScreenshot.GetPixel(124, 986).GetBrightness().ToString());
                }
                
            } while (CinematicShowing);
            
            bmpScreenshot.Save("DegubStart.bmp", ImageFormat.Bmp);

            //linesToLog.Add(CurrentPixelColor.R + ", " + CurrentPixelColor.G + ", " + CurrentPixelColor.B);

            //Splits on livesplit
            SendKeys.SendWait("{PGUP}");
            linesToLog.Add("started");
            //Waites for a second so the fade in can complete so that the pixel used for the end split is white and not grey
            Thread.Sleep(1000);
            do
            {
                //gets a pixel from the top left corner of the operator icon 
                gfxScreenshot.CopyFromScreen(709, 68, 0, 0, new Size(length, length), CopyPixelOperation.SourceCopy);
                CurrentPixelColor = bmpScreenshot.GetPixel(0, 0);


            } while (CurrentPixelColor.GetBrightness() > 0.9);
            bmpScreenshot.Save("DegubEnd.bmp", ImageFormat.Bmp);
            linesToLog.Add(CurrentPixelColor.R + ", " + CurrentPixelColor.G + ", " + CurrentPixelColor.B);
            //Splits on livesplit
            SendKeys.SendWait("{PGUP}");
            linesToLog.Add("ended");
            File.WriteAllLines("Log.txt", linesToLog);
            return 0;
        }

        public static int SplitAllSituations()
        {
            SplitSituations();
            Thread.Sleep(500);
            SendKeys.SendWait("{END}");
            return 0;
        }

        public static int SplitTerroristHunt()
        {
            
            List<string> linesToLog = new List<string>();
            linesToLog.Add(DateTime.Now.ToString());
            int length = 1;
            //Square bitmap of size "length" squared
            Bitmap bmpScreenshot = new Bitmap(length, length, PixelFormat.Format32bppArgb);
            Graphics gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            System.Drawing.Color CurrentPixelColor;
            //Runs while the pixel's Color is close to white. Cant just compare to white because sometimes its a bit darker
            do {
                //gets a pixel from the r6 loading icon
                gfxScreenshot.CopyFromScreen(124, 986, 0, 0, new Size(length, length), CopyPixelOperation.SourceCopy);
                CurrentPixelColor = bmpScreenshot.GetPixel(0, 0);

            } while (CurrentPixelColor.GetBrightness() > 0.9);
            bmpScreenshot.Save("DegubStart.bmp", ImageFormat.Bmp);

            linesToLog.Add(CurrentPixelColor.GetBrightness().ToString());

            //Splits on livesplit
            SendKeys.SendWait("{PGUP}");
            linesToLog.Add("started");
            //Waites for a second so the fade in can complete so that the pixel used for the end split is white and not grey
            Thread.Sleep(1000);

            bool operatorIconVisible = true;
            //had to check for this because in protect hostage theres a period after every wave where most of the ui including the operator icon disappears
            //but not the bottom tray. Cant just use camera as ui check because its too incosistent and changes when you use it. The chances of you going on camera
            //mid prepphase is low in a speedrun. This is a terrible way to do it but unfortunatly I cant think of a better way. Theres only so much I can do with the games ui
            bool KillFeedVisible = true;
            bool CameraVisible = true;
            do
            {
                CameraVisible = true;
                operatorIconVisible = true;
                KillFeedVisible = true;
                //gets a pixel from the top left corner of the operator icon 
                gfxScreenshot.CopyFromScreen(709, 68, 0, 0, new Size(length, length), CopyPixelOperation.SourceCopy);
                if (bmpScreenshot.GetPixel(0, 0).GetBrightness() < 0.9)
                {
                    operatorIconVisible = false;
                }
                gfxScreenshot.CopyFromScreen(1754, 309, 0, 0, new Size(length, length), CopyPixelOperation.SourceCopy);
                if (bmpScreenshot.GetPixel(0, 0).GetBrightness() > 0.1)
                {
                    KillFeedVisible = false;
                }
                gfxScreenshot.CopyFromScreen(924, 991, 0, 0, new Size(length, length), CopyPixelOperation.SourceCopy);
                if (bmpScreenshot.GetPixel(0, 0).GetBrightness() < 0.9)
                {
                    CameraVisible = false;
                }

            } while (operatorIconVisible || KillFeedVisible || CameraVisible);
            bmpScreenshot.Save("DegubEnd.bmp", ImageFormat.Bmp);
            linesToLog.Add(CurrentPixelColor.R + ", " + CurrentPixelColor.G + ", " + CurrentPixelColor.B);
            //Splits on livesplit
            SendKeys.SendWait("{PGUP}");
            linesToLog.Add("ended");
            File.WriteAllLines("Log.txt", linesToLog);
            return 0;
            
        }
        //same thing as one terrorist hunt but you have to pause afterwords so you can switch modes
        public static int SplitAllTerroristHunts()
        {
            
            SplitTerroristHunt();
            Thread.Sleep(500);
            SendKeys.SendWait("{END}");
            return 0;
        }


    }
}

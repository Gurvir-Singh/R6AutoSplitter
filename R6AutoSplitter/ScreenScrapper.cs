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
            int length = 5;
            //Square bitmap of size "length" squared
            Bitmap bmpScreenshot = new Bitmap(1920, 1080, PixelFormat.Format32bppArgb);
            Graphics gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            System.Drawing.Color CurrentPixelColor;
            //Runs while the pixel's Color is close to white. Cant just compare to white because sometimes its a bit darker
            do
            {
                //gets a pixel from the r6 loading icon
                gfxScreenshot.CopyFromScreen(0, 0, 0, 0, new Size(1920, 1080), CopyPixelOperation.SourceCopy);
                CurrentPixelColor = bmpScreenshot.GetPixel(0, 200);

            } while (CurrentPixelColor.R + CurrentPixelColor.G + CurrentPixelColor.B > 12);
            bmpScreenshot.Save("DegubStart.bmp", ImageFormat.Bmp);

            linesToLog.Add(CurrentPixelColor.R + ", " + CurrentPixelColor.G + ", " + CurrentPixelColor.B);

            //Splits on livesplit
            SendKeys.SendWait("{PGUP}");
            linesToLog.Add("started");
            //Waites for a second so the fade in can complete so that the pixel used for the end split is white and not grey
            Thread.Sleep(1000);
            do
            {
                //gets a pixel from the top left corner of the operator icon 
                gfxScreenshot.CopyFromScreen(0, 0, 0, 0, new Size(1920, 1080), CopyPixelOperation.SourceCopy);
                CurrentPixelColor = bmpScreenshot.GetPixel(709, 68);


            } while (CurrentPixelColor.R + CurrentPixelColor.G + CurrentPixelColor.B > 750);
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
            int returnCode = ScreenScrapper.SplitSituations();
            SendKeys.SendWait("{END}");
            return returnCode;
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

            } while (CurrentPixelColor.R + CurrentPixelColor.G + CurrentPixelColor.B > 700);
            bmpScreenshot.Save("DegubStart.bmp", ImageFormat.Bmp);

            linesToLog.Add(CurrentPixelColor.R + ", " + CurrentPixelColor.G + ", " + CurrentPixelColor.B);

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

                
            } while (CurrentPixelColor.R + CurrentPixelColor.G + CurrentPixelColor.B > 750);
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

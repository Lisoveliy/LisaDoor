using System.Drawing;
using static LisaDoor.SenderService;

namespace LisaDoor.Network
{
    internal class SSData : IData
    {
        public SSData(DateTime timeCreated, Image image)
        {
            TimeCreated = timeCreated;
            Image = image;
        }
        public DateTime TimeCreated { get; }
        public MessageType MessageType { get; } = MessageType.SCREENIMAGE;
        public Image Image;
    }
}

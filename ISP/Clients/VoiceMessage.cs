using ISP.Interfaces;
using System;

namespace ISP.Clients
{
    class VoiceMessage : IVoiceMessage
    {
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }

        public byte[] Voice { get; set; }
        public void Send()
        {
            Console.WriteLine("Sending Voice Message");
        }
    }
}

using ISP.Interfaces;
using System;

namespace ISP.Clients
{
    class Sms : ITextMessage
    {
        public string Text { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public void Send()
        {
            Console.WriteLine("Sending Sms: {0}", Text);
        }
    }
}

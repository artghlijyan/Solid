using ISP.Interfaces;
using System;

namespace ISP.Clients
{
    class Email : IEmailMessage
    {
        public string Text { get; set; }
        public string Subject { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }

        public void Send()
        {
            Console.WriteLine("Sending by Email: {0}", Text);
        }
    }
}

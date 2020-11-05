using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Interfaces
{
    interface IMessageNoteSegragated
    {
        void Send();
        string Text { get; set; }
        string Subject { get; set; }
        string ToAddress { get; set; }
        string FromAddress { get; set; }
        byte[] Voice { get; set; }
    }
}

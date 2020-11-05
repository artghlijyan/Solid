using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Interfaces
{
    interface IEmailMessage : ITextMessage
    {
        string Subject { get; set; }
    }
}

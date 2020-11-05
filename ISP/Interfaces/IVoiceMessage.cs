using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Interfaces
{
    interface IVoiceMessage : IMessage
    {
        byte[] Voice { get; set; }
    }
}

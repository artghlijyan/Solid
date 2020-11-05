using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Interfaces
{
    interface IMessage // not segregeated
    {
        void Send();
        string ToAddress { get; set; }
        string FromAddress { get; set; }
    }
}

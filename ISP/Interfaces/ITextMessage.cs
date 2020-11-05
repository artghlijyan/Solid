namespace ISP.Interfaces
{
    interface ITextMessage : IMessage
    {
        string Text { get; set; }
    }
}

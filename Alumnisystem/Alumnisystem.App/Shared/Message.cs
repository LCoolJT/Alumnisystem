using System;

namespace Alumnisystem.App.Shared;

public class Message
{
    public DateOnly DateTime { get; set; }
    public Guid messageID { get; set; }
    public string Reciever { get; set; }
    public string Message { get; set; }
}
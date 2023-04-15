using System;

namespace Alumnisystem.App.Shared;

public class Event
{
    public DateOnly Date { get; set; }

    public Guid eventID { get; set; }

    public string? Name { get; set; }

    public string? Summary { get; set; }
}
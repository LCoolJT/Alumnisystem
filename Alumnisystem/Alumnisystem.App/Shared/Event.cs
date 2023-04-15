using System;

namespace Alumnisystem.App.Shared;

public class Event
{
    public DateOnly Date { get; set; }

    public Guid eventID { get; set; }

    public string? Name { get; set; }

    public string? Summary { get; set; }

    public void Update(int? fromNow = null, string? name = null, string? summary = null)
    {
        if (!string.IsNullOrEmpty(name))
        {
            Name = name;
        }

        if (!string.IsNullOrEmpty(summary))
        {
            Summary = summary;
        }

        if (fromNow.HasValue)
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays((double)fromNow));
        }
    }
}
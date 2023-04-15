using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Alumnisystem.App.Shared;

namespace Alumnisystem.App.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class EventController : ControllerBase
{
    private readonly ILogger<EventController> _logger;

    private List<Event> Events = new List<Event>();

    public EventController(ILogger<EventController> logger)
    {
        _logger = logger;
        _addexampleEvents();
    }

    private void _addexampleEvents()
    {
        Events.Add(new Event
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(0)),
            eventID = Guid.NewGuid(),
            Name = "Homework1",
            Summary = "Event for Homework submission"
        }); 
        Events.Add(new Event
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(0)),
            eventID = Guid.NewGuid(),
            Name = "Homework3",
            Summary = "Event for Homework submission"
        });
    }

    [HttpGet("{ID}", Name = "GetEvent")]
    public Event? GetNth(Guid ID) => Events.FirstOrDefault(e => e.eventID == ID);

    [HttpGet(Name = "GetEvents")]
    public List<Event> Get() => Events;

    [HttpPost(Name = "AddEvent")]
    public Event? Add([FromBody] EventRequest eventRequest)
    {
        var foundEvent = GetNth(eventRequest.Ev.eventID);
        if (foundEvent != null)
            return null;

        Events.Add(eventRequest.Ev);
        return eventRequest.Ev;
    }

    [HttpPut(Name = "UpdateEvent")]
    public Event? Update([FromBody] Guid ID, int? fromNow = null, string? name = null, string? summary = null)
    {
        var selectedEvent = GetNth(ID);
        selectedEvent?.Update(fromNow, name, summary);
        return selectedEvent;
    }

    [HttpDelete("{ID}", Name = "DeleteEvent")]
    public void Delete(Guid ID)
    {
        var selectedEvent = GetNth(ID);
        if (selectedEvent == null)
            _logger.LogError("Event does not exist in the list of events.");
        else
            Events.Remove(selectedEvent);
    }

    public class EventRequest
    {
        public Event Ev { get; set; }
    }
}
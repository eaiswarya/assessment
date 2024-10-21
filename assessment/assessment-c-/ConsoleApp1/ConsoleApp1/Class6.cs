using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
internal class Event
{
    public string Name { get; set; }
    public DateTime StartDateTime { get; set; }
    public TimeSpan Duration { get; set; }
    public Event(string name, DateTime startDateTime, TimeSpan duration)
    {
        Name = name;
        StartDateTime = startDateTime;
        Duration = duration;
    }
    public bool OverlapsWith(Event nextEvent)
    {
        DateTime currentEventEnd = StartDateTime.Add(Duration);
        DateTime nextEventEnd = nextEvent.StartDateTime.Add(nextEvent.Duration);
        return StartDateTime < nextEventEnd && nextEvent.StartDateTime < currentEventEnd;
    }
    public TimeSpan TimeUntilEvent()
    {
        return StartDateTime - DateTime.Now;

    }
    public void Display()
    {
        Console.WriteLine("Event:{Name}");
        Console.WriteLine("Start Time:{StartDateTime}");
        Console.WriteLine("Time Until Event:{TimeUntilEvent}");
    }
}

public class EventScheduler
{

    private List<Event> events = new List<Event>();
    public bool AddEvent(Event newEvent)
    {
        foreach (var existingEvent in events)
        {
            if (newEvent.OverlapsWith(existingEvent))
            {
                Console.WriteLine("this event overlap with another event");
                return false;
            }
        }
        events.Add(newEvent);
        return true;


    }



}
class Finalise
{
    static void Main(string[] args)
    {
        EventScheduler scheduler = new EventScheduler();
    }
}
}

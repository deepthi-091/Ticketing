public class Event
{
    public long Id {get;set;}
    public string Title {get;set;} = "";
    public string? Description {get;set;} = "";
    public DateTimeOffset StartsAt {get;set;}
    public DateTimeOffset EndsAt {get;set;}
    public long VenueId {get;set;}
    public Venue Venue {get;set;}
    public List<TicketType> TicketTypes {get;set;} = new();
}
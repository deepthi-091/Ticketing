public class TicketType
{
    public int Id {get;set;}
    public string Name {get;set;} = "";
    public decimal Price{get;set;}
    public int Capacity {get;set;}
    public long EventId {get;set;}
    public Event Event{get;set;} = null!;
}
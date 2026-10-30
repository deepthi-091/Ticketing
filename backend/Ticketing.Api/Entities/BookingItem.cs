public class BookingItem
{
    public int Id {get;set;}
    public long BookingId {get;set;}
    public Booking Booking {get;set;}
    public long TicketTypeId {get;set;}
    public int Quantity {get;set;}
    public decimal UnitPrice {get;set;}
    public TicketType TicketType{get;set;} = null!;
 }
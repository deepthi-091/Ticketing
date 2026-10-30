public class Booking
{
    public int Id{get;set;}
    public  long UserId{get;set;}
    public User User {get;set;}
    public string Status {get;set;}
    public decimal TotalAmount {get;set;}
    public DateTimeOffset CreatedAt {get;set;} = DateTimeOffset.UtcNow;
    public List<BookingItem> Items {get;set;}
 
}
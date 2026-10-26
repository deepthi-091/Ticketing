public class User
{
    public long Id {get;set;}
    public string Email {get;set;} = "";
    public string PasswordHash {get;set;} = "";
    public string Name {get;set;} = "";
    public string Role {get;set;} = "user";
    public DateTimeOffset CreatedAt {get;set;} = DateTimeOffset.UtcNow;
    
}
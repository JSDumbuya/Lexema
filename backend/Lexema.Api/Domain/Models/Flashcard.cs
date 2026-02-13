namespace Lexema.Api.Domain.Models;

public class Flashcard
{
    public int Id {get; set;}
    public int? TextId {get; set;} 
    public string UserId {get; set;} = null!;
    public string Front {get; set;} = "";
    public string Back {get; set;} = "";
}
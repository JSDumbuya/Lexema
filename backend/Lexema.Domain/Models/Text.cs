namespace Lexema.Domain.Models;

public class Text
{
    public int Id {get; set;}
    public string UserId {get; set;} = null!;
    public string Title {get; set;} = "";
    public Level? Level {get; set;}
    public string Content {get; set;} = "";
    public DateTime AddedAt {get; set;} = DateTime.UtcNow;
    public List<Flashcard> Flashcards {get; set;} = new();
}
namespace Lexema.Infrastructure.Data;

using Lexema.Domain.Models;
using Lexema.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class LexemaDbContext : IdentityDbContext<ApplicationUser>
{
    public LexemaDbContext(DbContextOptions<LexemaDbContext> options) : base(options)
    {  
    }

    //To avoid nullable warnings use => Set<>();
    public DbSet<Flashcard> Flashcards => Set<Flashcard>();
    public DbSet<Text> Texts => Set<Text>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
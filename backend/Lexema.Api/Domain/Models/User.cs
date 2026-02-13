namespace Lexema.Api.Domain.Models;

using Microsoft.AspNetCore.Identity;
public class User : IdentityUser
{
    public string? DisplayName {get; set;}
}
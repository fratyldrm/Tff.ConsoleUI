namespace Tff.ConsoleUI.Models;

public abstract class Entity<TId>
{
    public TId Id { get; set; }
}
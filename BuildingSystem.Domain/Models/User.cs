namespace BuildingSystem.Domain.Models;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public List<Building> Buildings { get; set; }
}
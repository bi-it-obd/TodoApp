namespace TodoApp.Models;

public sealed class Urgency
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string ColorRGB { get; set; } = "#757575";
}
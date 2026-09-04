namespace TodoApp.Models;

public sealed class TodoTask
{
    public int Id { get; set; }
    public int? ParentTaskId { get; set; }
    public DateTime? DueDate { get; set; }
    public TimeSpan? DueTime { get; set; }
    public int? UrgencyId { get; set; }
    public int? StatusId { get; set; }
    public string? Description { get; set; }
}

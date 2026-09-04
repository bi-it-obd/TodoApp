namespace TodoApp.Repositories;

using Models;

public interface ITaskRepository
{
    Task<TodoTask?> GetByIdAsync(int id);
    Task<IReadOnlyList<TodoTask>> GetSubtasksAsync(int taskId);
    Task<IReadOnlyList<TodoTask>> GetByStatusNameAsync(string statusName);
    Task<IReadOnlyList<TodoTask>> GetByTagNameAsync(string tagName);
    Task<int> CreateAsync(TodoTask task);
    Task UpdateAsync(TodoTask task);
    Task DeleteAsync(int id);

    Task AddTagAsync(int taskId, int tagId);
    Task RemoveTagAsync(int taskId, int tagId);
}

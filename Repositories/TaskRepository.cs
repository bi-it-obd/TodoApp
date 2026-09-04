
using Dapper;
using TodoApp.Models;
using MySqlConnector;

namespace TodoApp.Repositories;
public sealed class TaskRepository(string connectionString): ITaskRepository
{
    private MySqlConnection GetConnection() =>  new MySqlConnection(connectionString);

    public async Task<TodoTask?> GetByIdAsync(int id)
    {
        await using var connection = GetConnection();

        const string query = """
            SELECT * FROM Task
            WHERE Id = @Id;
        """;

        return await connection.QuerySingleOrDefaultAsync<TodoTask?>(query, new {Id = id});
    }

    public Task<IReadOnlyList<TodoTask>> GetSubtasksAsync(int taskId)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<TodoTask>> GetByStatusNameAsync(string statusName)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<TodoTask>> GetByTagNameAsync(string tagName)
    {
        throw new NotImplementedException();
    }

    public async Task<int> CreateAsync(TodoTask task)
    {
        await using var connection = GetConnection();

        const string query = """
            INSERT INTO Task (ParentTaskId, DueDate, DueTime, UrgencyId, StatusId, Description)
            VALUES (@ParentTaskId, @DueDate, @DueTime, @UrgencyId, @StatusId, @Description);
            SELECT LAST_INSERT_ID();
        """;

        return await connection.QuerySingleAsync<int>(query, task);
    }

    public Task UpdateAsync(TodoTask task)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
        {
        throw new NotImplementedException();
    }

    public Task AddTagAsync(int taskId, int tagId)
    {
        throw new NotImplementedException();
    }

    public Task RemoveTagAsync(int taskId, int tagId)
    {
        throw new NotImplementedException();
    }
}
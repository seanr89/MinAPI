
public class TodoService
{
    public readonly TodoDb _db;
    public TodoService(TodoDb db) => _db = db;

    public async Task<IResult> GetTodoById(int id)
    {
        var todo = await _db.Todos.FindAsync(id);

        return todo != null ? Results.Ok(todo) : Results.NotFound();
    }
}
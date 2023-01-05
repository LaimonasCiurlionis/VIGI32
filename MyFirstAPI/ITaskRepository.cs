namespace MyFirstAPI
{
    public interface ITaskRepository
    {
        List<TodoTask> GetTasks();
        TodoTask AddTask(TodoTask task);
    }
}

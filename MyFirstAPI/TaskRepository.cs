namespace MyFirstAPI
{
    public class TaskRepository : ITaskRepository
    {
        private readonly List<TodoTask> _tasks = new();

        public TodoTask AddTask(TodoTask task)
        {
            _tasks.Add(task);
            return task;
        }

        public List<TodoTask> GetTasks()
        {
            return _tasks;
        }
    }
}

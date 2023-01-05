using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskRepository _taskRepository;

        public TasksController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }


        [HttpGet]
        public List<TodoTask> Get() 
        {
            return _taskRepository.GetTasks();
        }

        [HttpPost]
        public TodoTask Add([FromBody] TodoTask task) 
        {
            return _taskRepository.AddTask(task);
        }
    }
}

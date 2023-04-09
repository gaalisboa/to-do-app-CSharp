using Microsoft.AspNetCore.Mvc;
using to_do_app.Services.IServices;

namespace to_do_app.Controllers
{
    public class TaskController : Controller
    {
        private readonly IAppTaskService _taskService;

        public TaskController(IAppTaskService taskService)
        {
            _taskService = taskService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var appTasks = await _taskService.GetTasks();
            return View(appTasks);
        }
    }
}

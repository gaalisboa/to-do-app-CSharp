using to_do_app.Models;

namespace to_do_app.Services.IServices
{
    public interface IAppTaskService
    {
        Task<IEnumerable<AppTask>> GetTasks();
        Task<AppTask> GetTaskById(int id);
        Task<bool> CreateTask(AppTask appTask);
        Task<bool> UpdateTaskById(int id);
        Task<bool> DeleteTaskById(int id);
    }
}

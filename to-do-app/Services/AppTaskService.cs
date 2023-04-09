using Microsoft.EntityFrameworkCore;
using to_do_app.Models;
using to_do_app.Models.Context;
using to_do_app.Services.IServices;

namespace to_do_app.Services
{
    public class AppTaskService : IAppTaskService
    {
        private readonly MySqlContext _context;

        public AppTaskService(MySqlContext appTaskService)
        {
            _context = appTaskService;
        }

        public async Task<IEnumerable<AppTask>> GetTasks()
        {
            var appTasks = await _context.AppTasks.ToListAsync();
            return appTasks;
        }

        public async Task<AppTask> GetTaskById(int id)
        {
            var appTask = await _context.AppTasks.FindAsync(id);
            return appTask;
        }

        public async Task<bool> CreateTask(AppTask appTask)
        {
            await _context.AddAsync(appTask);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateTaskById(int id)
        {
            var appTask = await _context.AppTasks.FindAsync(id);
            _context.Update(appTask);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteTaskById(int id)
        {
            var appTask = await _context.AppTasks.FindAsync(id);
            _context.Remove(appTask);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace to_do_app.Models.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() { }
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }

        public DbSet<AppTask> AppTasks { get; set; }
    }
}

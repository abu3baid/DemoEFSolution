using DemoEFApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoEFApplication.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> mycontext) : base(mycontext)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            base.OnConfiguring(dbContextOptionsBuilder);
            var bulider = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot config = bulider.Build();
            var conString = config.GetConnectionString("MyDbConnection");
            dbContextOptionsBuilder.UseSqlServer(conString);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

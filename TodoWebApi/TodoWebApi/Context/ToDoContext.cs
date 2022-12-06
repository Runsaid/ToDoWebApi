using Microsoft.EntityFrameworkCore;
using TodoWebApi.Entities;

namespace TodoWebApi.Context
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {

        }


        public DbSet<ToDoEntity> ToDos => Set<ToDoEntity>();

    }
}

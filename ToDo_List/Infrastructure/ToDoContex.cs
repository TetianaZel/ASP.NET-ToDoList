using Microsoft.EntityFrameworkCore;
using ToDo_List.Models;

namespace ToDo_List.Infrastructure;

public class ToDoContex : DbContext
{
    public ToDoContex(DbContextOptions<ToDoContex> options) :base(options)
    {
            
    }
    
    public DbSet<ToDoList> ToDoList { get; set; }
}
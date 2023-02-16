using System.ComponentModel.DataAnnotations;

namespace ToDo_List.Models;

public class ToDoList
{
    public int Id { get; set; }
    [Required]
    public string Content { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace MvcToDoList.Models;

public class Task
{
    public int Id { get; set; }
    [Display(Name = "Task Description")]
    public string? Title { get; set; }
    [Display(Name = "Due Date")]
    [DataType(DataType.Date)]
    public DateTime DueDate { get; set; }
    public string? Category { get; set; }
    public int Priority { get; set; }
}
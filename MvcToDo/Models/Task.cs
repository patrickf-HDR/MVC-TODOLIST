using System.ComponentModel.DataAnnotations;

namespace MvcToDoList.Models;

public class Task
{
    public int Id { get; set; }
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime DueDate { get; set; }
    public string? Category { get; set; }
    public int Priority { get; set; }
}
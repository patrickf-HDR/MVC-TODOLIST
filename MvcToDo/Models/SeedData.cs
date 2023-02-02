using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcToDo.Data;
using System;
using System.Linq;

namespace MvcToDoList.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcToDoContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcToDoContext>>()))
        {
            // Look for any movies.
            if (context.Task.Any())
            {
                return;   // DB has been seeded
            }
            context.Task.AddRange(
                new Task
                {
                    Title = "Get Cat Food",
                    DueDate = DateTime.Parse("2023-2-12"),
                    Category = "Pets",
                    Priority = 10
                },
                new Task
                {
                    Title = "Trim Cats Nails",
                    DueDate = DateTime.Parse("2023-2-5"),
                    Category = "Pets",
                    Priority = 6
                },
                new Task
                {
                    Title = "Pet Cat",
                    DueDate = DateTime.Parse("2023-2-12"),
                    Category = "Pets",
                    Priority = 9
                }
            );
            context.SaveChanges();
        }
    }
}
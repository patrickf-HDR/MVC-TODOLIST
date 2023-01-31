using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcToDoList.Models;

namespace MvcToDo.Data
{
    public class MvcToDoContext : DbContext
    {
        public MvcToDoContext (DbContextOptions<MvcToDoContext> options)
            : base(options)
        {
        }

        public DbSet<MvcToDoList.Models.Task> Task { get; set; } = default!;
    }
}

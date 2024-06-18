using Microsoft.EntityFrameworkCore;
using Shared.Core.Drivens.Persistence.EFCore;
using TodoApp.Domain.Entities;

namespace TodoApp.Infrastructure.Persistence;

public class TodoAppDbContext(DbContextOptions options) : AppDbContext<TodoAppDbContext>(options)
{
    public required DbSet<Todo> Todos { get; init; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TodoAppDbContext).Assembly);
    }
}
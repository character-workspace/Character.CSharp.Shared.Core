using Shared.Core.Domain.Entities;

namespace TodoApp.Domain.Entities;

public class Todo : BaseEntity
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required string UserId { get; init; }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shared.Core.Domain.Rules.BaseEntityRules;
using TodoApp.Domain.Entities;

namespace TodoApp.Infrastructure.Persistence.EntityConfigurations;

public class TaskConfig : BaseEntityConfig<Todo>
{
    public override void Configure(EntityTypeBuilder<Todo> builder)
    {
        base.Configure(builder);

        builder
            .HasIndex(t => t.UserId);
        
        builder
            .Property(t => t.Title)
            .HasMaxLength(1000);
        
        builder
            .Property(t => t.Description)
            .HasColumnType(SqlServerTypes.NVarcharMax);
        
        // This should be split into utilities config
        builder
            .Property(t => t.UserId)
            .HasMaxLength(StringIdRule.MaxLen)
            .HasColumnType(SqlServerTypes.Varchar(StringIdRule.MaxLen));
    }
}
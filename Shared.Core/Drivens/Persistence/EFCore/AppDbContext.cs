using Microsoft.EntityFrameworkCore;

namespace Shared.Core.Drivens.Persistence.EFCore;

public abstract class AppDbContext(DbContextOptions options) : DbContext(options);
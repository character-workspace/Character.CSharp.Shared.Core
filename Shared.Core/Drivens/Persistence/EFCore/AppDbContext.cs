using Microsoft.EntityFrameworkCore;

namespace Shared.Core.Drivens.Persistence.EFCore;

public abstract class AppDbContext<TDerived>(DbContextOptions options) : DbContext(options);
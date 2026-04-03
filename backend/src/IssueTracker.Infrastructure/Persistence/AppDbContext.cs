using IssueTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Comment> Comments => Set<Comment>();
    public DbSet<Project> Projects => Set<Project>();
    public DbSet<TaskItem> TaskItems => Set<TaskItem>();
    public DbSet<UserProject> UserProjects => Set<UserProject>();

    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    {

    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entities = ChangeTracker.Entries<BaseEntity>();

        foreach (var entity in entities)
        {
            if(entity.State == EntityState.Added)
            {
                entity.Entity.CreatedAtUtc = DateTime.UtcNow;
                entity.Entity.UpdatedAtUtc = DateTime.UtcNow;
            }

            if(entity.State == EntityState.Modified)
            {
                entity.Entity.UpdatedAtUtc = DateTime.UtcNow;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

}

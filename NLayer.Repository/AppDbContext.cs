using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using NLayer.Core.Model;
using System.Reflection;

namespace NLayer.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is BaseEntitiy entityreference)
                {
                    switch (item.State)
                    {
                        case EntityState.Added:
                            {
                                entityreference.CreateDate = DateTime.Now;
                                break;
                            }
                        case EntityState.Modified:
                            {
                                Entry(entityreference).Property(x => x.CreateDate).IsModified = false;

                                entityreference.UpdatedDate = DateTime.Now;
                                break;
                            }
                    }

                }
            }
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            foreach (var item in ChangeTracker.Entries())
            {
                if(item.Entity is BaseEntitiy entityreference)
                {
                    switch(item.Entity)
                    {
                        case EntityState.Added:
                            {
                                entityreference.CreateDate = DateTime.Now;
                                break;
                            }
                        case EntityState.Modified:
                            {
                                entityreference.UpdatedDate = DateTime.Now;
                                break;
                            }
                    }

                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature()
            {
                Id = 1,
                Color = "Kırmızı",
                Height = 100,
                Width = 200,
                ProductId = 1
            },

           new ProductFeature()
           {
               Id = 2,
               Color = "Mavi",
               Height = 300,
               Width = 500,
               ProductId = 2
           });


            base.OnModelCreating(modelBuilder);
        }

    }



}


using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RestaurantAppAPI.Generated;

public partial class RestaurantAppDB : DbContext
{
    public RestaurantAppDB()
    {
    }

    public RestaurantAppDB(DbContextOptions<RestaurantAppDB> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory) 
        .AddJsonFile("appsettings.json", false, true)
        .Build();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Orders__C3905BAF32D7865A");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Restaurant)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

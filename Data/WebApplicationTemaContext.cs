using Microsoft.EntityFrameworkCore;
using System;

namespace WebApplicationTema.Data
{
    public class WebApplicationTemaContext : DbContext
    {
        public DbSet<WebApplicationTema.Models.Duckbill> Duckbill { get; set; }

        public WebApplicationTemaContext(DbContextOptions<WebApplicationTemaContext> options)
            : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<WebApplicationTema.Models.Duckbill>().HasData(new WebApplicationTema.Models.Duckbill() { ID = new Guid("c9f777a1-6166-471a-87db-2ef29ed1cd5a"), Name = "Duckbill1", DateOfBirth = new DateTime(2021, 01, 01) });
        }
    }
}
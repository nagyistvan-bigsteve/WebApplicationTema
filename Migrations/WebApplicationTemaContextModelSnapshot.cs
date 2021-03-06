// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationTema.Data;

namespace WebApplicationTema.Migrations
{
    [DbContext(typeof(WebApplicationTemaContext))]
    partial class WebApplicationTemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplicationTema.Models.Duckbill", b =>
            {
                b.Property<Guid>("ID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("DateOfBirth")
                    .HasColumnType("datetime2");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("ID");

                b.ToTable("Duckbill");

                b.HasData(
                    new
                    {
                        ID = new Guid("c9f777a1-6166-471a-87db-2ef29ed1cd5a"),
                        DateOfBirth = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        Name = "Duckbill1"
                    });
            });
#pragma warning restore 612, 618
        }
    }
}
// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiAspCore.Models;

namespace WebApiAspCore.Migrations
{
    [DbContext(typeof(EFDataContext))]
    [Migration("20201118025249_dbreact")]
    partial class dbreact
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiAspCore.Models.Category", b =>
                {
                    b.Property<int>("idCategory")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("SlugCategory");

                    b.HasKey("idCategory");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WebApiAspCore.Models.Product", b =>
                {
                    b.Property<int>("idProduct")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.Property<string>("Slug");

                    b.Property<string>("Title");

                    b.Property<int>("idCategory");

                    b.HasKey("idProduct");

                    b.HasIndex("idCategory");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WebApiAspCore.Models.Product", b =>
                {
                    b.HasOne("WebApiAspCore.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("idCategory")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}

// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrtDriver.Context;

namespace OrtDriver.Migrations
{
    [DbContext(typeof(OrtDriverDBContext))]
    partial class OrtDriverDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrtDriver.Models.Conductor", b =>
                {
                    b.Property<string>("ConductorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConductorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConductorSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dni")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaInscripto")
                        .HasColumnType("datetime2");

                    b.HasKey("ConductorId");

                    b.ToTable("Conductores");
                });

            modelBuilder.Entity("OrtDriver.Models.Viaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConductorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Destino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaInscripto")
                        .HasColumnType("datetime2");

                    b.Property<string>("Origen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ConductorId");

                    b.ToTable("Viajes");
                });

            modelBuilder.Entity("OrtDriver.Models.Viaje", b =>
                {
                    b.HasOne("OrtDriver.Models.Conductor", "Conductor")
                        .WithMany()
                        .HasForeignKey("ConductorId");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiExemploSwagger.Data;

namespace WebApiExemploSwagger.Migrations
{
    [DbContext(typeof(WebApiExemploSwaggerContext))]
    [Migration("20200325051652_CriaaoInicial")]
    partial class CriaaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiExemploSwagger.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .HasMaxLength(50);

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MudBlazorApp.DataContext;

#nullable disable

namespace MudBlazorApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240610151529_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MudBlazorApp.Entities.Departamento", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartamentoId"));

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DepartamentoId");

                    b.ToTable("Departamentos");

                    b.HasData(
                        new
                        {
                            DepartamentoId = 1,
                            Nome = "Gestão"
                        },
                        new
                        {
                            DepartamentoId = 2,
                            Nome = "Desenvolvimento"
                        },
                        new
                        {
                            DepartamentoId = 3,
                            Nome = "Infraestrutura"
                        });
                });

            modelBuilder.Entity("MudBlazorApp.Entities.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FuncionarioId"));

                    b.Property<string>("Cargo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FuncionarioId");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Funcionarios");

                    b.HasData(
                        new
                        {
                            FuncionarioId = 1,
                            Cargo = "Gerente",
                            DepartamentoId = 1,
                            Nome = "José",
                            Salario = 7000m
                        },
                        new
                        {
                            FuncionarioId = 2,
                            Cargo = "Coordenadora",
                            DepartamentoId = 1,
                            Nome = "Maria",
                            Salario = 6500m
                        },
                        new
                        {
                            FuncionarioId = 3,
                            Cargo = "Desenvolvedor Sênior",
                            DepartamentoId = 2,
                            Nome = "Carlos",
                            Salario = 3500m
                        },
                        new
                        {
                            FuncionarioId = 4,
                            Cargo = "Desenvolvedora Pleno",
                            DepartamentoId = 2,
                            Nome = "Ana",
                            Salario = 4200m
                        },
                        new
                        {
                            FuncionarioId = 5,
                            Cargo = "Desenvolvedor Júnior",
                            DepartamentoId = 2,
                            Nome = "Pedro",
                            Salario = 2500m
                        },
                        new
                        {
                            FuncionarioId = 6,
                            Cargo = "Analista de Infraestrutura",
                            DepartamentoId = 3,
                            Nome = "Rafael",
                            Salario = 4500m
                        },
                        new
                        {
                            FuncionarioId = 7,
                            Cargo = "Suporte Técnico",
                            DepartamentoId = 3,
                            Nome = "Fernanda",
                            Salario = 3200m
                        },
                        new
                        {
                            FuncionarioId = 8,
                            Cargo = "Estagiário de Desenvolvimento",
                            DepartamentoId = 2,
                            Nome = "Gabriel",
                            Salario = 1200m
                        },
                        new
                        {
                            FuncionarioId = 9,
                            Cargo = "Estagiária de Infraestrutura",
                            DepartamentoId = 3,
                            Nome = "Bruna",
                            Salario = 1200m
                        },
                        new
                        {
                            FuncionarioId = 10,
                            Cargo = "Assistente Administrativo",
                            DepartamentoId = 1,
                            Nome = "Ricardo",
                            Salario = 2200m
                        });
                });

            modelBuilder.Entity("MudBlazorApp.Entities.Funcionario", b =>
                {
                    b.HasOne("MudBlazorApp.Entities.Departamento", "Departamento")
                        .WithMany("Funcionarios")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("MudBlazorApp.Entities.Departamento", b =>
                {
                    b.Navigation("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}

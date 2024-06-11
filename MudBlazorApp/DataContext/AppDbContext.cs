using Microsoft.EntityFrameworkCore;
using MudBlazorApp.Entities;

namespace MudBlazorApp.DataContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Departamento>()
            .HasMany(d => d.Funcionarios)
            .WithOne(f => f.Departamento)
            .HasForeignKey(f => f.DepartamentoId);


        modelBuilder.Entity<Departamento>().HasData(
            new Departamento { DepartamentoId = 1, Nome = "Gestão" },
            new Departamento { DepartamentoId = 2, Nome = "Desenvolvimento" },
            new Departamento { DepartamentoId = 3, Nome = "Infraestrutura" },
            new Departamento { DepartamentoId = 4, Nome = "Qualidade" },
            new Departamento { DepartamentoId = 5, Nome = "Suporte" }
        );

        modelBuilder.Entity<Funcionario>().HasData(
            new Funcionario { FuncionarioId = 1, Nome = "José", Cargo = "Gerente", Salario = 7000, DepartamentoId = 1 },
            new Funcionario { FuncionarioId = 2, Nome = "Maria", Cargo = "Coordenadora", Salario = 6500, DepartamentoId = 1 },
            new Funcionario { FuncionarioId = 3, Nome = "Carlos", Cargo = "Desenvolvedor Sênior", Salario = 3500, DepartamentoId = 2 },
            new Funcionario { FuncionarioId = 4, Nome = "Ana", Cargo = "Desenvolvedora Pleno", Salario = 4200, DepartamentoId = 2 },
            new Funcionario { FuncionarioId = 5, Nome = "Pedro", Cargo = "Desenvolvedor Júnior", Salario = 2500, DepartamentoId = 2 },
            new Funcionario { FuncionarioId = 6, Nome = "Rafael", Cargo = "Analista de Infraestrutura", Salario = 4500, DepartamentoId = 3 },
            new Funcionario { FuncionarioId = 7, Nome = "Fernanda", Cargo = "Suporte Técnico", Salario = 3200, DepartamentoId = 3 },
            new Funcionario { FuncionarioId = 8, Nome = "Gabriel", Cargo = "Estagiário de Desenvolvimento", Salario = 1200, DepartamentoId = 2 },
            new Funcionario { FuncionarioId = 9, Nome = "Bruna", Cargo = "Estagiária de Infraestrutura", Salario = 1200, DepartamentoId = 3 },
            new Funcionario { FuncionarioId = 10, Nome = "Ricardo", Cargo = "Assistente Administrativo", Salario = 2200, DepartamentoId = 1 },
            new Funcionario { FuncionarioId = 11, Nome = "João", Cargo = "Analista de Suporte", Salario = 3800, DepartamentoId = 5 },
            new Funcionario { FuncionarioId = 12, Nome = "Mariana", Cargo = "Técnica de Suporte", Salario = 3000, DepartamentoId = 5 },
            new Funcionario { FuncionarioId = 13, Nome = "Lucas", Cargo = "Assistente de Suporte", Salario = 2500, DepartamentoId = 5 },
            new Funcionario { FuncionarioId = 14, Nome = "Carla", Cargo = "Analista de Qualidade", Salario = 4000, DepartamentoId = 4 },
            new Funcionario { FuncionarioId = 15, Nome = "Paulo", Cargo = "Técnico de Qualidade", Salario = 3200, DepartamentoId = 4 }
        );
    }
}

using System.ComponentModel.DataAnnotations;

namespace MudBlazorApp.Entities;

public class Funcionario
{
    public int FuncionarioId { get; set; }
    [MaxLength(100)]
    public string? Nome { get; set; }
    [MaxLength(50)]
    public string? Cargo { get; set; }
    public decimal Salario { get; set; }
    public Departamento? Departamento { get; set; }
    public int DepartamentoId { get; set; }
 
}

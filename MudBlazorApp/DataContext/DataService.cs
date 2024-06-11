using Microsoft.EntityFrameworkCore;
using MudBlazorApp.Entities;

namespace MudBlazorApp.DataContext;

public class DataService
{
    private readonly AppDbContext _context;

    public DataService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Funcionario>> GetFuncionariosAsync()
    {
        return await _context.Funcionarios.Include(f => f.Departamento).ToListAsync();
    }
    public async Task<List<Departamento>> GetDepartamentoAsync()
    {
        return await _context.Departamentos.ToListAsync();
    }

    public async Task<Dictionary<string, decimal>> GetSalariosPorDepartamentoAsync()
    {
        return await _context.Funcionarios
            .Include(f => f.Departamento!)
            .GroupBy(f => f.Departamento!.Nome!)
            .Select(g => new { Departamento = g.Key, TotalSalarios = g.Sum(f => f.Salario) })
            .ToDictionaryAsync(x => x.Departamento, x => x.TotalSalarios);
    }
  
}

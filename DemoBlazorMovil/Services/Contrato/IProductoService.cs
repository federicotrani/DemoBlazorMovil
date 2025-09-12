using DemoBlazorMovil.Models;

namespace DemoBlazorMovil.Services.Contrato;

public interface IProductoService
{
    Task<List<Producto>> GetAllAsync();
    Task<Producto> GetByIdAsync(int id);
}

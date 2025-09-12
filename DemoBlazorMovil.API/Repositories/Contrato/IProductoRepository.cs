using DemoBlazorMovil.Shared.Models;

namespace DemoBlazorMovil.API.Repositories.Contrato;

public interface IProductoRepository
{
    Task<List<Producto>> GetProductosAsync();
    Task<Producto> GetProductoByIdAsync(int id);
    Task AddProductoAsync(Producto producto);
    Task UpdateProductoAsync(Producto producto);
    Task DeleteProductoAsync(int id);
}

using DemoBlazorMovil.API.Data;
using DemoBlazorMovil.API.Repositories.Contrato;
using DemoBlazorMovil.Shared.Models;

namespace DemoBlazorMovil.API.Repositories.Implementa;

public class ProductoRepository : IProductoRepository
{
    private readonly DataContext _context;
    private readonly ILogger<ProductoRepository> _logger;

    public ProductoRepository(DataContext context, ILogger<ProductoRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public Task AddProductoAsync(Producto producto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteProductoAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Producto> GetProductoByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Producto>> GetProductosAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateProductoAsync(Producto producto)
    {
        throw new NotImplementedException();
    }
}

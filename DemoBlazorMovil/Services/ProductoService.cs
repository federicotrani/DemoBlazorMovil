using DemoBlazorMovil.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace DemoBlazorMovil.Services;

public class ProductoService
{
    private readonly HttpClient _httpClient;

    // public readonly List<Producto> lista;


    public ProductoService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.DefaultRequestHeaders.Accept.Clear();
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //lista = new List<Producto>()
        //{
        //    new Producto { Id = 1, Nombre = "Laptop", Descripcion = "Portátil 15''", Imagen = "img/generico.jpg", Precio = 1200.99m, Stock = 10 },
        //    new Producto { Id = 2, Nombre = "Smartphone", Descripcion = "Teléfono inteligente", Imagen = "img/generico.jpg", Precio = 799.50m, Stock = 25 },
        //    new Producto { Id = 3, Nombre = "Tablet", Descripcion = "Tablet 10''", Imagen = "img/generico.jpg", Precio = 450.00m, Stock = 15 },
        //    new Producto { Id = 4, Nombre = "Auriculares", Descripcion = "Auriculares inalámbricos", Imagen = "img/generico.jpg", Precio = 99.99m, Stock = 50 },
        //    new Producto { Id = 5, Nombre = "Monitor", Descripcion = "Monitor 24''", Imagen = "img/generico.jpg", Precio = 220.75m, Stock = 8 },
        //    new Producto { Id = 6, Nombre = "Teclado", Descripcion = "Teclado mecánico", Imagen = "img/generico.jpg", Precio = 65.00m, Stock = 30 },
        //    new Producto { Id = 7, Nombre = "Ratón", Descripcion = "Ratón óptico", Imagen = "img/generico.jpg", Precio = 25.99m, Stock = 40 },
        //    new Producto { Id = 8, Nombre = "Impresora", Descripcion = "Impresora multifunción", Imagen = "img/generico.jpg", Precio = 150.00m, Stock = 12 },
        //    new Producto { Id = 9, Nombre = "Altavoces", Descripcion = "Altavoces Bluetooth", Imagen = "img/generico.jpg", Precio = 45.50m, Stock = 20 },
        //    new Producto { Id = 10, Nombre = "Webcam", Descripcion = "Cámara web HD", Imagen = "img/generico.jpg", Precio = 39.99m, Stock = 18 }
        //};
    }



    public async Task<List<Producto>> GetProductosAsync()
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<List<Producto>>("api/productos");
        }
        catch (Exception ex)
        {

            throw new Exception();
        }
        
    }

    public async Task<Producto> GetProductoByIdAsync(int id)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<Producto>($"api/productos/{id}");
        }
        catch (Exception ex)
        {
            throw new Exception();
        }

    }



    //public List<Producto> GetProductos()
    //{
    //    return lista;
    //}

    //public Producto GetProducto(int id)
    //{
    //    return lista.FirstOrDefault(p => p.Id == id);
    //}

    //public void AddProducto(Producto producto)
    //{
    //    producto.Id = lista.Max(p => p.Id) + 1;
    //    lista.Add(producto);
    //}

}

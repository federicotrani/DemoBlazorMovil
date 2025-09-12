using DemoBlazorMovil.Shared.DTO;
using DemoBlazorMovil.Shared.Models;

namespace DemoBlazorMovil.API.Repositories.Contrato;

public interface IUsuarioRepository
{
    Task<Usuario> GetByIdAsync(int id);
    Task<IEnumerable<Usuario>> GetAllAsync();
    Task CreateAsync(Usuario usuario);
    Task UpdateAsync(Usuario usuario);
    Task DeleteAsync(int id);
    Task<SesionDTO> AuthenticateAsync(LoginDTO login);
}

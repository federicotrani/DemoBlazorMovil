
using DemoBlazorMovil.Shared.DTO;

namespace DemoBlazorMovil.Services.Contrato;

public interface IUsuarioService
{
    Task<SesionDTO> AuthenticateAsync(LoginDTO login);
}

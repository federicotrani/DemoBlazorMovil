using DemoBlazorMovil.Services.Contrato;
using DemoBlazorMovil.Shared.DTO;
using Microsoft.Extensions.Logging;
using System.Net.Http.Json;

namespace DemoBlazorMovil.Services.Implementa;

public class UsuarioService : IUsuarioService
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<UsuarioService> _logger;

    public UsuarioService(HttpClient httpClient, ILogger<UsuarioService> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    public async Task<SesionDTO> AuthenticateAsync(LoginDTO login)
    {
		try
		{
			var response = await _httpClient.PostAsJsonAsync("api/usuarios/authenticate", login);
			response.EnsureSuccessStatusCode();

			var result = await response.Content.ReadFromJsonAsync<SesionDTO>();
			return result;
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error en la autenticación");
			throw;
		}
    }
}

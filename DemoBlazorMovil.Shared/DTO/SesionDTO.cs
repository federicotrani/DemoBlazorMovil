namespace DemoBlazorMovil.Shared.DTO;

public class SesionDTO
{
    public required string Token { get; set; } = string.Empty;
    public required DateTime Expiracion { get; set; } = DateTime.Now.AddHours(24);
    public required string Email { get; set; } = string.Empty;
}

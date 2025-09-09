namespace DemoBlazorMovil.Services;

public class AlertaService
{
    public async Task MostrarAlerta(string titulo, string mensaje)
    {
        await Task.Delay(100); // Simulate some delay for demonstration purposes
        // Console.WriteLine($"Alerta: {titulo} - {mensaje}");
        await App.Current.MainPage.DisplayAlert(titulo, mensaje, "OK");
    }
}

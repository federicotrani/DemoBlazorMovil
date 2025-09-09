# DemoBlazorMovil

DemoBlazorMovil es una aplicación desarrollada con .NET MAUI y Blazor, diseñada para demostrar el uso de servicios, inyección de dependencias y consumo de APIs en una solución multiplataforma moderna.

## Características principales

- **.NET MAUI**: Permite ejecutar la aplicación en Android, iOS, Windows y Mac.
- **Blazor**: Interfaz de usuario basada en componentes Razor.
- **Inyección de dependencias**: Uso de servicios como `ProductoService` y `AlertaService`.
- **HttpClient**: Configurado para consumir APIs externas.
- **Soporte para desarrollo**: Incluye herramientas de desarrollador para Blazor en modo DEBUG.

## Estructura del proyecto

- `MauiProgram.cs`: Configuración principal de la aplicación, servicios e inyección de dependencias.
- `Services/ProductoService.cs`: Lógica para la gestión de productos.
- `Services/AlertaService.cs`: Lógica para la gestión de alertas.
- `wwwroot/`: Recursos estáticos (CSS, imágenes, etc.).
- `App.razor` y páginas Razor: Definición de la interfaz de usuario.

## Requisitos

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Visual Studio 2022 (con soporte para MAUI)
- Acceso a la API configurada en `https://localhost:7188`

## Ejecución

1. Clona el repositorio:
2. Abre la solución en Visual Studio 2022.
3. Selecciona la plataforma de destino (Android, Windows, etc.).
4. Ejecuta la aplicación (`F5`).

## Personalización

- Modifica la URL base de la API en `MauiProgram.cs` si es necesario.
- Agrega o modifica servicios en la carpeta `Services`.

## Licencia

Este proyecto se distribuye bajo la licencia MIT.
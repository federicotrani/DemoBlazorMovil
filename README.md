# DemoBlazorMovil

DemoBlazorMovil es una aplicaci�n desarrollada con .NET MAUI y Blazor, dise�ada para demostrar el uso de servicios, inyecci�n de dependencias y consumo de APIs en una soluci�n multiplataforma moderna.

## Caracter�sticas principales

- **.NET MAUI**: Permite ejecutar la aplicaci�n en Android, iOS, Windows y Mac.
- **Blazor**: Interfaz de usuario basada en componentes Razor.
- **Inyecci�n de dependencias**: Uso de servicios como `ProductoService` y `AlertaService`.
- **HttpClient**: Configurado para consumir APIs externas.
- **Soporte para desarrollo**: Incluye herramientas de desarrollador para Blazor en modo DEBUG.

## Estructura del proyecto

- `MauiProgram.cs`: Configuraci�n principal de la aplicaci�n, servicios e inyecci�n de dependencias.
- `Services/ProductoService.cs`: L�gica para la gesti�n de productos.
- `Services/AlertaService.cs`: L�gica para la gesti�n de alertas.
- `wwwroot/`: Recursos est�ticos (CSS, im�genes, etc.).
- `App.razor` y p�ginas Razor: Definici�n de la interfaz de usuario.

## Requisitos

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Visual Studio 2022 (con soporte para MAUI)
- Acceso a la API configurada en `https://localhost:7188`

## Ejecuci�n

1. Clona el repositorio:
2. Abre la soluci�n en Visual Studio 2022.
3. Selecciona la plataforma de destino (Android, Windows, etc.).
4. Ejecuta la aplicaci�n (`F5`).

## Personalizaci�n

- Modifica la URL base de la API en `MauiProgram.cs` si es necesario.
- Agrega o modifica servicios en la carpeta `Services`.

## Licencia

Este proyecto se distribuye bajo la licencia MIT.
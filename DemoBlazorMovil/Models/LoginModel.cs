﻿using System.ComponentModel.DataAnnotations;

namespace DemoBlazorMovil.Models;

public class LoginModel
{
    [Required(ErrorMessage = "El correo es obligatorio")]
    [EmailAddress(ErrorMessage = "Formato de correo inválido")]

    public string Email { get; set; } = string.Empty;
    [Required(ErrorMessage = "La contraseña es obligatoria")]

    public string Password { get; set; } = string.Empty;
    
}

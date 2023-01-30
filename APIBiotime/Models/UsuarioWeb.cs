using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class UsuarioWeb
{
    public string Rut { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Pass { get; set; } = null!;
}

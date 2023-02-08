using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class Historico
{
    public string? Id { get; set; }

    public string? Rut { get; set; }

    public string? Nombre { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Entrada { get; set; }

    public string? Salida { get; set; }

    public string? Procedencia { get; set; }
}

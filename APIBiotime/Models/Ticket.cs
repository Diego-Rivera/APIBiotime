using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class Ticket
{
    public int Id { get; set; }

    public string EmpCode { get; set; } = null!;

    public DateTime FechaTicket { get; set; }

    public DateOnly? DiaTicket { get; set; }

    public string UsuarioEmision { get; set; } = null!;

    public string? UsuarioMod { get; set; }

    public int EmpCodeRetira { get; set; }

    public int? Retirado { get; set; }

    public DateTime? FechaRetiroticket { get; set; }

    public int? Refuerzo { get; set; }

    public int? Nulo { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

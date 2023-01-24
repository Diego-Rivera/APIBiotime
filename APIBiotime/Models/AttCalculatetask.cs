using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttCalculatetask
{
    public int Id { get; set; }

    public int Emp { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? Event { get; set; }
}

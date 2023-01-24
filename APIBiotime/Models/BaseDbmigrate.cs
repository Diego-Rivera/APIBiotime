using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class BaseDbmigrate
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;
}

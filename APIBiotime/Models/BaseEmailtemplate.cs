using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class BaseEmailtemplate
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public int Category { get; set; }

    public int SubCategory { get; set; }

    public int Event { get; set; }

    public int Receiver { get; set; }

    public string? Subject { get; set; }

    public string Template { get; set; } = null!;

    public bool Enable { get; set; }
}

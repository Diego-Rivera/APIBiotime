using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PersonnelResign
{
    public int Id { get; set; }

    public DateOnly ResignDate { get; set; }

    public int? ResignType { get; set; }

    public bool Disableatt { get; set; }

    public string? Reason { get; set; }

    public int EmployeeId { get; set; }

    public virtual PersonnelEmployee Employee { get; set; } = null!;
}

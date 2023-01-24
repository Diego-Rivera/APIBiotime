using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PersonnelEmployeecustomattribute
{
    public int Id { get; set; }

    public string AttrName { get; set; } = null!;

    public short AttrType { get; set; }

    public string? AttrValue { get; set; }

    public bool Enable { get; set; }

    public bool IsUnique { get; set; }
}

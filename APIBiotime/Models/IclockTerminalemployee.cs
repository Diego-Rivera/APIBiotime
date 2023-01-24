using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class IclockTerminalemployee
{
    public int Id { get; set; }

    public string TerminalSn { get; set; } = null!;

    public string EmpCode { get; set; } = null!;

    public short Privilege { get; set; }
}

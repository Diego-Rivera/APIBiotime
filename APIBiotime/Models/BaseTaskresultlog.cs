using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class BaseTaskresultlog
{
    public int Id { get; set; }

    public string Task { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Result { get; set; } = null!;

    public DateTime Time { get; set; }
}

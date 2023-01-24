using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class BaseSystemlog
{
    public int Id { get; set; }

    public DateTime ExecuteTime { get; set; }

    public short Operation { get; set; }

    public short ExecuteStatus { get; set; }

    public string? Description { get; set; }
}

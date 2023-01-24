using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttTimeintervalBreakTime
{
    public int Id { get; set; }

    public int TimeintervalId { get; set; }

    public int BreaktimeId { get; set; }

    public virtual AttBreaktime Breaktime { get; set; } = null!;

    public virtual AttTimeinterval Timeinterval { get; set; } = null!;
}

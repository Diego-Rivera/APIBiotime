using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class BaseSendemail
{
    public int Id { get; set; }

    public int Purpose { get; set; }

    public string EmailTo { get; set; } = null!;

    public string? EmailCc { get; set; }

    public string? EmailBcc { get; set; }

    public string EmailSubject { get; set; } = null!;

    public string? EmailContent { get; set; }

    public DateTime? SendTime { get; set; }

    public short? SendStatus { get; set; }
}

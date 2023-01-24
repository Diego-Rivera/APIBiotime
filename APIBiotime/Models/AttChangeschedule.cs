using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttChangeschedule
{
    public int WorkflowinstancePtrId { get; set; }

    public DateOnly AttDate { get; set; }

    public string? PreviousTimeinterval { get; set; }

    public DateTime ApplyTime { get; set; }

    public string? ApplyReason { get; set; }

    public string? Attachment { get; set; }

    public int TimeintervalId { get; set; }

    public virtual AttTimeinterval Timeinterval { get; set; } = null!;

    public virtual WorkflowWorkflowinstance WorkflowinstancePtr { get; set; } = null!;
}

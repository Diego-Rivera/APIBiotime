using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttWebpunch
{
    public int WorkflowinstancePtrId { get; set; }

    public DateTime PunchTime { get; set; }

    public string PunchState { get; set; } = null!;

    public string? WorkCode { get; set; }

    public string? ApplyReason { get; set; }

    public DateTime ApplyTime { get; set; }

    public int VerifyType { get; set; }

    public virtual WorkflowWorkflowinstance WorkflowinstancePtr { get; set; } = null!;
}

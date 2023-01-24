using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttOvertime
{
    public int WorkflowinstancePtrId { get; set; }

    public short OvertimeType { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public string? ApplyReason { get; set; }

    public DateTime ApplyTime { get; set; }

    public string? Attachment { get; set; }

    public int? PayCodeId { get; set; }

    public virtual AttPaycode? PayCode { get; set; }

    public virtual WorkflowWorkflowinstance WorkflowinstancePtr { get; set; } = null!;
}

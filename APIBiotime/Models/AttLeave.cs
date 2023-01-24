using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttLeave
{
    public int WorkflowinstancePtrId { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public string? ApplyReason { get; set; }

    public DateTime ApplyTime { get; set; }

    public string? Attachment { get; set; }

    public int? PayCodeId { get; set; }

    public double LeaveDay { get; set; }

    public virtual ICollection<AttPayloadexception> AttPayloadexceptions { get; } = new List<AttPayloadexception>();

    public virtual AttPaycode? PayCode { get; set; }

    public virtual WorkflowWorkflowinstance WorkflowinstancePtr { get; set; } = null!;
}

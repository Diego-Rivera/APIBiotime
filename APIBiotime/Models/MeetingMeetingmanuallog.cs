using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class MeetingMeetingmanuallog
{
    public int WorkflowinstancePtrId { get; set; }

    public DateTime PunchTime { get; set; }

    public string PunchState { get; set; } = null!;

    public string ApplyReason { get; set; } = null!;

    public DateTime ApplyTime { get; set; }

    public int? MeetingId { get; set; }

    public virtual MeetingMeetingentity? Meeting { get; set; }

    public virtual WorkflowWorkflowinstance WorkflowinstancePtr { get; set; } = null!;
}

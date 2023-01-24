using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class WorkflowWorkflowinstance
{
    public int Id { get; set; }

    public DateTime? ApprovalTime { get; set; }

    public short ApprovalStatus { get; set; }

    public string? ApprovalRemark { get; set; }

    public string? Approver { get; set; }

    public string? ApproverInstance { get; set; }

    public int EmployeeId { get; set; }

    public int? WorkflowEngineId { get; set; }

    public virtual AttChangeschedule? AttChangeschedule { get; set; }

    public virtual AttLeave? AttLeave { get; set; }

    public virtual AttManuallog? AttManuallog { get; set; }

    public virtual AttOvertime? AttOvertime { get; set; }

    public virtual AttTraining? AttTraining { get; set; }

    public virtual AttWebpunch? AttWebpunch { get; set; }

    public virtual PersonnelEmployee Employee { get; set; } = null!;

    public virtual MeetingMeetingentity? MeetingMeetingentity { get; set; }

    public virtual MeetingMeetingmanuallog? MeetingMeetingmanuallog { get; set; }

    public virtual VisitorReservation? VisitorReservation { get; set; }

    public virtual WorkflowWorkflowengine? WorkflowEngine { get; set; }

    public virtual ICollection<WorkflowNodeinstance> WorkflowNodeinstances { get; } = new List<WorkflowNodeinstance>();
}

using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class WorkflowNodeinstance
{
    public int Id { get; set; }

    public string NodeName { get; set; } = null!;

    public int OrderId { get; set; }

    public short ApprovalStatus { get; set; }

    public DateTime? ApprovalTime { get; set; }

    public string? ApprovalRemark { get; set; }

    public bool Active { get; set; }

    public bool Targeted { get; set; }

    public int? ApproverEmployeeId { get; set; }

    public int? WorkflowInstanceId { get; set; }

    public int? WorkflowNodeId { get; set; }

    public virtual PersonnelEmployee? ApproverEmployee { get; set; }

    public virtual WorkflowWorkflowinstance? WorkflowInstance { get; set; }

    public virtual WorkflowWorkflownode? WorkflowNode { get; set; }
}

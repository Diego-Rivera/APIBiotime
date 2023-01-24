using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class WorkflowWorkflownode
{
    public int Id { get; set; }

    public string NodeName { get; set; } = null!;

    public int OrderId { get; set; }

    public bool ApproverByOverall { get; set; }

    public bool NotifyByOverall { get; set; }

    public int? WorkflowEngineId { get; set; }

    public virtual WorkflowWorkflowengine? WorkflowEngine { get; set; }

    public virtual ICollection<WorkflowNodeinstance> WorkflowNodeinstances { get; } = new List<WorkflowNodeinstance>();

    public virtual ICollection<WorkflowWorkflownodeApprover> WorkflowWorkflownodeApprovers { get; } = new List<WorkflowWorkflownodeApprover>();

    public virtual ICollection<WorkflowWorkflownodeNotifier> WorkflowWorkflownodeNotifiers { get; } = new List<WorkflowWorkflownodeNotifier>();
}

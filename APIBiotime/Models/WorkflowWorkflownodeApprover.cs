using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class WorkflowWorkflownodeApprover
{
    public int Id { get; set; }

    public int WorkflownodeId { get; set; }

    public int WorkflowroleId { get; set; }

    public virtual WorkflowWorkflownode Workflownode { get; set; } = null!;

    public virtual WorkflowWorkflowrole Workflowrole { get; set; } = null!;
}

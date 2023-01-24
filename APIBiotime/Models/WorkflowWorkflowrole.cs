using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class WorkflowWorkflowrole
{
    public int Id { get; set; }

    public string RoleCode { get; set; } = null!;

    public string RoleName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<PersonnelEmployeeFlowRole> PersonnelEmployeeFlowRoles { get; } = new List<PersonnelEmployeeFlowRole>();

    public virtual ICollection<WorkflowWorkflownodeApprover> WorkflowWorkflownodeApprovers { get; } = new List<WorkflowWorkflownodeApprover>();

    public virtual ICollection<WorkflowWorkflownodeNotifier> WorkflowWorkflownodeNotifiers { get; } = new List<WorkflowWorkflownodeNotifier>();
}

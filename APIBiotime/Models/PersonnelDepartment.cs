using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PersonnelDepartment
{
    public int Id { get; set; }

    public string DeptCode { get; set; } = null!;

    public string DeptName { get; set; } = null!;

    public bool IsDefault { get; set; }

    public int? ParentDeptId { get; set; }

    public int? DeptManagerId { get; set; }

    public int CompanyId { get; set; }

    public virtual ICollection<AttDepartmentpolicy> AttDepartmentpolicies { get; } = new List<AttDepartmentpolicy>();

    public virtual ICollection<AttDepartmentschedule> AttDepartmentschedules { get; } = new List<AttDepartmentschedule>();

    public virtual ICollection<AttDeptattrule> AttDeptattrules { get; } = new List<AttDeptattrule>();

    public virtual ICollection<AttHoliday> AttHolidays { get; } = new List<AttHoliday>();

    public virtual ICollection<AuthUserAuthDept> AuthUserAuthDepts { get; } = new List<AuthUserAuthDept>();

    public virtual ICollection<BaseLinenotifysetting> BaseLinenotifysettings { get; } = new List<BaseLinenotifysetting>();

    public virtual PersonnelCompany Company { get; set; } = null!;

    public virtual PersonnelEmployee? DeptManager { get; set; }

    public virtual ICollection<PersonnelDepartment> InverseParentDept { get; } = new List<PersonnelDepartment>();

    public virtual ICollection<MobileGpsfordepartment> MobileGpsfordepartments { get; } = new List<MobileGpsfordepartment>();

    public virtual PersonnelDepartment? ParentDept { get; set; }

    public virtual ICollection<PersonnelEmployee> PersonnelEmployees { get; } = new List<PersonnelEmployee>();

    public virtual ICollection<VisitorReservation> VisitorReservations { get; } = new List<VisitorReservation>();

    public virtual ICollection<VisitorVisitor> VisitorVisitors { get; } = new List<VisitorVisitor>();

    public virtual ICollection<WorkflowWorkflowengine> WorkflowWorkflowengines { get; } = new List<WorkflowWorkflowengine>();
}

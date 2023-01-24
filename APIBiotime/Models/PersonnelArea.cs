using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PersonnelArea
{
    public int Id { get; set; }

    public string AreaCode { get; set; } = null!;

    public string AreaName { get; set; } = null!;

    public bool IsDefault { get; set; }

    public int? ParentAreaId { get; set; }

    public int CompanyId { get; set; }

    public virtual ICollection<AccAcccombination> AccAcccombinations { get; } = new List<AccAcccombination>();

    public virtual ICollection<AccAccgroup> AccAccgroups { get; } = new List<AccAccgroup>();

    public virtual ICollection<AccAccholiday> AccAccholidays { get; } = new List<AccAccholiday>();

    public virtual ICollection<AccAccprivilege> AccAccprivileges { get; } = new List<AccAccprivilege>();

    public virtual ICollection<AccAcctimezone> AccAcctimezones { get; } = new List<AccAcctimezone>();

    public virtual ICollection<AuthUserAuthArea> AuthUserAuthAreas { get; } = new List<AuthUserAuthArea>();

    public virtual PersonnelCompany Company { get; set; } = null!;

    public virtual ICollection<IclockTerminal> IclockTerminals { get; } = new List<IclockTerminal>();

    public virtual ICollection<PersonnelArea> InverseParentArea { get; } = new List<PersonnelArea>();

    public virtual PersonnelArea? ParentArea { get; set; }

    public virtual ICollection<PersonnelAssignareaemployee> PersonnelAssignareaemployees { get; } = new List<PersonnelAssignareaemployee>();

    public virtual ICollection<PersonnelEmployeeArea> PersonnelEmployeeAreas { get; } = new List<PersonnelEmployeeArea>();

    public virtual ICollection<VisitorVisitorArea> VisitorVisitorAreas { get; } = new List<VisitorVisitorArea>();
}

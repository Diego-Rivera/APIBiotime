using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PersonnelCompany
{
    public int Id { get; set; }

    public string CompanyCode { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public bool IsDefault { get; set; }

    public virtual ICollection<BaseAutoimporttask> BaseAutoimporttasks { get; } = new List<BaseAutoimporttask>();

    public virtual ICollection<IclockTerminalworkcode> IclockTerminalworkcodes { get; } = new List<IclockTerminalworkcode>();

    public virtual ICollection<PersonnelArea> PersonnelAreas { get; } = new List<PersonnelArea>();

    public virtual ICollection<PersonnelDepartment> PersonnelDepartments { get; } = new List<PersonnelDepartment>();

    public virtual ICollection<PersonnelPosition> PersonnelPositions { get; } = new List<PersonnelPosition>();
}

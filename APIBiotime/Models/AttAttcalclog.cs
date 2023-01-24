using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttAttcalclog
{
    public int Id { get; set; }

    public int? DeptId { get; set; }

    public int? EmpId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime UpdateTime { get; set; }

    public int LogType { get; set; }
}

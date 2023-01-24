using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PayrollEmppayrollprofile
{
    public int Id { get; set; }

    public short? PaymentMode { get; set; }

    public short? PaymentType { get; set; }

    public string? BankName { get; set; }

    public string? BankAccount { get; set; }

    public string? PersonnelId { get; set; }

    public string? AgentId { get; set; }

    public string? AgentAccount { get; set; }

    public int EmployeeId { get; set; }
}

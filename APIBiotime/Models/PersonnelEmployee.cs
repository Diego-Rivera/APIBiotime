using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PersonnelEmployee
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string EmpCode { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Nickname { get; set; }

    public string? Passport { get; set; }

    public string? DriverLicenseAutomobile { get; set; }

    public string? DriverLicenseMotorcycle { get; set; }

    public string? Photo { get; set; }

    public string? SelfPassword { get; set; }

    public string? DevicePassword { get; set; }

    public int? DevPrivilege { get; set; }

    public string? CardNo { get; set; }

    public string? AccGroup { get; set; }

    public string? AccTimezone { get; set; }

    public string? Gender { get; set; }

    public DateOnly? Birthday { get; set; }

    public string? Address { get; set; }

    public string? Postcode { get; set; }

    public string? OfficeTel { get; set; }

    public string? ContactTel { get; set; }

    public string? Mobile { get; set; }

    public string? National { get; set; }

    public string? Religion { get; set; }

    public string? Title { get; set; }

    public string? EnrollSn { get; set; }

    public string? Ssn { get; set; }

    public DateTime? UpdateTime { get; set; }

    public DateOnly? HireDate { get; set; }

    public int? VerifyMode { get; set; }

    public string? City { get; set; }

    public bool IsAdmin { get; set; }

    public short? EmpType { get; set; }

    public bool EnablePayroll { get; set; }

    public bool Deleted { get; set; }

    public int? Reserved { get; set; }

    public int? DelTag { get; set; }

    public short? AppStatus { get; set; }

    public short? AppRole { get; set; }

    public string? Email { get; set; }

    public DateTime? LastLogin { get; set; }

    public bool IsActive { get; set; }

    public string? SessionKey { get; set; }

    public string? LoginIp { get; set; }

    public int? DepartmentId { get; set; }

    public int? PositionId { get; set; }

    public virtual ICollection<AttAttschedule> AttAttschedules { get; } = new List<AttAttschedule>();

    public virtual ICollection<AttLeaveyearbalance> AttLeaveyearbalances { get; } = new List<AttLeaveyearbalance>();

    public virtual ICollection<AttPayloadbase> AttPayloadbases { get; } = new List<AttPayloadbase>();

    public virtual ICollection<AttPayloadeffectpunch> AttPayloadeffectpunches { get; } = new List<AttPayloadeffectpunch>();

    public virtual ICollection<AttPayloadmulpunchset> AttPayloadmulpunchsets { get; } = new List<AttPayloadmulpunchset>();

    public virtual ICollection<AttPayloadparing> AttPayloadparings { get; } = new List<AttPayloadparing>();

    public virtual ICollection<AttPayloadpaycode> AttPayloadpaycodes { get; } = new List<AttPayloadpaycode>();

    public virtual ICollection<AttPayloadpunch> AttPayloadpunches { get; } = new List<AttPayloadpunch>();

    public virtual ICollection<AttReporttemplate> AttReporttemplates { get; } = new List<AttReporttemplate>();

    public virtual ICollection<AttTemporaryschedule> AttTemporaryschedules { get; } = new List<AttTemporaryschedule>();

    public virtual ICollection<AttTempschedule> AttTempschedules { get; } = new List<AttTempschedule>();

    public virtual PersonnelDepartment? Department { get; set; }

    public virtual ICollection<EpEptransaction> EpEptransactions { get; } = new List<EpEptransaction>();

    public virtual ICollection<IclockBiophoto> IclockBiophotos { get; } = new List<IclockBiophoto>();

    public virtual ICollection<IclockPrivatemessage> IclockPrivatemessages { get; } = new List<IclockPrivatemessage>();

    public virtual ICollection<MeetingMeetingentityAttender> MeetingMeetingentityAttenders { get; } = new List<MeetingMeetingentityAttender>();

    public virtual ICollection<MeetingMeetingpayloadbase> MeetingMeetingpayloadbases { get; } = new List<MeetingMeetingpayloadbase>();

    public virtual ICollection<MeetingMeetingtransaction> MeetingMeetingtransactions { get; } = new List<MeetingMeetingtransaction>();

    public virtual ICollection<MobileAnnouncement> MobileAnnouncementInitSenders { get; } = new List<MobileAnnouncement>();

    public virtual ICollection<MobileAnnouncement> MobileAnnouncementReceivers { get; } = new List<MobileAnnouncement>();

    public virtual ICollection<MobileAppnotification> MobileAppnotificationInitSenders { get; } = new List<MobileAppnotification>();

    public virtual ICollection<MobileAppnotification> MobileAppnotificationReceivers { get; } = new List<MobileAppnotification>();

    public virtual ICollection<MobileGpsforemployee> MobileGpsforemployees { get; } = new List<MobileGpsforemployee>();

    public virtual ICollection<MobileMobileapirequestlog> MobileMobileapirequestlogs { get; } = new List<MobileMobileapirequestlog>();

    public virtual ICollection<PayrollEmploan> PayrollEmploans { get; } = new List<PayrollEmploan>();

    public virtual ICollection<PayrollExtradeduction> PayrollExtradeductions { get; } = new List<PayrollExtradeduction>();

    public virtual ICollection<PayrollExtraincrease> PayrollExtraincreases { get; } = new List<PayrollExtraincrease>();

    public virtual ICollection<PayrollPayrollpayload> PayrollPayrollpayloads { get; } = new List<PayrollPayrollpayload>();

    public virtual ICollection<PayrollReimbursement> PayrollReimbursements { get; } = new List<PayrollReimbursement>();

    public virtual ICollection<PayrollSalaryadvance> PayrollSalaryadvances { get; } = new List<PayrollSalaryadvance>();

    public virtual ICollection<PayrollSalarystructure> PayrollSalarystructures { get; } = new List<PayrollSalarystructure>();

    public virtual ICollection<PersonnelAssignareaemployee> PersonnelAssignareaemployees { get; } = new List<PersonnelAssignareaemployee>();

    public virtual ICollection<PersonnelDepartment> PersonnelDepartments { get; } = new List<PersonnelDepartment>();

    public virtual ICollection<PersonnelEmployeeFlowRole> PersonnelEmployeeFlowRoles { get; } = new List<PersonnelEmployeeFlowRole>();

    public virtual ICollection<PersonnelEmployeecalendar> PersonnelEmployeecalendars { get; } = new List<PersonnelEmployeecalendar>();

    public virtual ICollection<PersonnelEmployeecertification> PersonnelEmployeecertifications { get; } = new List<PersonnelEmployeecertification>();

    public virtual PersonnelEmployeeextrainfo? PersonnelEmployeeextrainfo { get; set; }

    public virtual ICollection<PersonnelEmployeeleavebalance> PersonnelEmployeeleavebalances { get; } = new List<PersonnelEmployeeleavebalance>();

    public virtual PersonnelEmployment? PersonnelEmployment { get; set; }

    public virtual PersonnelResign? PersonnelResign { get; set; }

    public virtual PersonnelPosition? Position { get; set; }

    public virtual StaffStafftoken? StaffStafftoken { get; set; }

    public virtual ICollection<VisitorVisitor> VisitorVisitors { get; } = new List<VisitorVisitor>();

    public virtual ICollection<WorkflowNodeinstance> WorkflowNodeinstances { get; } = new List<WorkflowNodeinstance>();

    public virtual ICollection<WorkflowWorkflowengineEmployee> WorkflowWorkflowengineEmployees { get; } = new List<WorkflowWorkflowengineEmployee>();

    public virtual ICollection<WorkflowWorkflowinstance> WorkflowWorkflowinstances { get; } = new List<WorkflowWorkflowinstance>();
}

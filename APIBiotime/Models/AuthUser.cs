using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AuthUser
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime? UpdateTime { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? EmpPin { get; set; }

    public string Email { get; set; } = null!;

    public string? TelePhone { get; set; }

    public int? AuthTimeDept { get; set; }

    public int? LoginId { get; set; }

    public int? LoginType { get; set; }

    public int? LoginCount { get; set; }

    public bool IsStaff { get; set; }

    public bool IsActive { get; set; }

    public bool IsSuperuser { get; set; }

    public bool IsPublic { get; set; }

    public bool CanManageAllDept { get; set; }

    public int? DelFlag { get; set; }

    public DateTime DateJoined { get; set; }

    public DateTime? LastLogin { get; set; }

    public string? SessionKey { get; set; }

    public string? LoginIp { get; set; }

    public string? Photo { get; set; }

    public virtual ICollection<AccountsAdminbiodatum> AccountsAdminbiodata { get; } = new List<AccountsAdminbiodatum>();

    public virtual ICollection<AttReporttemplate> AttReporttemplates { get; } = new List<AttReporttemplate>();

    public virtual ICollection<AuthUserAuthArea> AuthUserAuthAreas { get; } = new List<AuthUserAuthArea>();

    public virtual ICollection<AuthUserAuthDept> AuthUserAuthDepts { get; } = new List<AuthUserAuthDept>();

    public virtual ICollection<AuthUserGroup> AuthUserGroups { get; } = new List<AuthUserGroup>();

    public virtual ICollection<AuthUserUserPermission> AuthUserUserPermissions { get; } = new List<AuthUserUserPermission>();

    public virtual ICollection<BaseAdminlog> BaseAdminlogs { get; } = new List<BaseAdminlog>();

    public virtual ICollection<BaseApilog> BaseApilogs { get; } = new List<BaseApilog>();

    public virtual ICollection<BaseBookmark> BaseBookmarks { get; } = new List<BaseBookmark>();

    public virtual ICollection<DjangoAdminLog> DjangoAdminLogs { get; } = new List<DjangoAdminLog>();

    public virtual ICollection<GuardianUserobjectpermission> GuardianUserobjectpermissions { get; } = new List<GuardianUserobjectpermission>();

    public virtual ICollection<MobileAnnouncement> MobileAnnouncements { get; } = new List<MobileAnnouncement>();

    public virtual ICollection<MobileAppnotification> MobileAppnotifications { get; } = new List<MobileAppnotification>();

    public virtual ICollection<RestFrameworkTrackingApirequestlog> RestFrameworkTrackingApirequestlogs { get; } = new List<RestFrameworkTrackingApirequestlog>();
}

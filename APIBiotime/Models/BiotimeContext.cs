using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace APIBiotime.Models;

public partial class BiotimeContext : DbContext
{
    public BiotimeContext()
    {
    }

    public BiotimeContext(DbContextOptions<BiotimeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccAcccombination> AccAcccombinations { get; set; }

    public virtual DbSet<AccAccgroup> AccAccgroups { get; set; }

    public virtual DbSet<AccAccholiday> AccAccholidays { get; set; }

    public virtual DbSet<AccAccprivilege> AccAccprivileges { get; set; }

    public virtual DbSet<AccAccterminal> AccAccterminals { get; set; }

    public virtual DbSet<AccAcctimezone> AccAcctimezones { get; set; }

    public virtual DbSet<AccountsAdminbiodatum> AccountsAdminbiodata { get; set; }

    public virtual DbSet<AccountsUsernotification> AccountsUsernotifications { get; set; }

    public virtual DbSet<AttAttcalclog> AttAttcalclogs { get; set; }

    public virtual DbSet<AttAttcode> AttAttcodes { get; set; }

    public virtual DbSet<AttAttemployee> AttAttemployees { get; set; }

    public virtual DbSet<AttAttgroup> AttAttgroups { get; set; }

    public virtual DbSet<AttAttpolicy> AttAttpolicies { get; set; }

    public virtual DbSet<AttAttreportsetting> AttAttreportsettings { get; set; }

    public virtual DbSet<AttAttrule> AttAttrules { get; set; }

    public virtual DbSet<AttAttschedule> AttAttschedules { get; set; }

    public virtual DbSet<AttAttshift> AttAttshifts { get; set; }

    public virtual DbSet<AttBreaktime> AttBreaktimes { get; set; }

    public virtual DbSet<AttCalculatelastdate> AttCalculatelastdates { get; set; }

    public virtual DbSet<AttCalculatetask> AttCalculatetasks { get; set; }

    public virtual DbSet<AttChangeschedule> AttChangeschedules { get; set; }

    public virtual DbSet<AttDepartmentpolicy> AttDepartmentpolicies { get; set; }

    public virtual DbSet<AttDepartmentschedule> AttDepartmentschedules { get; set; }

    public virtual DbSet<AttDeptattrule> AttDeptattrules { get; set; }

    public virtual DbSet<AttGrouppolicy> AttGrouppolicies { get; set; }

    public virtual DbSet<AttGroupschedule> AttGroupschedules { get; set; }

    public virtual DbSet<AttHoliday> AttHolidays { get; set; }

    public virtual DbSet<AttLeave> AttLeaves { get; set; }

    public virtual DbSet<AttLeavegroup> AttLeavegroups { get; set; }

    public virtual DbSet<AttLeavegroupdetail> AttLeavegroupdetails { get; set; }

    public virtual DbSet<AttLeaveyearbalance> AttLeaveyearbalances { get; set; }

    public virtual DbSet<AttManuallog> AttManuallogs { get; set; }

    public virtual DbSet<AttOvertime> AttOvertimes { get; set; }

    public virtual DbSet<AttOvertimepolicy> AttOvertimepolicies { get; set; }

    public virtual DbSet<AttPaycode> AttPaycodes { get; set; }

    public virtual DbSet<AttPayloadattcode> AttPayloadattcodes { get; set; }

    public virtual DbSet<AttPayloadbase> AttPayloadbases { get; set; }

    public virtual DbSet<AttPayloadbreak> AttPayloadbreaks { get; set; }

    public virtual DbSet<AttPayloadeffectpunch> AttPayloadeffectpunches { get; set; }

    public virtual DbSet<AttPayloadexception> AttPayloadexceptions { get; set; }

    public virtual DbSet<AttPayloadmulpunchset> AttPayloadmulpunchsets { get; set; }

    public virtual DbSet<AttPayloadovertime> AttPayloadovertimes { get; set; }

    public virtual DbSet<AttPayloadparing> AttPayloadparings { get; set; }

    public virtual DbSet<AttPayloadpaycode> AttPayloadpaycodes { get; set; }

    public virtual DbSet<AttPayloadpunch> AttPayloadpunches { get; set; }

    public virtual DbSet<AttPayloadtimecard> AttPayloadtimecards { get; set; }

    public virtual DbSet<AttReportparam> AttReportparams { get; set; }

    public virtual DbSet<AttReporttemplate> AttReporttemplates { get; set; }

    public virtual DbSet<AttShiftdetail> AttShiftdetails { get; set; }

    public virtual DbSet<AttTemporaryschedule> AttTemporaryschedules { get; set; }

    public virtual DbSet<AttTempschedule> AttTempschedules { get; set; }

    public virtual DbSet<AttTimeinterval> AttTimeintervals { get; set; }

    public virtual DbSet<AttTimeintervalBreakTime> AttTimeintervalBreakTimes { get; set; }

    public virtual DbSet<AttTraining> AttTrainings { get; set; }

    public virtual DbSet<AttWebpunch> AttWebpunches { get; set; }

    public virtual DbSet<Attparam> Attparams { get; set; }

    public virtual DbSet<AuthGroup> AuthGroups { get; set; }

    public virtual DbSet<AuthGroupPermission> AuthGroupPermissions { get; set; }

    public virtual DbSet<AuthPermission> AuthPermissions { get; set; }

    public virtual DbSet<AuthUser> AuthUsers { get; set; }

    public virtual DbSet<AuthUserAuthArea> AuthUserAuthAreas { get; set; }

    public virtual DbSet<AuthUserAuthDept> AuthUserAuthDepts { get; set; }

    public virtual DbSet<AuthUserGroup> AuthUserGroups { get; set; }

    public virtual DbSet<AuthUserProfile> AuthUserProfiles { get; set; }

    public virtual DbSet<AuthUserUserPermission> AuthUserUserPermissions { get; set; }

    public virtual DbSet<AuthtokenToken> AuthtokenTokens { get; set; }

    public virtual DbSet<BaseAdminlog> BaseAdminlogs { get; set; }

    public virtual DbSet<BaseApilog> BaseApilogs { get; set; }

    public virtual DbSet<BaseAttparamdept> BaseAttparamdepts { get; set; }

    public virtual DbSet<BaseAutoattexporttask> BaseAutoattexporttasks { get; set; }

    public virtual DbSet<BaseAutoexporttask> BaseAutoexporttasks { get; set; }

    public virtual DbSet<BaseAutoimporttask> BaseAutoimporttasks { get; set; }

    public virtual DbSet<BaseBookmark> BaseBookmarks { get; set; }

    public virtual DbSet<BaseDbbackuplog> BaseDbbackuplogs { get; set; }

    public virtual DbSet<BaseDbmigrate> BaseDbmigrates { get; set; }

    public virtual DbSet<BaseEmailtemplate> BaseEmailtemplates { get; set; }

    public virtual DbSet<BaseEventalertsetting> BaseEventalertsettings { get; set; }

    public virtual DbSet<BaseLinenotifysetting> BaseLinenotifysettings { get; set; }

    public virtual DbSet<BaseSecuritypolicy> BaseSecuritypolicies { get; set; }

    public virtual DbSet<BaseSendemail> BaseSendemails { get; set; }

    public virtual DbSet<BaseSftpsetting> BaseSftpsettings { get; set; }

    public virtual DbSet<BaseSysparam> BaseSysparams { get; set; }

    public virtual DbSet<BaseSysparamdept> BaseSysparamdepts { get; set; }

    public virtual DbSet<BaseSystemlog> BaseSystemlogs { get; set; }

    public virtual DbSet<BaseSystemsetting> BaseSystemsettings { get; set; }

    public virtual DbSet<BaseTaskresultlog> BaseTaskresultlogs { get; set; }

    public virtual DbSet<DjangoAdminLog> DjangoAdminLogs { get; set; }

    public virtual DbSet<DjangoCeleryBeatClockedschedule> DjangoCeleryBeatClockedschedules { get; set; }

    public virtual DbSet<DjangoCeleryBeatCrontabschedule> DjangoCeleryBeatCrontabschedules { get; set; }

    public virtual DbSet<DjangoCeleryBeatIntervalschedule> DjangoCeleryBeatIntervalschedules { get; set; }

    public virtual DbSet<DjangoCeleryBeatPeriodictask> DjangoCeleryBeatPeriodictasks { get; set; }

    public virtual DbSet<DjangoCeleryBeatPeriodictask1> DjangoCeleryBeatPeriodictasks1 { get; set; }

    public virtual DbSet<DjangoCeleryBeatSolarschedule> DjangoCeleryBeatSolarschedules { get; set; }

    public virtual DbSet<DjangoContentType> DjangoContentTypes { get; set; }

    public virtual DbSet<DjangoMigration> DjangoMigrations { get; set; }

    public virtual DbSet<DjangoSession> DjangoSessions { get; set; }

    public virtual DbSet<EpEpsetup> EpEpsetups { get; set; }

    public virtual DbSet<EpEptransaction> EpEptransactions { get; set; }

    public virtual DbSet<GuardianGroupobjectpermission> GuardianGroupobjectpermissions { get; set; }

    public virtual DbSet<GuardianUserobjectpermission> GuardianUserobjectpermissions { get; set; }

    public virtual DbSet<IclockBiodatum> IclockBiodata { get; set; }

    public virtual DbSet<IclockBiophoto> IclockBiophotos { get; set; }

    public virtual DbSet<IclockDevicemoduleconfig> IclockDevicemoduleconfigs { get; set; }

    public virtual DbSet<IclockErrorcommandlog> IclockErrorcommandlogs { get; set; }

    public virtual DbSet<IclockPrivatemessage> IclockPrivatemessages { get; set; }

    public virtual DbSet<IclockPublicmessage> IclockPublicmessages { get; set; }

    public virtual DbSet<IclockShortmessage> IclockShortmessages { get; set; }

    public virtual DbSet<IclockTerminal> IclockTerminals { get; set; }

    public virtual DbSet<IclockTerminalcommand> IclockTerminalcommands { get; set; }

    public virtual DbSet<IclockTerminalcommandlog> IclockTerminalcommandlogs { get; set; }

    public virtual DbSet<IclockTerminalemployee> IclockTerminalemployees { get; set; }

    public virtual DbSet<IclockTerminallog> IclockTerminallogs { get; set; }

    public virtual DbSet<IclockTerminalparameter> IclockTerminalparameters { get; set; }

    public virtual DbSet<IclockTerminaluploadlog> IclockTerminaluploadlogs { get; set; }

    public virtual DbSet<IclockTerminalworkcode> IclockTerminalworkcodes { get; set; }

    public virtual DbSet<IclockTransaction> IclockTransactions { get; set; }

    public virtual DbSet<IclockTransactionproofcmd> IclockTransactionproofcmds { get; set; }

    public virtual DbSet<IclockVisitorbiodatum> IclockVisitorbiodata { get; set; }

    public virtual DbSet<MeetingMeetingentity> MeetingMeetingentities { get; set; }

    public virtual DbSet<MeetingMeetingentityAttender> MeetingMeetingentityAttenders { get; set; }

    public virtual DbSet<MeetingMeetingmanuallog> MeetingMeetingmanuallogs { get; set; }

    public virtual DbSet<MeetingMeetingpayloadbase> MeetingMeetingpayloadbases { get; set; }

    public virtual DbSet<MeetingMeetingroom> MeetingMeetingrooms { get; set; }

    public virtual DbSet<MeetingMeetingroomdevice> MeetingMeetingroomdevices { get; set; }

    public virtual DbSet<MeetingMeetingtransaction> MeetingMeetingtransactions { get; set; }

    public virtual DbSet<MobileAnnouncement> MobileAnnouncements { get; set; }

    public virtual DbSet<MobileAppactionlog> MobileAppactionlogs { get; set; }

    public virtual DbSet<MobileApplist> MobileApplists { get; set; }

    public virtual DbSet<MobileAppnotification> MobileAppnotifications { get; set; }

    public virtual DbSet<MobileGpsfordepartment> MobileGpsfordepartments { get; set; }

    public virtual DbSet<MobileGpsfordepartmentLocation> MobileGpsfordepartmentLocations { get; set; }

    public virtual DbSet<MobileGpsforemployee> MobileGpsforemployees { get; set; }

    public virtual DbSet<MobileGpsforemployeeLocation> MobileGpsforemployeeLocations { get; set; }

    public virtual DbSet<MobileGpslocation> MobileGpslocations { get; set; }

    public virtual DbSet<MobileMobileapirequestlog> MobileMobileapirequestlogs { get; set; }

    public virtual DbSet<PayrollDeductionformula> PayrollDeductionformulas { get; set; }

    public virtual DbSet<PayrollEmploan> PayrollEmploans { get; set; }

    public virtual DbSet<PayrollEmppayrollprofile> PayrollEmppayrollprofiles { get; set; }

    public virtual DbSet<PayrollExceptionformula> PayrollExceptionformulas { get; set; }

    public virtual DbSet<PayrollExtradeduction> PayrollExtradeductions { get; set; }

    public virtual DbSet<PayrollExtraincrease> PayrollExtraincreases { get; set; }

    public virtual DbSet<PayrollIncreasementformula> PayrollIncreasementformulas { get; set; }

    public virtual DbSet<PayrollLeaveformula> PayrollLeaveformulas { get; set; }

    public virtual DbSet<PayrollOvertimeformula> PayrollOvertimeformulas { get; set; }

    public virtual DbSet<PayrollPayrollpayload> PayrollPayrollpayloads { get; set; }

    public virtual DbSet<PayrollPayrollpayloadpaycode> PayrollPayrollpayloadpaycodes { get; set; }

    public virtual DbSet<PayrollReimbursement> PayrollReimbursements { get; set; }

    public virtual DbSet<PayrollSalaryadvance> PayrollSalaryadvances { get; set; }

    public virtual DbSet<PayrollSalarystructure> PayrollSalarystructures { get; set; }

    public virtual DbSet<PayrollSalarystructureDeductionformula> PayrollSalarystructureDeductionformulas { get; set; }

    public virtual DbSet<PayrollSalarystructureExceptionformula> PayrollSalarystructureExceptionformulas { get; set; }

    public virtual DbSet<PayrollSalarystructureIncreasementformula> PayrollSalarystructureIncreasementformulas { get; set; }

    public virtual DbSet<PayrollSalarystructureLeaveformula> PayrollSalarystructureLeaveformulas { get; set; }

    public virtual DbSet<PayrollSalarystructureOvertimeformula> PayrollSalarystructureOvertimeformulas { get; set; }

    public virtual DbSet<PersonnelArea> PersonnelAreas { get; set; }

    public virtual DbSet<PersonnelAssignareaemployee> PersonnelAssignareaemployees { get; set; }

    public virtual DbSet<PersonnelCertification> PersonnelCertifications { get; set; }

    public virtual DbSet<PersonnelCompany> PersonnelCompanies { get; set; }

    public virtual DbSet<PersonnelDepartment> PersonnelDepartments { get; set; }

    public virtual DbSet<PersonnelEmployee> PersonnelEmployees { get; set; }

    public virtual DbSet<PersonnelEmployeeArea> PersonnelEmployeeAreas { get; set; }

    public virtual DbSet<PersonnelEmployeeFlowRole> PersonnelEmployeeFlowRoles { get; set; }

    public virtual DbSet<PersonnelEmployeecalendar> PersonnelEmployeecalendars { get; set; }

    public virtual DbSet<PersonnelEmployeecertification> PersonnelEmployeecertifications { get; set; }

    public virtual DbSet<PersonnelEmployeecustomattribute> PersonnelEmployeecustomattributes { get; set; }

    public virtual DbSet<PersonnelEmployeeextrainfo> PersonnelEmployeeextrainfos { get; set; }

    public virtual DbSet<PersonnelEmployeeleavebalance> PersonnelEmployeeleavebalances { get; set; }

    public virtual DbSet<PersonnelEmployeeprofile> PersonnelEmployeeprofiles { get; set; }

    public virtual DbSet<PersonnelEmployment> PersonnelEmployments { get; set; }

    public virtual DbSet<PersonnelPosition> PersonnelPositions { get; set; }

    public virtual DbSet<PersonnelResign> PersonnelResigns { get; set; }

    public virtual DbSet<RestFrameworkTrackingApirequestlog> RestFrameworkTrackingApirequestlogs { get; set; }

    public virtual DbSet<StaffStafftoken> StaffStafftokens { get; set; }

    public virtual DbSet<SyncArea> SyncAreas { get; set; }

    public virtual DbSet<SyncDepartment> SyncDepartments { get; set; }

    public virtual DbSet<SyncEmployee> SyncEmployees { get; set; }

    public virtual DbSet<SyncJob> SyncJobs { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UsuarioWeb> UsuarioWebs { get; set; }

    public virtual DbSet<VisitorReason> VisitorReasons { get; set; }

    public virtual DbSet<VisitorReservation> VisitorReservations { get; set; }

    public virtual DbSet<VisitorVisitor> VisitorVisitors { get; set; }

    public virtual DbSet<VisitorVisitorAccGroup> VisitorVisitorAccGroups { get; set; }

    public virtual DbSet<VisitorVisitorArea> VisitorVisitorAreas { get; set; }

    public virtual DbSet<VisitorVisitorbiodatum> VisitorVisitorbiodata { get; set; }

    public virtual DbSet<VisitorVisitorbiophoto> VisitorVisitorbiophotos { get; set; }

    public virtual DbSet<VisitorVisitorconfig> VisitorVisitorconfigs { get; set; }

    public virtual DbSet<VisitorVisitorlog> VisitorVisitorlogs { get; set; }

    public virtual DbSet<VisitorVisitortransaction> VisitorVisitortransactions { get; set; }

    public virtual DbSet<WorkflowNodeinstance> WorkflowNodeinstances { get; set; }

    public virtual DbSet<WorkflowWorkflowengine> WorkflowWorkflowengines { get; set; }

    public virtual DbSet<WorkflowWorkflowengineEmployee> WorkflowWorkflowengineEmployees { get; set; }

    public virtual DbSet<WorkflowWorkflowinstance> WorkflowWorkflowinstances { get; set; }

    public virtual DbSet<WorkflowWorkflownode> WorkflowWorkflownodes { get; set; }

    public virtual DbSet<WorkflowWorkflownodeApprover> WorkflowWorkflownodeApprovers { get; set; }

    public virtual DbSet<WorkflowWorkflownodeNotifier> WorkflowWorkflownodeNotifiers { get; set; }

    public virtual DbSet<WorkflowWorkflowrole> WorkflowWorkflowroles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=biotime;Username=postgres;Password=230169Mfc; Port=7496");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccAcccombination>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("acc_acccombination_pkey");

            entity.ToTable("acc_acccombination");

            entity.HasIndex(e => e.AreaId, "acc_acccombination_area_id_0d22c34e");

            entity.HasIndex(e => new { e.AreaId, e.CombinationNo }, "acc_acccombination_area_id_combination_no_619eb4f5_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CombinationName)
                .HasMaxLength(100)
                .HasColumnName("combination_name");
            entity.Property(e => e.CombinationNo).HasColumnName("combination_no");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Group1).HasColumnName("group1");
            entity.Property(e => e.Group2).HasColumnName("group2");
            entity.Property(e => e.Group3).HasColumnName("group3");
            entity.Property(e => e.Group4).HasColumnName("group4");
            entity.Property(e => e.Group5).HasColumnName("group5");
            entity.Property(e => e.Remark)
                .HasMaxLength(999)
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdateTime).HasColumnName("update_time");

            entity.HasOne(d => d.Area).WithMany(p => p.AccAcccombinations)
                .HasForeignKey(d => d.AreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("acc_acccombination_area_id_0d22c34e_fk_personnel_area_id");
        });

        modelBuilder.Entity<AccAccgroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("acc_accgroups_pkey");

            entity.ToTable("acc_accgroups");

            entity.HasIndex(e => e.AreaId, "acc_accgroups_area_id_b83745c3");

            entity.HasIndex(e => new { e.AreaId, e.GroupNo }, "acc_accgroups_area_id_group_no_5130a89c_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.GroupName)
                .HasMaxLength(100)
                .HasColumnName("group_name");
            entity.Property(e => e.GroupNo).HasColumnName("group_no");
            entity.Property(e => e.IsIncludeHoliday).HasColumnName("is_include_holiday");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timezone1).HasColumnName("timezone1");
            entity.Property(e => e.Timezone2).HasColumnName("timezone2");
            entity.Property(e => e.Timezone3).HasColumnName("timezone3");
            entity.Property(e => e.UpdateTime).HasColumnName("update_time");
            entity.Property(e => e.VerifyMode).HasColumnName("verify_mode");

            entity.HasOne(d => d.Area).WithMany(p => p.AccAccgroups)
                .HasForeignKey(d => d.AreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("acc_accgroups_area_id_b83745c3_fk_personnel_area_id");
        });

        modelBuilder.Entity<AccAccholiday>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("acc_accholiday_pkey");

            entity.ToTable("acc_accholiday");

            entity.HasIndex(e => e.AreaId, "acc_accholiday_area_id_d15c19da");

            entity.HasIndex(e => new { e.AreaId, e.HolidayId }, "acc_accholiday_area_id_holiday_id_6630c2eb_uniq").IsUnique();

            entity.HasIndex(e => e.HolidayId, "acc_accholiday_holiday_id_a9efe924");

            entity.HasIndex(e => e.TimezoneId, "acc_accholiday_timezone_id_450d2d1e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.HolidayId).HasColumnName("holiday_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TimezoneId).HasColumnName("timezone_id");
            entity.Property(e => e.UpdateTime).HasColumnName("update_time");

            entity.HasOne(d => d.Area).WithMany(p => p.AccAccholidays)
                .HasForeignKey(d => d.AreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("acc_accholiday_area_id_d15c19da_fk_personnel_area_id");

            entity.HasOne(d => d.Holiday).WithMany(p => p.AccAccholidays)
                .HasForeignKey(d => d.HolidayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("acc_accholiday_holiday_id_a9efe924_fk_att_holiday_id");

            entity.HasOne(d => d.Timezone).WithMany(p => p.AccAccholidays)
                .HasForeignKey(d => d.TimezoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("acc_accholiday_timezone_id_450d2d1e_fk_acc_acctimezone_id");
        });

        modelBuilder.Entity<AccAccprivilege>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("acc_accprivilege_pkey");

            entity.ToTable("acc_accprivilege");

            entity.HasIndex(e => e.AreaId, "acc_accprivilege_area_id_2123ff6f");

            entity.HasIndex(e => new { e.AreaId, e.EmployeeId, e.GroupId }, "acc_accprivilege_area_id_employee_id_group_id_f3b297d8_uniq").IsUnique();

            entity.HasIndex(e => e.EmployeeId, "acc_accprivilege_employee_id_5fc55f95");

            entity.HasIndex(e => e.GroupId, "acc_accprivilege_group_id_c5ed7003");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.IsGroupTimezone).HasColumnName("is_group_timezone");
            entity.Property(e => e.IsGroupVerifycode).HasColumnName("is_group_verifycode");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timezone1).HasColumnName("timezone1");
            entity.Property(e => e.Timezone2).HasColumnName("timezone2");
            entity.Property(e => e.Timezone3).HasColumnName("timezone3");
            entity.Property(e => e.UpdateTime).HasColumnName("update_time");
            entity.Property(e => e.VerifyMode).HasColumnName("verify_mode");

            entity.HasOne(d => d.Area).WithMany(p => p.AccAccprivileges)
                .HasForeignKey(d => d.AreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("acc_accprivilege_area_id_2123ff6f_fk_personnel_area_id");

            entity.HasOne(d => d.Group).WithMany(p => p.AccAccprivileges)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("acc_accprivilege_group_id_c5ed7003_fk_acc_accgroups_id");
        });

        modelBuilder.Entity<AccAccterminal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("acc_accterminal_pkey");

            entity.ToTable("acc_accterminal");

            entity.HasIndex(e => e.TerminalId, "acc_accterminal_terminal_id_fc92cce2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alarm11).HasColumnName("alarm_1_1");
            entity.Property(e => e.Alarm1N).HasColumnName("alarm_1_n");
            entity.Property(e => e.AlarmPassword).HasColumnName("alarm_password");
            entity.Property(e => e.AntiDoorDirection).HasColumnName("anti_door_direction");
            entity.Property(e => e.AntiPassbackMode).HasColumnName("anti_passback_mode");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.DoorAlarmDelay).HasColumnName("door_alarm_delay");
            entity.Property(e => e.DoorLockDelay).HasColumnName("door_lock_delay");
            entity.Property(e => e.DoorName)
                .HasMaxLength(50)
                .HasColumnName("door_name");
            entity.Property(e => e.DoorSensorDelay).HasColumnName("door_sensor_delay");
            entity.Property(e => e.DoorSensorType).HasColumnName("door_sensor_type");
            entity.Property(e => e.DuressAlarmDelay).HasColumnName("duress_alarm_delay");
            entity.Property(e => e.DuressFunOn).HasColumnName("duress_fun_on");
            entity.Property(e => e.NcTimePeriod).HasColumnName("nc_time_period");
            entity.Property(e => e.NoTimePeriod).HasColumnName("no_time_period");
            entity.Property(e => e.PushTime).HasColumnName("push_time");
            entity.Property(e => e.RetryTimes).HasColumnName("retry_times");
            entity.Property(e => e.SpeakerAlarm).HasColumnName("speaker_alarm");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
            entity.Property(e => e.ValidHoliday).HasColumnName("valid_holiday");
            entity.Property(e => e.VerifyMode485).HasColumnName("verify_mode_485");

            entity.HasOne(d => d.Terminal).WithMany(p => p.AccAccterminals)
                .HasForeignKey(d => d.TerminalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("acc_accterminal_terminal_id_fc92cce2_fk_iclock_terminal_id");
        });

        modelBuilder.Entity<AccAcctimezone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("acc_acctimezone_pkey");

            entity.ToTable("acc_acctimezone");

            entity.HasIndex(e => e.AreaId, "acc_acctimezone_area_id_e9ce7a7a");

            entity.HasIndex(e => new { e.AreaId, e.TimezoneNo }, "acc_acctimezone_area_id_timezone_no_0cb8250f_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.FriEnd).HasColumnName("fri_end");
            entity.Property(e => e.FriOn).HasColumnName("fri_on");
            entity.Property(e => e.FriStart).HasColumnName("fri_start");
            entity.Property(e => e.MonEnd).HasColumnName("mon_end");
            entity.Property(e => e.MonOn).HasColumnName("mon_on");
            entity.Property(e => e.MonStart).HasColumnName("mon_start");
            entity.Property(e => e.Remark)
                .HasMaxLength(999)
                .HasColumnName("remark");
            entity.Property(e => e.SatEnd).HasColumnName("sat_end");
            entity.Property(e => e.SatOn).HasColumnName("sat_on");
            entity.Property(e => e.SatStart).HasColumnName("sat_start");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.SunEnd).HasColumnName("sun_end");
            entity.Property(e => e.SunOn).HasColumnName("sun_on");
            entity.Property(e => e.SunStart).HasColumnName("sun_start");
            entity.Property(e => e.ThuEnd).HasColumnName("thu_end");
            entity.Property(e => e.ThuOn).HasColumnName("thu_on");
            entity.Property(e => e.ThuStart).HasColumnName("thu_start");
            entity.Property(e => e.TimezoneName)
                .HasMaxLength(100)
                .HasColumnName("timezone_name");
            entity.Property(e => e.TimezoneNo).HasColumnName("timezone_no");
            entity.Property(e => e.TueEnd).HasColumnName("tue_end");
            entity.Property(e => e.TueOn).HasColumnName("tue_on");
            entity.Property(e => e.TueStart).HasColumnName("tue_start");
            entity.Property(e => e.UpdateTime).HasColumnName("update_time");
            entity.Property(e => e.WedEnd).HasColumnName("wed_end");
            entity.Property(e => e.WedOn).HasColumnName("wed_on");
            entity.Property(e => e.WedStart).HasColumnName("wed_start");

            entity.HasOne(d => d.Area).WithMany(p => p.AccAcctimezones)
                .HasForeignKey(d => d.AreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("acc_acctimezone_area_id_e9ce7a7a_fk_personnel_area_id");
        });

        modelBuilder.Entity<AccountsAdminbiodatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("accounts_adminbiodata_pkey");

            entity.ToTable("accounts_adminbiodata");

            entity.HasIndex(e => e.AdminId, "accounts_adminbiodata_admin_id_1e6d2d45");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdminId).HasColumnName("admin_id");
            entity.Property(e => e.BioFormat).HasColumnName("bio_format");
            entity.Property(e => e.BioIndex).HasColumnName("bio_index");
            entity.Property(e => e.BioNo).HasColumnName("bio_no");
            entity.Property(e => e.BioTmp).HasColumnName("bio_tmp");
            entity.Property(e => e.BioType).HasColumnName("bio_type");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Duress).HasColumnName("duress");
            entity.Property(e => e.MajorVer)
                .HasMaxLength(30)
                .HasColumnName("major_ver");
            entity.Property(e => e.MinorVer)
                .HasMaxLength(30)
                .HasColumnName("minor_ver");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Valid).HasColumnName("valid");

            entity.HasOne(d => d.Admin).WithMany(p => p.AccountsAdminbiodata)
                .HasForeignKey(d => d.AdminId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("accounts_adminbiodata_admin_id_1e6d2d45_fk_auth_user_id");
        });

        modelBuilder.Entity<AccountsUsernotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("accounts_usernotification_pkey");

            entity.ToTable("accounts_usernotification");

            entity.HasIndex(e => e.UserId, "accounts_usernotification_user_id_b86755b3");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Event).HasColumnName("event");
            entity.Property(e => e.ReadTime).HasColumnName("read_time");
            entity.Property(e => e.SendTime).HasColumnName("send_time");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<AttAttcalclog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_attcalclog_pkey");

            entity.ToTable("att_attcalclog");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DeptId).HasColumnName("dept_id");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.LogType).HasColumnName("log_type");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.UpdateTime).HasColumnName("update_time");
        });

        modelBuilder.Entity<AttAttcode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_attcode_pkey");

            entity.ToTable("att_attcode");

            entity.HasIndex(e => e.Alias, "att_attcode_alias_51209102_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Alias, "att_attcode_alias_key").IsUnique();

            entity.HasIndex(e => e.Code, "att_attcode_code_2744cfec_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Code, "att_attcode_code_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .HasColumnName("alias");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.ColorSetting)
                .HasMaxLength(30)
                .HasColumnName("color_setting");
            entity.Property(e => e.DisplayFormat).HasColumnName("display_format");
            entity.Property(e => e.MinVal)
                .HasPrecision(4, 1)
                .HasColumnName("min_val");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.RoundOff).HasColumnName("round_off");
            entity.Property(e => e.Symbol)
                .HasMaxLength(20)
                .HasColumnName("symbol");
            entity.Property(e => e.SymbolOnly).HasColumnName("symbol_only");
        });

        modelBuilder.Entity<AttAttemployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_attemployee_pkey");

            entity.ToTable("att_attemployee");

            entity.HasIndex(e => e.EmpId, "att_attemployee_emp_id_key").IsUnique();

            entity.HasIndex(e => e.GroupId, "att_attemployee_group_id_18d3954d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.EnableAttendance).HasColumnName("enable_attendance");
            entity.Property(e => e.EnableCompensatory).HasColumnName("enable_compensatory");
            entity.Property(e => e.EnableHoliday).HasColumnName("enable_holiday");
            entity.Property(e => e.EnableOvertime).HasColumnName("enable_overtime");
            entity.Property(e => e.EnableSchedule).HasColumnName("enable_schedule");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.IpAddress).HasColumnName("ip_address");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Group).WithMany(p => p.AttAttemployees)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("att_attemployee_group_id_18d3954d_fk_att_attgroup_id");
        });

        modelBuilder.Entity<AttAttgroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_attgroup_pkey");

            entity.ToTable("att_attgroup");

            entity.HasIndex(e => e.Code, "att_attgroup_code_e12309ae_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Code, "att_attgroup_code_key").IsUnique();

            entity.HasIndex(e => e.Name, "att_attgroup_name_7dd662e2_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Name, "att_attgroup_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<AttAttpolicy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_attpolicy_pkey");

            entity.ToTable("att_attpolicy");

            entity.HasIndex(e => e.OtPayCodeId, "att_attpolicy_ot_pay_code_id_b189b952");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.DailyOt).HasColumnName("daily_ot");
            entity.Property(e => e.DailyOtRule).HasColumnName("daily_ot_rule");
            entity.Property(e => e.DayChange).HasColumnName("day_change");
            entity.Property(e => e.EarlyOut2absence).HasColumnName("early_out2absence");
            entity.Property(e => e.EarlyOutHrs).HasColumnName("early_out_hrs");
            entity.Property(e => e.EmailSendTime).HasColumnName("email_send_time");
            entity.Property(e => e.EnableCompensatory).HasColumnName("enable_compensatory");
            entity.Property(e => e.GlobalFrequency).HasColumnName("global_frequency");
            entity.Property(e => e.GlobalSendDay).HasColumnName("global_send_day");
            entity.Property(e => e.HolidayOt).HasColumnName("holiday_ot");
            entity.Property(e => e.HolidayOtRule).HasColumnName("holiday_ot_rule");
            entity.Property(e => e.LateIn2absence).HasColumnName("late_in2absence");
            entity.Property(e => e.LateInHrs).HasColumnName("late_in_hrs");
            entity.Property(e => e.MaxAbsent).HasColumnName("max_absent");
            entity.Property(e => e.MaxEarlyOut).HasColumnName("max_early_out");
            entity.Property(e => e.MaxHrs)
                .HasPrecision(4, 1)
                .HasColumnName("max_hrs");
            entity.Property(e => e.MaxLateIn).HasColumnName("max_late_in");
            entity.Property(e => e.MissIn).HasColumnName("miss_in");
            entity.Property(e => e.MissOut).HasColumnName("miss_out");
            entity.Property(e => e.OtPayCodeId).HasColumnName("ot_pay_code_id");
            entity.Property(e => e.OvertimePolicy).HasColumnName("overtime_policy");
            entity.Property(e => e.ParingRule).HasColumnName("paring_rule");
            entity.Property(e => e.PunchPeriod).HasColumnName("punch_period");
            entity.Property(e => e.RequireCapture).HasColumnName("require_capture");
            entity.Property(e => e.RequirePunchState).HasColumnName("require_punch_state");
            entity.Property(e => e.RequireWorkCode).HasColumnName("require_work_code");
            entity.Property(e => e.SendingDay).HasColumnName("sending_day");
            entity.Property(e => e.StartOfWeek).HasColumnName("start_of_week");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UseOt).HasColumnName("use_ot");
            entity.Property(e => e.Weekend1).HasColumnName("weekend1");
            entity.Property(e => e.Weekend1ColorSetting)
                .HasMaxLength(30)
                .HasColumnName("weekend1_color_setting");
            entity.Property(e => e.Weekend2).HasColumnName("weekend2");
            entity.Property(e => e.Weekend2ColorSetting)
                .HasMaxLength(30)
                .HasColumnName("weekend2_color_setting");
            entity.Property(e => e.WeekendOt).HasColumnName("weekend_ot");
            entity.Property(e => e.WeekendOtRule).HasColumnName("weekend_ot_rule");
            entity.Property(e => e.WeeklyOt).HasColumnName("weekly_ot");
            entity.Property(e => e.WeeklyOtRule).HasColumnName("weekly_ot_rule");

            entity.HasOne(d => d.OtPayCode).WithMany(p => p.AttAttpolicies)
                .HasForeignKey(d => d.OtPayCodeId)
                .HasConstraintName("att_attpolicy_ot_pay_code_id_b189b952_fk_att_paycode_id");
        });

        modelBuilder.Entity<AttAttreportsetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_attreportsetting_pkey");

            entity.ToTable("att_attreportsetting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FilterByHireDate).HasColumnName("filter_by_hire_date");
            entity.Property(e => e.ResignEmp).HasColumnName("resign_emp");
            entity.Property(e => e.ShortDate).HasColumnName("short_date");
            entity.Property(e => e.ShortTime).HasColumnName("short_time");
        });

        modelBuilder.Entity<AttAttrule>(entity =>
        {
            entity.HasKey(e => e.ParamName).HasName("att_attrule_pkey");

            entity.ToTable("att_attrule");

            entity.HasIndex(e => e.ParamName, "att_attrule_param_name_406bcfb6_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.Property(e => e.ParamName)
                .HasMaxLength(20)
                .HasColumnName("param_name");
            entity.Property(e => e.ParamValue).HasColumnName("param_value");
        });

        modelBuilder.Entity<AttAttschedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_attschedule_pkey");

            entity.ToTable("att_attschedule");

            entity.HasIndex(e => e.EmployeeId, "att_attschedule_employee_id_caa61686");

            entity.HasIndex(e => e.ShiftId, "att_attschedule_shift_id_13d2db9a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.ShiftId).HasColumnName("shift_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");

            entity.HasOne(d => d.Employee).WithMany(p => p.AttAttschedules)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_attschedule_employee_id_caa61686_fk_personnel_employee_id");

            entity.HasOne(d => d.Shift).WithMany(p => p.AttAttschedules)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_attschedule_shift_id_13d2db9a_fk_att_attshift_id");
        });

        modelBuilder.Entity<AttAttshift>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_attshift_pkey");

            entity.ToTable("att_attshift");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .HasColumnName("alias");
            entity.Property(e => e.AutoShift).HasColumnName("auto_shift");
            entity.Property(e => e.CycleUnit).HasColumnName("cycle_unit");
            entity.Property(e => e.DayOffType).HasColumnName("day_off_type");
            entity.Property(e => e.EnableOtRule).HasColumnName("enable_ot_rule");
            entity.Property(e => e.Frequency).HasColumnName("frequency");
            entity.Property(e => e.OtRule).HasColumnName("ot_rule");
            entity.Property(e => e.ShiftCycle).HasColumnName("shift_cycle");
            entity.Property(e => e.WeekendType).HasColumnName("weekend_type");
            entity.Property(e => e.WorkDayOff).HasColumnName("work_day_off");
            entity.Property(e => e.WorkWeekend).HasColumnName("work_weekend");
        });

        modelBuilder.Entity<AttBreaktime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_breaktime_pkey");

            entity.ToTable("att_breaktime");

            entity.HasIndex(e => e.Alias, "att_breaktime_alias_6212d9cf_uniq").IsUnique();

            entity.HasIndex(e => e.LossCodeId, "att_breaktime_loss_code_id_2ffb5432");

            entity.HasIndex(e => e.ProfitCodeId, "att_breaktime_profit_code_id_63cdbbcc");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .HasColumnName("alias");
            entity.Property(e => e.AvailableInterval).HasColumnName("available_interval");
            entity.Property(e => e.AvailableIntervalType).HasColumnName("available_interval_type");
            entity.Property(e => e.CalcType).HasColumnName("calc_type");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EarlyIn).HasColumnName("early_in");
            entity.Property(e => e.EndMargin).HasColumnName("end_margin");
            entity.Property(e => e.FuncKey).HasColumnName("func_key");
            entity.Property(e => e.LateIn).HasColumnName("late_in");
            entity.Property(e => e.LossCodeId).HasColumnName("loss_code_id");
            entity.Property(e => e.LossRule).HasColumnName("loss_rule");
            entity.Property(e => e.MinEarlyIn).HasColumnName("min_early_in");
            entity.Property(e => e.MinLateIn).HasColumnName("min_late_in");
            entity.Property(e => e.MinimumDuration).HasColumnName("minimum_duration");
            entity.Property(e => e.MultiplePunch).HasColumnName("multiple_punch");
            entity.Property(e => e.PeriodStart).HasColumnName("period_start");
            entity.Property(e => e.ProfitCodeId).HasColumnName("profit_code_id");
            entity.Property(e => e.ProfitRule).HasColumnName("profit_rule");

            entity.HasOne(d => d.LossCode).WithMany(p => p.AttBreaktimeLossCodes)
                .HasForeignKey(d => d.LossCodeId)
                .HasConstraintName("att_breaktime_loss_code_id_2ffb5432_fk_att_paycode_id");

            entity.HasOne(d => d.ProfitCode).WithMany(p => p.AttBreaktimeProfitCodes)
                .HasForeignKey(d => d.ProfitCodeId)
                .HasConstraintName("att_breaktime_profit_code_id_63cdbbcc_fk_att_paycode_id");
        });

        modelBuilder.Entity<AttCalculatelastdate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_calculatelastdate_pkey");

            entity.ToTable("att_calculatelastdate");

            entity.HasIndex(e => e.LastDate, "att_calculatelastdate_last_date_1441abdc");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastDate).HasColumnName("last_date");
        });

        modelBuilder.Entity<AttCalculatetask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_calculatetask_pkey");

            entity.ToTable("att_calculatetask");

            entity.HasIndex(e => e.EndDate, "att_calculatetask_end_date_75d1d6d2");

            entity.HasIndex(e => e.StartDate, "att_calculatetask_start_date_7bbaa889");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Emp).HasColumnName("emp");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.Event)
                .HasMaxLength(128)
                .HasColumnName("event");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
        });

        modelBuilder.Entity<AttChangeschedule>(entity =>
        {
            entity.HasKey(e => e.WorkflowinstancePtrId).HasName("att_changeschedule_pkey");

            entity.ToTable("att_changeschedule");

            entity.HasIndex(e => e.TimeintervalId, "att_changeschedule_timeinterval_id_d41ac077");

            entity.Property(e => e.WorkflowinstancePtrId)
                .ValueGeneratedNever()
                .HasColumnName("workflowinstance_ptr_id");
            entity.Property(e => e.ApplyReason)
                .HasMaxLength(200)
                .HasColumnName("apply_reason");
            entity.Property(e => e.ApplyTime).HasColumnName("apply_time");
            entity.Property(e => e.AttDate).HasColumnName("att_date");
            entity.Property(e => e.Attachment)
                .HasMaxLength(100)
                .HasColumnName("attachment");
            entity.Property(e => e.PreviousTimeinterval)
                .HasMaxLength(100)
                .HasColumnName("previous_timeinterval");
            entity.Property(e => e.TimeintervalId).HasColumnName("timeinterval_id");

            entity.HasOne(d => d.Timeinterval).WithMany(p => p.AttChangeschedules)
                .HasForeignKey(d => d.TimeintervalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_changeschedule_timeinterval_id_d41ac077_fk_att_timei");

            entity.HasOne(d => d.WorkflowinstancePtr).WithOne(p => p.AttChangeschedule)
                .HasForeignKey<AttChangeschedule>(d => d.WorkflowinstancePtrId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_changeschedule_workflowinstance_ptr_cee602bb_fk_workflow_");
        });

        modelBuilder.Entity<AttDepartmentpolicy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_departmentpolicy_pkey");

            entity.ToTable("att_departmentpolicy");

            entity.HasIndex(e => e.DepartmentId, "att_departmentpolicy_department_id_77059a9d");

            entity.HasIndex(e => e.OtPayCodeId, "att_departmentpolicy_ot_pay_code_id_390411dd");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.DailyOt).HasColumnName("daily_ot");
            entity.Property(e => e.DailyOtRule).HasColumnName("daily_ot_rule");
            entity.Property(e => e.DayChange).HasColumnName("day_change");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.DeptFrequency).HasColumnName("dept_frequency");
            entity.Property(e => e.DeptSendDay).HasColumnName("dept_send_day");
            entity.Property(e => e.EarlyOut2absence).HasColumnName("early_out2absence");
            entity.Property(e => e.EarlyOutHrs).HasColumnName("early_out_hrs");
            entity.Property(e => e.EmailSendTime).HasColumnName("email_send_time");
            entity.Property(e => e.EnableCompensatory).HasColumnName("enable_compensatory");
            entity.Property(e => e.HolidayOt).HasColumnName("holiday_ot");
            entity.Property(e => e.HolidayOtRule).HasColumnName("holiday_ot_rule");
            entity.Property(e => e.LateIn2absence).HasColumnName("late_in2absence");
            entity.Property(e => e.LateInHrs).HasColumnName("late_in_hrs");
            entity.Property(e => e.MaxAbsent).HasColumnName("max_absent");
            entity.Property(e => e.MaxEarlyOut).HasColumnName("max_early_out");
            entity.Property(e => e.MaxHrs)
                .HasPrecision(4, 1)
                .HasColumnName("max_hrs");
            entity.Property(e => e.MaxLateIn).HasColumnName("max_late_in");
            entity.Property(e => e.MissIn).HasColumnName("miss_in");
            entity.Property(e => e.MissOut).HasColumnName("miss_out");
            entity.Property(e => e.OtPayCodeId).HasColumnName("ot_pay_code_id");
            entity.Property(e => e.OvertimePolicy).HasColumnName("overtime_policy");
            entity.Property(e => e.ParingRule).HasColumnName("paring_rule");
            entity.Property(e => e.PunchPeriod).HasColumnName("punch_period");
            entity.Property(e => e.RequireCapture).HasColumnName("require_capture");
            entity.Property(e => e.RequirePunchState).HasColumnName("require_punch_state");
            entity.Property(e => e.RequireWorkCode).HasColumnName("require_work_code");
            entity.Property(e => e.SendingDay).HasColumnName("sending_day");
            entity.Property(e => e.StartOfWeek).HasColumnName("start_of_week");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UseOt).HasColumnName("use_ot");
            entity.Property(e => e.Weekend1).HasColumnName("weekend1");
            entity.Property(e => e.Weekend1ColorSetting)
                .HasMaxLength(30)
                .HasColumnName("weekend1_color_setting");
            entity.Property(e => e.Weekend2).HasColumnName("weekend2");
            entity.Property(e => e.Weekend2ColorSetting)
                .HasMaxLength(30)
                .HasColumnName("weekend2_color_setting");
            entity.Property(e => e.WeekendOt).HasColumnName("weekend_ot");
            entity.Property(e => e.WeekendOtRule).HasColumnName("weekend_ot_rule");
            entity.Property(e => e.WeeklyOt).HasColumnName("weekly_ot");
            entity.Property(e => e.WeeklyOtRule).HasColumnName("weekly_ot_rule");

            entity.HasOne(d => d.Department).WithMany(p => p.AttDepartmentpolicies)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_departmentpolicy_department_id_77059a9d_fk_personnel");

            entity.HasOne(d => d.OtPayCode).WithMany(p => p.AttDepartmentpolicies)
                .HasForeignKey(d => d.OtPayCodeId)
                .HasConstraintName("att_departmentpolicy_ot_pay_code_id_390411dd_fk_att_paycode_id");
        });

        modelBuilder.Entity<AttDepartmentschedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_departmentschedule_pkey");

            entity.ToTable("att_departmentschedule");

            entity.HasIndex(e => e.DepartmentId, "att_departmentschedule_department_id_c68fca3d");

            entity.HasIndex(e => e.ShiftId, "att_departmentschedule_shift_id_c37d5ade");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.ShiftId).HasColumnName("shift_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Department).WithMany(p => p.AttDepartmentschedules)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_departmentschedu_department_id_c68fca3d_fk_personnel");

            entity.HasOne(d => d.Shift).WithMany(p => p.AttDepartmentschedules)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_departmentschedule_shift_id_c37d5ade_fk_att_attshift_id");
        });

        modelBuilder.Entity<AttDeptattrule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_deptattrule_pkey");

            entity.ToTable("att_deptattrule");

            entity.HasIndex(e => e.DepartmentId, "att_deptattrule_department_id_f333c8f0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .HasColumnName("alias");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.Rule).HasColumnName("rule");

            entity.HasOne(d => d.Department).WithMany(p => p.AttDeptattrules)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_deptattrule_department_id_f333c8f0_fk_personnel");
        });

        modelBuilder.Entity<AttGrouppolicy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_grouppolicy_pkey");

            entity.ToTable("att_grouppolicy");

            entity.HasIndex(e => e.GroupId, "att_grouppolicy_group_id_b2e4dfe8");

            entity.HasIndex(e => e.OtPayCodeId, "att_grouppolicy_ot_pay_code_id_1ec83080");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.DailyOt).HasColumnName("daily_ot");
            entity.Property(e => e.DailyOtRule).HasColumnName("daily_ot_rule");
            entity.Property(e => e.DayChange).HasColumnName("day_change");
            entity.Property(e => e.EarlyOut2absence).HasColumnName("early_out2absence");
            entity.Property(e => e.EarlyOutHrs).HasColumnName("early_out_hrs");
            entity.Property(e => e.EmailSendTime).HasColumnName("email_send_time");
            entity.Property(e => e.EnableCompensatory).HasColumnName("enable_compensatory");
            entity.Property(e => e.GroupFrequency).HasColumnName("group_frequency");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.GroupSendDay).HasColumnName("group_send_day");
            entity.Property(e => e.HolidayOt).HasColumnName("holiday_ot");
            entity.Property(e => e.HolidayOtRule).HasColumnName("holiday_ot_rule");
            entity.Property(e => e.LateIn2absence).HasColumnName("late_in2absence");
            entity.Property(e => e.LateInHrs).HasColumnName("late_in_hrs");
            entity.Property(e => e.MaxAbsent).HasColumnName("max_absent");
            entity.Property(e => e.MaxEarlyOut).HasColumnName("max_early_out");
            entity.Property(e => e.MaxHrs)
                .HasPrecision(4, 1)
                .HasColumnName("max_hrs");
            entity.Property(e => e.MaxLateIn).HasColumnName("max_late_in");
            entity.Property(e => e.MissIn).HasColumnName("miss_in");
            entity.Property(e => e.MissOut).HasColumnName("miss_out");
            entity.Property(e => e.OtPayCodeId).HasColumnName("ot_pay_code_id");
            entity.Property(e => e.OvertimePolicy).HasColumnName("overtime_policy");
            entity.Property(e => e.ParingRule).HasColumnName("paring_rule");
            entity.Property(e => e.PunchPeriod).HasColumnName("punch_period");
            entity.Property(e => e.RequireCapture).HasColumnName("require_capture");
            entity.Property(e => e.RequirePunchState).HasColumnName("require_punch_state");
            entity.Property(e => e.RequireWorkCode).HasColumnName("require_work_code");
            entity.Property(e => e.SendingDay).HasColumnName("sending_day");
            entity.Property(e => e.StartOfWeek).HasColumnName("start_of_week");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UseOt).HasColumnName("use_ot");
            entity.Property(e => e.Weekend1).HasColumnName("weekend1");
            entity.Property(e => e.Weekend1ColorSetting)
                .HasMaxLength(30)
                .HasColumnName("weekend1_color_setting");
            entity.Property(e => e.Weekend2).HasColumnName("weekend2");
            entity.Property(e => e.Weekend2ColorSetting)
                .HasMaxLength(30)
                .HasColumnName("weekend2_color_setting");
            entity.Property(e => e.WeekendOt).HasColumnName("weekend_ot");
            entity.Property(e => e.WeekendOtRule).HasColumnName("weekend_ot_rule");
            entity.Property(e => e.WeeklyOt).HasColumnName("weekly_ot");
            entity.Property(e => e.WeeklyOtRule).HasColumnName("weekly_ot_rule");

            entity.HasOne(d => d.Group).WithMany(p => p.AttGrouppolicies)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_grouppolicy_group_id_b2e4dfe8_fk_att_attgroup_id");

            entity.HasOne(d => d.OtPayCode).WithMany(p => p.AttGrouppolicies)
                .HasForeignKey(d => d.OtPayCodeId)
                .HasConstraintName("att_grouppolicy_ot_pay_code_id_1ec83080_fk_att_paycode_id");
        });

        modelBuilder.Entity<AttGroupschedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_groupschedule_pkey");

            entity.ToTable("att_groupschedule");

            entity.HasIndex(e => e.GroupId, "att_groupschedule_group_id_c341493f");

            entity.HasIndex(e => e.ShiftId, "att_groupschedule_shift_id_287e7fc0");

            entity.HasIndex(e => e.StartDate, "att_groupschedule_start_date_638b6d85");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.ShiftId).HasColumnName("shift_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Group).WithMany(p => p.AttGroupschedules)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_groupschedule_group_id_c341493f_fk_att_attgroup_id");

            entity.HasOne(d => d.Shift).WithMany(p => p.AttGroupschedules)
                .HasForeignKey(d => d.ShiftId)
                .HasConstraintName("att_groupschedule_shift_id_287e7fc0_fk_att_attshift_id");
        });

        modelBuilder.Entity<AttHoliday>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_holiday_pkey");

            entity.ToTable("att_holiday");

            entity.HasIndex(e => e.AttGroupId, "att_holiday_att_group_id_9ddf13ba");

            entity.HasIndex(e => e.DepartmentId, "att_holiday_department_id_fbbbd185");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .HasColumnName("alias");
            entity.Property(e => e.AttGroupId).HasColumnName("att_group_id");
            entity.Property(e => e.ColorSetting)
                .HasMaxLength(30)
                .HasColumnName("color_setting");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.DurationDay).HasColumnName("duration_day");
            entity.Property(e => e.EnableOtRule).HasColumnName("enable_ot_rule");
            entity.Property(e => e.OtRule).HasColumnName("ot_rule");
            entity.Property(e => e.StartDate).HasColumnName("start_date");

            entity.HasOne(d => d.AttGroup).WithMany(p => p.AttHolidays)
                .HasForeignKey(d => d.AttGroupId)
                .HasConstraintName("att_holiday_att_group_id_9ddf13ba_fk_att_attgroup_id");

            entity.HasOne(d => d.Department).WithMany(p => p.AttHolidays)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("att_holiday_department_id_fbbbd185_fk_personnel_department_id");
        });

        modelBuilder.Entity<AttLeave>(entity =>
        {
            entity.HasKey(e => e.WorkflowinstancePtrId).HasName("att_leave_pkey");

            entity.ToTable("att_leave");

            entity.HasIndex(e => e.PayCodeId, "att_leave_pay_code_id_2fadf493");

            entity.Property(e => e.WorkflowinstancePtrId)
                .ValueGeneratedNever()
                .HasColumnName("workflowinstance_ptr_id");
            entity.Property(e => e.ApplyReason).HasColumnName("apply_reason");
            entity.Property(e => e.ApplyTime).HasColumnName("apply_time");
            entity.Property(e => e.Attachment)
                .HasMaxLength(100)
                .HasColumnName("attachment");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.LeaveDay).HasColumnName("leave_day");
            entity.Property(e => e.PayCodeId).HasColumnName("pay_code_id");
            entity.Property(e => e.StartTime).HasColumnName("start_time");

            entity.HasOne(d => d.PayCode).WithMany(p => p.AttLeaves)
                .HasForeignKey(d => d.PayCodeId)
                .HasConstraintName("att_leave_pay_code_id_2fadf493_fk_att_paycode_id");

            entity.HasOne(d => d.WorkflowinstancePtr).WithOne(p => p.AttLeave)
                .HasForeignKey<AttLeave>(d => d.WorkflowinstancePtrId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_leave_workflowinstance_ptr_39aaa9d9_fk_workflow_");
        });

        modelBuilder.Entity<AttLeavegroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_leavegroup_pkey");

            entity.ToTable("att_leavegroup");

            entity.HasIndex(e => e.Code, "att_leavegroup_code_2043ad21_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Code, "att_leavegroup_code_key").IsUnique();

            entity.HasIndex(e => e.Name, "att_leavegroup_name_ea482c9a_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Name, "att_leavegroup_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<AttLeavegroupdetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_leavegroupdetail_pkey");

            entity.ToTable("att_leavegroupdetail");

            entity.HasIndex(e => e.LeaveGroupId, "att_leavegroupdetail_leave_group_id_28f69ada");

            entity.HasIndex(e => e.PayCodeId, "att_leavegroupdetail_pay_code_id_5013b373");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AllowBalance).HasColumnName("allow_balance");
            entity.Property(e => e.AllowExceedLimit).HasColumnName("allow_exceed_limit");
            entity.Property(e => e.AllowLeaveDay).HasColumnName("allow_leave_day");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.DeductHolidayDay).HasColumnName("deduct_holiday_day");
            entity.Property(e => e.EntitlementDetail)
                .HasMaxLength(999)
                .HasColumnName("entitlement_detail");
            entity.Property(e => e.LeaveDistributionTime).HasColumnName("leave_distribution_time");
            entity.Property(e => e.LeaveEntitlement).HasColumnName("leave_entitlement");
            entity.Property(e => e.LeaveGroupId).HasColumnName("leave_group_id");
            entity.Property(e => e.LeaveInterval).HasColumnName("leave_interval");
            entity.Property(e => e.LeaveType).HasColumnName("leave_type");
            entity.Property(e => e.MaxBalance).HasColumnName("max_balance");
            entity.Property(e => e.MinLeaveDay).HasColumnName("min_leave_day");
            entity.Property(e => e.PayCodeId).HasColumnName("pay_code_id");
            entity.Property(e => e.SetHireDay).HasColumnName("set_hire_day");
            entity.Property(e => e.StartDay)
                .HasMaxLength(5)
                .HasColumnName("start_day");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.LeaveGroup).WithMany(p => p.AttLeavegroupdetails)
                .HasForeignKey(d => d.LeaveGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_leavegroupdetail_leave_group_id_28f69ada_fk_att_leave");

            entity.HasOne(d => d.PayCode).WithMany(p => p.AttLeavegroupdetails)
                .HasForeignKey(d => d.PayCodeId)
                .HasConstraintName("att_leavegroupdetail_pay_code_id_5013b373_fk_att_paycode_id");
        });

        modelBuilder.Entity<AttLeaveyearbalance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_leaveyearbalance_pkey");

            entity.ToTable("att_leaveyearbalance");

            entity.HasIndex(e => e.EmployeeId, "att_leaveyearbalance_employee_id_14febdb3");

            entity.HasIndex(e => new { e.EmployeeId, e.Year, e.PayCodeId }, "att_leaveyearbalance_employee_id_year_pay_code_id_2ec71517_uniq").IsUnique();

            entity.HasIndex(e => e.PayCodeId, "att_leaveyearbalance_pay_code_id_82632aca");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.EntitlementDays).HasColumnName("entitlement_days");
            entity.Property(e => e.LeaveDay).HasColumnName("leave_day");
            entity.Property(e => e.LeaveType).HasColumnName("leave_type");
            entity.Property(e => e.PayCodeId).HasColumnName("pay_code_id");
            entity.Property(e => e.PreBalance).HasColumnName("pre_balance");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.Employee).WithMany(p => p.AttLeaveyearbalances)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_leaveyearbalance_employee_id_14febdb3_fk_personnel");

            entity.HasOne(d => d.PayCode).WithMany(p => p.AttLeaveyearbalances)
                .HasForeignKey(d => d.PayCodeId)
                .HasConstraintName("att_leaveyearbalance_pay_code_id_82632aca_fk_att_paycode_id");
        });

        modelBuilder.Entity<AttManuallog>(entity =>
        {
            entity.HasKey(e => e.WorkflowinstancePtrId).HasName("att_manuallog_pkey");

            entity.ToTable("att_manuallog");

            entity.Property(e => e.WorkflowinstancePtrId)
                .ValueGeneratedNever()
                .HasColumnName("workflowinstance_ptr_id");
            entity.Property(e => e.ApplyReason).HasColumnName("apply_reason");
            entity.Property(e => e.ApplyTime).HasColumnName("apply_time");
            entity.Property(e => e.Attachment)
                .HasMaxLength(100)
                .HasColumnName("attachment");
            entity.Property(e => e.PunchState)
                .HasMaxLength(5)
                .HasColumnName("punch_state");
            entity.Property(e => e.PunchTime).HasColumnName("punch_time");
            entity.Property(e => e.WorkCode)
                .HasMaxLength(20)
                .HasColumnName("work_code");

            entity.HasOne(d => d.WorkflowinstancePtr).WithOne(p => p.AttManuallog)
                .HasForeignKey<AttManuallog>(d => d.WorkflowinstancePtrId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_manuallog_workflowinstance_ptr_22a3fbd0_fk_workflow_");
        });

        modelBuilder.Entity<AttOvertime>(entity =>
        {
            entity.HasKey(e => e.WorkflowinstancePtrId).HasName("att_overtime_pkey");

            entity.ToTable("att_overtime");

            entity.HasIndex(e => e.PayCodeId, "att_overtime_pay_code_id_05600ee0");

            entity.Property(e => e.WorkflowinstancePtrId)
                .ValueGeneratedNever()
                .HasColumnName("workflowinstance_ptr_id");
            entity.Property(e => e.ApplyReason).HasColumnName("apply_reason");
            entity.Property(e => e.ApplyTime).HasColumnName("apply_time");
            entity.Property(e => e.Attachment)
                .HasMaxLength(100)
                .HasColumnName("attachment");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.OvertimeType).HasColumnName("overtime_type");
            entity.Property(e => e.PayCodeId).HasColumnName("pay_code_id");
            entity.Property(e => e.StartTime).HasColumnName("start_time");

            entity.HasOne(d => d.PayCode).WithMany(p => p.AttOvertimes)
                .HasForeignKey(d => d.PayCodeId)
                .HasConstraintName("att_overtime_pay_code_id_05600ee0_fk_att_paycode_id");

            entity.HasOne(d => d.WorkflowinstancePtr).WithOne(p => p.AttOvertime)
                .HasForeignKey<AttOvertime>(d => d.WorkflowinstancePtrId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_overtime_workflowinstance_ptr_6bd6a6f4_fk_workflow_");
        });

        modelBuilder.Entity<AttOvertimepolicy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_overtimepolicy_pkey");

            entity.ToTable("att_overtimepolicy");

            entity.HasIndex(e => e.OvernightPayCodeId, "att_overtimepolicy_overnight_pay_code_id_274ce1b0");

            entity.HasIndex(e => e.PayCodeId, "att_overtimepolicy_pay_code_id_285b0a61");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.HrsFrom)
                .HasPrecision(4, 1)
                .HasColumnName("hrs_from");
            entity.Property(e => e.HrsTo)
                .HasPrecision(4, 1)
                .HasColumnName("hrs_to");
            entity.Property(e => e.Master).HasColumnName("master");
            entity.Property(e => e.Mode).HasColumnName("mode");
            entity.Property(e => e.OvernightPayCodeId).HasColumnName("overnight_pay_code_id");
            entity.Property(e => e.PayCodeId).HasColumnName("pay_code_id");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.OvernightPayCode).WithMany(p => p.AttOvertimepolicyOvernightPayCodes)
                .HasForeignKey(d => d.OvernightPayCodeId)
                .HasConstraintName("att_overtimepolicy_overnight_pay_code_i_274ce1b0_fk_att_payco");

            entity.HasOne(d => d.PayCode).WithMany(p => p.AttOvertimepolicyPayCodes)
                .HasForeignKey(d => d.PayCodeId)
                .HasConstraintName("att_overtimepolicy_pay_code_id_285b0a61_fk_att_paycode_id");
        });

        modelBuilder.Entity<AttPaycode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_paycode_pkey");

            entity.ToTable("att_paycode");

            entity.HasIndex(e => e.Code, "att_paycode_code_2865d89c_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Code, "att_paycode_code_key").IsUnique();

            entity.HasIndex(e => e.Name, "att_paycode_name_6098e40c_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Name, "att_paycode_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.CodeType).HasColumnName("code_type");
            entity.Property(e => e.ColorSetting)
                .HasMaxLength(30)
                .HasColumnName("color_setting");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Desc).HasColumnName("desc");
            entity.Property(e => e.DisplayFormat).HasColumnName("display_format");
            entity.Property(e => e.DisplayOrder).HasColumnName("display_order");
            entity.Property(e => e.FixedCode).HasColumnName("fixed_code");
            entity.Property(e => e.FixedHours)
                .HasPrecision(8, 2)
                .HasColumnName("fixed_hours");
            entity.Property(e => e.IsBenefit).HasColumnName("is_benefit");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.IsDisplay).HasColumnName("is_display");
            entity.Property(e => e.IsPaid).HasColumnName("is_paid");
            entity.Property(e => e.IsWork).HasColumnName("is_work");
            entity.Property(e => e.MinVal)
                .HasPrecision(4, 1)
                .HasColumnName("min_val");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.RoundOff).HasColumnName("round_off");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Symbol)
                .HasMaxLength(20)
                .HasColumnName("symbol");
            entity.Property(e => e.Tag).HasColumnName("tag");
        });

        modelBuilder.Entity<AttPayloadattcode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_payloadattcode_pkey");

            entity.ToTable("att_payloadattcode");

            entity.HasIndex(e => e.AttCodeId, "att_payloadattcode_att_code_id_0d635efd");

            entity.HasIndex(e => e.AttDate, "att_payloadattcode_att_date_19b2621e");

            entity.HasIndex(e => e.EmpId, "att_payloadattcode_emp_id_36569f54");

            entity.HasIndex(e => e.ShiftId, "att_payloadattcode_shift_id_731faddf");

            entity.HasIndex(e => e.TimeCardId, "att_payloadattcode_time_card_id_e8a37c7a");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AttCodeAlias)
                .HasMaxLength(50)
                .HasColumnName("att_code_alias");
            entity.Property(e => e.AttCodeId).HasColumnName("att_code_id");
            entity.Property(e => e.AttCodeSymbol)
                .HasMaxLength(20)
                .HasColumnName("att_code_symbol");
            entity.Property(e => e.AttDate).HasColumnName("att_date");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Hours)
                .HasPrecision(6, 1)
                .HasColumnName("hours");
            entity.Property(e => e.IsWeekly).HasColumnName("is_weekly");
            entity.Property(e => e.Minutes)
                .HasPrecision(8, 1)
                .HasColumnName("minutes");
            entity.Property(e => e.ShiftId).HasColumnName("shift_id");
            entity.Property(e => e.TimeCardId).HasColumnName("time_card_id");
            entity.Property(e => e.Week).HasColumnName("week");
            entity.Property(e => e.Weekday).HasColumnName("weekday");
            entity.Property(e => e.Workday)
                .HasPrecision(4, 1)
                .HasColumnName("workday");

            entity.HasOne(d => d.AttCode).WithMany(p => p.AttPayloadattcodes)
                .HasForeignKey(d => d.AttCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_payloadattcode_att_code_id_0d635efd_fk_att_attcode_id");

            entity.HasOne(d => d.Shift).WithMany(p => p.AttPayloadattcodes)
                .HasForeignKey(d => d.ShiftId)
                .HasConstraintName("att_payloadattcode_shift_id_731faddf_fk_att_attshift_id");
        });

        modelBuilder.Entity<AttPayloadbase>(entity =>
        {
            entity.HasKey(e => e.Uuid).HasName("att_payloadbase_pkey");

            entity.ToTable("att_payloadbase");

            entity.HasIndex(e => e.BreakTimeId, "att_payloadbase_break_time_id_022d6fac_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.BreakTimeId, "att_payloadbase_break_time_id_key").IsUnique();

            entity.HasIndex(e => e.EmpId, "att_payloadbase_emp_id_2c0f6a7b");

            entity.HasIndex(e => e.OvertimeId, "att_payloadbase_overtime_id_0e7be795_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.OvertimeId, "att_payloadbase_overtime_id_key").IsUnique();

            entity.HasIndex(e => e.TimetableId, "att_payloadbase_timetable_id_a389e3d8");

            entity.HasIndex(e => e.Uuid, "att_payloadbase_uuid_60250467_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.Property(e => e.Uuid)
                .HasMaxLength(36)
                .HasColumnName("uuid");
            entity.Property(e => e.Absent).HasColumnName("absent");
            entity.Property(e => e.ActualWorked).HasColumnName("actual_worked");
            entity.Property(e => e.AttDate).HasColumnName("att_date");
            entity.Property(e => e.BreakTimeId)
                .HasMaxLength(36)
                .HasColumnName("break_time_id");
            entity.Property(e => e.CheckIn).HasColumnName("check_in");
            entity.Property(e => e.CheckOut).HasColumnName("check_out");
            entity.Property(e => e.ClockIn).HasColumnName("clock_in");
            entity.Property(e => e.ClockOut).HasColumnName("clock_out");
            entity.Property(e => e.DayOff).HasColumnName("day_off");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.DutyDuration).HasColumnName("duty_duration");
            entity.Property(e => e.DutyWorked).HasColumnName("duty_worked");
            entity.Property(e => e.EarlyLeave).HasColumnName("early_leave");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Exception)
                .HasMaxLength(50)
                .HasColumnName("exception");
            entity.Property(e => e.Late).HasColumnName("late");
            entity.Property(e => e.Leave).HasColumnName("leave");
            entity.Property(e => e.OvertimeId)
                .HasMaxLength(36)
                .HasColumnName("overtime_id");
            entity.Property(e => e.Remaining).HasColumnName("remaining");
            entity.Property(e => e.Short).HasColumnName("short");
            entity.Property(e => e.TimetableId).HasColumnName("timetable_id");
            entity.Property(e => e.TotalTime).HasColumnName("total_time");
            entity.Property(e => e.TotalWorked).HasColumnName("total_worked");
            entity.Property(e => e.Unscheduled).HasColumnName("unscheduled");
            entity.Property(e => e.Weekday).HasColumnName("weekday");
            entity.Property(e => e.WorkDay).HasColumnName("work_day");

            entity.HasOne(d => d.Emp).WithMany(p => p.AttPayloadbases)
                .HasForeignKey(d => d.EmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_payloadbase_emp_id_2c0f6a7b_fk_personnel_employee_id");

            entity.HasOne(d => d.Timetable).WithMany(p => p.AttPayloadbases)
                .HasForeignKey(d => d.TimetableId)
                .HasConstraintName("att_payloadbase_timetable_id_a389e3d8_fk_att_timeinterval_id");
        });

        modelBuilder.Entity<AttPayloadbreak>(entity =>
        {
            entity.HasKey(e => e.Uuid).HasName("att_payloadbreak_pkey");

            entity.ToTable("att_payloadbreak");

            entity.HasIndex(e => e.Uuid, "att_payloadbreak_uuid_533ea5e2_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.Property(e => e.Uuid)
                .HasMaxLength(36)
                .HasColumnName("uuid");
            entity.Property(e => e.Absent).HasColumnName("absent");
            entity.Property(e => e.ActualDuration).HasColumnName("actual_duration");
            entity.Property(e => e.BreakIn).HasColumnName("break_in");
            entity.Property(e => e.BreakOut).HasColumnName("break_out");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EarlyIn).HasColumnName("early_in");
            entity.Property(e => e.EarlyLeave).HasColumnName("early_leave");
            entity.Property(e => e.HolidayOt).HasColumnName("holiday_ot");
            entity.Property(e => e.Late).HasColumnName("late");
            entity.Property(e => e.LateIn).HasColumnName("late_in");
            entity.Property(e => e.Overtime).HasColumnName("overtime");
            entity.Property(e => e.Taken).HasColumnName("taken");
            entity.Property(e => e.WeekendOt).HasColumnName("weekend_ot");
            entity.Property(e => e.WorkTime).HasColumnName("work_time");
        });

        modelBuilder.Entity<AttPayloadeffectpunch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_payloadeffectpunch_pkey");

            entity.ToTable("att_payloadeffectpunch");

            entity.HasIndex(e => e.AttDate, "att_payloadeffectpunch_att_date_1e3de2d4");

            entity.HasIndex(e => e.EmpId, "att_payloadeffectpunch_emp_id_67e28e01");

            entity.HasIndex(e => e.TimeCardId, "att_payloadeffectpunch_time_card_id_52f69aaf");

            entity.HasIndex(e => e.TransId, "att_payloadeffectpunch_trans_id_94affbe6");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AdjustState)
                .HasMaxLength(5)
                .HasColumnName("adjust_state");
            entity.Property(e => e.AttDate).HasColumnName("att_date");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.PunchDate).HasColumnName("punch_date");
            entity.Property(e => e.PunchDatetime).HasColumnName("punch_datetime");
            entity.Property(e => e.PunchState)
                .HasMaxLength(5)
                .HasColumnName("punch_state");
            entity.Property(e => e.PunchTime).HasColumnName("punch_time");
            entity.Property(e => e.TimeCardId).HasColumnName("time_card_id");
            entity.Property(e => e.TransId).HasColumnName("trans_id");
            entity.Property(e => e.Week).HasColumnName("week");
            entity.Property(e => e.Weekday).HasColumnName("weekday");
            entity.Property(e => e.WorkCode)
                .HasMaxLength(20)
                .HasColumnName("work_code");

            entity.HasOne(d => d.Emp).WithMany(p => p.AttPayloadeffectpunches)
                .HasForeignKey(d => d.EmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_payloadeffectpunch_emp_id_67e28e01_fk_personnel_employee_id");

            entity.HasOne(d => d.Trans).WithMany(p => p.AttPayloadeffectpunches)
                .HasForeignKey(d => d.TransId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_payloadeffectpun_trans_id_94affbe6_fk_iclock_tr");
        });

        modelBuilder.Entity<AttPayloadexception>(entity =>
        {
            entity.HasKey(e => e.Uuid).HasName("att_payloadexception_pkey");

            entity.ToTable("att_payloadexception");

            entity.HasIndex(e => e.ItemId, "att_payloadexception_item_id_a08bfe48");

            entity.HasIndex(e => e.SkdId, "att_payloadexception_skd_id_b2e9ecaa");

            entity.HasIndex(e => e.SkdId, "att_payloadexception_skd_id_b2e9ecaa_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Uuid, "att_payloadexception_uuid_517a81e8_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.Property(e => e.Uuid)
                .HasMaxLength(36)
                .HasColumnName("uuid");
            entity.Property(e => e.DataType).HasColumnName("data_type");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.SkdId)
                .HasMaxLength(36)
                .HasColumnName("skd_id");
            entity.Property(e => e.StartTime).HasColumnName("start_time");

            entity.HasOne(d => d.Item).WithMany(p => p.AttPayloadexceptions)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("att_payloadexception_item_id_a08bfe48_fk_att_leave");
        });

        modelBuilder.Entity<AttPayloadmulpunchset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_payloadmulpunchset_pkey");

            entity.ToTable("att_payloadmulpunchset");

            entity.HasIndex(e => e.EmpId, "att_payloadmulpunchset_emp_id_f47610c8");

            entity.HasIndex(e => e.TimetableId, "att_payloadmulpunchset_timetable_id_9a439a09");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AttDate).HasColumnName("att_date");
            entity.Property(e => e.ClockIn).HasColumnName("clock_in");
            entity.Property(e => e.ClockOut).HasColumnName("clock_out");
            entity.Property(e => e.DataIndex).HasColumnName("data_index");
            entity.Property(e => e.DataType).HasColumnName("data_type");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.InId).HasColumnName("in_id");
            entity.Property(e => e.OutId).HasColumnName("out_id");
            entity.Property(e => e.TimetableId).HasColumnName("timetable_id");
            entity.Property(e => e.TotalTime).HasColumnName("total_time");
            entity.Property(e => e.Weekday).HasColumnName("weekday");
            entity.Property(e => e.WorkedTime).HasColumnName("worked_time");

            entity.HasOne(d => d.Emp).WithMany(p => p.AttPayloadmulpunchsets)
                .HasForeignKey(d => d.EmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_payloadmulpunchset_emp_id_f47610c8_fk_personnel_employee_id");
        });

        modelBuilder.Entity<AttPayloadovertime>(entity =>
        {
            entity.HasKey(e => e.Uuid).HasName("att_payloadovertime_pkey");

            entity.ToTable("att_payloadovertime");

            entity.HasIndex(e => e.Uuid, "att_payloadovertime_uuid_15d7782f_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.Property(e => e.Uuid)
                .HasMaxLength(36)
                .HasColumnName("uuid");
            entity.Property(e => e.HolidayOt).HasColumnName("holiday_ot");
            entity.Property(e => e.NormalOt).HasColumnName("normal_ot");
            entity.Property(e => e.NormalWt).HasColumnName("normal_wt");
            entity.Property(e => e.OtLv1).HasColumnName("ot_lv1");
            entity.Property(e => e.OtLv2).HasColumnName("ot_lv2");
            entity.Property(e => e.OtLv3).HasColumnName("ot_lv3");
            entity.Property(e => e.TotalOt).HasColumnName("total_ot");
            entity.Property(e => e.WeekendOt).HasColumnName("weekend_ot");
        });

        modelBuilder.Entity<AttPayloadparing>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_payloadparing_pkey");

            entity.ToTable("att_payloadparing");

            entity.HasIndex(e => e.AttDate, "att_payloadparing_att_date_5daaa45d");

            entity.HasIndex(e => e.EmpId, "att_payloadparing_emp_id_c5daac4f");

            entity.HasIndex(e => e.InTransId, "att_payloadparing_in_trans_id_50a8040e");

            entity.HasIndex(e => e.OutTransId, "att_payloadparing_out_trans_id_8b2375b9");

            entity.HasIndex(e => e.PayCodeId, "att_payloadparing_pay_code_id_aa241cca");

            entity.HasIndex(e => e.TimeCardId, "att_payloadparing_time_card_id_3adc3517");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AttDate).HasColumnName("att_date");
            entity.Property(e => e.ClockIn).HasColumnName("clock_in");
            entity.Property(e => e.ClockOut).HasColumnName("clock_out");
            entity.Property(e => e.DataIndex).HasColumnName("data_index");
            entity.Property(e => e.DataType).HasColumnName("data_type");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.InDate).HasColumnName("in_date");
            entity.Property(e => e.InTime).HasColumnName("in_time");
            entity.Property(e => e.InTransId).HasColumnName("in_trans_id");
            entity.Property(e => e.OutDate).HasColumnName("out_date");
            entity.Property(e => e.OutTime).HasColumnName("out_time");
            entity.Property(e => e.OutTransId).HasColumnName("out_trans_id");
            entity.Property(e => e.PayCodeId).HasColumnName("pay_code_id");
            entity.Property(e => e.Stamp).HasColumnName("stamp");
            entity.Property(e => e.TimeCardId).HasColumnName("time_card_id");
            entity.Property(e => e.Week).HasColumnName("week");
            entity.Property(e => e.Weekday).HasColumnName("weekday");
            entity.Property(e => e.Workday)
                .HasPrecision(4, 1)
                .HasColumnName("workday");
            entity.Property(e => e.WorkedDuration).HasColumnName("worked_duration");

            entity.HasOne(d => d.Emp).WithMany(p => p.AttPayloadparings)
                .HasForeignKey(d => d.EmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_payloadparing_emp_id_c5daac4f_fk_personnel_employee_id");

            entity.HasOne(d => d.InTrans).WithMany(p => p.AttPayloadparingInTrans)
                .HasForeignKey(d => d.InTransId)
                .HasConstraintName("att_payloadparing_in_trans_id_50a8040e_fk_iclock_transaction_id");

            entity.HasOne(d => d.OutTrans).WithMany(p => p.AttPayloadparingOutTrans)
                .HasForeignKey(d => d.OutTransId)
                .HasConstraintName("att_payloadparing_out_trans_id_8b2375b9_fk_iclock_tr");

            entity.HasOne(d => d.PayCode).WithMany(p => p.AttPayloadparings)
                .HasForeignKey(d => d.PayCodeId)
                .HasConstraintName("att_payloadparing_pay_code_id_aa241cca_fk_att_paycode_id");
        });

        modelBuilder.Entity<AttPayloadpaycode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_payloadpaycode_pkey");

            entity.ToTable("att_payloadpaycode");

            entity.HasIndex(e => e.AttDate, "att_payloadpaycode_att_date_aa048d7b");

            entity.HasIndex(e => e.EmpId, "att_payloadpaycode_emp_id_78e75279");

            entity.HasIndex(e => e.PayCodeId, "att_payloadpaycode_pay_code_id_4a096cc7");

            entity.HasIndex(e => e.ShiftId, "att_payloadpaycode_shift_id_79a0901e");

            entity.HasIndex(e => e.TimeCardId, "att_payloadpaycode_time_card_id_1696b969");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AttDate).HasColumnName("att_date");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Hours)
                .HasPrecision(6, 1)
                .HasColumnName("hours");
            entity.Property(e => e.IsException).HasColumnName("is_exception");
            entity.Property(e => e.IsWeekly).HasColumnName("is_weekly");
            entity.Property(e => e.Minutes)
                .HasPrecision(8, 1)
                .HasColumnName("minutes");
            entity.Property(e => e.PayCodeAlias)
                .HasMaxLength(50)
                .HasColumnName("pay_code_alias");
            entity.Property(e => e.PayCodeId).HasColumnName("pay_code_id");
            entity.Property(e => e.PayCodeSymbol)
                .HasMaxLength(20)
                .HasColumnName("pay_code_symbol");
            entity.Property(e => e.ShiftId).HasColumnName("shift_id");
            entity.Property(e => e.TimeCardId).HasColumnName("time_card_id");
            entity.Property(e => e.Week).HasColumnName("week");
            entity.Property(e => e.Weekday).HasColumnName("weekday");
            entity.Property(e => e.Workday)
                .HasPrecision(4, 1)
                .HasColumnName("workday");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.Emp).WithMany(p => p.AttPayloadpaycodes)
                .HasForeignKey(d => d.EmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_payloadpaycode_emp_id_78e75279_fk_personnel_employee_id");

            entity.HasOne(d => d.PayCode).WithMany(p => p.AttPayloadpaycodes)
                .HasForeignKey(d => d.PayCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_payloadpaycode_pay_code_id_4a096cc7_fk_att_paycode_id");

            entity.HasOne(d => d.Shift).WithMany(p => p.AttPayloadpaycodes)
                .HasForeignKey(d => d.ShiftId)
                .HasConstraintName("att_payloadpaycode_shift_id_79a0901e_fk_att_attshift_id");
        });

        modelBuilder.Entity<AttPayloadpunch>(entity =>
        {
            entity.HasKey(e => e.Uuid).HasName("att_payloadpunch_pkey");

            entity.ToTable("att_payloadpunch");

            entity.HasIndex(e => e.EmpId, "att_payloadpunch_emp_id_053da2f0");

            entity.HasIndex(e => e.OrigId, "att_payloadpunch_orig_id_16b26416");

            entity.HasIndex(e => e.SkdId, "att_payloadpunch_skd_id_17596d82");

            entity.HasIndex(e => e.SkdId, "att_payloadpunch_skd_id_17596d82_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Uuid, "att_payloadpunch_uuid_91e722f4_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.Property(e => e.Uuid)
                .HasMaxLength(36)
                .HasColumnName("uuid");
            entity.Property(e => e.AttDate).HasColumnName("att_date");
            entity.Property(e => e.CorrectState)
                .HasMaxLength(3)
                .HasColumnName("correct_state");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.OrigId).HasColumnName("orig_id");
            entity.Property(e => e.SkdId)
                .HasMaxLength(36)
                .HasColumnName("skd_id");

            entity.HasOne(d => d.Emp).WithMany(p => p.AttPayloadpunches)
                .HasForeignKey(d => d.EmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_payloadpunch_emp_id_053da2f0_fk_personnel_employee_id");

            entity.HasOne(d => d.Orig).WithMany(p => p.AttPayloadpunches)
                .HasForeignKey(d => d.OrigId)
                .HasConstraintName("att_payloadpunch_orig_id_16b26416_fk_iclock_transaction_id");
        });

        modelBuilder.Entity<AttPayloadtimecard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_payloadtimecard_pkey");

            entity.ToTable("att_payloadtimecard");

            entity.HasIndex(e => e.AttDate, "att_payloadtimecard_att_date_48c1dc00");

            entity.HasIndex(e => e.EmpId, "att_payloadtimecard_emp_id_47caeab4");

            entity.HasIndex(e => new { e.EmpId, e.AttDate, e.TimeTableId }, "att_payloadtimecard_emp_id_att_date_time_table_id_9df16bc5_uniq").IsUnique();

            entity.HasIndex(e => e.TimeTableId, "att_payloadtimecard_time_table_id_6e0b0137");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AttDate).HasColumnName("att_date");
            entity.Property(e => e.BreakIn).HasColumnName("break_in");
            entity.Property(e => e.BreakOut).HasColumnName("break_out");
            entity.Property(e => e.CheckIn).HasColumnName("check_in");
            entity.Property(e => e.CheckOut).HasColumnName("check_out");
            entity.Property(e => e.ClockIn).HasColumnName("clock_in");
            entity.Property(e => e.ClockOut).HasColumnName("clock_out");
            entity.Property(e => e.DateType).HasColumnName("date_type");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.FullAttendance).HasColumnName("full_attendance");
            entity.Property(e => e.LockDown).HasColumnName("lock_down");
            entity.Property(e => e.Present).HasColumnName("present");
            entity.Property(e => e.TimeTableAlias)
                .HasMaxLength(50)
                .HasColumnName("time_table_alias");
            entity.Property(e => e.TimeTableId).HasColumnName("time_table_id");
            entity.Property(e => e.Week).HasColumnName("week");
            entity.Property(e => e.Weekday).HasColumnName("weekday");
            entity.Property(e => e.WorkDay)
                .HasPrecision(4, 1)
                .HasColumnName("work_day");

            entity.HasOne(d => d.TimeTable).WithMany(p => p.AttPayloadtimecards)
                .HasForeignKey(d => d.TimeTableId)
                .HasConstraintName("att_payloadtimecard_time_table_id_6e0b0137_fk_att_timei");
        });

        modelBuilder.Entity<AttReportparam>(entity =>
        {
            entity.HasKey(e => e.ParamName).HasName("att_reportparam_pkey");

            entity.ToTable("att_reportparam");

            entity.HasIndex(e => e.ParamName, "att_reportparam_param_name_23bdf026_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.Property(e => e.ParamName)
                .HasMaxLength(20)
                .HasColumnName("param_name");
            entity.Property(e => e.ParamValue).HasColumnName("param_value");
        });

        modelBuilder.Entity<AttReporttemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_reporttemplate_pkey");

            entity.ToTable("att_reporttemplate");

            entity.HasIndex(e => e.BuilderId, "att_reporttemplate_builder_id_e1bb15c6");

            entity.HasIndex(e => e.EmployeeId, "att_reporttemplate_employee_id_4f80d866");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BuilderId).HasColumnName("builder_id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.FixedDatePeriod).HasColumnName("fixed_date_period");
            entity.Property(e => e.IsAutoExport).HasColumnName("is_auto_export");
            entity.Property(e => e.IsShare).HasColumnName("is_share");
            entity.Property(e => e.Language)
                .HasMaxLength(10)
                .HasColumnName("language");
            entity.Property(e => e.Report)
                .HasMaxLength(50)
                .HasColumnName("report");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TemplateName)
                .HasMaxLength(50)
                .HasColumnName("template_name");
            entity.Property(e => e.TemplateValue).HasColumnName("template_value");

            entity.HasOne(d => d.Builder).WithMany(p => p.AttReporttemplates)
                .HasForeignKey(d => d.BuilderId)
                .HasConstraintName("att_reporttemplate_builder_id_e1bb15c6_fk_auth_user_id");

            entity.HasOne(d => d.Employee).WithMany(p => p.AttReporttemplates)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("att_reporttemplate_employee_id_4f80d866_fk_personnel");
        });

        modelBuilder.Entity<AttShiftdetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_shiftdetail_pkey");

            entity.ToTable("att_shiftdetail");

            entity.HasIndex(e => e.ShiftId, "att_shiftdetail_shift_id_7d694501");

            entity.HasIndex(e => e.TimeIntervalId, "att_shiftdetail_time_interval_id_777dde8f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DayIndex).HasColumnName("day_index");
            entity.Property(e => e.InTime).HasColumnName("in_time");
            entity.Property(e => e.OutTime).HasColumnName("out_time");
            entity.Property(e => e.ShiftId).HasColumnName("shift_id");
            entity.Property(e => e.TimeIntervalId).HasColumnName("time_interval_id");

            entity.HasOne(d => d.Shift).WithMany(p => p.AttShiftdetails)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_shiftdetail_shift_id_7d694501_fk_att_attshift_id");

            entity.HasOne(d => d.TimeInterval).WithMany(p => p.AttShiftdetails)
                .HasForeignKey(d => d.TimeIntervalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_shiftdetail_time_interval_id_777dde8f_fk_att_timei");
        });

        modelBuilder.Entity<AttTemporaryschedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_temporaryschedule_pkey");

            entity.ToTable("att_temporaryschedule");

            entity.HasIndex(e => e.AttDate, "att_temporaryschedule_att_date_8aed8916");

            entity.HasIndex(e => e.EmployeeId, "att_temporaryschedule_employee_id_2b2b94c2");

            entity.HasIndex(e => e.TimeIntervalId, "att_temporaryschedule_time_interval_id_2be60ee4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AttDate).HasColumnName("att_date");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TimeIntervalId).HasColumnName("time_interval_id");

            entity.HasOne(d => d.Employee).WithMany(p => p.AttTemporaryschedules)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_temporaryschedul_employee_id_2b2b94c2_fk_personnel");
        });

        modelBuilder.Entity<AttTempschedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_tempschedule_pkey");

            entity.ToTable("att_tempschedule");

            entity.HasIndex(e => e.EmployeeId, "att_tempschedule_employee_id_b89c7e54");

            entity.HasIndex(e => e.TimeIntervalId, "att_tempschedule_time_interval_id_08dd8eb3");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AttDate).HasColumnName("att_date");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.RuleFlag).HasColumnName("rule_flag");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
            entity.Property(e => e.TimeIntervalId).HasColumnName("time_interval_id");
            entity.Property(e => e.WorkType).HasColumnName("work_type");

            entity.HasOne(d => d.Employee).WithMany(p => p.AttTempschedules)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_tempschedule_employee_id_b89c7e54_fk_personnel_employee_id");
        });

        modelBuilder.Entity<AttTimeinterval>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_timeinterval_pkey");

            entity.ToTable("att_timeinterval");

            entity.HasIndex(e => e.Alias, "att_timeinterval_alias_0cc89610_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Alias, "att_timeinterval_alias_key").IsUnique();

            entity.HasIndex(e => e.OtPayCodeId, "att_timeinterval_ot_pay_code_id_17438af8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .HasColumnName("alias");
            entity.Property(e => e.AllowLate).HasColumnName("allow_late");
            entity.Property(e => e.AllowLeaveEarly).HasColumnName("allow_leave_early");
            entity.Property(e => e.AvailableInterval).HasColumnName("available_interval");
            entity.Property(e => e.AvailableIntervalType).HasColumnName("available_interval_type");
            entity.Property(e => e.ColorSetting)
                .HasMaxLength(30)
                .HasColumnName("color_setting");
            entity.Property(e => e.CountEarlyInInterval).HasColumnName("count_early_in_interval");
            entity.Property(e => e.CountLateOutInterval).HasColumnName("count_late_out_interval");
            entity.Property(e => e.DayChange).HasColumnName("day_change");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EarlyIn).HasColumnName("early_in");
            entity.Property(e => e.EnableEarlyIn).HasColumnName("enable_early_in");
            entity.Property(e => e.EnableLateOut).HasColumnName("enable_late_out");
            entity.Property(e => e.EnableMaxOtLimit).HasColumnName("enable_max_ot_limit");
            entity.Property(e => e.EnableOvertime).HasColumnName("enable_overtime");
            entity.Property(e => e.FuncKey).HasColumnName("func_key");
            entity.Property(e => e.InAboveMargin).HasColumnName("in_above_margin");
            entity.Property(e => e.InAheadMargin).HasColumnName("in_ahead_margin");
            entity.Property(e => e.InRequired).HasColumnName("in_required");
            entity.Property(e => e.InTime).HasColumnName("in_time");
            entity.Property(e => e.LateOut).HasColumnName("late_out");
            entity.Property(e => e.MaxOtLimit).HasColumnName("max_ot_limit");
            entity.Property(e => e.MinEarlyIn).HasColumnName("min_early_in");
            entity.Property(e => e.MinLateOut).HasColumnName("min_late_out");
            entity.Property(e => e.MultiplePunch).HasColumnName("multiple_punch");
            entity.Property(e => e.OtPayCodeId).HasColumnName("ot_pay_code_id");
            entity.Property(e => e.OtRule).HasColumnName("ot_rule");
            entity.Property(e => e.OutAboveMargin).HasColumnName("out_above_margin");
            entity.Property(e => e.OutAheadMargin).HasColumnName("out_ahead_margin");
            entity.Property(e => e.OutRequired).HasColumnName("out_required");
            entity.Property(e => e.OvertimeLv).HasColumnName("overtime_lv");
            entity.Property(e => e.OvertimeLv1).HasColumnName("overtime_lv1");
            entity.Property(e => e.OvertimeLv2).HasColumnName("overtime_lv2");
            entity.Property(e => e.OvertimeLv3).HasColumnName("overtime_lv3");
            entity.Property(e => e.OvertimePolicy).HasColumnName("overtime_policy");
            entity.Property(e => e.UseMode).HasColumnName("use_mode");
            entity.Property(e => e.WorkDay).HasColumnName("work_day");
            entity.Property(e => e.WorkTimeDuration).HasColumnName("work_time_duration");
            entity.Property(e => e.WorkType).HasColumnName("work_type");

            entity.HasOne(d => d.OtPayCode).WithMany(p => p.AttTimeintervals)
                .HasForeignKey(d => d.OtPayCodeId)
                .HasConstraintName("att_timeinterval_ot_pay_code_id_17438af8_fk_att_paycode_id");
        });

        modelBuilder.Entity<AttTimeintervalBreakTime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("att_timeinterval_break_time_pkey");

            entity.ToTable("att_timeinterval_break_time");

            entity.HasIndex(e => new { e.TimeintervalId, e.BreaktimeId }, "att_timeinterval_break_t_timeinterval_id_breaktim_6e1bfb4e_uniq").IsUnique();

            entity.HasIndex(e => e.BreaktimeId, "att_timeinterval_break_time_breaktime_id_08462308");

            entity.HasIndex(e => e.TimeintervalId, "att_timeinterval_break_time_timeinterval_id_2287017e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BreaktimeId).HasColumnName("breaktime_id");
            entity.Property(e => e.TimeintervalId).HasColumnName("timeinterval_id");

            entity.HasOne(d => d.Breaktime).WithMany(p => p.AttTimeintervalBreakTimes)
                .HasForeignKey(d => d.BreaktimeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_timeinterval_bre_breaktime_id_08462308_fk_att_break");

            entity.HasOne(d => d.Timeinterval).WithMany(p => p.AttTimeintervalBreakTimes)
                .HasForeignKey(d => d.TimeintervalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_timeinterval_bre_timeinterval_id_2287017e_fk_att_timei");
        });

        modelBuilder.Entity<AttTraining>(entity =>
        {
            entity.HasKey(e => e.WorkflowinstancePtrId).HasName("att_training_pkey");

            entity.ToTable("att_training");

            entity.HasIndex(e => e.PayCodeId, "att_training_pay_code_id_5790afdd");

            entity.Property(e => e.WorkflowinstancePtrId)
                .ValueGeneratedNever()
                .HasColumnName("workflowinstance_ptr_id");
            entity.Property(e => e.ApplyReason).HasColumnName("apply_reason");
            entity.Property(e => e.ApplyTime).HasColumnName("apply_time");
            entity.Property(e => e.Attachment)
                .HasMaxLength(100)
                .HasColumnName("attachment");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.PayCodeId).HasColumnName("pay_code_id");
            entity.Property(e => e.StartTime).HasColumnName("start_time");

            entity.HasOne(d => d.PayCode).WithMany(p => p.AttTrainings)
                .HasForeignKey(d => d.PayCodeId)
                .HasConstraintName("att_training_pay_code_id_5790afdd_fk_att_paycode_id");

            entity.HasOne(d => d.WorkflowinstancePtr).WithOne(p => p.AttTraining)
                .HasForeignKey<AttTraining>(d => d.WorkflowinstancePtrId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_training_workflowinstance_ptr_0aef1508_fk_workflow_");
        });

        modelBuilder.Entity<AttWebpunch>(entity =>
        {
            entity.HasKey(e => e.WorkflowinstancePtrId).HasName("att_webpunch_pkey");

            entity.ToTable("att_webpunch");

            entity.Property(e => e.WorkflowinstancePtrId)
                .ValueGeneratedNever()
                .HasColumnName("workflowinstance_ptr_id");
            entity.Property(e => e.ApplyReason).HasColumnName("apply_reason");
            entity.Property(e => e.ApplyTime).HasColumnName("apply_time");
            entity.Property(e => e.PunchState)
                .HasMaxLength(5)
                .HasColumnName("punch_state");
            entity.Property(e => e.PunchTime).HasColumnName("punch_time");
            entity.Property(e => e.VerifyType).HasColumnName("verify_type");
            entity.Property(e => e.WorkCode)
                .HasMaxLength(20)
                .HasColumnName("work_code");

            entity.HasOne(d => d.WorkflowinstancePtr).WithOne(p => p.AttWebpunch)
                .HasForeignKey<AttWebpunch>(d => d.WorkflowinstancePtrId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_webpunch_workflowinstance_ptr_c5f1c02e_fk_workflow_");
        });

        modelBuilder.Entity<Attparam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("attparam_pkey");

            entity.ToTable("attparam");

            entity.HasIndex(e => new { e.Paraname, e.Paratype }, "attparam_paraname_paratype_6f176d25_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Paraname)
                .HasMaxLength(30)
                .HasColumnName("paraname");
            entity.Property(e => e.Paratype)
                .HasMaxLength(10)
                .HasColumnName("paratype");
            entity.Property(e => e.Paravalue)
                .HasMaxLength(250)
                .HasColumnName("paravalue");
        });

        modelBuilder.Entity<AuthGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_group_pkey");

            entity.ToTable("auth_group");

            entity.HasIndex(e => e.Name, "auth_group_name_a6ea08ec_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Name, "auth_group_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuthGroupPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_group_permissions_pkey");

            entity.ToTable("auth_group_permissions");

            entity.HasIndex(e => e.GroupId, "auth_group_permissions_group_id_b120cbf9");

            entity.HasIndex(e => new { e.GroupId, e.PermissionId }, "auth_group_permissions_group_id_permission_id_0cd325b0_uniq").IsUnique();

            entity.HasIndex(e => e.PermissionId, "auth_group_permissions_permission_id_84c5c92e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");

            entity.HasOne(d => d.Group).WithMany(p => p.AuthGroupPermissions)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_group_permissions_group_id_b120cbf9_fk_auth_group_id");

            entity.HasOne(d => d.Permission).WithMany(p => p.AuthGroupPermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_group_permissio_permission_id_84c5c92e_fk_auth_perm");
        });

        modelBuilder.Entity<AuthPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_permission_pkey");

            entity.ToTable("auth_permission");

            entity.HasIndex(e => e.ContentTypeId, "auth_permission_content_type_id_2f476e4b");

            entity.HasIndex(e => new { e.ContentTypeId, e.Codename }, "auth_permission_content_type_id_codename_01ab375a_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codename)
                .HasMaxLength(100)
                .HasColumnName("codename");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuthUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_user_pkey");

            entity.ToTable("auth_user");

            entity.HasIndex(e => e.Username, "auth_user_username_6821ab7c_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Username, "auth_user_username_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AuthTimeDept).HasColumnName("auth_time_dept");
            entity.Property(e => e.CanManageAllDept).HasColumnName("can_manage_all_dept");
            entity.Property(e => e.DateJoined).HasColumnName("date_joined");
            entity.Property(e => e.DelFlag).HasColumnName("del_flag");
            entity.Property(e => e.Email)
                .HasMaxLength(254)
                .HasColumnName("email");
            entity.Property(e => e.EmpPin)
                .HasMaxLength(30)
                .HasColumnName("emp_pin");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .HasColumnName("first_name");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsPublic).HasColumnName("is_public");
            entity.Property(e => e.IsStaff).HasColumnName("is_staff");
            entity.Property(e => e.IsSuperuser).HasColumnName("is_superuser");
            entity.Property(e => e.LastLogin).HasColumnName("last_login");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .HasColumnName("last_name");
            entity.Property(e => e.LoginCount).HasColumnName("login_count");
            entity.Property(e => e.LoginId).HasColumnName("login_id");
            entity.Property(e => e.LoginIp)
                .HasMaxLength(32)
                .HasColumnName("login_ip");
            entity.Property(e => e.LoginType).HasColumnName("login_type");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .HasColumnName("password");
            entity.Property(e => e.Photo)
                .HasMaxLength(200)
                .HasColumnName("photo");
            entity.Property(e => e.SessionKey)
                .HasMaxLength(32)
                .HasColumnName("session_key");
            entity.Property(e => e.TelePhone)
                .HasMaxLength(30)
                .HasColumnName("tele_phone");
            entity.Property(e => e.UpdateTime).HasColumnName("update_time");
            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .HasColumnName("username");
        });

        modelBuilder.Entity<AuthUserAuthArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_user_auth_area_pkey");

            entity.ToTable("auth_user_auth_area");

            entity.HasIndex(e => e.AreaId, "auth_user_auth_area_area_id_d1e54c70");

            entity.HasIndex(e => e.MyuserId, "auth_user_auth_area_myuser_id_5fb9a803");

            entity.HasIndex(e => new { e.MyuserId, e.AreaId }, "auth_user_auth_area_myuser_id_area_id_02a19d63_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.MyuserId).HasColumnName("myuser_id");

            entity.HasOne(d => d.Area).WithMany(p => p.AuthUserAuthAreas)
                .HasForeignKey(d => d.AreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_auth_area_area_id_d1e54c70_fk_personnel_area_id");

            entity.HasOne(d => d.Myuser).WithMany(p => p.AuthUserAuthAreas)
                .HasForeignKey(d => d.MyuserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_auth_area_myuser_id_5fb9a803_fk_auth_user_id");
        });

        modelBuilder.Entity<AuthUserAuthDept>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_user_auth_dept_pkey");

            entity.ToTable("auth_user_auth_dept");

            entity.HasIndex(e => e.DepartmentId, "auth_user_auth_dept_department_id_5866c514");

            entity.HasIndex(e => e.MyuserId, "auth_user_auth_dept_myuser_id_18a51b27");

            entity.HasIndex(e => new { e.MyuserId, e.DepartmentId }, "auth_user_auth_dept_myuser_id_department_id_61d83386_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.MyuserId).HasColumnName("myuser_id");

            entity.HasOne(d => d.Department).WithMany(p => p.AuthUserAuthDepts)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_auth_dept_department_id_5866c514_fk_personnel");

            entity.HasOne(d => d.Myuser).WithMany(p => p.AuthUserAuthDepts)
                .HasForeignKey(d => d.MyuserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_auth_dept_myuser_id_18a51b27_fk_auth_user_id");
        });

        modelBuilder.Entity<AuthUserGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_user_groups_pkey");

            entity.ToTable("auth_user_groups");

            entity.HasIndex(e => e.GroupId, "auth_user_groups_group_id_97559544");

            entity.HasIndex(e => e.MyuserId, "auth_user_groups_myuser_id_d03e8dcc");

            entity.HasIndex(e => new { e.MyuserId, e.GroupId }, "auth_user_groups_myuser_id_group_id_664bdfc3_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.MyuserId).HasColumnName("myuser_id");

            entity.HasOne(d => d.Group).WithMany(p => p.AuthUserGroups)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_groups_group_id_97559544_fk_auth_group_id");

            entity.HasOne(d => d.Myuser).WithMany(p => p.AuthUserGroups)
                .HasForeignKey(d => d.MyuserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_groups_myuser_id_d03e8dcc_fk_auth_user_id");
        });

        modelBuilder.Entity<AuthUserProfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_user_profile_pkey");

            entity.ToTable("auth_user_profile");

            entity.HasIndex(e => e.UserId, "auth_user_profile_user_id_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ColumnOrder).HasColumnName("column_order");
            entity.Property(e => e.DisabledFields).HasColumnName("disabled_fields");
            entity.Property(e => e.LoginName)
                .HasMaxLength(30)
                .HasColumnName("login_name");
            entity.Property(e => e.PinTabs).HasColumnName("pin_tabs");
            entity.Property(e => e.Preferences).HasColumnName("preferences");
            entity.Property(e => e.PwdUpdateTime).HasColumnName("pwd_update_time");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<AuthUserUserPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_user_user_permissions_pkey");

            entity.ToTable("auth_user_user_permissions");

            entity.HasIndex(e => new { e.MyuserId, e.PermissionId }, "auth_user_user_permissio_myuser_id_permission_id_a558717f_uniq").IsUnique();

            entity.HasIndex(e => e.MyuserId, "auth_user_user_permissions_myuser_id_679b1527");

            entity.HasIndex(e => e.PermissionId, "auth_user_user_permissions_permission_id_1fbb5f2c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MyuserId).HasColumnName("myuser_id");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");

            entity.HasOne(d => d.Myuser).WithMany(p => p.AuthUserUserPermissions)
                .HasForeignKey(d => d.MyuserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_user_permissions_myuser_id_679b1527_fk_auth_user_id");

            entity.HasOne(d => d.Permission).WithMany(p => p.AuthUserUserPermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_user_permi_permission_id_1fbb5f2c_fk_auth_perm");
        });

        modelBuilder.Entity<AuthtokenToken>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("authtoken_token_pkey");

            entity.ToTable("authtoken_token");

            entity.HasIndex(e => e.Key, "authtoken_token_key_10f0b77e_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.UserId, "authtoken_token_user_id_key").IsUnique();

            entity.Property(e => e.Key)
                .HasMaxLength(40)
                .HasColumnName("key");
            entity.Property(e => e.Created).HasColumnName("created");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<BaseAdminlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_adminlog_pkey");

            entity.ToTable("base_adminlog");

            entity.HasIndex(e => e.ContentTypeId, "base_adminlog_content_type_id_3e553c30");

            entity.HasIndex(e => e.UserId, "base_adminlog_user_id_ecf659f8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .HasColumnName("action");
            entity.Property(e => e.ActionStatus).HasColumnName("action_status");
            entity.Property(e => e.CanRoutable).HasColumnName("can_routable");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IpAddress).HasColumnName("ip_address");
            entity.Property(e => e.OpTime).HasColumnName("op_time");
            entity.Property(e => e.Targets).HasColumnName("targets");
            entity.Property(e => e.TargetsRepr).HasColumnName("targets_repr");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.ContentType).WithMany(p => p.BaseAdminlogs)
                .HasForeignKey(d => d.ContentTypeId)
                .HasConstraintName("base_adminlog_content_type_id_3e553c30_fk_django_co");

            entity.HasOne(d => d.User).WithMany(p => p.BaseAdminlogs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("base_adminlog_user_id_ecf659f8_fk_auth_user_id");
        });

        modelBuilder.Entity<BaseApilog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_apilog_pkey");

            entity.ToTable("base_apilog");

            entity.HasIndex(e => e.ContentTypeId, "base_apilog_content_type_id_43a54c7d");

            entity.HasIndex(e => e.UserId, "base_apilog_user_id_c9f0bf2f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .HasColumnName("action");
            entity.Property(e => e.ActionStatus).HasColumnName("action_status");
            entity.Property(e => e.CanRoutable).HasColumnName("can_routable");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IpAddress).HasColumnName("ip_address");
            entity.Property(e => e.OpTime).HasColumnName("op_time");
            entity.Property(e => e.Targets).HasColumnName("targets");
            entity.Property(e => e.TargetsRepr).HasColumnName("targets_repr");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.ContentType).WithMany(p => p.BaseApilogs)
                .HasForeignKey(d => d.ContentTypeId)
                .HasConstraintName("base_apilog_content_type_id_43a54c7d_fk_django_content_type_id");

            entity.HasOne(d => d.User).WithMany(p => p.BaseApilogs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("base_apilog_user_id_c9f0bf2f_fk_auth_user_id");
        });

        modelBuilder.Entity<BaseAttparamdept>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_attparamdepts_pkey");

            entity.ToTable("base_attparamdepts");

            entity.HasIndex(e => e.Rulename, "base_attparamdepts_rulename_922e6bf3_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Rulename, "base_attparamdepts_rulename_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Deptid).HasColumnName("deptid");
            entity.Property(e => e.Operator)
                .HasMaxLength(20)
                .HasColumnName("operator");
            entity.Property(e => e.Optime).HasColumnName("optime");
            entity.Property(e => e.Rulename)
                .HasMaxLength(40)
                .HasColumnName("rulename");
        });

        modelBuilder.Entity<BaseAutoattexporttask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_autoattexporttask_pkey");

            entity.ToTable("base_autoattexporttask");

            entity.HasIndex(e => e.TaskCode, "base_autoattexporttask_task_code_88f19bac_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.TaskCode, "base_autoattexporttask_task_code_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Enable).HasColumnName("enable");
            entity.Property(e => e.Params).HasColumnName("params");
            entity.Property(e => e.ProcessTime).HasColumnName("process_time");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TaskCode)
                .HasMaxLength(30)
                .HasColumnName("task_code");
            entity.Property(e => e.TaskName)
                .HasMaxLength(30)
                .HasColumnName("task_name");
        });

        modelBuilder.Entity<BaseAutoexporttask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_autoexporttask_pkey");

            entity.ToTable("base_autoexporttask");

            entity.HasIndex(e => e.TaskCode, "base_autoexporttask_task_code_b7fa7d4e_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.TaskCode, "base_autoexporttask_task_code_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Enable).HasColumnName("enable");
            entity.Property(e => e.Params).HasColumnName("params");
            entity.Property(e => e.ProcessTime).HasColumnName("process_time");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TaskCode)
                .HasMaxLength(30)
                .HasColumnName("task_code");
            entity.Property(e => e.TaskName)
                .HasMaxLength(30)
                .HasColumnName("task_name");
        });

        modelBuilder.Entity<BaseAutoimporttask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_autoimporttask_pkey");

            entity.ToTable("base_autoimporttask");

            entity.HasIndex(e => e.CompanyId, "base_autoimporttask_company_id_d18431a1");

            entity.HasIndex(e => e.TaskCode, "base_autoimporttask_task_code_b2760302_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.TaskCode, "base_autoimporttask_task_code_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Enable).HasColumnName("enable");
            entity.Property(e => e.Params).HasColumnName("params");
            entity.Property(e => e.ProcessTime).HasColumnName("process_time");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TaskCode)
                .HasMaxLength(30)
                .HasColumnName("task_code");
            entity.Property(e => e.TaskName)
                .HasMaxLength(30)
                .HasColumnName("task_name");

            entity.HasOne(d => d.Company).WithMany(p => p.BaseAutoimporttasks)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("base_autoimporttask_company_id_d18431a1_fk_personnel_company_id");
        });

        modelBuilder.Entity<BaseBookmark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_bookmark_pkey");

            entity.ToTable("base_bookmark");

            entity.HasIndex(e => e.ContentTypeId, "base_bookmark_content_type_id_b6a0e799");

            entity.HasIndex(e => e.UserId, "base_bookmark_user_id_5f2d5ca2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.Filters)
                .HasMaxLength(1000)
                .HasColumnName("filters");
            entity.Property(e => e.IsShare).HasColumnName("is_share");
            entity.Property(e => e.TimeSaved).HasColumnName("time_saved");
            entity.Property(e => e.Title)
                .HasMaxLength(128)
                .HasColumnName("title");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.ContentType).WithMany(p => p.BaseBookmarks)
                .HasForeignKey(d => d.ContentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("base_bookmark_content_type_id_b6a0e799_fk_django_co");

            entity.HasOne(d => d.User).WithMany(p => p.BaseBookmarks)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("base_bookmark_user_id_5f2d5ca2_fk_auth_user_id");
        });

        modelBuilder.Entity<BaseDbbackuplog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_dbbackuplog_pkey");

            entity.ToTable("base_dbbackuplog");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BackupFile)
                .HasMaxLength(100)
                .HasColumnName("backup_file");
            entity.Property(e => e.BackupStatus).HasColumnName("backup_status");
            entity.Property(e => e.BackupTime).HasColumnName("backup_time");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.DbName)
                .HasMaxLength(50)
                .HasColumnName("db_name");
            entity.Property(e => e.DbType)
                .HasMaxLength(50)
                .HasColumnName("db_type");
            entity.Property(e => e.Operator)
                .HasMaxLength(50)
                .HasColumnName("operator");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<BaseDbmigrate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_dbmigrate_pkey");

            entity.ToTable("base_dbmigrate");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<BaseEmailtemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_emailtemplate_pkey");

            entity.ToTable("base_emailtemplate");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Enable).HasColumnName("enable");
            entity.Property(e => e.Event).HasColumnName("event");
            entity.Property(e => e.Receiver).HasColumnName("receiver");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.SubCategory).HasColumnName("sub_category");
            entity.Property(e => e.Subject)
                .HasMaxLength(100)
                .HasColumnName("subject");
            entity.Property(e => e.Template).HasColumnName("template");
        });

        modelBuilder.Entity<BaseEventalertsetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_eventalertsetting_pkey");

            entity.ToTable("base_eventalertsetting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppAlert).HasColumnName("app_alert");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.EmailAlert).HasColumnName("email_alert");
            entity.Property(e => e.Event)
                .HasMaxLength(50)
                .HasColumnName("event");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.Module)
                .HasMaxLength(50)
                .HasColumnName("module");
            entity.Property(e => e.SmsAlert).HasColumnName("sms_alert");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.SubModule)
                .HasMaxLength(50)
                .HasColumnName("sub_module");
            entity.Property(e => e.WhatappAlert).HasColumnName("whatapp_alert");
        });

        modelBuilder.Entity<BaseLinenotifysetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_linenotifysetting_pkey");

            entity.ToTable("base_linenotifysetting");

            entity.HasIndex(e => e.LineNotifyDeptId, "base_linenotifysetting_line_notify_dept_id_0643a5ed");

            entity.HasIndex(e => new { e.LineNotifyDeptId, e.LineNotifyToken, e.MessageType }, "base_linenotifysetting_line_notify_dept_id_line_dd79374f_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IncludeSubDepartment).HasColumnName("include_sub_department");
            entity.Property(e => e.IsValid).HasColumnName("is_valid");
            entity.Property(e => e.LineNotifyDeptId).HasColumnName("line_notify_dept_id");
            entity.Property(e => e.LineNotifyToken)
                .HasMaxLength(200)
                .HasColumnName("line_notify_token");
            entity.Property(e => e.MessageHead)
                .HasMaxLength(100)
                .HasColumnName("message_head");
            entity.Property(e => e.MessageTail)
                .HasMaxLength(100)
                .HasColumnName("message_tail");
            entity.Property(e => e.MessageType).HasColumnName("message_type");
            entity.Property(e => e.PushTime).HasColumnName("push_time");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasColumnName("remark");

            entity.HasOne(d => d.LineNotifyDept).WithMany(p => p.BaseLinenotifysettings)
                .HasForeignKey(d => d.LineNotifyDeptId)
                .HasConstraintName("base_linenotifysetti_line_notify_dept_id_0643a5ed_fk_personnel");
        });

        modelBuilder.Entity<BaseSecuritypolicy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_securitypolicy_pkey");

            entity.ToTable("base_securitypolicy");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppSingleUserLogin).HasColumnName("app_single_user_login");
            entity.Property(e => e.CodeLength).HasColumnName("code_length");
            entity.Property(e => e.EnforcePwdChange).HasColumnName("enforce_pwd_change");
            entity.Property(e => e.EnforcePwdExpiration).HasColumnName("enforce_pwd_expiration");
            entity.Property(e => e.ExportEncryption).HasColumnName("export_encryption");
            entity.Property(e => e.ExportEncryptionPassword)
                .HasMaxLength(20)
                .HasColumnName("export_encryption_password");
            entity.Property(e => e.FailedLocked).HasColumnName("failed_locked");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.LockDuration).HasColumnName("lock_duration");
            entity.Property(e => e.LockFailedCount).HasColumnName("lock_failed_count");
            entity.Property(e => e.PasswordLevel).HasColumnName("password_level");
            entity.Property(e => e.SecurityCode).HasColumnName("security_code");
            entity.Property(e => e.SessionTimeout).HasColumnName("session_timeout");
            entity.Property(e => e.SingleLogin).HasColumnName("single_login");
            entity.Property(e => e.ValidDuration).HasColumnName("valid_duration");
            entity.Property(e => e.ValidityPeriod).HasColumnName("validity_period");
        });

        modelBuilder.Entity<BaseSendemail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_sendemail_pkey");

            entity.ToTable("base_sendemail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EmailBcc).HasColumnName("email_bcc");
            entity.Property(e => e.EmailCc).HasColumnName("email_cc");
            entity.Property(e => e.EmailContent).HasColumnName("email_content");
            entity.Property(e => e.EmailSubject)
                .HasMaxLength(40)
                .HasColumnName("email_subject");
            entity.Property(e => e.EmailTo).HasColumnName("email_to");
            entity.Property(e => e.Purpose).HasColumnName("purpose");
            entity.Property(e => e.SendStatus).HasColumnName("send_status");
            entity.Property(e => e.SendTime).HasColumnName("send_time");
        });

        modelBuilder.Entity<BaseSftpsetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_sftpsetting_pkey");

            entity.ToTable("base_sftpsetting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Host)
                .HasMaxLength(39)
                .HasColumnName("host");
            entity.Property(e => e.IsSftp).HasColumnName("is_sftp");
            entity.Property(e => e.Port).HasColumnName("port");
            entity.Property(e => e.UserKey).HasColumnName("user_key");
            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .HasColumnName("user_name");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(128)
                .HasColumnName("user_password");
        });

        modelBuilder.Entity<BaseSysparam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_sysparam_pkey");

            entity.ToTable("base_sysparam");

            entity.HasIndex(e => new { e.ParaName, e.ParaType }, "base_sysparam_para_name_para_type_3086789a_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ParaName)
                .HasMaxLength(30)
                .HasColumnName("para_name");
            entity.Property(e => e.ParaType)
                .HasMaxLength(10)
                .HasColumnName("para_type");
            entity.Property(e => e.ParaValue)
                .HasMaxLength(250)
                .HasColumnName("para_value");
        });

        modelBuilder.Entity<BaseSysparamdept>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_sysparamdept_pkey");

            entity.ToTable("base_sysparamdept");

            entity.HasIndex(e => e.RuleName, "base_sysparamdept_rule_name_bb46d5af_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.RuleName, "base_sysparamdept_rule_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DeptId).HasColumnName("dept_id");
            entity.Property(e => e.OpTime).HasColumnName("op_time");
            entity.Property(e => e.Operator)
                .HasMaxLength(20)
                .HasColumnName("operator");
            entity.Property(e => e.RuleName)
                .HasMaxLength(40)
                .HasColumnName("rule_name");
        });

        modelBuilder.Entity<BaseSystemlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_systemlog_pkey");

            entity.ToTable("base_systemlog");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.ExecuteStatus).HasColumnName("execute_status");
            entity.Property(e => e.ExecuteTime).HasColumnName("execute_time");
            entity.Property(e => e.Operation).HasColumnName("operation");
        });

        modelBuilder.Entity<BaseSystemsetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_systemsetting_pkey");

            entity.ToTable("base_systemsetting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<BaseTaskresultlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_taskresultlog_pkey");

            entity.ToTable("base_taskresultlog");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Result)
                .HasMaxLength(500)
                .HasColumnName("result");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Task)
                .HasMaxLength(50)
                .HasColumnName("task");
            entity.Property(e => e.Time).HasColumnName("time");
        });

        modelBuilder.Entity<DjangoAdminLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_admin_log_pkey");

            entity.ToTable("django_admin_log");

            entity.HasIndex(e => e.ContentTypeId, "django_admin_log_content_type_id_c4bce8eb");

            entity.HasIndex(e => e.UserId, "django_admin_log_user_id_c564eba6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionFlag).HasColumnName("action_flag");
            entity.Property(e => e.ActionTime).HasColumnName("action_time");
            entity.Property(e => e.ChangeMessage).HasColumnName("change_message");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.ObjectId).HasColumnName("object_id");
            entity.Property(e => e.ObjectRepr)
                .HasMaxLength(200)
                .HasColumnName("object_repr");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.ContentType).WithMany(p => p.DjangoAdminLogs)
                .HasForeignKey(d => d.ContentTypeId)
                .HasConstraintName("django_admin_log_content_type_id_c4bce8eb_fk_django_co");

            entity.HasOne(d => d.User).WithMany(p => p.DjangoAdminLogs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("django_admin_log_user_id_c564eba6_fk_auth_user_id");
        });

        modelBuilder.Entity<DjangoCeleryBeatClockedschedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_celery_beat_clockedschedule_pkey");

            entity.ToTable("django_celery_beat_clockedschedule");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClockedTime).HasColumnName("clocked_time");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
        });

        modelBuilder.Entity<DjangoCeleryBeatCrontabschedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_celery_beat_crontabschedule_pkey");

            entity.ToTable("django_celery_beat_crontabschedule");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DayOfMonth)
                .HasMaxLength(124)
                .HasColumnName("day_of_month");
            entity.Property(e => e.DayOfWeek)
                .HasMaxLength(64)
                .HasColumnName("day_of_week");
            entity.Property(e => e.Hour)
                .HasMaxLength(96)
                .HasColumnName("hour");
            entity.Property(e => e.Minute)
                .HasMaxLength(240)
                .HasColumnName("minute");
            entity.Property(e => e.MonthOfYear)
                .HasMaxLength(64)
                .HasColumnName("month_of_year");
            entity.Property(e => e.Timezone)
                .HasMaxLength(63)
                .HasColumnName("timezone");
        });

        modelBuilder.Entity<DjangoCeleryBeatIntervalschedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_celery_beat_intervalschedule_pkey");

            entity.ToTable("django_celery_beat_intervalschedule");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Every).HasColumnName("every");
            entity.Property(e => e.Period)
                .HasMaxLength(24)
                .HasColumnName("period");
        });

        modelBuilder.Entity<DjangoCeleryBeatPeriodictask>(entity =>
        {
            entity.HasKey(e => e.Ident).HasName("django_celery_beat_periodictasks_pkey");

            entity.ToTable("django_celery_beat_periodictasks");

            entity.Property(e => e.Ident)
                .ValueGeneratedNever()
                .HasColumnName("ident");
            entity.Property(e => e.LastUpdate).HasColumnName("last_update");
        });

        modelBuilder.Entity<DjangoCeleryBeatPeriodictask1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_celery_beat_periodictask_pkey");

            entity.ToTable("django_celery_beat_periodictask");

            entity.HasIndex(e => e.ClockedId, "django_celery_beat_periodictask_clocked_id_47a69f82");

            entity.HasIndex(e => e.CrontabId, "django_celery_beat_periodictask_crontab_id_d3cba168");

            entity.HasIndex(e => e.IntervalId, "django_celery_beat_periodictask_interval_id_a8ca27da");

            entity.HasIndex(e => e.Name, "django_celery_beat_periodictask_name_265a36b7_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Name, "django_celery_beat_periodictask_name_key").IsUnique();

            entity.HasIndex(e => e.SolarId, "django_celery_beat_periodictask_solar_id_a87ce72c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Args).HasColumnName("args");
            entity.Property(e => e.ClockedId).HasColumnName("clocked_id");
            entity.Property(e => e.CrontabId).HasColumnName("crontab_id");
            entity.Property(e => e.DateChanged).HasColumnName("date_changed");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Exchange)
                .HasMaxLength(200)
                .HasColumnName("exchange");
            entity.Property(e => e.Expires).HasColumnName("expires");
            entity.Property(e => e.Headers).HasColumnName("headers");
            entity.Property(e => e.IntervalId).HasColumnName("interval_id");
            entity.Property(e => e.Kwargs).HasColumnName("kwargs");
            entity.Property(e => e.LastRunAt).HasColumnName("last_run_at");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.OneOff).HasColumnName("one_off");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.Queue)
                .HasMaxLength(200)
                .HasColumnName("queue");
            entity.Property(e => e.RoutingKey)
                .HasMaxLength(200)
                .HasColumnName("routing_key");
            entity.Property(e => e.SolarId).HasColumnName("solar_id");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
            entity.Property(e => e.Task)
                .HasMaxLength(200)
                .HasColumnName("task");
            entity.Property(e => e.TotalRunCount).HasColumnName("total_run_count");

            entity.HasOne(d => d.Clocked).WithMany(p => p.DjangoCeleryBeatPeriodictask1s)
                .HasForeignKey(d => d.ClockedId)
                .HasConstraintName("django_celery_beat_p_clocked_id_47a69f82_fk_django_ce");

            entity.HasOne(d => d.Crontab).WithMany(p => p.DjangoCeleryBeatPeriodictask1s)
                .HasForeignKey(d => d.CrontabId)
                .HasConstraintName("django_celery_beat_p_crontab_id_d3cba168_fk_django_ce");

            entity.HasOne(d => d.Interval).WithMany(p => p.DjangoCeleryBeatPeriodictask1s)
                .HasForeignKey(d => d.IntervalId)
                .HasConstraintName("django_celery_beat_p_interval_id_a8ca27da_fk_django_ce");

            entity.HasOne(d => d.Solar).WithMany(p => p.DjangoCeleryBeatPeriodictask1s)
                .HasForeignKey(d => d.SolarId)
                .HasConstraintName("django_celery_beat_p_solar_id_a87ce72c_fk_django_ce");
        });

        modelBuilder.Entity<DjangoCeleryBeatSolarschedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_celery_beat_solarschedule_pkey");

            entity.ToTable("django_celery_beat_solarschedule");

            entity.HasIndex(e => new { e.Event, e.Latitude, e.Longitude }, "django_celery_beat_solar_event_latitude_longitude_ba64999a_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Event)
                .HasMaxLength(24)
                .HasColumnName("event");
            entity.Property(e => e.Latitude)
                .HasPrecision(9, 6)
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasPrecision(9, 6)
                .HasColumnName("longitude");
        });

        modelBuilder.Entity<DjangoContentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_content_type_pkey");

            entity.ToTable("django_content_type");

            entity.HasIndex(e => new { e.AppLabel, e.Model }, "django_content_type_app_label_model_76bd3d3b_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppLabel)
                .HasMaxLength(100)
                .HasColumnName("app_label");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .HasColumnName("model");
        });

        modelBuilder.Entity<DjangoMigration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_migrations_pkey");

            entity.ToTable("django_migrations");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.App)
                .HasMaxLength(255)
                .HasColumnName("app");
            entity.Property(e => e.Applied).HasColumnName("applied");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DjangoSession>(entity =>
        {
            entity.HasKey(e => e.SessionKey).HasName("django_session_pkey");

            entity.ToTable("django_session");

            entity.HasIndex(e => e.ExpireDate, "django_session_expire_date_a5c62663");

            entity.HasIndex(e => e.SessionKey, "django_session_session_key_c0390e0f_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.Property(e => e.SessionKey)
                .HasMaxLength(40)
                .HasColumnName("session_key");
            entity.Property(e => e.ExpireDate).HasColumnName("expire_date");
            entity.Property(e => e.SessionData).HasColumnName("session_data");
        });

        modelBuilder.Entity<EpEpsetup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ep_epsetup_pkey");

            entity.ToTable("ep_epsetup");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.MaskAlarm).HasColumnName("mask_alarm");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TempAlarm).HasColumnName("temp_alarm");
            entity.Property(e => e.TempUnit).HasColumnName("temp_unit");
            entity.Property(e => e.TempWarning)
                .HasPrecision(4, 1)
                .HasColumnName("temp_warning");
            entity.Property(e => e.TempWarningF)
                .HasPrecision(4, 1)
                .HasColumnName("temp_warning_F");
        });

        modelBuilder.Entity<EpEptransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ep_eptransaction_pkey");

            entity.ToTable("ep_eptransaction");

            entity.HasIndex(e => e.EmpId, "ep_eptransaction_emp_id_1006883f");

            entity.HasIndex(e => new { e.EmpId, e.CheckDatetime }, "ep_eptransaction_emp_id_check_datetime_57cec995_uniq").IsUnique();

            entity.HasIndex(e => e.TerminalId, "ep_eptransaction_terminal_id_4490b209");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Area)
                .HasMaxLength(30)
                .HasColumnName("area");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CheckDate).HasColumnName("check_date");
            entity.Property(e => e.CheckDatetime).HasColumnName("check_datetime");
            entity.Property(e => e.CheckTime).HasColumnName("check_time");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.EmpCode)
                .HasMaxLength(50)
                .HasColumnName("emp_code");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.IsMask).HasColumnName("is_mask");
            entity.Property(e => e.Source).HasColumnName("source");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Temperature)
                .HasPrecision(4, 1)
                .HasColumnName("temperature");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
            entity.Property(e => e.TerminalSn)
                .HasMaxLength(50)
                .HasColumnName("terminal_sn");
            entity.Property(e => e.UploadTime).HasColumnName("upload_time");

            entity.HasOne(d => d.Emp).WithMany(p => p.EpEptransactions)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("ep_eptransaction_emp_id_1006883f_fk_personnel_employee_id");

            entity.HasOne(d => d.Terminal).WithMany(p => p.EpEptransactions)
                .HasForeignKey(d => d.TerminalId)
                .HasConstraintName("ep_eptransaction_terminal_id_4490b209_fk_iclock_terminal_id");
        });

        modelBuilder.Entity<GuardianGroupobjectpermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("guardian_groupobjectpermission_pkey");

            entity.ToTable("guardian_groupobjectpermission");

            entity.HasIndex(e => new { e.GroupId, e.PermissionId, e.ObjectPk }, "guardian_groupobjectperm_group_id_permission_id_o_3f189f7c_uniq").IsUnique();

            entity.HasIndex(e => e.ContentTypeId, "guardian_groupobjectpermission_content_type_id_7ade36b8");

            entity.HasIndex(e => e.GroupId, "guardian_groupobjectpermission_group_id_4bbbfb62");

            entity.HasIndex(e => e.PermissionId, "guardian_groupobjectpermission_permission_id_36572738");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.ObjectPk)
                .HasMaxLength(255)
                .HasColumnName("object_pk");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");

            entity.HasOne(d => d.ContentType).WithMany(p => p.GuardianGroupobjectpermissions)
                .HasForeignKey(d => d.ContentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("guardian_groupobject_content_type_id_7ade36b8_fk_django_co");

            entity.HasOne(d => d.Group).WithMany(p => p.GuardianGroupobjectpermissions)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("guardian_groupobject_group_id_4bbbfb62_fk_auth_grou");

            entity.HasOne(d => d.Permission).WithMany(p => p.GuardianGroupobjectpermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("guardian_groupobject_permission_id_36572738_fk_auth_perm");
        });

        modelBuilder.Entity<GuardianUserobjectpermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("guardian_userobjectpermission_pkey");

            entity.ToTable("guardian_userobjectpermission");

            entity.HasIndex(e => new { e.UserId, e.PermissionId, e.ObjectPk }, "guardian_userobjectpermi_user_id_permission_id_ob_b0b3d2fc_uniq").IsUnique();

            entity.HasIndex(e => e.ContentTypeId, "guardian_userobjectpermission_content_type_id_2e892405");

            entity.HasIndex(e => e.PermissionId, "guardian_userobjectpermission_permission_id_71807bfc");

            entity.HasIndex(e => e.UserId, "guardian_userobjectpermission_user_id_d5c1e964");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.ObjectPk)
                .HasMaxLength(255)
                .HasColumnName("object_pk");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.ContentType).WithMany(p => p.GuardianUserobjectpermissions)
                .HasForeignKey(d => d.ContentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("guardian_userobjectp_content_type_id_2e892405_fk_django_co");

            entity.HasOne(d => d.Permission).WithMany(p => p.GuardianUserobjectpermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("guardian_userobjectp_permission_id_71807bfc_fk_auth_perm");

            entity.HasOne(d => d.User).WithMany(p => p.GuardianUserobjectpermissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("guardian_userobjectpermission_user_id_d5c1e964_fk_auth_user_id");
        });

        modelBuilder.Entity<IclockBiodatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("iclock_biodata_pkey");

            entity.ToTable("iclock_biodata");

            entity.HasIndex(e => new { e.EmployeeId, e.BioNo, e.BioIndex, e.BioType, e.BioFormat, e.MajorVer }, "iclock_biodata_employee_id_bio_no_bio_i_b71b2ca9_uniq").IsUnique();

            entity.HasIndex(e => e.EmployeeId, "iclock_biodata_employee_id_ff748ea7");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BioFormat).HasColumnName("bio_format");
            entity.Property(e => e.BioIndex).HasColumnName("bio_index");
            entity.Property(e => e.BioNo).HasColumnName("bio_no");
            entity.Property(e => e.BioTmp).HasColumnName("bio_tmp");
            entity.Property(e => e.BioType).HasColumnName("bio_type");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Duress).HasColumnName("duress");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.MajorVer)
                .HasMaxLength(30)
                .HasColumnName("major_ver");
            entity.Property(e => e.MinorVer)
                .HasMaxLength(30)
                .HasColumnName("minor_ver");
            entity.Property(e => e.Sn)
                .HasMaxLength(50)
                .HasColumnName("sn");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdateTime).HasColumnName("update_time");
            entity.Property(e => e.Valid).HasColumnName("valid");
        });

        modelBuilder.Entity<IclockBiophoto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("iclock_biophoto_pkey");

            entity.ToTable("iclock_biophoto");

            entity.HasIndex(e => e.EmployeeId, "iclock_biophoto_employee_id_3dba5819");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApprovalPhoto)
                .HasMaxLength(100)
                .HasColumnName("approval_photo");
            entity.Property(e => e.ApprovalState).HasColumnName("approval_state");
            entity.Property(e => e.ApprovalTime).HasColumnName("approval_time");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Email)
                .HasMaxLength(254)
                .HasColumnName("email");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.EnrollSn)
                .HasMaxLength(50)
                .HasColumnName("enroll_sn");
            entity.Property(e => e.FirstName)
                .HasMaxLength(25)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(25)
                .HasColumnName("last_name");
            entity.Property(e => e.RegisterPhoto)
                .HasMaxLength(100)
                .HasColumnName("register_photo");
            entity.Property(e => e.RegisterTime).HasColumnName("register_time");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Employee).WithMany(p => p.IclockBiophotos)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_biophoto_employee_id_3dba5819_fk_personnel_employee_id");
        });

        modelBuilder.Entity<IclockDevicemoduleconfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("iclock_devicemoduleconfig_pkey");

            entity.ToTable("iclock_devicemoduleconfig");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApiPolicy).HasColumnName("api_policy");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CommandRetention).HasColumnName("command_retention");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.DevLogRetention).HasColumnName("dev_log_retention");
            entity.Property(e => e.DevicePolicy).HasColumnName("device_policy");
            entity.Property(e => e.EditPolicy).HasColumnName("edit_policy");
            entity.Property(e => e.EnableAutoAdd).HasColumnName("enable_auto_add");
            entity.Property(e => e.EnableCardUpload).HasColumnName("enable_card_upload");
            entity.Property(e => e.EnableNameDownload).HasColumnName("enable_name_download");
            entity.Property(e => e.EnableNameUpload).HasColumnName("enable_name_upload");
            entity.Property(e => e.EnableRegistration).HasColumnName("enable_registration");
            entity.Property(e => e.EnableResignedFilter).HasColumnName("enable_resigned_filter");
            entity.Property(e => e.Encryption).HasColumnName("encryption");
            entity.Property(e => e.GlobalSetup).HasColumnName("global_setup");
            entity.Property(e => e.Heartbeat).HasColumnName("heartbeat");
            entity.Property(e => e.ImportPolicy).HasColumnName("import_policy");
            entity.Property(e => e.MobilePolicy).HasColumnName("mobile_policy");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.SyncMode).HasColumnName("sync_mode");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(100)
                .HasColumnName("sync_time");
            entity.Property(e => e.Timezone).HasColumnName("timezone");
            entity.Property(e => e.TransactionRetention).HasColumnName("transaction_retention");
            entity.Property(e => e.TransferInterval).HasColumnName("transfer_interval");
            entity.Property(e => e.TransferMode).HasColumnName("transfer_mode");
            entity.Property(e => e.TransferTime)
                .HasMaxLength(100)
                .HasColumnName("transfer_time");
            entity.Property(e => e.UploadLogRetention).HasColumnName("upload_log_retention");
            entity.Property(e => e.VisitorPolicy).HasColumnName("visitor_policy");
        });

        modelBuilder.Entity<IclockErrorcommandlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("iclock_errorcommandlog_pkey");

            entity.ToTable("iclock_errorcommandlog");

            entity.HasIndex(e => e.TerminalId, "iclock_errorcommandlog_terminal_id_3b2d7cbd");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Additional).HasColumnName("additional");
            entity.Property(e => e.Cmd)
                .HasMaxLength(50)
                .HasColumnName("cmd");
            entity.Property(e => e.DataOrigin).HasColumnName("data_origin");
            entity.Property(e => e.ErrorCode)
                .HasMaxLength(16)
                .HasColumnName("error_code");
            entity.Property(e => e.ErrorMsg)
                .HasMaxLength(50)
                .HasColumnName("error_msg");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
            entity.Property(e => e.UploadTime).HasColumnName("upload_time");

            entity.HasOne(d => d.Terminal).WithMany(p => p.IclockErrorcommandlogs)
                .HasForeignKey(d => d.TerminalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_errorcommandl_terminal_id_3b2d7cbd_fk_iclock_te");
        });

        modelBuilder.Entity<IclockPrivatemessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("iclock_privatemessage_pkey");

            entity.ToTable("iclock_privatemessage");

            entity.HasIndex(e => e.EmployeeId, "iclock_privatemessage_employee_id_e84a34c0");

            entity.HasIndex(e => e.MessageId, "iclock_privatemessage_message_id_e3145d3b");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.LastSend).HasColumnName("last_send");
            entity.Property(e => e.MessageId).HasColumnName("message_id");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Employee).WithMany(p => p.IclockPrivatemessages)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_privatemessag_employee_id_e84a34c0_fk_personnel");

            entity.HasOne(d => d.Message).WithMany(p => p.IclockPrivatemessages)
                .HasForeignKey(d => d.MessageId)
                .HasConstraintName("iclock_privatemessag_message_id_e3145d3b_fk_iclock_sh");
        });

        modelBuilder.Entity<IclockPublicmessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("iclock_publicmessage_pkey");

            entity.ToTable("iclock_publicmessage");

            entity.HasIndex(e => e.MessageId, "iclock_publicmessage_message_id_7d125e28");

            entity.HasIndex(e => e.TerminalId, "iclock_publicmessage_terminal_id_c3b5e4cf");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.LastSend).HasColumnName("last_send");
            entity.Property(e => e.MessageId).HasColumnName("message_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");

            entity.HasOne(d => d.Message).WithMany(p => p.IclockPublicmessages)
                .HasForeignKey(d => d.MessageId)
                .HasConstraintName("iclock_publicmessage_message_id_7d125e28_fk_iclock_sh");

            entity.HasOne(d => d.Terminal).WithMany(p => p.IclockPublicmessages)
                .HasForeignKey(d => d.TerminalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_publicmessage_terminal_id_c3b5e4cf_fk_iclock_terminal_id");
        });

        modelBuilder.Entity<IclockShortmessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("iclock_shortmessage_pkey");

            entity.ToTable("iclock_shortmessage");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.MsgType)
                .HasMaxLength(5)
                .HasColumnName("msg_type");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
        });

        modelBuilder.Entity<IclockTerminal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("iclock_terminal_pkey");

            entity.ToTable("iclock_terminal");

            entity.HasIndex(e => e.AreaId, "iclock_terminal_area_id_c019c6f0");

            entity.HasIndex(e => e.Sn, "iclock_terminal_sn_209168b1_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Sn, "iclock_terminal_sn_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .HasColumnName("alias");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.Authentication).HasColumnName("authentication");
            entity.Property(e => e.CaptureStamp)
                .HasMaxLength(30)
                .HasColumnName("capture_stamp");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.ControllerType).HasColumnName("controller_type");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.FaceAlgVer)
                .HasMaxLength(10)
                .HasColumnName("face_alg_ver");
            entity.Property(e => e.FaceCount).HasColumnName("face_count");
            entity.Property(e => e.FpAlgVer)
                .HasMaxLength(10)
                .HasColumnName("fp_alg_ver");
            entity.Property(e => e.FpCount).HasColumnName("fp_count");
            entity.Property(e => e.FvAlgVer)
                .HasMaxLength(10)
                .HasColumnName("fv_alg_ver");
            entity.Property(e => e.FvCount).HasColumnName("fv_count");
            entity.Property(e => e.FwVer)
                .HasMaxLength(100)
                .HasColumnName("fw_ver");
            entity.Property(e => e.Heartbeat).HasColumnName("heartbeat");
            entity.Property(e => e.IpAddress).HasColumnName("ip_address");
            entity.Property(e => e.IsAccess).HasColumnName("is_access");
            entity.Property(e => e.IsAttendance).HasColumnName("is_attendance");
            entity.Property(e => e.IsRegistration).HasColumnName("is_registration");
            entity.Property(e => e.IsTft).HasColumnName("is_tft");
            entity.Property(e => e.Language).HasColumnName("language");
            entity.Property(e => e.LastActivity).HasColumnName("last_activity");
            entity.Property(e => e.LockFunc).HasColumnName("lock_func");
            entity.Property(e => e.LogStamp)
                .HasMaxLength(30)
                .HasColumnName("log_stamp");
            entity.Property(e => e.OemVendor)
                .HasMaxLength(50)
                .HasColumnName("oem_vendor");
            entity.Property(e => e.OpLogStamp)
                .HasMaxLength(30)
                .HasColumnName("op_log_stamp");
            entity.Property(e => e.PalmAlgVer)
                .HasMaxLength(10)
                .HasColumnName("palm_alg_ver");
            entity.Property(e => e.PalmCount).HasColumnName("palm_count");
            entity.Property(e => e.Platform)
                .HasMaxLength(30)
                .HasColumnName("platform");
            entity.Property(e => e.ProductType).HasColumnName("product_type");
            entity.Property(e => e.Purpose).HasColumnName("purpose");
            entity.Property(e => e.PushProtocol)
                .HasMaxLength(30)
                .HasColumnName("push_protocol");
            entity.Property(e => e.PushTime).HasColumnName("push_time");
            entity.Property(e => e.PushVer)
                .HasMaxLength(30)
                .HasColumnName("push_ver");
            entity.Property(e => e.RealIp).HasColumnName("real_ip");
            entity.Property(e => e.Sn)
                .HasMaxLength(50)
                .HasColumnName("sn");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Style)
                .HasMaxLength(20)
                .HasColumnName("style");
            entity.Property(e => e.TerminalName)
                .HasMaxLength(30)
                .HasColumnName("terminal_name");
            entity.Property(e => e.TerminalTz).HasColumnName("terminal_tz");
            entity.Property(e => e.TransactionCount).HasColumnName("transaction_count");
            entity.Property(e => e.TransferInterval).HasColumnName("transfer_interval");
            entity.Property(e => e.TransferMode).HasColumnName("transfer_mode");
            entity.Property(e => e.TransferTime)
                .HasMaxLength(100)
                .HasColumnName("transfer_time");
            entity.Property(e => e.UploadFlag)
                .HasMaxLength(10)
                .HasColumnName("upload_flag");
            entity.Property(e => e.UploadTime).HasColumnName("upload_time");
            entity.Property(e => e.UserCount).HasColumnName("user_count");

            entity.HasOne(d => d.Area).WithMany(p => p.IclockTerminals)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("iclock_terminal_area_id_c019c6f0_fk_personnel_area_id");
        });

        modelBuilder.Entity<IclockTerminalcommand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("iclock_terminalcommand_pkey");

            entity.ToTable("iclock_terminalcommand");

            entity.HasIndex(e => e.TerminalId, "iclock_terminalcommand_terminal_id_3dcf836f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CommitTime).HasColumnName("commit_time");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Package).HasColumnName("package");
            entity.Property(e => e.ReturnTime).HasColumnName("return_time");
            entity.Property(e => e.ReturnValue).HasColumnName("return_value");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
            entity.Property(e => e.TransferTime).HasColumnName("transfer_time");

            entity.HasOne(d => d.Terminal).WithMany(p => p.IclockTerminalcommands)
                .HasForeignKey(d => d.TerminalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_terminalcomma_terminal_id_3dcf836f_fk_iclock_te");
        });

        modelBuilder.Entity<IclockTerminalcommandlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("iclock_terminalcommandlog_pkey");

            entity.ToTable("iclock_terminalcommandlog");

            entity.HasIndex(e => e.TerminalId, "iclock_terminalcommandlog_terminal_id_35ea8b2b");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CommitTime).HasColumnName("commit_time");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Package).HasColumnName("package");
            entity.Property(e => e.ReturnTime).HasColumnName("return_time");
            entity.Property(e => e.ReturnValue).HasColumnName("return_value");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
            entity.Property(e => e.TransferTime).HasColumnName("transfer_time");

            entity.HasOne(d => d.Terminal).WithMany(p => p.IclockTerminalcommandlogs)
                .HasForeignKey(d => d.TerminalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_terminalcomma_terminal_id_35ea8b2b_fk_iclock_te");
        });

        modelBuilder.Entity<IclockTerminalemployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("iclock_terminalemployee_pkey");

            entity.ToTable("iclock_terminalemployee");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EmpCode)
                .HasMaxLength(20)
                .HasColumnName("emp_code");
            entity.Property(e => e.Privilege).HasColumnName("privilege");
            entity.Property(e => e.TerminalSn)
                .HasMaxLength(50)
                .HasColumnName("terminal_sn");
        });

        modelBuilder.Entity<IclockTerminallog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("iclock_terminallog_pkey");

            entity.ToTable("iclock_terminallog");

            entity.HasIndex(e => e.TerminalId, "iclock_terminallog_terminal_id_667b3ea7");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionName).HasColumnName("action_name");
            entity.Property(e => e.ActionTime).HasColumnName("action_time");
            entity.Property(e => e.Admin)
                .HasMaxLength(50)
                .HasColumnName("admin");
            entity.Property(e => e.Object)
                .HasMaxLength(50)
                .HasColumnName("object");
            entity.Property(e => e.Param1).HasColumnName("param1");
            entity.Property(e => e.Param2).HasColumnName("param2");
            entity.Property(e => e.Param3).HasColumnName("param3");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
            entity.Property(e => e.TerminalTz).HasColumnName("terminal_tz");
            entity.Property(e => e.UploadTime).HasColumnName("upload_time");

            entity.HasOne(d => d.Terminal).WithMany(p => p.IclockTerminallogs)
                .HasForeignKey(d => d.TerminalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_terminallog_terminal_id_667b3ea7_fk_iclock_terminal_id");
        });

        modelBuilder.Entity<IclockTerminalparameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("iclock_terminalparameter_pkey");

            entity.ToTable("iclock_terminalparameter");

            entity.HasIndex(e => e.TerminalId, "iclock_terminalparameter_terminal_id_443872e3");

            entity.HasIndex(e => new { e.TerminalId, e.ParamName }, "iclock_terminalparameter_terminal_id_param_name_8abbb5c0_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ParamName)
                .HasMaxLength(30)
                .HasColumnName("param_name");
            entity.Property(e => e.ParamType)
                .HasMaxLength(10)
                .HasColumnName("param_type");
            entity.Property(e => e.ParamValue)
                .HasMaxLength(100)
                .HasColumnName("param_value");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");

            entity.HasOne(d => d.Terminal).WithMany(p => p.IclockTerminalparameters)
                .HasForeignKey(d => d.TerminalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_terminalparam_terminal_id_443872e3_fk_iclock_te");
        });

        modelBuilder.Entity<IclockTerminaluploadlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("iclock_terminaluploadlog_pkey");

            entity.ToTable("iclock_terminaluploadlog");

            entity.HasIndex(e => e.TerminalId, "iclock_terminaluploadlog_terminal_id_9c9a7664");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content)
                .HasMaxLength(80)
                .HasColumnName("content");
            entity.Property(e => e.ErrorCount).HasColumnName("error_count");
            entity.Property(e => e.Event)
                .HasMaxLength(80)
                .HasColumnName("event");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
            entity.Property(e => e.UploadCount).HasColumnName("upload_count");
            entity.Property(e => e.UploadTime).HasColumnName("upload_time");

            entity.HasOne(d => d.Terminal).WithMany(p => p.IclockTerminaluploadlogs)
                .HasForeignKey(d => d.TerminalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_terminaluploa_terminal_id_9c9a7664_fk_iclock_te");
        });

        modelBuilder.Entity<IclockTerminalworkcode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("iclock_terminalworkcode_pkey");

            entity.ToTable("iclock_terminalworkcode");

            entity.HasIndex(e => e.Code, "iclock_terminalworkcode_code_244e0245_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Code, "iclock_terminalworkcode_code_key").IsUnique();

            entity.HasIndex(e => e.CompanyId, "iclock_terminalworkcode_company_id_77625f26");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alias)
                .HasMaxLength(24)
                .HasColumnName("alias");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.Code)
                .HasMaxLength(8)
                .HasColumnName("code");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.LastActivity).HasColumnName("last_activity");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Company).WithMany(p => p.IclockTerminalworkcodes)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("iclock_terminalworkc_company_id_77625f26_fk_personnel");
        });

        modelBuilder.Entity<IclockTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("iclock_transaction_pkey");

            entity.ToTable("iclock_transaction");

            entity.HasIndex(e => new { e.EmpCode, e.PunchTime }, "iclock_transaction_emp_code_punch_time_ca282852_uniq").IsUnique();

            entity.HasIndex(e => e.EmpId, "iclock_transaction_emp_id_60fa3521");

            entity.HasIndex(e => e.TerminalId, "iclock_transaction_terminal_id_451c81c2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AreaAlias)
                .HasMaxLength(30)
                .HasColumnName("area_alias");
            entity.Property(e => e.Crc)
                .HasMaxLength(100)
                .HasColumnName("crc");
            entity.Property(e => e.EmpCode)
                .HasMaxLength(20)
                .HasColumnName("emp_code");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.GpsLocation).HasColumnName("gps_location");
            entity.Property(e => e.IsAttendance).HasColumnName("is_attendance");
            entity.Property(e => e.IsMask).HasColumnName("is_mask");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .HasColumnName("mobile");
            entity.Property(e => e.PunchState)
                .HasMaxLength(5)
                .HasColumnName("punch_state");
            entity.Property(e => e.PunchTime).HasColumnName("punch_time");
            entity.Property(e => e.Purpose).HasColumnName("purpose");
            entity.Property(e => e.Reserved)
                .HasMaxLength(100)
                .HasColumnName("reserved");
            entity.Property(e => e.Source).HasColumnName("source");
            entity.Property(e => e.SyncStatus).HasColumnName("sync_status");
            entity.Property(e => e.SyncTime).HasColumnName("sync_time");
            entity.Property(e => e.Temperature)
                .HasPrecision(4, 1)
                .HasColumnName("temperature");
            entity.Property(e => e.TerminalAlias)
                .HasMaxLength(50)
                .HasColumnName("terminal_alias");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
            entity.Property(e => e.TerminalSn)
                .HasMaxLength(50)
                .HasColumnName("terminal_sn");
            entity.Property(e => e.UploadTime).HasColumnName("upload_time");
            entity.Property(e => e.VerifyType).HasColumnName("verify_type");
            entity.Property(e => e.WorkCode)
                .HasMaxLength(20)
                .HasColumnName("work_code");

            entity.HasOne(d => d.Terminal).WithMany(p => p.IclockTransactions)
                .HasForeignKey(d => d.TerminalId)
                .HasConstraintName("iclock_transaction_terminal_id_451c81c2_fk_iclock_terminal_id");
        });

        modelBuilder.Entity<IclockTransactionproofcmd>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("iclock_transactionproofcmd_pkey");

            entity.ToTable("iclock_transactionproofcmd");

            entity.HasIndex(e => e.TerminalId, "iclock_transactionproofcmd_terminal_id_08b81e1e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionTime).HasColumnName("action_time");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.Flag).HasColumnName("flag");
            entity.Property(e => e.ReservedChar)
                .HasMaxLength(30)
                .HasColumnName("reserved_char");
            entity.Property(e => e.ReservedFloat).HasColumnName("reserved_float");
            entity.Property(e => e.ReservedInit).HasColumnName("reserved_init");
            entity.Property(e => e.ServerCount).HasColumnName("server_count");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
            entity.Property(e => e.TerminalCount).HasColumnName("terminal_count");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");

            entity.HasOne(d => d.Terminal).WithMany(p => p.IclockTransactionproofcmds)
                .HasForeignKey(d => d.TerminalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_transactionpr_terminal_id_08b81e1e_fk_iclock_te");
        });

        modelBuilder.Entity<IclockVisitorbiodatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("iclock_visitorbiodata_pkey");

            entity.ToTable("iclock_visitorbiodata");

            entity.HasIndex(e => new { e.VisitorId, e.BioNo, e.BioIndex, e.BioType, e.BioFormat, e.MajorVer }, "iclock_visitorbiodata_visitor_id_bio_no_bio_in_92df53c1_uniq").IsUnique();

            entity.HasIndex(e => e.VisitorId, "iclock_visitorbiodata_visitor_id_e0900ba5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BioFormat).HasColumnName("bio_format");
            entity.Property(e => e.BioIndex).HasColumnName("bio_index");
            entity.Property(e => e.BioNo).HasColumnName("bio_no");
            entity.Property(e => e.BioTmp).HasColumnName("bio_tmp");
            entity.Property(e => e.BioType).HasColumnName("bio_type");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Duress).HasColumnName("duress");
            entity.Property(e => e.MajorVer)
                .HasMaxLength(30)
                .HasColumnName("major_ver");
            entity.Property(e => e.MinorVer)
                .HasMaxLength(30)
                .HasColumnName("minor_ver");
            entity.Property(e => e.Sn)
                .HasMaxLength(50)
                .HasColumnName("sn");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdateTime).HasColumnName("update_time");
            entity.Property(e => e.Valid).HasColumnName("valid");
            entity.Property(e => e.VisitorId).HasColumnName("visitor_id");

            entity.HasOne(d => d.Visitor).WithMany(p => p.IclockVisitorbiodata)
                .HasForeignKey(d => d.VisitorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_visitorbiodata_visitor_id_e0900ba5_fk_visitor_visitor_id");
        });

        modelBuilder.Entity<MeetingMeetingentity>(entity =>
        {
            entity.HasKey(e => e.WorkflowinstancePtrId).HasName("meeting_meetingentity_pkey");

            entity.ToTable("meeting_meetingentity");

            entity.HasIndex(e => e.Code, "meeting_meetingentity_code_2fe57c62_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Code, "meeting_meetingentity_code_key").IsUnique();

            entity.HasIndex(e => e.RoomId, "meeting_meetingentity_room_id_bc2c738e");

            entity.Property(e => e.WorkflowinstancePtrId)
                .ValueGeneratedNever()
                .HasColumnName("workflowinstance_ptr_id");
            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .HasColumnName("alias");
            entity.Property(e => e.ApplyReason)
                .HasMaxLength(200)
                .HasColumnName("apply_reason");
            entity.Property(e => e.ApplyTime).HasColumnName("apply_time");
            entity.Property(e => e.AutoRecording)
                .HasMaxLength(50)
                .HasColumnName("auto_recording");
            entity.Property(e => e.CalculationTime).HasColumnName("calculation_time");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.Content)
                .HasMaxLength(200)
                .HasColumnName("content");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EnableVirtual).HasColumnName("enable_virtual");
            entity.Property(e => e.EnableWaitingRoom).HasColumnName("enable_waiting_room");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.HostVideo).HasColumnName("host_video");
            entity.Property(e => e.InEnd).HasColumnName("in_end");
            entity.Property(e => e.InRequired).HasColumnName("in_required");
            entity.Property(e => e.InStart).HasColumnName("in_start");
            entity.Property(e => e.JbhAnytime).HasColumnName("jbh_anytime");
            entity.Property(e => e.LinkData).HasColumnName("link_data");
            entity.Property(e => e.MeetingDate).HasColumnName("meeting_date");
            entity.Property(e => e.MuteUponEntry).HasColumnName("mute_upon_entry");
            entity.Property(e => e.OutEnd).HasColumnName("out_end");
            entity.Property(e => e.OutRequired).HasColumnName("out_required");
            entity.Property(e => e.OutStart).HasColumnName("out_start");
            entity.Property(e => e.ParticipantVideo).HasColumnName("participant_video");
            entity.Property(e => e.Preferences).HasColumnName("preferences");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
            entity.Property(e => e.SyncTime).HasColumnName("sync_time");
            entity.Property(e => e.TimeZone).HasColumnName("time_zone");
            entity.Property(e => e.ViewDate).HasColumnName("view_date");
            entity.Property(e => e.VirutalUuid)
                .HasMaxLength(50)
                .HasColumnName("virutal_uuid");

            entity.HasOne(d => d.Room).WithMany(p => p.MeetingMeetingentities)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("meeting_meetingentit_room_id_bc2c738e_fk_meeting_m");

            entity.HasOne(d => d.WorkflowinstancePtr).WithOne(p => p.MeetingMeetingentity)
                .HasForeignKey<MeetingMeetingentity>(d => d.WorkflowinstancePtrId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("meeting_meetingentit_workflowinstance_ptr_dbd9ab40_fk_workflow_");
        });

        modelBuilder.Entity<MeetingMeetingentityAttender>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("meeting_meetingentity_attender_pkey");

            entity.ToTable("meeting_meetingentity_attender");

            entity.HasIndex(e => new { e.MeetingentityId, e.EmployeeId }, "meeting_meetingentity_at_meetingentity_id_employe_b556fc2d_uniq").IsUnique();

            entity.HasIndex(e => e.EmployeeId, "meeting_meetingentity_attender_employee_id_ee898064");

            entity.HasIndex(e => e.MeetingentityId, "meeting_meetingentity_attender_meetingentity_id_b96dbc7d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.MeetingentityId).HasColumnName("meetingentity_id");

            entity.HasOne(d => d.Employee).WithMany(p => p.MeetingMeetingentityAttenders)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("meeting_meetingentit_employee_id_ee898064_fk_personnel");

            entity.HasOne(d => d.Meetingentity).WithMany(p => p.MeetingMeetingentityAttenders)
                .HasForeignKey(d => d.MeetingentityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("meeting_meetingentit_meetingentity_id_b96dbc7d_fk_meeting_m");
        });

        modelBuilder.Entity<MeetingMeetingmanuallog>(entity =>
        {
            entity.HasKey(e => e.WorkflowinstancePtrId).HasName("meeting_meetingmanuallog_pkey");

            entity.ToTable("meeting_meetingmanuallog");

            entity.HasIndex(e => e.MeetingId, "meeting_meetingmanuallog_meeting_id_a672eaaf");

            entity.Property(e => e.WorkflowinstancePtrId)
                .ValueGeneratedNever()
                .HasColumnName("workflowinstance_ptr_id");
            entity.Property(e => e.ApplyReason)
                .HasMaxLength(200)
                .HasColumnName("apply_reason");
            entity.Property(e => e.ApplyTime).HasColumnName("apply_time");
            entity.Property(e => e.MeetingId).HasColumnName("meeting_id");
            entity.Property(e => e.PunchState)
                .HasMaxLength(5)
                .HasColumnName("punch_state");
            entity.Property(e => e.PunchTime).HasColumnName("punch_time");

            entity.HasOne(d => d.Meeting).WithMany(p => p.MeetingMeetingmanuallogs)
                .HasForeignKey(d => d.MeetingId)
                .HasConstraintName("meeting_meetingmanua_meeting_id_a672eaaf_fk_meeting_m");

            entity.HasOne(d => d.WorkflowinstancePtr).WithOne(p => p.MeetingMeetingmanuallog)
                .HasForeignKey<MeetingMeetingmanuallog>(d => d.WorkflowinstancePtrId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("meeting_meetingmanua_workflowinstance_ptr_bd514862_fk_workflow_");
        });

        modelBuilder.Entity<MeetingMeetingpayloadbase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("meeting_meetingpayloadbase_pkey");

            entity.ToTable("meeting_meetingpayloadbase");

            entity.HasIndex(e => e.EmpId, "meeting_meetingpayloadbase_emp_id_ed6ec148");

            entity.HasIndex(e => e.MeetingId, "meeting_meetingpayloadbase_meeting_id_ca9d20cc");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Absent).HasColumnName("absent");
            entity.Property(e => e.AttendedDuration).HasColumnName("attended_duration");
            entity.Property(e => e.ClockIn).HasColumnName("clock_in");
            entity.Property(e => e.ClockOut).HasColumnName("clock_out");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EarlyOut).HasColumnName("early_out");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.LateIn).HasColumnName("late_in");
            entity.Property(e => e.MeetingDate).HasColumnName("meeting_date");
            entity.Property(e => e.MeetingId).HasColumnName("meeting_id");
            entity.Property(e => e.StartTime).HasColumnName("start_time");

            entity.HasOne(d => d.Emp).WithMany(p => p.MeetingMeetingpayloadbases)
                .HasForeignKey(d => d.EmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("meeting_meetingpaylo_emp_id_ed6ec148_fk_personnel");

            entity.HasOne(d => d.Meeting).WithMany(p => p.MeetingMeetingpayloadbases)
                .HasForeignKey(d => d.MeetingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("meeting_meetingpaylo_meeting_id_ca9d20cc_fk_meeting_m");
        });

        modelBuilder.Entity<MeetingMeetingroom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("meeting_meetingroom_pkey");

            entity.ToTable("meeting_meetingroom");

            entity.HasIndex(e => e.Code, "meeting_meetingroom_code_c3663606_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Code, "meeting_meetingroom_code_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .HasColumnName("alias");
            entity.Property(e => e.Capacity).HasColumnName("capacity");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasColumnName("code");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.EnableRoom).HasColumnName("enable_room");
            entity.Property(e => e.Location)
                .HasMaxLength(200)
                .HasColumnName("location");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<MeetingMeetingroomdevice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("meeting_meetingroomdevice_pkey");

            entity.ToTable("meeting_meetingroomdevice");

            entity.HasIndex(e => e.DeviceId, "meeting_meetingroomdevice_device_id_key").IsUnique();

            entity.HasIndex(e => e.RoomId, "meeting_meetingroomdevice_room_id_e000d78d");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DeviceId).HasColumnName("device_id");
            entity.Property(e => e.RoomId).HasColumnName("room_id");

            entity.HasOne(d => d.Device).WithOne(p => p.MeetingMeetingroomdevice)
                .HasForeignKey<MeetingMeetingroomdevice>(d => d.DeviceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("meeting_meetingroomd_device_id_a09e8a7d_fk_iclock_te");

            entity.HasOne(d => d.Room).WithMany(p => p.MeetingMeetingroomdevices)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("meeting_meetingroomd_room_id_e000d78d_fk_meeting_m");
        });

        modelBuilder.Entity<MeetingMeetingtransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("meeting_meetingtransaction_pkey");

            entity.ToTable("meeting_meetingtransaction");

            entity.HasIndex(e => e.EmpId, "meeting_meetingtransaction_emp_id_fbcdd686");

            entity.HasIndex(e => new { e.EmpId, e.PunchDatetime }, "meeting_meetingtransaction_emp_id_punch_datetime_65665dce_uniq").IsUnique();

            entity.HasIndex(e => e.MeetingId, "meeting_meetingtransaction_meeting_id_e4e505e5");

            entity.HasIndex(e => e.TerminalId, "meeting_meetingtransaction_terminal_id_047426f2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EmpCode)
                .HasMaxLength(50)
                .HasColumnName("emp_code");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.MeetingId).HasColumnName("meeting_id");
            entity.Property(e => e.PunchDate).HasColumnName("punch_date");
            entity.Property(e => e.PunchDatetime).HasColumnName("punch_datetime");
            entity.Property(e => e.PunchState)
                .HasMaxLength(5)
                .HasColumnName("punch_state");
            entity.Property(e => e.PunchTime).HasColumnName("punch_time");
            entity.Property(e => e.Source).HasColumnName("source");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
            entity.Property(e => e.UploadTime).HasColumnName("upload_time");

            entity.HasOne(d => d.Emp).WithMany(p => p.MeetingMeetingtransactions)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("meeting_meetingtrans_emp_id_fbcdd686_fk_personnel");

            entity.HasOne(d => d.Meeting).WithMany(p => p.MeetingMeetingtransactions)
                .HasForeignKey(d => d.MeetingId)
                .HasConstraintName("meeting_meetingtrans_meeting_id_e4e505e5_fk_meeting_m");

            entity.HasOne(d => d.Terminal).WithMany(p => p.MeetingMeetingtransactions)
                .HasForeignKey(d => d.TerminalId)
                .HasConstraintName("meeting_meetingtrans_terminal_id_047426f2_fk_iclock_te");
        });

        modelBuilder.Entity<MobileAnnouncement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mobile_announcement_pkey");

            entity.ToTable("mobile_announcement");

            entity.HasIndex(e => e.AdminId, "mobile_announcement_admin_id_6af3868c");

            entity.HasIndex(e => e.InitSenderId, "mobile_announcement_init_sender_id_2f5e35bd");

            entity.HasIndex(e => e.ReceiverId, "mobile_announcement_receiver_id_ddf2a860");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdminId).HasColumnName("admin_id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.InitSenderId).HasColumnName("init_sender_id");
            entity.Property(e => e.ReceiverId).HasColumnName("receiver_id");
            entity.Property(e => e.Sender)
                .HasMaxLength(50)
                .HasColumnName("sender");
            entity.Property(e => e.Subject)
                .HasMaxLength(100)
                .HasColumnName("subject");
            entity.Property(e => e.SystemSender)
                .HasMaxLength(50)
                .HasColumnName("system_sender");

            entity.HasOne(d => d.Admin).WithMany(p => p.MobileAnnouncements)
                .HasForeignKey(d => d.AdminId)
                .HasConstraintName("mobile_announcement_admin_id_6af3868c_fk_auth_user_id");

            entity.HasOne(d => d.InitSender).WithMany(p => p.MobileAnnouncementInitSenders)
                .HasForeignKey(d => d.InitSenderId)
                .HasConstraintName("mobile_announcement_init_sender_id_2f5e35bd_fk_personnel");

            entity.HasOne(d => d.Receiver).WithMany(p => p.MobileAnnouncementReceivers)
                .HasForeignKey(d => d.ReceiverId)
                .HasConstraintName("mobile_announcement_receiver_id_ddf2a860_fk_personnel");
        });

        modelBuilder.Entity<MobileAppactionlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mobile_appactionlog_pkey");

            entity.ToTable("mobile_appactionlog");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .HasColumnName("action");
            entity.Property(e => e.ActionTime).HasColumnName("action_time");
            entity.Property(e => e.Client)
                .HasMaxLength(50)
                .HasColumnName("client");
            entity.Property(e => e.Describe).HasColumnName("describe");
            entity.Property(e => e.Params).HasColumnName("params");
            entity.Property(e => e.RemoteIp)
                .HasMaxLength(20)
                .HasColumnName("remote_ip");
            entity.Property(e => e.RequestStatus).HasColumnName("request_status");
            entity.Property(e => e.User)
                .HasMaxLength(20)
                .HasColumnName("user");
        });

        modelBuilder.Entity<MobileApplist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mobile_applist_pkey");

            entity.ToTable("mobile_applist");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.ClientCategory).HasColumnName("client_category");
            entity.Property(e => e.ClientId)
                .HasMaxLength(100)
                .HasColumnName("client_id");
            entity.Property(e => e.DeviceToken).HasColumnName("device_token");
            entity.Property(e => e.Enable).HasColumnName("enable");
            entity.Property(e => e.LastActive).HasColumnName("last_active");
            entity.Property(e => e.LoginTime).HasColumnName("login_time");
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<MobileAppnotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mobile_appnotification_pkey");

            entity.ToTable("mobile_appnotification");

            entity.HasIndex(e => e.AdminId, "mobile_appnotification_admin_id_29c27197");

            entity.HasIndex(e => e.InitSenderId, "mobile_appnotification_init_sender_id_d8aff845");

            entity.HasIndex(e => e.ReceiverId, "mobile_appnotification_receiver_id_90c4a355");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdminId).HasColumnName("admin_id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.InitSenderId).HasColumnName("init_sender_id");
            entity.Property(e => e.NotificationTime).HasColumnName("notification_time");
            entity.Property(e => e.Payload).HasColumnName("payload");
            entity.Property(e => e.ReadStatus).HasColumnName("read_status");
            entity.Property(e => e.ReadTime).HasColumnName("read_time");
            entity.Property(e => e.ReceiverId).HasColumnName("receiver_id");
            entity.Property(e => e.Sender)
                .HasMaxLength(50)
                .HasColumnName("sender");
            entity.Property(e => e.Source).HasColumnName("source");
            entity.Property(e => e.SubCategory).HasColumnName("sub_category");
            entity.Property(e => e.SystemSender)
                .HasMaxLength(50)
                .HasColumnName("system_sender");

            entity.HasOne(d => d.Admin).WithMany(p => p.MobileAppnotifications)
                .HasForeignKey(d => d.AdminId)
                .HasConstraintName("mobile_appnotification_admin_id_29c27197_fk_auth_user_id");

            entity.HasOne(d => d.InitSender).WithMany(p => p.MobileAppnotificationInitSenders)
                .HasForeignKey(d => d.InitSenderId)
                .HasConstraintName("mobile_appnotificati_init_sender_id_d8aff845_fk_personnel");

            entity.HasOne(d => d.Receiver).WithMany(p => p.MobileAppnotificationReceivers)
                .HasForeignKey(d => d.ReceiverId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mobile_appnotificati_receiver_id_90c4a355_fk_personnel");
        });

        modelBuilder.Entity<MobileGpsfordepartment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mobile_gpsfordepartment_pkey");

            entity.ToTable("mobile_gpsfordepartment");

            entity.HasIndex(e => e.DepartmentId, "mobile_gpsfordepartment_department_id_988ccf22");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.Distance).HasColumnName("distance");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Department).WithMany(p => p.MobileGpsfordepartments)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mobile_gpsfordepartm_department_id_988ccf22_fk_personnel");
        });

        modelBuilder.Entity<MobileGpsfordepartmentLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mobile_gpsfordepartment_location_pkey");

            entity.ToTable("mobile_gpsfordepartment_location");

            entity.HasIndex(e => new { e.GpsfordepartmentId, e.GpslocationId }, "mobile_gpsfordepartment__gpsfordepartment_id_gpsl_58226033_uniq").IsUnique();

            entity.HasIndex(e => e.GpsfordepartmentId, "mobile_gpsfordepartment_location_gpsfordepartment_id_23e9af3a");

            entity.HasIndex(e => e.GpslocationId, "mobile_gpsfordepartment_location_gpslocation_id_48b82e9e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GpsfordepartmentId).HasColumnName("gpsfordepartment_id");
            entity.Property(e => e.GpslocationId).HasColumnName("gpslocation_id");

            entity.HasOne(d => d.Gpsfordepartment).WithMany(p => p.MobileGpsfordepartmentLocations)
                .HasForeignKey(d => d.GpsfordepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mobile_gpsfordepartm_gpsfordepartment_id_23e9af3a_fk_mobile_gp");

            entity.HasOne(d => d.Gpslocation).WithMany(p => p.MobileGpsfordepartmentLocations)
                .HasForeignKey(d => d.GpslocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mobile_gpsfordepartm_gpslocation_id_48b82e9e_fk_mobile_gp");
        });

        modelBuilder.Entity<MobileGpsforemployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mobile_gpsforemployee_pkey");

            entity.ToTable("mobile_gpsforemployee");

            entity.HasIndex(e => e.EmployeeId, "mobile_gpsforemployee_employee_id_982b7cef");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Distance).HasColumnName("distance");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Employee).WithMany(p => p.MobileGpsforemployees)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mobile_gpsforemploye_employee_id_982b7cef_fk_personnel");
        });

        modelBuilder.Entity<MobileGpsforemployeeLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mobile_gpsforemployee_location_pkey");

            entity.ToTable("mobile_gpsforemployee_location");

            entity.HasIndex(e => new { e.GpsforemployeeId, e.GpslocationId }, "mobile_gpsforemployee_lo_gpsforemployee_id_gpsloc_9ceb93bf_uniq").IsUnique();

            entity.HasIndex(e => e.GpsforemployeeId, "mobile_gpsforemployee_location_gpsforemployee_id_a52023d5");

            entity.HasIndex(e => e.GpslocationId, "mobile_gpsforemployee_location_gpslocation_id_497a214f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GpsforemployeeId).HasColumnName("gpsforemployee_id");
            entity.Property(e => e.GpslocationId).HasColumnName("gpslocation_id");

            entity.HasOne(d => d.Gpsforemployee).WithMany(p => p.MobileGpsforemployeeLocations)
                .HasForeignKey(d => d.GpsforemployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mobile_gpsforemploye_gpsforemployee_id_a52023d5_fk_mobile_gp");

            entity.HasOne(d => d.Gpslocation).WithMany(p => p.MobileGpsforemployeeLocations)
                .HasForeignKey(d => d.GpslocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mobile_gpsforemploye_gpslocation_id_497a214f_fk_mobile_gp");
        });

        modelBuilder.Entity<MobileGpslocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mobile_gpslocation_pkey");

            entity.ToTable("mobile_gpslocation");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alias)
                .HasMaxLength(100)
                .HasColumnName("alias");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .HasColumnName("location");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<MobileMobileapirequestlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mobile_mobileapirequestlog_pkey");

            entity.ToTable("mobile_mobileapirequestlog");

            entity.HasIndex(e => e.Path, "mobile_mobileapirequestlog_path_830043b5");

            entity.HasIndex(e => e.Path, "mobile_mobileapirequestlog_path_830043b5_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.RequestedAt, "mobile_mobileapirequestlog_requested_at_a8c85067");

            entity.HasIndex(e => e.StatusCode, "mobile_mobileapirequestlog_status_code_c2de0c48");

            entity.HasIndex(e => e.UserId, "mobile_mobileapirequestlog_user_id_dfd3ded1");

            entity.HasIndex(e => e.View, "mobile_mobileapirequestlog_view_50dbf600");

            entity.HasIndex(e => e.View, "mobile_mobileapirequestlog_view_50dbf600_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.ViewMethod, "mobile_mobileapirequestlog_view_method_2e13cf95");

            entity.HasIndex(e => e.ViewMethod, "mobile_mobileapirequestlog_view_method_2e13cf95_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Errors).HasColumnName("errors");
            entity.Property(e => e.Host)
                .HasMaxLength(200)
                .HasColumnName("host");
            entity.Property(e => e.Method)
                .HasMaxLength(10)
                .HasColumnName("method");
            entity.Property(e => e.Path)
                .HasMaxLength(200)
                .HasColumnName("path");
            entity.Property(e => e.QueryParams).HasColumnName("query_params");
            entity.Property(e => e.RemoteAddr).HasColumnName("remote_addr");
            entity.Property(e => e.RequestedAt).HasColumnName("requested_at");
            entity.Property(e => e.Response).HasColumnName("response");
            entity.Property(e => e.ResponseMs).HasColumnName("response_ms");
            entity.Property(e => e.StatusCode).HasColumnName("status_code");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UsernamePersistent)
                .HasMaxLength(200)
                .HasColumnName("username_persistent");
            entity.Property(e => e.View)
                .HasMaxLength(200)
                .HasColumnName("view");
            entity.Property(e => e.ViewMethod)
                .HasMaxLength(200)
                .HasColumnName("view_method");

            entity.HasOne(d => d.User).WithMany(p => p.MobileMobileapirequestlogs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("mobile_mobileapirequ_user_id_dfd3ded1_fk_personnel");
        });

        modelBuilder.Entity<PayrollDeductionformula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payroll_deductionformula_pkey");

            entity.ToTable("payroll_deductionformula");

            entity.HasIndex(e => e.Name, "payroll_deductionformula_name_735ae7f7_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Name, "payroll_deductionformula_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Formula)
                .HasMaxLength(100)
                .HasColumnName("formula");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.Remark).HasColumnName("remark");
        });

        modelBuilder.Entity<PayrollEmploan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payroll_emploan_pkey");

            entity.ToTable("payroll_emploan");

            entity.HasIndex(e => e.EmployeeId, "payroll_emploan_employee_id_97a251ef");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.LoanAmount).HasColumnName("loan_amount");
            entity.Property(e => e.LoanCleanTime).HasColumnName("loan_clean_time");
            entity.Property(e => e.LoanTime).HasColumnName("loan_time");
            entity.Property(e => e.PerCycleRefund).HasColumnName("per_cycle_refund");
            entity.Property(e => e.RefundCycle).HasColumnName("refund_cycle");
            entity.Property(e => e.Remark)
                .HasMaxLength(300)
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Employee).WithMany(p => p.PayrollEmploans)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("payroll_emploan_employee_id_97a251ef_fk_personnel_employee_id");
        });

        modelBuilder.Entity<PayrollEmppayrollprofile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payroll_emppayrollprofile_pkey");

            entity.ToTable("payroll_emppayrollprofile");

            entity.HasIndex(e => e.EmployeeId, "payroll_emppayrollprofile_employee_id_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AgentAccount)
                .HasMaxLength(30)
                .HasColumnName("agent_account");
            entity.Property(e => e.AgentId)
                .HasMaxLength(30)
                .HasColumnName("agent_id");
            entity.Property(e => e.BankAccount)
                .HasMaxLength(30)
                .HasColumnName("bank_account");
            entity.Property(e => e.BankName)
                .HasMaxLength(30)
                .HasColumnName("bank_name");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.PaymentMode).HasColumnName("payment_mode");
            entity.Property(e => e.PaymentType).HasColumnName("payment_type");
            entity.Property(e => e.PersonnelId)
                .HasMaxLength(30)
                .HasColumnName("personnel_id");
        });

        modelBuilder.Entity<PayrollExceptionformula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payroll_exceptionformula_pkey");

            entity.ToTable("payroll_exceptionformula");

            entity.HasIndex(e => e.Name, "payroll_exceptionformula_name_e09c7463_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Name, "payroll_exceptionformula_name_key").IsUnique();

            entity.HasIndex(e => e.PayCodeId, "payroll_exceptionformula_pay_code_id_97609b51");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Formula)
                .HasMaxLength(100)
                .HasColumnName("formula");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.PayCodeId).HasColumnName("pay_code_id");
            entity.Property(e => e.Remark).HasColumnName("remark");

            entity.HasOne(d => d.PayCode).WithMany(p => p.PayrollExceptionformulas)
                .HasForeignKey(d => d.PayCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_exceptionformula_pay_code_id_97609b51_fk_att_paycode_id");
        });

        modelBuilder.Entity<PayrollExtradeduction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payroll_extradeduction_pkey");

            entity.ToTable("payroll_extradeduction");

            entity.HasIndex(e => e.EmployeeId, "payroll_extradeduction_employee_id_53072441");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.IssuedTime).HasColumnName("issued_time");
            entity.Property(e => e.Remark)
                .HasMaxLength(300)
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Employee).WithMany(p => p.PayrollExtradeductions)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("payroll_extradeducti_employee_id_53072441_fk_personnel");
        });

        modelBuilder.Entity<PayrollExtraincrease>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payroll_extraincrease_pkey");

            entity.ToTable("payroll_extraincrease");

            entity.HasIndex(e => e.EmployeeId, "payroll_extraincrease_employee_id_f902e6bb");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.IssuedTime).HasColumnName("issued_time");
            entity.Property(e => e.Remark)
                .HasMaxLength(300)
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Employee).WithMany(p => p.PayrollExtraincreases)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("payroll_extraincreas_employee_id_f902e6bb_fk_personnel");
        });

        modelBuilder.Entity<PayrollIncreasementformula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payroll_increasementformula_pkey");

            entity.ToTable("payroll_increasementformula");

            entity.HasIndex(e => e.Name, "payroll_increasementformula_name_ba17a9a3_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Name, "payroll_increasementformula_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Formula)
                .HasMaxLength(100)
                .HasColumnName("formula");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.Remark).HasColumnName("remark");
        });

        modelBuilder.Entity<PayrollLeaveformula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payroll_leaveformula_pkey");

            entity.ToTable("payroll_leaveformula");

            entity.HasIndex(e => e.Name, "payroll_leaveformula_name_f0ab005b_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Name, "payroll_leaveformula_name_key").IsUnique();

            entity.HasIndex(e => e.PayCodeId, "payroll_leaveformula_pay_code_id_63c7b4bd");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Formula)
                .HasMaxLength(100)
                .HasColumnName("formula");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.PayCodeId).HasColumnName("pay_code_id");
            entity.Property(e => e.Remark).HasColumnName("remark");

            entity.HasOne(d => d.PayCode).WithMany(p => p.PayrollLeaveformulas)
                .HasForeignKey(d => d.PayCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_leaveformula_pay_code_id_63c7b4bd_fk_att_paycode_id");
        });

        modelBuilder.Entity<PayrollOvertimeformula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payroll_overtimeformula_pkey");

            entity.ToTable("payroll_overtimeformula");

            entity.HasIndex(e => e.Name, "payroll_overtimeformula_name_6f2f3ff3_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Name, "payroll_overtimeformula_name_key").IsUnique();

            entity.HasIndex(e => e.PayCodeId, "payroll_overtimeformula_pay_code_id_36d2f10e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Formula)
                .HasMaxLength(100)
                .HasColumnName("formula");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.PayCodeId).HasColumnName("pay_code_id");
            entity.Property(e => e.Remark).HasColumnName("remark");

            entity.HasOne(d => d.PayCode).WithMany(p => p.PayrollOvertimeformulas)
                .HasForeignKey(d => d.PayCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_overtimeformula_pay_code_id_36d2f10e_fk_att_paycode_id");
        });

        modelBuilder.Entity<PayrollPayrollpayload>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payroll_payrollpayload_pkey");

            entity.ToTable("payroll_payrollpayload");

            entity.HasIndex(e => e.EmployeeId, "payroll_payrollpayload_employee_id_bc868f2b");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdvanceDeduction).HasColumnName("advance_deduction");
            entity.Property(e => e.AdvanceIncrease).HasColumnName("advance_increase");
            entity.Property(e => e.BasicSalary).HasColumnName("basic_salary");
            entity.Property(e => e.CalcTime).HasColumnName("calc_time");
            entity.Property(e => e.Deduction).HasColumnName("deduction");
            entity.Property(e => e.DeductionFormula).HasColumnName("deduction_formula");
            entity.Property(e => e.DeductionFormulaName).HasColumnName("deduction_formula_name");
            entity.Property(e => e.EffectiveDate).HasColumnName("effective_date");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.ExtraDeduction).HasColumnName("extra_deduction");
            entity.Property(e => e.ExtraIncrease).HasColumnName("extra_increase");
            entity.Property(e => e.FormatDict).HasColumnName("format_dict");
            entity.Property(e => e.Increase).HasColumnName("increase");
            entity.Property(e => e.IncreaseFormula).HasColumnName("increase_formula");
            entity.Property(e => e.IncreaseFormulaName).HasColumnName("increase_formula_name");
            entity.Property(e => e.LoanDeduction).HasColumnName("loan_deduction");
            entity.Property(e => e.LoanIncrease).HasColumnName("loan_increase");
            entity.Property(e => e.PaymentMode).HasColumnName("payment_mode");
            entity.Property(e => e.RefundLoanAmount).HasColumnName("refund_loan_amount");
            entity.Property(e => e.Reimbursement).HasColumnName("reimbursement");
            entity.Property(e => e.TotalDeduction).HasColumnName("total_deduction");
            entity.Property(e => e.TotalDeductionExpression).HasColumnName("total_deduction_expression");
            entity.Property(e => e.TotalDeductionFormula).HasColumnName("total_deduction_formula");
            entity.Property(e => e.TotalDeductionFormulaName).HasColumnName("total_deduction_formula_name");
            entity.Property(e => e.TotalIncrease).HasColumnName("total_increase");
            entity.Property(e => e.TotalIncreaseExpression).HasColumnName("total_increase_expression");
            entity.Property(e => e.TotalIncreaseFormula).HasColumnName("total_increase_formula");
            entity.Property(e => e.TotalIncreaseFormulaName).HasColumnName("total_increase_formula_name");
            entity.Property(e => e.TotalLoanAmount).HasColumnName("total_loan_amount");
            entity.Property(e => e.TotalSalary).HasColumnName("total_salary");
            entity.Property(e => e.TotalSalaryExpression).HasColumnName("total_salary_expression");
            entity.Property(e => e.UnrefundLoanAmount).HasColumnName("unrefund_loan_amount");

            entity.HasOne(d => d.Employee).WithMany(p => p.PayrollPayrollpayloads)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_payrollpaylo_employee_id_bc868f2b_fk_personnel");
        });

        modelBuilder.Entity<PayrollPayrollpayloadpaycode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payroll_payrollpayloadpaycode_pkey");

            entity.ToTable("payroll_payrollpayloadpaycode");

            entity.HasIndex(e => e.PayCodeId, "payroll_payrollpayloadpaycode_pay_code_id_c057af1f");

            entity.HasIndex(e => e.PayloadId, "payroll_payrollpayloadpaycode_payload_id_f085c4e8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Formula).HasColumnName("formula");
            entity.Property(e => e.FormulaName).HasColumnName("formula_name");
            entity.Property(e => e.PayCodeId).HasColumnName("pay_code_id");
            entity.Property(e => e.PayloadId).HasColumnName("payload_id");

            entity.HasOne(d => d.PayCode).WithMany(p => p.PayrollPayrollpayloadpaycodes)
                .HasForeignKey(d => d.PayCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_payrollpaylo_pay_code_id_c057af1f_fk_att_payco");

            entity.HasOne(d => d.Payload).WithMany(p => p.PayrollPayrollpayloadpaycodes)
                .HasForeignKey(d => d.PayloadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_payrollpaylo_payload_id_f085c4e8_fk_payroll_p");
        });

        modelBuilder.Entity<PayrollReimbursement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payroll_reimbursement_pkey");

            entity.ToTable("payroll_reimbursement");

            entity.HasIndex(e => e.EmployeeId, "payroll_reimbursement_employee_id_c4bbde36");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.RmbAmount).HasColumnName("rmb_amount");
            entity.Property(e => e.RmbFile)
                .HasMaxLength(200)
                .HasColumnName("rmb_file");
            entity.Property(e => e.RmbRemark)
                .HasMaxLength(300)
                .HasColumnName("rmb_remark");
            entity.Property(e => e.RmbTime).HasColumnName("rmb_time");

            entity.HasOne(d => d.Employee).WithMany(p => p.PayrollReimbursements)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("payroll_reimbursemen_employee_id_c4bbde36_fk_personnel");
        });

        modelBuilder.Entity<PayrollSalaryadvance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payroll_salaryadvance_pkey");

            entity.ToTable("payroll_salaryadvance");

            entity.HasIndex(e => e.EmployeeId, "payroll_salaryadvance_employee_id_2abd43e5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdvanceAmount).HasColumnName("advance_amount");
            entity.Property(e => e.AdvanceRemark)
                .HasMaxLength(300)
                .HasColumnName("advance_remark");
            entity.Property(e => e.AdvanceTime).HasColumnName("advance_time");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

            entity.HasOne(d => d.Employee).WithMany(p => p.PayrollSalaryadvances)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("payroll_salaryadvanc_employee_id_2abd43e5_fk_personnel");
        });

        modelBuilder.Entity<PayrollSalarystructure>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payroll_salarystructure_pkey");

            entity.ToTable("payroll_salarystructure");

            entity.HasIndex(e => e.EmployeeId, "payroll_salarystructure_employee_id_98996e15");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.EffectiveDate).HasColumnName("effective_date");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.SalaryAmount).HasColumnName("salary_amount");
            entity.Property(e => e.SalaryRemark)
                .HasMaxLength(300)
                .HasColumnName("salary_remark");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Employee).WithMany(p => p.PayrollSalarystructures)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("payroll_salarystruct_employee_id_98996e15_fk_personnel");
        });

        modelBuilder.Entity<PayrollSalarystructureDeductionformula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payroll_salarystructure_deductionformula_pkey");

            entity.ToTable("payroll_salarystructure_deductionformula");

            entity.HasIndex(e => new { e.SalarystructureId, e.DeductionformulaId }, "payroll_salarystructure__salarystructure_id_deduc_794e8449_uniq").IsUnique();

            entity.HasIndex(e => e.DeductionformulaId, "payroll_salarystructure_de_deductionformula_id_b174d5b6");

            entity.HasIndex(e => e.SalarystructureId, "payroll_salarystructure_de_salarystructure_id_5ca7cdb5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DeductionformulaId).HasColumnName("deductionformula_id");
            entity.Property(e => e.SalarystructureId).HasColumnName("salarystructure_id");

            entity.HasOne(d => d.Deductionformula).WithMany(p => p.PayrollSalarystructureDeductionformulas)
                .HasForeignKey(d => d.DeductionformulaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_salarystruct_deductionformula_id_b174d5b6_fk_payroll_d");

            entity.HasOne(d => d.Salarystructure).WithMany(p => p.PayrollSalarystructureDeductionformulas)
                .HasForeignKey(d => d.SalarystructureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_salarystruct_salarystructure_id_5ca7cdb5_fk_payroll_s");
        });

        modelBuilder.Entity<PayrollSalarystructureExceptionformula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payroll_salarystructure_exceptionformula_pkey");

            entity.ToTable("payroll_salarystructure_exceptionformula");

            entity.HasIndex(e => new { e.SalarystructureId, e.ExceptionformulaId }, "payroll_salarystructure__salarystructure_id_excep_a5e869ff_uniq").IsUnique();

            entity.HasIndex(e => e.ExceptionformulaId, "payroll_salarystructure_ex_exceptionformula_id_8f6dadb3");

            entity.HasIndex(e => e.SalarystructureId, "payroll_salarystructure_ex_salarystructure_id_3c087208");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ExceptionformulaId).HasColumnName("exceptionformula_id");
            entity.Property(e => e.SalarystructureId).HasColumnName("salarystructure_id");

            entity.HasOne(d => d.Exceptionformula).WithMany(p => p.PayrollSalarystructureExceptionformulas)
                .HasForeignKey(d => d.ExceptionformulaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_salarystruct_exceptionformula_id_8f6dadb3_fk_payroll_e");

            entity.HasOne(d => d.Salarystructure).WithMany(p => p.PayrollSalarystructureExceptionformulas)
                .HasForeignKey(d => d.SalarystructureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_salarystruct_salarystructure_id_3c087208_fk_payroll_s");
        });

        modelBuilder.Entity<PayrollSalarystructureIncreasementformula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payroll_salarystructure_increasementformula_pkey");

            entity.ToTable("payroll_salarystructure_increasementformula");

            entity.HasIndex(e => new { e.SalarystructureId, e.IncreasementformulaId }, "payroll_salarystructure__salarystructure_id_incre_749132b3_uniq").IsUnique();

            entity.HasIndex(e => e.IncreasementformulaId, "payroll_salarystructure_in_increasementformula_id_3cd77082");

            entity.HasIndex(e => e.SalarystructureId, "payroll_salarystructure_in_salarystructure_id_8752401c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IncreasementformulaId).HasColumnName("increasementformula_id");
            entity.Property(e => e.SalarystructureId).HasColumnName("salarystructure_id");

            entity.HasOne(d => d.Increasementformula).WithMany(p => p.PayrollSalarystructureIncreasementformulas)
                .HasForeignKey(d => d.IncreasementformulaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_salarystruct_increasementformula__3cd77082_fk_payroll_i");

            entity.HasOne(d => d.Salarystructure).WithMany(p => p.PayrollSalarystructureIncreasementformulas)
                .HasForeignKey(d => d.SalarystructureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_salarystruct_salarystructure_id_8752401c_fk_payroll_s");
        });

        modelBuilder.Entity<PayrollSalarystructureLeaveformula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payroll_salarystructure_leaveformula_pkey");

            entity.ToTable("payroll_salarystructure_leaveformula");

            entity.HasIndex(e => new { e.SalarystructureId, e.LeaveformulaId }, "payroll_salarystructure__salarystructure_id_leave_4efdce30_uniq").IsUnique();

            entity.HasIndex(e => e.SalarystructureId, "payroll_salarystructure_le_salarystructure_id_cf98fdd7");

            entity.HasIndex(e => e.LeaveformulaId, "payroll_salarystructure_leaveformula_leaveformula_id_049f9024");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LeaveformulaId).HasColumnName("leaveformula_id");
            entity.Property(e => e.SalarystructureId).HasColumnName("salarystructure_id");

            entity.HasOne(d => d.Leaveformula).WithMany(p => p.PayrollSalarystructureLeaveformulas)
                .HasForeignKey(d => d.LeaveformulaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_salarystruct_leaveformula_id_049f9024_fk_payroll_l");

            entity.HasOne(d => d.Salarystructure).WithMany(p => p.PayrollSalarystructureLeaveformulas)
                .HasForeignKey(d => d.SalarystructureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_salarystruct_salarystructure_id_cf98fdd7_fk_payroll_s");
        });

        modelBuilder.Entity<PayrollSalarystructureOvertimeformula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("payroll_salarystructure_overtimeformula_pkey");

            entity.ToTable("payroll_salarystructure_overtimeformula");

            entity.HasIndex(e => new { e.SalarystructureId, e.OvertimeformulaId }, "payroll_salarystructure__salarystructure_id_overt_0d0a0e81_uniq").IsUnique();

            entity.HasIndex(e => e.OvertimeformulaId, "payroll_salarystructure_ov_overtimeformula_id_40ad89ef");

            entity.HasIndex(e => e.SalarystructureId, "payroll_salarystructure_ov_salarystructure_id_64f75042");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OvertimeformulaId).HasColumnName("overtimeformula_id");
            entity.Property(e => e.SalarystructureId).HasColumnName("salarystructure_id");

            entity.HasOne(d => d.Overtimeformula).WithMany(p => p.PayrollSalarystructureOvertimeformulas)
                .HasForeignKey(d => d.OvertimeformulaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_salarystruct_overtimeformula_id_40ad89ef_fk_payroll_o");

            entity.HasOne(d => d.Salarystructure).WithMany(p => p.PayrollSalarystructureOvertimeformulas)
                .HasForeignKey(d => d.SalarystructureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_salarystruct_salarystructure_id_64f75042_fk_payroll_s");
        });

        modelBuilder.Entity<PersonnelArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("personnel_area_pkey");

            entity.ToTable("personnel_area");

            entity.HasIndex(e => e.CompanyId, "personnel_area_company_id_59750eb5");

            entity.HasIndex(e => new { e.CompanyId, e.AreaCode }, "personnel_area_company_id_area_code_aa39c55c_uniq").IsUnique();

            entity.HasIndex(e => e.ParentAreaId, "personnel_area_parent_area_id_39028fda");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(30)
                .HasColumnName("area_code");
            entity.Property(e => e.AreaName)
                .HasMaxLength(30)
                .HasColumnName("area_name");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.ParentAreaId).HasColumnName("parent_area_id");

            entity.HasOne(d => d.Company).WithMany(p => p.PersonnelAreas)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_area_company_id_59750eb5_fk_personnel_company_id");

            entity.HasOne(d => d.ParentArea).WithMany(p => p.InverseParentArea)
                .HasForeignKey(d => d.ParentAreaId)
                .HasConstraintName("personnel_area_parent_area_id_39028fda_fk_personnel_area_id");
        });

        modelBuilder.Entity<PersonnelAssignareaemployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("personnel_assignareaemployee_pkey");

            entity.ToTable("personnel_assignareaemployee");

            entity.HasIndex(e => e.AreaId, "personnel_assignareaemployee_area_id_6f049d6a");

            entity.HasIndex(e => e.EmployeeId, "personnel_assignareaemployee_employee_id_a3d4dd25");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.AssignedTime).HasColumnName("assigned_time");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

            entity.HasOne(d => d.Area).WithMany(p => p.PersonnelAssignareaemployees)
                .HasForeignKey(d => d.AreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_assignarea_area_id_6f049d6a_fk_personnel");

            entity.HasOne(d => d.Employee).WithMany(p => p.PersonnelAssignareaemployees)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_assignarea_employee_id_a3d4dd25_fk_personnel");
        });

        modelBuilder.Entity<PersonnelCertification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("personnel_certification_pkey");

            entity.ToTable("personnel_certification");

            entity.HasIndex(e => e.CertCode, "personnel_certification_cert_code_8ba51387_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.CertCode, "personnel_certification_cert_code_key").IsUnique();

            entity.HasIndex(e => e.CertName, "personnel_certification_cert_name_67dacd72_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.CertName, "personnel_certification_cert_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CertCode)
                .HasMaxLength(20)
                .HasColumnName("cert_code");
            entity.Property(e => e.CertName)
                .HasMaxLength(50)
                .HasColumnName("cert_name");
        });

        modelBuilder.Entity<PersonnelCompany>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("personnel_company_pkey");

            entity.ToTable("personnel_company");

            entity.HasIndex(e => e.CompanyCode, "personnel_company_company_code_537dca09_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.CompanyCode, "personnel_company_company_code_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(50)
                .HasColumnName("company_code");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .HasColumnName("company_name");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
        });

        modelBuilder.Entity<PersonnelDepartment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("personnel_department_pkey");

            entity.ToTable("personnel_department");

            entity.HasIndex(e => e.CompanyId, "personnel_department_company_id_00867fd8");

            entity.HasIndex(e => new { e.CompanyId, e.DeptCode }, "personnel_department_company_id_dept_code_dfa8fff7_uniq").IsUnique();

            entity.HasIndex(e => e.DeptManagerId, "personnel_department_dept_manager_id_c5124a7d");

            entity.HasIndex(e => e.ParentDeptId, "personnel_department_parent_dept_id_d0b44024");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.DeptCode)
                .HasMaxLength(50)
                .HasColumnName("dept_code");
            entity.Property(e => e.DeptManagerId).HasColumnName("dept_manager_id");
            entity.Property(e => e.DeptName)
                .HasMaxLength(100)
                .HasColumnName("dept_name");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.ParentDeptId).HasColumnName("parent_dept_id");

            entity.HasOne(d => d.Company).WithMany(p => p.PersonnelDepartments)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_department_company_id_00867fd8_fk_personnel");

            entity.HasOne(d => d.DeptManager).WithMany(p => p.PersonnelDepartments)
                .HasForeignKey(d => d.DeptManagerId)
                .HasConstraintName("personnel_department_dept_manager_id_c5124a7d_fk_personnel");

            entity.HasOne(d => d.ParentDept).WithMany(p => p.InverseParentDept)
                .HasForeignKey(d => d.ParentDeptId)
                .HasConstraintName("personnel_department_parent_dept_id_d0b44024_fk_personnel");
        });

        modelBuilder.Entity<PersonnelEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("personnel_employee_pkey");

            entity.ToTable("personnel_employee");

            entity.HasIndex(e => e.DepartmentId, "personnel_employee_department_id_068bbd08");

            entity.HasIndex(e => e.EmpCode, "personnel_employee_emp_code_740b0387_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.EmpCode, "personnel_employee_emp_code_key").IsUnique();

            entity.HasIndex(e => e.PositionId, "personnel_employee_position_id_c9321343");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccGroup)
                .HasMaxLength(5)
                .HasColumnName("acc_group");
            entity.Property(e => e.AccTimezone)
                .HasMaxLength(20)
                .HasColumnName("acc_timezone");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .HasColumnName("address");
            entity.Property(e => e.AppRole).HasColumnName("app_role");
            entity.Property(e => e.AppStatus).HasColumnName("app_status");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.CardNo)
                .HasMaxLength(20)
                .HasColumnName("card_no");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .HasColumnName("city");
            entity.Property(e => e.ContactTel)
                .HasMaxLength(20)
                .HasColumnName("contact_tel");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.DelTag).HasColumnName("del_tag");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.DevPrivilege).HasColumnName("dev_privilege");
            entity.Property(e => e.DevicePassword)
                .HasMaxLength(20)
                .HasColumnName("device_password");
            entity.Property(e => e.DriverLicenseAutomobile)
                .HasMaxLength(30)
                .HasColumnName("driver_license_automobile");
            entity.Property(e => e.DriverLicenseMotorcycle)
                .HasMaxLength(30)
                .HasColumnName("driver_license_motorcycle");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.EmpCode)
                .HasMaxLength(20)
                .HasColumnName("emp_code");
            entity.Property(e => e.EmpType).HasColumnName("emp_type");
            entity.Property(e => e.EnablePayroll).HasColumnName("enable_payroll");
            entity.Property(e => e.EnrollSn)
                .HasMaxLength(20)
                .HasColumnName("enroll_sn");
            entity.Property(e => e.FirstName)
                .HasMaxLength(25)
                .HasColumnName("first_name");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .HasColumnName("gender");
            entity.Property(e => e.HireDate).HasColumnName("hire_date");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsAdmin).HasColumnName("is_admin");
            entity.Property(e => e.LastLogin).HasColumnName("last_login");
            entity.Property(e => e.LastName)
                .HasMaxLength(25)
                .HasColumnName("last_name");
            entity.Property(e => e.LoginIp)
                .HasMaxLength(32)
                .HasColumnName("login_ip");
            entity.Property(e => e.Mobile)
                .HasMaxLength(20)
                .HasColumnName("mobile");
            entity.Property(e => e.National)
                .HasMaxLength(50)
                .HasColumnName("national");
            entity.Property(e => e.Nickname)
                .HasMaxLength(25)
                .HasColumnName("nickname");
            entity.Property(e => e.OfficeTel)
                .HasMaxLength(20)
                .HasColumnName("office_tel");
            entity.Property(e => e.Passport)
                .HasMaxLength(30)
                .HasColumnName("passport");
            entity.Property(e => e.Photo)
                .HasMaxLength(200)
                .HasColumnName("photo");
            entity.Property(e => e.PositionId).HasColumnName("position_id");
            entity.Property(e => e.Postcode)
                .HasMaxLength(10)
                .HasColumnName("postcode");
            entity.Property(e => e.Religion)
                .HasMaxLength(20)
                .HasColumnName("religion");
            entity.Property(e => e.Reserved).HasColumnName("reserved");
            entity.Property(e => e.SelfPassword)
                .HasMaxLength(128)
                .HasColumnName("self_password");
            entity.Property(e => e.SessionKey)
                .HasMaxLength(32)
                .HasColumnName("session_key");
            entity.Property(e => e.Ssn)
                .HasMaxLength(20)
                .HasColumnName("ssn");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(20)
                .HasColumnName("title");
            entity.Property(e => e.UpdateTime).HasColumnName("update_time");
            entity.Property(e => e.VerifyMode).HasColumnName("verify_mode");

            entity.HasOne(d => d.Department).WithMany(p => p.PersonnelEmployees)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("personnel_employee_department_id_068bbd08_fk_personnel");

            entity.HasOne(d => d.Position).WithMany(p => p.PersonnelEmployees)
                .HasForeignKey(d => d.PositionId)
                .HasConstraintName("personnel_employee_position_id_c9321343_fk_personnel");
        });

        modelBuilder.Entity<PersonnelEmployeeArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("personnel_employee_area_pkey");

            entity.ToTable("personnel_employee_area");

            entity.HasIndex(e => e.AreaId, "personnel_employee_area_area_id_64c21925");

            entity.HasIndex(e => e.EmployeeId, "personnel_employee_area_employee_id_8e5cec21");

            entity.HasIndex(e => new { e.EmployeeId, e.AreaId }, "personnel_employee_area_employee_id_area_id_00b3d777_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

            entity.HasOne(d => d.Area).WithMany(p => p.PersonnelEmployeeAreas)
                .HasForeignKey(d => d.AreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_employee_area_area_id_64c21925_fk_personnel_area_id");
        });

        modelBuilder.Entity<PersonnelEmployeeFlowRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("personnel_employee_flow_role_pkey");

            entity.ToTable("personnel_employee_flow_role");

            entity.HasIndex(e => new { e.EmployeeId, e.WorkflowroleId }, "personnel_employee_flow__employee_id_workflowrole_46b0e5e0_uniq").IsUnique();

            entity.HasIndex(e => e.EmployeeId, "personnel_employee_flow_role_employee_id_c27f8a56");

            entity.HasIndex(e => e.WorkflowroleId, "personnel_employee_flow_role_workflowrole_id_4704db32");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.WorkflowroleId).HasColumnName("workflowrole_id");

            entity.HasOne(d => d.Employee).WithMany(p => p.PersonnelEmployeeFlowRoles)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_employee_f_employee_id_c27f8a56_fk_personnel");

            entity.HasOne(d => d.Workflowrole).WithMany(p => p.PersonnelEmployeeFlowRoles)
                .HasForeignKey(d => d.WorkflowroleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_employee_f_workflowrole_id_4704db32_fk_workflow_");
        });

        modelBuilder.Entity<PersonnelEmployeecalendar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("personnel_employeecalendar_pkey");

            entity.ToTable("personnel_employeecalendar");

            entity.HasIndex(e => e.EmployeeId, "personnel_employeecalendar_employee_id_165e0779");

            entity.HasIndex(e => new { e.EmployeeId, e.Calendar }, "personnel_employeecalendar_employee_id_calendar_10f7278d_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Calendar)
                .HasMaxLength(100)
                .HasColumnName("calendar");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Employee).WithMany(p => p.PersonnelEmployeecalendars)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_employeeca_employee_id_165e0779_fk_personnel");
        });

        modelBuilder.Entity<PersonnelEmployeecertification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("personnel_employeecertification_pkey");

            entity.ToTable("personnel_employeecertification");

            entity.HasIndex(e => new { e.EmployeeId, e.CertificationId }, "personnel_employeecertif_employee_id_certificatio_7bcf4c7d_uniq").IsUnique();

            entity.HasIndex(e => e.CertificationId, "personnel_employeecertification_certification_id_faabed40");

            entity.HasIndex(e => e.EmployeeId, "personnel_employeecertification_employee_id_b7bd3867");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Before).HasColumnName("before");
            entity.Property(e => e.CertificationCode)
                .HasMaxLength(20)
                .HasColumnName("certification_code");
            entity.Property(e => e.CertificationId).HasColumnName("certification_id");
            entity.Property(e => e.EmailAlert).HasColumnName("email_alert");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.ExpireOn).HasColumnName("expire_on");
            entity.Property(e => e.File)
                .HasMaxLength(200)
                .HasColumnName("file");
            entity.Property(e => e.FileName)
                .HasMaxLength(200)
                .HasColumnName("file_name");

            entity.HasOne(d => d.Certification).WithMany(p => p.PersonnelEmployeecertifications)
                .HasForeignKey(d => d.CertificationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_employeece_certification_id_faabed40_fk_personnel");

            entity.HasOne(d => d.Employee).WithMany(p => p.PersonnelEmployeecertifications)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_employeece_employee_id_b7bd3867_fk_personnel");
        });

        modelBuilder.Entity<PersonnelEmployeecustomattribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("personnel_employeecustomattribute_pkey");

            entity.ToTable("personnel_employeecustomattribute");

            entity.HasIndex(e => e.AttrName, "personnel_employeecustomattribute_attr_name_d286b7d5_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.AttrName, "personnel_employeecustomattribute_attr_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AttrName)
                .HasMaxLength(50)
                .HasColumnName("attr_name");
            entity.Property(e => e.AttrType).HasColumnName("attr_type");
            entity.Property(e => e.AttrValue)
                .HasMaxLength(200)
                .HasColumnName("attr_value");
            entity.Property(e => e.Enable).HasColumnName("enable");
            entity.Property(e => e.IsUnique).HasColumnName("is_unique");
        });

        modelBuilder.Entity<PersonnelEmployeeextrainfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("personnel_employeeextrainfo_pkey");

            entity.ToTable("personnel_employeeextrainfo");

            entity.HasIndex(e => e.EmployeeId, "personnel_employeeextrainfo_employee_id_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.Employee).WithOne(p => p.PersonnelEmployeeextrainfo)
                .HasForeignKey<PersonnelEmployeeextrainfo>(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_employeeex_employee_id_41e2b04d_fk_personnel");
        });

        modelBuilder.Entity<PersonnelEmployeeleavebalance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("personnel_employeeleavebalance_pkey");

            entity.ToTable("personnel_employeeleavebalance");

            entity.HasIndex(e => new { e.EmployeeId, e.LeaveTypeId }, "personnel_employeeleaveb_employee_id_leave_type_i_4d9211f4_uniq").IsUnique();

            entity.HasIndex(e => e.EmployeeId, "personnel_employeeleavebalance_employee_id_2ef0fcfd");

            entity.HasIndex(e => e.LeaveTypeId, "personnel_employeeleavebalance_leave_type_id_c5be9dff");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.LeaveBalance).HasColumnName("leave_balance");
            entity.Property(e => e.LeaveTypeId).HasColumnName("leave_type_id");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Employee).WithMany(p => p.PersonnelEmployeeleavebalances)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_employeele_employee_id_2ef0fcfd_fk_personnel");

            entity.HasOne(d => d.LeaveType).WithMany(p => p.PersonnelEmployeeleavebalances)
                .HasForeignKey(d => d.LeaveTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_employeele_leave_type_id_c5be9dff_fk_att_payco");
        });

        modelBuilder.Entity<PersonnelEmployeeprofile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("personnel_employeeprofile_pkey");

            entity.ToTable("personnel_employeeprofile");

            entity.HasIndex(e => e.EmpId, "personnel_employeeprofile_emp_id_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ColumnOrder).HasColumnName("column_order");
            entity.Property(e => e.DisabledFields).HasColumnName("disabled_fields");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Preferences).HasColumnName("preferences");
            entity.Property(e => e.PwdUpdateTime).HasColumnName("pwd_update_time");
        });

        modelBuilder.Entity<PersonnelEmployment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("personnel_employment_pkey");

            entity.ToTable("personnel_employment");

            entity.HasIndex(e => e.EmployeeId, "personnel_employment_employee_id_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActiveTime).HasColumnName("active_time");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.EmploymentType).HasColumnName("employment_type");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.InactiveTime).HasColumnName("inactive_time");
            entity.Property(e => e.StartDate).HasColumnName("start_date");

            entity.HasOne(d => d.Employee).WithOne(p => p.PersonnelEmployment)
                .HasForeignKey<PersonnelEmployment>(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_employment_employee_id_f797c7d9_fk_personnel");
        });

        modelBuilder.Entity<PersonnelPosition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("personnel_position_pkey");

            entity.ToTable("personnel_position");

            entity.HasIndex(e => e.CompanyId, "personnel_position_company_id_f06c5d2a");

            entity.HasIndex(e => new { e.CompanyId, e.PositionCode }, "personnel_position_company_id_position_code_4708726e_uniq").IsUnique();

            entity.HasIndex(e => e.ParentPositionId, "personnel_position_parent_position_id_a496a36b");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.ParentPositionId).HasColumnName("parent_position_id");
            entity.Property(e => e.PositionCode)
                .HasMaxLength(50)
                .HasColumnName("position_code");
            entity.Property(e => e.PositionName)
                .HasMaxLength(100)
                .HasColumnName("position_name");

            entity.HasOne(d => d.Company).WithMany(p => p.PersonnelPositions)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_position_company_id_f06c5d2a_fk_personnel_company_id");

            entity.HasOne(d => d.ParentPosition).WithMany(p => p.InverseParentPosition)
                .HasForeignKey(d => d.ParentPositionId)
                .HasConstraintName("personnel_position_parent_position_id_a496a36b_fk_personnel");
        });

        modelBuilder.Entity<PersonnelResign>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("personnel_resign_pkey");

            entity.ToTable("personnel_resign");

            entity.HasIndex(e => e.EmployeeId, "personnel_resign_employee_id_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Disableatt).HasColumnName("disableatt");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .HasColumnName("reason");
            entity.Property(e => e.ResignDate).HasColumnName("resign_date");
            entity.Property(e => e.ResignType).HasColumnName("resign_type");

            entity.HasOne(d => d.Employee).WithOne(p => p.PersonnelResign)
                .HasForeignKey<PersonnelResign>(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_resign_employee_id_dd9b7e08_fk_personnel_employee_id");
        });

        modelBuilder.Entity<RestFrameworkTrackingApirequestlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("rest_framework_tracking_apirequestlog_pkey");

            entity.ToTable("rest_framework_tracking_apirequestlog");

            entity.HasIndex(e => e.Path, "rest_framework_tracking_apirequestlog_path_fe81f91b");

            entity.HasIndex(e => e.Path, "rest_framework_tracking_apirequestlog_path_fe81f91b_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.RequestedAt, "rest_framework_tracking_apirequestlog_requested_at_b6f1c2f2");

            entity.HasIndex(e => e.StatusCode, "rest_framework_tracking_apirequestlog_status_code_3c9e2003");

            entity.HasIndex(e => e.UserId, "rest_framework_tracking_apirequestlog_user_id_671b70b7");

            entity.HasIndex(e => e.View, "rest_framework_tracking_apirequestlog_view_5bd1e407");

            entity.HasIndex(e => e.View, "rest_framework_tracking_apirequestlog_view_5bd1e407_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.ViewMethod, "rest_framework_tracking_apirequestlog_view_method_dd790881");

            entity.HasIndex(e => e.ViewMethod, "rest_framework_tracking_apirequestlog_view_method_dd790881_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Errors).HasColumnName("errors");
            entity.Property(e => e.Host)
                .HasMaxLength(200)
                .HasColumnName("host");
            entity.Property(e => e.Method)
                .HasMaxLength(10)
                .HasColumnName("method");
            entity.Property(e => e.Path)
                .HasMaxLength(200)
                .HasColumnName("path");
            entity.Property(e => e.QueryParams).HasColumnName("query_params");
            entity.Property(e => e.RemoteAddr).HasColumnName("remote_addr");
            entity.Property(e => e.RequestedAt).HasColumnName("requested_at");
            entity.Property(e => e.Response).HasColumnName("response");
            entity.Property(e => e.ResponseMs).HasColumnName("response_ms");
            entity.Property(e => e.StatusCode).HasColumnName("status_code");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UsernamePersistent)
                .HasMaxLength(200)
                .HasColumnName("username_persistent");
            entity.Property(e => e.View)
                .HasMaxLength(200)
                .HasColumnName("view");
            entity.Property(e => e.ViewMethod)
                .HasMaxLength(200)
                .HasColumnName("view_method");

            entity.HasOne(d => d.User).WithMany(p => p.RestFrameworkTrackingApirequestlogs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("rest_framework_track_user_id_671b70b7_fk_auth_user");
        });

        modelBuilder.Entity<StaffStafftoken>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("staff_stafftoken_pkey");

            entity.ToTable("staff_stafftoken");

            entity.HasIndex(e => e.Key, "staff_stafftoken_key_af7789a4_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.UserId, "staff_stafftoken_user_id_key").IsUnique();

            entity.Property(e => e.Key)
                .HasMaxLength(40)
                .HasColumnName("key");
            entity.Property(e => e.Created).HasColumnName("created");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithOne(p => p.StaffStafftoken)
                .HasForeignKey<StaffStafftoken>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("staff_stafftoken_user_id_39c937fa_fk_personnel_employee_id");
        });

        modelBuilder.Entity<SyncArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sync_area_pkey");

            entity.ToTable("sync_area");

            entity.HasIndex(e => new { e.AreaCode, e.AreaName }, "sync_area_area_code_area_name_200046d1_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(30)
                .HasColumnName("area_code");
            entity.Property(e => e.AreaName)
                .HasMaxLength(30)
                .HasColumnName("area_name");
            entity.Property(e => e.Flag).HasColumnName("flag");
            entity.Property(e => e.PostTime).HasColumnName("post_time");
            entity.Property(e => e.SyncRet)
                .HasMaxLength(200)
                .HasColumnName("sync_ret");
            entity.Property(e => e.UpdateTime).HasColumnName("update_time");
        });

        modelBuilder.Entity<SyncDepartment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sync_department_pkey");

            entity.ToTable("sync_department");

            entity.HasIndex(e => new { e.DeptCode, e.DeptName }, "sync_department_dept_code_dept_name_93923213_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DeptCode)
                .HasMaxLength(50)
                .HasColumnName("dept_code");
            entity.Property(e => e.DeptName)
                .HasMaxLength(100)
                .HasColumnName("dept_name");
            entity.Property(e => e.Flag).HasColumnName("flag");
            entity.Property(e => e.PostTime).HasColumnName("post_time");
            entity.Property(e => e.SyncRet)
                .HasMaxLength(200)
                .HasColumnName("sync_ret");
            entity.Property(e => e.UpdateTime).HasColumnName("update_time");
        });

        modelBuilder.Entity<SyncEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sync_employee_pkey");

            entity.ToTable("sync_employee");

            entity.HasIndex(e => e.EmpCode, "sync_employee_emp_code_521bf06d_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActiveStatus).HasColumnName("active_status");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(30)
                .HasColumnName("area_code");
            entity.Property(e => e.AreaName)
                .HasMaxLength(30)
                .HasColumnName("area_name");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.CardNo)
                .HasMaxLength(20)
                .HasColumnName("card_no");
            entity.Property(e => e.DeptCode)
                .HasMaxLength(50)
                .HasColumnName("dept_code");
            entity.Property(e => e.DeptName)
                .HasMaxLength(100)
                .HasColumnName("dept_name");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.EmpCode)
                .HasMaxLength(20)
                .HasColumnName("emp_code");
            entity.Property(e => e.FirstName)
                .HasMaxLength(25)
                .HasColumnName("first_name");
            entity.Property(e => e.Flag).HasColumnName("flag");
            entity.Property(e => e.Gender)
                .HasMaxLength(2)
                .HasColumnName("gender");
            entity.Property(e => e.HireDate).HasColumnName("hire_date");
            entity.Property(e => e.JobCode)
                .HasMaxLength(50)
                .HasColumnName("job_code");
            entity.Property(e => e.JobName)
                .HasMaxLength(100)
                .HasColumnName("job_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(25)
                .HasColumnName("last_name");
            entity.Property(e => e.MultiArea).HasColumnName("multi_area");
            entity.Property(e => e.PostTime).HasColumnName("post_time");
            entity.Property(e => e.SyncRet)
                .HasMaxLength(200)
                .HasColumnName("sync_ret");
            entity.Property(e => e.UpdateTime).HasColumnName("update_time");
        });

        modelBuilder.Entity<SyncJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sync_job_pkey");

            entity.ToTable("sync_job");

            entity.HasIndex(e => new { e.JobCode, e.JobName }, "sync_job_job_code_job_name_4ec5619e_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Flag).HasColumnName("flag");
            entity.Property(e => e.JobCode)
                .HasMaxLength(50)
                .HasColumnName("job_code");
            entity.Property(e => e.JobName)
                .HasMaxLength(100)
                .HasColumnName("job_name");
            entity.Property(e => e.PostTime).HasColumnName("post_time");
            entity.Property(e => e.SyncRet)
                .HasMaxLength(200)
                .HasColumnName("sync_ret");
            entity.Property(e => e.UpdateTime).HasColumnName("update_time");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tickets_pkey");

            entity.ToTable("tickets");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DiaTicket).HasColumnName("dia_ticket");
            entity.Property(e => e.EmpCode)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("emp_code");
            entity.Property(e => e.EmpCodeRetira).HasColumnName("emp_code_retira");
            entity.Property(e => e.FechaRetiroticket)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_retiroticket");
            entity.Property(e => e.FechaTicket)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_ticket");
            entity.Property(e => e.Nulo)
                .HasDefaultValueSql("0")
                .HasColumnName("nulo");
            entity.Property(e => e.Refuerzo).HasColumnName("refuerzo");
            entity.Property(e => e.Retirado)
                .HasDefaultValueSql("0")
                .HasColumnName("retirado");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsuarioEmision)
                .HasMaxLength(255)
                .HasColumnName("usuario_emision");
            entity.Property(e => e.UsuarioMod)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("usuario_mod");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.EmailVerifiedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("email_verified_at");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.RememberToken)
                .HasMaxLength(100)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("remember_token");
            entity.Property(e => e.Role)
                .HasMaxLength(255)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("role");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<UsuarioWeb>(entity =>
        {
            entity.HasKey(e => e.Rut).HasName("usuario_web_pkey");

            entity.ToTable("usuario_web");

            entity.HasIndex(e => e.Email, "usuario_web_email_key").IsUnique();

            entity.Property(e => e.Rut)
                .HasMaxLength(10)
                .HasColumnName("rut");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("nombre");
            entity.Property(e => e.Pass)
                .HasMaxLength(15)
                .HasColumnName("pass");
        });

        modelBuilder.Entity<VisitorReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("visitor_reason_pkey");

            entity.ToTable("visitor_reason");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.VisitReason)
                .HasMaxLength(100)
                .HasColumnName("visit_reason");
        });

        modelBuilder.Entity<VisitorReservation>(entity =>
        {
            entity.HasKey(e => e.WorkflowinstancePtrId).HasName("visitor_reservation_pkey");

            entity.ToTable("visitor_reservation");

            entity.HasIndex(e => e.CertTypeId, "visitor_reservation_cert_type_id_4f047f2a");

            entity.HasIndex(e => e.VisitDepartmentId, "visitor_reservation_visit_department_id_2d293e10");

            entity.HasIndex(e => e.VisitReasonId, "visitor_reservation_visit_reason_id_c9ac83ac");

            entity.Property(e => e.WorkflowinstancePtrId)
                .ValueGeneratedNever()
                .HasColumnName("workflowinstance_ptr_id");
            entity.Property(e => e.ApplyReason).HasColumnName("apply_reason");
            entity.Property(e => e.ApplyTime).HasColumnName("apply_time");
            entity.Property(e => e.CertNo)
                .HasMaxLength(50)
                .HasColumnName("cert_no");
            entity.Property(e => e.CertTypeId).HasColumnName("cert_type_id");
            entity.Property(e => e.Company)
                .HasMaxLength(100)
                .HasColumnName("company");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .HasColumnName("gender");
            entity.Property(e => e.UpdateTime).HasColumnName("update_time");
            entity.Property(e => e.VisFirstName)
                .HasMaxLength(25)
                .HasColumnName("vis_first_name");
            entity.Property(e => e.VisLastName)
                .HasMaxLength(25)
                .HasColumnName("vis_last_name");
            entity.Property(e => e.VisitDate).HasColumnName("visit_date");
            entity.Property(e => e.VisitDepartmentId).HasColumnName("visit_department_id");
            entity.Property(e => e.VisitQuantity).HasColumnName("visit_quantity");
            entity.Property(e => e.VisitReasonId).HasColumnName("visit_reason_id");

            entity.HasOne(d => d.CertType).WithMany(p => p.VisitorReservations)
                .HasForeignKey(d => d.CertTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_reservation_cert_type_id_4f047f2a_fk_personnel");

            entity.HasOne(d => d.VisitDepartment).WithMany(p => p.VisitorReservations)
                .HasForeignKey(d => d.VisitDepartmentId)
                .HasConstraintName("visitor_reservation_visit_department_id_2d293e10_fk_personnel");

            entity.HasOne(d => d.VisitReason).WithMany(p => p.VisitorReservations)
                .HasForeignKey(d => d.VisitReasonId)
                .HasConstraintName("visitor_reservation_visit_reason_id_c9ac83ac_fk_visitor_r");

            entity.HasOne(d => d.WorkflowinstancePtr).WithOne(p => p.VisitorReservation)
                .HasForeignKey<VisitorReservation>(d => d.WorkflowinstancePtrId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_reservation_workflowinstance_ptr_3787bcd6_fk_workflow_");
        });

        modelBuilder.Entity<VisitorVisitor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("visitor_visitor_pkey");

            entity.ToTable("visitor_visitor");

            entity.HasIndex(e => e.CertTypeId, "visitor_visitor_cert_type_id_f62ea604");

            entity.HasIndex(e => e.VisitDepartmentId, "visitor_visitor_visit_department_id_f7dbdcb4");

            entity.HasIndex(e => e.VisitReasonId, "visitor_visitor_visit_reason_id_4b9a2d23");

            entity.HasIndex(e => e.VisitedId, "visitor_visitor_visited_id_8043a7ea");

            entity.HasIndex(e => e.VisitorCode, "visitor_visitor_visitor_code_5255ed7f_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.VisitorCode, "visitor_visitor_visitor_code_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CardNo)
                .HasMaxLength(20)
                .HasColumnName("card_no");
            entity.Property(e => e.CertNo)
                .HasMaxLength(50)
                .HasColumnName("cert_no");
            entity.Property(e => e.CertTypeId).HasColumnName("cert_type_id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.Company)
                .HasMaxLength(100)
                .HasColumnName("company");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.EntryCarryingGoods)
                .HasMaxLength(200)
                .HasColumnName("entry_carrying_goods");
            entity.Property(e => e.ExitCarryingGoods)
                .HasMaxLength(200)
                .HasColumnName("exit_carrying_goods");
            entity.Property(e => e.ExitTime).HasColumnName("exit_time");
            entity.Property(e => e.FirstName)
                .HasMaxLength(25)
                .HasColumnName("first_name");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .HasColumnName("gender");
            entity.Property(e => e.LastName)
                .HasMaxLength(25)
                .HasColumnName("last_name");
            entity.Property(e => e.Mobile)
                .HasMaxLength(20)
                .HasColumnName("mobile");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .HasColumnName("password");
            entity.Property(e => e.Photo)
                .HasMaxLength(200)
                .HasColumnName("photo");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasColumnName("remark");
            entity.Property(e => e.Ssn)
                .HasMaxLength(20)
                .HasColumnName("ssn");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdateTime).HasColumnName("update_time");
            entity.Property(e => e.VisitDepartmentId).HasColumnName("visit_department_id");
            entity.Property(e => e.VisitQuantity).HasColumnName("visit_quantity");
            entity.Property(e => e.VisitReasonId).HasColumnName("visit_reason_id");
            entity.Property(e => e.VisitedId).HasColumnName("visited_id");
            entity.Property(e => e.VisitorCode)
                .HasMaxLength(20)
                .HasColumnName("visitor_code");

            entity.HasOne(d => d.CertType).WithMany(p => p.VisitorVisitors)
                .HasForeignKey(d => d.CertTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_visitor_cert_type_id_f62ea604_fk_personnel");

            entity.HasOne(d => d.VisitDepartment).WithMany(p => p.VisitorVisitors)
                .HasForeignKey(d => d.VisitDepartmentId)
                .HasConstraintName("visitor_visitor_visit_department_id_f7dbdcb4_fk_personnel");

            entity.HasOne(d => d.VisitReason).WithMany(p => p.VisitorVisitors)
                .HasForeignKey(d => d.VisitReasonId)
                .HasConstraintName("visitor_visitor_visit_reason_id_4b9a2d23_fk_visitor_reason_id");

            entity.HasOne(d => d.Visited).WithMany(p => p.VisitorVisitors)
                .HasForeignKey(d => d.VisitedId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_visitor_visited_id_8043a7ea_fk_personnel_employee_id");
        });

        modelBuilder.Entity<VisitorVisitorAccGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("visitor_visitor_acc_groups_pkey");

            entity.ToTable("visitor_visitor_acc_groups");

            entity.HasIndex(e => new { e.VisitorId, e.AccgroupsId }, "visitor_visitor_acc_grou_visitor_id_accgroups_id_bb522609_uniq").IsUnique();

            entity.HasIndex(e => e.AccgroupsId, "visitor_visitor_acc_groups_accgroups_id_b1487149");

            entity.HasIndex(e => e.VisitorId, "visitor_visitor_acc_groups_visitor_id_8ce09562");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccgroupsId).HasColumnName("accgroups_id");
            entity.Property(e => e.VisitorId).HasColumnName("visitor_id");

            entity.HasOne(d => d.Accgroups).WithMany(p => p.VisitorVisitorAccGroups)
                .HasForeignKey(d => d.AccgroupsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_visitor_acc__accgroups_id_b1487149_fk_acc_accgr");

            entity.HasOne(d => d.Visitor).WithMany(p => p.VisitorVisitorAccGroups)
                .HasForeignKey(d => d.VisitorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_visitor_acc__visitor_id_8ce09562_fk_visitor_v");
        });

        modelBuilder.Entity<VisitorVisitorArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("visitor_visitor_area_pkey");

            entity.ToTable("visitor_visitor_area");

            entity.HasIndex(e => e.AreaId, "visitor_visitor_area_area_id_b402c047");

            entity.HasIndex(e => e.VisitorId, "visitor_visitor_area_visitor_id_98d7ed05");

            entity.HasIndex(e => new { e.VisitorId, e.AreaId }, "visitor_visitor_area_visitor_id_area_id_27d158cc_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.VisitorId).HasColumnName("visitor_id");

            entity.HasOne(d => d.Area).WithMany(p => p.VisitorVisitorAreas)
                .HasForeignKey(d => d.AreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_visitor_area_area_id_b402c047_fk_personnel_area_id");

            entity.HasOne(d => d.Visitor).WithMany(p => p.VisitorVisitorAreas)
                .HasForeignKey(d => d.VisitorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_visitor_area_visitor_id_98d7ed05_fk_visitor_visitor_id");
        });

        modelBuilder.Entity<VisitorVisitorbiodatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("visitor_visitorbiodata_pkey");

            entity.ToTable("visitor_visitorbiodata");

            entity.HasIndex(e => e.VisitorId, "visitor_visitorbiodata_visitor_id_b944ed37");

            entity.HasIndex(e => new { e.VisitorId, e.BioNo, e.BioIndex, e.BioType, e.BioFormat, e.MajorVer }, "visitor_visitorbiodata_visitor_id_bio_no_bio_in_e5d598fb_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BioFormat).HasColumnName("bio_format");
            entity.Property(e => e.BioIndex).HasColumnName("bio_index");
            entity.Property(e => e.BioNo).HasColumnName("bio_no");
            entity.Property(e => e.BioTmp).HasColumnName("bio_tmp");
            entity.Property(e => e.BioType).HasColumnName("bio_type");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Duress).HasColumnName("duress");
            entity.Property(e => e.MajorVer)
                .HasMaxLength(30)
                .HasColumnName("major_ver");
            entity.Property(e => e.MinorVer)
                .HasMaxLength(30)
                .HasColumnName("minor_ver");
            entity.Property(e => e.Sn)
                .HasMaxLength(50)
                .HasColumnName("sn");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdateTime).HasColumnName("update_time");
            entity.Property(e => e.Valid).HasColumnName("valid");
            entity.Property(e => e.VisitorId).HasColumnName("visitor_id");

            entity.HasOne(d => d.Visitor).WithMany(p => p.VisitorVisitorbiodata)
                .HasForeignKey(d => d.VisitorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_visitorbioda_visitor_id_b944ed37_fk_visitor_v");
        });

        modelBuilder.Entity<VisitorVisitorbiophoto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("visitor_visitorbiophoto_pkey");

            entity.ToTable("visitor_visitorbiophoto");

            entity.HasIndex(e => e.VisitorId, "visitor_visitorbiophoto_visitor_id_9816daf7");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApprovalPhoto)
                .HasMaxLength(100)
                .HasColumnName("approval_photo");
            entity.Property(e => e.ApprovalState).HasColumnName("approval_state");
            entity.Property(e => e.ApprovalTime).HasColumnName("approval_time");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Email)
                .HasMaxLength(254)
                .HasColumnName("email");
            entity.Property(e => e.EnrollSn)
                .HasMaxLength(50)
                .HasColumnName("enroll_sn");
            entity.Property(e => e.FirstName)
                .HasMaxLength(25)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(25)
                .HasColumnName("last_name");
            entity.Property(e => e.RegisterPhoto)
                .HasMaxLength(100)
                .HasColumnName("register_photo");
            entity.Property(e => e.RegisterTime).HasColumnName("register_time");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.VisitorId).HasColumnName("visitor_id");

            entity.HasOne(d => d.Visitor).WithMany(p => p.VisitorVisitorbiophotos)
                .HasForeignKey(d => d.VisitorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_visitorbioph_visitor_id_9816daf7_fk_visitor_v");
        });

        modelBuilder.Entity<VisitorVisitorconfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("visitor_visitorconfig_pkey");

            entity.ToTable("visitor_visitorconfig");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CodePrefix)
                .HasMaxLength(5)
                .HasColumnName("code_prefix");
            entity.Property(e => e.CodeStart).HasColumnName("code_start");
            entity.Property(e => e.CodeWidth).HasColumnName("code_width");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.QrCodePolicy).HasColumnName("qr_code_policy");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<VisitorVisitorlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("visitor_visitorlog_pkey");

            entity.ToTable("visitor_visitorlog");

            entity.HasIndex(e => e.VisitorId, "visitor_visitorlog_visitor_id_ebaafde1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.VisitorId).HasColumnName("visitor_id");
            entity.Property(e => e.VisitorStatus).HasColumnName("visitor_status");

            entity.HasOne(d => d.Visitor).WithMany(p => p.VisitorVisitorlogs)
                .HasForeignKey(d => d.VisitorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_visitorlog_visitor_id_ebaafde1_fk_visitor_visitor_id");
        });

        modelBuilder.Entity<VisitorVisitortransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("visitor_visitortransaction_pkey");

            entity.ToTable("visitor_visitortransaction");

            entity.HasIndex(e => e.TerminalId, "visitor_visitortransaction_terminal_id_7527ef69");

            entity.HasIndex(e => e.VisitorId, "visitor_visitortransaction_visitor_id_0ee95624");

            entity.HasIndex(e => new { e.VisitorId, e.PunchTime }, "visitor_visitortransaction_visitor_id_punch_time_836abbcf_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Area)
                .HasMaxLength(30)
                .HasColumnName("area");
            entity.Property(e => e.ChangeTime).HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime).HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .HasColumnName("create_user");
            entity.Property(e => e.IsMask).HasColumnName("is_mask");
            entity.Property(e => e.PunchState)
                .HasMaxLength(5)
                .HasColumnName("punch_state");
            entity.Property(e => e.PunchTime).HasColumnName("punch_time");
            entity.Property(e => e.Source).HasColumnName("source");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Temperature)
                .HasPrecision(4, 1)
                .HasColumnName("temperature");
            entity.Property(e => e.TerminalAlias)
                .HasMaxLength(50)
                .HasColumnName("terminal_alias");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
            entity.Property(e => e.TerminalSn)
                .HasMaxLength(50)
                .HasColumnName("terminal_sn");
            entity.Property(e => e.UploadTime).HasColumnName("upload_time");
            entity.Property(e => e.VerifyType).HasColumnName("verify_type");
            entity.Property(e => e.VisitorCode)
                .HasMaxLength(50)
                .HasColumnName("visitor_code");
            entity.Property(e => e.VisitorId).HasColumnName("visitor_id");

            entity.HasOne(d => d.Terminal).WithMany(p => p.VisitorVisitortransactions)
                .HasForeignKey(d => d.TerminalId)
                .HasConstraintName("visitor_visitortrans_terminal_id_7527ef69_fk_iclock_te");

            entity.HasOne(d => d.Visitor).WithMany(p => p.VisitorVisitortransactions)
                .HasForeignKey(d => d.VisitorId)
                .HasConstraintName("visitor_visitortrans_visitor_id_0ee95624_fk_visitor_v");
        });

        modelBuilder.Entity<WorkflowNodeinstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("workflow_nodeinstance_pkey");

            entity.ToTable("workflow_nodeinstance");

            entity.HasIndex(e => e.ApproverEmployeeId, "workflow_nodeinstance_approver_employee_id_d36cd45d");

            entity.HasIndex(e => e.WorkflowInstanceId, "workflow_nodeinstance_workflow_instance_id_afe84fe4");

            entity.HasIndex(e => e.WorkflowNodeId, "workflow_nodeinstance_workflow_node_id_166f36c4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.ApprovalRemark)
                .HasMaxLength(255)
                .HasColumnName("approval_remark");
            entity.Property(e => e.ApprovalStatus).HasColumnName("approval_status");
            entity.Property(e => e.ApprovalTime).HasColumnName("approval_time");
            entity.Property(e => e.ApproverEmployeeId).HasColumnName("approver_employee_id");
            entity.Property(e => e.NodeName)
                .HasMaxLength(30)
                .HasColumnName("node_name");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Targeted).HasColumnName("targeted");
            entity.Property(e => e.WorkflowInstanceId).HasColumnName("workflow_instance_id");
            entity.Property(e => e.WorkflowNodeId).HasColumnName("workflow_node_id");

            entity.HasOne(d => d.ApproverEmployee).WithMany(p => p.WorkflowNodeinstances)
                .HasForeignKey(d => d.ApproverEmployeeId)
                .HasConstraintName("workflow_nodeinstanc_approver_employee_id_d36cd45d_fk_personnel");

            entity.HasOne(d => d.WorkflowInstance).WithMany(p => p.WorkflowNodeinstances)
                .HasForeignKey(d => d.WorkflowInstanceId)
                .HasConstraintName("workflow_nodeinstanc_workflow_instance_id_afe84fe4_fk_workflow_");

            entity.HasOne(d => d.WorkflowNode).WithMany(p => p.WorkflowNodeinstances)
                .HasForeignKey(d => d.WorkflowNodeId)
                .HasConstraintName("workflow_nodeinstanc_workflow_node_id_166f36c4_fk_workflow_");
        });

        modelBuilder.Entity<WorkflowWorkflowengine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("workflow_workflowengine_pkey");

            entity.ToTable("workflow_workflowengine");

            entity.HasIndex(e => e.ApplicantPositionId, "workflow_workflowengine_applicant_position_id_8a65e03a");

            entity.HasIndex(e => e.ContentTypeId, "workflow_workflowengine_content_type_id_f7345c20");

            entity.HasIndex(e => e.DepartmentsId, "workflow_workflowengine_departments_id_0f06d4c7");

            entity.HasIndex(e => e.WorkflowCode, "workflow_workflowengine_workflow_code_86134f98_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.WorkflowCode, "workflow_workflowengine_workflow_code_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicantPositionId).HasColumnName("applicant_position_id");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.DepartmentsId).HasColumnName("departments_id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.WorkflowCode)
                .HasMaxLength(50)
                .HasColumnName("workflow_code");
            entity.Property(e => e.WorkflowName)
                .HasMaxLength(50)
                .HasColumnName("workflow_name");
            entity.Property(e => e.WorkflowType).HasColumnName("workflow_type");

            entity.HasOne(d => d.ApplicantPosition).WithMany(p => p.WorkflowWorkflowengines)
                .HasForeignKey(d => d.ApplicantPositionId)
                .HasConstraintName("workflow_workfloweng_applicant_position_i_8a65e03a_fk_personnel");

            entity.HasOne(d => d.ContentType).WithMany(p => p.WorkflowWorkflowengines)
                .HasForeignKey(d => d.ContentTypeId)
                .HasConstraintName("workflow_workfloweng_content_type_id_f7345c20_fk_django_co");

            entity.HasOne(d => d.Departments).WithMany(p => p.WorkflowWorkflowengines)
                .HasForeignKey(d => d.DepartmentsId)
                .HasConstraintName("workflow_workfloweng_departments_id_0f06d4c7_fk_personnel");
        });

        modelBuilder.Entity<WorkflowWorkflowengineEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("workflow_workflowengine_employee_pkey");

            entity.ToTable("workflow_workflowengine_employee");

            entity.HasIndex(e => new { e.WorkflowengineId, e.EmployeeId }, "workflow_workflowengine__workflowengine_id_employ_8128deb2_uniq").IsUnique();

            entity.HasIndex(e => e.EmployeeId, "workflow_workflowengine_employee_employee_id_803a409e");

            entity.HasIndex(e => e.WorkflowengineId, "workflow_workflowengine_employee_workflowengine_id_6ebcc5f2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.WorkflowengineId).HasColumnName("workflowengine_id");

            entity.HasOne(d => d.Employee).WithMany(p => p.WorkflowWorkflowengineEmployees)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("workflow_workfloweng_employee_id_803a409e_fk_personnel");

            entity.HasOne(d => d.Workflowengine).WithMany(p => p.WorkflowWorkflowengineEmployees)
                .HasForeignKey(d => d.WorkflowengineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("workflow_workfloweng_workflowengine_id_6ebcc5f2_fk_workflow_");
        });

        modelBuilder.Entity<WorkflowWorkflowinstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("workflow_workflowinstance_pkey");

            entity.ToTable("workflow_workflowinstance");

            entity.HasIndex(e => e.EmployeeId, "workflow_workflowinstance_employee_id_c7cff08e");

            entity.HasIndex(e => e.WorkflowEngineId, "workflow_workflowinstance_workflow_engine_id_1e6ac40f");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApprovalRemark).HasColumnName("approval_remark");
            entity.Property(e => e.ApprovalStatus).HasColumnName("approval_status");
            entity.Property(e => e.ApprovalTime).HasColumnName("approval_time");
            entity.Property(e => e.Approver)
                .HasMaxLength(30)
                .HasColumnName("approver");
            entity.Property(e => e.ApproverInstance).HasColumnName("approver_instance");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.WorkflowEngineId).HasColumnName("workflow_engine_id");

            entity.HasOne(d => d.Employee).WithMany(p => p.WorkflowWorkflowinstances)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("workflow_workflowins_employee_id_c7cff08e_fk_personnel");

            entity.HasOne(d => d.WorkflowEngine).WithMany(p => p.WorkflowWorkflowinstances)
                .HasForeignKey(d => d.WorkflowEngineId)
                .HasConstraintName("workflow_workflowins_workflow_engine_id_1e6ac40f_fk_workflow_");
        });

        modelBuilder.Entity<WorkflowWorkflownode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("workflow_workflownode_pkey");

            entity.ToTable("workflow_workflownode");

            entity.HasIndex(e => e.WorkflowEngineId, "workflow_workflownode_workflow_engine_id_04c8f470");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApproverByOverall).HasColumnName("approver_by_overall");
            entity.Property(e => e.NodeName)
                .HasMaxLength(30)
                .HasColumnName("node_name");
            entity.Property(e => e.NotifyByOverall).HasColumnName("notify_by_overall");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.WorkflowEngineId).HasColumnName("workflow_engine_id");

            entity.HasOne(d => d.WorkflowEngine).WithMany(p => p.WorkflowWorkflownodes)
                .HasForeignKey(d => d.WorkflowEngineId)
                .HasConstraintName("workflow_workflownod_workflow_engine_id_04c8f470_fk_workflow_");
        });

        modelBuilder.Entity<WorkflowWorkflownodeApprover>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("workflow_workflownode_approver_pkey");

            entity.ToTable("workflow_workflownode_approver");

            entity.HasIndex(e => new { e.WorkflownodeId, e.WorkflowroleId }, "workflow_workflownode_ap_workflownode_id_workflow_7543ba37_uniq").IsUnique();

            entity.HasIndex(e => e.WorkflownodeId, "workflow_workflownode_approver_workflownode_id_d814c941");

            entity.HasIndex(e => e.WorkflowroleId, "workflow_workflownode_approver_workflowrole_id_c8e00d42");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.WorkflownodeId).HasColumnName("workflownode_id");
            entity.Property(e => e.WorkflowroleId).HasColumnName("workflowrole_id");

            entity.HasOne(d => d.Workflownode).WithMany(p => p.WorkflowWorkflownodeApprovers)
                .HasForeignKey(d => d.WorkflownodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("workflow_workflownod_workflownode_id_d814c941_fk_workflow_");

            entity.HasOne(d => d.Workflowrole).WithMany(p => p.WorkflowWorkflownodeApprovers)
                .HasForeignKey(d => d.WorkflowroleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("workflow_workflownod_workflowrole_id_c8e00d42_fk_workflow_");
        });

        modelBuilder.Entity<WorkflowWorkflownodeNotifier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("workflow_workflownode_notifier_pkey");

            entity.ToTable("workflow_workflownode_notifier");

            entity.HasIndex(e => new { e.WorkflownodeId, e.WorkflowroleId }, "workflow_workflownode_no_workflownode_id_workflow_cac02b37_uniq").IsUnique();

            entity.HasIndex(e => e.WorkflownodeId, "workflow_workflownode_notifier_workflownode_id_57298016");

            entity.HasIndex(e => e.WorkflowroleId, "workflow_workflownode_notifier_workflowrole_id_73de7fc2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.WorkflownodeId).HasColumnName("workflownode_id");
            entity.Property(e => e.WorkflowroleId).HasColumnName("workflowrole_id");

            entity.HasOne(d => d.Workflownode).WithMany(p => p.WorkflowWorkflownodeNotifiers)
                .HasForeignKey(d => d.WorkflownodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("workflow_workflownod_workflownode_id_57298016_fk_workflow_");

            entity.HasOne(d => d.Workflowrole).WithMany(p => p.WorkflowWorkflownodeNotifiers)
                .HasForeignKey(d => d.WorkflowroleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("workflow_workflownod_workflowrole_id_73de7fc2_fk_workflow_");
        });

        modelBuilder.Entity<WorkflowWorkflowrole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("workflow_workflowrole_pkey");

            entity.ToTable("workflow_workflowrole");

            entity.HasIndex(e => e.RoleCode, "workflow_workflowrole_role_code_e2e9edb9_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.RoleCode, "workflow_workflowrole_role_code_key").IsUnique();

            entity.HasIndex(e => e.RoleName, "workflow_workflowrole_role_name_5e0a9215_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.RoleName, "workflow_workflowrole_role_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.RoleCode)
                .HasMaxLength(30)
                .HasColumnName("role_code");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .HasColumnName("role_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

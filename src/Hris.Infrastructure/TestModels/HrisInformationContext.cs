using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Hris.Infrastructure.TestModels;

public partial class HrisInformationContext : DbContext
{
    public HrisInformationContext()
    {
    }

    public HrisInformationContext(DbContextOptions<HrisInformationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeFieldDefinition> EmployeeFieldDefinitions { get; set; }

    public virtual DbSet<EmployeeFieldOption> EmployeeFieldOptions { get; set; }

    public virtual DbSet<EmployeeFieldValue> EmployeeFieldValues { get; set; }

    public virtual DbSet<EngagementSurvey> EngagementSurveys { get; set; }

    public virtual DbSet<EngagementSurveyMetric> EngagementSurveyMetrics { get; set; }

    public virtual DbSet<HeadcountRequest> HeadcountRequests { get; set; }

    public virtual DbSet<LeaveRequest> LeaveRequests { get; set; }

    public virtual DbSet<NotificationPreference> NotificationPreferences { get; set; }

    public virtual DbSet<PayrollSummary> PayrollSummaries { get; set; }

    public virtual DbSet<PayslipComponent> PayslipComponents { get; set; }

    public virtual DbSet<PerformanceReview> PerformanceReviews { get; set; }

    public virtual DbSet<ReportEmployee> ReportEmployees { get; set; }

    public virtual DbSet<ReportLeaf> ReportLeaves { get; set; }

    public virtual DbSet<ReportPayroll> ReportPayrolls { get; set; }

    public virtual DbSet<ReportPerformance> ReportPerformances { get; set; }

    public virtual DbSet<SecurityAuditLog> SecurityAuditLogs { get; set; }

    public virtual DbSet<SecuritySetting> SecuritySettings { get; set; }

    public virtual DbSet<SystemConfiguration> SystemConfigurations { get; set; }

    public virtual DbSet<TrainingProgress> TrainingProgresses { get; set; }

    public virtual DbSet<TrainingRequest> TrainingRequests { get; set; }

    public virtual DbSet<TrainingSession> TrainingSessions { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<WorkforcePlanEntry> WorkforcePlanEntries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Department).HasMaxLength(128);
            entity.Property(e => e.EmployeeNumber).HasMaxLength(32);
            entity.Property(e => e.FullName).HasMaxLength(128);
            entity.Property(e => e.HiredAt).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Position).HasMaxLength(128);
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<EmployeeFieldDefinition>(entity =>
        {
            entity.HasIndex(e => e.FieldKey, "IX_EmployeeFieldDefinitions_FieldKey").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Category).HasMaxLength(64);
            entity.Property(e => e.DataType).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.DisplayName).HasMaxLength(128);
            entity.Property(e => e.FieldKey).HasMaxLength(128);
        });

        modelBuilder.Entity<EmployeeFieldOption>(entity =>
        {
            entity.HasIndex(e => e.FieldDefinitionId, "IX_EmployeeFieldOptions_FieldDefinitionId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Label).HasMaxLength(128);
            entity.Property(e => e.Value).HasMaxLength(128);

            entity.HasOne(d => d.FieldDefinition).WithMany(p => p.EmployeeFieldOptions)
                .HasForeignKey(d => d.FieldDefinitionId)
                .HasConstraintName("FK_EmployeeFieldOptions_EmployeeFieldDefinitions_FieldDefiniti~");
        });

        modelBuilder.Entity<EmployeeFieldValue>(entity =>
        {
            entity.HasIndex(e => new { e.EmployeeId, e.FieldDefinitionId }, "IX_EmployeeFieldValues_EmployeeId_FieldDefinitionId").IsUnique();

            entity.HasIndex(e => e.FieldDefinitionId, "IX_EmployeeFieldValues_FieldDefinitionId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.UpdatedAtUtc).HasColumnType("timestamp without time zone");
            entity.Property(e => e.UpdatedBy).HasMaxLength(128);
            entity.Property(e => e.Value).HasMaxLength(1024);

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeFieldValues).HasForeignKey(d => d.EmployeeId);

            entity.HasOne(d => d.FieldDefinition).WithMany(p => p.EmployeeFieldValues)
                .HasForeignKey(d => d.FieldDefinitionId)
                .HasConstraintName("FK_EmployeeFieldValues_EmployeeFieldDefinitions_FieldDefinitio~");
        });

        modelBuilder.Entity<EngagementSurvey>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CloseDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.OpenDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Status).HasMaxLength(64);
            entity.Property(e => e.Title).HasMaxLength(128);
        });

        modelBuilder.Entity<EngagementSurveyMetric>(entity =>
        {
            entity.HasIndex(e => e.SurveyId, "IX_EngagementSurveyMetrics_SurveyId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.MetricName).HasMaxLength(64);
            entity.Property(e => e.Score).HasMaxLength(32);
            entity.Property(e => e.Trend).HasMaxLength(32);

            entity.HasOne(d => d.Survey).WithMany(p => p.EngagementSurveyMetrics).HasForeignKey(d => d.SurveyId);
        });

        modelBuilder.Entity<HeadcountRequest>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Department).HasMaxLength(128);
            entity.Property(e => e.Justification).HasMaxLength(512);
            entity.Property(e => e.RequestedAtUtc).HasColumnType("timestamp without time zone");
            entity.Property(e => e.RequestedBy).HasMaxLength(128);
            entity.Property(e => e.ResolvedAtUtc).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<LeaveRequest>(entity =>
        {
            entity.HasIndex(e => e.EmployeeId, "IX_LeaveRequests_EmployeeId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.EndDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.LeaveType).HasMaxLength(64);
            entity.Property(e => e.Reference).HasMaxLength(32);
            entity.Property(e => e.RequestedOn).HasColumnType("timestamp without time zone");
            entity.Property(e => e.StartDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Status).HasMaxLength(64);

            entity.HasOne(d => d.Employee).WithMany(p => p.LeaveRequests).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<NotificationPreference>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Channel).HasMaxLength(64);
            entity.Property(e => e.Frequency).HasMaxLength(64);
        });

        modelBuilder.Entity<PayrollSummary>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Department).HasMaxLength(128);
            entity.Property(e => e.Period).HasMaxLength(32);
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<PayslipComponent>(entity =>
        {
            entity.HasIndex(e => e.EmployeeId, "IX_PayslipComponents_EmployeeId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ComponentName).HasMaxLength(128);
            entity.Property(e => e.PayPeriod).HasMaxLength(32);

            entity.HasOne(d => d.Employee).WithMany(p => p.PayslipComponents).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<PerformanceReview>(entity =>
        {
            entity.HasIndex(e => e.EmployeeId, "IX_PerformanceReviews_EmployeeId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ManagerName).HasMaxLength(128);
            entity.Property(e => e.ReviewCycle).HasMaxLength(64);
            entity.Property(e => e.Status).HasMaxLength(64);

            entity.HasOne(d => d.Employee).WithMany(p => p.PerformanceReviews).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<ReportEmployee>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Department).HasMaxLength(128);
            entity.Property(e => e.EmployeeId).HasMaxLength(32);
            entity.Property(e => e.Name).HasMaxLength(128);
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<ReportLeaf>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Employee).HasMaxLength(128);
            entity.Property(e => e.LeaveType).HasMaxLength(64);
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<ReportPayroll>(entity =>
        {
            entity.ToTable("ReportPayroll");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.PayGroup).HasMaxLength(64);
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<ReportPerformance>(entity =>
        {
            entity.ToTable("ReportPerformance");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Department).HasMaxLength(128);
            entity.Property(e => e.Status).HasMaxLength(64);
            entity.Property(e => e.Trend).HasMaxLength(32);
        });

        modelBuilder.Entity<SecurityAuditLog>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.PerformedBy).HasMaxLength(128);
            entity.Property(e => e.RunAtUtc).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Status).HasMaxLength(64);
            entity.Property(e => e.Summary).HasMaxLength(1024);
        });

        modelBuilder.Entity<SecuritySetting>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Control)
                .HasMaxLength(128)
                .HasDefaultValueSql("''::character varying");
            entity.Property(e => e.LastReviewedAtUtc)
                .HasDefaultValueSql("'-infinity'::timestamp with time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.Owner)
                .HasMaxLength(128)
                .HasDefaultValueSql("''::character varying");
            entity.Property(e => e.Severity)
                .HasMaxLength(32)
                .HasDefaultValueSql("''::character varying");
            entity.Property(e => e.Status)
                .HasMaxLength(128)
                .HasDefaultValueSql("''::character varying");
        });

        modelBuilder.Entity<SystemConfiguration>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Category)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying");
            entity.Property(e => e.Key).HasMaxLength(64);
            entity.Property(e => e.Owner).HasMaxLength(128);
            entity.Property(e => e.UpdatedAtUtc)
                .HasDefaultValueSql("'-infinity'::timestamp with time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.Value)
                .HasMaxLength(256)
                .HasDefaultValueSql("''::character varying");
        });

        modelBuilder.Entity<TrainingProgress>(entity =>
        {
            entity.ToTable("TrainingProgress");

            entity.HasIndex(e => e.EmployeeId, "IX_TrainingProgress_EmployeeId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.EndDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.ProgramName).HasMaxLength(128);
            entity.Property(e => e.StartDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Status).HasMaxLength(64);

            entity.HasOne(d => d.Employee).WithMany(p => p.TrainingProgresses).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<TrainingRequest>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ProgramName).HasMaxLength(128);
            entity.Property(e => e.RequestedBy).HasMaxLength(128);
            entity.Property(e => e.Status).HasMaxLength(64);
            entity.Property(e => e.SubmittedOn).HasColumnType("timestamp without time zone");
        });

        modelBuilder.Entity<TrainingSession>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.SessionDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Status).HasMaxLength(64);
            entity.Property(e => e.Title).HasMaxLength(128);
            entity.Property(e => e.Trainer).HasMaxLength(128);
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.Name).HasMaxLength(128);
            entity.Property(e => e.Role).HasMaxLength(64);
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.Role).HasMaxLength(64);
        });

        modelBuilder.Entity<WorkforcePlanEntry>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AttritionRisk).HasMaxLength(32);
            entity.Property(e => e.Department).HasMaxLength(128);
            entity.Property(e => e.DepartmentLead).HasMaxLength(128);
            entity.Property(e => e.Focus).HasMaxLength(256);
            entity.Property(e => e.NextCriticalHire).HasMaxLength(128);
            entity.Property(e => e.Owner).HasMaxLength(128);
            entity.Property(e => e.UpdatedAtUtc).HasColumnType("timestamp without time zone");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

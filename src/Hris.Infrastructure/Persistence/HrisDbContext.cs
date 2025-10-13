using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Hris.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hris.Infrastructure.Persistence;

public class HrisDbContext : DbContext
{
    public HrisDbContext(DbContextOptions<HrisDbContext> options) : base(options)
    {
    }

    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<LeaveRequest> LeaveRequests => Set<LeaveRequest>();
    public DbSet<EmployeePayslipComponent> PayslipComponents => Set<EmployeePayslipComponent>();
    public DbSet<PayrollSummaryRecord> PayrollSummaries => Set<PayrollSummaryRecord>();
    public DbSet<PerformanceReview> PerformanceReviews => Set<PerformanceReview>();
    public DbSet<TrainingSession> TrainingSessions => Set<TrainingSession>();
    public DbSet<TrainingProgressRecord> TrainingProgress => Set<TrainingProgressRecord>();
    public DbSet<TrainingRequest> TrainingRequests => Set<TrainingRequest>();
    public DbSet<EngagementSurvey> EngagementSurveys => Set<EngagementSurvey>();
    public DbSet<EngagementSurveyMetric> EngagementSurveyMetrics => Set<EngagementSurveyMetric>();
    public DbSet<ReportEmployeeRecord> ReportEmployees => Set<ReportEmployeeRecord>();
    public DbSet<ReportLeaveRecord> ReportLeaves => Set<ReportLeaveRecord>();
    public DbSet<ReportPayrollRecord> ReportPayroll => Set<ReportPayrollRecord>();
    public DbSet<ReportPerformanceRecord> ReportPerformance => Set<ReportPerformanceRecord>();
    public DbSet<UserAccount> UserAccounts => Set<UserAccount>();
    public DbSet<UserRoleSummary> UserRoles => Set<UserRoleSummary>();
    public DbSet<NotificationPreference> NotificationPreferences => Set<NotificationPreference>();
    public DbSet<SystemConfiguration> SystemConfigurations => Set<SystemConfiguration>();
    public DbSet<EmployeeFieldDefinition> EmployeeFieldDefinitions => Set<EmployeeFieldDefinition>();
    public DbSet<EmployeeFieldOption> EmployeeFieldOptions => Set<EmployeeFieldOption>();
    public DbSet<EmployeeFieldValue> EmployeeFieldValues => Set<EmployeeFieldValue>();
    public DbSet<SecuritySetting> SecuritySettings => Set<SecuritySetting>();
    public DbSet<WorkforcePlanEntry> WorkforcePlanEntries => Set<WorkforcePlanEntry>();
    public DbSet<HeadcountRequest> HeadcountRequests => Set<HeadcountRequest>();
    public DbSet<SecurityAuditLog> SecurityAuditLogs => Set<SecurityAuditLog>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        ConfigureModel(modelBuilder);
        SeedData(modelBuilder);
    }

    private static void ConfigureModel(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.EmployeeNumber).HasMaxLength(32);
            entity.Property(e => e.FullName).HasMaxLength(128);
            entity.Property(e => e.Department).HasMaxLength(128);
            entity.Property(e => e.Position).HasMaxLength(128);
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<LeaveRequest>(entity =>
        {
            entity.Property(e => e.Reference).HasMaxLength(32);
            entity.Property(e => e.LeaveType).HasMaxLength(64);
            entity.Property(e => e.Status).HasMaxLength(64);

            entity.HasOne(l => l.Employee)
                .WithMany()
                .HasForeignKey(l => l.EmployeeId);
        });

        modelBuilder.Entity<EmployeePayslipComponent>(entity =>
        {
            entity.Property(e => e.PayPeriod).HasMaxLength(32);
            entity.Property(e => e.ComponentName).HasMaxLength(128);

            entity.HasOne(p => p.Employee)
                .WithMany()
                .HasForeignKey(p => p.EmployeeId);
        });

        modelBuilder.Entity<PayrollSummaryRecord>(entity =>
        {
            entity.Property(e => e.Department).HasMaxLength(128);
            entity.Property(e => e.Period).HasMaxLength(32);
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<PerformanceReview>(entity =>
        {
            entity.Property(e => e.ReviewCycle).HasMaxLength(64);
            entity.Property(e => e.ManagerName).HasMaxLength(128);
            entity.Property(e => e.Status).HasMaxLength(64);

            entity.HasOne(r => r.Employee)
                .WithMany()
                .HasForeignKey(r => r.EmployeeId);
        });

        modelBuilder.Entity<TrainingSession>(entity =>
        {
            entity.Property(e => e.Title).HasMaxLength(128);
            entity.Property(e => e.Trainer).HasMaxLength(128);
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<TrainingProgressRecord>(entity =>
        {
            entity.Property(e => e.ProgramName).HasMaxLength(128);
            entity.Property(e => e.Status).HasMaxLength(64);

            entity.HasOne(p => p.Employee)
                .WithMany()
                .HasForeignKey(p => p.EmployeeId);
        });

        modelBuilder.Entity<TrainingRequest>(entity =>
        {
            entity.Property(e => e.RequestedBy).HasMaxLength(128);
            entity.Property(e => e.ProgramName).HasMaxLength(128);
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<EngagementSurvey>(entity =>
        {
            entity.Property(e => e.Title).HasMaxLength(128);
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<EngagementSurveyMetric>(entity =>
        {
            entity.Property(e => e.MetricName).HasMaxLength(64);
            entity.Property(e => e.Score).HasMaxLength(32);
            entity.Property(e => e.Trend).HasMaxLength(32);

            entity.HasOne(m => m.Survey)
                .WithMany(s => s.Metrics)
                .HasForeignKey(m => m.SurveyId);
        });

        modelBuilder.Entity<ReportEmployeeRecord>(entity =>
        {
            entity.Property(e => e.EmployeeId).HasMaxLength(32);
            entity.Property(e => e.Name).HasMaxLength(128);
            entity.Property(e => e.Department).HasMaxLength(128);
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<ReportLeaveRecord>(entity =>
        {
            entity.Property(e => e.Employee).HasMaxLength(128);
            entity.Property(e => e.LeaveType).HasMaxLength(64);
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<ReportPayrollRecord>(entity =>
        {
            entity.Property(e => e.PayGroup).HasMaxLength(64);
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<ReportPerformanceRecord>(entity =>
        {
            entity.Property(e => e.Department).HasMaxLength(128);
            entity.Property(e => e.Trend).HasMaxLength(32);
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(128);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.Role).HasMaxLength(64);
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<UserRoleSummary>(entity =>
        {
            entity.Property(e => e.Role).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(256);
        });

        modelBuilder.Entity<NotificationPreference>(entity =>
        {
            entity.Property(e => e.Channel).HasMaxLength(64);
            entity.Property(e => e.Frequency).HasMaxLength(64);
        });

        modelBuilder.Entity<SystemConfiguration>(entity =>
        {
            entity.Property(e => e.Key).HasMaxLength(64);
            entity.Property(e => e.Value).HasMaxLength(256);
            entity.Property(e => e.Owner).HasMaxLength(128);
            entity.Property(e => e.Category).HasMaxLength(64);
        });

        modelBuilder.Entity<EmployeeFieldDefinition>(entity =>
        {
            entity.Property(e => e.FieldKey).HasMaxLength(128);
            entity.Property(e => e.DisplayName).HasMaxLength(128);
            entity.Property(e => e.DataType).HasMaxLength(64);
            entity.Property(e => e.Category).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.HasIndex(e => e.FieldKey).IsUnique();

            entity.HasMany(e => e.Options)
                .WithOne(option => option.FieldDefinition)
                .HasForeignKey(option => option.FieldDefinitionId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<EmployeeFieldOption>(entity =>
        {
            entity.Property(e => e.Label).HasMaxLength(128);
            entity.Property(e => e.Value).HasMaxLength(128);
        });

        modelBuilder.Entity<EmployeeFieldValue>(entity =>
        {
            entity.Property(e => e.Value).HasMaxLength(1024);
            entity.Property(e => e.UpdatedBy).HasMaxLength(128);

            entity.HasIndex(e => new { e.EmployeeId, e.FieldDefinitionId }).IsUnique();

            entity.HasOne(e => e.Employee)
                .WithMany()
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(e => e.FieldDefinition)
                .WithMany()
                .HasForeignKey(e => e.FieldDefinitionId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<SecuritySetting>(entity =>
        {
            entity.Property(e => e.Control).HasMaxLength(128);
            entity.Property(e => e.Status).HasMaxLength(128);
            entity.Property(e => e.Owner).HasMaxLength(128);
            entity.Property(e => e.Severity).HasMaxLength(32);
        });

        modelBuilder.Entity<WorkforcePlanEntry>(entity =>
        {
            entity.Property(e => e.Department).HasMaxLength(128);
            entity.Property(e => e.DepartmentLead).HasMaxLength(128);
            entity.Property(e => e.Focus).HasMaxLength(256);
            entity.Property(e => e.AttritionRisk).HasMaxLength(32);
            entity.Property(e => e.NextCriticalHire).HasMaxLength(128);
            entity.Property(e => e.Owner).HasMaxLength(128);
        });

        modelBuilder.Entity<HeadcountRequest>(entity =>
        {
            entity.Property(e => e.Department).HasMaxLength(128);
            entity.Property(e => e.RequestedBy).HasMaxLength(128);
            entity.Property(e => e.Justification).HasMaxLength(512);
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<SecurityAuditLog>(entity =>
        {
            entity.Property(e => e.PerformedBy).HasMaxLength(128);
            entity.Property(e => e.Status).HasMaxLength(64);
            entity.Property(e => e.Summary).HasMaxLength(1024);
        });
    }

    private static void SeedData(ModelBuilder modelBuilder)
    {
        var firstNames = new[]
        {
            "Anan", "Suchada", "Korn", "Nattawat", "Benjamas",
            "Kamol", "Ratchada", "Pisan", "Warisa", "Apichat",
            "Kannika", "Natdanai", "Supaporn", "Sorawit", "Wimon",
            "Chanya", "Suphakarn", "Anucha", "Duangjai", "Prasert"
        };

        var lastNames = new[]
        {
            "Techakul", "Dechapanya", "Wongchai", "La-ongsri", "Suksawat",
            "Rattanarak", "Chantana", "Kongthanaraj", "Intharachai", "Kittiphob",
            "Pakdeepong", "Thongchai", "Boonsri", "Saithong", "Praphan",
            "Wiriyakul", "Chawengchai", "Srisawat", "Pradchaphet", "Mekchai"
        };

        var departmentInfos = new (string Department, string Code, string[] Positions)[]
        {
            ("Technology", "IT", new[] { "Software Engineer", "Senior Software Engineer", "Lead Software Engineer", "Engineering Manager", "QA Analyst", "DevOps Engineer" }),
            ("Operations", "OP", new[] { "Operations Specialist", "Operations Manager", "Process Analyst", "Service Lead" }),
            ("People Operations", "HR", new[] { "HR Business Partner", "Recruiter", "HR Coordinator", "People Analytics Lead" }),
            ("Finance", "FN", new[] { "Payroll Specialist", "Financial Analyst", "Accounting Lead", "Compliance Officer" }),
            ("Sales", "SL", new[] { "Account Executive", "Sales Manager", "Customer Success Manager", "Partner Lead" }),
            ("Marketing", "MK", new[] { "Content Strategist", "Marketing Lead", "Brand Manager", "Growth Marketer" })
        };

        var employeeStatuses = new[]
        {
            "Active", "Active", "Active", "On Leave", "Probation", "Active", "Active", "Suspended", "Active"
        };

        var employees = new List<Employee>(capacity: 100);
        for (var i = 0; i < 100; i++)
        {
            var deptInfo = departmentInfos[i % departmentInfos.Length];
            var position = deptInfo.Positions[(i * 3) % deptInfo.Positions.Length];
            var status = employeeStatuses[i % employeeStatuses.Length];
            var firstName = firstNames[i % firstNames.Length];
            var lastName = lastNames[(i * 7) % lastNames.Length];
            var fullName = $"{firstName} {lastName}";
            var hiredAt = Utc(2017, 1, 5).AddDays((i * 29) % 3000);

            employees.Add(new Employee
            {
                Id = CreateDeterministicGuid(100, i + 1),
                EmployeeNumber = $"{deptInfo.Code}-{i + 1:000}",
                FullName = fullName,
                Department = deptInfo.Department,
                Position = position,
                Status = status,
                HiredAt = hiredAt
            });
        }

        modelBuilder.Entity<Employee>().HasData(employees);

        var leaveTypes = new[] { "Annual Leave", "Sick Leave", "Work From Home", "Unpaid Leave" };
        var leaveStatuses = new[] { "Approved", "Pending", "Approved", "Rejected" };
        var leaveRequests = new List<LeaveRequest>(capacity: 200);

        for (var i = 0; i < 200; i++)
        {
            var employee = employees[(i * 5 + 3) % employees.Count];
            var startDate = Utc(2024, 1, 1).AddDays(i * 2 - 150);
            var duration = (i % 5) + 1;
            var endDate = startDate.AddDays(duration - 1);
            var status = leaveStatuses[i % leaveStatuses.Length];
            if (startDate.Year >= 2025 && i % 2 == 0 && status == "Approved")
            {
                status = "Pending";
            }

            var requestedOn = startDate.AddDays(-Math.Max(1, (i % 6) + 1));

            leaveRequests.Add(new LeaveRequest
            {
                Id = CreateDeterministicGuid(200, i + 1),
                EmployeeId = employee.Id,
                Reference = $"LV-{startDate.Year}-{i + 1:0000}",
                LeaveType = leaveTypes[i % leaveTypes.Length],
                StartDate = startDate,
                EndDate = endDate,
                Status = status,
                RequestedOn = requestedOn
            });
        }

        modelBuilder.Entity<LeaveRequest>().HasData(leaveRequests);

        var payPeriods = new[] { "2024-12", "2025-01", "2025-02", "2025-03" };
        var payslipComponents = new List<EmployeePayslipComponent>();
        var payslipIndex = 0;

        foreach (var (employee, employeeIndex) in employees.Select((employee, index) => (employee, index)).Take(24))
        {
            var baseAmount = 38000m + (employeeIndex % 12) * 2500m;

            foreach (var period in payPeriods)
            {
                var monthParts = period.Split('-', StringSplitOptions.TrimEntries);
                var monthNumber = int.Parse(monthParts[1], CultureInfo.InvariantCulture);
                var monthLabel = CultureInfo.InvariantCulture.DateTimeFormat.GetMonthName(monthNumber);
                var yearLabel = monthParts[0];

                payslipComponents.Add(new EmployeePayslipComponent
                {
                    Id = CreateDeterministicGuid(300, ++payslipIndex),
                    EmployeeId = employee.Id,
                    PayPeriod = period,
                    ComponentName = "Base Salary",
                    Amount = baseAmount,
                    Notes = $"{monthLabel} {yearLabel}"
                });

                if (employeeIndex % 3 == 0)
                {
                    payslipComponents.Add(new EmployeePayslipComponent
                    {
                        Id = CreateDeterministicGuid(300, ++payslipIndex),
                        EmployeeId = employee.Id,
                        PayPeriod = period,
                        ComponentName = "Bonus",
                        Amount = decimal.Round(baseAmount * 0.2m, 2),
                        Notes = "Quarterly performance bonus"
                    });
                }

                payslipComponents.Add(new EmployeePayslipComponent
                {
                    Id = CreateDeterministicGuid(300, ++payslipIndex),
                    EmployeeId = employee.Id,
                    PayPeriod = period,
                    ComponentName = "Withholding Tax",
                    Amount = decimal.Round(baseAmount * -0.05m, 2),
                    Notes = "WHT 5%"
                });

                if (employeeIndex % 4 == 0)
                {
                    payslipComponents.Add(new EmployeePayslipComponent
                    {
                        Id = CreateDeterministicGuid(300, ++payslipIndex),
                        EmployeeId = employee.Id,
                        PayPeriod = period,
                        ComponentName = "Internet Allowance",
                        Amount = 1500m,
                        Notes = "Monthly allowance"
                    });
                }
            }
        }

        modelBuilder.Entity<EmployeePayslipComponent>().HasData(payslipComponents);

        var payrollSummaries = new List<PayrollSummaryRecord>();
        var summaryPeriods = new[] { "2024-12", "2025-01", "2025-02", "2025-03" };
        var summaryStatuses = new[] { "Approved", "Pending", "Completed" };
        var payrollIndex = 0;

        foreach (var dept in departmentInfos)
        {
            var deptEmployees = employees.Where(e => e.Department == dept.Department).ToList();
            for (var periodIndex = 0; periodIndex < summaryPeriods.Length; periodIndex++)
            {
                var gross = decimal.Round((deptEmployees.Count * 46000m) + (periodIndex * 120000m), 2);
                var net = decimal.Round(gross * 0.82m, 2);

                payrollSummaries.Add(new PayrollSummaryRecord
                {
                    Id = CreateDeterministicGuid(400, ++payrollIndex),
                    Department = dept.Department,
                    Period = summaryPeriods[periodIndex],
                    TotalEmployees = deptEmployees.Count,
                    GrossPay = gross,
                    NetPay = net,
                    Status = summaryStatuses[(periodIndex + deptEmployees.Count) % summaryStatuses.Length]
                });
            }
        }

        modelBuilder.Entity<PayrollSummaryRecord>().HasData(payrollSummaries);

        var performanceReviews = new List<PerformanceReview>();
        var reviewCycles = new[] { "Mid-Year 2024", "Year-End 2024", "Mid-Year 2025" };
        var reviewStatuses = new[] { "Completed", "Completed", "Pending Approval", "Submitted" };
        var managerNames = new[] { "Karn Suphachai", "Sureeporn Wai", "Anong Rittikrai", "David Miller", "Pakamon Dee" };

        for (var i = 0; i < 80; i++)
        {
            var employee = employees[(i * 4 + 3) % employees.Count];
            var cycle = reviewCycles[i % reviewCycles.Length];
            var status = reviewStatuses[i % reviewStatuses.Length];
            var score = decimal.Round(3.2m + ((i % 12) * 0.15m), 1, MidpointRounding.AwayFromZero);
            if (score > 4.8m)
            {
                score = 4.8m;
            }

            performanceReviews.Add(new PerformanceReview
            {
                Id = CreateDeterministicGuid(500, i + 1),
                EmployeeId = employee.Id,
                ReviewCycle = cycle,
                Score = score,
                ManagerName = managerNames[i % managerNames.Length],
                Status = status
            });
        }

        modelBuilder.Entity<PerformanceReview>().HasData(performanceReviews);

        var trainingSessions = new List<TrainingSession>
        {
            new()
            {
                Id = CreateDeterministicGuid(600, 1),
                Title = "Advanced Angular Workshop",
                SessionDate = Utc(2025, 3, 18),
                Trainer = "Anan Techakun",
                Status = "Open"
            },
            new()
            {
                Id = CreateDeterministicGuid(600, 2),
                Title = "Leadership for Managers",
                SessionDate = Utc(2025, 4, 2),
                Trainer = "Sasithorn P.",
                Status = "Waitlist"
            },
            new()
            {
                Id = CreateDeterministicGuid(600, 3),
                Title = "Financial Compliance Deep Dive",
                SessionDate = Utc(2025, 5, 9),
                Trainer = "James Walker",
                Status = "Scheduled"
            },
            new()
            {
                Id = CreateDeterministicGuid(600, 4),
                Title = "Customer Empathy Lab",
                SessionDate = Utc(2025, 2, 24),
                Trainer = "Warisa K.",
                Status = "Completed"
            },
            new()
            {
                Id = CreateDeterministicGuid(600, 5),
                Title = "Cloud Fundamentals",
                SessionDate = Utc(2025, 1, 12),
                Trainer = "Piyapong S.",
                Status = "Completed"
            },
            new()
            {
                Id = CreateDeterministicGuid(600, 6),
                Title = "Growth Marketing Experiments",
                SessionDate = Utc(2025, 3, 30),
                Trainer = "Arisa L.",
                Status = "Open"
            }
        };

        modelBuilder.Entity<TrainingSession>().HasData(trainingSessions);

        var trainingPrograms = new[] { "OKRs Mastery", "Leadership Essentials", "Cloud Fundamentals", "Customer Empathy", "Advanced Excel Automation" };
        var trainingProgress = new List<TrainingProgressRecord>();
        for (var i = 0; i < 40; i++)
        {
            var employee = employees[(i * 2 + 5) % employees.Count];
            var program = trainingPrograms[i % trainingPrograms.Length];
            var start = Utc(2024, 9, 1).AddDays(i * 5);
            DateTime? end = null;
            var status = "In Progress";

            if (i % 3 == 0)
            {
                end = start.AddDays(45);
                status = "Completed";
            }
            else if (i % 7 == 0)
            {
                status = "On Hold";
            }

            trainingProgress.Add(new TrainingProgressRecord
            {
                Id = CreateDeterministicGuid(610, i + 1),
                EmployeeId = employee.Id,
                ProgramName = program,
                StartDate = start,
                EndDate = end,
                Status = status
            });
        }

        modelBuilder.Entity<TrainingProgressRecord>().HasData(trainingProgress);

        var trainingRequests = new List<TrainingRequest>();
        var requestStatuses = new[] { "Pending", "Approved", "Rejected" };
        var requestPrograms = new[] { "Design Thinking Sprint", "Advanced Excel Automation", "People Analytics", "Strategic Negotiation" };

        for (var i = 0; i < 16; i++)
        {
            trainingRequests.Add(new TrainingRequest
            {
                Id = CreateDeterministicGuid(620, i + 1),
                RequestedBy = $"{firstNames[(i * 9) % firstNames.Length]} {lastNames[(i * 4) % lastNames.Length]}",
                ProgramName = requestPrograms[i % requestPrograms.Length],
                SubmittedOn = Utc(2025, 1, 5).AddDays(i * 3),
                Status = requestStatuses[i % requestStatuses.Length]
            });
        }

        modelBuilder.Entity<TrainingRequest>().HasData(trainingRequests);

        var engagementSurveys = new List<EngagementSurvey>
        {
            new()
            {
                Id = CreateDeterministicGuid(700, 1),
                Title = "2025 Q1 Engagement Pulse",
                Status = "Open",
                OpenDate = Utc(2025, 2, 24),
                CloseDate = Utc(2025, 3, 20)
            },
            new()
            {
                Id = CreateDeterministicGuid(700, 2),
                Title = "Hybrid Work Feedback",
                Status = "Scheduled",
                OpenDate = Utc(2025, 4, 5),
                CloseDate = Utc(2025, 4, 25)
            },
            new()
            {
                Id = CreateDeterministicGuid(700, 3),
                Title = "2024 People Experience Review",
                Status = "Closed",
                OpenDate = Utc(2024, 10, 1),
                CloseDate = Utc(2024, 10, 20)
            }
        };

        modelBuilder.Entity<EngagementSurvey>().HasData(engagementSurveys);

        var engagementMetrics = new List<EngagementSurveyMetric>
        {
            new()
            {
                Id = CreateDeterministicGuid(710, 1),
                SurveyId = engagementSurveys[0].Id,
                MetricName = "Participation",
                Score = "86%",
                Trend = "+4% QoQ"
            },
            new()
            {
                Id = CreateDeterministicGuid(710, 2),
                SurveyId = engagementSurveys[0].Id,
                MetricName = "eNPS",
                Score = "41",
                Trend = "+3"
            },
            new()
            {
                Id = CreateDeterministicGuid(710, 3),
                SurveyId = engagementSurveys[1].Id,
                MetricName = "Readiness",
                Score = "72%",
                Trend = "+2%"
            },
            new()
            {
                Id = CreateDeterministicGuid(710, 4),
                SurveyId = engagementSurveys[2].Id,
                MetricName = "eNPS",
                Score = "35",
                Trend = "+5"
            },
            new()
            {
                Id = CreateDeterministicGuid(710, 5),
                SurveyId = engagementSurveys[2].Id,
                MetricName = "Manager Effectiveness",
                Score = "4.1",
                Trend = "+0.3"
            }
        };

        modelBuilder.Entity<EngagementSurveyMetric>().HasData(engagementMetrics);

        var reportEmployees = employees
            .Select((employee, index) => new ReportEmployeeRecord
            {
                Id = CreateDeterministicGuid(800, index + 1),
                EmployeeId = employee.EmployeeNumber,
                Name = employee.FullName,
                Department = employee.Department,
                Status = employee.Status
            })
            .ToList();

        modelBuilder.Entity<ReportEmployeeRecord>().HasData(reportEmployees);

        var reportLeaveRecords = leaveRequests
            .GroupBy(l => new { l.EmployeeId, l.LeaveType })
            .OrderByDescending(g => g.Key.LeaveType)
            .Take(40)
            .Select((group, index) =>
            {
                var employee = employees.First(e => e.Id == group.Key.EmployeeId);
                var totalDays = group.Sum(l => (l.EndDate - l.StartDate).Days + 1);
                var latest = group.OrderByDescending(l => l.StartDate).First();

                return new ReportLeaveRecord
                {
                    Id = CreateDeterministicGuid(810, index + 1),
                    Employee = employee.FullName,
                    LeaveType = group.Key.LeaveType,
                    DaysUsed = totalDays,
                    Status = latest.Status
                };
            })
            .ToList();

        modelBuilder.Entity<ReportLeaveRecord>().HasData(reportLeaveRecords);

        var reportPayrollRecords = payrollSummaries
            .Select((summary, index) => new ReportPayrollRecord
            {
                Id = CreateDeterministicGuid(820, index + 1),
                PayGroup = summary.Period,
                GrossPay = summary.GrossPay,
                NetPay = summary.NetPay,
                Status = summary.Status
            })
            .ToList();

        modelBuilder.Entity<ReportPayrollRecord>().HasData(reportPayrollRecords);

        var reportPerformanceRecords = performanceReviews
            .GroupBy(review =>
            {
                var employee = employees.First(e => e.Id == review.EmployeeId);
                return employee.Department;
            })
            .Select((group, index) => new ReportPerformanceRecord
            {
                Id = CreateDeterministicGuid(830, index + 1),
                Department = group.Key,
                AverageScore = decimal.Round((decimal)group.Average(r => (double)r.Score), 1, MidpointRounding.AwayFromZero),
                Trend = index % 2 == 0 ? "+0.2" : "-0.1",
                Status = "Published"
            })
            .ToList();

        modelBuilder.Entity<ReportPerformanceRecord>().HasData(reportPerformanceRecords);

        var userAccounts = new List<UserAccount>();
        for (var i = 0; i < 20; i++)
        {
            var role = i < 5 ? "Administrator" : i < 10 ? "Manager" : "Employee";
            var status = i % 9 == 0 ? "Suspended" : "Active";
            var name = $"{firstNames[(i * 2) % firstNames.Length]} {lastNames[(i * 3) % lastNames.Length]}";
            var emailSlug = $"{firstNames[(i * 2) % firstNames.Length]}.{lastNames[(i * 3) % lastNames.Length]}".ToLowerInvariant();

            userAccounts.Add(new UserAccount
            {
                Id = CreateDeterministicGuid(900, i + 1),
                Name = name,
                Email = $"{emailSlug}@company.com",
                Role = role,
                Status = status
            });
        }

        modelBuilder.Entity<UserAccount>().HasData(userAccounts);

        var roleDescriptions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            ["Administrator"] = "Full access to manage system settings",
            ["Manager"] = "Manage team approvals and reports",
            ["Employee"] = "Self-service access to personal data"
        };

        var userRoleSummaries = userAccounts
            .GroupBy(account => account.Role)
            .Select((group, index) => new UserRoleSummary
            {
                Id = CreateDeterministicGuid(910, index + 1),
                Role = group.Key,
                Description = roleDescriptions.TryGetValue(group.Key, out var description) ? description : group.Key,
                AssignedUsers = group.Count()
            })
            .ToList();

        modelBuilder.Entity<UserRoleSummary>().HasData(userRoleSummaries);

        var notificationPreferences = new List<NotificationPreference>
        {
            new()
            {
                Id = CreateDeterministicGuid(920, 1),
                Channel = "Email",
                Frequency = "Daily"
            },
            new()
            {
                Id = CreateDeterministicGuid(920, 2),
                Channel = "In-app",
                Frequency = "Real-time"
            },
            new()
            {
                Id = CreateDeterministicGuid(920, 3),
                Channel = "SMS",
                Frequency = "Weekly"
            },
            new()
            {
                Id = CreateDeterministicGuid(920, 4),
                Channel = "Teams",
                Frequency = "Real-time"
            }
        };

        modelBuilder.Entity<NotificationPreference>().HasData(notificationPreferences);

        var systemConfigurations = new List<SystemConfiguration>
        {
            new()
            {
                Id = CreateDeterministicGuid(930, 1),
                Key = "PrimaryTimezone",
                Value = "(UTC+07:00) Bangkok",
                Owner = "IT Platform",
                UpdatedAtUtc = new DateTime(2025, 3, 1, 3, 0, 0, DateTimeKind.Utc),
                Category = "Regionalisation"
            },
            new()
            {
                Id = CreateDeterministicGuid(930, 2),
                Key = "WorkweekTemplate",
                Value = "Mon-Fri, 09:00-18:00",
                Owner = "People Operations",
                UpdatedAtUtc = new DateTime(2025, 2, 12, 6, 0, 0, DateTimeKind.Utc),
                Category = "Scheduling"
            },
            new()
            {
                Id = CreateDeterministicGuid(930, 3),
                Key = "HolidayCalendar",
                Value = "Thailand 2025",
                Owner = "People Operations",
                UpdatedAtUtc = new DateTime(2025, 1, 28, 9, 30, 0, DateTimeKind.Utc),
                Category = "Scheduling"
            },
            new()
            {
                Id = CreateDeterministicGuid(930, 4),
                Key = "DataResidency",
                Value = "ap-southeast-1",
                Owner = "Security Office",
                UpdatedAtUtc = new DateTime(2024, 12, 12, 4, 0, 0, DateTimeKind.Utc),
                Category = "Platform"
            }
        };

        modelBuilder.Entity<SystemConfiguration>().HasData(systemConfigurations);

        var employeeFieldDefinitions = new List<EmployeeFieldDefinition>
        {
            new()
            {
                Id = CreateDeterministicGuid(880, 1),
                FieldKey = "personal.full_name",
                DisplayName = "Legal full name",
                DataType = "text",
                IsRequired = true,
                Category = "Personal",
                SortOrder = 1,
                Description = "Official full name used on contracts and payslips.",
                IsActive = true
            },
            new()
            {
                Id = CreateDeterministicGuid(880, 2),
                FieldKey = "personal.birth_date",
                DisplayName = "Date of birth",
                DataType = "date",
                IsRequired = false,
                Category = "Personal",
                SortOrder = 2,
                Description = "Employee birth date for eligibility and benefits checks.",
                IsActive = true
            },
            new()
            {
                Id = CreateDeterministicGuid(880, 3),
                FieldKey = "job.department",
                DisplayName = "Department",
                DataType = "select",
                IsRequired = true,
                Category = "Employment",
                SortOrder = 10,
                Description = "Owning department within the organisation structure.",
                IsActive = true
            },
            new()
            {
                Id = CreateDeterministicGuid(880, 4),
                FieldKey = "job.job_level",
                DisplayName = "Job level",
                DataType = "select",
                IsRequired = false,
                Category = "Employment",
                SortOrder = 11,
                Description = "Career level aligned to the company job framework.",
                IsActive = true
            },
            new()
            {
                Id = CreateDeterministicGuid(880, 5),
                FieldKey = "job.employment_type",
                DisplayName = "Employment type",
                DataType = "select",
                IsRequired = true,
                Category = "Employment",
                SortOrder = 12,
                Description = "Indicates if the employee is full-time, contract, or intern.",
                IsActive = true
            }
        };

        modelBuilder.Entity<EmployeeFieldDefinition>().HasData(employeeFieldDefinitions);

        var employeeFieldOptions = new List<EmployeeFieldOption>
        {
            new()
            {
                Id = CreateDeterministicGuid(881, 1),
                FieldDefinitionId = CreateDeterministicGuid(880, 3),
                Label = "People Operations",
                Value = "People Operations",
                SortOrder = 1
            },
            new()
            {
                Id = CreateDeterministicGuid(881, 2),
                FieldDefinitionId = CreateDeterministicGuid(880, 3),
                Label = "Technology",
                Value = "Technology",
                SortOrder = 2
            },
            new()
            {
                Id = CreateDeterministicGuid(881, 3),
                FieldDefinitionId = CreateDeterministicGuid(880, 3),
                Label = "Finance",
                Value = "Finance",
                SortOrder = 3
            },
            new()
            {
                Id = CreateDeterministicGuid(881, 4),
                FieldDefinitionId = CreateDeterministicGuid(880, 3),
                Label = "Marketing",
                Value = "Marketing",
                SortOrder = 4
            },
            new()
            {
                Id = CreateDeterministicGuid(881, 5),
                FieldDefinitionId = CreateDeterministicGuid(880, 3),
                Label = "Customer Success",
                Value = "Customer Success",
                SortOrder = 5
            },
            new()
            {
                Id = CreateDeterministicGuid(881, 6),
                FieldDefinitionId = CreateDeterministicGuid(880, 3),
                Label = "Operations",
                Value = "Operations",
                SortOrder = 6
            },
            new()
            {
                Id = CreateDeterministicGuid(881, 7),
                FieldDefinitionId = CreateDeterministicGuid(880, 3),
                Label = "Sales",
                Value = "Sales",
                SortOrder = 7
            },
            new()
            {
                Id = CreateDeterministicGuid(881, 8),
                FieldDefinitionId = CreateDeterministicGuid(880, 3),
                Label = "Data & Analytics",
                Value = "Data & Analytics",
                SortOrder = 8
            },
            new()
            {
                Id = CreateDeterministicGuid(881, 9),
                FieldDefinitionId = CreateDeterministicGuid(880, 4),
                Label = "Junior",
                Value = "Junior",
                SortOrder = 1
            },
            new()
            {
                Id = CreateDeterministicGuid(881, 10),
                FieldDefinitionId = CreateDeterministicGuid(880, 4),
                Label = "Mid",
                Value = "Mid",
                SortOrder = 2
            },
            new()
            {
                Id = CreateDeterministicGuid(881, 11),
                FieldDefinitionId = CreateDeterministicGuid(880, 4),
                Label = "Senior",
                Value = "Senior",
                SortOrder = 3
            },
            new()
            {
                Id = CreateDeterministicGuid(881, 12),
                FieldDefinitionId = CreateDeterministicGuid(880, 4),
                Label = "Lead",
                Value = "Lead",
                SortOrder = 4
            },
            new()
            {
                Id = CreateDeterministicGuid(881, 13),
                FieldDefinitionId = CreateDeterministicGuid(880, 4),
                Label = "Director",
                Value = "Director",
                SortOrder = 5
            },
            new()
            {
                Id = CreateDeterministicGuid(881, 14),
                FieldDefinitionId = CreateDeterministicGuid(880, 5),
                Label = "Full-time",
                Value = "Full-time",
                SortOrder = 1
            },
            new()
            {
                Id = CreateDeterministicGuid(881, 15),
                FieldDefinitionId = CreateDeterministicGuid(880, 5),
                Label = "Contract",
                Value = "Contract",
                SortOrder = 2
            },
            new()
            {
                Id = CreateDeterministicGuid(881, 16),
                FieldDefinitionId = CreateDeterministicGuid(880, 5),
                Label = "Intern",
                Value = "Intern",
                SortOrder = 3
            }
        };

        modelBuilder.Entity<EmployeeFieldOption>().HasData(employeeFieldOptions);

        var employeeFieldValues = new List<EmployeeFieldValue>
        {
            new()
            {
                Id = CreateDeterministicGuid(882, 1),
                EmployeeId = CreateDeterministicGuid(100, 1),
                FieldDefinitionId = CreateDeterministicGuid(880, 1),
                Value = "Anan Techakul",
                UpdatedAtUtc = Utc(2025, 3, 12, 4, 15),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 2),
                EmployeeId = CreateDeterministicGuid(100, 1),
                FieldDefinitionId = CreateDeterministicGuid(880, 2),
                Value = "1991-05-18",
                UpdatedAtUtc = Utc(2025, 3, 12, 4, 15),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 3),
                EmployeeId = CreateDeterministicGuid(100, 1),
                FieldDefinitionId = CreateDeterministicGuid(880, 3),
                Value = "Technology",
                UpdatedAtUtc = Utc(2025, 3, 12, 4, 15),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 4),
                EmployeeId = CreateDeterministicGuid(100, 1),
                FieldDefinitionId = CreateDeterministicGuid(880, 4),
                Value = "Senior",
                UpdatedAtUtc = Utc(2025, 3, 12, 4, 15),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 5),
                EmployeeId = CreateDeterministicGuid(100, 1),
                FieldDefinitionId = CreateDeterministicGuid(880, 5),
                Value = "Full-time",
                UpdatedAtUtc = Utc(2025, 3, 12, 4, 15),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 6),
                EmployeeId = CreateDeterministicGuid(100, 2),
                FieldDefinitionId = CreateDeterministicGuid(880, 1),
                Value = "Suchada Pradchaphet",
                UpdatedAtUtc = Utc(2025, 3, 11, 7, 0),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 7),
                EmployeeId = CreateDeterministicGuid(100, 2),
                FieldDefinitionId = CreateDeterministicGuid(880, 2),
                Value = "1993-11-02",
                UpdatedAtUtc = Utc(2025, 3, 11, 7, 0),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 8),
                EmployeeId = CreateDeterministicGuid(100, 2),
                FieldDefinitionId = CreateDeterministicGuid(880, 3),
                Value = "Operations",
                UpdatedAtUtc = Utc(2025, 3, 11, 7, 0),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 9),
                EmployeeId = CreateDeterministicGuid(100, 2),
                FieldDefinitionId = CreateDeterministicGuid(880, 4),
                Value = "Lead",
                UpdatedAtUtc = Utc(2025, 3, 11, 7, 0),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 10),
                EmployeeId = CreateDeterministicGuid(100, 2),
                FieldDefinitionId = CreateDeterministicGuid(880, 5),
                Value = "Full-time",
                UpdatedAtUtc = Utc(2025, 3, 11, 7, 0),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 11),
                EmployeeId = CreateDeterministicGuid(100, 3),
                FieldDefinitionId = CreateDeterministicGuid(880, 1),
                Value = "Korn Kittiphob",
                UpdatedAtUtc = Utc(2025, 3, 10, 9, 30),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 12),
                EmployeeId = CreateDeterministicGuid(100, 3),
                FieldDefinitionId = CreateDeterministicGuid(880, 3),
                Value = "People Operations",
                UpdatedAtUtc = Utc(2025, 3, 10, 9, 30),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 13),
                EmployeeId = CreateDeterministicGuid(100, 3),
                FieldDefinitionId = CreateDeterministicGuid(880, 4),
                Value = "Lead",
                UpdatedAtUtc = Utc(2025, 3, 10, 9, 30),
                UpdatedBy = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(882, 14),
                EmployeeId = CreateDeterministicGuid(100, 3),
                FieldDefinitionId = CreateDeterministicGuid(880, 5),
                Value = "Contract",
                UpdatedAtUtc = Utc(2025, 3, 10, 9, 30),
                UpdatedBy = "People Operations"
            }
        };

        modelBuilder.Entity<EmployeeFieldValue>().HasData(employeeFieldValues);

        var securitySettings = new List<SecuritySetting>
        {
            new()
            {
                Id = CreateDeterministicGuid(940, 1),
                Control = "Multi-factor authentication",
                Status = "Enforced",
                Owner = "Security Office",
                LastReviewedAtUtc = new DateTime(2025, 2, 28, 7, 45, 0, DateTimeKind.Utc),
                Severity = "High"
            },
            new()
            {
                Id = CreateDeterministicGuid(940, 2),
                Control = "Password policy",
                Status = "12 chars / rotation 90 days",
                Owner = "Security Office",
                LastReviewedAtUtc = new DateTime(2025, 1, 15, 9, 15, 0, DateTimeKind.Utc),
                Severity = "High"
            },
            new()
            {
                Id = CreateDeterministicGuid(940, 3),
                Control = "Privileged access review",
                Status = "In progress",
                Owner = "Internal Audit",
                LastReviewedAtUtc = new DateTime(2025, 3, 5, 2, 30, 0, DateTimeKind.Utc),
                Severity = "Medium"
            },
            new()
            {
                Id = CreateDeterministicGuid(940, 4),
                Control = "Data loss prevention",
                Status = "Alerting",
                Owner = "Security Office",
                LastReviewedAtUtc = new DateTime(2025, 2, 10, 5, 50, 0, DateTimeKind.Utc),
                Severity = "Medium"
            }
        };

        modelBuilder.Entity<SecuritySetting>().HasData(securitySettings);

        var workforcePlanEntries = new List<WorkforcePlanEntry>
        {
            new()
            {
                Id = CreateDeterministicGuid(950, 1),
                Department = "People Operations",
                DepartmentLead = "Chanon Phumiphak",
                Focus = "HR strategy, talent development",
                ApprovedHeadcountQ3 = 9,
                AttritionRisk = "Low",
                NextCriticalHire = "HR Business Partner",
                UpdatedAtUtc = new DateTime(2025, 3, 10, 4, 0, 0, DateTimeKind.Utc),
                Owner = "People Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(950, 2),
                Department = "Technology",
                DepartmentLead = "Anuwat Khem",
                Focus = "Product delivery, platform reliability",
                ApprovedHeadcountQ3 = 16,
                AttritionRisk = "Medium",
                NextCriticalHire = "Senior Backend Engineer",
                UpdatedAtUtc = new DateTime(2025, 3, 2, 8, 30, 0, DateTimeKind.Utc),
                Owner = "Technology"
            },
            new()
            {
                Id = CreateDeterministicGuid(950, 3),
                Department = "Finance",
                DepartmentLead = "Benjamas Sriwilai",
                Focus = "Payroll, budgeting, treasury",
                ApprovedHeadcountQ3 = 6,
                AttritionRisk = "Low",
                NextCriticalHire = "Revenue Assurance Analyst",
                UpdatedAtUtc = new DateTime(2025, 2, 20, 9, 0, 0, DateTimeKind.Utc),
                Owner = "Finance"
            },
            new()
            {
                Id = CreateDeterministicGuid(950, 4),
                Department = "Marketing",
                DepartmentLead = "Oranicha Mek",
                Focus = "Demand generation, brand growth",
                ApprovedHeadcountQ3 = 7,
                AttritionRisk = "Medium",
                NextCriticalHire = "Lifecycle Marketer",
                UpdatedAtUtc = new DateTime(2025, 3, 8, 6, 45, 0, DateTimeKind.Utc),
                Owner = "Marketing"
            },
            new()
            {
                Id = CreateDeterministicGuid(950, 5),
                Department = "Customer Success",
                DepartmentLead = "Jirawat Kan",
                Focus = "Onboarding, renewals, support excellence",
                ApprovedHeadcountQ3 = 5,
                AttritionRisk = "Low",
                NextCriticalHire = "Technical Account Manager",
                UpdatedAtUtc = new DateTime(2025, 3, 3, 11, 15, 0, DateTimeKind.Utc),
                Owner = "Customer Success"
            },
            new()
            {
                Id = CreateDeterministicGuid(950, 6),
                Department = "Operations",
                DepartmentLead = "Amara Jittrakorn",
                Focus = "Facilities, procurement, logistics",
                ApprovedHeadcountQ3 = 6,
                AttritionRisk = "Medium",
                NextCriticalHire = "Facilities Supervisor",
                UpdatedAtUtc = new DateTime(2025, 2, 27, 7, 10, 0, DateTimeKind.Utc),
                Owner = "Operations"
            },
            new()
            {
                Id = CreateDeterministicGuid(950, 7),
                Department = "Sales",
                DepartmentLead = "Pimchanok Rukdee",
                Focus = "Enterprise acquisition, account growth",
                ApprovedHeadcountQ3 = 4,
                AttritionRisk = "High",
                NextCriticalHire = "Enterprise Account Executive",
                UpdatedAtUtc = new DateTime(2025, 3, 6, 5, 20, 0, DateTimeKind.Utc),
                Owner = "Sales"
            },
            new()
            {
                Id = CreateDeterministicGuid(950, 8),
                Department = "Data & Analytics",
                DepartmentLead = "Piyada Sornchai",
                Focus = "Insights, dashboards, data governance",
                ApprovedHeadcountQ3 = 4,
                AttritionRisk = "Medium",
                NextCriticalHire = "Analytics Engineer",
                UpdatedAtUtc = new DateTime(2025, 2, 25, 10, 5, 0, DateTimeKind.Utc),
                Owner = "Data & Analytics"
            }
        };

        modelBuilder.Entity<WorkforcePlanEntry>().HasData(workforcePlanEntries);

        var headcountRequests = new List<HeadcountRequest>
        {
            new()
            {
                Id = CreateDeterministicGuid(960, 1),
                Department = "Technology",
                RequestedHeadcount = 2,
                RequestedBy = "Anuwat Khem",
                Justification = "Increase backend squad capacity for FY25 roadmap.",
                Status = "Pending",
                RequestedAtUtc = new DateTime(2025, 3, 11, 2, 0, 0, DateTimeKind.Utc)
            },
            new()
            {
                Id = CreateDeterministicGuid(960, 2),
                Department = "Sales",
                RequestedHeadcount = 1,
                RequestedBy = "Pimchanok Rukdee",
                Justification = "Cover APAC enterprise pipeline growth.",
                Status = "Approved",
                RequestedAtUtc = new DateTime(2025, 2, 24, 3, 30, 0, DateTimeKind.Utc),
                ResolvedAtUtc = new DateTime(2025, 3, 4, 8, 15, 0, DateTimeKind.Utc)
            },
            new()
            {
                Id = CreateDeterministicGuid(960, 3),
                Department = "Data & Analytics",
                RequestedHeadcount = 1,
                RequestedBy = "Piyada Sornchai",
                Justification = "Support new BI initiatives for finance and operations.",
                Status = "Pending",
                RequestedAtUtc = new DateTime(2025, 3, 2, 7, 45, 0, DateTimeKind.Utc)
            }
        };

        modelBuilder.Entity<HeadcountRequest>().HasData(headcountRequests);

        var securityAuditLogs = new List<SecurityAuditLog>
        {
            new()
            {
                Id = CreateDeterministicGuid(970, 1),
                RunAtUtc = new DateTime(2025, 2, 18, 4, 0, 0, DateTimeKind.Utc),
                PerformedBy = "Supaporn Teerapat",
                Status = "Completed",
                Summary = "Quarterly MFA and password rotation review completed with no blocking findings."
            },
            new()
            {
                Id = CreateDeterministicGuid(970, 2),
                RunAtUtc = new DateTime(2025, 3, 6, 3, 15, 0, DateTimeKind.Utc),
                PerformedBy = "Kanokwan Yodying",
                Status = "In Progress",
                Summary = "Privileged access certification awaiting confirmation from Operations lead."
            }
        };

        modelBuilder.Entity<SecurityAuditLog>().HasData(securityAuditLogs);
    }

    private static Guid CreateDeterministicGuid(int scope, int index)
    {
        var a = (uint)scope;
        var b = (uint)index;
        var c = a ^ (b << 1);
        var d = a + b + 12345;
        return Guid.ParseExact($"{a:X8}{b:X8}{c:X8}{d:X8}", "N");
    }

    private static DateTime Utc(int year, int month, int day, int hour = 0, int minute = 0, int second = 0)
        => new DateTime(year, month, day, hour, minute, second, DateTimeKind.Utc);
}

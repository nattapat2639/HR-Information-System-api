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
    public DbSet<SecuritySetting> SecuritySettings => Set<SecuritySetting>();

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
            entity.Property(e => e.Timezone).HasMaxLength(128);
            entity.Property(e => e.Workweek).HasMaxLength(64);
        });

        modelBuilder.Entity<SecuritySetting>(entity =>
        {
            entity.Property(e => e.MfaMode).HasMaxLength(64);
            entity.Property(e => e.PasswordPolicy).HasMaxLength(64);
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
            var hiredAt = new DateTime(2017, 1, 5).AddDays((i * 29) % 3000);

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
            var startDate = new DateTime(2024, 1, 1).AddDays(i * 2 - 150);
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
                SessionDate = new DateTime(2025, 3, 18),
                Trainer = "Anan Techakun",
                Status = "Open"
            },
            new()
            {
                Id = CreateDeterministicGuid(600, 2),
                Title = "Leadership for Managers",
                SessionDate = new DateTime(2025, 4, 2),
                Trainer = "Sasithorn P.",
                Status = "Waitlist"
            },
            new()
            {
                Id = CreateDeterministicGuid(600, 3),
                Title = "Financial Compliance Deep Dive",
                SessionDate = new DateTime(2025, 5, 9),
                Trainer = "James Walker",
                Status = "Scheduled"
            },
            new()
            {
                Id = CreateDeterministicGuid(600, 4),
                Title = "Customer Empathy Lab",
                SessionDate = new DateTime(2025, 2, 24),
                Trainer = "Warisa K.",
                Status = "Completed"
            },
            new()
            {
                Id = CreateDeterministicGuid(600, 5),
                Title = "Cloud Fundamentals",
                SessionDate = new DateTime(2025, 1, 12),
                Trainer = "Piyapong S.",
                Status = "Completed"
            },
            new()
            {
                Id = CreateDeterministicGuid(600, 6),
                Title = "Growth Marketing Experiments",
                SessionDate = new DateTime(2025, 3, 30),
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
            var start = new DateTime(2024, 9, 1).AddDays(i * 5);
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
                SubmittedOn = new DateTime(2025, 1, 5).AddDays(i * 3),
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
                OpenDate = new DateTime(2025, 2, 24),
                CloseDate = new DateTime(2025, 3, 20)
            },
            new()
            {
                Id = CreateDeterministicGuid(700, 2),
                Title = "Hybrid Work Feedback",
                Status = "Scheduled",
                OpenDate = new DateTime(2025, 4, 5),
                CloseDate = new DateTime(2025, 4, 25)
            },
            new()
            {
                Id = CreateDeterministicGuid(700, 3),
                Title = "2024 People Experience Review",
                Status = "Closed",
                OpenDate = new DateTime(2024, 10, 1),
                CloseDate = new DateTime(2024, 10, 20)
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
                Timezone = "(UTC+07:00) Bangkok",
                Workweek = "Monday to Friday"
            },
            new()
            {
                Id = CreateDeterministicGuid(930, 2),
                Timezone = "(UTC+01:00) Berlin",
                Workweek = "Monday to Friday"
            }
        };

        modelBuilder.Entity<SystemConfiguration>().HasData(systemConfigurations);

        var securitySettings = new List<SecuritySetting>
        {
            new()
            {
                Id = CreateDeterministicGuid(940, 1),
                MfaMode = "Required",
                PasswordPolicy = "Standard"
            },
            new()
            {
                Id = CreateDeterministicGuid(940, 2),
                MfaMode = "Optional",
                PasswordPolicy = "Strict"
            }
        };

        modelBuilder.Entity<SecuritySetting>().HasData(securitySettings);
    }

    private static Guid CreateDeterministicGuid(int scope, int index)
    {
        var a = (uint)scope;
        var b = (uint)index;
        var c = a ^ (b << 1);
        var d = a + b + 12345;
        return Guid.ParseExact($"{a:X8}{b:X8}{c:X8}{d:X8}", "N");
    }
}

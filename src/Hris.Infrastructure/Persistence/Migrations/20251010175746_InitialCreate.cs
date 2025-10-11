using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hris.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeNumber = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    FullName = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Department = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Position = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Status = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    HiredAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EngagementSurveys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Status = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    OpenDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CloseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngagementSurveys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotificationPreferences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Channel = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    Frequency = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationPreferences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PayrollSummaries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Department = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Period = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    TotalEmployees = table.Column<int>(type: "integer", nullable: false),
                    GrossPay = table.Column<decimal>(type: "numeric", nullable: false),
                    NetPay = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollSummaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportEmployees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeId = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    Name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Department = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Status = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportEmployees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportLeaves",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Employee = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    LeaveType = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    DaysUsed = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportLeaves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportPayroll",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PayGroup = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    GrossPay = table.Column<decimal>(type: "numeric", nullable: false),
                    NetPay = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportPayroll", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportPerformance",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Department = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    AverageScore = table.Column<decimal>(type: "numeric", nullable: false),
                    Trend = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    Status = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportPerformance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecuritySettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MfaMode = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    PasswordPolicy = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecuritySettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemConfigurations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Timezone = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Workweek = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemConfigurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RequestedBy = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProgramName = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    SubmittedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingSessions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    SessionDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Trainer = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Status = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingSessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Role = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    Status = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Role = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    Description = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    AssignedUsers = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Reference = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    LeaveType = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    RequestedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PayslipComponents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    PayPeriod = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    ComponentName = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayslipComponents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayslipComponents_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerformanceReviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReviewCycle = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    Score = table.Column<decimal>(type: "numeric", nullable: false),
                    ManagerName = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Status = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerformanceReviews_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingProgress",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProgramName = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgress_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EngagementSurveyMetrics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SurveyId = table.Column<Guid>(type: "uuid", nullable: false),
                    MetricName = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    Score = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    Trend = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngagementSurveyMetrics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EngagementSurveyMetrics_EngagementSurveys_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "EngagementSurveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "EmployeeNumber", "FullName", "HiredAt", "Position", "Status" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "People Operations", "HR-0001", "Chanon Phumiphak", new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR Business Partner", "Active" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Technology", "IT-0005", "Supaporn Teerapat", new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lead Software Engineer", "Active" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Finance", "FN-0010", "Nattawat Charoen", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Payroll Specialist", "On Leave" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Marketing", "MK-0042", "Oranicha Mek", new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing Lead", "Active" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Customer Success", "CS-0021", "Jirawat Kan", new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Success Lead", "Probation" }
                });

            migrationBuilder.InsertData(
                table: "EngagementSurveys",
                columns: new[] { "Id", "CloseDate", "OpenDate", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("12121212-1212-1212-1212-121212121212"), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Open", "2025 Q1 Engagement Pulse" },
                    { new Guid("13131313-1313-1313-1313-131313131313"), new DateTime(2025, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scheduled", "Hybrid Work Feedback" }
                });

            migrationBuilder.InsertData(
                table: "NotificationPreferences",
                columns: new[] { "Id", "Channel", "Frequency" },
                values: new object[,]
                {
                    { new Guid("1f1f1f1f-1f1f-1f1f-1f1f-1f1f1f1f1f1f"), "Email", "Daily" },
                    { new Guid("20202020-2020-2020-2020-202020202020"), "In-app", "Real-time" }
                });

            migrationBuilder.InsertData(
                table: "PayrollSummaries",
                columns: new[] { "Id", "Department", "GrossPay", "NetPay", "Period", "Status", "TotalEmployees" },
                values: new object[,]
                {
                    { new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc1"), "Technology", 2560000m, 2180000m, "2025-03", "Approved", 42 },
                    { new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc2"), "Operations", 820000m, 705000m, "2025-03", "Pending", 18 }
                });

            migrationBuilder.InsertData(
                table: "ReportEmployees",
                columns: new[] { "Id", "Department", "EmployeeId", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("16161616-1616-1616-1616-161616161616"), "People Operations", "HR-0001", "Chanon Phumiphak", "Active" },
                    { new Guid("17171717-1717-1717-1717-171717171717"), "Technology", "IT-0005", "Supaporn Teerapat", "Active" }
                });

            migrationBuilder.InsertData(
                table: "ReportLeaves",
                columns: new[] { "Id", "DaysUsed", "Employee", "LeaveType", "Status" },
                values: new object[,]
                {
                    { new Guid("18181818-1818-1818-1818-181818181818"), 12, "Oranicha Mek", "Annual Leave", "Approved" },
                    { new Guid("19191919-1919-1919-1919-191919191919"), 5, "Jirawat Kan", "Sick Leave", "Approved" }
                });

            migrationBuilder.InsertData(
                table: "ReportPayroll",
                columns: new[] { "Id", "GrossPay", "NetPay", "PayGroup", "Status" },
                values: new object[,]
                {
                    { new Guid("1a1a1a1a-1a1a-1a1a-1a1a-1a1a1a1a1a1a"), 3950000m, 3210000m, "Monthly", "Completed" },
                    { new Guid("1b1b1b1b-1b1b-1b1b-1b1b-1b1b1b1b1b1b"), 780000m, 655000m, "Bi-weekly", "Completed" }
                });

            migrationBuilder.InsertData(
                table: "ReportPerformance",
                columns: new[] { "Id", "AverageScore", "Department", "Status", "Trend" },
                values: new object[,]
                {
                    { new Guid("1c1d1e1f-1111-2222-3333-444455556666"), 4.3m, "Technology", "Published", "+0.2" },
                    { new Guid("1c2d3e4f-5555-6666-7777-888899990000"), 4.0m, "Operations", "Published", "+0.1" }
                });

            migrationBuilder.InsertData(
                table: "SecuritySettings",
                columns: new[] { "Id", "MfaMode", "PasswordPolicy" },
                values: new object[] { new Guid("22222222-2121-2121-2121-222222222222"), "Required", "Standard" });

            migrationBuilder.InsertData(
                table: "SystemConfigurations",
                columns: new[] { "Id", "Timezone", "Workweek" },
                values: new object[] { new Guid("21212121-2121-2121-2121-212121212121"), "(UTC+07:00) Bangkok", "Monday to Friday" });

            migrationBuilder.InsertData(
                table: "TrainingRequests",
                columns: new[] { "Id", "ProgramName", "RequestedBy", "Status", "SubmittedOn" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-0000000000a1"), "Data Storytelling", "Janya K.", "Pending", new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-0000000000a2"), "Advanced Excel Automation", "Pattama Mee", "Approved", new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TrainingSessions",
                columns: new[] { "Id", "SessionDate", "Status", "Title", "Trainer" },
                values: new object[,]
                {
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeee1"), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Open", "Advanced Angular Workshop", "Anan Techakun" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeee2"), new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Waitlist", "Leadership for Managers", "Sasithorn P." }
                });

            migrationBuilder.InsertData(
                table: "UserAccounts",
                columns: new[] { "Id", "Email", "Name", "Role", "Status" },
                values: new object[,]
                {
                    { new Guid("1c1c1c1c-1c1c-1c1c-1c1c-1c1c1c1c1c1c"), "alex.morgan@company.com", "Alex Morgan", "Administrator", "Active" },
                    { new Guid("1d1d1d1d-1d1d-1d1d-1d1d-1d1d1d1d1d1d"), "pakamon.dee@company.com", "Pakamon Dee", "Manager", "Active" },
                    { new Guid("1e1e1e1e-1e1e-1e1e-1e1e-1e1e1e1e1e1e"), "siwaporn.lek@company.com", "Siwaporn Lek", "Employee", "Suspended" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "AssignedUsers", "Description", "Role" },
                values: new object[,]
                {
                    { new Guid("23232323-2323-2323-2323-232323232323"), 3, "Full access to manage system settings", "Administrator" },
                    { new Guid("24242424-2424-2424-2424-242424242424"), 18, "Manage team approvals and reports", "Manager" },
                    { new Guid("25252525-2525-2525-2525-252525252525"), 420, "Self-service access", "Employee" }
                });

            migrationBuilder.InsertData(
                table: "EngagementSurveyMetrics",
                columns: new[] { "Id", "MetricName", "Score", "SurveyId", "Trend" },
                values: new object[,]
                {
                    { new Guid("14141414-1414-1414-1414-141414141414"), "Participation", "87%", new Guid("12121212-1212-1212-1212-121212121212"), "+5% QoQ" },
                    { new Guid("15151515-1515-1515-1515-151515151515"), "eNPS", "42", new Guid("12121212-1212-1212-1212-121212121212"), "+3 pts" }
                });

            migrationBuilder.InsertData(
                table: "LeaveRequests",
                columns: new[] { "Id", "EmployeeId", "EndDate", "LeaveType", "Reference", "RequestedOn", "StartDate", "Status" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2025-0001", new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa2"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2025-0004", new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa3"), new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2025-0007", new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa4"), new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0145", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa5"), new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0162", new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" }
                });

            migrationBuilder.InsertData(
                table: "PayslipComponents",
                columns: new[] { "Id", "Amount", "ComponentName", "EmployeeId", "Notes", "PayPeriod" },
                values: new object[,]
                {
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"), 65000m, "Base Salary", new Guid("33333333-3333-3333-3333-333333333333"), "March 2025", "2025-03" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"), 10000m, "Bonus", new Guid("33333333-3333-3333-3333-333333333333"), "Performance FY24", "2025-03" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb3"), -5600m, "Withholding Tax", new Guid("33333333-3333-3333-3333-333333333333"), "WHT 5%", "2025-03" }
                });

            migrationBuilder.InsertData(
                table: "PerformanceReviews",
                columns: new[] { "Id", "EmployeeId", "ManagerName", "ReviewCycle", "Score", "Status" },
                values: new object[,]
                {
                    { new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd1"), new Guid("11111111-1111-1111-1111-111111111111"), "Karn Suphachai", "Mid-Year 2024", 4.3m, "Completed" },
                    { new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd2"), new Guid("11111111-1111-1111-1111-111111111111"), "Karn Suphachai", "Year-End 2024", 4.6m, "Completed" },
                    { new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd3"), new Guid("22222222-2222-2222-2222-222222222222"), "Sureeporn Wai", "Year-End 2024", 3.9m, "Pending Approval" }
                });

            migrationBuilder.InsertData(
                table: "TrainingProgress",
                columns: new[] { "Id", "EmployeeId", "EndDate", "ProgramName", "StartDate", "Status" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-fffffffffff1"), new Guid("22222222-2222-2222-2222-222222222222"), null, "OKRs Mastery", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("ffffffff-ffff-ffff-ffff-fffffffffff2"), new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cloud Fundamentals", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EngagementSurveyMetrics_SurveyId",
                table: "EngagementSurveyMetrics",
                column: "SurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_EmployeeId",
                table: "LeaveRequests",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PayslipComponents_EmployeeId",
                table: "PayslipComponents",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceReviews_EmployeeId",
                table: "PerformanceReviews",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgress_EmployeeId",
                table: "TrainingProgress",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EngagementSurveyMetrics");

            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.DropTable(
                name: "NotificationPreferences");

            migrationBuilder.DropTable(
                name: "PayrollSummaries");

            migrationBuilder.DropTable(
                name: "PayslipComponents");

            migrationBuilder.DropTable(
                name: "PerformanceReviews");

            migrationBuilder.DropTable(
                name: "ReportEmployees");

            migrationBuilder.DropTable(
                name: "ReportLeaves");

            migrationBuilder.DropTable(
                name: "ReportPayroll");

            migrationBuilder.DropTable(
                name: "ReportPerformance");

            migrationBuilder.DropTable(
                name: "SecuritySettings");

            migrationBuilder.DropTable(
                name: "SystemConfigurations");

            migrationBuilder.DropTable(
                name: "TrainingProgress");

            migrationBuilder.DropTable(
                name: "TrainingRequests");

            migrationBuilder.DropTable(
                name: "TrainingSessions");

            migrationBuilder.DropTable(
                name: "UserAccounts");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "EngagementSurveys");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hris.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class IntegratePostgresAndActions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "EngagementSurveyMetrics",
                keyColumn: "Id",
                keyValue: new Guid("14141414-1414-1414-1414-141414141414"));

            migrationBuilder.DeleteData(
                table: "EngagementSurveyMetrics",
                keyColumn: "Id",
                keyValue: new Guid("15151515-1515-1515-1515-151515151515"));

            migrationBuilder.DeleteData(
                table: "EngagementSurveys",
                keyColumn: "Id",
                keyValue: new Guid("13131313-1313-1313-1313-131313131313"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa2"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa3"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa4"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa5"));

            migrationBuilder.DeleteData(
                table: "NotificationPreferences",
                keyColumn: "Id",
                keyValue: new Guid("1f1f1f1f-1f1f-1f1f-1f1f-1f1f1f1f1f1f"));

            migrationBuilder.DeleteData(
                table: "NotificationPreferences",
                keyColumn: "Id",
                keyValue: new Guid("20202020-2020-2020-2020-202020202020"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc1"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc2"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb3"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd1"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd2"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd3"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("16161616-1616-1616-1616-161616161616"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("17171717-1717-1717-1717-171717171717"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("18181818-1818-1818-1818-181818181818"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("19191919-1919-1919-1919-191919191919"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("1a1a1a1a-1a1a-1a1a-1a1a-1a1a1a1a1a1a"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("1b1b1b1b-1b1b-1b1b-1b1b-1b1b1b1b1b1b"));

            migrationBuilder.DeleteData(
                table: "ReportPerformance",
                keyColumn: "Id",
                keyValue: new Guid("1c1d1e1f-1111-2222-3333-444455556666"));

            migrationBuilder.DeleteData(
                table: "ReportPerformance",
                keyColumn: "Id",
                keyValue: new Guid("1c2d3e4f-5555-6666-7777-888899990000"));

            migrationBuilder.DeleteData(
                table: "SecuritySettings",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2121-2121-2121-222222222222"));

            migrationBuilder.DeleteData(
                table: "SystemConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("21212121-2121-2121-2121-212121212121"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-fffffffffff1"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-fffffffffff2"));

            migrationBuilder.DeleteData(
                table: "TrainingRequests",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-0000000000a1"));

            migrationBuilder.DeleteData(
                table: "TrainingRequests",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-0000000000a2"));

            migrationBuilder.DeleteData(
                table: "TrainingSessions",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeee1"));

            migrationBuilder.DeleteData(
                table: "TrainingSessions",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeee2"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("1c1c1c1c-1c1c-1c1c-1c1c-1c1c1c1c1c1c"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("1d1d1d1d-1d1d-1d1d-1d1d-1d1d1d1d1d1d"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("1e1e1e1e-1e1e-1e1e-1e1e-1e1e1e1e1e1e"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("23232323-2323-2323-2323-232323232323"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("24242424-2424-2424-2424-242424242424"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("25252525-2525-2525-2525-252525252525"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "EngagementSurveys",
                keyColumn: "Id",
                keyValue: new Guid("12121212-1212-1212-1212-121212121212"));

            migrationBuilder.DropColumn(
                name: "MfaMode",
                table: "SecuritySettings");

            migrationBuilder.DropColumn(
                name: "PasswordPolicy",
                table: "SecuritySettings");

            migrationBuilder.RenameColumn(
                name: "Workweek",
                table: "SystemConfigurations",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "Timezone",
                table: "SystemConfigurations",
                newName: "Owner");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "SystemConfigurations",
                type: "character varying(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAtUtc",
                table: "SystemConfigurations",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "SystemConfigurations",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Control",
                table: "SecuritySettings",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastReviewedAtUtc",
                table: "SecuritySettings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "SecuritySettings",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Severity",
                table: "SecuritySettings",
                type: "character varying(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "SecuritySettings",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "HeadcountRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Department = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    RequestedHeadcount = table.Column<int>(type: "integer", nullable: false),
                    RequestedBy = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Justification = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    Status = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    RequestedAtUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ResolvedAtUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadcountRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecurityAuditLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RunAtUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PerformedBy = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Status = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    Summary = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityAuditLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkforcePlanEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Department = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    DepartmentLead = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Focus = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    ApprovedHeadcountQ3 = table.Column<int>(type: "integer", nullable: false),
                    AttritionRisk = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    NextCriticalHire = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    UpdatedAtUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Owner = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkforcePlanEntries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "EmployeeNumber", "FullName", "HiredAt", "Position", "Status" },
                values: new object[,]
                {
                    { new Guid("00000064-0000-0001-0000-00660000309e"), "Technology", "IT-001", "Anan Techakul", new DateTime(2017, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "Active" },
                    { new Guid("00000064-0000-0002-0000-00600000309f"), "Operations", "OP-002", "Suchada Kongthanaraj", new DateTime(2017, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Service Lead", "Active" },
                    { new Guid("00000064-0000-0003-0000-0062000030a0"), "People Operations", "HR-003", "Korn Praphan", new DateTime(2017, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR Coordinator", "Active" },
                    { new Guid("00000064-0000-0004-0000-006c000030a1"), "Finance", "FN-004", "Nattawat Dechapanya", new DateTime(2017, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Financial Analyst", "On Leave" },
                    { new Guid("00000064-0000-0005-0000-006e000030a2"), "Sales", "SL-005", "Benjamas Intharachai", new DateTime(2017, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Account Executive", "Probation" },
                    { new Guid("00000064-0000-0006-0000-0068000030a3"), "Marketing", "MK-006", "Kamol Wiriyakul", new DateTime(2017, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Growth Marketer", "Active" },
                    { new Guid("00000064-0000-0007-0000-006a000030a4"), "Technology", "IT-007", "Ratchada Wongchai", new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "Active" },
                    { new Guid("00000064-0000-0008-0000-0074000030a5"), "Operations", "OP-008", "Pisan Kittiphob", new DateTime(2017, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations Manager", "Suspended" },
                    { new Guid("00000064-0000-0009-0000-0076000030a6"), "People Operations", "HR-009", "Warisa Chawengchai", new DateTime(2017, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR Business Partner", "Active" },
                    { new Guid("00000064-0000-000a-0000-0070000030a7"), "Finance", "FN-010", "Apichat La-ongsri", new DateTime(2017, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compliance Officer", "Active" },
                    { new Guid("00000064-0000-000b-0000-0072000030a8"), "Sales", "SL-011", "Kannika Pakdeepong", new DateTime(2017, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Success Manager", "Active" },
                    { new Guid("00000064-0000-000c-0000-007c000030a9"), "Marketing", "MK-012", "Natdanai Srisawat", new DateTime(2017, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing Lead", "Active" },
                    { new Guid("00000064-0000-000d-0000-007e000030aa"), "Technology", "IT-013", "Supaporn Suksawat", new DateTime(2017, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "On Leave" },
                    { new Guid("00000064-0000-000e-0000-0078000030ab"), "Operations", "OP-014", "Sorawit Thongchai", new DateTime(2018, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Service Lead", "Probation" },
                    { new Guid("00000064-0000-000f-0000-007a000030ac"), "People Operations", "HR-015", "Wimon Pradchaphet", new DateTime(2018, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR Coordinator", "Active" },
                    { new Guid("00000064-0000-0010-0000-0044000030ad"), "Finance", "FN-016", "Chanya Rattanarak", new DateTime(2018, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Financial Analyst", "Active" },
                    { new Guid("00000064-0000-0011-0000-0046000030ae"), "Sales", "SL-017", "Suphakarn Boonsri", new DateTime(2018, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Account Executive", "Suspended" },
                    { new Guid("00000064-0000-0012-0000-0040000030af"), "Marketing", "MK-018", "Anucha Mekchai", new DateTime(2018, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Growth Marketer", "Active" },
                    { new Guid("00000064-0000-0013-0000-0042000030b0"), "Technology", "IT-019", "Duangjai Chantana", new DateTime(2018, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "Active" },
                    { new Guid("00000064-0000-0014-0000-004c000030b1"), "Operations", "OP-020", "Prasert Saithong", new DateTime(2018, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations Manager", "Active" },
                    { new Guid("00000064-0000-0015-0000-004e000030b2"), "People Operations", "HR-021", "Anan Techakul", new DateTime(2018, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR Business Partner", "Active" },
                    { new Guid("00000064-0000-0016-0000-0048000030b3"), "Finance", "FN-022", "Suchada Kongthanaraj", new DateTime(2018, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compliance Officer", "On Leave" },
                    { new Guid("00000064-0000-0017-0000-004a000030b4"), "Sales", "SL-023", "Korn Praphan", new DateTime(2018, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Success Manager", "Probation" },
                    { new Guid("00000064-0000-0018-0000-0054000030b5"), "Marketing", "MK-024", "Nattawat Dechapanya", new DateTime(2018, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing Lead", "Active" },
                    { new Guid("00000064-0000-0019-0000-0056000030b6"), "Technology", "IT-025", "Benjamas Intharachai", new DateTime(2018, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "Active" },
                    { new Guid("00000064-0000-001a-0000-0050000030b7"), "Operations", "OP-026", "Kamol Wiriyakul", new DateTime(2018, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Service Lead", "Suspended" },
                    { new Guid("00000064-0000-001b-0000-0052000030b8"), "People Operations", "HR-027", "Ratchada Wongchai", new DateTime(2019, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR Coordinator", "Active" },
                    { new Guid("00000064-0000-001c-0000-005c000030b9"), "Finance", "FN-028", "Pisan Kittiphob", new DateTime(2019, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Financial Analyst", "Active" },
                    { new Guid("00000064-0000-001d-0000-005e000030ba"), "Sales", "SL-029", "Warisa Chawengchai", new DateTime(2019, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Account Executive", "Active" },
                    { new Guid("00000064-0000-001e-0000-0058000030bb"), "Marketing", "MK-030", "Apichat La-ongsri", new DateTime(2019, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Growth Marketer", "Active" },
                    { new Guid("00000064-0000-001f-0000-005a000030bc"), "Technology", "IT-031", "Kannika Pakdeepong", new DateTime(2019, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "On Leave" },
                    { new Guid("00000064-0000-0020-0000-0024000030bd"), "Operations", "OP-032", "Natdanai Srisawat", new DateTime(2019, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations Manager", "Probation" },
                    { new Guid("00000064-0000-0021-0000-0026000030be"), "People Operations", "HR-033", "Supaporn Suksawat", new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR Business Partner", "Active" },
                    { new Guid("00000064-0000-0022-0000-0020000030bf"), "Finance", "FN-034", "Sorawit Thongchai", new DateTime(2019, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compliance Officer", "Active" },
                    { new Guid("00000064-0000-0023-0000-0022000030c0"), "Sales", "SL-035", "Wimon Pradchaphet", new DateTime(2019, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Success Manager", "Suspended" },
                    { new Guid("00000064-0000-0024-0000-002c000030c1"), "Marketing", "MK-036", "Chanya Rattanarak", new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing Lead", "Active" },
                    { new Guid("00000064-0000-0025-0000-002e000030c2"), "Technology", "IT-037", "Suphakarn Boonsri", new DateTime(2019, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "Active" },
                    { new Guid("00000064-0000-0026-0000-0028000030c3"), "Operations", "OP-038", "Anucha Mekchai", new DateTime(2019, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Service Lead", "Active" },
                    { new Guid("00000064-0000-0027-0000-002a000030c4"), "People Operations", "HR-039", "Duangjai Chantana", new DateTime(2020, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR Coordinator", "Active" },
                    { new Guid("00000064-0000-0028-0000-0034000030c5"), "Finance", "FN-040", "Prasert Saithong", new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Financial Analyst", "On Leave" },
                    { new Guid("00000064-0000-0029-0000-0036000030c6"), "Sales", "SL-041", "Anan Techakul", new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Account Executive", "Probation" },
                    { new Guid("00000064-0000-002a-0000-0030000030c7"), "Marketing", "MK-042", "Suchada Kongthanaraj", new DateTime(2020, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Growth Marketer", "Active" },
                    { new Guid("00000064-0000-002b-0000-0032000030c8"), "Technology", "IT-043", "Korn Praphan", new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "Active" },
                    { new Guid("00000064-0000-002c-0000-003c000030c9"), "Operations", "OP-044", "Nattawat Dechapanya", new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations Manager", "Suspended" },
                    { new Guid("00000064-0000-002d-0000-003e000030ca"), "People Operations", "HR-045", "Benjamas Intharachai", new DateTime(2020, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR Business Partner", "Active" },
                    { new Guid("00000064-0000-002e-0000-0038000030cb"), "Finance", "FN-046", "Kamol Wiriyakul", new DateTime(2020, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compliance Officer", "Active" },
                    { new Guid("00000064-0000-002f-0000-003a000030cc"), "Sales", "SL-047", "Ratchada Wongchai", new DateTime(2020, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Success Manager", "Active" },
                    { new Guid("00000064-0000-0030-0000-0004000030cd"), "Marketing", "MK-048", "Pisan Kittiphob", new DateTime(2020, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing Lead", "Active" },
                    { new Guid("00000064-0000-0031-0000-0006000030ce"), "Technology", "IT-049", "Warisa Chawengchai", new DateTime(2020, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "On Leave" },
                    { new Guid("00000064-0000-0032-0000-0000000030cf"), "Operations", "OP-050", "Apichat La-ongsri", new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Service Lead", "Probation" },
                    { new Guid("00000064-0000-0033-0000-0002000030d0"), "People Operations", "HR-051", "Kannika Pakdeepong", new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR Coordinator", "Active" },
                    { new Guid("00000064-0000-0034-0000-000c000030d1"), "Finance", "FN-052", "Natdanai Srisawat", new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Financial Analyst", "Active" },
                    { new Guid("00000064-0000-0035-0000-000e000030d2"), "Sales", "SL-053", "Supaporn Suksawat", new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Account Executive", "Suspended" },
                    { new Guid("00000064-0000-0036-0000-0008000030d3"), "Marketing", "MK-054", "Sorawit Thongchai", new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Growth Marketer", "Active" },
                    { new Guid("00000064-0000-0037-0000-000a000030d4"), "Technology", "IT-055", "Wimon Pradchaphet", new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "Active" },
                    { new Guid("00000064-0000-0038-0000-0014000030d5"), "Operations", "OP-056", "Chanya Rattanarak", new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations Manager", "Active" },
                    { new Guid("00000064-0000-0039-0000-0016000030d6"), "People Operations", "HR-057", "Suphakarn Boonsri", new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR Business Partner", "Active" },
                    { new Guid("00000064-0000-003a-0000-0010000030d7"), "Finance", "FN-058", "Anucha Mekchai", new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compliance Officer", "On Leave" },
                    { new Guid("00000064-0000-003b-0000-0012000030d8"), "Sales", "SL-059", "Duangjai Chantana", new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Success Manager", "Probation" },
                    { new Guid("00000064-0000-003c-0000-001c000030d9"), "Marketing", "MK-060", "Prasert Saithong", new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing Lead", "Active" },
                    { new Guid("00000064-0000-003d-0000-001e000030da"), "Technology", "IT-061", "Anan Techakul", new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "Active" },
                    { new Guid("00000064-0000-003e-0000-0018000030db"), "Operations", "OP-062", "Suchada Kongthanaraj", new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Service Lead", "Suspended" },
                    { new Guid("00000064-0000-003f-0000-001a000030dc"), "People Operations", "HR-063", "Korn Praphan", new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR Coordinator", "Active" },
                    { new Guid("00000064-0000-0040-0000-00e4000030dd"), "Finance", "FN-064", "Nattawat Dechapanya", new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Financial Analyst", "Active" },
                    { new Guid("00000064-0000-0041-0000-00e6000030de"), "Sales", "SL-065", "Benjamas Intharachai", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Account Executive", "Active" },
                    { new Guid("00000064-0000-0042-0000-00e0000030df"), "Marketing", "MK-066", "Kamol Wiriyakul", new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Growth Marketer", "Active" },
                    { new Guid("00000064-0000-0043-0000-00e2000030e0"), "Technology", "IT-067", "Ratchada Wongchai", new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "On Leave" },
                    { new Guid("00000064-0000-0044-0000-00ec000030e1"), "Operations", "OP-068", "Pisan Kittiphob", new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations Manager", "Probation" },
                    { new Guid("00000064-0000-0045-0000-00ee000030e2"), "People Operations", "HR-069", "Warisa Chawengchai", new DateTime(2022, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR Business Partner", "Active" },
                    { new Guid("00000064-0000-0046-0000-00e8000030e3"), "Finance", "FN-070", "Apichat La-ongsri", new DateTime(2022, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compliance Officer", "Active" },
                    { new Guid("00000064-0000-0047-0000-00ea000030e4"), "Sales", "SL-071", "Kannika Pakdeepong", new DateTime(2022, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Success Manager", "Suspended" },
                    { new Guid("00000064-0000-0048-0000-00f4000030e5"), "Marketing", "MK-072", "Natdanai Srisawat", new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing Lead", "Active" },
                    { new Guid("00000064-0000-0049-0000-00f6000030e6"), "Technology", "IT-073", "Supaporn Suksawat", new DateTime(2022, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "Active" },
                    { new Guid("00000064-0000-004a-0000-00f0000030e7"), "Operations", "OP-074", "Sorawit Thongchai", new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Service Lead", "Active" },
                    { new Guid("00000064-0000-004b-0000-00f2000030e8"), "People Operations", "HR-075", "Wimon Pradchaphet", new DateTime(2022, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR Coordinator", "Active" },
                    { new Guid("00000064-0000-004c-0000-00fc000030e9"), "Finance", "FN-076", "Chanya Rattanarak", new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Financial Analyst", "On Leave" },
                    { new Guid("00000064-0000-004d-0000-00fe000030ea"), "Sales", "SL-077", "Suphakarn Boonsri", new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Account Executive", "Probation" },
                    { new Guid("00000064-0000-004e-0000-00f8000030eb"), "Marketing", "MK-078", "Anucha Mekchai", new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Growth Marketer", "Active" },
                    { new Guid("00000064-0000-004f-0000-00fa000030ec"), "Technology", "IT-079", "Duangjai Chantana", new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "Active" },
                    { new Guid("00000064-0000-0050-0000-00c4000030ed"), "Operations", "OP-080", "Prasert Saithong", new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations Manager", "Suspended" },
                    { new Guid("00000064-0000-0051-0000-00c6000030ee"), "People Operations", "HR-081", "Anan Techakul", new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR Business Partner", "Active" },
                    { new Guid("00000064-0000-0052-0000-00c0000030ef"), "Finance", "FN-082", "Suchada Kongthanaraj", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compliance Officer", "Active" },
                    { new Guid("00000064-0000-0053-0000-00c2000030f0"), "Sales", "SL-083", "Korn Praphan", new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Success Manager", "Active" },
                    { new Guid("00000064-0000-0054-0000-00cc000030f1"), "Marketing", "MK-084", "Nattawat Dechapanya", new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing Lead", "Active" },
                    { new Guid("00000064-0000-0055-0000-00ce000030f2"), "Technology", "IT-085", "Benjamas Intharachai", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "On Leave" },
                    { new Guid("00000064-0000-0056-0000-00c8000030f3"), "Operations", "OP-086", "Kamol Wiriyakul", new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Service Lead", "Probation" },
                    { new Guid("00000064-0000-0057-0000-00ca000030f4"), "People Operations", "HR-087", "Ratchada Wongchai", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR Coordinator", "Active" },
                    { new Guid("00000064-0000-0058-0000-00d4000030f5"), "Finance", "FN-088", "Pisan Kittiphob", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Financial Analyst", "Active" },
                    { new Guid("00000064-0000-0059-0000-00d6000030f6"), "Sales", "SL-089", "Warisa Chawengchai", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Account Executive", "Suspended" },
                    { new Guid("00000064-0000-005a-0000-00d0000030f7"), "Marketing", "MK-090", "Apichat La-ongsri", new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Growth Marketer", "Active" },
                    { new Guid("00000064-0000-005b-0000-00d2000030f8"), "Technology", "IT-091", "Kannika Pakdeepong", new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "Active" },
                    { new Guid("00000064-0000-005c-0000-00dc000030f9"), "Operations", "OP-092", "Natdanai Srisawat", new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations Manager", "Active" },
                    { new Guid("00000064-0000-005d-0000-00de000030fa"), "People Operations", "HR-093", "Supaporn Suksawat", new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR Business Partner", "Active" },
                    { new Guid("00000064-0000-005e-0000-00d8000030fb"), "Finance", "FN-094", "Sorawit Thongchai", new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compliance Officer", "On Leave" },
                    { new Guid("00000064-0000-005f-0000-00da000030fc"), "Sales", "SL-095", "Wimon Pradchaphet", new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Success Manager", "Probation" },
                    { new Guid("00000064-0000-0060-0000-00a4000030fd"), "Marketing", "MK-096", "Chanya Rattanarak", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing Lead", "Active" },
                    { new Guid("00000064-0000-0061-0000-00a6000030fe"), "Technology", "IT-097", "Suphakarn Boonsri", new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "Active" },
                    { new Guid("00000064-0000-0062-0000-00a0000030ff"), "Operations", "OP-098", "Anucha Mekchai", new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Service Lead", "Suspended" },
                    { new Guid("00000064-0000-0063-0000-00a200003100"), "People Operations", "HR-099", "Duangjai Chantana", new DateTime(2024, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR Coordinator", "Active" },
                    { new Guid("00000064-0000-0064-0000-00ac00003101"), "Finance", "FN-100", "Prasert Saithong", new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Financial Analyst", "Active" }
                });

            migrationBuilder.InsertData(
                table: "EngagementSurveys",
                columns: new[] { "Id", "CloseDate", "OpenDate", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("000002bc-0000-0001-0000-02be000032f6"), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Open", "2025 Q1 Engagement Pulse" },
                    { new Guid("000002bc-0000-0002-0000-02b8000032f7"), new DateTime(2025, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scheduled", "Hybrid Work Feedback" },
                    { new Guid("000002bc-0000-0003-0000-02ba000032f8"), new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Closed", "2024 People Experience Review" }
                });

            migrationBuilder.InsertData(
                table: "HeadcountRequests",
                columns: new[] { "Id", "Department", "Justification", "RequestedAtUtc", "RequestedBy", "RequestedHeadcount", "ResolvedAtUtc", "Status" },
                values: new object[,]
                {
                    { new Guid("000003c0-0000-0001-0000-03c2000033fa"), "Technology", "Increase backend squad capacity for FY25 roadmap.", new DateTime(2025, 3, 11, 2, 0, 0, 0, DateTimeKind.Utc), "Anuwat Khem", 2, null, "Pending" },
                    { new Guid("000003c0-0000-0002-0000-03c4000033fb"), "Sales", "Cover APAC enterprise pipeline growth.", new DateTime(2025, 2, 24, 3, 30, 0, 0, DateTimeKind.Utc), "Pimchanok Rukdee", 1, new DateTime(2025, 3, 4, 8, 15, 0, 0, DateTimeKind.Utc), "Approved" },
                    { new Guid("000003c0-0000-0003-0000-03c6000033fc"), "Data & Analytics", "Support new BI initiatives for finance and operations.", new DateTime(2025, 3, 2, 7, 45, 0, 0, DateTimeKind.Utc), "Piyada Sornchai", 1, null, "Pending" }
                });

            migrationBuilder.InsertData(
                table: "NotificationPreferences",
                columns: new[] { "Id", "Channel", "Frequency" },
                values: new object[,]
                {
                    { new Guid("00000398-0000-0001-0000-039a000033d2"), "Email", "Daily" },
                    { new Guid("00000398-0000-0002-0000-039c000033d3"), "In-app", "Real-time" },
                    { new Guid("00000398-0000-0003-0000-039e000033d4"), "SMS", "Weekly" },
                    { new Guid("00000398-0000-0004-0000-0390000033d5"), "Teams", "Real-time" }
                });

            migrationBuilder.InsertData(
                table: "PayrollSummaries",
                columns: new[] { "Id", "Department", "GrossPay", "NetPay", "Period", "Status", "TotalEmployees" },
                values: new object[,]
                {
                    { new Guid("00000190-0000-0001-0000-0192000031ca"), "Technology", 782000m, 641240.00m, "2024-12", "Completed", 17 },
                    { new Guid("00000190-0000-0002-0000-0194000031cb"), "Technology", 902000m, 739640.00m, "2025-01", "Approved", 17 },
                    { new Guid("00000190-0000-0003-0000-0196000031cc"), "Technology", 1022000m, 838040.00m, "2025-02", "Pending", 17 },
                    { new Guid("00000190-0000-0004-0000-0198000031cd"), "Technology", 1142000m, 936440.00m, "2025-03", "Completed", 17 },
                    { new Guid("00000190-0000-0005-0000-019a000031ce"), "Operations", 782000m, 641240.00m, "2024-12", "Completed", 17 },
                    { new Guid("00000190-0000-0006-0000-019c000031cf"), "Operations", 902000m, 739640.00m, "2025-01", "Approved", 17 },
                    { new Guid("00000190-0000-0007-0000-019e000031d0"), "Operations", 1022000m, 838040.00m, "2025-02", "Pending", 17 },
                    { new Guid("00000190-0000-0008-0000-0180000031d1"), "Operations", 1142000m, 936440.00m, "2025-03", "Completed", 17 },
                    { new Guid("00000190-0000-0009-0000-0182000031d2"), "People Operations", 782000m, 641240.00m, "2024-12", "Completed", 17 },
                    { new Guid("00000190-0000-000a-0000-0184000031d3"), "People Operations", 902000m, 739640.00m, "2025-01", "Approved", 17 },
                    { new Guid("00000190-0000-000b-0000-0186000031d4"), "People Operations", 1022000m, 838040.00m, "2025-02", "Pending", 17 },
                    { new Guid("00000190-0000-000c-0000-0188000031d5"), "People Operations", 1142000m, 936440.00m, "2025-03", "Completed", 17 },
                    { new Guid("00000190-0000-000d-0000-018a000031d6"), "Finance", 782000m, 641240.00m, "2024-12", "Completed", 17 },
                    { new Guid("00000190-0000-000e-0000-018c000031d7"), "Finance", 902000m, 739640.00m, "2025-01", "Approved", 17 },
                    { new Guid("00000190-0000-000f-0000-018e000031d8"), "Finance", 1022000m, 838040.00m, "2025-02", "Pending", 17 },
                    { new Guid("00000190-0000-0010-0000-01b0000031d9"), "Finance", 1142000m, 936440.00m, "2025-03", "Completed", 17 },
                    { new Guid("00000190-0000-0011-0000-01b2000031da"), "Sales", 736000m, 603520.00m, "2024-12", "Pending", 16 },
                    { new Guid("00000190-0000-0012-0000-01b4000031db"), "Sales", 856000m, 701920.00m, "2025-01", "Completed", 16 },
                    { new Guid("00000190-0000-0013-0000-01b6000031dc"), "Sales", 976000m, 800320.00m, "2025-02", "Approved", 16 },
                    { new Guid("00000190-0000-0014-0000-01b8000031dd"), "Sales", 1096000m, 898720.00m, "2025-03", "Pending", 16 },
                    { new Guid("00000190-0000-0015-0000-01ba000031de"), "Marketing", 736000m, 603520.00m, "2024-12", "Pending", 16 },
                    { new Guid("00000190-0000-0016-0000-01bc000031df"), "Marketing", 856000m, 701920.00m, "2025-01", "Completed", 16 },
                    { new Guid("00000190-0000-0017-0000-01be000031e0"), "Marketing", 976000m, 800320.00m, "2025-02", "Approved", 16 },
                    { new Guid("00000190-0000-0018-0000-01a0000031e1"), "Marketing", 1096000m, 898720.00m, "2025-03", "Pending", 16 }
                });

            migrationBuilder.InsertData(
                table: "ReportEmployees",
                columns: new[] { "Id", "Department", "EmployeeId", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("00000320-0000-0001-0000-03220000335a"), "Technology", "IT-001", "Anan Techakul", "Active" },
                    { new Guid("00000320-0000-0002-0000-03240000335b"), "Operations", "OP-002", "Suchada Kongthanaraj", "Active" },
                    { new Guid("00000320-0000-0003-0000-03260000335c"), "People Operations", "HR-003", "Korn Praphan", "Active" },
                    { new Guid("00000320-0000-0004-0000-03280000335d"), "Finance", "FN-004", "Nattawat Dechapanya", "On Leave" },
                    { new Guid("00000320-0000-0005-0000-032a0000335e"), "Sales", "SL-005", "Benjamas Intharachai", "Probation" },
                    { new Guid("00000320-0000-0006-0000-032c0000335f"), "Marketing", "MK-006", "Kamol Wiriyakul", "Active" },
                    { new Guid("00000320-0000-0007-0000-032e00003360"), "Technology", "IT-007", "Ratchada Wongchai", "Active" },
                    { new Guid("00000320-0000-0008-0000-033000003361"), "Operations", "OP-008", "Pisan Kittiphob", "Suspended" },
                    { new Guid("00000320-0000-0009-0000-033200003362"), "People Operations", "HR-009", "Warisa Chawengchai", "Active" },
                    { new Guid("00000320-0000-000a-0000-033400003363"), "Finance", "FN-010", "Apichat La-ongsri", "Active" },
                    { new Guid("00000320-0000-000b-0000-033600003364"), "Sales", "SL-011", "Kannika Pakdeepong", "Active" },
                    { new Guid("00000320-0000-000c-0000-033800003365"), "Marketing", "MK-012", "Natdanai Srisawat", "Active" },
                    { new Guid("00000320-0000-000d-0000-033a00003366"), "Technology", "IT-013", "Supaporn Suksawat", "On Leave" },
                    { new Guid("00000320-0000-000e-0000-033c00003367"), "Operations", "OP-014", "Sorawit Thongchai", "Probation" },
                    { new Guid("00000320-0000-000f-0000-033e00003368"), "People Operations", "HR-015", "Wimon Pradchaphet", "Active" },
                    { new Guid("00000320-0000-0010-0000-030000003369"), "Finance", "FN-016", "Chanya Rattanarak", "Active" },
                    { new Guid("00000320-0000-0011-0000-03020000336a"), "Sales", "SL-017", "Suphakarn Boonsri", "Suspended" },
                    { new Guid("00000320-0000-0012-0000-03040000336b"), "Marketing", "MK-018", "Anucha Mekchai", "Active" },
                    { new Guid("00000320-0000-0013-0000-03060000336c"), "Technology", "IT-019", "Duangjai Chantana", "Active" },
                    { new Guid("00000320-0000-0014-0000-03080000336d"), "Operations", "OP-020", "Prasert Saithong", "Active" },
                    { new Guid("00000320-0000-0015-0000-030a0000336e"), "People Operations", "HR-021", "Anan Techakul", "Active" },
                    { new Guid("00000320-0000-0016-0000-030c0000336f"), "Finance", "FN-022", "Suchada Kongthanaraj", "On Leave" },
                    { new Guid("00000320-0000-0017-0000-030e00003370"), "Sales", "SL-023", "Korn Praphan", "Probation" },
                    { new Guid("00000320-0000-0018-0000-031000003371"), "Marketing", "MK-024", "Nattawat Dechapanya", "Active" },
                    { new Guid("00000320-0000-0019-0000-031200003372"), "Technology", "IT-025", "Benjamas Intharachai", "Active" },
                    { new Guid("00000320-0000-001a-0000-031400003373"), "Operations", "OP-026", "Kamol Wiriyakul", "Suspended" },
                    { new Guid("00000320-0000-001b-0000-031600003374"), "People Operations", "HR-027", "Ratchada Wongchai", "Active" },
                    { new Guid("00000320-0000-001c-0000-031800003375"), "Finance", "FN-028", "Pisan Kittiphob", "Active" },
                    { new Guid("00000320-0000-001d-0000-031a00003376"), "Sales", "SL-029", "Warisa Chawengchai", "Active" },
                    { new Guid("00000320-0000-001e-0000-031c00003377"), "Marketing", "MK-030", "Apichat La-ongsri", "Active" },
                    { new Guid("00000320-0000-001f-0000-031e00003378"), "Technology", "IT-031", "Kannika Pakdeepong", "On Leave" },
                    { new Guid("00000320-0000-0020-0000-036000003379"), "Operations", "OP-032", "Natdanai Srisawat", "Probation" },
                    { new Guid("00000320-0000-0021-0000-03620000337a"), "People Operations", "HR-033", "Supaporn Suksawat", "Active" },
                    { new Guid("00000320-0000-0022-0000-03640000337b"), "Finance", "FN-034", "Sorawit Thongchai", "Active" },
                    { new Guid("00000320-0000-0023-0000-03660000337c"), "Sales", "SL-035", "Wimon Pradchaphet", "Suspended" },
                    { new Guid("00000320-0000-0024-0000-03680000337d"), "Marketing", "MK-036", "Chanya Rattanarak", "Active" },
                    { new Guid("00000320-0000-0025-0000-036a0000337e"), "Technology", "IT-037", "Suphakarn Boonsri", "Active" },
                    { new Guid("00000320-0000-0026-0000-036c0000337f"), "Operations", "OP-038", "Anucha Mekchai", "Active" },
                    { new Guid("00000320-0000-0027-0000-036e00003380"), "People Operations", "HR-039", "Duangjai Chantana", "Active" },
                    { new Guid("00000320-0000-0028-0000-037000003381"), "Finance", "FN-040", "Prasert Saithong", "On Leave" },
                    { new Guid("00000320-0000-0029-0000-037200003382"), "Sales", "SL-041", "Anan Techakul", "Probation" },
                    { new Guid("00000320-0000-002a-0000-037400003383"), "Marketing", "MK-042", "Suchada Kongthanaraj", "Active" },
                    { new Guid("00000320-0000-002b-0000-037600003384"), "Technology", "IT-043", "Korn Praphan", "Active" },
                    { new Guid("00000320-0000-002c-0000-037800003385"), "Operations", "OP-044", "Nattawat Dechapanya", "Suspended" },
                    { new Guid("00000320-0000-002d-0000-037a00003386"), "People Operations", "HR-045", "Benjamas Intharachai", "Active" },
                    { new Guid("00000320-0000-002e-0000-037c00003387"), "Finance", "FN-046", "Kamol Wiriyakul", "Active" },
                    { new Guid("00000320-0000-002f-0000-037e00003388"), "Sales", "SL-047", "Ratchada Wongchai", "Active" },
                    { new Guid("00000320-0000-0030-0000-034000003389"), "Marketing", "MK-048", "Pisan Kittiphob", "Active" },
                    { new Guid("00000320-0000-0031-0000-03420000338a"), "Technology", "IT-049", "Warisa Chawengchai", "On Leave" },
                    { new Guid("00000320-0000-0032-0000-03440000338b"), "Operations", "OP-050", "Apichat La-ongsri", "Probation" },
                    { new Guid("00000320-0000-0033-0000-03460000338c"), "People Operations", "HR-051", "Kannika Pakdeepong", "Active" },
                    { new Guid("00000320-0000-0034-0000-03480000338d"), "Finance", "FN-052", "Natdanai Srisawat", "Active" },
                    { new Guid("00000320-0000-0035-0000-034a0000338e"), "Sales", "SL-053", "Supaporn Suksawat", "Suspended" },
                    { new Guid("00000320-0000-0036-0000-034c0000338f"), "Marketing", "MK-054", "Sorawit Thongchai", "Active" },
                    { new Guid("00000320-0000-0037-0000-034e00003390"), "Technology", "IT-055", "Wimon Pradchaphet", "Active" },
                    { new Guid("00000320-0000-0038-0000-035000003391"), "Operations", "OP-056", "Chanya Rattanarak", "Active" },
                    { new Guid("00000320-0000-0039-0000-035200003392"), "People Operations", "HR-057", "Suphakarn Boonsri", "Active" },
                    { new Guid("00000320-0000-003a-0000-035400003393"), "Finance", "FN-058", "Anucha Mekchai", "On Leave" },
                    { new Guid("00000320-0000-003b-0000-035600003394"), "Sales", "SL-059", "Duangjai Chantana", "Probation" },
                    { new Guid("00000320-0000-003c-0000-035800003395"), "Marketing", "MK-060", "Prasert Saithong", "Active" },
                    { new Guid("00000320-0000-003d-0000-035a00003396"), "Technology", "IT-061", "Anan Techakul", "Active" },
                    { new Guid("00000320-0000-003e-0000-035c00003397"), "Operations", "OP-062", "Suchada Kongthanaraj", "Suspended" },
                    { new Guid("00000320-0000-003f-0000-035e00003398"), "People Operations", "HR-063", "Korn Praphan", "Active" },
                    { new Guid("00000320-0000-0040-0000-03a000003399"), "Finance", "FN-064", "Nattawat Dechapanya", "Active" },
                    { new Guid("00000320-0000-0041-0000-03a20000339a"), "Sales", "SL-065", "Benjamas Intharachai", "Active" },
                    { new Guid("00000320-0000-0042-0000-03a40000339b"), "Marketing", "MK-066", "Kamol Wiriyakul", "Active" },
                    { new Guid("00000320-0000-0043-0000-03a60000339c"), "Technology", "IT-067", "Ratchada Wongchai", "On Leave" },
                    { new Guid("00000320-0000-0044-0000-03a80000339d"), "Operations", "OP-068", "Pisan Kittiphob", "Probation" },
                    { new Guid("00000320-0000-0045-0000-03aa0000339e"), "People Operations", "HR-069", "Warisa Chawengchai", "Active" },
                    { new Guid("00000320-0000-0046-0000-03ac0000339f"), "Finance", "FN-070", "Apichat La-ongsri", "Active" },
                    { new Guid("00000320-0000-0047-0000-03ae000033a0"), "Sales", "SL-071", "Kannika Pakdeepong", "Suspended" },
                    { new Guid("00000320-0000-0048-0000-03b0000033a1"), "Marketing", "MK-072", "Natdanai Srisawat", "Active" },
                    { new Guid("00000320-0000-0049-0000-03b2000033a2"), "Technology", "IT-073", "Supaporn Suksawat", "Active" },
                    { new Guid("00000320-0000-004a-0000-03b4000033a3"), "Operations", "OP-074", "Sorawit Thongchai", "Active" },
                    { new Guid("00000320-0000-004b-0000-03b6000033a4"), "People Operations", "HR-075", "Wimon Pradchaphet", "Active" },
                    { new Guid("00000320-0000-004c-0000-03b8000033a5"), "Finance", "FN-076", "Chanya Rattanarak", "On Leave" },
                    { new Guid("00000320-0000-004d-0000-03ba000033a6"), "Sales", "SL-077", "Suphakarn Boonsri", "Probation" },
                    { new Guid("00000320-0000-004e-0000-03bc000033a7"), "Marketing", "MK-078", "Anucha Mekchai", "Active" },
                    { new Guid("00000320-0000-004f-0000-03be000033a8"), "Technology", "IT-079", "Duangjai Chantana", "Active" },
                    { new Guid("00000320-0000-0050-0000-0380000033a9"), "Operations", "OP-080", "Prasert Saithong", "Suspended" },
                    { new Guid("00000320-0000-0051-0000-0382000033aa"), "People Operations", "HR-081", "Anan Techakul", "Active" },
                    { new Guid("00000320-0000-0052-0000-0384000033ab"), "Finance", "FN-082", "Suchada Kongthanaraj", "Active" },
                    { new Guid("00000320-0000-0053-0000-0386000033ac"), "Sales", "SL-083", "Korn Praphan", "Active" },
                    { new Guid("00000320-0000-0054-0000-0388000033ad"), "Marketing", "MK-084", "Nattawat Dechapanya", "Active" },
                    { new Guid("00000320-0000-0055-0000-038a000033ae"), "Technology", "IT-085", "Benjamas Intharachai", "On Leave" },
                    { new Guid("00000320-0000-0056-0000-038c000033af"), "Operations", "OP-086", "Kamol Wiriyakul", "Probation" },
                    { new Guid("00000320-0000-0057-0000-038e000033b0"), "People Operations", "HR-087", "Ratchada Wongchai", "Active" },
                    { new Guid("00000320-0000-0058-0000-0390000033b1"), "Finance", "FN-088", "Pisan Kittiphob", "Active" },
                    { new Guid("00000320-0000-0059-0000-0392000033b2"), "Sales", "SL-089", "Warisa Chawengchai", "Suspended" },
                    { new Guid("00000320-0000-005a-0000-0394000033b3"), "Marketing", "MK-090", "Apichat La-ongsri", "Active" },
                    { new Guid("00000320-0000-005b-0000-0396000033b4"), "Technology", "IT-091", "Kannika Pakdeepong", "Active" },
                    { new Guid("00000320-0000-005c-0000-0398000033b5"), "Operations", "OP-092", "Natdanai Srisawat", "Active" },
                    { new Guid("00000320-0000-005d-0000-039a000033b6"), "People Operations", "HR-093", "Supaporn Suksawat", "Active" },
                    { new Guid("00000320-0000-005e-0000-039c000033b7"), "Finance", "FN-094", "Sorawit Thongchai", "On Leave" },
                    { new Guid("00000320-0000-005f-0000-039e000033b8"), "Sales", "SL-095", "Wimon Pradchaphet", "Probation" },
                    { new Guid("00000320-0000-0060-0000-03e0000033b9"), "Marketing", "MK-096", "Chanya Rattanarak", "Active" },
                    { new Guid("00000320-0000-0061-0000-03e2000033ba"), "Technology", "IT-097", "Suphakarn Boonsri", "Active" },
                    { new Guid("00000320-0000-0062-0000-03e4000033bb"), "Operations", "OP-098", "Anucha Mekchai", "Suspended" },
                    { new Guid("00000320-0000-0063-0000-03e6000033bc"), "People Operations", "HR-099", "Duangjai Chantana", "Active" },
                    { new Guid("00000320-0000-0064-0000-03e8000033bd"), "Finance", "FN-100", "Prasert Saithong", "Active" }
                });

            migrationBuilder.InsertData(
                table: "ReportLeaves",
                columns: new[] { "Id", "DaysUsed", "Employee", "LeaveType", "Status" },
                values: new object[,]
                {
                    { new Guid("0000032a-0000-0001-0000-032800003364"), 30, "Sorawit Thongchai", "Work From Home", "Approved" },
                    { new Guid("0000032a-0000-0002-0000-032e00003365"), 20, "Sorawit Thongchai", "Work From Home", "Approved" },
                    { new Guid("0000032a-0000-0003-0000-032c00003366"), 10, "Sorawit Thongchai", "Work From Home", "Approved" },
                    { new Guid("0000032a-0000-0004-0000-032200003367"), 50, "Sorawit Thongchai", "Work From Home", "Approved" },
                    { new Guid("0000032a-0000-0005-0000-032000003368"), 40, "Sorawit Thongchai", "Work From Home", "Approved" },
                    { new Guid("0000032a-0000-0006-0000-032600003369"), 40, "Duangjai Chantana", "Unpaid Leave", "Rejected" },
                    { new Guid("0000032a-0000-0007-0000-03240000336a"), 30, "Duangjai Chantana", "Unpaid Leave", "Rejected" },
                    { new Guid("0000032a-0000-0008-0000-033a0000336b"), 20, "Duangjai Chantana", "Unpaid Leave", "Rejected" },
                    { new Guid("0000032a-0000-0009-0000-03380000336c"), 10, "Duangjai Chantana", "Unpaid Leave", "Rejected" },
                    { new Guid("0000032a-0000-000a-0000-033e0000336d"), 50, "Duangjai Chantana", "Unpaid Leave", "Rejected" },
                    { new Guid("0000032a-0000-000b-0000-033c0000336e"), 20, "Warisa Chawengchai", "Sick Leave", "Pending" },
                    { new Guid("0000032a-0000-000c-0000-03320000336f"), 10, "Warisa Chawengchai", "Sick Leave", "Pending" },
                    { new Guid("0000032a-0000-000d-0000-033000003370"), 50, "Warisa Chawengchai", "Sick Leave", "Pending" },
                    { new Guid("0000032a-0000-000e-0000-033600003371"), 40, "Warisa Chawengchai", "Sick Leave", "Pending" },
                    { new Guid("0000032a-0000-000f-0000-033400003372"), 30, "Warisa Chawengchai", "Sick Leave", "Pending" },
                    { new Guid("0000032a-0000-0010-0000-030a00003373"), 10, "Nattawat Dechapanya", "Annual Leave", "Approved" },
                    { new Guid("0000032a-0000-0011-0000-030800003374"), 50, "Nattawat Dechapanya", "Annual Leave", "Approved" },
                    { new Guid("0000032a-0000-0012-0000-030e00003375"), 40, "Nattawat Dechapanya", "Annual Leave", "Approved" },
                    { new Guid("0000032a-0000-0013-0000-030c00003376"), 30, "Nattawat Dechapanya", "Annual Leave", "Approved" },
                    { new Guid("0000032a-0000-0014-0000-030200003377"), 20, "Nattawat Dechapanya", "Annual Leave", "Approved" }
                });

            migrationBuilder.InsertData(
                table: "ReportPayroll",
                columns: new[] { "Id", "GrossPay", "NetPay", "PayGroup", "Status" },
                values: new object[,]
                {
                    { new Guid("00000334-0000-0001-0000-03360000336e"), 782000m, 641240.00m, "2024-12", "Completed" },
                    { new Guid("00000334-0000-0002-0000-03300000336f"), 902000m, 739640.00m, "2025-01", "Approved" },
                    { new Guid("00000334-0000-0003-0000-033200003370"), 1022000m, 838040.00m, "2025-02", "Pending" },
                    { new Guid("00000334-0000-0004-0000-033c00003371"), 1142000m, 936440.00m, "2025-03", "Completed" },
                    { new Guid("00000334-0000-0005-0000-033e00003372"), 782000m, 641240.00m, "2024-12", "Completed" },
                    { new Guid("00000334-0000-0006-0000-033800003373"), 902000m, 739640.00m, "2025-01", "Approved" },
                    { new Guid("00000334-0000-0007-0000-033a00003374"), 1022000m, 838040.00m, "2025-02", "Pending" },
                    { new Guid("00000334-0000-0008-0000-032400003375"), 1142000m, 936440.00m, "2025-03", "Completed" },
                    { new Guid("00000334-0000-0009-0000-032600003376"), 782000m, 641240.00m, "2024-12", "Completed" },
                    { new Guid("00000334-0000-000a-0000-032000003377"), 902000m, 739640.00m, "2025-01", "Approved" },
                    { new Guid("00000334-0000-000b-0000-032200003378"), 1022000m, 838040.00m, "2025-02", "Pending" },
                    { new Guid("00000334-0000-000c-0000-032c00003379"), 1142000m, 936440.00m, "2025-03", "Completed" },
                    { new Guid("00000334-0000-000d-0000-032e0000337a"), 782000m, 641240.00m, "2024-12", "Completed" },
                    { new Guid("00000334-0000-000e-0000-03280000337b"), 902000m, 739640.00m, "2025-01", "Approved" },
                    { new Guid("00000334-0000-000f-0000-032a0000337c"), 1022000m, 838040.00m, "2025-02", "Pending" },
                    { new Guid("00000334-0000-0010-0000-03140000337d"), 1142000m, 936440.00m, "2025-03", "Completed" },
                    { new Guid("00000334-0000-0011-0000-03160000337e"), 736000m, 603520.00m, "2024-12", "Pending" },
                    { new Guid("00000334-0000-0012-0000-03100000337f"), 856000m, 701920.00m, "2025-01", "Completed" },
                    { new Guid("00000334-0000-0013-0000-031200003380"), 976000m, 800320.00m, "2025-02", "Approved" },
                    { new Guid("00000334-0000-0014-0000-031c00003381"), 1096000m, 898720.00m, "2025-03", "Pending" },
                    { new Guid("00000334-0000-0015-0000-031e00003382"), 736000m, 603520.00m, "2024-12", "Pending" },
                    { new Guid("00000334-0000-0016-0000-031800003383"), 856000m, 701920.00m, "2025-01", "Completed" },
                    { new Guid("00000334-0000-0017-0000-031a00003384"), 976000m, 800320.00m, "2025-02", "Approved" },
                    { new Guid("00000334-0000-0018-0000-030400003385"), 1096000m, 898720.00m, "2025-03", "Pending" }
                });

            migrationBuilder.InsertData(
                table: "ReportPerformance",
                columns: new[] { "Id", "AverageScore", "Department", "Status", "Trend" },
                values: new object[,]
                {
                    { new Guid("0000033e-0000-0001-0000-033c00003378"), 4.0m, "Finance", "Published", "+0.2" },
                    { new Guid("0000033e-0000-0002-0000-033a00003379"), 4.0m, "Operations", "Published", "-0.1" },
                    { new Guid("0000033e-0000-0003-0000-03380000337a"), 4.0m, "Marketing", "Published", "+0.2" }
                });

            migrationBuilder.InsertData(
                table: "SecurityAuditLogs",
                columns: new[] { "Id", "PerformedBy", "RunAtUtc", "Status", "Summary" },
                values: new object[,]
                {
                    { new Guid("000003ca-0000-0001-0000-03c800003404"), "Supaporn Teerapat", new DateTime(2025, 2, 18, 4, 0, 0, 0, DateTimeKind.Utc), "Completed", "Quarterly MFA and password rotation review completed with no blocking findings." },
                    { new Guid("000003ca-0000-0002-0000-03ce00003405"), "Kanokwan Yodying", new DateTime(2025, 3, 6, 3, 15, 0, 0, DateTimeKind.Utc), "In Progress", "Privileged access certification awaiting confirmation from Operations lead." }
                });

            migrationBuilder.InsertData(
                table: "SecuritySettings",
                columns: new[] { "Id", "Control", "LastReviewedAtUtc", "Owner", "Severity", "Status" },
                values: new object[,]
                {
                    { new Guid("000003ac-0000-0001-0000-03ae000033e6"), "Multi-factor authentication", new DateTime(2025, 2, 28, 7, 45, 0, 0, DateTimeKind.Utc), "Security Office", "High", "Enforced" },
                    { new Guid("000003ac-0000-0002-0000-03a8000033e7"), "Password policy", new DateTime(2025, 1, 15, 9, 15, 0, 0, DateTimeKind.Utc), "Security Office", "High", "12 chars / rotation 90 days" },
                    { new Guid("000003ac-0000-0003-0000-03aa000033e8"), "Privileged access review", new DateTime(2025, 3, 5, 2, 30, 0, 0, DateTimeKind.Utc), "Internal Audit", "Medium", "In progress" },
                    { new Guid("000003ac-0000-0004-0000-03a4000033e9"), "Data loss prevention", new DateTime(2025, 2, 10, 5, 50, 0, 0, DateTimeKind.Utc), "Security Office", "Medium", "Alerting" }
                });

            migrationBuilder.InsertData(
                table: "SystemConfigurations",
                columns: new[] { "Id", "Category", "Key", "Owner", "UpdatedAtUtc", "Value" },
                values: new object[,]
                {
                    { new Guid("000003a2-0000-0001-0000-03a0000033dc"), "Regionalisation", "PrimaryTimezone", "IT Platform", new DateTime(2025, 3, 1, 3, 0, 0, 0, DateTimeKind.Utc), "(UTC+07:00) Bangkok" },
                    { new Guid("000003a2-0000-0002-0000-03a6000033dd"), "Scheduling", "WorkweekTemplate", "People Operations", new DateTime(2025, 2, 12, 6, 0, 0, 0, DateTimeKind.Utc), "Mon-Fri, 09:00-18:00" },
                    { new Guid("000003a2-0000-0003-0000-03a4000033de"), "Scheduling", "HolidayCalendar", "People Operations", new DateTime(2025, 1, 28, 9, 30, 0, 0, DateTimeKind.Utc), "Thailand 2025" },
                    { new Guid("000003a2-0000-0004-0000-03aa000033df"), "Platform", "DataResidency", "Security Office", new DateTime(2024, 12, 12, 4, 0, 0, 0, DateTimeKind.Utc), "ap-southeast-1" }
                });

            migrationBuilder.InsertData(
                table: "TrainingRequests",
                columns: new[] { "Id", "ProgramName", "RequestedBy", "Status", "SubmittedOn" },
                values: new object[,]
                {
                    { new Guid("0000026c-0000-0001-0000-026e000032a6"), "Design Thinking Sprint", "Anan Techakul", "Pending", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0000026c-0000-0002-0000-0268000032a7"), "Advanced Excel Automation", "Apichat Suksawat", "Approved", new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0000026c-0000-0003-0000-026a000032a8"), "People Analytics", "Duangjai Intharachai", "Rejected", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0000026c-0000-0004-0000-0264000032a9"), "Strategic Negotiation", "Pisan Boonsri", "Pending", new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0000026c-0000-0005-0000-0266000032aa"), "Design Thinking Sprint", "Suphakarn Chawengchai", "Approved", new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0000026c-0000-0006-0000-0260000032ab"), "Advanced Excel Automation", "Kamol Techakul", "Rejected", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0000026c-0000-0007-0000-0262000032ac"), "People Analytics", "Wimon Suksawat", "Pending", new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0000026c-0000-0008-0000-027c000032ad"), "Strategic Negotiation", "Nattawat Intharachai", "Approved", new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0000026c-0000-0009-0000-027e000032ae"), "Design Thinking Sprint", "Supaporn Boonsri", "Rejected", new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0000026c-0000-000a-0000-0278000032af"), "Advanced Excel Automation", "Suchada Chawengchai", "Pending", new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0000026c-0000-000b-0000-027a000032b0"), "People Analytics", "Kannika Techakul", "Approved", new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0000026c-0000-000c-0000-0274000032b1"), "Strategic Negotiation", "Prasert Suksawat", "Rejected", new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0000026c-0000-000d-0000-0276000032b2"), "Design Thinking Sprint", "Warisa Intharachai", "Pending", new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0000026c-0000-000e-0000-0270000032b3"), "Advanced Excel Automation", "Anucha Boonsri", "Approved", new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0000026c-0000-000f-0000-0272000032b4"), "People Analytics", "Ratchada Chawengchai", "Rejected", new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0000026c-0000-0010-0000-024c000032b5"), "Strategic Negotiation", "Chanya Techakul", "Pending", new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TrainingSessions",
                columns: new[] { "Id", "SessionDate", "Status", "Title", "Trainer" },
                values: new object[,]
                {
                    { new Guid("00000258-0000-0001-0000-025a00003292"), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Open", "Advanced Angular Workshop", "Anan Techakun" },
                    { new Guid("00000258-0000-0002-0000-025c00003293"), new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Waitlist", "Leadership for Managers", "Sasithorn P." },
                    { new Guid("00000258-0000-0003-0000-025e00003294"), new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scheduled", "Financial Compliance Deep Dive", "James Walker" },
                    { new Guid("00000258-0000-0004-0000-025000003295"), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed", "Customer Empathy Lab", "Warisa K." },
                    { new Guid("00000258-0000-0005-0000-025200003296"), new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed", "Cloud Fundamentals", "Piyapong S." },
                    { new Guid("00000258-0000-0006-0000-025400003297"), new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Open", "Growth Marketing Experiments", "Arisa L." }
                });

            migrationBuilder.InsertData(
                table: "UserAccounts",
                columns: new[] { "Id", "Email", "Name", "Role", "Status" },
                values: new object[,]
                {
                    { new Guid("00000384-0000-0001-0000-0386000033be"), "anan.techakul@company.com", "Anan Techakul", "Administrator", "Suspended" },
                    { new Guid("00000384-0000-0002-0000-0380000033bf"), "korn.la-ongsri@company.com", "Korn La-ongsri", "Administrator", "Active" },
                    { new Guid("00000384-0000-0003-0000-0382000033c0"), "benjamas.chantana@company.com", "Benjamas Chantana", "Administrator", "Active" },
                    { new Guid("00000384-0000-0004-0000-038c000033c1"), "ratchada.kittiphob@company.com", "Ratchada Kittiphob", "Administrator", "Active" },
                    { new Guid("00000384-0000-0005-0000-038e000033c2"), "warisa.boonsri@company.com", "Warisa Boonsri", "Administrator", "Active" },
                    { new Guid("00000384-0000-0006-0000-0388000033c3"), "kannika.wiriyakul@company.com", "Kannika Wiriyakul", "Manager", "Active" },
                    { new Guid("00000384-0000-0007-0000-038a000033c4"), "supaporn.pradchaphet@company.com", "Supaporn Pradchaphet", "Manager", "Active" },
                    { new Guid("00000384-0000-0008-0000-0394000033c5"), "wimon.dechapanya@company.com", "Wimon Dechapanya", "Manager", "Active" },
                    { new Guid("00000384-0000-0009-0000-0396000033c6"), "suphakarn.suksawat@company.com", "Suphakarn Suksawat", "Manager", "Active" },
                    { new Guid("00000384-0000-000a-0000-0390000033c7"), "duangjai.kongthanaraj@company.com", "Duangjai Kongthanaraj", "Manager", "Suspended" },
                    { new Guid("00000384-0000-000b-0000-0392000033c8"), "anan.pakdeepong@company.com", "Anan Pakdeepong", "Employee", "Active" },
                    { new Guid("00000384-0000-000c-0000-039c000033c9"), "korn.saithong@company.com", "Korn Saithong", "Employee", "Active" },
                    { new Guid("00000384-0000-000d-0000-039e000033ca"), "benjamas.chawengchai@company.com", "Benjamas Chawengchai", "Employee", "Active" },
                    { new Guid("00000384-0000-000e-0000-0398000033cb"), "ratchada.mekchai@company.com", "Ratchada Mekchai", "Employee", "Active" },
                    { new Guid("00000384-0000-000f-0000-039a000033cc"), "warisa.wongchai@company.com", "Warisa Wongchai", "Employee", "Active" },
                    { new Guid("00000384-0000-0010-0000-03a4000033cd"), "kannika.rattanarak@company.com", "Kannika Rattanarak", "Employee", "Active" },
                    { new Guid("00000384-0000-0011-0000-03a6000033ce"), "supaporn.intharachai@company.com", "Supaporn Intharachai", "Employee", "Active" },
                    { new Guid("00000384-0000-0012-0000-03a0000033cf"), "wimon.thongchai@company.com", "Wimon Thongchai", "Employee", "Active" },
                    { new Guid("00000384-0000-0013-0000-03a2000033d0"), "suphakarn.praphan@company.com", "Suphakarn Praphan", "Employee", "Suspended" },
                    { new Guid("00000384-0000-0014-0000-03ac000033d1"), "duangjai.srisawat@company.com", "Duangjai Srisawat", "Employee", "Active" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "AssignedUsers", "Description", "Role" },
                values: new object[,]
                {
                    { new Guid("0000038e-0000-0001-0000-038c000033c8"), 5, "Full access to manage system settings", "Administrator" },
                    { new Guid("0000038e-0000-0002-0000-038a000033c9"), 5, "Manage team approvals and reports", "Manager" },
                    { new Guid("0000038e-0000-0003-0000-0388000033ca"), 10, "Self-service access to personal data", "Employee" }
                });

            migrationBuilder.InsertData(
                table: "WorkforcePlanEntries",
                columns: new[] { "Id", "ApprovedHeadcountQ3", "AttritionRisk", "Department", "DepartmentLead", "Focus", "NextCriticalHire", "Owner", "UpdatedAtUtc" },
                values: new object[,]
                {
                    { new Guid("000003b6-0000-0001-0000-03b4000033f0"), 9, "Low", "People Operations", "Chanon Phumiphak", "HR strategy, talent development", "HR Business Partner", "People Operations", new DateTime(2025, 3, 10, 4, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000003b6-0000-0002-0000-03b2000033f1"), 16, "Medium", "Technology", "Anuwat Khem", "Product delivery, platform reliability", "Senior Backend Engineer", "Technology", new DateTime(2025, 3, 2, 8, 30, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000003b6-0000-0003-0000-03b0000033f2"), 6, "Low", "Finance", "Benjamas Sriwilai", "Payroll, budgeting, treasury", "Revenue Assurance Analyst", "Finance", new DateTime(2025, 2, 20, 9, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000003b6-0000-0004-0000-03be000033f3"), 7, "Medium", "Marketing", "Oranicha Mek", "Demand generation, brand growth", "Lifecycle Marketer", "Marketing", new DateTime(2025, 3, 8, 6, 45, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000003b6-0000-0005-0000-03bc000033f4"), 5, "Low", "Customer Success", "Jirawat Kan", "Onboarding, renewals, support excellence", "Technical Account Manager", "Customer Success", new DateTime(2025, 3, 3, 11, 15, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000003b6-0000-0006-0000-03ba000033f5"), 6, "Medium", "Operations", "Amara Jittrakorn", "Facilities, procurement, logistics", "Facilities Supervisor", "Operations", new DateTime(2025, 2, 27, 7, 10, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000003b6-0000-0007-0000-03b8000033f6"), 4, "High", "Sales", "Pimchanok Rukdee", "Enterprise acquisition, account growth", "Enterprise Account Executive", "Sales", new DateTime(2025, 3, 6, 5, 20, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000003b6-0000-0008-0000-03a6000033f7"), 4, "Medium", "Data & Analytics", "Piyada Sornchai", "Insights, dashboards, data governance", "Analytics Engineer", "Data & Analytics", new DateTime(2025, 2, 25, 10, 5, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "EngagementSurveyMetrics",
                columns: new[] { "Id", "MetricName", "Score", "SurveyId", "Trend" },
                values: new object[,]
                {
                    { new Guid("000002c6-0000-0001-0000-02c400003300"), "Participation", "86%", new Guid("000002bc-0000-0001-0000-02be000032f6"), "+4% QoQ" },
                    { new Guid("000002c6-0000-0002-0000-02c200003301"), "eNPS", "41", new Guid("000002bc-0000-0001-0000-02be000032f6"), "+3" },
                    { new Guid("000002c6-0000-0003-0000-02c000003302"), "Readiness", "72%", new Guid("000002bc-0000-0002-0000-02b8000032f7"), "+2%" },
                    { new Guid("000002c6-0000-0004-0000-02ce00003303"), "eNPS", "35", new Guid("000002bc-0000-0003-0000-02ba000032f8"), "+5" },
                    { new Guid("000002c6-0000-0005-0000-02cc00003304"), "Manager Effectiveness", "4.1", new Guid("000002bc-0000-0003-0000-02ba000032f8"), "+0.3" }
                });

            migrationBuilder.InsertData(
                table: "LeaveRequests",
                columns: new[] { "Id", "EmployeeId", "EndDate", "LeaveType", "Reference", "RequestedOn", "StartDate", "Status" },
                values: new object[,]
                {
                    { new Guid("000000c8-0000-0001-0000-00ca00003102"), new Guid("00000064-0000-0004-0000-006c000030a1"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2023-0001", new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0002-0000-00cc00003103"), new Guid("00000064-0000-0009-0000-0076000030a6"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2023-0002", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-0003-0000-00ce00003104"), new Guid("00000064-0000-000e-0000-0078000030ab"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2023-0003", new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0004-0000-00c000003105"), new Guid("00000064-0000-0013-0000-0042000030b0"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2023-0004", new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0005-0000-00c200003106"), new Guid("00000064-0000-0018-0000-0054000030b5"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2023-0005", new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0006-0000-00c400003107"), new Guid("00000064-0000-001d-0000-005e000030ba"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2023-0006", new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-0007-0000-00c600003108"), new Guid("00000064-0000-0022-0000-0020000030bf"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2023-0007", new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0008-0000-00d800003109"), new Guid("00000064-0000-0027-0000-002a000030c4"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2023-0008", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0009-0000-00da0000310a"), new Guid("00000064-0000-002c-0000-003c000030c9"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2023-0009", new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-000a-0000-00dc0000310b"), new Guid("00000064-0000-0031-0000-0006000030ce"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2023-0010", new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-000b-0000-00de0000310c"), new Guid("00000064-0000-0036-0000-0008000030d3"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2023-0011", new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-000c-0000-00d00000310d"), new Guid("00000064-0000-003b-0000-0012000030d8"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2023-0012", new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-000d-0000-00d20000310e"), new Guid("00000064-0000-0040-0000-00e4000030dd"), new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2023-0013", new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-000e-0000-00d40000310f"), new Guid("00000064-0000-0045-0000-00ee000030e2"), new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2023-0014", new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-000f-0000-00d600003110"), new Guid("00000064-0000-004a-0000-00f0000030e7"), new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2023-0015", new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0010-0000-00e800003111"), new Guid("00000064-0000-004f-0000-00fa000030ec"), new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2023-0016", new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0011-0000-00ea00003112"), new Guid("00000064-0000-0054-0000-00cc000030f1"), new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2023-0017", new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0012-0000-00ec00003113"), new Guid("00000064-0000-0059-0000-00d6000030f6"), new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2023-0018", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-0013-0000-00ee00003114"), new Guid("00000064-0000-005e-0000-00d8000030fb"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2023-0019", new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0014-0000-00e000003115"), new Guid("00000064-0000-0063-0000-00a200003100"), new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2023-0020", new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0015-0000-00e200003116"), new Guid("00000064-0000-0004-0000-006c000030a1"), new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2023-0021", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0016-0000-00e400003117"), new Guid("00000064-0000-0009-0000-0076000030a6"), new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2023-0022", new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-0017-0000-00e600003118"), new Guid("00000064-0000-000e-0000-0078000030ab"), new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2023-0023", new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0018-0000-00f800003119"), new Guid("00000064-0000-0013-0000-0042000030b0"), new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2023-0024", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0019-0000-00fa0000311a"), new Guid("00000064-0000-0018-0000-0054000030b5"), new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2023-0025", new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-001a-0000-00fc0000311b"), new Guid("00000064-0000-001d-0000-005e000030ba"), new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2023-0026", new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-001b-0000-00fe0000311c"), new Guid("00000064-0000-0022-0000-0020000030bf"), new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2023-0027", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-001c-0000-00f00000311d"), new Guid("00000064-0000-0027-0000-002a000030c4"), new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2023-0028", new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-001d-0000-00f20000311e"), new Guid("00000064-0000-002c-0000-003c000030c9"), new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2023-0029", new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-001e-0000-00f40000311f"), new Guid("00000064-0000-0031-0000-0006000030ce"), new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2023-0030", new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-001f-0000-00f600003120"), new Guid("00000064-0000-0036-0000-0008000030d3"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2023-0031", new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0020-0000-008800003121"), new Guid("00000064-0000-003b-0000-0012000030d8"), new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2023-0032", new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0021-0000-008a00003122"), new Guid("00000064-0000-0040-0000-00e4000030dd"), new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2023-0033", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0022-0000-008c00003123"), new Guid("00000064-0000-0045-0000-00ee000030e2"), new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2023-0034", new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-0023-0000-008e00003124"), new Guid("00000064-0000-004a-0000-00f0000030e7"), new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2023-0035", new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0024-0000-008000003125"), new Guid("00000064-0000-004f-0000-00fa000030ec"), new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2023-0036", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0025-0000-008200003126"), new Guid("00000064-0000-0054-0000-00cc000030f1"), new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2023-0037", new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0026-0000-008400003127"), new Guid("00000064-0000-0059-0000-00d6000030f6"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2023-0038", new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-0027-0000-008600003128"), new Guid("00000064-0000-005e-0000-00d8000030fb"), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2023-0039", new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0028-0000-009800003129"), new Guid("00000064-0000-0063-0000-00a200003100"), new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2023-0040", new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0029-0000-009a0000312a"), new Guid("00000064-0000-0004-0000-006c000030a1"), new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2023-0041", new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-002a-0000-009c0000312b"), new Guid("00000064-0000-0009-0000-0076000030a6"), new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2023-0042", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-002b-0000-009e0000312c"), new Guid("00000064-0000-000e-0000-0078000030ab"), new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2023-0043", new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-002c-0000-00900000312d"), new Guid("00000064-0000-0013-0000-0042000030b0"), new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2023-0044", new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-002d-0000-00920000312e"), new Guid("00000064-0000-0018-0000-0054000030b5"), new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2023-0045", new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-002e-0000-00940000312f"), new Guid("00000064-0000-001d-0000-005e000030ba"), new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2023-0046", new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-002f-0000-009600003130"), new Guid("00000064-0000-0022-0000-0020000030bf"), new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2023-0047", new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0030-0000-00a800003131"), new Guid("00000064-0000-0027-0000-002a000030c4"), new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2023-0048", new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0031-0000-00aa00003132"), new Guid("00000064-0000-002c-0000-003c000030c9"), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2023-0049", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0032-0000-00ac00003133"), new Guid("00000064-0000-0031-0000-0006000030ce"), new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2023-0050", new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-0033-0000-00ae00003134"), new Guid("00000064-0000-0036-0000-0008000030d3"), new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2023-0051", new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0034-0000-00a000003135"), new Guid("00000064-0000-003b-0000-0012000030d8"), new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2023-0052", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0035-0000-00a200003136"), new Guid("00000064-0000-0040-0000-00e4000030dd"), new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2023-0053", new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0036-0000-00a400003137"), new Guid("00000064-0000-0045-0000-00ee000030e2"), new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2023-0054", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-0037-0000-00a600003138"), new Guid("00000064-0000-004a-0000-00f0000030e7"), new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2023-0055", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0038-0000-00b800003139"), new Guid("00000064-0000-004f-0000-00fa000030ec"), new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2023-0056", new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0039-0000-00ba0000313a"), new Guid("00000064-0000-0054-0000-00cc000030f1"), new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2023-0057", new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-003a-0000-00bc0000313b"), new Guid("00000064-0000-0059-0000-00d6000030f6"), new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2023-0058", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-003b-0000-00be0000313c"), new Guid("00000064-0000-005e-0000-00d8000030fb"), new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2023-0059", new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-003c-0000-00b00000313d"), new Guid("00000064-0000-0063-0000-00a200003100"), new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2023-0060", new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-003d-0000-00b20000313e"), new Guid("00000064-0000-0004-0000-006c000030a1"), new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2023-0061", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-003e-0000-00b40000313f"), new Guid("00000064-0000-0009-0000-0076000030a6"), new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2023-0062", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-003f-0000-00b600003140"), new Guid("00000064-0000-000e-0000-0078000030ab"), new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2023-0063", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0040-0000-004800003141"), new Guid("00000064-0000-0013-0000-0042000030b0"), new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2023-0064", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0041-0000-004a00003142"), new Guid("00000064-0000-0018-0000-0054000030b5"), new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2023-0065", new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0042-0000-004c00003143"), new Guid("00000064-0000-001d-0000-005e000030ba"), new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2023-0066", new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-0043-0000-004e00003144"), new Guid("00000064-0000-0022-0000-0020000030bf"), new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2023-0067", new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0044-0000-004000003145"), new Guid("00000064-0000-0027-0000-002a000030c4"), new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2023-0068", new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0045-0000-004200003146"), new Guid("00000064-0000-002c-0000-003c000030c9"), new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2023-0069", new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0046-0000-004400003147"), new Guid("00000064-0000-0031-0000-0006000030ce"), new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2023-0070", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-0047-0000-004600003148"), new Guid("00000064-0000-0036-0000-0008000030d3"), new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2023-0071", new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0048-0000-005800003149"), new Guid("00000064-0000-003b-0000-0012000030d8"), new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2023-0072", new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0049-0000-005a0000314a"), new Guid("00000064-0000-0040-0000-00e4000030dd"), new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2023-0073", new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-004a-0000-005c0000314b"), new Guid("00000064-0000-0045-0000-00ee000030e2"), new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2023-0074", new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-004b-0000-005e0000314c"), new Guid("00000064-0000-004a-0000-00f0000030e7"), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2023-0075", new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-004c-0000-00500000314d"), new Guid("00000064-0000-004f-0000-00fa000030ec"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0076", new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-004d-0000-00520000314e"), new Guid("00000064-0000-0054-0000-00cc000030f1"), new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0077", new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-004e-0000-00540000314f"), new Guid("00000064-0000-0059-0000-00d6000030f6"), new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0078", new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-004f-0000-005600003150"), new Guid("00000064-0000-005e-0000-00d8000030fb"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0079", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0050-0000-006800003151"), new Guid("00000064-0000-0063-0000-00a200003100"), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0080", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0051-0000-006a00003152"), new Guid("00000064-0000-0004-0000-006c000030a1"), new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0081", new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0052-0000-006c00003153"), new Guid("00000064-0000-0009-0000-0076000030a6"), new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0082", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-0053-0000-006e00003154"), new Guid("00000064-0000-000e-0000-0078000030ab"), new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0083", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0054-0000-006000003155"), new Guid("00000064-0000-0013-0000-0042000030b0"), new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0084", new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0055-0000-006200003156"), new Guid("00000064-0000-0018-0000-0054000030b5"), new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0085", new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0056-0000-006400003157"), new Guid("00000064-0000-001d-0000-005e000030ba"), new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0086", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-0057-0000-006600003158"), new Guid("00000064-0000-0022-0000-0020000030bf"), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0087", new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0058-0000-007800003159"), new Guid("00000064-0000-0027-0000-002a000030c4"), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0088", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0059-0000-007a0000315a"), new Guid("00000064-0000-002c-0000-003c000030c9"), new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0089", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-005a-0000-007c0000315b"), new Guid("00000064-0000-0031-0000-0006000030ce"), new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0090", new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-005b-0000-007e0000315c"), new Guid("00000064-0000-0036-0000-0008000030d3"), new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0091", new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-005c-0000-00700000315d"), new Guid("00000064-0000-003b-0000-0012000030d8"), new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0092", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-005d-0000-00720000315e"), new Guid("00000064-0000-0040-0000-00e4000030dd"), new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0093", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-005e-0000-00740000315f"), new Guid("00000064-0000-0045-0000-00ee000030e2"), new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0094", new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-005f-0000-007600003160"), new Guid("00000064-0000-004a-0000-00f0000030e7"), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0095", new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0060-0000-000800003161"), new Guid("00000064-0000-004f-0000-00fa000030ec"), new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0096", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0061-0000-000a00003162"), new Guid("00000064-0000-0054-0000-00cc000030f1"), new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0097", new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0062-0000-000c00003163"), new Guid("00000064-0000-0059-0000-00d6000030f6"), new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0098", new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-0063-0000-000e00003164"), new Guid("00000064-0000-005e-0000-00d8000030fb"), new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0099", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0064-0000-000000003165"), new Guid("00000064-0000-0063-0000-00a200003100"), new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0100", new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0065-0000-000200003166"), new Guid("00000064-0000-0004-0000-006c000030a1"), new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0101", new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0066-0000-000400003167"), new Guid("00000064-0000-0009-0000-0076000030a6"), new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0102", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-0067-0000-000600003168"), new Guid("00000064-0000-000e-0000-0078000030ab"), new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0103", new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0068-0000-001800003169"), new Guid("00000064-0000-0013-0000-0042000030b0"), new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0104", new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0069-0000-001a0000316a"), new Guid("00000064-0000-0018-0000-0054000030b5"), new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0105", new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-006a-0000-001c0000316b"), new Guid("00000064-0000-001d-0000-005e000030ba"), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0106", new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-006b-0000-001e0000316c"), new Guid("00000064-0000-0022-0000-0020000030bf"), new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0107", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-006c-0000-00100000316d"), new Guid("00000064-0000-0027-0000-002a000030c4"), new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0108", new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-006d-0000-00120000316e"), new Guid("00000064-0000-002c-0000-003c000030c9"), new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0109", new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-006e-0000-00140000316f"), new Guid("00000064-0000-0031-0000-0006000030ce"), new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0110", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-006f-0000-001600003170"), new Guid("00000064-0000-0036-0000-0008000030d3"), new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0111", new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0070-0000-002800003171"), new Guid("00000064-0000-003b-0000-0012000030d8"), new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0112", new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0071-0000-002a00003172"), new Guid("00000064-0000-0040-0000-00e4000030dd"), new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0113", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0072-0000-002c00003173"), new Guid("00000064-0000-0045-0000-00ee000030e2"), new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0114", new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-0073-0000-002e00003174"), new Guid("00000064-0000-004a-0000-00f0000030e7"), new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0115", new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0074-0000-002000003175"), new Guid("00000064-0000-004f-0000-00fa000030ec"), new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0116", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0075-0000-002200003176"), new Guid("00000064-0000-0054-0000-00cc000030f1"), new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0117", new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0076-0000-002400003177"), new Guid("00000064-0000-0059-0000-00d6000030f6"), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0118", new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-0077-0000-002600003178"), new Guid("00000064-0000-005e-0000-00d8000030fb"), new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0119", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0078-0000-003800003179"), new Guid("00000064-0000-0063-0000-00a200003100"), new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0120", new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0079-0000-003a0000317a"), new Guid("00000064-0000-0004-0000-006c000030a1"), new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0121", new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-007a-0000-003c0000317b"), new Guid("00000064-0000-0009-0000-0076000030a6"), new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0122", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-007b-0000-003e0000317c"), new Guid("00000064-0000-000e-0000-0078000030ab"), new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0123", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-007c-0000-00300000317d"), new Guid("00000064-0000-0013-0000-0042000030b0"), new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0124", new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-007d-0000-00320000317e"), new Guid("00000064-0000-0018-0000-0054000030b5"), new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0125", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-007e-0000-00340000317f"), new Guid("00000064-0000-001d-0000-005e000030ba"), new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0126", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-007f-0000-003600003180"), new Guid("00000064-0000-0022-0000-0020000030bf"), new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0127", new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0080-0000-01c800003181"), new Guid("00000064-0000-0027-0000-002a000030c4"), new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0128", new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0081-0000-01ca00003182"), new Guid("00000064-0000-002c-0000-003c000030c9"), new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0129", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0082-0000-01cc00003183"), new Guid("00000064-0000-0031-0000-0006000030ce"), new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0130", new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-0083-0000-01ce00003184"), new Guid("00000064-0000-0036-0000-0008000030d3"), new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0131", new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0084-0000-01c000003185"), new Guid("00000064-0000-003b-0000-0012000030d8"), new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0132", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0085-0000-01c200003186"), new Guid("00000064-0000-0040-0000-00e4000030dd"), new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0133", new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0086-0000-01c400003187"), new Guid("00000064-0000-0045-0000-00ee000030e2"), new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0134", new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-0087-0000-01c600003188"), new Guid("00000064-0000-004a-0000-00f0000030e7"), new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0135", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0088-0000-01d800003189"), new Guid("00000064-0000-004f-0000-00fa000030ec"), new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0136", new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0089-0000-01da0000318a"), new Guid("00000064-0000-0054-0000-00cc000030f1"), new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0137", new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-008a-0000-01dc0000318b"), new Guid("00000064-0000-0059-0000-00d6000030f6"), new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0138", new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-008b-0000-01de0000318c"), new Guid("00000064-0000-005e-0000-00d8000030fb"), new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0139", new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-008c-0000-01d00000318d"), new Guid("00000064-0000-0063-0000-00a200003100"), new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0140", new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-008d-0000-01d20000318e"), new Guid("00000064-0000-0004-0000-006c000030a1"), new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0141", new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-008e-0000-01d40000318f"), new Guid("00000064-0000-0009-0000-0076000030a6"), new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0142", new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-008f-0000-01d600003190"), new Guid("00000064-0000-000e-0000-0078000030ab"), new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0143", new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0090-0000-01e800003191"), new Guid("00000064-0000-0013-0000-0042000030b0"), new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0144", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0091-0000-01ea00003192"), new Guid("00000064-0000-0018-0000-0054000030b5"), new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0145", new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0092-0000-01ec00003193"), new Guid("00000064-0000-001d-0000-005e000030ba"), new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0146", new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-0093-0000-01ee00003194"), new Guid("00000064-0000-0022-0000-0020000030bf"), new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0147", new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0094-0000-01e000003195"), new Guid("00000064-0000-0027-0000-002a000030c4"), new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0148", new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0095-0000-01e200003196"), new Guid("00000064-0000-002c-0000-003c000030c9"), new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0149", new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0096-0000-01e400003197"), new Guid("00000064-0000-0031-0000-0006000030ce"), new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0150", new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-0097-0000-01e600003198"), new Guid("00000064-0000-0036-0000-0008000030d3"), new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0151", new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-0098-0000-01f800003199"), new Guid("00000064-0000-003b-0000-0012000030d8"), new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0152", new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-0099-0000-01fa0000319a"), new Guid("00000064-0000-0040-0000-00e4000030dd"), new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0153", new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-009a-0000-01fc0000319b"), new Guid("00000064-0000-0045-0000-00ee000030e2"), new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0154", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-009b-0000-01fe0000319c"), new Guid("00000064-0000-004a-0000-00f0000030e7"), new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0155", new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-009c-0000-01f00000319d"), new Guid("00000064-0000-004f-0000-00fa000030ec"), new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0156", new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-009d-0000-01f20000319e"), new Guid("00000064-0000-0054-0000-00cc000030f1"), new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0157", new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-009e-0000-01f40000319f"), new Guid("00000064-0000-0059-0000-00d6000030f6"), new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0158", new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-009f-0000-01f6000031a0"), new Guid("00000064-0000-005e-0000-00d8000030fb"), new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0159", new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00a0-0000-0188000031a1"), new Guid("00000064-0000-0063-0000-00a200003100"), new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0160", new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-00a1-0000-018a000031a2"), new Guid("00000064-0000-0004-0000-006c000030a1"), new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0161", new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00a2-0000-018c000031a3"), new Guid("00000064-0000-0009-0000-0076000030a6"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0162", new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-00a3-0000-018e000031a4"), new Guid("00000064-0000-000e-0000-0078000030ab"), new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0163", new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00a4-0000-0180000031a5"), new Guid("00000064-0000-0013-0000-0042000030b0"), new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0164", new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-00a5-0000-0182000031a6"), new Guid("00000064-0000-0018-0000-0054000030b5"), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0165", new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00a6-0000-0184000031a7"), new Guid("00000064-0000-001d-0000-005e000030ba"), new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0166", new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-00a7-0000-0186000031a8"), new Guid("00000064-0000-0022-0000-0020000030bf"), new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0167", new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00a8-0000-0198000031a9"), new Guid("00000064-0000-0027-0000-002a000030c4"), new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0168", new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-00a9-0000-019a000031aa"), new Guid("00000064-0000-002c-0000-003c000030c9"), new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0169", new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00aa-0000-019c000031ab"), new Guid("00000064-0000-0031-0000-0006000030ce"), new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0170", new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-00ab-0000-019e000031ac"), new Guid("00000064-0000-0036-0000-0008000030d3"), new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0171", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00ac-0000-0190000031ad"), new Guid("00000064-0000-003b-0000-0012000030d8"), new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0172", new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-00ad-0000-0192000031ae"), new Guid("00000064-0000-0040-0000-00e4000030dd"), new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0173", new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00ae-0000-0194000031af"), new Guid("00000064-0000-0045-0000-00ee000030e2"), new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0174", new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-00af-0000-0196000031b0"), new Guid("00000064-0000-004a-0000-00f0000030e7"), new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0175", new DateTime(2024, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00b0-0000-01a8000031b1"), new Guid("00000064-0000-004f-0000-00fa000030ec"), new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0176", new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-00b1-0000-01aa000031b2"), new Guid("00000064-0000-0054-0000-00cc000030f1"), new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0177", new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00b2-0000-01ac000031b3"), new Guid("00000064-0000-0059-0000-00d6000030f6"), new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0178", new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-00b3-0000-01ae000031b4"), new Guid("00000064-0000-005e-0000-00d8000030fb"), new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0179", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00b4-0000-01a0000031b5"), new Guid("00000064-0000-0063-0000-00a200003100"), new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0180", new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-00b5-0000-01a2000031b6"), new Guid("00000064-0000-0004-0000-006c000030a1"), new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0181", new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00b6-0000-01a4000031b7"), new Guid("00000064-0000-0009-0000-0076000030a6"), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0182", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-00b7-0000-01a6000031b8"), new Guid("00000064-0000-000e-0000-0078000030ab"), new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0183", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00b8-0000-01b8000031b9"), new Guid("00000064-0000-0013-0000-0042000030b0"), new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0184", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-00b9-0000-01ba000031ba"), new Guid("00000064-0000-0018-0000-0054000030b5"), new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0185", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00ba-0000-01bc000031bb"), new Guid("00000064-0000-001d-0000-005e000030ba"), new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0186", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-00bb-0000-01be000031bc"), new Guid("00000064-0000-0022-0000-0020000030bf"), new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0187", new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00bc-0000-01b0000031bd"), new Guid("00000064-0000-0027-0000-002a000030c4"), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0188", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-00bd-0000-01b2000031be"), new Guid("00000064-0000-002c-0000-003c000030c9"), new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0189", new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00be-0000-01b4000031bf"), new Guid("00000064-0000-0031-0000-0006000030ce"), new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0190", new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-00bf-0000-01b6000031c0"), new Guid("00000064-0000-0036-0000-0008000030d3"), new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0191", new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00c0-0000-0148000031c1"), new Guid("00000064-0000-003b-0000-0012000030d8"), new DateTime(2024, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0192", new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-00c1-0000-014a000031c2"), new Guid("00000064-0000-0040-0000-00e4000030dd"), new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0193", new DateTime(2024, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00c2-0000-014c000031c3"), new Guid("00000064-0000-0045-0000-00ee000030e2"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0194", new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-00c3-0000-014e000031c4"), new Guid("00000064-0000-004a-0000-00f0000030e7"), new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0195", new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00c4-0000-0140000031c5"), new Guid("00000064-0000-004f-0000-00fa000030ec"), new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0196", new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" },
                    { new Guid("000000c8-0000-00c5-0000-0142000031c6"), new Guid("00000064-0000-0054-0000-00cc000030f1"), new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual Leave", "LV-2024-0197", new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00c6-0000-0144000031c7"), new Guid("00000064-0000-0059-0000-00d6000030f6"), new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "LV-2024-0198", new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { new Guid("000000c8-0000-00c7-0000-0146000031c8"), new Guid("00000064-0000-005e-0000-00d8000030fb"), new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work From Home", "LV-2024-0199", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { new Guid("000000c8-0000-00c8-0000-0158000031c9"), new Guid("00000064-0000-0063-0000-00a200003100"), new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid Leave", "LV-2024-0200", new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected" }
                });

            migrationBuilder.InsertData(
                table: "PayslipComponents",
                columns: new[] { "Id", "Amount", "ComponentName", "EmployeeId", "Notes", "PayPeriod" },
                values: new object[,]
                {
                    { new Guid("0000012c-0000-0001-0000-012e00003166"), 38000m, "Base Salary", new Guid("00000064-0000-0001-0000-00660000309e"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-0002-0000-012800003167"), 7600.0m, "Bonus", new Guid("00000064-0000-0001-0000-00660000309e"), "Quarterly performance bonus", "2024-12" },
                    { new Guid("0000012c-0000-0003-0000-012a00003168"), -1900.00m, "Withholding Tax", new Guid("00000064-0000-0001-0000-00660000309e"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-0004-0000-012400003169"), 1500m, "Internet Allowance", new Guid("00000064-0000-0001-0000-00660000309e"), "Monthly allowance", "2024-12" },
                    { new Guid("0000012c-0000-0005-0000-01260000316a"), 38000m, "Base Salary", new Guid("00000064-0000-0001-0000-00660000309e"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-0006-0000-01200000316b"), 7600.0m, "Bonus", new Guid("00000064-0000-0001-0000-00660000309e"), "Quarterly performance bonus", "2025-01" },
                    { new Guid("0000012c-0000-0007-0000-01220000316c"), -1900.00m, "Withholding Tax", new Guid("00000064-0000-0001-0000-00660000309e"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-0008-0000-013c0000316d"), 1500m, "Internet Allowance", new Guid("00000064-0000-0001-0000-00660000309e"), "Monthly allowance", "2025-01" },
                    { new Guid("0000012c-0000-0009-0000-013e0000316e"), 38000m, "Base Salary", new Guid("00000064-0000-0001-0000-00660000309e"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-000a-0000-01380000316f"), 7600.0m, "Bonus", new Guid("00000064-0000-0001-0000-00660000309e"), "Quarterly performance bonus", "2025-02" },
                    { new Guid("0000012c-0000-000b-0000-013a00003170"), -1900.00m, "Withholding Tax", new Guid("00000064-0000-0001-0000-00660000309e"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-000c-0000-013400003171"), 1500m, "Internet Allowance", new Guid("00000064-0000-0001-0000-00660000309e"), "Monthly allowance", "2025-02" },
                    { new Guid("0000012c-0000-000d-0000-013600003172"), 38000m, "Base Salary", new Guid("00000064-0000-0001-0000-00660000309e"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-000e-0000-013000003173"), 7600.0m, "Bonus", new Guid("00000064-0000-0001-0000-00660000309e"), "Quarterly performance bonus", "2025-03" },
                    { new Guid("0000012c-0000-000f-0000-013200003174"), -1900.00m, "Withholding Tax", new Guid("00000064-0000-0001-0000-00660000309e"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-0010-0000-010c00003175"), 1500m, "Internet Allowance", new Guid("00000064-0000-0001-0000-00660000309e"), "Monthly allowance", "2025-03" },
                    { new Guid("0000012c-0000-0011-0000-010e00003176"), 40500m, "Base Salary", new Guid("00000064-0000-0002-0000-00600000309f"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-0012-0000-010800003177"), -2025.00m, "Withholding Tax", new Guid("00000064-0000-0002-0000-00600000309f"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-0013-0000-010a00003178"), 40500m, "Base Salary", new Guid("00000064-0000-0002-0000-00600000309f"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-0014-0000-010400003179"), -2025.00m, "Withholding Tax", new Guid("00000064-0000-0002-0000-00600000309f"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-0015-0000-01060000317a"), 40500m, "Base Salary", new Guid("00000064-0000-0002-0000-00600000309f"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-0016-0000-01000000317b"), -2025.00m, "Withholding Tax", new Guid("00000064-0000-0002-0000-00600000309f"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-0017-0000-01020000317c"), 40500m, "Base Salary", new Guid("00000064-0000-0002-0000-00600000309f"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-0018-0000-011c0000317d"), -2025.00m, "Withholding Tax", new Guid("00000064-0000-0002-0000-00600000309f"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-0019-0000-011e0000317e"), 43000m, "Base Salary", new Guid("00000064-0000-0003-0000-0062000030a0"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-001a-0000-01180000317f"), -2150.00m, "Withholding Tax", new Guid("00000064-0000-0003-0000-0062000030a0"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-001b-0000-011a00003180"), 43000m, "Base Salary", new Guid("00000064-0000-0003-0000-0062000030a0"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-001c-0000-011400003181"), -2150.00m, "Withholding Tax", new Guid("00000064-0000-0003-0000-0062000030a0"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-001d-0000-011600003182"), 43000m, "Base Salary", new Guid("00000064-0000-0003-0000-0062000030a0"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-001e-0000-011000003183"), -2150.00m, "Withholding Tax", new Guid("00000064-0000-0003-0000-0062000030a0"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-001f-0000-011200003184"), 43000m, "Base Salary", new Guid("00000064-0000-0003-0000-0062000030a0"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-0020-0000-016c00003185"), -2150.00m, "Withholding Tax", new Guid("00000064-0000-0003-0000-0062000030a0"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-0021-0000-016e00003186"), 45500m, "Base Salary", new Guid("00000064-0000-0004-0000-006c000030a1"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-0022-0000-016800003187"), 9100.0m, "Bonus", new Guid("00000064-0000-0004-0000-006c000030a1"), "Quarterly performance bonus", "2024-12" },
                    { new Guid("0000012c-0000-0023-0000-016a00003188"), -2275.00m, "Withholding Tax", new Guid("00000064-0000-0004-0000-006c000030a1"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-0024-0000-016400003189"), 45500m, "Base Salary", new Guid("00000064-0000-0004-0000-006c000030a1"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-0025-0000-01660000318a"), 9100.0m, "Bonus", new Guid("00000064-0000-0004-0000-006c000030a1"), "Quarterly performance bonus", "2025-01" },
                    { new Guid("0000012c-0000-0026-0000-01600000318b"), -2275.00m, "Withholding Tax", new Guid("00000064-0000-0004-0000-006c000030a1"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-0027-0000-01620000318c"), 45500m, "Base Salary", new Guid("00000064-0000-0004-0000-006c000030a1"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-0028-0000-017c0000318d"), 9100.0m, "Bonus", new Guid("00000064-0000-0004-0000-006c000030a1"), "Quarterly performance bonus", "2025-02" },
                    { new Guid("0000012c-0000-0029-0000-017e0000318e"), -2275.00m, "Withholding Tax", new Guid("00000064-0000-0004-0000-006c000030a1"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-002a-0000-01780000318f"), 45500m, "Base Salary", new Guid("00000064-0000-0004-0000-006c000030a1"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-002b-0000-017a00003190"), 9100.0m, "Bonus", new Guid("00000064-0000-0004-0000-006c000030a1"), "Quarterly performance bonus", "2025-03" },
                    { new Guid("0000012c-0000-002c-0000-017400003191"), -2275.00m, "Withholding Tax", new Guid("00000064-0000-0004-0000-006c000030a1"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-002d-0000-017600003192"), 48000m, "Base Salary", new Guid("00000064-0000-0005-0000-006e000030a2"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-002e-0000-017000003193"), -2400.00m, "Withholding Tax", new Guid("00000064-0000-0005-0000-006e000030a2"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-002f-0000-017200003194"), 1500m, "Internet Allowance", new Guid("00000064-0000-0005-0000-006e000030a2"), "Monthly allowance", "2024-12" },
                    { new Guid("0000012c-0000-0030-0000-014c00003195"), 48000m, "Base Salary", new Guid("00000064-0000-0005-0000-006e000030a2"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-0031-0000-014e00003196"), -2400.00m, "Withholding Tax", new Guid("00000064-0000-0005-0000-006e000030a2"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-0032-0000-014800003197"), 1500m, "Internet Allowance", new Guid("00000064-0000-0005-0000-006e000030a2"), "Monthly allowance", "2025-01" },
                    { new Guid("0000012c-0000-0033-0000-014a00003198"), 48000m, "Base Salary", new Guid("00000064-0000-0005-0000-006e000030a2"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-0034-0000-014400003199"), -2400.00m, "Withholding Tax", new Guid("00000064-0000-0005-0000-006e000030a2"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-0035-0000-01460000319a"), 1500m, "Internet Allowance", new Guid("00000064-0000-0005-0000-006e000030a2"), "Monthly allowance", "2025-02" },
                    { new Guid("0000012c-0000-0036-0000-01400000319b"), 48000m, "Base Salary", new Guid("00000064-0000-0005-0000-006e000030a2"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-0037-0000-01420000319c"), -2400.00m, "Withholding Tax", new Guid("00000064-0000-0005-0000-006e000030a2"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-0038-0000-015c0000319d"), 1500m, "Internet Allowance", new Guid("00000064-0000-0005-0000-006e000030a2"), "Monthly allowance", "2025-03" },
                    { new Guid("0000012c-0000-0039-0000-015e0000319e"), 50500m, "Base Salary", new Guid("00000064-0000-0006-0000-0068000030a3"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-003a-0000-01580000319f"), -2525.00m, "Withholding Tax", new Guid("00000064-0000-0006-0000-0068000030a3"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-003b-0000-015a000031a0"), 50500m, "Base Salary", new Guid("00000064-0000-0006-0000-0068000030a3"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-003c-0000-0154000031a1"), -2525.00m, "Withholding Tax", new Guid("00000064-0000-0006-0000-0068000030a3"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-003d-0000-0156000031a2"), 50500m, "Base Salary", new Guid("00000064-0000-0006-0000-0068000030a3"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-003e-0000-0150000031a3"), -2525.00m, "Withholding Tax", new Guid("00000064-0000-0006-0000-0068000030a3"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-003f-0000-0152000031a4"), 50500m, "Base Salary", new Guid("00000064-0000-0006-0000-0068000030a3"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-0040-0000-01ac000031a5"), -2525.00m, "Withholding Tax", new Guid("00000064-0000-0006-0000-0068000030a3"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-0041-0000-01ae000031a6"), 53000m, "Base Salary", new Guid("00000064-0000-0007-0000-006a000030a4"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-0042-0000-01a8000031a7"), 10600.0m, "Bonus", new Guid("00000064-0000-0007-0000-006a000030a4"), "Quarterly performance bonus", "2024-12" },
                    { new Guid("0000012c-0000-0043-0000-01aa000031a8"), -2650.00m, "Withholding Tax", new Guid("00000064-0000-0007-0000-006a000030a4"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-0044-0000-01a4000031a9"), 53000m, "Base Salary", new Guid("00000064-0000-0007-0000-006a000030a4"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-0045-0000-01a6000031aa"), 10600.0m, "Bonus", new Guid("00000064-0000-0007-0000-006a000030a4"), "Quarterly performance bonus", "2025-01" },
                    { new Guid("0000012c-0000-0046-0000-01a0000031ab"), -2650.00m, "Withholding Tax", new Guid("00000064-0000-0007-0000-006a000030a4"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-0047-0000-01a2000031ac"), 53000m, "Base Salary", new Guid("00000064-0000-0007-0000-006a000030a4"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-0048-0000-01bc000031ad"), 10600.0m, "Bonus", new Guid("00000064-0000-0007-0000-006a000030a4"), "Quarterly performance bonus", "2025-02" },
                    { new Guid("0000012c-0000-0049-0000-01be000031ae"), -2650.00m, "Withholding Tax", new Guid("00000064-0000-0007-0000-006a000030a4"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-004a-0000-01b8000031af"), 53000m, "Base Salary", new Guid("00000064-0000-0007-0000-006a000030a4"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-004b-0000-01ba000031b0"), 10600.0m, "Bonus", new Guid("00000064-0000-0007-0000-006a000030a4"), "Quarterly performance bonus", "2025-03" },
                    { new Guid("0000012c-0000-004c-0000-01b4000031b1"), -2650.00m, "Withholding Tax", new Guid("00000064-0000-0007-0000-006a000030a4"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-004d-0000-01b6000031b2"), 55500m, "Base Salary", new Guid("00000064-0000-0008-0000-0074000030a5"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-004e-0000-01b0000031b3"), -2775.00m, "Withholding Tax", new Guid("00000064-0000-0008-0000-0074000030a5"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-004f-0000-01b2000031b4"), 55500m, "Base Salary", new Guid("00000064-0000-0008-0000-0074000030a5"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-0050-0000-018c000031b5"), -2775.00m, "Withholding Tax", new Guid("00000064-0000-0008-0000-0074000030a5"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-0051-0000-018e000031b6"), 55500m, "Base Salary", new Guid("00000064-0000-0008-0000-0074000030a5"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-0052-0000-0188000031b7"), -2775.00m, "Withholding Tax", new Guid("00000064-0000-0008-0000-0074000030a5"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-0053-0000-018a000031b8"), 55500m, "Base Salary", new Guid("00000064-0000-0008-0000-0074000030a5"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-0054-0000-0184000031b9"), -2775.00m, "Withholding Tax", new Guid("00000064-0000-0008-0000-0074000030a5"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-0055-0000-0186000031ba"), 58000m, "Base Salary", new Guid("00000064-0000-0009-0000-0076000030a6"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-0056-0000-0180000031bb"), -2900.00m, "Withholding Tax", new Guid("00000064-0000-0009-0000-0076000030a6"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-0057-0000-0182000031bc"), 1500m, "Internet Allowance", new Guid("00000064-0000-0009-0000-0076000030a6"), "Monthly allowance", "2024-12" },
                    { new Guid("0000012c-0000-0058-0000-019c000031bd"), 58000m, "Base Salary", new Guid("00000064-0000-0009-0000-0076000030a6"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-0059-0000-019e000031be"), -2900.00m, "Withholding Tax", new Guid("00000064-0000-0009-0000-0076000030a6"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-005a-0000-0198000031bf"), 1500m, "Internet Allowance", new Guid("00000064-0000-0009-0000-0076000030a6"), "Monthly allowance", "2025-01" },
                    { new Guid("0000012c-0000-005b-0000-019a000031c0"), 58000m, "Base Salary", new Guid("00000064-0000-0009-0000-0076000030a6"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-005c-0000-0194000031c1"), -2900.00m, "Withholding Tax", new Guid("00000064-0000-0009-0000-0076000030a6"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-005d-0000-0196000031c2"), 1500m, "Internet Allowance", new Guid("00000064-0000-0009-0000-0076000030a6"), "Monthly allowance", "2025-02" },
                    { new Guid("0000012c-0000-005e-0000-0190000031c3"), 58000m, "Base Salary", new Guid("00000064-0000-0009-0000-0076000030a6"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-005f-0000-0192000031c4"), -2900.00m, "Withholding Tax", new Guid("00000064-0000-0009-0000-0076000030a6"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-0060-0000-01ec000031c5"), 1500m, "Internet Allowance", new Guid("00000064-0000-0009-0000-0076000030a6"), "Monthly allowance", "2025-03" },
                    { new Guid("0000012c-0000-0061-0000-01ee000031c6"), 60500m, "Base Salary", new Guid("00000064-0000-000a-0000-0070000030a7"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-0062-0000-01e8000031c7"), 12100.0m, "Bonus", new Guid("00000064-0000-000a-0000-0070000030a7"), "Quarterly performance bonus", "2024-12" },
                    { new Guid("0000012c-0000-0063-0000-01ea000031c8"), -3025.00m, "Withholding Tax", new Guid("00000064-0000-000a-0000-0070000030a7"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-0064-0000-01e4000031c9"), 60500m, "Base Salary", new Guid("00000064-0000-000a-0000-0070000030a7"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-0065-0000-01e6000031ca"), 12100.0m, "Bonus", new Guid("00000064-0000-000a-0000-0070000030a7"), "Quarterly performance bonus", "2025-01" },
                    { new Guid("0000012c-0000-0066-0000-01e0000031cb"), -3025.00m, "Withholding Tax", new Guid("00000064-0000-000a-0000-0070000030a7"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-0067-0000-01e2000031cc"), 60500m, "Base Salary", new Guid("00000064-0000-000a-0000-0070000030a7"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-0068-0000-01fc000031cd"), 12100.0m, "Bonus", new Guid("00000064-0000-000a-0000-0070000030a7"), "Quarterly performance bonus", "2025-02" },
                    { new Guid("0000012c-0000-0069-0000-01fe000031ce"), -3025.00m, "Withholding Tax", new Guid("00000064-0000-000a-0000-0070000030a7"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-006a-0000-01f8000031cf"), 60500m, "Base Salary", new Guid("00000064-0000-000a-0000-0070000030a7"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-006b-0000-01fa000031d0"), 12100.0m, "Bonus", new Guid("00000064-0000-000a-0000-0070000030a7"), "Quarterly performance bonus", "2025-03" },
                    { new Guid("0000012c-0000-006c-0000-01f4000031d1"), -3025.00m, "Withholding Tax", new Guid("00000064-0000-000a-0000-0070000030a7"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-006d-0000-01f6000031d2"), 63000m, "Base Salary", new Guid("00000064-0000-000b-0000-0072000030a8"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-006e-0000-01f0000031d3"), -3150.00m, "Withholding Tax", new Guid("00000064-0000-000b-0000-0072000030a8"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-006f-0000-01f2000031d4"), 63000m, "Base Salary", new Guid("00000064-0000-000b-0000-0072000030a8"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-0070-0000-01cc000031d5"), -3150.00m, "Withholding Tax", new Guid("00000064-0000-000b-0000-0072000030a8"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-0071-0000-01ce000031d6"), 63000m, "Base Salary", new Guid("00000064-0000-000b-0000-0072000030a8"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-0072-0000-01c8000031d7"), -3150.00m, "Withholding Tax", new Guid("00000064-0000-000b-0000-0072000030a8"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-0073-0000-01ca000031d8"), 63000m, "Base Salary", new Guid("00000064-0000-000b-0000-0072000030a8"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-0074-0000-01c4000031d9"), -3150.00m, "Withholding Tax", new Guid("00000064-0000-000b-0000-0072000030a8"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-0075-0000-01c6000031da"), 65500m, "Base Salary", new Guid("00000064-0000-000c-0000-007c000030a9"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-0076-0000-01c0000031db"), -3275.00m, "Withholding Tax", new Guid("00000064-0000-000c-0000-007c000030a9"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-0077-0000-01c2000031dc"), 65500m, "Base Salary", new Guid("00000064-0000-000c-0000-007c000030a9"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-0078-0000-01dc000031dd"), -3275.00m, "Withholding Tax", new Guid("00000064-0000-000c-0000-007c000030a9"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-0079-0000-01de000031de"), 65500m, "Base Salary", new Guid("00000064-0000-000c-0000-007c000030a9"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-007a-0000-01d8000031df"), -3275.00m, "Withholding Tax", new Guid("00000064-0000-000c-0000-007c000030a9"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-007b-0000-01da000031e0"), 65500m, "Base Salary", new Guid("00000064-0000-000c-0000-007c000030a9"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-007c-0000-01d4000031e1"), -3275.00m, "Withholding Tax", new Guid("00000064-0000-000c-0000-007c000030a9"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-007d-0000-01d6000031e2"), 38000m, "Base Salary", new Guid("00000064-0000-000d-0000-007e000030aa"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-007e-0000-01d0000031e3"), 7600.0m, "Bonus", new Guid("00000064-0000-000d-0000-007e000030aa"), "Quarterly performance bonus", "2024-12" },
                    { new Guid("0000012c-0000-007f-0000-01d2000031e4"), -1900.00m, "Withholding Tax", new Guid("00000064-0000-000d-0000-007e000030aa"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-0080-0000-002c000031e5"), 1500m, "Internet Allowance", new Guid("00000064-0000-000d-0000-007e000030aa"), "Monthly allowance", "2024-12" },
                    { new Guid("0000012c-0000-0081-0000-002e000031e6"), 38000m, "Base Salary", new Guid("00000064-0000-000d-0000-007e000030aa"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-0082-0000-0028000031e7"), 7600.0m, "Bonus", new Guid("00000064-0000-000d-0000-007e000030aa"), "Quarterly performance bonus", "2025-01" },
                    { new Guid("0000012c-0000-0083-0000-002a000031e8"), -1900.00m, "Withholding Tax", new Guid("00000064-0000-000d-0000-007e000030aa"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-0084-0000-0024000031e9"), 1500m, "Internet Allowance", new Guid("00000064-0000-000d-0000-007e000030aa"), "Monthly allowance", "2025-01" },
                    { new Guid("0000012c-0000-0085-0000-0026000031ea"), 38000m, "Base Salary", new Guid("00000064-0000-000d-0000-007e000030aa"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-0086-0000-0020000031eb"), 7600.0m, "Bonus", new Guid("00000064-0000-000d-0000-007e000030aa"), "Quarterly performance bonus", "2025-02" },
                    { new Guid("0000012c-0000-0087-0000-0022000031ec"), -1900.00m, "Withholding Tax", new Guid("00000064-0000-000d-0000-007e000030aa"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-0088-0000-003c000031ed"), 1500m, "Internet Allowance", new Guid("00000064-0000-000d-0000-007e000030aa"), "Monthly allowance", "2025-02" },
                    { new Guid("0000012c-0000-0089-0000-003e000031ee"), 38000m, "Base Salary", new Guid("00000064-0000-000d-0000-007e000030aa"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-008a-0000-0038000031ef"), 7600.0m, "Bonus", new Guid("00000064-0000-000d-0000-007e000030aa"), "Quarterly performance bonus", "2025-03" },
                    { new Guid("0000012c-0000-008b-0000-003a000031f0"), -1900.00m, "Withholding Tax", new Guid("00000064-0000-000d-0000-007e000030aa"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-008c-0000-0034000031f1"), 1500m, "Internet Allowance", new Guid("00000064-0000-000d-0000-007e000030aa"), "Monthly allowance", "2025-03" },
                    { new Guid("0000012c-0000-008d-0000-0036000031f2"), 40500m, "Base Salary", new Guid("00000064-0000-000e-0000-0078000030ab"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-008e-0000-0030000031f3"), -2025.00m, "Withholding Tax", new Guid("00000064-0000-000e-0000-0078000030ab"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-008f-0000-0032000031f4"), 40500m, "Base Salary", new Guid("00000064-0000-000e-0000-0078000030ab"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-0090-0000-000c000031f5"), -2025.00m, "Withholding Tax", new Guid("00000064-0000-000e-0000-0078000030ab"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-0091-0000-000e000031f6"), 40500m, "Base Salary", new Guid("00000064-0000-000e-0000-0078000030ab"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-0092-0000-0008000031f7"), -2025.00m, "Withholding Tax", new Guid("00000064-0000-000e-0000-0078000030ab"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-0093-0000-000a000031f8"), 40500m, "Base Salary", new Guid("00000064-0000-000e-0000-0078000030ab"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-0094-0000-0004000031f9"), -2025.00m, "Withholding Tax", new Guid("00000064-0000-000e-0000-0078000030ab"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-0095-0000-0006000031fa"), 43000m, "Base Salary", new Guid("00000064-0000-000f-0000-007a000030ac"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-0096-0000-0000000031fb"), -2150.00m, "Withholding Tax", new Guid("00000064-0000-000f-0000-007a000030ac"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-0097-0000-0002000031fc"), 43000m, "Base Salary", new Guid("00000064-0000-000f-0000-007a000030ac"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-0098-0000-001c000031fd"), -2150.00m, "Withholding Tax", new Guid("00000064-0000-000f-0000-007a000030ac"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-0099-0000-001e000031fe"), 43000m, "Base Salary", new Guid("00000064-0000-000f-0000-007a000030ac"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-009a-0000-0018000031ff"), -2150.00m, "Withholding Tax", new Guid("00000064-0000-000f-0000-007a000030ac"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-009b-0000-001a00003200"), 43000m, "Base Salary", new Guid("00000064-0000-000f-0000-007a000030ac"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-009c-0000-001400003201"), -2150.00m, "Withholding Tax", new Guid("00000064-0000-000f-0000-007a000030ac"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-009d-0000-001600003202"), 45500m, "Base Salary", new Guid("00000064-0000-0010-0000-0044000030ad"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-009e-0000-001000003203"), 9100.0m, "Bonus", new Guid("00000064-0000-0010-0000-0044000030ad"), "Quarterly performance bonus", "2024-12" },
                    { new Guid("0000012c-0000-009f-0000-001200003204"), -2275.00m, "Withholding Tax", new Guid("00000064-0000-0010-0000-0044000030ad"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-00a0-0000-006c00003205"), 45500m, "Base Salary", new Guid("00000064-0000-0010-0000-0044000030ad"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-00a1-0000-006e00003206"), 9100.0m, "Bonus", new Guid("00000064-0000-0010-0000-0044000030ad"), "Quarterly performance bonus", "2025-01" },
                    { new Guid("0000012c-0000-00a2-0000-006800003207"), -2275.00m, "Withholding Tax", new Guid("00000064-0000-0010-0000-0044000030ad"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-00a3-0000-006a00003208"), 45500m, "Base Salary", new Guid("00000064-0000-0010-0000-0044000030ad"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-00a4-0000-006400003209"), 9100.0m, "Bonus", new Guid("00000064-0000-0010-0000-0044000030ad"), "Quarterly performance bonus", "2025-02" },
                    { new Guid("0000012c-0000-00a5-0000-00660000320a"), -2275.00m, "Withholding Tax", new Guid("00000064-0000-0010-0000-0044000030ad"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-00a6-0000-00600000320b"), 45500m, "Base Salary", new Guid("00000064-0000-0010-0000-0044000030ad"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-00a7-0000-00620000320c"), 9100.0m, "Bonus", new Guid("00000064-0000-0010-0000-0044000030ad"), "Quarterly performance bonus", "2025-03" },
                    { new Guid("0000012c-0000-00a8-0000-007c0000320d"), -2275.00m, "Withholding Tax", new Guid("00000064-0000-0010-0000-0044000030ad"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-00a9-0000-007e0000320e"), 48000m, "Base Salary", new Guid("00000064-0000-0011-0000-0046000030ae"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-00aa-0000-00780000320f"), -2400.00m, "Withholding Tax", new Guid("00000064-0000-0011-0000-0046000030ae"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-00ab-0000-007a00003210"), 1500m, "Internet Allowance", new Guid("00000064-0000-0011-0000-0046000030ae"), "Monthly allowance", "2024-12" },
                    { new Guid("0000012c-0000-00ac-0000-007400003211"), 48000m, "Base Salary", new Guid("00000064-0000-0011-0000-0046000030ae"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-00ad-0000-007600003212"), -2400.00m, "Withholding Tax", new Guid("00000064-0000-0011-0000-0046000030ae"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-00ae-0000-007000003213"), 1500m, "Internet Allowance", new Guid("00000064-0000-0011-0000-0046000030ae"), "Monthly allowance", "2025-01" },
                    { new Guid("0000012c-0000-00af-0000-007200003214"), 48000m, "Base Salary", new Guid("00000064-0000-0011-0000-0046000030ae"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-00b0-0000-004c00003215"), -2400.00m, "Withholding Tax", new Guid("00000064-0000-0011-0000-0046000030ae"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-00b1-0000-004e00003216"), 1500m, "Internet Allowance", new Guid("00000064-0000-0011-0000-0046000030ae"), "Monthly allowance", "2025-02" },
                    { new Guid("0000012c-0000-00b2-0000-004800003217"), 48000m, "Base Salary", new Guid("00000064-0000-0011-0000-0046000030ae"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-00b3-0000-004a00003218"), -2400.00m, "Withholding Tax", new Guid("00000064-0000-0011-0000-0046000030ae"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-00b4-0000-004400003219"), 1500m, "Internet Allowance", new Guid("00000064-0000-0011-0000-0046000030ae"), "Monthly allowance", "2025-03" },
                    { new Guid("0000012c-0000-00b5-0000-00460000321a"), 50500m, "Base Salary", new Guid("00000064-0000-0012-0000-0040000030af"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-00b6-0000-00400000321b"), -2525.00m, "Withholding Tax", new Guid("00000064-0000-0012-0000-0040000030af"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-00b7-0000-00420000321c"), 50500m, "Base Salary", new Guid("00000064-0000-0012-0000-0040000030af"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-00b8-0000-005c0000321d"), -2525.00m, "Withholding Tax", new Guid("00000064-0000-0012-0000-0040000030af"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-00b9-0000-005e0000321e"), 50500m, "Base Salary", new Guid("00000064-0000-0012-0000-0040000030af"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-00ba-0000-00580000321f"), -2525.00m, "Withholding Tax", new Guid("00000064-0000-0012-0000-0040000030af"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-00bb-0000-005a00003220"), 50500m, "Base Salary", new Guid("00000064-0000-0012-0000-0040000030af"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-00bc-0000-005400003221"), -2525.00m, "Withholding Tax", new Guid("00000064-0000-0012-0000-0040000030af"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-00bd-0000-005600003222"), 53000m, "Base Salary", new Guid("00000064-0000-0013-0000-0042000030b0"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-00be-0000-005000003223"), 10600.0m, "Bonus", new Guid("00000064-0000-0013-0000-0042000030b0"), "Quarterly performance bonus", "2024-12" },
                    { new Guid("0000012c-0000-00bf-0000-005200003224"), -2650.00m, "Withholding Tax", new Guid("00000064-0000-0013-0000-0042000030b0"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-00c0-0000-00ac00003225"), 53000m, "Base Salary", new Guid("00000064-0000-0013-0000-0042000030b0"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-00c1-0000-00ae00003226"), 10600.0m, "Bonus", new Guid("00000064-0000-0013-0000-0042000030b0"), "Quarterly performance bonus", "2025-01" },
                    { new Guid("0000012c-0000-00c2-0000-00a800003227"), -2650.00m, "Withholding Tax", new Guid("00000064-0000-0013-0000-0042000030b0"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-00c3-0000-00aa00003228"), 53000m, "Base Salary", new Guid("00000064-0000-0013-0000-0042000030b0"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-00c4-0000-00a400003229"), 10600.0m, "Bonus", new Guid("00000064-0000-0013-0000-0042000030b0"), "Quarterly performance bonus", "2025-02" },
                    { new Guid("0000012c-0000-00c5-0000-00a60000322a"), -2650.00m, "Withholding Tax", new Guid("00000064-0000-0013-0000-0042000030b0"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-00c6-0000-00a00000322b"), 53000m, "Base Salary", new Guid("00000064-0000-0013-0000-0042000030b0"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-00c7-0000-00a20000322c"), 10600.0m, "Bonus", new Guid("00000064-0000-0013-0000-0042000030b0"), "Quarterly performance bonus", "2025-03" },
                    { new Guid("0000012c-0000-00c8-0000-00bc0000322d"), -2650.00m, "Withholding Tax", new Guid("00000064-0000-0013-0000-0042000030b0"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-00c9-0000-00be0000322e"), 55500m, "Base Salary", new Guid("00000064-0000-0014-0000-004c000030b1"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-00ca-0000-00b80000322f"), -2775.00m, "Withholding Tax", new Guid("00000064-0000-0014-0000-004c000030b1"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-00cb-0000-00ba00003230"), 55500m, "Base Salary", new Guid("00000064-0000-0014-0000-004c000030b1"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-00cc-0000-00b400003231"), -2775.00m, "Withholding Tax", new Guid("00000064-0000-0014-0000-004c000030b1"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-00cd-0000-00b600003232"), 55500m, "Base Salary", new Guid("00000064-0000-0014-0000-004c000030b1"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-00ce-0000-00b000003233"), -2775.00m, "Withholding Tax", new Guid("00000064-0000-0014-0000-004c000030b1"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-00cf-0000-00b200003234"), 55500m, "Base Salary", new Guid("00000064-0000-0014-0000-004c000030b1"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-00d0-0000-008c00003235"), -2775.00m, "Withholding Tax", new Guid("00000064-0000-0014-0000-004c000030b1"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-00d1-0000-008e00003236"), 58000m, "Base Salary", new Guid("00000064-0000-0015-0000-004e000030b2"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-00d2-0000-008800003237"), -2900.00m, "Withholding Tax", new Guid("00000064-0000-0015-0000-004e000030b2"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-00d3-0000-008a00003238"), 1500m, "Internet Allowance", new Guid("00000064-0000-0015-0000-004e000030b2"), "Monthly allowance", "2024-12" },
                    { new Guid("0000012c-0000-00d4-0000-008400003239"), 58000m, "Base Salary", new Guid("00000064-0000-0015-0000-004e000030b2"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-00d5-0000-00860000323a"), -2900.00m, "Withholding Tax", new Guid("00000064-0000-0015-0000-004e000030b2"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-00d6-0000-00800000323b"), 1500m, "Internet Allowance", new Guid("00000064-0000-0015-0000-004e000030b2"), "Monthly allowance", "2025-01" },
                    { new Guid("0000012c-0000-00d7-0000-00820000323c"), 58000m, "Base Salary", new Guid("00000064-0000-0015-0000-004e000030b2"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-00d8-0000-009c0000323d"), -2900.00m, "Withholding Tax", new Guid("00000064-0000-0015-0000-004e000030b2"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-00d9-0000-009e0000323e"), 1500m, "Internet Allowance", new Guid("00000064-0000-0015-0000-004e000030b2"), "Monthly allowance", "2025-02" },
                    { new Guid("0000012c-0000-00da-0000-00980000323f"), 58000m, "Base Salary", new Guid("00000064-0000-0015-0000-004e000030b2"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-00db-0000-009a00003240"), -2900.00m, "Withholding Tax", new Guid("00000064-0000-0015-0000-004e000030b2"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-00dc-0000-009400003241"), 1500m, "Internet Allowance", new Guid("00000064-0000-0015-0000-004e000030b2"), "Monthly allowance", "2025-03" },
                    { new Guid("0000012c-0000-00dd-0000-009600003242"), 60500m, "Base Salary", new Guid("00000064-0000-0016-0000-0048000030b3"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-00de-0000-009000003243"), 12100.0m, "Bonus", new Guid("00000064-0000-0016-0000-0048000030b3"), "Quarterly performance bonus", "2024-12" },
                    { new Guid("0000012c-0000-00df-0000-009200003244"), -3025.00m, "Withholding Tax", new Guid("00000064-0000-0016-0000-0048000030b3"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-00e0-0000-00ec00003245"), 60500m, "Base Salary", new Guid("00000064-0000-0016-0000-0048000030b3"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-00e1-0000-00ee00003246"), 12100.0m, "Bonus", new Guid("00000064-0000-0016-0000-0048000030b3"), "Quarterly performance bonus", "2025-01" },
                    { new Guid("0000012c-0000-00e2-0000-00e800003247"), -3025.00m, "Withholding Tax", new Guid("00000064-0000-0016-0000-0048000030b3"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-00e3-0000-00ea00003248"), 60500m, "Base Salary", new Guid("00000064-0000-0016-0000-0048000030b3"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-00e4-0000-00e400003249"), 12100.0m, "Bonus", new Guid("00000064-0000-0016-0000-0048000030b3"), "Quarterly performance bonus", "2025-02" },
                    { new Guid("0000012c-0000-00e5-0000-00e60000324a"), -3025.00m, "Withholding Tax", new Guid("00000064-0000-0016-0000-0048000030b3"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-00e6-0000-00e00000324b"), 60500m, "Base Salary", new Guid("00000064-0000-0016-0000-0048000030b3"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-00e7-0000-00e20000324c"), 12100.0m, "Bonus", new Guid("00000064-0000-0016-0000-0048000030b3"), "Quarterly performance bonus", "2025-03" },
                    { new Guid("0000012c-0000-00e8-0000-00fc0000324d"), -3025.00m, "Withholding Tax", new Guid("00000064-0000-0016-0000-0048000030b3"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-00e9-0000-00fe0000324e"), 63000m, "Base Salary", new Guid("00000064-0000-0017-0000-004a000030b4"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-00ea-0000-00f80000324f"), -3150.00m, "Withholding Tax", new Guid("00000064-0000-0017-0000-004a000030b4"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-00eb-0000-00fa00003250"), 63000m, "Base Salary", new Guid("00000064-0000-0017-0000-004a000030b4"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-00ec-0000-00f400003251"), -3150.00m, "Withholding Tax", new Guid("00000064-0000-0017-0000-004a000030b4"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-00ed-0000-00f600003252"), 63000m, "Base Salary", new Guid("00000064-0000-0017-0000-004a000030b4"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-00ee-0000-00f000003253"), -3150.00m, "Withholding Tax", new Guid("00000064-0000-0017-0000-004a000030b4"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-00ef-0000-00f200003254"), 63000m, "Base Salary", new Guid("00000064-0000-0017-0000-004a000030b4"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-00f0-0000-00cc00003255"), -3150.00m, "Withholding Tax", new Guid("00000064-0000-0017-0000-004a000030b4"), "WHT 5%", "2025-03" },
                    { new Guid("0000012c-0000-00f1-0000-00ce00003256"), 65500m, "Base Salary", new Guid("00000064-0000-0018-0000-0054000030b5"), "December 2024", "2024-12" },
                    { new Guid("0000012c-0000-00f2-0000-00c800003257"), -3275.00m, "Withholding Tax", new Guid("00000064-0000-0018-0000-0054000030b5"), "WHT 5%", "2024-12" },
                    { new Guid("0000012c-0000-00f3-0000-00ca00003258"), 65500m, "Base Salary", new Guid("00000064-0000-0018-0000-0054000030b5"), "January 2025", "2025-01" },
                    { new Guid("0000012c-0000-00f4-0000-00c400003259"), -3275.00m, "Withholding Tax", new Guid("00000064-0000-0018-0000-0054000030b5"), "WHT 5%", "2025-01" },
                    { new Guid("0000012c-0000-00f5-0000-00c60000325a"), 65500m, "Base Salary", new Guid("00000064-0000-0018-0000-0054000030b5"), "February 2025", "2025-02" },
                    { new Guid("0000012c-0000-00f6-0000-00c00000325b"), -3275.00m, "Withholding Tax", new Guid("00000064-0000-0018-0000-0054000030b5"), "WHT 5%", "2025-02" },
                    { new Guid("0000012c-0000-00f7-0000-00c20000325c"), 65500m, "Base Salary", new Guid("00000064-0000-0018-0000-0054000030b5"), "March 2025", "2025-03" },
                    { new Guid("0000012c-0000-00f8-0000-00dc0000325d"), -3275.00m, "Withholding Tax", new Guid("00000064-0000-0018-0000-0054000030b5"), "WHT 5%", "2025-03" }
                });

            migrationBuilder.InsertData(
                table: "PerformanceReviews",
                columns: new[] { "Id", "EmployeeId", "ManagerName", "ReviewCycle", "Score", "Status" },
                values: new object[,]
                {
                    { new Guid("000001f4-0000-0001-0000-01f60000322e"), new Guid("00000064-0000-0004-0000-006c000030a1"), "Karn Suphachai", "Mid-Year 2024", 3.2m, "Completed" },
                    { new Guid("000001f4-0000-0002-0000-01f00000322f"), new Guid("00000064-0000-0008-0000-0074000030a5"), "Sureeporn Wai", "Year-End 2024", 3.4m, "Completed" },
                    { new Guid("000001f4-0000-0003-0000-01f200003230"), new Guid("00000064-0000-000c-0000-007c000030a9"), "Anong Rittikrai", "Mid-Year 2025", 3.5m, "Pending Approval" },
                    { new Guid("000001f4-0000-0004-0000-01fc00003231"), new Guid("00000064-0000-0010-0000-0044000030ad"), "David Miller", "Mid-Year 2024", 3.7m, "Submitted" },
                    { new Guid("000001f4-0000-0005-0000-01fe00003232"), new Guid("00000064-0000-0014-0000-004c000030b1"), "Pakamon Dee", "Year-End 2024", 3.8m, "Completed" },
                    { new Guid("000001f4-0000-0006-0000-01f800003233"), new Guid("00000064-0000-0018-0000-0054000030b5"), "Karn Suphachai", "Mid-Year 2025", 4.0m, "Completed" },
                    { new Guid("000001f4-0000-0007-0000-01fa00003234"), new Guid("00000064-0000-001c-0000-005c000030b9"), "Sureeporn Wai", "Mid-Year 2024", 4.1m, "Pending Approval" },
                    { new Guid("000001f4-0000-0008-0000-01e400003235"), new Guid("00000064-0000-0020-0000-0024000030bd"), "Anong Rittikrai", "Year-End 2024", 4.3m, "Submitted" },
                    { new Guid("000001f4-0000-0009-0000-01e600003236"), new Guid("00000064-0000-0024-0000-002c000030c1"), "David Miller", "Mid-Year 2025", 4.4m, "Completed" },
                    { new Guid("000001f4-0000-000a-0000-01e000003237"), new Guid("00000064-0000-0028-0000-0034000030c5"), "Pakamon Dee", "Mid-Year 2024", 4.6m, "Completed" },
                    { new Guid("000001f4-0000-000b-0000-01e200003238"), new Guid("00000064-0000-002c-0000-003c000030c9"), "Karn Suphachai", "Year-End 2024", 4.7m, "Pending Approval" },
                    { new Guid("000001f4-0000-000c-0000-01ec00003239"), new Guid("00000064-0000-0030-0000-0004000030cd"), "Sureeporn Wai", "Mid-Year 2025", 4.8m, "Submitted" },
                    { new Guid("000001f4-0000-000d-0000-01ee0000323a"), new Guid("00000064-0000-0034-0000-000c000030d1"), "Anong Rittikrai", "Mid-Year 2024", 3.2m, "Completed" },
                    { new Guid("000001f4-0000-000e-0000-01e80000323b"), new Guid("00000064-0000-0038-0000-0014000030d5"), "David Miller", "Year-End 2024", 3.4m, "Completed" },
                    { new Guid("000001f4-0000-000f-0000-01ea0000323c"), new Guid("00000064-0000-003c-0000-001c000030d9"), "Pakamon Dee", "Mid-Year 2025", 3.5m, "Pending Approval" },
                    { new Guid("000001f4-0000-0010-0000-01d40000323d"), new Guid("00000064-0000-0040-0000-00e4000030dd"), "Karn Suphachai", "Mid-Year 2024", 3.7m, "Submitted" },
                    { new Guid("000001f4-0000-0011-0000-01d60000323e"), new Guid("00000064-0000-0044-0000-00ec000030e1"), "Sureeporn Wai", "Year-End 2024", 3.8m, "Completed" },
                    { new Guid("000001f4-0000-0012-0000-01d00000323f"), new Guid("00000064-0000-0048-0000-00f4000030e5"), "Anong Rittikrai", "Mid-Year 2025", 4.0m, "Completed" },
                    { new Guid("000001f4-0000-0013-0000-01d200003240"), new Guid("00000064-0000-004c-0000-00fc000030e9"), "David Miller", "Mid-Year 2024", 4.1m, "Pending Approval" },
                    { new Guid("000001f4-0000-0014-0000-01dc00003241"), new Guid("00000064-0000-0050-0000-00c4000030ed"), "Pakamon Dee", "Year-End 2024", 4.3m, "Submitted" },
                    { new Guid("000001f4-0000-0015-0000-01de00003242"), new Guid("00000064-0000-0054-0000-00cc000030f1"), "Karn Suphachai", "Mid-Year 2025", 4.4m, "Completed" },
                    { new Guid("000001f4-0000-0016-0000-01d800003243"), new Guid("00000064-0000-0058-0000-00d4000030f5"), "Sureeporn Wai", "Mid-Year 2024", 4.6m, "Completed" },
                    { new Guid("000001f4-0000-0017-0000-01da00003244"), new Guid("00000064-0000-005c-0000-00dc000030f9"), "Anong Rittikrai", "Year-End 2024", 4.7m, "Pending Approval" },
                    { new Guid("000001f4-0000-0018-0000-01c400003245"), new Guid("00000064-0000-0060-0000-00a4000030fd"), "David Miller", "Mid-Year 2025", 4.8m, "Submitted" },
                    { new Guid("000001f4-0000-0019-0000-01c600003246"), new Guid("00000064-0000-0064-0000-00ac00003101"), "Pakamon Dee", "Mid-Year 2024", 3.2m, "Completed" },
                    { new Guid("000001f4-0000-001a-0000-01c000003247"), new Guid("00000064-0000-0004-0000-006c000030a1"), "Karn Suphachai", "Year-End 2024", 3.4m, "Completed" },
                    { new Guid("000001f4-0000-001b-0000-01c200003248"), new Guid("00000064-0000-0008-0000-0074000030a5"), "Sureeporn Wai", "Mid-Year 2025", 3.5m, "Pending Approval" },
                    { new Guid("000001f4-0000-001c-0000-01cc00003249"), new Guid("00000064-0000-000c-0000-007c000030a9"), "Anong Rittikrai", "Mid-Year 2024", 3.7m, "Submitted" },
                    { new Guid("000001f4-0000-001d-0000-01ce0000324a"), new Guid("00000064-0000-0010-0000-0044000030ad"), "David Miller", "Year-End 2024", 3.8m, "Completed" },
                    { new Guid("000001f4-0000-001e-0000-01c80000324b"), new Guid("00000064-0000-0014-0000-004c000030b1"), "Pakamon Dee", "Mid-Year 2025", 4.0m, "Completed" },
                    { new Guid("000001f4-0000-001f-0000-01ca0000324c"), new Guid("00000064-0000-0018-0000-0054000030b5"), "Karn Suphachai", "Mid-Year 2024", 4.1m, "Pending Approval" },
                    { new Guid("000001f4-0000-0020-0000-01b40000324d"), new Guid("00000064-0000-001c-0000-005c000030b9"), "Sureeporn Wai", "Year-End 2024", 4.3m, "Submitted" },
                    { new Guid("000001f4-0000-0021-0000-01b60000324e"), new Guid("00000064-0000-0020-0000-0024000030bd"), "Anong Rittikrai", "Mid-Year 2025", 4.4m, "Completed" },
                    { new Guid("000001f4-0000-0022-0000-01b00000324f"), new Guid("00000064-0000-0024-0000-002c000030c1"), "David Miller", "Mid-Year 2024", 4.6m, "Completed" },
                    { new Guid("000001f4-0000-0023-0000-01b200003250"), new Guid("00000064-0000-0028-0000-0034000030c5"), "Pakamon Dee", "Year-End 2024", 4.7m, "Pending Approval" },
                    { new Guid("000001f4-0000-0024-0000-01bc00003251"), new Guid("00000064-0000-002c-0000-003c000030c9"), "Karn Suphachai", "Mid-Year 2025", 4.8m, "Submitted" },
                    { new Guid("000001f4-0000-0025-0000-01be00003252"), new Guid("00000064-0000-0030-0000-0004000030cd"), "Sureeporn Wai", "Mid-Year 2024", 3.2m, "Completed" },
                    { new Guid("000001f4-0000-0026-0000-01b800003253"), new Guid("00000064-0000-0034-0000-000c000030d1"), "Anong Rittikrai", "Year-End 2024", 3.4m, "Completed" },
                    { new Guid("000001f4-0000-0027-0000-01ba00003254"), new Guid("00000064-0000-0038-0000-0014000030d5"), "David Miller", "Mid-Year 2025", 3.5m, "Pending Approval" },
                    { new Guid("000001f4-0000-0028-0000-01a400003255"), new Guid("00000064-0000-003c-0000-001c000030d9"), "Pakamon Dee", "Mid-Year 2024", 3.7m, "Submitted" },
                    { new Guid("000001f4-0000-0029-0000-01a600003256"), new Guid("00000064-0000-0040-0000-00e4000030dd"), "Karn Suphachai", "Year-End 2024", 3.8m, "Completed" },
                    { new Guid("000001f4-0000-002a-0000-01a000003257"), new Guid("00000064-0000-0044-0000-00ec000030e1"), "Sureeporn Wai", "Mid-Year 2025", 4.0m, "Completed" },
                    { new Guid("000001f4-0000-002b-0000-01a200003258"), new Guid("00000064-0000-0048-0000-00f4000030e5"), "Anong Rittikrai", "Mid-Year 2024", 4.1m, "Pending Approval" },
                    { new Guid("000001f4-0000-002c-0000-01ac00003259"), new Guid("00000064-0000-004c-0000-00fc000030e9"), "David Miller", "Year-End 2024", 4.3m, "Submitted" },
                    { new Guid("000001f4-0000-002d-0000-01ae0000325a"), new Guid("00000064-0000-0050-0000-00c4000030ed"), "Pakamon Dee", "Mid-Year 2025", 4.4m, "Completed" },
                    { new Guid("000001f4-0000-002e-0000-01a80000325b"), new Guid("00000064-0000-0054-0000-00cc000030f1"), "Karn Suphachai", "Mid-Year 2024", 4.6m, "Completed" },
                    { new Guid("000001f4-0000-002f-0000-01aa0000325c"), new Guid("00000064-0000-0058-0000-00d4000030f5"), "Sureeporn Wai", "Year-End 2024", 4.7m, "Pending Approval" },
                    { new Guid("000001f4-0000-0030-0000-01940000325d"), new Guid("00000064-0000-005c-0000-00dc000030f9"), "Anong Rittikrai", "Mid-Year 2025", 4.8m, "Submitted" },
                    { new Guid("000001f4-0000-0031-0000-01960000325e"), new Guid("00000064-0000-0060-0000-00a4000030fd"), "David Miller", "Mid-Year 2024", 3.2m, "Completed" },
                    { new Guid("000001f4-0000-0032-0000-01900000325f"), new Guid("00000064-0000-0064-0000-00ac00003101"), "Pakamon Dee", "Year-End 2024", 3.4m, "Completed" },
                    { new Guid("000001f4-0000-0033-0000-019200003260"), new Guid("00000064-0000-0004-0000-006c000030a1"), "Karn Suphachai", "Mid-Year 2025", 3.5m, "Pending Approval" },
                    { new Guid("000001f4-0000-0034-0000-019c00003261"), new Guid("00000064-0000-0008-0000-0074000030a5"), "Sureeporn Wai", "Mid-Year 2024", 3.7m, "Submitted" },
                    { new Guid("000001f4-0000-0035-0000-019e00003262"), new Guid("00000064-0000-000c-0000-007c000030a9"), "Anong Rittikrai", "Year-End 2024", 3.8m, "Completed" },
                    { new Guid("000001f4-0000-0036-0000-019800003263"), new Guid("00000064-0000-0010-0000-0044000030ad"), "David Miller", "Mid-Year 2025", 4.0m, "Completed" },
                    { new Guid("000001f4-0000-0037-0000-019a00003264"), new Guid("00000064-0000-0014-0000-004c000030b1"), "Pakamon Dee", "Mid-Year 2024", 4.1m, "Pending Approval" },
                    { new Guid("000001f4-0000-0038-0000-018400003265"), new Guid("00000064-0000-0018-0000-0054000030b5"), "Karn Suphachai", "Year-End 2024", 4.3m, "Submitted" },
                    { new Guid("000001f4-0000-0039-0000-018600003266"), new Guid("00000064-0000-001c-0000-005c000030b9"), "Sureeporn Wai", "Mid-Year 2025", 4.4m, "Completed" },
                    { new Guid("000001f4-0000-003a-0000-018000003267"), new Guid("00000064-0000-0020-0000-0024000030bd"), "Anong Rittikrai", "Mid-Year 2024", 4.6m, "Completed" },
                    { new Guid("000001f4-0000-003b-0000-018200003268"), new Guid("00000064-0000-0024-0000-002c000030c1"), "David Miller", "Year-End 2024", 4.7m, "Pending Approval" },
                    { new Guid("000001f4-0000-003c-0000-018c00003269"), new Guid("00000064-0000-0028-0000-0034000030c5"), "Pakamon Dee", "Mid-Year 2025", 4.8m, "Submitted" },
                    { new Guid("000001f4-0000-003d-0000-018e0000326a"), new Guid("00000064-0000-002c-0000-003c000030c9"), "Karn Suphachai", "Mid-Year 2024", 3.2m, "Completed" },
                    { new Guid("000001f4-0000-003e-0000-01880000326b"), new Guid("00000064-0000-0030-0000-0004000030cd"), "Sureeporn Wai", "Year-End 2024", 3.4m, "Completed" },
                    { new Guid("000001f4-0000-003f-0000-018a0000326c"), new Guid("00000064-0000-0034-0000-000c000030d1"), "Anong Rittikrai", "Mid-Year 2025", 3.5m, "Pending Approval" },
                    { new Guid("000001f4-0000-0040-0000-01740000326d"), new Guid("00000064-0000-0038-0000-0014000030d5"), "David Miller", "Mid-Year 2024", 3.7m, "Submitted" },
                    { new Guid("000001f4-0000-0041-0000-01760000326e"), new Guid("00000064-0000-003c-0000-001c000030d9"), "Pakamon Dee", "Year-End 2024", 3.8m, "Completed" },
                    { new Guid("000001f4-0000-0042-0000-01700000326f"), new Guid("00000064-0000-0040-0000-00e4000030dd"), "Karn Suphachai", "Mid-Year 2025", 4.0m, "Completed" },
                    { new Guid("000001f4-0000-0043-0000-017200003270"), new Guid("00000064-0000-0044-0000-00ec000030e1"), "Sureeporn Wai", "Mid-Year 2024", 4.1m, "Pending Approval" },
                    { new Guid("000001f4-0000-0044-0000-017c00003271"), new Guid("00000064-0000-0048-0000-00f4000030e5"), "Anong Rittikrai", "Year-End 2024", 4.3m, "Submitted" },
                    { new Guid("000001f4-0000-0045-0000-017e00003272"), new Guid("00000064-0000-004c-0000-00fc000030e9"), "David Miller", "Mid-Year 2025", 4.4m, "Completed" },
                    { new Guid("000001f4-0000-0046-0000-017800003273"), new Guid("00000064-0000-0050-0000-00c4000030ed"), "Pakamon Dee", "Mid-Year 2024", 4.6m, "Completed" },
                    { new Guid("000001f4-0000-0047-0000-017a00003274"), new Guid("00000064-0000-0054-0000-00cc000030f1"), "Karn Suphachai", "Year-End 2024", 4.7m, "Pending Approval" },
                    { new Guid("000001f4-0000-0048-0000-016400003275"), new Guid("00000064-0000-0058-0000-00d4000030f5"), "Sureeporn Wai", "Mid-Year 2025", 4.8m, "Submitted" },
                    { new Guid("000001f4-0000-0049-0000-016600003276"), new Guid("00000064-0000-005c-0000-00dc000030f9"), "Anong Rittikrai", "Mid-Year 2024", 3.2m, "Completed" },
                    { new Guid("000001f4-0000-004a-0000-016000003277"), new Guid("00000064-0000-0060-0000-00a4000030fd"), "David Miller", "Year-End 2024", 3.4m, "Completed" },
                    { new Guid("000001f4-0000-004b-0000-016200003278"), new Guid("00000064-0000-0064-0000-00ac00003101"), "Pakamon Dee", "Mid-Year 2025", 3.5m, "Pending Approval" },
                    { new Guid("000001f4-0000-004c-0000-016c00003279"), new Guid("00000064-0000-0004-0000-006c000030a1"), "Karn Suphachai", "Mid-Year 2024", 3.7m, "Submitted" },
                    { new Guid("000001f4-0000-004d-0000-016e0000327a"), new Guid("00000064-0000-0008-0000-0074000030a5"), "Sureeporn Wai", "Year-End 2024", 3.8m, "Completed" },
                    { new Guid("000001f4-0000-004e-0000-01680000327b"), new Guid("00000064-0000-000c-0000-007c000030a9"), "Anong Rittikrai", "Mid-Year 2025", 4.0m, "Completed" },
                    { new Guid("000001f4-0000-004f-0000-016a0000327c"), new Guid("00000064-0000-0010-0000-0044000030ad"), "David Miller", "Mid-Year 2024", 4.1m, "Pending Approval" },
                    { new Guid("000001f4-0000-0050-0000-01540000327d"), new Guid("00000064-0000-0014-0000-004c000030b1"), "Pakamon Dee", "Year-End 2024", 4.3m, "Submitted" }
                });

            migrationBuilder.InsertData(
                table: "TrainingProgress",
                columns: new[] { "Id", "EmployeeId", "EndDate", "ProgramName", "StartDate", "Status" },
                values: new object[,]
                {
                    { new Guid("00000262-0000-0001-0000-02600000329c"), new Guid("00000064-0000-0006-0000-0068000030a3"), new DateTime(2024, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "OKRs Mastery", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { new Guid("00000262-0000-0002-0000-02660000329d"), new Guid("00000064-0000-0008-0000-0074000030a5"), null, "Leadership Essentials", new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-0003-0000-02640000329e"), new Guid("00000064-0000-000a-0000-0070000030a7"), null, "Cloud Fundamentals", new DateTime(2024, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-0004-0000-026a0000329f"), new Guid("00000064-0000-000c-0000-007c000030a9"), new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Empathy", new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { new Guid("00000262-0000-0005-0000-0268000032a0"), new Guid("00000064-0000-000e-0000-0078000030ab"), null, "Advanced Excel Automation", new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-0006-0000-026e000032a1"), new Guid("00000064-0000-0010-0000-0044000030ad"), null, "OKRs Mastery", new DateTime(2024, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-0007-0000-026c000032a2"), new Guid("00000064-0000-0012-0000-0040000030af"), new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leadership Essentials", new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { new Guid("00000262-0000-0008-0000-0272000032a3"), new Guid("00000064-0000-0014-0000-004c000030b1"), null, "Cloud Fundamentals", new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "On Hold" },
                    { new Guid("00000262-0000-0009-0000-0270000032a4"), new Guid("00000064-0000-0016-0000-0048000030b3"), null, "Customer Empathy", new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-000a-0000-0276000032a5"), new Guid("00000064-0000-0018-0000-0054000030b5"), new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Advanced Excel Automation", new DateTime(2024, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { new Guid("00000262-0000-000b-0000-0274000032a6"), new Guid("00000064-0000-001a-0000-0050000030b7"), null, "OKRs Mastery", new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-000c-0000-027a000032a7"), new Guid("00000064-0000-001c-0000-005c000030b9"), null, "Leadership Essentials", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-000d-0000-0278000032a8"), new Guid("00000064-0000-001e-0000-0058000030bb"), new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cloud Fundamentals", new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { new Guid("00000262-0000-000e-0000-027e000032a9"), new Guid("00000064-0000-0020-0000-0024000030bd"), null, "Customer Empathy", new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-000f-0000-027c000032aa"), new Guid("00000064-0000-0022-0000-0020000030bf"), null, "Advanced Excel Automation", new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "On Hold" },
                    { new Guid("00000262-0000-0010-0000-0242000032ab"), new Guid("00000064-0000-0024-0000-002c000030c1"), new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OKRs Mastery", new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { new Guid("00000262-0000-0011-0000-0240000032ac"), new Guid("00000064-0000-0026-0000-0028000030c3"), null, "Leadership Essentials", new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-0012-0000-0246000032ad"), new Guid("00000064-0000-0028-0000-0034000030c5"), null, "Cloud Fundamentals", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-0013-0000-0244000032ae"), new Guid("00000064-0000-002a-0000-0030000030c7"), new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Empathy", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { new Guid("00000262-0000-0014-0000-024a000032af"), new Guid("00000064-0000-002c-0000-003c000030c9"), null, "Advanced Excel Automation", new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-0015-0000-0248000032b0"), new Guid("00000064-0000-002e-0000-0038000030cb"), null, "OKRs Mastery", new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-0016-0000-024e000032b1"), new Guid("00000064-0000-0030-0000-0004000030cd"), new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leadership Essentials", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { new Guid("00000262-0000-0017-0000-024c000032b2"), new Guid("00000064-0000-0032-0000-0000000030cf"), null, "Cloud Fundamentals", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-0018-0000-0252000032b3"), new Guid("00000064-0000-0034-0000-000c000030d1"), null, "Customer Empathy", new DateTime(2024, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-0019-0000-0250000032b4"), new Guid("00000064-0000-0036-0000-0008000030d3"), new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Advanced Excel Automation", new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { new Guid("00000262-0000-001a-0000-0256000032b5"), new Guid("00000064-0000-0038-0000-0014000030d5"), null, "OKRs Mastery", new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-001b-0000-0254000032b6"), new Guid("00000064-0000-003a-0000-0010000030d7"), null, "Leadership Essentials", new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-001c-0000-025a000032b7"), new Guid("00000064-0000-003c-0000-001c000030d9"), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cloud Fundamentals", new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { new Guid("00000262-0000-001d-0000-0258000032b8"), new Guid("00000064-0000-003e-0000-0018000030db"), null, "Customer Empathy", new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "On Hold" },
                    { new Guid("00000262-0000-001e-0000-025e000032b9"), new Guid("00000064-0000-0040-0000-00e4000030dd"), null, "Advanced Excel Automation", new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-001f-0000-025c000032ba"), new Guid("00000064-0000-0042-0000-00e0000030df"), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "OKRs Mastery", new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { new Guid("00000262-0000-0020-0000-0222000032bb"), new Guid("00000064-0000-0044-0000-00ec000030e1"), null, "Leadership Essentials", new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-0021-0000-0220000032bc"), new Guid("00000064-0000-0046-0000-00e8000030e3"), null, "Cloud Fundamentals", new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-0022-0000-0226000032bd"), new Guid("00000064-0000-0048-0000-00f4000030e5"), new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Empathy", new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { new Guid("00000262-0000-0023-0000-0224000032be"), new Guid("00000064-0000-004a-0000-00f0000030e7"), null, "Advanced Excel Automation", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-0024-0000-022a000032bf"), new Guid("00000064-0000-004c-0000-00fc000030e9"), null, "OKRs Mastery", new DateTime(2025, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "On Hold" },
                    { new Guid("00000262-0000-0025-0000-0228000032c0"), new Guid("00000064-0000-004e-0000-00f8000030eb"), new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leadership Essentials", new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { new Guid("00000262-0000-0026-0000-022e000032c1"), new Guid("00000064-0000-0050-0000-00c4000030ed"), null, "Cloud Fundamentals", new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-0027-0000-022c000032c2"), new Guid("00000064-0000-0052-0000-00c0000030ef"), null, "Customer Empathy", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Progress" },
                    { new Guid("00000262-0000-0028-0000-0232000032c3"), new Guid("00000064-0000-0054-0000-00cc000030f1"), new DateTime(2025, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Advanced Excel Automation", new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeadcountRequests");

            migrationBuilder.DropTable(
                name: "SecurityAuditLogs");

            migrationBuilder.DropTable(
                name: "WorkforcePlanEntries");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0019-0000-0056000030b6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-001b-0000-0052000030b8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-001f-0000-005a000030bc"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0021-0000-0026000030be"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0023-0000-0022000030c0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0025-0000-002e000030c2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0029-0000-0036000030c6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-002b-0000-0032000030c8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-002d-0000-003e000030ca"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-002f-0000-003a000030cc"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0033-0000-0002000030d0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0035-0000-000e000030d2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0037-0000-000a000030d4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0039-0000-0016000030d6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-003d-0000-001e000030da"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-003f-0000-001a000030dc"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0041-0000-00e6000030de"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0043-0000-00e2000030e0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0047-0000-00ea000030e4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0049-0000-00f6000030e6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-004b-0000-00f2000030e8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-004d-0000-00fe000030ea"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0051-0000-00c6000030ee"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0053-0000-00c2000030f0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0055-0000-00ce000030f2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0056-0000-00c8000030f3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0057-0000-00ca000030f4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-005a-0000-00d0000030f7"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-005b-0000-00d2000030f8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-005d-0000-00de000030fa"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-005f-0000-00da000030fc"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0061-0000-00a6000030fe"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0062-0000-00a0000030ff"));

            migrationBuilder.DeleteData(
                table: "EngagementSurveyMetrics",
                keyColumn: "Id",
                keyValue: new Guid("000002c6-0000-0001-0000-02c400003300"));

            migrationBuilder.DeleteData(
                table: "EngagementSurveyMetrics",
                keyColumn: "Id",
                keyValue: new Guid("000002c6-0000-0002-0000-02c200003301"));

            migrationBuilder.DeleteData(
                table: "EngagementSurveyMetrics",
                keyColumn: "Id",
                keyValue: new Guid("000002c6-0000-0003-0000-02c000003302"));

            migrationBuilder.DeleteData(
                table: "EngagementSurveyMetrics",
                keyColumn: "Id",
                keyValue: new Guid("000002c6-0000-0004-0000-02ce00003303"));

            migrationBuilder.DeleteData(
                table: "EngagementSurveyMetrics",
                keyColumn: "Id",
                keyValue: new Guid("000002c6-0000-0005-0000-02cc00003304"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0001-0000-00ca00003102"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0002-0000-00cc00003103"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0003-0000-00ce00003104"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0004-0000-00c000003105"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0005-0000-00c200003106"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0006-0000-00c400003107"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0007-0000-00c600003108"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0008-0000-00d800003109"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0009-0000-00da0000310a"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-000a-0000-00dc0000310b"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-000b-0000-00de0000310c"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-000c-0000-00d00000310d"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-000d-0000-00d20000310e"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-000e-0000-00d40000310f"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-000f-0000-00d600003110"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0010-0000-00e800003111"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0011-0000-00ea00003112"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0012-0000-00ec00003113"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0013-0000-00ee00003114"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0014-0000-00e000003115"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0015-0000-00e200003116"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0016-0000-00e400003117"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0017-0000-00e600003118"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0018-0000-00f800003119"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0019-0000-00fa0000311a"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-001a-0000-00fc0000311b"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-001b-0000-00fe0000311c"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-001c-0000-00f00000311d"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-001d-0000-00f20000311e"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-001e-0000-00f40000311f"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-001f-0000-00f600003120"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0020-0000-008800003121"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0021-0000-008a00003122"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0022-0000-008c00003123"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0023-0000-008e00003124"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0024-0000-008000003125"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0025-0000-008200003126"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0026-0000-008400003127"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0027-0000-008600003128"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0028-0000-009800003129"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0029-0000-009a0000312a"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-002a-0000-009c0000312b"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-002b-0000-009e0000312c"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-002c-0000-00900000312d"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-002d-0000-00920000312e"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-002e-0000-00940000312f"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-002f-0000-009600003130"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0030-0000-00a800003131"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0031-0000-00aa00003132"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0032-0000-00ac00003133"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0033-0000-00ae00003134"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0034-0000-00a000003135"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0035-0000-00a200003136"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0036-0000-00a400003137"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0037-0000-00a600003138"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0038-0000-00b800003139"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0039-0000-00ba0000313a"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-003a-0000-00bc0000313b"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-003b-0000-00be0000313c"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-003c-0000-00b00000313d"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-003d-0000-00b20000313e"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-003e-0000-00b40000313f"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-003f-0000-00b600003140"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0040-0000-004800003141"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0041-0000-004a00003142"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0042-0000-004c00003143"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0043-0000-004e00003144"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0044-0000-004000003145"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0045-0000-004200003146"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0046-0000-004400003147"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0047-0000-004600003148"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0048-0000-005800003149"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0049-0000-005a0000314a"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-004a-0000-005c0000314b"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-004b-0000-005e0000314c"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-004c-0000-00500000314d"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-004d-0000-00520000314e"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-004e-0000-00540000314f"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-004f-0000-005600003150"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0050-0000-006800003151"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0051-0000-006a00003152"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0052-0000-006c00003153"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0053-0000-006e00003154"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0054-0000-006000003155"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0055-0000-006200003156"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0056-0000-006400003157"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0057-0000-006600003158"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0058-0000-007800003159"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0059-0000-007a0000315a"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-005a-0000-007c0000315b"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-005b-0000-007e0000315c"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-005c-0000-00700000315d"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-005d-0000-00720000315e"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-005e-0000-00740000315f"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-005f-0000-007600003160"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0060-0000-000800003161"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0061-0000-000a00003162"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0062-0000-000c00003163"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0063-0000-000e00003164"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0064-0000-000000003165"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0065-0000-000200003166"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0066-0000-000400003167"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0067-0000-000600003168"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0068-0000-001800003169"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0069-0000-001a0000316a"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-006a-0000-001c0000316b"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-006b-0000-001e0000316c"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-006c-0000-00100000316d"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-006d-0000-00120000316e"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-006e-0000-00140000316f"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-006f-0000-001600003170"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0070-0000-002800003171"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0071-0000-002a00003172"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0072-0000-002c00003173"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0073-0000-002e00003174"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0074-0000-002000003175"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0075-0000-002200003176"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0076-0000-002400003177"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0077-0000-002600003178"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0078-0000-003800003179"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0079-0000-003a0000317a"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-007a-0000-003c0000317b"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-007b-0000-003e0000317c"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-007c-0000-00300000317d"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-007d-0000-00320000317e"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-007e-0000-00340000317f"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-007f-0000-003600003180"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0080-0000-01c800003181"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0081-0000-01ca00003182"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0082-0000-01cc00003183"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0083-0000-01ce00003184"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0084-0000-01c000003185"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0085-0000-01c200003186"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0086-0000-01c400003187"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0087-0000-01c600003188"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0088-0000-01d800003189"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0089-0000-01da0000318a"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-008a-0000-01dc0000318b"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-008b-0000-01de0000318c"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-008c-0000-01d00000318d"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-008d-0000-01d20000318e"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-008e-0000-01d40000318f"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-008f-0000-01d600003190"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0090-0000-01e800003191"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0091-0000-01ea00003192"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0092-0000-01ec00003193"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0093-0000-01ee00003194"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0094-0000-01e000003195"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0095-0000-01e200003196"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0096-0000-01e400003197"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0097-0000-01e600003198"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0098-0000-01f800003199"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0099-0000-01fa0000319a"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-009a-0000-01fc0000319b"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-009b-0000-01fe0000319c"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-009c-0000-01f00000319d"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-009d-0000-01f20000319e"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-009e-0000-01f40000319f"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-009f-0000-01f6000031a0"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a0-0000-0188000031a1"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a1-0000-018a000031a2"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a2-0000-018c000031a3"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a3-0000-018e000031a4"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a4-0000-0180000031a5"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a5-0000-0182000031a6"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a6-0000-0184000031a7"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a7-0000-0186000031a8"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a8-0000-0198000031a9"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a9-0000-019a000031aa"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00aa-0000-019c000031ab"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00ab-0000-019e000031ac"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00ac-0000-0190000031ad"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00ad-0000-0192000031ae"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00ae-0000-0194000031af"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00af-0000-0196000031b0"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b0-0000-01a8000031b1"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b1-0000-01aa000031b2"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b2-0000-01ac000031b3"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b3-0000-01ae000031b4"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b4-0000-01a0000031b5"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b5-0000-01a2000031b6"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b6-0000-01a4000031b7"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b7-0000-01a6000031b8"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b8-0000-01b8000031b9"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b9-0000-01ba000031ba"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00ba-0000-01bc000031bb"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00bb-0000-01be000031bc"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00bc-0000-01b0000031bd"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00bd-0000-01b2000031be"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00be-0000-01b4000031bf"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00bf-0000-01b6000031c0"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c0-0000-0148000031c1"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c1-0000-014a000031c2"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c2-0000-014c000031c3"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c3-0000-014e000031c4"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c4-0000-0140000031c5"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c5-0000-0142000031c6"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c6-0000-0144000031c7"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c7-0000-0146000031c8"));

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c8-0000-0158000031c9"));

            migrationBuilder.DeleteData(
                table: "NotificationPreferences",
                keyColumn: "Id",
                keyValue: new Guid("00000398-0000-0001-0000-039a000033d2"));

            migrationBuilder.DeleteData(
                table: "NotificationPreferences",
                keyColumn: "Id",
                keyValue: new Guid("00000398-0000-0002-0000-039c000033d3"));

            migrationBuilder.DeleteData(
                table: "NotificationPreferences",
                keyColumn: "Id",
                keyValue: new Guid("00000398-0000-0003-0000-039e000033d4"));

            migrationBuilder.DeleteData(
                table: "NotificationPreferences",
                keyColumn: "Id",
                keyValue: new Guid("00000398-0000-0004-0000-0390000033d5"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0001-0000-0192000031ca"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0002-0000-0194000031cb"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0003-0000-0196000031cc"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0004-0000-0198000031cd"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0005-0000-019a000031ce"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0006-0000-019c000031cf"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0007-0000-019e000031d0"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0008-0000-0180000031d1"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0009-0000-0182000031d2"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-000a-0000-0184000031d3"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-000b-0000-0186000031d4"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-000c-0000-0188000031d5"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-000d-0000-018a000031d6"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-000e-0000-018c000031d7"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-000f-0000-018e000031d8"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0010-0000-01b0000031d9"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0011-0000-01b2000031da"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0012-0000-01b4000031db"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0013-0000-01b6000031dc"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0014-0000-01b8000031dd"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0015-0000-01ba000031de"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0016-0000-01bc000031df"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0017-0000-01be000031e0"));

            migrationBuilder.DeleteData(
                table: "PayrollSummaries",
                keyColumn: "Id",
                keyValue: new Guid("00000190-0000-0018-0000-01a0000031e1"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0001-0000-012e00003166"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0002-0000-012800003167"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0003-0000-012a00003168"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0004-0000-012400003169"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0005-0000-01260000316a"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0006-0000-01200000316b"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0007-0000-01220000316c"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0008-0000-013c0000316d"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0009-0000-013e0000316e"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-000a-0000-01380000316f"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-000b-0000-013a00003170"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-000c-0000-013400003171"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-000d-0000-013600003172"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-000e-0000-013000003173"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-000f-0000-013200003174"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0010-0000-010c00003175"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0011-0000-010e00003176"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0012-0000-010800003177"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0013-0000-010a00003178"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0014-0000-010400003179"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0015-0000-01060000317a"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0016-0000-01000000317b"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0017-0000-01020000317c"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0018-0000-011c0000317d"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0019-0000-011e0000317e"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-001a-0000-01180000317f"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-001b-0000-011a00003180"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-001c-0000-011400003181"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-001d-0000-011600003182"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-001e-0000-011000003183"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-001f-0000-011200003184"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0020-0000-016c00003185"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0021-0000-016e00003186"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0022-0000-016800003187"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0023-0000-016a00003188"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0024-0000-016400003189"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0025-0000-01660000318a"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0026-0000-01600000318b"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0027-0000-01620000318c"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0028-0000-017c0000318d"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0029-0000-017e0000318e"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-002a-0000-01780000318f"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-002b-0000-017a00003190"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-002c-0000-017400003191"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-002d-0000-017600003192"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-002e-0000-017000003193"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-002f-0000-017200003194"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0030-0000-014c00003195"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0031-0000-014e00003196"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0032-0000-014800003197"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0033-0000-014a00003198"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0034-0000-014400003199"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0035-0000-01460000319a"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0036-0000-01400000319b"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0037-0000-01420000319c"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0038-0000-015c0000319d"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0039-0000-015e0000319e"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-003a-0000-01580000319f"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-003b-0000-015a000031a0"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-003c-0000-0154000031a1"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-003d-0000-0156000031a2"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-003e-0000-0150000031a3"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-003f-0000-0152000031a4"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0040-0000-01ac000031a5"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0041-0000-01ae000031a6"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0042-0000-01a8000031a7"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0043-0000-01aa000031a8"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0044-0000-01a4000031a9"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0045-0000-01a6000031aa"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0046-0000-01a0000031ab"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0047-0000-01a2000031ac"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0048-0000-01bc000031ad"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0049-0000-01be000031ae"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-004a-0000-01b8000031af"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-004b-0000-01ba000031b0"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-004c-0000-01b4000031b1"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-004d-0000-01b6000031b2"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-004e-0000-01b0000031b3"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-004f-0000-01b2000031b4"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0050-0000-018c000031b5"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0051-0000-018e000031b6"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0052-0000-0188000031b7"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0053-0000-018a000031b8"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0054-0000-0184000031b9"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0055-0000-0186000031ba"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0056-0000-0180000031bb"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0057-0000-0182000031bc"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0058-0000-019c000031bd"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0059-0000-019e000031be"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-005a-0000-0198000031bf"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-005b-0000-019a000031c0"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-005c-0000-0194000031c1"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-005d-0000-0196000031c2"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-005e-0000-0190000031c3"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-005f-0000-0192000031c4"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0060-0000-01ec000031c5"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0061-0000-01ee000031c6"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0062-0000-01e8000031c7"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0063-0000-01ea000031c8"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0064-0000-01e4000031c9"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0065-0000-01e6000031ca"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0066-0000-01e0000031cb"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0067-0000-01e2000031cc"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0068-0000-01fc000031cd"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0069-0000-01fe000031ce"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-006a-0000-01f8000031cf"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-006b-0000-01fa000031d0"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-006c-0000-01f4000031d1"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-006d-0000-01f6000031d2"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-006e-0000-01f0000031d3"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-006f-0000-01f2000031d4"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0070-0000-01cc000031d5"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0071-0000-01ce000031d6"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0072-0000-01c8000031d7"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0073-0000-01ca000031d8"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0074-0000-01c4000031d9"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0075-0000-01c6000031da"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0076-0000-01c0000031db"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0077-0000-01c2000031dc"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0078-0000-01dc000031dd"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0079-0000-01de000031de"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-007a-0000-01d8000031df"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-007b-0000-01da000031e0"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-007c-0000-01d4000031e1"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-007d-0000-01d6000031e2"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-007e-0000-01d0000031e3"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-007f-0000-01d2000031e4"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0080-0000-002c000031e5"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0081-0000-002e000031e6"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0082-0000-0028000031e7"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0083-0000-002a000031e8"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0084-0000-0024000031e9"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0085-0000-0026000031ea"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0086-0000-0020000031eb"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0087-0000-0022000031ec"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0088-0000-003c000031ed"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0089-0000-003e000031ee"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-008a-0000-0038000031ef"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-008b-0000-003a000031f0"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-008c-0000-0034000031f1"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-008d-0000-0036000031f2"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-008e-0000-0030000031f3"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-008f-0000-0032000031f4"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0090-0000-000c000031f5"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0091-0000-000e000031f6"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0092-0000-0008000031f7"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0093-0000-000a000031f8"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0094-0000-0004000031f9"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0095-0000-0006000031fa"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0096-0000-0000000031fb"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0097-0000-0002000031fc"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0098-0000-001c000031fd"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-0099-0000-001e000031fe"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-009a-0000-0018000031ff"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-009b-0000-001a00003200"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-009c-0000-001400003201"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-009d-0000-001600003202"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-009e-0000-001000003203"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-009f-0000-001200003204"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00a0-0000-006c00003205"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00a1-0000-006e00003206"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00a2-0000-006800003207"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00a3-0000-006a00003208"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00a4-0000-006400003209"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00a5-0000-00660000320a"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00a6-0000-00600000320b"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00a7-0000-00620000320c"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00a8-0000-007c0000320d"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00a9-0000-007e0000320e"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00aa-0000-00780000320f"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00ab-0000-007a00003210"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00ac-0000-007400003211"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00ad-0000-007600003212"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00ae-0000-007000003213"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00af-0000-007200003214"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00b0-0000-004c00003215"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00b1-0000-004e00003216"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00b2-0000-004800003217"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00b3-0000-004a00003218"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00b4-0000-004400003219"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00b5-0000-00460000321a"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00b6-0000-00400000321b"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00b7-0000-00420000321c"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00b8-0000-005c0000321d"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00b9-0000-005e0000321e"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00ba-0000-00580000321f"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00bb-0000-005a00003220"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00bc-0000-005400003221"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00bd-0000-005600003222"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00be-0000-005000003223"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00bf-0000-005200003224"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00c0-0000-00ac00003225"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00c1-0000-00ae00003226"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00c2-0000-00a800003227"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00c3-0000-00aa00003228"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00c4-0000-00a400003229"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00c5-0000-00a60000322a"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00c6-0000-00a00000322b"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00c7-0000-00a20000322c"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00c8-0000-00bc0000322d"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00c9-0000-00be0000322e"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00ca-0000-00b80000322f"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00cb-0000-00ba00003230"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00cc-0000-00b400003231"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00cd-0000-00b600003232"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00ce-0000-00b000003233"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00cf-0000-00b200003234"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00d0-0000-008c00003235"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00d1-0000-008e00003236"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00d2-0000-008800003237"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00d3-0000-008a00003238"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00d4-0000-008400003239"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00d5-0000-00860000323a"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00d6-0000-00800000323b"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00d7-0000-00820000323c"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00d8-0000-009c0000323d"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00d9-0000-009e0000323e"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00da-0000-00980000323f"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00db-0000-009a00003240"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00dc-0000-009400003241"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00dd-0000-009600003242"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00de-0000-009000003243"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00df-0000-009200003244"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00e0-0000-00ec00003245"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00e1-0000-00ee00003246"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00e2-0000-00e800003247"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00e3-0000-00ea00003248"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00e4-0000-00e400003249"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00e5-0000-00e60000324a"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00e6-0000-00e00000324b"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00e7-0000-00e20000324c"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00e8-0000-00fc0000324d"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00e9-0000-00fe0000324e"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00ea-0000-00f80000324f"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00eb-0000-00fa00003250"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00ec-0000-00f400003251"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00ed-0000-00f600003252"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00ee-0000-00f000003253"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00ef-0000-00f200003254"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00f0-0000-00cc00003255"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00f1-0000-00ce00003256"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00f2-0000-00c800003257"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00f3-0000-00ca00003258"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00f4-0000-00c400003259"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00f5-0000-00c60000325a"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00f6-0000-00c00000325b"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00f7-0000-00c20000325c"));

            migrationBuilder.DeleteData(
                table: "PayslipComponents",
                keyColumn: "Id",
                keyValue: new Guid("0000012c-0000-00f8-0000-00dc0000325d"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0001-0000-01f60000322e"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0002-0000-01f00000322f"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0003-0000-01f200003230"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0004-0000-01fc00003231"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0005-0000-01fe00003232"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0006-0000-01f800003233"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0007-0000-01fa00003234"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0008-0000-01e400003235"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0009-0000-01e600003236"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-000a-0000-01e000003237"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-000b-0000-01e200003238"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-000c-0000-01ec00003239"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-000d-0000-01ee0000323a"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-000e-0000-01e80000323b"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-000f-0000-01ea0000323c"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0010-0000-01d40000323d"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0011-0000-01d60000323e"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0012-0000-01d00000323f"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0013-0000-01d200003240"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0014-0000-01dc00003241"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0015-0000-01de00003242"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0016-0000-01d800003243"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0017-0000-01da00003244"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0018-0000-01c400003245"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0019-0000-01c600003246"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-001a-0000-01c000003247"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-001b-0000-01c200003248"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-001c-0000-01cc00003249"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-001d-0000-01ce0000324a"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-001e-0000-01c80000324b"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-001f-0000-01ca0000324c"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0020-0000-01b40000324d"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0021-0000-01b60000324e"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0022-0000-01b00000324f"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0023-0000-01b200003250"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0024-0000-01bc00003251"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0025-0000-01be00003252"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0026-0000-01b800003253"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0027-0000-01ba00003254"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0028-0000-01a400003255"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0029-0000-01a600003256"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-002a-0000-01a000003257"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-002b-0000-01a200003258"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-002c-0000-01ac00003259"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-002d-0000-01ae0000325a"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-002e-0000-01a80000325b"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-002f-0000-01aa0000325c"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0030-0000-01940000325d"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0031-0000-01960000325e"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0032-0000-01900000325f"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0033-0000-019200003260"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0034-0000-019c00003261"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0035-0000-019e00003262"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0036-0000-019800003263"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0037-0000-019a00003264"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0038-0000-018400003265"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0039-0000-018600003266"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-003a-0000-018000003267"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-003b-0000-018200003268"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-003c-0000-018c00003269"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-003d-0000-018e0000326a"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-003e-0000-01880000326b"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-003f-0000-018a0000326c"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0040-0000-01740000326d"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0041-0000-01760000326e"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0042-0000-01700000326f"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0043-0000-017200003270"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0044-0000-017c00003271"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0045-0000-017e00003272"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0046-0000-017800003273"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0047-0000-017a00003274"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0048-0000-016400003275"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0049-0000-016600003276"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-004a-0000-016000003277"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-004b-0000-016200003278"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-004c-0000-016c00003279"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-004d-0000-016e0000327a"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-004e-0000-01680000327b"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-004f-0000-016a0000327c"));

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "Id",
                keyValue: new Guid("000001f4-0000-0050-0000-01540000327d"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0001-0000-03220000335a"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0002-0000-03240000335b"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0003-0000-03260000335c"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0004-0000-03280000335d"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0005-0000-032a0000335e"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0006-0000-032c0000335f"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0007-0000-032e00003360"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0008-0000-033000003361"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0009-0000-033200003362"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-000a-0000-033400003363"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-000b-0000-033600003364"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-000c-0000-033800003365"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-000d-0000-033a00003366"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-000e-0000-033c00003367"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-000f-0000-033e00003368"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0010-0000-030000003369"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0011-0000-03020000336a"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0012-0000-03040000336b"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0013-0000-03060000336c"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0014-0000-03080000336d"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0015-0000-030a0000336e"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0016-0000-030c0000336f"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0017-0000-030e00003370"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0018-0000-031000003371"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0019-0000-031200003372"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-001a-0000-031400003373"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-001b-0000-031600003374"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-001c-0000-031800003375"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-001d-0000-031a00003376"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-001e-0000-031c00003377"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-001f-0000-031e00003378"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0020-0000-036000003379"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0021-0000-03620000337a"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0022-0000-03640000337b"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0023-0000-03660000337c"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0024-0000-03680000337d"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0025-0000-036a0000337e"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0026-0000-036c0000337f"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0027-0000-036e00003380"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0028-0000-037000003381"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0029-0000-037200003382"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-002a-0000-037400003383"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-002b-0000-037600003384"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-002c-0000-037800003385"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-002d-0000-037a00003386"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-002e-0000-037c00003387"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-002f-0000-037e00003388"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0030-0000-034000003389"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0031-0000-03420000338a"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0032-0000-03440000338b"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0033-0000-03460000338c"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0034-0000-03480000338d"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0035-0000-034a0000338e"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0036-0000-034c0000338f"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0037-0000-034e00003390"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0038-0000-035000003391"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0039-0000-035200003392"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-003a-0000-035400003393"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-003b-0000-035600003394"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-003c-0000-035800003395"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-003d-0000-035a00003396"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-003e-0000-035c00003397"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-003f-0000-035e00003398"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0040-0000-03a000003399"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0041-0000-03a20000339a"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0042-0000-03a40000339b"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0043-0000-03a60000339c"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0044-0000-03a80000339d"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0045-0000-03aa0000339e"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0046-0000-03ac0000339f"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0047-0000-03ae000033a0"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0048-0000-03b0000033a1"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0049-0000-03b2000033a2"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-004a-0000-03b4000033a3"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-004b-0000-03b6000033a4"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-004c-0000-03b8000033a5"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-004d-0000-03ba000033a6"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-004e-0000-03bc000033a7"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-004f-0000-03be000033a8"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0050-0000-0380000033a9"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0051-0000-0382000033aa"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0052-0000-0384000033ab"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0053-0000-0386000033ac"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0054-0000-0388000033ad"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0055-0000-038a000033ae"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0056-0000-038c000033af"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0057-0000-038e000033b0"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0058-0000-0390000033b1"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0059-0000-0392000033b2"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-005a-0000-0394000033b3"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-005b-0000-0396000033b4"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-005c-0000-0398000033b5"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-005d-0000-039a000033b6"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-005e-0000-039c000033b7"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-005f-0000-039e000033b8"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0060-0000-03e0000033b9"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0061-0000-03e2000033ba"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0062-0000-03e4000033bb"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0063-0000-03e6000033bc"));

            migrationBuilder.DeleteData(
                table: "ReportEmployees",
                keyColumn: "Id",
                keyValue: new Guid("00000320-0000-0064-0000-03e8000033bd"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0001-0000-032800003364"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0002-0000-032e00003365"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0003-0000-032c00003366"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0004-0000-032200003367"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0005-0000-032000003368"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0006-0000-032600003369"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0007-0000-03240000336a"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0008-0000-033a0000336b"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0009-0000-03380000336c"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-000a-0000-033e0000336d"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-000b-0000-033c0000336e"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-000c-0000-03320000336f"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-000d-0000-033000003370"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-000e-0000-033600003371"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-000f-0000-033400003372"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0010-0000-030a00003373"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0011-0000-030800003374"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0012-0000-030e00003375"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0013-0000-030c00003376"));

            migrationBuilder.DeleteData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0014-0000-030200003377"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0001-0000-03360000336e"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0002-0000-03300000336f"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0003-0000-033200003370"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0004-0000-033c00003371"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0005-0000-033e00003372"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0006-0000-033800003373"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0007-0000-033a00003374"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0008-0000-032400003375"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0009-0000-032600003376"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-000a-0000-032000003377"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-000b-0000-032200003378"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-000c-0000-032c00003379"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-000d-0000-032e0000337a"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-000e-0000-03280000337b"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-000f-0000-032a0000337c"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0010-0000-03140000337d"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0011-0000-03160000337e"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0012-0000-03100000337f"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0013-0000-031200003380"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0014-0000-031c00003381"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0015-0000-031e00003382"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0016-0000-031800003383"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0017-0000-031a00003384"));

            migrationBuilder.DeleteData(
                table: "ReportPayroll",
                keyColumn: "Id",
                keyValue: new Guid("00000334-0000-0018-0000-030400003385"));

            migrationBuilder.DeleteData(
                table: "ReportPerformance",
                keyColumn: "Id",
                keyValue: new Guid("0000033e-0000-0001-0000-033c00003378"));

            migrationBuilder.DeleteData(
                table: "ReportPerformance",
                keyColumn: "Id",
                keyValue: new Guid("0000033e-0000-0002-0000-033a00003379"));

            migrationBuilder.DeleteData(
                table: "ReportPerformance",
                keyColumn: "Id",
                keyValue: new Guid("0000033e-0000-0003-0000-03380000337a"));

            migrationBuilder.DeleteData(
                table: "SecuritySettings",
                keyColumn: "Id",
                keyValue: new Guid("000003ac-0000-0001-0000-03ae000033e6"));

            migrationBuilder.DeleteData(
                table: "SecuritySettings",
                keyColumn: "Id",
                keyValue: new Guid("000003ac-0000-0002-0000-03a8000033e7"));

            migrationBuilder.DeleteData(
                table: "SecuritySettings",
                keyColumn: "Id",
                keyValue: new Guid("000003ac-0000-0003-0000-03aa000033e8"));

            migrationBuilder.DeleteData(
                table: "SecuritySettings",
                keyColumn: "Id",
                keyValue: new Guid("000003ac-0000-0004-0000-03a4000033e9"));

            migrationBuilder.DeleteData(
                table: "SystemConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("000003a2-0000-0001-0000-03a0000033dc"));

            migrationBuilder.DeleteData(
                table: "SystemConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("000003a2-0000-0002-0000-03a6000033dd"));

            migrationBuilder.DeleteData(
                table: "SystemConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("000003a2-0000-0003-0000-03a4000033de"));

            migrationBuilder.DeleteData(
                table: "SystemConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("000003a2-0000-0004-0000-03aa000033df"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0001-0000-02600000329c"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0002-0000-02660000329d"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0003-0000-02640000329e"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0004-0000-026a0000329f"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0005-0000-0268000032a0"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0006-0000-026e000032a1"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0007-0000-026c000032a2"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0008-0000-0272000032a3"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0009-0000-0270000032a4"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-000a-0000-0276000032a5"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-000b-0000-0274000032a6"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-000c-0000-027a000032a7"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-000d-0000-0278000032a8"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-000e-0000-027e000032a9"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-000f-0000-027c000032aa"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0010-0000-0242000032ab"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0011-0000-0240000032ac"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0012-0000-0246000032ad"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0013-0000-0244000032ae"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0014-0000-024a000032af"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0015-0000-0248000032b0"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0016-0000-024e000032b1"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0017-0000-024c000032b2"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0018-0000-0252000032b3"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0019-0000-0250000032b4"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-001a-0000-0256000032b5"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-001b-0000-0254000032b6"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-001c-0000-025a000032b7"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-001d-0000-0258000032b8"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-001e-0000-025e000032b9"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-001f-0000-025c000032ba"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0020-0000-0222000032bb"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0021-0000-0220000032bc"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0022-0000-0226000032bd"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0023-0000-0224000032be"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0024-0000-022a000032bf"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0025-0000-0228000032c0"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0026-0000-022e000032c1"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0027-0000-022c000032c2"));

            migrationBuilder.DeleteData(
                table: "TrainingProgress",
                keyColumn: "Id",
                keyValue: new Guid("00000262-0000-0028-0000-0232000032c3"));

            migrationBuilder.DeleteData(
                table: "TrainingRequests",
                keyColumn: "Id",
                keyValue: new Guid("0000026c-0000-0001-0000-026e000032a6"));

            migrationBuilder.DeleteData(
                table: "TrainingRequests",
                keyColumn: "Id",
                keyValue: new Guid("0000026c-0000-0002-0000-0268000032a7"));

            migrationBuilder.DeleteData(
                table: "TrainingRequests",
                keyColumn: "Id",
                keyValue: new Guid("0000026c-0000-0003-0000-026a000032a8"));

            migrationBuilder.DeleteData(
                table: "TrainingRequests",
                keyColumn: "Id",
                keyValue: new Guid("0000026c-0000-0004-0000-0264000032a9"));

            migrationBuilder.DeleteData(
                table: "TrainingRequests",
                keyColumn: "Id",
                keyValue: new Guid("0000026c-0000-0005-0000-0266000032aa"));

            migrationBuilder.DeleteData(
                table: "TrainingRequests",
                keyColumn: "Id",
                keyValue: new Guid("0000026c-0000-0006-0000-0260000032ab"));

            migrationBuilder.DeleteData(
                table: "TrainingRequests",
                keyColumn: "Id",
                keyValue: new Guid("0000026c-0000-0007-0000-0262000032ac"));

            migrationBuilder.DeleteData(
                table: "TrainingRequests",
                keyColumn: "Id",
                keyValue: new Guid("0000026c-0000-0008-0000-027c000032ad"));

            migrationBuilder.DeleteData(
                table: "TrainingRequests",
                keyColumn: "Id",
                keyValue: new Guid("0000026c-0000-0009-0000-027e000032ae"));

            migrationBuilder.DeleteData(
                table: "TrainingRequests",
                keyColumn: "Id",
                keyValue: new Guid("0000026c-0000-000a-0000-0278000032af"));

            migrationBuilder.DeleteData(
                table: "TrainingRequests",
                keyColumn: "Id",
                keyValue: new Guid("0000026c-0000-000b-0000-027a000032b0"));

            migrationBuilder.DeleteData(
                table: "TrainingRequests",
                keyColumn: "Id",
                keyValue: new Guid("0000026c-0000-000c-0000-0274000032b1"));

            migrationBuilder.DeleteData(
                table: "TrainingRequests",
                keyColumn: "Id",
                keyValue: new Guid("0000026c-0000-000d-0000-0276000032b2"));

            migrationBuilder.DeleteData(
                table: "TrainingRequests",
                keyColumn: "Id",
                keyValue: new Guid("0000026c-0000-000e-0000-0270000032b3"));

            migrationBuilder.DeleteData(
                table: "TrainingRequests",
                keyColumn: "Id",
                keyValue: new Guid("0000026c-0000-000f-0000-0272000032b4"));

            migrationBuilder.DeleteData(
                table: "TrainingRequests",
                keyColumn: "Id",
                keyValue: new Guid("0000026c-0000-0010-0000-024c000032b5"));

            migrationBuilder.DeleteData(
                table: "TrainingSessions",
                keyColumn: "Id",
                keyValue: new Guid("00000258-0000-0001-0000-025a00003292"));

            migrationBuilder.DeleteData(
                table: "TrainingSessions",
                keyColumn: "Id",
                keyValue: new Guid("00000258-0000-0002-0000-025c00003293"));

            migrationBuilder.DeleteData(
                table: "TrainingSessions",
                keyColumn: "Id",
                keyValue: new Guid("00000258-0000-0003-0000-025e00003294"));

            migrationBuilder.DeleteData(
                table: "TrainingSessions",
                keyColumn: "Id",
                keyValue: new Guid("00000258-0000-0004-0000-025000003295"));

            migrationBuilder.DeleteData(
                table: "TrainingSessions",
                keyColumn: "Id",
                keyValue: new Guid("00000258-0000-0005-0000-025200003296"));

            migrationBuilder.DeleteData(
                table: "TrainingSessions",
                keyColumn: "Id",
                keyValue: new Guid("00000258-0000-0006-0000-025400003297"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-0001-0000-0386000033be"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-0002-0000-0380000033bf"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-0003-0000-0382000033c0"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-0004-0000-038c000033c1"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-0005-0000-038e000033c2"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-0006-0000-0388000033c3"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-0007-0000-038a000033c4"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-0008-0000-0394000033c5"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-0009-0000-0396000033c6"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-000a-0000-0390000033c7"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-000b-0000-0392000033c8"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-000c-0000-039c000033c9"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-000d-0000-039e000033ca"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-000e-0000-0398000033cb"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-000f-0000-039a000033cc"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-0010-0000-03a4000033cd"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-0011-0000-03a6000033ce"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-0012-0000-03a0000033cf"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-0013-0000-03a2000033d0"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: new Guid("00000384-0000-0014-0000-03ac000033d1"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("0000038e-0000-0001-0000-038c000033c8"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("0000038e-0000-0002-0000-038a000033c9"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("0000038e-0000-0003-0000-0388000033ca"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0001-0000-00660000309e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0002-0000-00600000309f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0003-0000-0062000030a0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0004-0000-006c000030a1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0005-0000-006e000030a2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0006-0000-0068000030a3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0007-0000-006a000030a4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0008-0000-0074000030a5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0009-0000-0076000030a6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-000a-0000-0070000030a7"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-000b-0000-0072000030a8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-000c-0000-007c000030a9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-000d-0000-007e000030aa"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-000e-0000-0078000030ab"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-000f-0000-007a000030ac"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0010-0000-0044000030ad"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0011-0000-0046000030ae"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0012-0000-0040000030af"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0013-0000-0042000030b0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0014-0000-004c000030b1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0015-0000-004e000030b2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0016-0000-0048000030b3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0017-0000-004a000030b4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0018-0000-0054000030b5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-001a-0000-0050000030b7"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-001c-0000-005c000030b9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-001d-0000-005e000030ba"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-001e-0000-0058000030bb"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0020-0000-0024000030bd"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0022-0000-0020000030bf"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0024-0000-002c000030c1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0026-0000-0028000030c3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0027-0000-002a000030c4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0028-0000-0034000030c5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-002a-0000-0030000030c7"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-002c-0000-003c000030c9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-002e-0000-0038000030cb"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0030-0000-0004000030cd"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0031-0000-0006000030ce"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0032-0000-0000000030cf"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0034-0000-000c000030d1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0036-0000-0008000030d3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0038-0000-0014000030d5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-003a-0000-0010000030d7"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-003b-0000-0012000030d8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-003c-0000-001c000030d9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-003e-0000-0018000030db"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0040-0000-00e4000030dd"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0042-0000-00e0000030df"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0044-0000-00ec000030e1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0045-0000-00ee000030e2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0046-0000-00e8000030e3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0048-0000-00f4000030e5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-004a-0000-00f0000030e7"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-004c-0000-00fc000030e9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-004e-0000-00f8000030eb"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-004f-0000-00fa000030ec"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0050-0000-00c4000030ed"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0052-0000-00c0000030ef"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0054-0000-00cc000030f1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0058-0000-00d4000030f5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0059-0000-00d6000030f6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-005c-0000-00dc000030f9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-005e-0000-00d8000030fb"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0060-0000-00a4000030fd"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0063-0000-00a200003100"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("00000064-0000-0064-0000-00ac00003101"));

            migrationBuilder.DeleteData(
                table: "EngagementSurveys",
                keyColumn: "Id",
                keyValue: new Guid("000002bc-0000-0001-0000-02be000032f6"));

            migrationBuilder.DeleteData(
                table: "EngagementSurveys",
                keyColumn: "Id",
                keyValue: new Guid("000002bc-0000-0002-0000-02b8000032f7"));

            migrationBuilder.DeleteData(
                table: "EngagementSurveys",
                keyColumn: "Id",
                keyValue: new Guid("000002bc-0000-0003-0000-02ba000032f8"));

            migrationBuilder.DropColumn(
                name: "Category",
                table: "SystemConfigurations");

            migrationBuilder.DropColumn(
                name: "UpdatedAtUtc",
                table: "SystemConfigurations");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "SystemConfigurations");

            migrationBuilder.DropColumn(
                name: "Control",
                table: "SecuritySettings");

            migrationBuilder.DropColumn(
                name: "LastReviewedAtUtc",
                table: "SecuritySettings");

            migrationBuilder.DropColumn(
                name: "Owner",
                table: "SecuritySettings");

            migrationBuilder.DropColumn(
                name: "Severity",
                table: "SecuritySettings");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "SecuritySettings");

            migrationBuilder.RenameColumn(
                name: "Owner",
                table: "SystemConfigurations",
                newName: "Timezone");

            migrationBuilder.RenameColumn(
                name: "Key",
                table: "SystemConfigurations",
                newName: "Workweek");

            migrationBuilder.AddColumn<string>(
                name: "MfaMode",
                table: "SecuritySettings",
                type: "character varying(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PasswordPolicy",
                table: "SecuritySettings",
                type: "character varying(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

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
        }
    }
}

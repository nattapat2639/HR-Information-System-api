using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hris.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FixMissingApproverIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ApproverId",
                table: "LeaveRequests",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApproverName",
                table: "LeaveRequests",
                type: "character varying(128)",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactDuringLeave",
                table: "LeaveRequests",
                type: "character varying(128)",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DecisionOn",
                table: "LeaveRequests",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsHalfDay",
                table: "LeaveRequests",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ManagerComment",
                table: "LeaveRequests",
                type: "character varying(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "LeaveRequests",
                type: "character varying(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupportingDocumentUrl",
                table: "LeaveRequests",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0001-0000-00ca00003102"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "IsHalfDay", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-000c-0000-007c000030a9"), "Natdanai Srisawat", "+66-8000-3000", new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Utc), true, "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", "https://cdn.example.com/leave-supporting/leave-001.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0002-0000-00cc00003103"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8737-3019", null, null, "Medical follow-up appointment as advised by doctor.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0003-0000-00ce00003104"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-001a-0000-0050000030b7"), "Kamol Wiriyakul", "+66-8464-3038", new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0004-0000-00c000003105"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0021-0000-0026000030be"), "Supaporn Suksawat", "+66-8191-3057", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0005-0000-00c200003106"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8828-3076", null, "Family Responsibility", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0006-0000-00c400003107"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-002f-0000-003a000030cc"), "Ratchada Wongchai", "+66-8555-3095", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Annual Leave", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0007-0000-00c600003108"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0036-0000-0008000030d3"), "Sorawit Thongchai", "+66-8282-3114", new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Sick Leave", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0008-0000-00d800003109"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8919-3133", null, "Work From Home", null, "Medical follow-up appointment as advised by doctor.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0009-0000-00da0000310a"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0044-0000-00ec000030e1"), "Pisan Kittiphob", "+66-8646-3152", new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Unpaid Leave", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-000a-0000-00dc0000310b"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-004b-0000-00f2000030e8"), "Wimon Pradchaphet", "+66-8373-3171", new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "Rejected", "https://cdn.example.com/leave-supporting/leave-010.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-000b-0000-00de0000310c"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8000-3190", null, "Annual Leave", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-000c-0000-00d00000310d"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0059-0000-00d6000030f6"), "Warisa Chawengchai", "+66-8737-3209", new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Sick Leave", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-000d-0000-00d20000310e"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0060-0000-00a4000030fd"), "Chanya Rattanarak", "+66-8464-3228", new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Work From Home", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-000e-0000-00d40000310f"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8191-3247", null, "Unpaid Leave", null, "Medical follow-up appointment as advised by doctor.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-000f-0000-00d600003110"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-000a-0000-0070000030a7"), "Apichat La-ongsri", "+66-8828-3266", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0010-0000-00e800003111"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "IsHalfDay", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0011-0000-0046000030ae"), "Suphakarn Boonsri", "+66-8555-3285", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Utc), true, "Annual Leave", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0011-0000-00ea00003112"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8282-3304", null, "Sick Leave", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0012-0000-00ec00003113"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-001f-0000-005a000030bc"), "Kannika Pakdeepong", "+66-8919-3323", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Work From Home", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0013-0000-00ee00003114"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0026-0000-0028000030c3"), "Anucha Mekchai", "+66-8646-3342", new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Unpaid Leave", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", "https://cdn.example.com/leave-supporting/leave-019.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0014-0000-00e000003115"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8373-3361", null, "Family Responsibility", null, "Medical follow-up appointment as advised by doctor.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0015-0000-00e200003116"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0034-0000-000c000030d1"), "Natdanai Srisawat", "+66-8000-3380", new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0016-0000-00e400003117"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-003b-0000-0012000030d8"), "Duangjai Chantana", "+66-8737-3399", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "Rejected", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0017-0000-00e600003118"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8464-3418", null, null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0018-0000-00f800003119"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0049-0000-00f6000030e6"), "Supaporn Suksawat", "+66-8191-3437", new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0019-0000-00fa0000311a"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0050-0000-00c4000030ed"), "Prasert Saithong", "+66-8828-3456", new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-001a-0000-00fc0000311b"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8555-3475", null, "Annual Leave", null, "Medical follow-up appointment as advised by doctor.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-001b-0000-00fe0000311c"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-005e-0000-00d8000030fb"), "Sorawit Thongchai", "+66-8282-3494", new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Sick Leave", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-001c-0000-00f00000311d"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0001-0000-00660000309e"), "Anan Techakul", "+66-8919-3513", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Work From Home", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "https://cdn.example.com/leave-supporting/leave-028.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-001d-0000-00f20000311e"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8646-3532", null, "Unpaid Leave", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-001e-0000-00f40000311f"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-000f-0000-007a000030ac"), "Wimon Pradchaphet", "+66-8373-3551", new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-001f-0000-00f600003120"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "IsHalfDay", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0016-0000-0048000030b3"), "Suchada Kongthanaraj", "+66-8000-3570", new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Utc), true, "Annual Leave", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0020-0000-008800003121"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8737-3589", null, "Sick Leave", null, "Medical follow-up appointment as advised by doctor.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0021-0000-008a00003122"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0024-0000-002c000030c1"), "Chanya Rattanarak", "+66-8464-3608", new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Work From Home", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0022-0000-008c00003123"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-002b-0000-0032000030c8"), "Korn Praphan", "+66-8191-3627", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Unpaid Leave", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "Rejected", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0023-0000-008e00003124"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8828-3646", null, "Family Responsibility", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0024-0000-008000003125"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0039-0000-0016000030d6"), "Suphakarn Boonsri", "+66-8555-3665", new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Annual Leave", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0025-0000-008200003126"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0040-0000-00e4000030dd"), "Nattawat Dechapanya", "+66-8282-3684", new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Sick Leave", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", "https://cdn.example.com/leave-supporting/leave-037.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0026-0000-008400003127"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8919-3703", null, "Work From Home", null, "Medical follow-up appointment as advised by doctor.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0027-0000-008600003128"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-004e-0000-00f8000030eb"), "Anucha Mekchai", "+66-8646-3722", new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Unpaid Leave", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0028-0000-009800003129"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0055-0000-00ce000030f2"), "Benjamas Intharachai", "+66-8373-3741", new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0029-0000-009a0000312a"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8000-3760", null, null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-002a-0000-009c0000312b"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0063-0000-00a200003100"), "Duangjai Chantana", "+66-8737-3779", new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-002b-0000-009e0000312c"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0006-0000-0068000030a3"), "Kamol Wiriyakul", "+66-8464-3798", new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Utc), "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-002c-0000-00900000312d"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8191-3817", null, null, "Medical follow-up appointment as advised by doctor.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-002d-0000-00920000312e"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0014-0000-004c000030b1"), "Prasert Saithong", "+66-8828-3836", new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-002e-0000-00940000312f"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "IsHalfDay", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-001b-0000-0052000030b8"), "Ratchada Wongchai", "+66-8555-3855", new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Utc), true, "Annual Leave", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "Rejected", "https://cdn.example.com/leave-supporting/leave-046.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-002f-0000-009600003130"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8282-3874", null, "Sick Leave", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0030-0000-00a800003131"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0029-0000-0036000030c6"), "Anan Techakul", "+66-8919-3893", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Work From Home", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0031-0000-00aa00003132"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0030-0000-0004000030cd"), "Pisan Kittiphob", "+66-8646-3912", new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Unpaid Leave", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0032-0000-00ac00003133"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8373-3931", null, "Family Responsibility", null, "Medical follow-up appointment as advised by doctor.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0033-0000-00ae00003134"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-003e-0000-0018000030db"), "Suchada Kongthanaraj", "+66-8000-3950", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Annual Leave", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0034-0000-00a000003135"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0045-0000-00ee000030e2"), "Warisa Chawengchai", "+66-8737-3969", new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Sick Leave", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0035-0000-00a200003136"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8464-3988", null, "Work From Home", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0036-0000-00a400003137"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0053-0000-00c2000030f0"), "Korn Praphan", "+66-8191-4007", new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Unpaid Leave", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0037-0000-00a600003138"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-005a-0000-00d0000030f7"), "Apichat La-ongsri", "+66-8828-4026", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", "https://cdn.example.com/leave-supporting/leave-055.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0038-0000-00b800003139"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8555-4045", null, "Annual Leave", null, "Medical follow-up appointment as advised by doctor.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0039-0000-00ba0000313a"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0004-0000-006c000030a1"), "Nattawat Dechapanya", "+66-8282-4064", new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Sick Leave", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-003a-0000-00bc0000313b"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-000b-0000-0072000030a8"), "Kannika Pakdeepong", "+66-8919-4083", new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Work From Home", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "Rejected", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-003b-0000-00be0000313c"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8646-4102", null, "Unpaid Leave", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-003c-0000-00b00000313d"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0019-0000-0056000030b6"), "Benjamas Intharachai", "+66-8373-4121", new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-003d-0000-00b20000313e"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "IsHalfDay", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0020-0000-0024000030bd"), "Natdanai Srisawat", "+66-8000-4140", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), true, "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-003e-0000-00b40000313f"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8737-4159", null, null, "Medical follow-up appointment as advised by doctor.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-003f-0000-00b600003140"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-002e-0000-0038000030cb"), "Kamol Wiriyakul", "+66-8464-4178", new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0040-0000-004800003141"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0035-0000-000e000030d2"), "Supaporn Suksawat", "+66-8191-4197", new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "https://cdn.example.com/leave-supporting/leave-064.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0041-0000-004a00003142"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8828-4216", null, "Family Responsibility", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0042-0000-004c00003143"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0043-0000-00e2000030e0"), "Ratchada Wongchai", "+66-8555-4235", new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Annual Leave", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0043-0000-004e00003144"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-004a-0000-00f0000030e7"), "Sorawit Thongchai", "+66-8282-4254", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Sick Leave", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0044-0000-004000003145"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8919-4273", null, "Work From Home", null, "Medical follow-up appointment as advised by doctor.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0045-0000-004200003146"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0058-0000-00d4000030f5"), "Pisan Kittiphob", "+66-8646-4292", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Unpaid Leave", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0046-0000-004400003147"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-005f-0000-00da000030fc"), "Wimon Pradchaphet", "+66-8373-4311", new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "Rejected", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0047-0000-004600003148"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8000-4330", null, "Annual Leave", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0048-0000-005800003149"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0009-0000-0076000030a6"), "Warisa Chawengchai", "+66-8737-4349", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Sick Leave", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0049-0000-005a0000314a"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0010-0000-0044000030ad"), "Chanya Rattanarak", "+66-8464-4368", new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Work From Home", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", "https://cdn.example.com/leave-supporting/leave-073.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-004a-0000-005c0000314b"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8191-4387", null, "Unpaid Leave", null, "Medical follow-up appointment as advised by doctor.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-004b-0000-005e0000314c"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-001e-0000-0058000030bb"), "Apichat La-ongsri", "+66-8828-4406", new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-004c-0000-00500000314d"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "IsHalfDay", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0025-0000-002e000030c2"), "Suphakarn Boonsri", "+66-8555-4425", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, "Annual Leave", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-004d-0000-00520000314e"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8282-4444", null, "Sick Leave", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-004e-0000-00540000314f"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0033-0000-0002000030d0"), "Kannika Pakdeepong", "+66-8919-4463", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Work From Home", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-004f-0000-005600003150"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-003a-0000-0010000030d7"), "Anucha Mekchai", "+66-8646-4482", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Unpaid Leave", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0050-0000-006800003151"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8373-4501", null, "Family Responsibility", null, "Medical follow-up appointment as advised by doctor.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0051-0000-006a00003152"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0048-0000-00f4000030e5"), "Natdanai Srisawat", "+66-8000-4520", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0052-0000-006c00003153"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-004f-0000-00fa000030ec"), "Duangjai Chantana", "+66-8737-4539", new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "Rejected", "https://cdn.example.com/leave-supporting/leave-082.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0053-0000-006e00003154"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8464-4558", null, null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0054-0000-006000003155"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-005d-0000-00de000030fa"), "Supaporn Suksawat", "+66-8191-4577", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0055-0000-006200003156"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0064-0000-00ac00003101"), "Prasert Saithong", "+66-8828-4596", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0056-0000-006400003157"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8555-4615", null, "Annual Leave", null, "Medical follow-up appointment as advised by doctor.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0057-0000-006600003158"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-000e-0000-0078000030ab"), "Sorawit Thongchai", "+66-8282-4634", new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Sick Leave", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0058-0000-007800003159"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0015-0000-004e000030b2"), "Anan Techakul", "+66-8919-4653", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Work From Home", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0059-0000-007a0000315a"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8646-4672", null, "Unpaid Leave", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-005a-0000-007c0000315b"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0023-0000-0022000030c0"), "Wimon Pradchaphet", "+66-8373-4691", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-005b-0000-007e0000315c"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "IsHalfDay", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-002a-0000-0030000030c7"), "Suchada Kongthanaraj", "+66-8000-4710", new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Utc), true, "Annual Leave", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", "https://cdn.example.com/leave-supporting/leave-091.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-005c-0000-00700000315d"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8737-4729", null, "Sick Leave", null, "Medical follow-up appointment as advised by doctor.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-005d-0000-00720000315e"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0038-0000-0014000030d5"), "Chanya Rattanarak", "+66-8464-4748", new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Work From Home", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-005e-0000-00740000315f"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-003f-0000-001a000030dc"), "Korn Praphan", "+66-8191-4767", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Unpaid Leave", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "Rejected", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-005f-0000-007600003160"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8828-4786", null, "Family Responsibility", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0060-0000-000800003161"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-004d-0000-00fe000030ea"), "Suphakarn Boonsri", "+66-8555-4805", new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Annual Leave", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0061-0000-000a00003162"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0054-0000-00cc000030f1"), "Nattawat Dechapanya", "+66-8282-4824", new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Sick Leave", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0062-0000-000c00003163"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8919-4843", null, "Work From Home", null, "Medical follow-up appointment as advised by doctor.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0063-0000-000e00003164"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0062-0000-00a0000030ff"), "Anucha Mekchai", "+66-8646-4862", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Unpaid Leave", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0064-0000-000000003165"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0005-0000-006e000030a2"), "Benjamas Intharachai", "+66-8373-4881", new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "https://cdn.example.com/leave-supporting/leave-100.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0065-0000-000200003166"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8000-4900", null, null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0066-0000-000400003167"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0013-0000-0042000030b0"), "Duangjai Chantana", "+66-8737-4919", new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0067-0000-000600003168"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-001a-0000-0050000030b7"), "Kamol Wiriyakul", "+66-8464-4938", new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0068-0000-001800003169"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8191-4957", null, null, "Medical follow-up appointment as advised by doctor.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0069-0000-001a0000316a"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0028-0000-0034000030c5"), "Prasert Saithong", "+66-8828-4976", new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-006a-0000-001c0000316b"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "IsHalfDay", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-002f-0000-003a000030cc"), "Ratchada Wongchai", "+66-8555-4995", new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Utc), true, "Annual Leave", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "Rejected", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-006b-0000-001e0000316c"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8282-5014", null, "Sick Leave", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-006c-0000-00100000316d"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-003d-0000-001e000030da"), "Anan Techakul", "+66-8919-5033", new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Work From Home", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-006d-0000-00120000316e"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0044-0000-00ec000030e1"), "Pisan Kittiphob", "+66-8646-5052", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Unpaid Leave", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", "https://cdn.example.com/leave-supporting/leave-109.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-006e-0000-00140000316f"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8373-5071", null, "Family Responsibility", null, "Medical follow-up appointment as advised by doctor.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-006f-0000-001600003170"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0052-0000-00c0000030ef"), "Suchada Kongthanaraj", "+66-8000-5090", new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Annual Leave", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0070-0000-002800003171"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0059-0000-00d6000030f6"), "Warisa Chawengchai", "+66-8737-5109", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Sick Leave", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0071-0000-002a00003172"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8464-5128", null, "Work From Home", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0072-0000-002c00003173"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0003-0000-0062000030a0"), "Korn Praphan", "+66-8191-5147", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Unpaid Leave", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0073-0000-002e00003174"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-000a-0000-0070000030a7"), "Apichat La-ongsri", "+66-8828-5166", new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0074-0000-002000003175"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8555-5185", null, "Annual Leave", null, "Medical follow-up appointment as advised by doctor.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0075-0000-002200003176"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0018-0000-0054000030b5"), "Nattawat Dechapanya", "+66-8282-5204", new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Sick Leave", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0076-0000-002400003177"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-001f-0000-005a000030bc"), "Kannika Pakdeepong", "+66-8919-5223", new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Work From Home", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "Rejected", "https://cdn.example.com/leave-supporting/leave-118.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0077-0000-002600003178"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8646-5242", null, "Unpaid Leave", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0078-0000-003800003179"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-002d-0000-003e000030ca"), "Benjamas Intharachai", "+66-8373-5261", new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0079-0000-003a0000317a"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "IsHalfDay", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0034-0000-000c000030d1"), "Natdanai Srisawat", "+66-8000-5280", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), true, "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-007a-0000-003c0000317b"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8737-5299", null, null, "Medical follow-up appointment as advised by doctor.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-007b-0000-003e0000317c"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0042-0000-00e0000030df"), "Kamol Wiriyakul", "+66-8464-5318", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-007c-0000-00300000317d"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0049-0000-00f6000030e6"), "Supaporn Suksawat", "+66-8191-5337", new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-007d-0000-00320000317e"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8828-5356", null, "Family Responsibility", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-007e-0000-00340000317f"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0057-0000-00ca000030f4"), "Ratchada Wongchai", "+66-8555-5375", new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Annual Leave", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-007f-0000-003600003180"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-005e-0000-00d8000030fb"), "Sorawit Thongchai", "+66-8282-5394", new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Sick Leave", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", "https://cdn.example.com/leave-supporting/leave-127.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0080-0000-01c800003181"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8919-5413", null, "Work From Home", null, "Medical follow-up appointment as advised by doctor.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0081-0000-01ca00003182"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0008-0000-0074000030a5"), "Pisan Kittiphob", "+66-8646-5432", new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Unpaid Leave", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0082-0000-01cc00003183"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-000f-0000-007a000030ac"), "Wimon Pradchaphet", "+66-8373-5451", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "Rejected", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0083-0000-01ce00003184"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8000-5470", null, "Annual Leave", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0084-0000-01c000003185"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-001d-0000-005e000030ba"), "Warisa Chawengchai", "+66-8737-5489", new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Sick Leave", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0085-0000-01c200003186"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0024-0000-002c000030c1"), "Chanya Rattanarak", "+66-8464-5508", new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Work From Home", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0086-0000-01c400003187"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8191-5527", null, "Unpaid Leave", null, "Medical follow-up appointment as advised by doctor.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0087-0000-01c600003188"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0032-0000-0000000030cf"), "Apichat La-ongsri", "+66-8828-5546", new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0088-0000-01d800003189"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "IsHalfDay", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0039-0000-0016000030d6"), "Suphakarn Boonsri", "+66-8555-5565", new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Utc), true, "Annual Leave", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "https://cdn.example.com/leave-supporting/leave-136.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0089-0000-01da0000318a"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8282-5584", null, "Sick Leave", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-008a-0000-01dc0000318b"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0047-0000-00ea000030e4"), "Kannika Pakdeepong", "+66-8919-5603", new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Utc), "Work From Home", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-008b-0000-01de0000318c"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-004e-0000-00f8000030eb"), "Anucha Mekchai", "+66-8646-5622", new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Unpaid Leave", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-008c-0000-01d00000318d"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8373-5641", null, "Family Responsibility", null, "Medical follow-up appointment as advised by doctor.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-008d-0000-01d20000318e"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-005c-0000-00dc000030f9"), "Natdanai Srisawat", "+66-8000-5660", new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-008e-0000-01d40000318f"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0063-0000-00a200003100"), "Duangjai Chantana", "+66-8737-5679", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "Rejected", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-008f-0000-01d600003190"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8464-5698", null, null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0090-0000-01e800003191"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-000d-0000-007e000030aa"), "Supaporn Suksawat", "+66-8191-5717", new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0091-0000-01ea00003192"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0014-0000-004c000030b1"), "Prasert Saithong", "+66-8828-5736", new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", "https://cdn.example.com/leave-supporting/leave-145.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0092-0000-01ec00003193"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8555-5755", null, "Annual Leave", null, "Medical follow-up appointment as advised by doctor.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0093-0000-01ee00003194"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0022-0000-0020000030bf"), "Sorawit Thongchai", "+66-8282-5774", new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Sick Leave", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0094-0000-01e000003195"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0029-0000-0036000030c6"), "Anan Techakul", "+66-8919-5793", new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Work From Home", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0095-0000-01e200003196"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8646-5812", null, "Unpaid Leave", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0096-0000-01e400003197"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0037-0000-000a000030d4"), "Wimon Pradchaphet", "+66-8373-5831", new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0097-0000-01e600003198"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "IsHalfDay", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-003e-0000-0018000030db"), "Suchada Kongthanaraj", "+66-8000-5850", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, "Annual Leave", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0098-0000-01f800003199"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8737-5869", null, "Sick Leave", null, "Medical follow-up appointment as advised by doctor.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0099-0000-01fa0000319a"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-004c-0000-00fc000030e9"), "Chanya Rattanarak", "+66-8464-5888", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Work From Home", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-009a-0000-01fc0000319b"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0053-0000-00c2000030f0"), "Korn Praphan", "+66-8191-5907", new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Unpaid Leave", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "Rejected", "https://cdn.example.com/leave-supporting/leave-154.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-009b-0000-01fe0000319c"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8828-5926", null, "Family Responsibility", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-009c-0000-01f00000319d"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0061-0000-00a6000030fe"), "Suphakarn Boonsri", "+66-8555-5945", new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Annual Leave", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-009d-0000-01f20000319e"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0004-0000-006c000030a1"), "Nattawat Dechapanya", "+66-8282-5964", new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Sick Leave", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-009e-0000-01f40000319f"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8919-5983", null, "Work From Home", null, "Medical follow-up appointment as advised by doctor.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-009f-0000-01f6000031a0"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0012-0000-0040000030af"), "Anucha Mekchai", "+66-8646-6002", new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Unpaid Leave", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a0-0000-0188000031a1"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0019-0000-0056000030b6"), "Benjamas Intharachai", "+66-8373-6021", new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a1-0000-018a000031a2"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8000-6040", null, null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a2-0000-018c000031a3"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0027-0000-002a000030c4"), "Duangjai Chantana", "+66-8737-6059", new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a3-0000-018e000031a4"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-002e-0000-0038000030cb"), "Kamol Wiriyakul", "+66-8464-6078", new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", "https://cdn.example.com/leave-supporting/leave-163.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a4-0000-0180000031a5"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8191-6097", null, null, "Medical follow-up appointment as advised by doctor.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a5-0000-0182000031a6"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-003c-0000-001c000030d9"), "Prasert Saithong", "+66-8828-6116", new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a6-0000-0184000031a7"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "IsHalfDay", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0043-0000-00e2000030e0"), "Ratchada Wongchai", "+66-8555-6135", new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Utc), true, "Annual Leave", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "Rejected", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a7-0000-0186000031a8"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8282-6154", null, "Sick Leave", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a8-0000-0198000031a9"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0051-0000-00c6000030ee"), "Anan Techakul", "+66-8919-6173", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Work From Home", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a9-0000-019a000031aa"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0058-0000-00d4000030f5"), "Pisan Kittiphob", "+66-8646-6192", new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Unpaid Leave", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00aa-0000-019c000031ab"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8373-6211", null, "Family Responsibility", null, "Medical follow-up appointment as advised by doctor.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00ab-0000-019e000031ac"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0002-0000-00600000309f"), "Suchada Kongthanaraj", "+66-8000-6230", new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Annual Leave", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00ac-0000-0190000031ad"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0009-0000-0076000030a6"), "Warisa Chawengchai", "+66-8737-6249", new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Sick Leave", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "https://cdn.example.com/leave-supporting/leave-172.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00ad-0000-0192000031ae"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8464-6268", null, "Work From Home", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00ae-0000-0194000031af"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0017-0000-004a000030b4"), "Korn Praphan", "+66-8191-6287", new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Unpaid Leave", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00af-0000-0196000031b0"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-001e-0000-0058000030bb"), "Apichat La-ongsri", "+66-8828-6306", new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b0-0000-01a8000031b1"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8555-6325", null, "Annual Leave", null, "Medical follow-up appointment as advised by doctor.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b1-0000-01aa000031b2"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-002c-0000-003c000030c9"), "Nattawat Dechapanya", "+66-8282-6344", new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Sick Leave", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b2-0000-01ac000031b3"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0033-0000-0002000030d0"), "Kannika Pakdeepong", "+66-8919-6363", new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Work From Home", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "Rejected", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b3-0000-01ae000031b4"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8646-6382", null, "Unpaid Leave", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b4-0000-01a0000031b5"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0041-0000-00e6000030de"), "Benjamas Intharachai", "+66-8373-6401", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b5-0000-01a2000031b6"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "IsHalfDay", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0048-0000-00f4000030e5"), "Natdanai Srisawat", "+66-8000-6420", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Utc), true, "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", "https://cdn.example.com/leave-supporting/leave-181.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b6-0000-01a4000031b7"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8737-6439", null, null, "Medical follow-up appointment as advised by doctor.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b7-0000-01a6000031b8"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0056-0000-00c8000030f3"), "Kamol Wiriyakul", "+66-8464-6458", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b8-0000-01b8000031b9"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-005d-0000-00de000030fa"), "Supaporn Suksawat", "+66-8191-6477", new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b9-0000-01ba000031ba"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8828-6496", null, "Family Responsibility", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00ba-0000-01bc000031bb"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0007-0000-006a000030a4"), "Ratchada Wongchai", "+66-8555-6515", new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Annual Leave", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00bb-0000-01be000031bc"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-000e-0000-0078000030ab"), "Sorawit Thongchai", "+66-8282-6534", new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Sick Leave", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00bc-0000-01b0000031bd"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8919-6553", null, "Work From Home", null, "Medical follow-up appointment as advised by doctor.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00bd-0000-01b2000031be"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-001c-0000-005c000030b9"), "Pisan Kittiphob", "+66-8646-6572", new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Unpaid Leave", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00be-0000-01b4000031bf"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0023-0000-0022000030c0"), "Wimon Pradchaphet", "+66-8373-6591", new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", "Rejected", "https://cdn.example.com/leave-supporting/leave-190.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00bf-0000-01b6000031c0"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8000-6610", null, "Annual Leave", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c0-0000-0148000031c1"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0031-0000-0006000030ce"), "Warisa Chawengchai", "+66-8737-6629", new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Sick Leave", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c1-0000-014a000031c2"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0038-0000-0014000030d5"), "Chanya Rattanarak", "+66-8464-6648", new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Work From Home", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c2-0000-014c000031c3"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8191-6667", null, "Unpaid Leave", null, "Medical follow-up appointment as advised by doctor.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c3-0000-014e000031c4"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0046-0000-00e8000030e3"), "Apichat La-ongsri", "+66-8828-6686", new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Family Responsibility", "Approved - coverage confirmed for the requested dates.", "Remote work arrangement for personal project delivery.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c4-0000-0140000031c5"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "IsHalfDay", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-004d-0000-00fe000030ea"), "Suphakarn Boonsri", "+66-8555-6705", new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), true, "Annual Leave", "Rejected - overlaps with critical delivery milestone.", "Vacation recharge planned months in advance.", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c5-0000-0142000031c6"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8282-6724", null, "Sick Leave", null, "Personal errands that require government office visit.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c6-0000-0144000031c7"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-005b-0000-00d2000030f8"), "Kannika Pakdeepong", "+66-8919-6743", new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Work From Home", "Approved - coverage confirmed for the requested dates.", "Rest after completing critical release.", "Approved", null });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c7-0000-0146000031c8"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "SupportingDocumentUrl" },
                values: new object[] { new Guid("00000064-0000-0062-0000-00a0000030ff"), "Anucha Mekchai", "+66-8646-6762", new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Unpaid Leave", "Approved - coverage confirmed for the requested dates.", "Family commitment and caregiving support.", "https://cdn.example.com/leave-supporting/leave-199.pdf" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c8-0000-0158000031c9"),
                columns: new[] { "ApproverId", "ApproverName", "ContactDuringLeave", "DecisionOn", "LeaveType", "ManagerComment", "Reason", "Status", "SupportingDocumentUrl" },
                values: new object[] { null, null, "+66-8373-6781", null, "Family Responsibility", null, "Medical follow-up appointment as advised by doctor.", "Pending", null });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0002-0000-032e00003365"),
                columns: new[] { "DaysUsed", "Employee", "Status" },
                values: new object[] { 30, "Duangjai Chantana", "Pending" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0003-0000-032c00003366"),
                columns: new[] { "DaysUsed", "Employee" },
                values: new object[] { 30, "Nattawat Dechapanya" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0004-0000-032200003367"),
                columns: new[] { "DaysUsed", "Employee" },
                values: new object[] { 30, "Warisa Chawengchai" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0005-0000-032000003368"),
                columns: new[] { "Employee", "LeaveType", "Status" },
                values: new object[] { "Duangjai Chantana", "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0006-0000-032600003369"),
                columns: new[] { "Employee", "Status" },
                values: new object[] { "Nattawat Dechapanya", "Approved" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0007-0000-03240000336a"),
                columns: new[] { "DaysUsed", "Employee", "Status" },
                values: new object[] { 40, "Warisa Chawengchai", "Pending" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0008-0000-033a0000336b"),
                columns: new[] { "DaysUsed", "Employee", "Status" },
                values: new object[] { 40, "Sorawit Thongchai", "Approved" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0009-0000-03380000336c"),
                columns: new[] { "DaysUsed", "Employee", "LeaveType", "Status" },
                values: new object[] { 20, "Warisa Chawengchai", "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-000a-0000-033e0000336d"),
                columns: new[] { "DaysUsed", "Employee", "LeaveType", "Status" },
                values: new object[] { 20, "Sorawit Thongchai", "Sick Leave", "Approved" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-000b-0000-033c0000336e"),
                columns: new[] { "Employee", "Status" },
                values: new object[] { "Duangjai Chantana", "Approved" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-000c-0000-03320000336f"),
                columns: new[] { "DaysUsed", "Employee" },
                values: new object[] { 20, "Nattawat Dechapanya" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-000d-0000-033000003370"),
                columns: new[] { "Employee", "LeaveType" },
                values: new object[] { "Nattawat Dechapanya", "Family Responsibility" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-000e-0000-033600003371"),
                columns: new[] { "DaysUsed", "LeaveType", "Status" },
                values: new object[] { 50, "Family Responsibility", "Rejected" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-000f-0000-033400003372"),
                columns: new[] { "DaysUsed", "Employee", "LeaveType", "Status" },
                values: new object[] { 50, "Sorawit Thongchai", "Family Responsibility", "Approved" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0010-0000-030a00003373"),
                columns: new[] { "DaysUsed", "Employee", "LeaveType", "Status" },
                values: new object[] { 50, "Duangjai Chantana", "Family Responsibility", "Pending" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0011-0000-030800003374"),
                column: "DaysUsed",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0012-0000-030e00003375"),
                columns: new[] { "DaysUsed", "Employee" },
                values: new object[] { 10, "Warisa Chawengchai" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0013-0000-030c00003376"),
                columns: new[] { "DaysUsed", "Employee", "Status" },
                values: new object[] { 10, "Sorawit Thongchai", "Pending" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0014-0000-030200003377"),
                columns: new[] { "DaysUsed", "Employee", "Status" },
                values: new object[] { 10, "Duangjai Chantana", "Rejected" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApproverId",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "ApproverName",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "ContactDuringLeave",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "DecisionOn",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "IsHalfDay",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "ManagerComment",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "SupportingDocumentUrl",
                table: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0005-0000-00c200003106"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Annual Leave", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0006-0000-00c400003107"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0007-0000-00c600003108"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0008-0000-00d800003109"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0009-0000-00da0000310a"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-000a-0000-00dc0000310b"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-000b-0000-00de0000310c"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Work From Home", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-000c-0000-00d00000310d"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-000d-0000-00d20000310e"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-000e-0000-00d40000310f"),
                column: "LeaveType",
                value: "Sick Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-000f-0000-00d600003110"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0010-0000-00e800003111"),
                column: "LeaveType",
                value: "Unpaid Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0011-0000-00ea00003112"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Annual Leave", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0012-0000-00ec00003113"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0013-0000-00ee00003114"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0014-0000-00e000003115"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0016-0000-00e400003117"),
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0017-0000-00e600003118"),
                column: "Status",
                value: "Approved");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0018-0000-00f800003119"),
                column: "Status",
                value: "Rejected");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0019-0000-00fa0000311a"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-001a-0000-00fc0000311b"),
                column: "LeaveType",
                value: "Sick Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-001b-0000-00fe0000311c"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-001c-0000-00f00000311d"),
                column: "LeaveType",
                value: "Unpaid Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-001d-0000-00f20000311e"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Annual Leave", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-001e-0000-00f40000311f"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-001f-0000-00f600003120"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0020-0000-008800003121"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0021-0000-008a00003122"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0022-0000-008c00003123"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0023-0000-008e00003124"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Work From Home", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0024-0000-008000003125"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0025-0000-008200003126"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0026-0000-008400003127"),
                column: "LeaveType",
                value: "Sick Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0027-0000-008600003128"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0028-0000-009800003129"),
                column: "LeaveType",
                value: "Unpaid Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0029-0000-009a0000312a"),
                column: "Status",
                value: "Approved");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-002a-0000-009c0000312b"),
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-002c-0000-00900000312d"),
                column: "Status",
                value: "Rejected");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-002d-0000-00920000312e"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-002e-0000-00940000312f"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-002f-0000-009600003130"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Work From Home", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0030-0000-00a800003131"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0031-0000-00aa00003132"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0032-0000-00ac00003133"),
                column: "LeaveType",
                value: "Sick Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0033-0000-00ae00003134"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0034-0000-00a000003135"),
                column: "LeaveType",
                value: "Unpaid Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0035-0000-00a200003136"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Annual Leave", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0036-0000-00a400003137"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0037-0000-00a600003138"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0038-0000-00b800003139"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0039-0000-00ba0000313a"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-003a-0000-00bc0000313b"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-003b-0000-00be0000313c"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Work From Home", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-003c-0000-00b00000313d"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0041-0000-004a00003142"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Annual Leave", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0042-0000-004c00003143"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0043-0000-004e00003144"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0044-0000-004000003145"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0045-0000-004200003146"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0046-0000-004400003147"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0047-0000-004600003148"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Work From Home", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0048-0000-005800003149"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0049-0000-005a0000314a"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-004a-0000-005c0000314b"),
                column: "LeaveType",
                value: "Sick Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-004b-0000-005e0000314c"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-004c-0000-00500000314d"),
                column: "LeaveType",
                value: "Unpaid Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-004d-0000-00520000314e"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Annual Leave", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-004e-0000-00540000314f"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-004f-0000-005600003150"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0050-0000-006800003151"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0052-0000-006c00003153"),
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0053-0000-006e00003154"),
                column: "Status",
                value: "Approved");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0054-0000-006000003155"),
                column: "Status",
                value: "Rejected");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0055-0000-006200003156"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0056-0000-006400003157"),
                column: "LeaveType",
                value: "Sick Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0057-0000-006600003158"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0058-0000-007800003159"),
                column: "LeaveType",
                value: "Unpaid Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0059-0000-007a0000315a"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Annual Leave", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-005a-0000-007c0000315b"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-005b-0000-007e0000315c"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-005c-0000-00700000315d"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-005d-0000-00720000315e"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-005e-0000-00740000315f"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-005f-0000-007600003160"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Work From Home", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0060-0000-000800003161"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0061-0000-000a00003162"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0062-0000-000c00003163"),
                column: "LeaveType",
                value: "Sick Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0063-0000-000e00003164"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0064-0000-000000003165"),
                column: "LeaveType",
                value: "Unpaid Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0065-0000-000200003166"),
                column: "Status",
                value: "Approved");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0066-0000-000400003167"),
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0068-0000-001800003169"),
                column: "Status",
                value: "Rejected");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0069-0000-001a0000316a"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-006a-0000-001c0000316b"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-006b-0000-001e0000316c"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Work From Home", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-006c-0000-00100000316d"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-006d-0000-00120000316e"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-006e-0000-00140000316f"),
                column: "LeaveType",
                value: "Sick Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-006f-0000-001600003170"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0070-0000-002800003171"),
                column: "LeaveType",
                value: "Unpaid Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0071-0000-002a00003172"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Annual Leave", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0072-0000-002c00003173"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0073-0000-002e00003174"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0074-0000-002000003175"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0075-0000-002200003176"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0076-0000-002400003177"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0077-0000-002600003178"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Work From Home", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0078-0000-003800003179"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-007d-0000-00320000317e"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Annual Leave", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-007e-0000-00340000317f"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-007f-0000-003600003180"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0080-0000-01c800003181"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0081-0000-01ca00003182"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0082-0000-01cc00003183"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0083-0000-01ce00003184"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Work From Home", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0084-0000-01c000003185"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0085-0000-01c200003186"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0086-0000-01c400003187"),
                column: "LeaveType",
                value: "Sick Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0087-0000-01c600003188"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0088-0000-01d800003189"),
                column: "LeaveType",
                value: "Unpaid Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0089-0000-01da0000318a"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Annual Leave", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-008a-0000-01dc0000318b"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-008b-0000-01de0000318c"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-008c-0000-01d00000318d"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-008e-0000-01d40000318f"),
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-008f-0000-01d600003190"),
                column: "Status",
                value: "Approved");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0090-0000-01e800003191"),
                column: "Status",
                value: "Rejected");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0091-0000-01ea00003192"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0092-0000-01ec00003193"),
                column: "LeaveType",
                value: "Sick Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0093-0000-01ee00003194"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0094-0000-01e000003195"),
                column: "LeaveType",
                value: "Unpaid Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0095-0000-01e200003196"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Annual Leave", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0096-0000-01e400003197"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0097-0000-01e600003198"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0098-0000-01f800003199"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-0099-0000-01fa0000319a"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-009a-0000-01fc0000319b"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-009b-0000-01fe0000319c"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Work From Home", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-009c-0000-01f00000319d"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-009d-0000-01f20000319e"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-009e-0000-01f40000319f"),
                column: "LeaveType",
                value: "Sick Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-009f-0000-01f6000031a0"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a0-0000-0188000031a1"),
                column: "LeaveType",
                value: "Unpaid Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a1-0000-018a000031a2"),
                column: "Status",
                value: "Approved");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a2-0000-018c000031a3"),
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a4-0000-0180000031a5"),
                column: "Status",
                value: "Rejected");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a5-0000-0182000031a6"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a6-0000-0184000031a7"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a7-0000-0186000031a8"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Work From Home", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a8-0000-0198000031a9"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00a9-0000-019a000031aa"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00aa-0000-019c000031ab"),
                column: "LeaveType",
                value: "Sick Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00ab-0000-019e000031ac"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00ac-0000-0190000031ad"),
                column: "LeaveType",
                value: "Unpaid Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00ad-0000-0192000031ae"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Annual Leave", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00ae-0000-0194000031af"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00af-0000-0196000031b0"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b0-0000-01a8000031b1"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b1-0000-01aa000031b2"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b2-0000-01ac000031b3"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b3-0000-01ae000031b4"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Work From Home", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b4-0000-01a0000031b5"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00b9-0000-01ba000031ba"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Annual Leave", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00ba-0000-01bc000031bb"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00bb-0000-01be000031bc"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00bc-0000-01b0000031bd"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00bd-0000-01b2000031be"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00be-0000-01b4000031bf"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00bf-0000-01b6000031c0"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Work From Home", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c0-0000-0148000031c1"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c1-0000-014a000031c2"),
                column: "LeaveType",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c2-0000-014c000031c3"),
                column: "LeaveType",
                value: "Sick Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c3-0000-014e000031c4"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c4-0000-0140000031c5"),
                column: "LeaveType",
                value: "Unpaid Leave");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c5-0000-0142000031c6"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Annual Leave", "Approved" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c6-0000-0144000031c7"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c7-0000-0146000031c8"),
                column: "LeaveType",
                value: "Work From Home");

            migrationBuilder.UpdateData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: new Guid("000000c8-0000-00c8-0000-0158000031c9"),
                columns: new[] { "LeaveType", "Status" },
                values: new object[] { "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0002-0000-032e00003365"),
                columns: new[] { "DaysUsed", "Employee", "Status" },
                values: new object[] { 20, "Sorawit Thongchai", "Approved" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0003-0000-032c00003366"),
                columns: new[] { "DaysUsed", "Employee" },
                values: new object[] { 10, "Sorawit Thongchai" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0004-0000-032200003367"),
                columns: new[] { "DaysUsed", "Employee" },
                values: new object[] { 50, "Sorawit Thongchai" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0005-0000-032000003368"),
                columns: new[] { "Employee", "LeaveType", "Status" },
                values: new object[] { "Sorawit Thongchai", "Work From Home", "Approved" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0006-0000-032600003369"),
                columns: new[] { "Employee", "Status" },
                values: new object[] { "Duangjai Chantana", "Rejected" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0007-0000-03240000336a"),
                columns: new[] { "DaysUsed", "Employee", "Status" },
                values: new object[] { 30, "Duangjai Chantana", "Rejected" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0008-0000-033a0000336b"),
                columns: new[] { "DaysUsed", "Employee", "Status" },
                values: new object[] { 20, "Duangjai Chantana", "Rejected" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0009-0000-03380000336c"),
                columns: new[] { "DaysUsed", "Employee", "LeaveType", "Status" },
                values: new object[] { 10, "Duangjai Chantana", "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-000a-0000-033e0000336d"),
                columns: new[] { "DaysUsed", "Employee", "LeaveType", "Status" },
                values: new object[] { 50, "Duangjai Chantana", "Unpaid Leave", "Rejected" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-000b-0000-033c0000336e"),
                columns: new[] { "Employee", "Status" },
                values: new object[] { "Warisa Chawengchai", "Pending" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-000c-0000-03320000336f"),
                columns: new[] { "DaysUsed", "Employee" },
                values: new object[] { 10, "Warisa Chawengchai" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-000d-0000-033000003370"),
                columns: new[] { "Employee", "LeaveType" },
                values: new object[] { "Warisa Chawengchai", "Sick Leave" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-000e-0000-033600003371"),
                columns: new[] { "DaysUsed", "LeaveType", "Status" },
                values: new object[] { 40, "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-000f-0000-033400003372"),
                columns: new[] { "DaysUsed", "Employee", "LeaveType", "Status" },
                values: new object[] { 30, "Warisa Chawengchai", "Sick Leave", "Pending" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0010-0000-030a00003373"),
                columns: new[] { "DaysUsed", "Employee", "LeaveType", "Status" },
                values: new object[] { 10, "Nattawat Dechapanya", "Annual Leave", "Approved" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0011-0000-030800003374"),
                column: "DaysUsed",
                value: 50);

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0012-0000-030e00003375"),
                columns: new[] { "DaysUsed", "Employee" },
                values: new object[] { 40, "Nattawat Dechapanya" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0013-0000-030c00003376"),
                columns: new[] { "DaysUsed", "Employee", "Status" },
                values: new object[] { 30, "Nattawat Dechapanya", "Approved" });

            migrationBuilder.UpdateData(
                table: "ReportLeaves",
                keyColumn: "Id",
                keyValue: new Guid("0000032a-0000-0014-0000-030200003377"),
                columns: new[] { "DaysUsed", "Employee", "Status" },
                values: new object[] { 20, "Nattawat Dechapanya", "Approved" });
        }
    }
}

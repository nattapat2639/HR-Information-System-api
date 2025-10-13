using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hris.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeFieldDefinitions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAtUtc",
                table: "WorkforcePlanEntries",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SessionDate",
                table: "TrainingSessions",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SubmittedOn",
                table: "TrainingRequests",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "TrainingProgress",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "TrainingProgress",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAtUtc",
                table: "SystemConfigurations",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastReviewedAtUtc",
                table: "SecuritySettings",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RunAtUtc",
                table: "SecurityAuditLogs",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "LeaveRequests",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RequestedOn",
                table: "LeaveRequests",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "LeaveRequests",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ResolvedAtUtc",
                table: "HeadcountRequests",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RequestedAtUtc",
                table: "HeadcountRequests",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OpenDate",
                table: "EngagementSurveys",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CloseDate",
                table: "EngagementSurveys",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HiredAt",
                table: "Employees",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.CreateTable(
                name: "EmployeeFieldDefinitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FieldKey = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    DisplayName = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    DataType = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    IsRequired = table.Column<bool>(type: "boolean", nullable: false),
                    Category = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeFieldDefinitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeFieldOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FieldDefinitionId = table.Column<Guid>(type: "uuid", nullable: false),
                    Label = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeFieldOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeFieldOptions_EmployeeFieldDefinitions_FieldDefiniti~",
                        column: x => x.FieldDefinitionId,
                        principalTable: "EmployeeFieldDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeFieldValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    FieldDefinitionId = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    UpdatedAtUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedBy = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeFieldValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeFieldValues_EmployeeFieldDefinitions_FieldDefinitio~",
                        column: x => x.FieldDefinitionId,
                        principalTable: "EmployeeFieldDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeFieldValues_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EmployeeFieldDefinitions",
                columns: new[] { "Id", "Category", "DataType", "Description", "DisplayName", "FieldKey", "IsActive", "IsRequired", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("00000370-0000-0001-0000-0372000033aa"), "Personal", "text", "Official full name used on contracts and payslips.", "Legal full name", "personal.full_name", true, true, 1 },
                    { new Guid("00000370-0000-0002-0000-0374000033ab"), "Personal", "date", "Employee birth date for eligibility and benefits checks.", "Date of birth", "personal.birth_date", true, false, 2 },
                    { new Guid("00000370-0000-0003-0000-0376000033ac"), "Employment", "select", "Owning department within the organisation structure.", "Department", "job.department", true, true, 10 },
                    { new Guid("00000370-0000-0004-0000-0378000033ad"), "Employment", "select", "Career level aligned to the company job framework.", "Job level", "job.job_level", true, false, 11 },
                    { new Guid("00000370-0000-0005-0000-037a000033ae"), "Employment", "select", "Indicates if the employee is full-time, contract, or intern.", "Employment type", "job.employment_type", true, true, 12 }
                });

            migrationBuilder.InsertData(
                table: "EmployeeFieldOptions",
                columns: new[] { "Id", "FieldDefinitionId", "Label", "SortOrder", "Value" },
                values: new object[,]
                {
                    { new Guid("00000371-0000-0001-0000-0373000033ab"), new Guid("00000370-0000-0003-0000-0376000033ac"), "People Operations", 1, "People Operations" },
                    { new Guid("00000371-0000-0002-0000-0375000033ac"), new Guid("00000370-0000-0003-0000-0376000033ac"), "Technology", 2, "Technology" },
                    { new Guid("00000371-0000-0003-0000-0377000033ad"), new Guid("00000370-0000-0003-0000-0376000033ac"), "Finance", 3, "Finance" },
                    { new Guid("00000371-0000-0004-0000-0379000033ae"), new Guid("00000370-0000-0003-0000-0376000033ac"), "Marketing", 4, "Marketing" },
                    { new Guid("00000371-0000-0005-0000-037b000033af"), new Guid("00000370-0000-0003-0000-0376000033ac"), "Customer Success", 5, "Customer Success" },
                    { new Guid("00000371-0000-0006-0000-037d000033b0"), new Guid("00000370-0000-0003-0000-0376000033ac"), "Operations", 6, "Operations" },
                    { new Guid("00000371-0000-0007-0000-037f000033b1"), new Guid("00000370-0000-0003-0000-0376000033ac"), "Sales", 7, "Sales" },
                    { new Guid("00000371-0000-0008-0000-0361000033b2"), new Guid("00000370-0000-0003-0000-0376000033ac"), "Data & Analytics", 8, "Data & Analytics" },
                    { new Guid("00000371-0000-0009-0000-0363000033b3"), new Guid("00000370-0000-0004-0000-0378000033ad"), "Junior", 1, "Junior" },
                    { new Guid("00000371-0000-000a-0000-0365000033b4"), new Guid("00000370-0000-0004-0000-0378000033ad"), "Mid", 2, "Mid" },
                    { new Guid("00000371-0000-000b-0000-0367000033b5"), new Guid("00000370-0000-0004-0000-0378000033ad"), "Senior", 3, "Senior" },
                    { new Guid("00000371-0000-000c-0000-0369000033b6"), new Guid("00000370-0000-0004-0000-0378000033ad"), "Lead", 4, "Lead" },
                    { new Guid("00000371-0000-000d-0000-036b000033b7"), new Guid("00000370-0000-0004-0000-0378000033ad"), "Director", 5, "Director" },
                    { new Guid("00000371-0000-000e-0000-036d000033b8"), new Guid("00000370-0000-0005-0000-037a000033ae"), "Full-time", 1, "Full-time" },
                    { new Guid("00000371-0000-000f-0000-036f000033b9"), new Guid("00000370-0000-0005-0000-037a000033ae"), "Contract", 2, "Contract" },
                    { new Guid("00000371-0000-0010-0000-0351000033ba"), new Guid("00000370-0000-0005-0000-037a000033ae"), "Intern", 3, "Intern" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeFieldValues",
                columns: new[] { "Id", "EmployeeId", "FieldDefinitionId", "UpdatedAtUtc", "UpdatedBy", "Value" },
                values: new object[,]
                {
                    { new Guid("00000372-0000-0001-0000-0370000033ac"), new Guid("00000064-0000-0001-0000-00660000309e"), new Guid("00000370-0000-0001-0000-0372000033aa"), new DateTime(2025, 3, 12, 4, 15, 0, 0, DateTimeKind.Utc), "People Operations", "Anan Techakul" },
                    { new Guid("00000372-0000-0002-0000-0376000033ad"), new Guid("00000064-0000-0001-0000-00660000309e"), new Guid("00000370-0000-0002-0000-0374000033ab"), new DateTime(2025, 3, 12, 4, 15, 0, 0, DateTimeKind.Utc), "People Operations", "1991-05-18" },
                    { new Guid("00000372-0000-0003-0000-0374000033ae"), new Guid("00000064-0000-0001-0000-00660000309e"), new Guid("00000370-0000-0003-0000-0376000033ac"), new DateTime(2025, 3, 12, 4, 15, 0, 0, DateTimeKind.Utc), "People Operations", "Technology" },
                    { new Guid("00000372-0000-0004-0000-037a000033af"), new Guid("00000064-0000-0001-0000-00660000309e"), new Guid("00000370-0000-0004-0000-0378000033ad"), new DateTime(2025, 3, 12, 4, 15, 0, 0, DateTimeKind.Utc), "People Operations", "Senior" },
                    { new Guid("00000372-0000-0005-0000-0378000033b0"), new Guid("00000064-0000-0001-0000-00660000309e"), new Guid("00000370-0000-0005-0000-037a000033ae"), new DateTime(2025, 3, 12, 4, 15, 0, 0, DateTimeKind.Utc), "People Operations", "Full-time" },
                    { new Guid("00000372-0000-0006-0000-037e000033b1"), new Guid("00000064-0000-0002-0000-00600000309f"), new Guid("00000370-0000-0001-0000-0372000033aa"), new DateTime(2025, 3, 11, 7, 0, 0, 0, DateTimeKind.Utc), "People Operations", "Suchada Pradchaphet" },
                    { new Guid("00000372-0000-0007-0000-037c000033b2"), new Guid("00000064-0000-0002-0000-00600000309f"), new Guid("00000370-0000-0002-0000-0374000033ab"), new DateTime(2025, 3, 11, 7, 0, 0, 0, DateTimeKind.Utc), "People Operations", "1993-11-02" },
                    { new Guid("00000372-0000-0008-0000-0362000033b3"), new Guid("00000064-0000-0002-0000-00600000309f"), new Guid("00000370-0000-0003-0000-0376000033ac"), new DateTime(2025, 3, 11, 7, 0, 0, 0, DateTimeKind.Utc), "People Operations", "Operations" },
                    { new Guid("00000372-0000-0009-0000-0360000033b4"), new Guid("00000064-0000-0002-0000-00600000309f"), new Guid("00000370-0000-0004-0000-0378000033ad"), new DateTime(2025, 3, 11, 7, 0, 0, 0, DateTimeKind.Utc), "People Operations", "Lead" },
                    { new Guid("00000372-0000-000a-0000-0366000033b5"), new Guid("00000064-0000-0002-0000-00600000309f"), new Guid("00000370-0000-0005-0000-037a000033ae"), new DateTime(2025, 3, 11, 7, 0, 0, 0, DateTimeKind.Utc), "People Operations", "Full-time" },
                    { new Guid("00000372-0000-000b-0000-0364000033b6"), new Guid("00000064-0000-0003-0000-0062000030a0"), new Guid("00000370-0000-0001-0000-0372000033aa"), new DateTime(2025, 3, 10, 9, 30, 0, 0, DateTimeKind.Utc), "People Operations", "Korn Kittiphob" },
                    { new Guid("00000372-0000-000c-0000-036a000033b7"), new Guid("00000064-0000-0003-0000-0062000030a0"), new Guid("00000370-0000-0003-0000-0376000033ac"), new DateTime(2025, 3, 10, 9, 30, 0, 0, DateTimeKind.Utc), "People Operations", "People Operations" },
                    { new Guid("00000372-0000-000d-0000-0368000033b8"), new Guid("00000064-0000-0003-0000-0062000030a0"), new Guid("00000370-0000-0004-0000-0378000033ad"), new DateTime(2025, 3, 10, 9, 30, 0, 0, DateTimeKind.Utc), "People Operations", "Lead" },
                    { new Guid("00000372-0000-000e-0000-036e000033b9"), new Guid("00000064-0000-0003-0000-0062000030a0"), new Guid("00000370-0000-0005-0000-037a000033ae"), new DateTime(2025, 3, 10, 9, 30, 0, 0, DateTimeKind.Utc), "People Operations", "Contract" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeFieldDefinitions_FieldKey",
                table: "EmployeeFieldDefinitions",
                column: "FieldKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeFieldOptions_FieldDefinitionId",
                table: "EmployeeFieldOptions",
                column: "FieldDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeFieldValues_EmployeeId_FieldDefinitionId",
                table: "EmployeeFieldValues",
                columns: new[] { "EmployeeId", "FieldDefinitionId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeFieldValues_FieldDefinitionId",
                table: "EmployeeFieldValues",
                column: "FieldDefinitionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeFieldOptions");

            migrationBuilder.DropTable(
                name: "EmployeeFieldValues");

            migrationBuilder.DropTable(
                name: "EmployeeFieldDefinitions");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAtUtc",
                table: "WorkforcePlanEntries",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SessionDate",
                table: "TrainingSessions",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SubmittedOn",
                table: "TrainingRequests",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "TrainingProgress",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "TrainingProgress",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAtUtc",
                table: "SystemConfigurations",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastReviewedAtUtc",
                table: "SecuritySettings",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RunAtUtc",
                table: "SecurityAuditLogs",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "LeaveRequests",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RequestedOn",
                table: "LeaveRequests",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "LeaveRequests",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ResolvedAtUtc",
                table: "HeadcountRequests",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RequestedAtUtc",
                table: "HeadcountRequests",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OpenDate",
                table: "EngagementSurveys",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CloseDate",
                table: "EngagementSurveys",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HiredAt",
                table: "Employees",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");
        }
    }
}

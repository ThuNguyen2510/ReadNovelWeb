using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComicAPI.Migrations
{
    public partial class initt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answer",
                keyColumn: "ID",
                keyValue: 1,
                column: "AnswerTime",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 549, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Answer",
                keyColumn: "ID",
                keyValue: 2,
                column: "AnswerTime",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 550, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Answer",
                keyColumn: "ID",
                keyValue: 3,
                column: "AnswerTime",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 550, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Answer",
                keyColumn: "ID",
                keyValue: 4,
                column: "AnswerTime",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 550, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 1,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 2,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 3,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 4,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 5,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 6,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 7,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 8,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 9,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 10,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 11,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 12,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 1,
                column: "CommentTime",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 548, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 2,
                column: "CommentTime",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 548, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 3,
                column: "CommentTime",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 548, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 4,
                column: "CommentTime",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 548, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 5,
                column: "CommentTime",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 549, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 6,
                column: "CommentTime",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 549, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 7,
                column: "CommentTime",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 549, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 1,
                column: "PostTime",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 549, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 2,
                column: "PostTime",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 549, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 3,
                column: "PostTime",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 549, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 4,
                column: "PostTime",
                value: new DateTime(2019, 12, 9, 23, 41, 10, 549, DateTimeKind.Local).AddTicks(5512));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answer",
                keyColumn: "ID",
                keyValue: 1,
                column: "AnswerTime",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 227, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Answer",
                keyColumn: "ID",
                keyValue: 2,
                column: "AnswerTime",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 228, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "Answer",
                keyColumn: "ID",
                keyValue: 3,
                column: "AnswerTime",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 228, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Answer",
                keyColumn: "ID",
                keyValue: 4,
                column: "AnswerTime",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 228, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 1,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 224, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 2,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 224, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 3,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 224, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 4,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 224, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 5,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 224, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 6,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 224, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 7,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 224, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 8,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 224, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 9,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 224, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 10,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 224, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 11,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 224, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 12,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 224, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 1,
                column: "CommentTime",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 225, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 2,
                column: "CommentTime",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 225, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 3,
                column: "CommentTime",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 225, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 4,
                column: "CommentTime",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 225, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 5,
                column: "CommentTime",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 225, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 6,
                column: "CommentTime",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 226, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 7,
                column: "CommentTime",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 226, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 1,
                column: "PostTime",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 226, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 2,
                column: "PostTime",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 226, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 3,
                column: "PostTime",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 226, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 4,
                column: "PostTime",
                value: new DateTime(2019, 12, 4, 10, 59, 15, 226, DateTimeKind.Local).AddTicks(8486));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComicAPI.Migrations
{
    public partial class reset2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answer",
                keyColumn: "ID",
                keyValue: 1,
                column: "AnswerTime",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 856, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "Answer",
                keyColumn: "ID",
                keyValue: 2,
                column: "AnswerTime",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 857, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Answer",
                keyColumn: "ID",
                keyValue: 3,
                column: "AnswerTime",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 857, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Answer",
                keyColumn: "ID",
                keyValue: 4,
                column: "AnswerTime",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 857, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 1,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 854, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 2,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 855, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 3,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 855, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 4,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 855, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 5,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 855, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 6,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 855, DateTimeKind.Local).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 7,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 855, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 8,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 855, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 9,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 855, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 10,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 855, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 11,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 855, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 12,
                column: "Update_time",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 855, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 1,
                column: "CommentTime",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 855, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 2,
                column: "CommentTime",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 856, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 3,
                column: "CommentTime",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 856, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 4,
                column: "CommentTime",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 856, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 5,
                column: "CommentTime",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 856, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 6,
                column: "CommentTime",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 856, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 7,
                column: "CommentTime",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 856, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 1,
                column: "PostTime",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 856, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 2,
                column: "PostTime",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 856, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 3,
                column: "PostTime",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 856, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 4,
                column: "PostTime",
                value: new DateTime(2019, 12, 4, 10, 49, 39, 856, DateTimeKind.Local).AddTicks(6054));
        }
    }
}

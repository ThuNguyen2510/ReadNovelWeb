using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComicAPI.Migrations
{
    public partial class reset3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answer",
                keyColumn: "ID",
                keyValue: 1,
                column: "AnswerTime",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 24, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Answer",
                keyColumn: "ID",
                keyValue: 2,
                column: "AnswerTime",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 24, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Answer",
                keyColumn: "ID",
                keyValue: 3,
                column: "AnswerTime",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 24, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Answer",
                keyColumn: "ID",
                keyValue: 4,
                column: "AnswerTime",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 24, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 1,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 21, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 2,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 22, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 3,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 22, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 4,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 22, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 5,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 22, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 6,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 22, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 7,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 22, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 8,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 22, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 9,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 22, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 10,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 22, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 11,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 22, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 12,
                column: "Update_time",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 22, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 1,
                column: "CommentTime",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 22, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 2,
                column: "CommentTime",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 23, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 3,
                column: "CommentTime",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 23, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 4,
                column: "CommentTime",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 23, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 5,
                column: "CommentTime",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 23, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 6,
                column: "CommentTime",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 23, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 7,
                column: "CommentTime",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 23, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 1,
                column: "PostTime",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 23, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 2,
                column: "PostTime",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 23, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 3,
                column: "PostTime",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 23, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 4,
                column: "PostTime",
                value: new DateTime(2019, 12, 9, 14, 40, 19, 23, DateTimeKind.Local).AddTicks(9527));
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

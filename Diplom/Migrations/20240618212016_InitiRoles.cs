using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Diplom.Migrations
{
    /// <inheritdoc />
    public partial class InitiRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                """ insert into "AspNetRoles"("Id","Name") values ('1','admin'),('2','editor'),('3','banned')"""
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                  """DELETE FROM "AspNetRoles" where "Id"="1" or "Id"="2" or "Id"="3" """
              );
        }
    }
}

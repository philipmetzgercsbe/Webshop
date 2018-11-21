using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class Products : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserID" },
                values: new object[,]
                {
                    { "6b55b147-7fa1-4ef3-b3eb-38aa6bcc0e12", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 10L },
                    { "14a695e7-e7b5-4ad9-b2cd-6084247031e9", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 8L },
                    { "1b3438d6-7fcb-4cf4-b94c-8d9c8de07ec5", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 7L },
                    { "df72fc9b-ecfb-461b-8033-1478c4946be7", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 6L },
                    { "5d966aba-9236-41c2-ae26-ff7589347669", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 5L },
                    { "194455a6-8916-435b-8e29-deda1fc8b6db", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 4L },
                    { "36a731d3-1174-44e3-9e99-7db6a0a80d27", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 3L },
                    { "0685782e-7179-4c9b-a629-ca316988c726", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 2L },
                    { "af3716e4-52fb-4d1b-b9ae-dcaa77fc43e3", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 1L },
                    { "16763d1b-1d19-4a73-909f-e8b063287814", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 9L }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CartID", "Description", "Imagepath", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 10L, null, "Dolor laboriosam vero distinctio dolorem. Veniam quidem alias magnam. Labore nulla consequuntur qui laboriosam quia. Rem vel illo necessitatibus aut. Illum ab fuga eius dolor ut velit consequuntur. Sint non quae ea.", "http://lorempixel.com/640/480/abstract", "et", 121.0275218030566, 432 },
                    { 8L, null, "quo", "http://lorempixel.com/640/480/cats", "sit", 117.93435276669186, 322 },
                    { 7L, null, "ex", "http://lorempixel.com/640/480/fashion", "dignissimos", 28.953637773615142, 70 },
                    { 6L, null, "Aut aut sed itaque est laudantium consequatur iure et aliquid.", "http://lorempixel.com/640/480/sports", "architecto", 219.91063452600997, 554 },
                    { 5L, null, "In eum aliquid sapiente placeat facere sapiente odio.", "http://lorempixel.com/640/480/nightlife", "aut", 124.73273135476407, 710 },
                    { 4L, null, "Voluptatem vel minus et molestiae atque qui fugiat. Consequatur ut molestias voluptates. Enim architecto repellendus optio aliquam asperiores iste. Eveniet voluptas explicabo qui veniam temporibus sit. Repellat sapiente qui iste id possimus harum quia.", "http://lorempixel.com/640/480/animals", "maxime", 118.35278564056046, 901 },
                    { 3L, null, "Voluptatem error rerum molestiae necessitatibus quaerat in.", "http://lorempixel.com/640/480/food", "ad", 15.746378233538184, 828 },
                    { 2L, null, "Ducimus odio inventore sunt rerum id officiis aut. Est voluptatibus beatae eos pariatur perferendis corrupti. Porro nostrum amet illo.", "http://lorempixel.com/640/480/abstract", "eos", 35.206429959370958, 363 },
                    { 9L, null, "Officiis deleniti delectus ad nam ut. Optio rerum quo eveniet et. Praesentium repellat vitae adipisci. Eum eius qui mollitia consequatur. Eius omnis voluptatem harum aut eveniet numquam.", "http://lorempixel.com/640/480/food", "ipsa", 170.41591704237084, 452 },
                    { 1L, null, @"Aut ex minima nostrum commodi aut.
                Eligendi atque inventore repellendus voluptas in minus.
                Neque aliquam dolor doloribus.
                Ex magnam molestias ut aut tempora qui enim.
                Molestiae et quam ab alias ut in.", "http://lorempixel.com/640/480/city", "commodi", 211.25242488936169, 690 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "0685782e-7179-4c9b-a629-ca316988c726", null });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "14a695e7-e7b5-4ad9-b2cd-6084247031e9", null });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "16763d1b-1d19-4a73-909f-e8b063287814", null });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "194455a6-8916-435b-8e29-deda1fc8b6db", null });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1b3438d6-7fcb-4cf4-b94c-8d9c8de07ec5", null });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "36a731d3-1174-44e3-9e99-7db6a0a80d27", null });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5d966aba-9236-41c2-ae26-ff7589347669", null });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "6b55b147-7fa1-4ef3-b3eb-38aa6bcc0e12", null });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "af3716e4-52fb-4d1b-b9ae-dcaa77fc43e3", null });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "df72fc9b-ecfb-461b-8033-1478c4946be7", null });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10L);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Migrations
{
    public partial class Product : Migration
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
                    { "cc420bdf-effc-4008-9ab4-e1cdc9318633", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 10L },
                    { "8e3606a2-d003-4214-ba4e-8c967b0aa77c", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 8L },
                    { "7ba11371-d534-4845-81de-2fae62511701", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 7L },
                    { "29fb7e0d-f262-4cab-b9f8-fcd0aedf6e48", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 6L },
                    { "efef457f-beb4-4a74-a5dd-8bf2697eca19", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 5L },
                    { "89f9d899-e8d7-40de-8d31-4dd227ffa274", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 4L },
                    { "c9d75fa5-5a5a-4093-a873-5a6a62b0df40", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 3L },
                    { "ea83daab-29b4-49fa-a822-42cb261a1bb2", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 2L },
                    { "02242f97-8030-4ccc-9f87-12a9060e7a0b", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 1L },
                    { "ef785964-a67f-472f-a222-d38d9be773c8", 0, null, "User", null, true, false, null, null, null, null, null, true, null, false, null, 9L }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CartID", "Description", "Imagepath", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 10L, null, @"Maiores non libero dolorem ipsam.
                Error amet nulla praesentium eveniet in sit eos ducimus.
                Harum numquam quas numquam architecto dolorem.
                Aliquid corporis commodi voluptas.
                Accusantium iure voluptas rerum nostrum adipisci.
                Autem possimus rerum.", "http://lorempixel.com/640/480/nature", "Gorgeous Rubber Gloves", 98.682133154795565, 646 },
                    { 8L, null, "deserunt", "http://lorempixel.com/640/480/fashion", "Practical Concrete Chicken", 60.387473651388419, 278 },
                    { 7L, null, @"Aspernatur at laboriosam repellendus est dolorem deserunt laudantium libero facilis.
                Voluptatem provident est quia rerum quam omnis.
                Minima eum natus.
                Rem dolores pariatur numquam ut nulla laboriosam.", "http://lorempixel.com/640/480/cats", "Small Plastic Keyboard", 230.49904216150708, 978 },
                    { 6L, null, "ea", "http://lorempixel.com/640/480/nature", "Incredible Wooden Shirt", 14.312676217552589, 768 },
                    { 5L, null, @"Odio quibusdam sint omnis qui recusandae earum.
                Et vero et maiores.
                Sequi rem sit iste aut.
                Et ducimus iste vel.", "http://lorempixel.com/640/480/cats", "Rustic Fresh Keyboard", 240.98328850650381, 447 },
                    { 4L, null, "Labore sapiente ut qui sapiente est architecto quasi. Quas unde voluptatem deserunt mollitia enim est cupiditate cupiditate. Mollitia possimus aliquam officia placeat. Dolor dolores aut eveniet eaque inventore doloribus facilis et voluptatem.", "http://lorempixel.com/640/480/nature", "Refined Metal Shoes", 241.01873246255272, 619 },
                    { 3L, null, "Occaecati provident autem at enim est sit quasi maiores illum.", "http://lorempixel.com/640/480/cats", "Licensed Frozen Computer", 28.57124506895023, 151 },
                    { 2L, null, @"Nisi in cum consequatur cupiditate recusandae asperiores qui ab.
                Occaecati quae adipisci ea adipisci dolorem fuga quidem dolores at.
                Doloremque fuga ut exercitationem sed fugit rerum doloribus adipisci dolore.
                Voluptatem velit et.
                Officia distinctio id quod necessitatibus veniam tenetur.", "http://lorempixel.com/640/480/business", "Sleek Concrete Towels", 139.83749050965415, 506 },
                    { 9L, null, @"Beatae ut nihil impedit impedit voluptatum et.
                Sed nisi et nostrum.", "http://lorempixel.com/640/480/abstract", "Handmade Metal Fish", 218.88078772876446, 952 },
                    { 1L, null, "quo", "http://lorempixel.com/640/480/nightlife", "Unbranded Cotton Chair", 46.184450600847811, 453 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "02242f97-8030-4ccc-9f87-12a9060e7a0b", null });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "29fb7e0d-f262-4cab-b9f8-fcd0aedf6e48", null });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7ba11371-d534-4845-81de-2fae62511701", null });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "89f9d899-e8d7-40de-8d31-4dd227ffa274", null });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "8e3606a2-d003-4214-ba4e-8c967b0aa77c", null });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c9d75fa5-5a5a-4093-a873-5a6a62b0df40", null });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "cc420bdf-effc-4008-9ab4-e1cdc9318633", null });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ea83daab-29b4-49fa-a822-42cb261a1bb2", null });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ef785964-a67f-472f-a222-d38d9be773c8", null });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "efef457f-beb4-4a74-a5dd-8bf2697eca19", null });

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

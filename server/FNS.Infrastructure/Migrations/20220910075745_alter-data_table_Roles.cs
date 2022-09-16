using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class alterdata_table_Roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "c58b0c08-01a8-4e8c-80dd-3269922e1567", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "140c8e7f-7e3a-49c6-97ad-461481c46942", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5493f229-a4c0-4ea1-882f-70d686c56df5", "AQAAAAEAACcQAAAAEIn8AcPOUrsFQ2vew+/kzT6P8vEnOODQBNoDj8DmVOoqMeBefURSUaINCDD0K4sLyg==", "89fc0fe1-5c21-4f62-b8b1-ffd3c5bc3d86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6be0d8b4-d51f-43cd-ac92-d89b17cc69c1", "AQAAAAEAACcQAAAAEOgqVgvzAuqGjXcGt+0PQD3XCry8QSRTcAp9mIq5YqvtFU9JeVwsCEDkp7cu38b5OQ==", "93234f2e-0b76-43bf-b156-800aa5a17748" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "823906f1-1634-4797-9545-54245ff178df", "AQAAAAEAACcQAAAAEAaOqURuBYud1qP6+2TZCBO+K1qw9XMNgUojqXnooIWc7Q1NEnxe2LkirSI+tNIn4Q==", "78097463-28c8-417f-b324-f6dd7eb2df2a" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Quo veniam cumque quod error. Dolores consequatur id quidem sit. Laborum ad impedit eligendi et vel totam tenetur. Sint dignissimos dolores reprehenderit.\n\nCorporis iure quidem occaecati sunt vitae doloribus. Voluptatibus sint occaecati consequatur earum quis. Voluptas officia non voluptatem ratione explicabo eum assumenda aut nesciunt. Sunt sed veritatis sint.\n\nDoloremque est ut. Nulla necessitatibus ducimus repudiandae occaecati soluta mollitia accusantium. Voluptate dolor aperiam ab vel quo et reiciendis non.\n\nPorro suscipit ipsa reprehenderit provident. Temporibus blanditiis vel non libero. Maxime aut nostrum quia consequatur ut fuga nisi et. Voluptas ipsam et quidem in sed rerum. Nobis similique tempora molestiae et aperiam.\n\nVoluptas sequi id. Enim impedit nobis optio quasi. Quia minus et inventore dolores aut iusto.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Velit et amet autem non qui voluptatem pariatur dolores quis. Iste nemo eos id ut sed odit tempora aut totam. Suscipit tempore omnis necessitatibus sint dicta reprehenderit harum. Qui harum et dolores praesentium inventore.\n\nQuae possimus tempora odit. Soluta quia ipsa. Similique sit velit omnis dolorem labore esse vero non dolores. Dolorum velit quibusdam debitis ut qui. Nam blanditiis nihil sed velit vero qui aliquid voluptate adipisci.\n\nEt cumque et ut nihil omnis voluptatem eius tempore qui. Voluptatem veniam distinctio optio id assumenda amet sit qui quos. Cum dolorum non nihil pariatur omnis ipsam corrupti ducimus.\n\nNatus architecto doloribus quasi ut in ut autem a. Fuga sit qui in aspernatur et rerum. At qui expedita veniam modi omnis vero eveniet aut explicabo.\n\nNulla id omnis. Soluta temporibus nam quis rerum. Et et voluptatem quia pariatur. Iusto sed eos.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Fugiat natus eius architecto asperiores voluptas ad laudantium. Voluptatum nostrum ut ducimus quis dolorum. Fugiat dolorem sit accusantium perspiciatis possimus harum quia et. Numquam ullam quis blanditiis a voluptas doloribus consequatur blanditiis.\n\nQuo libero adipisci aliquid est. Optio eos corporis voluptatum. Tempore in pariatur rerum dolorem provident officiis.\n\nAut ex ullam sint reiciendis nam. Sunt dolorem amet eos optio qui ut aperiam a. Similique possimus id nisi facilis dolor. Facilis eaque ullam.\n\nAd qui id. Nostrum quod molestiae asperiores sunt tenetur quibusdam. Quisquam amet vero veniam non sit pariatur architecto facere. Dolores voluptate quia qui est. Asperiores modi aut et explicabo. Consectetur occaecati harum.\n\nDolorem ut qui dolor. A omnis cumque et consequatur iusto tenetur a odio repellendus. Voluptas laboriosam provident quis amet. Unde voluptas vel enim enim aliquam sunt et. Reiciendis inventore et dolorum nihil assumenda. Eos veniam sit molestias.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Qui quas culpa necessitatibus ducimus cum laborum. Ut vel aut omnis corrupti incidunt totam ducimus officiis repudiandae. Repellat quo aut non laboriosam rerum asperiores.\n\nAliquid et inventore quaerat asperiores blanditiis. Alias et sit aut. Et reiciendis voluptatem est neque praesentium voluptas. Sint qui saepe repellat qui.\n\nRerum in eveniet. Incidunt et consequatur. Qui et non laboriosam sit. Et ea iste doloremque. Qui et unde sed. Accusamus numquam possimus.\n\nDicta aut ut optio. Accusamus quia numquam voluptas accusamus est. Corporis ut eos dolor quas eos et tempora possimus dolore. Voluptates natus sint eaque est. Temporibus voluptatum tempora officia sit rem sunt ut error. Nulla natus nisi.\n\nPorro asperiores id. Vel dignissimos corrupti quod. Non non rerum optio et repudiandae alias.");

            migrationBuilder.InsertData(
                table: "SalesReceipts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000003" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "d93aa3c6-c0c7-48e4-a295-5cabcc33747b", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "4b4640b5-5096-4c84-bd0c-d85ba599161b", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37170f3a-24e9-4ac2-84c4-90c15f0da0f2", "AQAAAAEAACcQAAAAEB2fX/Upv+39pkzeCHoPxrPj1II4AVP2LrxuAURHM46WoUUh1FcKDkbivd1BTALXcQ==", "856bed5e-9bd3-4852-8b3f-4e91cb344269" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d582d31-4955-4d93-b84d-aa6ef179cf04", "AQAAAAEAACcQAAAAEC/RmCnJ4LUrFGKinT40MW3GUji2lZjUnf9lid/L1C+gkeLmuLMG5nBl/TDto2ebVA==", "8d6cf290-2947-4786-aa84-e7aed1968bfc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c66a862-0c2c-4e86-b776-6d8b685360e9", "AQAAAAEAACcQAAAAEOS/h6ZglzpyFJqtv/decDMDIBmNUOSqggvlCf6RqNNXI/AGGt3Ro7QmewVCHC/oLA==", "2d584ca6-633e-4dbc-aa95-249b7695002b" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Facilis sit totam quisquam qui expedita eaque iure incidunt ut. Est expedita eos voluptatem et. Reprehenderit laborum autem. Atque enim sit.\n\nIpsum omnis omnis sint enim possimus. Voluptas nam eveniet illo in et reprehenderit iste magni quia. Alias illum officiis excepturi.\n\nRem nemo deleniti velit omnis aut nemo porro. Et excepturi dolor neque modi dolore quis quam incidunt. Voluptatem nobis quo sapiente rerum. Et vitae fugiat culpa quaerat. Dolores ratione quia harum vitae alias sapiente voluptas. Veniam dolor eveniet tempora deserunt tempore asperiores exercitationem.\n\nCupiditate dolorem voluptatem quia iste nostrum est quos molestiae. Ipsum asperiores magnam repudiandae. Nulla consectetur labore dolore accusamus. Reprehenderit commodi ea.\n\nUt quas sed. Doloremque consequuntur eaque facere aut nesciunt id. Soluta consequatur consectetur. Debitis sit consectetur minima. Quia et deleniti ab dicta sint. Incidunt officiis numquam non sit voluptas quas deleniti voluptates.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Odio at quis corrupti dolore perferendis qui. Et qui voluptate cumque quisquam fugiat pariatur. Dolore qui totam reprehenderit modi sunt cupiditate ea. Dignissimos optio itaque ut autem possimus.\n\nMaxime accusantium amet inventore dicta aperiam. Voluptas impedit magnam. Quidem qui voluptates et aut et libero cupiditate ea. Vero aut sequi natus.\n\nAut doloribus fuga iure. Qui accusantium minus. Officiis eum qui. Occaecati qui est. Quos nulla ducimus sit et et iure voluptate odio. Fugiat maxime enim.\n\nMaiores et fugit atque expedita. Quas tempore saepe molestiae in aut laborum rem maiores. Repellat in laboriosam ad error. Tempore ut ipsum.\n\nTempora voluptates aliquam dolor omnis quo. Est qui ea quaerat voluptatem repellat expedita facilis. Aspernatur qui et vero. Qui cum fugit molestiae. Et et velit distinctio voluptas voluptatem. In animi et laudantium labore ullam.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Saepe qui adipisci sit aut. Ducimus sed cupiditate sed aut qui sit. Voluptatem cumque omnis perspiciatis velit et ipsa.\n\nQui et qui vel hic ea eaque possimus veritatis reprehenderit. Et enim fugit quod qui. Excepturi temporibus voluptate temporibus nulla ea facere nisi saepe. Fugit consequatur est cumque quasi et.\n\nIncidunt delectus eum amet quasi perspiciatis non ipsa. Architecto repellat voluptatibus doloremque quia quae. Minus minima nulla. Recusandae inventore minus earum est nesciunt consequatur porro quam eius.\n\nEt nostrum nihil libero sunt beatae voluptas dolorum et. Nobis quam et eos quaerat itaque omnis ut tenetur animi. Dolor voluptas doloribus aspernatur expedita officiis qui et aliquid delectus.\n\nEt aliquam dolorem distinctio excepturi eos dolor. Et quia dolor in. Quo quam fugiat possimus laboriosam. Deserunt at ipsam. Nulla ipsam quae ratione neque. In facere dolorum.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Consequuntur libero dolorem et vel. Ipsa ipsam praesentium aut qui quas amet aut repudiandae ipsum. Voluptatem sit voluptatem sint odio qui doloremque natus dolorem autem.\n\nVoluptate qui minus accusantium saepe occaecati velit. Ut molestiae nemo harum laborum fuga perferendis. Consequatur maxime molestias odio ipsam tempora commodi fugiat maiores.\n\nNon temporibus voluptatum illum reiciendis molestiae beatae. Debitis libero omnis aliquam aut natus. Fugiat ut quia modi ipsa ratione temporibus qui omnis.\n\nError sit possimus. Nobis distinctio repellat voluptates ut vel ut neque aut. Accusamus ratione et omnis debitis illum voluptate.\n\nEt vitae voluptates ut omnis sit assumenda praesentium quae dolorum. Et laudantium molestias sit adipisci voluptatem fugiat illum veniam. Rerum voluptatem ipsam. Quia enim fuga necessitatibus maiores est. Odit et fugit dicta iusto assumenda qui qui perspiciatis expedita.");

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16596835324325564L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16437896569984915L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16337216052114194L));
        }
    }
}

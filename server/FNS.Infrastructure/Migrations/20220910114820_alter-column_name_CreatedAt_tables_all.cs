using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class altercolumn_name_CreatedAt_tables_all : Migration
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

            migrationBuilder.AddColumn<Instant>(
                name: "CreatedAt",
                table: "SubCategories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<Instant>(
                name: "CreatedAt",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<Instant>(
                name: "CreatedAt",
                table: "ProductAttributeValues",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<Instant>(
                name: "CreatedAt",
                table: "ProductAttributes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "205f112b-447d-412a-82a4-0a83ccd285b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "5c22ebfb-ddf4-4bb0-a8f2-0ddc952e9594");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b90c4ffa-381f-4f21-9331-5539d0b9adf9", "AQAAAAEAACcQAAAAEBR/1shOo/nkUtRyMuExBS1TdU2HmTv9FB1MFXds7bbP4xlQjA5slNVYgTfan77WRQ==", "0c849343-d011-4707-93b8-490f14296f10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a63bc00-d445-4daa-9dd6-a1c1354ed89e", "AQAAAAEAACcQAAAAEPG485VBHZisdDQxQAzPcRD3f/kQqvuvJDrZc8ZA92ZzMJKu/xIWVYlxfgVzMVM7NA==", "f030f409-ffdb-4394-80f8-acf57373327f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "788101fc-c4af-4425-8b92-503ceb2afe7f", "AQAAAAEAACcQAAAAEMpZ/SwcieJ8jTVaB9H1rmfbs2p7hxuvRs4Hyv/ypFUA3LeL1tYdazjxCn+Tv8r2hw==", "907af006-32a7-4f84-a704-fd4961b2ae9c" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Sunt enim facere et a inventore et dicta sed voluptate. Natus repellat aut beatae necessitatibus laboriosam temporibus repudiandae ea. Explicabo in enim quisquam blanditiis ea quia.\n\nEt impedit accusantium at culpa ut non et. Inventore quia maiores quia tempora provident accusantium est eum. Aliquid voluptates eos.\n\nPerspiciatis consectetur sit tempore tenetur placeat illo. Maxime rerum quos perspiciatis ipsa dicta veritatis doloribus. Iste et sed sint consectetur molestias sint ab quam et. Ut hic quia est expedita.\n\nRerum iusto asperiores fugiat veritatis. Soluta dolorem exercitationem deleniti et nesciunt et sunt id. Error quibusdam quasi est repellendus expedita libero nobis molestiae pariatur. Ipsam eaque aut sed corrupti. Atque consectetur ut dignissimos error. Nemo sit dicta iusto ut corrupti.\n\nDolor fugit ut dolor architecto est. Repellendus consequatur et rem velit itaque. Perspiciatis magni id commodi voluptatem.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Et mollitia sit ea iure voluptas provident quia et. Voluptatem rem quae id dolor ipsum nulla et debitis qui. Nulla repudiandae sed odio quasi dolor accusamus illo est odit. Quia est incidunt eveniet. Quis ut ullam odit.\n\nIusto ratione asperiores iste rerum provident temporibus aut beatae et. Qui laborum voluptatem quia ut et et rerum omnis. Error laborum et id laboriosam voluptatem.\n\nSed laboriosam officiis sed dolores. Optio magni culpa. Dolor provident modi vel ducimus est.\n\nDignissimos similique explicabo enim quia qui. Et rerum aut vel accusantium. Nemo ut voluptatem eaque perferendis ut repellendus quasi amet ab. Non id omnis totam. Inventore soluta eligendi.\n\nNulla corrupti saepe sequi repudiandae ullam repellat architecto. Qui odit est et qui deserunt necessitatibus eum in. A rem veniam iusto. Rem et aliquam officiis. Consectetur quaerat fugit.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Sequi dolorum sunt nisi. Dolorem velit hic et ut ipsam aut aut enim. Et earum nam. Quod aut voluptatem laborum quia incidunt excepturi veritatis autem saepe. Omnis molestias rem eaque repudiandae minima et.\n\nEt enim explicabo natus molestias quam. Ratione aut autem voluptate fugit. At amet id sed.\n\nAut nisi rerum sapiente ut ipsum pariatur repellat nihil. Est itaque suscipit cupiditate beatae aut sunt. Velit earum qui autem porro soluta itaque magnam in illum. Aperiam atque consectetur fuga labore eligendi aut. Aperiam quia eius vitae corrupti minima. Consequatur rerum sapiente.\n\nDebitis vel ea cum quas. Quibusdam a hic recusandae. Occaecati ipsam iure sit animi praesentium beatae dolorem rerum earum.\n\nConsequatur ut est quibusdam omnis natus consectetur est nulla. Explicabo libero assumenda saepe. Laudantium totam qui occaecati voluptas. Corporis explicabo corrupti repudiandae recusandae ut nihil sint cumque quo.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Nulla in molestias voluptas sed a velit dolorem pariatur. Nemo molestiae praesentium quod ipsam minima ab. Doloremque ea dolor optio est quo. Beatae nostrum est assumenda ipsa atque facere deleniti voluptatem.\n\nNeque nihil iure eligendi et et officia ad voluptas voluptatem. Consequatur quis enim omnis voluptatem quia qui quos. Aut dolore recusandae eum officia veritatis culpa autem et vel. A quis modi sit fuga. Natus vel dolorum. Facilis ut iure laborum optio reprehenderit veritatis.\n\nAut non deserunt voluptatem repudiandae voluptatem illo quo sit. Enim perferendis illum. Tempora quidem amet. Placeat eius quidem doloremque aut. Voluptatem officiis fuga nulla praesentium.\n\nConsequatur cum eum eos. Possimus reprehenderit similique ut corrupti. Dolores ut inventore.\n\nConsequatur numquam neque aut minus iusto totam. Eius quisquam iure fuga id molestias. Repellendus pariatur et est earum sit voluptatibus.");

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
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductAttributeValues");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductAttributes");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "c58b0c08-01a8-4e8c-80dd-3269922e1567");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "140c8e7f-7e3a-49c6-97ad-461481c46942");

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

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16609151994002877L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16596398220169783L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16330842986236876L));
        }
    }
}

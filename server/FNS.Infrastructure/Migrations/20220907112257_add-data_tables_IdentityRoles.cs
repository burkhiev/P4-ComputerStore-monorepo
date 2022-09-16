using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class adddata_tables_IdentityRoles : Migration
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a7298e95-bc14-418f-8c6b-a457fd37bf8f", "a6707839-fcc4-45b5-8967-449c0d8d7906", "user", null },
                    { "abeb0007-caf8-47e7-91e2-52c1858c3256", "0262be59-f74b-4d03-b5aa-b0f5eb1c08da", "admin", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f21e2784-4907-4118-854d-c970838d3c5a", "AQAAAAEAACcQAAAAEJQLISaWKjmUMR0BdahCEc3q9/odmljTMUdlVhM3ooI6AW8rhGN8Ngv4wzHcsKMMrQ==", "2b54fcd3-b8e3-4079-b0cc-6cd8d19ad7da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed69ec48-89e8-4c82-ab05-f8caf9140f22", "AQAAAAEAACcQAAAAEAJvpljFvvzcrj4J1f3HDJUJ+y9EM8+jE5NYa3eYBkdv1pw9d7wEnnMPb7jFFyZF3A==", "66b4e980-0b2f-412c-bbf7-99392ceaa626" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1db105f4-28e7-45a7-958a-f41c99989143", "AQAAAAEAACcQAAAAEBhg3j4Pxmh+9EV2Bg6MdqrsLcAjglh8S8pJcSG++zErO3gciC3BnyAkVyCoJm726Q==", "9c7487ab-7002-4c6b-aac9-10d86d02de2c" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Architecto aliquid facere officiis excepturi facere dolorem error. Qui omnis totam ex dolorum voluptas sit. Id illo tempora.\n\nRepellendus placeat provident quo nobis facilis ratione. Accusantium quidem praesentium rerum est. Molestiae quasi dolor quibusdam accusamus et et. Blanditiis laborum labore quisquam molestiae blanditiis non accusantium. Ipsum hic tempore velit id laboriosam recusandae dolorum. Asperiores in quo sequi.\n\nQuibusdam adipisci delectus nisi. Ut enim culpa vel. Totam unde ipsum in in. Aut voluptatem ratione assumenda velit maiores qui id dolor. Ut id a voluptates et voluptatibus.\n\nPlaceat voluptates laboriosam dolorem. Molestiae ut blanditiis laudantium voluptatem omnis quod esse. Ut id quo et. Atque unde recusandae ea quos odio.\n\nEum quia totam possimus placeat amet deleniti. Rem ea molestiae. Consequatur quia quos ex rerum voluptatem occaecati. Dolorem corrupti iure deserunt fugit esse.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Iste illum est ad voluptas provident laboriosam. Vel omnis ut. Dolor ea suscipit repellat explicabo molestiae animi velit. Cupiditate aut sit quod dolorem debitis sed praesentium.\n\nEst eius rerum unde voluptatem magni dolore voluptate. Reiciendis fuga voluptatibus molestiae dolor quaerat. Illum aut qui nostrum autem culpa qui.\n\nError iusto nisi ut est ut rerum assumenda necessitatibus. Repellendus illum corrupti voluptatem et quia qui qui dolorem. Debitis consequatur amet vero quae voluptatem. Et repellendus nam et nemo incidunt.\n\nRerum velit qui consequatur et provident inventore. Omnis necessitatibus eligendi. Sint explicabo velit molestiae et quis.\n\nAssumenda quo iusto est corrupti et. Earum et adipisci quia molestiae provident facilis. Mollitia voluptatibus atque voluptatem adipisci quo sit. Placeat non nesciunt neque voluptatum. Mollitia harum reiciendis commodi at aut earum mollitia voluptatem.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Cum perspiciatis aperiam odit ut. Debitis et officia. Officia est id. Et atque quibusdam ratione assumenda ad est et hic ab. Et dolorem sit et similique. Voluptatem maxime consectetur quia occaecati dolores architecto voluptatem sit.\n\nVoluptatem tenetur aperiam ab. Numquam aut harum. Blanditiis nihil quis non atque nisi id. Deleniti aut ducimus rerum. Ut dolorem doloremque nihil sunt sed sint.\n\nDolorem quis harum cum incidunt vitae nesciunt. Esse optio praesentium aut voluptas modi iure sunt illum praesentium. At dignissimos sed consequuntur hic est libero dolor.\n\nMolestiae quidem nam. Doloremque et ut quos inventore nemo provident id. Adipisci temporibus eius tempora et nisi accusantium. Facilis ab aut perferendis doloribus sit.\n\nHarum ab nisi aliquid optio quia non asperiores iste. Accusamus est culpa. Dolorum perferendis officia et possimus aut ab autem placeat. Magni laudantium a ut animi quasi et modi.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Eos praesentium enim voluptates quas consequatur et non perferendis. Rerum et autem esse omnis. Molestias veniam vel fuga quos aut aut soluta. Eius placeat corporis laboriosam.\n\nEos totam maiores recusandae maiores voluptate expedita. Distinctio cupiditate quos quod qui cumque optio. Voluptatibus nostrum dolor id aut est rem. Consectetur nemo beatae consequatur dolores quis.\n\nLibero sit et tenetur fugiat vero earum. Et soluta rerum aut et voluptates veniam. Maiores illo voluptate et accusamus vero adipisci non sapiente velit. Officia quia non aperiam eligendi alias expedita minima.\n\nNostrum nihil non voluptas corporis vel soluta. Enim alias culpa qui. Quidem at cumque aliquid. Voluptatibus ut porro et. Iusto nisi nulla.\n\nOptio dolores qui sit error velit quam. Et molestiae similique odio necessitatibus est et non. Iste molestiae modi omnis in debitis blanditiis est deserunt. Et explicabo aliquam voluptatem dolores.");

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
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7298e95-bc14-418f-8c6b-a457fd37bf8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abeb0007-caf8-47e7-91e2-52c1858c3256");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a44fc20e-5f21-4d10-8ef8-d60962e2b3fe", "AQAAAAEAACcQAAAAEA6eMYAzr4KAvg2gMZBZ0hHbRLIlCDr24uo9DkaJJDM3FZa8HxnWpY2ORPdKLtfQLg==", "968126b1-5ab9-4da2-98d2-65b886179ec7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25d78d53-3a88-49b6-a488-f13aee510c13", "AQAAAAEAACcQAAAAEH4t1svXbpckWqGRQI5bk3PtbaEvhScITyoogbAtv2YBEA7JsmcHrq4wU/uU6Fb5qQ==", "41aeca7f-242d-4257-b236-6593193ec020" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0a1e5f7-4532-46f5-acc3-1fc493fd9162", "AQAAAAEAACcQAAAAEKOHlBgxujPC6qUDprdhPZ2KuhJZJE/U13sCyHSoCrUsdyrH0p0ksGBOW0gnkSsTVQ==", "31176904-5e70-446a-8d29-f36ce68a2730" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Voluptatem quis aspernatur. Vitae quia et. Id sapiente possimus delectus earum et. Odio quia qui ut et praesentium quis.\n\nQui facilis explicabo maxime qui dolor quas labore molestias. Fugit accusantium neque temporibus iure. Enim nemo soluta exercitationem. Et eligendi laboriosam ut sit voluptatum. Eum consequatur ut quisquam. Cumque eum eos voluptatem dignissimos accusantium ea quod.\n\nAut qui quod magni laborum suscipit tempore mollitia. Atque adipisci error quo. Modi neque autem. Quia tenetur qui voluptas excepturi aut saepe reiciendis beatae laboriosam.\n\nMagni in qui ut deleniti earum quidem. Et harum vel veritatis eligendi unde voluptatem deleniti voluptas blanditiis. Est cumque esse est dolores voluptatem qui. Repellat dolorum laborum id est molestiae aperiam odio et officia.\n\nAut quod ut. Deleniti libero sint ut repellendus. Illo nulla sint officia et.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Vel aut et adipisci est hic fugiat. Qui excepturi officiis itaque. Unde dolorum aut. Voluptas atque dignissimos soluta soluta. Ea soluta voluptate vel distinctio illum laudantium. Accusamus fugit officia nobis impedit magnam.\n\nUt autem perferendis sed in. Et ducimus explicabo temporibus et autem. Sint explicabo omnis corrupti voluptate dicta. Ab eos ullam consequatur dolores vero rerum ad iure. Dolor soluta provident aut dignissimos consequatur.\n\nMagni quis ex a deleniti asperiores. Molestias ad deleniti ut repudiandae aut. Eos exercitationem qui eum omnis. Nobis voluptatem quas a animi excepturi distinctio velit unde voluptatem.\n\nDebitis expedita velit nihil facere minima est optio error. Mollitia voluptas illum eum aut. Inventore distinctio doloremque.\n\nDebitis explicabo blanditiis atque aliquid in esse. Libero maiores aperiam aut voluptate consequatur dolorem. Rerum nihil veniam. Sit odio deserunt enim sed mollitia nihil. Id officia eum.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Non modi temporibus consequuntur voluptatem. Molestiae rerum et dolorem illo saepe natus est. Quo aut molestiae doloribus. Rerum fugiat saepe. Ab consectetur inventore nostrum.\n\nIure magni iste. Sint reprehenderit amet. Eveniet nobis rem qui ut distinctio quibusdam distinctio dolorem magni.\n\nNemo molestiae iste similique. Nulla nulla veritatis est. Dignissimos ut illum est ad. Omnis qui rerum dolor dolorem dicta et in. Laudantium deserunt eligendi cum et iusto quasi deserunt corrupti doloribus. Debitis recusandae tempora debitis quas ut quo non impedit quibusdam.\n\nMollitia eum est suscipit eligendi a ut accusantium nobis rerum. Autem porro est. Eum ex dolore.\n\nAb quisquam illo quasi atque numquam eum ducimus exercitationem delectus. Perferendis quaerat facere officiis corporis. Dicta at sunt placeat alias eum ut. Perspiciatis sit voluptatibus odio ea. Expedita aperiam ut laborum ut voluptatem amet voluptas.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Blanditiis illum voluptatum est praesentium accusantium voluptas asperiores. Esse dolore nihil alias. Accusantium excepturi aut voluptates fugit voluptas.\n\nQuia minus est aut eos ratione. Dolor et est. Qui soluta autem id nihil. Consequuntur unde quia laboriosam incidunt voluptatem similique. Rerum sequi eligendi vel doloribus rem voluptates corporis ut. Ut animi eaque aperiam sit facilis quia.\n\nEt hic fugiat reprehenderit rerum. Ea repudiandae tempora eos. Eligendi omnis architecto deleniti facilis explicabo.\n\nDebitis in eum. Tempora voluptatem in sed. Corrupti ut eligendi quo est repudiandae nulla perspiciatis. Voluptate vero accusamus voluptatem accusantium aut et rerum.\n\nRerum saepe non similique excepturi laudantium similique quis. Nobis id quo. Id animi quia. Ex a inventore nesciunt eius autem.");

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16447290872532468L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16341581641508424L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16581017530114842L));
        }
    }
}

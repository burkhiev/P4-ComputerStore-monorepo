using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class updatelastmigration2 : Migration
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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a44fc20e-5f21-4d10-8ef8-d60962e2b3fe", "USER1@GMAIL.RU", "USER1", "AQAAAAEAACcQAAAAEA6eMYAzr4KAvg2gMZBZ0hHbRLIlCDr24uo9DkaJJDM3FZa8HxnWpY2ORPdKLtfQLg==", "968126b1-5ab9-4da2-98d2-65b886179ec7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25d78d53-3a88-49b6-a488-f13aee510c13", "USER2@GMAIL.RU", "USER2", "AQAAAAEAACcQAAAAEH4t1svXbpckWqGRQI5bk3PtbaEvhScITyoogbAtv2YBEA7JsmcHrq4wU/uU6Fb5qQ==", "41aeca7f-242d-4257-b236-6593193ec020" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0a1e5f7-4532-46f5-acc3-1fc493fd9162", "ADMIN@YANDEX.RU", "ADMIN", "AQAAAAEAACcQAAAAEKOHlBgxujPC6qUDprdhPZ2KuhJZJE/U13sCyHSoCrUsdyrH0p0ksGBOW0gnkSsTVQ==", "31176904-5e70-446a-8d29-f36ce68a2730" });

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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45ff29e3-1bbe-489a-a4bb-6d42709629db", null, null, null, "b207506f-70c4-4018-9eaf-9366e2a11ef7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3316ceea-3d52-415d-9e3b-54bde842ab82", null, null, null, "941211cf-4828-4523-81ab-ea96cb6b5b9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f15b76d-fb05-4b66-a616-3468f967832d", null, null, null, "aa29f9f8-aa0a-4d53-97e2-a9047e7b19b1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Fugit sed magnam ut praesentium ipsam odit dolorem earum. Sapiente sunt impedit hic sit quis dolores enim necessitatibus nulla. Animi laboriosam iure reiciendis odio.\n\nNobis aut dicta quos est fugiat et. Et sint aut quae numquam. Ad distinctio officia veritatis qui pariatur minus. Sed sunt qui voluptatem reprehenderit tempora iure amet sapiente sint.\n\nHarum occaecati ipsa exercitationem sed. Aut quo quasi cum eum nihil. Impedit facilis voluptate et velit. Rem accusamus voluptates.\n\nAutem aliquid nam rerum enim qui repellendus est omnis facilis. Rem sunt ducimus doloribus eum totam incidunt nihil architecto modi. Omnis non iste dolor quisquam a. Vitae sapiente ipsam laborum sed voluptas. Reiciendis quisquam minus iste repudiandae. Qui eos ipsam omnis aut est et fugiat.\n\nLaborum repudiandae id qui eos maiores. Quis a et ab voluptatem suscipit sit molestiae repudiandae molestiae. Velit consequatur aut sit atque esse. Quia et facilis corrupti.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Excepturi quo quae minus voluptas aperiam cum laborum consectetur unde. Architecto quidem et. Libero dolor quia. Deleniti beatae impedit. Sit aperiam qui voluptas atque aut fuga quo.\n\nAutem modi aut voluptatem. Rem qui maxime consequatur et voluptas et ipsa in. Porro accusamus perspiciatis voluptatem est rerum velit.\n\nEaque perferendis minima est similique aliquid aut qui eaque. Provident aut aperiam qui culpa dolore. Nostrum explicabo adipisci et maiores quo deserunt est.\n\nIn ex ut optio voluptate quis rerum. Repudiandae pariatur voluptate exercitationem doloremque in. Et quidem quia consequatur labore laudantium fugiat culpa. Et ut delectus laborum magni veritatis adipisci. Odit mollitia beatae earum. Voluptate accusamus commodi aut.\n\nSed hic suscipit facere commodi. Nobis dolore perferendis sit. Sit natus sunt. Molestiae ut ad odit.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Rerum in culpa aliquid aut magnam. Voluptas libero praesentium maiores eaque omnis ut tempore. Saepe cupiditate ea eos.\n\nOdio cum id dolorem laudantium adipisci omnis. A et non laboriosam nisi earum. Optio quo et voluptatem dolores. Iusto tempore et.\n\nPerspiciatis nemo voluptatibus nulla. Esse nulla deleniti aut numquam consequatur veritatis. Laboriosam repudiandae qui pariatur voluptates id veritatis voluptas sunt minus. Impedit necessitatibus laborum sed et quaerat eaque sunt expedita. Ratione accusantium tenetur hic necessitatibus ut qui dolor.\n\nPerspiciatis fugiat blanditiis qui recusandae explicabo aliquam. Quo ad vel quas. Magnam ut voluptas impedit provident magnam tempore quae veniam est.\n\nAut cum quia perspiciatis eveniet eum facilis necessitatibus. Dolor quia eos accusamus eum consequuntur sed. Ut aperiam facilis quasi mollitia minus ut est. Commodi dolores qui. Perferendis deleniti quibusdam quisquam dolores dolorem soluta illo beatae. Esse velit qui vel.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Iure et fuga atque sapiente. Eius facere numquam minima pariatur officiis. Aperiam consequatur voluptate commodi molestias doloribus facilis.\n\nCumque et expedita ut. Consectetur ratione quisquam dolorem eum voluptatem. Alias quam facere similique omnis reprehenderit ut quo perferendis. Non minima id cumque repudiandae autem. Beatae unde enim quis enim repellendus.\n\nEt est deleniti inventore illo aut odit. Ut velit assumenda quia corporis. Sunt est rerum quis qui dignissimos.\n\nQuod temporibus fugit necessitatibus distinctio ut adipisci. Vel in aut. Et molestiae ut quo rem sint eaque.\n\nVitae labore dolorem tenetur aperiam. Id fugiat dolor quis aperiam sed quia. Autem quas qui deleniti tempora dolorem reprehenderit fugiat sit.");

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16558197937296512L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16393931456335860L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16594587692418792L));
        }
    }
}

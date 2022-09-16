using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class altertable__tablesProducts_SubCategories__addcolumnImgPath : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "ImgPath",
                table: "SubCategories",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgPath",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "7d245ddb-2020-44d5-a9b9-40e44955e258");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "b26d7768-71ea-4e79-a66c-d1752962a63c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39242ded-0d49-4049-bea5-54e0406dc827", "AQAAAAEAACcQAAAAEHiLWC3SaGsVmICB0WU/A40ZSGvkstQhG8Wcja98Pz799AFtHcHhXayQR2cTu1L/zA==", "de1abddd-7776-4e00-afb4-40dd0ab11bad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e50e15b8-2d48-4a46-87d2-e3eda39bf947", "AQAAAAEAACcQAAAAEOQrR1DJOXvv1s0sXOrarfJmRUIP2kMPbBDwbIaAXngjzGWDTMt6QVjoFvrzPlkUNA==", "8368de91-621f-4940-ae7f-404c3da6a5a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48797ca3-942e-403a-a670-d26dfad8de6f", "AQAAAAEAACcQAAAAEAzFEReO3ut6E+33hllob0BFmFPXnILNOVveTo3Af0uXX7fC0kZUwuehLPjy96vCMQ==", "d4493504-5efc-4c71-a957-0244a86a9005" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Qui quasi qui et quis maxime animi. Velit accusamus voluptatem sint fugit sunt. Totam est tenetur nobis a dolore consequatur quia consectetur. Soluta est qui.\n\nEt est natus nihil enim rerum. Nihil id commodi in quod similique tenetur doloremque. In et aut sit rerum aspernatur. Deleniti eveniet voluptas. Sit perspiciatis beatae.\n\nNam et et. Est qui ducimus aut aut reiciendis. Dicta cumque eligendi aliquid qui. Dolores ut id amet aut officiis rerum autem alias. Inventore saepe expedita nemo doloremque assumenda illum. Aut voluptas vero.\n\nPraesentium voluptatum et cum. Hic deserunt ut rerum optio beatae. Laborum sapiente quia ad iusto natus. Optio est inventore accusantium. Rem nihil ea doloribus eum. Debitis beatae error vitae dignissimos cupiditate magnam.\n\nConsequatur aliquid adipisci. Optio saepe magni fugiat soluta neque. Esse iure voluptatem velit. Non aliquam qui quasi nihil vitae nesciunt laboriosam consequatur. Totam occaecati illum est tenetur rerum. Tempora a ipsam.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Maxime ipsa excepturi voluptatem ducimus deserunt. Hic doloremque qui dolores corrupti. Aut eveniet sapiente provident pariatur nihil eum. Consequuntur quos quo ut. Dolore ab sint possimus maxime distinctio et impedit.\n\nFuga ea est expedita. Dolorem quod tempora repellendus et similique. Quasi quidem est voluptas officia est. Quaerat veniam nihil ut tempora tenetur incidunt vero atque.\n\nSit rem error nemo doloribus eaque molestiae in maxime. Quisquam vel qui omnis assumenda aspernatur voluptas et reiciendis ut. Quo rerum nam non ullam eius eius. Corporis exercitationem vitae.\n\nModi corrupti et eaque amet explicabo. Velit aut animi quaerat dolorum minus nobis. Qui neque nemo architecto molestiae error et minima.\n\nConsectetur autem eum molestiae enim tempore qui minus. Tempore eligendi libero rerum unde modi consectetur. Id doloribus eligendi.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Possimus quia voluptatem porro dolorum impedit et illo. Nesciunt facere odit odit alias. Est esse labore. Ullam error rerum aut.\n\nPlaceat ipsam consequuntur maxime consectetur officiis dolor esse magni. Et et et libero reiciendis dolor quaerat. Cumque aliquam soluta doloremque. Est sed molestiae. Cum voluptatem eius accusantium. Non perspiciatis saepe sunt suscipit enim.\n\nIpsa reprehenderit dolores rem tempore modi commodi optio amet. Illum quia voluptatem quod id corporis qui qui qui. Et odit doloremque illum.\n\nConsequatur explicabo aliquam error quasi sit. Ab dolor vero nobis cumque rem quia optio. Aut sequi aliquam. Rem voluptate repellendus voluptates eius qui quis. Perspiciatis qui in officia incidunt quo sit magnam. Porro vel qui tempora dolores et corrupti.\n\nNisi cupiditate hic qui aut. Consequatur sunt et sit mollitia dolorem sapiente. Dignissimos recusandae quod facere aut. Optio quia enim aut illo iste. In officia excepturi omnis repellendus. Qui dolor est repudiandae.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Nemo expedita et esse quam distinctio. Eaque maxime expedita officiis non aliquid. Et aut dolorem. Est inventore tempore voluptatem et.\n\nEarum aut fugit aperiam aspernatur. Et autem non necessitatibus porro ut est vel reprehenderit facere. Et consequatur est quis qui id. Tempora excepturi ex expedita. Est ducimus et.\n\nNecessitatibus maxime qui distinctio consequuntur rerum eum officiis. Quia expedita temporibus animi. Autem laborum aut sit similique eos quis repudiandae ex qui. Dignissimos qui ut sunt harum corporis earum aut dignissimos.\n\nIste non voluptates voluptatem. Sit voluptas perferendis omnis. Facilis consequatur sequi. Eos at laborum iste vel ut adipisci omnis incidunt consequatur.\n\nOdio unde id enim. Facilis quis in fugiat doloremque necessitatibus voluptate quia. Non id qui ut maiores est qui ratione numquam sunt.");

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
                name: "ImgPath",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "ImgPath",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "eaf44339-7526-461d-909a-d909f6ebfdf6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "3328c008-8b8c-40c3-be86-4787b3f8d3f3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6891078-0eb8-4586-89a3-4dd4fbf18913", "AQAAAAEAACcQAAAAEJ9WTlKMiX0Gf73CCUD0+8nTgWrGA/thnXVHJUD4XW4dWi7I2ULXm67oBQewMTkkQA==", "e0d81d84-c467-433e-bfa8-9a181a464e1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a64999b-3fa3-4db8-84b8-47b3cde4d962", "AQAAAAEAACcQAAAAECF5MYhD7goDfuvfDOoXqt1RPnyW08b4Y6lvq9y//dfxe0Rg41U1gWi0fEJPl7znGQ==", "872a4f85-1984-452c-aadd-ae1a519f66c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68e4c0cc-7d94-479b-abe1-2f53f3e9db0d", "AQAAAAEAACcQAAAAEHoy2SekRNEvVWx5Rpf+8Ftr9i9MIeq6TH8naEl8X3Ev6oq/EFJ64uBuCGH4MIkUGQ==", "d7ecb5c5-765e-4b5b-be4b-943fb12cfed3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Facere reprehenderit consequatur quia vel recusandae quos. Exercitationem sint commodi ad ut et. Nam non voluptate et et sint et hic qui. Quia natus inventore adipisci dolorem dolorem ut quod deleniti.\n\nCorporis in beatae sed ea non non quae maiores. Et officiis molestias quis dignissimos. Blanditiis dolores officia et amet quidem odit est illo.\n\nOmnis illum voluptatem. Repudiandae dignissimos eligendi harum minima ducimus exercitationem enim. Voluptatem quos id voluptatibus.\n\nNon ut ut. Molestiae porro eum. Dolor consequatur dolorum blanditiis.\n\nDistinctio odit fugiat maiores rerum. Sunt ea aspernatur dolores minima consequatur dignissimos dolorem et velit. Incidunt ad vero id enim. Est sunt molestiae qui hic. Sit asperiores numquam saepe quia dolores neque et. Qui ut sunt blanditiis quae quo qui dolore sed.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Nostrum quod dolor porro quas sit porro consequuntur veritatis voluptatem. Voluptas dolore architecto enim qui. Doloremque accusantium debitis soluta explicabo architecto ad natus. Aliquid ea corrupti quia et.\n\nHic blanditiis molestias tenetur dolores laudantium numquam odio dolorem ut. Numquam earum ea. Voluptatum odit magni minus qui corrupti ducimus.\n\nVoluptatem quam possimus accusamus maiores. Quibusdam dolorem dolorum distinctio. Ipsum aliquid quam quisquam. Iure doloremque labore rerum qui quae. Incidunt quos sequi modi.\n\nRerum omnis laboriosam omnis maxime quisquam. Dolorum beatae possimus. Ducimus modi aut quia sunt non. Cum ut iure aut ut sit et. Voluptas tenetur impedit. Velit numquam officiis et harum.\n\nInventore dolorem consequuntur ut et debitis quasi. Repudiandae assumenda a. Doloremque et reiciendis reiciendis sed id asperiores impedit voluptatem voluptatem.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Id doloribus ea. Facilis expedita eligendi et sint sit voluptas corrupti autem placeat. Suscipit similique non. Quia aspernatur voluptatum.\n\nPlaceat eaque aliquam distinctio assumenda. Rerum voluptates voluptatem architecto voluptatem atque. Quos non quis. Sit impedit magnam amet facere sit ut dolore aut.\n\nEligendi architecto non repellat eum. Voluptas delectus nemo quidem provident voluptatem. Suscipit repellendus consequatur magni quia maiores voluptatem.\n\nQuia in fuga officia. Rem itaque aliquam. Eos totam aut laudantium voluptatem ut numquam molestiae ut. Adipisci aperiam qui voluptatum quam eos enim consectetur.\n\nOccaecati ut perferendis. Incidunt excepturi id ipsam doloribus cupiditate. Quis autem laboriosam dolores sequi aut quis in. Qui consequuntur hic.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Est eius recusandae autem deserunt laboriosam sapiente. Nostrum adipisci sequi sed et illum. Enim corporis aut laboriosam voluptas. Itaque aut dolorem temporibus assumenda quasi eaque et. Omnis reprehenderit perspiciatis.\n\nItaque et sint. Dolorem dolorem nostrum. Aut perferendis iure.\n\nA eligendi et. Dolorem et aspernatur accusamus occaecati fugit nisi. Harum a totam sapiente. Voluptatem facilis consectetur distinctio eaque labore et quis.\n\nSed vel quia facere. Cum beatae autem at adipisci cupiditate asperiores. Nisi aliquid autem sequi earum itaque eligendi velit consequatur nisi. Necessitatibus quaerat illo pariatur.\n\nSaepe officia velit et. Qui ut delectus et ad. Aut est quos rerum et quibusdam consequatur officia. Et aut eos magnam et impedit porro. Delectus cupiditate voluptatum. Sunt ut et molestiae saepe ut et recusandae.");

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16534685963348209L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16425828711395056L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16492493310662871L));
        }
    }
}

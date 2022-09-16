using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class altertables_IdentityRoles_IdentityUserRoles : Migration
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
                column: "ConcurrencyStamp",
                value: "d93aa3c6-c0c7-48e4-a295-5cabcc33747b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "4b4640b5-5096-4c84-bd0c-d85ba599161b");

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
                column: "ConcurrencyStamp",
                value: "2584f3b5-3ffe-4a14-a62e-808df96ca222");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "61f7409e-8fa2-4d24-bbdf-cb3ad2cf87ac");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46ae2710-99c3-4e06-bf10-d8f3654da2ce", "AQAAAAEAACcQAAAAEC8AZVqj59hkZFBDkSU8cLoT/Ke1LnSLf3jBUP7suVpmWisHYJhbon3fM74hz7gG6w==", "606be663-2233-47da-8233-d18b4aa8b7fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "081d99fe-7488-41fa-91c8-003a3e90e148", "AQAAAAEAACcQAAAAEGOsliabFEitspBxiLWg/7bWUIn/FJjps/ct3G+nMtr4RvCgl2+BA+gGiSPOvU5YPw==", "c19a3db2-56e5-4ab2-8160-3f96339f9214" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09a4a8bf-0663-41e8-8867-db2b3b941abf", "AQAAAAEAACcQAAAAENKA8D7GXsmmxWUDJ1szouzkn3wHMeQe5+jk/irRDGJZWuAQA4zVIaAJL30rp+BsVw==", "d70d3306-a27c-42e9-a301-44186c06af85" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Possimus et error rem. Est magnam laudantium ipsum. Praesentium distinctio sed dicta.\n\nEum cumque eveniet rem voluptatibus voluptatem consequuntur et. Aut numquam repellat sit omnis. Sapiente incidunt corporis.\n\nIpsam aut porro sed et et corrupti. Aut quo iusto quasi tempora nulla et adipisci est alias. Illo voluptatem eius dolor excepturi earum soluta neque officiis facilis. Hic cumque et aspernatur libero deleniti nisi iste.\n\nConsequuntur qui hic non in beatae cum omnis. Omnis ut cupiditate id sit. Quia et omnis repellendus. Magni quia error quisquam suscipit amet velit illum distinctio. Quo quas nisi consequatur natus consequuntur veritatis.\n\nUnde voluptatibus nemo incidunt dolor. Ipsum voluptatibus laboriosam. Voluptas ex nisi neque voluptas perferendis. Autem est magni aperiam velit corrupti praesentium. Asperiores labore est. Consequatur vel delectus officia dolorem suscipit autem adipisci voluptatem.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Non quia sunt iure dicta asperiores itaque corporis voluptatem. Similique et sed corrupti velit dolores eaque dolorem. Voluptatem unde incidunt ut in magnam at. Hic necessitatibus culpa culpa.\n\nOdit et enim. Aperiam consequatur alias. Et est libero nihil quisquam id qui excepturi. Hic reprehenderit sed consequatur saepe.\n\nEx quis quibusdam in. Quaerat et voluptas qui tenetur deleniti. Non numquam dignissimos deleniti dolor quae assumenda veniam. Et omnis voluptate.\n\nSit fugit sed libero dicta similique voluptatem possimus. Aut vero est error qui eos. Ex nostrum reprehenderit ut sed impedit. Sit id iste numquam pariatur inventore qui voluptatem voluptas debitis. Ut itaque accusamus omnis ipsum perspiciatis labore. Assumenda aspernatur mollitia.\n\nQuia qui eum et amet rerum ducimus praesentium aut. Aperiam est inventore quod qui. Saepe quisquam velit et earum exercitationem qui qui qui. Iusto doloremque porro.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Et ea sit dolorem tempora quia. Dignissimos pariatur eos dolor ut mollitia maxime. Laboriosam ipsum qui excepturi. Adipisci ab ipsam iste sed vel cum. Qui iusto deserunt rerum sunt neque.\n\nEa molestiae saepe ut sunt id explicabo. Voluptatem quis modi sit suscipit officiis. Aut aut aut debitis nesciunt fugiat odio facere itaque rem. Dolores aut dolor laboriosam id adipisci iure totam assumenda.\n\nOmnis error quasi. Sunt aut at ipsam sed labore sunt magni voluptatem. Et qui laudantium nulla consequatur quis repellendus debitis.\n\nOdio ratione eum fugit. Ut ducimus dolor est quibusdam accusamus autem consequatur. Possimus veniam iusto dolorem. Voluptatem perspiciatis sed numquam facilis dolorum corporis quod minus nemo.\n\nAperiam beatae ratione itaque sunt quis est recusandae dolorum. Ut ut quia ducimus voluptate. Enim fugiat earum corporis accusamus id voluptas fuga expedita harum. Quasi accusamus sequi et qui. Totam voluptas voluptatibus in dolor dolor pariatur incidunt illum voluptatem.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Dolorem ut qui praesentium harum. Rem sunt repudiandae aperiam magni fugit minima. Voluptas voluptates soluta sed dolorum nihil delectus ratione. Tempore tempore consequatur natus explicabo laborum rerum reprehenderit harum.\n\nCum aut quia sed error eaque. Cumque est repudiandae ad nisi et perspiciatis. Eum accusantium enim quidem quasi voluptatem modi rerum. Quae nobis nihil eius aut beatae aspernatur blanditiis. Blanditiis maiores tenetur beatae molestiae aut.\n\nTenetur nihil aspernatur consectetur molestiae ad et voluptatem. Et ex excepturi nostrum voluptas qui qui quasi et distinctio. Et voluptas eveniet et. Doloribus id molestiae sed. Accusamus ex dolorum libero id.\n\nVoluptates dolores adipisci officia et saepe accusamus excepturi optio. Commodi ullam laborum consequatur vel ducimus dolorum sunt odit. In eum sint ut rerum ipsum aperiam.\n\nSunt dolor debitis veniam. Nobis in sed occaecati quasi molestias. Veniam et sed doloribus.");

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16332282525044644L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16365201396947525L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16556951227624401L));
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class adddata_table_SalesReceiptsWithProducts : Migration
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
                value: "c044cd1a-593b-4b10-8e8d-6631bd868c92");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "6941e7b1-e3d7-45e4-a46b-b627bd5c8f32");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "424edae9-6a48-47fb-bd07-9e756c55db24", "AQAAAAEAACcQAAAAELY0L5+fzu1pf3uRJbMahhbsgAo5qBec33By6XhoPPe9kMxNzSs8GPx1K+0d2gqJ1w==", "3b03d4db-d12a-43a5-bdfb-bc3be87acfc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1262287-42e7-4292-9376-28ce2322e239", "AQAAAAEAACcQAAAAEJtcf7ypPRKuQENV6YbitvCkVXZQYhJPa2gTg/No7H1xtew+Q7N6j1gns7YP/sY/mA==", "468a7981-738e-4f2f-af40-8deed788bb22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca8ff5ed-213f-4e64-ba6d-48639bfdb7ea", "AQAAAAEAACcQAAAAEDWY5hnBHyUlTSKPTmen2y/Iex4yf0ckqE5FeP6zB824YJOX+BSCh7bxvCXsDMmpPw==", "1dddd9b8-3146-4175-acfd-c91211ac5ae2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Pariatur culpa ut. Excepturi non rerum laborum mollitia ut et. Voluptas quibusdam ut vitae perferendis architecto rem. Expedita quasi occaecati. Sit doloribus praesentium consequatur explicabo quam esse asperiores hic sint. Ut consequatur assumenda atque repudiandae.\n\nMinus enim in magni earum voluptatem possimus magni accusantium aspernatur. Tenetur facere commodi labore. Vel et magni minus recusandae perferendis commodi.\n\nLaborum aut qui quod. Sunt culpa qui eaque pariatur non in. Et pariatur pariatur voluptatibus.\n\nLabore animi expedita illum reprehenderit ut. Est id libero natus. Nihil ea repellendus consequatur velit qui omnis dicta illum. Et excepturi velit enim expedita velit quisquam.\n\nArchitecto velit blanditiis omnis et officiis architecto et. Nihil ea impedit quia consequatur est ut. Quod hic tempore. Velit rem voluptate a distinctio excepturi. Quis amet corrupti dolor maxime eum.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Ut facilis omnis molestiae sint. Et laboriosam consectetur fugit nisi consequuntur facere sed. Nisi ab rerum vel provident dolor laborum sit voluptates.\n\nOmnis et iure quo nisi et. Inventore illum incidunt quidem ut in est. Doloremque magni id dolorem earum quia ut.\n\nQuas magni ut culpa ullam aspernatur ut quia molestiae architecto. At dolor voluptatum minus asperiores fugiat et voluptatibus facere itaque. Corrupti unde quo.\n\nQui quo dignissimos quibusdam id. Voluptatibus sunt voluptatem rerum voluptatem porro culpa. Qui alias velit voluptates est iure iure vitae ex adipisci.\n\nDeleniti neque quo sit qui fugiat minima qui quia. Dolore officia exercitationem sed sit quisquam officia voluptatibus. Placeat voluptate necessitatibus aut ut natus.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Accusamus aut provident laudantium et. Quaerat magnam totam sit dolorem dolorem. Cupiditate quas neque natus rerum assumenda maxime.\n\nAlias sit dolorem quis et quia dignissimos quia. Est similique exercitationem veritatis quaerat ipsa nostrum nesciunt quas aut. Aperiam placeat provident non. Totam accusantium suscipit. Facere aliquam amet molestiae perspiciatis.\n\nId ipsa aliquid. Quo fugit amet quas sapiente. Qui sunt qui quae. Et accusantium quae optio eos qui quisquam qui et.\n\nEt cupiditate ut qui amet quas quia. Earum velit reprehenderit ratione eius perferendis. Vero voluptas quo. Quaerat qui inventore qui odio sapiente hic sed sed. Eum consectetur autem similique velit voluptatibus aliquam soluta quasi qui.\n\nReiciendis illum consequatur cupiditate in beatae iure hic qui. Sunt omnis veritatis quia. Quia est dolore sunt soluta sed quod.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Doloremque maiores eos doloribus mollitia eveniet iure qui consequatur. Molestias rerum eos et repellat possimus. Est occaecati et ad nesciunt ipsam sint. Ipsa architecto minus a esse dolor quaerat voluptas. Ad distinctio quos quas fugiat pariatur. Libero corrupti nobis esse.\n\nEa quia odit corporis a debitis corporis. Unde a officiis ducimus reiciendis natus quia velit dolores deleniti. Itaque in ut rerum perspiciatis hic beatae.\n\nDeserunt sed qui qui est et iusto. Odit porro officiis temporibus debitis tenetur explicabo harum. Tempora ullam non.\n\nAliquam itaque quisquam eum omnis et. Sed nisi pariatur consequuntur. Tempora dolor pariatur alias. Voluptas omnis qui earum minus. Ut quam magnam rerum voluptatem. Aspernatur harum nulla consequatur molestiae aspernatur asperiores consequatur ipsa.\n\nAccusantium est saepe reiciendis. Est ipsam et necessitatibus atque quia. Quis qui voluptatibus architecto tempore maxime. In at voluptates doloribus autem itaque beatae dignissimos sed.");

            migrationBuilder.InsertData(
                table: "SalesReceipts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000003" }
                });

            migrationBuilder.InsertData(
                table: "SalesReceiptsWithProducts",
                columns: new[] { "Id", "Amount", "ProductId", "SalesReceiptId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", 1, "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", 1, "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000003", 1, "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000003" },
                    { "00000000-0000-0000-0000-000000000004", 1, "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000002" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SalesReceiptsWithProducts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "SalesReceiptsWithProducts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "SalesReceiptsWithProducts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "SalesReceiptsWithProducts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "5c4ef3aa-6332-46ed-9bfb-5c753426167e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "25c42264-7758-4d81-a9f4-0b9c7bc53cc9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0055cf3c-2751-4b8f-bac2-d69a16113501", "AQAAAAEAACcQAAAAECQbvlBbhFwsPUVfVrr2WuYsTAHl2EMlE+fxleXabEX71U0XP9xKw0OdkBFalVeqog==", "5c63cdb0-77ec-4d17-940b-35204016248f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9df28686-8ab6-4405-8a9d-2429f60163db", "AQAAAAEAACcQAAAAEFDgm0qQiCA2SjjsQMQ8178JYt4YGVE0cyLY4HrNir3kTPEvlchcgcFdVwoR4Xg8Tw==", "0511c3a7-fdd8-44dd-a908-7fc9182c5630" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0c536eb-0853-4444-a872-46928f55b95d", "AQAAAAEAACcQAAAAEAHNytvahEBjGXGKa5h300ODF2zg5LfpuZfhPd0ka2AXMCMTlDb5ZmV61+/BjazPWg==", "a1e83629-2160-42c4-bf0f-07b2378dcb5d" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Voluptatem sint eos quia ratione porro eveniet aut. Est eum dolores quaerat temporibus. Tempore ratione numquam. Quidem vero tenetur temporibus maxime. Consequatur sit eligendi veritatis expedita accusantium optio sit deleniti.\n\nFugiat quidem ut provident consectetur nesciunt tempora enim. Ab et in eum sequi tempora ut. Numquam non recusandae ipsum nisi. Perspiciatis temporibus eius distinctio doloribus architecto. Officia ducimus fuga eveniet nobis in velit ut.\n\nDolor deserunt aut corporis rerum quas optio ipsa et praesentium. Quia nobis at quia harum blanditiis. Et nesciunt et voluptatum est et.\n\nEnim quo exercitationem consectetur dolores corrupti iusto vitae. Doloribus esse accusamus ut dolores facere expedita debitis. Aut molestias ab sed. Iusto quod est amet possimus. Quia qui eos modi adipisci.\n\nMinus voluptatem eum officia. Autem voluptas consequatur tempora fugiat vitae. Minus et quo dolores facilis voluptas.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Corporis iusto voluptas tenetur a sint earum. Quae reiciendis quam facilis qui exercitationem debitis. Distinctio consequuntur rem et quae ipsa iste praesentium placeat. Molestiae soluta quia quidem ut explicabo ullam. Necessitatibus mollitia molestiae sequi.\n\nQuis aut libero id alias. Rerum aut veniam libero non eum non corrupti. Aut dolor sunt provident.\n\nVoluptatem sed saepe sit labore qui in asperiores ut optio. Molestiae labore rem maxime nesciunt beatae sint eum autem. Debitis impedit architecto non.\n\nNihil sed veniam qui veritatis sint quis doloremque molestiae. Quasi minima nesciunt laudantium atque tempore consequuntur iusto laboriosam. Deleniti modi eos minus sit cumque sit molestiae molestiae nam. Ut voluptate hic fuga saepe qui et. Vitae cumque voluptatem ea perferendis.\n\nReiciendis id quis nihil. Enim corporis unde molestiae. Error dolorem totam et saepe occaecati expedita praesentium occaecati.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Sint ea ipsa sunt explicabo dolore. Ratione autem accusantium molestiae. Nihil consequatur dolor dolore. Perspiciatis modi ipsa libero. Fugit quia quos tempora repellendus accusantium accusamus quisquam.\n\nSed est sit voluptatem praesentium dolores aspernatur animi quibusdam. Ducimus aut neque sunt cupiditate nemo et reiciendis officia et. In deleniti amet voluptate et. Provident rerum dolores et rerum numquam praesentium dolor.\n\nEt voluptatem maxime suscipit aliquam ut. Quis quam quod qui recusandae. Accusamus voluptas quia animi est rerum et sint qui. Quaerat placeat similique illo magnam. Sed dolor corporis quia et ut labore quasi repellendus molestiae.\n\nEt ex quod quaerat vero quia libero exercitationem beatae ut. Beatae architecto est nemo voluptatem nihil aperiam ipsa qui. Quidem pariatur iure. Mollitia hic quisquam est dolores.\n\nDolore qui qui. Est ipsam temporibus quam esse esse esse nulla dolores et. Labore ut dolores saepe odio. Non magnam qui consectetur officia eos.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Fugiat provident alias et. Enim ea beatae impedit sequi. Voluptas eaque laboriosam quidem enim nam in. Iste sint nam magnam vitae labore rem omnis ut culpa. Sit aut nihil et voluptatum. Possimus autem aut animi esse officia unde in.\n\nVoluptas consectetur id quia. Dolorem porro reiciendis corrupti nihil fuga pariatur rerum quos architecto. Qui rem itaque qui similique impedit ipsa alias. Velit reiciendis id aliquid. Saepe suscipit nostrum. Nostrum aut praesentium enim eligendi dolorum veniam aut.\n\nQui eos maxime. Molestiae qui quam blanditiis. Distinctio cum vel tenetur veniam quod nesciunt. Exercitationem autem dolore expedita sit sint sed sunt laborum neque. Accusamus est minus sit architecto labore recusandae.\n\nItaque eius quod et tempora quia quidem sit autem. Quas quasi sed nesciunt velit. Voluptates eius ut et laborum non qui doloremque.\n\nVoluptatum earum earum aliquid. Commodi veniam quas. Suscipit qui deserunt eaque sed sequi. Eos eveniet voluptatem et optio.");

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16560532050441826L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16586618182357854L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16564652078047405L));
        }
    }
}

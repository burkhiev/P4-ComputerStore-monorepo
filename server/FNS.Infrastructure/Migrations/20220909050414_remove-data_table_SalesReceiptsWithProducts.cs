using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class removedata_table_SalesReceiptsWithProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "9ea15db5-1566-412e-a381-e09ec51ea16e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "5694a770-ecd9-437b-b119-fd72b56b6921");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "653bc204-3294-467f-ad56-d740890bff6c", "AQAAAAEAACcQAAAAEITdFMOxlYvS1o4wl14MQSeoVyGklUWhOoVqsVjsgDJuH560Mjl1IjMv45BmdUhhpA==", "74596072-d9e0-4e06-934c-5e60a5b0ce68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0236d309-b176-4e11-8c42-b65a85a4c6ef", "AQAAAAEAACcQAAAAEBQI4KA7IuQ/2LZ8RNX/s2JkWh4fcjcXBvAeXORBTR21Xn+o80HLIb6zkzJOiUzhww==", "1fd08640-e864-41ed-adf3-4bf2597cf6db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48d5ffa8-9710-480f-aa48-d21e83298f80", "AQAAAAEAACcQAAAAEIdZJWMxRLZy+6u5tzUONrL/2NQfwD6IYMSeA55pBEIlrhDVTmLSedk5OZA3xG4v4A==", "07af4168-432e-4753-a6af-33f487b714ef" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Sint aut et vel. Neque harum ratione quas amet quis eos ullam repellendus ab. Laboriosam et blanditiis.\n\nDucimus consequatur laboriosam molestias et consequatur suscipit. Nihil aut rem et vel eos. Eos aut mollitia ducimus.\n\nUt doloremque eligendi suscipit optio quae neque in ut. Provident velit quos aut quod voluptatum voluptatibus. Nulla blanditiis praesentium. Illum modi velit rerum repellendus optio et.\n\nEx rem quo ut et enim dicta sed. Praesentium provident saepe. Officia autem omnis. Aspernatur illum ut. Voluptatem iste sed molestiae aut autem consequuntur sed est. Ut beatae maiores odio consequuntur natus soluta.\n\nEarum assumenda neque autem voluptatum. Cumque et sit dignissimos optio. Maiores quia molestiae perferendis rerum et molestiae voluptatem. Dolores veritatis recusandae vero adipisci dignissimos eum quia et. Minus beatae accusantium eos mollitia ut ut.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Maiores cupiditate consequatur tenetur ipsum facilis qui. Libero aut velit ipsa nemo necessitatibus harum earum corporis autem. Et ab quo aut fugiat quia quisquam ipsam. Iste qui magnam reiciendis saepe.\n\nUt sint alias quisquam dolor voluptatem exercitationem. Ipsa molestiae voluptatem a odit sapiente. Doloremque commodi porro dolorem expedita. Tenetur sint et voluptatem nulla fugiat sit aut. Incidunt vel officiis qui omnis eligendi rerum totam.\n\nIllum earum dolores animi error qui nostrum. Laborum est autem nisi est. Nisi hic quis molestiae laborum et numquam vero. Numquam impedit veritatis ut qui nostrum voluptatem. Aut odio delectus repellat excepturi.\n\nNihil blanditiis pariatur ex. Necessitatibus optio a et ratione voluptas et. Iure soluta dolores.\n\nIn eos qui harum at vel soluta. Dolores nihil sed inventore qui magnam dolor delectus ut. Vero eius numquam reprehenderit laborum facere quos. Similique quidem omnis.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Occaecati consequatur est quidem consequatur reprehenderit voluptatem. Eos laudantium aut doloribus. Cumque est fugit illum non aut similique dolorem aut. Praesentium eaque ducimus vel qui.\n\nEt vel fugiat et dolores architecto. Nihil labore doloribus neque itaque. Ab expedita harum corporis eveniet neque labore.\n\nRecusandae eius nemo soluta et alias et. Repellendus fugit accusamus voluptates doloremque quo labore dolor eos. Ex voluptatem alias quia impedit ipsa. Fugit ut modi molestiae sed ea nostrum. Consequuntur cumque a maxime veniam ea adipisci quod. Nihil atque saepe consequatur.\n\nQui necessitatibus pariatur amet est mollitia reiciendis nihil aspernatur ipsa. Quis dolorem dolores mollitia voluptatem dolores. Occaecati ab eius laborum earum aut odio. Sit eaque quia odio sit fugit. Quaerat occaecati nisi cumque voluptas debitis at expedita.\n\nEnim nam porro ipsum repellendus consequatur natus eligendi. Rerum hic cupiditate autem quae. Quis earum ab magni.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Sunt nemo fugiat quos eligendi doloremque odit non ut dignissimos. Illo beatae aut. Amet aut eveniet distinctio.\n\nEt aut culpa sit. Incidunt beatae in numquam eos doloremque. Et dolor quis iste nam commodi.\n\nIpsam voluptates et commodi. Numquam quo delectus aut voluptatem. Aut sint voluptates et quo ut. Pariatur perferendis sed vel ut.\n\nEt sint exercitationem beatae. Architecto nesciunt autem quaerat quia. Architecto eum voluptatibus quos vel odit sequi.\n\nEa at placeat tempora eveniet. Labore ipsam dignissimos ea dignissimos eligendi sint. Consequatur excepturi sit non provident corporis sit alias nam. Mollitia consectetur dolores. Numquam incidunt ipsam eius quo et qui quod a aliquid.");

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16558245364055499L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16597459206212567L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16411032402026122L));

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
    }
}

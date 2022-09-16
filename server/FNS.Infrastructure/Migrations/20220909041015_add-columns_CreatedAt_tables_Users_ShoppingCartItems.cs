using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class addcolumns_CreatedAt_tables_Users_ShoppingCartItems : Migration
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

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.AddColumn<Instant>(
                name: "CreatedAt",
                table: "ShoppingCartItems",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: NodaTime.Instant.FromUnixTimeTicks(0L));

            migrationBuilder.AddColumn<Instant>(
                name: "CreatedAt",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "492068b0-6e09-4f5c-be6b-9765f7c8a669");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "eef0e6cb-dbfd-4c55-9fe5-bea2d5a81496");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", 0, "7d42216e-8355-4dae-819e-54686b2c4687", "user1@gmail.ru", false, false, null, "USER1@GMAIL.RU", "USER1", "AQAAAAEAACcQAAAAEBr3B5LKeV80tzL2e01DoeUQ/OLGSD6wAmDoQrWnVo4r3SrF+F+U63mhnHMK0uF08Q==", null, false, "7461a0b1-8f51-4481-a91e-25dfb20d4495", false, "user1" },
                    { "00000000-0000-0000-0000-000000000002", 0, "eec0470d-a613-4dc5-8da7-10c9f6bc8751", "user2@gmail.ru", false, false, null, "USER2@GMAIL.RU", "USER2", "AQAAAAEAACcQAAAAELZGeomfgpGsi1se4SycfewlZhMWJLz/h8CD8RatlzNpepuSy5t65b2hYkUTaFW48w==", null, false, "97108238-7021-475c-969c-70c2e5758279", false, "user2" },
                    { "00000000-0000-0000-0000-000000000003", 0, "bac37403-0c22-4974-b62f-8e0f9bb3ac6a", "admin@yandex.ru", false, false, null, "ADMIN@YANDEX.RU", "ADMIN", "AQAAAAEAACcQAAAAEOd5KzJklxsR5VOvwHAfjIevqhFp+XdXbHjDqsL7IsHguTA2YUFyphFDEHHpnPEmSA==", null, false, "8a1ea8c3-f9d4-41df-915d-01b8cd3ee359", false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Odio sed alias ea saepe neque. Qui quam ratione veritatis error ratione vel blanditiis. Tempore voluptatibus saepe hic inventore praesentium et. Velit voluptatem harum accusamus sit nihil omnis qui. Dignissimos minima et sed totam eveniet et similique blanditiis. Et ut excepturi et nam laudantium dignissimos.\n\nIllum doloremque nemo dolores ipsa dolor explicabo. Eveniet non voluptas eum nihil dolorum dolores soluta. Eum officia veniam ipsam.\n\nRecusandae laborum odit similique saepe. Et voluptatem incidunt. Occaecati voluptatem et non assumenda optio eos odio. Qui voluptate dolorum et quam non qui recusandae.\n\nOfficia nemo eaque. Est sit natus libero ex saepe cumque beatae velit. Consequatur voluptatibus itaque enim. Voluptatem repudiandae est.\n\nRepellat debitis a vitae labore magnam est accusamus et. Et voluptatem consequatur vel nostrum. Cumque dolorum dicta ea dolor.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Doloribus et laudantium. At voluptas necessitatibus corrupti rem incidunt ut provident. Placeat aliquam explicabo sapiente accusantium eum accusantium facilis. Voluptas numquam aliquid deleniti cumque adipisci iusto et.\n\nIllo et vel. Quod laudantium eius nesciunt nisi. Maxime incidunt quia facere nulla dolor rerum. Aut ratione ad rem praesentium et. Sed placeat ut recusandae vel officia est eum aut minus.\n\nNon earum iusto quia dolore. Veniam qui ut nesciunt molestiae est exercitationem natus. Natus tenetur officiis minus ullam.\n\nMaxime qui omnis aperiam nostrum at quibusdam. Quam non quia atque suscipit mollitia similique. Minima adipisci sequi rerum. Cum qui voluptatem incidunt accusamus repellendus aliquam et id nam. Repellat minus et. Recusandae ut ab qui nemo est quisquam.\n\nVero totam nihil. Amet nemo molestiae nisi quia qui sit est doloremque. Est modi suscipit perspiciatis aut. Officiis corrupti qui aut placeat dignissimos laudantium qui sequi nemo.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Necessitatibus qui similique ab. Est quod quas quia magni. Et et est repellendus. Eum eum veniam eos. At omnis est dignissimos.\n\nCorporis et molestiae beatae. Sit quisquam sint molestiae. Eos ut ea ut necessitatibus. Id sunt voluptatem deleniti blanditiis.\n\nDicta illum eius sint. Nam omnis sunt. Aut sequi ipsam quam illo similique unde expedita.\n\nPossimus laboriosam sint non veniam odio dolorem nisi. Tenetur consequuntur inventore distinctio. Facilis eum quibusdam eveniet consequatur non similique ut incidunt dolores.\n\nAut distinctio sed voluptatem et. Alias cupiditate in est soluta eum aut officia et magnam. Impedit earum sit ut quas asperiores quo.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Neque non vitae dolorum velit quos perspiciatis tempore et voluptates. Consectetur velit ratione consequatur repudiandae voluptatum. Eos aut aspernatur sunt. Aut atque minima eius rerum.\n\nSimilique fugit aut architecto omnis debitis quae. Eveniet et mollitia laboriosam ab repellat odit nihil quod. Culpa in quasi blanditiis voluptas explicabo eum quae sit. Nostrum praesentium unde nemo facere nihil dolores dolor.\n\nSapiente sint est maiores vel quas. Rem nulla consequatur ea doloribus delectus vel voluptatem sit cumque. Minima architecto aspernatur excepturi eos est quia.\n\nNam et architecto qui nulla eligendi sapiente voluptatem aliquid sit. Tenetur ratione nihil repellat modi et quas eligendi et vero. Sed est enim nihil. Cumque quas natus corporis qui architecto dolorem quibusdam sit provident.\n\nNesciunt ut architecto illum accusantium non officiis ut est eos. Molestiae reiciendis debitis architecto deleniti voluptatum quia praesentium perferendis. Exercitationem quos ab.");

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
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "508e6184-15fa-4bb6-b8fc-d238bd536af5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "5287b4a4-92f3-45e2-af72-af4daeb4be08");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef110111-c5d6-406e-b89f-59343bf52525", "AQAAAAEAACcQAAAAEILm4xvlaaA26V7qT64ie/6N6q9ZkJezUq1DKKRBij4dIjiGjoM6L2CcYcpjN/hmLQ==", "3c151401-3b94-443d-9374-cea7196273d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5e7901c-0d5d-4ae9-a7db-9570c58f2e80", "AQAAAAEAACcQAAAAEPABeXZftUz81PaQp4vfLlaWWNzBxRxTY+l5UlidtjcdSbQUHi5ZcVimshV9tQ7r0g==", "5c11e2f8-69a2-41da-b37e-34e6ae4aa389" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0efadab-b40a-483b-9eb1-aa439953ee0b", "AQAAAAEAACcQAAAAEKv5dDd4uBTusSMQ/qvFD7Uz3WJyoxEaDVcUDo34rgelqtuRGKX2yIhJWuxgjqD2VA==", "a7a4e8c0-0822-4ace-b722-9e4d4de4b5a2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Quasi quia architecto. Qui consequuntur possimus fugiat sint voluptates soluta autem. Sunt asperiores nobis quis commodi. Velit quis in. Sunt quam eos. Architecto dolorem sed repellat.\n\nDoloribus sunt similique repellat. Voluptatibus velit laboriosam sint esse dolorem. Suscipit possimus ad minus distinctio.\n\nMinima laborum voluptatem et quod quia voluptas nulla qui ex. Illo est repudiandae ex similique itaque distinctio quae provident voluptatem. Enim fuga nam magni architecto vero debitis consequatur rerum. Inventore sint enim.\n\nUt numquam praesentium sed velit sed sunt eligendi est. Impedit est atque maiores similique et. Minus delectus dolores.\n\nVeniam iusto consequatur perspiciatis quae laudantium accusantium qui eaque. Ut exercitationem et laudantium. Aspernatur culpa eligendi debitis possimus dignissimos id ratione eos vel. Autem tenetur delectus esse quia.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Est velit qui quaerat. Ab facilis id. Sit iusto nihil aut sapiente enim voluptas. Dolores impedit dicta ut. Libero aut sint accusamus.\n\nFuga quam exercitationem. Vel maxime consequuntur ut. Ducimus quia sint modi a consequatur ea nihil earum ut. Necessitatibus nihil repudiandae qui repellat odit eius veritatis sapiente. Tempora et accusantium veritatis eos minima deserunt illo accusamus aut.\n\nNumquam ut quidem. Necessitatibus illo at nam. Ipsa eligendi quas accusantium cupiditate at esse. Quidem aspernatur laborum a ut voluptatibus ea consequatur fugit. Iusto odio ab et maiores porro voluptates quo.\n\nFacilis ut sint explicabo impedit ut quam sed vero. Quaerat ipsam veniam voluptates amet sed cumque ut similique. Deserunt et quos et officia odio.\n\nAssumenda molestiae id distinctio. Veniam tempora id commodi aspernatur natus numquam. Animi dolor exercitationem dicta quia pariatur sed quae. Amet rerum quia aliquam veniam aliquid ut.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Ullam consequatur et temporibus rerum fuga velit quidem. Officia consequatur cumque tenetur ut. Corrupti numquam in ipsam odio. Aut ea et sint quos quis et.\n\nSunt nostrum accusantium eum voluptates. Explicabo non recusandae autem maiores praesentium consequatur sed ad. Voluptas veniam nostrum dignissimos corrupti ut a quibusdam. Eum enim itaque fuga.\n\nNostrum vitae perferendis et ut numquam eius quae omnis dolor. Eos id consequuntur dignissimos earum et. Voluptatem qui saepe et consequatur. Non rem aut tenetur dolor quisquam porro omnis tenetur fuga. Eligendi facilis quidem sed quia omnis dolores.\n\nQuisquam dolor doloribus quae autem laboriosam asperiores eius non earum. Aperiam rem enim quia cumque est ducimus ratione. Voluptates deserunt voluptate dolor.\n\nRem atque soluta nihil aut voluptatem quas architecto quod et. Ipsa nam ut officia nesciunt sunt aut. Ut autem consequatur tenetur.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Suscipit nemo et ipsa sit aut eaque repudiandae facere pariatur. Repellendus rem tempora commodi et esse veniam doloremque aperiam cupiditate. Magni voluptatem est.\n\nNon deserunt vitae unde eligendi. Voluptas occaecati maiores id natus cumque et voluptatem quia quia. Aut aut provident.\n\nSunt eos quasi cum optio dignissimos repudiandae voluptas et. Minus nobis eius esse. Atque sit ab non totam odio aliquid quia sit saepe. Molestias est cupiditate voluptatum a consectetur eum nulla commodi facere. Non quis ut hic officia nesciunt qui reprehenderit et. Qui neque fugiat ut dolorum magni.\n\nEnim hic dolorum sed. Itaque quas occaecati a nihil quis esse dignissimos ut itaque. Eum harum suscipit illo sed.\n\nLabore provident distinctio rem aut. Qui rerum qui non officiis qui cupiditate. Quis voluptate doloribus architecto. Nemo qui odit facilis quod corrupti nemo asperiores labore aut. Veritatis eius dignissimos dignissimos facilis eum expedita officiis vero.");

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16423856450612356L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16506611545975354L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16576426484559884L));
        }
    }
}

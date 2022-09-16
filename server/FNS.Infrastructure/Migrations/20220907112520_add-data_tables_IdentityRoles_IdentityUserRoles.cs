using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class adddata_tables_IdentityRoles_IdentityUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7298e95-bc14-418f-8c6b-a457fd37bf8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abeb0007-caf8-47e7-91e2-52c1858c3256");

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
                    { "00000000-0000-0000-0000-000000000001", "508e6184-15fa-4bb6-b8fc-d238bd536af5", "admin", null },
                    { "00000000-0000-0000-0000-000000000002", "5287b4a4-92f3-45e2-af72-af4daeb4be08", "user", null }
                });

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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000003" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000001" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000003" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

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

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16370881734255612L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16566011763189938L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16418309308077856L));
        }
    }
}

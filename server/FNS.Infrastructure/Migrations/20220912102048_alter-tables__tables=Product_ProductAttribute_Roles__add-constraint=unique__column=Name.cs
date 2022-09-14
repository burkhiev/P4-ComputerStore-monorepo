using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class altertables__tablesProduct_ProductAttribute_Roles__addconstraintunique__columnName : Migration
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
                value: "6a269003-f65b-4d07-93a9-5c4776667d94");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "81c81d73-ccab-4d49-9641-98a773269782");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6409408-1654-4ed3-a5cd-dfedf7c5ac2c", "AQAAAAEAACcQAAAAEOyyWzhhNRVI6IuxKScFJ3KfcLWfNCeDGDlExBXQWqd/ijc5AvSSS7iAa7pYarp9dg==", "9891bccb-4f97-4c22-9477-bb52030682af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93ba23ed-2468-4191-a3fe-778be918ef99", "AQAAAAEAACcQAAAAEFqTMtl2Buab9OeyZ/R82Md4gGn5yZSwTom9+a3cQiKSB0NsAoO2gmN7YX5HAEvqzg==", "d7ea9a1e-0134-498b-8180-72ba02a2a7f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45e7fc40-21bf-4b04-8282-171aa0661fe1", "AQAAAAEAACcQAAAAEABq8ljRBUeoOn5ltNVqs7hO/JZSEzQxBSKnPcRGZeFWo7dLr196YFANdFlEeDhjUw==", "bb9d18a5-ebed-4464-8ef9-cc95194b3bab" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Aliquam voluptas eaque molestias modi debitis. Ut eaque autem dolorem odit autem quam. Saepe reprehenderit et. Repellat ipsa facilis voluptatem cum ex quis minus.\n\nMagni culpa suscipit. Nisi pariatur dolores error neque qui. In hic culpa. Voluptatem corrupti ad ex deserunt rerum ullam neque ea. Ipsam atque esse sit placeat velit. Voluptates excepturi at dolorum.\n\nRatione quis similique facere nobis quod ipsum eum nihil tempora. Consequuntur beatae voluptates rerum expedita aperiam aperiam. Suscipit nulla eius voluptatem deserunt omnis magni quia sit.\n\nVoluptas nam et et non. Placeat accusamus consequuntur et eveniet a repellendus. Iure voluptatem quod veniam possimus non.\n\nEt quia voluptatem fuga. Eveniet at optio at omnis labore quas ad rem aut. Aut debitis corporis dolorum quia sunt. Accusantium autem reprehenderit fugit. Numquam asperiores quaerat unde optio tempore saepe excepturi aliquam aut.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Minima magni numquam non odit in. Consectetur qui inventore doloribus quia cumque aut ipsa. Praesentium minima et quia. Sed recusandae quos vel voluptates. Laudantium delectus illum expedita quas corporis.\n\nMagni dolor ullam sequi. Non ut suscipit rem maxime voluptate ea ut vel maiores. Illum cumque delectus perferendis non ut aut.\n\nDoloribus accusantium quasi architecto. Veniam est ipsum optio expedita necessitatibus maxime pariatur numquam. Alias nisi quis corrupti et adipisci rerum cum expedita. Accusantium hic delectus optio tenetur nihil incidunt reiciendis quasi qui.\n\nCumque cupiditate molestiae omnis ut ut iure magnam. Similique non eius. Eum doloribus laudantium. Qui placeat voluptas incidunt aut inventore dolor omnis.\n\nNobis incidunt natus et dolores debitis odit quae et. Ea magni praesentium modi labore sit ad possimus. Molestiae repudiandae harum sit qui quo. Quo sequi asperiores ea ullam. Consectetur sunt accusantium dolorum aliquid et at illo qui.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Autem eveniet blanditiis rerum. Eum voluptatibus qui temporibus. Iure iusto in. Sunt provident magnam.\n\nVoluptates odit quia. Voluptate vel nesciunt magnam excepturi. Porro sit totam et autem ut itaque sint aspernatur.\n\nImpedit tenetur qui praesentium nostrum cupiditate qui est et ratione. Debitis quibusdam molestiae at voluptatem velit qui omnis. Id perspiciatis est repellat. Magnam vel qui possimus consequatur nemo dolores.\n\nArchitecto quaerat tenetur. Iste hic ab et eaque et. Dolor blanditiis modi voluptatibus.\n\nAut modi nam. Nisi earum provident eaque minima enim accusantium non fuga ab. Pariatur unde laborum necessitatibus qui aut. Est molestiae sint vitae nisi ut est qui. Quia eius perferendis deleniti. Ipsum laboriosam est neque.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Esse quia rerum necessitatibus optio rerum. Vel beatae aut eum et est nobis. Dolores ea reiciendis ut repudiandae.\n\nNihil earum consequatur aut rerum corporis nisi deleniti. Et ab est quia quisquam atque harum. Iure natus quo. Officia quod deleniti perferendis et commodi eum.\n\nEt optio officiis quia possimus. Dolores hic voluptatem excepturi sunt. Corporis in est corporis consectetur molestias et earum voluptate.\n\nDistinctio aliquam libero iste ut sequi excepturi perferendis aliquam ipsum. Consequatur voluptatem veniam corporis aut quo ullam enim. Et incidunt maxime et. Eaque omnis ab rerum exercitationem voluptatem voluptate dolores.\n\nRerum aut minima illum sequi corrupti quo fugiat. Tempora quia vel dolor ut sint voluptatem. Consequuntur aliquid autem. Dicta rerum ex. Voluptatibus sunt modi doloremque voluptatem odio non magni omnis.");

            migrationBuilder.InsertData(
                table: "SalesReceipts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000003" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_Name",
                table: "SubCategories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Name",
                table: "Products",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_Name",
                table: "ProductAttributes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_Name",
                table: "AspNetRoles",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SubCategories_Name",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_Products_Name",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_ProductAttributes_Name",
                table: "ProductAttributes");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_Name",
                table: "AspNetRoles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "0c6b7185-7fc5-49bd-820e-435a34c4e5b2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "76cb2a14-d87d-47e0-a62d-609efdae00ae");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84212327-e13d-415e-ae0b-486b50f80697", "AQAAAAEAACcQAAAAEAvFjdYRR0cgnxyWFPosdHbxqqdTmpbKQ0OpJx2CJvsgjUhcoQq/s+RnDLgGkyu1Ow==", "1e17fc92-6c3d-423a-bfa5-7a8040a25198" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc01de1b-1b67-4c46-a412-536ad8208837", "AQAAAAEAACcQAAAAEPuuPeo7YcSr7R7W4z18VMRjVlgpbk48FZxPaFk+Qeb32JAdvIH6TiU0AhCZhWfOSg==", "98346e19-9c52-4071-b5e0-c9ce6d8c9141" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "233a4c57-eb17-456f-92bd-f0689fe0937e", "AQAAAAEAACcQAAAAEIVBCZEeCOPtyNj81NdDHX0Pyu0KFBNdAKz9WKEn2GRgxdkJsXFsr3qIOyQSVzo69A==", "3ba9357c-7d89-4210-8435-71262e9e3eaa" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Ea odit quis asperiores odio numquam eos. Corrupti tempore architecto voluptates aspernatur voluptatem fugit. Odit rerum similique accusantium qui sint et. Itaque voluptas deserunt minima ipsam quaerat ducimus qui excepturi.\n\nPerferendis officia voluptatum harum amet commodi numquam. Sit quia exercitationem laborum vero maiores qui officiis laborum. Recusandae expedita ipsum.\n\nOccaecati quis natus quo est porro. Harum aspernatur ab animi cumque eum non. Veniam quam reprehenderit ut et non veniam veniam.\n\nIste consectetur eius omnis voluptatum. Libero omnis voluptate. Dolore molestiae voluptas vitae omnis tempore alias. Veritatis excepturi quia debitis ipsa quam. Fuga repudiandae asperiores ratione delectus consequatur dolores sunt possimus.\n\nOfficia asperiores voluptatibus sed ut ab repellendus sunt. Nulla aut quos. Quam consequatur itaque temporibus veniam sapiente. Rerum repudiandae excepturi ut nulla aut.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Voluptas voluptas voluptatem. Et autem doloribus maiores. Quia sit quia. Sit ullam voluptas.\n\nHarum accusantium corrupti est ut ut facere. Architecto et quis at. Voluptatem ad dignissimos odit quasi et itaque. Pariatur omnis sed eveniet veritatis placeat et omnis et debitis. Dolorem eveniet sed aspernatur. Consequatur nihil alias cum libero veritatis sit quam.\n\nVoluptatum voluptatem ab molestias. Qui et omnis dicta minus. Aliquid cumque qui aut in. Magnam debitis iste aliquid corrupti aperiam ullam non vitae. Et eos tenetur ipsam aut voluptatum consectetur.\n\nOmnis ullam rerum alias quaerat. Qui totam corrupti veritatis nostrum qui eum perferendis alias. Veritatis et sint molestias aut et voluptatem id. Molestiae fuga natus repellendus soluta provident nobis animi numquam. Blanditiis sequi expedita voluptatum excepturi et consequatur suscipit totam nobis.\n\nA ut eaque possimus. Laboriosam illum et reiciendis quaerat. Atque sit quia sunt rerum fuga. Voluptas sit dolorem corrupti.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Tempore illum corrupti ut blanditiis consequuntur modi exercitationem temporibus pariatur. Reiciendis ea magnam qui sunt consequuntur vel qui eos. Similique rerum maiores rem non est fuga nostrum eveniet facilis.\n\nRerum qui autem nobis ut laudantium id. Maxime eveniet inventore. Eveniet ut voluptates sit velit accusantium ut aperiam. Rerum sint dolores delectus provident cumque nulla voluptas. Rem eveniet velit corrupti vel dolorem aspernatur.\n\nUt deleniti ut ut velit. Et qui iste cum excepturi harum. Quis ut doloremque qui tempore ipsa voluptatem nostrum. Tempora laboriosam molestiae.\n\nQuibusdam qui et sapiente officiis. Fugit ipsam non asperiores illo reprehenderit nesciunt commodi quasi. Ab ratione omnis impedit fugit cumque quo cum. Deserunt accusamus ducimus veniam ea natus nam eos.\n\nEt asperiores vel unde. Corrupti debitis cupiditate enim perspiciatis dolorem id eligendi. Id velit quia consequatur.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Commodi aliquid sed provident provident aut ipsum. Nobis temporibus quo tenetur est quam. Sed nulla totam repellat explicabo culpa veritatis voluptatibus. Voluptas assumenda et.\n\nOdio iusto consequuntur neque sed cum sequi quidem. Ut sed earum laudantium in provident fuga recusandae non. Porro rem possimus perferendis omnis non qui eveniet qui omnis.\n\nDeleniti reiciendis fugit recusandae ducimus ducimus odio nulla nemo vitae. Ipsa et harum. Blanditiis perferendis aspernatur amet.\n\nBlanditiis in labore nemo dignissimos atque eligendi similique eveniet enim. Possimus minima numquam. Possimus consequatur possimus voluptate velit commodi necessitatibus est sint vero.\n\nAut soluta modi modi magnam adipisci enim odit ut. Facere tempore natus illum animi. Quasi et dolorem dolor amet ullam ab.");

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16590021332138221L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16441129432715612L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16415416709026905L));
        }
    }
}

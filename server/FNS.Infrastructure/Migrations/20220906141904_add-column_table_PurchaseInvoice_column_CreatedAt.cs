using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class addcolumn_table_PurchaseInvoice_column_CreatedAt : Migration
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
                table: "PurchaseInvoice",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "45ff29e3-1bbe-489a-a4bb-6d42709629db", "b207506f-70c4-4018-9eaf-9366e2a11ef7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3316ceea-3d52-415d-9e3b-54bde842ab82", "941211cf-4828-4523-81ab-ea96cb6b5b9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9f15b76d-fb05-4b66-a616-3468f967832d", "aa29f9f8-aa0a-4d53-97e2-a9047e7b19b1" });

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
                table: "PurchaseInvoice");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "51fca09c-daab-493f-b056-21f4cc338c36", "bb4aac08-f613-45ee-a404-6749b0b7f168" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dbc426ec-4ee7-48d6-b429-620f9d9090e2", "4536bee9-a919-42a6-81ac-348cc468102a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b9b08773-c398-4803-9e92-cfe0d3d593af", "109493d6-3ded-4a39-8777-5205d4270675" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Veritatis modi facere porro accusamus laboriosam ullam. Praesentium quas reprehenderit in asperiores ipsa perferendis fugit quisquam. Modi autem quas illum. Sunt officiis tempore aliquam non aliquid. Placeat sunt illo eos repudiandae sed.\n\nQuis error quis. Placeat rerum exercitationem. Exercitationem dolor pariatur dolores placeat exercitationem ea. Voluptates nihil et deserunt est omnis eius deserunt sint aliquid. Accusantium architecto dolores expedita. Non minima tenetur fuga.\n\nLaudantium et et laudantium. Asperiores inventore ab soluta repellat repudiandae voluptatem aut. Rerum odit explicabo non iste autem.\n\nEnim sit culpa et facilis. Qui similique iure et animi. Quisquam ipsam corporis tempore quis. Est voluptate consequatur quod aut architecto minus.\n\nAliquam veniam repellendus numquam. Voluptatem ea dolorem quia voluptatum mollitia nulla qui perspiciatis. Quo cumque culpa perferendis vel architecto dolorem. Nulla quasi dolorum quibusdam.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Officiis nulla expedita reiciendis quia quos aut delectus. Et accusantium fugit voluptas dolor ab autem in. Fugiat et voluptatibus eum impedit officiis illo nihil.\n\nExpedita ipsa nostrum ex totam expedita quos perferendis magnam aut. Qui itaque et sed tempora praesentium quia illum ex illo. Id omnis non non perferendis vel porro aut assumenda quos. Quo excepturi rerum officia fugiat quo ea.\n\nNostrum nihil occaecati. Rem recusandae eos eos et. Impedit harum repellat et natus culpa aut consequatur aut aliquam. Ut harum voluptatibus et sed labore deleniti. Quia quia aut voluptates voluptas aperiam.\n\nNam quos et vel voluptatibus totam. Et voluptatem autem id. Ut rerum facere. Et sed ut impedit et beatae modi molestiae quia. Velit quas molestias sed dolor quia accusantium.\n\nNam consequuntur praesentium ullam. Natus corporis quisquam. Libero maxime voluptate illo porro quam labore inventore enim. Eum consequuntur quidem molestias sint nobis minus. Eius accusamus facilis eius molestiae.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Fuga ab id explicabo veniam. Doloribus maiores ut optio. Tempore ea nam quibusdam aut. Voluptatibus deleniti laudantium cupiditate labore.\n\nInventore dolor id. Harum in minus velit reiciendis culpa numquam. Iure distinctio reprehenderit inventore. Eligendi velit optio enim voluptatum tempora quia.\n\nEt accusamus veniam distinctio consequatur. Distinctio nam nesciunt perferendis incidunt. Et dolores earum qui iusto velit voluptate. Nesciunt odio corrupti quas vel sit.\n\nDoloremque velit ab esse cumque aut et. Eum veritatis qui quo mollitia. Ea voluptatem asperiores et qui maxime et aut in dolorem. Neque ex dicta harum nisi et rerum.\n\nQuas voluptas adipisci neque harum. Quis non dicta veritatis ea quasi facere distinctio. Beatae ipsa est ut et nemo veniam. Temporibus quo doloremque et maiores ut. Consequatur omnis fugit. Ex eos molestias libero ducimus minus nihil.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Non dicta iste qui corrupti quia. Atque ea temporibus tempora excepturi facere quam aut eum. Tempora recusandae quam voluptatem beatae sed. Minus itaque enim qui fuga vel.\n\nAut fugiat facilis cum similique aliquam. Rerum tempora et aut minus corrupti quo accusantium inventore molestiae. Sed et voluptatem eveniet minima. Est dolores velit sunt sint sunt ut laborum.\n\nTempore rem aut esse delectus voluptatem et itaque et. Omnis voluptatem rerum aut eaque omnis. Soluta expedita ex autem consequatur eos.\n\nEveniet rerum id quis maxime. Sed ab corrupti voluptate veritatis saepe ipsum dignissimos ut fugiat. Pariatur et recusandae exercitationem fuga at voluptatem quia atque accusamus.\n\nPraesentium eum corrupti. Natus modi voluptatem doloribus reiciendis. Enim doloribus sit sit quas est magnam modi.");

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16562347599568371L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16545521545976454L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16563358515689113L));
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class addtable_ProductBalance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductBalances",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    ProductId = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBalances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductBalances_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16205507-915f-4dd2-936e-a588f2b00582", "26e6cbc3-dd5e-4a06-8c56-b8a21dedc1e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ea1d679-1eb2-42ca-aeef-62d6f2ca1052", "7ff06153-dd12-4448-802b-b2500b2a2267" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9c3fc76a-7d12-4525-a914-ea2c61789e19", "0c4ab19e-ad92-42d8-b46c-fbfa54024dc9" });

            migrationBuilder.InsertData(
                table: "ProductBalances",
                columns: new[] { "Id", "Amount", "ProductId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", 4, "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", 10, "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000003", 3, "00000000-0000-0000-0000-000000000003" },
                    { "00000000-0000-0000-0000-000000000004", 5, "00000000-0000-0000-0000-000000000004" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Sit sed tenetur nam et. Facilis corporis aut. Inventore omnis quas nostrum.\n\nNam qui iusto repellat. Error tempore eligendi rem eligendi rerum quae. Neque ipsum vitae quia.\n\nEst nihil voluptate consequatur in a pariatur earum numquam cum. Est excepturi facilis cupiditate ipsum est suscipit rem consequuntur. Velit iusto nesciunt possimus est expedita optio enim quidem. A molestiae quibusdam omnis deleniti.\n\nQuod recusandae quia nostrum. Rerum modi possimus similique facere occaecati facere quos. Non est numquam.\n\nNemo molestias quis iusto commodi. Fugit quia non odio blanditiis. Impedit at cumque occaecati eaque veritatis dolore.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Tenetur qui laudantium nulla quia vel qui. Soluta ex et nam deserunt esse et. Quas illum et laboriosam dignissimos alias quo alias. Eius minus et.\n\nLabore molestias qui autem. Nisi culpa voluptas amet eos consequatur. Quia omnis consequuntur voluptas aut qui aliquam repellendus vel.\n\nAtque quas adipisci nobis et ratione vel. Voluptatibus ipsum quas consequatur minus pariatur maiores. Laboriosam voluptatem id quaerat saepe quia dolores quidem cupiditate voluptates. Quia perferendis expedita aut.\n\nNeque fugit sequi natus occaecati iusto consequatur quas sunt a. Inventore ducimus odio velit eligendi et quia. Rerum molestiae quasi autem impedit eligendi sed est. Voluptatem dicta omnis praesentium sunt voluptas pariatur sunt ipsam.\n\nDoloribus quia dolor consectetur vitae qui. Illo nostrum corrupti harum et. Occaecati dolores in labore ea in ad. Vel non distinctio reiciendis nam accusantium suscipit repellat corporis.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Et placeat iusto iste dolorem inventore ut amet ex consectetur. Et esse aspernatur et. Repudiandae et id nisi est id ipsa.\n\nVoluptas deserunt sint vero odit soluta repellat magnam aspernatur distinctio. Consequatur facilis sunt dolores. Quam harum vero earum alias et voluptatum ullam est culpa. Facere nemo odit id. Dicta sequi soluta. Quia eligendi aut.\n\nSed adipisci rem. Velit est ratione. Inventore quis aliquid alias impedit quo numquam occaecati. Voluptatum corrupti ducimus. Laudantium cumque quaerat nihil quos.\n\nDeserunt et repellendus magni ut nihil sit. Deleniti sequi et. Eum suscipit culpa nisi quasi ut omnis nihil ad et. Qui et aliquam iste.\n\nPerspiciatis corrupti consectetur sed beatae. Nihil ipsa ea rem occaecati. Optio porro quibusdam autem deleniti voluptatem repellat consequatur ducimus atque. Animi error ipsum ut incidunt omnis aliquam nam aut. Magnam repellat hic quia voluptatem quisquam cumque. Soluta odio et quae reprehenderit molestiae aut sint dolorem.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Culpa vel facilis tempore aliquam. Deleniti ut nemo assumenda. Qui quia est laudantium.\n\nDucimus quis alias qui. Quo et sed ut quae dicta animi. Autem et vitae. Reprehenderit totam itaque quaerat dolorum. Saepe qui minus cum maxime quibusdam. Quod aliquid a eum.\n\nCommodi aut praesentium ut assumenda dolorem dolorem animi aut sit. Aut rerum minus ducimus ducimus quia non. Totam libero illum autem repellendus. Est quae fugit expedita quia reprehenderit corporis nulla quia. Dolor cupiditate ut sapiente nulla. Corrupti excepturi voluptatibus delectus dolores quis nisi modi perferendis dolore.\n\nSequi et voluptas est. Nihil consequuntur unde. Molestiae ut eum culpa nostrum. Deleniti eum soluta. Aut nihil iusto labore exercitationem ratione laborum.\n\nDistinctio sequi numquam ut. Possimus tenetur repellendus. Beatae odit debitis cum dolorum possimus est minus. Omnis nam dicta itaque ipsum ipsa. Sequi aspernatur dolorem sequi et.");

            migrationBuilder.CreateIndex(
                name: "IX_ProductBalances_ProductId",
                table: "ProductBalances",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductBalances");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "01573a66-6f9e-4bfd-b1ab-d713ddd04768", "ae2730d7-569a-49d3-9890-4e615ac7e4df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "694efe14-534a-4586-aa47-636369b73407", "7374f215-f985-44e1-849b-abcae3dd3737" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d3fa80ad-7a20-488a-bb45-9bd25ee9212c", "512b72a5-767f-41f4-88bb-d65a8deb06eb" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Eos temporibus et temporibus. Sit et et sunt in minima. Ratione a pariatur qui ex. Debitis voluptatem soluta porro dolor et iusto eveniet.\n\nTemporibus quidem vel aliquid ea dolorem vero corporis eum ut. Illo ut non rem ad ut corporis eius sunt. Nihil cumque eaque aut sed tempore.\n\nNatus minus quibusdam et esse odio tenetur nostrum veritatis. Dignissimos distinctio facere facere molestias quo voluptas voluptatem aspernatur et. Omnis ea ea consectetur nesciunt laborum iste.\n\nQuibusdam quia reiciendis quia voluptas blanditiis facere optio. Quia ea autem dolor quaerat. Facere quam quis aut et deleniti qui aut cum rerum. Veritatis sed nulla ipsa est vitae natus sint qui. Recusandae nisi officia laudantium excepturi commodi rerum consequatur voluptatem.\n\nIpsum eligendi est perferendis incidunt aut tempore. Unde consectetur perferendis aperiam. Aut soluta aut tenetur qui aspernatur.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Qui aut quia omnis maxime voluptas qui dolores et sunt. Laborum aliquid eius dolore labore nulla magni. Natus aut quo repudiandae nam recusandae ut magnam. Suscipit natus accusamus consequatur eveniet blanditiis ipsa dolorem provident dicta. Doloribus beatae sit officiis.\n\nVoluptas facere excepturi ab veritatis et sint fugit nam ut. Quisquam nesciunt laudantium aspernatur iure. Minus mollitia laborum ut. Et officia architecto repellendus nemo qui alias non.\n\nEt labore voluptatem mollitia quasi culpa. Facere unde est. Ut eaque pariatur laudantium dicta perferendis. Ipsum odit fuga blanditiis.\n\nEt voluptate et consequatur sed sequi repudiandae saepe. Nam voluptatem minima sed sed et ipsa veniam dolores. Sint dicta veritatis illo molestiae possimus enim dolorem.\n\nNatus ipsam adipisci dolores voluptatem asperiores. Unde consequatur quis laudantium aut. Fuga aspernatur enim dicta libero.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Illum omnis ducimus sunt officiis repudiandae. Est aspernatur officiis minima odit earum aspernatur earum est eius. Praesentium eveniet numquam et reprehenderit sed harum.\n\nAtque earum fugit placeat quaerat exercitationem enim voluptates fuga. Sed recusandae quos nihil ut omnis repellat. Velit cum facere cupiditate veniam asperiores iusto ipsum.\n\nRepellat laudantium animi neque et quia. Numquam quia veniam deleniti quis et. Est at et autem minima. Ea reiciendis sequi rerum beatae qui earum omnis explicabo.\n\nCum deleniti saepe sint facere laudantium vero. Corrupti voluptatem ab fugiat ut et magnam iure. Et consequatur ex atque nisi fugit possimus error impedit.\n\nIusto sed id consequatur qui. Numquam laudantium aperiam quidem corporis magni voluptas accusantium facilis quo. Ab consequuntur omnis perspiciatis blanditiis omnis.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Laborum tenetur labore. Sint cum temporibus rerum quidem. Nesciunt omnis rerum illum. Dolorum ipsa magni adipisci voluptatem enim qui cupiditate.\n\nSoluta animi odio maiores repellat voluptatem eligendi. Libero aliquam harum ex et cum qui officia sed dolore. Optio ut autem sed incidunt est. Nobis sunt sed quia repellat temporibus qui.\n\nQuo magni aliquam. Exercitationem tempore ducimus consectetur sed natus est. Illo nisi officiis.\n\nTenetur eum blanditiis tempora doloremque asperiores in laboriosam natus. Est delectus reiciendis sit. Labore quae quas praesentium sapiente quas aperiam et culpa eos. Est voluptas nam numquam consequatur hic.\n\nAtque rerum odio repellat ducimus aut perferendis quaerat commodi recusandae. Officia officia quas aut perspiciatis ratione sunt porro non. Aut nihil asperiores nihil adipisci tempore fugit.");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class adddata_tables_all : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "2584f3b5-3ffe-4a14-a62e-808df96ca222", "admin", null },
                    { "00000000-0000-0000-0000-000000000002", "61f7409e-8fa2-4d24-bbdf-cb3ad2cf87ac", "user", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", 0, "46ae2710-99c3-4e06-bf10-d8f3654da2ce", "user1@gmail.ru", false, false, null, "USER1@GMAIL.RU", "USER1", "AQAAAAEAACcQAAAAEC8AZVqj59hkZFBDkSU8cLoT/Ke1LnSLf3jBUP7suVpmWisHYJhbon3fM74hz7gG6w==", null, false, "606be663-2233-47da-8233-d18b4aa8b7fa", false, "user1" },
                    { "00000000-0000-0000-0000-000000000002", 0, "081d99fe-7488-41fa-91c8-003a3e90e148", "user2@gmail.ru", false, false, null, "USER2@GMAIL.RU", "USER2", "AQAAAAEAACcQAAAAEGOsliabFEitspBxiLWg/7bWUIn/FJjps/ct3G+nMtr4RvCgl2+BA+gGiSPOvU5YPw==", null, false, "c19a3db2-56e5-4ab2-8160-3f96339f9214", false, "user2" },
                    { "00000000-0000-0000-0000-000000000003", 0, "09a4a8bf-0663-41e8-8867-db2b3b941abf", "admin@yandex.ru", false, false, null, "ADMIN@YANDEX.RU", "ADMIN", "AQAAAAEAACcQAAAAENKA8D7GXsmmxWUDJ1szouzkn3wHMeQe5+jk/irRDGJZWuAQA4zVIaAJL30rp+BsVw==", null, false, "d70d3306-a27c-42e9-a301-44186c06af85", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttributes",
                columns: new[] { "Id", "ClrType", "Measure", "Name" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "String", null, "Model" },
                    { "00000000-0000-0000-0000-000000000002", "String", null, "Socket" },
                    { "00000000-0000-0000-0000-000000000003", "Int32", null, "Release year" },
                    { "00000000-0000-0000-0000-000000000004", "Int32", null, "Total number of cores" },
                    { "00000000-0000-0000-0000-000000000005", "String", null, "Maximum threads" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "Процессоры" },
                    { "00000000-0000-0000-0000-000000000002", "Материские платы" },
                    { "00000000-0000-0000-0000-000000000003", "Видеокарты" }
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "ProductCode", "SubCategoryId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "Possimus et error rem. Est magnam laudantium ipsum. Praesentium distinctio sed dicta.\n\nEum cumque eveniet rem voluptatibus voluptatem consequuntur et. Aut numquam repellat sit omnis. Sapiente incidunt corporis.\n\nIpsam aut porro sed et et corrupti. Aut quo iusto quasi tempora nulla et adipisci est alias. Illo voluptatem eius dolor excepturi earum soluta neque officiis facilis. Hic cumque et aspernatur libero deleniti nisi iste.\n\nConsequuntur qui hic non in beatae cum omnis. Omnis ut cupiditate id sit. Quia et omnis repellendus. Magni quia error quisquam suscipit amet velit illum distinctio. Quo quas nisi consequatur natus consequuntur veritatis.\n\nUnde voluptatibus nemo incidunt dolor. Ipsum voluptatibus laboriosam. Voluptas ex nisi neque voluptas perferendis. Autem est magni aperiam velit corrupti praesentium. Asperiores labore est. Consequatur vel delectus officia dolorem suscipit autem adipisci voluptatem.", "AMD Ryzen 5 3600 OEM", 12599m, "1372637", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", "Non quia sunt iure dicta asperiores itaque corporis voluptatem. Similique et sed corrupti velit dolores eaque dolorem. Voluptatem unde incidunt ut in magnam at. Hic necessitatibus culpa culpa.\n\nOdit et enim. Aperiam consequatur alias. Et est libero nihil quisquam id qui excepturi. Hic reprehenderit sed consequatur saepe.\n\nEx quis quibusdam in. Quaerat et voluptas qui tenetur deleniti. Non numquam dignissimos deleniti dolor quae assumenda veniam. Et omnis voluptate.\n\nSit fugit sed libero dicta similique voluptatem possimus. Aut vero est error qui eos. Ex nostrum reprehenderit ut sed impedit. Sit id iste numquam pariatur inventore qui voluptatem voluptas debitis. Ut itaque accusamus omnis ipsum perspiciatis labore. Assumenda aspernatur mollitia.\n\nQuia qui eum et amet rerum ducimus praesentium aut. Aperiam est inventore quod qui. Saepe quisquam velit et earum exercitationem qui qui qui. Iusto doloremque porro.", "AMD Ryzen 5 3600 BOX", 12899m, "5059834", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000003", "Et ea sit dolorem tempora quia. Dignissimos pariatur eos dolor ut mollitia maxime. Laboriosam ipsum qui excepturi. Adipisci ab ipsam iste sed vel cum. Qui iusto deserunt rerum sunt neque.\n\nEa molestiae saepe ut sunt id explicabo. Voluptatem quis modi sit suscipit officiis. Aut aut aut debitis nesciunt fugiat odio facere itaque rem. Dolores aut dolor laboriosam id adipisci iure totam assumenda.\n\nOmnis error quasi. Sunt aut at ipsam sed labore sunt magni voluptatem. Et qui laudantium nulla consequatur quis repellendus debitis.\n\nOdio ratione eum fugit. Ut ducimus dolor est quibusdam accusamus autem consequatur. Possimus veniam iusto dolorem. Voluptatem perspiciatis sed numquam facilis dolorum corporis quod minus nemo.\n\nAperiam beatae ratione itaque sunt quis est recusandae dolorum. Ut ut quia ducimus voluptate. Enim fugiat earum corporis accusamus id voluptas fuga expedita harum. Quasi accusamus sequi et qui. Totam voluptas voluptatibus in dolor dolor pariatur incidunt illum voluptatem.", "AMD Ryzen 5 PRO 4650G OEM", 12599m, "1689358", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000004", "Dolorem ut qui praesentium harum. Rem sunt repudiandae aperiam magni fugit minima. Voluptas voluptates soluta sed dolorum nihil delectus ratione. Tempore tempore consequatur natus explicabo laborum rerum reprehenderit harum.\n\nCum aut quia sed error eaque. Cumque est repudiandae ad nisi et perspiciatis. Eum accusantium enim quidem quasi voluptatem modi rerum. Quae nobis nihil eius aut beatae aspernatur blanditiis. Blanditiis maiores tenetur beatae molestiae aut.\n\nTenetur nihil aspernatur consectetur molestiae ad et voluptatem. Et ex excepturi nostrum voluptas qui qui quasi et distinctio. Et voluptas eveniet et. Doloribus id molestiae sed. Accusamus ex dolorum libero id.\n\nVoluptates dolores adipisci officia et saepe accusamus excepturi optio. Commodi ullam laborum consequatur vel ducimus dolorum sunt odit. In eum sint ut rerum ipsum aperiam.\n\nSunt dolor debitis veniam. Nobis in sed occaecati quasi molestias. Veniam et sed doloribus.", "AMD Ryzen 5 5600X OEM", 16199m, "4721161", "00000000-0000-0000-0000-000000000001" }
                });

            migrationBuilder.InsertData(
                table: "PurchaseInvoices",
                columns: new[] { "Id", "UserId" },
                values: new object[] { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000003" });

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
                table: "ShoppingCarts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000003" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttributeValues",
                columns: new[] { "Id", "ProductAttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001", "AMD Ryzen 5 3600 OEM" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000001", "AM4" },
                    { "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000001", "2019" },
                    { "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000001", "6" },
                    { "00000000-0000-0000-0000-000000000005", "00000000-0000-0000-0000-000000000005", "00000000-0000-0000-0000-000000000001", "12" },
                    { "00000000-0000-0000-0000-000000000006", "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000002", "AMD Ryzen 5 3600 BOX" },
                    { "00000000-0000-0000-0000-000000000007", "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002", "AM4" },
                    { "00000000-0000-0000-0000-000000000008", "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000002", "2019" },
                    { "00000000-0000-0000-0000-000000000009", "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000002", "6" },
                    { "00000000-0000-0000-0000-000000000010", "00000000-0000-0000-0000-000000000005", "00000000-0000-0000-0000-000000000002", "12" },
                    { "00000000-0000-0000-0000-000000000011", "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000003", "AMD Ryzen 5 4650G OEM" },
                    { "00000000-0000-0000-0000-000000000012", "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000003", "AM4" },
                    { "00000000-0000-0000-0000-000000000013", "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000003", "2020" },
                    { "00000000-0000-0000-0000-000000000014", "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000003", "6" },
                    { "00000000-0000-0000-0000-000000000015", "00000000-0000-0000-0000-000000000005", "00000000-0000-0000-0000-000000000003", "12" },
                    { "00000000-0000-0000-0000-000000000016", "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000004", "AMD Ryzen 5 5600X OEM" },
                    { "00000000-0000-0000-0000-000000000017", "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000004", "AM4" },
                    { "00000000-0000-0000-0000-000000000018", "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000004", "2020" },
                    { "00000000-0000-0000-0000-000000000019", "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000004", "6" },
                    { "00000000-0000-0000-0000-000000000020", "00000000-0000-0000-0000-000000000005", "00000000-0000-0000-0000-000000000004", "12" }
                });

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

            migrationBuilder.InsertData(
                table: "PurchaseInvoiceItems",
                columns: new[] { "Id", "Amount", "ProductId", "PurchaseInvoiceId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", 2, "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", 3, "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000003", 7, "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000004", 5, "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000001" }
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

            migrationBuilder.InsertData(
                table: "ShoppingCartItems",
                columns: new[] { "Id", "Amount", "CreatedAt", "ProductId", "ShoppingCartId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", 1, NodaTime.Instant.FromUnixTimeTicks(0L), "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000002", 2, NodaTime.Instant.FromUnixTimeTicks(0L), "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000003", 1, NodaTime.Instant.FromUnixTimeTicks(0L), "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000004", 1, NodaTime.Instant.FromUnixTimeTicks(0L), "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000001" }
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
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000006");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000011");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000012");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000013");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000014");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000015");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000016");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000017");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000018");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000019");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000020");

            migrationBuilder.DeleteData(
                table: "ProductBalances",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "ProductBalances",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "ProductBalances",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "ProductBalances",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.DeleteData(
                table: "PurchaseInvoiceItems",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "PurchaseInvoiceItems",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "PurchaseInvoiceItems",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "PurchaseInvoiceItems",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004");

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
                table: "ShoppingCartItems",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "ShoppingCartItems",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "ShoppingCartItems",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "ShoppingCartItems",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "ProductAttributes",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "ProductAttributes",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "ProductAttributes",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "ProductAttributes",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.DeleteData(
                table: "ProductAttributes",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.DeleteData(
                table: "PurchaseInvoices",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

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
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

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

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");
        }
    }
}

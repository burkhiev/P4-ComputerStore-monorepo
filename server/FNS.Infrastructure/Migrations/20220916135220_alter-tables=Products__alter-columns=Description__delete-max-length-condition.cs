using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class altertablesProducts__altercolumnsDescription__deletemaxlengthcondition : Migration
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

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "8c1877fb-d773-4311-81d4-5ef7a61769d4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "bf452e0b-3b3b-45f7-ab4e-4fa1fc09b4b7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0664ad07-0b02-41d2-bd24-a64d551f79b1", "AQAAAAEAACcQAAAAECqtWnEgwk8OQxzbb/TmEkSuuTqO697HJLUk3Ny0erSCLBOnywJNznRkbKPYDVFZTw==", "ab9e22fb-26d8-470c-84de-b3285d5d89b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66776391-5e08-4527-a62d-c67ebcb962a0", "AQAAAAEAACcQAAAAEFVJy5UtzG3imga9B+HTwggEwivRqHLt2vEzSznlIIYr+XvGJQOeJ9UiiD5+g28/NA==", "9aadb86d-226a-4e36-b610-b51a3510ebd4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d957349-2e31-4f0d-93af-36393bec6174", "AQAAAAEAACcQAAAAEHkLQa69gvz6qs2cokVfjZHeb6Z7dVpxszLN4cAV/i9BcB8gGRw7D9f7lObAnd4iZA==", "5999dfde-ce82-452e-b580-5fddd0e1f486" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Et amet aliquam. Velit laudantium sed magnam voluptas est et non commodi. Et quo nemo ipsum. Incidunt laudantium expedita. Voluptas illo corrupti tenetur occaecati dolores sit molestiae maiores. Rem alias vel earum ipsa et.\n\nQuaerat distinctio vel aut nam neque. Ipsa et hic sapiente nihil eos. Non voluptates necessitatibus ad. Harum blanditiis voluptatibus qui. Eveniet porro impedit. Ab eos id occaecati unde laborum eos amet.\n\nOmnis dolor ut qui occaecati autem et. Quia enim tenetur nulla. Suscipit et quis quisquam vel omnis. Aut vero et unde quia. Sint nemo sint corrupti consequatur et molestiae laborum quod ea. Consequatur eum nisi voluptatem ducimus.\n\nNatus et distinctio animi eaque. Necessitatibus architecto nobis ullam cupiditate quibusdam et. Ipsam ratione incidunt quaerat est adipisci et. Magni in velit quaerat alias excepturi pariatur sed necessitatibus ut. Et maxime mollitia animi. Dicta laboriosam accusamus provident sint maiores temporibus.\n\nNon ducimus cupiditate molestiae doloremque et. Beatae fugit veritatis quibusdam sed. Adipisci libero quis eius ipsum beatae.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Provident porro repellendus. Iusto eos hic laboriosam. Iusto fuga expedita. Quod explicabo qui est.\n\nSunt consectetur repellat dolor dolorem. Qui facere incidunt optio enim aut distinctio. Perspiciatis maxime culpa sunt repellat sit consequuntur.\n\nAccusantium repellendus sit animi. In quia maxime qui reprehenderit et quasi et harum in. Qui perspiciatis optio voluptates. Unde dolorem nesciunt culpa est et qui. Libero in quae.\n\nImpedit quod nam ex iste excepturi incidunt quia impedit qui. Minima ut et impedit neque molestiae autem labore aliquam non. Et nihil illo hic molestiae doloremque inventore qui tempore. Occaecati consectetur natus aut nihil quia voluptas dignissimos et. Quos molestias esse id in architecto aperiam in veritatis repellendus. Praesentium enim magnam perferendis aut commodi reiciendis.\n\nVelit nihil ducimus. Aut iusto tenetur et. Accusamus temporibus vero nesciunt quibusdam adipisci facere dolore. Velit et perferendis aut. Delectus soluta perferendis sit eveniet quod cupiditate. Recusandae minus qui quam veniam ullam ipsa molestiae.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Consequuntur quia iure officiis sit. Hic aut magnam et aut molestiae rem. Ut sed ea. Ut et ad et vel qui aliquid.\n\nAut deleniti facilis sunt. Magnam maiores recusandae. Nisi corrupti repudiandae nobis expedita.\n\nTempore adipisci ad non adipisci eveniet perferendis voluptatibus rerum. Numquam qui occaecati deleniti. Eius qui praesentium quo. Repudiandae libero illum optio dolor et minima ea ad.\n\nIusto ut est. Et et dolor. Quibusdam molestiae nisi in inventore id autem. Cupiditate dolores est fuga molestiae ea. Debitis officia est qui. Repellat et iure delectus cumque aliquam sed iusto incidunt.\n\nEt sed pariatur reiciendis accusamus voluptate. Tenetur eum voluptatem id praesentium. Dolor sed id odit ut et veniam impedit. Consequatur ratione eum saepe nihil veritatis ut harum quo ut. Perspiciatis voluptatem odio quis officia consequatur unde eos officiis officiis. Molestias voluptas saepe consequatur ullam iure.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Quisquam animi voluptatem possimus sit sed nesciunt. Rerum ut architecto et voluptate odio magnam nihil voluptas dolores. Voluptatum quasi quos quod. Eos voluptatum ducimus. Praesentium sunt qui veniam qui.\n\nVitae pariatur at sapiente aut eligendi maxime vero odio fuga. Optio tempora et dolores. Est magnam dolor architecto aut tempore. Corporis et qui quam distinctio adipisci adipisci unde cum et.\n\nEst omnis qui suscipit. Iste sunt perspiciatis voluptatem et ratione. Soluta excepturi quas sequi voluptate dolorem nisi nobis quis. Repellendus distinctio in sit qui est et.\n\nConsequatur quod explicabo molestiae qui nam magni enim. Iusto doloremque qui. Quod et repudiandae aut aut eveniet recusandae rerum. Aut numquam et fugiat iure. Amet quibusdam repellat atque. Voluptate animi qui et ea.\n\nSint consequuntur ea officiis veniam enim tempore dolorem quod velit. Nesciunt illum iste earum eaque occaecati vero sunt ut. Qui culpa aut.");

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
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "character varying(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16545679357050127L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16483917109944861L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16368783389766483L));
        }
    }
}

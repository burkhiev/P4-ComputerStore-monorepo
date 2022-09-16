using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class altertable__tableProductAttributes__deletecolumnMeasure : Migration
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

            migrationBuilder.DropColumn(
                name: "Measure",
                table: "ProductAttributes");

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
            migrationBuilder.AddColumn<string>(
                name: "Measure",
                table: "ProductAttributes",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "205f112b-447d-412a-82a4-0a83ccd285b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "5c22ebfb-ddf4-4bb0-a8f2-0ddc952e9594");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b90c4ffa-381f-4f21-9331-5539d0b9adf9", "AQAAAAEAACcQAAAAEBR/1shOo/nkUtRyMuExBS1TdU2HmTv9FB1MFXds7bbP4xlQjA5slNVYgTfan77WRQ==", "0c849343-d011-4707-93b8-490f14296f10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a63bc00-d445-4daa-9dd6-a1c1354ed89e", "AQAAAAEAACcQAAAAEPG485VBHZisdDQxQAzPcRD3f/kQqvuvJDrZc8ZA92ZzMJKu/xIWVYlxfgVzMVM7NA==", "f030f409-ffdb-4394-80f8-acf57373327f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "788101fc-c4af-4425-8b92-503ceb2afe7f", "AQAAAAEAACcQAAAAEMpZ/SwcieJ8jTVaB9H1rmfbs2p7hxuvRs4Hyv/ypFUA3LeL1tYdazjxCn+Tv8r2hw==", "907af006-32a7-4f84-a704-fd4961b2ae9c" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Sunt enim facere et a inventore et dicta sed voluptate. Natus repellat aut beatae necessitatibus laboriosam temporibus repudiandae ea. Explicabo in enim quisquam blanditiis ea quia.\n\nEt impedit accusantium at culpa ut non et. Inventore quia maiores quia tempora provident accusantium est eum. Aliquid voluptates eos.\n\nPerspiciatis consectetur sit tempore tenetur placeat illo. Maxime rerum quos perspiciatis ipsa dicta veritatis doloribus. Iste et sed sint consectetur molestias sint ab quam et. Ut hic quia est expedita.\n\nRerum iusto asperiores fugiat veritatis. Soluta dolorem exercitationem deleniti et nesciunt et sunt id. Error quibusdam quasi est repellendus expedita libero nobis molestiae pariatur. Ipsam eaque aut sed corrupti. Atque consectetur ut dignissimos error. Nemo sit dicta iusto ut corrupti.\n\nDolor fugit ut dolor architecto est. Repellendus consequatur et rem velit itaque. Perspiciatis magni id commodi voluptatem.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Et mollitia sit ea iure voluptas provident quia et. Voluptatem rem quae id dolor ipsum nulla et debitis qui. Nulla repudiandae sed odio quasi dolor accusamus illo est odit. Quia est incidunt eveniet. Quis ut ullam odit.\n\nIusto ratione asperiores iste rerum provident temporibus aut beatae et. Qui laborum voluptatem quia ut et et rerum omnis. Error laborum et id laboriosam voluptatem.\n\nSed laboriosam officiis sed dolores. Optio magni culpa. Dolor provident modi vel ducimus est.\n\nDignissimos similique explicabo enim quia qui. Et rerum aut vel accusantium. Nemo ut voluptatem eaque perferendis ut repellendus quasi amet ab. Non id omnis totam. Inventore soluta eligendi.\n\nNulla corrupti saepe sequi repudiandae ullam repellat architecto. Qui odit est et qui deserunt necessitatibus eum in. A rem veniam iusto. Rem et aliquam officiis. Consectetur quaerat fugit.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Sequi dolorum sunt nisi. Dolorem velit hic et ut ipsam aut aut enim. Et earum nam. Quod aut voluptatem laborum quia incidunt excepturi veritatis autem saepe. Omnis molestias rem eaque repudiandae minima et.\n\nEt enim explicabo natus molestias quam. Ratione aut autem voluptate fugit. At amet id sed.\n\nAut nisi rerum sapiente ut ipsum pariatur repellat nihil. Est itaque suscipit cupiditate beatae aut sunt. Velit earum qui autem porro soluta itaque magnam in illum. Aperiam atque consectetur fuga labore eligendi aut. Aperiam quia eius vitae corrupti minima. Consequatur rerum sapiente.\n\nDebitis vel ea cum quas. Quibusdam a hic recusandae. Occaecati ipsam iure sit animi praesentium beatae dolorem rerum earum.\n\nConsequatur ut est quibusdam omnis natus consectetur est nulla. Explicabo libero assumenda saepe. Laudantium totam qui occaecati voluptas. Corporis explicabo corrupti repudiandae recusandae ut nihil sint cumque quo.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Nulla in molestias voluptas sed a velit dolorem pariatur. Nemo molestiae praesentium quod ipsam minima ab. Doloremque ea dolor optio est quo. Beatae nostrum est assumenda ipsa atque facere deleniti voluptatem.\n\nNeque nihil iure eligendi et et officia ad voluptas voluptatem. Consequatur quis enim omnis voluptatem quia qui quos. Aut dolore recusandae eum officia veritatis culpa autem et vel. A quis modi sit fuga. Natus vel dolorum. Facilis ut iure laborum optio reprehenderit veritatis.\n\nAut non deserunt voluptatem repudiandae voluptatem illo quo sit. Enim perferendis illum. Tempora quidem amet. Placeat eius quidem doloremque aut. Voluptatem officiis fuga nulla praesentium.\n\nConsequatur cum eum eos. Possimus reprehenderit similique ut corrupti. Dolores ut inventore.\n\nConsequatur numquam neque aut minus iusto totam. Eius quisquam iure fuga id molestias. Repellendus pariatur et est earum sit voluptatibus.");

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16497438198355340L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16368549622004121L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16604457698210827L));
        }
    }
}

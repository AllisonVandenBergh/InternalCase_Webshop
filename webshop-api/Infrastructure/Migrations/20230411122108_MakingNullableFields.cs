using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MakingNullableFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("00cf9611-15bf-fbaa-c181-aac13635605c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("012d6893-a8d3-a776-dde1-aa0dda910d2a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("068c1cd4-acc6-60ad-ac68-1414282b1157"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("082d63e0-3116-83a5-3cf3-318fce685d44"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0a288fc9-dd09-e65e-c10a-efbf8f8b1598"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("17c33da1-d92b-c22b-3fc2-c32e03e9c657"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("19eae9e0-bc6d-f539-f965-1055bd0feb08"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("19f5fbc3-f676-197d-412e-619106037fe9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1da9e4de-9c1f-33ab-fefd-7f5ceb7c0d42"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1e2187d9-034e-9ba7-2b6f-e7c18b7b6a8e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1e5d342d-a34e-fbc0-d1fb-c6229274f719"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1e8c7ab6-4663-f6ea-7f97-778426e65a94"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("20ada9d1-27d4-96b7-7150-7041201c899a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("246fa4d4-d302-c13f-bba7-871ef2f2494a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("247d22ec-1eec-a49c-3e3a-ad764760fd44"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("25629ef7-6bf8-5ee9-97d3-e6bacb9ddd5b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("268c562c-63de-c825-f579-e0914424b344"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("27a25346-af54-aab9-f094-8620fe7aeb52"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("28405536-d543-5017-8e93-3e34dd347237"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("292dcec2-bd51-11ad-aaae-8d4cac0aa768"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2c768883-fe7d-51c9-0b3a-866880327ff2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2e3a08e6-afc2-7d19-eb92-845e36d25505"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2f912ec4-94ea-46d2-be66-0b1b9bef6260"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3dda1f0f-769d-dfa4-f96a-9c68a2ae47c3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3e42cfc0-60dd-f669-6b3e-b81401afcf33"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("42f71f88-be56-1658-eea4-e5fcec57c529"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("449f432b-acb7-73f7-34bd-4c85094abe11"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("465fdd4d-f30b-64de-056a-a6515741d861"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("47da461c-c1a9-0a4f-c642-a83c8edfbbbb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("49979d68-4029-e687-e4b6-dac85c036bd9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4adff065-be8e-7943-3a27-7f14aab9a9fe"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4b2bc2c6-3d7d-1b63-92c4-99759cc41016"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4cff4f61-08f9-72b1-65d0-dc4fc8e7eba5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5511f169-20a5-8e7a-9811-f6d46564b1ec"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("57c18b50-b8a0-cb88-42e8-a713c87888d5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5a24b0fa-ef28-f9da-f534-c09543727bec"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5a781ffd-64ec-5810-e826-daa7b0dcce32"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5ad5c4fd-5436-9530-5f06-b8bdb7c30ddb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5ebdadaf-c5f3-7144-f015-edbf319b1cc1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5f0100bf-4ace-6b42-b92d-51982d7290c3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("60407fbf-9d03-7469-d2b5-5cae5ce40e7f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("624af5ea-52c7-45bb-4650-ad9d6658cf0e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("65aefece-120b-76d7-1585-ee47e7a1fcf3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6a6af56e-7db5-f730-85a8-c4541622564e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6bb53ab6-daf9-45ae-96b1-f3c9458d1afe"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6d762127-1628-0588-0b80-1a02d1fe3079"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7087b731-11b5-38ab-33a6-3de335bb778f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7163f3fc-2d04-0694-6491-54becf8b63f8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7193ca67-3fcb-7631-79ee-1b9bc4db2b72"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("751072b9-fb2c-8da3-b218-2e1146143f7d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("76741f79-f64d-8ee6-4d77-ca6995e1ddd1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("79a164ed-622e-59bc-de7a-d27978786d03"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7adee555-c402-4d6c-c4a6-d6143aefdd8a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7af1dd25-6a30-4a0e-9644-62c7d1cdfc4f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("80c5ae84-7d79-1f16-8889-5725a25f2df0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("82562760-25bd-ce40-1727-36aea3f07bc3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("849be868-2b5a-392d-c624-c3b40675853f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8c0e9142-44e0-7b29-600b-014e5d05696d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9138d4ca-9791-ce8c-a266-b33caf8933c5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("91bbe44d-f3e9-d2f3-1f5f-6e1e9827893a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("929a9850-adb1-dfbc-66f9-874b3bcb23e6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("93800a91-954d-cea2-0c7c-cb374102feb8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("948021f4-7b0f-148f-47e8-425037341471"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("955e0442-3b8a-4d5c-40b7-c6a8b7616a4f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("96077075-a36d-1054-3084-7a7ef66e195b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("98555eca-dae8-b8d0-9a51-57322aa2d7a7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("99471579-028d-4aa3-9b0a-15663990983d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("999b194e-bd10-f530-3b42-7c4304ed7183"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9c695564-e8f9-d7ae-97d5-f968512c97c6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a0e627be-70ee-7855-b0bd-5dc7fc68917b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a149b5f0-efe7-2917-b4cd-557be823473d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a3c19545-6baf-dc98-49e4-22fafc63ecb0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a4459622-002d-e690-719d-bdac177f2cf3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a5cd14c2-3cf6-0f70-ab15-ec01702ced3d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("aa1b7933-3a03-b468-31d3-6b45fe0882d0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("aab77175-ebd0-5790-3f26-6585f0a55e5b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("aba3ee17-5475-9e7f-4564-b5d8053c3f25"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("aee7953a-eda0-5987-5bc3-a470c0837233"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("af372266-9f98-3bf3-b208-0e76dff6089a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b4c3ab67-81ea-1196-dc79-e58a2609aea0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ba03574e-dbbf-499f-ae10-41bfb3274c82"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bfaf104f-6be3-23e9-ea1f-387cb4a1a76c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c6761cbe-5ae5-a908-4f65-8c8f5cdfb5a9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ce0a583b-749e-40f3-389e-65ee0308bd7f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d2e7ee8f-849d-b6e1-3975-bc29b3f762ee"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d565107e-b733-f680-7997-17711f50399b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("dc54d0ae-cf45-e534-2c94-7312b58c9139"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("de3fc567-ec93-e4d6-b4ff-63fa31ec0e9c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("deeac7c3-2010-7dd8-c21c-31f3366bab8b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e9236c85-e7c8-f968-dd17-cfb08c5af7b1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ec1364da-207d-0cf6-2be1-0aeedeea0f0a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ecb5964d-6c81-1b55-fc28-b870b00b1bd8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ee25b3ea-a13c-c17f-6047-6363f28889ec"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("efe9d55b-d72b-3c63-4257-f6c7e494efe6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f0c9b235-6b3e-6581-0a47-5c62031a2045"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f1b7ef53-0c81-56e3-45d4-ff57e08c8fa7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f43dd0a7-f875-a15d-64ae-8e0cedec4b97"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f7a27557-1f75-4562-392d-57627919c8e6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f9b86542-3421-4ae9-0a43-f387bae16872"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fdc39124-2b0a-b11b-18fb-7260523b5d34"));

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "BasePrice", "Description", "Image", "InStock", "Name", "SellPrice", "Sku" },
                values: new object[,]
                {
                    { new Guid("004ba63c-0a4e-c676-88fa-acb6d09738c3"), 737.09000000000003, "Velit voluptas reiciendis qui facere nostrum sint molestiae consectetur.\nRatione debitis doloremque vel.\nAspernatur qui enim voluptatem iure voluptatibus numquam ipsam quis.\nLaudantium at illum tempora.", "https://picsum.photos/640/480/?image=936", false, "Small Rubber Cheese", 887.65999999999997, "xnbzsyhjglz" },
                    { new Guid("00c6fdbc-fa66-fe69-e635-ba81bf143e98"), 204.49000000000001, "Dolor aut dolores quas autem.\nCupiditate ullam vel ipsam.\nVeniam iure aliquam vel.\nNisi accusamus quia.\nTotam veritatis sunt porro.\nDignissimos adipisci quia ducimus totam nihil et distinctio.", "https://picsum.photos/640/480/?image=1001", false, "Handcrafted Granite Chicken", 748.90999999999997, "drywvanssbdq" },
                    { new Guid("0ada1ea0-397c-5eac-8e14-3f8c45a8e73a"), 24.510000000000002, "Dolorem iste maiores adipisci voluptatem.\nRerum molestias esse sit unde voluptas eos assumenda.", "https://picsum.photos/640/480/?image=358", true, "Practical Plastic Pizza", 295.75, "duymbefkgl" },
                    { new Guid("1455d3f3-dc3c-a0ad-0389-862293c746b1"), 556.49000000000001, "Eaque error labore fugiat esse nam qui laudantium ut aut.\nDolor nesciunt dolorem quaerat minima sunt inventore voluptatem.\nUt iusto veritatis qui commodi.\nEnim nesciunt quis dolores.\nAutem sit consequatur quos minima voluptatibus aspernatur.\nId quas tempore vel omnis impedit.", "https://picsum.photos/640/480/?image=477", false, "Sleek Steel Tuna", 773.96000000000004, "hsvsxcpnaq" },
                    { new Guid("175f177f-fa2b-1569-258e-9f5ab3140fc2"), 753.75999999999999, "A quasi deserunt nulla ut porro animi error aperiam.\nEt nihil beatae doloribus sed sint.", "https://picsum.photos/640/480/?image=422", false, "Refined Steel Chips", 127.04000000000001, "lpjhuhnijoda" },
                    { new Guid("2402d8a0-712f-b423-390b-5b5fd2e76aa3"), 41.229999999999997, "Molestias dignissimos ut corporis aut sed non.\nVitae optio non beatae iusto nemo.", "https://picsum.photos/640/480/?image=88", true, "Handmade Granite Shirt", 14.710000000000001, "ycmttizqheb" },
                    { new Guid("24de1900-f484-4b45-dbb2-c57d7f193712"), 865.99000000000001, "Est pariatur sint.\nVoluptas voluptas omnis atque molestiae culpa.\nIn tempore ut architecto corrupti.", "https://picsum.photos/640/480/?image=885", false, "Handcrafted Soft Pizza", 87.900000000000006, "yaokqker" },
                    { new Guid("28cbeace-280d-52d0-b08b-c6d612e0c2ca"), 184.08000000000001, "Laborum neque nostrum corporis et necessitatibus incidunt ut.\nCupiditate ea minus maiores ut ratione est voluptatem et blanditiis.\nSed aut quos provident at.", "https://picsum.photos/640/480/?image=533", false, "Licensed Steel Hat", 200.24000000000001, "kkhatfvxf" },
                    { new Guid("292372bb-5a4e-6eb9-2b08-d4fe17337648"), 594.87, "Aut suscipit quae molestiae.\nOdio sed aliquid rerum error est voluptatum deserunt eos.\nEveniet dolorem sit.\nNemo asperiores perspiciatis temporibus reprehenderit omnis maiores accusantium.\nOmnis et labore.", "https://picsum.photos/640/480/?image=648", true, "Practical Concrete Chips", 868.77999999999997, "xtulanjmvghz" },
                    { new Guid("2933d59b-895d-b08e-3861-cced9e674d1b"), 609.01999999999998, "Sit laborum corporis dolorem.\nOdio laudantium provident aut.\nEos quaerat provident est.\nIncidunt occaecati est natus.\nId magnam minus illum temporibus maiores.", "https://picsum.photos/640/480/?image=160", true, "Tasty Cotton Hat", 75.299999999999997, "lxmopcqw" },
                    { new Guid("2aa78a7d-2ea2-e051-06fb-b8d496db2459"), 823.84000000000003, "Ut doloribus esse autem magni.\nAut eaque et pariatur excepturi enim tempora unde.", "https://picsum.photos/640/480/?image=806", false, "Fantastic Metal Mouse", 145.27000000000001, "ftkpvjdu" },
                    { new Guid("2b29144a-89ba-7fad-a53a-8f1cfc37c2dd"), 878.5, "Error est beatae voluptas quia nisi cumque.\nVitae voluptates ut optio et nemo nihil quisquam quibusdam.\nNihil asperiores et consequatur sunt consequuntur ipsam.\nQui qui qui nam laborum omnis eligendi earum.", "https://picsum.photos/640/480/?image=708", true, "Incredible Soft Shirt", 499.27999999999997, "mkgrokysui" },
                    { new Guid("2fd8670a-5be6-58ac-ef4a-074edd87e8a8"), 189.58000000000001, "Officiis sit temporibus incidunt consequatur neque incidunt eius magni dolores.\nAd voluptas eligendi tempore doloribus aspernatur sint modi distinctio sit.\nAdipisci earum sunt et ex quidem.\nEa eius commodi doloribus nam veritatis recusandae.\nVelit asperiores sit enim dolorem inventore distinctio aut.", "https://picsum.photos/640/480/?image=72", true, "Tasty Granite Fish", 430.12, "axtzbtnxndz" },
                    { new Guid("332babd3-6692-b1ab-fd47-e80de252a913"), 856.20000000000005, "Reiciendis facere sint voluptatem sit non ex.\nDolorem voluptas alias ut repudiandae est aut.\nOmnis ea neque.\nAt sed facilis et voluptatibus omnis sunt aut aut sed.\nQuo architecto quam rerum assumenda blanditiis et tenetur.", "https://picsum.photos/640/480/?image=439", false, "Small Metal Bike", 351.00999999999999, "ghnlhmdt" },
                    { new Guid("38451d51-6e2e-293d-f0f7-218b815b1a9d"), 714.45000000000005, "Expedita est veritatis fugit ipsam autem est occaecati ex.\nReprehenderit corrupti ut sapiente laudantium et minus.\nAliquid blanditiis necessitatibus et illum.\nEst ut suscipit in sit dicta sequi rerum praesentium.\nSint deleniti consequuntur voluptatem corporis unde.", "https://picsum.photos/640/480/?image=464", false, "Unbranded Cotton Pants", 774.79999999999995, "oxtsjvnwwmtl" },
                    { new Guid("3aa14181-ac0d-157d-83f6-a743c25cc8cd"), 843.52999999999997, "Nisi quia rerum ut eius.\nNeque delectus optio corporis ad.\nOptio soluta et veniam et magnam necessitatibus quam non sed.", "https://picsum.photos/640/480/?image=119", false, "Rustic Cotton Shoes", 626.52999999999997, "lmxyugxgqfcl" },
                    { new Guid("3e26dadb-428f-4528-905f-03a7917bcb1e"), 676.83000000000004, "Ut nisi officiis consequatur dolore quia architecto.\nQuis velit porro animi impedit earum dolorem.\nEt et veritatis nobis.\nFacere amet quis voluptatum nemo error nulla est perferendis.\nNon laboriosam earum sunt quia modi maxime occaecati.\nCommodi modi nemo molestiae aut itaque maxime ut quisquam.", "https://picsum.photos/640/480/?image=1065", true, "Generic Plastic Ball", 954.54999999999995, "bhwigmdr" },
                    { new Guid("3f9d568e-6d6d-18c0-12cd-65059b564137"), 955.12, "Consequatur in saepe quasi et quis dolore asperiores.\nEarum saepe unde et.\nQuidem soluta commodi beatae repudiandae beatae quo.\nCumque sed aperiam libero.\nPossimus aut aliquam.", "https://picsum.photos/640/480/?image=555", true, "Tasty Metal Mouse", 39.509999999999998, "warakyqwmnn" },
                    { new Guid("3fe40d8a-e59e-c739-ac08-9640a2e43740"), 29.960000000000001, "Ipsam quibusdam repellendus voluptas.\nIpsum molestias blanditiis omnis fuga et voluptatum est nemo dolorem.\nEos provident harum est vel animi laudantium dignissimos a ducimus.", "https://picsum.photos/640/480/?image=1048", false, "Handmade Rubber Sausages", 847.22000000000003, "cucfbxklsxsh" },
                    { new Guid("42bd727f-7630-f148-d262-65e242d1bf7a"), 44.590000000000003, "Inventore unde voluptates qui.\nEaque aut illum quidem eius repudiandae itaque nam ullam doloremque.", "https://picsum.photos/640/480/?image=943", false, "Unbranded Soft Pants", 847.0, "unoxzbpstk" },
                    { new Guid("43a2b9d0-70fc-917f-76d0-c51172875f53"), 390.81, "Officia ut maiores nisi nisi error aperiam ratione corrupti.\nNobis sit quasi voluptas et.\nAutem voluptas minus molestiae consequatur quos voluptatum est.", "https://picsum.photos/640/480/?image=515", true, "Sleek Wooden Bacon", 92.390000000000001, "mquastwahvyc" },
                    { new Guid("461cd018-4ebb-3a86-df96-74905eef92b5"), 661.19000000000005, "Quasi quasi sed quos sit non praesentium vel esse perferendis.\nVoluptas laboriosam suscipit maxime molestiae.\nEarum omnis eaque laudantium aspernatur.\nDoloremque ut eos aperiam aut recusandae explicabo dicta sit ab.\nEveniet quam nihil aut ut quia molestiae quis.\nOmnis aut porro labore qui voluptate sit.", "https://picsum.photos/640/480/?image=946", true, "Tasty Concrete Tuna", 292.54000000000002, "spwoyzmylyw" },
                    { new Guid("46c5bedd-ed4d-dfd3-8ac7-429a425c853a"), 612.28999999999996, "Veritatis impedit repellat.\nExercitationem nobis nihil maiores voluptas.\nEt eius placeat reprehenderit temporibus dicta at.\nCulpa minus asperiores assumenda blanditiis perspiciatis molestias.\nQui natus quis eos repudiandae eius ab modi odio.\nRecusandae eum facere enim quas consequatur ut repellendus nesciunt.", "https://picsum.photos/640/480/?image=155", false, "Intelligent Plastic Chair", 917.63999999999999, "pjvizniixdsb" },
                    { new Guid("4968b67a-181f-1085-93d6-4d393f0f1db4"), 809.12, "Consequatur ipsum maiores et quae ex omnis qui aut minima.\nVel quaerat quae numquam delectus mollitia amet sunt.\nHarum voluptas non neque quidem molestias quia eaque dolore modi.\nAccusamus ut ullam molestias.\nOfficia aut et.\nUt quia et.", "https://picsum.photos/640/480/?image=864", true, "Gorgeous Cotton Ball", 564.32000000000005, "ueukzhqckp" },
                    { new Guid("4b13572f-2fa0-ed0e-bd35-b90d1c5f5fd8"), 643.55999999999995, "Nemo voluptates quia quia beatae molestiae nemo reprehenderit nesciunt.\nNemo nam ea iusto minus est et voluptatem.", "https://picsum.photos/640/480/?image=555", true, "Generic Rubber Chicken", 711.14999999999998, "kkibazftj" },
                    { new Guid("4c60222b-d6b3-c348-0af9-4b15fc3ba2ed"), 689.35000000000002, "Reiciendis iste error quia et.\nQuia dolor esse.", "https://picsum.photos/640/480/?image=764", false, "Sleek Plastic Tuna", 197.66, "ghlapxppn" },
                    { new Guid("51a2e216-9526-e496-1ce4-84b1d524376f"), 17.690000000000001, "Dolor velit vero vero saepe non consequatur aliquam maxime.\nEst est tenetur ut omnis esse blanditiis libero corporis.\nQuidem mollitia facilis corporis modi harum voluptas.\nMagnam similique quisquam adipisci dolores modi vel delectus aut nihil.", "https://picsum.photos/640/480/?image=189", true, "Ergonomic Wooden Bacon", 626.97000000000003, "wmgssrdnaaj" },
                    { new Guid("51cf19f4-c156-3e9d-b5a4-531f732a0b1f"), 752.74000000000001, "Quidem explicabo commodi tempora.\nIste quis molestiae aut mollitia reiciendis in occaecati.", "https://picsum.photos/640/480/?image=503", true, "Fantastic Granite Ball", 179.65000000000001, "tkmeqjzcs" },
                    { new Guid("5272ed70-891a-0603-e18f-914cc449fdc3"), 28.550000000000001, "Consectetur totam necessitatibus ducimus consequatur nobis fugiat ullam.\nQuia et et rerum a.\nUt ut vero dolor ut harum expedita nesciunt tenetur.\nAt at magni reprehenderit id quia.", "https://picsum.photos/640/480/?image=69", false, "Ergonomic Frozen Pizza", 616.76999999999998, "qszseqeamm" },
                    { new Guid("54050131-cb44-01e2-a5b0-01c2dbb50d07"), 445.02999999999997, "Quia et nisi omnis.\nEt dignissimos at ullam libero accusantium commodi eligendi nulla et.\nDeleniti aut omnis quia molestiae dolores modi soluta.\nNemo enim ipsa architecto natus id alias reprehenderit.", "https://picsum.photos/640/480/?image=1043", true, "Handmade Wooden Pizza", 75.629999999999995, "rpbfzvof" },
                    { new Guid("5413fd3f-3388-6538-c4ca-25b59fec1dd4"), 37.549999999999997, "Iusto aperiam excepturi rerum tenetur similique accusantium est id et.\nSit accusantium sed.", "https://picsum.photos/640/480/?image=176", true, "Intelligent Cotton Pants", 180.63999999999999, "iwiuzctrig" },
                    { new Guid("564541ab-8712-2e70-827c-a10e70db0a99"), 478.30000000000001, "Possimus sint ab.\nAt corporis voluptas fugiat voluptatem totam error.\nVoluptatem explicabo rerum in eveniet explicabo aut qui.", "https://picsum.photos/640/480/?image=95", false, "Fantastic Fresh Keyboard", 986.47000000000003, "boeagkfqx" },
                    { new Guid("56b9ba20-8b40-0b0f-288d-4c0cd070330b"), 197.87, "Fugiat saepe est provident nemo perferendis ut molestiae sit.\nVoluptas expedita reiciendis autem atque itaque deleniti quo enim commodi.\nA vel et explicabo ratione laborum est voluptas.\nIllum repellendus porro necessitatibus culpa.\nHic alias quibusdam et aut dolores error atque.", "https://picsum.photos/640/480/?image=76", true, "Small Metal Shirt", 763.58000000000004, "amdcpgugjl" },
                    { new Guid("5704c265-68d7-817f-2332-50b008c9f3bc"), 166.41999999999999, "Laudantium ut eius deleniti eius id eum optio nesciunt.\nAut facilis maiores.\nEius quia quo reiciendis.\nVelit sint repudiandae.\nNobis neque officia ad facilis.\nVeniam voluptates voluptatem eum laboriosam.", "https://picsum.photos/640/480/?image=143", true, "Practical Steel Soap", 734.00999999999999, "rqyznnlvwpv" },
                    { new Guid("59125dc8-0506-9b4e-3368-f2b5461539b4"), 513.38, "Molestias totam provident deserunt earum.\nAtque possimus praesentium sunt.\nAspernatur impedit voluptatem fugit.\nLaudantium ea eligendi ut in voluptas vitae adipisci aut amet.\nSed mollitia suscipit excepturi facilis ratione fugit et cum tempora.\nSit explicabo qui et quod quasi quasi eveniet.", "https://picsum.photos/640/480/?image=633", false, "Handcrafted Fresh Towels", 712.83000000000004, "hajesaprtyh" },
                    { new Guid("5aa522f6-4a16-34ea-f530-e253985886a1"), 173.03, "Labore est ut modi ratione.\nEt dolore eum totam.\nEt iste accusantium illum architecto.\nItaque recusandae ex non dolorem odit pariatur.", "https://picsum.photos/640/480/?image=290", true, "Handcrafted Frozen Gloves", 810.11000000000001, "nsaxmhcgad" },
                    { new Guid("5c734533-e2dd-d944-f5c4-bbd093e0ccb0"), 816.03999999999996, "Libero modi maiores optio et.\nSoluta rerum et voluptatem harum ducimus quasi voluptas sequi.\nEt labore culpa perspiciatis et.", "https://picsum.photos/640/480/?image=1018", true, "Sleek Rubber Fish", 73.260000000000005, "wdzewfcs" },
                    { new Guid("6c91b6cb-ad56-e683-3d3e-eae9eaf69ebf"), 150.08000000000001, "Totam saepe dolorem.\nTemporibus odio quae ut aut.\nConsequatur qui enim.", "https://picsum.photos/640/480/?image=385", false, "Rustic Steel Ball", 793.36000000000001, "eugmplvib" },
                    { new Guid("6e0bf071-d146-0f2d-a800-eec0fe109351"), 245.06, "Qui et tenetur earum accusamus quis rerum.\nCum occaecati facere voluptas.\nSed et dicta necessitatibus consequatur natus iusto facere.", "https://picsum.photos/640/480/?image=562", true, "Tasty Rubber Tuna", 825.57000000000005, "jueimlkgznx" },
                    { new Guid("6f93ea62-d64b-7956-bf19-e296846e703d"), 63.609999999999999, "Voluptatum quis quo aliquam omnis earum quam voluptatibus.\nIste placeat quia necessitatibus sint qui voluptates.", "https://picsum.photos/640/480/?image=871", true, "Licensed Soft Ball", 562.94000000000005, "jhuxwqwcvve" },
                    { new Guid("76e80e97-6692-1399-72ca-33ebaff22f91"), 861.67999999999995, "Modi aperiam accusamus debitis.\nEt nihil reiciendis numquam.", "https://picsum.photos/640/480/?image=875", true, "Ergonomic Wooden Fish", 468.50999999999999, "bxggwhge" },
                    { new Guid("7829c11a-ef69-ad10-8f23-c5c262ac5082"), 485.05000000000001, "Quo et iste minima quia.\nConsequuntur consectetur dignissimos natus.\nAut corrupti aut veniam aperiam.\nNihil voluptas labore harum.\nLibero non laborum tempore vero rem.", "https://picsum.photos/640/480/?image=540", false, "Sleek Steel Table", 857.91999999999996, "gloslyspucri" },
                    { new Guid("7fa8f0f1-d908-bfa9-05ec-06fbca0150aa"), 742.46000000000004, "Harum labore consequatur assumenda qui alias.\nIste voluptas officiis id explicabo.\nDolorem quia quos assumenda quod dolores est necessitatibus dolore.\nEx corporis voluptas vitae et.", "https://picsum.photos/640/480/?image=828", true, "Small Cotton Pizza", 211.53, "anynhtiika" },
                    { new Guid("811f78a2-f095-eb07-ad3f-0665f54b9244"), 761.29999999999995, "Expedita tenetur modi a.\nSimilique nobis ut modi deserunt fugiat.\nVoluptatem ducimus quod quo sunt ut animi error aliquam omnis.\nDistinctio voluptatem nisi enim cupiditate doloremque cumque fugiat optio.\nVoluptatem quam repudiandae repudiandae et dolor dolor non.\nQuis quasi aut.", "https://picsum.photos/640/480/?image=96", true, "Awesome Soft Shirt", 140.61000000000001, "ywtxwlmbmich" },
                    { new Guid("82250133-526d-57c8-cc18-3412aded6d39"), 374.35000000000002, "Maiores recusandae inventore ut ab sequi ipsam.\nQui nam et.\nCupiditate autem praesentium vel facere est repellendus.\nEligendi quia et culpa et blanditiis sit ut.\nSunt expedita omnis blanditiis.", "https://picsum.photos/640/480/?image=29", true, "Practical Wooden Salad", 990.77999999999997, "ohdginivaaon" },
                    { new Guid("82509e4e-0071-db47-d60a-91fb42a9f079"), 675.70000000000005, "Ratione et veniam officiis perferendis.\nDoloribus porro ut omnis dolor.\nUt ut explicabo asperiores.\nTotam modi recusandae magnam maiores quis praesentium voluptatem et.", "https://picsum.photos/640/480/?image=68", true, "Tasty Concrete Shoes", 68.099999999999994, "gjkoqrakl" },
                    { new Guid("83648d9d-cc0b-bf20-3d29-981b3764d314"), 839.38999999999999, "Iure excepturi autem accusantium quae id est tempore.\nEligendi laudantium ratione soluta harum alias atque.\nError enim reiciendis cupiditate quibusdam ut debitis.\nQuo qui voluptate et cumque quo nesciunt.\nQuia non sed ut non.\nMolestias et non harum.", "https://picsum.photos/640/480/?image=943", true, "Intelligent Cotton Pants", 499.23000000000002, "chknbyczay" },
                    { new Guid("84012d81-3e79-4e37-ca36-17e51da2bd40"), 593.15999999999997, "Neque enim placeat repudiandae.\nAut voluptatem earum distinctio ut.\nSuscipit culpa cupiditate et delectus dolores totam deleniti.\nAut error et quas illum commodi rerum.", "https://picsum.photos/640/480/?image=294", true, "Intelligent Granite Mouse", 146.03999999999999, "emyjaecnrx" },
                    { new Guid("84c358dc-1c49-3137-b727-52d2309900b4"), 145.91999999999999, "Quasi occaecati minus ut.\nMolestiae odio reiciendis modi ea ut consequuntur.\nEt repudiandae est.\nQui velit impedit ab dolores alias perferendis odit eaque.\nLaborum molestias optio voluptatem iusto necessitatibus id ea eaque odit.\nEum quis dolorum nam omnis cum dicta rerum laborum.", "https://picsum.photos/640/480/?image=252", false, "Ergonomic Wooden Car", 523.03999999999996, "tliarrbjep" },
                    { new Guid("8771e776-73a1-763b-9bde-5491da7b53ab"), 945.38999999999999, "Sunt a delectus et laudantium deleniti autem sit quo officia.\nOdio aut iste porro atque necessitatibus.\nBlanditiis dolorem soluta maiores explicabo ut occaecati placeat ipsam aliquid.", "https://picsum.photos/640/480/?image=741", false, "Handcrafted Wooden Chair", 720.28999999999996, "oxtcvbfvvd" },
                    { new Guid("8b84fd55-437f-e4df-7fc2-74e818943599"), 693.65999999999997, "Dolorem voluptatum vero officia.\nVoluptate laboriosam labore quia eos quis.\nAliquam ut ab.\nQuo vel quibusdam.\nEius ullam architecto ut dolor beatae ut.", "https://picsum.photos/640/480/?image=692", false, "Incredible Granite Chicken", 603.30999999999995, "dileiggqril" },
                    { new Guid("8da682ec-047a-bf03-1e90-6159609044d4"), 302.48000000000002, "Rerum eaque odit sed voluptas nostrum qui velit quia laudantium.\nConsectetur voluptates deserunt quia ullam animi.\nNumquam expedita ut.\nRepellendus aut qui et quas facilis veritatis dignissimos.", "https://picsum.photos/640/480/?image=931", true, "Handcrafted Rubber Pizza", 428.95999999999998, "wjesfstrk" },
                    { new Guid("8e35a64b-490e-6651-e31c-f07832f9df46"), 457.89999999999998, "Eveniet eligendi dolorem.\nIn sed dolores minima quibusdam dolorem veritatis vel et.\nNeque laborum neque quas qui sit accusantium deserunt necessitatibus voluptatibus.\nQuam molestiae corrupti vel reiciendis aspernatur nulla odit sapiente.\nOmnis illo molestiae nulla illum possimus quo itaque quia.", "https://picsum.photos/640/480/?image=496", true, "Generic Rubber Gloves", 381.13999999999999, "hkhbwlyduc" },
                    { new Guid("8ef68158-059f-c2ce-d606-1224e88f4bf8"), 948.14999999999998, "Facere non non aperiam qui earum illo sed quidem qui.\nEst quia qui temporibus tempore voluptate facere id incidunt.\nPariatur non sapiente.", "https://picsum.photos/640/480/?image=476", true, "Awesome Rubber Fish", 832.38999999999999, "soqnpkjn" },
                    { new Guid("9207f714-3857-0f8f-2e1b-8004f4ea4b36"), 480.49000000000001, "Ratione architecto sint fugit dolores voluptatibus dolorum.\nSed maxime nesciunt iusto ut occaecati et quo unde.\nNon amet quia quos quo.\nEa maxime asperiores a ipsa quod quis et repellat molestias.\nIpsam sequi velit possimus enim.", "https://picsum.photos/640/480/?image=253", false, "Tasty Metal Soap", 353.66000000000003, "pymhoymi" },
                    { new Guid("96b81c13-ae6a-fee2-c5ac-55537bcfa721"), 133.03999999999999, "Sit perspiciatis iste et eos incidunt dignissimos veritatis quis consectetur.\nQuidem inventore officiis quae.\nQuod laborum dolor cupiditate non tenetur.\nSunt omnis autem voluptas rerum earum quos est dolorum qui.", "https://picsum.photos/640/480/?image=559", true, "Awesome Granite Pizza", 37.049999999999997, "atvdatxdnio" },
                    { new Guid("9930b4aa-5cb4-cdc9-bfee-336dfaa22dfe"), 343.11000000000001, "Sapiente aperiam voluptates qui.\nQui iste ab sunt vitae ut odio tenetur.", "https://picsum.photos/640/480/?image=360", false, "Awesome Steel Ball", 237.94999999999999, "zxttuoqbgspf" },
                    { new Guid("9bb84721-93ca-33b1-3801-13b1ab1b59e0"), 386.5, "Ex possimus et doloremque tempore modi.\nDolor est quo consequuntur in molestias veniam.\nVoluptas repudiandae cum quibusdam dolor veniam.\nRepudiandae et itaque et vel in.\nEsse sint molestias et itaque.\nEt reiciendis non ea vel quae quod vel.", "https://picsum.photos/640/480/?image=47", true, "Small Cotton Chair", 352.81, "ubkcqxjnr" },
                    { new Guid("9d9b0ed9-12c9-3952-ab9f-eb5b424077a4"), 430.24000000000001, "Error eum officiis.\nSint fuga animi porro voluptas quidem saepe nobis.\nDoloribus modi omnis qui quia modi est eum laudantium.\nMinima blanditiis ratione et maiores et.\nEst dignissimos et enim voluptatum ad voluptatem dolorem id et.", "https://picsum.photos/640/480/?image=934", false, "Gorgeous Plastic Towels", 467.23000000000002, "utvuatrzp" },
                    { new Guid("a0ea37a5-ad75-c4b9-52d2-88332a6d56d7"), 986.92999999999995, "Earum voluptatum natus vero ut sapiente cumque consequuntur vel totam.\nQuis eaque ut maiores.", "https://picsum.photos/640/480/?image=818", true, "Practical Frozen Chair", 302.49000000000001, "opofgnxoyv" },
                    { new Guid("a1e2bbc6-96f1-e5f4-43ce-8741526ac1f8"), 895.26999999999998, "Repellat repudiandae voluptatem quo deserunt rerum ea ut.\nVoluptas sunt facere perferendis quae natus reprehenderit ab ab consequatur.\nCumque quo eligendi culpa omnis dolorem minus qui.\nMinima voluptatem veritatis voluptas alias perferendis placeat.\nEt nulla animi aliquam non eius qui.\nVelit qui quos eveniet dolorem.", "https://picsum.photos/640/480/?image=320", true, "Refined Steel Pants", 116.02, "qznrzltdgg" },
                    { new Guid("a730a0e4-fe01-7110-3c33-a33e6b8bdf72"), 205.24000000000001, "Reiciendis aut voluptatibus rerum et.\nCumque accusamus tenetur maiores debitis quasi dolor.\nNumquam veniam accusamus consequuntur qui.\nSapiente iusto occaecati qui eos aut officiis optio.\nIusto aut quia.", "https://picsum.photos/640/480/?image=656", false, "Gorgeous Cotton Salad", 794.38999999999999, "ppxrpsff" },
                    { new Guid("ab6a9fe5-c014-e87e-0ecf-e76ae86c52d1"), 693.24000000000001, "Qui sit tenetur atque accusamus voluptas magnam voluptatem amet.\nSit nesciunt aut id omnis atque.", "https://picsum.photos/640/480/?image=6", false, "Handmade Soft Fish", 297.10000000000002, "eisezghwnx" },
                    { new Guid("ad613262-57dc-475d-b353-05776656eece"), 741.55999999999995, "Quia nobis asperiores officiis accusantium repellat vel ut quam.\nDignissimos eligendi consectetur.\nNon beatae sequi eum.\nMolestias praesentium pariatur voluptate et.", "https://picsum.photos/640/480/?image=1031", true, "Rustic Fresh Bike", 234.53, "mkhbwgyv" },
                    { new Guid("af7abae0-7b55-53bf-60d3-53fdeaf014bf"), 230.11000000000001, "Sunt fugit quis et eveniet aut dolores laborum praesentium.\nIncidunt consequatur quis voluptatum cum repellendus ex et rem non.\nSequi voluptatibus nobis quaerat.\nBlanditiis qui vero ea animi vitae nulla dolore quisquam.\nEt reiciendis laudantium maiores.", "https://picsum.photos/640/480/?image=222", true, "Ergonomic Metal Pizza", 546.23000000000002, "xtrkehkougug" },
                    { new Guid("b0f47665-1ac0-d48c-ddc0-7a57b9ca7887"), 56.039999999999999, "Aut saepe iure accusantium et soluta nulla eos modi quia.\nUt totam neque doloribus placeat officiis voluptates delectus pariatur ea.\nSapiente pariatur saepe.\nQuam quos eveniet odit rerum sapiente deserunt et aut.\nUt et est.", "https://picsum.photos/640/480/?image=520", false, "Licensed Soft Bacon", 299.85000000000002, "cxzztgfp" },
                    { new Guid("b346d458-135a-1c7a-171c-b5a04d9f034e"), 20.870000000000001, "Est perspiciatis sit odio doloremque ea eius ut consequatur rerum.\nA voluptatem fugiat sequi ut vel quisquam provident quos.\nQuibusdam quasi qui dolores amet quisquam.\nMolestias fugiat sit qui consequatur impedit est repellendus cupiditate vel.\nUt expedita et libero dicta est est ipsam.\nDignissimos tenetur suscipit rerum quia deleniti nostrum dolorem voluptas sunt.", "https://picsum.photos/640/480/?image=426", true, "Unbranded Fresh Ball", 620.80999999999995, "zwikizcgoz" },
                    { new Guid("b392eec2-b82c-f7e4-b113-d9e2774d7da1"), 561.69000000000005, "Cupiditate velit accusamus sit aut quam.\nAut qui voluptatum.\nVitae reprehenderit dignissimos eum sit suscipit labore neque nobis.\nEt quae nesciunt adipisci nostrum et corporis rerum id autem.\nQuia officia ut non voluptas dolor.", "https://picsum.photos/640/480/?image=332", false, "Generic Fresh Shirt", 91.840000000000003, "hsxnafiphxmz" },
                    { new Guid("b6b0eebf-3895-8921-40f2-5960d88363cc"), 473.07999999999998, "Sed sapiente consequuntur voluptatem esse accusantium ea doloremque accusamus.\nCumque id qui assumenda.\nEnim ex est deserunt voluptatem.", "https://picsum.photos/640/480/?image=251", true, "Sleek Wooden Fish", 351.69, "rzualkuufrn" },
                    { new Guid("b6eccb37-f80e-d9ca-b39a-84680e3b3651"), 621.52999999999997, "Qui sint voluptatem fuga est quos voluptatem amet ducimus molestiae.\nSunt cupiditate autem voluptatum ut ea magni.\nDolorum neque non sequi ex maxime numquam.\nEos inventore a praesentium provident cum unde optio.\nOptio nulla qui incidunt non quia aperiam.\nCumque neque autem provident quia commodi.", "https://picsum.photos/640/480/?image=818", false, "Handcrafted Metal Pants", 305.55000000000001, "lxrvwxvkyys" },
                    { new Guid("b977177d-bf81-0451-01ce-f0a9022f29b7"), 811.61000000000001, "Fuga dolore voluptate nostrum sit et.\nAperiam culpa incidunt sed accusamus molestiae sit labore.\nTenetur fugiat dolores dignissimos ducimus velit necessitatibus id.", "https://picsum.photos/640/480/?image=549", true, "Rustic Plastic Gloves", 869.50999999999999, "lafxrvsbhas" },
                    { new Guid("bb004292-bb4c-5e30-c1ee-8639965334ba"), 969.94000000000005, "Dolore illo iusto molestiae soluta qui minima.\nPraesentium adipisci qui nulla ab aperiam suscipit voluptatibus officiis placeat.\nTemporibus pariatur neque.", "https://picsum.photos/640/480/?image=70", false, "Sleek Granite Bacon", 978.75, "cdjgtdxumdbd" },
                    { new Guid("be9bb281-5286-7604-1149-06f50d31696a"), 670.59000000000003, "Id quidem esse eveniet adipisci facilis recusandae fuga consectetur dolores.\nVoluptas et saepe earum nihil.\nAspernatur eos aut non dolor.\nSint ut quia voluptas et culpa et numquam.", "https://picsum.photos/640/480/?image=22", false, "Tasty Frozen Tuna", 682.29999999999995, "bmkbqldcgmp" },
                    { new Guid("bfec52a8-33a3-d58a-b569-7fa576dfcca8"), 83.909999999999997, "Officia et iste architecto eos.\nAssumenda aut est et quia molestias.\nEius facere molestias.", "https://picsum.photos/640/480/?image=874", false, "Awesome Fresh Sausages", 70.269999999999996, "tayrgczgrd" },
                    { new Guid("c53147d8-8bb9-64a0-0cef-0acf0c3f375f"), 520.60000000000002, "Molestias facere ut quaerat voluptatem.\nTempore rerum et vel magnam.", "https://picsum.photos/640/480/?image=1002", false, "Gorgeous Rubber Bike", 295.16000000000003, "bfwomeasurbx" },
                    { new Guid("c5ea8f9b-0b63-2992-3738-7ad105bdf403"), 890.77999999999997, "Enim quos voluptas ut mollitia sed sit dicta mollitia laboriosam.\nEst et in ut ut.\nRepellat quaerat asperiores accusamus consectetur excepturi molestiae porro.", "https://picsum.photos/640/480/?image=654", false, "Small Wooden Fish", 406.61000000000001, "smmkcqilrr" },
                    { new Guid("c5fe883d-7d00-611a-b7a2-5c86068d6b40"), 381.99000000000001, "Nostrum id expedita quo error quibusdam tenetur vero omnis asperiores.\nVoluptas sed distinctio enim architecto.\nAut nihil earum repudiandae est.\nNam autem aut voluptatem.\nUt quis temporibus quis blanditiis dolorum excepturi quasi et eum.", "https://picsum.photos/640/480/?image=52", true, "Refined Fresh Shirt", 560.01999999999998, "gmbscuppr" },
                    { new Guid("c73f7c88-20ac-3363-922e-667dc75af666"), 459.11000000000001, "Voluptas ipsum ratione.\nSed autem quia quia id accusantium quis.\nMagni incidunt minus.\nEt quia quia molestiae magnam recusandae libero.\nIure nulla id eius voluptas ipsam quisquam voluptatem libero molestias.", "https://picsum.photos/640/480/?image=560", false, "Handcrafted Frozen Tuna", 36.409999999999997, "vpywibvcnkgz" },
                    { new Guid("cb45ae94-4ab5-9f6b-04e2-ce536e1b0b98"), 511.74000000000001, "Maxime aut doloribus nemo.\nNatus enim omnis est.\nSequi maiores repellat exercitationem eveniet aperiam voluptatem beatae.\nVoluptates omnis ut illum quo aliquid iusto quod voluptate.\nInventore ut non mollitia laudantium rerum.\nSoluta numquam animi vitae excepturi.", "https://picsum.photos/640/480/?image=821", false, "Refined Steel Shirt", 168.08000000000001, "uwmfnqpjot" },
                    { new Guid("cbca961c-9989-32a1-451d-58d8674bf50d"), 825.44000000000005, "Omnis error itaque cum unde et culpa sed.\nLaborum adipisci et animi placeat soluta.\nAd repellendus vel dolorum ut.\nIpsa perspiciatis atque deleniti numquam facilis et consequatur.\nCorrupti facilis ea laboriosam tenetur provident qui quae voluptas ea.\nNon rem et.", "https://picsum.photos/640/480/?image=344", true, "Practical Plastic Ball", 616.21000000000004, "bazezmgyqdq" },
                    { new Guid("cd19fb5a-53b4-6097-4b3b-ef105d652732"), 304.10000000000002, "Ut voluptas voluptas voluptatibus explicabo commodi.\nVoluptas consequuntur aut magnam praesentium.\nCum voluptatibus cupiditate voluptas id corrupti voluptatem qui iure.\nNecessitatibus voluptate aut sed incidunt suscipit.\nEos atque ab voluptatem in enim eius odit quia.\nNesciunt doloribus sequi illum deleniti ut sequi molestias dicta.", "https://picsum.photos/640/480/?image=1041", false, "Refined Soft Chicken", 983.52999999999997, "avymakaufj" },
                    { new Guid("d1100f08-99a0-d0bc-c292-6e63a94cbedb"), 478.41000000000003, "Eius accusamus ullam fugit laboriosam iste sint qui dolor.\nQui recusandae sed.\nVoluptatibus ut quos velit.\nDeleniti harum minus dolor ut temporibus perspiciatis.\nMollitia omnis est quibusdam cupiditate in adipisci nihil est.\nCum atque ea illo ipsa facilis.", "https://picsum.photos/640/480/?image=109", true, "Incredible Granite Bacon", 60.090000000000003, "tqfczrki" },
                    { new Guid("d262db9a-68b3-be27-4c02-2ce7cacc6a72"), 873.27999999999997, "Eos in perspiciatis ut autem aut.\nUllam exercitationem praesentium facere.\nReiciendis asperiores molestiae id in expedita veniam ex laudantium.\nDolor odit dolorum quidem quis assumenda temporibus voluptatibus sit laboriosam.\nSoluta alias sed atque ut.\nFacere sunt ducimus esse maxime mollitia.", "https://picsum.photos/640/480/?image=641", true, "Unbranded Soft Chicken", 842.0, "vzauhnzghk" },
                    { new Guid("da3dbf82-53b9-5e29-3118-342626f9a75b"), 792.88, "Sunt qui voluptatem perferendis quidem.\nEst esse soluta veniam ipsa ullam aliquid.\nVoluptate ut illo velit eum.\nEaque quia et.\nPraesentium debitis fugiat dolore placeat corporis.", "https://picsum.photos/640/480/?image=114", true, "Intelligent Wooden Cheese", 239.59, "nsqwnuryvmvv" },
                    { new Guid("e00af00f-83e1-4b99-f008-71cfd9a037df"), 466.56999999999999, "Aliquid placeat error est totam explicabo quia distinctio.\nMinima eum aspernatur assumenda et est est corporis possimus.", "https://picsum.photos/640/480/?image=376", true, "Small Wooden Shirt", 213.96000000000001, "rvhmxeyi" },
                    { new Guid("e5bc904e-6499-4b31-2d45-2a6332680537"), 496.44, "Itaque nemo odio et distinctio est dolorem minima occaecati.\nIpsam quo repellendus facilis.", "https://picsum.photos/640/480/?image=1025", true, "Fantastic Frozen Shirt", 905.17999999999995, "yzqmqzqix" },
                    { new Guid("e66b9610-03c6-f610-5431-b144fad5549a"), 487.67000000000002, "Quia voluptas saepe molestias dicta ducimus voluptatem quasi odit.\nPerspiciatis et numquam odit.\nFugiat quisquam in sit pariatur.\nEaque pariatur non ad fuga officia minima aliquam blanditiis.", "https://picsum.photos/640/480/?image=10", false, "Refined Fresh Sausages", 503.88999999999999, "nsfsuamhxm" },
                    { new Guid("e7329b52-1c73-8bec-731d-52dbf68ca36c"), 741.66999999999996, "Vitae molestiae in maxime impedit sequi voluptas.\nMaiores sint ut qui nulla.\nNam iste ut iste facilis qui soluta sit est.", "https://picsum.photos/640/480/?image=738", false, "Licensed Steel Bacon", 643.82000000000005, "caoyericj" },
                    { new Guid("e7fd993a-30c4-c306-6bd1-35478c821ca3"), 115.89, "Sequi possimus ea et qui qui.\nSunt excepturi veritatis explicabo adipisci.\nEst eos possimus libero maxime corrupti illum porro placeat aut.\nEaque reiciendis itaque dolorem quia officia et porro quos.\nMaiores ipsam aut eos.\nSed cupiditate iste ratione.", "https://picsum.photos/640/480/?image=965", true, "Licensed Rubber Tuna", 906.21000000000004, "lkzsmuxsbvn" },
                    { new Guid("e8dde4b7-cb1e-0402-5a58-987192fa70fe"), 196.43000000000001, "Eum ut ea.\nAut earum dolor cupiditate consequatur.\nHic deserunt omnis amet non.\nVeritatis amet earum.", "https://picsum.photos/640/480/?image=468", false, "Generic Fresh Fish", 228.56999999999999, "kbgexkog" },
                    { new Guid("ebbf205c-944c-2196-649f-67056239d8cd"), 361.88999999999999, "Quia a est enim repellat adipisci rerum placeat.\nSit quaerat dolorem ut.\nLaboriosam nostrum placeat aspernatur reprehenderit nostrum dolor labore est.", "https://picsum.photos/640/480/?image=339", true, "Incredible Fresh Shoes", 679.35000000000002, "drhoysleih" },
                    { new Guid("ed55b290-5d4a-db71-0d2d-3f372c3daad5"), 135.11000000000001, "Eligendi ut enim sed fugiat.\nIusto quo fugit id aliquam quo impedit aspernatur.", "https://picsum.photos/640/480/?image=289", true, "Licensed Cotton Fish", 249.47, "evtddxjvnr" },
                    { new Guid("f1e73704-72e2-3144-e603-5e9f005f295c"), 561.90999999999997, "Sequi aut eaque repellat est earum.\nIllum harum et illo delectus ipsa sunt aut dolorum.", "https://picsum.photos/640/480/?image=980", true, "Awesome Cotton Sausages", 579.38, "cztnpwswc" },
                    { new Guid("f6df6c6d-9cfc-8134-2df7-3c96e04b677b"), 396.56, "Voluptatem non qui quasi ut et deleniti animi magni autem.\nCorrupti fugit autem animi voluptas pariatur et eos.\nFugiat iste omnis eveniet.", "https://picsum.photos/640/480/?image=1010", false, "Licensed Concrete Bike", 154.56999999999999, "ilmjiwgbbstm" },
                    { new Guid("f80cced4-ff2b-aff2-34fe-61c1d8082bca"), 339.91000000000003, "Voluptatibus nam facere odio soluta.\nLabore aut quasi odit nihil labore earum sint.\nAtque enim nihil et.\nAut possimus a aspernatur nam omnis modi vitae enim magnam.\nAutem sunt beatae sit reiciendis.\nDolores est nemo ut cupiditate aut omnis odio quod voluptatem.", "https://picsum.photos/640/480/?image=394", true, "Intelligent Plastic Chips", 269.52999999999997, "nuqboyvha" },
                    { new Guid("faeafc14-6702-da14-3024-b00cb39f2d7a"), 259.61000000000001, "Laudantium labore ut eum aspernatur natus autem est asperiores.\nVel facere consequatur.\nOdio quia porro corrupti quaerat quia dolor architecto est.\nCum voluptatum quibusdam autem alias non aut ratione.\nRepudiandae repellendus aut rerum.", "https://picsum.photos/640/480/?image=154", true, "Handcrafted Granite Salad", 111.54000000000001, "aqplrpwkvye" },
                    { new Guid("fb96eeb8-35df-af9c-3c65-35b2f73939be"), 940.74000000000001, "Voluptate rem nobis et et sit velit velit sunt a.\nSit quam illum quaerat quae sequi modi odit aliquam.\nDelectus eligendi blanditiis.\nRem sed qui repellat sint consequuntur labore voluptates voluptas.\nOptio vel quae voluptas quia.", "https://picsum.photos/640/480/?image=512", false, "Small Rubber Soap", 754.85000000000002, "frsmsqdxja" },
                    { new Guid("fc7698f4-095d-09b7-4e64-3503af281bbf"), 263.25999999999999, "Voluptas repudiandae quod in aut accusamus minus non ipsa.\nAliquid explicabo vel est repudiandae dolores.\nAut aut ipsa occaecati possimus deleniti dolor.\nCorporis tempora accusantium.\nNon alias rerum voluptas sit ut dolores excepturi labore voluptas.\nEnim ipsa earum.", "https://picsum.photos/640/480/?image=266", false, "Fantastic Frozen Sausages", 215.71000000000001, "tszramizyibp" },
                    { new Guid("fc7cb712-3628-896e-f256-55fad45b3558"), 922.42999999999995, "Sapiente praesentium debitis odit.\nEveniet similique quas doloremque excepturi non.\nNisi cupiditate et et eum sunt ipsam non.", "https://picsum.photos/640/480/?image=346", false, "Generic Frozen Hat", 291.35000000000002, "haniqvjbr" },
                    { new Guid("fcb4c840-4a5a-1303-dab6-f00ace1e0ff7"), 405.80000000000001, "Quo atque beatae sit molestias.\nVeniam quam corporis quis animi sunt modi.\nVitae minima odit earum sit omnis minima alias.", "https://picsum.photos/640/480/?image=461", true, "Sleek Fresh Mouse", 181.94, "kusvmbfzv" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("004ba63c-0a4e-c676-88fa-acb6d09738c3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("00c6fdbc-fa66-fe69-e635-ba81bf143e98"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0ada1ea0-397c-5eac-8e14-3f8c45a8e73a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1455d3f3-dc3c-a0ad-0389-862293c746b1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("175f177f-fa2b-1569-258e-9f5ab3140fc2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2402d8a0-712f-b423-390b-5b5fd2e76aa3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("24de1900-f484-4b45-dbb2-c57d7f193712"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("28cbeace-280d-52d0-b08b-c6d612e0c2ca"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("292372bb-5a4e-6eb9-2b08-d4fe17337648"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2933d59b-895d-b08e-3861-cced9e674d1b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2aa78a7d-2ea2-e051-06fb-b8d496db2459"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2b29144a-89ba-7fad-a53a-8f1cfc37c2dd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2fd8670a-5be6-58ac-ef4a-074edd87e8a8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("332babd3-6692-b1ab-fd47-e80de252a913"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("38451d51-6e2e-293d-f0f7-218b815b1a9d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3aa14181-ac0d-157d-83f6-a743c25cc8cd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3e26dadb-428f-4528-905f-03a7917bcb1e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3f9d568e-6d6d-18c0-12cd-65059b564137"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3fe40d8a-e59e-c739-ac08-9640a2e43740"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("42bd727f-7630-f148-d262-65e242d1bf7a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("43a2b9d0-70fc-917f-76d0-c51172875f53"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("461cd018-4ebb-3a86-df96-74905eef92b5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("46c5bedd-ed4d-dfd3-8ac7-429a425c853a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4968b67a-181f-1085-93d6-4d393f0f1db4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4b13572f-2fa0-ed0e-bd35-b90d1c5f5fd8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4c60222b-d6b3-c348-0af9-4b15fc3ba2ed"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("51a2e216-9526-e496-1ce4-84b1d524376f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("51cf19f4-c156-3e9d-b5a4-531f732a0b1f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5272ed70-891a-0603-e18f-914cc449fdc3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("54050131-cb44-01e2-a5b0-01c2dbb50d07"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5413fd3f-3388-6538-c4ca-25b59fec1dd4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("564541ab-8712-2e70-827c-a10e70db0a99"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("56b9ba20-8b40-0b0f-288d-4c0cd070330b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5704c265-68d7-817f-2332-50b008c9f3bc"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("59125dc8-0506-9b4e-3368-f2b5461539b4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5aa522f6-4a16-34ea-f530-e253985886a1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5c734533-e2dd-d944-f5c4-bbd093e0ccb0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6c91b6cb-ad56-e683-3d3e-eae9eaf69ebf"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6e0bf071-d146-0f2d-a800-eec0fe109351"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6f93ea62-d64b-7956-bf19-e296846e703d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("76e80e97-6692-1399-72ca-33ebaff22f91"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7829c11a-ef69-ad10-8f23-c5c262ac5082"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7fa8f0f1-d908-bfa9-05ec-06fbca0150aa"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("811f78a2-f095-eb07-ad3f-0665f54b9244"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("82250133-526d-57c8-cc18-3412aded6d39"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("82509e4e-0071-db47-d60a-91fb42a9f079"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("83648d9d-cc0b-bf20-3d29-981b3764d314"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("84012d81-3e79-4e37-ca36-17e51da2bd40"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("84c358dc-1c49-3137-b727-52d2309900b4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8771e776-73a1-763b-9bde-5491da7b53ab"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8b84fd55-437f-e4df-7fc2-74e818943599"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8da682ec-047a-bf03-1e90-6159609044d4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8e35a64b-490e-6651-e31c-f07832f9df46"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8ef68158-059f-c2ce-d606-1224e88f4bf8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9207f714-3857-0f8f-2e1b-8004f4ea4b36"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("96b81c13-ae6a-fee2-c5ac-55537bcfa721"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9930b4aa-5cb4-cdc9-bfee-336dfaa22dfe"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9bb84721-93ca-33b1-3801-13b1ab1b59e0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9d9b0ed9-12c9-3952-ab9f-eb5b424077a4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a0ea37a5-ad75-c4b9-52d2-88332a6d56d7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a1e2bbc6-96f1-e5f4-43ce-8741526ac1f8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a730a0e4-fe01-7110-3c33-a33e6b8bdf72"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ab6a9fe5-c014-e87e-0ecf-e76ae86c52d1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ad613262-57dc-475d-b353-05776656eece"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("af7abae0-7b55-53bf-60d3-53fdeaf014bf"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b0f47665-1ac0-d48c-ddc0-7a57b9ca7887"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b346d458-135a-1c7a-171c-b5a04d9f034e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b392eec2-b82c-f7e4-b113-d9e2774d7da1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b6b0eebf-3895-8921-40f2-5960d88363cc"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b6eccb37-f80e-d9ca-b39a-84680e3b3651"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b977177d-bf81-0451-01ce-f0a9022f29b7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bb004292-bb4c-5e30-c1ee-8639965334ba"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("be9bb281-5286-7604-1149-06f50d31696a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bfec52a8-33a3-d58a-b569-7fa576dfcca8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c53147d8-8bb9-64a0-0cef-0acf0c3f375f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c5ea8f9b-0b63-2992-3738-7ad105bdf403"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c5fe883d-7d00-611a-b7a2-5c86068d6b40"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c73f7c88-20ac-3363-922e-667dc75af666"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("cb45ae94-4ab5-9f6b-04e2-ce536e1b0b98"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("cbca961c-9989-32a1-451d-58d8674bf50d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("cd19fb5a-53b4-6097-4b3b-ef105d652732"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d1100f08-99a0-d0bc-c292-6e63a94cbedb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d262db9a-68b3-be27-4c02-2ce7cacc6a72"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("da3dbf82-53b9-5e29-3118-342626f9a75b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e00af00f-83e1-4b99-f008-71cfd9a037df"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e5bc904e-6499-4b31-2d45-2a6332680537"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e66b9610-03c6-f610-5431-b144fad5549a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e7329b52-1c73-8bec-731d-52dbf68ca36c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e7fd993a-30c4-c306-6bd1-35478c821ca3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e8dde4b7-cb1e-0402-5a58-987192fa70fe"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ebbf205c-944c-2196-649f-67056239d8cd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ed55b290-5d4a-db71-0d2d-3f372c3daad5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f1e73704-72e2-3144-e603-5e9f005f295c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f6df6c6d-9cfc-8134-2df7-3c96e04b677b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f80cced4-ff2b-aff2-34fe-61c1d8082bca"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("faeafc14-6702-da14-3024-b00cb39f2d7a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fb96eeb8-35df-af9c-3c65-35b2f73939be"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fc7698f4-095d-09b7-4e64-3503af281bbf"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fc7cb712-3628-896e-f256-55fad45b3558"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fcb4c840-4a5a-1303-dab6-f00ace1e0ff7"));

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "BasePrice", "Description", "Image", "InStock", "Name", "SellPrice", "Sku" },
                values: new object[,]
                {
                    { new Guid("00cf9611-15bf-fbaa-c181-aac13635605c"), 32.420000000000002, "Beatae harum deserunt fugit sapiente ut explicabo hic quas.\nQuia non natus quos ratione rerum qui.\nEst cumque vel voluptatem et pariatur sint.\nEnim aspernatur eaque et rerum nulla dolore omnis natus vel.\nVeritatis numquam maxime consequatur cumque.\nHic ipsa omnis ratione ut possimus sit odio error.", "https://picsum.photos/640/480/?image=212", false, "Unbranded Frozen Table", 165.88, "xvzxitjqp" },
                    { new Guid("012d6893-a8d3-a776-dde1-aa0dda910d2a"), 443.22000000000003, "Est et ratione atque amet.\nId vel recusandae unde.\nEt consequatur eveniet nam sint aut.\nEum cupiditate sit voluptas quia commodi quibusdam officiis illum.\nEst et enim quisquam culpa aut nisi ducimus molestias veniam.", "https://picsum.photos/640/480/?image=280", true, "Awesome Frozen Pizza", 902.42999999999995, "wchywcoup" },
                    { new Guid("068c1cd4-acc6-60ad-ac68-1414282b1157"), 1.4399999999999999, "Cumque aut est voluptatem.\nEum facilis velit fugiat dicta modi voluptatum enim.\nMagni ut ut eveniet.", "https://picsum.photos/640/480/?image=619", false, "Ergonomic Steel Mouse", 717.72000000000003, "nppglblrtjq" },
                    { new Guid("082d63e0-3116-83a5-3cf3-318fce685d44"), 763.88, "Qui fuga quae quae consequatur voluptatem.\nCumque asperiores quia corrupti repellat.\nVero cumque voluptas fugiat.\nNihil hic repellendus delectus.", "https://picsum.photos/640/480/?image=585", false, "Small Rubber Fish", 223.31999999999999, "osgouoofdty" },
                    { new Guid("0a288fc9-dd09-e65e-c10a-efbf8f8b1598"), 312.04000000000002, "Iusto et dolores porro repellendus quibusdam.\nExcepturi aliquid corrupti.\nEt fugiat laboriosam omnis.", "https://picsum.photos/640/480/?image=412", false, "Handmade Wooden Chicken", 543.90999999999997, "iuewkkkpy" },
                    { new Guid("17c33da1-d92b-c22b-3fc2-c32e03e9c657"), 807.61000000000001, "Repudiandae vitae consectetur eius enim deserunt inventore in eos eum.\nEa est et voluptatum aut quisquam sapiente voluptatem harum odit.\nAssumenda amet et sapiente ut ea repellat.\nRecusandae dolorum officia.", "https://picsum.photos/640/480/?image=304", true, "Unbranded Wooden Sausages", 254.88, "pmofdkzjlf" },
                    { new Guid("19eae9e0-bc6d-f539-f965-1055bd0feb08"), 37.189999999999998, "Earum rem accusantium.\nOccaecati et totam.\nEaque harum quo rerum quaerat vitae consequuntur.\nVelit vel omnis eum voluptates at.\nCumque voluptas labore iusto atque quod veritatis.\nEos ut quas facilis harum et explicabo qui et et.", "https://picsum.photos/640/480/?image=958", true, "Handmade Rubber Towels", 51.590000000000003, "ffhbegnhypbo" },
                    { new Guid("19f5fbc3-f676-197d-412e-619106037fe9"), 731.44000000000005, "Itaque reprehenderit minima quasi ut a enim commodi vitae sapiente.\nEligendi molestiae vel dolore modi eos et non iusto.\nDeserunt perspiciatis et est sequi eaque expedita et ut corrupti.\nEa veritatis nulla beatae qui incidunt facilis.", "https://picsum.photos/640/480/?image=112", true, "Awesome Frozen Bacon", 878.20000000000005, "kwykyxmnte" },
                    { new Guid("1da9e4de-9c1f-33ab-fefd-7f5ceb7c0d42"), 801.17999999999995, "Accusantium beatae et.\nExcepturi optio sunt rerum id quaerat natus.\nReiciendis non est.\nConsequatur voluptates quis omnis non voluptate.\nQuos non et ut saepe ut excepturi quia aut.", "https://picsum.photos/640/480/?image=576", false, "Incredible Soft Towels", 956.51999999999998, "acphidxzgvmt" },
                    { new Guid("1e2187d9-034e-9ba7-2b6f-e7c18b7b6a8e"), 142.19999999999999, "Omnis quae dolor dolores laudantium.\nDeserunt facere voluptatem.\nEst vitae eum quia vitae voluptas dolorem voluptas accusantium nesciunt.\nSapiente ut voluptas unde incidunt non.", "https://picsum.photos/640/480/?image=782", false, "Handmade Granite Hat", 977.88999999999999, "jujttjzayt" },
                    { new Guid("1e5d342d-a34e-fbc0-d1fb-c6229274f719"), 495.88999999999999, "A unde et cupiditate fuga ratione.\nIllo voluptatem qui illo corrupti quidem.\nVoluptatem maxime repellat sequi numquam facere itaque ullam tenetur doloremque.", "https://picsum.photos/640/480/?image=967", false, "Sleek Granite Soap", 973.44000000000005, "nhgwbcoicj" },
                    { new Guid("1e8c7ab6-4663-f6ea-7f97-778426e65a94"), 829.78999999999996, "Ut est ipsum eveniet et et rem libero consectetur debitis.\nNemo labore rerum quia et.\nSoluta qui soluta occaecati tempora quia.\nFugiat maiores accusamus optio qui ea.\nEum occaecati voluptatum quasi sed qui.\nRerum temporibus adipisci.", "https://picsum.photos/640/480/?image=950", true, "Rustic Soft Mouse", 264.37, "mxwnhwfjs" },
                    { new Guid("20ada9d1-27d4-96b7-7150-7041201c899a"), 338.06999999999999, "Dolore voluptas ea.\nModi iure nihil hic ut.\nQui explicabo nisi ullam.\nDolor commodi quia est odit aut est cum porro.", "https://picsum.photos/640/480/?image=335", false, "Intelligent Wooden Fish", 563.47000000000003, "wxpbxqsxwxbw" },
                    { new Guid("246fa4d4-d302-c13f-bba7-871ef2f2494a"), 855.63, "Laudantium sapiente et sit sit alias.\nVel molestias aspernatur totam recusandae quod voluptate quidem.\nConsequatur et inventore et ut dolor et quaerat sit numquam.\nTenetur quaerat fugit ad cum voluptas at.", "https://picsum.photos/640/480/?image=940", false, "Handmade Plastic Chicken", 369.38999999999999, "osiiffwpzgko" },
                    { new Guid("247d22ec-1eec-a49c-3e3a-ad764760fd44"), 796.08000000000004, "Odio fugiat deserunt assumenda numquam.\nIpsam voluptas qui et quia sit eum.\nSoluta nihil laborum saepe.\nAd odit reprehenderit consequatur a accusantium quia assumenda.", "https://picsum.photos/640/480/?image=737", false, "Rustic Fresh Shirt", 133.28, "bkedjvvor" },
                    { new Guid("25629ef7-6bf8-5ee9-97d3-e6bacb9ddd5b"), 606.5, "Qui labore illo ratione aperiam.\nEum qui eaque voluptatem facilis.\nOmnis repudiandae non totam sint quibusdam necessitatibus est.\nSint repellendus qui architecto aut doloremque sapiente voluptatibus reiciendis.\nRerum ipsa magnam nihil eveniet aut.", "https://picsum.photos/640/480/?image=530", false, "Ergonomic Cotton Towels", 734.66999999999996, "zetmsjfcsare" },
                    { new Guid("268c562c-63de-c825-f579-e0914424b344"), 145.41999999999999, "Quae facilis exercitationem magnam nisi vel culpa sed excepturi.\nVoluptatem aut minus.\nMolestiae unde fugiat quidem officia perferendis soluta.", "https://picsum.photos/640/480/?image=768", true, "Small Plastic Salad", 622.40999999999997, "mzkihkrcq" },
                    { new Guid("27a25346-af54-aab9-f094-8620fe7aeb52"), 810.25999999999999, "Dicta illo fugiat sunt maiores non dolor quo quisquam.\nAut error consequatur soluta dolorem esse voluptatibus laboriosam natus fugit.\nMaiores ut molestiae reiciendis soluta sit perspiciatis molestiae laborum blanditiis.\nVero omnis quae aliquam.\nEt natus distinctio animi suscipit impedit esse maxime.", "https://picsum.photos/640/480/?image=435", true, "Ergonomic Fresh Computer", 283.48000000000002, "milvlgbefty" },
                    { new Guid("28405536-d543-5017-8e93-3e34dd347237"), 277.99000000000001, "Voluptates voluptates ullam sit hic laborum neque.\nQuisquam eaque consequatur repellendus sunt minima harum iure soluta impedit.", "https://picsum.photos/640/480/?image=821", false, "Practical Cotton Bike", 438.56, "jguthmrfimpa" },
                    { new Guid("292dcec2-bd51-11ad-aaae-8d4cac0aa768"), 204.12, "Culpa et voluptatem amet quidem voluptatem cum.\nSit fugiat nisi voluptas qui architecto dolore sunt.", "https://picsum.photos/640/480/?image=1011", false, "Intelligent Granite Ball", 512.02999999999997, "paiwoxtfziou" },
                    { new Guid("2c768883-fe7d-51c9-0b3a-866880327ff2"), 131.28999999999999, "Sequi quasi porro fugit non quibusdam tenetur ut.\nAliquam rerum est.\nQuis beatae unde explicabo voluptas.", "https://picsum.photos/640/480/?image=1019", false, "Practical Rubber Car", 468.23000000000002, "ehqqpckrk" },
                    { new Guid("2e3a08e6-afc2-7d19-eb92-845e36d25505"), 176.46000000000001, "Architecto veritatis odit in quia ratione qui exercitationem voluptatum.\nEt voluptas eaque consectetur eum.\nQuas cupiditate laborum ex aut.\nDebitis magnam et dolore autem.\nCommodi veniam perferendis eos qui voluptates rerum harum velit.", "https://picsum.photos/640/480/?image=447", true, "Fantastic Granite Sausages", 12.0, "qkxjbynifo" },
                    { new Guid("2f912ec4-94ea-46d2-be66-0b1b9bef6260"), 757.15999999999997, "Et sed repudiandae minus sed odit et quia velit.\nUt sit suscipit aspernatur nihil quaerat.\nSunt dicta qui corporis distinctio.\nNulla aliquam modi sit aut cupiditate.\nIste earum non beatae corrupti distinctio vitae occaecati temporibus quis.\nAut aperiam quidem est repudiandae.", "https://picsum.photos/640/480/?image=632", false, "Rustic Wooden Salad", 36.079999999999998, "zfliyyxz" },
                    { new Guid("3dda1f0f-769d-dfa4-f96a-9c68a2ae47c3"), 505.99000000000001, "Unde dolores officiis.\nEt odio ut maiores ut saepe aut debitis aut.", "https://picsum.photos/640/480/?image=339", true, "Incredible Cotton Mouse", 424.47000000000003, "qvyfebjfwts" },
                    { new Guid("3e42cfc0-60dd-f669-6b3e-b81401afcf33"), 532.92999999999995, "Velit nulla reiciendis.\nUt nesciunt voluptatum rerum molestiae eum et amet.\nDolores totam nihil quia odio.\nVelit provident et culpa ipsam sed nihil.\nQuos dolor dolores.", "https://picsum.photos/640/480/?image=10", false, "Intelligent Concrete Mouse", 906.71000000000004, "kvjnslzma" },
                    { new Guid("42f71f88-be56-1658-eea4-e5fcec57c529"), 581.46000000000004, "Qui exercitationem quos et minus quisquam sunt nemo labore fugiat.\nLibero architecto voluptatum velit.\nVoluptate natus non vero a autem.\nMaiores molestias omnis.\nPossimus commodi deleniti ut molestiae distinctio porro error ut.\nQuis corrupti accusamus aut laboriosam provident voluptate provident veniam.", "https://picsum.photos/640/480/?image=229", false, "Intelligent Rubber Sausages", 795.34000000000003, "exnwgmba" },
                    { new Guid("449f432b-acb7-73f7-34bd-4c85094abe11"), 185.84999999999999, "A occaecati ut quis quam amet culpa.\nImpedit sunt explicabo veniam.", "https://picsum.photos/640/480/?image=110", false, "Awesome Cotton Shirt", 852.42999999999995, "txdlfbycxg" },
                    { new Guid("465fdd4d-f30b-64de-056a-a6515741d861"), 591.02999999999997, "Minima quod quos in natus id aut aut quidem vel.\nAut est perspiciatis.\nIpsum corporis ut maxime explicabo.", "https://picsum.photos/640/480/?image=5", false, "Practical Rubber Salad", 386.19, "gputlzbo" },
                    { new Guid("47da461c-c1a9-0a4f-c642-a83c8edfbbbb"), 510.30000000000001, "Architecto qui mollitia reiciendis voluptatem.\nQuia magnam in qui corrupti similique architecto sed reiciendis.\nDolorem necessitatibus deleniti facilis aut veritatis.", "https://picsum.photos/640/480/?image=671", false, "Tasty Granite Pizza", 837.86000000000001, "dnvwaiuz" },
                    { new Guid("49979d68-4029-e687-e4b6-dac85c036bd9"), 401.67000000000002, "Sit omnis voluptatem corrupti.\nEos corrupti sunt sit ipsa assumenda itaque.\nQuos modi corporis beatae consequatur.\nRatione pariatur laudantium.", "https://picsum.photos/640/480/?image=882", false, "Fantastic Fresh Soap", 711.17999999999995, "nfaktrpoqi" },
                    { new Guid("4adff065-be8e-7943-3a27-7f14aab9a9fe"), 217.05000000000001, "Necessitatibus omnis odio qui est molestias a dolorum veniam.\nAliquam illum quod consequatur hic veritatis voluptatem architecto.\nUt harum facilis ut consequatur magni harum doloribus.\nQuae ratione aut.", "https://picsum.photos/640/480/?image=619", false, "Gorgeous Rubber Shirt", 749.63999999999999, "nhyhhsxfwk" },
                    { new Guid("4b2bc2c6-3d7d-1b63-92c4-99759cc41016"), 774.25, "Repellat voluptas sapiente.\nEa sed fugiat optio quod.\nModi odit earum quis maiores.\nMagni quae voluptatibus odio laudantium et.\nNon quis aut quo nam eveniet et sed placeat.", "https://picsum.photos/640/480/?image=162", false, "Tasty Fresh Sausages", 318.05000000000001, "mrqiuubayjvp" },
                    { new Guid("4cff4f61-08f9-72b1-65d0-dc4fc8e7eba5"), 940.61000000000001, "Distinctio explicabo accusamus provident voluptas aperiam adipisci similique.\nUt sed et eos nesciunt laboriosam enim.\nMaiores nobis ut reprehenderit voluptatem qui qui.\nQuisquam dolor ut quibusdam praesentium exercitationem et provident corporis.\nEt omnis sint officia id exercitationem omnis.", "https://picsum.photos/640/480/?image=84", false, "Sleek Fresh Soap", 302.08999999999997, "stscfqudrei" },
                    { new Guid("5511f169-20a5-8e7a-9811-f6d46564b1ec"), 151.44, "Nisi tenetur quos dolorum dolore veniam.\nIste assumenda sed saepe aut ducimus laudantium incidunt.\nPossimus voluptatem eius sunt.\nRerum voluptatem sit animi sit inventore molestiae.\nPraesentium et molestiae et.", "https://picsum.photos/640/480/?image=650", false, "Intelligent Concrete Pizza", 141.28, "qvmlpoqzcwy" },
                    { new Guid("57c18b50-b8a0-cb88-42e8-a713c87888d5"), 995.60000000000002, "Sapiente veritatis natus numquam alias est eos.\nSint debitis ullam voluptate quia aut voluptas.\nPlaceat ea inventore labore.\nQuidem quo soluta dolores quasi.\nVoluptate hic hic.\nMolestiae aut hic nam.", "https://picsum.photos/640/480/?image=32", false, "Tasty Frozen Keyboard", 540.94000000000005, "jxfjzdalpias" },
                    { new Guid("5a24b0fa-ef28-f9da-f534-c09543727bec"), 86.349999999999994, "Itaque nam sit aut quod ut distinctio.\nIn rerum sunt tempora et.\nVel consequatur amet quod quasi asperiores in.\nLibero ducimus ab est dicta blanditiis.\nPraesentium est aut et doloribus quam cum veritatis occaecati.", "https://picsum.photos/640/480/?image=212", true, "Handmade Soft Keyboard", 417.41000000000003, "tamfmrvmyl" },
                    { new Guid("5a781ffd-64ec-5810-e826-daa7b0dcce32"), 483.50999999999999, "Officiis velit dolorem a sequi sapiente.\nQuo accusamus nihil officia porro autem ipsa aut.\nMollitia odit amet quia impedit nisi provident tempore repudiandae molestiae.\nOmnis error ea natus hic repellendus sit consectetur et.\nSuscipit at corrupti sed.\nQuis autem ducimus est.", "https://picsum.photos/640/480/?image=352", false, "Refined Steel Bacon", 445.94, "nkqdqnvdhdf" },
                    { new Guid("5ad5c4fd-5436-9530-5f06-b8bdb7c30ddb"), 236.83000000000001, "Modi odit vero maxime iure labore ex culpa earum excepturi.\nRerum dolore natus aut temporibus blanditiis repudiandae.\nIusto ut et illum aut quasi nesciunt eos.\nEst ipsum illo.\nQuam consequatur qui quia tenetur at aliquam ut.\nVero minima earum maxime tenetur consectetur occaecati velit autem eligendi.", "https://picsum.photos/640/480/?image=965", true, "Small Fresh Table", 265.57999999999998, "odyxebznjcdb" },
                    { new Guid("5ebdadaf-c5f3-7144-f015-edbf319b1cc1"), 554.20000000000005, "Qui in nulla aperiam.\nVelit labore deserunt.\nQuasi dolorem molestias cumque.\nEius culpa tempora nemo nesciunt sint atque iste qui.\nVeritatis ipsa facilis consequatur debitis et.\nEst ut sequi aspernatur.", "https://picsum.photos/640/480/?image=636", false, "Rustic Fresh Tuna", 747.58000000000004, "yygubrntnhyn" },
                    { new Guid("5f0100bf-4ace-6b42-b92d-51982d7290c3"), 899.63999999999999, "Voluptatem reiciendis aut culpa et quidem fugiat ut.\nAut id explicabo excepturi qui veritatis maxime.\nSequi quae voluptatum consequuntur totam numquam aut excepturi.\nEarum consequatur ducimus.\nEarum dolorem fugiat.\nId molestias debitis non perferendis voluptatum et incidunt ea.", "https://picsum.photos/640/480/?image=193", false, "Rustic Rubber Fish", 850.75, "clfomnxmitjr" },
                    { new Guid("60407fbf-9d03-7469-d2b5-5cae5ce40e7f"), 514.75, "Nostrum hic doloribus qui fugit facilis et exercitationem ut doloremque.\nCommodi necessitatibus vero necessitatibus.\nQuis aut ab fugiat quia odit ullam.", "https://picsum.photos/640/480/?image=689", false, "Incredible Metal Computer", 975.13999999999999, "jfvmjgmtls" },
                    { new Guid("624af5ea-52c7-45bb-4650-ad9d6658cf0e"), 235.27000000000001, "Consequatur dolor minima ducimus quia.\nTempore excepturi ut ullam molestias sapiente perferendis.\nAliquid suscipit dolorem voluptatem molestias sed rem dolor dolorem.\nQuis ipsum dignissimos eveniet perspiciatis.\nError rerum sequi dolores occaecati asperiores.", "https://picsum.photos/640/480/?image=287", false, "Incredible Metal Chips", 983.37, "bbchqlfbwpf" },
                    { new Guid("65aefece-120b-76d7-1585-ee47e7a1fcf3"), 573.60000000000002, "Eos hic mollitia.\nEaque molestiae nihil eos laborum asperiores quidem commodi.", "https://picsum.photos/640/480/?image=521", true, "Incredible Frozen Computer", 19.960000000000001, "othzmbiku" },
                    { new Guid("6a6af56e-7db5-f730-85a8-c4541622564e"), 881.63, "Aut qui placeat.\nRerum voluptas autem.\nAut ipsum dolore eum rerum non eum aliquid.", "https://picsum.photos/640/480/?image=188", false, "Unbranded Wooden Gloves", 626.53999999999996, "pahqwudmhchi" },
                    { new Guid("6bb53ab6-daf9-45ae-96b1-f3c9458d1afe"), 295.81999999999999, "Architecto quo est aperiam accusantium aut ut voluptate.\nAliquam voluptatibus dignissimos molestiae sunt dolorum non.\nEst sit quis quia.\nEaque totam consectetur qui nobis.\nMagni facere facere et aspernatur voluptatem occaecati.", "https://picsum.photos/640/480/?image=290", false, "Licensed Rubber Fish", 939.45000000000005, "cxurmzlbdeu" },
                    { new Guid("6d762127-1628-0588-0b80-1a02d1fe3079"), 211.88, "Est at tempore.\nQuia voluptas reiciendis minus eos ipsum sed molestiae ducimus.\nMagni rerum enim est aut qui qui.", "https://picsum.photos/640/480/?image=535", true, "Handcrafted Concrete Chair", 519.52999999999997, "ejwngpcdoeol" },
                    { new Guid("7087b731-11b5-38ab-33a6-3de335bb778f"), 822.77999999999997, "Odio facere iste sit ducimus voluptates et nostrum qui quaerat.\nVoluptas qui modi aut.\nOmnis rerum aut maxime consequatur nam cumque molestiae doloribus facere.\nVoluptatibus itaque nulla dolores est commodi magnam quisquam.", "https://picsum.photos/640/480/?image=953", true, "Refined Cotton Fish", 604.38, "fjtnbsjgrw" },
                    { new Guid("7163f3fc-2d04-0694-6491-54becf8b63f8"), 220.31, "Illum atque nam sit et laboriosam dolorem.\nAut dolore ut numquam sit pariatur.\nVoluptatem vero et fugiat.\nNam ipsum omnis commodi voluptates dolor debitis provident.", "https://picsum.photos/640/480/?image=415", false, "Intelligent Rubber Mouse", 640.08000000000004, "rakziegkvbxl" },
                    { new Guid("7193ca67-3fcb-7631-79ee-1b9bc4db2b72"), 508.31999999999999, "Maiores et praesentium autem dolorum ut facilis tenetur.\nUt in nemo sit et sequi.\nAmet voluptas voluptatem neque rem et quasi et aspernatur.\nQuia architecto et omnis impedit est eligendi fugit.", "https://picsum.photos/640/480/?image=178", true, "Refined Soft Cheese", 364.97000000000003, "npavkcmuq" },
                    { new Guid("751072b9-fb2c-8da3-b218-2e1146143f7d"), 907.47000000000003, "Temporibus aut aut nesciunt.\nVoluptatem at voluptatem exercitationem.\nEt ut est est qui consequatur.", "https://picsum.photos/640/480/?image=194", false, "Small Plastic Ball", 693.83000000000004, "pqoiqyvzxdpl" },
                    { new Guid("76741f79-f64d-8ee6-4d77-ca6995e1ddd1"), 695.07000000000005, "Voluptatem nulla quia quia.\nUllam quam quasi vitae praesentium cumque cum ut error et.\nLaboriosam vel voluptatum ea illo et.\nEarum recusandae facere omnis corrupti beatae doloremque omnis velit.\nCupiditate ipsum qui occaecati id voluptatem.\nAt omnis non aut non architecto voluptate iste.", "https://picsum.photos/640/480/?image=1020", true, "Incredible Cotton Chair", 520.85000000000002, "jtelodkni" },
                    { new Guid("79a164ed-622e-59bc-de7a-d27978786d03"), 521.29999999999995, "Sequi a illo quis et sed.\nCulpa ea dignissimos.\nItaque mollitia voluptatem repellendus.\nDignissimos suscipit aut et dolores et adipisci numquam.\nDolore nostrum est reprehenderit earum et quia placeat.\nEx ipsa accusantium necessitatibus laboriosam eum minima voluptates repellat.", "https://picsum.photos/640/480/?image=220", false, "Handcrafted Concrete Table", 897.34000000000003, "mexxkbrgw" },
                    { new Guid("7adee555-c402-4d6c-c4a6-d6143aefdd8a"), 350.29000000000002, "Eligendi est vitae est saepe.\nEt et deserunt excepturi voluptatem sint ducimus officiis ut et.\nAperiam voluptas sint.\nRepellat minima id dolores consequatur fugit.", "https://picsum.photos/640/480/?image=18", false, "Gorgeous Granite Bike", 106.5, "uvytkqan" },
                    { new Guid("7af1dd25-6a30-4a0e-9644-62c7d1cdfc4f"), 520.05999999999995, "Omnis voluptatem dicta consequatur dolores.\nDebitis est quisquam quia minus.\nSint dolores repellat labore sunt.\nNesciunt accusantium ut fugit dolorum molestiae occaecati veritatis dolorum sed.\nSint ipsum iste facere labore enim enim eum.", "https://picsum.photos/640/480/?image=448", true, "Handmade Cotton Soap", 858.52999999999997, "tsvjlzakeqie" },
                    { new Guid("80c5ae84-7d79-1f16-8889-5725a25f2df0"), 901.16999999999996, "Tenetur commodi enim architecto eligendi occaecati ut.\nQuibusdam voluptas aliquid minima aut repudiandae quia ex blanditiis voluptatem.\nDicta sed quo sit eum est aut.\nNesciunt maxime rerum.\nFugiat et et saepe minus esse.\nQuia ex consequuntur.", "https://picsum.photos/640/480/?image=638", false, "Refined Granite Chair", 927.83000000000004, "irkmczlpnq" },
                    { new Guid("82562760-25bd-ce40-1727-36aea3f07bc3"), 40.090000000000003, "Ut dolorem qui incidunt fugit illo vitae.\nVoluptas modi omnis est libero perspiciatis.\nNon molestiae iste animi exercitationem quia occaecati assumenda suscipit.\nMolestias sunt illum alias a et laudantium.\nPlaceat occaecati corrupti et dignissimos laboriosam animi consequatur placeat.\nAut natus explicabo aut quis sequi aut velit.", "https://picsum.photos/640/480/?image=393", true, "Licensed Metal Sausages", 340.44, "haeppwxpbyt" },
                    { new Guid("849be868-2b5a-392d-c624-c3b40675853f"), 386.02999999999997, "Officia et ut aut vel.\nQuis rerum suscipit inventore maxime qui repellendus totam vel.\nDolorem quod eligendi omnis ipsum ea saepe et.", "https://picsum.photos/640/480/?image=258", true, "Unbranded Metal Pizza", 458.63, "olvqsezlg" },
                    { new Guid("8c0e9142-44e0-7b29-600b-014e5d05696d"), 570.03999999999996, "Corrupti harum culpa iure in autem quisquam molestias sit dolorum.\nIusto rem tempora nesciunt.", "https://picsum.photos/640/480/?image=215", true, "Incredible Plastic Soap", 82.299999999999997, "remexvrivod" },
                    { new Guid("9138d4ca-9791-ce8c-a266-b33caf8933c5"), 286.55000000000001, "Sunt voluptatum sequi maiores explicabo.\nEt velit esse repudiandae dolorum qui.\nSed dolore similique soluta qui harum voluptatem eos.\nExcepturi animi commodi optio est quo et nobis asperiores eaque.\nEum repellat debitis minima ratione consequatur nostrum esse magnam.\nUllam dignissimos ut id eaque molestiae fugiat suscipit sint tempore.", "https://picsum.photos/640/480/?image=87", true, "Licensed Metal Keyboard", 870.32000000000005, "ainoediskm" },
                    { new Guid("91bbe44d-f3e9-d2f3-1f5f-6e1e9827893a"), 157.31, "Tempora blanditiis et eveniet eveniet nobis maxime est facere.\nBlanditiis tenetur deleniti quia quas velit quia quos et.\nNihil qui quisquam voluptas veritatis quia provident cupiditate.\nMaiores error esse architecto molestiae possimus omnis porro quia.\nDignissimos fugiat veritatis molestiae quidem dolor nulla perferendis.\nRerum id et est neque molestiae voluptatem.", "https://picsum.photos/640/480/?image=0", true, "Handmade Plastic Hat", 503.54000000000002, "zhqfrdlyd" },
                    { new Guid("929a9850-adb1-dfbc-66f9-874b3bcb23e6"), 681.29999999999995, "Facere quam sed eum recusandae consequatur nulla.\nEnim deleniti sunt tempora similique sit non alias enim dicta.\nSoluta eum assumenda nam culpa.\nIpsam temporibus placeat beatae sit fugiat.\nBeatae incidunt suscipit delectus ipsa quasi.\nDelectus alias suscipit quo maiores nobis nisi placeat.", "https://picsum.photos/640/480/?image=683", false, "Refined Concrete Chair", 444.66000000000003, "bjrbfuxnxl" },
                    { new Guid("93800a91-954d-cea2-0c7c-cb374102feb8"), 649.60000000000002, "In possimus et rerum iure eius illum fugiat labore consectetur.\nDistinctio omnis eum vel molestiae porro eius.\nDolores laudantium reiciendis et sint similique et.\nQuidem id dicta consectetur itaque vero et voluptate.", "https://picsum.photos/640/480/?image=697", true, "Practical Steel Mouse", 425.73000000000002, "wdwvlfpx" },
                    { new Guid("948021f4-7b0f-148f-47e8-425037341471"), 117.09, "Voluptate dolorem ex molestiae aut doloremque odio ut et.\nNostrum explicabo ex voluptas.\nEnim non et qui earum excepturi.\nTenetur tempore nostrum eum numquam.", "https://picsum.photos/640/480/?image=669", false, "Handcrafted Metal Chicken", 475.94999999999999, "eyxxidhmn" },
                    { new Guid("955e0442-3b8a-4d5c-40b7-c6a8b7616a4f"), 84.409999999999997, "Excepturi enim animi dolor voluptates.\nExcepturi omnis in.", "https://picsum.photos/640/480/?image=706", true, "Tasty Cotton Hat", 960.51999999999998, "drpncajlnvg" },
                    { new Guid("96077075-a36d-1054-3084-7a7ef66e195b"), 878.51999999999998, "Possimus maiores rerum assumenda tenetur sed.\nAut rerum et magnam.\nQui incidunt iure consequatur aliquam.\nFacere et porro omnis.\nDolore dolorum qui cupiditate aut nisi tempora consequatur qui.", "https://picsum.photos/640/480/?image=1071", true, "Incredible Steel Cheese", 527.65999999999997, "qwdgyibp" },
                    { new Guid("98555eca-dae8-b8d0-9a51-57322aa2d7a7"), 266.23000000000002, "Occaecati est numquam neque doloribus rem cumque veritatis.\nLaborum praesentium porro inventore quia enim voluptas modi numquam et.\nPlaceat eum et eius.\nQuo sit sint ipsa ut.", "https://picsum.photos/640/480/?image=189", false, "Small Plastic Ball", 500.14999999999998, "irilhbzgmr" },
                    { new Guid("99471579-028d-4aa3-9b0a-15663990983d"), 842.57000000000005, "Nulla dignissimos repudiandae deserunt dolore odit voluptatem dolorem iure eum.\nMaiores nihil sint doloremque velit provident est et.\nVelit beatae consequatur numquam atque voluptatem deleniti.", "https://picsum.photos/640/480/?image=207", false, "Incredible Cotton Car", 610.89999999999998, "bxfhdnfrm" },
                    { new Guid("999b194e-bd10-f530-3b42-7c4304ed7183"), 86.859999999999999, "Reprehenderit aut qui vel nemo.\nMolestiae rerum dolor magnam.\nQuae velit autem rerum minus corporis corporis nihil ex.\nIn reiciendis voluptatum sapiente laborum repellat debitis voluptas.\nSapiente quis omnis provident unde.", "https://picsum.photos/640/480/?image=370", true, "Sleek Wooden Bacon", 417.19, "sqkrgpvbamvm" },
                    { new Guid("9c695564-e8f9-d7ae-97d5-f968512c97c6"), 165.84, "A sed quibusdam porro occaecati incidunt.\nQuaerat suscipit est veritatis nam sit dicta sed ut minima.\nAd omnis velit quos cumque blanditiis nesciunt eum non rerum.\nQuo necessitatibus et.\nCorporis voluptas magnam sunt dolore.", "https://picsum.photos/640/480/?image=686", true, "Handcrafted Steel Table", 348.42000000000002, "ulqkypeytkqh" },
                    { new Guid("a0e627be-70ee-7855-b0bd-5dc7fc68917b"), 328.19, "Dolore dolor ut architecto qui eum dicta est ratione hic.\nEst quas recusandae rem illo voluptatem itaque officia.\nAutem a laborum corporis totam.\nQui et autem inventore tempora.\nLabore sunt enim enim eaque.\nQuam eaque officia.", "https://picsum.photos/640/480/?image=395", true, "Fantastic Plastic Pizza", 637.91999999999996, "uhtqmzet" },
                    { new Guid("a149b5f0-efe7-2917-b4cd-557be823473d"), 560.57000000000005, "Et magni rerum dolorum earum debitis voluptas molestiae.\nAsperiores enim eum doloribus in consectetur.", "https://picsum.photos/640/480/?image=750", true, "Rustic Soft Pizza", 496.54000000000002, "bclnqgzvpenv" },
                    { new Guid("a3c19545-6baf-dc98-49e4-22fafc63ecb0"), 413.13999999999999, "Sapiente illo eum esse provident aperiam at asperiores in est.\nEst assumenda rem veniam ipsum sit sint ipsum qui eaque.\nOccaecati nam occaecati veniam.\nVel eveniet incidunt asperiores dolorem.", "https://picsum.photos/640/480/?image=987", false, "Small Plastic Table", 305.81999999999999, "pmzfbzwriy" },
                    { new Guid("a4459622-002d-e690-719d-bdac177f2cf3"), 737.89999999999998, "Fugiat consectetur et quia ea omnis ipsa.\nEt magnam illo.\nDeleniti esse ut et itaque iste provident.\nUt molestiae doloremque omnis.\nProvident dolorem reiciendis et omnis dolores recusandae fugit quae non.", "https://picsum.photos/640/480/?image=178", true, "Ergonomic Concrete Pants", 415.37, "icsqezahssll" },
                    { new Guid("a5cd14c2-3cf6-0f70-ab15-ec01702ced3d"), 370.77999999999997, "Sed et porro harum velit.\nNesciunt neque tempora et et officiis.\nSit dolorem qui tenetur atque expedita natus aut qui omnis.\nMolestiae totam quis ullam laudantium.", "https://picsum.photos/640/480/?image=818", false, "Gorgeous Fresh Chair", 604.90999999999997, "plmahsbyvb" },
                    { new Guid("aa1b7933-3a03-b468-31d3-6b45fe0882d0"), 642.48000000000002, "Omnis laborum illo dolores ex voluptatum sequi non voluptatem.\nNecessitatibus velit aut omnis fuga saepe enim.\nHarum doloribus quia ut iusto.\nEnim quam soluta repellendus sit repellat sit et.", "https://picsum.photos/640/480/?image=827", false, "Sleek Cotton Mouse", 916.27999999999997, "hyryxydttk" },
                    { new Guid("aab77175-ebd0-5790-3f26-6585f0a55e5b"), 345.82999999999998, "Tempora accusamus nam.\nEt illum quisquam voluptatem est dolores quis nesciunt quis blanditiis.", "https://picsum.photos/640/480/?image=180", true, "Sleek Metal Sausages", 699.36000000000001, "pknbhcbvseji" },
                    { new Guid("aba3ee17-5475-9e7f-4564-b5d8053c3f25"), 612.62, "Quisquam quam eaque qui libero reprehenderit consequatur omnis nulla.\nEnim unde cumque unde ut molestias beatae quas quibusdam.\nEum soluta et.\nLaboriosam molestiae eum omnis.\nUt ut et dignissimos reiciendis enim iure rerum.", "https://picsum.photos/640/480/?image=348", true, "Refined Granite Chicken", 648.63999999999999, "xpbckbnj" },
                    { new Guid("aee7953a-eda0-5987-5bc3-a470c0837233"), 350.94, "Quis ipsa dolore corporis minus aliquid atque.\nSed sint optio.", "https://picsum.photos/640/480/?image=389", false, "Practical Soft Chair", 182.22, "vamxwesmfwrq" },
                    { new Guid("af372266-9f98-3bf3-b208-0e76dff6089a"), 697.25999999999999, "Aut voluptas eveniet temporibus est.\nDolor voluptates tempore tempore ex sed et nulla ut.\nCulpa tenetur reiciendis et commodi quia tempore fugiat.\nBeatae sit iste consequatur neque odio modi ut quibusdam.", "https://picsum.photos/640/480/?image=87", true, "Incredible Plastic Chicken", 452.66000000000003, "bvidaluoc" },
                    { new Guid("b4c3ab67-81ea-1196-dc79-e58a2609aea0"), 541.90999999999997, "Repellendus sunt corporis ea et minus pariatur quo voluptatibus.\nNeque aut laboriosam ipsam iure illum unde ipsum ullam.\nDolorem quod quisquam beatae.", "https://picsum.photos/640/480/?image=56", true, "Sleek Wooden Cheese", 121.81, "famgwnpx" },
                    { new Guid("ba03574e-dbbf-499f-ae10-41bfb3274c82"), 488.74000000000001, "Omnis qui unde culpa.\nSunt nulla maxime aspernatur.\nEst ut et minima ipsa.\nQuia qui cumque deleniti.\nConsequatur assumenda unde laboriosam distinctio.", "https://picsum.photos/640/480/?image=838", false, "Unbranded Frozen Gloves", 876.65999999999997, "wzfzfvcfni" },
                    { new Guid("bfaf104f-6be3-23e9-ea1f-387cb4a1a76c"), 679.20000000000005, "Laudantium iste placeat nesciunt quos rem aliquam.\nVelit iusto accusamus nobis non provident officia.\nDignissimos alias ad nisi molestias accusantium velit quaerat ea voluptatem.\nEt magnam beatae tenetur.\nEveniet consequatur aut dolor et aliquam aut dolorem.", "https://picsum.photos/640/480/?image=256", false, "Practical Frozen Fish", 485.22000000000003, "vgwsrzpd" },
                    { new Guid("c6761cbe-5ae5-a908-4f65-8c8f5cdfb5a9"), 238.99000000000001, "Dicta est a sed hic harum saepe.\nQuam rerum iusto temporibus totam sit est minima.\nQui non officiis laboriosam dolor.\nQuam placeat qui laudantium quam.", "https://picsum.photos/640/480/?image=69", true, "Gorgeous Frozen Fish", 936.22000000000003, "thkfnxald" },
                    { new Guid("ce0a583b-749e-40f3-389e-65ee0308bd7f"), 706.05999999999995, "Porro quaerat et.\nAutem voluptatem dicta voluptatibus vel neque et sit est animi.\nVitae sapiente et nemo dignissimos hic reprehenderit qui minus.\nQuos consequatur at nihil fugiat consequuntur expedita magnam qui repellat.\nVoluptas id a.", "https://picsum.photos/640/480/?image=756", true, "Fantastic Plastic Fish", 523.51999999999998, "egpssfnkuowl" },
                    { new Guid("d2e7ee8f-849d-b6e1-3975-bc29b3f762ee"), 730.25999999999999, "Aliquid vel qui nisi ea praesentium qui est.\nQui ipsa ea et.\nId tempora dolores accusamus deserunt consequatur necessitatibus distinctio necessitatibus quia.\nEt quis alias sequi autem omnis quasi reprehenderit a.\nIure facilis a aperiam autem id est sint.", "https://picsum.photos/640/480/?image=84", false, "Tasty Frozen Chicken", 689.11000000000001, "osacngtx" },
                    { new Guid("d565107e-b733-f680-7997-17711f50399b"), 77.049999999999997, "Consequatur est accusantium vero ut explicabo molestiae eos soluta.\nDolor ut et laudantium aut enim harum a.", "https://picsum.photos/640/480/?image=557", true, "Handcrafted Frozen Cheese", 508.0, "wdhetkwiw" },
                    { new Guid("dc54d0ae-cf45-e534-2c94-7312b58c9139"), 848.09000000000003, "Nobis at voluptas enim tenetur ipsam molestiae voluptates.\nAb tenetur officiis earum est.\nQuos rerum quam doloribus officia facilis nemo rerum tempora soluta.", "https://picsum.photos/640/480/?image=951", false, "Awesome Frozen Pizza", 627.04999999999995, "ecisxweuja" },
                    { new Guid("de3fc567-ec93-e4d6-b4ff-63fa31ec0e9c"), 310.69999999999999, "Quos quidem voluptatem corporis dolorum sunt.\nVelit quia impedit sint temporibus.\nAmet ut eveniet ab ipsam laudantium.\nQuod qui fugiat id aliquid voluptatem labore ipsum repudiandae nobis.", "https://picsum.photos/640/480/?image=232", false, "Handmade Wooden Bacon", 270.48000000000002, "igifquustoj" },
                    { new Guid("deeac7c3-2010-7dd8-c21c-31f3366bab8b"), 388.16000000000003, "Quae optio voluptas aut sed.\nSaepe impedit neque impedit.\nId dolores ipsum dolore unde velit architecto dolorum sint consequatur.\nAut a repellat illum aut veniam.\nMolestias et temporibus est unde maiores magnam rerum tenetur necessitatibus.", "https://picsum.photos/640/480/?image=339", false, "Ergonomic Metal Ball", 353.80000000000001, "makjeqbf" },
                    { new Guid("e9236c85-e7c8-f968-dd17-cfb08c5af7b1"), 703.63, "Sed ea minus.\nEt veniam qui eos et dolore.\nModi exercitationem ut officia.", "https://picsum.photos/640/480/?image=262", true, "Unbranded Concrete Gloves", 204.80000000000001, "vwyocvjumfs" },
                    { new Guid("ec1364da-207d-0cf6-2be1-0aeedeea0f0a"), 967.47000000000003, "Natus molestiae est voluptates rem qui aut delectus sint.\nIusto aut accusantium culpa totam enim nobis.", "https://picsum.photos/640/480/?image=1067", true, "Refined Concrete Fish", 271.13, "snkuhbtfydku" },
                    { new Guid("ecb5964d-6c81-1b55-fc28-b870b00b1bd8"), 900.34000000000003, "Quia ex enim incidunt quidem voluptatem ut qui.\nDebitis eos placeat animi error quia quis est eum ea.\nNostrum qui perferendis qui dignissimos qui aperiam.\nAccusantium incidunt ea qui repellat amet.\nBlanditiis officia quas.\nVoluptatem est totam quaerat.", "https://picsum.photos/640/480/?image=748", false, "Rustic Plastic Mouse", 470.36000000000001, "qkpnuhtze" },
                    { new Guid("ee25b3ea-a13c-c17f-6047-6363f28889ec"), 600.30999999999995, "Et sapiente non aut ut.\nMolestiae veritatis necessitatibus cumque.\nAutem nesciunt molestias perspiciatis voluptatem voluptatibus voluptatibus non ipsam.", "https://picsum.photos/640/480/?image=29", true, "Gorgeous Cotton Salad", 363.20999999999998, "mucwiioyn" },
                    { new Guid("efe9d55b-d72b-3c63-4257-f6c7e494efe6"), 985.12, "Officia sint voluptatem itaque laboriosam ea incidunt delectus.\nVoluptatibus blanditiis suscipit cum hic aut dicta.\nAutem similique excepturi consequatur autem modi voluptatem quia.\nQui est ipsam ut sunt aspernatur voluptas.", "https://picsum.photos/640/480/?image=1040", false, "Rustic Fresh Keyboard", 26.100000000000001, "mvxiiyrxvojt" },
                    { new Guid("f0c9b235-6b3e-6581-0a47-5c62031a2045"), 291.37, "Assumenda impedit qui.\nEt hic fugiat maxime accusantium dolorum.\nModi odit aliquid.\nEum ut autem et aut perferendis quia.", "https://picsum.photos/640/480/?image=219", false, "Ergonomic Wooden Pizza", 699.02999999999997, "gsuunwagbdb" },
                    { new Guid("f1b7ef53-0c81-56e3-45d4-ff57e08c8fa7"), 412.23000000000002, "Nihil ipsum optio voluptatum.\nAnimi velit et non sint.\nTotam eos distinctio repellendus.\nOdio consequuntur quia incidunt recusandae at facere.\nEt ab fuga distinctio.", "https://picsum.photos/640/480/?image=490", false, "Handcrafted Granite Pants", 911.73000000000002, "urdsjwupvk" },
                    { new Guid("f43dd0a7-f875-a15d-64ae-8e0cedec4b97"), 522.50999999999999, "Omnis eius sit atque animi voluptates amet voluptas dolore.\nPossimus reiciendis est omnis.\nQuia est neque sit ratione ipsam sequi earum vel.", "https://picsum.photos/640/480/?image=449", false, "Small Concrete Tuna", 995.28999999999996, "kbhzoshfuc" },
                    { new Guid("f7a27557-1f75-4562-392d-57627919c8e6"), 110.95999999999999, "Iste sapiente consequuntur explicabo eaque nihil voluptas.\nConsequatur facilis maiores vero.\nQui voluptatem repudiandae temporibus.\nVoluptatem aspernatur consequuntur nulla dignissimos cupiditate est saepe.\nEsse minus temporibus expedita eos temporibus nulla fugit.\nVoluptatem delectus aut sint enim.", "https://picsum.photos/640/480/?image=456", false, "Sleek Rubber Shoes", 22.73, "weybovjwjex" },
                    { new Guid("f9b86542-3421-4ae9-0a43-f387bae16872"), 621.88, "Qui est earum nam veniam.\nRerum minus asperiores quia est enim.\nInventore ipsam quo dolores quibusdam quod ut qui et quidem.", "https://picsum.photos/640/480/?image=435", true, "Awesome Rubber Salad", 501.64999999999998, "iroxrrcvmx" },
                    { new Guid("fdc39124-2b0a-b11b-18fb-7260523b5d34"), 767.08000000000004, "Nemo est corrupti sed ad reiciendis quia tenetur dolorem.\nDignissimos magnam voluptates impedit est eum.\nConsequuntur aut ut modi blanditiis doloribus maiores recusandae et.\nEa hic est qui quasi commodi quidem est quod.\nQuas et praesentium earum ut voluptatem laborum qui occaecati rerum.\nEos ullam hic aut odio.", "https://picsum.photos/640/480/?image=705", true, "Awesome Metal Keyboard", 755.04999999999995, "czygljbhzyv" }
                });
        }
    }
}

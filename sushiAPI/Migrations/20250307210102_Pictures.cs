using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sushiAPI.Migrations
{
    /// <inheritdoc />
    public partial class Pictures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "3 lax, 1 räka, 1 avokado, 3 futomakirullar med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHC97aSO8QolfP_75c905eSbFjSYFkuHRmzA&s" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "3 lax, 1 räka, 1 avokado, 1 tonfisk, 1 bläckfisk, 4 futomakirullar med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6M9H7I418gOLiVZ48aXGo5GNIhNjf1XMi4w&s" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "5 lax, 1 räka, 1 avokado, 1 tonfisk, 1 hokkigai mussla, 1 bläckfisk, 4 futomakirullar med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS_rPIccq0sVCTu6Vypgs5qg9mkNLiaVqRn5g&s" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ProductDescription", "ProductImage", "ProductName" },
                values: new object[] { "Halstrad lax med chilimajonnäs, ålsås, sesamfrö och rostad lök.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRwXWRc-bVTqjz_uRMjBh7pJP3amHNOBBE5zA&s", "Lätt grillad 8 bitar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "3 lax, 1 räka, 1 avokado, 1 tonfisk, 1 hokkigai mussla, 1 pilgrims mussla, 1 sardin, 1 ål, 1 bläckfisk, chillimajonäs, ålsås, sesamfrö, rom och rostad lök.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSk2AIUIoGdq8t0h5THZYxnP4XqGMpsbILMhw&s" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "9 bitar laxnigiri med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTwY_15mOvAKlD2J6J9JpDweEpBhnS2BH5CWQ&s" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "5 lax, 4 avokado, chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ48iaAy81c6BCNL1QOMYUaAzh5O6i5yVlkVw&s" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "ProductDescription", "ProductImage", "ProductName" },
                values: new object[] { "5 lax, 4 räkor, chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXPraCfYN857lbWbxZ9-n8TrELfOS4XpCTfw&s", "Lax räkor sushi 9 bitar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "ProductDescription", "ProductImage", "ProductName" },
                values: new object[] { "9 bitar räknigiri med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSaBo81jS3KYx4bSDzJKopZDApnvPVNEuAuCA&s", "Räk sushi 9 bitar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "3 avokado, 2 tofu, 4 vegetariska rullar, edamame, soya sås, sesamfrö och rostad lök.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRI87TnpM3n3bSd-3N-fwG1SBG_7NXny0qjJA&s" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "5 avokado, 3 tofu, 4 vegetariska rullar, edamame, soya sås, sesamfrö och rostad lök.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEnuqODIUMocXlMm054D1G0-hfJ-J_-TcXIw&s" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "2 avokado, 1 räka, 1 tofu, 1 crabstick surimi, 4 vegetariska rullar, chilimajonnäs, soya sås, sesamfrö och rostad lök.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS016V_D80oDQ1kgaudn-6JUcr6zucxWG08fw&s" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "4 avokado, 1 räka, 2 tofu, 1 crabstick surimi, 4 vegetariska rullar, chilimajonnäs, soya sås, sesamfrö och rostad lök.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS7h189nxA56bT7-gZEVpm0bzSr6s2YTxW_5g&s" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "Olika sorters rå fisk med blandad sallad, chilimajonnäs, ål sås, sesamfrö och rostad lök", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSO5OIdUxpnygTC86_eWbfM8ifJqNAylwSBRQ&s" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "Olika sorters rå fisk med blandad sallad, chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQTbYpfW_Sfcs4e-W3eXIkv83jbd0h2jOMv2Q&s" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "Lax, tonfisk, avokado, gurka, crabstick surimi, ål sås, chilimajonnäs, sesamfrö och rostad lök.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQr7l1LmWInyy3_hdsohHWI-xsjV6CauBtvHw&s" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "3 lax, 1 r�ka, 1 avokado, 3 futomakirullar med chilimajonn�s, �l s�s, sesamfr�, rom och rostad l�k.", "/images/menu-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "3 lax, 1 r�ka, 1 avokado, 1 tonfisk, 1 bl�ckfisk, 4 futomakirullar med chilimajonn�s, �l s�s, sesamfr�, rom och rostad l�k.", "/images/menu-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "5 lax, 1 r�ka, 1 avokado, 1 tonfisk, 1 hokkigai mussla, 1 bl�ckfisk, 4 futomakirullar med chilimajonn�s, �l s�s, sesamfr�, rom och rostad l�k.", "/images/menu-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ProductDescription", "ProductImage", "ProductName" },
                values: new object[] { "Halstrad lax med chilimajonn�s, �ls�s, sesamfr� och rostad l�k.", "/images/menu-4.jpg", "L�tt grillad 8 bitar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "3 lax, 1 r�ka, 1 avokado, 1 tonfisk, 1 hokkigai mussla, 1 pilgrims mussla, 1 sardin, 1 �l, 1 bl�ckfisk, chillimajon�s, �ls�s, sesamfr�, rom och rostad l�k.", "/images/menu-5.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "9 bitar laxnigiri med chilimajonn�s, �l s�s, sesamfr�, rom och rostad l�k.", "/images/menu-6.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "5 lax, 4 avokado, chilimajonn�s, �l s�s, sesamfr�, rom och rostad l�k.", "/images/menu-7.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "ProductDescription", "ProductImage", "ProductName" },
                values: new object[] { "5 lax, 4 r�kor, chilimajonn�s, �l s�s, sesamfr�, rom och rostad l�k.", "/images/menu-8.jpg", "Lax r�kor sushi 9 bitar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "ProductDescription", "ProductImage", "ProductName" },
                values: new object[] { "9 bitar r�knigiri med chilimajonn�s, �l s�s, sesamfr�, rom och rostad l�k.", "/images/menu-9.jpg", "R�k sushi 9 bitar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "3 avokado, 2 tofu, 4 vegetariska rullar, edamame, soya s�s, sesamfr� och rostad l�k.", "/images/menu-10.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "5 avokado, 3 tofu, 4 vegetariska rullar, edamame, soya s�s, sesamfr� och rostad l�k.", "/images/menu-11.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "2 avokado, 1 r�ka, 1 tofu, 1 crabstick surimi, 4 vegetariska rullar, chilimajonn�s, soya s�s, sesamfr� och rostad l�k.", "/images/menu-12.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "4 avokado, 1 r�ka, 2 tofu, 1 crabstick surimi, 4 vegetariska rullar, chilimajonn�s, soya s�s, sesamfr� och rostad l�k.", "/images/menu-13.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "Olika sorters r� fisk med blandad sallad, chilimajonn�s, �l s�s, sesamfr� och rostad l�k", "/images/menu-14.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "Olika sorters r� fisk med blandad sallad, chilimajonn�s, �l s�s, sesamfr�, rom och rostad l�k.", "/images/menu-15.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "ProductDescription", "ProductImage" },
                values: new object[] { "Lax, tonfisk, avokado, gurka, crabstick surimi, �l s�s, chilimajonn�s, sesamfr� och rostad l�k.", "/images/menu-16.jpg" });
        }
    }
}

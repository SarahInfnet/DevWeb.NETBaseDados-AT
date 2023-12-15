using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtPetShop.Migrations
{
    public partial class PopulandoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ShelfLocation",
                columns: new[] { "Id", "Aisle", "Column", "Created", "Row" },
                values: new object[] { 1, 6, 3, new DateTime(2023, 12, 15, 16, 21, 0, 750, DateTimeKind.Local).AddTicks(8609), 4 });

            migrationBuilder.InsertData(
                table: "ShelfLocation",
                columns: new[] { "Id", "Aisle", "Column", "Created", "Row" },
                values: new object[] { 2, 7, 1, new DateTime(2023, 12, 15, 16, 21, 0, 750, DateTimeKind.Local).AddTicks(8618), 5 });

            migrationBuilder.InsertData(
                table: "ShelfLocation",
                columns: new[] { "Id", "Aisle", "Column", "Created", "Row" },
                values: new object[] { 3, 9, 6, new DateTime(2023, 12, 15, 16, 21, 0, 750, DateTimeKind.Local).AddTicks(8618), 12 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShelfLocationId", "ShortDescription" },
                values: new object[] { 1, "Roupa", new DateTime(2023, 12, 15, 16, 21, 0, 750, DateTimeKind.Local).AddTicks(8689), "Vestido rosa para gatos filhotes, tecido sem estampa", "pinkDress.jpg", "Vestido para gato", 45m, 1, "Vestido rosa" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShelfLocationId", "ShortDescription" },
                values: new object[] { 2, "Farmácia", new DateTime(2023, 12, 15, 16, 21, 0, 750, DateTimeKind.Local).AddTicks(8692), "Indicado para cães de 5,1 a 10 kg. Proteção contra pulgas, carrapatos, sarnas. Comprimido mastigável", "antipulgas.jpg", "Antipulgas", 95.69m, 2, "Antipulgas Simparic 20 mg para cães 5,1 a 10 kg - Zoetis" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Created", "Description", "ImageFile", "Name", "Price", "ShelfLocationId", "ShortDescription" },
                values: new object[] { 3, "Acessórios de Alimentação", new DateTime(2023, 12, 15, 16, 21, 0, 750, DateTimeKind.Local).AddTicks(8693), "Recipiente amplo e limpo. Disponível nos tamanhos 2, 3 e 4.", "comedouro.jpg", "Comedouro", 59.99m, 3, "Comedouro Chalesco Duplo Inox para Cães" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ShelfLocation",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShelfLocation",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShelfLocation",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

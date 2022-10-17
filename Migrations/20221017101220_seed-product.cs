using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComputerStore.Migrations
{
    public partial class seedproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1L, "Ноутбуки", "Екран 15.6” IPS (1920x1080) Full HD, матовий/AMD Ryzen 5 3500U (2.1 — 3.7 ГГц)/RAM 8 ГБ/SSD 512 ГБ/AMD Radeon Vega 8 Graphics/без ОД/LAN/Wi-Fi/Bluetooth/вебкамера/Windows 10 Pro 64bit/1.74 кг/сірий", "HP 255 G8 (2W1E7EA) Asteroid Silver", 32599m },
                    { 2L, "Ноутбуки", "Екран 14\" IPS (1920x1080) Full HD, матовий / Intel Core i3-1125G4 (2.0 — 3.7 ГГц) / RAM 8 ГБ / SSD 512 ГБ / Intel UHD Graphics / без ОД / Wi-Fi / Bluetooth / вебкамера / Windows 10 Home 64 bit / 1.41 кг / сріблястий", "HP Pavilion 14-dv0047ua (4A7L9EA) Natural Silver", 36055m },
                    { 3L, "Мобільні телефони", "Екран (6.4\", Super AMOLED, 2400x1080) / MediaTek Helio G80(2.0 ГГц + 1.8 ГГц) / основна квадрокамера: 64 Мп + 8 Мп + 2 Мп + 2 Мп, фронтальна камера: 20 Мп / RAM 6 ГБ / 128 ГБ вбудованої пам'яті + microSD (до 1 ТБ) / 3G / LTE / GPS / підтримка 2 SIM-карток (Nano-SIM) / Android 11 / 5000 мА·год", "Samsung Galaxy M32 6/128 GB Light Blue (SM-M325FLBGSEK)", 8555m },
                    { 4L, "Комп'ютерні миші", "Під'єднання Бездротове / Розмір миші Маленька / Особливості Для обох рук (симетричний дизайн) / Сумісність з ОС Mac OS, Microsoft Windows", "Logitech M185 Wireless Blue (910-002239/910-002236)", 8555m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4L);
        }
    }
}

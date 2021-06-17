using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieDataBase.Migrations
{
    public partial class MovieMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    ID_M = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name_P = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Synopsis = table.Column<string>(type: "TEXT", nullable: true),
                    Genre = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Director = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Duration = table.Column<int>(type: "INTEGER", nullable: false),
                    Photo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.ID_M);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID_M", "Director", "Duration", "Genre", "Name_P", "Photo", "Synopsis" },
                values: new object[] { 1, "Vicky Jenson", 90, "Animación", "Shrek I", "shrek1.jpg", "Shrek es un ogro verde, gruñón y altamente territorial que ama la soledad..." });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID_M", "Director", "Duration", "Genre", "Name_P", "Photo", "Synopsis" },
                values: new object[] { 2, "Vicky Jenson", 93, "Animación", "Shrek II", "shrek2.jpg", "Tras su luna de miel después de derrotar a lord farquaad en la película anterior , el ogro Shrek y la princesa Fiona regresan a su pantano..." });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID_M", "Director", "Duration", "Genre", "Name_P", "Photo", "Synopsis" },
                values: new object[] { 3, "Rob Cohen", 107, "Accion", "The Fast and the Furious", "fastfurious1.jpg", "El oficial de policía Brian O'Conner (Paul Walker) es enviado encubierto en una investigación conjunta de la policía de Los Ángeles y el FBI para detener a la banda que se dedica al robo de camiones con mercancía..." });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID_M", "Director", "Duration", "Genre", "Name_P", "Photo", "Synopsis" },
                values: new object[] { 4, "Jill Culton", 97, "Animación", "Abominable", "abominable.jpg", "Un joven Yeti escapa de un complejo en Shanghái propiedad del rico empresario Burnish (Eddie Izzard), que tiene la intención de usarlo para demostrar la existencia de yetis en el mundo..." });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID_M", "Director", "Duration", "Genre", "Name_P", "Photo", "Synopsis" },
                values: new object[] { 5, "Sam Mendes", 143, "Acción", "Skyfall", "skyfall.jpg", "" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID_M", "Director", "Duration", "Genre", "Name_P", "Photo", "Synopsis" },
                values: new object[] { 6, "Peter Jackson", 201, "Aventuras", "El Señor de los Anillos: El Retorno del Rey", "senoranillos1.jpg", "La historia comienza con un recuerdo de cómo el hobbit Smeágol llegó a poseer el Anillo de Poder, tras matar a su amigo Déagol, quien lo había encontrado en el fondo de un río..." });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID_M", "Director", "Duration", "Genre", "Name_P", "Photo", "Synopsis" },
                values: new object[] { 7, "Rich Moore", 108, "Animación", "Zootopia", "zootopia.jpg", "En un mundo poblado por animales antropomórficos en donde los humanos nunca existieron, Judy Hopps, una coneja de la ciudad rural de Bunnyburrow, sueña con convertirse en oficial de policía..." });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID_M", "Director", "Duration", "Genre", "Name_P", "Photo", "Synopsis" },
                values: new object[] { 8, "James Wan", 143, "Acción, Aventura, Fantasía, Superhéroes", "Aquaman", "aquaman.jpg", "En Maine, 1985, el guardián del faro Thomas Curry encuentra y rescata, durante una tormenta, seriamente herida a la princesa del reino submarino Atlantis, Atlanna y la lleva a su casa..." });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID_M", "Director", "Duration", "Genre", "Name_P", "Photo", "Synopsis" },
                values: new object[] { 9, "James Cameron", 162, "Ciencia ficción", "Avatar", "avatar1.jpg", "La acción se sitúa en 2154. Jake Sully, un marine veterano de guerra y herido en combate que ha quedado parapléjico, es seleccionado para participar en el programa Avatar..." });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID_M", "Director", "Duration", "Genre", "Name_P", "Photo", "Synopsis" },
                values: new object[] { 10, "Clay Kaytis", 97, "Animación", "Angry Birds", "angrybirds1.jpg", "La Isla Pájaro es una isla habitada por aves que no vuelan, una de ellas Red, un cardenal rojo que es sentenciado por el juez Peckinpah a asistir a sesiones de control de ira, tras perder su temperamento..." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}

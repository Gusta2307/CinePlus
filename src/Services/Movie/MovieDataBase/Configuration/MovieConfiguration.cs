using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDataBase.Configuration
{
    public class MovieConfiguration
    {
        public MovieConfiguration(EntityTypeBuilder<Movie> entityBuilder)
        {
            entityBuilder.HasKey(movie => movie.ID_M); //declarar el id de movie: ID_M
            entityBuilder.Property(movie => movie.Name_P).IsRequired().HasMaxLength(100);
            entityBuilder.Property(movie => movie.Genre).HasMaxLength(100);
            entityBuilder.Property(movie => movie.Director).HasMaxLength(100);
            entityBuilder.HasData(CreateDefaultMovies());
        }

        public List<Movie> CreateDefaultMovies()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie
                {
                    ID_M = 1,
                    Name_P = "Shrek I",
                    Synopsis = "Shrek es un ogro verde, gruñón y altamente territorial que ama la soledad...",
                    Genre = "Animación",
                    Director = "Vicky Jenson",
                    Duration = 90,
                    Photo = "shrek1.jpg"
                },
                new Movie
                {
                    ID_M = 2,
                    Name_P = "Shrek II",
                    Synopsis = "Tras su luna de miel después de derrotar a lord farquaad en la película anterior , el ogro Shrek y la princesa Fiona regresan a su pantano...",
                    Genre = "Animación",
                    Director = "Vicky Jenson",
                    Duration = 93,
                    Photo = "shrek2.jpg"
                },
                new Movie
                {
                    ID_M = 3,
                    Name_P = "The Fast and the Furious",
                    Synopsis = "El oficial de policía Brian O'Conner (Paul Walker) es enviado encubierto en una investigación conjunta de la policía de Los Ángeles y el FBI para detener a la banda que se dedica al robo de camiones con mercancía...",
                    Genre = "Accion",
                    Director = "Rob Cohen",
                    Duration = 107,
                    Photo = "fastfurious1.jpg"
                },
                new Movie
                {
                    ID_M = 4,
                    Name_P = "Abominable",
                    Synopsis = "Un joven Yeti escapa de un complejo en Shanghái propiedad del rico empresario Burnish (Eddie Izzard), que tiene la intención de usarlo para demostrar la existencia de yetis en el mundo...",
                    Genre = "Animación",
                    Director = "Jill Culton",
                    Duration = 97,
                    Photo = "abominable.jpg",
                },
                new Movie
                {
                    ID_M = 5,
                    Name_P = "Skyfall",
                    Synopsis = "",
                    Genre = "Acción",
                    Director = "Sam Mendes",
                    Duration = 143,
                    Photo ="skyfall.jpg"
                },
                new Movie
                {
                    ID_M = 6,
                    Name_P = "El Señor de los Anillos: El Retorno del Rey",
                    Synopsis = "La historia comienza con un recuerdo de cómo el hobbit Smeágol llegó a poseer el Anillo de Poder, tras matar a su amigo Déagol, quien lo había encontrado en el fondo de un río...",
                    Genre = "Aventuras",
                    Director = "Peter Jackson",
                    Duration = 201,
                    Photo = "senoranillos1.jpg"
                },
                new Movie
                {
                    ID_M = 7,
                    Name_P = "Zootopia",
                    Synopsis = "En un mundo poblado por animales antropomórficos en donde los humanos nunca existieron, Judy Hopps, una coneja de la ciudad rural de Bunnyburrow, sueña con convertirse en oficial de policía...",
                    Genre = "Animación",
                    Director = "Rich Moore",
                    Duration = 108,
                    Photo = "zootopia.jpg"
                },
                new Movie
                {
                    ID_M = 8,
                    Name_P ="Aquaman",
                    Synopsis = "En Maine, 1985, el guardián del faro Thomas Curry encuentra y rescata, durante una tormenta, seriamente herida a la princesa del reino submarino Atlantis, Atlanna y la lleva a su casa...",
                    Genre = "Acción, Aventura, Fantasía, Superhéroes",
                    Director = "James Wan",
                    Duration = 143,
                    Photo = "aquaman.jpg"
                },
                new Movie
                {
                    ID_M = 9,
                    Name_P = "Avatar",
                    Synopsis = "La acción se sitúa en 2154. Jake Sully, un marine veterano de guerra y herido en combate que ha quedado parapléjico, es seleccionado para participar en el programa Avatar...",
                    Genre = "Ciencia ficción",
                    Director = "James Cameron",
                    Duration = 162,
                    Photo = "avatar1.jpg"
                },
                new Movie
                {
                    ID_M = 10,
                    Name_P = "Angry Birds",
                    Synopsis = "La Isla Pájaro es una isla habitada por aves que no vuelan, una de ellas Red, un cardenal rojo que es sentenciado por el juez Peckinpah a asistir a sesiones de control de ira, tras perder su temperamento...",
                    Genre = "Animación",
                    Director = "Clay Kaytis",
                    Duration = 97,
                    Photo = "angrybirds1.jpg"
                },
            };

            return movies;
        }
    }
}

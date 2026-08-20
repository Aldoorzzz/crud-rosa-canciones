using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace crud_rosa_canciones.clases
{
    public class cancion
    {
        public int Id { get; set; }
        public char Titulo { get; set; }
        public char Artista { get; set; }
        public int Año { get; set; }



        public cancion(int id, char titulo, char artista, int año)
        {
            Id = id;
            Titulo = titulo;
            Artista = artista;
            Año = año;
        }
    
}
}

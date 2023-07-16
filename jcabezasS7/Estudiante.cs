using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace jcabezasS7
{
    public class Estudiante
    {
        [PrimaryKey, AutoIncrement] //defino mi primer atributo de la tabla
        public int Id { get; set; } // defino el nommbre y tipo de atributo

        [MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(50)]
        public string Usuario { get; set;}

        [MaxLength(50)]
        public string Contrasena { get; set;}

    }
}

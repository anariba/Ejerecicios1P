using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ejercicios1Parcial
{
        public    class Contact2
    {
        [PrimaryKey,AutoIncrement]
        public int codigo { get; set; }
        [MaxLength(100)]
        public String Nombre { get; set; }

        [MaxLength(100)]
        public String Apellido { get; set; }

        public Int32 Edad { get; set; }


        [MaxLength(100)]
        public String Correo { get; set; }


        [MaxLength(100)]
        public String Direccion { get; set; }

    }
}

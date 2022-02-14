using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ApiUsuario.Models.Renponse
{
    public class Respuesta<T>
    {
        public int Exito { get; set; }
        public string Mensaje { get; set; }
        public T Data { get; set; }

        public Respuesta()
        {
            this.Exito = 0;

        }

    }



}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace WebApplication33.Models
{
    [Serializable] // <-- eso es una anotacion
    public class Pais 
    {
        public int IdPais { set; get;}
        public string Nombre { set; get;}

        public int Poblacion { set; get;}


        // boton derecho quick action constructor

        public Pais()
        {
        }

        public Pais(int idPais, string nombre, int poblacion)
        {
            IdPais = idPais;
            Nombre = nombre;
            Poblacion = poblacion;
        }

        




    }
}
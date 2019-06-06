using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using WebApplication33.Models;

namespace WebApplication33.servicio
{
    public class PaisServicio
    {
        public static Pais Factory(TextBox txtId,
            TextBox txtNombre,TextBox txtPoblacion)
        {
            var obj=new Pais();
            obj.IdPais=Convert.ToInt32(txtId.Text); // otra vez: falta Convert
            obj.Nombre=txtNombre.Text;
            obj.Poblacion= Convert.ToInt32(txtPoblacion.Text); // otra vez: falta Convert
            
            return obj;
        }
    }
}
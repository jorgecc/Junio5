using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication33.Models;
using WebApplication33.servicio;

namespace WebApplication33
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        List<Pais> paises = new List<Pais>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack==false)
            {
                // cuando se carga la primera vez
                paises = new List<Pais>(); // parto la lista vacia
           
                GridView1.DataSource=paises;
                GridView1.DataBind();

                ViewState.Add("key",paises);
                // Session = guardamos valores de la sesion
                // Request = obtenemos informacion que el usuario envio
                // Response = enviamos informacion al usuario
                // Application = obtenemos informacion de la aplicacion
                // ViewState = leemos o guardamos estados (alternativa a sesiones)
                // IsPostBack = devuelve =true si el formulario se esta enviando a si mismo

            } else
            {
                paises =(List<Pais>) ViewState["key"];
            }

        } // fin funcion page_load

        protected void Button1_Click(object sender, EventArgs e)
        {
            // 1) crear un objeto pais
            Pais miPais=PaisServicio.Factory(TextBox1
                ,TextBox2,TextBox3);
            // 2) agregar ese objeto a la lista
            
            paises.Add(miPais);
            // 3) asignar la lista a la grilla
            GridView1.DataSource=paises;
            GridView1.DataBind(); // <-- es necesario para dibujar

        }
    }
}
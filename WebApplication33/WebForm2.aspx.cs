using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication33.Models;

namespace WebApplication33
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Pais> listado=new List<Pais>();
            listado.Add(new Pais(1,"Chile",33));
            listado.Add(new Pais(2, "Argentina", 44));
            listado.Add(new Pais(3, "Peru", 55));

            GridView1.DataSource=listado;
            GridView1.DataBind(); // <-- para que la grilla dibuje los datos

            // luego, en la grilla, cambiar la propiedad CSSCLASS por una 
            // de bootstrap (ir a la pagina de bootstrap y buscar por TABLE)

        }
    }
}
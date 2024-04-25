using Examen02.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen02.Pages
{
    public partial class ListaPersonas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                using (PV_Examen02Entities db = new PV_Examen02Entities())
                {
                    var Lista = db.spConsultarTodasLasPersonas().Select(p => new
                    {
                        idPersona = p.idPersona,
                        nombreProvincia = p.nombreProvincia,
                        nombreCompleto = p.nombreCompleto,
                        telefono = p.telefono,
                        fechaNacimiento = p.fechaNacimiento.ToString("dd/MM/yyyy"),
                        salario = p.salario,
                        edad = DateTime.Now.Year - p.fechaNacimiento.Year,
                        generacion = ObtenerGeneracion(p.fechaNacimiento.Year)
                    });

                    GvListarPersonas.DataSource = Lista;
                    GvListarPersonas.DataBind();
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/Error.aspx");
            }
        }

        // Método para calcular la generación según la fecha de nacimiento
        public string ObtenerGeneracion(int year)
        {

            if (year >= 1994 && year <= 2010)
                return "Generación Z";
            else if (year >= 1981 && year <= 1993)
                return "Generación Y";
            else if (year >= 1969 && year <= 1980)
                return "Generación X";
            else if (year >= 1949 && year <= 1968)
                return "Generación Baby Boomers";
            else if (year >= 1930 && year <= 1948)
                return "Generación Silenciosa";
            else
                return "N/D";
        }
    }
}
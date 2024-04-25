using Examen02.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen02.Pages
{
    public partial class CrearPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LlenarListaProvincias();
            }
        }

        private void LlenarListaProvincias()
        {
            try
            {
                var ListaProvincias = new List<ListItem>();

                using (PV_Examen02Entities db = new PV_Examen02Entities())
                {
                    var query = (from lr in db.spConsultarTodasLasProvincias()
                                 select new ListItem
                                 {
                                     Value = lr.idProvincia.ToString(),
                                     Text = lr.nombre
                                 }
                                 ).ToList();
                    ListaProvincias.AddRange(query);

                    DdlProvincias.DataTextField = "Text";
                    DdlProvincias.DataValueField = "Value";

                    DdlProvincias.DataSource = ListaProvincias;
                    DdlProvincias.DataBind();

                    DdlProvincias.ClearSelection();
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/Error.aspx");
            }
        }
        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int idProvincia = Convert.ToInt32(DdlProvincias.SelectedItem.Value);
                string nombreCompleto = TxtNombreCompleto.Text.Trim();
                string telefono = TxtTelefono.Text.Trim();
                DateTime fechaNacimiento = DateTime.Parse(TxtFechaNacimiento.Text.Trim());
                int salario = Convert.ToInt32(TxtSalario.Text.Trim());

                try
                {
                    using (PV_Examen02Entities db = new PV_Examen02Entities())
                    {
                        db.spCrearPersona(idProvincia, nombreCompleto, telefono, fechaNacimiento, salario);
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("~/Pages/Error.aspx");
                }

                Response.Redirect("~/Pages/MensajeRegistrar.aspx");
            }
            else
            {
                Response.Redirect("~/Pages/Error.aspx");
            }
        }
    }
}
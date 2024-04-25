using Examen02.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen02.Pages
{
    public partial class EditarPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                LlenarListaProvincias();

                CargarInformacionDePersona();

            }
        }
        private void CargarInformacionDePersona()
        {
            int idPersona = Convert.ToInt32(Request.QueryString["id"]);
            TxtidPersona.Text = idPersona.ToString();

            try
            {
                using (PV_Examen02Entities db = new PV_Examen02Entities())
                {
                    var datosPersona = db.spConsultarPersonaPorId(idPersona).FirstOrDefault();

                    if (datosPersona != null)
                    {
                        string idProvincias = datosPersona.idProvincia.ToString();
                        DdlProvincias.Items.FindByValue(idProvincias).Selected = true;

                        TxtNombreCompleto.Text = datosPersona.nombreCompleto;
                        TxtTelefono.Text = datosPersona.telefono;
                        TxtFechaNacimiento.Text = datosPersona.fechaNacimiento.ToString("yyyy/MM/dd");
                        TxtSalario.Text = datosPersona.salario.ToString("").Split('.')[0];
                    }
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
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
        protected void BtnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                int idPersona = Convert.ToInt32(TxtidPersona.Text.Trim());
                int idProvincia = Convert.ToInt32(DdlProvincias.SelectedItem.Value);
                string nombreCompleto = TxtNombreCompleto.Text.Trim();
                string telefono = TxtTelefono.Text.Trim();
                DateTime fechaNacimiento = DateTime.Parse(TxtFechaNacimiento.Text.Trim());
                int salario = Convert.ToInt32(TxtSalario.Text.Trim());

                using (PV_Examen02Entities db = new PV_Examen02Entities())
                {
                    db.spEditarPersona(idPersona, idProvincia, nombreCompleto, telefono, fechaNacimiento, salario);
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/Error.aspx");
            }

            Response.Redirect("~/Pages/MensajeEditar.aspx");
        }


        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idPersona = Convert.ToInt32(TxtidPersona.Text.Trim());

                using (PV_Examen02Entities db = new PV_Examen02Entities())
                {
                    db.spEliminarPersona(idPersona);
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }

            Response.Redirect("MensajeEliminar.aspx");
        }
    }
}
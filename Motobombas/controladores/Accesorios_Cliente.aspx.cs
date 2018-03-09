using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

public partial class vistas_Accesorios_Cliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            validar_session sesion = new validar_session();
            Int32 valida = Int32.Parse(sesion.validar(Int32.Parse(Session["id_usuaro"].ToString())));
        }
        catch (Exception es)
        {
            Response.Redirect("login.aspx");
        }
        Response.Cache.SetNoStore();
    }
    protected void GV_accesorios_cliente_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "B_obtener_accesorios")
        {

            int index;


            index = int.Parse(e.CommandArgument.ToString());
            Session["id_producto"] = index;
            
            Response.Redirect("seleccionCarrito.aspx");

        }
        
    }
    protected void GV_accesorios_cliente_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
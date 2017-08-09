using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaOnline.Logica;
namespace SistemaOnline
{
    public partial class Contactanos : System.Web.UI.Page
    {
        MetodoCorreo cls_correo = new MetodoCorreo();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnenviar_Click(object sender, EventArgs e)
        {
            String Mensaje = "";
            Mensaje += "<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'><html xmlns='http://www.w3.org/1999/xhtml'><head><meta http-equiv='Content-Type' content='text/html; charset=UTF-8' /><title>Demystifying Email Design</title><meta name='viewport' content='width=device-width, initial-scale=1.0'/></head><body style='margin: 0; padding: 0;'><table align='center' border='1' cellpadding='0' cellspacing='0' width='600'><td align='center' bgcolor='#70bbd9' style='padding: 40px 0 30px 0;'><img src='http://www.soleofdiscretion.co.uk/wp-content/uploads/2014/03/buy-online-300x300.png' alt='Creating Email Magic' width='auto' height='auto' style='display: block;'/></td></tr><tr><td bgcolor='#ffffff' style='padding: 40px 30px 40px 30px;'><table border='1' cellpadding='0' cellspacing='0' width='100%'><tr><td><h2><center><strong>Datos del Cliente </strong></center></h2></td></tr><tr><td style='padding: 20px 0 30px 0;'><table border='0' cellpadding='0' cellspacing='0' width='100%'><tr><td width='40%' valign='top'>";
            Mensaje += "<strong>Nombres:</strong></td><td width='60%' valign='top'>" + txtnombrecompleto.Text;
            Mensaje += "</td></tr><tr><td width='40%' valign='top'><strong>Correo:</strong></td><td width='60%' valign='top'>" + txtcorreo.Text + "<br/>";
            Mensaje += "</td></tr><tr><td width='40%' valign='top'><strong>Teléfono:</strong></td><td width='60%' valign='top'>" + txtTelefono.Text + "<br/>";
            Mensaje += "</td></tr><tr><td width='40%' valign='top'><strong>Sexo::</strong></td><td width='60%' valign='top'>" + rbt_sexo.SelectedItem.ToString() + "<br/>";
            Mensaje += "</td></tr></table></td></tr><tr><td><table border='0' cellpadding='0' cellspacing='0' width='100%'><tr><td width='40%' valign='top' colspan='2'><strong>Mensaje:</strong></td></tr><tr><td width='260' valign='top'>" + txtmensaje.Text+ "</td></tr></table></td></tr></table></td></tr><tr><td bgcolor='#ee4c50' style='padding: 30px 30px 30px 30px;'><table border='0' cellpadding='0' cellspacing='0' width='100%'><tr><td width='75%'><p style='display:inline;'>&copy; 2017 Buy Online.</p></td><td align='right' width='25%'><table border='0' cellpadding='0' cellspacing='0'><tr><td><a href='http://www.twitter.com/'><img src='http://www.freeiconspng.com/uploads/twitter-icon-8.png' alt='Twitter' width='38' height='38' style='display: block;' border='0' /></a></td><td style='font-size: 0; line-height: 0;' width='20'>&nbsp;</td><td><a href='http://www.twitter.com/'><img src='http://www.freeiconspng.com/uploads/facebook-logo-3.png' alt='Facebook' width='38' height='38' style='display: block;' border='0' /></a></td></tr></table></td></tr></table></td></tr></table></body></html>";
            cls_correo.SendMail(Mensaje);
            pnl_mensajeFinal.Visible = true;
        }

        protected void lnk_productos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}
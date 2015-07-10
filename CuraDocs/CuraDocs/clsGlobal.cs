using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CuraDocs
{

   public class clsGlobal
    {
       public static string frmtext;
       public static string usuarioGlobal;
       public static string rolGlobal;
       public static string perfilUsuario;
       public static string admUsuario;
       public static string admNombreCompleto;
       public static int idPerfil;
       public static bool admTermino=false;
       public static string accion = string.Empty;
       public static bool notificaciones;
       public static string admCorreo = string.Empty;

       //Variable para indicar el tipo de accion a ejecutar cuando se invoca el Store Procedure spInsDelValUsuarioTipoTramite.
       public static int nAction;

       //Constante para el texto ubicado en el borde de la caja de mensaje informativo (MessageBox).
       public static string sTextoInformativoMarcoMessageBox = "CuraDocs - Información";
       //Constante para el texto ubicado en el borde de la caja de mensaje de error (MessageBox).
       public static string sTextoErrorMarcoMessageBox = "CuraDocs - Error";
            
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VeterinariaBE;
using VeterinariaDAL;

namespace VeterinariaBL
{
    public class AccesoBL
    {
        private static AccesoDAL obj = new AccesoDAL();

     

        public static iniciar_sesion_Result Login2(string correo,string contraseña)
        {
            return obj.Login2(correo,contraseña);
        }

        public static void RecuperarContraseña(string correo,string dni,string contraseña)
        {
            obj.RecuperarContraseña(correo, dni, contraseña);
        }
    }
}

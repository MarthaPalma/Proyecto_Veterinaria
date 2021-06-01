using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VeterinariaBE;

namespace VeterinariaDAL
{
    public class AccesoDAL
    {
        

        public iniciar_sesion_Result Login2(string correo,string contraseña)
        {
            var pass = Encrypt.GetSHA256(contraseña);
            iniciar_sesion_Result s = new iniciar_sesion_Result();
            using (var db = new BD_VETERINARIAEntities())
            {
                foreach (var ss in db.iniciar_sesion(correo,pass).ToList())
                {
                    s.idusuario = ss.idusuario;
                    s.nombre = ss.nombre;
                    s.apellido = ss.apellido;
                    s.direccion = ss.direccion;
                    s.telefono = ss.telefono;
                    s.dni = ss.dni;
                    s.correo = ss.correo;
                    s.contraseña = ss.contraseña;
                    s.idrol = ss.idrol;
                   

                }
            }
            return s;

        }

        public void RecuperarContraseña(string correo,string dni,string contraseña)
        {
            try
            {
                using (var db = new BD_VETERINARIAEntities())
                {
                    db.recuperar_contraseña(correo,dni,Encrypt.GetSHA256(contraseña));   
                }

            }
            catch (Exception e )
            {

                throw e;
            }

        }





    }
}

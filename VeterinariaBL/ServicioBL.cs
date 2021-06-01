using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VeterinariaDAL;
using VeterinariaBE;

namespace VeterinariaBL
{
    public class ServicioBL
    {
        private static ServicioDAL obj = new ServicioDAL();

        public static List<listar_servicio_Result> ListarServicio()
        {
            return obj.ListarServicio();
        }
        public static List<listar_servicio_por_id_Result> GetServicio(int id)
        {
            return obj.GetServicio(id);
        }
        public static listar_servicio_por_id_Result GetServicio2(int id)
        {
            return obj.GetServicio2(id);
        }
        public static void EliminarServicio(int id)
        {
            obj.EliminarServicio(id);
        }
        public static void InsertarServicio(string nombre, string descripcion, decimal precio, string foto)
        {
            obj.InsertarServicio(nombre, descripcion, precio, foto);
        }
        public static void ActualizarServicio(int idservicio, string nombre, string descripcion, decimal precio, string foto)
        {
            obj.ActualizarServicio(idservicio, nombre, descripcion, precio, foto);

        }
    }
}

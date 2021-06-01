using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VeterinariaBE;

namespace VeterinariaDAL
{
    public class ServicioDAL
    {
        public List<listar_servicio_Result> ListarServicio()
        {
            using (var db = new BD_VETERINARIAEntities())
            {
                return db.listar_servicio().ToList();
            }
        }

        public List<listar_servicio_por_id_Result> GetServicio(int id)
        {
            using (var db = new BD_VETERINARIAEntities())
            {
                return db.listar_servicio_por_id(id).ToList();
            }
        }

        public void EliminarServicio(int id)
        {
            try
            {
                using (var db = new BD_VETERINARIAEntities())
                {
                    db.eliminar_servicio(id);
                }

            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void InsertarServicio(string nombre, string descripcion, decimal precio, string foto)
        {
            try
            {
                using (var db = new BD_VETERINARIAEntities())
                {
                    db.insertar_servicio(nombre, descripcion, precio, foto);
                }

            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public void ActualizarServicio(int idservicio, string nombre, string descripcion, decimal precio, string foto)
        {
            try
            {
                using (var db = new BD_VETERINARIAEntities())
                {
                    db.actualizar_servicio(idservicio, nombre, descripcion, precio, foto);
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public listar_servicio_por_id_Result GetServicio2(int id)
        {
            listar_servicio_por_id_Result s = new listar_servicio_por_id_Result();
            using (var db = new BD_VETERINARIAEntities())
            {
                foreach (var se in db.listar_servicio_por_id(id).ToList())
                {
                    s.idservicio = se.idservicio;
                    s.nombre = se.nombre;
                    s.descripcion = se.descripcion;
                    s.precio = se.precio;
                    s.foto = se.foto;
                   

                }
            }
            return s;

        }

    }
}

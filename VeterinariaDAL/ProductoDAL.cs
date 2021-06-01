using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaBE;

namespace VeterinariaDAL
{
    public class ProductoDAL
    {
        public List<listar_proveedor_Result> ListarProveedor()
        {
            using (var db = new BD_VETERINARIAEntities())
            {
                return db.listar_proveedor().ToList();
            }
        }

        public List<listar_tipoproducto_Result> ListarTipoProducto()
        {
            using (var db = new BD_VETERINARIAEntities())
            {
                return db.listar_tipoproducto().ToList();
            }
        }

        public List<listar_producto_Result> ListarProducto()
        {
            using (var db = new BD_VETERINARIAEntities())
            {
                return db.listar_producto().ToList();
            }
        }
        public List<listar_producto_por_id_Result> GetProducto(int id)
        {
            using (var db = new BD_VETERINARIAEntities())
            {
                return db.listar_producto_por_id(id).ToList();
            }
        }

        public void EliminarProducto(int id)
        {
            try
            {
                using (var db = new BD_VETERINARIAEntities())
                {
                    db.eliminar_producto(id);
                }

            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public void InsertarProducto(string nombre , int idtipoproducto, string descripcion,int idproveedor,decimal precio,int stock,string foto)
        {
            try
            {
                using (var db = new BD_VETERINARIAEntities())
                {
                    db.insertar_producto(nombre,idtipoproducto,descripcion,idproveedor,precio,stock,foto);
                }
                    
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void ActualizarProducto(int idproducto, string nombre, int idtipoproducto, string descripcion, int idproveedor, decimal precio, int stock, string foto)
        {
            try
            {
                using (var db = new BD_VETERINARIAEntities())
                {
                    db.actualizar_producto(idproducto, nombre, idtipoproducto, descripcion, idproveedor, precio, stock, foto);
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public listar_producto_por_id_Result GetProducto2(int id)
        {
            listar_producto_por_id_Result p = new listar_producto_por_id_Result();
            using (var db = new BD_VETERINARIAEntities())
            {
                foreach (var pr in db.listar_producto_por_id(id).ToList())
                {
                    p.idproducto = pr.idproducto;
                    p.nombre = pr.nombre;
                    p.descripcion = pr.descripcion;
                    p.precio = pr.precio;
                    p.stock = pr.stock;
                    p.foto = pr.foto;
                    p.idtipoproducto = pr.idtipoproducto;
                    p.idproveedor = pr.idproveedor;

                }
            }
            return p;

        }




    }
}

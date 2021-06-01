using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VeterinariaDAL;
using VeterinariaBE;

namespace VeterinariaBL
{
    public class ProductoBL
    {
        private static ProductoDAL obj = new ProductoDAL();

        public static List<listar_proveedor_Result> ListarProveedor()
        {
            return obj.ListarProveedor();
        }

        public static List<listar_tipoproducto_Result> ListarTipoProducto()
        {
            return obj.ListarTipoProducto();
        }
        public static List<listar_producto_Result> ListarProducto()
        {
            return obj.ListarProducto();
        }
        public static List<listar_producto_por_id_Result> GetProducto(int id)
        {
            return obj.GetProducto(id);
        }
        public static listar_producto_por_id_Result GetProducto2(int id)
        {
            return obj.GetProducto2(id);
        }

        public static void EliminarProducto(int id)
        {
            obj.EliminarProducto(id);
        }
        public static void InsertarProducto(string nombre, int idtipoproducto, string descripcion, int idproveedor, decimal precio, int stock, string foto)
        {
            obj.InsertarProducto(nombre, idtipoproducto, descripcion, idproveedor, precio, stock, foto);
        }
        public static void ActualizarProducto(int idproducto, string nombre, int idtipoproducto, string descripcion, int idproveedor, decimal precio, int stock, string foto)
        {
            obj.ActualizarProducto(idproducto, nombre, idtipoproducto, descripcion, idproveedor, precio, stock, foto);

        }
    }
}

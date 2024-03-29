﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VeterinariaBE
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BD_VETERINARIAEntities : DbContext
    {
        public BD_VETERINARIAEntities()
            : base("name=BD_VETERINARIAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int actualizar_producto(Nullable<int> idproducto, string nombre, Nullable<int> idtipoproducto, string descripcion, Nullable<int> idproveedor, Nullable<decimal> precio, Nullable<int> stock, string foto)
        {
            var idproductoParameter = idproducto.HasValue ?
                new ObjectParameter("idproducto", idproducto) :
                new ObjectParameter("idproducto", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var idtipoproductoParameter = idtipoproducto.HasValue ?
                new ObjectParameter("idtipoproducto", idtipoproducto) :
                new ObjectParameter("idtipoproducto", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var idproveedorParameter = idproveedor.HasValue ?
                new ObjectParameter("idproveedor", idproveedor) :
                new ObjectParameter("idproveedor", typeof(int));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("precio", precio) :
                new ObjectParameter("precio", typeof(decimal));
    
            var stockParameter = stock.HasValue ?
                new ObjectParameter("stock", stock) :
                new ObjectParameter("stock", typeof(int));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("foto", foto) :
                new ObjectParameter("foto", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("actualizar_producto", idproductoParameter, nombreParameter, idtipoproductoParameter, descripcionParameter, idproveedorParameter, precioParameter, stockParameter, fotoParameter);
        }
    
        public virtual int actualizar_servicio(Nullable<int> idservicio, string nombre, string descripcion, Nullable<decimal> precio, string foto)
        {
            var idservicioParameter = idservicio.HasValue ?
                new ObjectParameter("idservicio", idservicio) :
                new ObjectParameter("idservicio", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("precio", precio) :
                new ObjectParameter("precio", typeof(decimal));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("foto", foto) :
                new ObjectParameter("foto", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("actualizar_servicio", idservicioParameter, nombreParameter, descripcionParameter, precioParameter, fotoParameter);
        }
    
        public virtual int eliminar_producto(Nullable<int> idproducto)
        {
            var idproductoParameter = idproducto.HasValue ?
                new ObjectParameter("idproducto", idproducto) :
                new ObjectParameter("idproducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("eliminar_producto", idproductoParameter);
        }
    
        public virtual int eliminar_servicio(Nullable<int> idservicio)
        {
            var idservicioParameter = idservicio.HasValue ?
                new ObjectParameter("idservicio", idservicio) :
                new ObjectParameter("idservicio", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("eliminar_servicio", idservicioParameter);
        }
    
        public virtual ObjectResult<iniciar_sesion_Result> iniciar_sesion(string correo, string contraseña)
        {
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var contraseñaParameter = contraseña != null ?
                new ObjectParameter("contraseña", contraseña) :
                new ObjectParameter("contraseña", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<iniciar_sesion_Result>("iniciar_sesion", correoParameter, contraseñaParameter);
        }
    
        public virtual int insertar_producto(string nombre, Nullable<int> idtipoproducto, string descripcion, Nullable<int> idproveedor, Nullable<decimal> precio, Nullable<int> stock, string foto)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var idtipoproductoParameter = idtipoproducto.HasValue ?
                new ObjectParameter("idtipoproducto", idtipoproducto) :
                new ObjectParameter("idtipoproducto", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var idproveedorParameter = idproveedor.HasValue ?
                new ObjectParameter("idproveedor", idproveedor) :
                new ObjectParameter("idproveedor", typeof(int));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("precio", precio) :
                new ObjectParameter("precio", typeof(decimal));
    
            var stockParameter = stock.HasValue ?
                new ObjectParameter("stock", stock) :
                new ObjectParameter("stock", typeof(int));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("foto", foto) :
                new ObjectParameter("foto", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertar_producto", nombreParameter, idtipoproductoParameter, descripcionParameter, idproveedorParameter, precioParameter, stockParameter, fotoParameter);
        }
    
        public virtual int insertar_servicio(string nombre, string descripcion, Nullable<decimal> precio, string foto)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("precio", precio) :
                new ObjectParameter("precio", typeof(decimal));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("foto", foto) :
                new ObjectParameter("foto", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertar_servicio", nombreParameter, descripcionParameter, precioParameter, fotoParameter);
        }
    
        public virtual ObjectResult<listar_producto_Result> listar_producto()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listar_producto_Result>("listar_producto");
        }
    
        public virtual ObjectResult<listar_producto_por_id_Result> listar_producto_por_id(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listar_producto_por_id_Result>("listar_producto_por_id", idParameter);
        }
    
        public virtual ObjectResult<listar_proveedor_Result> listar_proveedor()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listar_proveedor_Result>("listar_proveedor");
        }
    
        public virtual ObjectResult<listar_servicio_Result> listar_servicio()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listar_servicio_Result>("listar_servicio");
        }
    
        public virtual ObjectResult<listar_servicio_por_id_Result> listar_servicio_por_id(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listar_servicio_por_id_Result>("listar_servicio_por_id", idParameter);
        }
    
        public virtual ObjectResult<listar_tipoproducto_Result> listar_tipoproducto()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listar_tipoproducto_Result>("listar_tipoproducto");
        }
    
        public virtual int recuperar_contraseña(string correo, string dni, string contraseña)
        {
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var dniParameter = dni != null ?
                new ObjectParameter("dni", dni) :
                new ObjectParameter("dni", typeof(string));
    
            var contraseñaParameter = contraseña != null ?
                new ObjectParameter("contraseña", contraseña) :
                new ObjectParameter("contraseña", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("recuperar_contraseña", correoParameter, dniParameter, contraseñaParameter);
        }
    
        public virtual ObjectResult<listar_rol_Result> listar_rol()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listar_rol_Result>("listar_rol");
        }
    
        public virtual ObjectResult<listar_sexomascota_Result> listar_sexomascota()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listar_sexomascota_Result>("listar_sexomascota");
        }
    
        public virtual ObjectResult<listar_tipodocumento_Result> listar_tipodocumento()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listar_tipodocumento_Result>("listar_tipodocumento");
        }
    
        public virtual ObjectResult<listar_tipomascota_Result> listar_tipomascota()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listar_tipomascota_Result>("listar_tipomascota");
        }
    
        public virtual int registrar_mascota(Nullable<int> idtipomascota, string nombre, string raza, Nullable<int> idsexo, string edad, Nullable<int> idusuario)
        {
            var idtipomascotaParameter = idtipomascota.HasValue ?
                new ObjectParameter("idtipomascota", idtipomascota) :
                new ObjectParameter("idtipomascota", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var razaParameter = raza != null ?
                new ObjectParameter("raza", raza) :
                new ObjectParameter("raza", typeof(string));
    
            var idsexoParameter = idsexo.HasValue ?
                new ObjectParameter("idsexo", idsexo) :
                new ObjectParameter("idsexo", typeof(int));
    
            var edadParameter = edad != null ?
                new ObjectParameter("edad", edad) :
                new ObjectParameter("edad", typeof(string));
    
            var idusuarioParameter = idusuario.HasValue ?
                new ObjectParameter("idusuario", idusuario) :
                new ObjectParameter("idusuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("registrar_mascota", idtipomascotaParameter, nombreParameter, razaParameter, idsexoParameter, edadParameter, idusuarioParameter);
        }
    
        public virtual int registrar_usuario_cliente(string nombre, string apellido, string direccion, string telefono, Nullable<int> idtipodoc, string dni, string correo, string contraseña, ObjectParameter idusuario)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("apellido", apellido) :
                new ObjectParameter("apellido", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("direccion", direccion) :
                new ObjectParameter("direccion", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var idtipodocParameter = idtipodoc.HasValue ?
                new ObjectParameter("idtipodoc", idtipodoc) :
                new ObjectParameter("idtipodoc", typeof(int));
    
            var dniParameter = dni != null ?
                new ObjectParameter("dni", dni) :
                new ObjectParameter("dni", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var contraseñaParameter = contraseña != null ?
                new ObjectParameter("contraseña", contraseña) :
                new ObjectParameter("contraseña", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("registrar_usuario_cliente", nombreParameter, apellidoParameter, direccionParameter, telefonoParameter, idtipodocParameter, dniParameter, correoParameter, contraseñaParameter, idusuario);
        }
    }
}

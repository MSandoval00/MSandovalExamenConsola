﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MSandovalExamenConsolaEntities1 : DbContext
    {
        public MSandovalExamenConsolaEntities1()
            : base("name=MSandovalExamenConsolaEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Usuario> Usuarios { get; set; }
    
        public virtual ObjectResult<UsuarioGetAll_Result> UsuarioGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioGetAll_Result>("UsuarioGetAll");
        }
    
        public virtual ObjectResult<UsuarioGetById_Result> UsuarioGetById(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioGetById_Result>("UsuarioGetById", idUsuarioParameter);
        }
    
        public virtual int UsuarioAdd(string nombre, Nullable<double> altura, string genero)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var alturaParameter = altura.HasValue ?
                new ObjectParameter("Altura", altura) :
                new ObjectParameter("Altura", typeof(double));
    
            var generoParameter = genero != null ?
                new ObjectParameter("Genero", genero) :
                new ObjectParameter("Genero", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioAdd", nombreParameter, alturaParameter, generoParameter);
        }
    
        public virtual int UsuarioDelete(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioDelete", idUsuarioParameter);
        }
    
        public virtual int UsuarioUpdate(Nullable<int> idUsuario, string nombre, Nullable<double> altura, string genero)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var alturaParameter = altura.HasValue ?
                new ObjectParameter("Altura", altura) :
                new ObjectParameter("Altura", typeof(double));
    
            var generoParameter = genero != null ?
                new ObjectParameter("Genero", genero) :
                new ObjectParameter("Genero", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioUpdate", idUsuarioParameter, nombreParameter, alturaParameter, generoParameter);
        }
    }
}

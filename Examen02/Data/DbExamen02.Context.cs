﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examen02.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PV_Examen02Entities : DbContext
    {
        public PV_Examen02Entities()
            : base("name=PV_Examen02Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<spConsultarPersonaPorId_Result> spConsultarPersonaPorId(Nullable<int> idPersona)
        {
            var idPersonaParameter = idPersona.HasValue ?
                new ObjectParameter("idPersona", idPersona) :
                new ObjectParameter("idPersona", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spConsultarPersonaPorId_Result>("spConsultarPersonaPorId", idPersonaParameter);
        }
    
        public virtual ObjectResult<spConsultarTodasLasPersonas_Result> spConsultarTodasLasPersonas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spConsultarTodasLasPersonas_Result>("spConsultarTodasLasPersonas");
        }
    
        public virtual ObjectResult<spConsultarTodasLasProvincias_Result> spConsultarTodasLasProvincias()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spConsultarTodasLasProvincias_Result>("spConsultarTodasLasProvincias");
        }
    
        public virtual int spCrearPersona(Nullable<int> idProvincia, string nombreCompleto, string telefono, Nullable<System.DateTime> fechaNacimiento, Nullable<decimal> salario)
        {
            var idProvinciaParameter = idProvincia.HasValue ?
                new ObjectParameter("idProvincia", idProvincia) :
                new ObjectParameter("idProvincia", typeof(int));
    
            var nombreCompletoParameter = nombreCompleto != null ?
                new ObjectParameter("nombreCompleto", nombreCompleto) :
                new ObjectParameter("nombreCompleto", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("fechaNacimiento", fechaNacimiento) :
                new ObjectParameter("fechaNacimiento", typeof(System.DateTime));
    
            var salarioParameter = salario.HasValue ?
                new ObjectParameter("salario", salario) :
                new ObjectParameter("salario", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCrearPersona", idProvinciaParameter, nombreCompletoParameter, telefonoParameter, fechaNacimientoParameter, salarioParameter);
        }
    
        public virtual int spEditarPersona(Nullable<int> idPersona, Nullable<int> idProvincia, string nombreCompleto, string telefono, Nullable<System.DateTime> fechaNacimiento, Nullable<decimal> salario)
        {
            var idPersonaParameter = idPersona.HasValue ?
                new ObjectParameter("idPersona", idPersona) :
                new ObjectParameter("idPersona", typeof(int));
    
            var idProvinciaParameter = idProvincia.HasValue ?
                new ObjectParameter("idProvincia", idProvincia) :
                new ObjectParameter("idProvincia", typeof(int));
    
            var nombreCompletoParameter = nombreCompleto != null ?
                new ObjectParameter("nombreCompleto", nombreCompleto) :
                new ObjectParameter("nombreCompleto", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("fechaNacimiento", fechaNacimiento) :
                new ObjectParameter("fechaNacimiento", typeof(System.DateTime));
    
            var salarioParameter = salario.HasValue ?
                new ObjectParameter("salario", salario) :
                new ObjectParameter("salario", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEditarPersona", idPersonaParameter, idProvinciaParameter, nombreCompletoParameter, telefonoParameter, fechaNacimientoParameter, salarioParameter);
        }
    
        public virtual int spEliminarPersona(Nullable<int> idPersona)
        {
            var idPersonaParameter = idPersona.HasValue ?
                new ObjectParameter("idPersona", idPersona) :
                new ObjectParameter("idPersona", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEliminarPersona", idPersonaParameter);
        }
    }
}
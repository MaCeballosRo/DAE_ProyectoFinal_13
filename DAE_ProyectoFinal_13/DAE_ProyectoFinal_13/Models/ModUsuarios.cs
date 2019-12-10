using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAE_ProyectoFinal_13.Models
{

    public class cat_institutos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdInstituto { get; set; }//PK
        [StringLength(50)]
        public string DesInstituto { get; set; }
        [StringLength(20)]
        public string Alias { get; set; }
        [StringLength(1)]
        public string Matriz { get; set; }
        //public Nullable<Int16> IdInstitutoPadre { get; set; }//FK
        //public cat_institutos cat_institutos_padre { get; set; }
        public Nullable<Int16> IdTipoGenGiro { get; set; }
        //public cat_tipos_generales cat_tipos_generales { get; set; }
        public Nullable<Int16> IdGenGiro { get; set; }
        //public cat_generales cat_generales { get; set; }
        public Nullable<DateTime> FechaReg { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
        public Nullable<DateTime> FechaUltMod { get; set; }
        [StringLength(20)]
        public string UsuarioMod { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }
    }//Ok

    public class rh_cat_dir_web
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdDirWeb { get; set; }//PK
        [StringLength(50)]
        public string DesDirWeb { get; set; }
        [StringLength(255)]
        public string DireccionWeb { get; set; }
        [StringLength(1)]
        public string Principal { get; set; }
        public Nullable<Int16> IdTipoGenDirWeb { get; set; }//FK
        //public cat_tipos_generales cat_tipos_generales { get; set; }
        public Nullable<Int16> IdGenDirWeb { get; set; }//FK
        //public cat_generales cat_generales { get; set; }
        [StringLength(50)]
        public string ClaveReferencia { get; set; }
        [StringLength(50)]
        public string Referencia { get; set; }
        public Nullable<DateTime> FechaReg { get; set; }
        public Nullable<DateTime> FechaUltMod { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
        [StringLength(20)]
        public string UsuarioMod { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }
    }//Ok

    public class rh_cat_personas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPersona { get; set; }//PKD:\AppEvaWebSrv\AppEvaWebSrv\Models\Eva\FicModPersonas.cs
        public int IdInstituto { get; set; } //FK
        public cat_institutos cat_institutos { get; set; }
        [StringLength(20)]
        public string NumControl { get; set; }
        [StringLength(100)]
        public string Nombre { get; set; }
        [StringLength(60)]
        public string ApPaterno { get; set; }
        [StringLength(60)]
        public string ApMaterno { get; set; }
        [StringLength(15)]
        public string RFC { get; set; }
        [StringLength(25)]
        public string CURP { get; set; }
        public Nullable<DateTime> FechaNac { get; set; }
        [StringLength(1)]
        public string TipoPersona { get; set; }
        [StringLength(1)]
        public string Sexo { get; set; }
        [StringLength(255)]
        public string RutaFoto { get; set; }
        [StringLength(20)]
        public string Alias { get; set; }
        public Nullable<Int16> IdTipoGenOcupacion { get; set; }//FK
        public Nullable<Int16> IdGenOcupacion { get; set; }//FK
        public Nullable<Int16> IdTipoGenEstadoCivil { get; set; }//FK
        public Nullable<Int16> IdGenEstadoCivil { get; set; }//FK
        //public cat_tipos_generales cat_tipos_generales { get; set; }
        //public cat_generales cat_generales { get; set; }
        public Nullable<DateTime> FechaReg { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
        public Nullable<DateTime> FechaUltMod { get; set; }
        [StringLength(20)]
        public string UsuarioMod { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }
    }//Ok

    public class rh_cat_telefonos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTelefono { get; set; } //PK
        [StringLength(2)]
        public string CodPais { get; set; }
        [StringLength(20)]
        public string NumTelefono { get; set; }
        [StringLength(30)]
        public string NumExtension { get; set; }
        [StringLength(1)]
        public string Principal { get; set; }
        public Nullable<Int16> IdTipoGenTelefono { get; set; }//FK
        //public cat_tipos_generales cat_tipos_generales { get; set; }
        public Nullable<Int16> IdGenTelefono { get; set; }//FK
        //public cat_generales cat_generales { get; set; }
        [StringLength(50)]
        public string ClaveReferencia { get; set; }
        [StringLength(50)]
        public string Referencia { get; set; }
        public Nullable<DateTime> FechaReg { get; set; }
        public Nullable<DateTime> FechaUltMod { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
        [StringLength(20)]
        public string UsuarioMod { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }
    }//Ok

    public class cat_usuarios
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdUsuario { get; set; }//PK
        public int IdPersona { get; set; }//FK
        public rh_cat_personas rh_cat_personas { get; set; }
        [StringLength(20)]
        public string Usuario { get; set; }
        [StringLength(1)]
        public string Expira { get; set; }
        [StringLength(1)]
        public string Conectado { get; set; }
        public Nullable<DateTime> FechaAlta { get; set; }
        public int NumIntentos { get; set; }
        public Nullable<DateTime> FechaReg { get; set; }
        public Nullable<DateTime> FechaUltMod { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
        [StringLength(20)]
        public string UsuarioMod { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }

    }//Ok

    public class seg_expira_claves
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdClave { get; set; }//PK
        public int IdUsuario { get; set; }//PK FK
        public cat_usuarios cat_usuarios { get; set; }
        public Nullable<DateTime> FechaExpiraIni { get; set; }
        public Nullable<DateTime> FechaExpiraFin { get; set; }
        [StringLength(1)]
        public string Actual { get; set; }
        [StringLength(20)]
        public string Clave { get; set; }
        [StringLength(1)]
        public string ClaveAutoSys { get; set; }
        public Nullable<DateTime> FechaReg { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }
    }//Ok

    public class seg_usuarios_estatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCrtlEstatus { get; set; }//PK
        public int IdUsuario { get; set; }//FK
        public Nullable<DateTime> FechaEstatus { get; set; }
        public Nullable<Int16> IdTipoEstatus { get; set; }//FK
        //public cat_tipos_estatus cat_tipos_estatus { get; set; }
        public Nullable<Int16> IdEstatus { get; set; }//FK
        //public cat_estatus cat_estatus { get; set; }
        [StringLength(1)]
        public string Actual { get; set; }
        [StringLength(500)]
        public string Observacion { get; set; }
        public Nullable<DateTime> FechaReg { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }
    }//Ok

    public class seg_cat_modulos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdModulo { get; set; }//PK
        [StringLength(100)]
        public string DesModulo { get; set; }
        public int Prioridad { get; set; }
        [StringLength(255)]
        public string RutaIcono { get; set; }
        [StringLength(10)]
        public string Version { get; set; }
        [StringLength(20)]
        public string Abreviatura { get; set; }
        public string UsuarioReg { get; set; }
        public Nullable<DateTime> FechaReg { get; set; }
        [StringLength(20)]
        public string UsuarioMod { get; set; }
        public Nullable<DateTime> FechaUltMod { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }
    }//Ok

    public class seg_versiones_sys
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdModulo { get; set; }//PK FK
        public seg_cat_modulos seg_cat_modulos { get; set; }
        [StringLength(20)]
        public string VersionActual { get; set; }
        [StringLength(20)]
        public string VersionInstalado { get; set; }
        [StringLength(1)]
        public string Estatus { get; set; }
        public Nullable<DateTime> FechaReg { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
        [StringLength(20)]
        public Nullable<DateTime> FechaUltMod { get; set; }
        [StringLength(20)]
        public string UsuarioMod { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }
    }

    //-------
    public class cat_datosUsuario
    {
        public int IdPersona { get; set; }
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        //public string ApPaterno { get; set; }
        //public string ApMaterno { get; set; }
        public Nullable<DateTime> FechaNac { get; set; }
        public string DireccionWeb { get; set; }
        public string Telefono { get; set; }
        public string DesInstituto { get; set; }
        //public string NumTelefono { get; set; }
    }

    public class cat_datosApp
    {
        public int IdModulo { get; set; }
        public string DesModulo { get; set; }
        public string RutaIcono { get; set; }
        public string VersionActual { get; set; }
        public string VersionInstalado { get; set; }
        public string Estatus { get; set; }
        public string UsuarioReg { get; set; }
    }
}

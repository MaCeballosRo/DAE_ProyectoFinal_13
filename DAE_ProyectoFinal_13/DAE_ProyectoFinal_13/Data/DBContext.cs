using System;
using System.Collections.Generic;
using System.Text;
using DAE_ProyectoFinal_13.Models;
using Xamarin.Forms;
using Microsoft.EntityFrameworkCore;

namespace DAE_ProyectoFinal_13.Data
{
    public class DataBaseContext : DbContext
    {
        private readonly string LoDataBasePath;

        public DbSet<cat_institutos> cat_institutos { get; set; }
        public DbSet<rh_cat_personas> rh_cat_personas { get; set; }
        public DbSet<rh_cat_telefonos> rh_cat_telefonos { get; set; }
        public DbSet<cat_usuarios> cat_usuarios { get; set; }
        public DbSet<rh_cat_dir_web> rh_cat_dir_web { get; set; }
        public DbSet<seg_usuarios_estatus> seg_usuarios_estatus { get; set; }
        public DbSet<seg_expira_claves> seg_expira_claves { get; set; }
        public DbSet<seg_cat_modulos> seg_cat_modulos { get; set; }
        public DbSet<seg_versiones_sys> seg_versiones_sys { get; set; }


        public DataBaseContext(string PaDataBasePath)
        {
            LoDataBasePath = PaDataBasePath;
            //Se manda a llamar el método que crea la BD localmente en la plataforma.
            MetCreateDataBase();
        }//constructor

        private async void MetCreateDataBase()
        {
            try
            {
                await Database.EnsureCreatedAsync();
            }
            catch (Exception e)
            {
                await new Page().DisplayAlert("Alerta", e.Message.ToString(), "OK");
            }
        }

        protected async override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            try
            {
                OptionsBuilder.UseSqlite($"Filename={LoDataBasePath}");
                OptionsBuilder.EnableSensitiveDataLogging();
            }
            catch (Exception e)
            {
                await new Page().DisplayAlert("Alerta", e.Message.ToString(), "OK");
            }
        }//Configuracion de la conexión

        protected async override void OnModelCreating(ModelBuilder modelBuilder)
        {
            try
            {
                #region Usuario
                //CAT_INSTITUTOS ------------------------
                modelBuilder.Entity<cat_institutos>()
                    .HasKey(c => new { c.IdInstituto });

                //RH_CAT_DIR_WEB ---------------------------
                modelBuilder.Entity<rh_cat_dir_web>()
                    .HasKey(c => new { c.IdDirWeb });
                

                //RH_CAT_PERSONAS ---------------------------
                modelBuilder.Entity<rh_cat_personas>()
                    .HasKey(c => new { c.IdPersona });

                modelBuilder.Entity<rh_cat_personas>()
                .HasOne(s => s.cat_institutos).
                WithMany().HasForeignKey(s => new { s.IdInstituto });

                //RH_CAT_TELEFONOS
                modelBuilder.Entity<rh_cat_telefonos>()
                    .HasKey(c => new { c.IdTelefono });        

                //CAT_USUARIOS
                modelBuilder.Entity<cat_usuarios>()
                    .HasKey(c => new { c.IdUsuario });

                modelBuilder.Entity<cat_usuarios>()
                .HasOne(s => s.rh_cat_personas).
                WithMany().HasForeignKey(s => new { s.IdPersona });

                //SEG_EXPIRA_CLAVES
                modelBuilder.Entity<seg_expira_claves>()
                    .HasKey(c => new { c.IdClave, c.IdUsuario });

                modelBuilder.Entity<seg_expira_claves>()
                .HasOne(s => s.cat_usuarios).
                WithMany().HasForeignKey(s => new { s.IdUsuario });

                //SEG_USUARIOS_ESTATUS
                modelBuilder.Entity<seg_usuarios_estatus>()
                    .HasKey(c => new { c.IdCrtlEstatus });

                //SEG_CAT_MODULOS
                modelBuilder.Entity<seg_cat_modulos>()
                   .HasKey(c => new { c.IdModulo });

                //SEG_VERSIONES_SYS
                modelBuilder.Entity<seg_versiones_sys>()
                    .HasKey(c => new { c.IdModulo });

                modelBuilder.Entity<seg_versiones_sys>()
                    .HasOne(s => s.seg_cat_modulos).
                     WithMany().HasForeignKey(s => new { s.IdModulo });

                #endregion
            }
            catch (Exception e)
            {
                await new Page().DisplayAlert("Alerta", e.Message.ToString(), "OK");
            }
        }// Al crear el modelo
    }


}

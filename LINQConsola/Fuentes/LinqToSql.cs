using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Fuentes
{
    class LinqToSql
    {
        //AGREGAR
        public static void Agregar()
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LINQConsola.Properties.Settings.CursosVirtualesConnectionString"].ToString();

            var db = new LINQToSQLDataContext(connectionString);

            var newCurso = new Cursos
            {
                Nombre = "Nuevo curso",
                Idioma = "Jeringoso",
                Precio = 1.99,
                FechaRegistro = DateTime.UtcNow,
                FechaModificacion = DateTime.UtcNow,
                Estado = true
            };

            db.Cursos.InsertOnSubmit(newCurso);
            db.SubmitChanges();

            var reporte = (from c in db.Cursos
                          where c.Nombre.Equals("Nuevo curso")
                          select c).FirstOrDefault();

            Console.WriteLine(reporte.Nombre + " agregado.");
        }

        public static void Actualizar(int id)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LINQConsola.Properties.Settings.CursosVirtualesConnectionString"].ToString();

            var db = new LINQToSQLDataContext(connectionString);

            var curso = db.Cursos.FirstOrDefault(c => c.CursoId == id);

            curso.Nombre = "Actualizado";
            curso.Precio = 19.99;
            curso.FechaModificacion = DateTime.UtcNow;

            db.SubmitChanges();

            var reporte = db.Cursos.FirstOrDefault(c => c.CursoId == id);

            Console.WriteLine(reporte.Nombre);
        }

        public static void Eliminar(int id)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LINQConsola.Properties.Settings.CursosVirtualesConnectionString"].ToString();

            var db = new LINQToSQLDataContext(connectionString);

            var cursoAEliminar = db.Cursos.FirstOrDefault(c => c.CursoId == id);

            db.Cursos.DeleteOnSubmit(cursoAEliminar);
            db.SubmitChanges();

            var cursoEliminado = db.Cursos.FirstOrDefault(c => c.CursoId == id);

            if (cursoEliminado == null)
            {
                Console.WriteLine("Curso eliminado");
            }
            else
            {
                Console.WriteLine("Algo salió mal");
            }
        }
    }
}

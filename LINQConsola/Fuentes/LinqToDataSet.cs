using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Fuentes
{
    public class LinqToDataSet
    {
        public static void LinqWDataSets()
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LINQConsola.Properties.Settings.CursosVirtualesConnectionString"].ToString();

            var query = "SELECT * FROM Cursos";

            var adapter = new SqlDataAdapter(query, connectionString);

            adapter.TableMappings.Add("Table", "Cursos");

            var ds = new DataSet();

            adapter.Fill(ds);

            var cursos = ds.Tables["Cursos"];

            var q = from c in cursos.AsEnumerable()
                    select new
                    {
                        CursoId = c.Field<int>("CursoId"),
                        CursoNombre = c.Field<string>("Nombre")
                    };

            foreach (var c in q)
            {
                Console.WriteLine($"ID = {c.CursoId}, Nombre = {c.CursoNombre}");
            }
        }
    }
}

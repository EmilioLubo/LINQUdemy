using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQConsola.Fuentes
{
    public class LinqToXML
    {
        public static void LeerXML()
        {
            string ruta = "../../Archivos/Empleados.xml";

            var xml = XDocument.Load(ruta);

            var empleados = xml.Element("Empresa").Elements("Empleado");

            foreach (var e in empleados)
            {
                Console.WriteLine($"Nombre: {e.Element("Nombre").Value} {e.Element("Apellido").Value},\n" +
                    $"Teléfono: {e.Element("ContactNo").Value}\n" +
                    $"Email: {e.Element("Email").Value}\n" +
                    $"Dirección: {e.Element("Direccion").Element("Ciudad").Value}, {e.Element("Direccion").Element("Estado").Value}");

                Console.WriteLine(Environment.NewLine);
            }
        }

        public static void CrearXML()
        {
            using (var db = new CursosVirtualesEntities())
            {
                var cursos = db.Cursos.Take(10).ToList();

                var docXml = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("Documento creado a partir de la tabla \"Cursos\""),

                    new XElement("Cursos", from c in cursos
                                           select new XElement("Curso",
                                                    new XAttribute("Id", c.CursoId),
                                                    new XElement("NombreCurso", c.Nombre),
                                                    new XElement("Idioma", c.Idioma),
                                                    new XElement("Precio", c.Precio),
                                                    new XElement("FechaRegistro", c.FechaRegistro),
                                                    new XElement("FechaModificacion", c.FechaModificacion),
                                                    new XElement("Estado", c.Estado))
                                           )
                    );

                docXml.Save("../../Archivos/Cursos.xml");

                Console.WriteLine("Documento generado correctamente");
            }
        }

        public static void Agregar()
        {
            var xDoc = XDocument.Load("../../Archivos/Cursos.xml");

            //xDoc.Element("Cursos").Add(
            //    new XElement("Curso", new XAttribute("Id", 11),
            //        new XElement("NombreCurso", "Trabajando con Linq y Xml"),
            //        new XElement("Idioma", "español"),
            //        new XElement("Precio", 79.99),
            //        new XElement("FechaRegistro", DateTime.UtcNow),
            //        new XElement("FechaModificacion", DateTime.UtcNow),
            //        new XElement("Estado", true)
            //        )
            //    );

            //AGREGAR AL PRINCIPIO

            //xDoc.Element("Cursos").AddFirst(
            //    new XElement("Curso", new XAttribute("Id", 12),
            //        new XElement("NombreCurso", "Primer Curso"),
            //        new XElement("Idioma", "español"),
            //        new XElement("Precio", 99.99),
            //        new XElement("FechaRegistro", DateTime.UtcNow),
            //        new XElement("FechaModificacion", DateTime.UtcNow),
            //        new XElement("Estado", true)
            //        )
            //    );

            //AGREGAR ANTES DE UN ELEMENTO

            //xDoc.Element("Cursos").Elements("Curso").Where(c => c.Attribute("Id").Value == "1").FirstOrDefault().AddBeforeSelf(
            //    new XElement("Curso", new XAttribute("Id", 12),
            //        new XElement("NombreCurso", "Antes de"),
            //        new XElement("Idioma", "español"),
            //        new XElement("Precio", 99.99),
            //        new XElement("FechaRegistro", DateTime.UtcNow),
            //        new XElement("FechaModificacion", DateTime.UtcNow),
            //        new XElement("Estado", true)
            //        )
            //    );

            //AGREGAR DESPUES DE UN ELEMENTO

            xDoc.Element("Cursos").Elements("Curso").Where(c => c.Attribute("Id").Value == "1").FirstOrDefault().AddAfterSelf(
                new XElement("Curso", new XAttribute("Id", 12),
                        new XElement("NombreCurso", "Antes de"),
                        new XElement("Idioma", "español"),
                        new XElement("Precio", 99.99),
                        new XElement("FechaRegistro", DateTime.UtcNow),
                        new XElement("FechaModificacion", DateTime.UtcNow),
                        new XElement("Estado", true)
                        )
                );


            xDoc.Save("../../Archivos/Cursos.xml");

            Console.WriteLine("Nodo agregado correctamente.");
        }

        public static void Eliminar()
        {
            var xDoc = XDocument.Load("../../Archivos/Cursos.xml");

            xDoc.Root.Elements().Where(c => c.Attribute("Id").Value == "12").FirstOrDefault().Remove();

            xDoc.Save("../../Archivos/Cursos.xml");

            Console.WriteLine("Nodo eliminado correctamente.");
        }

        public static void Actualizar()
        {
            var xDoc = XDocument.Load("../../Archivos/Cursos.xml");

            xDoc.Element("Cursos").Elements("Curso")
                .Where(c => c.Attribute("Id").Value == "1")
                .FirstOrDefault()
                .SetElementValue("NombreCurso", "Nuevo nombre");

            xDoc.Save("../../Archivos/Cursos.xml");

            Console.WriteLine("Nodo actualizado");
        }
    }
}

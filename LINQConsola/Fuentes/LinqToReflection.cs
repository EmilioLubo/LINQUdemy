using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Fuentes
{
    public class LinqToReflection
    {
        private readonly Assembly Ensamblado;

        public LinqToReflection(string ensamblado)
        {
            Ensamblado = Assembly.Load(ensamblado);
        }

        public void GetInfo()
        {
            var constructores = from t in Ensamblado.GetTypes()
                                from c in t.GetConstructors()
                                group c.ToString()
                                by t.ToString();

            var metodos = from t in Ensamblado.GetTypes()
                          from m in t.GetMethods()
                          group m.ToString()
                          by t.ToString();

            foreach (var c in constructores)
            {
                Console.WriteLine(c.Key);

                foreach(var cr in c)
                {
                    Console.WriteLine($"\t{cr}");
                }

                var metodosIn = from m in metodos
                                where m.Key == c.Key
                                select m;
                foreach(var m in metodosIn)
                {
                    foreach(var t in m)
                    {
                        Console.WriteLine($"\t\t{t}");
                    }
                }

                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}

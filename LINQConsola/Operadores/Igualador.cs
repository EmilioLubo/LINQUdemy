using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Igualador
    {
        public void Igualar()
        {

            using (var db = new CursosVirtualesEntities())
            {
                //SEQUENCEEQUAL
                    
                var cont1 = db.Continentes.ToList();

                var cont2 = (from c in db.Continentes
                             where c.Nombre.Equals("Oceania")
                            select c).ToList();

                bool equals = cont1.SequenceEqual(cont2);

                Console.WriteLine($"Los continentes comparados " + (equals ? "" : "no ") + "son iguales");

            }
        }
    }
}

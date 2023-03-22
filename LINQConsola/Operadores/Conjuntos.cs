using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Conjuntos
    {
        public void Conjunto()
        {

            /*string[] dias = new string[] { "lunes", "martes", "sábado", "domingo", "martes", "miercoles", "sábado", "viernes", "lunes", "jueves" };*/

            //foreach (string d in dias)
            //{
            //    Console.WriteLine($"{d}, ");
            //}

            //DISTINCT
            //IEnumerable<string> diasDistinct = from dia 
            //                                   in dias.Distinct() 
            //                                   select dia;
            //foreach (string d in diasDistinct)
            //{
            //    Console.WriteLine($"{d}, ");
            //}

            //EXCEPT

            string[] meses1 = new string[] { "Enero", "Marzo", "Abril", "Febrero", "Mayo", "Agosto", "Junio" };
            string[] meses2 = new string[] { "Marzo", "Febrero", "Abril", "Mayo", "Abril", "Agosto", "Diciembre" };

            //IEnumerable<string> meses = from m in meses1.Except(meses2)
            //                            select m;

            //foreach (string m in meses)
            //{
            //    Console.WriteLine($"{m}, ");
            //}

            //var mesesQuery = from m in meses2.Except(meses1) 
            //                 select m;
            //foreach (string m in mesesQuery)
            //{
            //    Console.WriteLine($"{m}, ");
            //}

            //INTERSECT

            //var meses = from m in meses1.Intersect(meses2)
            //            select m;
            //foreach ( var m in meses) 
            //{
            //    Console.WriteLine($"{m}, ");
            //}

            //UNION

            //var meses = from m in meses1.Union(meses2)
            //            select m;
            //foreach (var m in meses)
            //{
            //    Console.WriteLine(m);
            //}
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto cariñosa = new Moto("Honda", 400);
            Console.WriteLine(cariñosa.NotificarEstado());
            cariñosa.Montar();
            Console.WriteLine(cariñosa.NotificarEstado());
            Console.ReadKey();
        }
    }
}

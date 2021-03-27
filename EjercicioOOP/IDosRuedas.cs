using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioOOP
{
    public interface IDosRuedas
    {
        void Montar();
        void Bajar();
        void Equilibrar();
        string NotificarEstado();
        int numeroPasajeros();
        
    }
}

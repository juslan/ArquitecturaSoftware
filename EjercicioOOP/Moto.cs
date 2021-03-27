using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioOOP
{
    public class Moto : Motorizado, IDosRuedas
    {
        private string _estadoMotor;
        public int año { get; set; }
        public string marca { get; set; }
        public bool equilibrado { get; set; }
        public bool montado { get; set; }


        public Moto(string m,int ci)
        {
            _estadoMotor = "Apagado";
            año = 2016;
            marca = m;
            cilindrada = ci;
            
        }
        public void Equilibrar()
        {
            equilibrado = true;
        }

        public void Montar()
        {
            montado = true;
            Equilibrar();
            Encender();
            _estadoMotor = "Encendido ";
        }


        public int numeroPasajeros()
        {
            return 2;
        }

        public string NotificarEstado()
        {
            return $"{Estado()} {_estadoMotor} soy del año {año} mi cilindrada es {cilindrada} cc y mi fabricante es {marca}";
        }

        public void Bajar()
        {
            Apagar();
            _estadoMotor = "Apagado";        }
    }
}

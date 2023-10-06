using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public  class Auto:Transporte
    {
        #region Atributos

        public int cantidadRuedas;

        #endregion

        #region Propiedades

        public override string TiempoUso
        {
            get
            {
                return "Se usa desde el siglo XIX (1886)";
            }
        }

        #endregion

        #region Constructor

        public Auto(byte pasajeros, Velocidades velocidad, int ruedas):base(pasajeros,velocidad)
        {
            this.cantidadRuedas = ruedas;
        }

        #endregion

        #region Métodos
        public override void Avanzar()// se considera virtual y el hijo puede sobreescribir el metodo
        {
            base.Avanzar();//base es la clase padre
            //sin la base se sobreescribe completamente
            Console.WriteLine("El auto avanza a {0}", this._velocidadMaxima);
        }

        public override void Frenar()
        {
            Console.WriteLine("reduzco velocidad pisando el freno...");
        }

        #endregion

    

        public override string ToString()
        {
            System.Text.StringBuilder sb = new StringBuilder();

            //INVOCO AL TOSTRING() DE LA CLASE BASE
            sb.AppendLine(base.ToString());//especializamos

            sb.AppendLine("En la clase Auto...");
            sb.Append("Cantidad de ruedas: ");
            sb.AppendLine(this.cantidadRuedas.ToString());

            return sb.ToString();
        }

        public void TocarBocina()
        {
            Console.WriteLine("PIIIIPIPIIII");
        }
 
    }
}


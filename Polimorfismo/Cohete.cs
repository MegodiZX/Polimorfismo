using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Cohete:Transporte
    {
        #region Atributos

        public string modelo;
        public int cantidadVentanas;

        #endregion

        

        #region Constructor

        public Cohete(byte pasajeros, Velocidades velocidad, int cantidadVentanas, string modelo):base(pasajeros,velocidad)
        {
            this.cantidadVentanas = cantidadVentanas;
            this.modelo = modelo;
        }

        #endregion

        #region Métodos
        public override void Avanzar()
        {
            Console.WriteLine("El auto avanza a {0}", this._velocidadMaxima);
        }

        public override void Frenar()
        {
            Console.WriteLine("El cohete disminuye la fuerza de los propulsores");
        }

        public override string TiempoUso
        {
            get
            {
                return "Desde 1961 hasta el infinito y mas alla";
            }
        }

        #endregion



        public override string ToString()
        {
            System.Text.StringBuilder sb = new StringBuilder();

          
            sb.AppendLine("En la clase Cohete...");

            sb.Append("Cantidad de ventanas: ");
            sb.AppendLine(this.cantidadVentanas.ToString());
            sb.Append("Modelo: ");
            sb.AppendLine(this.modelo);

            return sb.ToString();
        }

  
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public abstract class Transporte
    {
        #region Atributos

        protected byte _cantidadPasajeros;
        protected Velocidades _velocidadMaxima;

        #endregion

        public abstract string TiempoUso
        {
            get;
        }



        #region Constructor

        public Transporte(byte pasajeros, Velocidades velocidadMaxima)
        {
            this._cantidadPasajeros = pasajeros;
            this._velocidadMaxima = velocidadMaxima;
        }

        #endregion

        #region Métodos 
        public virtual void Avanzar()
        {
            Console.WriteLine("Estoy avanzando");
        }

        public abstract void Frenar();
        //un metodo abstracto implica que no tiene utilizacion. Tiene que estar si o si en una clase abstracta




        #endregion

        #region Polimorfismo ToString

        public override string ToString()
        {
            System.Text.StringBuilder sb = new StringBuilder();

            sb.AppendLine("En la clase Transporte...");
            sb.Append("Cantidad de pasajeros: ");
            sb.AppendLine(this._cantidadPasajeros.ToString());
            sb.Append("Velocidad Máxima: ");
            sb.AppendLine(((Int32)this._velocidadMaxima).ToString());

            return sb.ToString();
        }


        #endregion
    }
}

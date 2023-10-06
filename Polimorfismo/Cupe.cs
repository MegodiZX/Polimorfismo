using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Cupe : Transporte
    {

        public Cupe():base(5,Velocidades.Media)
        {
            
        }

        public override void Avanzar()
        {
            Console.WriteLine("Aca Cupe avanza");
        }

        public override void Frenar()
        {
            throw new NotImplementedException();
        }

        public override string TiempoUso
        {
            get
            {
                return "Se usa desde ???";
            }
        }

    }
}

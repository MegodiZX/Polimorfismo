namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //para que haya polimorfismo se debera definir en metodo de la clase base como virtual
            Auto miAuto = new Auto(4, Velocidades.Media, 4);
            Caballo miCaballo = new Caballo("Equinus", 2, Velocidades.Minima, Colores.Pinto);
            Cohete miCohete = new Cohete(16, Velocidades.Hiper, 5, "2000 Space");
            Caballo miOtroCaballo = new Caballo("ico", 2, Velocidades.Minima, Colores.Negro);
            Cohete miOtroCohete = new Cohete(5, Velocidades.Hiper, 3, "Odisea Space");

            List<Transporte> lista = new List<Transporte>();

            lista.Add(miAuto);
            lista.Add(miCaballo);
            lista.Add(miCohete);
            lista.Add(miOtroCaballo);
            lista.Add(miOtroCohete);

            foreach (Transporte t in lista)
            {
                //Console.WriteLine(t.ToString());
                t.Avanzar();
            }

            foreach (Transporte t in lista)
            {
                if (t.GetType() == typeof(Caballo))
                {
                    t.Frenar();
                }

            }

            foreach (Transporte t in lista)
            {
                if (t.GetType() == typeof(Auto))
                {
                    ((Auto)t).TocarBocina();
                }

            }
        }
    }
}
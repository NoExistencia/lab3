namespace Semana3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJEMPLO DE INTERACCION CON ENUMERADO
            //Console.WriteLine("Ingrese el tipo de combustible");
            //Console.WriteLine("1- Nafta 2- Diesel 3- Eléctrico");
            //string resultado = Console.ReadLine();

            //Parseo para que quede asignado el valor en el Enum, pero acepta valores no definidos en el Enum
            //TipoCombustible tipoC = Enum.Parse<TipoCombustible>(resultado);

            //Chequeo que el valor esté definido en el Enum
            //if(!Enum.IsDefined(typeof(TipoCombustible), tipoC))
            //{
            //    Console.WriteLine("Ingrese un valor correcto");
            //}

            try
            {
                Auto a1 = new Auto("Fiat", "Premio", true, "AAA1234", 2010, TipoCombustible.Nafta);
                Console.WriteLine("auto dado de alta correctamente");
                Console.WriteLine($"La patente de {a1.Marca} es {a1.CalcularPatente()}");

                Auto a2 = new Auto("Chevrolet", "Corsa", false, "BBB2233", 2020, TipoCombustible.Diesel);

                //Delego al constructor de Auto
                //Auto a2 = new Auto("Chevrolet", new DateTime(2021, 01, 01));
                //a1.Validar();
                //a1.ValidarMatricula();
                //a1.ValidarMarca();
                //a1.ValidarModelo();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }
    }
}

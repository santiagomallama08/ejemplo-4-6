namespace ejercicio
{
    public class program
    {
        public static void Main()
        {
            double cantidad, cantidadaño = 0, ahorromes;
            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine("proceso" + i);
                Console.WriteLine("ingrese el valor a depositar ");
                cantidad = double.Parse(Console.ReadLine());
                cantidadaño = cantidadaño + cantidad;
                ahorromes = cantidadaño;
                Console.WriteLine($"el valor de cantidad de mes es de  {ahorromes}");
            }
            Console.WriteLine($"el ahorro de un año es de  {cantidadaño} ");
        }
    }
}
namespace Ejercicio4_5
{
    class program
    {
        static void Main()
        {
            double estatura = 0, suma = 0, total, promedio = 0;
            Console.WriteLine("Digite el total de personas: ");
            total = int.Parse(Console.ReadLine());
            for (int i = 1; i <= total; i++)
            {
                Console.WriteLine("Digite su estatura ({0}) : ", i);
                estatura = Convert.ToDouble(Console.ReadLine());

                suma = suma + estatura;
                i = i + 0;
                promedio = suma / total;
            }
            Console.WriteLine("El promedio de estatura de todo el grupo es: " + promedio);
        }
    }
}
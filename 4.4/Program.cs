namespace Ejercicio4_4
{
    class program
    {
        public static void Main(string[] args)
        {
            int edad = 0, suma = 0, total, promedio = 0;
            Console.WriteLine("Digite el total de alumnos: ");
            total = int.Parse(Console.ReadLine());
            for (int i = 1; i <= total; i++)
            {
                Console.WriteLine("Digite su edad ({0}) : ", i);
                edad = int.Parse(Console.ReadLine());

                suma = suma + edad;
                i = i + 0;
                promedio = suma / total;
            }
            Console.WriteLine("El promedio de edades de todo el grupo es: " + promedio);

        }
    }
}
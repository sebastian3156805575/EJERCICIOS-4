namespace Ejercicio4_1
{
    class program
    {
        static void Main()
        {
            int i = 1;
            int total = 0;
            while (i <= 10)
            {
                Console.WriteLine("Digite un numero ({0})", i);
                int cantidad = Convert.ToInt32(Console.ReadLine());

                total = total + cantidad;
                i++;

                Console.WriteLine("la suma actual de los numeros es: {0}", total);

            }
        }
    }
}
namespace Ejercicio4_6
{
    class program
    {
        static void Main(string[] args)
        {
            int i;
            double ahorro_del_mes, ahorro_en_un_ano, cantidad_depositada;
            ahorro_en_un_ano = 0;
            for (i = 1; i <= 12; i++)
            {
                Console.WriteLine("Mes " + i);
                Console.Write("Ingresa el valor de cantidad depositada: ");
                cantidad_depositada = double.Parse(Console.ReadLine());
                ahorro_en_un_ano = ahorro_en_un_ano + cantidad_depositada;
                ahorro_del_mes = ahorro_en_un_ano;
                Console.WriteLine("Valor de ahorro del mes: " + ahorro_del_mes);
                Console.WriteLine();
            }
            Console.WriteLine("Valor de ahorro en un año: " + ahorro_en_un_ano);
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}
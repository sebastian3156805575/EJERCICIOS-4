
namespace Ejercicio4_Dia
{
    public class program
    {
        static void Main()

        {
            

            int año, mes, dia;

            Console.WriteLine("Digite el año");
            año = Convert.ToInt32(Console.ReadLine());
            if (año >= 0)
            {
                Console.WriteLine("Digite el mes");
                mes = Convert.ToInt32(Console.ReadLine());
                if (mes >= 0 && mes <= 12)
                {
                    if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                    {
                        Console.WriteLine("Digite un dia ");
                        dia = Convert.ToInt32(Console.ReadLine());
                        if (dia >= 0 && dia <= 30)
                        {
                            dia++;
                            Console.WriteLine("La fecha del dia siguiente es: {0}:{1}:{2}", año, mes, dia);
                        }
                        else
                        {
                            Console.WriteLine("Digite un dia que exista, si digito 31 le hago acuerdo que no" +
                                "existe un dia 32");
                        }
                    }
                    if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                    {
                        Console.WriteLine("Digite un dia ");
                        dia = Convert.ToInt32(Console.ReadLine());
                        if (dia >= 0 && dia <= 29)
                        {
                            dia++;
                            Console.WriteLine("La fecha del dia siguiente es: {0}:{1}:{2}", año, mes, dia);
                        }
                        else
                        {
                            Console.WriteLine("Digite un dia que exista, si digito 30 le hago acuerdo que no" +
                                "existe un dia 31");
                        }
                    }
                    if (mes == 2)
                    {
                        if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
                        {
                            Console.WriteLine("Digite el dia");
                            dia = Convert.ToInt32(Console.ReadLine());
                            if (dia >= 0 || dia <= 28)
                            {
                                dia++;
                                Console.WriteLine("La fecha del dia siguiente es: {0}:{1}:{2}", año, mes, dia);
                            }
                            else
                            {
                                Console.WriteLine("Digite un dia que exista, si digito 29 le hago acuerdo que no" +
                                "existe un dia 30");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Digite el dia");
                            dia = Convert.ToInt32(Console.ReadLine());
                            if (dia >= 0 || dia <= 27)
                            {
                                dia++;
                                Console.WriteLine("La fecha del dia siguiente es: {0}:{1}:{2}", año, mes, dia);
                            }
                            else
                            {
                                Console.WriteLine("Digite un dia que exista, si digito 28 le hago acuerdo que no" +
                                "existe un dia 29");
                            }
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Digite un mes que exista");
                }
            }
            else
            {
                Console.WriteLine("Digite un año positivo");
            }


        }
    }


}
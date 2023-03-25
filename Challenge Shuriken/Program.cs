using System;
namespace Challenge_Shuriken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan Input : ");
            int Input = Convert.ToInt32(Console.ReadLine());
            int duaXInput = 2 * Input;
            int spasiAwal = 0;
            int spasiAkhir = 1;
            for (int n = 1; n <= duaXInput; n++)
            {
                for (int o = 1; o <= duaXInput; o++)
                {
                    if (o == duaXInput - n + 1 && o <= Input)
                    {
                        spasiAwal++;
                    }
                }
                for (int p = Input + 1; p <= n; p++)
                {
                    spasiAwal++;
                }
            }
            //Console.WriteLine("spasi awal= "+spasiAwal);
            for (int i = 1; i <= duaXInput; i++)
            {
                for (int j = 1; j <= duaXInput; j++)
                {
                    if (j == duaXInput - i + 1 && i <= Input)
                    {
                        for (int k = 1; k <= spasiAwal; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                        if (i > 1)
                        {
                            for (int o = 1; o <= 2 * (spasiAkhir) - 3; o++)
                            {
                                Console.Write(" ");
                            }
                            Console.Write("*");
                        }
                    }
                    else if (j == duaXInput - i + 1 && i > Input)
                    {
                        for (int m = Input + 1; m <= i; m++)
                        {
                            spasiAwal--;
                        }
                        for (int k = 1; k <= spasiAwal; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                        for (int m = Input + 1; m <= i; m++)
                        {
                            spasiAkhir++;
                        }
                        for (int k = 1; k <= 2 * spasiAkhir - 3; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                spasiAkhir++;
                Console.WriteLine();
            }
            //Console.WriteLine("spasi akhir= " + spasiAkhir);
            spasiAkhir = spasiAkhir - 1;
            for (int i = 1; i <= duaXInput - 1; i++)
            {
                for (int j = 1; j <= duaXInput; j++)
                {
                    if (j == i && i <= Input)
                    {
                        for (int m = i; m <= Input; m++)
                        {
                            spasiAwal++;
                        }
                        for (int k = 1; k <= spasiAwal + 1; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                        for (int m = i; m <= Input + 1; m++)
                        {
                            spasiAkhir--;
                        }
                        for (int k = 1; k <= 2 * spasiAkhir - 3; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                    }
                    else if (j == i && i > Input - 1)
                    {
                        for (int k = 1; k <= spasiAwal + 1; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                        spasiAkhir--;
                        if (i <= duaXInput - 2)
                        {
                            for (int k = 1; k <= 2 * spasiAkhir - 3; k++)
                            {
                                Console.Write(" ");
                            }
                            Console.Write("*");
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

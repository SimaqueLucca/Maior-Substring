using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        string entrada1 = Console.ReadLine();
        string entrada2 = Console.ReadLine();

        while (entrada1 != String.Empty)
        {
            try
            {
                List<string> subsEntrada1 = new List<string>();
                List<string> subsEntrada2 = new List<string>();
                int maior = 0;


                for (int tamanho = 1; tamanho <= entrada1.Length; tamanho++)
                {
                    for (int inicioString = 0; inicioString <= entrada1.Length - tamanho; inicioString++)
                    {
                        string text = entrada1.Substring(inicioString, tamanho);
                        subsEntrada1.Add(text);
                    }
                }

                for (int tamanho = 1; tamanho <= entrada2.Length; tamanho++)
                {
                    for (int inicioString = 0; inicioString <= entrada2.Length - tamanho; inicioString++)
                    {
                        string text = entrada2.Substring(inicioString, tamanho);
                        subsEntrada2.Add(text);
                    }
                }

                foreach (string subs in subsEntrada1)
                {
                    bool result = subsEntrada2.Exists(x => x == subs);

                    if (result)
                    {
                        if (subs.Length > maior)
                            maior = subs.Length;
                    }
                }

                System.Console.WriteLine(maior);

                entrada1 = Console.ReadLine();
                entrada2 = Console.ReadLine();
            }
            catch
            {
                entrada1 = String.Empty;
                break;
            }
        }
    }
}
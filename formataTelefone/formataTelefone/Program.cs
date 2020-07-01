using System;

namespace formataTelefone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o numero telefone?");
            string numero = Console.ReadLine();

            string pais, area, prefixo, sufixo;

            switch (numero.Length)
            {
                case 7:
                    prefixo = numero.Substring(0, 3);
                    sufixo = numero.Substring(3);
                    //Console.WriteLine("{0}-{1}", prefixo, sufixo);
                    Console.WriteLine($"{ prefixo}-{ sufixo}");
                case 8:
                    prefixo = numero.Substring(0, 4);
                    sufixo = numero.Substring(4);
                    Console.WriteLine($"({area}) { prefixo}-{ sufixo}");
                case 9:
                    prefixo = numero.Substring(0, 5);
                    sufixo = numero.Substring(5);
                    Console.WriteLine($"{pais}-{area}-{ prefixo}-{ sufixo}");
                    break;
                case 10:
                    area = numero.Substring(0, 2);
                    prefixo = numero.Substring(2, 4);
                    sufixo = numero.Substring(6);
                    break;
                case 11:
                    area = numero.Substring(0, 2);
                    prefixo = numero.Substring(2, 5);
                    sufixo = numero.Substring(7);
                    break;
                case 12:
                    pais = numero.Substring(2);
                    area = numero.Substring(2, 2);
                    prefixo = numero.Substring(4, 4);
                    sufixo = numero.Substring(8);
                    break;
                case 13:
                    pais = numero.Substring(2);
                    area = numero.Substring(2, 2);
                    prefixo = numero.Substring(4, 5);
                    sufixo = numero.Substring(9);
                    break;
                default:
                    Console.WriteLine("numero invalido");
                    break;
            }
        }
    }
}

using System;
using System.IO;

namespace Rsa_lab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var p = 0;
            var q = 0;
            
            while (true)
            {
                Console.WriteLine("Введите простое число P:");
                p = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите простое число Q:");
                q = Int32.Parse(Console.ReadLine());

                if (RSA.IsTheNumberSimple(p) && RSA.IsTheNumberSimple(q))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(
                        "Пожалуйста, убедитесь в правильности введенных чисел (целочисленные и простые числа)");
                }
            }
            
            var message = "";
            StreamReader sr = new StreamReader("input.txt");

            while (!sr.EndOfStream)
            {
                message += sr.ReadLine();
            }

            sr.Close();

            message = message.ToUpper();
            RSA rsaEncryptor = new RSA(p, q);
            Console.WriteLine($"Ваши секретный ключи: \ne_:{rsaEncryptor.GetE_()} \nn:{rsaEncryptor.GetN()}");
            
            Console.WriteLine("Исходная строка:");
            Console.WriteLine(message);
            
            var encoded = rsaEncryptor.Encode(message);
            Console.WriteLine("Зашифрованная строка:");
            encoded.ForEach(Console.Write);
            
            Console.WriteLine("\nРасшифрованная строка:");
            Console.WriteLine(rsaEncryptor.Decode(encoded));
        }
    }
}
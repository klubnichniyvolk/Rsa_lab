// https://vscode.ru/prog-lessons/algoritm-rsa.html

using System;

namespace Rsa_lab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите простое число P:");
            var p = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите простое число Q:");
            var q = Int32.Parse(Console.ReadLine());

            if (RSA.IsTheNumberSimple(p) && RSA.IsTheNumberSimple(q))
            {
                RSA rsaEncryptor = new RSA(p, q);
                Console.WriteLine($"Ваши секретный ключи: \ne_:{rsaEncryptor.GetE_()} \nn:{rsaEncryptor.GetN()}");
                
                Console.WriteLine("Введите сообщение, которое будет зашифровано:");
                var message = Console.ReadLine().ToUpper();
                var encoded = rsaEncryptor.Encode(message);
                Console.WriteLine("Зашифрованная строка:");
                encoded.ForEach(Console.Write);
                
                Console.WriteLine("\nРасшифрованная строка:");
                Console.WriteLine(rsaEncryptor.Decode(encoded));
            }
            else
            {
                Console.WriteLine("Пожалуйста, убедитесь в правильности введенных чисел (целочисленные и простые числа)");
            }
        }
    }
}
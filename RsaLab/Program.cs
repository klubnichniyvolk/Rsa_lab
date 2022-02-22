// https://vscode.ru/prog-lessons/algoritm-rsa.html

using System;
using System.Collections.Generic;
using System.Numerics;

namespace Rsa_lab
{
    public class Program
    {
        private readonly char[] _characters = new char[] 
            {'#', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
            'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 
            'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
            'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', '7',
            '8', '9', '0'};
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите простое число P:");
            Rsa p = new Rsa(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Введите простое число Q:");
            Rsa q = new Rsa(Int32.Parse(Console.ReadLine()));

            Console.WriteLine($"p:{p.Decode()}, q:{q.Decode()}");
        }
        
        private List<string> RSA_Endode(string s, long e, long n)
        {
            List<string> result = new List<string>();
            BigInteger bi;

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(_characters, s[i]);

                bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                result.Add(bi.ToString());
            }

            return result;
        }
    }

    public class Rsa
    {
        private readonly byte[] _value;

        public Rsa(int value)
        {
            _value = BitConverter.GetBytes(value);
        }
        
        ~Rsa()
        {
            Console.WriteLine($"{Decode()} has been deleted");
        }
        
        public byte[] GetValue()
        {
            return _value;
        }

        public int Decode()
        {
            return BitConverter.ToInt32(_value, 0);
        }

        public static Rsa operator +(Rsa value1, Rsa value2)
        {
            return new Rsa(value1.Decode() + value2.Decode());
        }
        
        public static Rsa operator -(Rsa value1, Rsa value2)
        {
            return new Rsa(value1.Decode() - value2.Decode());
        }

        public static Rsa operator *(Rsa value1, Rsa value2)
        {
            return new Rsa(value1.Decode() * value2.Decode());
        }

        public static Rsa operator /(Rsa value1, Rsa value2)
        {
            return new Rsa(value1.Decode() / value2.Decode());
        }

        public static Rsa operator %(Rsa value1, Rsa value2)
        {
            return new Rsa(value1.Decode() % value2.Decode());
        }

        public static bool operator ==(Rsa value1, Rsa value2)
        {
            return value1.Decode() == value2.Decode();
        }
        
        public static bool operator !=(Rsa value1, Rsa value2)
        {
            return value1.Decode() != value2.Decode();
        }
        
        public static bool operator >(Rsa value1, Rsa value2)
        {
            return value1.Decode() > value2.Decode();
        }
        
        public static bool operator <(Rsa value1, Rsa value2)
        {
            return value1.Decode() < value2.Decode();
        }
    }
}
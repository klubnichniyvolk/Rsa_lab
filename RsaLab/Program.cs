using System;

namespace Rsa_lab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var rsa = new Rsa(101);
            var rsa1 = new Rsa(5);
            Console.WriteLine((rsa+rsa1).Decode());
            Console.WriteLine((rsa%rsa1).Decode());
            Console.WriteLine(rsa==rsa1);
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
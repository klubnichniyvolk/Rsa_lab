using System;

namespace Rsa_lab
{
    public class MyByte
    {
        private readonly byte[] _value;

        public MyByte(int value)
        {
            _value = BitConverter.GetBytes(value);
        }

        ~MyByte()
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

        public static MyByte operator +(MyByte value1, MyByte value2)
        {
            return new MyByte(value1.Decode() + value2.Decode());
        }
        
        public static MyByte operator -(MyByte value1, MyByte value2)
        {
            return new MyByte(value1.Decode() - value2.Decode());
        }

        public static MyByte operator *(MyByte value1, MyByte value2)
        {
            return new MyByte(value1.Decode() * value2.Decode());
        }

        public static MyByte operator /(MyByte value1, MyByte value2)
        {
            return new MyByte(value1.Decode() / value2.Decode());
        }

        public static MyByte operator %(MyByte value1, MyByte value2)
        {
            return new MyByte(value1.Decode() % value2.Decode());
        }

        public static bool operator ==(MyByte value1, MyByte value2)
        {
            return value1.Decode() == value2.Decode();
        }
        
        public static bool operator !=(MyByte value1, MyByte value2)
        {
            return value1.Decode() != value2.Decode();
        }
        
        public static bool operator >(MyByte value1, MyByte value2)
        {
            return value1.Decode() > value2.Decode();
        }
        
        public static bool operator <(MyByte value1, MyByte value2)
        {
            return value1.Decode() < value2.Decode();
        }
    }
}
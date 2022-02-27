using System;
using System.Collections.Generic;
using System.Numerics;

namespace Rsa_lab
{
    public class RSA
    {
        private readonly long p;
        private readonly long q;
        private readonly long e_;
        private readonly long n;
        private readonly long m;
        private readonly long d; 
        
        private static readonly char[] _characters = 
        {'#', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
            'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 
            'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
            'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', '7',
            '8', '9', '0', '!', '?', '.', ',', ':', ';', ')', '('};

        public RSA(long p, long q)
        {
            this.p = p;
            this.q = q;
            this.n = p * q;
            this.m = (p - 1) * (q - 1);
            this.d = Calculate_d(m);
            this.e_ = Calculate_e(d, m);
        }

        public long GetE_()
        {
            return e_;
        }

        public long GetN()
        {
            return n;
        }
        
        private long Calculate_d(long m)
        {
            long d = m - 1;

            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0))
                {
                    d--;
                    i = 1;
                }

            return d;
        }
        
        private long Calculate_e(long d, long m)
        {
            long e = 10;

            while (true)
            {
                if ((e * d) % m == 1)
                    break;
                else
                    e++;
            }

            return e;
        }
        
        public static bool IsTheNumberSimple(long n)
        {
            if (n < 0)
            {;
                n *= -1;
            }
            
            if (n < 2)
                return false;
 
            if (n == 2)
                return true;
 
            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
 
            return true;
        }
        
        public List<string> Encode(string s)
        {
            s = s.ToUpper();
            List<string> result = new List<string>();
            BigInteger bi;

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(_characters, s[i]);

                bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e_);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                result.Add(bi.ToString());
            }

            return result;
        }
        
        public string Decode(List<string> input)
        {
            string result = "";

            BigInteger bi;

            foreach (string item in input)
            {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                int index = Convert.ToInt32(bi.ToString());

                result += _characters[index].ToString();
            }

            return result;
        }
    }
}
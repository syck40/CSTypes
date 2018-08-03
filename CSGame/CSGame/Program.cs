using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            short _sshort = 31000;
            ushort _usshort = 63666;
            int _int = 2_147_483_647;
            uint _uint = 3_147_483_647;
            long _long = 2_147_483_647;
            ulong _ulong = 12_147_483_647;

            float _float = 5.7f;
            double _db = 6.8;
            decimal _decimal = 11.32m;

            //_float = _db;
            //_db = _float;

            //var rett = _float * _db;

            int xy = 5;
            var post = xy++;
            xy = 5;
            var pre = ++xy;
            Console.WriteLine($"{post} and {pre}");

            int dz = 6;
            int k = 3;
            k += dz;
            Console.WriteLine($"{k}");
            k -= dz;
            Console.WriteLine($"{k}");
            k *= dz;
            Console.WriteLine($"{k}");
            if (k < 5 && dz > 3)
            {
                Console.WriteLine("Yes");
            }

            //int _1stName = 1;
            //int _2ndString = _1stName;
            //_2ndString = 2;
            //Console.WriteLine($"{_1stName} and {_2ndString}");

            //var arr = new[] {1, 2, 3};
            //var arr1 = arr;
            //arr1[0] = 5;
            //Console.WriteLine($"{arr[0]} and {arr1[0]}");
            //Console.WriteLine($"Type is {_1stName.GetType()}");

            Console.ReadLine();
        }
    }
}
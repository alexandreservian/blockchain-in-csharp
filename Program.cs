using System;
using Blockchain.Utils;

namespace Blockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Hashing.ToSha256("alexandre servian");
            Console.WriteLine(name);
        }
    }
}

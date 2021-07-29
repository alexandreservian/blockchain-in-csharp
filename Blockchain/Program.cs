using System;
using Blockchain.Utils;
using Blockchain.Features;

namespace Blockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            Block geneses = Block.geneses();
            string hashGeneses = Block.calculateHash(geneses.ToString());
            Console.WriteLine(hashGeneses);
        }
    }
}

using System;

namespace numFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Write the segret number");
            String valueRead = Console.ReadLine();
            Double SecretNum = double.Parse(valueRead);
            BlackBox BB = new BlackBox(SecretNum);
            BB.setAccuracy(0.1);
            BB.setMaximumNumberOfIterations(2000);
            BinarySearch BS = new BinarySearch(BB, "BinaryFinder",double.MaxValue);
            BS.printResult();
            LinearSearch LS = new LinearSearch(BB, "LinearFinder",0);
            LS.printResult();
            ExponentialSearch ES = new ExponentialSearch(BB, "ExponentialFinder", 1); 
            ES.printResult();

        }
    }
}

using System;

namespace Table
{
    static class Multiplication
    {
        static void Main(string[] args)
        {




            Console.Write("Enter starting value for rows: ");
            int startRow = int.Parse(Console.ReadLine());
            Console.Write("Enter ending value for rows: ");
            int endRow = int.Parse(Console.ReadLine());
            Console.Write("Enter starting value for columns: ");
            int startColumn = int.Parse(Console.ReadLine());
            Console.Write("Enter ending value for columns: ");
            int endColumn = int.Parse(Console.ReadLine());

            // if (startRow != 0 && endRow != 0 && startColumn != 0 && endColumn != 0)
            // {
            //     Console.WriteLine("Invalid input.");
            // }


            Console.Write("\t");
            for (int j = startColumn; j <= endColumn; j++)
            {
                
                
                
                Console.Write($"{j}\t");
                
            }

            Console.WriteLine();

            for (int j = startColumn; j <= endColumn; j++)
                for (int p = 1; p <= 10; p++)
                {
                    
                    Console.Write("=");
                }
                


            
            Console.WriteLine();
            

        
            for (int i = startRow; i <= endRow; i++)
            {
                Console.WriteLine("\t");
                Console.Write("{0, 0}", i);
                
                

                for (int j = startColumn; j <= endColumn; j++)
                {
                    
                    int table = i * j;
                    Console.Write("\t");
                    Console.Write("{0, 0}", table);
                }


            }
        }

    }
}

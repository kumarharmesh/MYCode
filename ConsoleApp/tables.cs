using System;

namespace ConsoleApp
{
    class Program
    {
       public void Table(int table)
       {
             for(int i=1;i<=10;i++)
             {
                    Console.WriteLine($"{table} X {i} = {table*i}");
             }
       }
    }
}

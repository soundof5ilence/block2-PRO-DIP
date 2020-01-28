using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hoe groot moet de lijst zijn? ");
            int arrayLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Tot welk getal mogen de willekeurige getallen gaan? ");
            int maxGetal = int.Parse(Console.ReadLine());


            

            nummers(arrayLength, maxGetal);

            

            
            }
            static void nummers(int lengte, int lijst)
            {

                Random rnd = new Random();
                int[] getalLijst = new int[lengte];

                for(int i = 0; i < lengte; i++)
                {
                    
                    getalLijst[i] = rnd.Next(0, lijst + 1);
                
                
                
                    Console.WriteLine(getalLijst[i].ToString());
                
                }
            }
     }
}


